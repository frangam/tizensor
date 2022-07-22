S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10638
Date: 2018-04-23 20:35:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73da52d, r5   = 0xf7bb4f98
r6   = 0xffd8b2d0, r7   = 0xffd8b180
r8   = 0xf7bb1c18, r9   = 0x00000000
r10  = 0xffd8b25c, fp   = 0xffd8b2d0
ip   = 0x00000001, sp   = 0xffd8b158
lr   = 0xf73da539, pc   = 0xf7443228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    140740 KB
Buffers:     37396 KB
Cached:     156812 KB
VmPeak:      53632 KB
VmSize:      53628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12068 KB
VmRSS:       12068 KB
VmData:      11356 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10638 TID = 10638
10638 10641 

Maps Information
f42a5000 f4aa4000 rw-p [stack:10641]
f4aab000 f4aad000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ab5000 f4ab9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ac2000 f4ac4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4acc000 f4acf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ade000 f4ae3000 r-xp /usr/lib/libsystem.so.0.0.0
f4aee000 f4af1000 r-xp /lib/libattr.so.1.1.0
f4af9000 f4b09000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b11000 f4b1a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b22000 f4b23000 r-xp /usr/lib/libresponse.so.0.2.96
f4b2c000 f4b31000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63d3000 f64d9000 r-xp /usr/lib/libicuuc.so.57.1
f64ef000 f6677000 r-xp /usr/lib/libicui18n.so.57.1
f6687000 f6694000 r-xp /usr/lib/libail.so.0.1.0
f669d000 f66a4000 r-xp /usr/lib/libminizip.so.1.0.0
f66ad000 f6856000 r-xp /usr/lib/libcrypto.so.1.0.0
f6876000 f68bd000 r-xp /usr/lib/libssl.so.1.0.0
f68c9000 f68cb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68d3000 f68da000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68e3000 f68ea000 r-xp /lib/libcrypt-2.13.so
f691b000 f691e000 r-xp /lib/libcap.so.2.21
f6926000 f6928000 r-xp /usr/lib/libiri.so
f6930000 f6979000 r-xp /usr/lib/libmdm.so.1.2.69
f6981000 f6987000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f698f000 f69b2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69bc000 f69be000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69c6000 f69e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69ec000 f69f0000 r-xp /usr/lib/libsmack.so.1.0.0
f69f9000 f6a12000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a1b000 f6a23000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a2b000 f6a31000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a3a000 f6a3c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a45000 f6a55000 r-xp /lib/libresolv-2.13.so
f6a59000 f6a71000 r-xp /usr/lib/liblzma.so.5.0.3
f6a7a000 f6a7c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a84000 f6a9e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6aa6000 f6ad5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ade000 f6aed000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6af7000 f6b01000 r-xp /usr/lib/libsensord-shared.so
f6b0a000 f6bdd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6be8000 f6bfe000 r-xp /lib/libz.so.1.2.5
f6c06000 f6c0b000 r-xp /usr/lib/libffi.so.5.0.10
f6c13000 f6c14000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c1c000 f6c2c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c34000 f6c4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c55000 f6c57000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c5f000 f6cd4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cde000 f6ce4000 r-xp /lib/librt-2.13.so
f6ced000 f6d0b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d15000 f6d16000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d1e000 f6d41000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d49000 f6d4e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d56000 f6d80000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d89000 f6da0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6da8000 f6e11000 r-xp /lib/libm-2.13.so
f6e1a000 f6eae000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ec1000 f6ec6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ece000 f6ed5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6edd000 f6f07000 r-xp /usr/lib/libsensor.so.1.9.6
f6f10000 f6fdc000 r-xp /usr/lib/libxml2.so.2.7.8
f6fe9000 f6feb000 r-xp /usr/lib/libiniparser.so.0
f6ff4000 f6ffa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7003000 f70d3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70d4000 f7108000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7111000 f714d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7155000 f7158000 r-xp /usr/lib/libbundle.so.0.1.22
f7160000 f7166000 r-xp /usr/lib/libappsvc.so.0.1.0
f716e000 f71af000 r-xp /usr/lib/libeina.so.1.7.99
f71b8000 f71cf000 r-xp /usr/lib/libecore.so.1.7.99
f71e6000 f71ef000 r-xp /usr/lib/libvconf.so.0.2.45
f71f7000 f720b000 r-xp /lib/libpthread-2.13.so
f7216000 f7223000 r-xp /usr/lib/libaul.so.0.1.0
f722d000 f722f000 r-xp /lib/libdl-2.13.so
f7238000 f7243000 r-xp /lib/libunwind.so.8.0.1
f7270000 f7278000 r-xp /lib/libgcc_s-4.6.so.1
f7279000 f739d000 r-xp /lib/libc-2.13.so
f73ab000 f73ad000 r-xp /usr/lib/libdlog.so.0.0.0
f73b5000 f73c1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ca000 f73cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73d7000 f73e6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73ee000 f73f2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73fb000 f73fe000 r-xp /usr/lib/libappcore-agent.so.1.1
f7406000 f7408000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7410000 f7414000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f741c000 f7439000 r-xp /lib/ld-2.13.so
f7442000 f7445000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7445000 f7449000 r-xp /usr/lib/libsys-assert.so
f7b81000 f7c1f000 rw-p [heap]
ffd6c000 ffd8d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10638)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7443228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73da539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70e13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70dfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70ebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70f1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70f1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf712675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71211f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70dfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70ebe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70f1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70f1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7123e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7124017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf712bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ac31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ab6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b89663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7036fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70387a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71c8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71c3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71c45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71c4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73fc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73fc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf744353f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf729085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7442f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
onnection_status(362) > update FALSE
04-23 20:35:01.099+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:01.109+0200 I/HealthDataService( 2920): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 20:35:01.109+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.119+0200 I/healthData( 3097): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 20:35:01.119+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.119+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:01.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.169+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.219+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:01.219+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:01.219+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:01.219+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c29048
04-23 20:35:01.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c15ef8]
04-23 20:35:01.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:01.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:01.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:01.279+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:01.279+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.279+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.289+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.299+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.299+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:01.299+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:01.299+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.299+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:01.299+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:01.299+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:01.299+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.299+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:01.299+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:01.309+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.319+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.319+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:01.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.349+0200 I/servicemanager(10115): es.ugr.frailty.location sleep timeout
04-23 20:35:01.349+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:01.349+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:01.349+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:01.359+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:01.359+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10587
04-23 20:35:01.379+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:01.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:01.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:01.389+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c15ef8
04-23 20:35:01.409+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10587
04-23 20:35:01.409+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10587) type(svcapp) bg(0)
04-23 20:35:01.419+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10587)
04-23 20:35:01.419+0200 I/servicemanager(10115): es.ugr.frailty.location stop request sent!
04-23 20:35:01.419+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:01.419+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10587]
04-23 20:35:01.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:01.439+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10587
04-23 20:35:01.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:01.439+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:01.449+0200 E/CAPI_APPFW_APPLICATION(10587): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:01.449+0200 E/CAPI_APPFW_APPLICATION(10587): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:01.449+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10587
04-23 20:35:01.449+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10587) was created
04-23 20:35:01.449+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:01.469+0200 W/LOCATION(10587): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:01.469+0200 E/LOCATION(10587): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:01.469+0200 E/PKGMGR_INFO(10587): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:01.479+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.499+0200 I/LOCATION(10587): location.c: location_new(269) > method: 0
04-23 20:35:01.499+0200 W/LOCATION(10587): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.499+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.509+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.509+0200 W/LOCATION(10587): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:01.509+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:01.519+0200 W/LOCATION(10587): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:01.519+0200 W/LOCATION(10587): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.519+0200 W/LOCATION(10587): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:01.519+0200 W/LOCATION(10587): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:01.539+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:01.539+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:01.539+0200 W/LOCATION(10587): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:01.549+0200 W/LOCATION(10587): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:01.549+0200 W/LOCATION(10587): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:01.549+0200 W/LOCATION(10587): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:01.549+0200 W/LOCATION(10587): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:01.569+0200 W/LOCATION(10587): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:01.569+0200 I/LOCATION(10587): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7f5ec18
04-23 20:35:01.569+0200 I/LOCATION(10587): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:01.569+0200 I/LOCATION(10587): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7f5ec18
04-23 20:35:01.569+0200 I/LOCATION(10587): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:01.569+0200 I/location(10587): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:01.609+0200 I/LOCATION(10587): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:01.649+0200 W/LOCATION(10587): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:01.649+0200 W/LOCATION(10587): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:01.649+0200 I/LOCATION(10587): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:01.719+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:01.719+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:01.719+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:01.719+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:01.719+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:01.719+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:01.719+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:01.719+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:01.719+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:01.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:01.729+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:01.729+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:01.729+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:01.789+0200 W/SHealthService( 3097): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 20:35:01.789+0200 W/LOCATION(10587): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:01.789+0200 W/LOCATION(10587): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:01.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.909+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c14d90]
04-23 20:35:01.909+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:01.909+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:01.909+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:01.909+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:01.919+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.919+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.919+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.929+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.929+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:01.929+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:01.929+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:01.929+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:01.929+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:01.929+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:01.929+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:01.929+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:01.929+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:01.939+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.949+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:01.949+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:01.949+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:01.969+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:01.969+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2577236), time2(2574181)
04-23 20:35:01.969+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:35:01.969+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:01.969+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:01.969+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:01.989+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.019+0200 W/LOCATION(10587): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:02.019+0200 I/LOCATION(10587): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:02.019+0200 I/LOCATION(10587): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:02.019+0200 I/location(10587): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:02.079+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:02.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:02.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:02.139+0200 I/LOCATION(10587): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:02.189+0200 W/AUL     (10587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:02.189+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:02.189+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10587
04-23 20:35:02.199+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:02.199+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:02.199+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:02.199+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.199+0200 I/utils   (10115): specific action
04-23 20:35:02.199+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.199+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.199+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.199+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:02.209+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:02.209+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:02.209+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:02.219+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:02.219+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:02.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.219+0200 I/utils   (10120): specific action
04-23 20:35:02.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.219+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:02.219+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:02.219+0200 I/recorder(10120): guardando datos en local
04-23 20:35:02.219+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:02.219+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:02.219+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:02.219+0200 W/AUL     (10587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:02.219+0200 I/location(10587): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:02.219+0200 I/location(10587): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:02:194,nan,37.171719,-3.592982,0.000000,0,0.000000,62.000000,-1.000000
04-23 20:35:02.219+0200 I/location(10587): stopping es.ugr.frailty.location service
04-23 20:35:02.219+0200 E/CAPI_APPFW_APP_CONTROL(10587): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:35:02.219+0200 E/location(10587): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:35:02.219+0200 I/CAPI_APPFW_APPLICATION(10587): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:35:02.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:35:02.219+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:35:02.259+0200 W/LOCATION(10587): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:02.259+0200 I/LOCATION(10587): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:02.269+0200 I/LOCATION(10587): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:35:02.329+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:35:02.329+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:35:02.329+0200 E/CAPI_LOCATION_MANAGER(10195): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:35:02.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:35:02.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:02.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:02.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:02.479+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c14d90
04-23 20:35:02.529+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf7310f78]
04-23 20:35:02.539+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:02.539+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:02.539+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:02.539+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:02.539+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:02.539+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:02.549+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.559+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.559+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:02.559+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:02.559+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:02.559+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:02.559+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:02.559+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:02.559+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:02.559+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:02.559+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:02.569+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.569+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.569+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:02.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.619+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.679+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:02.679+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:02.679+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:02.679+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf7310f78
04-23 20:35:02.729+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c090c8]
04-23 20:35:02.729+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:02.729+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:02.729+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:02.729+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:02.739+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:02.739+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:02.749+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.759+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.759+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:02.759+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:02.759+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:02.759+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:02.759+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:02.759+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:02.759+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:02.759+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:02.759+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:02.759+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.769+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:02.769+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:02.769+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.849+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:02.859+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:35:02.859+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:35:02.859+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:35:02.859+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_destroy(471) > Destroy handle: 0xf3c090c8
04-23 20:35:03.019+0200 W/AUL     (10600): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:35:03.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:35:03.019+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:35:03.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10566
04-23 20:35:03.019+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:35:03.029+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10566
04-23 20:35:03.029+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10566)
04-23 20:35:04.219+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:35:11.429+0200 I/servicemanager(10115): es.ugr.frailty.location alive timeout
04-23 20:35:11.429+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:35:11.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:11.429+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:11.449+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 10638
04-23 20:35:11.459+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:35:11.499+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10638
04-23 20:35:11.499+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(10638) type(svcapp) bg(0)
04-23 20:35:11.519+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10638]
04-23 20:35:11.529+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10638)
04-23 20:35:11.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:11.539+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10638
04-23 20:35:11.549+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:11.549+0200 I/servicemanager(10115): es.ugr.frailty.location launch request sent!
04-23 20:35:11.549+0200 I/servicemanager(10115): App control destroyed.
04-23 20:35:11.559+0200 E/CAPI_APPFW_APPLICATION(10638): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:11.559+0200 E/CAPI_APPFW_APPLICATION(10638): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:35:11.559+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (10638) was created
04-23 20:35:11.569+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:35:11.579+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10638
04-23 20:35:11.579+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:35:11.589+0200 W/LOCATION(10638): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:35:11.589+0200 E/LOCATION(10638): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:35:11.589+0200 E/PKGMGR_INFO(10638): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:35:11.589+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:11.609+0200 I/LOCATION(10638): location.c: location_new(269) > method: 0
04-23 20:35:11.609+0200 W/LOCATION(10638): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:11.619+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:11.619+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:11.629+0200 W/LOCATION(10638): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:11.629+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:11.629+0200 W/LOCATION(10638): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:11.629+0200 W/LOCATION(10638): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:11.629+0200 W/LOCATION(10638): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:11.629+0200 W/LOCATION(10638): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:11.659+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:11.659+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:35:11.659+0200 W/LOCATION(10638): module-internal.c: module_new(311) > module (wps) open success
04-23 20:35:11.669+0200 W/LOCATION(10638): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:35:11.669+0200 W/LOCATION(10638): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:35:11.669+0200 W/LOCATION(10638): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:11.669+0200 W/LOCATION(10638): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:11.689+0200 W/LOCATION(10638): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:35:11.689+0200 I/LOCATION(10638): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7bb1c18
04-23 20:35:11.689+0200 I/LOCATION(10638): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:35:11.689+0200 I/LOCATION(10638): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7bb1c18
04-23 20:35:11.689+0200 I/LOCATION(10638): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:35:11.689+0200 I/location(10638): es.ugr.frailty.location: creado servicio de localización
04-23 20:35:11.739+0200 I/LOCATION(10638): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:35:11.779+0200 W/LOCATION(10638): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:11.779+0200 W/LOCATION(10638): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:11.779+0200 I/LOCATION(10638): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:11.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:35:11.829+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:35:11.829+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:35:11.829+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:11.829+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:11.829+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:35:11.839+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:35:11.839+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:35:11.839+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:35:11.839+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:35:11.839+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:35:11.839+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:35:11.839+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:35:11.879+0200 W/LOCATION(10638): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:35:11.879+0200 W/LOCATION(10638): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:35:11.949+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:11.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_create(453) > New handle created[0xf3c02928]
04-23 20:35:11.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:35:11.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:35:11.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:35:11.989+0200 I/CAPI_NETWORK_CONNECTION(10195): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:35:11.989+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:11.989+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:11.999+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:12.009+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:12.009+0200 E/LOCATION(10195): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:35:12.009+0200 I/LOCATION(10195): location.c: location_new(269) > method: 1
04-23 20:35:12.009+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:35:12.009+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (gps) open success
04-23 20:35:12.009+0200 W/LOCATION(10195): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:35:12.009+0200 W/LOCATION(10195): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:35:12.009+0200 W/LOCATION(10195): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:35:12.009+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:35:12.009+0200 W/LOCATION(10195): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:35:12.019+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:12.019+0200 I/AUL     (10195): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:35:12.019+0200 E/LOCATION(10195): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:35:12.029+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:12.059+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:35:12.059+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2587328), time2(2574181)
04-23 20:35:12.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:35:12.059+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:35:12.059+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:35:12.059+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:35:12.069+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:35:12.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:12.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:12.089+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:12.099+0200 W/LOCATION(10638): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:35:12.099+0200 I/LOCATION(10638): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:12.099+0200 I/LOCATION(10638): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:35:12.099+0200 I/location(10638): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:35:12.179+0200 I/LOCATION(10638): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:35:12.229+0200 W/AUL     (10638): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:35:12.229+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:12.229+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10638
04-23 20:35:12.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10115
04-23 20:35:12.239+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.239+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:12.239+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10115), cmd(0)
04-23 20:35:12.239+0200 W/AUL     (10638): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10115)
04-23 20:35:12.239+0200 I/location(10638): request sent to service es.ugr.frailty.servicemanager
04-23 20:35:12.239+0200 I/location(10638): es.ugr.frailty.location: SM-R760,23/04/2018,20:35:12:231,nan,37.171719,-3.592982,0.000000,0,0.000000,62.000000,-1.000000
04-23 20:35:12.239+0200 W/CAPI_APPFW_APP_CONTROL(10638): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.239+0200 I/utils   (10638): specific action
04-23 20:35:12.239+0200 I/utils   (10115): specific action
04-23 20:35:12.239+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.239+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.239+0200 W/CAPI_APPFW_APP_CONTROL(10115): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.239+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:35:12.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:35:12.239+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 10115
04-23 20:35:12.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10120
04-23 20:35:12.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.249+0200 I/utils   (10120): specific action
04-23 20:35:12.249+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:35:12.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(10120), cmd(0)
04-23 20:35:12.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.249+0200 W/CAPI_APPFW_APP_CONTROL(10120): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:35:12.249+0200 I/recorder(10120): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:35:12.249+0200 I/recorder(10120): guardando datos en local
04-23 20:35:12.249+0200 W/AUL     (10115): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10120)
04-23 20:35:12.249+0200 I/servicemanager(10115): request sent to service es.ugr.frailty.recorder
04-23 20:35:12.249+0200 I/servicemanager(10115): requesting to save local data
04-23 20:35:13.069+0200 E/CAPI_TELEPHONY(10195): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:35:13.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:35:13.079+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:35:13.079+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:35:13.759+0200 W/LOCATION(10638): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:35:13.969+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11106386c6f63152450851
