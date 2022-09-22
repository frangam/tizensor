#include <tizen.h>
#include <service_app.h>
#include "location.h"

static location_service_state_e service_state;

bool service_app_create(void *data)
{
	location_manager_h manager;
	if(location_manager_create(LOCATIONS_METHOD_HYBRID, &manager) == LOCATIONS_ERROR_NONE){
		sensordata_s* sd = (sensordata_s*)data;
		sd->serviceID = LOCATION_SERVICE_ID;
		sd->serviceTAG = LOG_TAG;
		sd->dataCaptured = "";
		sd->manager = manager;
		sd->stop_requested = false;

		int min_interval = get_sensor_min_interval(LOCATION_SERVICE_ID);
		int ret = location_manager_set_service_state_changed_cb(sd->manager, state_changed_cb, NULL);
		location_manager_set_position_updated_cb(sd->manager, position_updated, min_interval, NULL);
		location_manager_set_position_updated_cb(sd->manager, velocity_updated, min_interval, NULL);

		int sensor_id = get_service_index_by_id(sd->serviceID);
//		sensors[sensor_id] = (sensordata_s *) malloc(sizeof(sensordata_s));
//		sensors[sensor_id].serviceID = sd->serviceID;
//		sensors[sensor_id].serviceTAG = sd->serviceTAG;
//		sensors[sensor_id].dataCaptured = sd->dataCaptured;
//		sensors[sensor_id].stop_requested = sd->stop_requested;
//		sensors[sensor_id].manager = sd->manager;

		get_cur_location(&sensors[sensor_id]);

//		if(ret == LOCATIONS_ERROR_NONE){
//			dlog_print(DLOG_INFO, sd->serviceTAG, "%s: creado servicio de localización", sd->serviceID);
//			ret = location_manager_start(sd->manager);
//			if(ret == LOCATIONS_ERROR_NONE){
//				dlog_print(DLOG_INFO, sd->serviceTAG, "%s:iniciado servicio de localización", sd->serviceID);
//				get_cur_location(sd);
//			}
//			else{
//				dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error intentando iniciar el servicio de localización", sd->serviceID);
//			}
//		}
//		else{
//			dlog_print(DLOG_ERROR, LOG_TAG, "%s: error creando el servicio de localización", LOCATION_SERVICE_ID);
//		}

	}
	else{
		dlog_print(DLOG_ERROR, LOG_TAG, "%s: error creando el servicio de localización", LOCATION_SERVICE_ID);
		service_app_exit();
	}

    return true;
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
    		get_cur_location(sd);
    }
    else{
    		dlog_print(DLOG_INFO, sd->serviceTAG, "%s: servicio de localización deshabilitado", sd->serviceID);
    }
}

void position_updated(double latitude, double longitude, double altitude,
                      time_t timestamp, void *user_data) {
	sensordata_s* sd = (sensordata_s*)user_data;
	dlog_print(DLOG_INFO, sd->serviceTAG, "%s: position updated", sd->serviceID);
	get_cur_location(sd);
}
void velocity_updated(double speed, double direction, double climb,
                      time_t timestamp, void *user_data) {
	sensordata_s* sd = (sensordata_s*)user_data;
	dlog_print(DLOG_INFO, sd->serviceTAG, "%s: velocity updated", sd->serviceID);
	get_cur_location(sd);
}

void get_cur_location(sensordata_s* sd){
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
	int ret = location_manager_get_location(sd->manager, &altitude, &latitude, &longitude,
		                                         &climb, &direction, &speed, &level, &horizontal,
		                                         &vertical, &timestamp);
	if(ret != LOCATIONS_ERROR_NONE){
		ret = location_manager_get_last_location(sd->manager, &altitude, &latitude, &longitude,
			                                         &climb, &direction, &speed, &level, &horizontal,
			                                         &vertical, &timestamp);
	}

	if(ret == LOCATIONS_ERROR_NONE){
		//obtenemos la fecha y hora (incluyendo milisegundos)
		char* date_str[30], time_str[30], timstap_str[30];
//		get_current_datetime(&date_str, &time_str, &timstap_str);
//		struct timespec spec;
//		clock_gettime(CLOCK_REALTIME, &spec);
//		unsigned long long current_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
//		clock_gettime(CLOCK_MONOTONIC, &spec);
//		unsigned long long monotonic_time_ms = spec.tv_sec * 1000LL + spec.tv_nsec / 1000000LL;
//		unsigned long long event_time_ms = current_time_ms - monotonic_time_ms + timestamp / 1000LL;



		char* content[DATA_LINE_SIZE];
//        sprintf ( content, "%llu,%s,%s,%f,%f,%f,%f,%g,%f,%f,%f\n",event_time_ms, date_str, time_str,
		sprintf ( content, "%s,%s,%f,%f,%f,%f,%g,%f,%f,%f\n", date_str, time_str,
						altitude, latitude, longitude, climb, direction, speed, horizontal, vertical);
		send_message_to_service_with_data(SERVICE_MANAGER_ID,
												LOG_TAG, LOCATION_SERVICE_ID, content);
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
		dlog_print(DLOG_ERROR, sd->serviceTAG, "%s: error intentando obtener la última localización", sd->serviceID);
	}
}

void service_app_terminate(void *data)
{
	sensordata_s* sd = (sensordata_s*)data;
	location_manager_stop(sd->manager);
	location_manager_destroy(sd->manager);
	sd->manager = NULL;
}

void service_app_control(app_control_h app_control, void *data)
{
    handle_app_control_for_sensor_services(LOCATION_SERVICE_ID,
                                           app_control,
                                           (sensordata_s*)data);
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
