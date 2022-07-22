#include "sensorutils.h"


sensordata_s sensors[NUM_SENSORS];
location_manager_h location_manager = NULL;
sensordata_s* sensors2;
int total_active_sensors = 0;

void launch_sensors(my_sensor_types_e types){
	//iniciar todos los sensores
	int i=0;
	bool created = false;
	char* serviceID = NULL;

	total_active_sensors = 0;
	char** serviceIDs = get_service_ids_contained_in_enum(types, &total_active_sensors);
	int total_services = sizeof serviceIDs / sizeof *serviceIDs;

//	sensors2 = malloc(total_services * sizeof(sensordata_s));

	dlog_print(DLOG_INFO, LOG_TAG, "launch request services total (sizeof): %d", total_services);
	dlog_print(DLOG_INFO, LOG_TAG, "launch request services total (returned): %d", total_active_sensors);
	for(i=0; i<total_active_sensors; i++){
		char* svID = serviceIDs[i];
		dlog_print(DLOG_INFO, LOG_TAG, "launch request service for %s", svID);

		if(!strcmp(svID, LOCATION_SERVICE_ID)){
			created = init_location(&sensors[i]);
		}
		else{
			created = create_sensor(svID, LOG_TAG, &sensors[i]);
		}
	}
//	while(*serviceIDs) {
//		dlog_print(DLOG_INFO, LOG_TAG, "launch request service for %s", *serviceIDs);
//		if(!strcmp(*serviceIDs, LOCATION_SERVICE_ID)){
//			created = init_location(&sensors[i]);
//		}
//		else{
//			created = create_sensor(*serviceIDs, LOG_TAG, &sensors[i]);
//		}
//	    serviceIDs++;
//	    i++;
//
//	}


//
//	for(i=0; i<NUM_SENSORS; i++){
//		serviceID = get_service_id_by_index(i);
//
//		if(!strcmp(serviceID, LOCATION_SERVICE_ID)){
//			created = init_location(&sensors[i]);
//		}
//		else{
//			created = create_sensor(serviceID, LOG_TAG, &sensors[i]);
//		}
//		dlog_print(DLOG_INFO, LOG_TAG, "created sensor [%s, %d]", sensors[i].serviceID, sensors[i].type);
//	}
}



void stop_sensors(){
	int i;
	for(i=0; i<total_active_sensors; i++){
		char* serviceID = sensors[i].serviceID;
		if(!strcmp(serviceID, LOCATION_SERVICE_ID)){//get_service_id_by_index(i), LOCATION_SERVICE_ID)){
			terminate_location(&sensors[i]);
		}
		else{
			if (sensor_listener_unset_event_cb(sensors[i].listener) == SENSOR_ERROR_NONE
				&& sensor_listener_stop(sensors[i].listener) == SENSOR_ERROR_NONE
				&& sensor_destroy_listener(sensors[i].listener) == SENSOR_ERROR_NONE
				&& device_power_release_lock ( POWER_LOCK_CPU ) == DEVICE_ERROR_NONE
				){

				dlog_print(DLOG_INFO, LOG_TAG, "%s stop sensor", sensors[i].serviceID);
			}
			else{
				dlog_print(DLOG_INFO,LOG_TAG, "%s error occurred when destroying listener or the listener was never created", sensors[i].serviceID);
			}
		}
	}
}

