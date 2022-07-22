S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27207
Date: 2018-04-23 16:21:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74b252d, r5   = 0xf77a5f98
r6   = 0xffbcce60, r7   = 0xffbccd10
r8   = 0xf77a2c18, r9   = 0x00000000
r10  = 0xffbccdec, fp   = 0xffbcce60
ip   = 0x00000001, sp   = 0xffbcbb90
lr   = 0xf74b2539, pc   = 0xf751b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     20768 KB
Buffers:     63784 KB
Cached:     219144 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12036 KB
VmRSS:       12036 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27207 TID = 27207
27207 27210 

Maps Information
f437d000 f4b7c000 rw-p [stack:27210]
f4b83000 f4b85000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b8d000 f4b91000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b9a000 f4b9c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ba4000 f4ba7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bb6000 f4bbb000 r-xp /usr/lib/libsystem.so.0.0.0
f4bc6000 f4bc9000 r-xp /lib/libattr.so.1.1.0
f4bd1000 f4be1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4be9000 f4bf2000 r-xp /usr/lib/libedbus.so.1.7.99
f4bfa000 f4bfb000 r-xp /usr/lib/libresponse.so.0.2.96
f4c04000 f4c09000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64ab000 f65b1000 r-xp /usr/lib/libicuuc.so.57.1
f65c7000 f674f000 r-xp /usr/lib/libicui18n.so.57.1
f675f000 f676c000 r-xp /usr/lib/libail.so.0.1.0
f6775000 f677c000 r-xp /usr/lib/libminizip.so.1.0.0
f6785000 f692e000 r-xp /usr/lib/libcrypto.so.1.0.0
f694e000 f6995000 r-xp /usr/lib/libssl.so.1.0.0
f69a1000 f69a3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69ab000 f69b2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69bb000 f69c2000 r-xp /lib/libcrypt-2.13.so
f69f3000 f69f6000 r-xp /lib/libcap.so.2.21
f69fe000 f6a00000 r-xp /usr/lib/libiri.so
f6a08000 f6a51000 r-xp /usr/lib/libmdm.so.1.2.69
f6a59000 f6a5f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a67000 f6a8a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a94000 f6a96000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a9e000 f6abb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ac4000 f6ac8000 r-xp /usr/lib/libsmack.so.1.0.0
f6ad1000 f6aea000 r-xp /usr/lib/libnetwork.so.0.0.0
f6af3000 f6afb000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b03000 f6b09000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b12000 f6b14000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b1d000 f6b2d000 r-xp /lib/libresolv-2.13.so
f6b31000 f6b49000 r-xp /usr/lib/liblzma.so.5.0.3
f6b52000 f6b54000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b5c000 f6b76000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b7e000 f6bad000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bb6000 f6bc5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bcf000 f6bd9000 r-xp /usr/lib/libsensord-shared.so
f6be2000 f6cb5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cc0000 f6cd6000 r-xp /lib/libz.so.1.2.5
f6cde000 f6ce3000 r-xp /usr/lib/libffi.so.5.0.10
f6ceb000 f6cec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cf4000 f6d04000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d0c000 f6d25000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d2d000 f6d2f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d37000 f6dac000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6db6000 f6dbc000 r-xp /lib/librt-2.13.so
f6dc5000 f6de3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ded000 f6dee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6df6000 f6e19000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e21000 f6e26000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e2e000 f6e58000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e61000 f6e78000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e80000 f6ee9000 r-xp /lib/libm-2.13.so
f6ef2000 f6f86000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f99000 f6f9e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fa6000 f6fad000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fb5000 f6fdf000 r-xp /usr/lib/libsensor.so.1.9.6
f6fe8000 f70b4000 r-xp /usr/lib/libxml2.so.2.7.8
f70c1000 f70c3000 r-xp /usr/lib/libiniparser.so.0
f70cc000 f70d2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70db000 f71ab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ac000 f71e0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71e9000 f7225000 r-xp /usr/lib/libSLP-location.so.0.9.24
f722d000 f7230000 r-xp /usr/lib/libbundle.so.0.1.22
f7238000 f723e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7246000 f7287000 r-xp /usr/lib/libeina.so.1.7.99
f7290000 f72a7000 r-xp /usr/lib/libecore.so.1.7.99
f72be000 f72c7000 r-xp /usr/lib/libvconf.so.0.2.45
f72cf000 f72e3000 r-xp /lib/libpthread-2.13.so
f72ee000 f72fb000 r-xp /usr/lib/libaul.so.0.1.0
f7305000 f7307000 r-xp /lib/libdl-2.13.so
f7310000 f731b000 r-xp /lib/libunwind.so.8.0.1
f7348000 f7350000 r-xp /lib/libgcc_s-4.6.so.1
f7351000 f7475000 r-xp /lib/libc-2.13.so
f7483000 f7485000 r-xp /usr/lib/libdlog.so.0.0.0
f748d000 f7499000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74a2000 f74a7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74af000 f74be000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74c6000 f74ca000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74d3000 f74d6000 r-xp /usr/lib/libappcore-agent.so.1.1
f74de000 f74e0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74e8000 f74ec000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74f4000 f7511000 r-xp /lib/ld-2.13.so
f751a000 f751d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f751d000 f7521000 r-xp /usr/lib/libsys-assert.so
f7772000 f77d4000 rw-p [heap]
ffbae000 ffbcf000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27207)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf751b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74b2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71b93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71b7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71c3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71c9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71c9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71fe75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71f91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71b7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71c3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71c9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71c9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71fbe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71fc017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7203f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b9b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b8e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c61663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf710efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71107a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72a0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf729bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf729c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf729c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74d4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74d47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf751b6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf736885c) [/lib/libc.so.6] + 0x1785c
29: (0xf751afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
 16:20:02.631+0200 W/LOCATION(27140): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:20:02.631+0200 W/LOCATION(27140): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:02.631+0200 W/LOCATION(27140): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:02.631+0200 W/LOCATION(27140): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:02.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:02.631+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:20:02.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.681+0200 W/LOCATION(27140): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:20:02.681+0200 W/LOCATION(27140): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:20:02.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.691+0200 W/LOCATION(27140): module-internal.c: module_new(311) > module (wps) open success
04-23 16:20:02.691+0200 W/LOCATION(27140): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:20:02.691+0200 W/LOCATION(27140): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:20:02.691+0200 W/LOCATION(27140): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:20:02.691+0200 W/LOCATION(27140): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:20:02.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.711+0200 W/LOCATION(27140): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:20:02.711+0200 I/LOCATION(27140): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf743ac18
04-23 16:20:02.711+0200 I/LOCATION(27140): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:20:02.711+0200 I/LOCATION(27140): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf743ac18
04-23 16:20:02.711+0200 I/LOCATION(27140): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:20:02.711+0200 I/location(27140): es.ugr.frailty.location: creado servicio de localización
04-23 16:20:02.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:02.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:02.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:02.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73340a0
04-23 16:20:02.791+0200 I/LOCATION(27140): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:20:02.831+0200 W/LOCATION(27140): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:02.841+0200 W/LOCATION(27140): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:02.841+0200 I/LOCATION(27140): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:20:02.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7336420]
04-23 16:20:02.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:20:02.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:20:02.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:20:02.841+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:20:02.841+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:02.841+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:02.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:02.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:02.861+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:20:02.861+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:20:02.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:02.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:20:02.861+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:20:02.861+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:20:02.861+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:02.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:02.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:02.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:02.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:02.881+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:20:02.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:02.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:02.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:02.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:02.931+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7336420
04-23 16:20:02.961+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:20:02.961+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:20:02.961+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:20:02.961+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:02.961+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:20:02.961+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:20:02.961+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:20:02.961+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:20:02.961+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:20:02.961+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:20:02.961+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:20:02.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:20:03.011+0200 W/LOCATION(27140): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:20:03.011+0200 W/LOCATION(27140): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:20:03.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361ed8]
04-23 16:20:03.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:20:03.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:20:03.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:20:03.121+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:20:03.131+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:03.131+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:03.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.141+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:20:03.141+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:20:03.151+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:03.151+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:20:03.151+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:20:03.151+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:20:03.151+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:03.151+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:03.151+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:03.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.161+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:20:03.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:20:03.201+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(7098868), time2(7096309)
04-23 16:20:03.201+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:20:03.201+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:20:03.201+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:20:03.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:20:03.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.251+0200 W/LOCATION(27140): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:20:03.251+0200 I/LOCATION(27140): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:20:03.251+0200 I/LOCATION(27140): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:20:03.251+0200 I/location(27140): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:20:03.351+0200 I/LOCATION(27140): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:20:03.411+0200 E/location(27140): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:20:03.411+0200 W/AUL     (27140): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:20:03.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:20:03.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27140
04-23 16:20:03.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:20:03.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:20:03.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:20:03.421+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.431+0200 I/utils   (26979): specific action
04-23 16:20:03.431+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.431+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.431+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.431+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:20:03.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:20:03.431+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:20:03.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:20:03.441+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:20:03.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:20:03.441+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.441+0200 I/utils   (26984): specific action
04-23 16:20:03.441+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.441+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.441+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.441+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:20:03.441+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:20:03.441+0200 I/recorder(26984): guardando datos en local
04-23 16:20:03.441+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:20:03.441+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:20:03.441+0200 I/servicemanager(26979): requesting to save local data
04-23 16:20:03.441+0200 W/AUL     (27140): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:20:03.441+0200 I/location(27140): request sent to service es.ugr.frailty.servicemanager
04-23 16:20:03.441+0200 I/location(27140): stopping es.ugr.frailty.location service
04-23 16:20:03.441+0200 E/CAPI_APPFW_APP_CONTROL(27140): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:20:03.441+0200 E/location(27140): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:20:03.441+0200 I/CAPI_APPFW_APPLICATION(27140): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:20:03.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:20:03.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:20:03.501+0200 W/LOCATION(27140): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:20:03.501+0200 I/LOCATION(27140): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:20:03.501+0200 I/LOCATION(27140): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:20:03.571+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:20:03.571+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:20:03.571+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:20:03.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:20:03.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:03.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7361ed8
04-23 16:20:03.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e112d8]
04-23 16:20:03.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:20:03.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:20:03.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:20:03.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:20:03.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:03.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:03.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.821+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:20:03.821+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:20:03.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:03.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:20:03.821+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:20:03.821+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:20:03.821+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:03.821+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:03.831+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:03.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.841+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:03.841+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:20:03.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:03.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:03.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:03.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:03.941+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e112d8
04-23 16:20:04.011+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734c800]
04-23 16:20:04.011+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:20:04.011+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:20:04.011+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:20:04.011+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:20:04.021+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:04.021+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:04.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:04.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:04.071+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:20:04.071+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:20:04.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:20:04.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:20:04.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:20:04.071+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:20:04.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:20:04.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:20:04.071+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:20:04.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:04.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:20:04.091+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:20:04.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:04.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:20:04.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:20:04.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:20:04.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:20:04.151+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734c800
04-23 16:20:04.351+0200 W/AUL     (27163): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:20:04.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:20:04.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:20:04.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27057
04-23 16:20:04.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:20:04.351+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27057
04-23 16:20:04.351+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27057)
04-23 16:20:05.451+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:20:11.921+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 146 ms (from 7107436 to 7107582) (logOverhead=0,0,0,0,0,0,0), start: 16:20:11.781
04-23 16:20:11.921+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 146 ms (from 7107436 to 7107582) (logOverhead=0,0,0,0,0,0,0), start: 16:20:11.781
04-23 16:20:25.441+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 7120996 to 7121097) (logOverhead=0,0,0,0,0,0,0), start: 16:20:25.341
04-23 16:20:25.441+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 7120996 to 7121097) (logOverhead=0,0,0,0,0,0,0), start: 16:20:25.341
04-23 16:20:25.441+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:20:25.441+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:20:25.461+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 16:20:25.461+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 14 45 03 00 36 E0 01 09 0A 02 A5 68)
04-23 16:20:25.461+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:21:02.501+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 16:21:02.501+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:21:02.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:21:02.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:21:02.521+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 27207
04-23 16:21:02.531+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:21:02.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27207
04-23 16:21:02.571+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(27207) type(svcapp) bg(0)
04-23 16:21:02.581+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27207]
04-23 16:21:02.601+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27207)
04-23 16:21:02.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:21:02.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27207
04-23 16:21:02.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:21:02.631+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 16:21:02.631+0200 I/servicemanager(26979): App control destroyed.
04-23 16:21:02.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:21:02.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27207
04-23 16:21:02.651+0200 E/CAPI_APPFW_APPLICATION(27207): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:21:02.651+0200 E/CAPI_APPFW_APPLICATION(27207): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:21:02.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:21:02.661+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (27207) was created
04-23 16:21:02.681+0200 W/LOCATION(27207): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:21:02.681+0200 E/LOCATION(27207): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:21:02.681+0200 E/PKGMGR_INFO(27207): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:21:02.681+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:02.701+0200 I/LOCATION(27207): location.c: location_new(269) > method: 0
04-23 16:21:02.701+0200 W/LOCATION(27207): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:02.711+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:02.711+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:02.721+0200 W/LOCATION(27207): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:02.721+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:02.721+0200 W/LOCATION(27207): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:02.721+0200 W/LOCATION(27207): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:02.721+0200 W/LOCATION(27207): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:02.721+0200 W/LOCATION(27207): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:02.741+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:21:02.751+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:21:02.751+0200 W/LOCATION(27207): module-internal.c: module_new(311) > module (wps) open success
04-23 16:21:02.751+0200 W/LOCATION(27207): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:21:02.751+0200 W/LOCATION(27207): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:21:02.751+0200 W/LOCATION(27207): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:21:02.751+0200 W/LOCATION(27207): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:21:02.771+0200 W/LOCATION(27207): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:21:02.771+0200 I/LOCATION(27207): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77a2c18
04-23 16:21:02.771+0200 I/LOCATION(27207): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:21:02.771+0200 I/LOCATION(27207): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77a2c18
04-23 16:21:02.771+0200 I/LOCATION(27207): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:21:02.781+0200 I/location(27207): es.ugr.frailty.location: creado servicio de localización
04-23 16:21:02.821+0200 I/LOCATION(27207): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:21:02.851+0200 W/LOCATION(27207): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:02.851+0200 W/LOCATION(27207): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:02.851+0200 I/LOCATION(27207): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:21:02.911+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:21:02.911+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:21:02.911+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:02.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:02.921+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:21:02.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:21:02.921+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:21:02.921+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:21:02.921+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:21:02.931+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:21:02.931+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:21:02.931+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:21:02.931+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:21:02.931+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:21:02.941+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:21:02.951+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:21:02.951+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:21:02.951+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:21:02.961+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:21:02.961+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:21:02.961+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:21:02.961+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 16:21:02.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:21:02.971+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:21:02.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:21:02.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:21:02.991+0200 W/LOCATION(27207): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:21:02.991+0200 W/LOCATION(27207): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:21:03.061+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:03.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73344f0]
04-23 16:21:03.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:21:03.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:21:03.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:21:03.101+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:21:03.111+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:03.111+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:03.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:03.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:03.131+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:21:03.131+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:21:03.131+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:21:03.131+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:21:03.131+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:21:03.131+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:21:03.131+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:21:03.131+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:21:03.131+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:21:03.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:03.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:21:03.141+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:21:03.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:03.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:03.211+0200 W/LOCATION(27207): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:21:03.211+0200 I/LOCATION(27207): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:21:03.211+0200 I/LOCATION(27207): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:21:03.211+0200 I/location(27207): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:21:03.271+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 7158629 to 7158930) (logOverhead=0,0,0,0,0,0,0), start: 16:21:02.974
04-23 16:21:03.271+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 306 ms (from 7158627 to 7158933) (logOverhead=0,0,0,0,0,0,0), start: 16:21:02.972
04-23 16:21:03.271+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 306 ms (from 7158627 to 7158933) (logOverhead=0,0,0,0,0,0,0), start: 16:21:02.972
04-23 16:21:03.301+0200 I/LOCATION(27207): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:21:03.371+0200 E/location(27207): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:21:03.371+0200 W/AUL     (27207): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:21:03.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:21:03.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27207
04-23 16:21:03.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:21:03.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.391+0200 I/utils   (26979): specific action
04-23 16:21:03.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.391+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.391+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:21:03.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:21:03.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:21:03.391+0200 W/AUL     (27207): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:21:03.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:21:03.391+0200 I/location(27207): request sent to service es.ugr.frailty.servicemanager
04-23 16:21:03.391+0200 W/CAPI_APPFW_APP_CONTROL(27207): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:21:03.391+0200 I/utils   (27207): specific action
04-23 16:21:03.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:21:03.401+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.401+0200 I/utils   (26984): specific action
04-23 16:21:03.401+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.411+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.411+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.411+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:21:03.411+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:21:03.411+0200 I/recorder(26984): guardando datos en local
04-23 16:21:03.411+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:21:03.411+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:21:03.411+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:21:03.411+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:21:03.411+0200 I/servicemanager(26979): requesting to save local data
04-23 16:21:03.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:21:03.551+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(7159217), time2(7096309)
04-23 16:21:03.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:21:03.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:21:03.551+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:21:03.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:21:04.091+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 140 ms (from 7159610 to 7159750) (logOverhead=0,0,0,0,0,0,0), start: 16:21:03.955
04-23 16:21:04.091+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 140 ms (from 7159610 to 7159750) (logOverhead=0,0,0,0,0,0,0), start: 16:21:03.955
04-23 16:21:04.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:21:04.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:04.141+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:21:04.231+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:21:04.971+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:21:04.971+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:04.971+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:21:05.071+0200 W/LOCATION(27207): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 16:21:05.321+0200 W/AUL     (27218): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:21:05.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:21:05.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:21:05.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27120
04-23 16:21:05.321+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:21:05.321+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:21:05.321+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:21:05.321+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:21:05.321+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:21:05.331+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27120
04-23 16:21:05.331+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27120)
04-23 16:21:05.341+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:21:05.421+0200 W/CRASH_MANAGER(27220): worker.c: worker_job(1205) > 11272076c6f63152449326
