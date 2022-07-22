#include <tizen.h>
#include <service_app.h>
#include "bluetoothtransfer.h"

//#define BT_REMOTE_DEVICE_NAME "Frailty"//"90:E1:7B:2D:2C:44"
//#define BT_REMOTE_DEVICE_ADDRESS "66:92:47:E2:5D:08"
//int server_socket_fd = -1;
//static int total_gatt_services_created = 0;
//bt_gatt_server_h gatt_server = NULL;
//bt_gatt_client_h gatt_client = NULL;

//static bt_gatt_h service = NULL;
//static bt_gatt_h characteristic = NULL;
//static bt_gatt_h characteristic_wr = NULL;
//static bt_gatt_h descriptor = NULL;
//static bt_advertiser_h advertiser = NULL;

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
//	bt_gatt_service_destroy (service);
//	bt_gatt_characteristic_destroy (characteristic);
//	bt_gatt_server_unregister_all_services(gatt_server);
//	bt_gatt_server_deinitialize();
//	bt_gatt_server_destroy (gatt_server);
//	dlog_print(DLOG_INFO, LOG_TAG, "%s destroy gatt server", BLUETOOTH_TRANSFER_SERVICE_ID);
}

void service_app_control(app_control_h app_control, void *data)
{
	char *action_value = NULL;
	char* serviceID = NULL;
	char* gatt_properties = NULL;
	sensordata_s* sd = (sensordata_s*)data;
	type_app_control_e type = handle_app_control_not_save_data(ANY_SERVICE_ID, app_control, sd);


//	dlog_print(DLOG_INFO, LOG_TAG, "%s request %d", BLUETOOTH_TRANSFER_SERVICE_ID, type);
//	if(app_control_get_extra_data(app_control, CREATE_GATT_SERVICE, &action_value) == APP_CONTROL_ERROR_NONE
//	){
////		dlog_print(DLOG_INFO, LOG_TAG, "%s specific request", BLUETOOTH_TRANSFER_SERVICE_ID);
//		init_bluetooth((sensordata_s*) action_value);
//	//				if(bt_gatt_server_register_service(gatt_server, sd->gatt_service) == BT_ERROR_NONE){
//	//					dlog_print(DLOG_INFO, LOG_TAG, "%s gatt service successfully added to gatt server.", sd->serviceID);
//	//				}
//	//				else{
//	//					dlog_print(DLOG_ERROR, LOG_TAG, "%s error occurred when adding service to gatt server!", BLUETOOTH_TRANSFER_SERVICE_ID);
//	//				}
//	}

	switch (type) {
		case LAUNCH:
//			init_bluetooth();
//			create_gatt_server();
			create_gatt_client();
			break;
		case SPECIFIC:
			if (send_data_of_any_sensor_to_bt_device(app_control)){

			}
			else if (app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& action_value != NULL && !strncmp(action_value, SEND_VALUE_TO_DEVICE, STRNCMP_LIMIT)){
				send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_DELETE_ALL_SUCCEES_ID, "Todos los datos eliminados");
			}
//			if(must_create_gatt_server_of_any_sensor(app_control, &serviceID, &gatt_properties)){
//				bool service_created = create_gatt_service_for_sensor(serviceID, gatt_properties);
//				if(service_created){
//					total_gatt_services_created++;
//					if(total_gatt_services_created == 1){//NUM_SENSORS){
//						int res = bt_gatt_server_start();
//						if(res == BT_ERROR_NONE){
//							dlog_print(DLOG_INFO, LOG_TAG, "%s gatt server successfully started.", BLUETOOTH_TRANSFER_SERVICE_ID);
//						}
//						else{
//							dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when starting gatt server! [%s]", BLUETOOTH_TRANSFER_SERVICE_ID, bt_get_error_message(res));
//						}
//					}
//				}
//
////				if(bt_gatt_server_register_service(gatt_server, sd->gatt_service) == BT_ERROR_NONE){
////					dlog_print(DLOG_INFO, LOG_TAG, "%s gatt service successfully added to gatt server.", sd->serviceID);
////				}
////				else{
////					dlog_print(DLOG_ERROR, LOG_TAG, "%s error occurred when adding service to gatt server!", BLUETOOTH_TRANSFER_SERVICE_ID);
////				}
//			}
////			else if(app_control_get_extra_data(app_control, START_GATT_SERVER, &action_value) == APP_CONTROL_ERROR_NONE){
////				if(bt_gatt_server_start() == BT_ERROR_NONE){
////					dlog_print(DLOG_INFO, LOG_TAG, "%s Gatt server successfully started.", BLUETOOTH_TRANSFER_SERVICE_ID);
////				}
////				else
////				{
////					dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when starting gatt server!", BLUETOOTH_TRANSFER_SERVICE_ID);
////				}
////			}
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

	for(i=0; i<NUM_SENSORS; i++){
		serviceID = get_service_id_by_index(i);
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



bool create_gatt_service_for_sensor(char* serviceID, bt_gatt_property_e gatt_properties){
	bool result = false;
	bt_gatt_h gatt_service = NULL;
	bt_gatt_h gatt_characteristic = NULL;

//	dlog_print(DLOG_INFO, LOG_TAG, "trying to create a gatt service with id %s and param %d", serviceID, gatt_properties);

	char* gatt_serv_id = serviceNameToUUID(serviceID);
//	dlog_print(DLOG_INFO, LOG_TAG, "trying to create a gatt service with id %s and param %d. gatt svc id: %s", serviceID, gatt_properties, gatt_serv_id);

	int res = bt_gatt_service_create(gatt_serv_id, BT_GATT_SERVICE_TYPE_PRIMARY, &gatt_service);
//	bt_gatt_property_e gatt_property = gatt_properties == STR_BT_READ_PROPERTY ? BT_GATT_PROPERTY_READ : BT_GATT_PROPERTY_WRITE;

	if(res == BT_ERROR_NONE){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt service created successfully: svc id: %s", serviceID, gatt_serv_id);
		const char* char_val = "50";
		dlog_print(DLOG_INFO, LOG_TAG, "%s getting gatt characteristic", serviceID);
		char* gatt_char_id = characteristicNameToUUID(serviceID);
		dlog_print(DLOG_INFO, LOG_TAG, "%s get gatt characteristic id: %s", serviceID, gatt_char_id);

		res = bt_gatt_characteristic_create(gatt_char_id, BT_GATT_PERMISSION_READ | BT_GATT_PERMISSION_WRITE,
				//	                        		BT_GATT_PROPERTY_WRITE | BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE | BT_GATT_PROPERTY_NOTIFY,
				gatt_properties, // | BT_GATT_PROPERTY_NOTIFY,
									 BLUETOOTH_SERVER_CHARACTERISTIC_VALUE,
									 BLE_INITIAL_BUF_SIZE, &gatt_characteristic);
		if(res == BT_ERROR_NONE){
			dlog_print(DLOG_INFO, LOG_TAG, "%s gatt characteristic created successfully. gatt char id: %s", serviceID, gatt_char_id);

			if(gatt_properties == BT_GATT_PROPERTY_READ){
				res = bt_gatt_server_set_read_value_requested_cb (gatt_characteristic, __bt_gatt_server_read_value_requested_cb, serviceID);
				if(res == BT_ERROR_NONE){
					dlog_print(DLOG_INFO, LOG_TAG, "%s [bt_gatt_server_set_read_value_requested_cb] gatt successfully created", serviceID);
				}
				else{
					dlog_print(DLOG_ERROR, LOG_TAG, "%s [bt_gatt_server_set_read_value_requested_cb] gatt failed. [%s]", serviceID, bt_get_error_message(res));
				}
			}
			else if(gatt_properties == BT_GATT_PROPERTY_WRITE || gatt_properties == BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE){
				res = bt_gatt_server_set_write_value_requested_cb (gatt_characteristic, __bt_gatt_server_write_value_requested_cb, serviceID);
				if(res == BT_ERROR_NONE){
					dlog_print(DLOG_INFO, LOG_TAG, "%s [bt_gatt_server_set_write_value_requested_cb] gatt successfully created", serviceID);
				}
				else{
					dlog_print(DLOG_ERROR, LOG_TAG, "%s [bt_gatt_server_set_write_value_requested_cb] gatt failed. [%s]", serviceID, bt_get_error_message(res));
				}
			}

			res = bt_gatt_service_add_characteristic(gatt_service, gatt_characteristic);
			if(res == BT_ERROR_NONE){
				dlog_print(DLOG_INFO, LOG_TAG, "%s characteristic successfully added to gatt service. char ID: %s", serviceID, gatt_char_id);

				//agregar el servicio al server
				res = bt_gatt_server_register_service(gatt_server, gatt_service);
				if(res == BT_ERROR_NONE){
					dlog_print(DLOG_INFO, LOG_TAG, "%s gatt service successfully added to gatt server.", serviceID);
					result = true;
				}
				else{
					dlog_print(DLOG_ERROR, LOG_TAG, "%s error occurred when adding gatt service to gatt server! [%s]", BLUETOOTH_TRANSFER_SERVICE_ID, bt_get_error_message(res));
				}
			}
			else{
				dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when adding gatt characteristic to service! [%s]", serviceID, bt_get_error_message(res));
			}
		}
		else
		{
			dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when creating gatt characteristic! [%s]", serviceID, bt_get_error_message(res));
		}
	}
	else{
		dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when creating gatt service! [%s]", serviceID, bt_get_error_message(res));
	}

	return result;
}

void
__bt_gatt_connection_state_changed_cb(int result, bool connected,
                                      const char *remote_address, void *user_data){
    if (connected)
        dlog_print(DLOG_INFO, LOG_TAG, "gatt LE connected");
    else
        dlog_print(DLOG_INFO, LOG_TAG, "gatt LE disconnected");
}


bool create_gatt_server(){
	bool result = false;
	char* serviceID;
	if(init_bluetooth()){
		result = true;
		int i;

		//crear un gatt service por cada sensor
		for(i=0; i<NUM_SENSORS; i++){
			serviceID = get_service_id_by_index(i);

			if(serviceID){
				result = create_gatt_service_for_sensor(serviceID, BT_GATT_PROPERTY_READ);
				if(result)
					dlog_print(DLOG_INFO, LOG_TAG, "create gatt service for %s", serviceID);
				else {
					dlog_print(DLOG_ERROR, LOG_TAG, "not created gatt service for %s", serviceID);
				}
			}
		}

//		result = result && create_gatt_service_for_sensor(BT_EXT_CONTROL_START_SERVICE_ID, BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE )
//			&& create_gatt_service_for_sensor(BT_EXT_CONTROL_STOP_SERVICE_ID, BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE)
//			&& create_gatt_service_for_sensor(BT_EXT_CONTROL_RECORD_NEW_EVENT_SVC_ID, BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE)
//			&& create_gatt_service_for_sensor(BT_EXT_CONTROL_HTTP_POST_SVC_ID, BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE)
//			&& create_gatt_service_for_sensor(BT_EXT_CONTROL_DELETE_SVC_ID, BT_GATT_PROPERTY_WRITE_WITHOUT_RESPONSE);

		if(result){
			dlog_print(DLOG_INFO, LOG_TAG, "all services created gatt service");
			int res = bt_gatt_server_start();
			if(res == BT_ERROR_NONE){
				dlog_print(DLOG_INFO, LOG_TAG, "%s gatt server successfully started.", BLUETOOTH_TRANSFER_SERVICE_ID);
			}
			else{
				dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when starting gatt server! [%s]", BLUETOOTH_TRANSFER_SERVICE_ID, bt_get_error_message(res));
			}
		}
		else{
			dlog_print(DLOG_ERROR, LOG_TAG, "not all services created gatt service");
		}
	}
	return result;
}

void
__bt_gatt_server_read_value_requested_cb (const char *remote_address,
										int request_id, bt_gatt_server_h server,
										bt_gatt_h gatt_handle, int offset,
										void* user_data){
	char* serviceID = (char*) user_data;
	char*last_val_id = get_last_value_id(serviceID);
    dlog_print(DLOG_INFO, LOG_TAG, "gat read request for %s; last val id: %s", serviceID, last_val_id);

	char* message = read_file(last_val_id);
	bt_gatt_server_send_response(request_id,
	                                     BT_GATT_REQUEST_TYPE_READ, offset,
	                                     BT_ERROR_NONE, message, strlen(message));
    dlog_print(DLOG_INFO, LOG_TAG, "%s gatt read request id: %s; size: %d; message: %s", BLUETOOTH_TRANSFER_SERVICE_ID, serviceID, strlen(message), message);
}

//callback function to be invoked when a value of a characteristic or descriptor has been changed by a remote device(GATT client)'s request.
void
__bt_gatt_server_write_value_requested_cb(const char *remote_address, int request_id,
										bt_gatt_server_h server, bt_gatt_h gatt_handle,
										bool response_needed, int offset, const char *value,
										int len, void *user_data){
	if(response_needed){
		bt_gatt_server_send_response(request_id,
												 BT_GATT_REQUEST_TYPE_WRITE, offset,
												 BT_ERROR_NONE, NULL, 0);
	}

	char* data_str = substr(value, 0, len);
	dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. raw value %s", BLUETOOTH_TRANSFER_SERVICE_ID, data_str);


	if(!strncmp(data_str, BT_RECORD_ACTION, STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. response needed: %d. data received: %s; record action", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, data_str);
		record_time_mark();
	}
	else if(!strncmp(data_str, BT_START_ACTION, STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. response needed: %d. data received: %s; start action", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, data_str);
		send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
	}
	else if(!strncmp(data_str, BT_STOP_ACTION, STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. response needed: %d. data received: %s; stop action", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, data_str);
		send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, STOP_ONLY_SENSORS_ACTION);
	}
	else if(!strncmp(data_str, BT_DELETE_ACTION, STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. response needed: %d. data received: %s; delete action", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, data_str);
		send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, DELETE_LOCAL_DATA, DELETE_LOCAL_DATA);
	}
	else if(!strncmp(data_str, BT_HTTP_POST_ACTION, STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt write request. response needed: %d. data received: %s; http action", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, data_str);
		send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, SEND_ALL_DATA_TO_SERVER);
	}
	else{
		dlog_print(DLOG_WARN, LOG_TAG, "%s gatt write request. response needed: %d. Address: %s; data received: %s; len: %d", BLUETOOTH_TRANSFER_SERVICE_ID, response_needed, remote_address, data_str, len);
	}
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
