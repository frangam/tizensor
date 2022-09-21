#include <tizen.h>
#include <service_app.h>
#include <stdlib.h>
#include <Ecore.h>
#include "recorder.h"

bool service_app_create(void *data)
{
	dlog_print(DLOG_INFO, LOG_TAG, "%s service app create", RECORDER_SERVICE_ID);
	sensordata_s* sd = (sensordata_s*) data;
	sd->serviceID = RECORDER_SERVICE_ID;
	sd->serviceTAG = LOG_TAG;
    return true;
}

void service_app_terminate(void *data)
{
    // Todo: add your code here.
    return;
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

void service_app_control(app_control_h app_control, void *data)
{
	char *action_value = NULL;
	type_app_control_e type = handle_app_control_not_save_data(ANY_SERVICE_ID, app_control, (sensordata_s*)data);

	if(type == SPECIFIC){
        /* DELETE DATA & CLOSE APP*/
		if(app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && !strncmp(action_value, DELETE_DATA_AND_CLOSE, STRNCMP_LIMIT)){
			delete_all_data_and_close_app();
			send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, SEND_VALUE_TO_DEVICE);
		}
        /* DELETE DATA & DO NOT CLOSE APP*/
		else if(app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && !strncmp(action_value, DELETE_LOCAL_DATA, STRNCMP_LIMIT)){
			delete_all_data_without_close_app();
			send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, SEND_VALUE_TO_DEVICE);
		}
        /* GET LOCAL DATA stored*/
		else if (app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE){
			if(!strncmp(action_value, GET_LOCAL_DATA, STRNCMP_LIMIT)){
				dlog_print(DLOG_INFO, LOG_TAG, "obteniendo datos locales...");
				char* all_local_data[total_active_sensors];
				int i;
				for(i=0; i<total_active_sensors; i++){
					char* serviceID = get_service_id_by_index(i);
					//all_local_data[i] = (char*) malloc(4096);
					//all_local_data[i] = local_data;

					dlog_print(DLOG_INFO, LOG_TAG, "read obteniendo datos locales %s", serviceID);
					//dlog_print(DLOG_INFO, LOG_TAG, "obteniendo datos locales, DATA: %s", local_data);

					ecore_timer_add(DELAY_FOR_SEND_DATA_TO_SERVER*(i+1), send_local_data, (char*) serviceID);
//					send_local_data(serviceID);
				}
			}
		}
		//Guardar en local datos de algun sensor
		else if (local_data_of_any_sensor(app_control, SAVE)){
        	dlog_print(DLOG_INFO, LOG_TAG, "datos guardados en local");
		}
		//Eliminar datos locales de algun sensor
		else if(local_data_of_any_sensor(app_control, DELETE)){
			dlog_print(DLOG_INFO, LOG_TAG, "eliminando datos en local");
		}
//		//eliminar todos los datos de todos los sensores y cerrar app
//		else if(app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
//				&& action_value != NULL && !strncmp(action_value, DELETE_DATA_AND_CLOSE, STRNCMP_LIMIT)){
//			dlog_print(DLOG_INFO, LOG_TAG, "trying to delete all");
//			int i;
//			for(i=0; i<total_active_sensors; i++){
//				remove(get_app_filepath(get_service_id_by_index(i)));
//			}
//			dlog_print(DLOG_INFO, LOG_TAG, "delete se eliminaron todos los datos locales");
//			send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, ALL_LOCAL_DATA_DELETED);
//		}
    }
}

bool delete_all_data_and_close_app(){
	return delete_all_data_recorder(true);
}
bool delete_all_data_without_close_app(){
	return delete_all_data_recorder(false);
}
bool delete_all_data_recorder(bool close_app){
	bool res = delete_all_data();
	
	if(res && close_app ){
		dlog_print(DLOG_INFO, LOG_TAG, "all data deleted");
		send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, ALL_LOCAL_DATA_DELETED);
	}

	return res;
}

Eina_Bool send_local_data(char* serviceID){
	char* local_data = read_file(serviceID);
	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, get_local_data_message_to_handler(serviceID), local_data);
	dlog_print(DLOG_INFO, LOG_TAG, "datos locales enviados a ServiceManager: %s; data: %s", serviceID, local_data);
	return ECORE_CALLBACK_CANCEL;
}

bool local_data_of_any_sensor(app_control_h app_control, operation_e op){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	char*last_val_id = "";
	char* filename = "";
	int i;

	for(i=0; i<total_active_sensors; i++){
		serviceID = get_service_id_by_index(i);

		switch(op){
			case SAVE:
				r = app_control_get_extra_data(app_control, serviceID, &action_value) == APP_CONTROL_ERROR_NONE
								&& action_value != NULL && action_value != "";
				if(r){
					dlog_print(DLOG_INFO, LOG_TAG, "saving local data for %s", serviceID);
					write_file_appending_content(serviceID, action_value);

					//---------------------------------
					//guardar ultimo valor capturado
					last_val_id = get_last_value_id(serviceID);
					dlog_print(DLOG_INFO, LOG_TAG, "id file path for last value %s; content: %s", last_val_id, action_value);
					write_file_overriding_content(last_val_id, action_value);
					//---------------------------------
				}
				break;
			case DELETE:
				r = app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
								&& action_value != NULL && !strncmp(action_value, serviceID, STRNCMP_LIMIT);
				if(r){
					r = !remove(get_app_filepath(serviceID));
					remove(get_app_filepath(get_last_value_id(serviceID)));
					dlog_print(DLOG_INFO, LOG_TAG, "deleted %s", filename);
					send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, LOCAL_DATA_DELETED, serviceID);
				}
				break;
		}

		if(r)
			break;
	}

	return r;
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
