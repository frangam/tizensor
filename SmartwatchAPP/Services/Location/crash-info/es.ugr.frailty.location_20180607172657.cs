S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21822
Date: 2018-06-07 17:26:57+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75cc52d, r5   = 0xf7a8ef98
r6   = 0xff824300, r7   = 0xff8241b0
r8   = 0xf7a8bc18, r9   = 0x00000000
r10  = 0xff82428c, fp   = 0xff824300
ip   = 0x00000001, sp   = 0xff824188
lr   = 0xf75cc539, pc   = 0xf7635228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    279080 KB
Buffers:      6564 KB
Cached:     112952 KB
VmPeak:      52404 KB
VmSize:      52400 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11816 KB
VmRSS:       11816 KB
VmData:      10128 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21822 TID = 21822
21822 21911 

Maps Information
f4497000 f4c96000 rw-p [stack:21911]
f4c9d000 f4c9f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ca7000 f4cab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cb4000 f4cb6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cbe000 f4cc1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cd0000 f4cd5000 r-xp /usr/lib/libsystem.so.0.0.0
f4ce0000 f4ce3000 r-xp /lib/libattr.so.1.1.0
f4ceb000 f4cfb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d03000 f4d0c000 r-xp /usr/lib/libedbus.so.1.7.99
f4d14000 f4d15000 r-xp /usr/lib/libresponse.so.0.2.96
f4d1e000 f4d23000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65c5000 f66cb000 r-xp /usr/lib/libicuuc.so.57.1
f66e1000 f6869000 r-xp /usr/lib/libicui18n.so.57.1
f6879000 f6886000 r-xp /usr/lib/libail.so.0.1.0
f688f000 f6896000 r-xp /usr/lib/libminizip.so.1.0.0
f689f000 f6a48000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a68000 f6aaf000 r-xp /usr/lib/libssl.so.1.0.0
f6abb000 f6abd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ac5000 f6acc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ad5000 f6adc000 r-xp /lib/libcrypt-2.13.so
f6b0d000 f6b10000 r-xp /lib/libcap.so.2.21
f6b18000 f6b1a000 r-xp /usr/lib/libiri.so
f6b22000 f6b6b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b73000 f6b79000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b81000 f6ba4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bae000 f6bb0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bb8000 f6bd5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bde000 f6be2000 r-xp /usr/lib/libsmack.so.1.0.0
f6beb000 f6c04000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c0d000 f6c15000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c1d000 f6c23000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c2c000 f6c2e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c37000 f6c47000 r-xp /lib/libresolv-2.13.so
f6c4b000 f6c63000 r-xp /usr/lib/liblzma.so.5.0.3
f6c6c000 f6c6e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c76000 f6c90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c98000 f6cc7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cd0000 f6cdf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ce9000 f6cf3000 r-xp /usr/lib/libsensord-shared.so
f6cfc000 f6dcf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dda000 f6df0000 r-xp /lib/libz.so.1.2.5
f6df8000 f6dfd000 r-xp /usr/lib/libffi.so.5.0.10
f6e05000 f6e06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e0e000 f6e1e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e26000 f6e3f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e47000 f6e49000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e51000 f6ec6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ed0000 f6ed6000 r-xp /lib/librt-2.13.so
f6edf000 f6efd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f07000 f6f08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f10000 f6f33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3b000 f6f40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f48000 f6f72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7b000 f6f92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9a000 f7003000 r-xp /lib/libm-2.13.so
f700c000 f70a0000 r-xp /usr/lib/libstdc++.so.6.0.16
f70b3000 f70b8000 r-xp /usr/lib/libctx-client.so.0.8.3
f70c0000 f70c7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70cf000 f70f9000 r-xp /usr/lib/libsensor.so.1.9.6
f7102000 f71ce000 r-xp /usr/lib/libxml2.so.2.7.8
f71db000 f71dd000 r-xp /usr/lib/libiniparser.so.0
f71e6000 f71ec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71f5000 f72c5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72c6000 f72fa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7303000 f733f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7347000 f734a000 r-xp /usr/lib/libbundle.so.0.1.22
f7352000 f7358000 r-xp /usr/lib/libappsvc.so.0.1.0
f7360000 f73a1000 r-xp /usr/lib/libeina.so.1.7.99
f73aa000 f73c1000 r-xp /usr/lib/libecore.so.1.7.99
f73d8000 f73e1000 r-xp /usr/lib/libvconf.so.0.2.45
f73e9000 f73fd000 r-xp /lib/libpthread-2.13.so
f7408000 f7415000 r-xp /usr/lib/libaul.so.0.1.0
f741f000 f7421000 r-xp /lib/libdl-2.13.so
f742a000 f7435000 r-xp /lib/libunwind.so.8.0.1
f7462000 f746a000 r-xp /lib/libgcc_s-4.6.so.1
f746b000 f758f000 r-xp /lib/libc-2.13.so
f759d000 f759f000 r-xp /usr/lib/libdlog.so.0.0.0
f75a7000 f75b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75bc000 f75c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75c9000 f75d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75e0000 f75e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ed000 f75f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f75f8000 f75fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7602000 f7606000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f760e000 f762b000 r-xp /lib/ld-2.13.so
f7634000 f7637000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7637000 f763b000 r-xp /usr/lib/libsys-assert.so
f7a5b000 f7aca000 rw-p [heap]
ff805000 ff826000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21822)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7635228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72d33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7315e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7316017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf731df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cb51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ca8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d7b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7228fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf722a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73baca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73b5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73b65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73b6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76355c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf748285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7634f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
( 2762): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): main.c: _appcore_pause_cb(488) > appcore pause
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 17:28:08.101+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xee468850
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xee468850, elm_layout, func : 0xf7719d05
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xee468850, activated : 1
06-07 17:28:08.101+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 17:28:08.101+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 17:28:08.101+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 17:28:08.101+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 17:28:08.111+0200 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 17:28:08.111+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 17:28:08.121+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-07 17:28:08.141+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1383739031, next duetime: 1528385308
06-07 17:28:08.141+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1383739031)
06-07 17:28:08.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1528408106), due_time(1528385308)
06-07 17:28:08.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 17:28:08.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 17:28:08.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 15:28:28 (UTC).
06-07 17:28:08.151+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 17:28:08.161+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 17:28:08.171+0200 E/CAPI_APPFW_APP_CONTROL( 3247): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-07 17:28:08.181+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3247]   [com.samsung.w-home]register msg port [false][0m
06-07 17:28:08.181+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 17:28:08.181+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 17:28:08.181+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 17:28:08.191+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 17:28:08.191+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 17:28:08.191+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 17:28:08.191+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:72,0.140000,0.070000,0.070000
06-07 17:28:08.191+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.201+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:80,-0.012478,-0.034877,-0.005192
06-07 17:28:08.211+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:198,0.308702,-0.093340,9.801346
06-07 17:28:08.221+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:82,0.318245,-0.098106,9.824929
06-07 17:28:08.221+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.221+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:08.221+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:08.221+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.221+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.221+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:231,-0.003917,-0.001713,0.061761
06-07 17:28:08.231+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:204,0.070000,0.070000,0.070000
06-07 17:28:08.231+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:08.241+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:08:245,1210.000000
06-07 17:28:08.251+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.251+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:259,0.070000,0.070000,0.070000
06-07 17:28:08.261+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:237,0.323031,-0.059821,9.772287
06-07 17:28:08.261+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:255,0.307379,-0.092791,9.801393
06-07 17:28:08.261+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.271+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.271+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.301+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.301+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:306,0.140000,0.070000,0.070000
06-07 17:28:08.301+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:274,0.042683,-0.067345,-0.002870
06-07 17:28:08.301+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:285,0.310068,-0.092888,9.801307
06-07 17:28:08.311+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.311+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.311+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:281,0.320638,-0.093320,9.817751
06-07 17:28:08.311+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.311+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.321+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:325,0.332602,-0.090927,9.865608
06-07 17:28:08.331+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:321,0.309525,-0.089351,9.801357
06-07 17:28:08.331+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:326,0.070000,0.070000,0.070000
06-07 17:28:08.331+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:317,0.014087,-0.050472,0.044984
06-07 17:28:08.331+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.341+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.341+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.341+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.341+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:348,0.308648,-0.089204,9.801386
06-07 17:28:08.361+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:366,0.070000,0.070000,0.070000
06-07 17:28:08.361+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:355,0.315853,-0.057428,9.824929
06-07 17:28:08.361+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:343,0.016203,0.046066,0.028346
06-07 17:28:08.361+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.371+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.371+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.371+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.391+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:391,0.306827,-0.088821,9.801446
06-07 17:28:08.401+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:376,0.013807,-0.009499,-0.000350
06-07 17:28:08.401+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.401+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:392,0.337388,-0.095713,9.803394
06-07 17:28:08.401+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:387,-0.070000,0.070000,0.070000
06-07 17:28:08.401+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.401+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.401+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.411+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:420,0.306698,-0.089885,9.801441
06-07 17:28:08.421+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:08.421+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:08.421+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:409,0.006441,0.023932,0.030741
06-07 17:28:08.431+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:08.441+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:08:440,1206.000000
06-07 17:28:08.441+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:418,0.294317,-0.129212,9.834501
06-07 17:28:08.451+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:416,0.140000,0.070000,0.070000
06-07 17:28:08.451+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.451+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.451+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.451+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.461+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:459,0.008581,-0.018744,0.030752
06-07 17:28:08.481+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:465,0.305415,-0.089166,9.801487
06-07 17:28:08.501+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:462,0.070000,0.070000,0.070000
06-07 17:28:08.501+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:467,0.289532,-0.145962,9.791430
06-07 17:28:08.501+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.501+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.511+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.511+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.521+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:513,-0.019655,-0.020243,0.040295
06-07 17:28:08.531+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:524,0.306033,-0.090572,9.801455
06-07 17:28:08.531+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:529,0.320638,-0.100499,9.793823
06-07 17:28:08.541+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:523,0.070000,0.070000,0.070000
06-07 17:28:08.541+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.541+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.541+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.561+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.561+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:568,0.287139,-0.112463,9.812965
06-07 17:28:08.561+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:554,0.030576,-0.000330,0.025945
06-07 17:28:08.571+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:556,0.305845,-0.090972,9.801457
06-07 17:28:08.571+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:557,0.140000,0.070000,0.070000
06-07 17:28:08.571+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.581+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.581+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.581+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.591+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:595,0.070000,0.070000,0.070000
06-07 17:28:08.601+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:601,0.351745,-0.098106,9.877571
06-07 17:28:08.621+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 17:28:08.621+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:08.621+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:08.621+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:592,0.036497,0.019617,0.045059
06-07 17:28:08.621+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.631+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:599,0.307380,-0.089809,9.801420
06-07 17:28:08.631+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.631+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:08.631+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:08:640,1187.000000
06-07 17:28:08.641+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:645,0.140000,0.070000,0.070000
06-07 17:28:08.641+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.651+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.651+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:656,0.308460,-0.089221,9.801392
06-07 17:28:08.661+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:664,0.318245,-0.081356,9.839286
06-07 17:28:08.661+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:637,-0.003080,-0.004462,0.035526
06-07 17:28:08.661+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.671+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.671+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:677,0.070000,0.070000,0.070000
06-07 17:28:08.681+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.681+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.691+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:695,0.351745,-0.102891,9.810574
06-07 17:28:08.711+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:686,-0.005441,0.013760,-0.004972
06-07 17:28:08.711+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.711+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.711+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:694,0.307624,-0.089076,9.801419
06-07 17:28:08.711+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.721+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.721+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:727,0.307702,-0.088602,9.801421
06-07 17:28:08.731+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:718,0.070000,0.070000,0.070000
06-07 17:28:08.731+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:736,0.311067,-0.088534,9.858429
06-07 17:28:08.741+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:723,-0.007990,-0.007746,0.006864
06-07 17:28:08.741+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.741+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.741+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.751+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:755,0.308614,-0.086996,9.801407
06-07 17:28:08.751+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.761+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:765,0.325424,-0.074178,9.812965
06-07 17:28:08.771+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:752,0.140000,0.070000,0.070000
06-07 17:28:08.771+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.781+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:755,-0.003746,0.018163,0.064059
06-07 17:28:08.781+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.781+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.781+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:788,0.308304,-0.085543,9.801429
06-07 17:28:08.791+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.791+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:792,0.140000,0.070000,0.070000
06-07 17:28:08.801+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:805,0.311067,-0.114855,9.812965
06-07 17:28:08.811+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.811+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:794,-0.015710,-0.058407,0.064059
06-07 17:28:08.811+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.811+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.821+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:08.821+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:08.821+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.831+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:08.831+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:08:841,1101.000000
06-07 17:28:08.841+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:826,0.070000,0.070000,0.070000
06-07 17:28:08.851+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:820,0.309188,-0.084764,9.801408
06-07 17:28:08.851+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:830,0.015765,-0.022791,0.061447
06-07 17:28:08.861+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:833,0.294317,-0.100499,9.858429
06-07 17:28:08.861+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.861+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.881+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.881+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.881+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:891,0.311067,-0.107677,9.824929
06-07 17:28:08.891+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:886,0.070000,0.070000,0.070000
06-07 17:28:08.891+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:872,0.307806,-0.084428,9.801455
06-07 17:28:08.891+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.901+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.901+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:895,0.050750,0.159411,0.499505
06-07 17:28:08.901+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.911+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.921+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:907,0.306669,-0.085796,9.801478
06-07 17:28:08.931+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:910,0.140000,0.070000,0.070000
06-07 17:28:08.931+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:918,0.320638,-0.098106,9.810574
06-07 17:28:08.941+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.941+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.951+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.951+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:933,0.032794,0.019880,0.040088
06-07 17:28:08.961+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:08.961+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:950,0.070000,0.070000,0.070000
06-07 17:28:08.971+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:952,0.306551,-0.085919,9.801481
06-07 17:28:08.971+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:960,0.260818,-0.083749,9.808180
06-07 17:28:08.981+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:08.981+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:08.981+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:08:987,0.070000,0.070000,0.070000
06-07 17:28:08.981+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:08.991+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:08:995,0.330210,-0.105284,9.834501
06-07 17:28:08.991+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:08:967,-0.035072,-0.059592,0.004164
06-07 17:28:08.991+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.001+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:5,0.003459,-0.015855,0.033233
06-07 17:28:09.011+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:08:991,0.309221,-0.089137,9.801369
06-07 17:28:09.011+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.011+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.011+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:17,0.140000,0.070000,0.070000
06-07 17:28:09.011+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.031+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:09.031+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:09.031+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.031+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:09.041+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:09:43,1100.000000
06-07 17:28:09.041+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:22,0.309224,-0.091000,9.801352
06-07 17:28:09.051+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.051+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.051+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:25,0.294317,-0.088534,9.789038
06-07 17:28:09.051+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.061+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:47,0.095528,0.038176,0.147794
06-07 17:28:09.071+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.071+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:67,0.378066,-0.098106,9.853643
06-07 17:28:09.081+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:92,0.017037,-0.025598,-0.055376
06-07 17:28:09.091+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:61,0.309411,-0.088538,9.801368
06-07 17:28:09.091+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:60,0.140000,0.070000,0.070000
06-07 17:28:09.091+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.091+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.091+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:100,0.140000,0.070000,0.070000
06-07 17:28:09.101+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.101+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:106,0.306281,-0.023928,9.834501
06-07 17:28:09.121+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.121+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:103,0.309665,-0.088933,9.801356
06-07 17:28:09.121+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:129,0.174749,-0.055615,0.206146
06-07 17:28:09.121+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.121+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.131+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.131+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:137,0.309186,-0.087434,9.801385
06-07 17:28:09.131+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:135,0.070000,-0.070000,0.070000
06-07 17:28:09.141+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.141+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:149,0.080146,-0.095460,-0.011175
06-07 17:28:09.151+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.151+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.151+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:145,0.306281,-0.093320,9.832108
06-07 17:28:09.161+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.151+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.161+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:165,0.070000,-0.070000,0.140000
06-07 17:28:09.171+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:160,0.309205,-0.088204,9.801377
06-07 17:28:09.181+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.181+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:170,0.287139,-0.088534,9.879964
06-07 17:28:09.181+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.191+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.201+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:180,-0.094904,-0.009549,0.036407
06-07 17:28:09.201+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:206,0.311067,-0.114855,9.796216
06-07 17:28:09.211+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.211+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:195,0.070000,-0.070000,0.070000
06-07 17:28:09.221+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:200,0.308070,-0.089009,9.801406
06-07 17:28:09.221+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:09.221+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:09.221+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:224,1.799505,2.001712,-2.214413
06-07 17:28:09.231+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.231+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.231+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:09.241+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:09:242,1151.000000
06-07 17:28:09.241+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.261+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.261+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:265,0.289532,-0.078963,9.846465
06-07 17:28:09.271+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:238,0.309362,-0.088858,9.801367
06-07 17:28:09.271+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:237,0.070000,0.070000,0.070000
06-07 17:28:09.271+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:267,-0.000202,0.023307,0.052877
06-07 17:28:09.281+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.281+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.281+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.291+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:295,0.330210,-0.126820,9.846465
06-07 17:28:09.301+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.311+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:287,0.140000,0.070000,0.070000
06-07 17:28:09.311+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:294,0.316508,-0.083152,9.801188
06-07 17:28:09.311+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.311+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.311+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.321+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:325,-0.070000,0.070000,0.070000
06-07 17:28:09.331+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:317,-5.258852,-0.191495,1.637110
06-07 17:28:09.341+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.341+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:325,0.311878,-0.085574,9.801316
06-07 17:28:09.341+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.351+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.351+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:341,0.311067,-0.102891,9.827322
06-07 17:28:09.361+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.361+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:348,-3.685776,-0.075248,0.842482
06-07 17:28:09.371+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.371+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:363,-0.070000,0.070000,0.140000
06-07 17:28:09.381+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:367,0.310483,-0.079233,9.801414
06-07 17:28:09.381+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.381+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.381+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:371,0.354138,-0.069392,9.853643
06-07 17:28:09.401+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.401+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:401,0.305241,-0.082770,9.801549
06-07 17:28:09.411+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:392,0.140000,0.070000,0.140000
06-07 17:28:09.411+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:378,-1.945990,-0.088966,0.250370
06-07 17:28:09.411+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.421+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:09.421+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:09.421+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.421+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.431+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:410,0.346959,-0.083749,9.801002
06-07 17:28:09.431+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:09.441+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:09:441,1205.000000
06-07 17:28:09.451+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.451+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:426,-1.024955,0.004664,0.146100
06-07 17:28:09.461+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.461+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:432,0.070000,0.070000,0.070000
06-07 17:28:09.461+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:469,0.002996,-0.031691,0.044932
06-07 17:28:09.471+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.481+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:449,0.300088,-0.075315,9.801768
06-07 17:28:09.481+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.491+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:490,0.298602,-0.099590,9.801597
06-07 17:28:09.581+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:487,0.070000,0.070000,0.070000
06-07 17:28:09.581+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.591+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:457,0.306281,-0.093320,9.841680
06-07 17:28:09.591+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.591+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:597,0.299809,-0.096451,9.801592
06-07 17:28:09.591+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.601+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.601+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:604,-0.007008,-0.090085,0.014009
06-07 17:28:09.611+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:600,0.325424,-0.086142,9.834501
06-07 17:28:09.611+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:615,0.140000,0.070000,0.070000
06-07 17:28:09.611+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.611+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.621+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:09.621+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:09.621+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.641+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:09.641+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:09:647,1229.000000
06-07 17:28:09.651+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:623,0.310247,-0.048085,9.801623
06-07 17:28:09.651+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.661+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.661+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:625,0.334995,-0.057428,9.853643
06-07 17:28:09.661+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:668,0.319572,-0.058322,9.801269
06-07 17:28:09.671+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.671+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:636,0.008700,-0.019281,0.047585
06-07 17:28:09.681+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.681+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:659,0.070000,0.070000,0.070000
06-07 17:28:09.681+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.691+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.701+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:684,0.306281,-0.059821,9.839286
06-07 17:28:09.701+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:695,0.070000,-0.070000,0.140000
06-07 17:28:09.701+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.701+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:691,0.008054,0.041581,0.074166
06-07 17:28:09.721+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.721+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.721+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:703,0.306466,-0.076462,9.801562
06-07 17:28:09.731+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.731+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:712,0.332602,-0.071785,9.822537
06-07 17:28:09.731+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.751+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:745,0.313173,-0.077293,9.801343
06-07 17:28:09.751+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:726,0.004116,0.025109,0.031124
06-07 17:28:09.751+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.751+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:733,0.070000,-0.070000,0.070000
06-07 17:28:09.761+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.761+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:748,0.289532,-0.081356,9.810574
06-07 17:28:09.761+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:770,0.070000,-0.070000,0.070000
06-07 17:28:09.771+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.771+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.771+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:781,0.337315,-0.064026,9.800638
06-07 17:28:09.781+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:785,0.296710,-0.119641,9.796216
06-07 17:28:09.781+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:763,-0.010873,-0.035447,-0.007257
06-07 17:28:09.791+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.791+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:796,0.006670,-0.050348,0.073778
06-07 17:28:09.791+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.801+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.801+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.801+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:807,0.345776,-0.081609,9.800213
06-07 17:28:09.811+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:815,0.303888,-0.086142,9.863215
06-07 17:28:09.821+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.821+0200 I/heartrate(22302): es.ugr.frailty.heartrate - capturing data
06-07 17:28:09.821+0200 I/heartrate(22302): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:28:09.821+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:803,0.070000,-0.070000,0.070000
06-07 17:28:09.821+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.821+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:28:09:831,0.070000,-0.070000,0.070000
06-07 17:28:09.821+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.831+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:826,0.019255,-0.067013,-0.031575
06-07 17:28:09.831+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer - capturing data
06-07 17:28:09.831+0200 I/light   (22334): es.ugr.frailty.light - capturing data
06-07 17:28:09.841+0200 I/light   (22334): es.ugr.frailty.light: SM-R760,07/06/2018,17:28:09:844,1245.000000
06-07 17:28:09.851+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration - capturing data
06-07 17:28:09.851+0200 I/linearacceleration(22318): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:28:09:856,0.013858,0.001053,0.136119
06-07 17:28:09.861+0200 I/accelerometer(22297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:28:09:851,0.349352,-0.153141,9.798609
06-07 17:28:09.861+0200 I/gyroscope(22300): es.ugr.frailty.gyroscope - capturing data
06-07 17:28:09.871+0200 I/gravity (22325): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:28:09:838,0.398793,-0.093342,9.798094
06-07 17:28:09.871+0200 I/gravity (22325): es.ugr.frailty.gravity - capturing data
06-07 17:28:09.871+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11218226c6f63152838521
