S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20493
Date: 2018-04-23 15:58:22+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf746c52d, r5   = 0xf77d5f98
r6   = 0xffc41a58, r7   = 0xffc41908
r8   = 0xf77d2c18, r9   = 0x00000000
r10  = 0xffc419e4, fp   = 0xffc41a58
ip   = 0x00000001, sp   = 0xffc40788
lr   = 0xf746c539, pc   = 0xf74d52b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12892 KB
Buffers:     58516 KB
Cached:     229292 KB
VmPeak:      52408 KB
VmSize:      52404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11904 KB
VmRSS:       11904 KB
VmData:      10132 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20493 TID = 20493
20493 20496 

Maps Information
f4337000 f4b36000 rw-p [stack:20496]
f4b3d000 f4b3f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b47000 f4b4b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b54000 f4b56000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b5e000 f4b61000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b70000 f4b75000 r-xp /usr/lib/libsystem.so.0.0.0
f4b80000 f4b83000 r-xp /lib/libattr.so.1.1.0
f4b8b000 f4b9b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ba3000 f4bac000 r-xp /usr/lib/libedbus.so.1.7.99
f4bb4000 f4bb5000 r-xp /usr/lib/libresponse.so.0.2.96
f4bbe000 f4bc3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6465000 f656b000 r-xp /usr/lib/libicuuc.so.57.1
f6581000 f6709000 r-xp /usr/lib/libicui18n.so.57.1
f6719000 f6726000 r-xp /usr/lib/libail.so.0.1.0
f672f000 f6736000 r-xp /usr/lib/libminizip.so.1.0.0
f673f000 f68e8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6908000 f694f000 r-xp /usr/lib/libssl.so.1.0.0
f695b000 f695d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6965000 f696c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6975000 f697c000 r-xp /lib/libcrypt-2.13.so
f69ad000 f69b0000 r-xp /lib/libcap.so.2.21
f69b8000 f69ba000 r-xp /usr/lib/libiri.so
f69c2000 f6a0b000 r-xp /usr/lib/libmdm.so.1.2.69
f6a13000 f6a19000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a21000 f6a44000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a4e000 f6a50000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a58000 f6a75000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a7e000 f6a82000 r-xp /usr/lib/libsmack.so.1.0.0
f6a8b000 f6aa4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6aad000 f6ab5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6abd000 f6ac3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6acc000 f6ace000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ad7000 f6ae7000 r-xp /lib/libresolv-2.13.so
f6aeb000 f6b03000 r-xp /usr/lib/liblzma.so.5.0.3
f6b0c000 f6b0e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b16000 f6b30000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b38000 f6b67000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b70000 f6b7f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b89000 f6b93000 r-xp /usr/lib/libsensord-shared.so
f6b9c000 f6c6f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c7a000 f6c90000 r-xp /lib/libz.so.1.2.5
f6c98000 f6c9d000 r-xp /usr/lib/libffi.so.5.0.10
f6ca5000 f6ca6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cae000 f6cbe000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cc6000 f6cdf000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ce7000 f6ce9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cf1000 f6d66000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d70000 f6d76000 r-xp /lib/librt-2.13.so
f6d7f000 f6d9d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6da7000 f6da8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6db0000 f6dd3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ddb000 f6de0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6de8000 f6e12000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e1b000 f6e32000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e3a000 f6ea3000 r-xp /lib/libm-2.13.so
f6eac000 f6f40000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f53000 f6f58000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f60000 f6f67000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f6f000 f6f99000 r-xp /usr/lib/libsensor.so.1.9.6
f6fa2000 f706e000 r-xp /usr/lib/libxml2.so.2.7.8
f707b000 f707d000 r-xp /usr/lib/libiniparser.so.0
f7086000 f708c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7095000 f7165000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7166000 f719a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71a3000 f71df000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71e7000 f71ea000 r-xp /usr/lib/libbundle.so.0.1.22
f71f2000 f71f8000 r-xp /usr/lib/libappsvc.so.0.1.0
f7200000 f7241000 r-xp /usr/lib/libeina.so.1.7.99
f724a000 f7261000 r-xp /usr/lib/libecore.so.1.7.99
f7278000 f7281000 r-xp /usr/lib/libvconf.so.0.2.45
f7289000 f729d000 r-xp /lib/libpthread-2.13.so
f72a8000 f72b5000 r-xp /usr/lib/libaul.so.0.1.0
f72bf000 f72c1000 r-xp /lib/libdl-2.13.so
f72ca000 f72d5000 r-xp /lib/libunwind.so.8.0.1
f7302000 f730a000 r-xp /lib/libgcc_s-4.6.so.1
f730b000 f742f000 r-xp /lib/libc-2.13.so
f743d000 f743f000 r-xp /usr/lib/libdlog.so.0.0.0
f7447000 f7453000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f745c000 f7461000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7469000 f7478000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7480000 f7484000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f748d000 f7490000 r-xp /usr/lib/libappcore-agent.so.1.1
f7498000 f749a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74a2000 f74a6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74ae000 f74cb000 r-xp /lib/ld-2.13.so
f74d4000 f74d7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74d7000 f74db000 r-xp /usr/lib/libsys-assert.so
f77a2000 f7812000 rw-p [heap]
ffc23000 ffc44000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20493)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74d52b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf746c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71733f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7171c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf717de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7183be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7183dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71b875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71b31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7171c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf717de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7183be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7183dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71b5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71b6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71ba8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf74a40bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b48171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c1b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70c8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70ca7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf725aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7255b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72565a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7256879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf748e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf748e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74d56a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf732285c) [/lib/libc.so.6] + 0x1785c
29: (0xf74d4fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
sclientd, ret : 0
04-23 15:58:26.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:26.791+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:26.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:26.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:26.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:26.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:26.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:26:957,75
04-23 15:58:26.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:26.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:26.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:26.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01610
04-23 15:58:27.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73363b0]
04-23 15:58:27.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:27.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:27.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:27.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:27.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:27.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:27.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:27.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:27.081+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:27.081+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:27.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:27.081+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:27.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:27.081+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:27.081+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:27.081+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:27.081+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:27.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:27.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:27.101+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:27.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:27.141+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:27.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:27.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:27.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:27.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:27.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73363b0
04-23 15:58:27.171+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:27:153,75
04-23 15:58:27.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:27.391+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:27:353,76
04-23 15:58:27.541+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:27.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:27:553,75
04-23 15:58:27.661+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:58:27.661+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:27.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:27.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:27.681+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20571
04-23 15:58:27.681+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:27.731+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20571
04-23 15:58:27.731+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20571) type(svcapp) bg(0)
04-23 15:58:27.741+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20571]
04-23 15:58:27.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20571)
04-23 15:58:27.741+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:27.741+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:27.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:27.751+0200 E/CAPI_APPFW_APPLICATION(20571): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:27.751+0200 E/CAPI_APPFW_APPLICATION(20571): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:27.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20571
04-23 15:58:27.761+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20571) was created
04-23 15:58:27.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:27.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:27.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20571
04-23 15:58:27.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:27.781+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:27.791+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:27:792,76
04-23 15:58:27.801+0200 W/LOCATION(20571): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:27.801+0200 E/LOCATION(20571): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:27.801+0200 E/PKGMGR_INFO(20571): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:27.801+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:27.841+0200 I/LOCATION(20571): location.c: location_new(269) > method: 0
04-23 15:58:27.841+0200 W/LOCATION(20571): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:27.841+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:27.861+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:27.861+0200 W/LOCATION(20571): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:27.861+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:27.871+0200 W/LOCATION(20571): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:27.871+0200 W/LOCATION(20571): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:27.871+0200 W/LOCATION(20571): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:27.871+0200 W/LOCATION(20571): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:27.901+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:27.901+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:27.901+0200 W/LOCATION(20571): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:27.911+0200 W/LOCATION(20571): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:27.911+0200 W/LOCATION(20571): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:27.911+0200 W/LOCATION(20571): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:27.911+0200 W/LOCATION(20571): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:27.931+0200 W/LOCATION(20571): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:27.931+0200 I/LOCATION(20571): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7455c18
04-23 15:58:27.931+0200 I/LOCATION(20571): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:27.931+0200 I/LOCATION(20571): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7455c18
04-23 15:58:27.931+0200 I/LOCATION(20571): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:27.941+0200 I/location(20571): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:27.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:27.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:27:953,76
04-23 15:58:27.981+0200 I/LOCATION(20571): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:28.021+0200 W/LOCATION(20571): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:28.031+0200 W/LOCATION(20571): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:28.031+0200 I/LOCATION(20571): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:28.111+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:28.111+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:28.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:28.111+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:28.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:28.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:28.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:28.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:28.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:28.111+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:28.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:28.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:28.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:28.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:28:155,76
04-23 15:58:28.191+0200 W/LOCATION(20571): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:28.191+0200 W/LOCATION(20571): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:28.271+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:28.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375518]
04-23 15:58:28.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:28.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:28.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:28.311+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:28.321+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:28.321+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:28.331+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.341+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.341+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:28.341+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:28.341+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:28.341+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:28.341+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:28.341+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:28.341+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:28.341+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:28.341+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:28.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:28.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:28.351+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5804010), time2(5799802)
04-23 15:58:28.351+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:28.351+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:28.351+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:28.351+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:28.351+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.361+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.361+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:28.361+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:28.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:28.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:28.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:28.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:28.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:28.411+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:28.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:28.431+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:28.431+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:28.431+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:28.441+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:28:352,76
04-23 15:58:28.461+0200 W/LOCATION(20571): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:28.461+0200 I/LOCATION(20571): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:28.461+0200 I/LOCATION(20571): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:28.461+0200 I/location(20571): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:28.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:28.561+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:28:562,76
04-23 15:58:28.611+0200 I/LOCATION(20571): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:28.671+0200 W/AUL     (20571): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:28.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:28.681+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20571
04-23 15:58:28.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:28.691+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:28.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:28.691+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.691+0200 I/utils   (19708): specific action
04-23 15:58:28.691+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.691+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.691+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:28.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:28.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:28.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:28.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:28.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:28.711+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.711+0200 I/utils   (19713): specific action
04-23 15:58:28.711+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.711+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.711+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.711+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:28.711+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:28.711+0200 I/recorder(19713): guardando datos en local
04-23 15:58:28.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:28.711+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:28.711+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:28.711+0200 W/AUL     (20571): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:28.711+0200 I/location(20571): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:28.711+0200 I/location(20571): stopping es.ugr.frailty.location service
04-23 15:58:28.711+0200 E/CAPI_APPFW_APP_CONTROL(20571): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:28.711+0200 E/location(20571): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:28.711+0200 I/CAPI_APPFW_APPLICATION(20571): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:28.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:28.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:28.741+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:28.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:28:754,76
04-23 15:58:28.801+0200 W/LOCATION(20571): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:28.801+0200 I/LOCATION(20571): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:28.801+0200 I/LOCATION(20571): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:28.871+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:28.871+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:28.871+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:28.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:28.951+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:28.951+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:28:955,76
04-23 15:58:28.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:29.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:29.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:29.021+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375518
04-23 15:58:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73b3ce0]
04-23 15:58:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:29.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:29.101+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.111+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:29.111+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:29.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:29.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:29.111+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:29.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.111+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:29.121+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:29.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.131+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:29.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.151+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:29.151+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:29:155,77
04-23 15:58:29.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.251+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:29.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:29.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:29.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73b3ce0
04-23 15:58:29.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf736ff78]
04-23 15:58:29.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:29.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:29.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:29.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:29.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.311+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:29.311+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:29.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:29.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:29.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:29.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:29.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:29.351+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:29.361+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:29:360,77
04-23 15:58:29.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:29.391+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:29.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:29.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:29.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:29.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:29.451+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf736ff78
04-23 15:58:29.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:29.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:29:557,77
04-23 15:58:29.651+0200 W/AUL     (20587): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:29.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:29.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:29.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20551
04-23 15:58:29.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:29.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20551
04-23 15:58:29.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20551)
04-23 15:58:29.741+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:29.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:29.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:29.741+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:29.751+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20588
04-23 15:58:29.751+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:29.781+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:29.781+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:29:786,77
04-23 15:58:29.801+0200 E/CAPI_APPFW_APPLICATION(20588): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:29.801+0200 E/CAPI_APPFW_APPLICATION(20588): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:29.801+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20588
04-23 15:58:29.801+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20588) type(svcapp) bg(0)
04-23 15:58:29.801+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20588) was created
04-23 15:58:29.801+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20588]
04-23 15:58:29.811+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20588)
04-23 15:58:29.811+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:29.811+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:29.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:29.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20588
04-23 15:58:29.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:29.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:29.841+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20588
04-23 15:58:29.841+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:29.881+0200 W/LOCATION(20588): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:29.881+0200 E/LOCATION(20588): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:29.881+0200 E/PKGMGR_INFO(20588): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:29.881+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.901+0200 I/LOCATION(20588): location.c: location_new(269) > method: 0
04-23 15:58:29.911+0200 W/LOCATION(20588): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.911+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.921+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:29.921+0200 W/LOCATION(20588): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:29.931+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:29.941+0200 W/LOCATION(20588): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:29.941+0200 W/LOCATION(20588): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:29.941+0200 W/LOCATION(20588): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:29.941+0200 W/LOCATION(20588): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:29.941+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:29.961+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:29:954,77
04-23 15:58:29.961+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:29.971+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:29.981+0200 W/LOCATION(20588): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:29.981+0200 W/LOCATION(20588): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:29.981+0200 W/LOCATION(20588): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:29.991+0200 W/LOCATION(20588): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:29.991+0200 W/LOCATION(20588): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:30.021+0200 W/LOCATION(20588): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:30.021+0200 I/LOCATION(20588): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7523c18
04-23 15:58:30.021+0200 I/LOCATION(20588): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:30.021+0200 I/LOCATION(20588): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7523c18
04-23 15:58:30.021+0200 I/LOCATION(20588): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:30.021+0200 I/location(20588): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:30.071+0200 I/LOCATION(20588): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:30.121+0200 W/LOCATION(20588): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:30.121+0200 W/LOCATION(20588): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:30.121+0200 I/LOCATION(20588): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:30.141+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:30.171+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:30:154,77
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:30.281+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:30.281+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:30.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:30.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:30.281+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:30.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:30.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:30.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:30.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:30.291+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:30.291+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:30.291+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:30.291+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:30.341+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:30.371+0200 W/LOCATION(20588): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:30.371+0200 W/LOCATION(20588): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:30.391+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:30:353,77
04-23 15:58:30.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:30.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:30.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:30.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:30.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:30.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:30.541+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5806206), time2(5799802)
04-23 15:58:30.541+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:30.541+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:30.541+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:30.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:30.551+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:30.551+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:30:555,77
04-23 15:58:30.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18d90]
04-23 15:58:30.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:30.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:30.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:30.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:30.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:30.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:30.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.591+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:30.591+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:30.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:30.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:30.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:30.601+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:30.601+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:30.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:30.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:30.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.611+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:30.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:30.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:30.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.681+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:30.681+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:30.681+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:30.681+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:30.711+0200 W/LOCATION(20588): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:30.711+0200 I/LOCATION(20588): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:30.711+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:30.711+0200 I/LOCATION(20588): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:30.711+0200 I/location(20588): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:30.751+0200 I/heartrate(20378): capturing data from es.ugr.frailty.heartrate
04-23 15:58:30.751+0200 I/heartrate(20378): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:58:30:756,77
04-23 15:58:30.821+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11204936c6f63152449190
