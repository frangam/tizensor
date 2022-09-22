/**
 * This file contains the exported symbol.
 */
#include "utils.h"

char* initial_time_capture_str = "";
int current_time_mark_counter = 0;
bool start_to_record_data = false;
bool stop_requested_from_remote_device = false;
//sensordata_s sensors[NUM_SENSORS];




bool is_received_stop_request_from_remote_device(){
	return stop_requested_from_remote_device;
}
void upate_stop_requested_from_remote_device(bool received){
	stop_requested_from_remote_device = received;
}


void handle_app_control_for_sensor_services(char* rightCallerID, app_control_h app_control, char* serviceID){
    type_app_control_e type = handle_app_control_not_save_data(rightCallerID, app_control, sd);
    switch (type) {
        case LAUNCH:
            dlog_print(DLOG_INFO, LOG_TAG, "lauched %s", rightCallerID);
            break;
        case STOP:
            dlog_print(DLOG_INFO, LOG_TAG, "stoped %s", rightCallerID);
            break;
        case SPECIFIC:
            break;
    }
}

type_app_control_e handle_app_control_not_save_data(char* rightCallerID, app_control_h app_control, char* serviceID){
	return handle_app_control(rightCallerID, app_control, serviceID, false);
}

type_app_control_e handle_app_control_and_save_data(char* rightCallerID, app_control_h app_control, char* serviceID){
	return handle_app_control(rightCallerID, app_control, serviceID, true);
}

type_app_control_e handle_app_control(char* rightCallerID, app_control_h app_control, char* serviceID, bool save){
	type_app_control_e type_app = ERROR;
	char *caller_id = NULL, *action_value = NULL;
	int r = app_control_get_caller(app_control, &caller_id);

	//Check the sender is the correct
	//if ANY_SERVICE_ID no worries
	if (rightCallerID == ANY_SERVICE_ID || (r == APP_CONTROL_ERROR_NONE
			&& (caller_id != NULL) && (!strncmp(caller_id, rightCallerID, STRNCMP_LIMIT)))){

		if ((app_control_get_extra_data(app_control, SERVICE_ACTION, &action_value) == APP_CONTROL_ERROR_NONE)){
			//STOP
			if (!strncmp(action_value, STOP_ACTION, STRNCMP_LIMIT)){
				type_app = STOP;

				free(caller_id);
				free(action_value);

				//petición de guardar los datos al controlador de servicios
//				if(save && sd->dataCaptured != NULL && sd->dataCaptured != ""){
//					dlog_print(DLOG_INFO, sd->serviceTAG, "save local data request sent, after stopping %s service", sd->serviceID);
//					send_message_to_service_with_data(SERVICE_MANAGER_ID,
//							sd->serviceTAG, sd->serviceID, sd->dataCaptured);
//				}
				dlog_print(DLOG_INFO, LOG_TAG, "stop service request received %s ", serviceID);
//				sd->stop_requested = true;
//				stop_sensor(sd);
//				send_message_to_service_with_data(SERVICE_MANAGER_ID, sd->serviceTAG, STOP_CONFIRMED, sd->serviceID);
//				service_app_exit();
//				dlog_print(DLOG_INFO, sd->serviceTAG, " %s stop request received", sd->serviceID);
			}
//			//Confirmación de detención de un servicio
//			else if(!strncmp(action_value,STOP_CONFIRMED, STRNCMP_LIMIT)){
//				dlog_print(DLOG_INFO, sd->serviceTAG, "stopped %s service", sd->serviceID);
//				service_app_exit();
//			}
			//LAUNCH
			else if(!strncmp(action_value, LAUNCH_ACTION, STRNCMP_LIMIT)){
//				sd->stop_requested = false;
				type_app = LAUNCH;
				dlog_print(DLOG_INFO, LOG_TAG, "launch for %", serviceID);


				//guardar datos en local
//				if(save){
//					dlog_print(DLOG_INFO, LOG_TAG, "creando timer para save datos local data for %s", sd->serviceID);
//					ecore_timer_add(10, save_local_data_cb, sd); //cada 5 segundos guarda en local los datos capturados
//				}
			}
			//SPECIFIC
			else{
				type_app = SPECIFIC;
				dlog_print(DLOG_INFO, LOG_TAG, "specific action for %", serviceID);
				free(caller_id);
				free(action_value);
				caller_id = NULL;
				action_value = NULL;
			}
		}
		//----------------
		//SPECIFIC action
		//----------------
		else {
			type_app = SPECIFIC;

			dlog_print(DLOG_INFO, LOG_TAG, "specific action for %", serviceID);

			free(caller_id);
			free(action_value);
			caller_id = NULL;
			action_value = NULL;
		}
	}
	dlog_print(DLOG_INFO, LOG_TAG, "%s request type app control: %s", serviceID, get_type_app_control_message(type_app));

	return type_app;
}

