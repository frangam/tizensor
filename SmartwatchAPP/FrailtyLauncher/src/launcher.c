#include "../inc/launcher.h"


typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *list;
} appdata_s;

static bool first_resume = true;


//Callback de lanzamiento del servicio MANAGER
static void launch_service_cb(void *data, Evas_Object *obj, void *event_info)
{
	//	obj-> //CAMBIAR NOMBRE AL BOTON Y AL BOTON STOP
	//lanzamos el servicio controlador de todos
//	dlog_print(DLOG_INFO, LOG_TAG, "launch service %s", SERVICE_MANAGER_ID);

	//lanzamos recorder y http services desde el inicio de la creacion de la app
//	send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
//	send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
//	send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
//	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
	ui_app_exit();
}


static void stop_sensors_cb(void *data, Evas_Object *obj, void *event_info)
{
//	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
//	send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
//	send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
//	send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
	ui_app_exit();
}

//Callback para eliminar datos
static void delete_service_cb(void *data, Evas_Object *obj, void *event_info)
{
//	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, DELETE_LOCAL_DATA, DELETE_DATA_AND_CLOSE);
	ui_app_exit();
}

static void send_data_to_server_cb(void *data, Evas_Object *obj, void *event_info)
{
//	obj-> //CAMBIAR NOMBRE AL BOTON
//	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, CHECK_INTERNET_ACTION);
    ui_app_exit();
}

static void close_app_cb(void *data, Evas_Object *obj, void *event_info)
{
//	send_message_to_service_with_data(SERVICE_MANAGER_ID, LOG_TAG, SERVICE_ACTION, STOP_ALL_ACTION);
//	send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
//	send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
//	send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, STOP_ACTION);
	ui_app_exit();
}


static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* List of buttons */
	ad->list = elm_list_add(ad->conform);
//	elm_list_item_append (ad->list, "Start", NULL, NULL, launch_service_cb, NULL);
//	elm_list_item_append (ad->list, "Stop", NULL, NULL, stop_sensors_cb, NULL);
//	//elm_list_item_append (ad->list, "Delete", NULL, NULL, delete_service_cb, NULL);
//	elm_list_item_append (ad->list, "Close", NULL, NULL, close_app_cb, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "Send To Server", NULL, NULL, send_data_to_server_cb, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "", NULL, NULL, NULL, NULL);
	elm_list_item_append (ad->list, "UGR", NULL, NULL, NULL, NULL);
//	elm_list_item_append (ad->list, "Delete", NULL, NULL, delete_service_cb, NULL);
	elm_object_content_set(ad->conform, ad->list);
	evas_object_show(ad->list);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}



static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
//	sensordata_s* sd = (sensordata_s*) data;
	appdata_s *ad = data;
//	sd->serviceID = MYSERVICELAUNCHER_APP_ID;
//	sd->serviceTAG = LOG_TAG;

	create_base_gui(ad);


//	sensors = malloc(NUM_SENSORS * sizeof *sensors);

//	sensors = &sensors_array;


	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */

}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
	dlog_print(DLOG_INFO, LOG_TAG, "app_resume");

	//primera vez que se muestra la app y arrancamos los serivicios
	if(first_resume){
		first_resume = false;
		create_gatt_client();
//		mqtt_create();
//		send_message_to_service_with_data(HTTPPOSTREQ_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
//		send_message_to_service_with_data(RECORDER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
//		send_message_to_service_with_data(BLUETOOTH_TRANSFER_SERVICE_ID, LOG_TAG, SERVICE_ACTION, LAUNCH_ACTION);
	}
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
	first_resume = true;
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	char ad[50] = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
