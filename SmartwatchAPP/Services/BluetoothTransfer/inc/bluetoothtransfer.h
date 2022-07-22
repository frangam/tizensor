#ifndef __bluetoothtransfer_H__
#define __bluetoothtransfer_H__

#include <dlog.h>
#include "utils.h"
#include "bleutils.h"
#include "sensorutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "bluetoothtransfer"



bool create_gatt_server();
//bool create_gatt_client();
//int __bt_gatt_client_set_value(char *type, char *value, bt_gatt_h h);
//void __bt_gatt_client_write_complete_cb(int result, bt_gatt_h gatt_handle, void *data);
//void __bt_gatt_client_service_changed_cb(bt_gatt_client_h client, bt_gatt_client_service_change_type_e change_type, const char *service_uuid, void *user_data);
//void listen_all_characteristic_values_changed_in_remote_device();
//bool listen_characteristic_value_changed_in_remote_device(char* serviceUUID, char* characteristicUUID);
//void __bt_gatt_client_value_changed_cb(bt_gatt_h chr, char *value, int len, void *user_data);
//bool send_value_to_device(char* serviceID, char* characteristicUUID, char* data);
bool send_data_of_any_sensor_to_bt_device(app_control_h app_control);
void __bt_gatt_connection_state_changed_cb(int result, bool connected, const char *remote_address, void *user_data);
//void _bt_adapter_le_scan_result_cb(int result, bt_adapter_le_device_scan_result_info_s *discovery_info, void *user_data);
//bool __bt_gatt_client_foreach_svc_cb(int total, int index, bt_gatt_h svc_handle, void *data) ;
//bool __bt_gatt_client_foreach_chr_cb(int total, int index, bt_gatt_h chr_handle, void *data);

//bool init_bluetooth();
//void record_time_mark();
//bool must_create_gatt_server_of_any_sensor(app_control_h app_control, char** serviceID, char** extra_param);
bool create_gatt_service_for_sensor(char* serviceID, bt_gatt_property_e gatt_properties);
void
__bt_gatt_server_read_value_requested_cb (const char *remote_address,
										int request_id, bt_gatt_server_h server,
										bt_gatt_h gatt_handle, int offset,
										void* user_data);
void
__bt_gatt_server_write_value_requested_cb(const char *remote_address, int request_id,
										bt_gatt_server_h server, bt_gatt_h gatt_handle,
										bool response_needed, int offset, const char *value,
										int len, void *user_data);

#endif /* __bluetoothtransfer_H__ */