void send_message_to_service_with_data(char* toServiceID, char* serviceTAG, char* message, char* data)
{
    app_control_h app_control = NULL;
    if (app_control_create(&app_control)== APP_CONTROL_ERROR_NONE){
    		int res1 = app_control_set_app_id(app_control, toServiceID);
    		int res2 = app_control_add_extra_data(app_control, message, data);
    		int res3 = app_control_send_launch_request(app_control, NULL, NULL);

    		if (res1 != APP_CONTROL_ERROR_NONE){
			dlog_print(DLOG_ERROR, serviceTAG, "request sent failed to service %s; app_control_set_app_id error: %d; message: %s; data: %s", toServiceID, res1, message, data);
		}

    		if(res2 != APP_CONTROL_ERROR_NONE){
			dlog_print(DLOG_ERROR, serviceTAG, "request sent failed to service %s; app_control_add_extra_data error: %d; message: %s; data: %s", toServiceID, res2, message, data);
		}

		if(res3 == APP_CONTROL_ERROR_NONE){
			dlog_print(DLOG_INFO, serviceTAG, "launch request success for service %s", toServiceID);
		}
		else if(res3 == APP_CONTROL_ERROR_LAUNCH_REJECTED){
			dlog_print(DLOG_ERROR, serviceTAG, "launch request sent failed to service %s; launch rejected; error: %d; message: %s; data: %s", toServiceID, res3, message, data);
		}
		else if(res3 == APP_CONTROL_ERROR_APP_NOT_FOUND){
			dlog_print(DLOG_ERROR, serviceTAG, "launch request sent failed to service %s; the app is not found; error: %d; message: %s; data: %s", toServiceID, res3, message, data);
		}
		else if(res3 == APP_CONTROL_ERROR_INVALID_DATA_TYPE){
			dlog_print(DLOG_ERROR, serviceTAG, "launch request sent failed to service %s; invalid data type; error: %d; message: %s; data: %s", toServiceID, res3, message, data);
		}
			else if(res3 == APP_CONTROL_ERROR_LAUNCH_FAILED){
			dlog_print(DLOG_ERROR, serviceTAG, "launch request sent failed to service %s; internal launch; error: %d; message: %s; data: %s", toServiceID, res3, message, data);
		}
			else if(res3 != APP_CONTROL_ERROR_NONE){
			dlog_print(DLOG_ERROR, serviceTAG, "launch request sent failed to service %s; error: %d; message: %s; data: %s", toServiceID, res3, message, data);
		}
    }
    else{
        dlog_print(DLOG_ERROR, serviceTAG, "app control creation failed!");
    }
}


void get_current_datetime(char** date_str, char** time_str, char** timestamp_str){
	struct timeval curTime;
	gettimeofday(&curTime, NULL);
	struct tm* myLocalTime = localtime(&curTime.tv_sec);
	int milli = curTime.tv_usec/1000;
	unsigned long long totalseconds = curTime.tv_sec*1000LL + curTime.tv_usec/1000000LL;

	//date
	//char date_s [30];
	//incluimos dia/mes/anyo
	strftime(date_str, 30, "%d/%m/%Y", myLocalTime); //localtime_r (thread safe mode)

	//time
	//char time_s [30];
	//incluirmos horas:minutos:segundos
	strftime(time_str, 30, "%H:%M:%S", myLocalTime); //localtime_r (thread safe mode)

	//incluimos los milisegundos despues del punto >> horas:minutos:segundos.milisegundos
	sprintf(time_str, "%s.%d", time_str, milli);

	sprintf(timestamp_str, "%llu", totalseconds);

	//dlog_print(DLOG_INFO, LOG_TAG, "accelerometer utils fecha %s,%s", date_str, time_str);
	dlog_print(DLOG_INFO, LOG_TAG, "get time %s,%s,%s", date_str, time_str, timestamp_str);
}


