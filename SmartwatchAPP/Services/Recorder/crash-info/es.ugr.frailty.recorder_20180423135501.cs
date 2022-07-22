S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 19327
Date: 2018-04-23 13:55:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf762a648, r1   = 0xf7e7e1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7e7e1b8, r5   = 0x00012cd0
r6   = 0xf7e90e88, r7   = 0xf762a250
r8   = 0x000005e0, r9   = 0xf710d824
r10  = 0xf7e769d8, fp   = 0x00000000
ip   = 0xf7629030, sp   = 0xffab84c0
lr   = 0xf756d5d0, pc   = 0xf75699fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:    107912 KB
Buffers:     26252 KB
Cached:     139164 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7796 KB
VmRSS:        7792 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6ca4000 f6ca7000 r-xp /lib/libattr.so.1.1.0
f6cb0000 f6cb7000 r-xp /lib/libcrypt-2.13.so
f6ce7000 f6cea000 r-xp /lib/libcap.so.2.21
f6cf2000 f6cf4000 r-xp /usr/lib/libiri.so
f6cfc000 f6d19000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d22000 f6d26000 r-xp /usr/lib/libsmack.so.1.0.0
f6d30000 f6d32000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d3a000 f6d3f000 r-xp /usr/lib/libffi.so.5.0.10
f6d47000 f6d48000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d50000 f6d52000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d5a000 f6d5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d66000 f6d76000 r-xp /lib/libresolv-2.13.so
f6d7a000 f6d92000 r-xp /usr/lib/liblzma.so.5.0.3
f6d9a000 f6d9c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6da4000 f6dd3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ddc000 f6deb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6df4000 f6dfe000 r-xp /usr/lib/libsensord-shared.so
f6e07000 f6e3b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e44000 f6f17000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f22000 f6f38000 r-xp /lib/libz.so.1.2.5
f6f40000 f6f46000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f4f000 f6fc4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fce000 f6fe8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ff0000 f6ff6000 r-xp /lib/librt-2.13.so
f6fff000 f701d000 r-xp /usr/lib/libsystemd.so.0.4.0
f7027000 f7028000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7030000 f7035000 r-xp /usr/lib/libxdgmime.so.1.1.0
f703d000 f710d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f710e000 f7138000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7141000 f7158000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7160000 f71c9000 r-xp /lib/libm-2.13.so
f71d2000 f7266000 r-xp /usr/lib/libstdc++.so.6.0.16
f7279000 f727e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7286000 f728d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7295000 f72bf000 r-xp /usr/lib/libsensor.so.1.9.6
f72c8000 f7394000 r-xp /usr/lib/libxml2.so.2.7.8
f73a1000 f73a3000 r-xp /usr/lib/libiniparser.so.0
f73ac000 f73af000 r-xp /usr/lib/libbundle.so.0.1.22
f73b7000 f73bd000 r-xp /usr/lib/libappsvc.so.0.1.0
f73c5000 f73e8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f73f0000 f7431000 r-xp /usr/lib/libeina.so.1.7.99
f743a000 f7451000 r-xp /usr/lib/libecore.so.1.7.99
f7468000 f7471000 r-xp /usr/lib/libvconf.so.0.2.45
f7479000 f748d000 r-xp /lib/libpthread-2.13.so
f7498000 f74a5000 r-xp /usr/lib/libaul.so.0.1.0
f74af000 f74b1000 r-xp /lib/libdl-2.13.so
f74ba000 f74c5000 r-xp /lib/libunwind.so.8.0.1
f74f2000 f74fa000 r-xp /lib/libgcc_s-4.6.so.1
f74fb000 f761f000 r-xp /lib/libc-2.13.so
f762d000 f762f000 r-xp /usr/lib/libdlog.so.0.0.0
f7637000 f7643000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f764c000 f7651000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7659000 f765d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7666000 f7668000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7671000 f7674000 r-xp /usr/lib/libappcore-agent.so.1.1
f7692000 f76af000 r-xp /lib/ld-2.13.so
f76b8000 f76bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f76bb000 f76bf000 r-xp /usr/lib/libsys-assert.so
f7e6c000 f7eba000 rw-p [heap]
ffa9a000 ffabb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19327)
Call Stack Count: 1
 0: (0xf75699fc) [/lib/libc.so.6] + 0x6e9fc
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
SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:52.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491692300,000000, pattern:[H:mm][0;m
04-23 13:54:52.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:52.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:52.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:52.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:52.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:52.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:52.311+0200 W/SHealthCommon( 3087): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 13:54:52.481+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 13:54:52.561+0200 I/HealthDataService( 2940): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 13:54:52.601+0200 I/healthData( 3087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 13:54:53.071+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [21368.182440] layer(0x47f2c0) now usable
04-23 13:54:53.071+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [21368.182471] layer[0x47ee10]zpos[1]
04-23 13:54:53.071+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [21368.182499] layer(0x47f310) now usable
04-23 13:54:53.071+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [21368.182510] layer[0x47ef30]zpos[2]
04-23 13:54:53.071+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [21368.182524] dpms[0 -> 3]sync[1]
04-23 13:54:53.071+0200 I/TDM     ( 1945): 
04-23 13:54:53.081+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 13:54:53.081+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:54:53.081+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 13:54:53.081+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 13:54:53.081+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 13:54:53.081+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 13:54:53.081+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 1
04-23 13:54:53.081+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 1
04-23 13:54:53.081+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] reserved app is running now. raise it.
04-23 13:54:53.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:53.091+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:54:53.091+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1449) > [_pre_lcd_off:1449] [com.samsung.shealth.alert] is now running & will raise when lcd on.
04-23 13:54:53.101+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 13:54:53.101+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 13:54:53.101+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 13:54:53.101+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 13:54:53.101+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 13:54:53.101+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 13:54:53.101+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 13:54:53.121+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 13:54:53.121+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 13:54:53.121+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 13:54:53.121+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 13:54:53.201+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [21368.310860] dpms[3 -> 3]done
04-23 13:54:53.201+0200 I/TDM     ( 1945): 
04-23 13:54:53.211+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:54:53.211+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 13:54:53.211+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 13:54:53.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[com.samsung.shealth.alert] alpm mode[0]
04-23 13:54:53.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 1
04-23 13:54:53.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1525) > [_post_lcd_off:1525] raise [com.samsung.shealth.alert] when lcd off after 20 sec.
04-23 13:54:53.211+0200 E/ALARM_MANAGER( 2693): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(23-4-2018, 13:55:13), repeat(1), interval(20), type(-1073741822)
04-23 13:54:53.211+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:54:53.221+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2693].
04-23 13:54:53.241+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1847065215, next duetime: 1524484513
04-23 13:54:53.241+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1847065215)
04-23 13:54:53.241+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1524493503), due_time(1524484513)
04-23 13:54:53.251+0200 W/SHealthCommon(17411): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:54:53.251+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: PAUSE State: RUNNING
04-23 13:54:53.251+0200 I/CAPI_APPFW_APPLICATION(17411): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-23 13:54:53.251+0200 W/WSLib   (17411): Application.cpp: SOnAppPause(315) > [1;35m ###[0;m
04-23 13:54:53.251+0200 W/SHealthCommon(17411): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:54:53.251+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:54:53.251+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:54:53.251+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:54:53.261+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:54:53.261+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 13:54:53.261+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 11:55:13 (UTC).
04-23 13:54:53.261+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 13:54:53.271+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491693292,000000, pattern:[H:mm][0;m
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:53.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:53.291+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 13:54:53.291+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 13:54:53.291+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:54:53.291+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:54:53.291+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:54:53.291+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
04-23 13:54:53.541+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf818b938) is deleting
04-23 13:54:53.541+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf818b938) is deleting
04-23 13:54:53.541+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf818ac00) is deleting
04-23 13:54:53.541+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf818ac00) is deleting
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491694292,000000, pattern:[H:mm][0;m
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:54.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491695293,000000, pattern:[H:mm][0;m
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:55.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491696297,000000, pattern:[H:mm][0;m
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:56.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491697297,000000, pattern:[H:mm][0;m
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:57.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:58.261+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: MEM_FLUSH State: PAUSED
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491698294,000000, pattern:[H:mm][0;m
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:58.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:59.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491699298,000000, pattern:[H:mm][0;m
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:59.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:59.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:59.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:55:00.281+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:55:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491700301,000000, pattern:[H:mm][0;m
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:55:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:55:00.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:55:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:55][0;m
04-23 13:55:00.311+0200 W/SHealthService( 3087): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 13:55:00.311+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(pedometer_goal_achieve_percents) error
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 13:55:00.311+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(best_step_goal) error
04-23 13:55:00.311+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 13:55:00.331+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 13:55:00.341+0200 I/HealthDataService( 2940): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 13:55:00.361+0200 I/healthData( 3087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 13:55:00.361+0200 W/SHealthService( 3087): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 13:55:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:55:01.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:55:01.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:55:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491701296,000000, pattern:[H:mm][0;m
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:55:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:55:01.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:55:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:55][0;m
04-23 13:55:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:55:01.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:55:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:55:01.311+0200 I/utils   (17422): specific action
04-23 13:55:01.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:55:01.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:55:01.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:55:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:55:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:55:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:55:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:55:01.311+0200 I/httppostreq(17422): internet available
04-23 13:55:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:55:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:55:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:55:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:55:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:55:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:55:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:55:01.331+0200 I/utils   (17419): specific action
04-23 13:55:01.331+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:55:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:55:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:55:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:55:01.331+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:55:01.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:55:01.331+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:55:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:55:01.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:55:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19319
04-23 13:55:01.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:55:01.391+0200 E/CAPI_APPFW_APPLICATION(19319): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:55:01.391+0200 E/CAPI_APPFW_APPLICATION(19319): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:55:01.391+0200 I/utils   (19319): trying to start service: es.ugr.frailty.accelerometer
04-23 13:55:01.391+0200 I/utils   (19319): es.ugr.frailty.accelerometer sensor supported
04-23 13:55:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19319
04-23 13:55:01.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(19319) type(svcapp) bg(0)
04-23 13:55:01.401+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19319]
04-23 13:55:01.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19319) was created
04-23 13:55:01.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19319)
04-23 13:55:01.421+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:55:01.421+0200 I/servicemanager(17419): App control destroyed.
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 0
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 1
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 2
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 3
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 4
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 5
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 6
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:55:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:55:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:55:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 7
04-23 13:55:01.421+0200 I/servicemanager(17419): deleting timer 8
04-23 13:55:01.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:55:01.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:55:01.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:55:01.441+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19327
04-23 13:55:01.441+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:55:01.481+0200 E/CAPI_APPFW_APPLICATION(19327): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:55:01.491+0200 E/CAPI_APPFW_APPLICATION(19327): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:55:01.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19327
04-23 13:55:01.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(19327) type(svcapp) bg(0)
04-23 13:55:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19319
04-23 13:55:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.511+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19327]
04-23 13:55:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19319
04-23 13:55:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:01.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19327
04-23 13:55:01.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.651+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19327
04-23 13:55:01.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:01.691+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19327) was created
04-23 13:55:01.691+0200 I/utils   (19327): specific action
04-23 13:55:01.691+0200 I/recorder(19327): obteniendo datos locales...
04-23 13:55:01.711+0200 I/recorder(19327): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:55:01.711+0200 I/recorder(19327): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:55:01.741+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19327)
04-23 13:55:01.741+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:55:01.741+0200 I/utils   (19319): es.ugr.frailty.accelerometer listener started
04-23 13:55:01.741+0200 I/accelerometer(19319): stopping es.ugr.frailty.accelerometer service
04-23 13:55:01.741+0200 E/CAPI_APPFW_APP_CONTROL(19319): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:55:01.741+0200 E/accelerometer(19319): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:55:01.741+0200 I/CAPI_APPFW_APPLICATION(19319): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:55:01.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:55:01.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:55:01.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19319
04-23 13:55:01.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:01.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:55:01.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19327
04-23 13:55:02.051+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:55:02.061+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:55:02.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:55:02.111+0200 I/accelerometer(19319): es.ugr.frailty.accelerometer listener destroyed
04-23 13:55:02.151+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1119327726563152448450
