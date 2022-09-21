#include "bleutils.h"


bt_gatt_server_h gatt_server = NULL;
bt_gatt_client_h gatt_client = NULL;

char *GattServices[][2] =
		{{"CDD441F7-A574-4370-AF7B-2811FA832D0A", ACCELEROMETER_SERVICE_ID},
		{"1FB9B584-5072-4E3D-8635-5EA8C8A72270", GYROSCOPE_SERVICE_ID},
		{"6DFBAD02-708B-4B07-A72B-9EDC9EFA7B70", HEART_RATE_SERVICE_ID},
		{"8688C2AA-0905-4D23-B636-92688B269169", LINEAR_ACCELERATION_SERVICE_ID},
		{"AB2561CD-D15E-42C7-8C9C-2E98206B2661", GRAVITY_SERVICE_ID},
		{"2DD84D72-B634-443D-9219-6E986CD5FB97", LIGHT_SERVICE_ID},
		{"149B37E9-1EC4-4F43-BF85-AF749225A4C7", PRESSURE_SERVICE_ID},
		{"2253FB3D-17F3-4B5F-B35B-8B2D46028A6E", PEDOMETER_SERVICE_ID},
		{"9F61335F-1368-47E5-A6CF-D81CABBA8809", HR_GREEN_LIGHT_SERVICE_ID},
		{"0E32347F-59AA-4642-864F-25EF781801D1", STRESS_SERVICE_ID},
		{"783A3CF3-B865-4103-B8A1-CF88A440C5C9", LOCATION_SERVICE_ID},
		{"91EE0AD3-B464-41C0-A827-88C388CB5920", SLEEP_SERVICE_ID},
		{"785147F1-CB21-4C3A-B2BC-D4B2CA0FCE27", BT_EXT_CONTROL_SVC_ID},
//		{"BD2BD840-1BB2-4115-8D8C-62AC2945626B", BT_EXT_CONTROL_START_SERVICE_ID},
//		{"4C4979B3-C54B-45A1-972D-3920E70178D8", BT_EXT_CONTROL_STOP_SERVICE_ID},
//		{"A870FE06-527C-4659-8259-E67E36AC44E2", BT_EXT_CONTROL_DELETE_SVC_ID},
//		{"E853DFDA-6B2E-40F2-97A6-3E00A143C3D2", BT_EXT_CONTROL_RECORD_NEW_EVENT_SVC_ID},
//		{"B8CBB5CF-B86E-4DFC-BDCD-249B62C69DBB", BT_EXT_CONTROL_HTTP_POST_SVC_ID},
		{"00002b30-0000-1000-8000-00805f9b34fb", "Advertising Interval"},
		{"00002b20-0000-1000-8000-00805f9b34fb", "Acceleration/Orientation"},
		{"00002b10-0000-1000-8000-00805f9b34fb", "Temperature"},
		{"00001811-0000-1000-8000-00805f9b34fb", "Alert Notification Service"},
		{"0000180f-0000-1000-8000-00805f9b34fb", "Battery Service"},
		{"00001810-0000-1000-8000-00805f9b34fb", "Blood Pressure"},
		{"00001805-0000-1000-8000-00805f9b34fb", "Current Time Service"},
		{"00001818-0000-1000-8000-00805f9b34fb", "Cycling Power"},
		{"00001816-0000-1000-8000-00805f9b34fb", "Cycling Speed and Cadence"},
		{"0000180a-0000-1000-8000-00805f9b34fb", "Device Information"},
		{"00001800-0000-1000-8000-00805f9b34fb", "Generic Access"},
		{"00001801-0000-1000-8000-00805f9b34fb", "Generic Attribute"},
		{"00001808-0000-1000-8000-00805f9b34fb", "Glucose"},
		{"00001809-0000-1000-8000-00805f9b34fb", "Health Thermometer"},
		{"0000180d-0000-1000-8000-00805f9b34fb", "Heart Rate"},
		{"00001812-0000-1000-8000-00805f9b34fb", "Human Interface Device"},
		{"00001802-0000-1000-8000-00805f9b34fb", "Immediate Alert"},
		{"00001803-0000-1000-8000-00805f9b34fb", "Link Loss"},
		{"00001819-0000-1000-8000-00805f9b34fb", "Location and Navigation"},
		{"00001807-0000-1000-8000-00805f9b34fb", "Next DST Change Service"},
		{"0000180e-0000-1000-8000-00805f9b34fb", "Phone Alert Status Service"},
		{"00001806-0000-1000-8000-00805f9b34fb", "Reference Time Update Service"},
		{"00001814-0000-1000-8000-00805f9b34fb", "Running Speed and Cadence"},
		{"00001813-0000-1000-8000-00805f9b34fb", "Scan Parameters"},
		{"00001804-0000-1000-8000-00805f9b34fb", "Tx Power"},
		{"00001930-0000-1000-8000-00805f9b34fb", "Advertising Interval Service"},
		{"00001910-0000-1000-8000-00805f9b34fb", "Temperature Service"},
		{"00001920-0000-1000-8000-00805f9b34fb", "Acceleration/Orientation Service"}};

