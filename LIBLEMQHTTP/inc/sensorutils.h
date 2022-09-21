#ifndef _SENSORUTILS_H_
#define _SENSORUTILS_H_

#include "utils.h"
#include <power.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "sensorutils"

#ifdef __cplusplus
extern "C" {
#endif

typedef struct sensordata
{
	char* serviceID; 			//identificador del servicio
	char* serviceTAG; 			//tag del servicio
	sensor_type_e type; 		//tipo de sensor
    sensor_h sensor; 			// controlador del sensor
    sensor_listener_h listener; // controlador del listener del sensor
    location_manager_h manager; //controlador de localizacion
    char* dataCaptured; 		//datos capturados y no guardados en memoria interna
    bool stop_requested;		//si ha recibido la orden de ser detenido o no
    bool header_file_recorded;
    time_t timestamp;
    bt_gatt_property_e gatt_properties;
//    bt_gatt_server_h gatt_server;
    bt_gatt_h gatt_service;
    bt_gatt_h gatt_characteristic;
//    bt_gatt_h gatt_characteristic_record_time = NULL;
} sensordata_s;

typedef enum{
	NONE 					= 0,			// 0000000000
	PEDOMETER				= 1 << 0,		// 0000000001
	ACCELEROMETER			= 1 << 1,		// 0000000010
	GYROSCOPE				= 1 << 2,		// 0000000100
	HEARTRATE				= 1 << 3,		// 0000001000
    GRAVITY 				= 1 << 4,		// 0000010000
	LINEAR_ACCELERATION		= 1 << 5,		// 0000100000
	LIGHT					= 1 << 6,		// 0001000000
	HR_GREEN_LIGHT			= 1 << 7, 		// 0010000000
    PRESSURE				= 1 << 8,		// 0100000000
	LOCATION				= 1 << 9		// 1000000000
} my_sensor_types_e;

typedef struct sensordata_dict
{
	sensordata_s* sd;
	char* serviceID;
} sensordata_dict_s;

extern sensordata_s sensors[NUM_SENSORS];
extern sensordata_dict_s sensors_dict[NUM_SENSORS];
extern location_manager_h location_manager;
extern int total_active_sensors;


extern void launch_sensors(my_sensor_types_e types);
extern void stop_sensors();

/**
 * @brief Crea el sensor y el listener si está soportado
 */
extern bool create_sensor(char* serviceID, char* serviceTAG, sensordata_s* sd);
extern void terminate_sensor(sensordata_s* sd);

/**
 * @brief Gestiona la captura de datos de un sensor
 */
extern void sensor_capture_data(sensor_h sensor, sensor_event_s *event, sensordata_s* sd);
extern char* get_sensor_data(sensordata_s* sd, sensor_event_s *event);
extern Eina_Bool force_read_sensor_data(char* serviceID);

extern char* get_sensor_error_message(int error);

extern char* get_header_of_sensor_file(char* serviceID);

extern void register_sensor_data_captured(sensordata_s* sd, char* content);

//--
// Location
//--
extern bool init_location(sensordata_s* sd);
extern void state_changed_cb(location_service_state_e state, void *user_data);
extern void position_updated(double latitude, double longitude, double altitude, time_t timestamp, void *user_data);
extern void velocity_updated(double speed, double direction, double climb, time_t timestamp, void *user_data);
extern char* get_cur_location(sensordata_s* sd);
extern void terminate_location();
extern char* get_location_error_message(int error);
extern char** get_service_ids_contained_in_enum(my_sensor_types_e types, int* counter);

#ifdef __cplusplus
}
#endif
#endif /* _SENSORUTILS_H_ */
