S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7586
Date: 2018-04-23 20:10:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71da52d, r5   = 0xf77d0f98
r6   = 0xffe78270, r7   = 0xffe78120
r8   = 0xf77cdc18, r9   = 0x00000000
r10  = 0xffe781fc, fp   = 0xffe78270
ip   = 0x00000001, sp   = 0xffe780f8
lr   = 0xf71da539, pc   = 0xf7243228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    106272 KB
Buffers:     41092 KB
Cached:     187660 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11956 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7586 TID = 7586
7586 7589 

Maps Information
f40a5000 f48a4000 rw-p [stack:7589]
f48ab000 f48ad000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48b5000 f48b9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48c2000 f48c4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48cc000 f48cf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48de000 f48e3000 r-xp /usr/lib/libsystem.so.0.0.0
f48ee000 f48f1000 r-xp /lib/libattr.so.1.1.0
f48f9000 f4909000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4911000 f491a000 r-xp /usr/lib/libedbus.so.1.7.99
f4922000 f4923000 r-xp /usr/lib/libresponse.so.0.2.96
f492c000 f4931000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61d3000 f62d9000 r-xp /usr/lib/libicuuc.so.57.1
f62ef000 f6477000 r-xp /usr/lib/libicui18n.so.57.1
f6487000 f6494000 r-xp /usr/lib/libail.so.0.1.0
f649d000 f64a4000 r-xp /usr/lib/libminizip.so.1.0.0
f64ad000 f6656000 r-xp /usr/lib/libcrypto.so.1.0.0
f6676000 f66bd000 r-xp /usr/lib/libssl.so.1.0.0
f66c9000 f66cb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66d3000 f66da000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66e3000 f66ea000 r-xp /lib/libcrypt-2.13.so
f671b000 f671e000 r-xp /lib/libcap.so.2.21
f6726000 f6728000 r-xp /usr/lib/libiri.so
f6730000 f6779000 r-xp /usr/lib/libmdm.so.1.2.69
f6781000 f6787000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f678f000 f67b2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67bc000 f67be000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67c6000 f67e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67ec000 f67f0000 r-xp /usr/lib/libsmack.so.1.0.0
f67f9000 f6812000 r-xp /usr/lib/libnetwork.so.0.0.0
f681b000 f6823000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f682b000 f6831000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f683a000 f683c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6845000 f6855000 r-xp /lib/libresolv-2.13.so
f6859000 f6871000 r-xp /usr/lib/liblzma.so.5.0.3
f687a000 f687c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6884000 f689e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68a6000 f68d5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68de000 f68ed000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68f7000 f6901000 r-xp /usr/lib/libsensord-shared.so
f690a000 f69dd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69e8000 f69fe000 r-xp /lib/libz.so.1.2.5
f6a06000 f6a0b000 r-xp /usr/lib/libffi.so.5.0.10
f6a13000 f6a14000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a1c000 f6a2c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a34000 f6a4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a55000 f6a57000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a5f000 f6ad4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ade000 f6ae4000 r-xp /lib/librt-2.13.so
f6aed000 f6b0b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b15000 f6b16000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b1e000 f6b41000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b49000 f6b4e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b56000 f6b80000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b89000 f6ba0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ba8000 f6c11000 r-xp /lib/libm-2.13.so
f6c1a000 f6cae000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cc1000 f6cc6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cce000 f6cd5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cdd000 f6d07000 r-xp /usr/lib/libsensor.so.1.9.6
f6d10000 f6ddc000 r-xp /usr/lib/libxml2.so.2.7.8
f6de9000 f6deb000 r-xp /usr/lib/libiniparser.so.0
f6df4000 f6dfa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e03000 f6ed3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ed4000 f6f08000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f11000 f6f4d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f55000 f6f58000 r-xp /usr/lib/libbundle.so.0.1.22
f6f60000 f6f66000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f6e000 f6faf000 r-xp /usr/lib/libeina.so.1.7.99
f6fb8000 f6fcf000 r-xp /usr/lib/libecore.so.1.7.99
f6fe6000 f6fef000 r-xp /usr/lib/libvconf.so.0.2.45
f6ff7000 f700b000 r-xp /lib/libpthread-2.13.so
f7016000 f7023000 r-xp /usr/lib/libaul.so.0.1.0
f702d000 f702f000 r-xp /lib/libdl-2.13.so
f7038000 f7043000 r-xp /lib/libunwind.so.8.0.1
f7070000 f7078000 r-xp /lib/libgcc_s-4.6.so.1
f7079000 f719d000 r-xp /lib/libc-2.13.so
f71ab000 f71ad000 r-xp /usr/lib/libdlog.so.0.0.0
f71b5000 f71c1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71ca000 f71cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71d7000 f71e6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71ee000 f71f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71fb000 f71fe000 r-xp /usr/lib/libappcore-agent.so.1.1
f7206000 f7208000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7210000 f7214000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f721c000 f7239000 r-xp /lib/ld-2.13.so
f7242000 f7245000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7245000 f7249000 r-xp /usr/lib/libsys-assert.so
f779d000 f780e000 rw-p [heap]
ffe59000 ffe7a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7586)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7243228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71da539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ee13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6edfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6eebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ef1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ef1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f2675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f211f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6edfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6eebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ef1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ef1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f23e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f24017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f2bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48c31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48b6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6989663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e36fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e387a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fc8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fc3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fc45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fc4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71fc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71fc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72434f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf709085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7242f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
s
04-23 20:10:33.609+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:33.609+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:33.609+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:33.609+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:33.609+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:33.609+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.619+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][2][5][0][0][0][0][0][0][0][0][0][0]
04-23 20:10:33.629+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.629+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:33.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:33.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:33.689+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:33.739+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:33.739+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:33.739+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:33.739+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f26c08
04-23 20:10:33.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e6088]
04-23 20:10:33.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:33.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:33.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:33.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:33.819+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:33.819+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:33.829+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.839+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.839+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:33.839+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:33.839+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:33.839+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:33.839+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:33.839+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:33.839+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:33.839+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:33.839+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:33.849+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.859+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:33.859+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:33.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:33.909+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:33.919+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:33.919+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:33.919+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:33.919+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e6088
04-23 20:10:34.059+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:10:34.059+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:34.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:34.069+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:34.079+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7537
04-23 20:10:34.079+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:34.129+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7537
04-23 20:10:34.129+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7537) type(svcapp) bg(0)
04-23 20:10:34.129+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7537]
04-23 20:10:34.139+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7537)
04-23 20:10:34.139+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:10:34.139+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:34.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:34.159+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7537
04-23 20:10:34.159+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:34.169+0200 E/CAPI_APPFW_APPLICATION( 7537): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:34.169+0200 E/CAPI_APPFW_APPLICATION( 7537): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:34.179+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:34.189+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7537
04-23 20:10:34.189+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7537) was created
04-23 20:10:34.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:34.209+0200 W/LOCATION( 7537): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:34.209+0200 E/LOCATION( 7537): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:34.209+0200 E/PKGMGR_INFO( 7537): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:34.219+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:34.229+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][1][6][0][0][0][0][0][0][0][0][0][0]
04-23 20:10:34.229+0200 E/wnoti-ancs( 2993): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][0][4][0][0][0][0][0][0][0][0][0][0]
04-23 20:10:34.239+0200 I/LOCATION( 7537): location.c: location_new(269) > method: 0
04-23 20:10:34.239+0200 W/LOCATION( 7537): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:34.249+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:34.259+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:34.259+0200 W/LOCATION( 7537): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:34.259+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:34.269+0200 W/LOCATION( 7537): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:34.269+0200 W/LOCATION( 7537): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:34.269+0200 W/LOCATION( 7537): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:34.269+0200 W/LOCATION( 7537): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:34.289+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:34.289+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:34.299+0200 W/LOCATION( 7537): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:34.299+0200 W/LOCATION( 7537): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:34.299+0200 W/LOCATION( 7537): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:34.299+0200 W/LOCATION( 7537): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:34.299+0200 W/LOCATION( 7537): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:34.319+0200 W/LOCATION( 7537): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:34.319+0200 I/LOCATION( 7537): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7799c18
04-23 20:10:34.329+0200 I/LOCATION( 7537): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:34.329+0200 I/LOCATION( 7537): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7799c18
04-23 20:10:34.329+0200 I/LOCATION( 7537): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:34.349+0200 I/location( 7537): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:34.399+0200 I/LOCATION( 7537): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:34.439+0200 W/LOCATION( 7537): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:34.439+0200 W/LOCATION( 7537): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:34.439+0200 I/LOCATION( 7537): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:34.509+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:34.509+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:34.509+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:34.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:34.509+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:34.509+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:34.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:34.519+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:34.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:34.519+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:34.519+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:34.519+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:34.519+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:34.579+0200 W/LOCATION( 7537): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:34.579+0200 W/LOCATION( 7537): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:34.669+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:34.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a0fba8]
04-23 20:10:34.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:34.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:34.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:34.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:34.719+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:34.719+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:34.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:34.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:34.739+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:34.739+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:34.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:34.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:34.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:34.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:34.739+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:34.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:34.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:34.749+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:34.759+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:34.759+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(1110024), time2(1106892)
04-23 20:10:34.759+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:10:34.759+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:34.759+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:34.759+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:34.759+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:34.759+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:34.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:34.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:34.839+0200 W/LOCATION( 7537): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:34.839+0200 I/LOCATION( 7537): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:34.839+0200 I/LOCATION( 7537): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:34.839+0200 I/location( 7537): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:34.959+0200 I/LOCATION( 7537): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:35.009+0200 E/location( 7537): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:35.019+0200 W/AUL     ( 7537): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:35.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:35.019+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7537
04-23 20:10:35.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:35.029+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:35.029+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:35.029+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.029+0200 I/utils   ( 5532): specific action
04-23 20:10:35.029+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.029+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.029+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.029+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:35.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:35.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:35.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:35.039+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:35.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:35.039+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.039+0200 I/utils   ( 5538): specific action
04-23 20:10:35.039+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.049+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:35.049+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:35.049+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:35.049+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:35.049+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:35.049+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:35.049+0200 W/AUL     ( 7537): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:35.049+0200 I/location( 7537): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:35.049+0200 I/location( 7537): stopping es.ugr.frailty.location service
04-23 20:10:35.049+0200 E/CAPI_APPFW_APP_CONTROL( 7537): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:10:35.049+0200 E/location( 7537): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:10:35.049+0200 I/CAPI_APPFW_APPLICATION( 7537): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:10:35.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:10:35.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:10:35.109+0200 W/LOCATION( 7537): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:35.109+0200 I/LOCATION( 7537): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:35.109+0200 I/LOCATION( 7537): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:10:35.189+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:10:35.189+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:10:35.189+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:10:35.189+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:10:35.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:35.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:35.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:35.359+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a0fba8
04-23 20:10:35.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d3640]
04-23 20:10:35.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:35.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:35.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:35.429+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:35.439+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:35.439+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:35.449+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.459+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.459+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:35.459+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:35.459+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:35.459+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:35.459+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:35.459+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:35.459+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:35.459+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:35.459+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:35.469+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.469+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.469+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:35.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.579+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:35.579+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:35.579+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:35.579+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d3640
04-23 20:10:35.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e6038]
04-23 20:10:35.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:35.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:35.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:35.709+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:35.709+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:35.709+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:35.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.739+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:35.739+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:35.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:35.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:35.739+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:35.739+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:35.739+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:35.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:35.739+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:35.749+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.759+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:35.759+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:35.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.809+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:35.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:35.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:35.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:35.819+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e6038
04-23 20:10:35.999+0200 W/AUL     ( 7547): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:10:36.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:10:36.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:10:36.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7513
04-23 20:10:36.009+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:10:36.009+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7513
04-23 20:10:36.009+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7513)
04-23 20:10:37.049+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:10:44.149+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:10:44.149+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:44.149+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:44.149+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:44.159+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7586
04-23 20:10:44.159+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:44.199+0200 E/CAPI_APPFW_APPLICATION( 7586): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:44.199+0200 E/CAPI_APPFW_APPLICATION( 7586): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:44.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7586
04-23 20:10:44.209+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7586) type(svcapp) bg(0)
04-23 20:10:44.209+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7586) was created
04-23 20:10:44.209+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7586)
04-23 20:10:44.209+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:10:44.209+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:44.209+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7586]
04-23 20:10:44.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:44.239+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7586
04-23 20:10:44.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:44.249+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7586
04-23 20:10:44.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:44.249+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:44.259+0200 W/LOCATION( 7586): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:44.259+0200 E/LOCATION( 7586): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:44.259+0200 E/PKGMGR_INFO( 7586): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:44.259+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:44.279+0200 I/LOCATION( 7586): location.c: location_new(269) > method: 0
04-23 20:10:44.279+0200 W/LOCATION( 7586): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:44.289+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:44.289+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:44.289+0200 W/LOCATION( 7586): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:44.299+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:44.299+0200 W/LOCATION( 7586): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:44.299+0200 W/LOCATION( 7586): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:44.299+0200 W/LOCATION( 7586): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:44.299+0200 W/LOCATION( 7586): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:44.319+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:44.319+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:44.329+0200 W/LOCATION( 7586): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:44.329+0200 W/LOCATION( 7586): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:44.329+0200 W/LOCATION( 7586): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:44.329+0200 W/LOCATION( 7586): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:44.329+0200 W/LOCATION( 7586): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:44.359+0200 W/LOCATION( 7586): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:44.359+0200 I/LOCATION( 7586): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77cdc18
04-23 20:10:44.359+0200 I/LOCATION( 7586): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:44.359+0200 I/LOCATION( 7586): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77cdc18
04-23 20:10:44.359+0200 I/LOCATION( 7586): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:44.369+0200 I/location( 7586): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:44.409+0200 I/LOCATION( 7586): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:44.449+0200 W/LOCATION( 7586): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:44.449+0200 W/LOCATION( 7586): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:44.449+0200 I/LOCATION( 7586): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:44.519+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:44.519+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:44.519+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:44.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:44.519+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:44.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:44.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:44.519+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:44.519+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:44.529+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:44.529+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:44.529+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:44.529+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:44.579+0200 W/LOCATION( 7586): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:44.579+0200 W/LOCATION( 7586): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:44.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:44.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf7a15490]
04-23 20:10:44.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:44.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:44.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:44.689+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:44.699+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:44.699+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:44.709+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:44.719+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:44.719+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:44.719+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:44.719+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:44.719+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:44.719+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:44.719+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:44.719+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:44.719+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:44.719+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:44.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:44.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:44.729+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:44.739+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:44.769+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:44.769+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1120033), time2(1106892)
04-23 20:10:44.769+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:10:44.769+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:44.769+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:44.769+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:44.779+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:44.819+0200 W/LOCATION( 7586): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:44.819+0200 I/LOCATION( 7586): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:44.819+0200 I/LOCATION( 7586): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:44.819+0200 I/location( 7586): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:44.899+0200 I/LOCATION( 7586): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:44.949+0200 E/location( 7586): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:44.949+0200 W/AUL     ( 7586): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:44.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:44.949+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7586
04-23 20:10:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:44.959+0200 W/AUL     ( 7586): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:44.959+0200 I/location( 7586): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:44.959+0200 W/CAPI_APPFW_APP_CONTROL( 7586): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.959+0200 I/utils   ( 7586): specific action
04-23 20:10:44.959+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:44.959+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.959+0200 I/utils   ( 5532): specific action
04-23 20:10:44.959+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.959+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.959+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.959+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:44.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:44.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:44.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:44.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:44.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:44.969+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.969+0200 I/utils   ( 5538): specific action
04-23 20:10:44.969+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.969+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.969+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.969+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:44.969+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:44.969+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:44.969+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:44.969+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:44.969+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:45.359+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:45.359+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:45.359+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:45.779+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:10:46.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:46.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:46.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:46.369+0200 W/LOCATION( 7586): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:10:46.529+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11075866c6f63152450704
