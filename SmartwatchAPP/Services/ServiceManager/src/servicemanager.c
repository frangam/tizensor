#include <tizen.h>
#include <service_app.h>
#include "servicemanager.h"



//Service alive and sleep time
#define INITIAL_DELAY_TO_START_SERVICES 	1
#define CHECK_INTERNET_TIMER 				10
#define ACCELEROMETER_ALIVE_DELAY 			20
#define ACCELEROMETER_SLEEP_DELAY 			5
#define GYROSCOPE_ALIVE_DELAY 				10
#define GYROSCOPE_SLEEP_DELAY 				5
#define HEART_RATE_ALIVE_DELAY 				10
#define HEART_RATE_SLEEP_DELAY 				5
#define LOCATION_ALIVE_DELAY 				10
#define LOCATION_SLEEP_DELAY 				5
#define LINEAR_ACCELERATION_ALIVE_DELAY 	10
#define LINEAR_ACCELERATION_SLEEP_DELAY		5
#define GRAVITY_ALIVE_DELAY 				10
#define GRAVITY_SLEEP_DELAY 				5
#define GRAVITY_ALIVE_DELAY 				10
#define GRAVITY_SLEEP_DELAY 				5
#define PRESSURE_ALIVE_DELAY 				10
#define PRESSURE_SLEEP_DELAY 				5
#define LIGHT_ALIVE_DELAY 					10
#define LIGHT_SLEEP_DELAY 					5
#define PEDOMETER_ALIVE_DELAY 				10
#define PEDOMETER_SLEEP_DELAY 				5

//Service actions (messages)
#define SERVICE_ACTION 						"service_action"
#define RECORD_SERVICE_REQUEST 				"record_service"

#define MAX_SERVICE_ID_LEN 					50

#define ALIVE_TIMER_INDEX					0
#define SLEEP_TIMER_INDEX					1
#define TOTAL_TIMER_STATES					2 //alive, sleep



//..... sensor_timers matrix .....
//   _____________________
// 0 | alive acc timer   |  0 (STATE) + 0 (service index) * 2 (nº estados: alive + sleep) = 0
// 1 | sleep acc timer   |  1 + (0 * 2) = 1
//   ---------------------
// 2 | alive gyros timer |  0 + (1 * 2) = 2
// 3 | sleep gyros timer |  1 + (1 * 2) = 3
//   ---------------------
// 4 | alive hr timer    |  0 + (2 * 2) = 4
// 5 | sleep hr timer    |  1 + (2 * 2) = 5
//    .......               .....
EAPI Ecore_Timer* sensor_timers[NUM_SENSORS*TOTAL_TIMER_STATES]; //1º alive y 2º sleep
bool sensors_stopped[NUM_SENSORS];
EAPI Ecore_Timer* check_internet_time;



int get_alive_delay(char* serviceID){
	int r = 0;

	if(serviceID == ACCELEROMETER_SERVICE_ID) 				r = ACCELEROMETER_ALIVE_DELAY;
	else if(serviceID == GYROSCOPE_SERVICE_ID) 				r = GYROSCOPE_ALIVE_DELAY;
	else if(serviceID == HEART_RATE_SERVICE_ID) 				r = HEART_RATE_ALIVE_DELAY;
	else if(serviceID == LOCATION_SERVICE_ID) 				r = LOCATION_ALIVE_DELAY;
	else if(serviceID == PEDOMETER_SERVICE_ID) 				r = PEDOMETER_ALIVE_DELAY;
	else if(serviceID == LINEAR_ACCELERATION_SERVICE_ID) 	r = LINEAR_ACCELERATION_ALIVE_DELAY;
	else if(serviceID == GRAVITY_SERVICE_ID) 				r = GRAVITY_ALIVE_DELAY;
	else if(serviceID == PRESSURE_SERVICE_ID) 				r = PRESSURE_ALIVE_DELAY;
	else if(serviceID == LIGHT_SERVICE_ID) 					r = LIGHT_ALIVE_DELAY;

	//todo agregar todos
	return r;
}