void stop_service(char* service_id){
	dlog_print(DLOG_INFO, LOG_TAG, "stop service %s", service_id);
	send_message_to_service_with_data(service_id, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
}


bool create_sensor(char* serviceID, char* serviceTAG, sensordata_s* sd){
	bool success = false;
	sensor_type_e type = get_sensor_type_by_service_id(serviceID);

	dlog_print(DLOG_INFO, serviceTAG, "trying to start service: %s", serviceID);

	//Sensor no soportado
	bool sensor_supported = false;
	if (sensor_is_supported(type, &sensor_supported) != SENSOR_ERROR_NONE || !sensor_supported)
	{
		dlog_print(DLOG_ERROR, serviceTAG, "%s sensor not supported", serviceID);
		service_app_exit();
	}
	else{ //Sensor soportado
		dlog_print(DLOG_INFO, serviceTAG, "%s sensor supported", serviceID);
		sd->serviceID = serviceID; //guardamos el id del servicio
		sd->serviceTAG = serviceTAG; //guardamos el service tag
		sd->type = type; //guardamos el tipo de sensor
		sd->dataCaptured = ""; //inicializamos
		sd->stop_requested = false;
		sd->header_file_recorded = false;

		//iniciar el listener del sensor
		int r = sensor_get_default_sensor(type, &sd->sensor);
		if(r != SENSOR_ERROR_NONE){
			dlog_print(DLOG_ERROR, serviceTAG, "error getting sensor: %s", get_sensor_error_message(r));
		}
		else{
			int interval = get_sensor_min_interval(sd->serviceID);
			int min_int_sup = 0;
			sensor_get_min_interval(sd->sensor, &min_int_sup);

			r = device_power_request_lock(POWER_LOCK_CPU, 0);
			if (r != DEVICE_ERROR_NONE){
				dlog_print(DLOG_INFO, serviceTAG, "%s error on init, unable to get power lock! %d", serviceID, r);
			}

			dlog_print(DLOG_INFO, serviceTAG, "%s min interval supported: %d", serviceID, min_int_sup);
			dlog_print(DLOG_INFO, serviceTAG, "%s min interval: %d", serviceID, interval);

			if (sensor_create_listener(sd->sensor, &sd->listener) == SENSOR_ERROR_NONE
				&& sensor_listener_set_event_cb(sd->listener, interval, sensor_capture_data, sd) == SENSOR_ERROR_NONE
//				&& sensor_listener_set_interval(sd->listener, interval) == SENSOR_ERROR_NONE
				&& sensor_listener_set_attribute_int(sd->listener, SENSOR_ATTRIBUTE_PAUSE_POLICY, SENSOR_PAUSE_NONE) == SENSOR_ERROR_NONE
				&& sensor_listener_set_option(sd->listener, SENSOR_OPTION_ALWAYS_ON) == SENSOR_ERROR_NONE
				)
			{
				success = sensor_listener_start(sd->listener) == SENSOR_ERROR_NONE;

				if (success)
				{
					int sensor_id = get_service_index_by_id(serviceID);
//					sensors[sensor_id] = (sensordata_s *) malloc(sizeof(sensordata_s));
//					sensors[sensor_id].serviceID = sd->serviceID;
//					sensors[sensor_id].serviceTAG = sd->serviceTAG;
//					sensors[sensor_id].type = sd->type;
//					sensors[sensor_id].dataCaptured = sd->dataCaptured;
//					sensors[sensor_id].stop_requested = sd->stop_requested;
//					sensors[sensor_id].sensor = sd->sensor;
//					sensors[sensor_id].listener = sd->listener;

					dlog_print(DLOG_INFO, serviceTAG, "%s service listener created and started", serviceID);

//					//force first read
					if(!strcmp(sd->serviceID, PEDOMETER_SERVICE_ID)){
//						ecore_timer_add(0.04, force_read_sensor_data, (char*) sd->serviceID);
						force_read_sensor_data(sd->serviceID);
					}

//					dlog_print(DLOG_INFO, serviceTAG, "%s service listener created %s", serviceID, sensors[sensor_id].serviceID);

//					sd->gatt_properties = BT_GATT_PROPERTY_READ;
//					send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, sd->serviceTAG, sd->serviceID, STR_BT_READ_PROPERTY);
				}
				else{
					dlog_print(DLOG_ERROR, serviceTAG, "%s listener not started", serviceID);
					service_app_exit();
				}
			}
		}
	}

	return success;
}



void terminate_sensor(sensordata_s* sd){
//	bt_gatt_service_destroy (sd->gatt_service);
//	bt_gatt_characteristic_destroy (sd->gatt_characteristic);

	dlog_print(DLOG_INFO, sd->serviceTAG, "%s terminate sensor callback", sd->serviceID);
//	service_app_exit();
}


void sensor_capture_data(sensor_h sensor, sensor_event_s *event, sensordata_s* sd){
	sensor_type_e type = SENSOR_ALL;
	int r = sensor_get_type(sensor, &type);
	dlog_print(DLOG_INFO, sd->serviceTAG, "%s; [ sensor_capture_data ] r=%d", sd->serviceID, r);

//	dlog_print(DLOG_INFO, sd->serviceTAG, "%s; stop request received: %s", sd->serviceID, sd->stop_requested ? "true" : "false");
//	dlog_print(DLOG_INFO, sd->serviceTAG, "%s stop request received ? (%s) from remote device", sd->serviceID, is_received_stop_request_from_remote_device() ? "true" : "false");


	if(!sd->stop_requested && (r == SENSOR_ERROR_NONE && type == sd->type))
	{
		register_sensor_data_captured(sd, get_sensor_data(sd, event));
	}
	else{
		if(sd->stop_requested){
			dlog_print(DLOG_WARN, sd->serviceTAG, "stop requested for service %s", sd->serviceID);
		}
		if(sensor_get_type(sensor, &type) != SENSOR_ERROR_NONE){
			dlog_print(DLOG_WARN, sd->serviceTAG, "stop requested for service %s; sensor error type", sd->serviceID);
		}
		if(type != sd->type){
			dlog_print(DLOG_WARN, sd->serviceTAG, "stop requested for service %s; sensor != type: %d", sd->serviceID, type);
		}
	}
}


void register_sensor_data_captured(sensordata_s* sd, char* content){
	char* final_content;
	if(!strncmp(content, "", STRNCMP_LIMIT)){
		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for right values", sd->serviceID,content);
	}
	else{
		dlog_print(DLOG_INFO, sd->serviceTAG, "data captured from %s: %s", sd->serviceID,content);

		//guardamos los datos una vez que ya se ha indicado
		if(start_to_record_data){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s header recorded %s", sd->serviceID, sd->header_file_recorded ? "true" : "false");
//			if(!sd->header_file_recorded){
//				char* header_content = get_header_of_sensor_file(sd->serviceID);
//				sd->header_file_recorded = true;
//				final_content = malloc(1+strlen(header_content)+strlen(content));
//				strcpy(final_content, header_content);
//				strcat(final_content, content);
//			}
//			else{
				final_content = malloc(1+strlen(content));
				strcpy(final_content, content);
//			}

			write_file_appending_content(sd->serviceID, final_content);
			sd->dataCaptured = "";

			//---------------------------------
			//guardar ultimo valor capturado
			char*last_val_id = get_last_value_id(sd->serviceID);
			dlog_print(DLOG_INFO, sd->serviceTAG, "id file path for last val %s; content: %s", last_val_id, content);

			write_file_overriding_content(last_val_id, content);
			//---------------------------------
		}

		//enviarlo por bluetooth
		send_value_to_device(sd->serviceID, sd->serviceID, content);
	}
}

Eina_Bool force_read_sensor_data(char* serviceID){
	sensor_event_s event;
	sensordata_s sd = sensors[get_service_index_by_id(serviceID)];
	if(sensor_listener_read_data(sd.listener, &event) == SENSOR_ERROR_NONE){
		char* data_captured = get_sensor_data(&sd, &event);
		dlog_print(DLOG_INFO, LOG_TAG, "%s first read", serviceID);
		dlog_print(DLOG_INFO, LOG_TAG, "%s first read data: %s", sd.serviceID, data_captured);
		send_value_to_device(sd.serviceID, sd.serviceID, data_captured);
	}
	else {
		dlog_print(DLOG_ERROR, LOG_TAG, "%s first read failed", serviceID);
	}
	return ECORE_CALLBACK_RENEW;
}

char* get_sensor_data(sensordata_s* sd, sensor_event_s *event){
	char* content [DATA_LINE_SIZE];

	dlog_print(DLOG_INFO, sd->serviceTAG, "%s - capturing data", sd->serviceID);

	if(sd->serviceID == LOCATION_SERVICE_ID){
		sprintf(content, "%s", get_cur_location(sd));
	}
	else{
		//obtenemos la fecha y hora (incluyendo milisegundos)
		char* date_str[30], time_str[30], timestamp_str[30];
		struct timespec spec;
		clock_gettime(CLOCK_REALTIME, &spec);
		unsigned long long current_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
		clock_gettime(CLOCK_MONOTONIC, &spec);
		unsigned long long monotonic_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
		unsigned long long event_time_ms = current_time_ms - monotonic_time_ms + event->timestamp / 1000LL;
		get_current_datetime(&date_str, &time_str, &timestamp_str);

		//cambiar los float con punto (.) para decimales
		setlocale(LC_NUMERIC, "en_US.UTF-8");

		//dlog_print(DLOG_INFO, sd->serviceTAG, "capturing data from %s", sd->serviceID);
		if(sd->serviceID == ACCELEROMETER_SERVICE_ID || sd->serviceID == GYROSCOPE_SERVICE_ID
				|| sd->serviceID == LINEAR_ACCELERATION_SERVICE_ID || sd->serviceID == GRAVITY_SERVICE_ID
				){
	//			sprintf ( content, "%s,%s,%s,%f,%f,%f\n",get_device_id(), date_str, time_str,
	//				event->values[0], event->values[1], event->values[2]);
			sprintf ( content, "%llu,%s,%s,%f,%f,%f,%d\n",event_time_ms,date_str, time_str,
							event->values[0], event->values[1], event->values[2], current_time_mark_counter);
					}
	//		}
		else if(sd->serviceID == HEART_RATE_SERVICE_ID ||  sd->serviceID == HR_GREEN_LIGHT_SERVICE_ID){
			if((int) event->values[0] > 0){
				sprintf ( content, "%llu,%s,%s,%d,%d\n",event_time_ms, date_str, time_str, (int) event->values[0], current_time_mark_counter);
			}
			else{
				sprintf ( content, "");
			}
		}
		else if(sd->serviceID == PRESSURE_SERVICE_ID || sd->serviceID == LIGHT_SERVICE_ID || sd->serviceID == STRESS_SERVICE_ID){
			sprintf ( content, "%llu,%s,%s,%f,%d\n",event_time_ms,date_str, time_str, event->values[0], current_time_mark_counter);
		}
		else if(sd->serviceID == PEDOMETER_SERVICE_ID){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: trying to get right values", sd->serviceID);
			dlog_print(DLOG_INFO, sd->serviceTAG, "data captured from %s: %d,%d,%d", sd->serviceID,
					(int) event->values[0], (int) event->values[1], (int) event->values[2]);

			// 0: number of steps; 1: number of walking steps; 2: number of running steps;
			// 3: moving distance (meters); 4: calories burned (kcal); 5: last speed (Km/h);
			// 6: last stepping frequency (steps/second);
			// 7: last pedestrian state >> SENSOR_PEDOMETER_STATE_UNKNOWN, SENSOR_PEDOMETER_STATE_STOP, SENSOR_PEDOMETER_STATE_WALK, or SENSOR_PEDOMETER_STATE_RUN
			sprintf ( content, "%llu,%s,%s,%d,%d,%d,%d,%d,%d,%d,%d\n",event_time_ms, date_str, time_str, (int) event->values[0],
					(int) event->values[1], (int) event->values[2], (int) event->values[3], (int) event->values[4],
					(int) event->values[5], (int) event->values[6], current_time_mark_counter);
		}
	}

	return content;
}

char* get_header_of_sensor_file(char* serviceID){
	char* content[DATA_LINE_SIZE];
	float sampling_freq = get_frequency_in_hz_from_service_id(serviceID);

	dlog_print(DLOG_INFO, LOG_TAG, "%s header file", serviceID);
	dlog_print(DLOG_INFO, LOG_TAG, "%s header file sampling frequency %f", serviceID, sampling_freq);
	dlog_print(DLOG_INFO, LOG_TAG, "%s header file initial time capture %f", serviceID, initial_time_capture_str);

	if(serviceID == ACCELEROMETER_SERVICE_ID || serviceID == GYROSCOPE_SERVICE_ID
					|| serviceID == LINEAR_ACCELERATION_SERVICE_ID || serviceID == GRAVITY_SERVICE_ID){
		sprintf ( content, "%s,%s,%s,%s,%s,%s,%s\n%f,%f,%f,%f,%f,%f,%f\n",initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq);
	}
	else if(serviceID == HEART_RATE_SERVICE_ID ||  serviceID == HR_GREEN_LIGHT_SERVICE_ID){
		sprintf ( content, "%s,%s,%s,%s,%s\n%f,%f,%f,%f,%f\n",initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, initial_time_capture_str, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq);
	}
	else if(serviceID == PRESSURE_SERVICE_ID || serviceID == LIGHT_SERVICE_ID || serviceID == STRESS_SERVICE_ID){
		sprintf ( content, "%s,%s,%s,%s,%s\n%f,%f,%f,%f,%f\n", initial_time_capture_str, initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq);
	}
	else if(serviceID == PEDOMETER_SERVICE_ID || serviceID == LOCATION_SERVICE_ID){
		sprintf ( content, "%s,%s,%s,%s,%s,%s,%s,%s,%s,%s,%s\n%f,%f,%f,%f,%f,%f,%f,%f,%f,%f,%f\n",initial_time_capture_str, initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq);
	}
//	else if(serviceID == LOCATION_SERVICE_ID){
//		sprintf ( content, "%s,%s,%s,%s,%s,%s,%s,%s,%s,%s,%s\n%f,%f,%f,%f,%f,%f,%f,%f,%f,%f,%f\n",initial_time_capture_str, initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,initial_time_capture_str,sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq, sampling_freq);
//	}

	dlog_print(DLOG_INFO, LOG_TAG, "%s header file content: %s", serviceID, content);

//	send_value_to_device(serviceID, serviceID, content);
//	write_file_appending_content(serviceID, content);
	return content;
}


char* get_sensor_error_message(int error){
	char* res = "error desconocido";

	if(error == SENSOR_ERROR_NONE)	res = "success";
	else if(error == SENSOR_ERROR_INVALID_PARAMETER)	res = "invalid parameter";
	else if(error == SENSOR_ERROR_NOT_AVAILABLE)	res = "not available";
	else if(error == SENSOR_ERROR_NOT_SUPPORTED)	res = "sensor not supported";
	else if(error == SENSOR_ERROR_PERMISSION_DENIED)	res = "permission denied";
	else if(error == SENSOR_ERROR_IO_ERROR)	res = "input output error";
	else if(error == SENSOR_ERROR_NOT_NEED_CALIBRATION)	res = "not need calibration";
	else if(error == SENSOR_ERROR_NO_DATA)	res = "no data";
	else if(error == SENSOR_ERROR_OPERATION_FAILED)	res = "operation failed";
	else if(error == SENSOR_ERROR_OUT_OF_MEMORY)	res = "out of memory";

	return res;
}



//-----------------------------------
// Location
//-----------------------------------
bool init_location(sensordata_s* sd){
	if(location_manager_create(LOCATIONS_METHOD_HYBRID, &location_manager) == LOCATIONS_ERROR_NONE){
		sd->serviceID = LOCATION_SERVICE_ID; //guardamos el id del servicio
		sd->serviceTAG = LOG_TAG; //guardamos el service tag
		sd->dataCaptured = ""; //inicializamos
		sd->stop_requested = false;

		int min_interval = get_sensor_min_interval(LOCATION_SERVICE_ID);
		int ret = location_manager_set_service_state_changed_cb(location_manager, state_changed_cb, sd);
		location_manager_set_position_updated_cb(location_manager, position_updated, min_interval, sd);
		gps_status_set_satellite_updated_cb(location_manager, velocity_updated, min_interval*5, sd);

//		register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
		if(ret == LOCATIONS_ERROR_NONE){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s creado servicio de GPS", sd->serviceID);
			ret = location_manager_start(location_manager);
			if(ret == LOCATIONS_ERROR_NONE){
				dlog_print(DLOG_INFO, sd->serviceTAG, "%s iniciado servicio de GPS", sd->serviceID);
				register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
			}
			else{
				dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error intentando iniciar el servicio de GPS", sd->serviceID);
			}
		}
		else{
			dlog_print(DLOG_ERROR, LOG_TAG, "%s: error creando el servicio de GPS", LOCATION_SERVICE_ID);
		}

	}
	else{
		dlog_print(DLOG_ERROR, LOG_TAG, "%s: error creando el servicio de GPS", LOCATION_SERVICE_ID);
		service_app_exit();
	}
}

void state_changed_cb(location_service_state_e state, void *user_data)
{
	sensordata_s* sd = (sensordata_s*)user_data;
//    double altitude;
//    double latitude;
//    double longitude;
//    double climb;
//    double direction;
//    double speed;
//    double horizontal;
//    double vertical;
//    location_accuracy_level_e level;
//    time_t timestamp;

    if (state == LOCATIONS_SERVICE_ENABLED) {
    		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: servicio de localización activo", sd->serviceID);
    		register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
    }
    else{
    		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: servicio de localización deshabilitado", sd->serviceID);
    }
}

void position_updated(double latitude, double longitude, double altitude,
                      time_t timestamp, void *user_data) {
	sensordata_s* sd = (sensordata_s*)user_data;
	time_t curr_timestamp;

	// Get current time to compare to the last position timestamp
	time(&curr_timestamp);

	// Send updated position only if init data has been sent and position update
	// was registered less than MAX_TIME_DIFF seconds ago
	if (curr_timestamp - timestamp < MAX_TIME_DIFF){
	 // Send position update through message port
	  register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
	}

	dlog_print(DLOG_INFO, sd->serviceTAG, "%s: position updated", sd->serviceID);
//	register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
}
void velocity_updated(double speed, double direction, double climb,
                      time_t timestamp, void *user_data) {
	sensordata_s* sd = (sensordata_s*)user_data;
	time_t curr_timestamp;

	// Get current time to compare to the last position timestamp
	time(&curr_timestamp);

	// Send updated position only if init data has been sent and position update
	// was registered less than MAX_TIME_DIFF seconds ago
	if (curr_timestamp - timestamp < MAX_TIME_DIFF){
	 // Send position update through message port
	  register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
	}

	dlog_print(DLOG_INFO, sd->serviceTAG, "%s: velocity updated", sd->serviceID);
//	register_sensor_data_captured(sd, get_sensor_data(sd, NULL));
}

char* get_cur_location(sensordata_s* sd){
	char* content[DATA_LINE_SIZE];
	double altitude;
	double latitude;
	double longitude;
	double climb;
	double direction;
	double speed;
	double horizontal;
	double vertical;
	location_accuracy_level_e level;
	time_t timestamp;
//	int ret = location_manager_get_last_location(sd->manager, &altitude, &latitude, &longitude,
//	                                         &climb, &direction, &speed, &level, &horizontal,
//	                                         &vertical, &timestamp);
	int ret = location_manager_get_location(location_manager, &altitude, &latitude, &longitude,
		                                         &climb, &direction, &speed, &level, &horizontal,
		                                         &vertical, &timestamp);
	sd->timestamp = timestamp;
//	if(ret != LOCATIONS_ERROR_NONE){
//		dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error location_manager_get_location: %s", sd->serviceID, get_location_error_message(ret));
//	}
//	else{
//		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: success location_manager_get_location", sd->serviceID);
//	}

//	if(ret != LOCATIONS_ERROR_NONE){
		ret = location_manager_get_last_location(location_manager, &altitude, &latitude, &longitude,
			                                         &climb, &direction, &speed, &level, &horizontal,
													 &vertical, &timestamp);
		sd->timestamp = timestamp;
		if(ret != LOCATIONS_ERROR_NONE){
			dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error location_manager_get_last_location: %s", sd->serviceID, get_location_error_message(ret));
		}
		else{
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: success location_manager_get_last_location", sd->serviceID);
		}
//	}

	if(ret == LOCATIONS_ERROR_NONE){
		//obtenemos la fecha y hora (incluyendo milisegundos)
		char* date_str[30], time_str[30], timstap_str[30];
		get_current_datetime(&date_str, &time_str, &timstap_str);
		struct timespec spec;
		clock_gettime(CLOCK_REALTIME, &spec);
		unsigned long long current_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
		clock_gettime(CLOCK_MONOTONIC, &spec);
		unsigned long long monotonic_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
		unsigned long long event_time_ms = current_time_ms - monotonic_time_ms + timestamp / 1000LL;
		sprintf ( content, "%llu,%s,%s,%f,%f,%f,%f,%g,%f,%f,%f\n",event_time_ms, date_str, time_str,
						altitude, latitude, longitude, climb, direction, speed, horizontal, vertical);
//		send_message_to_service_with_data(SERVICE_MANAGER_ID,
//												LOG_TAG, LOCATION_SERVICE_ID, content);


		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: %s", sd->serviceID, content);

		if (!altitude || !latitude || !longitude){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for rigth values (!altitude || !latitude || !longitude)", sd->serviceID,content);
		}
		else if (!speed){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for rigth values (!speed)", sd->serviceID,content);
		}
		else if(!direction || !horizontal || !vertical){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for rigth values (!direction || !horizontal || !vertical)", sd->serviceID,content);
		}
		else if(!climb){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for rigth values (!climb)", sd->serviceID,content);
		}
		else if(!content || !strncmp(content, "", STRNCMP_LIMIT)){
			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: waiting for rigth values (!content || !strncmp(content, "", STRNCMP_LIMIT))", sd->serviceID,content);
		}
//		else{
//			send_message_to_service_with_data(SERVICE_MANAGER_ID,
//										LOG_TAG, LOCATION_SERVICE_ID, content);
//			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: %s", sd->serviceID, content);
//		}
	}
	else{
		dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error intentando obtener la ultima localizacion", sd->serviceID);
	}

	return content;
}


void terminate_location(){
	location_manager_stop(location_manager);
	location_manager_destroy(location_manager);
	location_manager_unset_position_updated_cb(location_manager);
	gps_status_unset_satellite_updated_cb(location_manager);

	location_manager = NULL;
}

char* get_location_error_message(int error){
	char* res = "unknown error";

	if(error == LOCATIONS_ERROR_GPS_SETTING_OFF){
		res = "LOCATIONS_ERROR_GPS_SETTING_OFF";
	}
	else if(error == LOCATIONS_ERROR_ACCESSIBILITY_NOT_ALLOWED){
		res = "LOCATIONS_ERROR_ACCESSIBILITY_NOT_ALLOWED";
	}
	else if(error == LOCATIONS_ERROR_INCORRECT_METHOD){
		res = "LOCATIONS_ERROR_INCORRECT_METHOD";
	}
	else if(error == LOCATIONS_ERROR_INVALID_PARAMETER){
		res = "LOCATIONS_ERROR_INVALID_PARAMETER";
	}
	else if(error == LOCATIONS_ERROR_NETWORK_FAILED){
		res = "LOCATIONS_ERROR_NETWORK_FAILED";
	}
	else if(error == LOCATIONS_ERROR_NOT_SUPPORTED){
		res = "LOCATIONS_ERROR_NOT_SUPPORTED";
	}
	else if(error == LOCATIONS_ERROR_OUT_OF_MEMORY){
		res = "LOCATIONS_ERROR_OUT_OF_MEMORY";
	}
	else if(error == LOCATIONS_ERROR_SECURITY_RESTRICTED){
		res = "LOCATIONS_ERROR_SECURITY_RESTRICTED";
	}
	else if(error == LOCATIONS_ERROR_SERVICE_NOT_AVAILABLE){
		res = "LOCATIONS_ERROR_SERVICE_NOT_AVAILABLE";
	}

	return res;
}

char** get_service_ids_contained_in_enum(my_sensor_types_e types, int* counter){
	char* serviceID = NULL;
	(*counter) = 0;
	if((types & PEDOMETER) == PEDOMETER)							(*counter)++;
	if((types & ACCELEROMETER) == ACCELEROMETER) 				(*counter)++;
	if((types & GYROSCOPE) == GYROSCOPE) 						(*counter)++;
	if((types & HEARTRATE) == HEARTRATE) 						(*counter)++;
	if((types & GRAVITY) == GRAVITY) 							(*counter)++;
	if((types & LINEAR_ACCELERATION) == LINEAR_ACCELERATION) 	(*counter)++;
	if((types & LIGHT) == LIGHT) 								(*counter)++;
	if((types & PRESSURE) == PRESSURE) 							(*counter)++;
	if((types & HR_GREEN_LIGHT) == HR_GREEN_LIGHT) 				(*counter)++;
	if((types & LOCATION) == LOCATION) 							(*counter)++;
	dlog_print(DLOG_INFO, LOG_TAG, "launch request total services %d", (*counter));

	char** serviceIDs = malloc((*counter) * sizeof(char*));
	int index = 0;
	if((types & PEDOMETER) == PEDOMETER){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request pedometer");
		serviceIDs[index] = malloc(1+strlen(PEDOMETER_SERVICE_ID));
		serviceIDs[index] = PEDOMETER_SERVICE_ID;
		index++;
	}
	if((types & LOCATION) == LOCATION){
			dlog_print(DLOG_INFO, LOG_TAG, "launch request location");
			serviceIDs[index] = malloc(1+strlen(LOCATION_SERVICE_ID));
			serviceIDs[index] = LOCATION_SERVICE_ID;
			index++;
		}
	if((types & ACCELEROMETER) == ACCELEROMETER){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request accelerometer");
		serviceIDs[index] = malloc(1+strlen(ACCELEROMETER_SERVICE_ID));
		serviceIDs[index] = ACCELEROMETER_SERVICE_ID;
		index++;
	}
	if((types & GYROSCOPE) == GYROSCOPE){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request gyroscope");
		serviceIDs[index] = malloc(1+strlen(GYROSCOPE_SERVICE_ID));
		serviceIDs[index] = GYROSCOPE_SERVICE_ID;
		index++;
	}
	if((types & HEARTRATE) == HEARTRATE){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request heart rate");
		serviceIDs[index] = malloc(1+strlen(HEART_RATE_SERVICE_ID));
		serviceIDs[index] = HEART_RATE_SERVICE_ID;
		index++;
	}
	if((types & GRAVITY) == GRAVITY){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request gravity");
		serviceIDs[index] = malloc(1+strlen(GRAVITY_SERVICE_ID));
		serviceIDs[index] = GRAVITY_SERVICE_ID;
		index++;
	}
	if((types & LINEAR_ACCELERATION) == LINEAR_ACCELERATION){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request lin acc");
		serviceIDs[index] = malloc(1+strlen(LINEAR_ACCELERATION_SERVICE_ID));
		serviceIDs[index] = LINEAR_ACCELERATION_SERVICE_ID;
		index++;
	}
	if((types & LIGHT) == LIGHT){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request light");
		serviceIDs[index] = malloc(1+strlen(LIGHT_SERVICE_ID));
		serviceIDs[index] = LIGHT_SERVICE_ID;
		index++;
	}
	if((types & PRESSURE) == PRESSURE){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request pressure");
		serviceIDs[index] = malloc(1+strlen(PRESSURE_SERVICE_ID));
		serviceIDs[index] = PRESSURE_SERVICE_ID;
		index++;
	}
	if((types & HR_GREEN_LIGHT) == HR_GREEN_LIGHT){
		dlog_print(DLOG_INFO, LOG_TAG, "launch request hr green");
		serviceIDs[index] = malloc(1+strlen(HR_GREEN_LIGHT_SERVICE_ID));
		serviceIDs[index] = HR_GREEN_LIGHT_SERVICE_ID;
		index++;
	}

	return serviceIDs;
}
