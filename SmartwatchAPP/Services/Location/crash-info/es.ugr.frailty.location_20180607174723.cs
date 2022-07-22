S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24429
Date: 2018-06-07 17:47:23+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75a852d, r5   = 0xf7b0ef98
r6   = 0xffba9be0, r7   = 0xffba9a90
r8   = 0xf7b0bc18, r9   = 0x00000000
r10  = 0xffba9b6c, fp   = 0xffba9be0
ip   = 0x00000001, sp   = 0xffba9a68
lr   = 0xf75a8539, pc   = 0xf7611228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    260164 KB
Buffers:     13768 KB
Cached:     112848 KB
VmPeak:      53460 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11760 KB
VmRSS:       11756 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24429 TID = 24429
24429 24518 

Maps Information
f4473000 f4c72000 rw-p [stack:24518]
f4c79000 f4c7b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c83000 f4c87000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c90000 f4c92000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c9a000 f4c9d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cac000 f4cb1000 r-xp /usr/lib/libsystem.so.0.0.0
f4cbc000 f4cbf000 r-xp /lib/libattr.so.1.1.0
f4cc7000 f4cd7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cdf000 f4ce8000 r-xp /usr/lib/libedbus.so.1.7.99
f4cf0000 f4cf1000 r-xp /usr/lib/libresponse.so.0.2.96
f4cfa000 f4cff000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65a1000 f66a7000 r-xp /usr/lib/libicuuc.so.57.1
f66bd000 f6845000 r-xp /usr/lib/libicui18n.so.57.1
f6855000 f6862000 r-xp /usr/lib/libail.so.0.1.0
f686b000 f6872000 r-xp /usr/lib/libminizip.so.1.0.0
f687b000 f6a24000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a44000 f6a8b000 r-xp /usr/lib/libssl.so.1.0.0
f6a97000 f6a99000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aa1000 f6aa8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ab1000 f6ab8000 r-xp /lib/libcrypt-2.13.so
f6ae9000 f6aec000 r-xp /lib/libcap.so.2.21
f6af4000 f6af6000 r-xp /usr/lib/libiri.so
f6afe000 f6b47000 r-xp /usr/lib/libmdm.so.1.2.69
f6b4f000 f6b55000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b5d000 f6b80000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b8a000 f6b8c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b94000 f6bb1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bba000 f6bbe000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc7000 f6be0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6be9000 f6bf1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bf9000 f6bff000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c08000 f6c0a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c13000 f6c23000 r-xp /lib/libresolv-2.13.so
f6c27000 f6c3f000 r-xp /usr/lib/liblzma.so.5.0.3
f6c48000 f6c4a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c52000 f6c6c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c74000 f6ca3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cac000 f6cbb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cc5000 f6ccf000 r-xp /usr/lib/libsensord-shared.so
f6cd8000 f6dab000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db6000 f6dcc000 r-xp /lib/libz.so.1.2.5
f6dd4000 f6dd9000 r-xp /usr/lib/libffi.so.5.0.10
f6de1000 f6de2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dea000 f6dfa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e02000 f6e1b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e23000 f6e25000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e2d000 f6ea2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eac000 f6eb2000 r-xp /lib/librt-2.13.so
f6ebb000 f6ed9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ee3000 f6ee4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eec000 f6f0f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f17000 f6f1c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f24000 f6f4e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f57000 f6f6e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f76000 f6fdf000 r-xp /lib/libm-2.13.so
f6fe8000 f707c000 r-xp /usr/lib/libstdc++.so.6.0.16
f708f000 f7094000 r-xp /usr/lib/libctx-client.so.0.8.3
f709c000 f70a3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70ab000 f70d5000 r-xp /usr/lib/libsensor.so.1.9.6
f70de000 f71aa000 r-xp /usr/lib/libxml2.so.2.7.8
f71b7000 f71b9000 r-xp /usr/lib/libiniparser.so.0
f71c2000 f71c8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71d1000 f72a1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72a2000 f72d6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72df000 f731b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7323000 f7326000 r-xp /usr/lib/libbundle.so.0.1.22
f732e000 f7334000 r-xp /usr/lib/libappsvc.so.0.1.0
f733c000 f737d000 r-xp /usr/lib/libeina.so.1.7.99
f7386000 f739d000 r-xp /usr/lib/libecore.so.1.7.99
f73b4000 f73bd000 r-xp /usr/lib/libvconf.so.0.2.45
f73c5000 f73d9000 r-xp /lib/libpthread-2.13.so
f73e4000 f73f1000 r-xp /usr/lib/libaul.so.0.1.0
f73fb000 f73fd000 r-xp /lib/libdl-2.13.so
f7406000 f7411000 r-xp /lib/libunwind.so.8.0.1
f743e000 f7446000 r-xp /lib/libgcc_s-4.6.so.1
f7447000 f756b000 r-xp /lib/libc-2.13.so
f7579000 f757b000 r-xp /usr/lib/libdlog.so.0.0.0
f7583000 f758f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7598000 f759d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75a5000 f75b4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75bc000 f75c0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75c9000 f75cc000 r-xp /usr/lib/libappcore-agent.so.1.1
f75d4000 f75d6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75de000 f75e2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75ea000 f7607000 r-xp /lib/ld-2.13.so
f7610000 f7613000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7613000 f7617000 r-xp /usr/lib/libsys-assert.so
f7adb000 f7b49000 rw-p [heap]
ffb8b000 ffbac000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24429)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7611228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75a8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72af3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72adc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72b9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72bfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72bfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72f475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72ef1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72adc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72b9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72bfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72bfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72f1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72f2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72f9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c911fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c84171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d57663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7204fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72067a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7396ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7391b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73925a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7392879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ca183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ca7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76115c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf745e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7610f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: location
App ID: es.ugr.frailty.location
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ent_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-07 17:47:23.331+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:47:23.331+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:47:23.331+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:47:23.331+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xee468850
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xee468850, elm_layout, func : 0xf7719d05
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xee468850, activated : 1
06-07 17:47:23.331+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 17:47:23.331+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 17:47:23.331+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 17:47:23.341+0200 I/APP_CORE(24361): appcore-efl.c: __do_app(453) > [APP 24361] Event: RESUME State: RUNNING
06-07 17:47:23.341+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2762] goes to (4)
06-07 17:47:23.341+0200 E/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2762)'s state(4)
06-07 17:47:23.361+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2762) status(bg) type(uiapp)
06-07 17:47:23.371+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[24361] goes to (3)
06-07 17:47:23.371+0200 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-07 17:47:23.371+0200 W/AUL_AMD ( 2479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-07 17:47:23.371+0200 W/AUL_AMD ( 2479): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 17:47:23.371+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(24361) status(fg) type(uiapp)
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 17:47:23.371+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 17:47:23.371+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 17:47:23.371+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 17:47:23.371+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
06-07 17:47:23.371+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 17:47:23.371+0200 W/wnotib  ( 2762): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
06-07 17:47:23.401+0200 E/CAPI_APPFW_APP_CONTROL( 3247): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-07 17:47:23.401+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:23.401+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:23.401+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3247]   [com.samsung.w-home]register msg port [false][0m
06-07 17:47:23.401+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:23:335,1564.000000
06-07 17:47:23.411+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:333,0.272782,-0.169890,9.877571
06-07 17:47:23.421+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-07 17:47:23.421+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:222,0.374782,-0.186076,9.797719
06-07 17:47:23.421+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.421+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:219,-0.070000,0.070000,0.070000
06-07 17:47:23.431+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.431+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:263,-0.067773,0.020967,0.135182
06-07 17:47:23.431+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.441+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.441+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:445,-0.059538,0.029564,0.115888
06-07 17:47:23.441+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.441+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:436,0.373402,-0.185674,9.797779
06-07 17:47:23.451+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.451+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:451,-0.025430,0.009007,0.091817
06-07 17:47:23.451+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.451+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:440,-0.070000,0.070000,0.070000
06-07 17:47:23.461+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.461+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:449,0.327817,-0.169890,9.896714
06-07 17:47:23.461+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.481+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:469,-0.070000,0.070000,0.070000
06-07 17:47:23.481+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:476,0.296710,-0.169890,9.882358
06-07 17:47:23.481+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:461,-0.050371,0.010998,0.079792
06-07 17:47:23.491+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:462,0.370860,-0.185220,9.797885
06-07 17:47:23.501+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:47:23.501+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.511+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:47:23.511+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:23.511+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:47:23.511+0200 E/EFL     (24361): evas_main<24361> evas_stack.c:158 evas_object_stack_above() BITCH! evas_object_stack_above(), 0xf7e1deb0 not inside same smart as 0xf7efc358!
06-07 17:47:23.521+0200 E/EFL     (24361): elementary<24361> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0xf7e1ce88 into part 'elm.swallow.event.0'
06-07 17:47:23.521+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:23:520,1520.000000
06-07 17:47:23.521+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.531+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf7ded1c8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
06-07 17:47:23.531+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.531+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.551+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:535,-0.070000,0.070000,0.070000
06-07 17:47:23.551+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:515,0.367817,-0.186655,9.797972
06-07 17:47:23.551+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.561+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:543,-0.057400,-0.027741,0.082079
06-07 17:47:23.561+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.561+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.561+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:550,0.337388,-0.196211,9.884750
06-07 17:47:23.571+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:567,-0.004108,0.031121,0.081992
06-07 17:47:23.571+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.581+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:23.581+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:23.581+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:567,0.366849,-0.184672,9.798046
06-07 17:47:23.581+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:580,-0.113209,0.019567,0.084311
06-07 17:47:23.581+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.581+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.591+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:593,-0.087874,0.013771,0.079276
06-07 17:47:23.591+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.601+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:599,-0.028121,0.012993,0.098232
06-07 17:47:23.601+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.611+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:573,-0.070000,0.140000,0.070000
06-07 17:47:23.611+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.611+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:595,0.351745,-0.205783,9.875179
06-07 17:47:23.621+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.621+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.621+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:615,-0.057143,0.011902,0.083780
06-07 17:47:23.621+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.631+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:632,-0.013155,-0.015355,0.086037
06-07 17:47:23.631+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.641+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:643,0.002388,-0.024602,0.076429
06-07 17:47:23.641+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.641+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:650,-0.014369,-0.013816,0.050130
06-07 17:47:23.641+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.651+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:655,-0.001639,-0.008290,0.138651
06-07 17:47:23.651+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.661+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:660,-0.036929,-0.041710,0.081203
06-07 17:47:23.661+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.661+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:666,0.005891,0.007917,0.107483
06-07 17:47:23.661+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.671+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:672,0.001198,-0.014026,0.069185
06-07 17:47:23.671+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.671+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:676,-0.041378,0.003096,0.076354
06-07 17:47:23.671+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.671+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:622,0.360655,-0.183662,9.798295
06-07 17:47:23.681+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:682,-0.062752,0.019434,0.083435
06-07 17:47:23.681+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.681+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:687,-0.018636,0.013506,0.104830
06-07 17:47:23.681+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.691+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.691+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:628,0.140000,0.140000,0.070000
06-07 17:47:23.691+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.691+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:635,0.334995,-0.196211,9.848858
06-07 17:47:23.691+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.701+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:692,-0.048405,-0.032889,0.131088
06-07 17:47:23.701+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.701+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:698,0.355938,-0.182884,9.798482
06-07 17:47:23.701+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:706,-0.009682,-0.002842,0.068801
06-07 17:47:23.711+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.711+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.721+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:717,0.353853,-0.181792,9.798577
06-07 17:47:23.721+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.721+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:722,-0.018799,0.019035,0.071185
06-07 17:47:23.731+0200 E/AUL     ( 2479): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-07 17:47:23.731+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.731+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:738,-0.007809,-0.046897,0.085469
06-07 17:47:23.741+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:23.741+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:728,0.350542,-0.180856,9.798714
06-07 17:47:23.741+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.741+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.741+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:23:748,1506.000000
06-07 17:47:23.741+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:707,0.070000,0.140000,0.140000
06-07 17:47:23.751+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:709,0.346959,-0.191426,9.937392
06-07 17:47:23.751+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.751+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.751+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:760,0.070000,0.070000,0.140000
06-07 17:47:23.751+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:749,0.349357,-0.181181,9.798750
06-07 17:47:23.751+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.761+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:752,-0.049885,0.026631,0.090253
06-07 17:47:23.761+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.761+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:764,0.311067,-0.224925,9.879964
06-07 17:47:23.761+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.761+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:764,0.349364,-0.182396,9.798728
06-07 17:47:23.761+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.761+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:770,0.351745,-0.177069,9.906286
06-07 17:47:23.771+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.771+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:23.771+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:23.771+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:776,0.346959,-0.198604,9.868000
06-07 17:47:23.771+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.781+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.781+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:783,0.303888,-0.181855,9.875179
06-07 17:47:23.781+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.781+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:786,0.140000,0.140000,0.070000
06-07 17:47:23.781+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.781+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:789,0.279960,-0.165105,9.882358
06-07 17:47:23.781+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:790,0.140000,0.070000,0.070000
06-07 17:47:23.781+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.781+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.791+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:794,0.320638,-0.169890,9.903893
06-07 17:47:23.791+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:769,-0.037650,0.008608,0.051855
06-07 17:47:23.791+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.791+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.791+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:774,0.348598,-0.183135,9.798741
06-07 17:47:23.791+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.801+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:802,0.289532,-0.215354,9.930215
06-07 17:47:23.801+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.801+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:801,0.019714,0.003155,0.042192
06-07 17:47:23.801+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.801+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:807,0.325424,-0.186640,9.868000
06-07 17:47:23.801+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.811+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:812,0.315853,-0.165105,9.870394
06-07 17:47:23.811+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.811+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:820,0.325424,-0.229711,9.884750
06-07 17:47:23.811+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.821+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:805,0.347996,-0.183216,9.798761
06-07 17:47:23.821+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.821+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:824,0.282353,-0.157926,9.889536
06-07 17:47:23.821+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.821+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:827,0.345854,-0.184986,9.798803
06-07 17:47:23.821+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:829,0.291924,-0.174676,9.851252
06-07 17:47:23.821+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.821+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:809,-0.028535,0.033844,0.087662
06-07 17:47:23.831+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:793,0.140000,0.070000,0.070000
06-07 17:47:23.831+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.831+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.831+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:836,-0.070000,0.070000,0.070000
06-07 17:47:23.831+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.841+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:843,-0.070000,0.070000,0.070000
06-07 17:47:23.841+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:835,0.346959,-0.179462,9.841680
06-07 17:47:23.841+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.841+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.841+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:838,-0.033993,0.008002,0.054069
06-07 17:47:23.841+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.841+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:849,0.070000,0.070000,0.070000
06-07 17:47:23.841+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.841+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.851+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:855,0.070000,0.070000,0.070000
06-07 17:47:23.851+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.861+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:864,-0.070000,0.140000,0.070000
06-07 17:47:23.861+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.861+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:869,0.070000,0.140000,0.070000
06-07 17:47:23.861+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.871+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:847,0.299103,-0.148355,9.887143
06-07 17:47:23.871+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 17:47:23.881+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.891+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:854,0.345761,-0.184578,9.798815
06-07 17:47:23.891+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:852,-0.022690,-0.035365,0.094684
06-07 17:47:23.891+0200 E/EFL     (24361): ecore_x<24361> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=10268665 button=1
06-07 17:47:23.891+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7ded1c8 : elm_scroller] mouse move
06-07 17:47:23.891+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:874,0.070000,0.140000,0.070000
06-07 17:47:23.891+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7ded1c8 : elm_scroller] mouse move
06-07 17:47:23.891+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7ded1c8 : elm_scroller] hold(0), freeze(0)
06-07 17:47:23.901+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.901+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:23.901+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.911+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:23.921+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:23:923,1365.000000
06-07 17:47:23.931+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:914,0.070000,0.070000,0.070000
06-07 17:47:23.941+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7ded1c8 : elm_scroller] mouse move
06-07 17:47:23.941+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7ded1c8 : elm_scroller] hold(0), freeze(0)
06-07 17:47:23.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:47:23.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24361
06-07 17:47:23.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:47:23.961+0200 E/EFL     (24361): ecore_x<24361> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=10268733 button=1
06-07 17:47:23.971+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24361
06-07 17:47:23.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:47:23.971+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:23.971+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:23.971+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:23:917,0.345267,-0.184951,9.798825
06-07 17:47:23.971+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:897,0.291924,-0.172283,9.853643
06-07 17:47:23.981+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:23:916,0.002467,0.016609,0.113818
06-07 17:47:23.981+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:23.981+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:23.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:47:23.991+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:23.991+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:47:24.001+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:23:995,0.070000,0.070000,0.070000
06-07 17:47:24.011+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:47:24.011+0200 W/AUL     (24361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.frailtylauncher)
06-07 17:47:24.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:47:24.011+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 24361
06-07 17:47:24.011+0200 I/AUL_AMD ( 2479): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
06-07 17:47:24.011+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:23:989,0.301496,-0.215354,9.894321
06-07 17:47:24.011+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.021+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:1,0.004941,-0.000921,0.089872
06-07 17:47:24.021+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:0,0.342713,-0.184539,9.798923
06-07 17:47:24.021+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.021+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(2218) > pad pid(-5)
06-07 17:47:24.031+0200 W/AUL_PAD ( 3366): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
06-07 17:47:24.031+0200 W/AUL_PAD ( 3366): launchpad.c: __send_result_to_caller(272) > Check app launching
06-07 17:47:24.031+0200 W/AUL_PAD (24395): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
06-07 17:47:24.031+0200 W/AUL_PAD (24395): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
06-07 17:47:24.031+0200 W/AUL_PAD (24395): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
06-07 17:47:24.031+0200 W/AUL_PAD (24395): launchpad_loader.c: main(680) > [candidate] dlopen(es.ugr.frailty.frailtylauncher)
06-07 17:47:24.031+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 17:47:24.041+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.071+0200 I/efl-extension(24395): efl_extension.c: eext_mod_init(40) > Init
06-07 17:47:24.081+0200 I/UXT     (24395): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-07 17:47:24.081+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:88,0.339274,-0.183397,9.799064
06-07 17:47:24.081+0200 W/AUL_PAD (24395): launchpad_loader.c: main(690) > [candidate] dlsym
06-07 17:47:24.081+0200 W/AUL_PAD (24395): launchpad_loader.c: main(694) > [candidate] dl_main(es.ugr.frailty.frailtylauncher)
06-07 17:47:24.081+0200 I/CAPI_APPFW_APPLICATION(24395): app_main.c: ui_app_main(704) > app_efl_main
06-07 17:47:24.091+0200 I/CAPI_APPFW_APPLICATION(24395): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-07 17:47:24.091+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:99,0.014446,-0.019987,0.056376
06-07 17:47:24.101+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:31,0.070000,0.070000,0.070000
06-07 17:47:24.101+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:28,0.325424,-0.165105,9.913465
06-07 17:47:24.101+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.101+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.111+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:24.121+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:24:120,1501.000000
06-07 17:47:24.121+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.121+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.131+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.frailtylauncher) pid(24395) type(uiapp) bg(0)
06-07 17:47:24.131+0200 W/AUL     (24361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24395)
06-07 17:47:24.131+0200 E/W_TASKMANAGER(24361): task.c: taskmanager_launch_task_info(1075) > [taskmanager_launch_task_info:1075] _launch_app() failed(24395)
06-07 17:47:24.131+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (24395) was created
06-07 17:47:24.141+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24395]
06-07 17:47:24.151+0200 E/AUL     ( 2479): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
06-07 17:47:24.201+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:24.201+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:24.221+0200 E/EFL     (24395): ecore_evas<24395> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
06-07 17:47:24.251+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:114,0.327817,-0.181855,9.889536
06-07 17:47:24.281+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:115,-0.140000,0.070000,0.070000
06-07 17:47:24.281+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.291+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:146,0.016516,0.002249,0.058793
06-07 17:47:24.291+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.301+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.301+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:131,0.337937,-0.182465,9.799127
06-07 17:47:24.301+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.321+0200 I/APP_CORE(24395): appcore-efl.c: __do_app(453) > [APP 24395] Event: RESET State: CREATED
06-07 17:47:24.321+0200 I/CAPI_APPFW_APPLICATION(24395): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-07 17:47:24.331+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:287,0.140000,0.070000,0.070000
06-07 17:47:24.331+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.331+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:301,-0.036507,-0.007669,0.094691
06-07 17:47:24.331+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.341+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:306,0.337388,-0.200997,9.856036
06-07 17:47:24.341+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.341+0200 I/APP_CORE(24395): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
06-07 17:47:24.341+0200 I/APP_CORE(24395): appcore-efl.c: __do_app(524) > [APP 24395] Initial Launching, call the resume_cb
06-07 17:47:24.341+0200 I/CAPI_APPFW_APPLICATION(24395): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-07 17:47:24.341+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:313,0.335106,-0.183798,9.799199
06-07 17:47:24.341+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.341+0200 W/APP_CORE(24395): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3200002
06-07 17:47:24.351+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:24.361+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:24:356,1572.000000
06-07 17:47:24.371+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:339,0.140000,0.140000,0.070000
06-07 17:47:24.381+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:352,0.334651,-0.184140,9.799209
06-07 17:47:24.381+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:348,0.339781,-0.179462,9.858429
06-07 17:47:24.391+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.391+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.391+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:344,-0.000798,-0.029075,0.077871
06-07 17:47:24.401+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.411+0200 I/APP_CORE(24361): appcore-efl.c: __do_app(453) > [APP 24361] Event: PAUSE State: RUNNING
06-07 17:47:24.411+0200 I/CAPI_APPFW_APPLICATION(24361): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 17:47:24.421+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:24.421+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:24.421+0200 I/APP_CORE(24395): appcore-efl.c: __do_app(453) > [APP 24395] Event: RESUME State: RUNNING
06-07 17:47:24.421+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.431+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[24361] goes to (4)
06-07 17:47:24.431+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-taskmanager) pid(24361) status(bg) type(uiapp)
06-07 17:47:24.441+0200 W/STARTER ( 2696): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[24395] goes to (3)
06-07 17:47:24.451+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(24395) status(fg) type(uiapp)
06-07 17:47:24.471+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:403,-0.070000,0.140000,0.070000
06-07 17:47:24.471+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:410,0.287139,-0.189033,9.894321
06-07 17:47:24.471+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.481+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.481+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:420,0.333233,-0.182814,9.799281
06-07 17:47:24.511+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:47:24.511+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:47:24.511+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:47:24.521+0200 I/light   (24482): es.ugr.frailty.light - capturing data
06-07 17:47:24.521+0200 I/light   (24482): es.ugr.frailty.light: SM-R760,07/06/2018,17:47:24:530,1565.000000
06-07 17:47:24.531+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:435,-0.048504,0.036941,0.120963
06-07 17:47:24.531+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.531+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.541+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:486,0.070000,0.140000,0.070000
06-07 17:47:24.551+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:545,0.332238,-0.184557,9.799283
06-07 17:47:24.571+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.581+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:580,0.329574,-0.183285,9.799397
06-07 17:47:24.581+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.591+0200 I/heartrate(24417): es.ugr.frailty.heartrate - capturing data
06-07 17:47:24.591+0200 I/heartrate(24417): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:47:24.591+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.591+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:595,0.327246,-0.182617,9.799487
06-07 17:47:24.591+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.591+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:482,0.320638,-0.210568,9.877571
06-07 17:47:24.601+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer - capturing data
06-07 17:47:24.611+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:47:24:542,-0.010022,0.023166,0.099310
06-07 17:47:24.611+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:602,0.327638,-0.182199,9.799481
06-07 17:47:24.611+0200 I/linearacceleration(24445): es.ugr.frailty.linearacceleration - capturing data
06-07 17:47:24.611+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:47:24:602,0.070000,0.140000,0.070000
06-07 17:47:24.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:47:24.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:47:24.661+0200 I/gyroscope(24414): es.ugr.frailty.gyroscope - capturing data
06-07 17:47:24.671+0200 E/APP_CORE(24361): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
06-07 17:47:24.671+0200 I/APP_CORE(24361): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
06-07 17:47:24.671+0200 I/CAPI_APPFW_APPLICATION(24361): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
06-07 17:47:24.671+0200 I/efl-extension(24361): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0xf7ded1c8, obj: 0xf7ded1c8
06-07 17:47:24.671+0200 I/efl-extension(24361): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
06-07 17:47:24.671+0200 I/efl-extension(24361): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
06-07 17:47:24.671+0200 I/efl-extension(24361): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
06-07 17:47:24.671+0200 I/efl-extension(24361): efl_extension_rotary.c: _object_deleted_cb(618) > done
06-07 17:47:24.671+0200 E/EFL     (24361): elementary<24361> elm_interface_scrollable.c:1962 _elm_scroll_content_region_show_internal() [0xf7ded1c8 : elm_scroller] x(0), y(0), nx(0), px(0), ny(0) py(0)
06-07 17:47:24.681+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0xf7e0b700
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0xf7e29da8 is freed
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7ded1c8, elm_scroller, func : 0xf39ce419
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7e0b700, elm_image, func : 0xf39ce419
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 17:47:24.691+0200 I/efl-extension(24361): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(852) > [0xf7ded1c8 : elm_scroller] rotary callabck is deleted
06-07 17:47:24.701+0200 I/gravity (24464): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:47:24:693,0.325917,-0.180285,9.799575
06-07 17:47:24.701+0200 I/gravity (24464): es.ugr.frailty.gravity - capturing data
06-07 17:47:24.711+0200 I/accelerometer(24411): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:47:24:609,0.272782,-0.145962,9.920642
06-07 17:47:24.721+0200 W/CRASH_MANAGER(24535): worker.c: worker_job(1205) > 11244296c6f63152838644
