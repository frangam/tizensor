#include <tizen.h>
#include <service_app.h>
#include "bluetoothtransfer.h"

bool service_app_create(void *data)
{
	dlog_print(DLOG_INFO, LOG_TAG, "%s service app create", BLUETOOTH_TRANSFER_SERVICE_ID);

	sensordata_s* sd = (sensordata_s*) data;
	sd->serviceID = BLUETOOTH_TRANSFER_SERVICE_ID;
	sd->serviceTAG = LOG_TAG;

    return true;
}

void service_app_terminate(void *data)
{

}

void service_app_control(app_control_h app_control, void *data)
{
	char *action_value = NULL;
	char* serviceID = NULL;
	char* gatt_properties = NULL;
	sensordata_s* sd = (sensordata_s*)data;
	type_app_control_e type = handle_app_control_not_save_data(ANY_SERVICE_ID, app_control, sd);

	switch (type) {
		case LAUNCH:
            /* Scan BLE peripherals (clients) */
			create_gatt_client();
			break;
		case SPECIFIC:
            /* Send data of any sensor to BLE GATT peripheral */
			if (send_data_of_any_sensor_to_bt_device(app_control)){

			}
			else if (app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& action_value != NULL && !strncmp(action_value, SEND_VALUE_TO_DEVICE, STRNCMP_LIMIT)){
				send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_DELETE_ALL_SUCCEES_ID, "Todos los datos eliminados");
			}
			break;
	}
}

bool send_data_of_any_sensor_to_bt_device(app_control_h app_control){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	char*last_val_id = "";
	char* filename = "";
	int i;

	for(i=0; i<total_active_sensors; i++){
        serviceID = sensors[i].serviceID; // get_service_id_by_index(i);
		r = app_control_get_extra_data(app_control, serviceID, &action_value) == APP_CONTROL_ERROR_NONE
						&& action_value != NULL && action_value != "";
		if(r){
			dlog_print(DLOG_INFO, LOG_TAG, "%s gatt sending data to bt device: %s", serviceID, action_value);
			send_value_to_device(serviceID, serviceID, action_value);
		}

		if(r)
			break;
	}

	return r;
}


static void
service_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	return;
}

static void
service_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
service_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
service_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char* argv[])
{
	char ad[50] = {0,};
	service_app_lifecycle_callback_s event_callback;
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = service_app_create;
	event_callback.terminate = service_app_terminate;
	event_callback.app_control = service_app_control;

	service_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, service_app_low_battery, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, service_app_low_memory, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, service_app_lang_changed, &ad);
	service_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, service_app_region_changed, &ad);

	return service_app_main(argc, argv, &event_callback, ad);
}
