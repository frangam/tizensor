S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 10752
Date: 2018-04-12 19:25:50+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffa6d818
r6   = 0xf74986da, r7   = 0x000000f7
r8   = 0x0000001e, r9   = 0x00000000
r10  = 0xf74986bc, fp   = 0xffa6d80c
ip   = 0xffa6dd50, sp   = 0xffa6d2a0
lr   = 0xf7332e8c, pc   = 0xf73680b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     50492 KB
Buffers:     52256 KB
Cached:     224408 KB
VmPeak:      45016 KB
VmSize:      45012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7220 KB
VmRSS:        7220 KB
VmData:      35184 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10752 TID = 10752
10752 10761 10762 10763 10764 

Maps Information
f4901000 f5100000 rw-p [stack:10764]
f52a4000 f5aa3000 rw-p [stack:10763]
f5aa4000 f62a3000 rw-p [stack:10762]
f62a4000 f6aa7000 rw-p [stack:10761]
f6aa7000 f6aaa000 r-xp /lib/libattr.so.1.1.0
f6ab2000 f6ab9000 r-xp /lib/libcrypt-2.13.so
f6aea000 f6aed000 r-xp /lib/libcap.so.2.21
f6af5000 f6af7000 r-xp /usr/lib/libiri.so
f6aff000 f6b01000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b09000 f6b0b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b14000 f6be0000 r-xp /usr/lib/libxml2.so.2.7.8
f6bee000 f6c0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c14000 f6c18000 r-xp /usr/lib/libsmack.so.1.0.0
f6c21000 f6c37000 r-xp /lib/libz.so.1.2.5
f6c3f000 f6c41000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c49000 f6c4e000 r-xp /usr/lib/libffi.so.5.0.10
f6c56000 f6c57000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c5f000 f6c6f000 r-xp /lib/libresolv-2.13.so
f6c73000 f6c8b000 r-xp /usr/lib/liblzma.so.5.0.3
f6c93000 f6c95000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c9d000 f6cb7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cbf000 f6cee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf7000 f6d06000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d0f000 f6d19000 r-xp /usr/lib/libsensord-shared.so
f6d22000 f6d56000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d5f000 f6e32000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e3d000 f6e43000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e4c000 f6ec1000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ecb000 f6ed1000 r-xp /lib/librt-2.13.so
f6eda000 f6ef8000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f02000 f6f03000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f0b000 f6f2e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f36000 f6f3b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f43000 f7013000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7014000 f703e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7047000 f705e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7066000 f70cf000 r-xp /lib/libm-2.13.so
f70d8000 f716c000 r-xp /usr/lib/libstdc++.so.6.0.16
f717f000 f7184000 r-xp /usr/lib/libctx-client.so.0.8.3
f718c000 f7193000 r-xp /usr/lib/libctx-shared.so.0.8.3
f719b000 f71c5000 r-xp /usr/lib/libsensor.so.1.9.6
f71ce000 f71d1000 r-xp /usr/lib/libbundle.so.0.1.22
f71d9000 f71df000 r-xp /usr/lib/libappsvc.so.0.1.0
f71e7000 f7228000 r-xp /usr/lib/libeina.so.1.7.99
f7231000 f7248000 r-xp /usr/lib/libecore.so.1.7.99
f725f000 f7268000 r-xp /usr/lib/libvconf.so.0.2.45
f7270000 f7284000 r-xp /lib/libpthread-2.13.so
f728f000 f729c000 r-xp /usr/lib/libaul.so.0.1.0
f72a6000 f72a8000 r-xp /lib/libdl-2.13.so
f72b1000 f72bc000 r-xp /lib/libunwind.so.8.0.1
f72e9000 f72f1000 r-xp /lib/libgcc_s-4.6.so.1
f72f2000 f7416000 r-xp /lib/libc-2.13.so
f7424000 f7426000 r-xp /usr/lib/libdlog.so.0.0.0
f742e000 f743a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7443000 f7447000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7450000 f7453000 r-xp /usr/lib/libappcore-agent.so.1.1
f7471000 f748e000 r-xp /lib/ld-2.13.so
f7497000 f7499000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7499000 f749d000 r-xp /usr/lib/libsys-assert.so
f7704000 f7746000 rw-p [heap]
ffa4f000 ffa70000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10752)
Call Stack Count: 1
 0: strlen + 0x4 (0xf73680b4) [/lib/libc.so.6] + 0x760b4
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
 apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.649+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 19:25:45.649+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-12 19:25:45.649+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:25:45.649+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:25:45.649+0200 I/APP_CORE(10703): appcore-efl.c: __do_app(453) > [APP 10703] Event: RESET State: CREATED