char *GattCharacteristics[][2] =
		{{"74CF6286-3C85-4BB8-AB94-0A6DEE08F260", ACCELEROMETER_SERVICE_ID},
		{"1A3D0B34-DAC0-479C-91AF-FCB75F0B15B9", GYROSCOPE_SERVICE_ID},
		{"3FCB96E6-E293-47A8-8238-0FCCCBA129A2", HEART_RATE_SERVICE_ID},
		{"D108B7F6-4A6A-4F83-BCC2-8C807D3C1510", LINEAR_ACCELERATION_SERVICE_ID},
		{"506A9FE2-2391-4330-979B-1CA27DF9DD89", GRAVITY_SERVICE_ID},
		{"7DF8639A-D846-4518-828A-B8F06F35EAB5", LIGHT_SERVICE_ID},
		{"096D0E1C-3CBD-427A-871E-A1FCB9EB044E", PRESSURE_SERVICE_ID},
		{"5FED9024-6645-4662-A96B-18185270651A", PEDOMETER_SERVICE_ID},
		{"F6361764-5612-40BD-8E81-9A4D6859CBB7", HR_GREEN_LIGHT_SERVICE_ID},
		{"A91065A8-4B70-4A26-9653-F6E58328A28E", STRESS_SERVICE_ID},
		{"727A501F-17DF-47A6-A9E3-008000711F0D", LOCATION_SERVICE_ID},
		{"11F15CA4-8DE4-4C9E-8E1A-1D7EC9E36B00", SLEEP_SERVICE_ID},
		{"7627BF64-FB2F-415A-BBE7-9D403343BADF", BLE_CHAR_SENSORS_FOR_USING},
		{"4B1B530C-1540-4917-B100-3AF4BE67F8A0", BLE_CHAR_RECORD_SENSOR_DATA_ID},
		{"96E40C7C-11FE-4FBE-99F9-D2B961324EC8", BLE_CHAR_START_SENSORS_ID},
		{"D7BB0470-EA3F-4868-891B-43993E121534", BLE_CHAR_STOP_SENSORS_ID},
		{"928557A2-1C9B-412F-B675-3A572EA1A183", BLE_CHAR_DELETE_SENSORS_DATA_ID},
		{"5E50C0BE-09FD-4049-82DC-6DC3AA4EEAF5", BLE_CHAR_RECORD_TIME_MARK_ID},
		{"C085302D-5B76-4A9B-B784-BA6D9417FD4F", BLE_CHAR_SEND_SENSORS_DATA_TO_CLOUD_ID},
		{"5A541D0A-36DF-43AF-9343-3B935C4B8025", BLE_CHAR_CONNECTED_ID},
		{"5A76C9DB-914B-4364-B3DB-3F892756AC17", BLE_CHAR_DELETE_ALL_SUCCEES_ID},
		{"594BD17F-AA3A-4AF6-8587-219DCEF3223F", BLE_CHAR_RECORDED_TIME_MARK_SUCCEES_ID},
		{"66D52C61-BD80-48C4-8C5B-06A7BE7D4129", BLE_CHAR_ACCELEROMETER_SAMPLING_RATE},
		{"A40AF02E-F009-4C17-91E1-92A8B62F3778", BLE_CHAR_GYROSCOPE_SAMPLING_RATE},
		{"D054D14F-ECB1-44B7-9C42-137C9D1BA3F3", BLE_CHAR_PEDOMETER_SAMPLING_RATE},
		{"8434F3EE-91C7-43FB-B030-0626CECF0901", BLE_CHAR_HEARTRATE_SAMPLING_RATE},
		{"73B82DC6-4068-42E5-8337-87E25C34905D", BLE_CHAR_GRAVITY_SAMPLING_RATE},
		{"2AE3FCAB-BC2E-42BA-97E4-D26FD2BFE42B", BLE_CHAR_LINEAR_ACC_SAMPLING_RATE},
		{"FC2BAC14-9E11-4041-8FD8-08C5D54C4DBE", BLE_CHAR_LIGHT_SAMPLING_RATE},
		{"95BA082C-D4DC-435E-80DE-5F3CEDF056B2", BLE_CHAR_HRGREEN_SAMPLING_RATE},
		{"65251E01-EF75-4C73-B75C-94FC631B34C2", BLE_CHAR_PRESSURE_SAMPLING_RATE},
		{"00002a43-0000-1000-8000-00805f9b34fb","Alert Category ID"},
		{"00002a42-0000-1000-8000-00805f9b34fb","Alert Category ID Bit Mask"},
		{"00002a06-0000-1000-8000-00805f9b34fb","Alert Level"},
		{"00002a44-0000-1000-8000-00805f9b34fb","Alert Notification Control Point"},
		{"00002a3F-0000-1000-8000-00805f9b34fb","Alert Status"},
		{"00002a01-0000-1000-8000-00805f9b34fb","Appearance"},
		{"00002a19-0000-1000-8000-00805f9b34fb","Battery Level"},
		{"00002a49-0000-1000-8000-00805f9b34fb","Blood Pressure Feature"},
		{"00002a35-0000-1000-8000-00805f9b34fb", "Blood Pressure Measurement"},
		{"00002a38-0000-1000-8000-00805f9b34fb", "Body Sensor Location"},
		{"00002a22-0000-1000-8000-00805f9b34fb", "Boot Keyboard Input Report"},
		{"00002a32-0000-1000-8000-00805f9b34fb", "Boot Keyboard Output Report"},
		{"00002a33-0000-1000-8000-00805f9b34fb", "Boot Mouse Input Report"},
		{"00002a5a-0000-1000-8000-00805f9b34fb", "CSC Feature"},
		{"00002a5b-0000-1000-8000-00805f9b34fb", "CSC Measurement"},
		{"00002a2b-0000-1000-8000-00805f9b34fb", "Current Time"},
		{"00002a66-0000-1000-8000-00805f9b34fb", "Cycling Power Control Point"},
		{"00002a65-0000-1000-8000-00805f9b34fb", "Cycling Power Feature"},
		{"00002a63-0000-1000-8000-00805f9b34fb", "Cycling Power Measurement"},
		{"00002a64-0000-1000-8000-00805f9b34fb", "Cycling Power Vector"},
		{"00002a08-0000-1000-8000-00805f9b34fb", "Date Time"},
		{"00002a0a-0000-1000-8000-00805f9b34fb", "Day Date Time"},
		{"00002a09-0000-1000-8000-00805f9b34fb", "Day of Week"},
		{"00002a00-0000-1000-8000-00805f9b34fb", "Device Name"},
		{"00002a0d-0000-1000-8000-00805f9b34fb", "DST Offset"},
		{"00002a0c-0000-1000-8000-00805f9b34fb", "Exact Time 256"},
		{"00002a26-0000-1000-8000-00805f9b34fb", "Firmware Revision String"},
		{"00002a51-0000-1000-8000-00805f9b34fb", "Glucose Feature"},
		{"00002a18-0000-1000-8000-00805f9b34fb", "Glucose Measurement"},
		{"00002a34-0000-1000-8000-00805f9b34fb", "Glucose Measurement Context"},
		{"00002a27-0000-1000-8000-00805f9b34fb", "Hardware Revision String"},
		{"00002a39-0000-1000-8000-00805f9b34fb", "Heart Rate Control Point"},
		{"00002a37-0000-1000-8000-00805f9b34fb", "Heart Rate Measurement"},
		{"00002a4c-0000-1000-8000-00805f9b34fb", "HID Control Point"},
		{"00002a4a-0000-1000-8000-00805f9b34fb", "HID Information"},
		{"00002a2a-0000-1000-8000-00805f9b34fb", "IEEE 11073-20601 Regulatory Certification Data List"},
		{"00002a36-0000-1000-8000-00805f9b34fb", "Intermediate Cuff Pressure"},
		{"00002a1e-0000-1000-8000-00805f9b34fb", "Intermediate Temperature"},
		{"00002a6b-0000-1000-8000-00805f9b34fb", "LN Control Point"},
		{"00002a6a-0000-1000-8000-00805f9b34fb", "LN Feature"},
		{"00002a0f-0000-1000-8000-00805f9b34fb", "Local Time Information"},
		{"00002a67-0000-1000-8000-00805f9b34fb", "Location and Speed"},
		{"00002a29-0000-1000-8000-00805f9b34fb", "Manufacturer Name String"},
		{"00002a21-0000-1000-8000-00805f9b34fb", "Measurement Interval"},
		{"00002a24-0000-1000-8000-00805f9b34fb", "Model Number String"},
		{"00002a68-0000-1000-8000-00805f9b34fb", "Navigation"},
		{"00002a46-0000-1000-8000-00805f9b34fb", "New Alert"},
		{"00002a04-0000-1000-8000-00805f9b34fb", "Peripheral Preferred Connection Parameters"},
		{"00002a02-0000-1000-8000-00805f9b34fb", "Peripheral Privacy Flag"},
		{"00002a50-0000-1000-8000-00805f9b34fb", "PnP ID"},
		{"00002a69-0000-1000-8000-00805f9b34fb", "Position Quality"},
		{"00002a4e-0000-1000-8000-00805f9b34fb", "Protocol Mode"},
		{"00002a03-0000-1000-8000-00805f9b34fb", "Reconnection Address"},
		{"00002a52-0000-1000-8000-00805f9b34fb", "Record Access Control Point"},
		{"00002a14-0000-1000-8000-00805f9b34fb", "Reference Time Information"},
		{"00002a4d-0000-1000-8000-00805f9b34fb", "Report"},
		{"00002a4b-0000-1000-8000-00805f9b34fb", "Report Map"},
		{"00002a40-0000-1000-8000-00805f9b34fb", "Ringer Control Point"},
		{"00002a41-0000-1000-8000-00805f9b34fb", "Ringer Setting"},
		{"00002a54-0000-1000-8000-00805f9b34fb", "RSC Feature"},
		{"00002a53-0000-1000-8000-00805f9b34fb", "RSC Measurement"},
		{"00002a55-0000-1000-8000-00805f9b34fb", "SC Control Point"},
		{"00002a4f-0000-1000-8000-00805f9b34fb", "Scan Interval Window"},
		{"00002a31-0000-1000-8000-00805f9b34fb", "Scan Refresh"},
		{"00002a5d-0000-1000-8000-00805f9b34fb", "Sensor Location"},
		{"00002a25-0000-1000-8000-00805f9b34fb", "Serial Number String"},
		{"00002a05-0000-1000-8000-00805f9b34fb", "Service Changed"},
		{"00002a28-0000-1000-8000-00805f9b34fb", "Software Revision String"},
		{"00002a47-0000-1000-8000-00805f9b34fb", "Supported New Alert Category"},
		{"00002a48-0000-1000-8000-00805f9b34fb", "Supported Unread Alert Category"},
		{"00002a23-0000-1000-8000-00805f9b34fb", "System ID"},
		{"00002a1c-0000-1000-8000-00805f9b34fb", "Temperature Measurement"},
		{"00002a1d-0000-1000-8000-00805f9b34fb", "Temperature Type"},
		{"00002a12-0000-1000-8000-00805f9b34fb", "Time Accuracy"},
		{"00002a13-0000-1000-8000-00805f9b34fb", "Time Source"},
		{"00002a16-0000-1000-8000-00805f9b34fb", "Time Update Control Point"},
		{"00002a17-0000-1000-8000-00805f9b34fb", "Time Update State"},
		{"00002a11-0000-1000-8000-00805f9b34fb", "Time with DST"},
		{"00002a0e-0000-1000-8000-00805f9b34fb", "Time Zone"},
		{"00002a07-0000-1000-8000-00805f9b34fb", "Tx Power Level"},
		{"00002a45-0000-1000-8000-00805f9b34fb", "Unread Alert Status"}};

