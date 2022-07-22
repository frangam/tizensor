S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9379
Date: 2018-04-23 20:30:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75ea52d, r5   = 0xf7901f98
r6   = 0xff999ea0, r7   = 0xff999d50
r8   = 0xf78fec18, r9   = 0x00000000
r10  = 0xff999e2c, fp   = 0xff999ea0
ip   = 0x00000001, sp   = 0xff999d28
lr   = 0xf75ea539, pc   = 0xf7653228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146948 KB
Buffers:     34864 KB
Cached:     153644 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12084 KB
VmRSS:       12080 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9379 TID = 9379
9379 9382 

Maps Information
f44b5000 f4cb4000 rw-p [stack:9382]
f4cbb000 f4cbd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cc5000 f4cc9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cd2000 f4cd4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cdc000 f4cdf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cee000 f4cf3000 r-xp /usr/lib/libsystem.so.0.0.0
f4cfe000 f4d01000 r-xp /lib/libattr.so.1.1.0
f4d09000 f4d19000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d21000 f4d2a000 r-xp /usr/lib/libedbus.so.1.7.99
f4d32000 f4d33000 r-xp /usr/lib/libresponse.so.0.2.96
f4d3c000 f4d41000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65e3000 f66e9000 r-xp /usr/lib/libicuuc.so.57.1
f66ff000 f6887000 r-xp /usr/lib/libicui18n.so.57.1
f6897000 f68a4000 r-xp /usr/lib/libail.so.0.1.0
f68ad000 f68b4000 r-xp /usr/lib/libminizip.so.1.0.0
f68bd000 f6a66000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a86000 f6acd000 r-xp /usr/lib/libssl.so.1.0.0
f6ad9000 f6adb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ae3000 f6aea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6af3000 f6afa000 r-xp /lib/libcrypt-2.13.so
f6b2b000 f6b2e000 r-xp /lib/libcap.so.2.21
f6b36000 f6b38000 r-xp /usr/lib/libiri.so
f6b40000 f6b89000 r-xp /usr/lib/libmdm.so.1.2.69
f6b91000 f6b97000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b9f000 f6bc2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bcc000 f6bce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bd6000 f6bf3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bfc000 f6c00000 r-xp /usr/lib/libsmack.so.1.0.0
f6c09000 f6c22000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c2b000 f6c33000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c3b000 f6c41000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c4a000 f6c4c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c55000 f6c65000 r-xp /lib/libresolv-2.13.so
f6c69000 f6c81000 r-xp /usr/lib/liblzma.so.5.0.3
f6c8a000 f6c8c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c94000 f6cae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cb6000 f6ce5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cee000 f6cfd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d07000 f6d11000 r-xp /usr/lib/libsensord-shared.so
f6d1a000 f6ded000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6df8000 f6e0e000 r-xp /lib/libz.so.1.2.5
f6e16000 f6e1b000 r-xp /usr/lib/libffi.so.5.0.10
f6e23000 f6e24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e2c000 f6e3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e44000 f6e5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e65000 f6e67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e6f000 f6ee4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eee000 f6ef4000 r-xp /lib/librt-2.13.so
f6efd000 f6f1b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f25000 f6f26000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f2e000 f6f51000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f59000 f6f5e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f66000 f6f90000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f99000 f6fb0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fb8000 f7021000 r-xp /lib/libm-2.13.so
f702a000 f70be000 r-xp /usr/lib/libstdc++.so.6.0.16
f70d1000 f70d6000 r-xp /usr/lib/libctx-client.so.0.8.3
f70de000 f70e5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70ed000 f7117000 r-xp /usr/lib/libsensor.so.1.9.6
f7120000 f71ec000 r-xp /usr/lib/libxml2.so.2.7.8
f71f9000 f71fb000 r-xp /usr/lib/libiniparser.so.0
f7204000 f720a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7213000 f72e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72e4000 f7318000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7321000 f735d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7365000 f7368000 r-xp /usr/lib/libbundle.so.0.1.22
f7370000 f7376000 r-xp /usr/lib/libappsvc.so.0.1.0
f737e000 f73bf000 r-xp /usr/lib/libeina.so.1.7.99
f73c8000 f73df000 r-xp /usr/lib/libecore.so.1.7.99
f73f6000 f73ff000 r-xp /usr/lib/libvconf.so.0.2.45
f7407000 f741b000 r-xp /lib/libpthread-2.13.so
f7426000 f7433000 r-xp /usr/lib/libaul.so.0.1.0
f743d000 f743f000 r-xp /lib/libdl-2.13.so
f7448000 f7453000 r-xp /lib/libunwind.so.8.0.1
f7480000 f7488000 r-xp /lib/libgcc_s-4.6.so.1
f7489000 f75ad000 r-xp /lib/libc-2.13.so
f75bb000 f75bd000 r-xp /usr/lib/libdlog.so.0.0.0
f75c5000 f75d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75da000 f75df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75e7000 f75f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75fe000 f7602000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f760b000 f760e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7616000 f7618000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7620000 f7624000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f762c000 f7649000 r-xp /lib/ld-2.13.so
f7652000 f7655000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7655000 f7659000 r-xp /usr/lib/libsys-assert.so
f78ce000 f7958000 rw-p [heap]
ff97b000 ff99c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9379)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7653228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72f13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7301be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7301dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf733675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7301be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7301dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7333e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7334017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf733bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cd31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cc6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d99663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7246fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73d8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73d3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73d45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73d4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf760c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf760c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76534f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf74a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7652f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
orted(340) > module name(gps) is found
04-23 20:30:16.159+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:16.159+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:16.159+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:16.159+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:16.159+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:16.159+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:16.169+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.179+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.179+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:16.179+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:16.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:16.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:16.289+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:16.289+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:16.289+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:16.289+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4006248
04-23 20:30:16.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf7710e78]
04-23 20:30:16.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:16.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:16.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:16.359+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:16.369+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:16.369+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:16.379+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.389+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.389+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:16.389+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:16.389+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:16.389+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:16.389+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:16.389+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:16.389+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:16.389+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:16.389+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:16.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.409+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:16.409+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:16.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:16.449+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:16.449+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:16.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:16.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:16.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf7710e78
04-23 20:30:16.629+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:30:16.629+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:16.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:16.629+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:16.639+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9331
04-23 20:30:16.649+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:16.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9331
04-23 20:30:16.689+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9331) type(svcapp) bg(0)
04-23 20:30:16.699+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9331)
04-23 20:30:16.699+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:30:16.699+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:16.699+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9331]
04-23 20:30:16.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:16.719+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9331
04-23 20:30:16.719+0200 E/CAPI_APPFW_APPLICATION( 9331): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:16.719+0200 E/CAPI_APPFW_APPLICATION( 9331): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:16.719+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9331) was created
04-23 20:30:16.719+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:16.729+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:16.739+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9331
04-23 20:30:16.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:16.759+0200 W/LOCATION( 9331): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:16.759+0200 E/LOCATION( 9331): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:16.759+0200 E/PKGMGR_INFO( 9331): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:16.759+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:16.779+0200 I/LOCATION( 9331): location.c: location_new(269) > method: 0
04-23 20:30:16.779+0200 W/LOCATION( 9331): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:16.789+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:16.789+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:16.789+0200 W/LOCATION( 9331): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:16.799+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:16.799+0200 W/LOCATION( 9331): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:16.799+0200 W/LOCATION( 9331): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:16.799+0200 W/LOCATION( 9331): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:16.799+0200 W/LOCATION( 9331): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:16.819+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:16.819+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:16.829+0200 W/LOCATION( 9331): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:16.829+0200 W/LOCATION( 9331): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:16.829+0200 W/LOCATION( 9331): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:16.829+0200 W/LOCATION( 9331): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:16.829+0200 W/LOCATION( 9331): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:16.849+0200 W/LOCATION( 9331): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:16.849+0200 I/LOCATION( 9331): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7553c18
04-23 20:30:16.849+0200 I/LOCATION( 9331): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:16.849+0200 I/LOCATION( 9331): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7553c18
04-23 20:30:16.849+0200 I/LOCATION( 9331): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:16.859+0200 I/location( 9331): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:16.899+0200 I/LOCATION( 9331): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:16.939+0200 W/LOCATION( 9331): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:16.939+0200 W/LOCATION( 9331): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:16.939+0200 I/LOCATION( 9331): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:17.009+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:17.009+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:17.009+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:17.009+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:17.009+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:17.009+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:17.019+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:17.019+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:17.019+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:17.019+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:17.069+0200 W/LOCATION( 9331): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:17.069+0200 W/LOCATION( 9331): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:17.139+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:17.179+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76c9f88]
04-23 20:30:17.179+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:17.179+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:17.179+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:17.179+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:17.189+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:17.189+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:17.199+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.209+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.209+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:17.209+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:17.209+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:17.209+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:17.209+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:17.209+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:17.209+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:17.209+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:17.209+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:17.219+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.229+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.229+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:17.229+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:17.249+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2292512), time2(2289481)
04-23 20:30:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:30:17.249+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:17.249+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:17.249+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:17.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:17.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:17.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:17.289+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:17.319+0200 W/LOCATION( 9331): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:17.319+0200 I/LOCATION( 9331): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:17.319+0200 I/LOCATION( 9331): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:17.319+0200 I/location( 9331): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:17.439+0200 I/LOCATION( 9331): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:17.499+0200 E/location( 9331): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:17.499+0200 W/AUL     ( 9331): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:17.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:17.499+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9331
04-23 20:30:17.509+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:17.509+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:17.509+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:17.509+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.509+0200 I/utils   ( 8242): specific action
04-23 20:30:17.509+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.509+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.509+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.509+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:17.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:17.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:17.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:17.539+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:17.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:17.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.539+0200 I/utils   ( 8247): specific action
04-23 20:30:17.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:17.539+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:17.539+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:17.559+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:17.559+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:17.559+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:17.559+0200 W/AUL     ( 9331): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:17.559+0200 I/location( 9331): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:17.559+0200 I/location( 9331): stopping es.ugr.frailty.location service
04-23 20:30:17.559+0200 E/CAPI_APPFW_APP_CONTROL( 9331): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:30:17.559+0200 E/location( 9331): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:30:17.559+0200 I/CAPI_APPFW_APPLICATION( 9331): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:17.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:17.559+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:17.629+0200 W/LOCATION( 9331): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:17.639+0200 I/LOCATION( 9331): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:17.639+0200 I/LOCATION( 9331): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:30:17.749+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:30:17.749+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:30:17.749+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:30:17.749+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:30:17.859+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:17.919+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:17.919+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:17.919+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:17.919+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76c9f88
04-23 20:30:17.979+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40205a0]
04-23 20:30:17.979+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:17.979+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:17.979+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:17.979+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:17.989+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:17.989+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:17.999+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.999+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:17.999+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:18.009+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:18.009+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:18.009+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:18.009+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:18.009+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:18.009+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:18.009+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:18.009+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:18.009+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.019+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.019+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:18.019+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:18.069+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:18.079+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:18.149+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:18.149+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:18.149+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:18.149+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf40205a0
04-23 20:30:18.169+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40023d8]
04-23 20:30:18.169+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:18.169+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:18.169+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:18.169+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:18.169+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:18.169+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:18.189+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.199+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.199+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:18.199+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:18.199+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:18.199+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:18.199+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:18.199+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:18.199+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:18.199+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:18.199+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:18.209+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.219+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:18.219+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:18.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:18.269+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:18.279+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:18.279+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:18.279+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:18.279+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf40023d8
04-23 20:30:18.499+0200 W/AUL     ( 9343): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:30:18.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:18.499+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:18.499+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9307
04-23 20:30:18.499+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:18.499+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9307
04-23 20:30:18.499+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9307)
04-23 20:30:19.559+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:30:26.699+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:30:26.699+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:26.709+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:26.709+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:26.719+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:26.719+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9379
04-23 20:30:26.769+0200 E/CAPI_APPFW_APPLICATION( 9379): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:26.769+0200 E/CAPI_APPFW_APPLICATION( 9379): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:26.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9379
04-23 20:30:26.769+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9379) type(svcapp) bg(0)
04-23 20:30:26.769+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9379) was created
04-23 20:30:26.769+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9379]
04-23 20:30:26.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:26.789+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9379
04-23 20:30:26.789+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:26.789+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9379)
04-23 20:30:26.789+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:30:26.789+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:26.809+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:26.809+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9379
04-23 20:30:26.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:26.829+0200 W/LOCATION( 9379): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:26.829+0200 E/LOCATION( 9379): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:26.829+0200 E/PKGMGR_INFO( 9379): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:26.829+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:26.849+0200 I/LOCATION( 9379): location.c: location_new(269) > method: 0
04-23 20:30:26.849+0200 W/LOCATION( 9379): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:26.849+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:26.859+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:26.859+0200 W/LOCATION( 9379): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:26.869+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:26.869+0200 W/LOCATION( 9379): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:26.869+0200 W/LOCATION( 9379): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:26.869+0200 W/LOCATION( 9379): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:26.869+0200 W/LOCATION( 9379): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:26.889+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:26.899+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:26.899+0200 W/LOCATION( 9379): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:26.899+0200 W/LOCATION( 9379): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:26.909+0200 W/LOCATION( 9379): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:26.909+0200 W/LOCATION( 9379): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:26.909+0200 W/LOCATION( 9379): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:26.929+0200 W/LOCATION( 9379): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:26.929+0200 I/LOCATION( 9379): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf78fec18
04-23 20:30:26.929+0200 I/LOCATION( 9379): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:26.929+0200 I/LOCATION( 9379): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf78fec18
04-23 20:30:26.929+0200 I/LOCATION( 9379): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:26.929+0200 I/location( 9379): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:26.979+0200 I/LOCATION( 9379): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:27.019+0200 W/LOCATION( 9379): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:27.019+0200 W/LOCATION( 9379): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:27.019+0200 I/LOCATION( 9379): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:27.089+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:27.089+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:27.089+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:27.089+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:27.089+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:27.089+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:27.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:27.089+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:27.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:27.089+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:27.089+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:27.089+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:27.139+0200 W/LOCATION( 9379): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:27.139+0200 W/LOCATION( 9379): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:27.219+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:27.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf40317c0]
04-23 20:30:27.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:27.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:27.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:27.249+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:27.259+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:27.259+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:27.269+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:27.279+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:27.279+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:27.279+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:27.279+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:27.279+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:27.279+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:27.279+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:27.279+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:27.279+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:27.279+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:27.279+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:27.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:27.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:27.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:27.299+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:27.299+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:27.299+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:27.319+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:27.319+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2302588), time2(2289481)
04-23 20:30:27.319+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:30:27.319+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:27.319+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:27.319+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:27.349+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:27.379+0200 W/LOCATION( 9379): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:27.379+0200 I/LOCATION( 9379): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:27.379+0200 I/LOCATION( 9379): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:27.379+0200 I/location( 9379): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:27.469+0200 I/LOCATION( 9379): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:27.519+0200 E/location( 9379): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:27.519+0200 W/AUL     ( 9379): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:27.519+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:27.519+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9379
04-23 20:30:27.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:27.529+0200 W/AUL     ( 9379): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:27.529+0200 I/location( 9379): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:27.529+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.529+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:27.529+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:27.529+0200 W/CAPI_APPFW_APP_CONTROL( 9379): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.529+0200 I/utils   ( 9379): specific action
04-23 20:30:27.529+0200 I/utils   ( 8242): specific action
04-23 20:30:27.529+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.529+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.529+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.529+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:27.529+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:27.529+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:27.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:27.539+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.539+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:27.539+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:27.539+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:27.539+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:27.539+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:27.549+0200 I/utils   ( 8247): specific action
04-23 20:30:27.549+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.549+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.549+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.549+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:27.549+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:27.549+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:28.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:28.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:28.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:28.309+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:30:29.109+0200 W/LOCATION( 9379): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:30:29.259+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11093796c6f63152450822
