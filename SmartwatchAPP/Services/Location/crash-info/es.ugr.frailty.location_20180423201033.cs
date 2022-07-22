S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 7513
Date: 2018-04-23 20:10:33+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf756e52d, r5   = 0xf783f958
r6   = 0xffaff500, r7   = 0xffaff3b0
r8   = 0xf7852c18, r9   = 0x00000000
r10  = 0xffaff48c, fp   = 0xffaff500
ip   = 0x00000001, sp   = 0xffaff388
lr   = 0xf756e539, pc   = 0xf75d7228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    106256 KB
Buffers:     40908 KB
Cached:     187408 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12000 KB
VmRSS:       12000 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7513 TID = 7513
7513 7516 

Maps Information
f4439000 f4c38000 rw-p [stack:7516]
f4c3f000 f4c41000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c49000 f4c4d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c56000 f4c58000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c60000 f4c63000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c72000 f4c77000 r-xp /usr/lib/libsystem.so.0.0.0
f4c82000 f4c85000 r-xp /lib/libattr.so.1.1.0
f4c8d000 f4c9d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ca5000 f4cae000 r-xp /usr/lib/libedbus.so.1.7.99
f4cb6000 f4cb7000 r-xp /usr/lib/libresponse.so.0.2.96
f4cc0000 f4cc5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6567000 f666d000 r-xp /usr/lib/libicuuc.so.57.1
f6683000 f680b000 r-xp /usr/lib/libicui18n.so.57.1
f681b000 f6828000 r-xp /usr/lib/libail.so.0.1.0
f6831000 f6838000 r-xp /usr/lib/libminizip.so.1.0.0
f6841000 f69ea000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a0a000 f6a51000 r-xp /usr/lib/libssl.so.1.0.0
f6a5d000 f6a5f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a67000 f6a6e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a77000 f6a7e000 r-xp /lib/libcrypt-2.13.so
f6aaf000 f6ab2000 r-xp /lib/libcap.so.2.21
f6aba000 f6abc000 r-xp /usr/lib/libiri.so
f6ac4000 f6b0d000 r-xp /usr/lib/libmdm.so.1.2.69
f6b15000 f6b1b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b23000 f6b46000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b50000 f6b52000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b5a000 f6b77000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b80000 f6b84000 r-xp /usr/lib/libsmack.so.1.0.0
f6b8d000 f6ba6000 r-xp /usr/lib/libnetwork.so.0.0.0
f6baf000 f6bb7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bbf000 f6bc5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bce000 f6bd0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bd9000 f6be9000 r-xp /lib/libresolv-2.13.so
f6bed000 f6c05000 r-xp /usr/lib/liblzma.so.5.0.3
f6c0e000 f6c10000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c18000 f6c32000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c3a000 f6c69000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c72000 f6c81000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c8b000 f6c95000 r-xp /usr/lib/libsensord-shared.so
f6c9e000 f6d71000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d7c000 f6d92000 r-xp /lib/libz.so.1.2.5
f6d9a000 f6d9f000 r-xp /usr/lib/libffi.so.5.0.10
f6da7000 f6da8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6db0000 f6dc0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dc8000 f6de1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6de9000 f6deb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6df3000 f6e68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e72000 f6e78000 r-xp /lib/librt-2.13.so
f6e81000 f6e9f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ea9000 f6eaa000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eb2000 f6ed5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6edd000 f6ee2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6eea000 f6f14000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f1d000 f6f34000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f3c000 f6fa5000 r-xp /lib/libm-2.13.so
f6fae000 f7042000 r-xp /usr/lib/libstdc++.so.6.0.16
f7055000 f705a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7062000 f7069000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7071000 f709b000 r-xp /usr/lib/libsensor.so.1.9.6
f70a4000 f7170000 r-xp /usr/lib/libxml2.so.2.7.8
f717d000 f717f000 r-xp /usr/lib/libiniparser.so.0
f7188000 f718e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7197000 f7267000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7268000 f729c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72a5000 f72e1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72e9000 f72ec000 r-xp /usr/lib/libbundle.so.0.1.22
f72f4000 f72fa000 r-xp /usr/lib/libappsvc.so.0.1.0
f7302000 f7343000 r-xp /usr/lib/libeina.so.1.7.99
f734c000 f7363000 r-xp /usr/lib/libecore.so.1.7.99
f737a000 f7383000 r-xp /usr/lib/libvconf.so.0.2.45
f738b000 f739f000 r-xp /lib/libpthread-2.13.so
f73aa000 f73b7000 r-xp /usr/lib/libaul.so.0.1.0
f73c1000 f73c3000 r-xp /lib/libdl-2.13.so
f73cc000 f73d7000 r-xp /lib/libunwind.so.8.0.1
f7404000 f740c000 r-xp /lib/libgcc_s-4.6.so.1
f740d000 f7531000 r-xp /lib/libc-2.13.so
f753f000 f7541000 r-xp /usr/lib/libdlog.so.0.0.0
f7549000 f7555000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f755e000 f7563000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f756b000 f757a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7582000 f7586000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f758f000 f7592000 r-xp /usr/lib/libappcore-agent.so.1.1
f759a000 f759c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75a4000 f75a8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75b0000 f75cd000 r-xp /lib/ld-2.13.so
f75d6000 f75d9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75d9000 f75dd000 r-xp /usr/lib/libsys-assert.so
f7822000 f78ac000 rw-p [heap]
ffae0000 ffb01000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7513)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75d7228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf756e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72753f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7273c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf727fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7285be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7285dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72ba75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72b51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7273c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf727fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7285be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7285dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72b7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72b8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72bff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c571fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c4a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d1d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71cafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71cc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf735cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7357b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73585a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7358879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7590183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75907fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75d74f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf742485c) [/lib/libc.so.6] + 0x1785c
29: (0xf75d6f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:20.479+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:20.479+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:20.479+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:20.479+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:20.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:20.479+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:20.489+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.499+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.499+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:20.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:20.579+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:20.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:20.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:20.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:20.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:20.639+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf7a00a20
04-23 20:10:20.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d7eb8]
04-23 20:10:20.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:20.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:20.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:20.699+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:20.709+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:20.709+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:20.719+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.729+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.729+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:20.729+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:20.729+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:20.729+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:20.729+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:20.729+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:20.729+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:20.729+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:20.729+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:20.739+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.749+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:20.749+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:20.749+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:20.799+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:20.799+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:20.799+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:20.799+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:20.799+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d7eb8
04-23 20:10:20.899+0200 I/servicemanager( 5532): es.ugr.frailty.location sleep timeout
04-23 20:10:20.899+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:20.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:20.909+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:20.919+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7465
04-23 20:10:20.919+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:20.969+0200 E/CAPI_APPFW_APPLICATION( 7465): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:20.969+0200 E/CAPI_APPFW_APPLICATION( 7465): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:20.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7465
04-23 20:10:20.969+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7465) type(svcapp) bg(0)
04-23 20:10:20.969+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7465) was created
04-23 20:10:20.969+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7465)
04-23 20:10:20.969+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7465]
04-23 20:10:20.989+0200 I/servicemanager( 5532): es.ugr.frailty.location stop request sent!
04-23 20:10:20.989+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:20.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:20.999+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7465
04-23 20:10:21.009+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:21.019+0200 W/LOCATION( 7465): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:21.019+0200 E/LOCATION( 7465): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:21.019+0200 E/PKGMGR_INFO( 7465): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:21.019+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:21.039+0200 I/LOCATION( 7465): location.c: location_new(269) > method: 0
04-23 20:10:21.039+0200 W/LOCATION( 7465): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:21.039+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:21.049+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:21.049+0200 W/LOCATION( 7465): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:21.049+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:21.049+0200 W/LOCATION( 7465): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:21.049+0200 W/LOCATION( 7465): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:21.049+0200 W/LOCATION( 7465): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:21.049+0200 W/LOCATION( 7465): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:21.079+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:21.079+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:21.079+0200 W/LOCATION( 7465): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:21.089+0200 W/LOCATION( 7465): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:21.089+0200 W/LOCATION( 7465): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:21.089+0200 W/LOCATION( 7465): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:21.089+0200 W/LOCATION( 7465): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:21.109+0200 W/LOCATION( 7465): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:21.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:21.119+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7465
04-23 20:10:21.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:21.129+0200 I/LOCATION( 7465): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf73ccc18
04-23 20:10:21.129+0200 I/LOCATION( 7465): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:21.129+0200 I/LOCATION( 7465): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf73ccc18
04-23 20:10:21.129+0200 I/LOCATION( 7465): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:21.129+0200 I/location( 7465): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:21.179+0200 I/LOCATION( 7465): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:21.209+0200 W/LOCATION( 7465): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:21.209+0200 W/LOCATION( 7465): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:21.209+0200 I/LOCATION( 7465): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:21.279+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:21.279+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:21.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:21.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:21.289+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:21.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:21.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:21.289+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:21.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:21.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:21.289+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:21.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:21.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:21.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:21.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:21.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:21.359+0200 W/LOCATION( 7465): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:21.359+0200 W/LOCATION( 7465): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:21.439+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:21.489+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d8858]
04-23 20:10:21.489+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:21.489+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:21.489+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:21.489+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:21.499+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:21.499+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:21.509+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:21.519+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:21.519+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:21.519+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:21.519+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:21.519+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:21.519+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:21.519+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:21.519+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:21.519+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:21.519+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:21.529+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:21.529+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:21.529+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(1096795), time2(1093776)
04-23 20:10:21.529+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:10:21.529+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:21.529+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:21.529+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:21.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:21.539+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:21.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:21.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:21.609+0200 W/LOCATION( 7465): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:21.609+0200 I/LOCATION( 7465): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:21.609+0200 I/LOCATION( 7465): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:21.609+0200 I/location( 7465): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:21.739+0200 I/LOCATION( 7465): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:21.809+0200 E/location( 7465): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:21.809+0200 W/AUL     ( 7465): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:21.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:21.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7465
04-23 20:10:21.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:21.819+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.819+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:21.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:21.819+0200 W/AUL     ( 7465): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:21.819+0200 I/location( 7465): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:21.819+0200 I/location( 7465): stopping es.ugr.frailty.location service
04-23 20:10:21.819+0200 E/CAPI_APPFW_APP_CONTROL( 7465): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:10:21.819+0200 E/location( 7465): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:10:21.819+0200 I/CAPI_APPFW_APPLICATION( 7465): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:10:21.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:10:21.829+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:10:21.829+0200 I/utils   ( 5532): specific action
04-23 20:10:21.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.839+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:21.839+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:21.839+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:21.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:21.849+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.849+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:21.849+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:21.859+0200 I/utils   ( 5538): specific action
04-23 20:10:21.859+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.859+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.859+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.859+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:21.859+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:21.859+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:21.859+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:21.859+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:21.859+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:21.899+0200 W/LOCATION( 7465): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:21.899+0200 I/LOCATION( 7465): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:21.899+0200 I/LOCATION( 7465): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:10:21.989+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:10:21.989+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:10:21.999+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:10:21.999+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:10:22.109+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:22.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:22.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:22.159+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d8858
04-23 20:10:22.229+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e6000]
04-23 20:10:22.229+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:22.229+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:22.229+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:22.229+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:22.239+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:22.239+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:22.249+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.259+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.259+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:22.259+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:22.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:22.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:22.259+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:22.259+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:22.259+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:22.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:22.259+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:22.269+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.269+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.269+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:22.279+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.319+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.329+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.389+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:22.389+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:22.389+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:22.389+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79e6000
04-23 20:10:22.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79d9748]
04-23 20:10:22.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:22.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:22.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:22.479+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:22.489+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:22.489+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:22.499+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.509+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.509+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:22.509+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:22.509+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:22.509+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:22.509+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:22.509+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:22.509+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:22.509+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:22.509+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:22.519+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.529+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:22.529+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:22.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:22.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:10:22.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:10:22.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:10:22.589+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf79d9748
04-23 20:10:22.809+0200 W/AUL     ( 7477): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:10:22.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:10:22.809+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:10:22.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7441
04-23 20:10:22.809+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:10:22.819+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7441
04-23 20:10:22.819+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7441)
04-23 20:10:23.829+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:10:30.999+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:10:30.999+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:10:30.999+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:30.999+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:31.009+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:10:31.009+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 7513
04-23 20:10:31.059+0200 E/CAPI_APPFW_APPLICATION( 7513): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:31.059+0200 E/CAPI_APPFW_APPLICATION( 7513): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:10:31.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7513
04-23 20:10:31.059+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(7513) type(svcapp) bg(0)
04-23 20:10:31.059+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (7513) was created
04-23 20:10:31.059+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7513)
04-23 20:10:31.059+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:10:31.059+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:10:31.059+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7513]
04-23 20:10:31.079+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:31.089+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7513
04-23 20:10:31.089+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:10:31.099+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7513
04-23 20:10:31.099+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:31.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:10:31.129+0200 W/LOCATION( 7513): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:10:31.129+0200 E/LOCATION( 7513): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:10:31.129+0200 E/PKGMGR_INFO( 7513): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:10:31.129+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:31.149+0200 I/LOCATION( 7513): location.c: location_new(269) > method: 0
04-23 20:10:31.149+0200 W/LOCATION( 7513): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:31.159+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:31.159+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:31.159+0200 W/LOCATION( 7513): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:31.169+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:31.169+0200 W/LOCATION( 7513): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:31.169+0200 W/LOCATION( 7513): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:31.169+0200 W/LOCATION( 7513): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:31.169+0200 W/LOCATION( 7513): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:31.189+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:31.199+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:10:31.199+0200 W/LOCATION( 7513): module-internal.c: module_new(311) > module (wps) open success
04-23 20:10:31.199+0200 W/LOCATION( 7513): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:10:31.209+0200 W/LOCATION( 7513): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:10:31.209+0200 W/LOCATION( 7513): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:31.209+0200 W/LOCATION( 7513): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:31.219+0200 W/LOCATION( 7513): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:10:31.219+0200 I/LOCATION( 7513): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7852c18
04-23 20:10:31.219+0200 I/LOCATION( 7513): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:10:31.219+0200 I/LOCATION( 7513): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7852c18
04-23 20:10:31.219+0200 I/LOCATION( 7513): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:10:31.229+0200 I/location( 7513): es.ugr.frailty.location: creado servicio de localización
04-23 20:10:31.269+0200 I/LOCATION( 7513): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:10:31.309+0200 W/LOCATION( 7513): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:31.309+0200 W/LOCATION( 7513): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:31.309+0200 I/LOCATION( 7513): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:10:31.379+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:10:31.379+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:31.379+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:31.379+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:10:31.379+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:10:31.379+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:10:31.379+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:10:31.379+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:10:31.379+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:10:31.389+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:10:31.389+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:10:31.389+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:10:31.389+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:10:31.439+0200 W/LOCATION( 7513): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:10:31.439+0200 W/LOCATION( 7513): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:10:31.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:31.559+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1ecb8]
04-23 20:10:31.559+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:10:31.559+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:10:31.559+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:10:31.559+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:10:31.569+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:31.569+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:31.579+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:31.579+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:31.579+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:10:31.579+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:10:31.579+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:10:31.579+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:10:31.579+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:10:31.579+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:10:31.579+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:10:31.589+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:10:31.589+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:10:31.589+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:31.599+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:10:31.599+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:10:31.609+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:31.629+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:10:31.629+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(1106892), time2(1093776)
04-23 20:10:31.629+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:10:31.629+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:10:31.629+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:10:31.629+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:10:31.649+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:10:31.679+0200 W/LOCATION( 7513): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:10:31.679+0200 I/LOCATION( 7513): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:31.679+0200 I/LOCATION( 7513): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:10:31.679+0200 I/location( 7513): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:10:31.759+0200 I/LOCATION( 7513): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:10:31.809+0200 E/location( 7513): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:10:31.809+0200 W/AUL     ( 7513): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:10:31.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:31.809+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 7513
04-23 20:10:31.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:10:31.819+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:31.819+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:10:31.819+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.819+0200 I/utils   ( 5532): specific action
04-23 20:10:31.819+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.819+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.819+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.819+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:10:31.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:10:31.819+0200 W/AUL     ( 7513): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:10:31.819+0200 I/location( 7513): request sent to service es.ugr.frailty.servicemanager
04-23 20:10:31.819+0200 W/CAPI_APPFW_APP_CONTROL( 7513): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.819+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:10:31.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:10:31.829+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:10:31.829+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:10:31.829+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.839+0200 I/utils   ( 5538): specific action
04-23 20:10:31.839+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.839+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.839+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.839+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:10:31.839+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:10:31.839+0200 I/recorder( 5538): guardando datos en local
04-23 20:10:31.839+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:10:31.839+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:10:31.839+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:10:31.839+0200 I/utils   ( 7513): specific action
04-23 20:10:32.349+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:32.349+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:32.349+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:32.619+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:10:33.199+0200 W/LOCATION( 7513): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:10:33.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:10:33.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:10:33.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:10:33.389+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11075136c6f63152450703