bool init_bluetooth(){
	bool result = false;
	int res = bt_initialize();
	if(res == BT_ERROR_NONE){
		dlog_print(DLOG_INFO, LOG_TAG, "%s gatt bluetooth initialized successfully", BLUETOOTH_TRANSFER_SERVICE_ID);
		bt_adapter_state_e state = BT_ADAPTER_DISABLED;
		res = bt_adapter_get_state(&state);

		if (state == BT_ADAPTER_ENABLED){
			dlog_print(DLOG_INFO, LOG_TAG, "%s gatt bluetooth adapter is enabled", BLUETOOTH_TRANSFER_SERVICE_ID);
			result = true;
		}
	}
	else{
		dlog_print(DLOG_ERROR, LOG_TAG, "%s Error occurred when initializing gatt bluetooth! [%s]", BLUETOOTH_TRANSFER_SERVICE_ID, bt_get_error_message(res));
	}

	return result;
}


bool create_gatt_client(){
	bool result = false;
	char* serviceID;

	if(init_bluetooth()){
		int res = bt_adapter_le_start_scan(_bt_adapter_le_scan_result_cb, NULL);
		if (res == BT_ERROR_NONE){
			dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_adapter_le_start_scan succeeded");
		}
		else{
			dlog_print(DLOG_ERROR, LOG_TAG, "gatt failed bt_adapter_le_start_scan [%s]", bt_get_error_message(res));
		}
	}

	return result;
}