char* get_device_id(){
	char *value = "";
	int ret;
	ret =
//			system_info_get_platform_string("tizen.org/system/model_name", &value);
			system_info_get_platform_string("tizen.org/system/tizenid", &value);

	if (ret == SYSTEM_INFO_ERROR_NONE)
	{
	  // Error handling
	}
	return value;
}

sensor_type_e get_sensor_type_by_service_id(char* serviceID){
	sensor_type_e type = SENSOR_ACCELEROMETER;

	if (serviceID == ACCELEROMETER_SERVICE_ID) 				type = SENSOR_ACCELEROMETER;
	else if (serviceID == GYROSCOPE_SERVICE_ID) 				type = SENSOR_GYROSCOPE;
	else if (serviceID == HEART_RATE_SERVICE_ID) 			type = SENSOR_HRM;
	else if (serviceID == PEDOMETER_SERVICE_ID) 				type = SENSOR_HUMAN_PEDOMETER;
	else if(serviceID == LINEAR_ACCELERATION_SERVICE_ID) 	type = SENSOR_LINEAR_ACCELERATION;
	else if(serviceID == GRAVITY_SERVICE_ID) 				type = SENSOR_GRAVITY;
	else if(serviceID == PRESSURE_SERVICE_ID) 				type = SENSOR_PRESSURE;

	//No soportados...
//			SENSOR_PROXIMITY;
//			SENSOR_GEOMAGNETIC_ROTATION_VECTOR;
//			SENSOR_ROTATION_VECTOR;
//			SENSOR_ULTRAVIOLET;
//			SENSOR_TEMPERATURE;
//			SENSOR_HUMIDITY;
//			SENSOR_HRM_LED_RED;
//			SENSOR_HRM_LED_IR
//			SENSOR_SIGNIFICANT_MOTION;

	else if(serviceID == LIGHT_SERVICE_ID) 					type = SENSOR_LIGHT;
	else if(serviceID == STRESS_SERVICE_ID) 					type = SENSOR_HUMAN_STRESS_MONITOR;
	else if(serviceID == SLEEP_SERVICE_ID) 					type = SENSOR_HUMAN_SLEEP_MONITOR;
	else if (serviceID == HR_GREEN_LIGHT_SERVICE_ID) 		type = SENSOR_HRM_LED_GREEN;

	return type;
}

char* get_service_id_by_index(int index){
	char* r = ACCELEROMETER_SERVICE_ID;

	if (index == 0)			r = PEDOMETER_SERVICE_ID;
	else if(index == 1) 		r = HEART_RATE_SERVICE_ID;
	else if(index == 2) 		r = ACCELEROMETER_SERVICE_ID;
	else if(index == 3) 		r = GYROSCOPE_SERVICE_ID;
	else if(index == 4) 		r = LINEAR_ACCELERATION_SERVICE_ID;
	else if(index == 5) 		r = GRAVITY_SERVICE_ID;
	else if(index == 6) 		r = LIGHT_SERVICE_ID;
	else if(index == 7)		r = PRESSURE_SERVICE_ID;
	else if(index == 8) 		r = HR_GREEN_LIGHT_SERVICE_ID;
	else if(index == 9) 		r = LOCATION_SERVICE_ID;
	else if(index == 10) 	r = STRESS_SERVICE_ID;
	else if(index == 11) 	r = SLEEP_SERVICE_ID;
	//todo agregar mas

	return r;
}