int get_sleep_delay(char* serviceID){
	int r = 0;

	if(serviceID == ACCELEROMETER_SERVICE_ID) 				r = ACCELEROMETER_SLEEP_DELAY;
	else if(serviceID == GYROSCOPE_SERVICE_ID) 				r = GYROSCOPE_SLEEP_DELAY;
	else if(serviceID == HEART_RATE_SERVICE_ID) 				r = HEART_RATE_SLEEP_DELAY;
	else if(serviceID == LOCATION_SERVICE_ID) 				r = LOCATION_SLEEP_DELAY;
	else if(serviceID == PEDOMETER_SERVICE_ID) 				r = PEDOMETER_SLEEP_DELAY;
	else if(serviceID == LINEAR_ACCELERATION_SERVICE_ID) 	r = LINEAR_ACCELERATION_SLEEP_DELAY;
	else if(serviceID == GRAVITY_SERVICE_ID) 				r = GRAVITY_SLEEP_DELAY;
	else if(serviceID == PRESSURE_SERVICE_ID) 				r = PRESSURE_SLEEP_DELAY;
	else if(serviceID == LIGHT_SERVICE_ID) 					r = LIGHT_SLEEP_DELAY;

	//todo agregar todos
	return r;
}



Eina_Bool check_internet_timer(void* data){
	send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, CHECK_INTERNET_ACTION);
	return ECORE_CALLBACK_RENEW;
}

Eina_Bool sensor_alive_timer(void *data){
	char* serviceID = (char*) data;
	int serviceIndex = get_service_index_by_id(serviceID);

	dlog_print(DLOG_INFO, LOG_TAG, "%s alive timeout", serviceID);
	launch_service(serviceID);

	//sensor_timers[ALIVE_TIMER_INDEX + (serviceIndex * TOTAL_TIMER_STATES)] = ecore_timer_add(get_alive_delay(serviceID), sensor_sleep_timer, serviceID);

	//sensor_timers[SLEEP_TIMER_INDEX + (serviceIndex * TOTAL_TIMER_STATES)] = NULL;

	return ECORE_CALLBACK_CANCEL;
}


Eina_Bool sensor_sleep_timer(void *data){
	char* serviceID = (char*) data;
	dlog_print(DLOG_INFO, LOG_TAG, "%s sleep timeout", serviceID);
	stop_service(serviceID);
	int serviceIndex = get_service_index_by_id(serviceID);
	sensor_timers[SLEEP_TIMER_INDEX + (serviceIndex * TOTAL_TIMER_STATES)] = ecore_timer_add(get_sleep_delay(serviceID), sensor_alive_timer, serviceID);

	//sensor_timers[ALIVE_TIMER_INDEX + (serviceIndex * TOTAL_TIMER_STATES)] = NULL;


	return ECORE_CALLBACK_CANCEL; //ECORE_CALLBACK_RENEW;
}



bool service_app_create(void *data)
{
	dlog_print(DLOG_INFO, LOG_TAG, "Frailty Service Manager created");
	sensordata_s* sd = (sensordata_s*) data;
	sd->serviceID = MYSERVICELAUNCHER_APP_ID;
	sd->serviceTAG = LOG_TAG;

    return true;
}

