#ifndef __servicemanager_H__
#define __servicemanager_H__

#include <dlog.h>
#include <Ecore.h>
#include "utils.h"
#include "sensorutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "servicemanager"

void launch_service(char* service_id);
void stop_service(char* service_id);
void stop_all_alive_services();
void stop_only_sensors_services();
void stop_all_sensors_and_timers();
void launch_all_sensors_and_timers();
EAPI Ecore_Timer * launch_sensor_and_timer(char* serviceID);
bool save_local_data_any_sensor_data_captured(app_control_h app_control);
bool send_local_data_of_any_sensor_to_server(app_control_h app_control);
bool delete_local_data_of_any_sensor(app_control_h app_control);
bool delete_local_data_of_any_sensor_confirmed(app_control_h app_control);

// Timers
Eina_Bool check_internet_timer(void* data);
Eina_Bool sensor_sleep_timer(void *data);
Eina_Bool sensor_alive_timer(void *data);
int get_alive_delay(char* serviceID);
int get_sleep_delay(char* serviceID);

#endif /* __servicemanager_H__ */
