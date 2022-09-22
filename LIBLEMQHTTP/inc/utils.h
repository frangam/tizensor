#ifndef _UTILS_H_
#define _UTILS_H_

/**
 * This header file is included to define _EXPORT_.
 */

#include <tizen.h>
#include <service_app.h>
#include <sensor.h>
#include <locations.h>
#include <bluetooth.h>
#include <dlog.h>

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

#include <time.h>
#include <system_info.h>
#include <locale.h>
#include <Ecore.h>


//#include "sensorutils.h"
//#include "bleutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "utils"



#ifdef __cplusplus
extern "C" {
#endif



#define STRNCMP_LIMIT 							256
#define DATA_LINE_SIZE							2048
#define NUM_SENSORS								10 //no streess and no sleep sensors
#define DELAY_FOR_SEND_DATA_TO_SERVER			2

#define GENERAL_SENSORS_MS_INTERVAL				40 //(1/40)*1000 = 25Hz of sampling frequency
#define HIGH_SENSORS_MS_INTERVAL				300 //3.3Hz of sampling frequency
#define HR_MS_INTERVAL							250 //4Hz of sampling frequency
#define PEDOMETER_MS_INTERVAL					5000 //0.2Hz of sampling frequency
#define LOCATION_MS_INTERVAL					10000 //0.1Hz
#define SLEEP_MS_INTERVAL						1000 //1Hz of sampling frequency
#define STRESS_MS_INTERVAL						1000 //1Hz of sampling frequency

#define MAX_TIME_DIFF							15

//Service ids
#define ANY_SERVICE_ID							"es.ugr.tizensor.*"
#define MYSERVICELAUNCHER_APP_ID 				"es.ugr.tizensor.tizensorlauncher" 	// the ID of the UI application of our package
#define SERVICE_MANAGER_ID 						"es.ugr.tizensor.servicemanager"
#define RECORDER_SERVICE_ID 					"es.ugr.tizensor.recorder"
#define HTTPPOSTREQ_SERVICE_ID 					"es.ugr.tizensor.httppostreq"
#define BLUETOOTH_TRANSFER_SERVICE_ID 			"es.ugr.tizensor.bluetoothtransfer"
#define TIME_MARKS_FILE_ID 						"es.ugr.tizensor.timemarks"

#define PEDOMETER_SERVICE_ID					"es.ugr.tizensor.pedometer"			// Index 0
#define HEART_RATE_SERVICE_ID 					"es.ugr.tizensor.heartrate"			// Index 1
#define ACCELEROMETER_SERVICE_ID 				"es.ugr.tizensor.accelerometer"		// Index 2
#define GYROSCOPE_SERVICE_ID 					"es.ugr.tizensor.gyroscope"			// Index 3
#define LINEAR_ACCELERATION_SERVICE_ID			"es.ugr.tizensor.linearacceleration" // Index 4
#define GRAVITY_SERVICE_ID						"es.ugr.tizensor.gravity"			// Index 5
#define LIGHT_SERVICE_ID						"es.ugr.tizensor.light"				// Index 6
#define PRESSURE_SERVICE_ID						"es.ugr.tizensor.pressure"			// Index 7
#define HR_GREEN_LIGHT_SERVICE_ID				"es.ugr.tizensor.hrgreenlight"		// Index 8
#define LOCATION_SERVICE_ID 					"es.ugr.tizensor.location"			// Index 9
#define STRESS_SERVICE_ID						"es.ugr.tizensor.stress"			// Index 10
#define SLEEP_SERVICE_ID						"es.ugr.tizensor.sleep"				// Index 11

#define LAST_VALUE_ID							".lastvalue"

//#define BT_EXT_CONTROL_START_SERVICE_ID			"ext_control_start_service"
//#define BT_EXT_CONTROL_STOP_SERVICE_ID			"ext_control_stop_service"
//#define BT_EXT_CONTROL_RECORD_NEW_EVENT_SVC_ID	"ext_control_record_new_event_service"
//#define BT_EXT_CONTROL_DELETE_SVC_ID				"ext_control_delete_service"
//#define BT_EXT_CONTROL_HTTP_POST_SVC_ID			"ext_control_post_http_service"
#define BT_EXT_CONTROL_SVC_ID					"ext_control_service"
#define BLE_CHAR_RECORD_SENSOR_DATA_ID			"ble_char_record_sensor_data"			//BLE Characteristic id for recordong sensor data
#define BLE_CHAR_START_SENSORS_ID				"ble_char_start_sensors"					//BLE Characteristic id for starting sensors collect data
#define BLE_CHAR_STOP_SENSORS_ID					"ble_char_stop_sensors" 					//BLE Characteristic id for stopping sensors collect data
#define BLE_CHAR_DELETE_SENSORS_DATA_ID			"ble_char_delete_sensors_data" 			//BLE Characteristic id for deleting sensors collected data
#define BLE_CHAR_RECORD_TIME_MARK_ID				"ble_char_record_time_mark" 				//BLE Characteristic id for recording time mark
#define BLE_CHAR_SEND_SENSORS_DATA_TO_CLOUD_ID	"ble_char_send_sensors_data_to_cloud" 	//BLE Characteristic id for sending sensors collected data to cloud server
#define BLE_CHAR_CONNECTED_ID					"ble_char_connected" 					//BLE Characteristic id for advising the watch is connected to the remote device
#define BLE_CHAR_DELETE_ALL_SUCCEES_ID			"ble_char_delete_all_succees" 			//BLE Characteristic id for advising all data was deleted
#define BLE_CHAR_RECORDED_TIME_MARK_SUCCEES_ID	"ble_char_recorded_time_mark_succees" 	//BLE Characteristic id for advising time mark was recorded
#define BLE_CHAR_ACCELEROMETER_SAMPLING_RATE		"ble_char_acc_sr"
#define BLE_CHAR_GYROSCOPE_SAMPLING_RATE			"ble_char_gyr_sr"
#define BLE_CHAR_PEDOMETER_SAMPLING_RATE			"ble_char_ped_sr"
#define BLE_CHAR_HEARTRATE_SAMPLING_RATE			"ble_char_hr_sr"
#define BLE_CHAR_GRAVITY_SAMPLING_RATE			"ble_char_grav_sr"
#define BLE_CHAR_LINEAR_ACC_SAMPLING_RATE		"ble_char_lin_sr"
#define BLE_CHAR_LIGHT_SAMPLING_RATE				"ble_char_lig_sr"
#define BLE_CHAR_HRGREEN_SAMPLING_RATE			"ble_char_hrgreen_sr"
#define BLE_CHAR_PRESSURE_SAMPLING_RATE			"ble_char_pressure_sr"
#define BLE_CHAR_SENSORS_FOR_USING				"ble_char_sensors_for_using"

#define BLE_INITIAL_BUF_SIZE 512

//Actions
#define SERVICE_ACTION 							"service_action"
#define LAUNCH_ACTION 							"launch"
#define STOP_ACTION 							"stop"
#define STOP_ONLY_SENSORS_ACTION 				"stop_only_sensors"
#define STOP_ALL_ACTION 							"stop_all"
#define CHECK_INTERNET_ACTION					"check_internet" 					// Comprueba si hay internet y si hay envia los datos al servidor
#define TRUE_ACTION_VALUE						"true"
#define FALSE_ACTION_VALUE						"false"
#define STOP_CONFIRMED							"stop_confirmed"					// Confirmada la detección de un servicio
#define RECORD_TIME_ACTION						"record"
#define CREATE_GATT_SERVICE						"create_service"
#define START_GATT_SERVER						"start_server"
#define BT_CONNECTED_ACTION						"0"
#define BT_START_ACTION							"1"
#define BT_STOP_ACTION							"2"
#define BT_DELETE_ACTION						"3"
#define BT_RECORD_TIME_MARK_ACTION				"4"
#define BT_HTTP_POST_ACTION						"5"
#define START_ACTION 							"start"
#define DELETE_ACTION 							"delete"
#define SEND_ALL_DATA_TO_SERVER					"send_all_data_to_server"
#define SEND_VALUE_TO_DEVICE						"send_value_to_device"

#define STR_BT_READ_PROPERTY						"bt_read_property"
#define STR_BT_WRITE_PROPERTY					"bt_write_property"

#define CAPTURE_ACCELEROMETER					"capture_acc"
#define CAPTURE_GYROSCOPE						"capture_gyr"
#define CAPTURE_HEARTRATE						"capture_hr"

#define GET_LOCAL_DATA							"get_local_data"					// Orden para obtener los datos locales capturados
#define DELETE_LOCAL_DATA						"del_local_data"					// Orden para eliminar los datos locales
#define LOCAL_DATA_DELETED						"ld_deleted"						// Orden para avisar que los datos locales se eliminaron
#define DELETE_DATA_AND_CLOSE					"del_local_data_and_close"			// Orden para eliminar los datos locales y cerrar la app
#define ALL_LOCAL_DATA_DELETED					"all_ld_deleted"

#define SEND_LOCAL_DATA_ACCELEROMETER			"send_ld_acc"						// Orden para enviar los datos del acelerómetro al servidor
#define SEND_LOCAL_DATA_GYROSCOPE				"send_ld_gyr"						// Orden para enviar los datos del gyroscope al servidor
#define SEND_LOCAL_DATA_HEART_RATE				"send_ld_hr"
#define SEND_LOCAL_DATA_LOCATION					"send_ld_loc"
#define SEND_LOCAL_DATA_PEDOMETER				"send_ld_ped"
#define SEND_LOCAL_DATA_LIN_ACC					"send_ld_lin_acc"
#define SEND_LOCAL_DATA_GRAVITY					"send_ld_gravity"
#define SEND_LOCAL_DATA_PRESSURE					"send_ld_pressure"
#define SEND_LOCAL_DATA_LIGHT					"send_ld_light"
#define SEND_LOCAL_DATA_HRGL						"send_ld_hrgl"
#define SEND_LOCAL_DATA_HRIR						"send_ld_hrir"
#define SEND_LOCAL_DATA_STRESS					"send_ld_stress"
#define SEND_LOCAL_DATA_SLEEP					"send_ld_sleep"


#define BLUETOOTH_SERVER_SERVICE_UUID			"3570AC09-CAE2-4EBC-80E6-6D92A9830785"
#define BLUETOOTH_SERVER_CHARACTERISTIC_UUID		"C6FA72CA-A3BD-4A3A-A3A9-07493469B259"
#define BLUETOOTH_SERVER_CHAR_WRITE_UUID			"0DBF59A2-7C41-476C-BE64-D845B00860D7"
#define BLUETOOTH_SERVER_CHARACTERISTIC_VALUE	"FRAILTY SENSORS"


//Enumerados
typedef enum {
	ERROR 		= 0,		/**< Si sucede algún error */
	LAUNCH 		= 1,		/**< Acción de lanzar un servicio */
	STOP 		= 2,		/**< Acción de detener un servicio */
	SPECIFIC 	= 3		/**< Acción específica para un servicio */
} type_app_control_e;

typedef enum {
	GET			= 0,		/**< Obtener datos */
	SAVE			= 1,		/**< Salvar datos */
	DELETE		= 2,		/**< Eliminar datos */
	DELETE_ALL	= 3		/**< Eliminar todos los datos de todos los sensores */
} operation_e;



extern int current_time_mark_counter;
extern char* initial_time_capture_str;
extern bool start_to_record_data;
extern bool stop_requested_from_remote_device;




/**
 * @brief Obtiene el tipo de sensor segun el id del servicio
 */
extern sensor_type_e get_sensor_type_by_service_id(char* serviceID);

extern char* get_service_id_by_index(int index);
extern int get_service_index_by_id(char* serviceID);
extern char* get_local_data_message_to_handler(char* serviceID);

/**
 * @brief Send an internal message to a service app with data
 * @param toServiceID destination service app id
 * @param message the text message is sent
 * @param data the extra data are sent
 */
extern void send_message_to_service_with_data(char* toServiceID, char* serviceTAG, char* message, char* data);

/**
 * @brief Obtiene la fecha y la hora (incluye milisegundos) como cadena y en formato spain
 */
extern void get_current_datetime(char** date_str, char** time_str, char** timestamp_str);

/**
 * @brief Obtiene el id del dispositivo
 */
extern char* get_device_id();

extern char* get_last_value_id(char* serviceID);


/**
 * @brief manages the app_control of a tizen service app, that means the internal message passing between service apps
 */
extern type_app_control_e handle_app_control(char* rightCallerID, app_control_h app_control, char* serviceID, bool save);
extern type_app_control_e handle_app_control_not_save_data(char* rightCallerID, app_control_h app_control, char* serviceID);
extern type_app_control_e handle_app_control_and_save_data(char* rightCallerID, app_control_h app_control, char* serviceID);



//extern Eina_Bool save_local_data_cb(void* data);


//Mensajes
extern const char *get_type_app_control_message(type_app_control_e type);


extern char* convert_bytes_to_binary_string(uint8_t *bytes, size_t count);
extern uint8_t* convert_string_to_bytes(char* str, size_t len);

extern char* substr(char*, int, int);

extern bool is_received_stop_request_from_remote_device();
extern void upate_stop_requested_from_remote_device(bool received);




#ifdef __cplusplus
}
#endif
#endif // _UTILS_H_