void _bt_adapter_le_scan_result_cb(int result, bt_adapter_le_device_scan_result_info_s *discovery_info, void *user_data)
{
	dlog_print(DLOG_INFO, LOG_TAG, "gatt scan remote address: %s", discovery_info->remote_address);
	dlog_print(DLOG_INFO, LOG_TAG, "gatt scan data: %s", discovery_info->scan_data);

	char* device_name = NULL;

	int ret = bt_adapter_le_get_scan_result_device_name(discovery_info, BT_ADAPTER_LE_PACKET_ADVERTISING	, &device_name);
	dlog_print(DLOG_INFO, LOG_TAG, "gatt device name %s", device_name);
	if(device_name != NULL){
		dlog_print(DLOG_INFO, LOG_TAG, "gatt device name %s", device_name);
	}

	if (ret == BT_ERROR_NONE && (!strcmp(device_name, BT_REMOTE_DEVICE_NAME) //"TIZENSOR"
                                 /* ONLY FOR TEST PURPOSES*/
//			|| !strcmp(discovery_info->remote_address, BT_REMOTE_DEVICE_ADDRESS)
                                 /* ONLY FOR TEST PURPOSES*/
//			|| !strcmp(discovery_info->remote_address, BT_REMOTE_DEVICE_ADDRESS_2)
			)) {
		dlog_print(DLOG_INFO, LOG_TAG, "gatt it is our device: %s", discovery_info->remote_address);
		bt_adapter_le_stop_scan();
		ret = bt_gatt_connect(discovery_info->remote_address, false);
		if (ret != BT_ERROR_NONE) {
			dlog_print(DLOG_ERROR, LOG_TAG,"gatt failed to connect LE device [%s]", bt_get_error_message(ret));
		} else {
			ret = bt_gatt_client_create(discovery_info->remote_address, &gatt_client);
			if (ret == BT_ERROR_NONE) {
				dlog_print(DLOG_INFO, LOG_TAG, "gatt client created");

				ret = bt_gatt_client_set_service_changed_cb (gatt_client, __bt_gatt_client_service_changed_cb, NULL);
				if (ret != BT_ERROR_NONE) {
					dlog_print(DLOG_ERROR, LOG_TAG, "gatt fail to read services [%s]", bt_get_error_message(ret));
				}
				else{
					dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_client_set_service_changed_cb success");
				}
                
                /* Iterate over GATT services */
				ret = bt_gatt_client_foreach_services(gatt_client, __bt_gatt_client_foreach_svc_cb, NULL);
				if (ret != BT_ERROR_NONE) {
					dlog_print(DLOG_ERROR, LOG_TAG, "gatt fail to read services [%s]", bt_get_error_message(ret));
				}
				else{
					dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_client_foreach_services success");
					listen_all_characteristic_values_changed_in_remote_device();
				}
			}
		}
	}
}