void service_app_terminate(void *data)
{
//	ecore_shutdown();
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

void launch_service(char* service_id)
{
	dlog_print(DLOG_INFO, LOG_TAG, "launch service %s", service_id);
	send_message_to_service_with_data(service_id, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
}



void stop_service(char* service_id)
{
	dlog_print(DLOG_INFO, LOG_TAG, "stop service %s", service_id);
	send_message_to_service_with_data(service_id, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
}



void launch_all_sensors_and_timers(){
	dlog_print(DLOG_INFO, LOG_TAG, "launch all sensors and timers");
	int i;
	for(i=0; i<NUM_SENSORS; i++){
		//sensor_timers[INITIAL_TIMER_INDEX + (i * TOTAL_TIMER_STATES)] = launch_sensor_and_timer(get_service_id_by_index(i));
	    char* serviceID = get_service_id_by_index(i);
		launch_sensor_and_timer(serviceID);
//	    sensor_alive_timer(serviceID);
//	    launch_service(serviceID);
//	    sensors_stopped[i] = false;
	}
}

EAPI Ecore_Timer * launch_sensor_and_timer(char* serviceID){
	return ecore_timer_add(INITIAL_DELAY_TO_START_SERVICES, sensor_alive_timer, serviceID);
}


void stop_all_sensors_and_timers(){
	dlog_print(DLOG_INFO, LOG_TAG, "stop all sensors and timers");
//	//stop_only_sensors_services();
//	int i;
//	for(i=0; i<sizeof sensor_timers / sizeof *sensor_timers; i++){
//		//ecore_timer_freeze(sensor_timers[i]);
//		//if(sensor_timers[i] != NULL){
//			ecore_timer_del(sensor_timers[i]);
//			sensor_timers[i] = NULL;
//			sensors_stopped[i] = true;
//			dlog_print(DLOG_INFO, LOG_TAG, "deleting dead timer %d", i);
//		//}
//	}
	stop_only_sensors_services();
}


void stop_all_alive_services(){
	dlog_print(DLOG_INFO, LOG_TAG, "stop all alive services");
	stop_service(RECORDER_SERVICE_ID);
	stop_service(HTTPPOSTREQ_SERVICE_ID);
	stop_service(BLUETOOTH_TRANSFER_SERVICE_ID);
	stop_only_sensors_services();
}


void stop_only_sensors_services(){
	dlog_print(DLOG_INFO, LOG_TAG, "stop only sensors");
	int i;
	for(i=0; i<NUM_SENSORS; i++){
//		dlog_print(DLOG_INFO, LOG_TAG, "stop only sensors: %d", sizeof sensors / sizeof *sensors);


//		sensors[i]->stop_requested = true;
//		dlog_print(DLOG_INFO, LOG_TAG, "stop only sensors: %s", sensors[i].serviceID);
//		stop_sensor(&sensors[i]);
		stop_service(get_service_id_by_index(i));
	}
}



//Lógica de envío de mensajes entres los servicios y este controlador general
//y la APP gráfica y éste controlador
void service_app_control(app_control_h app_control, void *data)
{
	char *action_value = NULL;
	sensordata_s* sd = (sensordata_s*)data;


	dlog_print(DLOG_INFO, LOG_TAG, "service_app_control %s", SERVICE_MANAGER_ID);


	type_app_control_e type = handle_app_control_not_save_data(ANY_SERVICE_ID, app_control, sd);



	switch (type) {
		case LAUNCH:
			//iniciamos el recorder de datos y el http post request
//			launch_service(HTTPPOSTREQ_SERVICE_ID);
//			launch_service(RECORDER_SERVICE_ID);
//			launch_service(BLUETOOTH_TRANSFER_SERVICE_ID);
			launch_all_sensors_and_timers();

//			//iniciamos timer para comprobar conexion a internet para enviar datos de las capturas realizadas
//			check_internet_time = ecore_timer_add(CHECK_INTERNET_TIMER, check_internet_timer, NULL);
			break;
		case STOP:
//			stop_all_alive_services();
			//stop_only_sensors_services();
			stop_all_sensors_and_timers();
			break;
		case SPECIFIC:
			if(app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, STOP_ONLY_SENSORS_ACTION, STRNCMP_LIMIT)){
				stop_all_sensors_and_timers();
			}
//			// Guardar en local los datos algun sensor
//			else if(save_local_data_any_sensor_data_captured(app_control)){
//				dlog_print(DLOG_INFO, LOG_TAG, "requesting to %s to save local data", RECORDER_SERVICE_ID);
//			}
			//eliminar los datos de algun sensor concreto
			else if(delete_local_data_of_any_sensor(app_control)){
				dlog_print(DLOG_INFO, LOG_TAG, "delete eliminar datos locales de algun sensor realizado");
			}
			//confirmacion de la eliminacion de algun sensor concreto
			else if(delete_local_data_of_any_sensor_confirmed(app_control)){
				dlog_print(DLOG_INFO, LOG_TAG, "re launch service");
			}

//			//confirmación de detención de un servicio
//			else if (app_control_get_extra_data(app_control, STOP_CONFIRMED, &action_value) == APP_CONTROL_ERROR_NONE){
//				//dlog_print(DLOG_INFO, LOG_TAG, "delete all data and close app");
//				//send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_CONFIRMED);
//				int serviceIndex = get_service_index_by_id(action_value);
//
//				if(serviceIndex >= 0 && serviceIndex < NUM_SENSORS)
//					sensors_stopped[serviceIndex] = true;
//			}

			//eliminar todos los datos
			else if (app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, DELETE_DATA_AND_CLOSE, STRNCMP_LIMIT)){
				dlog_print(DLOG_INFO, LOG_TAG, "delete all data and close app");
//				stop_all_sensors_and_timers();
				send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, DELETE_LOCAL_DATA, DELETE_DATA_AND_CLOSE);
			}
			//detener este servicio despues de eliminar los datos
			else if(app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, ALL_LOCAL_DATA_DELETED, STRNCMP_LIMIT)){
				stop_service(SERVICE_MANAGER_ID);
			}
			// Si se quiere comprobar la conexion a internet para enviar datos
			else if(app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, CHECK_INTERNET_ACTION, STRNCMP_LIMIT)){
				send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, CHECK_INTERNET_ACTION);
			}
			//Si hay conexion a internet se solicitan los datos locales para enviar al servidor
			else if (app_control_get_extra_data(app_control, CHECK_INTERNET_ACTION, &action_value) == APP_CONTROL_ERROR_NONE){
				//si hay internet
				if (!strncmp(action_value, TRUE_ACTION_VALUE, STRNCMP_LIMIT)){
					dlog_print(DLOG_INFO, LOG_TAG, "internet connection available - request local data");
					stop_all_sensors_and_timers(); //detenemos sensores y timers de éstos

					//solicitamos los datos locales grabados al recorder
					send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, GET_LOCAL_DATA);
				}
				else{
					dlog_print(DLOG_INFO, LOG_TAG, "internet connection not available");
				}
			}
			// enviar datos locales al servidor de alguno de los sensores
			else if (send_local_data_of_any_sensor_to_server(app_control)){
				dlog_print(DLOG_INFO, LOG_TAG, "obteniendo datos locales. Datos recibidos");
			}
			// Si se quieren detener todos los sensores
			else if (app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, STOP_ONLY_SENSORS_ACTION, STRNCMP_LIMIT)){
				stop_all_sensors_and_timers();
			}
