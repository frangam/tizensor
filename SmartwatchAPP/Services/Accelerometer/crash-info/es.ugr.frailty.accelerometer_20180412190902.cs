S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 9275
Date: 2018-04-12 19:09:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf7

Register Information
r0   = 0x000000f7, r1   = 0xffa62697
r2   = 0x00000000, r3   = 0x00000002
r4   = 0x00000031, r5   = 0xfffffffd
r6   = 0x00000000, r7   = 0x000000f7
r8   = 0xf74c24c0, r9   = 0x00000002
r10  = 0xffa62696, fp   = 0x00000000
ip   = 0x00000039, sp   = 0xffa62604
lr   = 0xf742886c, pc   = 0xf740c250
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     55432 KB
Buffers:     49376 KB
Cached:     222840 KB
VmPeak:      43984 KB
VmSize:      43980 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7268 KB
VmRSS:        7268 KB
VmData:      34152 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9275 TID = 9275
9275 9284 9285 9286 9287 

Maps Information
f4b46000 f5345000 rw-p [stack:9287]
f5346000 f5b45000 rw-p [stack:9286]
f5b46000 f6345000 rw-p [stack:9285]
f6346000 f6b49000 rw-p [stack:9284]
f6b49000 f6b4c000 r-xp /lib/libattr.so.1.1.0
f6b54000 f6b5b000 r-xp /lib/libcrypt-2.13.so
f6b8c000 f6b8f000 r-xp /lib/libcap.so.2.21
f6b97000 f6b99000 r-xp /usr/lib/libiri.so
f6ba1000 f6ba3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bab000 f6bad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bb6000 f6c82000 r-xp /usr/lib/libxml2.so.2.7.8
f6c90000 f6cad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cb6000 f6cba000 r-xp /usr/lib/libsmack.so.1.0.0
f6cc3000 f6cd9000 r-xp /lib/libz.so.1.2.5
f6ce1000 f6ce3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ceb000 f6cf0000 r-xp /usr/lib/libffi.so.5.0.10
f6cf8000 f6cf9000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d01000 f6d11000 r-xp /lib/libresolv-2.13.so
f6d15000 f6d2d000 r-xp /usr/lib/liblzma.so.5.0.3
f6d35000 f6d37000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d3f000 f6d59000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d61000 f6d90000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d99000 f6da8000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db1000 f6dbb000 r-xp /usr/lib/libsensord-shared.so
f6dc4000 f6df8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e01000 f6ed4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6edf000 f6ee5000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6eee000 f6f63000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f6d000 f6f73000 r-xp /lib/librt-2.13.so
f6f7c000 f6f9a000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fa4000 f6fa5000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fad000 f6fd0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fd8000 f6fdd000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fe5000 f70b5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70b6000 f70e0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70e9000 f7100000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7108000 f7171000 r-xp /lib/libm-2.13.so
f717a000 f720e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7221000 f7226000 r-xp /usr/lib/libctx-client.so.0.8.3
f722e000 f7235000 r-xp /usr/lib/libctx-shared.so.0.8.3
f723d000 f7267000 r-xp /usr/lib/libsensor.so.1.9.6
f7270000 f7273000 r-xp /usr/lib/libbundle.so.0.1.22
f727b000 f7281000 r-xp /usr/lib/libappsvc.so.0.1.0
f7289000 f72ca000 r-xp /usr/lib/libeina.so.1.7.99
f72d3000 f72ea000 r-xp /usr/lib/libecore.so.1.7.99
f7301000 f730a000 r-xp /usr/lib/libvconf.so.0.2.45
f7312000 f7326000 r-xp /lib/libpthread-2.13.so
f7331000 f733e000 r-xp /usr/lib/libaul.so.0.1.0
f7348000 f734a000 r-xp /lib/libdl-2.13.so
f7353000 f735e000 r-xp /lib/libunwind.so.8.0.1
f738b000 f7393000 r-xp /lib/libgcc_s-4.6.so.1
f7394000 f74b8000 r-xp /lib/libc-2.13.so
f74c6000 f74c8000 r-xp /usr/lib/libdlog.so.0.0.0
f74d0000 f74dc000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e5000 f74e9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f2000 f74f5000 r-xp /usr/lib/libappcore-agent.so.1.1
f7513000 f7530000 r-xp /lib/ld-2.13.so
f7539000 f753b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f753b000 f753f000 r-xp /usr/lib/libsys-assert.so
f7884000 f78c6000 rw-p [heap]
ffa44000 ffa65000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9275)
Call Stack Count: 1
 0: memcpy + 0xd0 (0xf740c250) [/lib/libc.so.6] + 0x78250
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: accelerometer
App ID: es.ugr.frailty.accelerometer
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
et(645) > app_appcore_reset
04-12 19:08:55.179+0200 I/APP_CORE( 9222): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-12 19:08:55.179+0200 I/APP_CORE( 9222): appcore-efl.c: __do_app(524) > [APP 9222] Initial Launching, call the resume_cb
04-12 19:08:55.179+0200 I/CAPI_APPFW_APPLICATION( 9222): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 19:08:55.189+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-12 19:08:55.199+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:08:55.199+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:08:55.209+0200 W/APP_CORE( 9222): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(1)
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.279+0200 I/APP_CORE( 9222): appcore-efl.c: __do_app(453) > [APP 9222] Event: RESUME State: RUNNING
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(326) > appcore paused manually
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): main.c: home_appcore_pause(515) > Home Appcore Paused
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.279+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8477e70
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8477e70, elm_layout, func : 0xf76d3d05
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf8477e70, activated : 1
04-12 19:08:55.279+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 19:08:55.279+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:08:55.279+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 19:08:55.289+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:08:55.289+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 19:08:55.289+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 19:08:55.289+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 19:08:55.299+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:08:55.309+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[9222] goes to (3)
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:08:55.309+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:08:55.309+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:08:55.309+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:08:55.309+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(9222) status(fg) type(uiapp)
04-12 19:08:55.309+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:08:55.309+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
04-12 19:08:55.319+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:08:55.319+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: PAUSE State: RUNNING
04-12 19:08:55.319+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 19:08:55.319+0200 W/W_HOME  ( 2742): main.c: _appcore_pause_cb(488) > appcore pause
04-12 19:08:55.319+0200 E/W_HOME  ( 2742): main.c: _pause_cb(466) > paused already
04-12 19:08:55.319+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 19:08:55.319+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:08:55.319+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 19:08:55.329+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 19:08:55.329+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:08:55.349+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-12 19:08:55.669+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 19:08:55.819+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 19:08:55.939+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 19:08:55.989+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:08:56.089+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:56.099+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9222
04-12 19:08:56.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:56.109+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:08:56.129+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 19:08:56.149+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:56.159+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9222
04-12 19:08:56.159+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:56.159+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 19:08:56.169+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 19:08:56.189+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 19:08:56.269+0200 I/AUL_PAD ( 9258): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 19:08:59.449+0200 E/EFL     ( 9222): ecore_x<9222> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=12604711 button=1
04-12 19:08:59.449+0200 E/EFL     ( 9222): elementary<9222> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7be9fc0 : elm_list] mouse move
04-12 19:08:59.529+0200 E/EFL     ( 9222): ecore_x<9222> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=12604796 button=1
04-12 19:08:59.529+0200 W/AUL     ( 9222): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:08:59.539+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:08:59.539+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 9222
04-12 19:08:59.549+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 9261
04-12 19:08:59.549+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:08:59.569+0200 E/CAPI_APPFW_APPLICATION( 9261): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.569+0200 E/CAPI_APPFW_APPLICATION( 9261): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.569+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:08:59.599+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9261
04-12 19:08:59.599+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(9261) type(svcapp) bg(0)
04-12 19:08:59.599+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:08:59.599+0200 W/AUL     ( 9222): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9261)
04-12 19:08:59.599+0200 I/utils   ( 9222): es.ugr.frailty.servicemanager launch request sent!
04-12 19:08:59.599+0200 I/utils   ( 9222): App control destroyed.
04-12 19:08:59.599+0200 I/CAPI_APPFW_APPLICATION( 9222): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:08:59.599+0200 I/CAPI_APPFW_APPLICATION( 9222): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:08:59.609+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9261]
04-12 19:08:59.609+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 9261
04-12 19:08:59.619+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 9264
04-12 19:08:59.619+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:08:59.659+0200 E/CAPI_APPFW_APPLICATION( 9264): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.659+0200 E/CAPI_APPFW_APPLICATION( 9264): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.669+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9264
04-12 19:08:59.669+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(9264) type(svcapp) bg(0)
04-12 19:08:59.669+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (9261) was created
04-12 19:08:59.669+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (9264) was created
04-12 19:08:59.669+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.679+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9264]
04-12 19:08:59.689+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9264)
04-12 19:08:59.689+0200 I/servicemanager( 9261): es.ugr.frailty.httppostreq launch request sent!
04-12 19:08:59.689+0200 I/servicemanager( 9261): App control destroyed.
04-12 19:08:59.689+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:08:59.689+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9261
04-12 19:08:59.689+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.699+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9261
04-12 19:08:59.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:08:59.709+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 9261
04-12 19:08:59.719+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:08:59.719+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 9265
04-12 19:08:59.739+0200 E/CAPI_APPFW_APPLICATION( 9265): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.739+0200 E/CAPI_APPFW_APPLICATION( 9265): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:08:59.749+0200 W/CAPI_APPFW_APP_CONTROL( 9265): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.749+0200 W/CAPI_APPFW_APP_CONTROL( 9265): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.769+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9265
04-12 19:08:59.769+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(9265) type(svcapp) bg(0)
04-12 19:08:59.769+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.769+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (9265) was created
04-12 19:08:59.779+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.779+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9265)
04-12 19:08:59.779+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9265]
04-12 19:08:59.779+0200 I/servicemanager( 9261): es.ugr.frailty.recorder launch request sent!
04-12 19:08:59.779+0200 I/servicemanager( 9261): App control destroyed.
04-12 19:08:59.779+0200 I/servicemanager( 9261): Frailty Service Manager created
04-12 19:08:59.789+0200 W/CAPI_APPFW_APP_CONTROL( 9261): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.799+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9264
04-12 19:08:59.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.809+0200 W/CAPI_APPFW_APP_CONTROL( 9261): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.809+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9264
04-12 19:08:59.809+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.819+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.829+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9265
04-12 19:08:59.829+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.829+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:08:59.839+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9265
04-12 19:08:59.839+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:08:59.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:08:59.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:08:59.909+0200 W/APP_CORE( 9222): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:08:59.909+0200 W/APP_CORE( 9222): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[603888] for es.ugr.frailty.frailtylauncher[9222]
04-12 19:08:59.919+0200 I/CAPI_NETWORK_CONNECTION( 9264): connection.c: connection_create(453) > New handle created[0xf7979298]
04-12 19:08:59.919+0200 W/CAPI_APPFW_APP_CONTROL( 9264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.919+0200 W/CAPI_APPFW_APP_CONTROL( 9264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:08:59.959+0200 I/APP_CORE( 9222): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:08:59.959+0200 I/APP_CORE( 9222): appcore-efl.c: __after_loop(1234) > [APP 9222] PAUSE before termination
04-12 19:08:59.959+0200 I/CAPI_APPFW_APPLICATION( 9222): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:08:59.959+0200 I/CAPI_APPFW_APPLICATION( 9222): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:08:59.959+0200 I/APP_CORE( 9222): appcore-efl.c: __after_loop(1243) > [APP 9222] After terminate() callback
04-12 19:08:59.969+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:08:59.969+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:08:59.969+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:08:59.969+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:08:59.969+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:08:59.969+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:08:59.969+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:08:59.969+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:08:59.969+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:08:59.969+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:09:00.019+0200 I/UXT     ( 9222): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:09:00.079+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:09:00.079+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:09:00.079+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:09:00.079+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:09:00.079+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:09:00.079+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:09:00.099+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:09:00.099+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.099+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.099+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.099+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:09:00.099+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:09:00.099+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:09:00.109+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:09:00.109+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:09:00.109+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.109+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.109+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:09:00.119+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:09:00.119+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.119+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:09:00.119+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 19:09:00.119+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf8477e70
04-12 19:09:00.119+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8477e70, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 19:09:00.119+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 19:09:00.119+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 19:09:00.119+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:09:00.119+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:09:00.119+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:09:00.119+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:09:00.139+0200 I/efl-extension( 9222): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:09:00.139+0200 W/AUL_PAD ( 9222): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:09:00.159+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 9222 pgid = 9222
04-12 19:09:00.159+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:09:00.169+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 19:09:00.189+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:09:00.189+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9222
04-12 19:09:00.199+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9222)
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:09:01.119+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.119+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:09:01.119+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:09:01.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:09:01.139+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:09:01.149+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:09:01.149+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:09:01.149+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:09:01.149+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:09:01.149+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:09:01.149+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:09:01.159+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.159+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:09:01.159+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:09:01.159+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:09:01.169+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:09:01.169+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:09:01.169+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:09:01.169+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:09:01.169+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.169+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:09:01.169+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:09:01.179+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:09:01.189+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:09:01.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:09:01.909+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:09:02.779+0200 I/servicemanager( 9261): accelerometer alive timeout
04-12 19:09:02.779+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:09:02.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:09:02.789+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 9261
04-12 19:09:02.809+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:09:02.819+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 9275
04-12 19:09:02.869+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9275
04-12 19:09:02.869+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(9275) type(svcapp) bg(0)
04-12 19:09:02.869+0200 W/AUL     ( 9261): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9275)
04-12 19:09:02.869+0200 I/servicemanager( 9261): es.ugr.frailty.accelerometer launch request sent!
04-12 19:09:02.869+0200 I/servicemanager( 9261): App control destroyed.
04-12 19:09:02.879+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9275]
04-12 19:09:02.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:09:02.899+0200 E/CAPI_APPFW_APPLICATION( 9275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:09:02.899+0200 E/CAPI_APPFW_APPLICATION( 9275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:09:02.899+0200 I/accelerometer( 9275): Starting es.ugr.frailty.accelerometer service
04-12 19:09:02.899+0200 I/accelerometer( 9275): sensor supported
04-12 19:09:02.909+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9275
04-12 19:09:02.909+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (9275) was created
04-12 19:09:02.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:09:02.909+0200 I/accelerometer( 9275): es.ugr.frailty.accelerometer listener started
04-12 19:09:02.909+0200 W/CAPI_APPFW_APP_CONTROL( 9275): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:09:02.929+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:09:02.939+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9275
04-12 19:09:02.949+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:09:03.039+0200 W/AUL     ( 9290): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:09:03.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:09:03.039+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:09:03.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9275
04-12 19:09:03.039+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:09:03.049+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9275
04-12 19:09:03.049+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9275)
04-12 19:09:03.119+0200 W/CRASH_MANAGER( 9288): worker.c: worker_job(1205) > 1109275616363152355294
