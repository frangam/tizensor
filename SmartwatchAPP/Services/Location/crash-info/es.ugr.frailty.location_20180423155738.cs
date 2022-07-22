S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 19921
Date: 2018-04-23 15:57:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6fc252d, r5   = 0xf7258958
r6   = 0xffc1eda8, r7   = 0xffc1ec58
r8   = 0xf726bc18, r9   = 0x00000000
r10  = 0xffc1ed34, fp   = 0xffc1eda8
ip   = 0x00000001, sp   = 0xffc1dad8
lr   = 0xf6fc2539, pc   = 0xf702b2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11524 KB
Buffers:     57892 KB
Cached:     232560 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11776 KB
VmRSS:       11776 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 19921 TID = 19921
19921 19926 

Maps Information
f3e8d000 f468c000 rw-p [stack:19926]
f4693000 f4695000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f469d000 f46a1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46aa000 f46ac000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f46b4000 f46b7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f46c6000 f46cb000 r-xp /usr/lib/libsystem.so.0.0.0
f46d6000 f46d9000 r-xp /lib/libattr.so.1.1.0
f46e1000 f46f1000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46f9000 f4702000 r-xp /usr/lib/libedbus.so.1.7.99
f470a000 f470b000 r-xp /usr/lib/libresponse.so.0.2.96
f4714000 f4719000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5fbb000 f60c1000 r-xp /usr/lib/libicuuc.so.57.1
f60d7000 f625f000 r-xp /usr/lib/libicui18n.so.57.1
f626f000 f627c000 r-xp /usr/lib/libail.so.0.1.0
f6285000 f628c000 r-xp /usr/lib/libminizip.so.1.0.0
f6295000 f643e000 r-xp /usr/lib/libcrypto.so.1.0.0
f645e000 f64a5000 r-xp /usr/lib/libssl.so.1.0.0
f64b1000 f64b3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f64bb000 f64c2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f64cb000 f64d2000 r-xp /lib/libcrypt-2.13.so
f6503000 f6506000 r-xp /lib/libcap.so.2.21
f650e000 f6510000 r-xp /usr/lib/libiri.so
f6518000 f6561000 r-xp /usr/lib/libmdm.so.1.2.69
f6569000 f656f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6577000 f659a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65a4000 f65a6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65ae000 f65cb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f65d4000 f65d8000 r-xp /usr/lib/libsmack.so.1.0.0
f65e1000 f65fa000 r-xp /usr/lib/libnetwork.so.0.0.0
f6603000 f660b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6613000 f6619000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6622000 f6624000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f662d000 f663d000 r-xp /lib/libresolv-2.13.so
f6641000 f6659000 r-xp /usr/lib/liblzma.so.5.0.3
f6662000 f6664000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f666c000 f6686000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f668e000 f66bd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f66c6000 f66d5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66df000 f66e9000 r-xp /usr/lib/libsensord-shared.so
f66f2000 f67c5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f67d0000 f67e6000 r-xp /lib/libz.so.1.2.5
f67ee000 f67f3000 r-xp /usr/lib/libffi.so.5.0.10
f67fb000 f67fc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6804000 f6814000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f681c000 f6835000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f683d000 f683f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6847000 f68bc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68c6000 f68cc000 r-xp /lib/librt-2.13.so
f68d5000 f68f3000 r-xp /usr/lib/libsystemd.so.0.4.0
f68fd000 f68fe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6906000 f6929000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6931000 f6936000 r-xp /usr/lib/libxdgmime.so.1.1.0
f693e000 f6968000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6971000 f6988000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6990000 f69f9000 r-xp /lib/libm-2.13.so
f6a02000 f6a96000 r-xp /usr/lib/libstdc++.so.6.0.16
f6aa9000 f6aae000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ab6000 f6abd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ac5000 f6aef000 r-xp /usr/lib/libsensor.so.1.9.6
f6af8000 f6bc4000 r-xp /usr/lib/libxml2.so.2.7.8
f6bd1000 f6bd3000 r-xp /usr/lib/libiniparser.so.0
f6bdc000 f6be2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6beb000 f6cbb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cbc000 f6cf0000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cf9000 f6d35000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d3d000 f6d40000 r-xp /usr/lib/libbundle.so.0.1.22
f6d48000 f6d4e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d56000 f6d97000 r-xp /usr/lib/libeina.so.1.7.99
f6da0000 f6db7000 r-xp /usr/lib/libecore.so.1.7.99
f6dce000 f6dd7000 r-xp /usr/lib/libvconf.so.0.2.45
f6ddf000 f6df3000 r-xp /lib/libpthread-2.13.so
f6dfe000 f6e0b000 r-xp /usr/lib/libaul.so.0.1.0
f6e15000 f6e17000 r-xp /lib/libdl-2.13.so
f6e20000 f6e2b000 r-xp /lib/libunwind.so.8.0.1
f6e58000 f6e60000 r-xp /lib/libgcc_s-4.6.so.1
f6e61000 f6f85000 r-xp /lib/libc-2.13.so
f6f93000 f6f95000 r-xp /usr/lib/libdlog.so.0.0.0
f6f9d000 f6fa9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fb2000 f6fb7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fbf000 f6fce000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6fd6000 f6fda000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fe3000 f6fe6000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fee000 f6ff0000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6ff8000 f6ffc000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7004000 f7021000 r-xp /lib/ld-2.13.so
f702a000 f702d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f702d000 f7031000 r-xp /usr/lib/libsys-assert.so
f723b000 f72ac000 rw-p [heap]
ffc00000 ffc21000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19921)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf702b2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf6fc2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6cc93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6cc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6cd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6cd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6cd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d0e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d091f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6cc7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6cd3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6cd9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6cd9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d0be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d0c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d108d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf6ffa0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf469e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6771663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c1efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c207a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6db0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dabb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dac5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dac879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fe4183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fe47fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf702b6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6e7885c) [/lib/libc.so.6] + 0x1785c
29: (0xf702afa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
n-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7524c18
04-23 15:57:32.081+0200 I/LOCATION(19864): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:32.091+0200 I/location(19864): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:32.231+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:32.231+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:32.281+0200 I/LOCATION(19864): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:32.421+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:32.421+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:32.471+0200 W/LOCATION(19864): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:32.481+0200 W/LOCATION(19864): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:32.481+0200 I/LOCATION(19864): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:32.601+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:32.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:32.621+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:32.621+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:32.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:32.621+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:32.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:32.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:32.621+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:32.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:32.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:32.621+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:32.621+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:32.621+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:32.731+0200 W/LOCATION(19864): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:32.731+0200 W/LOCATION(19864): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:32.791+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:32.791+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:32.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:32.861+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:32.861+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5748529), time2(5740657)
04-23 15:57:32.861+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:57:32.861+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:32.861+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:32.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:32.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e066b0]
04-23 15:57:32.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:32.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:32.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:32.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:32.881+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:32.881+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:32.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:32.901+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:32.901+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:32.901+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:32.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:32.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:32.901+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:32.901+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:32.901+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:32.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:32.901+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:32.911+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:32.921+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:32.921+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:32.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:32.941+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:57:32.941+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:32.941+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:32.951+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:32.961+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19864
04-23 15:57:32.961+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19864)
04-23 15:57:32.961+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:57:32.961+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:32.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:32.991+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:33.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:33.071+0200 W/LOCATION(19864): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:33.071+0200 I/LOCATION(19864): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:33.071+0200 I/LOCATION(19864): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:33.071+0200 I/location(19864): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:33.251+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:33.251+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:33.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:33.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:33.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:33.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:33.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:33.401+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:33.401+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:33.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:33.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:33.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:33.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:33.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:33.451+0200 I/LOCATION(19864): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:33.621+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:33.621+0200 I/heartrate(19742): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:57:33.691+0200 W/AUL     (19864): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:33.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:33.701+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19864
04-23 15:57:33.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:33.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.711+0200 I/utils   (19708): specific action
04-23 15:57:33.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.711+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:33.711+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:33.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19708), cmd(0)
04-23 15:57:33.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:33.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:33.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:33.721+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.721+0200 I/utils   (19713): specific action
04-23 15:57:33.721+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.721+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.721+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.721+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:33.721+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:33.721+0200 I/recorder(19713): guardando datos en local
04-23 15:57:33.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:33.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19713), cmd(0)
04-23 15:57:33.731+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:33.731+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:33.731+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:33.741+0200 W/AUL     (19864): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:33.741+0200 I/location(19864): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:33.741+0200 I/location(19864): stopping es.ugr.frailty.location service
04-23 15:57:33.741+0200 E/CAPI_APPFW_APP_CONTROL(19864): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:57:33.741+0200 E/location(19864): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:57:33.741+0200 I/CAPI_APPFW_APPLICATION(19864): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:57:33.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:57:33.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:57:33.881+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:33.881+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:33:885,90
04-23 15:57:33.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:34.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:34:2,91
04-23 15:57:34.141+0200 W/LOCATION(19864): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:34.161+0200 I/LOCATION(19864): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:34.161+0200 I/LOCATION(19864): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:57:34.231+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:34.231+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:34:235,91
04-23 15:57:34.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:34.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 15:57:34.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:34.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:34.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:34.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:34.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:34.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:34.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:34.441+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:34.451+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:34:450,91
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:57:34.461+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:57:34.461+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:57:34.461+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:34.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:57:34.621+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:34.631+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 15:57:34.631+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:34:632,91
04-23 15:57:34.821+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:34.821+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:34:826,91
04-23 15:57:34.961+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 15:57:34.961+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:34.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:34.961+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:34.981+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19864
04-23 15:57:34.981+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19864)
04-23 15:57:34.981+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 15:57:34.981+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:34.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:35.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:35:3,91
04-23 15:57:35.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:35.231+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:35:203,92
04-23 15:57:35.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:35.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:35.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:35.291+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e066b0
04-23 15:57:35.391+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:35.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf733b648]
04-23 15:57:35.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:35.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:35.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:35.441+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:35.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:35.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:35.471+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.481+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.481+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:35.481+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:35.491+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:35.491+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:35.491+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:35.491+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:35.491+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:35.491+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:35.491+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:35.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.521+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:35.521+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.531+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:35:403,92
04-23 15:57:35.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.581+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:35.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:35.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:35.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:35.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf733b648
04-23 15:57:35.641+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:35:603,92
04-23 15:57:35.641+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73740c0]
04-23 15:57:35.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:35.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:35.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:35.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:35.651+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:35.651+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:35.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.681+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.681+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:35.681+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:35.681+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:35.681+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:35.681+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:35.681+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:35.681+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:35.681+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:35.681+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:35.691+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.701+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:35.701+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:35.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:35.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:57:35.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:57:35.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:57:35.761+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73740c0
04-23 15:57:35.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:57:35.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:35.771+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19864), cmd(0)
04-23 15:57:35.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:57:35.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:35.771+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(19864), cmd(0)
04-23 15:57:35.781+0200 W/AUL     (19915): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:57:35.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:57:35.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:57:35.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 19864
04-23 15:57:35.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:57:35.801+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 19864
04-23 15:57:35.801+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(19864)
04-23 15:57:35.811+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:35.811+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:35:817,92
04-23 15:57:35.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:36.071+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:36:3,93
04-23 15:57:36.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:36.201+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:36:203,93
04-23 15:57:36.391+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:36.401+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:36:403,93
04-23 15:57:36.591+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:36.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:36:604,93
04-23 15:57:36.801+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:36.801+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:36:805,93
04-23 15:57:36.991+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:37.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:37:4,93
04-23 15:57:37.011+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 15:57:37.011+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 15:57:37.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:37.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:37.021+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 19921
04-23 15:57:37.021+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:57:37.071+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19921
04-23 15:57:37.071+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(19921) type(svcapp) bg(0)
04-23 15:57:37.071+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19921)
04-23 15:57:37.071+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 15:57:37.071+0200 I/servicemanager(19708): App control destroyed.
04-23 15:57:37.081+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19921]
04-23 15:57:37.081+0200 E/CAPI_APPFW_APPLICATION(19921): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:37.081+0200 E/CAPI_APPFW_APPLICATION(19921): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:57:37.081+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (19921) was created
04-23 15:57:37.091+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:37.101+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19921
04-23 15:57:37.101+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:37.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:57:37.121+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19921
04-23 15:57:37.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:57:37.131+0200 W/LOCATION(19921): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 15:57:37.131+0200 E/LOCATION(19921): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 15:57:37.131+0200 E/PKGMGR_INFO(19921): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:57:37.141+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:37.161+0200 I/LOCATION(19921): location.c: location_new(269) > method: 0
04-23 15:57:37.161+0200 W/LOCATION(19921): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:37.161+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:37.171+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:37.171+0200 W/LOCATION(19921): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:37.181+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:37.181+0200 W/LOCATION(19921): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:37.181+0200 W/LOCATION(19921): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:37.181+0200 W/LOCATION(19921): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:37.181+0200 W/LOCATION(19921): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:37.191+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:37.201+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:37:204,93
04-23 15:57:37.211+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:37.211+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:57:37.221+0200 W/LOCATION(19921): module-internal.c: module_new(311) > module (wps) open success
04-23 15:57:37.221+0200 W/LOCATION(19921): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:57:37.221+0200 W/LOCATION(19921): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:57:37.221+0200 W/LOCATION(19921): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:37.221+0200 W/LOCATION(19921): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:37.241+0200 W/LOCATION(19921): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:57:37.241+0200 I/LOCATION(19921): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf726bc18
04-23 15:57:37.241+0200 I/LOCATION(19921): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:57:37.241+0200 I/LOCATION(19921): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf726bc18
04-23 15:57:37.241+0200 I/LOCATION(19921): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:57:37.251+0200 I/location(19921): es.ugr.frailty.location: creado servicio de localización
04-23 15:57:37.301+0200 I/LOCATION(19921): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:57:37.351+0200 W/LOCATION(19921): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:37.351+0200 W/LOCATION(19921): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:37.351+0200 I/LOCATION(19921): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:37.401+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:37.421+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:37:405,92
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:57:37.441+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:57:37.441+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:57:37.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:57:37.441+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:57:37.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:57:37.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:57:37.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:57:37.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:57:37.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:57:37.441+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:57:37.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:57:37.441+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:57:37.491+0200 W/LOCATION(19921): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:57:37.491+0200 W/LOCATION(19921): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:57:37.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:37.601+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:37.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332bf0]
04-23 15:57:37.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:57:37.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:57:37.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:57:37.611+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:57:37.621+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:37:605,93
04-23 15:57:37.621+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:37.621+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:37.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:37.631+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:37.631+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:57:37.631+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:57:37.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:57:37.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:57:37.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:57:37.631+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:57:37.631+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:57:37.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:57:37.631+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:57:37.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:37.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:37.651+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:57:37.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:37.681+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:57:37.681+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5753348), time2(5740657)
04-23 15:57:37.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:57:37.681+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:57:37.681+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:57:37.681+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:57:37.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:57:37.721+0200 W/LOCATION(19921): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:57:37.721+0200 I/LOCATION(19921): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:37.721+0200 I/LOCATION(19921): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:57:37.721+0200 I/location(19921): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:57:37.801+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:37.801+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:37:805,93
04-23 15:57:37.811+0200 I/LOCATION(19921): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:37.861+0200 W/AUL     (19921): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:57:37.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:37.861+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19921
04-23 15:57:37.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:57:37.871+0200 W/AUL     (19921): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:57:37.871+0200 I/location(19921): request sent to service es.ugr.frailty.servicemanager
04-23 15:57:37.871+0200 W/CAPI_APPFW_APP_CONTROL(19921): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.871+0200 I/utils   (19921): specific action
04-23 15:57:37.881+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.881+0200 I/utils   (19708): specific action
04-23 15:57:37.881+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.881+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.881+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.881+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:57:37.881+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:37.881+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:57:37.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:57:37.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:57:37.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19713
04-23 15:57:37.891+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:57:37.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:57:37.891+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19713)
04-23 15:57:37.891+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:57:37.891+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.891+0200 I/utils   (19713): specific action
04-23 15:57:37.891+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.891+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.891+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.891+0200 W/CAPI_APPFW_APP_CONTROL(19713): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:57:37.891+0200 I/recorder(19713): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:57:37.891+0200 I/recorder(19713): guardando datos en local
04-23 15:57:37.891+0200 I/servicemanager(19708): requesting to save local data
04-23 15:57:38.001+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:38.001+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:38:5,93
04-23 15:57:38.201+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:38.201+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:38:205,93
04-23 15:57:38.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:57:38.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:57:38.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:57:38.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:57:38.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:57:38.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:38.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:57:38.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:57:38.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:57:38.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:38.421+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:38.421+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:38:425,93
04-23 15:57:38.451+0200 I/LOCATION(19921): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:57:38.601+0200 I/heartrate(19742): capturing data from es.ugr.frailty.heartrate
04-23 15:57:38.601+0200 I/heartrate(19742): es.ugr.frailty.heartrate: SM-R760,23/04/2018,15:57:38:606,94
04-23 15:57:38.611+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11199216c6f63152449185