void listen_all_characteristic_values_changed_in_remote_device(){
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_START_SENSORS_ID);
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_STOP_SENSORS_ID);
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_DELETE_SENSORS_DATA_ID);
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_RECORD_TIME_MARK_ID);
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_SEND_SENSORS_DATA_TO_CLOUD_ID);
    listen_characteristic_value_changed_in_remote_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_CONNECTED_ID);
}

bool listen_characteristic_value_changed_in_remote_device(char* serviceID, char* characteristicID){
    bool r = false;
    bt_gatt_h svc = NULL;
    bt_gatt_h chr = NULL;
    char* serviceUUID = serviceNameToUUID(serviceID);
    char* characteristicUUID = characteristicNameToUUID(characteristicID);
    char* characteristicName = uuidToCharacteristicName(characteristicUUID);
    int ret = bt_gatt_client_get_service(gatt_client, serviceUUID, &svc);

    if (ret != BT_ERROR_NONE) {
        dlog_print(DLOG_ERROR, LOG_TAG, "gatt bt_gatt_client_get_service failed: %s", bt_get_error_message(ret));
    }
    else{
        ret = bt_gatt_service_get_characteristic(svc, characteristicUUID, &chr);
        if (ret != BT_ERROR_NONE) {
            dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_service_get_characteristic failed: %s", bt_get_error_message(ret));
        }
        else{
            ret = bt_gatt_client_set_characteristic_value_changed_cb(chr, __bt_gatt_client_value_changed_cb, NULL);
            if (ret != BT_ERROR_NONE) {
                dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_client_set_characteristic_value_changed_cb failed: %s", bt_get_error_message(ret));
            }
            else{
                r = true;
                dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_client_set_characteristic_value_changed_cb succeed: %s [uuid: %s]", characteristicName, characteristicUUID);
            }
        }
    }

    return r;
}

/* ALL BLE CALLBACKS */

void __bt_gatt_client_service_changed_cb(bt_gatt_client_h client, bt_gatt_client_service_change_type_e change_type, const char *service_uuid, void *user_data){
	dlog_print(DLOG_INFO, LOG_TAG, "gatt services changed on remote device");


	send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_CONNECTED_ID, "Cambiaron los servicios");


	int ret = bt_gatt_client_foreach_services(gatt_client, __bt_gatt_client_foreach_svc_cb, NULL);
	if (ret != BT_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "gatt fail to read services [%s]", bt_get_error_message(ret));
	}
	else{
		listen_all_characteristic_values_changed_in_remote_device();
	}
}


bool __bt_gatt_client_foreach_svc_cb(int total, int index, bt_gatt_h svc_handle, void *data) {
	int ret;
	char *uuid = NULL;

	dlog_print(DLOG_INFO, LOG_TAG, "gatt callback __bt_gatt_client_foreach_svc_cb");

	bt_gatt_get_uuid(svc_handle, &uuid);
	dlog_print(DLOG_INFO, LOG_TAG, "gatt service [%d / %d] uuid : (%s)", index, total, uuid);

	// g_free(uuid);
    
    /* Iterate over GATT characteristics */
	ret = bt_gatt_service_foreach_characteristics(svc_handle, __bt_gatt_client_foreach_chr_cb, NULL);
	if (ret != BT_ERROR_NONE) {
		dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_service_foreach_characteristics is failed : %s", bt_get_error_message(ret));
	}

	char* uuid_control = serviceNameToUUID(BT_EXT_CONTROL_SVC_ID);
	dlog_print(DLOG_INFO, LOG_TAG, "gatt listen_all_characteristic_values_changed_in_remote_device check: %s == %s", uuid, uuid_control);

	return true;
}

