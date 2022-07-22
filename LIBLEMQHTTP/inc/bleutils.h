#ifndef _BLEUTILS_H_
#define _BLEUTILS_H_

#include "utils.h"
#include "sensorutils.h"
#include "internetutils.h"
#include "fileutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "bleutils"

#define BT_REMOTE_DEVICE_NAME 		"Frailty"
#define BT_REMOTE_DEVICE_ADDRESS 	"66:92:47:E2:5D:08"
#define BT_REMOTE_DEVICE_ADDRESS_2 	"41:A1:CC:C0:C4:87"

#ifdef __cplusplus
extern "C" {
#endif

extern bt_gatt_server_h gatt_server;
extern bt_gatt_client_h gatt_client;

extern bool init_bluetooth();
extern bool create_gatt_client();
extern void _bt_adapter_le_scan_result_cb(int result, bt_adapter_le_device_scan_result_info_s *discovery_info, void *user_data);
extern void __bt_gatt_client_service_changed_cb(bt_gatt_client_h client, bt_gatt_client_service_change_type_e change_type, const char *service_uuid, void *user_data);
extern bool __bt_gatt_client_foreach_svc_cb(int total, int index, bt_gatt_h svc_handle, void *data);
extern bool __bt_gatt_client_foreach_chr_cb(int total, int index, bt_gatt_h chr_handle, void *data);
extern void listen_all_characteristic_values_changed_in_remote_device();
extern bool listen_characteristic_value_changed_in_remote_device(char* serviceID, char* characteristicID);
extern void __bt_gatt_client_value_changed_cb(bt_gatt_h chr, char *value, int len, void *user_data);
extern bool send_value_to_device(char* serviceID, char* characteristicUUID, char* data);
extern int __bt_gatt_client_set_value(char *type, char *value, bt_gatt_h h);
extern void __bt_gatt_client_write_complete_cb(int result, bt_gatt_h gatt_handle, void *data);
extern void record_time_mark();
extern const char *bt_get_error_message(bt_error_e err);
extern char *uuidToServiceName(char *raw_data);
extern char *uuidToCharacteristicName(char *raw_data);
extern char *serviceNameToUUID(char *raw_data);
extern char *characteristicNameToUUID(char *raw_data);

#ifdef __cplusplus
}
#endif
#endif // _BLEUTILS_H_
