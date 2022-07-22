S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 31033
Date: 2018-04-23 17:35:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf724a52d, r5   = 0xf783af98
r6   = 0xff9efe90, r7   = 0xff9efd40
r8   = 0xf7837c18, r9   = 0x00000000
r10  = 0xff9efe1c, fp   = 0xff9efe90
ip   = 0x00000001, sp   = 0xff9eebc0
lr   = 0xf724a539, pc   = 0xf72b32b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     21664 KB
Buffers:     66784 KB
Cached:     214152 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12052 KB
VmRSS:       12052 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 31033 TID = 31033
31033 31036 

Maps Information
f4115000 f4914000 rw-p [stack:31036]
f491b000 f491d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4925000 f4929000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4932000 f4934000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f493c000 f493f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f494e000 f4953000 r-xp /usr/lib/libsystem.so.0.0.0
f495e000 f4961000 r-xp /lib/libattr.so.1.1.0
f4969000 f4979000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4981000 f498a000 r-xp /usr/lib/libedbus.so.1.7.99
f4992000 f4993000 r-xp /usr/lib/libresponse.so.0.2.96
f499c000 f49a1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6243000 f6349000 r-xp /usr/lib/libicuuc.so.57.1
f635f000 f64e7000 r-xp /usr/lib/libicui18n.so.57.1
f64f7000 f6504000 r-xp /usr/lib/libail.so.0.1.0
f650d000 f6514000 r-xp /usr/lib/libminizip.so.1.0.0
f651d000 f66c6000 r-xp /usr/lib/libcrypto.so.1.0.0
f66e6000 f672d000 r-xp /usr/lib/libssl.so.1.0.0
f6739000 f673b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6743000 f674a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6753000 f675a000 r-xp /lib/libcrypt-2.13.so
f678b000 f678e000 r-xp /lib/libcap.so.2.21
f6796000 f6798000 r-xp /usr/lib/libiri.so
f67a0000 f67e9000 r-xp /usr/lib/libmdm.so.1.2.69
f67f1000 f67f7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67ff000 f6822000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f682c000 f682e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6836000 f6853000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f685c000 f6860000 r-xp /usr/lib/libsmack.so.1.0.0
f6869000 f6882000 r-xp /usr/lib/libnetwork.so.0.0.0
f688b000 f6893000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f689b000 f68a1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68aa000 f68ac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68b5000 f68c5000 r-xp /lib/libresolv-2.13.so
f68c9000 f68e1000 r-xp /usr/lib/liblzma.so.5.0.3
f68ea000 f68ec000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68f4000 f690e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6916000 f6945000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f694e000 f695d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6967000 f6971000 r-xp /usr/lib/libsensord-shared.so
f697a000 f6a4d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a58000 f6a6e000 r-xp /lib/libz.so.1.2.5
f6a76000 f6a7b000 r-xp /usr/lib/libffi.so.5.0.10
f6a83000 f6a84000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a8c000 f6a9c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6aa4000 f6abd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ac5000 f6ac7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6acf000 f6b44000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b4e000 f6b54000 r-xp /lib/librt-2.13.so
f6b5d000 f6b7b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b85000 f6b86000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b8e000 f6bb1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bb9000 f6bbe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bc6000 f6bf0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bf9000 f6c10000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c18000 f6c81000 r-xp /lib/libm-2.13.so
f6c8a000 f6d1e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d31000 f6d36000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d3e000 f6d45000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d4d000 f6d77000 r-xp /usr/lib/libsensor.so.1.9.6
f6d80000 f6e4c000 r-xp /usr/lib/libxml2.so.2.7.8
f6e59000 f6e5b000 r-xp /usr/lib/libiniparser.so.0
f6e64000 f6e6a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e73000 f6f43000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f44000 f6f78000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f81000 f6fbd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fc5000 f6fc8000 r-xp /usr/lib/libbundle.so.0.1.22
f6fd0000 f6fd6000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fde000 f701f000 r-xp /usr/lib/libeina.so.1.7.99
f7028000 f703f000 r-xp /usr/lib/libecore.so.1.7.99
f7056000 f705f000 r-xp /usr/lib/libvconf.so.0.2.45
f7067000 f707b000 r-xp /lib/libpthread-2.13.so
f7086000 f7093000 r-xp /usr/lib/libaul.so.0.1.0
f709d000 f709f000 r-xp /lib/libdl-2.13.so
f70a8000 f70b3000 r-xp /lib/libunwind.so.8.0.1
f70e0000 f70e8000 r-xp /lib/libgcc_s-4.6.so.1
f70e9000 f720d000 r-xp /lib/libc-2.13.so
f721b000 f721d000 r-xp /usr/lib/libdlog.so.0.0.0
f7225000 f7231000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f723a000 f723f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7247000 f7256000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f725e000 f7262000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f726b000 f726e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7276000 f7278000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7280000 f7284000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f728c000 f72a9000 r-xp /lib/ld-2.13.so
f72b2000 f72b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72b5000 f72b9000 r-xp /usr/lib/libsys-assert.so
f7807000 f7877000 rw-p [heap]
ff9d1000 ff9f2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:31033)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf72b32b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf724a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f513f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f9675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f911f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f93e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f94017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f9bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49331fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4926171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69f9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ea6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ea87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7038ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7033b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70345a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7034879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf726c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf726c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72b36c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf710085c) [/lib/libc.so.6] + 0x1785c
29: (0xf72b2fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
nboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:34:35.901+0200 E/PKGMGR_INFO(30970): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:34:35.911+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:35.931+0200 I/LOCATION(30970): location.c: location_new(269) > method: 0
04-23 17:34:35.931+0200 W/LOCATION(30970): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:35.931+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:35.941+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:35.941+0200 W/LOCATION(30970): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:35.951+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:35.951+0200 W/LOCATION(30970): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:35.951+0200 W/LOCATION(30970): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:35.951+0200 W/LOCATION(30970): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:35.951+0200 W/LOCATION(30970): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:35.981+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:34:35.981+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:34:35.981+0200 W/LOCATION(30970): module-internal.c: module_new(311) > module (wps) open success
04-23 17:34:35.991+0200 W/LOCATION(30970): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:34:35.991+0200 W/LOCATION(30970): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:34:35.991+0200 W/LOCATION(30970): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:34:35.991+0200 W/LOCATION(30970): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:34:36.011+0200 W/LOCATION(30970): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:34:36.011+0200 I/LOCATION(30970): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf712ac18
04-23 17:34:36.011+0200 I/LOCATION(30970): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:34:36.011+0200 I/LOCATION(30970): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf712ac18
04-23 17:34:36.011+0200 I/LOCATION(30970): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:34:36.021+0200 I/location(30970): es.ugr.frailty.location: creado servicio de localización
04-23 17:34:36.061+0200 I/LOCATION(30970): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:34:36.101+0200 W/LOCATION(30970): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:36.101+0200 W/LOCATION(30970): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:36.101+0200 I/LOCATION(30970): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:34:36.171+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:34:36.171+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:36.171+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:36.171+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:34:36.171+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:34:36.171+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:34:36.171+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:34:36.171+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:34:36.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:34:36.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:34:36.181+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:34:36.181+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:34:36.181+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:34:36.231+0200 W/LOCATION(30970): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:34:36.231+0200 W/LOCATION(30970): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:34:36.321+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:36.361+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e7ba80]
04-23 17:34:36.361+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:34:36.361+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:34:36.361+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:34:36.361+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:34:36.371+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:36.371+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:36.381+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:36.391+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:36.391+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:34:36.391+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:34:36.391+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:36.391+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:36.391+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:36.391+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:36.391+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:36.391+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:36.391+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:36.401+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:36.401+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:36.401+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:34:36.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:36.411+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:34:36.411+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(11572077), time2(11566086)
04-23 17:34:36.411+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 17:34:36.411+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:34:36.411+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:34:36.411+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:34:36.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:36.481+0200 W/LOCATION(30970): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:34:36.481+0200 I/LOCATION(30970): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:34:36.481+0200 I/LOCATION(30970): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:34:36.481+0200 I/location(30970): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:34:36.581+0200 I/LOCATION(30970): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:34:36.621+0200 E/location(30970): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:34:36.621+0200 W/AUL     (30970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:34:36.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:34:36.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30970
04-23 17:34:36.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:34:36.641+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:34:36.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:34:36.641+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.641+0200 I/utils   (30105): specific action
04-23 17:34:36.641+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.641+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.641+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.641+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:34:36.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:34:36.641+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:34:36.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:34:36.661+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.661+0200 I/utils   (30110): specific action
04-23 17:34:36.661+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.661+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.661+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.661+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:34:36.661+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:34:36.661+0200 I/recorder(30110): guardando datos en local
04-23 17:34:36.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:34:36.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:34:36.661+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:34:36.661+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:34:36.661+0200 I/servicemanager(30105): requesting to save local data
04-23 17:34:36.661+0200 W/AUL     (30970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:34:36.661+0200 I/location(30970): request sent to service es.ugr.frailty.servicemanager
04-23 17:34:36.661+0200 I/location(30970): stopping es.ugr.frailty.location service
04-23 17:34:36.661+0200 E/CAPI_APPFW_APP_CONTROL(30970): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:34:36.661+0200 E/location(30970): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:34:36.661+0200 I/CAPI_APPFW_APPLICATION(30970): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:34:36.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:34:36.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:34:36.711+0200 W/LOCATION(30970): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:34:36.711+0200 I/LOCATION(30970): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:34:36.711+0200 I/LOCATION(30970): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:34:36.781+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:34:36.781+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:34:36.781+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:34:36.781+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:34:36.951+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.011+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:34:37.011+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:34:37.021+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:34:37.021+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e7ba80
04-23 17:34:37.101+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e93660]
04-23 17:34:37.101+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:34:37.101+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:34:37.101+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:34:37.101+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:34:37.121+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:37.121+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:37.131+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.141+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.141+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:34:37.141+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:34:37.141+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:37.141+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:37.141+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:37.141+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:37.141+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:37.141+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:37.141+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:37.151+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.161+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.161+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:34:37.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.301+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:34:37.301+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:34:37.301+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:34:37.301+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e93660
04-23 17:34:37.341+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e7c458]
04-23 17:34:37.341+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:34:37.341+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:34:37.341+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:34:37.341+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:34:37.351+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:37.351+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:37.361+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.381+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.381+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:34:37.381+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:34:37.381+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:34:37.381+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:34:37.381+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:34:37.381+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:34:37.381+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:34:37.381+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:34:37.381+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:34:37.391+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.411+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:34:37.411+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:34:37.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:34:37.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:34:37.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:34:37.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:34:37.481+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e7c458
04-23 17:34:37.681+0200 W/AUL     (30983): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:34:37.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:34:37.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:34:37.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30925
04-23 17:34:37.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:34:37.691+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 30925
04-23 17:34:37.691+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(30925)
04-23 17:34:38.661+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:34:40.981+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 114 ms (from 11576530 to 11576644) (logOverhead=0,0,0,0,0,0,0), start: 17:34:40.875
04-23 17:34:40.981+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 114 ms (from 11576530 to 11576644) (logOverhead=0,0,0,0,0,0,0), start: 17:34:40.875
04-23 17:34:58.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 11593989 to 11594090) (logOverhead=0,0,0,0,0,0,0), start: 17:34:58.334
04-23 17:34:58.431+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 11593989 to 11594090) (logOverhead=0,0,0,0,0,0,0), start: 17:34:58.334
04-23 17:34:58.431+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:58.431+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:34:58.451+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:34:58.451+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 44 69 03 00 88 E0 01 01 A8 02 A5 68)
04-23 17:34:58.451+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:34:59.791+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 17:34:59.841+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 17:34:59.861+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(pedometer_goal_achieve_percents) error
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 17:34:59.861+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(best_step_goal) error
04-23 17:34:59.861+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 17:34:59.871+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 17:34:59.891+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 17:34:59.901+0200 W/healthData( 2864): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
04-23 17:34:59.901+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 17:34:59.901+0200 W/SHealthService( 3091): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 17:35:32.621+0200 I/servicemanager(30105): es.ugr.frailty.location alive timeout
04-23 17:35:32.621+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:35:32.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:35:32.621+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:35:32.641+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 31033
04-23 17:35:32.651+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:35:32.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 31033
04-23 17:35:32.691+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(31033) type(svcapp) bg(0)
04-23 17:35:32.701+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [31033]
04-23 17:35:32.711+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(31033)
04-23 17:35:32.711+0200 I/servicemanager(30105): es.ugr.frailty.location launch request sent!
04-23 17:35:32.711+0200 I/servicemanager(30105): App control destroyed.
04-23 17:35:32.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:35:32.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 31033
04-23 17:35:32.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:35:32.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:35:32.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 31033
04-23 17:35:32.771+0200 E/CAPI_APPFW_APPLICATION(31033): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:35:32.771+0200 E/CAPI_APPFW_APPLICATION(31033): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:35:32.781+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (31033) was created
04-23 17:35:32.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:35:32.801+0200 W/LOCATION(31033): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:35:32.801+0200 E/LOCATION(31033): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:35:32.801+0200 E/PKGMGR_INFO(31033): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:35:32.811+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:35:32.831+0200 I/LOCATION(31033): location.c: location_new(269) > method: 0
04-23 17:35:32.831+0200 W/LOCATION(31033): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:35:32.831+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:35:32.841+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:35:32.841+0200 W/LOCATION(31033): module-internal.c: module_new(311) > module (gps) open success
04-23 17:35:32.841+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:35:32.851+0200 W/LOCATION(31033): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:35:32.851+0200 W/LOCATION(31033): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:35:32.851+0200 W/LOCATION(31033): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:35:32.851+0200 W/LOCATION(31033): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:35:32.871+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:35:32.871+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:35:32.881+0200 W/LOCATION(31033): module-internal.c: module_new(311) > module (wps) open success
04-23 17:35:32.881+0200 W/LOCATION(31033): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:35:32.881+0200 W/LOCATION(31033): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:35:32.881+0200 W/LOCATION(31033): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:35:32.881+0200 W/LOCATION(31033): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:35:32.901+0200 W/LOCATION(31033): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:35:32.901+0200 I/LOCATION(31033): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7837c18
04-23 17:35:32.901+0200 I/LOCATION(31033): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:35:32.901+0200 I/LOCATION(31033): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7837c18
04-23 17:35:32.901+0200 I/LOCATION(31033): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:35:32.901+0200 I/location(31033): es.ugr.frailty.location: creado servicio de localización
04-23 17:35:32.951+0200 I/LOCATION(31033): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:35:32.981+0200 W/LOCATION(31033): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:35:32.981+0200 W/LOCATION(31033): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:35:32.981+0200 I/LOCATION(31033): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:35:33.051+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:35:33.051+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:35:33.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:35:33.051+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:35:33.061+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:35:33.061+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:35:33.061+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:35:33.061+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:35:33.071+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:35:33.071+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:35:33.071+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:35:33.071+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:35:33.071+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:35:33.071+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:35:33.081+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:35:33.091+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:35:33.091+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:35:33.091+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:35:33.101+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:35:33.111+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:35:33.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:35:33.111+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:35:33.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:35:33.111+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:35:33.111+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:35:33.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:35:33.111+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:35:33.111+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:35:33.111+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:35:33.141+0200 W/LOCATION(31033): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:35:33.141+0200 W/LOCATION(31033): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:35:33.211+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:35:33.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_create(453) > New handle created[0xf7e7b208]
04-23 17:35:33.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:35:33.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:35:33.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:35:33.241+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:35:33.251+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:35:33.251+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:35:33.261+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:35:33.261+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:35:33.261+0200 E/LOCATION(30823): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:35:33.261+0200 I/LOCATION(30823): location.c: location_new(269) > method: 1
04-23 17:35:33.261+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:35:33.261+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (gps) open success
04-23 17:35:33.261+0200 W/LOCATION(30823): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:35:33.261+0200 W/LOCATION(30823): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:35:33.261+0200 W/LOCATION(30823): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:35:33.261+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:35:33.261+0200 W/LOCATION(30823): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:35:33.271+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:35:33.281+0200 I/AUL     (30823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:35:33.281+0200 E/LOCATION(30823): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:35:33.281+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:35:33.321+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:35:33.341+0200 W/LOCATION(31033): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:35:33.341+0200 I/LOCATION(31033): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:35:33.351+0200 I/LOCATION(31033): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:35:33.351+0200 I/location(31033): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:35:33.411+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 11628775 to 11629076) (logOverhead=0,0,0,0,0,0,0), start: 17:35:33.120
04-23 17:35:33.411+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 305 ms (from 11628773 to 11629078) (logOverhead=0,0,0,0,0,0,0), start: 17:35:33.119
04-23 17:35:33.411+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 11628773 to 11629078) (logOverhead=0,0,0,0,0,0,0), start: 17:35:33.119
04-23 17:35:33.431+0200 I/LOCATION(31033): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:35:33.471+0200 E/location(31033): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:35:33.471+0200 W/AUL     (31033): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:35:33.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:35:33.481+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 31033
04-23 17:35:33.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:35:33.491+0200 W/AUL     (31033): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:35:33.491+0200 I/location(31033): request sent to service es.ugr.frailty.servicemanager
04-23 17:35:33.491+0200 W/CAPI_APPFW_APP_CONTROL(31033): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.491+0200 I/utils   (31033): specific action
04-23 17:35:33.491+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:35:33.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:35:33.491+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.491+0200 I/utils   (30105): specific action
04-23 17:35:33.491+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.491+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.491+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.491+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:35:33.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:35:33.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:35:33.501+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:35:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.511+0200 I/utils   (30110): specific action
04-23 17:35:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.511+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:35:33.511+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:35:33.511+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:35:33.511+0200 I/recorder(30110): guardando datos en local
04-23 17:35:33.511+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:35:33.511+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:35:33.511+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:35:33.511+0200 I/servicemanager(30105): requesting to save local data
04-23 17:35:33.691+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:35:33.691+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(11629350), time2(11566086)
04-23 17:35:33.691+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:35:33.691+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:35:33.691+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:35:33.691+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:35:34.241+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 151 ms (from 11629755 to 11629906) (logOverhead=0,0,0,0,0,0,0), start: 17:35:34.100
04-23 17:35:34.241+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 151 ms (from 11629755 to 11629906) (logOverhead=0,0,0,0,0,0,0), start: 17:35:34.100
04-23 17:35:34.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:35:34.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:35:34.281+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:35:34.441+0200 E/CAPI_TELEPHONY(30823): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:35:35.101+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:35:35.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:35:35.111+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:35:35.241+0200 W/LOCATION(31033): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:35:35.481+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:35:35.481+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:35:35.481+0200 E/CAPI_LOCATION_MANAGER(30823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:35:35.481+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:35:35.491+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:35:35.551+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:35:35.551+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:35:35.551+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:35:35.551+0200 I/CAPI_NETWORK_CONNECTION(30823): connection.c: connection_destroy(471) > Destroy handle: 0xf7e7b208
04-23 17:35:35.551+0200 W/AUL     (31045): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:35:35.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:35:35.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:35:35.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 30954
04-23 17:35:35.551+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:35:35.561+0200 W/CRASH_MANAGER(31044): worker.c: worker_job(1205) > 11310336c6f63152449773
