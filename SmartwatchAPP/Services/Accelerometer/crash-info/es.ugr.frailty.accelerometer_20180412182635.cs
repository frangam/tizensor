S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 6311
Date: 2018-04-12 18:26:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffa135a0
r6   = 0xf71966c4, r7   = 0x000000f7
r8   = 0x00000014, r9   = 0x00000000
r10  = 0xf71966af, fp   = 0xffa13594
ip   = 0xffa13ad4, sp   = 0xffa13028
lr   = 0xf7030e8c, pc   = 0xf70660b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     73216 KB
Buffers:     40728 KB
Cached:     218176 KB
VmPeak:      45264 KB
VmSize:      45012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7088 KB
VmRSS:        7088 KB
VmData:      35184 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6311 TID = 6311
6311 6320 6321 6322 6323 

Maps Information
f47a2000 f4fa1000 rw-p [stack:6323]
f4fa2000 f57a1000 rw-p [stack:6322]
f57a2000 f5fa1000 rw-p [stack:6321]
f5fa2000 f67a5000 rw-p [stack:6320]
f67a5000 f67a8000 r-xp /lib/libattr.so.1.1.0
f67b0000 f67b7000 r-xp /lib/libcrypt-2.13.so
f67e8000 f67eb000 r-xp /lib/libcap.so.2.21
f67f3000 f67f5000 r-xp /usr/lib/libiri.so
f67fd000 f67ff000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6807000 f6809000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6812000 f68de000 r-xp /usr/lib/libxml2.so.2.7.8
f68ec000 f6909000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6912000 f6916000 r-xp /usr/lib/libsmack.so.1.0.0
f691f000 f6935000 r-xp /lib/libz.so.1.2.5
f693d000 f693f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6947000 f694c000 r-xp /usr/lib/libffi.so.5.0.10
f6954000 f6955000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f695d000 f696d000 r-xp /lib/libresolv-2.13.so
f6971000 f6989000 r-xp /usr/lib/liblzma.so.5.0.3
f6991000 f6993000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f699b000 f69b5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69bd000 f69ec000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69f5000 f6a04000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a0d000 f6a17000 r-xp /usr/lib/libsensord-shared.so
f6a20000 f6a54000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a5d000 f6b30000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b3b000 f6b41000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b4a000 f6bbf000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bc9000 f6bcf000 r-xp /lib/librt-2.13.so
f6bd8000 f6bf6000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c00000 f6c01000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c09000 f6c2c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c34000 f6c39000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c41000 f6d11000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d12000 f6d3c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d45000 f6d5c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d64000 f6dcd000 r-xp /lib/libm-2.13.so
f6dd6000 f6e6a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e7d000 f6e82000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e8a000 f6e91000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e99000 f6ec3000 r-xp /usr/lib/libsensor.so.1.9.6
f6ecc000 f6ecf000 r-xp /usr/lib/libbundle.so.0.1.22
f6ed7000 f6edd000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ee5000 f6f26000 r-xp /usr/lib/libeina.so.1.7.99
f6f2f000 f6f46000 r-xp /usr/lib/libecore.so.1.7.99
f6f5d000 f6f66000 r-xp /usr/lib/libvconf.so.0.2.45
f6f6e000 f6f82000 r-xp /lib/libpthread-2.13.so
f6f8d000 f6f9a000 r-xp /usr/lib/libaul.so.0.1.0
f6fa4000 f6fa6000 r-xp /lib/libdl-2.13.so
f6faf000 f6fba000 r-xp /lib/libunwind.so.8.0.1
f6fe7000 f6fef000 r-xp /lib/libgcc_s-4.6.so.1
f6ff0000 f7114000 r-xp /lib/libc-2.13.so
f7122000 f7124000 r-xp /usr/lib/libdlog.so.0.0.0
f712c000 f7138000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7141000 f7145000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f714e000 f7151000 r-xp /usr/lib/libappcore-agent.so.1.1
f716f000 f718c000 r-xp /lib/ld-2.13.so
f7195000 f7197000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7197000 f719b000 r-xp /usr/lib/libsys-assert.so
f734c000 f738e000 rw-p [heap]
ff9f4000 ffa15000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6311)
Call Stack Count: 1
 0: strlen + 0x4 (0xf70660b4) [/lib/libc.so.6] + 0x760b4
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
isibility : 1, apptray edit visibility : 0
04-12 18:26:30.349+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 18:26:30.349+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 0
04-12 18:26:30.349+0200 W/APP_CORE( 6258): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(1)
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
04-12 18:26:30.399+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: PAUSE State: RUNNING
04-12 18:26:30.399+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): main.c: _appcore_pause_cb(488) > appcore pause
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:30.399+0200 W/W_HOME  ( 2742): rotary.c: rotary_deattach(156) > rotary_deattach:0xf8477e70
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf8477e70, elm_layout, func : 0xf76d3d05
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf83b6fd0, elm_box, _activated_obj : 0xf8477e70, activated : 1
04-12 18:26:30.399+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:26:30.399+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:26:30.399+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
04-12 18:26:30.409+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 18:26:30.409+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 18:26:30.409+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 18:26:30.409+0200 I/APP_CORE( 6258): appcore-efl.c: __do_app(453) > [APP 6258] Event: RESUME State: RUNNING
04-12 18:26:30.409+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:30.419+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:30.419+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 18:26:30.419+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:26:30.419+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:26:30.419+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(6258) status(fg) type(uiapp)
04-12 18:26:30.419+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6258] goes to (3)
04-12 18:26:30.429+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:26:30.429+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 18:26:30.429+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:26:30.429+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 18:26:30.439+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-12 18:26:30.449+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:26:30.449+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:26:30.789+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:26:30.919+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:26:31.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:31.309+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6258
04-12 18:26:31.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:31.349+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:31.359+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6258
04-12 18:26:31.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:31.559+0200 I/AUL_PAD ( 6296): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:26:31.909+0200 E/EFL     ( 6258): ecore_x<6258> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=10057169 button=1
04-12 18:26:31.909+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:31.909+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:31.909+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:31.959+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:31.959+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:31.999+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:31.999+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:32.019+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:32.019+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:32.029+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:32.029+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:32.049+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] mouse move
04-12 18:26:32.049+0200 E/EFL     ( 6258): elementary<6258> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7414fe8 : elm_list] hold(0), freeze(0)
04-12 18:26:32.059+0200 E/EFL     ( 6258): ecore_x<6258> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=10057321 button=1
04-12 18:26:32.059+0200 W/AUL     ( 6258): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:26:32.059+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:26:32.059+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6258
04-12 18:26:32.069+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6299
04-12 18:26:32.079+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:26:32.099+0200 E/CAPI_APPFW_APPLICATION( 6299): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.099+0200 E/CAPI_APPFW_APPLICATION( 6299): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.099+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:26:32.129+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6299
04-12 18:26:32.129+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(6299) type(svcapp) bg(0)
04-12 18:26:32.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:26:32.129+0200 W/AUL     ( 6258): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6299)
04-12 18:26:32.129+0200 I/utils   ( 6258): es.ugr.frailty.servicemanager launch request sent!
04-12 18:26:32.129+0200 I/utils   ( 6258): App control destroyed.
04-12 18:26:32.129+0200 I/CAPI_APPFW_APPLICATION( 6258): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:26:32.129+0200 I/CAPI_APPFW_APPLICATION( 6258): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:26:32.139+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6299]
04-12 18:26:32.139+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:26:32.149+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6302
04-12 18:26:32.149+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:26:32.189+0200 E/CAPI_APPFW_APPLICATION( 6302): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.189+0200 E/CAPI_APPFW_APPLICATION( 6302): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.199+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6302
04-12 18:26:32.199+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(6302) type(svcapp) bg(0)
04-12 18:26:32.199+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6299) was created
04-12 18:26:32.199+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6302) was created
04-12 18:26:32.199+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.209+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6299
04-12 18:26:32.209+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.219+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6302)
04-12 18:26:32.219+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6302]
04-12 18:26:32.229+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6299
04-12 18:26:32.229+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.229+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.239+0200 I/servicemanager( 6299): es.ugr.frailty.httppostreq launch request sent!
04-12 18:26:32.239+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:26:32.239+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:26:32.239+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:26:32.239+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:26:32.249+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6305
04-12 18:26:32.249+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:26:32.279+0200 E/CAPI_APPFW_APPLICATION( 6305): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.279+0200 E/CAPI_APPFW_APPLICATION( 6305): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:32.279+0200 W/CAPI_APPFW_APP_CONTROL( 6305): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.279+0200 W/CAPI_APPFW_APP_CONTROL( 6305): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.299+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6305
04-12 18:26:32.299+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6305) type(svcapp) bg(0)
04-12 18:26:32.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.309+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6305)
04-12 18:26:32.309+0200 I/servicemanager( 6299): es.ugr.frailty.recorder launch request sent!
04-12 18:26:32.309+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:26:32.309+0200 I/servicemanager( 6299): Frailty Service Manager created
04-12 18:26:32.309+0200 W/CAPI_APPFW_APP_CONTROL( 6299): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.309+0200 W/CAPI_APPFW_APP_CONTROL( 6299): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.309+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6302
04-12 18:26:32.309+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6305) was created
04-12 18:26:32.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.319+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6302
04-12 18:26:32.319+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.319+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.329+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6305]
04-12 18:26:32.339+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.349+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6305
04-12 18:26:32.349+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:32.359+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6305
04-12 18:26:32.369+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:32.389+0200 I/CAPI_NETWORK_CONNECTION( 6302): connection.c: connection_create(453) > New handle created[0xf792abe0]
04-12 18:26:32.389+0200 W/CAPI_APPFW_APP_CONTROL( 6302): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.389+0200 W/CAPI_APPFW_APP_CONTROL( 6302): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:32.399+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:26:32.399+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:26:32.399+0200 W/APP_CORE( 6258): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:26:32.399+0200 W/APP_CORE( 6258): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[6013f1] for es.ugr.frailty.frailtylauncher[6258]
04-12 18:26:32.439+0200 I/APP_CORE( 6258): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:26:32.439+0200 I/APP_CORE( 6258): appcore-efl.c: __after_loop(1234) > [APP 6258] PAUSE before termination
04-12 18:26:32.439+0200 I/CAPI_APPFW_APPLICATION( 6258): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:26:32.439+0200 I/CAPI_APPFW_APPLICATION( 6258): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:26:32.439+0200 I/APP_CORE( 6258): appcore-efl.c: __after_loop(1243) > [APP 6258] After terminate() callback
04-12 18:26:32.449+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:26:32.449+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:26:32.449+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:26:32.449+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:26:32.449+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:26:32.449+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:26:32.449+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:26:32.449+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:26:32.449+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:26:32.449+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:26:32.489+0200 I/UXT     ( 6258): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:26:32.559+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:26:32.559+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:26:32.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.559+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.559+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:26:32.559+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:26:32.559+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:26:32.559+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:26:32.559+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:26:32.559+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:26:32.559+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:26:32.559+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:26:32.589+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:26:32.589+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:26:32.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.599+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.599+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-12 18:26:32.599+0200 W/APPS    ( 2742): apps_main.c: _time_changed_cb(308) >  date : 12->12
04-12 18:26:32.599+0200 W/APPS    ( 2742): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-12 18:26:32.599+0200 W/W_HOME  ( 2742): rotary.c: rotary_attach(138) > rotary_attach:0xf8477e70
04-12 18:26:32.599+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf8477e70, elm_layout, _activated_obj : 0xf83b6fd0, activated : 1
04-12 18:26:32.599+0200 I/efl-extension( 2742): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-12 18:26:32.599+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:26:32.599+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:26:32.599+0200 W/W_HOME  ( 2742): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-12 18:26:32.599+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:26:32.599+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:26:32.599+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:26:32.599+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:26:32.599+0200 I/efl-extension( 6258): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:26:32.599+0200 W/AUL_PAD ( 6258): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:26:32.629+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6258 pgid = 6258
04-12 18:26:32.629+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:26:32.659+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:26:32.669+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6258
04-12 18:26:32.669+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6258)
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.599+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:26:33.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:26:33.609+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:33.619+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:26:33.639+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:26:33.639+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:26:33.639+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:26:33.649+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:26:33.649+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:26:33.659+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.659+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:26:33.659+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:26:33.669+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:26:33.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:26:33.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:26:33.669+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:26:33.669+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.669+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:26:33.669+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:26:33.679+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:26:33.679+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:26:33.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:26:34.399+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:26:34.929+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:26:34.979+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:34.999+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:26:35.009+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:26:35.029+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:26:35.039+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:26:35.059+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:26:35.309+0200 I/servicemanager( 6299): accelerometer alive timeout
04-12 18:26:35.309+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:26:35.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:26:35.319+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6299
04-12 18:26:35.339+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:26:35.339+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6311
04-12 18:26:35.389+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6311
04-12 18:26:35.389+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6311) type(svcapp) bg(0)
04-12 18:26:35.399+0200 W/AUL     ( 6299): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6311)
04-12 18:26:35.399+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6311]
04-12 18:26:35.399+0200 I/servicemanager( 6299): es.ugr.frailty.accelerometer launch request sent!
04-12 18:26:35.399+0200 I/servicemanager( 6299): App control destroyed.
04-12 18:26:35.419+0200 E/CAPI_APPFW_APPLICATION( 6311): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:35.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:35.429+0200 E/CAPI_APPFW_APPLICATION( 6311): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:26:35.429+0200 I/accelerometer( 6311): Starting es.ugr.frailty.accelerometer service
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6311
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6311) was created
04-12 18:26:35.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:35.439+0200 I/accelerometer( 6311): sensor supported
04-12 18:26:35.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:26:35.449+0200 I/accelerometer( 6311): es.ugr.frailty.accelerometer listener started
04-12 18:26:35.449+0200 W/CAPI_APPFW_APP_CONTROL( 6311): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:26:35.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6311
04-12 18:26:35.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:26:35.469+0200 I/accelerometer( 6311): accelerometer fecha get
04-12 18:26:35.469+0200 I/accelerometer( 6311): accelerometer fecha conseguida
04-12 18:26:35.559+0200 W/AUL     ( 6327): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6311
04-12 18:26:35.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:26:35.569+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6311
04-12 18:26:35.569+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6311)
04-12 18:26:35.619+0200 W/CRASH_MANAGER( 6325): worker.c: worker_job(1205) > 1106311616363152355039
