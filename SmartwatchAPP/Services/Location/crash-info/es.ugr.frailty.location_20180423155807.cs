S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20239
Date: 2018-04-23 15:58:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf744252d, r5   = 0xf7516f98
r6   = 0xff81ee68, r7   = 0xff81ed18
r8   = 0xf7513c18, r9   = 0x00000000
r10  = 0xff81edf4, fp   = 0xff81ee68
ip   = 0x00000001, sp   = 0xff81db98
lr   = 0xf7442539, pc   = 0xf74ab2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9892 KB
Buffers:     58260 KB
Cached:     234292 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11744 KB
VmRSS:       11744 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20239 TID = 20239
20239 20242 

Maps Information
f430d000 f4b0c000 rw-p [stack:20242]
f4b13000 f4b15000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b1d000 f4b21000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b2a000 f4b2c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b34000 f4b37000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b46000 f4b4b000 r-xp /usr/lib/libsystem.so.0.0.0
f4b56000 f4b59000 r-xp /lib/libattr.so.1.1.0
f4b61000 f4b71000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b79000 f4b82000 r-xp /usr/lib/libedbus.so.1.7.99
f4b8a000 f4b8b000 r-xp /usr/lib/libresponse.so.0.2.96
f4b94000 f4b99000 r-xp /usr/lib/libproc-stat.so.0.2.96
f643b000 f6541000 r-xp /usr/lib/libicuuc.so.57.1
f6557000 f66df000 r-xp /usr/lib/libicui18n.so.57.1
f66ef000 f66fc000 r-xp /usr/lib/libail.so.0.1.0
f6705000 f670c000 r-xp /usr/lib/libminizip.so.1.0.0
f6715000 f68be000 r-xp /usr/lib/libcrypto.so.1.0.0
f68de000 f6925000 r-xp /usr/lib/libssl.so.1.0.0
f6931000 f6933000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f693b000 f6942000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f694b000 f6952000 r-xp /lib/libcrypt-2.13.so
f6983000 f6986000 r-xp /lib/libcap.so.2.21
f698e000 f6990000 r-xp /usr/lib/libiri.so
f6998000 f69e1000 r-xp /usr/lib/libmdm.so.1.2.69
f69e9000 f69ef000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69f7000 f6a1a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a24000 f6a26000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a2e000 f6a4b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a54000 f6a58000 r-xp /usr/lib/libsmack.so.1.0.0
f6a61000 f6a7a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a83000 f6a8b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a93000 f6a99000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6aa2000 f6aa4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aad000 f6abd000 r-xp /lib/libresolv-2.13.so
f6ac1000 f6ad9000 r-xp /usr/lib/liblzma.so.5.0.3
f6ae2000 f6ae4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aec000 f6b06000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b0e000 f6b3d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b46000 f6b55000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b5f000 f6b69000 r-xp /usr/lib/libsensord-shared.so
f6b72000 f6c45000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c50000 f6c66000 r-xp /lib/libz.so.1.2.5
f6c6e000 f6c73000 r-xp /usr/lib/libffi.so.5.0.10
f6c7b000 f6c7c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c84000 f6c94000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c9c000 f6cb5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cbd000 f6cbf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cc7000 f6d3c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d46000 f6d4c000 r-xp /lib/librt-2.13.so
f6d55000 f6d73000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d7d000 f6d7e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d86000 f6da9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6db1000 f6db6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6dbe000 f6de8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6df1000 f6e08000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e10000 f6e79000 r-xp /lib/libm-2.13.so
f6e82000 f6f16000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f29000 f6f2e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f36000 f6f3d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f45000 f6f6f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f78000 f7044000 r-xp /usr/lib/libxml2.so.2.7.8
f7051000 f7053000 r-xp /usr/lib/libiniparser.so.0
f705c000 f7062000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f706b000 f713b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f713c000 f7170000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7179000 f71b5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71bd000 f71c0000 r-xp /usr/lib/libbundle.so.0.1.22
f71c8000 f71ce000 r-xp /usr/lib/libappsvc.so.0.1.0
f71d6000 f7217000 r-xp /usr/lib/libeina.so.1.7.99
f7220000 f7237000 r-xp /usr/lib/libecore.so.1.7.99
f724e000 f7257000 r-xp /usr/lib/libvconf.so.0.2.45
f725f000 f7273000 r-xp /lib/libpthread-2.13.so
f727e000 f728b000 r-xp /usr/lib/libaul.so.0.1.0
f7295000 f7297000 r-xp /lib/libdl-2.13.so
f72a0000 f72ab000 r-xp /lib/libunwind.so.8.0.1
f72d8000 f72e0000 r-xp /lib/libgcc_s-4.6.so.1
f72e1000 f7405000 r-xp /lib/libc-2.13.so
f7413000 f7415000 r-xp /usr/lib/libdlog.so.0.0.0
f741d000 f7429000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7432000 f7437000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f743f000 f744e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7456000 f745a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7463000 f7466000 r-xp /usr/lib/libappcore-agent.so.1.1
f746e000 f7470000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7478000 f747c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7484000 f74a1000 r-xp /lib/ld-2.13.so
f74aa000 f74ad000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74ad000 f74b1000 r-xp /usr/lib/libsys-assert.so
f74e3000 f7554000 rw-p [heap]
ff800000 ff821000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20239)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74ab2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7442539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71493f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7147c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7153e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7159be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7159dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf718e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71891f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7147c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7153e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7159be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7159dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf718be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf718c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71908d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf747a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b1e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bf1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf709efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70a07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7230ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf722bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf722c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf722c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7464183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74647fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74ab6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf72f885c) [/lib/libc.so.6] + 0x1785c
29: (0xf74aafa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
541+0200 W/LOCATION(20224): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:04.541+0200 I/LOCATION(20224): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf74a2c18
04-23 15:58:04.541+0200 I/LOCATION(20224): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:04.541+0200 I/LOCATION(20224): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf74a2c18
04-23 15:58:04.541+0200 I/LOCATION(20224): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:04.551+0200 I/location(20224): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:04.621+0200 I/LOCATION(20224): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:04.681+0200 W/LOCATION(20224): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:04.681+0200 W/LOCATION(20224): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:04.681+0200 I/LOCATION(20224): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:04.751+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:04.751+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:04.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:04.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:04.751+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:04.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:04.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:04.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:04.751+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:04.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:04.761+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:04.761+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:04.761+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:04.831+0200 W/LOCATION(20224): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:04.831+0200 W/LOCATION(20224): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:04.901+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:04.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18030]
04-23 15:58:04.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:04.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:04.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:04.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:04.951+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:04.951+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:04.961+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:04.971+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:04.971+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:04.971+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:04.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:04.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:04.971+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:04.971+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:04.971+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:04.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:04.971+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:04.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:04.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:04.991+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5780654), time2(5776282)
04-23 15:58:04.991+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:04.991+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:04.991+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:04.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:04.991+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:04.991+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:04.991+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.061+0200 W/LOCATION(20224): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:05.061+0200 I/LOCATION(20224): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:05.061+0200 I/LOCATION(20224): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:05.061+0200 I/location(20224): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:05.181+0200 I/LOCATION(20224): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:05.241+0200 W/AUL     (20224): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:05.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:05.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20224
04-23 15:58:05.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:05.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.261+0200 I/utils   (19708): specific action
04-23 15:58:05.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.261+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.261+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:05.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:05.261+0200 W/AUL     (20224): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:05.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:05.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:05.271+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.271+0200 I/utils   (19713): specific action
04-23 15:58:05.271+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.271+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.271+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.271+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:05.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:05.271+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:05.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:05.271+0200 I/recorder(19713): guardando datos en local
04-23 15:58:05.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:05.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:05.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19713), cmd(0)
04-23 15:58:05.271+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:05.271+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:05.271+0200 I/location(20224): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:05.281+0200 I/location(20224): stopping es.ugr.frailty.location service
04-23 15:58:05.281+0200 E/CAPI_APPFW_APP_CONTROL(20224): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:58:05.281+0200 E/location(20224): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:58:05.281+0200 I/CAPI_APPFW_APPLICATION(20224): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:58:05.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:58:05.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:58:05.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:05.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:05.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:05.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:05.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:05.401+0200 W/LOCATION(20224): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:05.401+0200 I/LOCATION(20224): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:05.401+0200 I/LOCATION(20224): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:58:05.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:05.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:05.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:05.521+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:05.521+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:05.521+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:05.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:05.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.711+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:05.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:05.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:05.721+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18030
04-23 15:58:05.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2a260]
04-23 15:58:05.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:05.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:05.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:05.791+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:05.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:05.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:05.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.811+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:05.811+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:05.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:05.811+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:05.811+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:05.811+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:05.811+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:05.811+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:05.811+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:05.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.831+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:05.831+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:05.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.931+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:05.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:05.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:05.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:05.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2a260
04-23 15:58:06.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332b68]
04-23 15:58:06.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:06.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:06.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:06.031+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:06.041+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:06.041+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:06.051+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:06.061+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:06.061+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:06.061+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:06.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:06.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:06.061+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:06.061+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:06.061+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:06.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:06.061+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:06.071+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:06.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:06.081+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:06.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:06.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:06.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:06.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:06.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:06.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332b68
04-23 15:58:06.291+0200 W/AUL     (20238): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:06.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:06.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:06.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20224
04-23 15:58:06.291+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:06.301+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20224
04-23 15:58:06.301+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20224)
04-23 15:58:06.381+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:58:06.381+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:58:06.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:06.391+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:06.401+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 20239
04-23 15:58:06.401+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:58:06.451+0200 E/CAPI_APPFW_APPLICATION(20239): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:06.451+0200 E/CAPI_APPFW_APPLICATION(20239): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:58:06.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20239
04-23 15:58:06.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(20239) type(svcapp) bg(0)
04-23 15:58:06.451+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20239)
04-23 15:58:06.451+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:58:06.451+0200 I/servicemanager(19708): App control destroyed.
04-23 15:58:06.451+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20239]
04-23 15:58:06.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:06.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20239
04-23 15:58:06.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:58:06.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20239
04-23 15:58:06.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:06.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:58:06.491+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (20239) was created
04-23 15:58:06.521+0200 W/LOCATION(20239): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:58:06.521+0200 E/LOCATION(20239): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:58:06.521+0200 E/PKGMGR_INFO(20239): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:58:06.531+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:06.551+0200 I/LOCATION(20239): location.c: location_new(269) > method: 0
04-23 15:58:06.561+0200 W/LOCATION(20239): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:06.561+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:06.571+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:06.571+0200 W/LOCATION(20239): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:06.581+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:06.581+0200 W/LOCATION(20239): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:06.581+0200 W/LOCATION(20239): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:06.581+0200 W/LOCATION(20239): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:06.581+0200 W/LOCATION(20239): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:06.611+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:06.621+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:58:06.621+0200 W/LOCATION(20239): module-internal.c: module_new(311) > module (wps) open success
04-23 15:58:06.631+0200 W/LOCATION(20239): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:58:06.631+0200 W/LOCATION(20239): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:58:06.631+0200 W/LOCATION(20239): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:06.631+0200 W/LOCATION(20239): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:06.661+0200 W/LOCATION(20239): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:58:06.671+0200 I/LOCATION(20239): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7513c18
04-23 15:58:06.671+0200 I/LOCATION(20239): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:58:06.671+0200 I/LOCATION(20239): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7513c18
04-23 15:58:06.671+0200 I/LOCATION(20239): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:58:06.671+0200 I/location(20239): es.ugr.frailty.location: creado servicio de localización
04-23 15:58:06.731+0200 I/LOCATION(20239): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:58:06.791+0200 W/LOCATION(20239): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:06.791+0200 W/LOCATION(20239): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:06.791+0200 I/LOCATION(20239): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:58:06.861+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:58:06.861+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:06.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:58:06.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:58:06.871+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:58:06.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:58:06.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:58:06.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:58:06.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:58:06.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:58:06.871+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:58:06.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:58:06.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:58:06.931+0200 W/LOCATION(20239): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:58:06.931+0200 W/LOCATION(20239): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:58:07.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03778]
04-23 15:58:07.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:07.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:07.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:07.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:07.081+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:07.081+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:07.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.101+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:07.101+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:07.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:07.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:07.101+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:07.101+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:07.101+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:07.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:07.101+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:07.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:58:07.111+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5782770), time2(5776282)
04-23 15:58:07.111+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:58:07.111+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:58:07.111+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:58:07.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:58:07.111+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.121+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.121+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:07.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.191+0200 W/LOCATION(20239): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:58:07.191+0200 I/LOCATION(20239): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:07.191+0200 I/LOCATION(20239): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:58:07.191+0200 I/location(20239): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:58:07.281+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:58:07.301+0200 I/LOCATION(20239): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:07.361+0200 W/AUL     (20239): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:58:07.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:07.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 20239
04-23 15:58:07.371+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:58:07.381+0200 W/AUL     (20239): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:58:07.381+0200 I/location(20239): request sent to service es.ugr.frailty.servicemanager
04-23 15:58:07.381+0200 W/CAPI_APPFW_APP_CONTROL(20239): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.381+0200 I/utils   (20239): specific action
04-23 15:58:07.381+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.381+0200 I/utils   (19708): specific action
04-23 15:58:07.381+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.381+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.381+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.381+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:58:07.381+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:07.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:58:07.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:58:07.381+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:58:07.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:58:07.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:58:07.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:58:07.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:58:07.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:58:07.391+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.391+0200 I/utils   (19713): specific action
04-23 15:58:07.391+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.391+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.391+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.391+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:58:07.391+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:58:07.391+0200 I/recorder(19713): guardando datos en local
04-23 15:58:07.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:07.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:58:07.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:07.401+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:58:07.401+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:58:07.401+0200 I/servicemanager(19708): requesting to save local data
04-23 15:58:07.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:58:07.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:58:07.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:07.481+0200 I/LOCATION(20239): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:58:07.631+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:58:07.631+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:58:07.631+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:58:07.631+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:58:07.641+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.641+0200 W/AUL     (20249): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:58:07.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:58:07.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:58:07.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20239
04-23 15:58:07.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:58:07.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20239
04-23 15:58:07.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20239)
04-23 15:58:07.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:07.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:07.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:07.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e03778
04-23 15:58:07.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18e90]
04-23 15:58:07.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:07.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:07.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:07.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:07.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:07.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:07.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.791+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:07.791+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:07.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:07.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:07.791+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:07.791+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:07.791+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:07.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:07.791+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:07.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:07.811+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:07.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.861+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:07.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:07.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:07.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:07.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18e90
04-23 15:58:07.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e37b58]
04-23 15:58:07.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:58:07.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:58:07.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:58:07.991+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:58:07.991+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:07.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:08.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:08.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:08.011+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:58:08.011+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:58:08.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:58:08.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:58:08.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:58:08.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:58:08.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:58:08.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:58:08.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:58:08.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:08.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:58:08.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:58:08.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:08.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:58:08.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:58:08.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:58:08.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:58:08.091+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e37b58
04-23 15:58:08.191+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11202396c6f63152449188
