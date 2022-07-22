S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 5479
Date: 2018-04-23 14:30:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7016648, r1   = 0xf72151b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf72151b8, r5   = 0x00012cd0
r6   = 0xf7227e88, r7   = 0xf7016250
r8   = 0x00000618, r9   = 0xf6af9824
r10  = 0xf720d9d8, fp   = 0x00000000
ip   = 0xf7015030, sp   = 0xffa19620
lr   = 0xf6f595d0, pc   = 0xf6f559fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     66768 KB
Buffers:     36780 KB
Cached:     219852 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6690000 f6693000 r-xp /lib/libattr.so.1.1.0
f669c000 f66a3000 r-xp /lib/libcrypt-2.13.so
f66d3000 f66d6000 r-xp /lib/libcap.so.2.21
f66de000 f66e0000 r-xp /usr/lib/libiri.so
f66e8000 f6705000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f670e000 f6712000 r-xp /usr/lib/libsmack.so.1.0.0
f671c000 f671e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6726000 f672b000 r-xp /usr/lib/libffi.so.5.0.10
f6733000 f6734000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f673c000 f673e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6746000 f6748000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6752000 f6762000 r-xp /lib/libresolv-2.13.so
f6766000 f677e000 r-xp /usr/lib/liblzma.so.5.0.3
f6786000 f6788000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6790000 f67bf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67c8000 f67d7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67e0000 f67ea000 r-xp /usr/lib/libsensord-shared.so
f67f3000 f6827000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6830000 f6903000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f690e000 f6924000 r-xp /lib/libz.so.1.2.5
f692c000 f6932000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f693b000 f69b0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ba000 f69d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69dc000 f69e2000 r-xp /lib/librt-2.13.so
f69eb000 f6a09000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a13000 f6a14000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a1c000 f6a21000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a29000 f6af9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6afa000 f6b24000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b2d000 f6b44000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b4c000 f6bb5000 r-xp /lib/libm-2.13.so
f6bbe000 f6c52000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c65000 f6c6a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c72000 f6c79000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c81000 f6cab000 r-xp /usr/lib/libsensor.so.1.9.6
f6cb4000 f6d80000 r-xp /usr/lib/libxml2.so.2.7.8
f6d8d000 f6d8f000 r-xp /usr/lib/libiniparser.so.0
f6d98000 f6d9b000 r-xp /usr/lib/libbundle.so.0.1.22
f6da3000 f6da9000 r-xp /usr/lib/libappsvc.so.0.1.0
f6db1000 f6dd4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ddc000 f6e1d000 r-xp /usr/lib/libeina.so.1.7.99
f6e26000 f6e3d000 r-xp /usr/lib/libecore.so.1.7.99
f6e54000 f6e5d000 r-xp /usr/lib/libvconf.so.0.2.45
f6e65000 f6e79000 r-xp /lib/libpthread-2.13.so
f6e84000 f6e91000 r-xp /usr/lib/libaul.so.0.1.0
f6e9b000 f6e9d000 r-xp /lib/libdl-2.13.so
f6ea6000 f6eb1000 r-xp /lib/libunwind.so.8.0.1
f6ede000 f6ee6000 r-xp /lib/libgcc_s-4.6.so.1
f6ee7000 f700b000 r-xp /lib/libc-2.13.so
f7019000 f701b000 r-xp /usr/lib/libdlog.so.0.0.0
f7023000 f702f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7038000 f703d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7045000 f7049000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7052000 f7054000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f705d000 f7060000 r-xp /usr/lib/libappcore-agent.so.1.1
f707e000 f709b000 r-xp /lib/ld-2.13.so
f70a4000 f70a7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f70a7000 f70ab000 r-xp /usr/lib/libsys-assert.so
f7203000 f7251000 rw-p [heap]
ff9fb000 ffa1c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5479)
Call Stack Count: 1
 0: (0xf6f559fc) [/lib/libc.so.6] + 0x6e9fc
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: recorder
App ID: es.ugr.frailty.recorder
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ing : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 14:30:55.251+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 14:30:55.251+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:30:55.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 14:30:55.251+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 14:30:55.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -145282292[0;m
04-23 14:30:55.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 14:30:55.251+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 14:30:55.251+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 14:30:55.261+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [550.921562] layer(0x5ac2c0) not usable
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [550.921587] layer(0x5ac2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [550.921608] layer[0x5abe10]zpos[1]
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [550.921675] layer(0x5ac250) not usable
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [550.921691] layer(0x5ac250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [550.921710] layer[0x5abcf0]zpos[0]
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [550.921741] layer(0x5ac310) not usable
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [550.921756] layer(0x5ac310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 14:30:55.261+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [550.921774] layer[0x5abf30]zpos[2]
04-23 14:30:55.261+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 14:30:55.261+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:30:55.261+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(fg) type(watchapp)
04-23 14:30:55.261+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppResume(560) > 
04-23 14:30:55.261+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:55.261+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:55.261+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:30:55.281+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:30:55.281+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 14:30:55.281+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 14:30:55.281+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:30:55.281+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 14:30:55.281+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 14:30:55.291+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 14:30:55.291+0200 I/watchface-viewer( 2864): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 14:30:55.301+0200 W/SHealthService( 3091): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1006[0;m
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(75), length(2)
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 75%
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 75, isCharging: 0
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_75
04-23 14:30:55.301+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 14:30:55.331+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 14:30:55.331+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 14:30:55.381+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 14:30:55.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:55.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:55.431+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 14:30:55.431+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 0
04-23 14:30:55.431+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 14:30:55.451+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 14:30:55.451+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 14:30:55.461+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 14:30:55.461+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 14:30:55.481+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:30:55.481+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:30:55.491+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 14:30:55.491+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 14:30:55.511+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_period error
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
04-23 14:30:55.521+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : inactive_test_mode_on error
04-23 14:30:55.521+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextSettingTimeUpdatedCB(885) > [1;40;33minactive state change : => PEDOMETER_INACTIVE_STATE_10MIN_PRECAUTION[0;m
04-23 14:30:55.531+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 14:30:55.541+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 14:30:55.541+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:30:55.551+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:30:55.561+0200 W/SHealthCommon( 3091): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 14:30:55.581+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 14:30:55.581+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 14:30:55.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:55.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:55.601+0200 W/healthData( 2864): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
04-23 14:30:55.611+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 14:30:55.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:55.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:55.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:55.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:56.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:56.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:30:56.241+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.241+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:30:56.241+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 14:30:56.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:56.261+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 14:30:56.261+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:30:56.261+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:30:56.261+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:30:56.261+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:30:56.261+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:30:56.271+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.271+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:30:56.271+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:30:56.271+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:30:56.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:30:56.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:30:56.271+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:30:56.271+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.271+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:30:56.281+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.281+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:30:56.281+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:30:56.281+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 14:30:56.291+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:30:56.291+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:30:56.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:56.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:56.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:56.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:56.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:56.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:56.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:56.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:57.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:57.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:57.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:57.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:57.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:57.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:57.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:57.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:57.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:30:57.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:57.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:30:57.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:30:57.991+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:30:57.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:30:58.001+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:58.001+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:58.001+0200 I/utils   ( 4443): specific action
04-23 14:30:58.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:30:58.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:30:58.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:30:58.001+0200 I/httppostreq( 4443): internet connection type...
04-23 14:30:58.001+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:30:58.001+0200 I/httppostreq( 4443): internet available
04-23 14:30:58.001+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:30:58.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:30:58.001+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:30:58.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:30:58.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:30:58.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:30:58.021+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:30:58.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:30:58.021+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:30:58.021+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:30:58.021+0200 I/utils   ( 4440): specific action
04-23 14:30:58.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:30:58.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:30:58.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:30:58.021+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:30:58.021+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:30:58.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:58.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:30:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5453
04-23 14:30:58.041+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:30:58.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5453
04-23 14:30:58.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5453) type(svcapp) bg(0)
04-23 14:30:58.091+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5453)
04-23 14:30:58.091+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:30:58.091+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:30:58.091+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:30:58.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5453]
04-23 14:30:58.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:58.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:30:58.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5456
04-23 14:30:58.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:30:58.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5456
04-23 14:30:58.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5456) type(svcapp) bg(0)
04-23 14:30:58.181+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5456)
04-23 14:30:58.181+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:30:58.181+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:30:58.181+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:30:58.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.181+0200 E/CAPI_APPFW_APPLICATION( 5453): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.181+0200 E/CAPI_APPFW_APPLICATION( 5453): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5456]
04-23 14:30:58.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:58.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5453
04-23 14:30:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.201+0200 I/utils   ( 5453): trying to start service: es.ugr.frailty.accelerometer
04-23 14:30:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5453
04-23 14:30:58.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:58.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:30:58.211+0200 I/utils   ( 5453): es.ugr.frailty.accelerometer sensor supported
04-23 14:30:58.221+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:30:58.231+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5461
04-23 14:30:58.241+0200 I/utils   ( 5453): es.ugr.frailty.accelerometer listener started
04-23 14:30:58.241+0200 I/accelerometer( 5453): stopping es.ugr.frailty.accelerometer service
04-23 14:30:58.241+0200 E/CAPI_APPFW_APP_CONTROL( 5453): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.241+0200 E/accelerometer( 5453): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:30:58.241+0200 I/CAPI_APPFW_APPLICATION( 5453): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:30:58.241+0200 E/CAPI_APPFW_APPLICATION( 5456): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.241+0200 E/CAPI_APPFW_APPLICATION( 5456): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.241+0200 I/utils   ( 5456): trying to start service: es.ugr.frailty.gyroscope
04-23 14:30:58.261+0200 I/utils   ( 5456): es.ugr.frailty.gyroscope sensor supported
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5461
04-23 14:30:58.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5461) type(svcapp) bg(0)
04-23 14:30:58.281+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5461)
04-23 14:30:58.281+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5453) was created
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5456) was created
04-23 14:30:58.281+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:30:58.281+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:30:58.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:30:58.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:30:58.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:30:58.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:30:58.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:30:58.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:30:58.281+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.281+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:30:58.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:30:58.301+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5461]
04-23 14:30:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:30:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:30:58.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:30:58.311+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:30:58.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:30:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5456
04-23 14:30:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:30:58.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:30:58.321+0200 E/CAPI_APPFW_APPLICATION( 5461): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.321+0200 E/CAPI_APPFW_APPLICATION( 5461): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.321+0200 I/utils   ( 5461): trying to start service: es.ugr.frailty.heartrate
04-23 14:30:58.331+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5479
04-23 14:30:58.331+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:30:58.331+0200 I/utils   ( 5461): es.ugr.frailty.heartrate sensor supported
04-23 14:30:58.351+0200 I/utils   ( 5461): es.ugr.frailty.heartrate listener started
04-23 14:30:58.351+0200 I/heartrate( 5461): stopping es.ugr.frailty.heartrate service
04-23 14:30:58.351+0200 E/CAPI_APPFW_APP_CONTROL( 5461): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.351+0200 E/heartrate( 5461): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:30:58.351+0200 I/CAPI_APPFW_APPLICATION( 5461): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:30:58.381+0200 E/CAPI_APPFW_APPLICATION( 5479): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.381+0200 E/CAPI_APPFW_APPLICATION( 5479): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5479
04-23 14:30:58.381+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5479) type(svcapp) bg(0)
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5461) was created
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5479) was created
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:30:58.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:30:58.381+0200 I/utils   ( 5479): specific action
04-23 14:30:58.381+0200 I/recorder( 5479): obteniendo datos locales...
04-23 14:30:58.391+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5479]
04-23 14:30:58.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:58.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:58.391+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5479)
04-23 14:30:58.391+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:30:58.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5461
04-23 14:30:58.431+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:30:58.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.441+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:30:58.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5456
04-23 14:30:58.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.471+0200 I/utils   ( 5456): es.ugr.frailty.gyroscope listener started
04-23 14:30:58.471+0200 I/gyroscope( 5456): stopping es.ugr.frailty.gyroscope service
04-23 14:30:58.471+0200 E/CAPI_APPFW_APP_CONTROL( 5456): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:30:58.471+0200 E/gyroscope( 5456): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:30:58.471+0200 I/CAPI_APPFW_APPLICATION( 5456): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:30:58.471+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5479
04-23 14:30:58.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:30:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:30:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.491+0200 I/recorder( 5479): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:30:58.491+0200 I/recorder( 5479): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:30:58.501+0200 W/SHealthService( 3091): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1006[0;m
04-23 14:30:58.521+0200 I/accelerometer( 5453): es.ugr.frailty.accelerometer listener destroyed
04-23 14:30:58.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:30:58.571+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5461
04-23 14:30:58.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:30:58.581+0200 W/SHealthService( 3091): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1004[0;m
04-23 14:30:58.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:30:58.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:30:58.611+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1105479726563152448665
