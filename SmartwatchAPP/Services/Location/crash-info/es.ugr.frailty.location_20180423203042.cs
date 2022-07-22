S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9448
Date: 2018-04-23 20:30:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71f052d, r5   = 0xf7644f98
r6   = 0xff9bcaa0, r7   = 0xff9bc950
r8   = 0xf7641c18, r9   = 0x00000000
r10  = 0xff9bca2c, fp   = 0xff9bcaa0
ip   = 0x00000001, sp   = 0xff9bc928
lr   = 0xf71f0539, pc   = 0xf7259228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    146808 KB
Buffers:     35036 KB
Cached:     153384 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11952 KB
VmRSS:       11952 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9448 TID = 9448
9448 9451 

Maps Information
f40bb000 f48ba000 rw-p [stack:9451]
f48c1000 f48c3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48cb000 f48cf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48d8000 f48da000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48e2000 f48e5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48f4000 f48f9000 r-xp /usr/lib/libsystem.so.0.0.0
f4904000 f4907000 r-xp /lib/libattr.so.1.1.0
f490f000 f491f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4927000 f4930000 r-xp /usr/lib/libedbus.so.1.7.99
f4938000 f4939000 r-xp /usr/lib/libresponse.so.0.2.96
f4942000 f4947000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61e9000 f62ef000 r-xp /usr/lib/libicuuc.so.57.1
f6305000 f648d000 r-xp /usr/lib/libicui18n.so.57.1
f649d000 f64aa000 r-xp /usr/lib/libail.so.0.1.0
f64b3000 f64ba000 r-xp /usr/lib/libminizip.so.1.0.0
f64c3000 f666c000 r-xp /usr/lib/libcrypto.so.1.0.0
f668c000 f66d3000 r-xp /usr/lib/libssl.so.1.0.0
f66df000 f66e1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66e9000 f66f0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66f9000 f6700000 r-xp /lib/libcrypt-2.13.so
f6731000 f6734000 r-xp /lib/libcap.so.2.21
f673c000 f673e000 r-xp /usr/lib/libiri.so
f6746000 f678f000 r-xp /usr/lib/libmdm.so.1.2.69
f6797000 f679d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67a5000 f67c8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67d2000 f67d4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67dc000 f67f9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6802000 f6806000 r-xp /usr/lib/libsmack.so.1.0.0
f680f000 f6828000 r-xp /usr/lib/libnetwork.so.0.0.0
f6831000 f6839000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6841000 f6847000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6850000 f6852000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f685b000 f686b000 r-xp /lib/libresolv-2.13.so
f686f000 f6887000 r-xp /usr/lib/liblzma.so.5.0.3
f6890000 f6892000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f689a000 f68b4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68bc000 f68eb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68f4000 f6903000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f690d000 f6917000 r-xp /usr/lib/libsensord-shared.so
f6920000 f69f3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69fe000 f6a14000 r-xp /lib/libz.so.1.2.5
f6a1c000 f6a21000 r-xp /usr/lib/libffi.so.5.0.10
f6a29000 f6a2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a32000 f6a42000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a4a000 f6a63000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a6b000 f6a6d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a75000 f6aea000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6af4000 f6afa000 r-xp /lib/librt-2.13.so
f6b03000 f6b21000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b2b000 f6b2c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b34000 f6b57000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b5f000 f6b64000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b6c000 f6b96000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b9f000 f6bb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bbe000 f6c27000 r-xp /lib/libm-2.13.so
f6c30000 f6cc4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cd7000 f6cdc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ce4000 f6ceb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cf3000 f6d1d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d26000 f6df2000 r-xp /usr/lib/libxml2.so.2.7.8
f6dff000 f6e01000 r-xp /usr/lib/libiniparser.so.0
f6e0a000 f6e10000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e19000 f6ee9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eea000 f6f1e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f27000 f6f63000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f6b000 f6f6e000 r-xp /usr/lib/libbundle.so.0.1.22
f6f76000 f6f7c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f84000 f6fc5000 r-xp /usr/lib/libeina.so.1.7.99
f6fce000 f6fe5000 r-xp /usr/lib/libecore.so.1.7.99
f6ffc000 f7005000 r-xp /usr/lib/libvconf.so.0.2.45
f700d000 f7021000 r-xp /lib/libpthread-2.13.so
f702c000 f7039000 r-xp /usr/lib/libaul.so.0.1.0
f7043000 f7045000 r-xp /lib/libdl-2.13.so
f704e000 f7059000 r-xp /lib/libunwind.so.8.0.1
f7086000 f708e000 r-xp /lib/libgcc_s-4.6.so.1
f708f000 f71b3000 r-xp /lib/libc-2.13.so
f71c1000 f71c3000 r-xp /usr/lib/libdlog.so.0.0.0
f71cb000 f71d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71e0000 f71e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71ed000 f71fc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7204000 f7208000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7211000 f7214000 r-xp /usr/lib/libappcore-agent.so.1.1
f721c000 f721e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7226000 f722a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7232000 f724f000 r-xp /lib/ld-2.13.so
f7258000 f725b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f725b000 f725f000 r-xp /usr/lib/libsys-assert.so
f7611000 f769b000 rw-p [heap]
ff99e000 ff9bf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9448)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7259228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71f0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ef73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ef5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f3c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f371f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ef5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f01e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f07be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f07dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f39e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f3a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f41f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48d91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf48cc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf699f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e4cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e4e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fdeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fd9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fda5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fda879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7212183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72127fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72594f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf70a685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7258f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
69+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:29.469+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:29.469+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:29.469+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:29.469+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.479+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.479+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:29.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:29.539+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:29.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:29.599+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:29.599+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:29.599+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:29.599+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400b600
04-23 20:30:29.669+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400c418]
04-23 20:30:29.669+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:29.669+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:29.669+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:29.669+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:29.679+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:29.679+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:29.689+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.699+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.699+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:29.699+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:29.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:29.699+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:29.699+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:29.699+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:29.699+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:29.699+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:29.699+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:29.709+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.719+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:29.719+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:29.719+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:29.759+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:29.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:29.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:29.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:29.769+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400c418
04-23 20:30:29.799+0200 I/servicemanager( 8242): es.ugr.frailty.location sleep timeout
04-23 20:30:29.799+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:29.799+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:29.799+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:29.809+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9397
04-23 20:30:29.809+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:29.859+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9397
04-23 20:30:29.859+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9397) type(svcapp) bg(0)
04-23 20:30:29.859+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9397)
04-23 20:30:29.859+0200 I/servicemanager( 8242): es.ugr.frailty.location stop request sent!
04-23 20:30:29.859+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:29.859+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9397]
04-23 20:30:29.859+0200 E/CAPI_APPFW_APPLICATION( 9397): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:29.859+0200 E/CAPI_APPFW_APPLICATION( 9397): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:29.859+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9397) was created
04-23 20:30:29.879+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:29.889+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9397
04-23 20:30:29.889+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:29.899+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9397
04-23 20:30:29.899+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:29.909+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:29.939+0200 W/LOCATION( 9397): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:29.939+0200 E/LOCATION( 9397): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:29.939+0200 E/PKGMGR_INFO( 9397): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:29.949+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:29.969+0200 I/LOCATION( 9397): location.c: location_new(269) > method: 0
04-23 20:30:29.969+0200 W/LOCATION( 9397): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:29.969+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:29.979+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:29.989+0200 W/LOCATION( 9397): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:29.989+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:29.999+0200 W/LOCATION( 9397): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:29.999+0200 W/LOCATION( 9397): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:29.999+0200 W/LOCATION( 9397): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:29.999+0200 W/LOCATION( 9397): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:30.029+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:30.029+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:30.039+0200 W/LOCATION( 9397): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:30.039+0200 W/LOCATION( 9397): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:30.039+0200 W/LOCATION( 9397): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:30.049+0200 W/LOCATION( 9397): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:30.049+0200 W/LOCATION( 9397): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:30.079+0200 W/LOCATION( 9397): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:30.079+0200 I/LOCATION( 9397): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf72d8c18
04-23 20:30:30.079+0200 I/LOCATION( 9397): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:30.079+0200 I/LOCATION( 9397): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf72d8c18
04-23 20:30:30.079+0200 I/LOCATION( 9397): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:30.079+0200 I/location( 9397): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:30.139+0200 I/LOCATION( 9397): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:30.189+0200 W/LOCATION( 9397): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:30.189+0200 W/LOCATION( 9397): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:30.189+0200 I/LOCATION( 9397): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:30.259+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:30.259+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:30.259+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:30.259+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:30.259+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:30.259+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:30.259+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:30.259+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:30.269+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:30.269+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:30.269+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:30.269+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:30.269+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:30.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:30.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:30.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:30.349+0200 W/LOCATION( 9397): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:30.349+0200 W/LOCATION( 9397): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:30.429+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:30.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf76c28e0]
04-23 20:30:30.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:30.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:30.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:30.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:30.479+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:30.479+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:30.489+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:30.499+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:30.499+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(2305760), time2(2302589)
04-23 20:30:30.499+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 20:30:30.499+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:30.499+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:30.499+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:30.499+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:30.499+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:30.499+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:30.499+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:30.499+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:30.499+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:30.499+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:30.499+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:30.499+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:30.499+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:30.509+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:30.509+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:30.509+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:30.519+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:30.559+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:30.599+0200 W/LOCATION( 9397): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:30.599+0200 I/LOCATION( 9397): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:30.599+0200 I/LOCATION( 9397): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:30.599+0200 I/location( 9397): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:30.689+0200 I/LOCATION( 9397): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:30.739+0200 E/location( 9397): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:30.739+0200 W/AUL     ( 9397): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:30.739+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:30.739+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9397
04-23 20:30:30.749+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:30.759+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:30.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:30.759+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.759+0200 I/utils   ( 8242): specific action
04-23 20:30:30.759+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.759+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.759+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.759+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:30.759+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:30.759+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:30.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:30.769+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:30.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:30.769+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.769+0200 I/utils   ( 8247): specific action
04-23 20:30:30.769+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.769+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.769+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.769+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:30.769+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:30.769+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:30.769+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:30.769+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:30.769+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:30.769+0200 W/AUL     ( 9397): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:30.769+0200 I/location( 9397): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:30.769+0200 I/location( 9397): stopping es.ugr.frailty.location service
04-23 20:30:30.769+0200 E/CAPI_APPFW_APP_CONTROL( 9397): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:30:30.769+0200 E/location( 9397): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
04-23 20:30:30.769+0200 I/CAPI_APPFW_APPLICATION( 9397): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:30:30.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:30:30.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:30:30.819+0200 W/LOCATION( 9397): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:30.819+0200 I/LOCATION( 9397): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:30.819+0200 I/LOCATION( 9397): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:30:30.889+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:30:30.889+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:30:30.899+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:30:30.899+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:30:30.989+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.029+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:31.029+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:31.029+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:31.029+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf76c28e0
04-23 20:30:31.089+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf400b3d0]
04-23 20:30:31.089+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:31.089+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:31.089+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:31.089+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:31.099+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:31.099+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:31.099+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.109+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.109+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:31.109+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:31.109+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:31.109+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:31.109+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:31.109+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:31.109+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:31.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:31.109+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:31.119+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.129+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.129+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:31.129+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.199+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.209+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.259+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:31.259+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:31.259+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:31.259+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400b3d0
04-23 20:30:31.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4002a48]
04-23 20:30:31.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:31.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:31.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:31.339+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:31.339+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:31.339+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:31.349+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.359+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.359+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:31.359+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:31.359+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:31.359+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:31.359+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:31.359+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:31.359+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:31.359+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:31.359+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:31.399+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.409+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:31.409+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:31.419+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.459+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:31.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:30:31.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:30:31.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:30:31.469+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4002a48
04-23 20:30:31.669+0200 W/AUL     ( 9412): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:30:31.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:30:31.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:30:31.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9379
04-23 20:30:31.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:30:31.669+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9379
04-23 20:30:31.669+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9379)
04-23 20:30:32.769+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:30:39.869+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:30:39.869+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:30:39.869+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:39.869+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:39.879+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9448
04-23 20:30:39.879+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:30:39.929+0200 E/CAPI_APPFW_APPLICATION( 9448): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:39.929+0200 E/CAPI_APPFW_APPLICATION( 9448): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:30:39.929+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9448
04-23 20:30:39.929+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9448) type(svcapp) bg(0)
04-23 20:30:39.929+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9448) was created
04-23 20:30:39.929+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9448)
04-23 20:30:39.929+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:30:39.929+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:30:39.929+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9448]
04-23 20:30:39.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:39.949+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9448
04-23 20:30:39.949+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:39.969+0200 W/LOCATION( 9448): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:30:39.969+0200 E/LOCATION( 9448): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:30:39.969+0200 E/PKGMGR_INFO( 9448): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:30:39.969+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:39.989+0200 I/LOCATION( 9448): location.c: location_new(269) > method: 0
04-23 20:30:39.989+0200 W/LOCATION( 9448): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:39.989+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:39.999+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:39.999+0200 W/LOCATION( 9448): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:40.009+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:40.009+0200 W/LOCATION( 9448): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:40.009+0200 W/LOCATION( 9448): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:40.009+0200 W/LOCATION( 9448): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:40.009+0200 W/LOCATION( 9448): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:40.029+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:40.029+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:30:40.039+0200 W/LOCATION( 9448): module-internal.c: module_new(311) > module (wps) open success
04-23 20:30:40.039+0200 W/LOCATION( 9448): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:30:40.039+0200 W/LOCATION( 9448): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:30:40.049+0200 W/LOCATION( 9448): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:40.049+0200 W/LOCATION( 9448): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:40.059+0200 W/LOCATION( 9448): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:30:40.059+0200 I/LOCATION( 9448): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7641c18
04-23 20:30:40.059+0200 I/LOCATION( 9448): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:30:40.069+0200 I/LOCATION( 9448): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7641c18
04-23 20:30:40.069+0200 I/LOCATION( 9448): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:30:40.069+0200 I/location( 9448): es.ugr.frailty.location: creado servicio de localización
04-23 20:30:40.109+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:30:40.119+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9448
04-23 20:30:40.119+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:30:40.119+0200 I/LOCATION( 9448): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:30:40.159+0200 W/LOCATION( 9448): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:40.159+0200 W/LOCATION( 9448): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:40.159+0200 I/LOCATION( 9448): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:30:40.229+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:30:40.229+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:40.229+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:40.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:30:40.229+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:30:40.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:30:40.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:30:40.229+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:30:40.229+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:30:40.239+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:30:40.239+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:30:40.239+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:30:40.239+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:30:40.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:40.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:40.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:40.289+0200 W/LOCATION( 9448): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:30:40.289+0200 W/LOCATION( 9448): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:30:40.369+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:40.409+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4001b08]
04-23 20:30:40.409+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:30:40.409+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:30:40.409+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:30:40.409+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:30:40.419+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:40.419+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:40.429+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:40.439+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:40.439+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:30:40.439+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:30:40.439+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:30:40.439+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:30:40.439+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:30:40.439+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:30:40.439+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:30:40.439+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:30:40.439+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:30:40.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:40.449+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:30:40.449+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:30:40.459+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:40.459+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:30:40.459+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2315727), time2(2302589)
04-23 20:30:40.459+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:30:40.459+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:30:40.459+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:30:40.459+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:30:40.499+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:30:40.529+0200 W/LOCATION( 9448): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:30:40.529+0200 I/LOCATION( 9448): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:40.529+0200 I/LOCATION( 9448): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:30:40.529+0200 I/location( 9448): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:30:40.619+0200 I/LOCATION( 9448): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:30:40.659+0200 E/location( 9448): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:30:40.659+0200 W/AUL     ( 9448): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:30:40.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:40.669+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9448
04-23 20:30:40.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:30:40.679+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:40.679+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:30:40.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.679+0200 I/utils   ( 8242): specific action
04-23 20:30:40.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.679+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.679+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:30:40.679+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:30:40.679+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:30:40.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:30:40.689+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:30:40.689+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:30:40.689+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:30:40.689+0200 W/AUL     ( 9448): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:30:40.689+0200 I/location( 9448): request sent to service es.ugr.frailty.servicemanager
04-23 20:30:40.689+0200 W/CAPI_APPFW_APP_CONTROL( 9448): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.689+0200 I/utils   ( 9448): specific action
04-23 20:30:40.689+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:30:40.689+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:30:40.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.689+0200 I/utils   ( 8247): specific action
04-23 20:30:40.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.689+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.699+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:30:40.699+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:30:40.699+0200 I/recorder( 8247): guardando datos en local
04-23 20:30:41.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:41.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:41.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:41.449+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:30:42.109+0200 W/LOCATION( 9448): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:30:42.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:30:42.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:30:42.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:30:42.299+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11094486c6f63152450824
