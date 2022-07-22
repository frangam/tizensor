S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22587
Date: 2018-04-23 16:01:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f7c52d, r5   = 0xf7775f98
r6   = 0xffb68a98, r7   = 0xffb68948
r8   = 0xf7772c18, r9   = 0x00000000
r10  = 0xffb68a24, fp   = 0xffb68a98
ip   = 0x00000001, sp   = 0xffb677c8
lr   = 0xf6f7c539, pc   = 0xf6fe52b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8276 KB
Buffers:     60400 KB
Cached:     226136 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11884 KB
VmRSS:       11884 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22587 TID = 22587
22587 22590 

Maps Information
f3e47000 f4646000 rw-p [stack:22590]
f464d000 f464f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4657000 f465b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4664000 f4666000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f466e000 f4671000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4680000 f4685000 r-xp /usr/lib/libsystem.so.0.0.0
f4690000 f4693000 r-xp /lib/libattr.so.1.1.0
f469b000 f46ab000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46b3000 f46bc000 r-xp /usr/lib/libedbus.so.1.7.99
f46c4000 f46c5000 r-xp /usr/lib/libresponse.so.0.2.96
f46ce000 f46d3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f75000 f607b000 r-xp /usr/lib/libicuuc.so.57.1
f6091000 f6219000 r-xp /usr/lib/libicui18n.so.57.1
f6229000 f6236000 r-xp /usr/lib/libail.so.0.1.0
f623f000 f6246000 r-xp /usr/lib/libminizip.so.1.0.0
f624f000 f63f8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6418000 f645f000 r-xp /usr/lib/libssl.so.1.0.0
f646b000 f646d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6475000 f647c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6485000 f648c000 r-xp /lib/libcrypt-2.13.so
f64bd000 f64c0000 r-xp /lib/libcap.so.2.21
f64c8000 f64ca000 r-xp /usr/lib/libiri.so
f64d2000 f651b000 r-xp /usr/lib/libmdm.so.1.2.69
f6523000 f6529000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6531000 f6554000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f655e000 f6560000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6568000 f6585000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f658e000 f6592000 r-xp /usr/lib/libsmack.so.1.0.0
f659b000 f65b4000 r-xp /usr/lib/libnetwork.so.0.0.0
f65bd000 f65c5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65cd000 f65d3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65dc000 f65de000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65e7000 f65f7000 r-xp /lib/libresolv-2.13.so
f65fb000 f6613000 r-xp /usr/lib/liblzma.so.5.0.3
f661c000 f661e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6626000 f6640000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6648000 f6677000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6680000 f668f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6699000 f66a3000 r-xp /usr/lib/libsensord-shared.so
f66ac000 f677f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f678a000 f67a0000 r-xp /lib/libz.so.1.2.5
f67a8000 f67ad000 r-xp /usr/lib/libffi.so.5.0.10
f67b5000 f67b6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67be000 f67ce000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67d6000 f67ef000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f67f7000 f67f9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6801000 f6876000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6880000 f6886000 r-xp /lib/librt-2.13.so
f688f000 f68ad000 r-xp /usr/lib/libsystemd.so.0.4.0
f68b7000 f68b8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68c0000 f68e3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68eb000 f68f0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f68f8000 f6922000 r-xp /usr/lib/libdbus-1.so.3.8.12
f692b000 f6942000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f694a000 f69b3000 r-xp /lib/libm-2.13.so
f69bc000 f6a50000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a63000 f6a68000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a70000 f6a77000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a7f000 f6aa9000 r-xp /usr/lib/libsensor.so.1.9.6
f6ab2000 f6b7e000 r-xp /usr/lib/libxml2.so.2.7.8
f6b8b000 f6b8d000 r-xp /usr/lib/libiniparser.so.0
f6b96000 f6b9c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ba5000 f6c75000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c76000 f6caa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cb3000 f6cef000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6cf7000 f6cfa000 r-xp /usr/lib/libbundle.so.0.1.22
f6d02000 f6d08000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d10000 f6d51000 r-xp /usr/lib/libeina.so.1.7.99
f6d5a000 f6d71000 r-xp /usr/lib/libecore.so.1.7.99
f6d88000 f6d91000 r-xp /usr/lib/libvconf.so.0.2.45
f6d99000 f6dad000 r-xp /lib/libpthread-2.13.so
f6db8000 f6dc5000 r-xp /usr/lib/libaul.so.0.1.0
f6dcf000 f6dd1000 r-xp /lib/libdl-2.13.so
f6dda000 f6de5000 r-xp /lib/libunwind.so.8.0.1
f6e12000 f6e1a000 r-xp /lib/libgcc_s-4.6.so.1
f6e1b000 f6f3f000 r-xp /lib/libc-2.13.so
f6f4d000 f6f4f000 r-xp /usr/lib/libdlog.so.0.0.0
f6f57000 f6f63000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f6c000 f6f71000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f79000 f6f88000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f90000 f6f94000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6f9d000 f6fa0000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fa8000 f6faa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fb2000 f6fb6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fbe000 f6fdb000 r-xp /lib/ld-2.13.so
f6fe4000 f6fe7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6fe7000 f6feb000 r-xp /usr/lib/libsys-assert.so
f7742000 f77b3000 rw-p [heap]
ffb4a000 ffb6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22587)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf6fe52b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf6f7c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c833f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6c93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6c93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cc875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cc31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c81c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c8de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6c93be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6c93dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cc5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cc6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cca8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf6fb40bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4658171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf672b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6bd8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bda7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d6aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d65b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d665a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d66879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6f9e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6f9e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6fe56a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6e3285c) [/lib/libc.so.6] + 0x1785c
29: (0xf6fe4fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
supported(340) > module name(wps) is found
04-23 16:01:39.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:39.631+0200 W/LOCATION(22572): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:39.631+0200 W/LOCATION(22572): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:39.631+0200 W/LOCATION(22572): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:39.631+0200 W/LOCATION(22572): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:39.631+0200 W/LOCATION(22572): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:39.641+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22572
04-23 16:01:39.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:39.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:39.651+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:39:651,69
04-23 16:01:39.661+0200 W/LOCATION(22572): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:39.661+0200 I/LOCATION(22572): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7deac18
04-23 16:01:39.661+0200 I/LOCATION(22572): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:39.661+0200 I/LOCATION(22572): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7deac18
04-23 16:01:39.661+0200 I/LOCATION(22572): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:39.671+0200 I/location(22572): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:39.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:39.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22572
04-23 16:01:39.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:39.711+0200 I/LOCATION(22572): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:39.751+0200 W/LOCATION(22572): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:39.751+0200 W/LOCATION(22572): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:39.751+0200 I/LOCATION(22572): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:39.831+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:39.831+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:39.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:39.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:39.841+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:39.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:39.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:39.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:39.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:39.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:39.841+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:39.841+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:39.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:39.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:39.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:39:851,69
04-23 16:01:39.891+0200 W/LOCATION(22572): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:39.891+0200 W/LOCATION(22572): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:39.971+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7374d88]
04-23 16:01:40.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:40.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:40.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:40.001+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:40.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.021+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:40.021+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:40.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:40.031+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:40.031+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:40.031+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:40.031+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:40.031+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.041+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.041+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:40.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:40.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:40:51,69
04-23 16:01:40.051+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.081+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:40.081+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5995743), time2(5987497)
04-23 16:01:40.081+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:40.081+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:40.081+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:40.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:40.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.121+0200 W/LOCATION(22572): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:40.121+0200 I/LOCATION(22572): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:40.121+0200 I/LOCATION(22572): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:40.121+0200 I/location(22572): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:40.211+0200 I/LOCATION(22572): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:40.251+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:40.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:40:255,69
04-23 16:01:40.261+0200 W/AUL     (22572): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:40.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:40.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22572
04-23 16:01:40.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:40.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:40.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:40.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.271+0200 I/utils   (19708): specific action
04-23 16:01:40.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.271+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.271+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:40.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:40.271+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:40.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:40.281+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:40.281+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:40.281+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:40.281+0200 W/AUL     (22572): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:40.281+0200 I/location(22572): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:40.281+0200 I/location(22572): stopping es.ugr.frailty.location service
04-23 16:01:40.281+0200 E/CAPI_APPFW_APP_CONTROL(22572): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:40.281+0200 E/location(22572): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:40.281+0200 I/CAPI_APPFW_APPLICATION(22572): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:40.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.281+0200 I/utils   (21185): specific action
04-23 16:01:40.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.281+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:40.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:40.281+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:40.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:40.281+0200 I/recorder(21185): guardando datos en local
04-23 16:01:40.291+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:40.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:40.341+0200 W/LOCATION(22572): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:40.341+0200 I/LOCATION(22572): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:40.341+0200 I/LOCATION(22572): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:40.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:40.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:40.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:40.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:40.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:40.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:40.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:40.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:01:40.431+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:40.431+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:40.431+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:40.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:40.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:40.451+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:40:453,69
04-23 16:01:40.521+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:40.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:40.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:40.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7374d88
04-23 16:01:40.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7386538]
04-23 16:01:40.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:40.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:40.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:40.631+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:40.641+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.641+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:40.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.651+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:40:654,70
04-23 16:01:40.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.651+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:40.651+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:40.651+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.651+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:40.651+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:40.661+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:40.661+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.661+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:40.661+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:40.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.671+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.671+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:40.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:40.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:40.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:40.781+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7386538
04-23 16:01:40.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01ef0]
04-23 16:01:40.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:40.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:40.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:40.831+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:40.841+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.841+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:40.851+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:40:852,69
04-23 16:01:40.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.851+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.851+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:40.851+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:40.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:40.851+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:40.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:40.851+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:40.861+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:40.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:40.861+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:40.861+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:40.871+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:40.871+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.961+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:40.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:40.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:40.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:40.971+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01ef0
04-23 16:01:41.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:41.051+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:41:52,70
04-23 16:01:41.141+0200 W/AUL     (22584): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22526
04-23 16:01:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:41.151+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22526
04-23 16:01:41.151+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22526)
04-23 16:01:41.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:41.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:41:252,69
04-23 16:01:41.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:41.451+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:41:452,70
04-23 16:01:41.621+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:41.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:41.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:41.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:41.641+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:01:41.641+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 22587
04-23 16:01:41.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:41.651+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:41:652,70
04-23 16:01:41.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22587
04-23 16:01:41.691+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(22587) type(svcapp) bg(0)
04-23 16:01:41.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22587)
04-23 16:01:41.691+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:41.691+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:41.691+0200 E/CAPI_APPFW_APPLICATION(22587): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:41.691+0200 E/CAPI_APPFW_APPLICATION(22587): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:01:41.691+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (22587) was created
04-23 16:01:41.691+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22587]
04-23 16:01:41.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:41.721+0200 W/LOCATION(22587): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:01:41.721+0200 E/LOCATION(22587): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:01:41.721+0200 E/PKGMGR_INFO(22587): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:01:41.721+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:41.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22587
04-23 16:01:41.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:41.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:01:41.741+0200 I/LOCATION(22587): location.c: location_new(269) > method: 0
04-23 16:01:41.741+0200 W/LOCATION(22587): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:41.741+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:41.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22587
04-23 16:01:41.751+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:41.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:01:41.751+0200 W/LOCATION(22587): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:41.761+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:41.761+0200 W/LOCATION(22587): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:41.761+0200 W/LOCATION(22587): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:41.761+0200 W/LOCATION(22587): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:41.761+0200 W/LOCATION(22587): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:41.791+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:41.791+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:01:41.801+0200 W/LOCATION(22587): module-internal.c: module_new(311) > module (wps) open success
04-23 16:01:41.801+0200 W/LOCATION(22587): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:01:41.801+0200 W/LOCATION(22587): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:01:41.801+0200 W/LOCATION(22587): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:41.801+0200 W/LOCATION(22587): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:41.821+0200 W/LOCATION(22587): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:01:41.821+0200 I/LOCATION(22587): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7772c18
04-23 16:01:41.821+0200 I/LOCATION(22587): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:01:41.821+0200 I/LOCATION(22587): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7772c18
04-23 16:01:41.821+0200 I/LOCATION(22587): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:01:41.821+0200 I/location(22587): es.ugr.frailty.location: creado servicio de localización
04-23 16:01:41.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:41.851+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:41:853,70
04-23 16:01:41.871+0200 I/LOCATION(22587): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:01:41.911+0200 W/LOCATION(22587): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:41.911+0200 W/LOCATION(22587): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:41.911+0200 I/LOCATION(22587): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:41.981+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:41.981+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:41.981+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:41.981+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:41.981+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:41.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:41.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:41.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:41.991+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:41.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:41.991+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:41.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:41.991+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:42.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:42.051+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:42:52,70
04-23 16:01:42.061+0200 W/LOCATION(22587): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:42.061+0200 W/LOCATION(22587): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:42.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:42.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e225e8]
04-23 16:01:42.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:42.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:42.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:42.191+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:42.201+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:42.201+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:42.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.221+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:42.221+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:42.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:42.221+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:42.221+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:42.221+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:42.221+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:42.221+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:42.221+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:42.221+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:42.221+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5997886), time2(5987497)
04-23 16:01:42.221+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:01:42.221+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:42.221+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:42.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:42.221+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.231+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.231+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:42.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:42.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:42.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:42:253,70
04-23 16:01:42.281+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:42.291+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:42.311+0200 W/LOCATION(22587): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:42.311+0200 I/LOCATION(22587): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:42.311+0200 I/LOCATION(22587): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:42.311+0200 I/location(22587): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:42.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:42.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:42.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:42.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:42.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:42.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:42.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:42.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:42.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:42.421+0200 I/LOCATION(22587): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:42.441+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:42.451+0200 I/heartrate(22257): es.ugr.frailty.heartrate: SM-R760,23/04/2018,16:01:42:454,70
04-23 16:01:42.471+0200 W/AUL     (22587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:42.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:42.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22587
04-23 16:01:42.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:42.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:42.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:42.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.481+0200 I/utils   (19708): specific action
04-23 16:01:42.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:42.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:42.481+0200 W/AUL     (22587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:42.481+0200 I/location(22587): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:42.481+0200 W/CAPI_APPFW_APP_CONTROL(22587): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.481+0200 I/utils   (22587): specific action
04-23 16:01:42.481+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:42.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:42.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.491+0200 I/utils   (21185): specific action
04-23 16:01:42.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.491+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.491+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:42.491+0200 I/recorder(21185): guardando datos en local
04-23 16:01:42.491+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:42.491+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:42.491+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:42.491+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:42.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:42.521+0200 I/servicemanager(19708): es.ugr.frailty.heartrate sleep timeout
04-23 16:01:42.521+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 16:01:42.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:42.521+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:42.531+0200 I/LOCATION(22587): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:42.531+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22257
04-23 16:01:42.531+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22257)
04-23 16:01:42.531+0200 I/servicemanager(19708): es.ugr.frailty.heartrate stop request sent!
04-23 16:01:42.531+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:42.531+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:42.531+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22257), cmd(0)
04-23 16:01:42.541+0200 I/heartrate(22257): stopping es.ugr.frailty.heartrate service
04-23 16:01:42.541+0200 W/AUL     (22257): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:42.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:42.541+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22257
04-23 16:01:42.551+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:42.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.551+0200 I/utils   (19708): specific action
04-23 16:01:42.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.551+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.551+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:42.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:42.561+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:42.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.571+0200 I/utils   (21185): specific action
04-23 16:01:42.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:42.571+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:42.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:42.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:42.571+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:42.571+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:42.571+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(21185), cmd(0)
04-23 16:01:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.571+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:42.571+0200 W/AUL     (22257): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:42.571+0200 I/heartrate(22257): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:42.571+0200 I/CAPI_APPFW_APPLICATION(22257): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:42.571+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 16:01:42.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:42.571+0200 I/recorder(21185): guardando datos en local
04-23 16:01:42.571+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:42.651+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:42.661+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:42.681+0200 I/heartrate(22257): es.ugr.frailty.heartrate listener destroyed
04-23 16:01:42.691+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11225876c6f63152449210
