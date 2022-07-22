S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19982
Date: 2018-04-23 15:57:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75ca52d, r5   = 0xf7d3ff98
r6   = 0xff9f6c38, r7   = 0xff9f6ae8
r8   = 0xf7d3cc18, r9   = 0x00000000
r10  = 0xff9f6bc4, fp   = 0xff9f6c38
ip   = 0x00000001, sp   = 0xff9f5968
lr   = 0xf75ca539, pc   = 0xf76332b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12208 KB
Buffers:     57980 KB
Cached:     231840 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12108 KB
VmRSS:       12108 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19982 TID = 19982
19982 19985 

Maps Information
f4495000 f4c94000 rw-p [stack:19985]
f4c9b000 f4c9d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ca5000 f4ca9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cb2000 f4cb4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cbc000 f4cbf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cce000 f4cd3000 r-xp /usr/lib/libsystem.so.0.0.0
f4cde000 f4ce1000 r-xp /lib/libattr.so.1.1.0
f4ce9000 f4cf9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d01000 f4d0a000 r-xp /usr/lib/libedbus.so.1.7.99
f4d12000 f4d13000 r-xp /usr/lib/libresponse.so.0.2.96
f4d1c000 f4d21000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65c3000 f66c9000 r-xp /usr/lib/libicuuc.so.57.1
f66df000 f6867000 r-xp /usr/lib/libicui18n.so.57.1
f6877000 f6884000 r-xp /usr/lib/libail.so.0.1.0
f688d000 f6894000 r-xp /usr/lib/libminizip.so.1.0.0
f689d000 f6a46000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a66000 f6aad000 r-xp /usr/lib/libssl.so.1.0.0
f6ab9000 f6abb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ac3000 f6aca000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ad3000 f6ada000 r-xp /lib/libcrypt-2.13.so
f6b0b000 f6b0e000 r-xp /lib/libcap.so.2.21
f6b16000 f6b18000 r-xp /usr/lib/libiri.so
f6b20000 f6b69000 r-xp /usr/lib/libmdm.so.1.2.69
f6b71000 f6b77000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b7f000 f6ba2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bac000 f6bae000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bb6000 f6bd3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bdc000 f6be0000 r-xp /usr/lib/libsmack.so.1.0.0
f6be9000 f6c02000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c0b000 f6c13000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c1b000 f6c21000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c2a000 f6c2c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c35000 f6c45000 r-xp /lib/libresolv-2.13.so
f6c49000 f6c61000 r-xp /usr/lib/liblzma.so.5.0.3
f6c6a000 f6c6c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c74000 f6c8e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c96000 f6cc5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cce000 f6cdd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ce7000 f6cf1000 r-xp /usr/lib/libsensord-shared.so
f6cfa000 f6dcd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dd8000 f6dee000 r-xp /lib/libz.so.1.2.5
f6df6000 f6dfb000 r-xp /usr/lib/libffi.so.5.0.10
f6e03000 f6e04000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e0c000 f6e1c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e24000 f6e3d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e45000 f6e47000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e4f000 f6ec4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ece000 f6ed4000 r-xp /lib/librt-2.13.so
f6edd000 f6efb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f05000 f6f06000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f0e000 f6f31000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f39000 f6f3e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f46000 f6f70000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f79000 f6f90000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f98000 f7001000 r-xp /lib/libm-2.13.so
f700a000 f709e000 r-xp /usr/lib/libstdc++.so.6.0.16
f70b1000 f70b6000 r-xp /usr/lib/libctx-client.so.0.8.3
f70be000 f70c5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70cd000 f70f7000 r-xp /usr/lib/libsensor.so.1.9.6
f7100000 f71cc000 r-xp /usr/lib/libxml2.so.2.7.8
f71d9000 f71db000 r-xp /usr/lib/libiniparser.so.0
f71e4000 f71ea000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71f3000 f72c3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72c4000 f72f8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7301000 f733d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7345000 f7348000 r-xp /usr/lib/libbundle.so.0.1.22
f7350000 f7356000 r-xp /usr/lib/libappsvc.so.0.1.0
f735e000 f739f000 r-xp /usr/lib/libeina.so.1.7.99
f73a8000 f73bf000 r-xp /usr/lib/libecore.so.1.7.99
f73d6000 f73df000 r-xp /usr/lib/libvconf.so.0.2.45
f73e7000 f73fb000 r-xp /lib/libpthread-2.13.so
f7406000 f7413000 r-xp /usr/lib/libaul.so.0.1.0
f741d000 f741f000 r-xp /lib/libdl-2.13.so
f7428000 f7433000 r-xp /lib/libunwind.so.8.0.1
f7460000 f7468000 r-xp /lib/libgcc_s-4.6.so.1
f7469000 f758d000 r-xp /lib/libc-2.13.so
f759b000 f759d000 r-xp /usr/lib/libdlog.so.0.0.0
f75a5000 f75b1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75ba000 f75bf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75c7000 f75d6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75de000 f75e2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75eb000 f75ee000 r-xp /usr/lib/libappcore-agent.so.1.1
f75f6000 f75f8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7600000 f7604000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f760c000 f7629000 r-xp /lib/ld-2.13.so
f7632000 f7635000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7635000 f7639000 r-xp /usr/lib/libsys-assert.so
f7d0c000 f7d96000 rw-p [heap]
ff9d8000 ff9f9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19982)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf76332b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf75ca539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72d13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72cfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72dbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72e1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72e1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73111f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72cfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72dbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72e1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72e1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7313e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7314017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73188d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf76020bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4ca6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d79663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7226fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72287a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73b8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73b3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73b45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73b4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75ec183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75ec7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76336a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf748085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7632fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
: pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:39.231+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:39.251+0200 I/LOCATION(19956): location.c: location_new(269) > method: 0
04-23 15:57:39.251+0200 W/LOCATION(19956): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:39.251+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:39.261+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:39.261+0200 W/LOCATION(19956): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:39.271+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:39.271+0200 W/LOCATION(19956): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:39.271+0200 W/LOCATION(19956): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:39.271+0200 W/LOCATION(19956): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:39.271+0200 W/LOCATION(19956): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:39.291+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:39.291+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:39.301+0200 W/LOCATION(19956): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:39.301+0200 W/LOCATION(19956): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:39.301+0200 W/LOCATION(19956): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:39.301+0200 W/LOCATION(19956): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:39.301+0200 W/LOCATION(19956): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:39.331+0200 W/LOCATION(19956): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:39.331+0200 I/LOCATION(19956): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7c58c18
04-23 15:57:39.331+0200 I/LOCATION(19956): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:39.331+0200 I/LOCATION(19956): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7c58c18
04-23 15:57:39.331+0200 I/LOCATION(19956): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:39.331+0200 I/location(19956): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:39.391+0200 I/LOCATION(19956): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:39.401+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:39.401+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:39:410,94
04-23 15:57:39.441+0200 W/LOCATION(19956): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:39.441+0200 W/LOCATION(19956): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:39.441+0200 I/LOCATION(19956): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:39.511+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:39.511+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:39.511+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:39.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:39.511+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:39.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:39.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:39.511+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:39.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:39.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:39.521+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:39.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:39.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:39.561+0200 W/LOCATION(19956): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:39.561+0200 W/LOCATION(19956): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:39.621+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:39.621+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:39:625,94
04-23 15:57:39.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:39.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf736e550]
04-23 15:57:39.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:39.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:39.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:39.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:39.701+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:39.701+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:39.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:39.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:39.731+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:39.731+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:39.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:39.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:39.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:39.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:39.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:39.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:39.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:39.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:39.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:39.751+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:39.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:39.751+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5755415), time2(5753348)
04-23 15:57:39.751+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:39.751+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:39.751+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:39.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:39.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:39.801+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:39.801+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:39:806,94
04-23 15:57:39.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:39.841+0200 W/LOCATION(19956): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:39.841+0200 I/LOCATION(19956): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:39.841+0200 I/LOCATION(19956): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:39.841+0200 I/location(19956): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:39.921+0200 I/LOCATION(19956): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:39.971+0200 W/AUL     (19956): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:39.971+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:39.971+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19956
04-23 15:57:39.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:39.981+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:39.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:39.981+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:39.981+0200 I/utils   (19708): specific action
04-23 15:57:39.981+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:39.981+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:39.981+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:39.981+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:39.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:39.991+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:39.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:40.001+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:40.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:40:6,94
04-23 15:57:40.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:40.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:40.001+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:40.001+0200 I/utils   (19713): specific action
04-23 15:57:40.001+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:40.001+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:40.001+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:40.001+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:40.001+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:40.001+0200 I/recorder(19713): guardando datos en local
04-23 15:57:40.001+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:40.001+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:40.001+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:40.001+0200 W/AUL     (19956): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:40.001+0200 I/location(19956): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:40.001+0200 I/location(19956): stopping es.ugr.frailty.location service
04-23 15:57:40.001+0200 E/CAPI_APPFW_APP_CONTROL(19956): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:57:40.001+0200 E/location(19956): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:57:40.001+0200 I/CAPI_APPFW_APPLICATION(19956): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:57:40.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:57:40.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:57:40.051+0200 W/LOCATION(19956): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:40.051+0200 I/LOCATION(19956): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:40.051+0200 I/LOCATION(19956): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:57:40.121+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:57:40.121+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:57:40.121+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:40.121+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:57:40.201+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:40.201+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:40:207,94
04-23 15:57:40.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:40.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:40.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:40.261+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf736e550
04-23 15:57:40.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf734c6b0]
04-23 15:57:40.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:40.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:40.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:40.331+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:40.371+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:40.371+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:40.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.381+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:40.381+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:40.381+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:40.381+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:40.381+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:40.381+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:40.381+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:40.381+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:40.381+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:40.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.401+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:40.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.401+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:40.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.411+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:40:407,94
04-23 15:57:40.441+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:40.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:40.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:40.501+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf734c6b0
04-23 15:57:40.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2c000]
04-23 15:57:40.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:40.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:40.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:40.561+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:40.571+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:40.571+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:40.581+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.591+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:40.591+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:40.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:40.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:40.591+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:40.591+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:40.591+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:40.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:40.591+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:40.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.601+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:40.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:40:607,94
04-23 15:57:40.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:40.601+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:40.601+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.681+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:40.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:40.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:40.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:40.691+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2c000
04-23 15:57:40.801+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:40.801+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:40:807,94
04-23 15:57:40.861+0200 W/AUL     (19981): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:57:40.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:57:40.861+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:57:40.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19956
04-23 15:57:40.861+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:57:40.871+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19956
04-23 15:57:40.871+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19956)
04-23 15:57:41.001+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:41.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:41:7,95
04-23 15:57:41.191+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:57:41.191+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:41.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:41.191+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:41.211+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 19982
04-23 15:57:41.211+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:41.211+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:41.211+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:41:217,94
04-23 15:57:41.261+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19982
04-23 15:57:41.261+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(19982) type(svcapp) bg(0)
04-23 15:57:41.261+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19982)
04-23 15:57:41.261+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:57:41.261+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:41.261+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19982]
04-23 15:57:41.271+0200 E/CAPI_APPFW_APPLICATION(19982): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:41.271+0200 E/CAPI_APPFW_APPLICATION(19982): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:41.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:41.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19982
04-23 15:57:41.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:41.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (19982) was created
04-23 15:57:41.321+0200 W/LOCATION(19982): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:41.321+0200 E/LOCATION(19982): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:41.321+0200 E/PKGMGR_INFO(19982): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:41.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:41.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19982
04-23 15:57:41.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:41.341+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:41.361+0200 I/LOCATION(19982): location.c: location_new(269) > method: 0
04-23 15:57:41.361+0200 W/LOCATION(19982): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:41.371+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:41.371+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:41.381+0200 W/LOCATION(19982): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:41.381+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:41.391+0200 W/LOCATION(19982): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:41.391+0200 W/LOCATION(19982): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:41.391+0200 W/LOCATION(19982): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:41.391+0200 W/LOCATION(19982): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:41.401+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:41.401+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:41:408,95
04-23 15:57:41.411+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:41.421+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:41.421+0200 W/LOCATION(19982): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:41.421+0200 W/LOCATION(19982): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:41.421+0200 W/LOCATION(19982): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:41.431+0200 W/LOCATION(19982): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:41.431+0200 W/LOCATION(19982): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:41.441+0200 W/LOCATION(19982): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:41.441+0200 I/LOCATION(19982): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d3cc18
04-23 15:57:41.441+0200 I/LOCATION(19982): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:41.441+0200 I/LOCATION(19982): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d3cc18
04-23 15:57:41.441+0200 I/LOCATION(19982): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:41.451+0200 I/location(19982): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:41.501+0200 I/LOCATION(19982): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:41.541+0200 W/LOCATION(19982): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:41.541+0200 W/LOCATION(19982): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:41.541+0200 I/LOCATION(19982): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:41.601+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:41.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:41:608,95
04-23 15:57:41.611+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:41.611+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:41.611+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:41.611+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:41.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:41.611+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:41.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:41.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:41.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:41.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:41.621+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:41.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:41.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:41.661+0200 W/LOCATION(19982): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:41.661+0200 W/LOCATION(19982): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:41.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:41.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e095c8]
04-23 15:57:41.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:41.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:41.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:41.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:41.771+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:41.771+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:41.781+0200 I/servicemanager(19708): es.ugr.frailty.heartrate sleep timeout
04-23 15:57:41.781+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 15:57:41.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:41.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:41.781+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:41.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19742
04-23 15:57:41.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:41.791+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:41.791+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:41.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:41.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:41.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:41.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:41.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:41.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:41.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:41.791+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:41.791+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19742), cmd(0)
04-23 15:57:41.801+0200 I/heartrate(19742): stopping es.ugr.frailty.heartrate service
04-23 15:57:41.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:41.801+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19742)
04-23 15:57:41.801+0200 W/AUL     (19742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:41.801+0200 I/servicemanager(19708): es.ugr.frailty.heartrate stop request sent!
04-23 15:57:41.801+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:41.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:41.801+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19742
04-23 15:57:41.811+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:41.811+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.821+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:41.821+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:41.821+0200 I/utils   (19708): specific action
04-23 15:57:41.821+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.821+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.821+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:41.821+0200 W/AUL     (19742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:41.821+0200 I/heartrate(19742): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:41.821+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:41.821+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:41.821+0200 I/CAPI_APPFW_APPLICATION(19742): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:57:41.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:41.821+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:41.831+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:41.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:57:41.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:57:41.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:41.841+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.841+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:41.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:41.841+0200 I/utils   (19713): specific action
04-23 15:57:41.841+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.841+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.841+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:41.851+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 15:57:41.851+0200 I/recorder(19713): guardando datos en local
04-23 15:57:41.851+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:41.851+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:41.851+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:41.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:41.861+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5757522), time2(5753348)
04-23 15:57:41.861+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:41.861+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:41.861+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:41.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:41.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:41.911+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:57:41.931+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:57:41.951+0200 W/LOCATION(19982): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:41.951+0200 I/LOCATION(19982): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:41.951+0200 I/LOCATION(19982): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:41.951+0200 I/location(19982): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:41.961+0200 I/heartrate(19742): es.ugr.frailty.heartrate listener destroyed
04-23 15:57:42.011+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:57:42.041+0200 I/LOCATION(19982): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:42.111+0200 W/AUL     (19991): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 15:57:42.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:57:42.111+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:57:42.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19742
04-23 15:57:42.111+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:57:42.111+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19742
04-23 15:57:42.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19742)
04-23 15:57:42.131+0200 W/AUL     (19982): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:42.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:42.131+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19982
04-23 15:57:42.141+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:42.141+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.141+0200 I/utils   (19708): specific action
04-23 15:57:42.141+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:42.141+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:42.141+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.141+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.141+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.141+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:42.141+0200 W/AUL     (19982): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:42.141+0200 I/location(19982): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:42.141+0200 W/CAPI_APPFW_APP_CONTROL(19982): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.141+0200 I/utils   (19982): specific action
04-23 15:57:42.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:42.141+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:42.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:42.151+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.151+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:42.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:42.151+0200 I/utils   (19713): specific action
04-23 15:57:42.151+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.151+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.151+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.151+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:42.151+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:42.151+0200 I/recorder(19713): guardando datos en local
04-23 15:57:42.151+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:42.161+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:42.161+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:42.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:42.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:42.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:42.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:42.371+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:42.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:42.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:42.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:42.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:42.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:42.461+0200 I/LOCATION(19982): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:42.581+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11199826c6f63152449186