04-12 19:25:45.649+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-12 19:25:45.659+0200 I/APP_CORE(10703): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-12 19:25:45.659+0200 I/APP_CORE(10703): appcore-efl.c: __do_app(524) > [APP 10703] Initial Launching, call the resume_cb
04-12 19:25:45.659+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-12 19:25:45.669+0200 W/APP_CORE(10703): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(1)
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
04-12 19:25:45.719+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: PAUSE State: RUNNING
04-12 19:25:45.719+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): main.c: _appcore_pause_cb(488) > appcore pause
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.719+0200 I/APP_CORE(10703): appcore-efl.c: __do_app(453) > [APP 10703] Event: RESUME State: RUNNING
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8477e70
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8477e70, elm_layout, func : 0xf76d3d05
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf8477e70, activated : 1
04-12 19:25:45.719+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 19:25:45.719+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:25:45.719+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 19:25:45.719+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:25:45.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:45.729+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:25:45.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:25:45.729+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:45.729+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 19:25:45.729+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:25:45.729+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:25:45.729+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 19:25:45.729+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 19:25:45.729+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 19:25:45.729+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 19:25:45.739+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 19:25:45.749+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[10703] goes to (3)
04-12 19:25:45.749+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:25:45.749+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:25:45.749+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(10703) status(fg) type(uiapp)
04-12 19:25:45.759+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-12 19:25:45.979+0200 I/AUL     (10714): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 19:25:45.989+0200 I/AUL     (10714): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 19:25:45.989+0200 E/AUL     (10714): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 19:25:45.989+0200 E/AUL     (10714): aul_path.c: __get_path(169) > root_path is NULL!
04-12 19:25:46.119+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 19:25:46.229+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 19:25:46.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:46.639+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10703
04-12 19:25:46.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:46.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:46.669+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10703
04-12 19:25:46.669+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:46.739+0200 E/PKGMGR_SERVER(10667): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-12 19:25:46.739+0200 E/PKGMGR_SERVER(10667): pkgmgr-server.c: main(2295) > package manager server terminated.
04-12 19:25:46.879+0200 I/AUL_PAD (10737): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 19:25:47.049+0200 E/EFL     (10703): ecore_x<10703> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13612309 button=1
04-12 19:25:47.049+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] mouse move
04-12 19:25:47.049+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] mouse move
04-12 19:25:47.049+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] hold(0), freeze(0)
04-12 19:25:47.059+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] mouse move
04-12 19:25:47.059+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] hold(0), freeze(0)
04-12 19:25:47.069+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] mouse move
04-12 19:25:47.069+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] hold(0), freeze(0)
04-12 19:25:47.099+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] mouse move
04-12 19:25:47.099+0200 E/EFL     (10703): elementary<10703> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf74f3f98 : elm_list] hold(0), freeze(0)
04-12 19:25:47.169+0200 E/EFL     (10703): ecore_x<10703> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13612433 button=1
04-12 19:25:47.169+0200 W/AUL     (10703): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:25:47.169+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:25:47.169+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10703
04-12 19:25:47.189+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10741
04-12 19:25:47.189+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:25:47.209+0200 E/CAPI_APPFW_APPLICATION(10741): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.209+0200 E/CAPI_APPFW_APPLICATION(10741): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.209+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:25:47.239+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10741
04-12 19:25:47.239+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(10741) type(svcapp) bg(0)
04-12 19:25:47.239+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:25:47.239+0200 W/AUL     (10703): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10741)
04-12 19:25:47.239+0200 I/utils   (10703): es.ugr.frailty.servicemanager launch request sent!
04-12 19:25:47.239+0200 I/utils   (10703): App control destroyed.
04-12 19:25:47.239+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:25:47.239+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:25:47.239+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10741]
04-12 19:25:47.239+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10741
04-12 19:25:47.259+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10744
04-12 19:25:47.259+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:25:47.289+0200 E/CAPI_APPFW_APPLICATION(10744): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.289+0200 E/CAPI_APPFW_APPLICATION(10744): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.309+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10744
04-12 19:25:47.309+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(10744) type(svcapp) bg(0)
04-12 19:25:47.309+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10741) was created
04-12 19:25:47.309+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10744) was created
04-12 19:25:47.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.309+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10744]
04-12 19:25:47.319+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10741
04-12 19:25:47.319+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.329+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10744)
04-12 19:25:47.329+0200 I/servicemanager(10741): es.ugr.frailty.httppostreq launch request sent!
04-12 19:25:47.329+0200 I/servicemanager(10741): App control destroyed.
04-12 19:25:47.329+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:25:47.329+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10741
04-12 19:25:47.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:25:47.329+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10741
04-12 19:25:47.339+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10745
04-12 19:25:47.339+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:25:47.359+0200 E/CAPI_APPFW_APPLICATION(10745): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.359+0200 E/CAPI_APPFW_APPLICATION(10745): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:47.359+0200 W/CAPI_APPFW_APP_CONTROL(10745): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.359+0200 W/CAPI_APPFW_APP_CONTROL(10745): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.389+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10745
04-12 19:25:47.389+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(10745) type(svcapp) bg(0)
04-12 19:25:47.389+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.389+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10745) was created
04-12 19:25:47.399+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10745]
04-12 19:25:47.409+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.419+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10744
04-12 19:25:47.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.429+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10744
04-12 19:25:47.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.429+0200 I/CAPI_NETWORK_CONNECTION(10744): connection.c: connection_create(453) > New handle created[0xf75cdbe0]
04-12 19:25:47.429+0200 W/CAPI_APPFW_APP_CONTROL(10744): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.429+0200 W/CAPI_APPFW_APP_CONTROL(10744): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10745
04-12 19:25:47.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.449+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10745)
04-12 19:25:47.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:47.449+0200 I/servicemanager(10741): es.ugr.frailty.recorder launch request sent!
04-12 19:25:47.449+0200 I/servicemanager(10741): App control destroyed.
04-12 19:25:47.449+0200 I/servicemanager(10741): Frailty Service Manager created
04-12 19:25:47.449+0200 W/CAPI_APPFW_APP_CONTROL(10741): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.449+0200 W/CAPI_APPFW_APP_CONTROL(10741): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:47.459+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10745
04-12 19:25:47.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:47.529+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:25:47.529+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:25:47.539+0200 W/APP_CORE(10703): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:25:47.539+0200 W/APP_CORE(10703): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[604896] for es.ugr.frailty.frailtylauncher[10703]
04-12 19:25:47.579+0200 I/APP_CORE(10703): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:25:47.579+0200 I/APP_CORE(10703): appcore-efl.c: __after_loop(1234) > [APP 10703] PAUSE before termination
04-12 19:25:47.579+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:25:47.579+0200 I/CAPI_APPFW_APPLICATION(10703): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:25:47.579+0200 I/APP_CORE(10703): appcore-efl.c: __after_loop(1243) > [APP 10703] After terminate() callback
04-12 19:25:47.609+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:25:47.609+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:25:47.609+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:25:47.609+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:25:47.609+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:25:47.609+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:25:47.609+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:25:47.619+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:25:47.619+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:25:47.619+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:25:47.659+0200 I/UXT     (10703): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:25:47.739+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:25:47.749+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:25:47.749+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:25:47.749+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:25:47.749+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:25:47.749+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:25:47.749+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:25:47.749+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.749+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.749+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.749+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:25:47.759+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:25:47.759+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:25:47.779+0200 I/efl-extension(10703): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:25:47.779+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:25:47.779+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 19:25:47.779+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 19:25:47.779+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf8477e70
04-12 19:25:47.779+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8477e70, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 19:25:47.779+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 19:25:47.779+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 19:25:47.779+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:25:47.779+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:25:47.779+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:25:47.779+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:25:47.789+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:25:47.789+0200 W/AUL_PAD (10703): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:25:47.819+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10703 pgid = 10703
04-12 19:25:47.819+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:25:47.839+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:25:47.839+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10703
04-12 19:25:47.849+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10703)
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:25:48.779+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.789+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:25:48.789+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:25:48.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:48.799+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:25:48.809+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:25:48.819+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:25:48.819+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:25:48.819+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:25:48.819+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:25:48.819+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:25:48.819+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.819+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:25:48.819+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:25:48.829+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:25:48.829+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:25:48.829+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:25:48.829+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:25:48.829+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:25:48.829+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.829+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:25:48.829+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:25:48.839+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:25:48.839+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.839+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:25:48.849+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:25:49.539+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:25:50.459+0200 I/servicemanager(10741): accelerometer alive timeout
04-12 19:25:50.459+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:25:50.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:25:50.459+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10741
04-12 19:25:50.479+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10752
04-12 19:25:50.479+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:25:50.529+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10752
04-12 19:25:50.529+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(10752) type(svcapp) bg(0)
04-12 19:25:50.539+0200 W/AUL     (10741): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10752)
04-12 19:25:50.539+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10752]
04-12 19:25:50.539+0200 I/servicemanager(10741): es.ugr.frailty.accelerometer launch request sent!
04-12 19:25:50.539+0200 I/servicemanager(10741): App control destroyed.
04-12 19:25:50.559+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:50.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10752
04-12 19:25:50.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:50.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:25:50.579+0200 E/CAPI_APPFW_APPLICATION(10752): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:50.579+0200 E/CAPI_APPFW_APPLICATION(10752): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:25:50.579+0200 I/accelerometer(10752): Starting es.ugr.frailty.accelerometer service
04-12 19:25:50.579+0200 I/accelerometer(10752): sensor supported
04-12 19:25:50.589+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10752
04-12 19:25:50.589+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10752) was created
04-12 19:25:50.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:25:50.589+0200 I/accelerometer(10752): es.ugr.frailty.accelerometer listener started
04-12 19:25:50.589+0200 W/CAPI_APPFW_APP_CONTROL(10752): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:25:50.599+0200 I/utils   (10752): accelerometer utils fecha ,	õ5:50
04-12 19:25:50.709+0200 W/AUL     (10768): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:25:50.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:25:50.709+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:25:50.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10752
04-12 19:25:50.709+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:25:50.719+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10752
04-12 19:25:50.719+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10752)
04-12 19:25:50.749+0200 W/CRASH_MANAGER(10766): worker.c: worker_job(1205) > 1110752616363152355395