bool __bt_gatt_client_foreach_chr_cb(int total, int index, bt_gatt_h chr_handle, void *data) {
	int ret;
	char *uuid = NULL;

	dlog_print(DLOG_INFO, LOG_TAG, "gatt callback __bt_gatt_client_foreach_chr_cb");

	int r = bt_gatt_get_uuid(chr_handle, &uuid);

	//CONNECTION SUCCESS and tells to peripheral is paired
	if(r == BT_ERROR_NONE && !strcasecmp(uuid, characteristicNameToUUID(BLE_CHAR_CONNECTED_ID))){
		dlog_print(DLOG_INFO, LOG_TAG, "gatt connected. char uuid %s", uuid);
		send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_CONNECTED_ID, "Connected");
	}

	dlog_print(DLOG_INFO, LOG_TAG, "\t gatt [%d / %d] uuid : (%s)", index, total, uuid);

	return true;
}

void __bt_gatt_client_value_changed_cb(bt_gatt_h chr, char *value, int len, void *user_data){
    char *uuid = NULL;
    int i;

    bt_gatt_get_uuid(chr, &uuid);

    dlog_print(DLOG_INFO, LOG_TAG, "gatt value changed for characteristic [%s]", uuid);
    dlog_print(DLOG_INFO, LOG_TAG, "gatt value len [%d]", len);
    dlog_print(DLOG_INFO, LOG_TAG, "gatt value: %s", (char*) value);

    char* data_str = substr(value, 0, len);
    dlog_print(DLOG_INFO, LOG_TAG, "gatt value changed: %s", data_str);

    /* Launch services request received via GATT*/
    if(!strcasecmp(uuid, characteristicNameToUUID(BLE_CHAR_START_SENSORS_ID))){
        dlog_print(DLOG_INFO, LOG_TAG, "gatt value start characteristic value changed: %s", (char*) value);
        int value_int = atoi((char*)value);
        dlog_print(DLOG_INFO, LOG_TAG, "gatt value start characteristic value (int) changed: %d", value_int);
        
        dlog_print(DLOG_INFO, LOG_TAG, "launch services %d (int) - this int is going to be converted to (my_sensor_types_e) enumerate", value_int);
        send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, LAUNCH_ACTION, value_int);
    }
    else{
        dlog_print(DLOG_INFO, LOG_TAG, "gatt value start characteristic not: %s", value);
        
        /* CONNECTION SUCCESS received, and tells to peripheral we received via BLE*/
        if(!strncmp(data_str, BT_CONNECTED_ACTION, STRNCMP_LIMIT)){
            dlog_print(DLOG_INFO, LOG_TAG, "gatt connected action");
            send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_CONNECTED_ID, "Connected");
        }
        
        /* RECORD TIME MARK (LABEL DATA) request received via BLE by the peripheral*/
        else if(!strncmp(data_str, BT_RECORD_TIME_MARK_ACTION, STRNCMP_LIMIT)){
            dlog_print(DLOG_INFO, LOG_TAG, "gatt record time mark action");
            record_time_mark();
        }
        /* STOP sensors request received via BLE by the peripheral*/
        else if(!strncmp(data_str, BT_STOP_ACTION, STRNCMP_LIMIT)){
            dlog_print(DLOG_INFO, LOG_TAG, "gatt stop action");
            start_to_record_data = false;
            current_time_mark_counter = 0;
            send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, STOP_ONLY_SENSORS_ACTION);
        }
        /* DELETE sensor data request received via BLE by the peripheral*/
        else if(!strncmp(data_str, BT_DELETE_ACTION, STRNCMP_LIMIT)){
            dlog_print(DLOG_INFO, LOG_TAG, "gatt delete action");
            send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, DELETE_LOCAL_DATA, DELETE_LOCAL_DATA);
            send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_DELETE_ALL_SUCCEES_ID, "Datos eliminados");
        }
        /* HTTP post to sent data tu SERVER URL request received via BLE by the peripheral*/
        else if(!strncmp(data_str, BT_HTTP_POST_ACTION, STRNCMP_LIMIT)){
            dlog_print(DLOG_INFO, LOG_TAG, "gatt send data to cloud action");
            send_all_data_to_server();
        }
        else{
            dlog_print(DLOG_WARN, LOG_TAG, "gatt unrecognized action received");
        }
    }

    return;
}

