S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 7645
Date: 2018-04-12 18:47:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffa5b850
r6   = 0xf75e26f3, r7   = 0x000000f7
r8   = 0x00000018, r9   = 0x00000000
r10  = 0xf75e26db, fp   = 0xffa5b844
ip   = 0xffa5bd88, sp   = 0xffa5b2d8
lr   = 0xf747ce8c, pc   = 0xf74b20b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     64316 KB
Buffers:     45036 KB
Cached:     220732 KB
VmPeak:      45264 KB
VmSize:      45012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7100 KB
VmRSS:        7100 KB
VmData:      35184 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7645 TID = 7645
7645 7654 7655 7656 7657 

Maps Information
f4bee000 f53ed000 rw-p [stack:7657]
f53ee000 f5bed000 rw-p [stack:7656]
f5bee000 f63ed000 rw-p [stack:7655]
f63ee000 f6bf1000 rw-p [stack:7654]
f6bf1000 f6bf4000 r-xp /lib/libattr.so.1.1.0
f6bfc000 f6c03000 r-xp /lib/libcrypt-2.13.so
f6c34000 f6c37000 r-xp /lib/libcap.so.2.21
f6c3f000 f6c41000 r-xp /usr/lib/libiri.so
f6c49000 f6c4b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c53000 f6c55000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c5e000 f6d2a000 r-xp /usr/lib/libxml2.so.2.7.8
f6d38000 f6d55000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d5e000 f6d62000 r-xp /usr/lib/libsmack.so.1.0.0
f6d6b000 f6d81000 r-xp /lib/libz.so.1.2.5
f6d89000 f6d8b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d93000 f6d98000 r-xp /usr/lib/libffi.so.5.0.10
f6da0000 f6da1000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6da9000 f6db9000 r-xp /lib/libresolv-2.13.so
f6dbd000 f6dd5000 r-xp /usr/lib/liblzma.so.5.0.3
f6ddd000 f6ddf000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6de7000 f6e01000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e09000 f6e38000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e41000 f6e50000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e59000 f6e63000 r-xp /usr/lib/libsensord-shared.so
f6e6c000 f6ea0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ea9000 f6f7c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f87000 f6f8d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f96000 f700b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7015000 f701b000 r-xp /lib/librt-2.13.so
f7024000 f7042000 r-xp /usr/lib/libsystemd.so.0.4.0
f704c000 f704d000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7055000 f7078000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7080000 f7085000 r-xp /usr/lib/libxdgmime.so.1.1.0
f708d000 f715d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f715e000 f7188000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7191000 f71a8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f71b0000 f7219000 r-xp /lib/libm-2.13.so
f7222000 f72b6000 r-xp /usr/lib/libstdc++.so.6.0.16
f72c9000 f72ce000 r-xp /usr/lib/libctx-client.so.0.8.3
f72d6000 f72dd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f72e5000 f730f000 r-xp /usr/lib/libsensor.so.1.9.6
f7318000 f731b000 r-xp /usr/lib/libbundle.so.0.1.22
f7323000 f7329000 r-xp /usr/lib/libappsvc.so.0.1.0
f7331000 f7372000 r-xp /usr/lib/libeina.so.1.7.99
f737b000 f7392000 r-xp /usr/lib/libecore.so.1.7.99
f73a9000 f73b2000 r-xp /usr/lib/libvconf.so.0.2.45
f73ba000 f73ce000 r-xp /lib/libpthread-2.13.so
f73d9000 f73e6000 r-xp /usr/lib/libaul.so.0.1.0
f73f0000 f73f2000 r-xp /lib/libdl-2.13.so
f73fb000 f7406000 r-xp /lib/libunwind.so.8.0.1
f7433000 f743b000 r-xp /lib/libgcc_s-4.6.so.1
f743c000 f7560000 r-xp /lib/libc-2.13.so
f756e000 f7570000 r-xp /usr/lib/libdlog.so.0.0.0
f7578000 f7584000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f758d000 f7591000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f759a000 f759d000 r-xp /usr/lib/libappcore-agent.so.1.1
f75bb000 f75d8000 r-xp /lib/ld-2.13.so
f75e1000 f75e3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f75e3000 f75e7000 r-xp /usr/lib/libsys-assert.so
f7cac000 f7cee000 rw-p [heap]
ffa3c000 ffa5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7645)
Call Stack Count: 1
 0: strlen + 0x4 (0xf74b20b4) [/lib/libc.so.6] + 0x760b4
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
R ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7596]
04-12 18:47:44.359+0200 E/EFL     ( 7596): ecore_evas<7596> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-12 18:47:44.429+0200 I/APP_CORE( 7596): appcore-efl.c: __do_app(453) > [APP 7596] Event: RESET State: CREATED
04-12 18:47:44.429+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-12 18:47:44.459+0200 I/APP_CORE( 7596): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-12 18:47:44.459+0200 I/APP_CORE( 7596): appcore-efl.c: __do_app(524) > [APP 7596] Initial Launching, call the resume_cb
04-12 18:47:44.459+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 18:47:44.459+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-12 18:47:44.459+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:47:44.459+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:47:44.469+0200 W/APP_CORE( 7596): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
04-12 18:47:44.549+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(1)
04-12 18:47:44.549+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-12 18:47:44.549+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.549+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
04-12 18:47:44.559+0200 I/APP_CORE( 7596): appcore-efl.c: __do_app(453) > [APP 7596] Event: RESUME State: RUNNING
04-12 18:47:44.559+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: PAUSE State: RUNNING
04-12 18:47:44.559+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): main.c: _appcore_pause_cb(488) > appcore pause
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:44.559+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8477e70
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8477e70, elm_layout, func : 0xf76d3d05
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf8477e70, activated : 1
04-12 18:47:44.559+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:47:44.559+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:47:44.559+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 18:47:44.559+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:47:44.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:47:44.569+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 18:47:44.579+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 18:47:44.579+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 18:47:44.589+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:47:44.589+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:44.589+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 18:47:44.589+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:47:44.589+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 18:47:44.599+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:47:44.599+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:47:44.599+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(7596) status(fg) type(uiapp)
04-12 18:47:44.599+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[7596] goes to (3)
04-12 18:47:44.629+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-12 18:47:44.629+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:47:44.629+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 18:47:44.929+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:47:45.089+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:47:45.189+0200 E/EFL     ( 7596): ecore_x<7596> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11330452 button=1
04-12 18:47:45.189+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] mouse move
04-12 18:47:45.189+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] mouse move
04-12 18:47:45.189+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] hold(0), freeze(0)
04-12 18:47:45.219+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] mouse move
04-12 18:47:45.219+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] hold(0), freeze(0)
04-12 18:47:45.269+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] mouse move
04-12 18:47:45.269+0200 E/EFL     ( 7596): elementary<7596> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7b57fc0 : elm_list] hold(0), freeze(0)
04-12 18:47:45.329+0200 E/EFL     ( 7596): ecore_x<7596> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11330594 button=1
04-12 18:47:45.329+0200 W/AUL     ( 7596): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:47:45.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:47:45.329+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7596
04-12 18:47:45.349+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7632
04-12 18:47:45.369+0200 E/CAPI_APPFW_APPLICATION( 7632): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.369+0200 E/CAPI_APPFW_APPLICATION( 7632): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.369+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:47:45.399+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:47:45.399+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7632
04-12 18:47:45.399+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(7632) type(svcapp) bg(0)
04-12 18:47:45.399+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:47:45.399+0200 W/AUL     ( 7596): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7632)
04-12 18:47:45.399+0200 I/utils   ( 7596): es.ugr.frailty.servicemanager launch request sent!
04-12 18:47:45.399+0200 I/utils   ( 7596): App control destroyed.
04-12 18:47:45.399+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:47:45.399+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:47:45.399+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7632]
04-12 18:47:45.409+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7632
04-12 18:47:45.419+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7635
04-12 18:47:45.419+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:47:45.469+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7635
04-12 18:47:45.469+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(7635) type(svcapp) bg(0)
04-12 18:47:45.469+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7635)
04-12 18:47:45.469+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7635]
04-12 18:47:45.469+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7632) was created
04-12 18:47:45.469+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.479+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7596
04-12 18:47:45.479+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.489+0200 E/CAPI_APPFW_APPLICATION( 7635): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.489+0200 E/CAPI_APPFW_APPLICATION( 7635): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.489+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7596
04-12 18:47:45.489+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7635) was created
04-12 18:47:45.489+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.499+0200 I/servicemanager( 7632): es.ugr.frailty.httppostreq launch request sent!
04-12 18:47:45.499+0200 I/servicemanager( 7632): App control destroyed.
04-12 18:47:45.509+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:47:45.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.519+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7632
04-12 18:47:45.519+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:47:45.519+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7632
04-12 18:47:45.529+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7637
04-12 18:47:45.529+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:47:45.549+0200 E/CAPI_APPFW_APPLICATION( 7637): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.549+0200 E/CAPI_APPFW_APPLICATION( 7637): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:45.549+0200 W/CAPI_APPFW_APP_CONTROL( 7637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.549+0200 W/CAPI_APPFW_APP_CONTROL( 7637): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.579+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7637
04-12 18:47:45.579+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(7637) type(svcapp) bg(0)
04-12 18:47:45.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.589+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7637) was created
04-12 18:47:45.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.589+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7637)
04-12 18:47:45.589+0200 I/servicemanager( 7632): es.ugr.frailty.recorder launch request sent!
04-12 18:47:45.589+0200 I/servicemanager( 7632): App control destroyed.
04-12 18:47:45.589+0200 I/servicemanager( 7632): Frailty Service Manager created
04-12 18:47:45.589+0200 W/CAPI_APPFW_APP_CONTROL( 7632): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.599+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.609+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7635
04-12 18:47:45.609+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.619+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7632
04-12 18:47:45.629+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7637]
04-12 18:47:45.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.639+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:47:45.639+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:47:45.639+0200 W/APP_CORE( 7596): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:47:45.639+0200 W/APP_CORE( 7596): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[6026b9] for es.ugr.frailty.frailtylauncher[7596]
04-12 18:47:45.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.659+0200 W/CAPI_APPFW_APP_CONTROL( 7632): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.659+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7637
04-12 18:47:45.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.669+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7635
04-12 18:47:45.669+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.679+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:45.689+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7637
04-12 18:47:45.689+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:45.689+0200 I/APP_CORE( 7596): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:47:45.689+0200 I/APP_CORE( 7596): appcore-efl.c: __after_loop(1234) > [APP 7596] PAUSE before termination
04-12 18:47:45.689+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:47:45.689+0200 I/CAPI_APPFW_APPLICATION( 7596): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:47:45.689+0200 I/APP_CORE( 7596): appcore-efl.c: __after_loop(1243) > [APP 7596] After terminate() callback
04-12 18:47:45.699+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:47:45.699+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:47:45.699+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:47:45.699+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:47:45.699+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:47:45.699+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:47:45.699+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:47:45.699+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:47:45.699+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:47:45.699+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:47:45.749+0200 I/UXT     ( 7596): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:47:45.829+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:47:45.839+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:47:45.839+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:47:45.839+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:47:45.839+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:47:45.839+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:47:45.859+0200 I/CAPI_NETWORK_CONNECTION( 7635): connection.c: connection_create(453) > New handle created[0xf7598be0]
04-12 18:47:45.859+0200 W/CAPI_APPFW_APP_CONTROL( 7635): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.859+0200 I/efl-extension( 7596): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:47:45.859+0200 W/CAPI_APPFW_APP_CONTROL( 7635): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:45.859+0200 W/AUL_PAD ( 7596): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:47:45.879+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:47:45.879+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.879+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.889+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.889+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:47:45.889+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7596 pgid = 7596
04-12 18:47:45.889+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:47:45.899+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:47:45.899+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:47:45.899+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 18:47:45.899+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf8477e70
04-12 18:47:45.899+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8477e70, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 18:47:45.899+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:47:45.899+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:47:45.899+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:47:45.899+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:47:45.899+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:47:45.899+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:47:45.899+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:47:45.929+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:47:45.929+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7596
04-12 18:47:45.929+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7596)
04-12 18:47:46.019+0200 I/AUL_PAD ( 7631): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:47:46.899+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.899+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:47:46.899+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:47:46.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:46.919+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:47:46.939+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:47:46.939+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:47:46.939+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:47:46.939+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:47:46.939+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:47:46.939+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:47:46.939+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.939+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:47:46.939+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:47:46.939+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:47:46.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:47:46.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:47:46.949+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:47:46.949+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.949+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:47:46.949+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:47:46.949+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:47:46.949+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:47:46.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:47:47.639+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:47:48.599+0200 I/servicemanager( 7632): accelerometer alive timeout
04-12 18:47:48.599+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:47:48.599+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:47:48.599+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7632
04-12 18:47:48.619+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7645
04-12 18:47:48.619+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:47:48.669+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7645
04-12 18:47:48.669+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(7645) type(svcapp) bg(0)
04-12 18:47:48.669+0200 W/AUL     ( 7632): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7645)
04-12 18:47:48.679+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7645]
04-12 18:47:48.679+0200 I/servicemanager( 7632): es.ugr.frailty.accelerometer launch request sent!
04-12 18:47:48.689+0200 I/servicemanager( 7632): App control destroyed.
04-12 18:47:48.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:48.719+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7645
04-12 18:47:48.719+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:48.739+0200 E/CAPI_APPFW_APPLICATION( 7645): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:48.739+0200 E/CAPI_APPFW_APPLICATION( 7645): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:47:48.739+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7645) was created
04-12 18:47:48.739+0200 I/accelerometer( 7645): Starting es.ugr.frailty.accelerometer service
04-12 18:47:48.739+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:47:48.739+0200 I/accelerometer( 7645): sensor supported
04-12 18:47:48.749+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7645
04-12 18:47:48.749+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:47:48.759+0200 I/accelerometer( 7645): es.ugr.frailty.accelerometer listener started
04-12 18:47:48.759+0200 W/CAPI_APPFW_APP_CONTROL( 7645): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:47:48.769+0200 I/utils   ( 7645): accelerometer utils fecha 12/04/2018,18:47:48
04-12 18:47:48.769+0200 I/utils   ( 7645): accelerometer utils fecha  ½¥ÿ€²V÷,Ð¼¥ÿ€²V÷ 
04-12 18:47:48.779+0200 I/accelerometer( 7645): accelerometer fecha conseguida
04-12 18:47:48.859+0200 W/AUL     ( 7660): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:47:48.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:47:48.869+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:47:48.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7645
04-12 18:47:48.869+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:47:48.869+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7645
04-12 18:47:48.869+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7645)
04-12 18:47:48.929+0200 W/CRASH_MANAGER( 7659): worker.c: worker_job(1205) > 1107645616363152355166