int get_service_index_by_id(char* serviceID){
	int r = 0; //ACCELEROMETER

	if(serviceID == PEDOMETER_SERVICE_ID )						r = 0;
	else if (serviceID == HEART_RATE_SERVICE_ID ) 				r = 1;
	else if(serviceID == ACCELEROMETER_SERVICE_ID) 				r = 2;
	else if(serviceID == GYROSCOPE_SERVICE_ID) 					r = 3;
	else if(serviceID == LINEAR_ACCELERATION_SERVICE_ID) 		r = 4;
	else if(serviceID == GRAVITY_SERVICE_ID) 					r = 5;
	else if(serviceID == LIGHT_SERVICE_ID) 						r = 6;
	else if(serviceID == PRESSURE_SERVICE_ID) 					r = 7;
	else if(serviceID == HR_GREEN_LIGHT_SERVICE_ID) 				r = 8;
	else if(serviceID == LOCATION_SERVICE_ID) 					r = 9;
	else if(serviceID == STRESS_SERVICE_ID) 						r = 10;
	else if(serviceID == SLEEP_SERVICE_ID) 						r = 11;
	//todo agregar mas

	return r;
}


char* get_local_data_message_to_handler(char* serviceID){
	char* r = SEND_LOCAL_DATA_ACCELEROMETER;

	if(serviceID == GYROSCOPE_SERVICE_ID) 					r = SEND_LOCAL_DATA_GYROSCOPE;
	else if(serviceID == HEART_RATE_SERVICE_ID) 			r = SEND_LOCAL_DATA_HEART_RATE;
	else if(serviceID == LOCATION_SERVICE_ID) 				r = SEND_LOCAL_DATA_LOCATION;
	else if(serviceID == PEDOMETER_SERVICE_ID) 				r = SEND_LOCAL_DATA_PEDOMETER;
	else if(serviceID == LINEAR_ACCELERATION_SERVICE_ID) 	r = SEND_LOCAL_DATA_LIN_ACC;
	else if(serviceID == GRAVITY_SERVICE_ID) 				r = SEND_LOCAL_DATA_GRAVITY;
	else if(serviceID == PRESSURE_SERVICE_ID) 				r = SEND_LOCAL_DATA_PRESSURE;
	else if(serviceID == LIGHT_SERVICE_ID)					r = SEND_LOCAL_DATA_LIGHT;
	else if(serviceID == HR_GREEN_LIGHT_SERVICE_ID)			r = SEND_LOCAL_DATA_HRGL;
	else if(serviceID == STRESS_SERVICE_ID)					r = SEND_LOCAL_DATA_STRESS;
	else if(serviceID == SLEEP_SERVICE_ID)					r = SEND_LOCAL_DATA_SLEEP;

	//todo agregar mas
	return r;
}

const char* get_type_app_control_message(type_app_control_e type){
	const char* res = "";

	switch(type){
		case ERROR: 		res="ERROR"; break;
		case LAUNCH: 	res="LAUNCH"; break;
		case STOP: 		res="STOP"; break;
		case SPECIFIC: 	res="SPECIFIC"; break;
	}

	return res;
}


char* get_last_value_id(char* serviceID){
	char* final = malloc(1 + strlen(serviceID) + strlen(LAST_VALUE_ID));
	strcpy(final, serviceID);
	strcat(final, LAST_VALUE_ID);
	dlog_print(DLOG_INFO, LOG_TAG, "%s last value id: %s", serviceID, final);

	return final;
}



char* convert_bytes_to_binary_string(uint8_t *bytes, size_t count) {
  if ( count < 1 ) {
    return NULL;
  }

  const char *table[] = {
    "0000", "0001", "0010", "0011",
    "0100", "0101", "0110", "0111",
    "1000", "1001", "1010", "1011",
    "1100", "1101", "1110", "1111"
  };

  size_t buffer_size = 8 * count + 1;
  char *buffer = malloc( buffer_size );
  if ( buffer == NULL ) {
    return NULL;
  }

  char *output = buffer;
  for ( int i = 0 ; i < count ; i++ ) {
    memcpy( output, table[ bytes[i] >> 4 ], 4 );
    output += 4;
    memcpy( output, table[ bytes[i] & 0x0F ], 4 );
    output += 4;
  }

  *output = 0;

  return buffer;
}

uint8_t* convert_string_to_bytes(char* str, size_t len){
	uint8_t *result = malloc(len);
	memcpy(result, str, len);
	return result;
}

char* substr(char* str, int start, int len){
    if (len == 0)
        len = strlen(str)-start;

    char *new_str = (char*)malloc(sizeof(char) * (len+1));
    new_str[len] = '\0';
    strncpy(new_str, str + start, len);

    return new_str;
}