bool send_value_to_device(char* serviceID, char* characteristicUUID, char* data){
	bool res = false;

	if(gatt_client != NULL){
		char* svc_uuid = serviceNameToUUID(serviceID);
		char* chr_uuid = characteristicNameToUUID(characteristicUUID);
		bt_gatt_h svc = NULL;
		bt_gatt_h chr = NULL;
//		bt_gatt_h desc = NULL;

		int ret = bt_gatt_client_get_service(gatt_client, svc_uuid, &svc);
		if (ret != BT_ERROR_NONE) {
			dlog_print(DLOG_ERROR, LOG_TAG, "%s gatt bt_gatt_client_get_service failed: %s", serviceID, bt_get_error_message(ret));
		}
		else{
			ret = bt_gatt_service_get_characteristic(svc, chr_uuid, &chr);
			if (ret != BT_ERROR_NONE) {
				dlog_print(DLOG_ERROR, LOG_TAG, "%s gatt bt_gatt_service_get_characteristic failed: %s", serviceID, bt_get_error_message(ret));
			}
			else{
				ret = __bt_gatt_client_set_value("str", data, chr);
				if (ret != BT_ERROR_NONE) {
				    dlog_print(DLOG_ERROR, LOG_TAG, "%s gatt bt_gatt_set_value failed: %s", serviceID, bt_get_error_message(ret));
				}
				else{
				    dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_set_value succeed. Data: %s", data);

					ret = bt_gatt_client_write_value(chr, __bt_gatt_client_write_complete_cb, NULL);

					if (ret != BT_ERROR_NONE) {
					    dlog_print(DLOG_ERROR, LOG_TAG, "bt_gatt_client_write_value failed: %d", bt_get_error_message(ret));
					}
					else{
					    dlog_print(DLOG_INFO, LOG_TAG, "gatt bt_gatt_client_write_value succeed. Data: %s", data);

						res = true;
					}
				}
			}
		}
	}
	return res;
}


int __bt_gatt_client_set_value(char *type, char *value, bt_gatt_h h){
    int ret;
    int s_val;
    unsigned int u_val;
    char *buf;
    int len;

    if (strcasecmp(type, "int8") == 0) {
        s_val = atoi(value);
        buf = (char *)&s_val;
        len = 1;
    } else if (strcasecmp(type, "int16") == 0) {
        s_val = atoi(value);
        buf = (char *)&s_val;
        len = 2;
    } else if (strcasecmp(type, "int32") == 0) {
        s_val = atoi(value);
        buf = (char *)&s_val;
        len = 4;
    } else if (strcasecmp(type, "uint8") == 0) {
        u_val = strtoul(value, NULL, 10);
        buf = (char *)&u_val;
        len = 1;
    } else if (strcasecmp(type, "uint16") == 0) {
        u_val = strtoul(value, NULL, 10);
        buf = (char *)&u_val;
        len = 2;
    } else if (strcasecmp(type, "uint32") == 0) {
        u_val = strtoul(value, NULL, 10);
        buf = (char *)&u_val;
        len = 4;
    } else if (strcasecmp(type, "str") == 0) {
        buf = value;
        len = strlen(buf);
    } else {
        return BT_ERROR_INVALID_PARAMETER;
    }

    ret = bt_gatt_set_value(h, buf, len);
    if (ret != BT_ERROR_NONE)
    		dlog_print(DLOG_ERROR, LOG_TAG, "gatt bt_gatt_set_value failed [%s]", bt_get_error_message(ret));

    return ret;
}

void __bt_gatt_client_write_complete_cb(int result, bt_gatt_h gatt_handle, void *data){
    char *uuid = NULL;

    bt_gatt_get_uuid(gatt_handle, &uuid);

    dlog_print(DLOG_INFO, LOG_TAG, "gatt write %s for uuid: (%s)",
               result == BT_ERROR_NONE ? "Success" : "Fail", uuid);

//    g_free(uuid);

    return;
}

void record_time_mark(){
	char* content[DATA_LINE_SIZE];
	char* date_str[30], time_str[30], timestamp_str[30];

	//obtener tiempo
	struct timeval curTime;
	gettimeofday(&curTime, NULL);
	unsigned long long totalseconds = curTime.tv_sec*1000LL + curTime.tv_usec/1000000LL;

	if(current_time_mark_counter == 0){
	    	start_to_record_data = true;
	    	initial_time_capture_str = malloc(1 + strlen(timestamp_str));
	    	sprintf(timestamp_str, "%llu", totalseconds);
	    	strcpy(initial_time_capture_str, timestamp_str);
	    dlog_print(DLOG_INFO, LOG_TAG, "header file timestamp initial %s", initial_time_capture_str);
	}

	current_time_mark_counter++;

	sprintf(content, "%llu,%d\n", totalseconds, current_time_mark_counter);
	send_value_to_device(BT_EXT_CONTROL_SVC_ID, BLE_CHAR_RECORDED_TIME_MARK_SUCCEES_ID, content);
	write_file_appending_content(TIME_MARKS_FILE_ID, content);
}

