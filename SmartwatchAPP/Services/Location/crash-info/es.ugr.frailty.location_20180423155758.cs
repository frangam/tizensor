S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20160
Date: 2018-04-23 15:57:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76cc52d, r5   = 0xf7a66f98
r6   = 0xffbed3a8, r7   = 0xffbed258
r8   = 0xf7a63c18, r9   = 0x00000000
r10  = 0xffbed334, fp   = 0xffbed3a8
ip   = 0x00000001, sp   = 0xffbec0d8
lr   = 0xf76cc539, pc   = 0xf77352b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13892 KB
Buffers:     58116 KB
Cached:     231128 KB
VmPeak:      53460 KB
VmSize:      53388 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12236 KB
VmRSS:       12236 KB
VmData:      11116 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20160 TID = 20160
20160 20163 

Maps Information
f4597000 f4d96000 rw-p [stack:20163]
f4d9d000 f4d9f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4da7000 f4dab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4db4000 f4db6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dbe000 f4dc1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dd0000 f4dd5000 r-xp /usr/lib/libsystem.so.0.0.0
f4de0000 f4de3000 r-xp /lib/libattr.so.1.1.0
f4deb000 f4dfb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e03000 f4e0c000 r-xp /usr/lib/libedbus.so.1.7.99
f4e14000 f4e15000 r-xp /usr/lib/libresponse.so.0.2.96
f4e1e000 f4e23000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66c5000 f67cb000 r-xp /usr/lib/libicuuc.so.57.1
f67e1000 f6969000 r-xp /usr/lib/libicui18n.so.57.1
f6979000 f6986000 r-xp /usr/lib/libail.so.0.1.0
f698f000 f6996000 r-xp /usr/lib/libminizip.so.1.0.0
f699f000 f6b48000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b68000 f6baf000 r-xp /usr/lib/libssl.so.1.0.0
f6bbb000 f6bbd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bc5000 f6bcc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bd5000 f6bdc000 r-xp /lib/libcrypt-2.13.so
f6c0d000 f6c10000 r-xp /lib/libcap.so.2.21
f6c18000 f6c1a000 r-xp /usr/lib/libiri.so
f6c22000 f6c6b000 r-xp /usr/lib/libmdm.so.1.2.69
f6c73000 f6c79000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c81000 f6ca4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cae000 f6cb0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cb8000 f6cd5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cde000 f6ce2000 r-xp /usr/lib/libsmack.so.1.0.0
f6ceb000 f6d04000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d0d000 f6d15000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d1d000 f6d23000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d2c000 f6d2e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d37000 f6d47000 r-xp /lib/libresolv-2.13.so
f6d4b000 f6d63000 r-xp /usr/lib/liblzma.so.5.0.3
f6d6c000 f6d6e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d76000 f6d90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d98000 f6dc7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dd0000 f6ddf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6de9000 f6df3000 r-xp /usr/lib/libsensord-shared.so
f6dfc000 f6ecf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6eda000 f6ef0000 r-xp /lib/libz.so.1.2.5
f6ef8000 f6efd000 r-xp /usr/lib/libffi.so.5.0.10
f6f05000 f6f06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f0e000 f6f1e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f26000 f6f3f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f47000 f6f49000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f51000 f6fc6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fd0000 f6fd6000 r-xp /lib/librt-2.13.so
f6fdf000 f6ffd000 r-xp /usr/lib/libsystemd.so.0.4.0
f7007000 f7008000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7010000 f7033000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f703b000 f7040000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7048000 f7072000 r-xp /usr/lib/libdbus-1.so.3.8.12
f707b000 f7092000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f709a000 f7103000 r-xp /lib/libm-2.13.so
f710c000 f71a0000 r-xp /usr/lib/libstdc++.so.6.0.16
f71b3000 f71b8000 r-xp /usr/lib/libctx-client.so.0.8.3
f71c0000 f71c7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71cf000 f71f9000 r-xp /usr/lib/libsensor.so.1.9.6
f7202000 f72ce000 r-xp /usr/lib/libxml2.so.2.7.8
f72db000 f72dd000 r-xp /usr/lib/libiniparser.so.0
f72e6000 f72ec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72f5000 f73c5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73c6000 f73fa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7403000 f743f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7447000 f744a000 r-xp /usr/lib/libbundle.so.0.1.22
f7452000 f7458000 r-xp /usr/lib/libappsvc.so.0.1.0
f7460000 f74a1000 r-xp /usr/lib/libeina.so.1.7.99
f74aa000 f74c1000 r-xp /usr/lib/libecore.so.1.7.99
f74d8000 f74e1000 r-xp /usr/lib/libvconf.so.0.2.45
f74e9000 f74fd000 r-xp /lib/libpthread-2.13.so
f7508000 f7515000 r-xp /usr/lib/libaul.so.0.1.0
f751f000 f7521000 r-xp /lib/libdl-2.13.so
f752a000 f7535000 r-xp /lib/libunwind.so.8.0.1
f7562000 f756a000 r-xp /lib/libgcc_s-4.6.so.1
f756b000 f768f000 r-xp /lib/libc-2.13.so
f769d000 f769f000 r-xp /usr/lib/libdlog.so.0.0.0
f76a7000 f76b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76bc000 f76c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76c9000 f76d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76e0000 f76e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76ed000 f76f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f76f8000 f76fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7702000 f7706000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f770e000 f772b000 r-xp /lib/ld-2.13.so
f7734000 f7737000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7737000 f773b000 r-xp /usr/lib/libsys-assert.so
f7a33000 f7a95000 rw-p [heap]
ffbce000 ffbef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20160)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf77352b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf76cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73d33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf741875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7415e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7416017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf741a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf77040bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4da8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e7b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7328fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf732a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74baca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74b5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74b65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74b6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77356a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf758285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7734fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
visibility : 0, apptray edit visibility : 0
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:57:54.071+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 15:57:54.081+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 15:57:54.091+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 15:57:54.091+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 15:57:54.091+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 15:57:54.091+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 15:57:54.091+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 15:57:54.101+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 15:57:54.101+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 15:57:54.111+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 15:57:54.111+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 15:57:54.111+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 15:57:54.581+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 15:57:54.881+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:57:55.731+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:57:55.731+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:55.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:55.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:55.751+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20149
04-23 15:57:55.751+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:55.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20149
04-23 15:57:55.801+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20149) type(svcapp) bg(0)
04-23 15:57:55.811+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20149]
04-23 15:57:55.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:55.851+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20149
04-23 15:57:55.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:55.851+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20149)
04-23 15:57:55.851+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:57:55.851+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:55.861+0200 E/CAPI_APPFW_APPLICATION(20149): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:55.861+0200 E/CAPI_APPFW_APPLICATION(20149): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:55.861+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20149) was created
04-23 15:57:55.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:55.881+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20149
04-23 15:57:55.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:55.891+0200 W/LOCATION(20149): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:55.891+0200 E/LOCATION(20149): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:55.891+0200 E/PKGMGR_INFO(20149): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:55.891+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:55.911+0200 I/LOCATION(20149): location.c: location_new(269) > method: 0
04-23 15:57:55.911+0200 W/LOCATION(20149): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:55.921+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:55.921+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:55.931+0200 W/LOCATION(20149): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:55.931+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:55.941+0200 W/LOCATION(20149): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:55.941+0200 W/LOCATION(20149): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:55.941+0200 W/LOCATION(20149): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:55.941+0200 W/LOCATION(20149): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:55.961+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:55.961+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:55.971+0200 W/LOCATION(20149): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:55.971+0200 W/LOCATION(20149): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:55.971+0200 W/LOCATION(20149): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:55.971+0200 W/LOCATION(20149): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:55.971+0200 W/LOCATION(20149): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:55.991+0200 W/LOCATION(20149): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:55.991+0200 I/LOCATION(20149): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf761cc18
04-23 15:57:55.991+0200 I/LOCATION(20149): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:55.991+0200 I/LOCATION(20149): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf761cc18
04-23 15:57:55.991+0200 I/LOCATION(20149): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:55.991+0200 I/location(20149): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:56.041+0200 I/LOCATION(20149): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:56.071+0200 W/LOCATION(20149): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:56.071+0200 W/LOCATION(20149): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:56.071+0200 I/LOCATION(20149): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:56.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:56.131+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:56.131+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:56.131+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:56.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:56.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:56.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:56.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:56.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:56.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:56.141+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:56.141+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:56.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:56.191+0200 W/LOCATION(20149): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:56.191+0200 W/LOCATION(20149): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:56.271+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:56.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e1a570]
04-23 15:57:56.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:56.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:56.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:56.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:56.321+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:56.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:56.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.351+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.351+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:56.351+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:56.351+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:56.351+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:56.351+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:56.351+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:56.351+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:56.351+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:56.351+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:56.361+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.371+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.371+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:56.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:56.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:56.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:56.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:56.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:56.401+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:56.401+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5772069), time2(5764427)
04-23 15:57:56.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:56.401+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:56.401+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:56.401+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:56.431+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:56.441+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:56.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:56.461+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:56.461+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:56.461+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:56.471+0200 W/LOCATION(20149): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:56.471+0200 I/LOCATION(20149): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:56.471+0200 I/LOCATION(20149): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:56.471+0200 I/location(20149): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:56.591+0200 I/LOCATION(20149): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:56.641+0200 W/AUL     (20149): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:56.641+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20149
04-23 15:57:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:56.651+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.651+0200 I/utils   (19708): specific action
04-23 15:57:56.651+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.651+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.651+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:56.651+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:56.651+0200 W/AUL     (20149): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:56.651+0200 I/location(20149): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:56.651+0200 I/location(20149): stopping es.ugr.frailty.location service
04-23 15:57:56.651+0200 E/CAPI_APPFW_APP_CONTROL(20149): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:57:56.651+0200 E/location(20149): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:57:56.651+0200 I/CAPI_APPFW_APPLICATION(20149): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:57:56.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:56.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:56.661+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.661+0200 I/utils   (19713): specific action
04-23 15:57:56.661+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.661+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.661+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.661+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:56.661+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:56.661+0200 I/recorder(19713): guardando datos en local
04-23 15:57:56.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:57:56.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:57:56.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:56.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:56.661+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:56.661+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:56.661+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:56.701+0200 W/LOCATION(20149): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:56.701+0200 I/LOCATION(20149): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:56.701+0200 I/LOCATION(20149): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:57:56.771+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:57:56.771+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:57:56.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:57:56.771+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:56.861+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:56.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:56.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:56.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:56.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a570
04-23 15:57:56.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18c00]
04-23 15:57:56.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:56.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:56.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:56.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:57.001+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:57.001+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:57.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:57.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:57.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:57.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:57.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:57.021+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:57.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:57.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:57.021+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:57.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:57.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:57.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:57.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:57.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:57.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:57.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:57.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18c00
04-23 15:57:57.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e37a28]
04-23 15:57:57.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:57.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:57.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:57.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:57.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:57.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:57.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.341+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:57.341+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:57.341+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:57.341+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:57.341+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:57.341+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:57.341+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:57.341+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:57.341+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:57.351+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.371+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:57.371+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:57.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:57.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:57.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:57.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:57.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:57.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e37a28
04-23 15:57:57.631+0200 W/AUL     (20159): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:57:57.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:57:57.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:57:57.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20149
04-23 15:57:57.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:57:57.641+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20149
04-23 15:57:57.641+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20149)
04-23 15:57:57.861+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:57:57.861+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:57.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:57.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:57.881+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20160
04-23 15:57:57.881+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:57.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20160
04-23 15:57:57.931+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20160) type(svcapp) bg(0)
04-23 15:57:57.941+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20160]
04-23 15:57:57.961+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20160)
04-23 15:57:57.961+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:57:57.961+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:57.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:57.971+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20160
04-23 15:57:57.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:57.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:57.991+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20160
04-23 15:57:57.991+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:58.001+0200 E/CAPI_APPFW_APPLICATION(20160): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:58.001+0200 E/CAPI_APPFW_APPLICATION(20160): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:58.001+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20160) was created
04-23 15:57:58.031+0200 W/LOCATION(20160): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:58.031+0200 E/LOCATION(20160): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:58.031+0200 E/PKGMGR_INFO(20160): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:58.041+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:58.051+0200 I/LOCATION(20160): location.c: location_new(269) > method: 0
04-23 15:57:58.061+0200 W/LOCATION(20160): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:58.061+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:58.071+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:58.071+0200 W/LOCATION(20160): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:58.071+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:58.081+0200 W/LOCATION(20160): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:58.081+0200 W/LOCATION(20160): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:58.081+0200 W/LOCATION(20160): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:58.081+0200 W/LOCATION(20160): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:58.101+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:58.101+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:58.101+0200 W/LOCATION(20160): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:58.111+0200 W/LOCATION(20160): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:58.111+0200 W/LOCATION(20160): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:58.111+0200 W/LOCATION(20160): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:58.111+0200 W/LOCATION(20160): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:58.121+0200 W/LOCATION(20160): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:58.121+0200 I/LOCATION(20160): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a63c18
04-23 15:57:58.121+0200 I/LOCATION(20160): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:58.121+0200 I/LOCATION(20160): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a63c18
04-23 15:57:58.121+0200 I/LOCATION(20160): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:58.131+0200 I/location(20160): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:58.171+0200 I/LOCATION(20160): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:58.211+0200 W/LOCATION(20160): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:58.211+0200 W/LOCATION(20160): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:58.211+0200 I/LOCATION(20160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:58.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:58.271+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:58.271+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:58.271+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:58.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:58.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:58.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:58.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:58.271+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:58.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:58.281+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:58.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:58.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:58.331+0200 W/LOCATION(20160): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:58.331+0200 W/LOCATION(20160): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:58.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:58.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:58.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:58.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:58.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:58.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01b78]
04-23 15:57:58.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:58.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:58.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:58.461+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:58.471+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:58.471+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:58.471+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.481+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.481+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:58.481+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:58.481+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:58.491+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:58.491+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:58.491+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:58.491+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:58.491+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:58.491+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:58.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.511+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.511+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:58.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:58.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:58.551+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5774216), time2(5764427)
04-23 15:57:58.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:58.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:58.551+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:58.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:58.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:58.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:58.601+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:58.601+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:58.601+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:58.621+0200 W/LOCATION(20160): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:58.621+0200 I/LOCATION(20160): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:58.621+0200 I/LOCATION(20160): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:58.621+0200 I/location(20160): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:58.661+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:57:58.731+0200 I/LOCATION(20160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:58.771+0200 W/AUL     (20160): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:58.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:58.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20160
04-23 15:57:58.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:58.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.791+0200 I/utils   (19708): specific action
04-23 15:57:58.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.791+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.791+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:58.791+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:58.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:58.791+0200 W/AUL     (20160): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:58.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:58.791+0200 I/location(20160): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:58.791+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:58.791+0200 W/CAPI_APPFW_APP_CONTROL(20160): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.791+0200 I/utils   (20160): specific action
04-23 15:57:58.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:58.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.801+0200 I/utils   (19713): specific action
04-23 15:57:58.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.801+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:58.801+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:58.801+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:58.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:58.801+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:58.801+0200 I/recorder(19713): guardando datos en local
04-23 15:57:58.801+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:58.801+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:58.831+0200 I/LOCATION(20160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:58.931+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11201606c6f63152449187