//			//Contabilizar total de Gatt services creados
//			else if(app_control_get_extra_data(app_control, GATT_SERVICE_CREATED, &action_value) == APP_CONTROL_ERROR_NONE
////					&& !strncmp(action_value, STOP_ONLY_SENSORS_ACTION, STRNCMP_LIMIT)){
//			){
//				total_gatt_services_created++;
//				send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, CREATE_GATT_SERVICE, sd);
//
//				//Start GATT server when all of the sensors have been created as GATT services
//				if(total_gatt_services_created == NUM_SENSORS){
//					send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, CREATE_GATT_SERVICE, sd);
//				}
//			}
			// Detener sensores y el propio servicio manager
			else if(app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE
					&& !strncmp(action_value, STOP_ALL_ACTION, STRNCMP_LIMIT)){
				stop_all_sensors_and_timers();
				stop_service(SERVICE_MANAGER_ID);
			}

			break;
	}
}

bool send_local_data_of_any_sensor_to_server(app_control_h app_control){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	char* messageKey = "";
	int i;

	for(i=0; i<NUM_SENSORS; i++){
		serviceID = get_service_id_by_index(i);
		messageKey = get_local_data_message_to_handler(serviceID);

		r = app_control_get_extra_data(app_control, messageKey, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && action_value != "";
		if(r){
			dlog_print(DLOG_INFO, LOG_TAG, "send local data to server for %s. Action: %s", serviceID, action_value);
			send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, serviceID, action_value);
			break;
		}
	}

	return r;
}

bool delete_local_data_of_any_sensor(app_control_h app_control){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	int i;

	for(i=0; i<NUM_SENSORS; i++){
		serviceID = get_service_id_by_index(i);

		r = app_control_get_extra_data(app_control, DELETE_LOCAL_DATA, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && !strncmp(action_value, serviceID, STRNCMP_LIMIT);
		if(r){
			dlog_print(DLOG_INFO, LOG_TAG, "delete local data for %s", serviceID);
			send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, DELETE_LOCAL_DATA, serviceID);
			break;
		}
	}

	return r;
}



bool save_local_data_any_sensor_data_captured(app_control_h app_control){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	int i;

//	dlog_print(DLOG_INFO, LOG_TAG, "save_local_data_any_sensor_data_captured");

	for(i=0; i<NUM_SENSORS; i++){
		serviceID = get_service_id_by_index(i);
//		dlog_print(DLOG_INFO, LOG_TAG, "save_local_data_any_sensor_data_captured %s", serviceID);
		r = app_control_get_extra_data(app_control, serviceID, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && action_value != "";
		if(r){
			dlog_print(DLOG_INFO, LOG_TAG, "requesting to save local data for %s", serviceID);
			send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, serviceID, action_value);
			break;
		}
//		else{
//			dlog_print(DLOG_WARN, LOG_TAG, "not requesting to save local data for %s", serviceID);
//		}
	}

	return r;
}

bool delete_local_data_of_any_sensor_confirmed(app_control_h app_control){
	bool r = false;
	char* action_value = NULL;
	char* serviceID = "";
	int i;

	for(i=0; i<NUM_SENSORS; i++){
		serviceID = get_service_id_by_index(i);

		r = app_control_get_extra_data(app_control, LOCAL_DATA_DELETED, &action_value) == APP_CONTROL_ERROR_NONE
				&& action_value != NULL && !strncmp(action_value, serviceID, STRNCMP_LIMIT);
		if(r){
			dlog_print(DLOG_INFO, LOG_TAG, "delete local data confirmed for %s", serviceID);
			launch_sensor_and_timer(serviceID);
			break;
		}
	}

	return r;
}


int main(int argc, char* argv[])
{
	char ad[50] = {0,};
	//appdata_s ad = {0,}; // we declare ad as a structure appdata_s defined earlier
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