const char *bt_get_error_message(bt_error_e err)
{
    const char *errStr = NULL;

    switch (err)
    {
        case BT_ERROR_NONE:
            errStr = "BT_ERROR_NONE";
            break;
        case BT_ERROR_CANCELLED:
            errStr = "BT_ERROR_CANCELLED";
            break;
        case BT_ERROR_INVALID_PARAMETER:
            errStr = "BT_ERROR_INVALID_PARAMETER";
            break;
        case BT_ERROR_OUT_OF_MEMORY:
            errStr = "BT_ERROR_OUT_OF_MEMORY";
            break;
        case BT_ERROR_RESOURCE_BUSY:
            errStr = "BT_ERROR_RESOURCE_BUSY";
            break;
        case BT_ERROR_TIMED_OUT:
            errStr = "BT_ERROR_TIMED_OUT";
            break;
        case BT_ERROR_NOW_IN_PROGRESS:
            errStr = "BT_ERROR_NOW_IN_PROGRESS";
            break;
        case BT_ERROR_NOT_INITIALIZED:
            errStr = "BT_ERROR_NOT_INITIALIZED";
            break;
        case BT_ERROR_NOT_ENABLED:
            errStr = "BT_ERROR_NOT_ENABLED";
            break;
        case BT_ERROR_ALREADY_DONE:
            errStr = "BT_ERROR_ALREADY_DONE";
            break;
        case BT_ERROR_OPERATION_FAILED:
            errStr = "BT_ERROR_OPERATION_FAILED";
            break;
        case BT_ERROR_NOT_IN_PROGRESS:
            errStr = "BT_ERROR_NOT_IN_PROGRESS";
            break;
        case BT_ERROR_REMOTE_DEVICE_NOT_BONDED:
            errStr = "BT_ERROR_REMOTE_DEVICE_NOT_BONDED";
            break;
        case BT_ERROR_AUTH_REJECTED:
            errStr = "BT_ERROR_AUTH_REJECTED";
            break;
        case BT_ERROR_AUTH_FAILED:
            errStr = "BT_ERROR_AUTH_FAILED";
            break;
        case BT_ERROR_REMOTE_DEVICE_NOT_FOUND:
            errStr = "BT_ERROR_REMOTE_DEVICE_NOT_FOUND";
            break;
        case BT_ERROR_SERVICE_SEARCH_FAILED:
            errStr = "BT_ERROR_SERVICE_SEARCH_FAILED";
            break;
        case BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED:
            errStr = "BT_ERROR_REMOTE_DEVICE_NOT_CONNECTED";
            break;
        case BT_ERROR_PERMISSION_DENIED:
            errStr = "BT_ERROR_PERMISSION_DENIED";
            break;
        case BT_ERROR_SERVICE_NOT_FOUND:
            errStr = "BT_ERROR_SERVICE_NOT_FOUND";
            break;
        case BT_ERROR_NOT_SUPPORTED:
            errStr = "BT_ERROR_NOT_SUPPORTED";
            break;
        case BT_ERROR_QUOTA_EXCEEDED:
            errStr = "BT_ERROR_QUOTA_EXCEEDED";
            break;
        case BT_ERROR_NO_DATA:
            errStr = "BT_ERROR_NO_DATA";
            break;
        case BT_ERROR_AGAIN:
            errStr = "BT_ERROR_AGAIN";
            break;
        default:
            errStr = "NOT Defined";
            break;
    }

    return errStr;
}


char *uuidToServiceName(char *raw_data)
{
	bool found = false;
	int begin = 0;
	char *string = NULL;

	do
	{
		if(begin == (sizeof(GattServices) / sizeof(GattServices[0])))
		{
			string = "Unknown Service";
			break;
		}

		if(strcmp(raw_data, GattServices[begin][0]) != 0)
		{
			begin++;
		}
		else
		{
			string = GattServices[begin][1];
			found = true;
		}
	}while(found == false);

	return string;
}


char *uuidToCharacteristicName(char *raw_data)
{
	bool found = false;
	int begin = 0;
	char *string = NULL;

	do
	{
		if(begin == (sizeof(GattCharacteristics) / sizeof(GattCharacteristics[0])))
		{
			string = "Unknown Characteristic";
			break;
		}

		if(strcmp(raw_data, GattCharacteristics[begin][0]) != 0)
		{
			begin++;
		}
		else
		{
			string = GattCharacteristics[begin][1];
			found = true;
		}
	}while(found == false);

	return string;
}

char *serviceNameToUUID(char *raw_data)
{
	bool found = false;
	int begin = 0;
	char *string = NULL;

	do
	{
		if(begin == (sizeof(GattServices) / sizeof(GattServices[0])))
		{
			string = "Unknown Service";
			break;
		}

		if(strcmp(raw_data, GattServices[begin][1]) != 0)
		{
			begin++;
		}
		else
		{
			string = GattServices[begin][0];
			found = true;
		}
	}while(found == false);

	return string;
}


char *characteristicNameToUUID(char *raw_data)
{
	bool found = false;
	int begin = 0;
	char *string = NULL;

	do
	{
		if(begin == (sizeof(GattCharacteristics) / sizeof(GattCharacteristics[0])))
		{
			string = "Unknown Characteristic";
			break;
		}

		if(strcmp(raw_data, GattCharacteristics[begin][1]) != 0)
		{
			begin++;
		}
		else
		{
			string = GattCharacteristics[begin][0];
			found = true;
		}
	}while(found == false);

	return string;
}

