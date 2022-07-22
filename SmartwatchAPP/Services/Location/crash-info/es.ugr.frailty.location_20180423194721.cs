S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22160
Date: 2018-04-23 19:47:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75cc52d, r5   = 0xf7df2f98
r6   = 0xff893978, r7   = 0xff893828
r8   = 0xf7defc18, r9   = 0x00000000
r10  = 0xff893904, fp   = 0xff893978
ip   = 0x00000001, sp   = 0xff893800
lr   = 0xf75cc539, pc   = 0xf7635228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16084 KB
Buffers:     57860 KB
Cached:     226028 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12004 KB
VmRSS:       12004 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22160 TID = 22160
22160 22212 

Maps Information
f4497000 f4c96000 rw-p [stack:22212]
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
f7dbf000 f7e49000 rw-p [heap]
ff875000 ff896000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22160)
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
15: (0xf731a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf76040bb) [/usr/lib/location/module/libgps.so] + 0x20bb
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
27: main + 0xda (0xf76354f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
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
-23 19:47:16.769+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:16.769+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:16.769+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:16.769+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:16.769+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:16.769+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:16.769+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:16.779+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:16.789+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:16.789+0200 E/LOCATION(21673): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:47:16.789+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:16.839+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:16.859+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 19:47:16.859+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 19:47:16.859+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 19:47:16.859+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_destroy(471) > Destroy handle: 0xf401e8c8
04-23 19:47:16.889+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:47:17.369+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:47:17.609+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:47:19.389+0200 I/servicemanager(21592): es.ugr.frailty.accelerometer alive timeout
04-23 19:47:19.389+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 19:47:19.389+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:19.389+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:19.399+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:19.409+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22134
04-23 19:47:19.439+0200 E/CAPI_APPFW_APPLICATION(22134): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:19.439+0200 E/CAPI_APPFW_APPLICATION(22134): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:19.439+0200 I/utils   (22134): trying to start service: es.ugr.frailty.accelerometer
04-23 19:47:19.449+0200 I/utils   (22134): es.ugr.frailty.accelerometer sensor supported
04-23 19:47:19.459+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22134
04-23 19:47:19.459+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22134) type(svcapp) bg(0)
04-23 19:47:19.459+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22134) was created
04-23 19:47:19.459+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22134)
04-23 19:47:19.459+0200 I/servicemanager(21592): es.ugr.frailty.accelerometer launch request sent!
04-23 19:47:19.459+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:19.459+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22134]
04-23 19:47:19.459+0200 I/utils   (22134): es.ugr.frailty.accelerometer listener started
04-23 19:47:19.459+0200 W/CAPI_APPFW_APP_CONTROL(22134): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:19.459+0200 I/utils   (22134): specific action
04-23 19:47:19.479+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:19.479+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:19.489+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22134
04-23 19:47:19.489+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:19.489+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:19:484,4.130012,-8.458629,-3.256632
04-23 19:47:19.489+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:19.499+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22134
04-23 19:47:19.509+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:19.679+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:19.679+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:19:684,4.161119,-8.662018,-3.342773
04-23 19:47:19.699+0200 I/servicemanager(21592): es.ugr.frailty.gyroscope alive timeout
04-23 19:47:19.699+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 19:47:19.699+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:19.699+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:19.709+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22147
04-23 19:47:19.709+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:19.749+0200 E/CAPI_APPFW_APPLICATION(22147): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:19.749+0200 E/CAPI_APPFW_APPLICATION(22147): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:19.749+0200 I/utils   (22147): trying to start service: es.ugr.frailty.gyroscope
04-23 19:47:19.749+0200 I/utils   (22147): es.ugr.frailty.gyroscope sensor supported
04-23 19:47:19.759+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22147
04-23 19:47:19.759+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(22147) type(svcapp) bg(0)
04-23 19:47:19.759+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22147) was created
04-23 19:47:19.769+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22147]
04-23 19:47:19.769+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22147)
04-23 19:47:19.769+0200 I/servicemanager(21592): es.ugr.frailty.gyroscope launch request sent!
04-23 19:47:19.769+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:19.779+0200 I/utils   (22147): es.ugr.frailty.gyroscope listener started
04-23 19:47:19.779+0200 W/CAPI_APPFW_APP_CONTROL(22147): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:19.779+0200 I/utils   (22147): specific action
04-23 19:47:19.779+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:19.789+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22147
04-23 19:47:19.789+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:19.809+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:19.809+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22147
04-23 19:47:19.819+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:19.879+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:19.879+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:19:885,3.924229,-8.422735,-2.902494
04-23 19:47:19.879+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:19.889+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:19:890,-8.260000,3.290000,1.260000
04-23 19:47:20.079+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:20.079+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:20.079+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:20:84,-0.700000,1.470000,2.940000
04-23 19:47:20.089+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:20:85,3.936193,-8.480164,-3.093920
04-23 19:47:20.149+0200 I/servicemanager(21592): es.ugr.frailty.location alive timeout
04-23 19:47:20.149+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:47:20.159+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:20.159+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:20.169+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22160
04-23 19:47:20.169+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:20.219+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22160
04-23 19:47:20.219+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22160) type(svcapp) bg(0)
04-23 19:47:20.219+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22160)
04-23 19:47:20.219+0200 I/servicemanager(21592): es.ugr.frailty.location launch request sent!
04-23 19:47:20.219+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:20.219+0200 I/servicemanager(21592): es.ugr.frailty.linearacceleration alive timeout
04-23 19:47:20.219+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
04-23 19:47:20.219+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22160]
04-23 19:47:20.219+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:20.219+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:20.239+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22163
04-23 19:47:20.239+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:20.269+0200 E/CAPI_APPFW_APPLICATION(22160): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.279+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:20.279+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:20:285,3.986443,-8.659625,-3.426522
04-23 19:47:20.279+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:20.289+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22163
04-23 19:47:20.289+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.linearacceleration) pid(22163) type(svcapp) bg(0)
04-23 19:47:20.289+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.289+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22163]
04-23 19:47:20.299+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22160
04-23 19:47:20.299+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.309+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.319+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:20:292,1.050000,3.220000,-1.960000
04-23 19:47:20.319+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22163
04-23 19:47:20.319+0200 E/CAPI_APPFW_APPLICATION(22160): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.319+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.329+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22163)
04-23 19:47:20.329+0200 I/servicemanager(21592): es.ugr.frailty.linearacceleration launch request sent!
04-23 19:47:20.329+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:20.329+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22160) was created
04-23 19:47:20.339+0200 E/CAPI_APPFW_APPLICATION(22163): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.339+0200 E/CAPI_APPFW_APPLICATION(22163): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.349+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22163) was created
04-23 19:47:20.349+0200 I/utils   (22163): trying to start service: es.ugr.frailty.linearacceleration
04-23 19:47:20.349+0200 I/utils   (22163): es.ugr.frailty.linearacceleration sensor supported
04-23 19:47:20.349+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.359+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22160
04-23 19:47:20.359+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.379+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.389+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22163
04-23 19:47:20.389+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.399+0200 I/utils   (22163): es.ugr.frailty.linearacceleration listener started
04-23 19:47:20.399+0200 W/CAPI_APPFW_APP_CONTROL(22163): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:20.399+0200 I/utils   (22163): specific action
04-23 19:47:20.449+0200 W/LOCATION(22160): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 19:47:20.449+0200 E/LOCATION(22160): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 19:47:20.449+0200 E/PKGMGR_INFO(22160): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 19:47:20.459+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:20.479+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:20.479+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:20.479+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:20.489+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:20:489,-5.180000,1.050000,2.520000
04-23 19:47:20.489+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:20:489,3.873980,-8.563912,-3.395415
04-23 19:47:20.489+0200 I/LOCATION(22160): location.c: location_new(269) > method: 0
04-23 19:47:20.489+0200 W/LOCATION(22160): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:20.489+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:20:492,1.170753,0.588581,-5.652582
04-23 19:47:20.489+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:20.499+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:20.499+0200 W/LOCATION(22160): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:20.499+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:20.509+0200 W/LOCATION(22160): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:20.509+0200 W/LOCATION(22160): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:20.509+0200 W/LOCATION(22160): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:20.509+0200 W/LOCATION(22160): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:20.529+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:20.529+0200 I/servicemanager(21592): es.ugr.frailty.gravity alive timeout
04-23 19:47:20.529+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 19:47:20.539+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:20.539+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:20.539+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:20.539+0200 W/LOCATION(22160): module-internal.c: module_new(311) > module (wps) open success
04-23 19:47:20.539+0200 W/LOCATION(22160): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 19:47:20.549+0200 W/LOCATION(22160): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 19:47:20.549+0200 W/LOCATION(22160): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:20.549+0200 W/LOCATION(22160): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:20.549+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22199
04-23 19:47:20.549+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:20.589+0200 W/LOCATION(22160): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 19:47:20.589+0200 I/LOCATION(22160): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7defc18
04-23 19:47:20.589+0200 I/LOCATION(22160): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 19:47:20.589+0200 I/LOCATION(22160): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7defc18
04-23 19:47:20.589+0200 I/LOCATION(22160): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 19:47:20.599+0200 I/location(22160): es.ugr.frailty.location: creado servicio de localización
04-23 19:47:20.619+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22199
04-23 19:47:20.619+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(22199) type(svcapp) bg(0)
04-23 19:47:20.619+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22199]
04-23 19:47:20.629+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.639+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22199
04-23 19:47:20.639+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.649+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22199)
04-23 19:47:20.649+0200 I/servicemanager(21592): es.ugr.frailty.gravity launch request sent!
04-23 19:47:20.649+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:20.669+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:20.669+0200 E/CAPI_APPFW_APPLICATION(22199): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.669+0200 E/CAPI_APPFW_APPLICATION(22199): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:20.669+0200 I/utils   (22199): trying to start service: es.ugr.frailty.gravity
04-23 19:47:20.669+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22199
04-23 19:47:20.669+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22199) was created
04-23 19:47:20.679+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:20.679+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:20.679+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:20:686,-2.240000,2.940000,1.260000
04-23 19:47:20.679+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:20.679+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:20.689+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:20:690,3.888337,-8.405986,-3.586841
04-23 19:47:20.689+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:20:692,0.086925,-0.002494,-0.255029
04-23 19:47:20.689+0200 I/utils   (22199): es.ugr.frailty.gravity sensor supported
04-23 19:47:20.699+0200 I/utils   (22199): es.ugr.frailty.gravity listener started
04-23 19:47:20.699+0200 W/CAPI_APPFW_APP_CONTROL(22199): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:20.699+0200 I/utils   (22199): specific action
04-23 19:47:20.709+0200 I/LOCATION(22160): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 19:47:20.749+0200 W/LOCATION(22160): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:20.749+0200 W/LOCATION(22160): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:20.749+0200 I/LOCATION(22160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 19:47:20.819+0200 W/libgps  ( 3158): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHookStateIdle             : EXIT
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHookStateGps              : ENTRY
04-23 19:47:20.819+0200 W/libgps  ( 3158): [proxy__gps_start][line = 1022]: called.
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:20.819+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:20.819+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:26
04-23 19:47:20.819+0200 D/gpsd_d  ( 3126): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 19:47:20.819+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:27
04-23 19:47:20.819+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:8
04-23 19:47:20.819+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 19:47:20.819+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:1
04-23 19:47:20.829+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(11), data(0xf7672238), size(4)
04-23 19:47:20.829+0200 W/libgps_d( 3158): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 19:47:20.829+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 19:47:20.829+0200 W/libgps_d( 3158): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 19:47:20.879+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:20.879+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:20.879+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:20.879+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:20.889+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:20:893,0.420000,1.120000,1.540000
04-23 19:47:20.889+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:20:892,3.836350,-8.365505,-3.386903
04-23 19:47:20.899+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:20:887,3.821337,-8.171489,-3.330809
04-23 19:47:20.899+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:20:889,-0.006629,0.189389,0.076944
04-23 19:47:20.899+0200 W/LOCATION(22160): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:20.899+0200 W/LOCATION(22160): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:20.979+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:21.009+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_create(453) > New handle created[0xf401bf60]
04-23 19:47:21.009+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:47:21.009+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:47:21.009+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:47:21.009+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:47:21.019+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:21.019+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:21.029+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.039+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.039+0200 E/LOCATION(21673): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:47:21.039+0200 I/LOCATION(21673): location.c: location_new(269) > method: 1
04-23 19:47:21.039+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:21.039+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:21.039+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:21.039+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:21.039+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:21.039+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:21.039+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:21.039+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.049+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.049+0200 E/LOCATION(21673): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:47:21.059+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:21.059+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:47:21.059+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3301346), time2(3291201)
04-23 19:47:21.059+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 19:47:21.059+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:47:21.059+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:47:21.059+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:47:21.079+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.079+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.079+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.079+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.089+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:94,3.801855,-8.449079,-3.213931
04-23 19:47:21.089+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:93,5.530000,3.710000,-1.120000
04-23 19:47:21.099+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:90,-0.091583,-0.229513,0.245127
04-23 19:47:21.099+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:88,3.744767,-8.595018,-3.141776
04-23 19:47:21.099+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:21.119+0200 W/LOCATION(22160): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:47:21.119+0200 I/LOCATION(22160): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:21.119+0200 I/LOCATION(22160): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:21.119+0200 I/location(22160): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:47:21.219+0200 I/LOCATION(22160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:21.279+0200 E/location(22160): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:47:21.279+0200 W/AUL     (22160): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:47:21.279+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.279+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.279+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.279+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:285,-0.840000,0.630000,0.560000
04-23 19:47:21.279+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.289+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:290,3.854837,-8.425128,-3.381058
04-23 19:47:21.289+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:21.289+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:290,0.052983,0.023951,-0.167128
04-23 19:47:21.289+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 22160
04-23 19:47:21.289+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:286,3.813889,-8.422915,-3.267895
04-23 19:47:21.299+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21592
04-23 19:47:21.299+0200 W/AUL     (22160): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21592)
04-23 19:47:21.299+0200 I/location(22160): request sent to service es.ugr.frailty.servicemanager
04-23 19:47:21.299+0200 W/CAPI_APPFW_APP_CONTROL(22160): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.299+0200 I/utils   (22160): specific action
04-23 19:47:21.299+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:21.299+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21592), cmd(0)
04-23 19:47:21.299+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.299+0200 I/utils   (21592): specific action
04-23 19:47:21.299+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.299+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.299+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.299+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:47:21.299+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:21.299+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:21.309+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21598
04-23 19:47:21.309+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.309+0200 I/utils   (21598): specific action
04-23 19:47:21.309+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.309+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:21.309+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21598), cmd(0)
04-23 19:47:21.309+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.309+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.309+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:21.309+0200 I/recorder(21598): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:47:21.309+0200 I/recorder(21598): guardando datos en local
04-23 19:47:21.309+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21598)
04-23 19:47:21.309+0200 I/servicemanager(21592): request sent to service es.ugr.frailty.recorder
04-23 19:47:21.309+0200 I/servicemanager(21592): requesting to save local data
04-23 19:47:21.479+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.479+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.489+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.489+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.509+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:488,3.931407,-8.501699,-3.498307
04-23 19:47:21.509+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:492,4.690000,3.430000,-1.120000
04-23 19:47:21.519+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:503,0.117519,-0.078784,-0.230411
04-23 19:47:21.519+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:501,3.836566,-8.419178,-3.250937
04-23 19:47:21.649+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:47:21.649+0200 W/libgps_d( 3158): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 19:47:21.659+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 19:47:21.659+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:47:21.659+0200 E/CAPI_LOCATION_MANAGER(21673): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:47:21.679+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.689+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:21.689+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.689+0200 E/LOCATION(21673): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:47:21.689+0200 I/LOCATION(21673): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:47:21.689+0200 I/LOCATION(21673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:21.699+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.699+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.699+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.729+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:704,-1.610000,0.770000,0.420000
04-23 19:47:21.729+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:702,3.883551,-8.583055,-3.474378
04-23 19:47:21.729+0200 I/LOCATION(22160): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:21.729+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.729+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:709,0.046985,-0.163877,-0.223441
04-23 19:47:21.729+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:713,3.830218,-8.398170,-3.312184
04-23 19:47:21.729+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.739+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.739+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.739+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:741,0.630000,1.610000,-0.280000
04-23 19:47:21.739+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.749+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:742,3.955336,-8.616554,-3.424129
04-23 19:47:21.749+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.749+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:754,3.881158,-8.475377,-3.467200
04-23 19:47:21.749+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.759+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:760,3.902694,-8.456236,-3.460021
04-23 19:47:21.759+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.759+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:745,0.125118,-0.218385,-0.111946
04-23 19:47:21.759+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.759+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:767,0.048750,-0.077703,-0.156291
04-23 19:47:21.759+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.759+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:768,3.835695,-8.403593,-3.402594
04-23 19:47:21.769+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:744,3.832408,-8.397674,-3.310909
04-23 19:47:21.769+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.769+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:752,1.400000,2.100000,-0.840000
04-23 19:47:21.769+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.769+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:775,3.834333,-8.396188,-3.312446
04-23 19:47:21.769+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:776,-0.070000,2.380000,-0.560000
04-23 19:47:21.769+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.769+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.779+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.779+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:787,3.850052,-8.551948,-3.388237
04-23 19:47:21.779+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:781,3.838242,-8.393024,-3.315934
04-23 19:47:21.779+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.789+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:771,0.068361,-0.060048,-0.147575
04-23 19:47:21.789+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.789+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:792,3.842206,-8.389093,-3.321287
04-23 19:47:21.789+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.789+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:799,3.843834,-8.387294,-3.323947
04-23 19:47:21.799+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:780,-2.310000,3.010000,-0.280000
04-23 19:47:21.799+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:796,-0.002547,-0.010569,-0.086660
04-23 19:47:21.799+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.799+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.799+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.799+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:808,0.007845,-0.162854,-0.066949
04-23 19:47:21.799+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.809+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.809+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:812,3.844261,-8.387101,-3.323940
04-23 19:47:21.809+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:814,-2.310000,2.590000,-0.210000
04-23 19:47:21.809+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:808,3.890730,-8.535198,-3.460021
04-23 19:47:21.809+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.809+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:817,1.330000,1.820000,-0.700000
04-23 19:47:21.819+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:812,0.046896,-0.147904,-0.136075
04-23 19:47:21.819+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.819+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.819+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.819+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:826,2.450000,1.750000,-1.120000
04-23 19:47:21.819+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.829+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:830,0.058433,-0.057170,-0.203080
04-23 19:47:21.829+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:827,3.846028,-8.385395,-3.326200
04-23 19:47:21.829+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:830,3.902694,-8.444271,-3.527020
04-23 19:47:21.839+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.839+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.849+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:850,0.350000,2.380000,-0.490000
04-23 19:47:21.849+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:851,-0.048619,-0.066054,-0.296534
04-23 19:47:21.849+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.849+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.849+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:856,3.843829,-8.382664,-3.335612
04-23 19:47:21.859+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:859,3.797409,-8.451449,-3.622734
04-23 19:47:21.859+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.859+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.859+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:865,-3.010000,3.360000,0.070000
04-23 19:47:21.859+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:866,-0.022492,-0.073572,-0.131588
04-23 19:47:21.859+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.859+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.869+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:871,3.845901,-8.378850,-3.342798
04-23 19:47:21.869+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:874,3.821337,-8.456236,-3.467200
04-23 19:47:21.879+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.879+0200 I/linearacceleration(22163): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:21.879+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:886,-2.310000,4.270000,0.420000
04-23 19:47:21.879+0200 I/linearacceleration(22163): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:21:886,-0.120276,-0.125241,0.023953
04-23 19:47:21.879+0200 I/accelerometer(22134): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:21.889+0200 I/accelerometer(22134): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:21:891,3.725625,-8.504091,-3.318845
04-23 19:47:21.889+0200 I/gravity (22199): capturing data from es.ugr.frailty.gravity
04-23 19:47:21.889+0200 I/gravity (22199): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:21:895,3.843777,-8.380401,-3.341353
04-23 19:47:21.899+0200 I/gyroscope(22147): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:21.899+0200 I/gyroscope(22147): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:21:906,11.270000,2.100000,1.750000
04-23 19:47:21.919+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11221606c6f63152450564
