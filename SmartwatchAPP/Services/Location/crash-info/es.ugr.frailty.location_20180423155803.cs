S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20196
Date: 2018-04-23 15:58:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf727c52d, r5   = 0xf7ae3958
r6   = 0xffa4a738, r7   = 0xffa4a5e8
r8   = 0xf7af6c18, r9   = 0x00000000
r10  = 0xffa4a6c4, fp   = 0xffa4a738
ip   = 0x00000001, sp   = 0xffa49468
lr   = 0xf727c539, pc   = 0xf72e52b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9612 KB
Buffers:     58184 KB
Cached:     234928 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11868 KB
VmRSS:       11868 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20196 TID = 20196
20196 20199 

Maps Information
f4147000 f4946000 rw-p [stack:20199]
f494d000 f494f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4957000 f495b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4964000 f4966000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f496e000 f4971000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4980000 f4985000 r-xp /usr/lib/libsystem.so.0.0.0
f4990000 f4993000 r-xp /lib/libattr.so.1.1.0
f499b000 f49ab000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49b3000 f49bc000 r-xp /usr/lib/libedbus.so.1.7.99
f49c4000 f49c5000 r-xp /usr/lib/libresponse.so.0.2.96
f49ce000 f49d3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6275000 f637b000 r-xp /usr/lib/libicuuc.so.57.1
f6391000 f6519000 r-xp /usr/lib/libicui18n.so.57.1
f6529000 f6536000 r-xp /usr/lib/libail.so.0.1.0
f653f000 f6546000 r-xp /usr/lib/libminizip.so.1.0.0
f654f000 f66f8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6718000 f675f000 r-xp /usr/lib/libssl.so.1.0.0
f676b000 f676d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6775000 f677c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6785000 f678c000 r-xp /lib/libcrypt-2.13.so
f67bd000 f67c0000 r-xp /lib/libcap.so.2.21
f67c8000 f67ca000 r-xp /usr/lib/libiri.so
f67d2000 f681b000 r-xp /usr/lib/libmdm.so.1.2.69
f6823000 f6829000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6831000 f6854000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f685e000 f6860000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6868000 f6885000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f688e000 f6892000 r-xp /usr/lib/libsmack.so.1.0.0
f689b000 f68b4000 r-xp /usr/lib/libnetwork.so.0.0.0
f68bd000 f68c5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68cd000 f68d3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68dc000 f68de000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68e7000 f68f7000 r-xp /lib/libresolv-2.13.so
f68fb000 f6913000 r-xp /usr/lib/liblzma.so.5.0.3
f691c000 f691e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6926000 f6940000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6948000 f6977000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6980000 f698f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6999000 f69a3000 r-xp /usr/lib/libsensord-shared.so
f69ac000 f6a7f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a8a000 f6aa0000 r-xp /lib/libz.so.1.2.5
f6aa8000 f6aad000 r-xp /usr/lib/libffi.so.5.0.10
f6ab5000 f6ab6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6abe000 f6ace000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ad6000 f6aef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6af7000 f6af9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b01000 f6b76000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b80000 f6b86000 r-xp /lib/librt-2.13.so
f6b8f000 f6bad000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bb7000 f6bb8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bc0000 f6be3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6beb000 f6bf0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bf8000 f6c22000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c2b000 f6c42000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c4a000 f6cb3000 r-xp /lib/libm-2.13.so
f6cbc000 f6d50000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d63000 f6d68000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d70000 f6d77000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d7f000 f6da9000 r-xp /usr/lib/libsensor.so.1.9.6
f6db2000 f6e7e000 r-xp /usr/lib/libxml2.so.2.7.8
f6e8b000 f6e8d000 r-xp /usr/lib/libiniparser.so.0
f6e96000 f6e9c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ea5000 f6f75000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f76000 f6faa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fb3000 f6fef000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ff7000 f6ffa000 r-xp /usr/lib/libbundle.so.0.1.22
f7002000 f7008000 r-xp /usr/lib/libappsvc.so.0.1.0
f7010000 f7051000 r-xp /usr/lib/libeina.so.1.7.99
f705a000 f7071000 r-xp /usr/lib/libecore.so.1.7.99
f7088000 f7091000 r-xp /usr/lib/libvconf.so.0.2.45
f7099000 f70ad000 r-xp /lib/libpthread-2.13.so
f70b8000 f70c5000 r-xp /usr/lib/libaul.so.0.1.0
f70cf000 f70d1000 r-xp /lib/libdl-2.13.so
f70da000 f70e5000 r-xp /lib/libunwind.so.8.0.1
f7112000 f711a000 r-xp /lib/libgcc_s-4.6.so.1
f711b000 f723f000 r-xp /lib/libc-2.13.so
f724d000 f724f000 r-xp /usr/lib/libdlog.so.0.0.0
f7257000 f7263000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f726c000 f7271000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7279000 f7288000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7290000 f7294000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f729d000 f72a0000 r-xp /usr/lib/libappcore-agent.so.1.1
f72a8000 f72aa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72b2000 f72b6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72be000 f72db000 r-xp /lib/ld-2.13.so
f72e4000 f72e7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72e7000 f72eb000 r-xp /usr/lib/libsys-assert.so
f7ac6000 f7b37000 rw-p [heap]
ffa2b000 ffa4c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20196)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf72e52b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf727c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f833f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fc875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fc31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fc5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fc6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fca8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72b40bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4958171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a2b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ed8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6eda7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf706aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7065b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70665a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7066879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf729e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf729e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72e56a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf713285c) [/lib/libc.so.6] + 0x1785c
29: (0xf72e4fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
odule-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:59.121+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:59.121+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:59.121+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:59.121+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:59.121+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:59.121+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:59.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.131+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:59.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:59.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:59.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:59.231+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:59.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:59.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:59.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e0fbd8
04-23 15:57:59.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e192f8]
04-23 15:57:59.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:59.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:59.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:59.281+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:59.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:59.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:59.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.311+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:59.311+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:59.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:59.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:59.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:59.311+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:59.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:59.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:59.311+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:59.321+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.331+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:59.331+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:59.331+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:59.381+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:59.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:59.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:59.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:59.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e192f8
04-23 15:57:59.961+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:57:59.961+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:59.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:59.961+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:59.971+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20184
04-23 15:57:59.971+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:00.021+0200 E/CAPI_APPFW_APPLICATION(20184): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:00.021+0200 E/CAPI_APPFW_APPLICATION(20184): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:00.051+0200 W/LOCATION(20184): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:00.051+0200 E/LOCATION(20184): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:00.051+0200 E/PKGMGR_INFO(20184): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:00.051+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:00.061+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20184
04-23 15:58:00.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20184) type(svcapp) bg(0)
04-23 15:58:00.061+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20184) was created
04-23 15:58:00.061+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20184]
04-23 15:58:00.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:00.081+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20184
04-23 15:58:00.081+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:00.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20184)
04-23 15:58:00.081+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:58:00.081+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:00.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:00.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20184
04-23 15:58:00.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:00.101+0200 I/LOCATION(20184): location.c: location_new(269) > method: 0
04-23 15:58:00.101+0200 W/LOCATION(20184): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:00.111+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:00.111+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:00.121+0200 W/LOCATION(20184): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:00.121+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:00.131+0200 W/LOCATION(20184): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:00.131+0200 W/LOCATION(20184): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:00.131+0200 W/LOCATION(20184): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:00.131+0200 W/LOCATION(20184): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:00.151+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:00.161+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:00.161+0200 W/LOCATION(20184): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:00.161+0200 W/LOCATION(20184): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:00.171+0200 W/LOCATION(20184): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:00.171+0200 W/LOCATION(20184): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:00.171+0200 W/LOCATION(20184): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:00.181+0200 W/LOCATION(20184): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:00.181+0200 I/LOCATION(20184): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7fa5c18
04-23 15:58:00.181+0200 I/LOCATION(20184): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:00.191+0200 I/LOCATION(20184): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7fa5c18
04-23 15:58:00.191+0200 I/LOCATION(20184): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:00.191+0200 I/location(20184): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:00.231+0200 I/LOCATION(20184): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:00.271+0200 W/LOCATION(20184): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:00.271+0200 W/LOCATION(20184): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:00.271+0200 I/LOCATION(20184): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:00.371+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:00.371+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:00.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:00.371+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:00.371+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:00.371+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:00.371+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:00.371+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:00.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:00.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:00.381+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:00.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:00.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:00.431+0200 W/LOCATION(20184): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:00.431+0200 W/LOCATION(20184): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:00.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:00.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375800]
04-23 15:58:00.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:00.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:00.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:00.541+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:00.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:00.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:00.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:00.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:00.571+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:00.571+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:00.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:00.571+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:00.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:00.571+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:00.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:00.571+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:00.571+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:00.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:00.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:00.581+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:00.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:00.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:00.621+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5776281), time2(5764427)
04-23 15:58:00.621+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:58:00.621+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:00.621+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:00.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:00.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:00.661+0200 W/LOCATION(20184): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:00.661+0200 I/LOCATION(20184): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:00.661+0200 I/LOCATION(20184): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:00.661+0200 I/location(20184): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:00.751+0200 I/LOCATION(20184): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:00.791+0200 W/AUL     (20184): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:00.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:00.801+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20184
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:00.811+0200 W/AUL     (20184): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:00.811+0200 I/location(20184): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:00.811+0200 I/location(20184): stopping es.ugr.frailty.location service
04-23 15:58:00.811+0200 E/CAPI_APPFW_APP_CONTROL(20184): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:00.811+0200 E/location(20184): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:00.811+0200 I/CAPI_APPFW_APPLICATION(20184): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:00.811+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:00.811+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.811+0200 I/utils   (19708): specific action
04-23 15:58:00.811+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.811+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.811+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.811+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:00.811+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:00.821+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:00.831+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.831+0200 I/utils   (19713): specific action
04-23 15:58:00.831+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:00.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:00.831+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.831+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.831+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.831+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:00.831+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:00.831+0200 I/recorder(19713): guardando datos en local
04-23 15:58:00.831+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:00.831+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:00.831+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:00.871+0200 W/LOCATION(20184): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:00.871+0200 I/LOCATION(20184): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:00.871+0200 I/LOCATION(20184): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:58:00.931+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:00.931+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:00.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:00.941+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:01.021+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:01.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:01.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:01.071+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375800
04-23 15:58:01.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e02300]
04-23 15:58:01.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:01.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:01.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:01.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:01.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:01.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:01.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.151+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:01.151+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:01.151+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:01.151+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:01.151+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:01.151+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:01.151+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:01.151+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:01.151+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:01.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.171+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:01.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:01.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:01.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:01.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e02300
04-23 15:58:01.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e189e8]
04-23 15:58:01.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:01.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:01.341+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:01.371+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:01.381+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:01.381+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:01.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.401+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:01.401+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:01.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:01.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:01.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:01.401+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:01.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:01.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:01.401+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:01.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:01.411+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:01.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:01.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:01.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:01.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:01.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e189e8
04-23 15:58:01.641+0200 W/AUL     (20193): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:01.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:01.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:01.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20184
04-23 15:58:01.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:01.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20184
04-23 15:58:01.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20184)
04-23 15:58:02.081+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:02.081+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:02.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:02.091+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:02.101+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:02.101+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20196
04-23 15:58:02.131+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20196
04-23 15:58:02.131+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20196) type(svcapp) bg(0)
04-23 15:58:02.141+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20196]
04-23 15:58:02.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:02.161+0200 E/CAPI_APPFW_APPLICATION(20196): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:02.161+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20196
04-23 15:58:02.161+0200 E/CAPI_APPFW_APPLICATION(20196): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:02.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:02.161+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20196) was created
04-23 15:58:02.191+0200 W/LOCATION(20196): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:02.191+0200 E/LOCATION(20196): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:02.191+0200 E/PKGMGR_INFO(20196): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:02.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:02.201+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:02.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20196
04-23 15:58:02.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:02.231+0200 I/LOCATION(20196): location.c: location_new(269) > method: 0
04-23 15:58:02.241+0200 W/LOCATION(20196): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:02.241+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:02.251+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:02.261+0200 W/LOCATION(20196): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:02.261+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:02.271+0200 W/LOCATION(20196): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:02.271+0200 W/LOCATION(20196): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:02.271+0200 W/LOCATION(20196): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:02.271+0200 W/LOCATION(20196): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:02.281+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20196)
04-23 15:58:02.281+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:02.281+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:02.301+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:02.301+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:02.301+0200 W/LOCATION(20196): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:02.341+0200 W/LOCATION(20196): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:02.361+0200 W/LOCATION(20196): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:02.361+0200 W/LOCATION(20196): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:02.361+0200 W/LOCATION(20196): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:02.391+0200 W/LOCATION(20196): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:02.391+0200 I/LOCATION(20196): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7af6c18
04-23 15:58:02.391+0200 I/LOCATION(20196): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:02.391+0200 I/LOCATION(20196): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7af6c18
04-23 15:58:02.391+0200 I/LOCATION(20196): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:02.391+0200 I/location(20196): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:02.441+0200 I/LOCATION(20196): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:02.471+0200 W/LOCATION(20196): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:02.471+0200 W/LOCATION(20196): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:02.471+0200 I/LOCATION(20196): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:02.541+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:02.541+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:02.541+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:02.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:02.541+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:02.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:02.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:02.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:02.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:02.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:02.551+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:02.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:02.551+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:02.621+0200 W/LOCATION(20196): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:02.621+0200 W/LOCATION(20196): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:02.711+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:02.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e00ca0]
04-23 15:58:02.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:02.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:02.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:02.751+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:02.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:02.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:02.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:02.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:02.781+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:02.781+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:02.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:02.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:02.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:02.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:02.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:02.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:02.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:02.791+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:02.791+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5778450), time2(5776282)
04-23 15:58:02.791+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:02.791+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:02.791+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:02.791+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:02.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:02.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:02.791+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:02.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:02.811+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:02.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:02.881+0200 W/LOCATION(20196): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:02.881+0200 I/LOCATION(20196): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:02.881+0200 I/LOCATION(20196): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:02.881+0200 I/location(20196): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:02.971+0200 I/LOCATION(20196): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:03.011+0200 W/AUL     (20196): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:03.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:03.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20196
04-23 15:58:03.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:03.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.031+0200 I/utils   (19708): specific action
04-23 15:58:03.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:03.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:03.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.031+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.031+0200 W/AUL     (20196): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:03.031+0200 I/location(20196): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:03.031+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:03.031+0200 W/CAPI_APPFW_APP_CONTROL(20196): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.031+0200 I/utils   (20196): specific action
04-23 15:58:03.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:03.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:03.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:03.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:03.041+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:03.041+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:03.051+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.051+0200 I/utils   (19713): specific action
04-23 15:58:03.051+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.051+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:03.051+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:03.051+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.051+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.051+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:03.051+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:03.051+0200 I/recorder(19713): guardando datos en local
04-23 15:58:03.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:03.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:03.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:03.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:03.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:03.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:03.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:03.431+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:03.431+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:03.431+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:03.471+0200 I/LOCATION(20196): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:03.591+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11201966c6f63152449188
