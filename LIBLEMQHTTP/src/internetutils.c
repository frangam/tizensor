#include "internetutils.h"

CURL *curl;
CURLcode curl_err;
connection_h connection;

bool init_internet_connection(){
	bool created_connection = false;
	curl = curl_easy_init();

	connection_h connection;
	int conn_err;
	conn_err = connection_create(&connection);
	created_connection = conn_err == CONNECTION_ERROR_NONE;
	if (!created_connection) {
		dlog_print(DLOG_ERROR, LOG_TAG, "internet error creating connection");
	}
	else{
		dlog_print(DLOG_INFO, LOG_TAG, "internet creating connection");
	}

	return created_connection;
}


void terminate_http_connection(){
	curl_easy_cleanup(curl);
	connection_unset_proxy_address_changed_cb(connection);
	connection_destroy(connection);
	dlog_print(DLOG_INFO, LOG_TAG, "internet destroying connection");
}


bool check_internet(){
	bool internet_available = false;
	connection_type_e type;

	if(connection == NULL){
		if (connection_create(&connection) != CONNECTION_ERROR_NONE) {
			/* Error handling */
			dlog_print(DLOG_ERROR, LOG_TAG, "internet error creating connection");
		}
	}


	if (connection != NULL){
		dlog_print(DLOG_INFO, LOG_TAG, "internet connection != null");
		if(connection_get_type(connection, &type) == CONNECTION_ERROR_NONE){
			dlog_print(DLOG_INFO, LOG_TAG, "internet connection type...");
			dlog_print(DLOG_INFO, LOG_TAG, "internet connection type %d", type);

			if( type == CONNECTION_TYPE_WIFI || type == CONNECTION_TYPE_CELLULAR || type == CONNECTION_TYPE_ETHERNET){
				internet_available = true;
				dlog_print(DLOG_INFO, LOG_TAG, "internet available");
			} else {
				dlog_print(DLOG_INFO, LOG_TAG, "internet not available");
			}
		}
		else{
			dlog_print(DLOG_ERROR, LOG_TAG, "internet error getting connection type");
		}
	}
	else{
		dlog_print(DLOG_INFO, LOG_TAG, "internet connection == null");
	}

	return internet_available;
}

//Eina_Bool
void
send_request(char* serviceID){//(char* data){//
	dlog_print(DLOG_INFO, LOG_TAG,"http post requesting for %s", serviceID);
	char* local_data = read_file(serviceID);
	char* sv = "service=";
	char* dt = "&data=";
	char* post_fields[4096];// = malloc(1 + strlen(local_data) + strlen(sv) + strlen(dt));
	sprintf (post_fields, "service=%s&data=%s", serviceID, local_data); //usando Eina
//	strcpy(post_fields, sv);
//	strcat(post_fields, serviceID);
//	strcat(post_fields, dt);
//	strcat(post_fields, local_data);
//	sprintf (post_fields, "%s%s%s%s", sv, serviceID, dt, local_data);

	dlog_print(DLOG_INFO, LOG_TAG,"http post request data: %s", post_fields);

	curl_easy_setopt(curl, CURLOPT_URL, SERVER_URL);
	curl_easy_setopt(curl, CURLOPT_POST, 1L);
	curl_easy_setopt(curl, CURLOPT_POSTFIELDS, post_fields);
	dlog_print(DLOG_INFO, LOG_TAG,"http post request preparing");
	//realizar la peticion
	curl_err = curl_easy_perform(curl);
	dlog_print(DLOG_INFO, LOG_TAG,"http post request done");
	dlog_print(DLOG_INFO, LOG_TAG,"http post request done. result %d", curl_err);

	if (curl_err != CURLE_OK){
		dlog_print(DLOG_ERROR, LOG_TAG,"http post request failed: %s. Error: %d", post_fields, curl_err);
	}
	else{
		dlog_print(DLOG_INFO, LOG_TAG,"http post request succeed %s", serviceID);
	}
//	//si no hay error, petición para eliminar los datos locales del serviceID
//	else{
//		//se eliminan los datos locales una vez enviados al servidor
//		send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, DELETE_LOCAL_DATA, current_serv_id_sending_data);
//	}

//	return ECORE_CALLBACK_CANCEL;
}

void send_all_data_to_server(){
	if(check_internet()){
		int i;
		for(i=0; i<NUM_SENSORS; i++){
			char* serviceID = get_service_id_by_index(i);
//				char* local_data = read_file(serviceID);
			dlog_print(DLOG_INFO, LOG_TAG, "http post read obteniendo datos locales %s", serviceID);
			//dlog_print(DLOG_INFO, LOG_TAG, "obteniendo datos locales, DATA: %s", local_data);

			send_request(serviceID);
//			ecore_timer_add(2, send_request, (char*)serviceID);
//				ecore_timer_add(DELAY_FOR_SEND_DATA_TO_SERVER*(i+1), send_local_data, (char*) serviceID);
		}
	}
}
