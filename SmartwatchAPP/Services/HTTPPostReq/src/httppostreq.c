#include <tizen.h>
#include <service_app.h>
#include <stdio.h>
#include <stdlib.h>
#include <curl/curl.h>
#include <net_connection.h>
#include <Ecore.h>
#include "httppostreq.h"


//#define SERVER_URL "http://52.47.66.31/frailty/post.php" //"http://mydass.ddns.net/frailty/post.php"
//
//CURL *curl;
//CURLcode curl_err;
//connection_h connection;
//char* current_serv_id_sending_data;
//EAPI Ecore_Timer* sensor_timers[NUM_SENSORS];

bool service_app_create(void *data)
{
	dlog_print(DLOG_INFO, LOG_TAG, "%s service app create", HTTPPOSTREQ_SERVICE_ID);
	sensordata_s* sd = (sensordata_s*) data;
	sd->serviceID = BLUETOOTH_TRANSFER_SERVICE_ID;
	sd->serviceTAG = LOG_TAG;

//	curl = curl_easy_init();
//
//	connection_h connection;
//	int conn_err;
//	conn_err = connection_create(&connection);
//	if (conn_err != CONNECTION_ERROR_NONE) {
//	    /* Error handling */
//		dlog_print(DLOG_ERROR, LOG_TAG, "internet error creating connection");
//	}
//
//	dlog_print(DLOG_INFO, LOG_TAG, "internet creating connection");

	init_internet_connection();

    return true;
}

void service_app_terminate(void *data)
{
//	curl_easy_cleanup(curl);
//	connection_unset_proxy_address_changed_cb(connection);
//	connection_destroy(connection);
//	dlog_print(DLOG_INFO, LOG_TAG, "internet destroying connection");
	terminate_http_connection();
}

void service_app_control(app_control_h app_control, void *data)
{
	char *action_value = NULL;
	type_app_control_e type = handle_app_control_not_save_data(ANY_SERVICE_ID, app_control, (sensordata_s*)data);

	if(type == SPECIFIC){
		//comprobar conexion a internet
		if (app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
			&& (!strncmp(action_value, CHECK_INTERNET_ACTION, STRNCMP_LIMIT))){
			dlog_print(DLOG_INFO, LOG_TAG, "internet connection check received");
			send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, CHECK_INTERNET_ACTION, check_internet() ? TRUE_ACTION_VALUE : FALSE_ACTION_VALUE);
		}
		//Enviar todos los datos al servidor
		else if(app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
				&& (!strncmp(action_value, SEND_ALL_DATA_TO_SERVER, STRNCMP_LIMIT))){
			send_all_data_to_server();
		}
//		//enviar datos de los sensores al servidor
//		else if (send_local_data_of_any_sensor_to_server(app_control)){
//			dlog_print(DLOG_INFO, LOG_TAG, "requesting http post Request Service");
//		}
//		else{
//			dlog_print(DLOG_INFO, LOG_TAG, "http post request not sent");
//		}
	}
}
//
//bool send_local_data_of_any_sensor_to_server(app_control_h app_control){
//	bool r = false;
//	char* action_value = NULL;
//	char* serviceID = "";
//	int i;
//
//	for(i=0; i<NUM_SENSORS; i++){
//		serviceID = get_service_id_by_index(i);
//
//		r = app_control_get_extra_data(app_control, serviceID, &action_value) == APP_CONTROL_ERROR_NONE
//				&& action_value != NULL && action_value != "";
//		if(r){
//
//			current_serv_id_sending_data = serviceID;
////			sensor_timers[i] = ecore_timer_add(2*i, send_request, (char*) action_value);
//
//			ecore_timer_add(2, send_request, (char*) action_value);
//
////			send_request(serviceID, action_value);
//			break;
//		}
//	}
//
//	return r;
//}
//
//
//bool check_internet(){
//	bool internet_available = false;
//	connection_type_e type;
//
//	if(connection == NULL){
//		if (connection_create(&connection) != CONNECTION_ERROR_NONE) {
//			/* Error handling */
//			dlog_print(DLOG_ERROR, LOG_TAG, "internet error creating connection");
//		}
//	}
//
//
//	if (connection != NULL){
//		dlog_print(DLOG_INFO, LOG_TAG, "internet connection != null");
//		if(connection_get_type(connection, &type) == CONNECTION_ERROR_NONE){
//			dlog_print(DLOG_INFO, LOG_TAG, "internet connection type...");
//			dlog_print(DLOG_INFO, LOG_TAG, "internet connection type %d", type);
//
//			if( type == CONNECTION_TYPE_WIFI || type == CONNECTION_TYPE_CELLULAR || type == CONNECTION_TYPE_ETHERNET){
//				internet_available = true;
//				dlog_print(DLOG_INFO, LOG_TAG, "internet available");
//			} else {
//				dlog_print(DLOG_INFO, LOG_TAG, "internet not available");
//			}
//		}
//		else{
//			dlog_print(DLOG_ERROR, LOG_TAG, "internet error getting connection type");
//		}
//	}
//	else{
//		dlog_print(DLOG_INFO, LOG_TAG, "internet connection == null");
//	}
//
//	return internet_available;
//}



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


//Eina_Bool
//void
//send_request(char* serviceID){//(char* data){//
//	dlog_print(DLOG_INFO, LOG_TAG,"http post requesting for %s", serviceID);
//
//	char* local_data = read_file(serviceID);
//	char* sv = "service=";
//	char* dt = "&data=";
//	char* post_fields[4096];// = malloc(1 + strlen(local_data) + strlen(sv) + strlen(dt));
//	sprintf (post_fields, "service=%s&data=%s", serviceID, local_data); //usando Eina
////	strcpy(post_fields, sv);
////	strcat(post_fields, serviceID);
////	strcat(post_fields, dt);
////	strcat(post_fields, local_data);
////	sprintf (post_fields, "%s%s%s%s", sv, serviceID, dt, local_data);
//
//	dlog_print(DLOG_INFO, LOG_TAG,"http post request data: %s", post_fields);
//
//	curl_easy_setopt(curl, CURLOPT_URL, SERVER_URL);
//	curl_easy_setopt(curl, CURLOPT_POST, 1L);
//	curl_easy_setopt(curl, CURLOPT_POSTFIELDS, post_fields);
//	dlog_print(DLOG_INFO, LOG_TAG,"http post request preparing");
//	//realizar la peticion
//	curl_err = curl_easy_perform(curl);
//	dlog_print(DLOG_INFO, LOG_TAG,"http post request done");
//	dlog_print(DLOG_INFO, LOG_TAG,"http post request done. result %d", curl_err);
//
//	if (curl_err != CURLE_OK){
//		dlog_print(DLOG_ERROR, LOG_TAG,"http post request failed: %s. Error: %d", post_fields, curl_err);
//	}
//	else{
//		dlog_print(DLOG_INFO, LOG_TAG,"http post request succeed %s", serviceID);
//	}
////	//si no hay error, petición para eliminar los datos locales del serviceID
////	else{
////		//se eliminan los datos locales una vez enviados al servidor
////		send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, DELETE_LOCAL_DATA, current_serv_id_sending_data);
////	}
//
//	return ECORE_CALLBACK_CANCEL;
//}

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
