S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 9084
Date: 2018-04-23 20:29:36+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf751852d, r5   = 0xf7a2af98
r6   = 0xffacbed0, r7   = 0xffacbd80
r8   = 0xf7a27c18, r9   = 0x00000000
r10  = 0xffacbe5c, fp   = 0xffacbed0
ip   = 0x00000001, sp   = 0xffacbd58
lr   = 0xf7518539, pc   = 0xf7581228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    142528 KB
Buffers:     34176 KB
Cached:     152792 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11908 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 9084 TID = 9084
9084 9087 

Maps Information
f43e3000 f4be2000 rw-p [stack:9087]
f4be9000 f4beb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bf3000 f4bf7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c00000 f4c02000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c0a000 f4c0d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c1c000 f4c21000 r-xp /usr/lib/libsystem.so.0.0.0
f4c2c000 f4c2f000 r-xp /lib/libattr.so.1.1.0
f4c37000 f4c47000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c4f000 f4c58000 r-xp /usr/lib/libedbus.so.1.7.99
f4c60000 f4c61000 r-xp /usr/lib/libresponse.so.0.2.96
f4c6a000 f4c6f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6511000 f6617000 r-xp /usr/lib/libicuuc.so.57.1
f662d000 f67b5000 r-xp /usr/lib/libicui18n.so.57.1
f67c5000 f67d2000 r-xp /usr/lib/libail.so.0.1.0
f67db000 f67e2000 r-xp /usr/lib/libminizip.so.1.0.0
f67eb000 f6994000 r-xp /usr/lib/libcrypto.so.1.0.0
f69b4000 f69fb000 r-xp /usr/lib/libssl.so.1.0.0
f6a07000 f6a09000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a11000 f6a18000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a21000 f6a28000 r-xp /lib/libcrypt-2.13.so
f6a59000 f6a5c000 r-xp /lib/libcap.so.2.21
f6a64000 f6a66000 r-xp /usr/lib/libiri.so
f6a6e000 f6ab7000 r-xp /usr/lib/libmdm.so.1.2.69
f6abf000 f6ac5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6acd000 f6af0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6afa000 f6afc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b04000 f6b21000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b2a000 f6b2e000 r-xp /usr/lib/libsmack.so.1.0.0
f6b37000 f6b50000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b59000 f6b61000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b69000 f6b6f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b78000 f6b7a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b83000 f6b93000 r-xp /lib/libresolv-2.13.so
f6b97000 f6baf000 r-xp /usr/lib/liblzma.so.5.0.3
f6bb8000 f6bba000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bc2000 f6bdc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6be4000 f6c13000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c1c000 f6c2b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c35000 f6c3f000 r-xp /usr/lib/libsensord-shared.so
f6c48000 f6d1b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d26000 f6d3c000 r-xp /lib/libz.so.1.2.5
f6d44000 f6d49000 r-xp /usr/lib/libffi.so.5.0.10
f6d51000 f6d52000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d5a000 f6d6a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d72000 f6d8b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d93000 f6d95000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d9d000 f6e12000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e1c000 f6e22000 r-xp /lib/librt-2.13.so
f6e2b000 f6e49000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e53000 f6e54000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e5c000 f6e7f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e87000 f6e8c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e94000 f6ebe000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ec7000 f6ede000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ee6000 f6f4f000 r-xp /lib/libm-2.13.so
f6f58000 f6fec000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fff000 f7004000 r-xp /usr/lib/libctx-client.so.0.8.3
f700c000 f7013000 r-xp /usr/lib/libctx-shared.so.0.8.3
f701b000 f7045000 r-xp /usr/lib/libsensor.so.1.9.6
f704e000 f711a000 r-xp /usr/lib/libxml2.so.2.7.8
f7127000 f7129000 r-xp /usr/lib/libiniparser.so.0
f7132000 f7138000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7141000 f7211000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7212000 f7246000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f724f000 f728b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7293000 f7296000 r-xp /usr/lib/libbundle.so.0.1.22
f729e000 f72a4000 r-xp /usr/lib/libappsvc.so.0.1.0
f72ac000 f72ed000 r-xp /usr/lib/libeina.so.1.7.99
f72f6000 f730d000 r-xp /usr/lib/libecore.so.1.7.99
f7324000 f732d000 r-xp /usr/lib/libvconf.so.0.2.45
f7335000 f7349000 r-xp /lib/libpthread-2.13.so
f7354000 f7361000 r-xp /usr/lib/libaul.so.0.1.0
f736b000 f736d000 r-xp /lib/libdl-2.13.so
f7376000 f7381000 r-xp /lib/libunwind.so.8.0.1
f73ae000 f73b6000 r-xp /lib/libgcc_s-4.6.so.1
f73b7000 f74db000 r-xp /lib/libc-2.13.so
f74e9000 f74eb000 r-xp /usr/lib/libdlog.so.0.0.0
f74f3000 f74ff000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7508000 f750d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7515000 f7524000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f752c000 f7530000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7539000 f753c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7544000 f7546000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f754e000 f7552000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f755a000 f7577000 r-xp /lib/ld-2.13.so
f7580000 f7583000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7583000 f7587000 r-xp /usr/lib/libsys-assert.so
f79f7000 f7a85000 rw-p [heap]
ffaad000 fface000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9084)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7581228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7518539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf721f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf721dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7229e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf722fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf722fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf726475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf725f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf721dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7229e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf722fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf722fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7261e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7262017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7269f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c011fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bf4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cc7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7174fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71767a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7306ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7301b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73025a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7302879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf753a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf753a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75814f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf73ce85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7580f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
roduct.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:29:25.269+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:29:25.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:25.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:25:300,0.029543,9.770555,0.840090
04-23 20:29:25.409+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:29:25.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:29:25.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:25.459+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf400a218
04-23 20:29:25.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:25.549+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4032c10]
04-23 20:29:25.549+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:25.549+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:25.549+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:25.549+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:25.549+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:25.549+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:25.559+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.569+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.569+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:25.569+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:25.569+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:25.569+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:25.569+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:25.569+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:25.569+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:25.569+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:25.569+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:25.579+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.589+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.589+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:25.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.629+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:25:510,0.027115,9.769836,0.848492
04-23 20:29:25.629+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.639+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:29:25.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:29:25.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:25.709+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4032c10
04-23 20:29:25.739+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4003b30]
04-23 20:29:25.739+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:25.739+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:25.739+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:25.739+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:25.749+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:25.749+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:25.749+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.759+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.759+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:25.759+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:25.759+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:25.759+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:25.769+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:25.769+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:25.769+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:25.769+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:25.769+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:25.769+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.789+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:25.799+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:25.799+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.839+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:25.839+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:29:25.839+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:29:25.849+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:29:25.849+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_destroy(471) > Destroy handle: 0xf4003b30
04-23 20:29:25.879+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:25.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:25:896,0.020780,9.768369,0.865410
04-23 20:29:25.909+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:25.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:25:923,0.016438,9.766526,0.886050
04-23 20:29:26.059+0200 W/AUL     ( 9047): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:29:26.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:29:26.069+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:29:26.069+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 9013
04-23 20:29:26.069+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:29:26.069+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 9013
04-23 20:29:26.069+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(9013)
04-23 20:29:26.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:26.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:26:100,0.023140,9.769537,0.852057
04-23 20:29:26.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:26.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:26:300,0.022118,9.768866,0.859745
04-23 20:29:26.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:26.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:26:500,0.027003,9.769462,0.852804
04-23 20:29:26.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:26.749+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:26:700,0.026295,9.771804,0.825557
04-23 20:29:26.899+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:26.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:26:903,0.024983,9.771688,0.826974
04-23 20:29:27.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:27.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:27:100,0.019280,9.769443,0.853230
04-23 20:29:27.119+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:29:27.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:27.289+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:27:299,0.014922,9.773090,0.810474
04-23 20:29:27.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:27.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:27:500,0.010977,9.778031,0.748573
04-23 20:29:27.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:27.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:27:700,0.021373,9.780884,0.710103
04-23 20:29:27.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:27.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:27:901,0.039444,9.779081,0.733756
04-23 20:29:28.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:28.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:28:102,0.037769,9.776209,0.771165
04-23 20:29:28.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:28.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:28:301,0.044546,9.775640,0.777990
04-23 20:29:28.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:28.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:28:501,0.048293,9.774302,0.794405
04-23 20:29:28.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:28.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:28:701,0.040419,9.773315,0.806881
04-23 20:29:28.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:28.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:28:901,0.042353,9.774025,0.798144
04-23 20:29:29.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:29.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:29:102,0.036358,9.773299,0.807275
04-23 20:29:29.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:29.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:29:302,0.037974,9.773234,0.807981
04-23 20:29:29.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:29.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:29:501,0.033495,9.772948,0.811634
04-23 20:29:29.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:29.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:29:701,0.032116,9.772222,0.820391
04-23 20:29:29.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:29.909+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:29:901,0.023998,9.770854,0.836793
04-23 20:29:30.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:30.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:30:100,0.018833,9.774368,0.794826
04-23 20:29:30.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:30.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:30:300,0.022314,9.772813,0.813640
04-23 20:29:30.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:30.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:30:501,0.011278,9.775268,0.783832
04-23 20:29:30.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:30.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:30:701,0.024498,9.774879,0.788379
04-23 20:29:30.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:30.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:30:902,0.025292,9.774158,0.797243
04-23 20:29:31.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:31.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:31:101,0.036953,9.774666,0.790522
04-23 20:29:31.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:31.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:31:301,0.035965,9.774181,0.796538
04-23 20:29:31.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:31.509+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:31:501,0.036139,9.774721,0.789880
04-23 20:29:31.699+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:31.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:31:703,0.028363,9.772966,0.811603
04-23 20:29:31.899+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:31.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:31:903,0.035182,9.774848,0.788347
04-23 20:29:32.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:32.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:32:100,0.037318,9.773143,0.809118
04-23 20:29:32.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:32.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:32:301,0.029934,9.771651,0.827239
04-23 20:29:32.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:32.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:32:501,0.028938,9.772225,0.820457
04-23 20:29:32.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:32.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:32:701,0.025912,9.771165,0.833094
04-23 20:29:32.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:32.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:32:901,0.001881,9.791963,0.536509
04-23 20:29:33.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:33.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:33:100,-0.012155,9.665671,1.656813
04-23 20:29:33.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:33.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:33:301,-0.003480,9.803732,0.239174
04-23 20:29:33.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:33.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:33:501,0.004868,9.794106,0.495815
04-23 20:29:33.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:33.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:33:700,0.028213,9.781670,0.698953
04-23 20:29:33.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:33.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:33:900,0.035885,9.778924,0.736037
04-23 20:29:33.929+0200 I/servicemanager( 8242): es.ugr.frailty.location alive timeout
04-23 20:29:33.929+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:29:33.929+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:33.929+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:33.939+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:29:33.939+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 9084
04-23 20:29:33.989+0200 E/CAPI_APPFW_APPLICATION( 9084): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:33.989+0200 E/CAPI_APPFW_APPLICATION( 9084): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:29:33.989+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 9084
04-23 20:29:33.989+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(9084) type(svcapp) bg(0)
04-23 20:29:33.989+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9084)
04-23 20:29:33.989+0200 I/servicemanager( 8242): es.ugr.frailty.location launch request sent!
04-23 20:29:33.989+0200 I/servicemanager( 8242): App control destroyed.
04-23 20:29:33.999+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (9084) was created
04-23 20:29:33.999+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [9084]
04-23 20:29:34.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:34.019+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9084
04-23 20:29:34.019+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:29:34.029+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 9084
04-23 20:29:34.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:34.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:29:34.049+0200 W/LOCATION( 9084): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:29:34.049+0200 E/LOCATION( 9084): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:29:34.049+0200 E/PKGMGR_INFO( 9084): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:29:34.059+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:34.079+0200 I/LOCATION( 9084): location.c: location_new(269) > method: 0
04-23 20:29:34.079+0200 W/LOCATION( 9084): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:34.079+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:34.089+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:34.089+0200 W/LOCATION( 9084): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:34.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:34.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:34:101,0.034017,9.776263,0.770650
04-23 20:29:34.099+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:34.099+0200 W/LOCATION( 9084): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:34.099+0200 W/LOCATION( 9084): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:34.099+0200 W/LOCATION( 9084): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:34.099+0200 W/LOCATION( 9084): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:34.119+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:34.129+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:29:34.129+0200 W/LOCATION( 9084): module-internal.c: module_new(311) > module (wps) open success
04-23 20:29:34.129+0200 W/LOCATION( 9084): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:29:34.129+0200 W/LOCATION( 9084): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:29:34.139+0200 W/LOCATION( 9084): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:34.139+0200 W/LOCATION( 9084): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:34.149+0200 W/LOCATION( 9084): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:29:34.149+0200 I/LOCATION( 9084): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a27c18
04-23 20:29:34.149+0200 I/LOCATION( 9084): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:29:34.149+0200 I/LOCATION( 9084): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a27c18
04-23 20:29:34.149+0200 I/LOCATION( 9084): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:29:34.159+0200 I/location( 9084): es.ugr.frailty.location: creado servicio de localización
04-23 20:29:34.199+0200 I/LOCATION( 9084): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:29:34.239+0200 W/LOCATION( 9084): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:34.239+0200 W/LOCATION( 9084): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:34.239+0200 I/LOCATION( 9084): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:34.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:34.299+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:34:301,0.041705,9.773619,0.803137
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:29:34.339+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:29:34.339+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:34.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:29:34.339+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:29:34.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:29:34.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:29:34.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:29:34.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:29:34.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:29:34.339+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:29:34.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:29:34.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:29:34.389+0200 W/LOCATION( 9084): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:29:34.389+0200 W/LOCATION( 9084): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:29:34.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:34.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:34.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:34:505,0.038691,9.771936,0.823500
04-23 20:29:34.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_create(453) > New handle created[0xf4029c40]
04-23 20:29:34.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:29:34.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:29:34.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:29:34.509+0200 I/CAPI_NETWORK_CONNECTION( 8322): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:29:34.519+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:34.519+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:34.529+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:34.539+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:34.539+0200 E/LOCATION( 8322): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:29:34.539+0200 I/LOCATION( 8322): location.c: location_new(269) > method: 1
04-23 20:29:34.539+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:29:34.539+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (gps) open success
04-23 20:29:34.539+0200 W/LOCATION( 8322): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:29:34.539+0200 W/LOCATION( 8322): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:29:34.539+0200 W/LOCATION( 8322): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:29:34.539+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:29:34.539+0200 W/LOCATION( 8322): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:29:34.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:34.549+0200 I/AUL     ( 8322): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:29:34.549+0200 E/LOCATION( 8322): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:29:34.559+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:34.569+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:29:34.569+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(2249835), time2(2236635)
04-23 20:29:34.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:29:34.569+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:29:34.569+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:29:34.569+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:29:34.599+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:29:34.629+0200 W/LOCATION( 9084): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:29:34.629+0200 I/LOCATION( 9084): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:34.629+0200 I/LOCATION( 9084): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:29:34.629+0200 I/location( 9084): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:29:34.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:34.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:34:701,0.038514,9.769541,0.851456
04-23 20:29:34.719+0200 I/LOCATION( 9084): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:29:34.769+0200 E/location( 9084): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:29:34.769+0200 W/AUL     ( 9084): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:29:34.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:34.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 9084
04-23 20:29:34.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8242
04-23 20:29:34.779+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:34.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8242), cmd(0)
04-23 20:29:34.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.779+0200 I/utils   ( 8242): specific action
04-23 20:29:34.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.779+0200 W/CAPI_APPFW_APP_CONTROL( 8242): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.779+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:29:34.779+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:29:34.779+0200 W/AUL     ( 9084): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8242)
04-23 20:29:34.779+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 8242
04-23 20:29:34.789+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8247
04-23 20:29:34.789+0200 W/AUL     ( 8242): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8247)
04-23 20:29:34.799+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 I/utils   ( 8247): specific action
04-23 20:29:34.799+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8247), cmd(0)
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 8247): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 I/recorder( 8247): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:29:34.799+0200 I/recorder( 8247): guardando datos en local
04-23 20:29:34.799+0200 I/servicemanager( 8242): request sent to service es.ugr.frailty.recorder
04-23 20:29:34.799+0200 I/servicemanager( 8242): requesting to save local data
04-23 20:29:34.799+0200 I/location( 9084): request sent to service es.ugr.frailty.servicemanager
04-23 20:29:34.799+0200 W/CAPI_APPFW_APP_CONTROL( 9084): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:29:34.799+0200 I/utils   ( 9084): specific action
04-23 20:29:34.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:34.899+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:34:900,0.034111,9.767791,0.871484
04-23 20:29:35.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:100,0.032984,9.765686,0.894807
04-23 20:29:35.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:35.299+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:35.299+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:35.299+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:308,0.041258,9.764676,0.905413
04-23 20:29:35.319+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:323,0.043153,9.765762,0.893536
04-23 20:29:35.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.339+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:340,0.043448,9.766078,0.890067
04-23 20:29:35.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.359+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:362,0.042719,9.765891,0.892151
04-23 20:29:35.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.379+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:380,0.042566,9.766090,0.889974
04-23 20:29:35.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.399+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:400,0.042688,9.766254,0.888166
04-23 20:29:35.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.419+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:421,0.042651,9.766109,0.889760
04-23 20:29:35.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:500,0.042532,9.765989,0.891086
04-23 20:29:35.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:505,0.043110,9.766146,0.889342
04-23 20:29:35.499+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.499+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:509,0.042933,9.766200,0.888752
04-23 20:29:35.509+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:521,0.043040,9.766236,0.888344
04-23 20:29:35.519+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.519+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:528,0.042762,9.766312,0.887530
04-23 20:29:35.529+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.539+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:541,0.044117,9.766546,0.884878
04-23 20:29:35.569+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.569+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:573,0.046237,9.767240,0.877084
04-23 20:29:35.599+0200 E/CAPI_TELEPHONY( 8322): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:29:35.599+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.599+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:608,0.044539,9.767091,0.878829
04-23 20:29:35.599+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.609+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:612,0.043805,9.766685,0.883357
04-23 20:29:35.609+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.619+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:620,0.043186,9.766433,0.886176
04-23 20:29:35.629+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.639+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:640,0.044695,9.766621,0.884025
04-23 20:29:35.649+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.659+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:662,0.044754,9.766460,0.885798
04-23 20:29:35.669+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.679+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:680,0.045556,9.767096,0.878720
04-23 20:29:35.689+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.699+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:700,0.046469,9.767456,0.874654
04-23 20:29:35.709+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.719+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:720,0.047329,9.767693,0.871968
04-23 20:29:35.729+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.739+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:740,0.047600,9.767916,0.869446
04-23 20:29:35.749+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.759+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:761,0.047705,9.767907,0.869538
04-23 20:29:35.769+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.779+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:780,0.047209,9.767946,0.869123
04-23 20:29:35.789+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.799+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:800,0.047317,9.768366,0.864393
04-23 20:29:35.809+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.819+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:820,0.048849,9.768887,0.858397
04-23 20:29:35.829+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.839+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:841,0.049697,9.768779,0.859577
04-23 20:29:35.849+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.889+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:867,0.049586,9.768666,0.860864
04-23 20:29:35.889+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:893,0.047874,9.768405,0.863914
04-23 20:29:35.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.919+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:928,0.047933,9.768618,0.861505
04-23 20:29:35.919+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.929+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:931,0.047191,9.768797,0.859514
04-23 20:29:35.929+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.939+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:940,0.047333,9.768671,0.860933
04-23 20:29:35.949+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.959+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:962,0.045373,9.767857,0.870227
04-23 20:29:35.969+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.979+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:35:980,0.045478,9.768029,0.868281
04-23 20:29:35.989+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:35.999+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:0,0.046595,9.767987,0.868695
04-23 20:29:36.009+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.019+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:21,0.045611,9.767836,0.870456
04-23 20:29:36.029+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.039+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:40,0.044564,9.767621,0.872914
04-23 20:29:36.049+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.059+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:61,0.045695,9.768027,0.868294
04-23 20:29:36.069+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.079+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:80,0.043930,9.767744,0.871573
04-23 20:29:36.089+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.099+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:100,0.044235,9.767894,0.869876
04-23 20:29:36.109+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.119+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:120,0.045978,9.768050,0.868028
04-23 20:29:36.129+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.139+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:141,0.044920,9.767692,0.872107
04-23 20:29:36.149+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.159+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:161,0.042835,9.767321,0.876359
04-23 20:29:36.169+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.179+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:180,0.043631,9.767323,0.876296
04-23 20:29:36.189+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.199+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:201,0.045054,9.767801,0.870863
04-23 20:29:36.219+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.229+0200 W/LOCATION( 9084): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:29:36.249+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:228,0.045188,9.768032,0.868274
04-23 20:29:36.249+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.259+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:258,0.043813,9.767720,0.871843
04-23 20:29:36.259+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.269+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:270,0.044189,9.768104,0.867520
04-23 20:29:36.289+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:29:36.289+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:29:36.289+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:29:36.289+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.309+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:302,0.044681,9.768087,0.867674
04-23 20:29:36.309+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.319+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:321,0.045439,9.768062,0.867925
04-23 20:29:36.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.329+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:334,0.043950,9.767562,0.873601
04-23 20:29:36.329+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.339+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:348,0.043114,9.767177,0.877948
04-23 20:29:36.349+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.359+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:361,0.043104,9.767214,0.877531
04-23 20:29:36.369+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.379+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:380,0.042783,9.767038,0.879495
04-23 20:29:36.389+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.399+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:400,0.042097,9.766835,0.881781
04-23 20:29:36.409+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.419+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:421,0.043384,9.767158,0.878142
04-23 20:29:36.429+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.439+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:440,0.043474,9.767099,0.878781
04-23 20:29:36.449+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.459+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:461,0.042725,9.767020,0.879706
04-23 20:29:36.469+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.479+0200 I/gravity ( 8932): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:29:36:480,0.042613,9.767072,0.879131
04-23 20:29:36.489+0200 I/gravity ( 8932): capturing data from es.ugr.frailty.gravity
04-23 20:29:36.529+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11090846c6f63152450817
