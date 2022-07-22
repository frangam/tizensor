S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28852
Date: 2018-04-23 17:03:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf758452d, r5   = 0xf7748958
r6   = 0xffe0ead0, r7   = 0xffe0e980
r8   = 0xf775bc18, r9   = 0x00000000
r10  = 0xffe0ea5c, fp   = 0xffe0ead0
ip   = 0x00000001, sp   = 0xffe0d800
lr   = 0xf7584539, pc   = 0xf75ed2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     15752 KB
Buffers:     65092 KB
Cached:     222384 KB
VmPeak:      53632 KB
VmSize:      53628 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11676 KB
VmRSS:       11676 KB
VmData:      11356 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28852 TID = 28852
28852 28855 

Maps Information
f444f000 f4c4e000 rw-p [stack:28855]
f4c55000 f4c57000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c5f000 f4c63000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c6c000 f4c6e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c76000 f4c79000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c88000 f4c8d000 r-xp /usr/lib/libsystem.so.0.0.0
f4c98000 f4c9b000 r-xp /lib/libattr.so.1.1.0
f4ca3000 f4cb3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cbb000 f4cc4000 r-xp /usr/lib/libedbus.so.1.7.99
f4ccc000 f4ccd000 r-xp /usr/lib/libresponse.so.0.2.96
f4cd6000 f4cdb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f657d000 f6683000 r-xp /usr/lib/libicuuc.so.57.1
f6699000 f6821000 r-xp /usr/lib/libicui18n.so.57.1
f6831000 f683e000 r-xp /usr/lib/libail.so.0.1.0
f6847000 f684e000 r-xp /usr/lib/libminizip.so.1.0.0
f6857000 f6a00000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a20000 f6a67000 r-xp /usr/lib/libssl.so.1.0.0
f6a73000 f6a75000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a7d000 f6a84000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a8d000 f6a94000 r-xp /lib/libcrypt-2.13.so
f6ac5000 f6ac8000 r-xp /lib/libcap.so.2.21
f6ad0000 f6ad2000 r-xp /usr/lib/libiri.so
f6ada000 f6b23000 r-xp /usr/lib/libmdm.so.1.2.69
f6b2b000 f6b31000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b39000 f6b5c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b66000 f6b68000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b70000 f6b8d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b96000 f6b9a000 r-xp /usr/lib/libsmack.so.1.0.0
f6ba3000 f6bbc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bc5000 f6bcd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bd5000 f6bdb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6be4000 f6be6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bef000 f6bff000 r-xp /lib/libresolv-2.13.so
f6c03000 f6c1b000 r-xp /usr/lib/liblzma.so.5.0.3
f6c24000 f6c26000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c2e000 f6c48000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c50000 f6c7f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c88000 f6c97000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ca1000 f6cab000 r-xp /usr/lib/libsensord-shared.so
f6cb4000 f6d87000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d92000 f6da8000 r-xp /lib/libz.so.1.2.5
f6db0000 f6db5000 r-xp /usr/lib/libffi.so.5.0.10
f6dbd000 f6dbe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dc6000 f6dd6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dde000 f6df7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dff000 f6e01000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e09000 f6e7e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e88000 f6e8e000 r-xp /lib/librt-2.13.so
f6e97000 f6eb5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ebf000 f6ec0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ec8000 f6eeb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ef3000 f6ef8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f00000 f6f2a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f33000 f6f4a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f52000 f6fbb000 r-xp /lib/libm-2.13.so
f6fc4000 f7058000 r-xp /usr/lib/libstdc++.so.6.0.16
f706b000 f7070000 r-xp /usr/lib/libctx-client.so.0.8.3
f7078000 f707f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7087000 f70b1000 r-xp /usr/lib/libsensor.so.1.9.6
f70ba000 f7186000 r-xp /usr/lib/libxml2.so.2.7.8
f7193000 f7195000 r-xp /usr/lib/libiniparser.so.0
f719e000 f71a4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71ad000 f727d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f727e000 f72b2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72bb000 f72f7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72ff000 f7302000 r-xp /usr/lib/libbundle.so.0.1.22
f730a000 f7310000 r-xp /usr/lib/libappsvc.so.0.1.0
f7318000 f7359000 r-xp /usr/lib/libeina.so.1.7.99
f7362000 f7379000 r-xp /usr/lib/libecore.so.1.7.99
f7390000 f7399000 r-xp /usr/lib/libvconf.so.0.2.45
f73a1000 f73b5000 r-xp /lib/libpthread-2.13.so
f73c0000 f73cd000 r-xp /usr/lib/libaul.so.0.1.0
f73d7000 f73d9000 r-xp /lib/libdl-2.13.so
f73e2000 f73ed000 r-xp /lib/libunwind.so.8.0.1
f741a000 f7422000 r-xp /lib/libgcc_s-4.6.so.1
f7423000 f7547000 r-xp /lib/libc-2.13.so
f7555000 f7557000 r-xp /usr/lib/libdlog.so.0.0.0
f755f000 f756b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7574000 f7579000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7581000 f7590000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7598000 f759c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75a5000 f75a8000 r-xp /usr/lib/libappcore-agent.so.1.1
f75b0000 f75b2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75ba000 f75be000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75c6000 f75e3000 r-xp /lib/ld-2.13.so
f75ec000 f75ef000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75ef000 f75f3000 r-xp /usr/lib/libsys-assert.so
f772b000 f77c9000 rw-p [heap]
ffdf0000 ffe11000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28852)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75ed2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7584539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf728b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7289c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7295e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf729bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf729bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72d075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72cb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7289c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7295e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf729bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf729bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72cde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72ce017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72d5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c6d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c60171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d33663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71e0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71e27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7372ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf736db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf736e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf736e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75a6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75a67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75ed6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf743a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf75ecfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
 W/LOCATION(28800): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:02:10.301+0200 W/LOCATION(28800): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:02:10.301+0200 I/LOCATION(28800): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:02:10.421+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:02:10.421+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:02:10.421+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:02:10.421+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:02:10.421+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:02:10.421+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:02:10.421+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:02:10.421+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:02:10.421+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:02:10.421+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:02:10.421+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:02:10.421+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:02:10.481+0200 W/LOCATION(28800): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:02:10.481+0200 W/LOCATION(28800): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:02:10.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:10.611+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4205968]
04-23 17:02:10.611+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:02:10.611+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:02:10.611+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:02:10.611+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:02:10.611+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:10.611+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:10.621+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:10.631+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:10.631+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:02:10.631+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:02:10.631+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:10.631+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:02:10.631+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:02:10.631+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:02:10.631+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:10.631+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:02:10.631+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:02:10.641+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:10.651+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:10.651+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:02:10.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:10.661+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:02:10.661+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(9626328), time2(9623680)
04-23 17:02:10.661+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 17:02:10.661+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:02:10.661+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:02:10.661+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:02:10.691+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:10.731+0200 W/LOCATION(28800): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:02:10.731+0200 I/LOCATION(28800): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:02:10.731+0200 I/LOCATION(28800): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:02:10.731+0200 I/location(28800): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:02:10.811+0200 I/LOCATION(28800): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:02:10.861+0200 E/location(28800): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:02:10.861+0200 W/AUL     (28800): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:02:10.861+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:02:10.871+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 28800
04-23 17:02:10.871+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:02:10.881+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:02:10.881+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:02:10.881+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.881+0200 I/utils   (26979): specific action
04-23 17:02:10.881+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.881+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.881+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.881+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:02:10.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:02:10.881+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:02:10.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 28352
04-23 17:02:10.901+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:02:10.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(28352), cmd(0)
04-23 17:02:10.901+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.901+0200 I/utils   (28352): specific action
04-23 17:02:10.901+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.901+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.901+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.901+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:02:10.901+0200 I/recorder(28352): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:02:10.901+0200 I/recorder(28352): guardando datos en local
04-23 17:02:10.901+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28352)
04-23 17:02:10.901+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:02:10.901+0200 I/servicemanager(26979): requesting to save local data
04-23 17:02:10.901+0200 W/AUL     (28800): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:02:10.901+0200 I/location(28800): request sent to service es.ugr.frailty.servicemanager
04-23 17:02:10.901+0200 I/location(28800): stopping es.ugr.frailty.location service
04-23 17:02:10.901+0200 E/CAPI_APPFW_APP_CONTROL(28800): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 17:02:10.901+0200 E/location(28800): request sending failed to service es.ugr.frailty.servicemanager
04-23 17:02:10.901+0200 I/CAPI_APPFW_APPLICATION(28800): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:02:10.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:02:10.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:02:10.941+0200 W/LOCATION(28800): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:02:10.951+0200 I/LOCATION(28800): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 17:02:10.951+0200 I/LOCATION(28800): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:02:11.011+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:02:11.011+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:02:11.011+0200 E/CAPI_LOCATION_MANAGER(28530): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:02:11.011+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:02:11.111+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.151+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:02:11.151+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:02:11.151+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:02:11.151+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4205968
04-23 17:02:11.211+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf796b508]
04-23 17:02:11.211+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:02:11.211+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:02:11.211+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:02:11.211+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:02:11.221+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:11.221+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:11.221+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.231+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.231+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:02:11.231+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:02:11.231+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:11.231+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:02:11.231+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:02:11.231+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:02:11.231+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:11.231+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:02:11.231+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:02:11.241+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.251+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.251+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:02:11.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.291+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.301+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.371+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:02:11.371+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:02:11.371+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:02:11.371+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf796b508
04-23 17:02:11.421+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf796d268]
04-23 17:02:11.421+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:02:11.421+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:02:11.421+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:02:11.421+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:02:11.431+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:11.431+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:11.441+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.441+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.441+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:02:11.441+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:02:11.441+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:02:11.451+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:02:11.451+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:02:11.451+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:02:11.451+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:02:11.451+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:02:11.451+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:02:11.451+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.461+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:02:11.461+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:02:11.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:02:11.551+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:02:11.551+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:02:11.551+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:02:11.551+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf796d268
04-23 17:02:11.751+0200 W/AUL     (28811): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:02:11.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:02:11.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:02:11.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28688
04-23 17:02:11.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:02:11.761+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28688
04-23 17:02:11.761+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28688)
04-23 17:02:12.901+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:02:18.471+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 118 ms (from 9634020 to 9634138) (logOverhead=0,0,0,0,0,0,0), start: 17:02:18.365
04-23 17:02:18.471+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 118 ms (from 9634020 to 9634138) (logOverhead=0,0,0,0,0,0,0), start: 17:02:18.365
04-23 17:02:20.471+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 120 ms (from 9636019 to 9636139) (logOverhead=0,0,0,0,0,0,0), start: 17:02:20.364
04-23 17:02:20.471+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 120 ms (from 9636019 to 9636139) (logOverhead=0,0,0,0,0,0,0), start: 17:02:20.364
04-23 17:02:21.001+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_period error
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(inactive_test_mode_on), check retry err: -21/(2/No such file or directory).
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_test_mode_on) step(-17825744) failed(2 / No such file or directory)
04-23 17:02:21.021+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : inactive_test_mode_on error
04-23 17:02:21.021+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextSettingTimeUpdatedCB(896) > [1;40;33minactive state change : => PEDOMETER_INACTIVE_STATE_BEFORE_10MIN_PRECAUTION[0;m
04-23 17:02:21.021+0200 W/SHealthService( 3091): PedometerServiceController.cpp: OnInactiveTimeBefore10MinPrecaution(1072) > [1;40;33minactive 50 min started[0;m
04-23 17:02:21.021+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [4980][0;m
04-23 17:02:21.041+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: inactive_50min, pendingClientInfoList.size(): 0[0;m
04-23 17:02:21.091+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 17:02:21.111+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_alert_always), check retry err: -21/(2/No such file or directory).
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_alert_always) step(-17825744) failed(2 / No such file or directory)
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_boolean(1173) > preference_get_boolean(3091) : pedometer_inactive_alert_always error
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_alert_time_start), check retry err: -21/(2/No such file or directory).
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_alert_time_start) step(-17825744) failed(2 / No such file or directory)
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_alert_time_start error
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_alert_time_end), check retry err: -21/(2/No such file or directory).
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_alert_time_end) step(-17825744) failed(2 / No such file or directory)
04-23 17:02:21.111+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_double(1214) > preference_get_double(3091) : pedometer_inactive_alert_time_end error
04-23 17:02:21.111+0200 W/SHealthService( 3091): PedometerAlertNotiMessageControls.cpp: Static_InactiveRelatedNotiMessageCheckCondition(76) > [1;35mST [32400000,000000] ET [61200000,000000] NT [61341030,000000][0;m
04-23 17:02:21.111+0200 W/SHealthService( 3091): AlertNotiManager.cpp: NotifyAlertMessageImpl(393) > [1;40;33malert noti[inactive_before_10min_precaution] blocked[0;m
04-23 17:02:21.111+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [2910][0;m
04-23 17:02:21.121+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [2900][0;m
04-23 17:02:21.131+0200 W/SHealthCommon( 3091): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1524441600000,000000[0;m
04-23 17:02:21.151+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 1[0;m
04-23 17:02:21.151+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-23 17:02:21.161+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 17:02:21.181+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 17:02:32.451+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 9648006 to 9648108) (logOverhead=0,0,0,0,0,0,0), start: 17:02:32.351
04-23 17:02:32.451+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 102 ms (from 9648006 to 9648108) (logOverhead=0,0,0,0,0,0,0), start: 17:02:32.351
04-23 17:02:32.451+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:02:32.451+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:02:32.471+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 17:02:32.471+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 BE 3F 03 00 72 E0 01 01 E2 02 A5 68)
04-23 17:02:32.471+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:02:34.791+0200 E/wnoti-ancs( 3002): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][4][0][14][0][0][0][0][0][0][0][0][0][0]
04-23 17:03:10.071+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 17:03:10.071+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:03:10.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:03:10.081+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:03:10.101+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:03:10.101+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 28852
04-23 17:03:10.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 28852
04-23 17:03:10.161+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(28852) type(svcapp) bg(0)
04-23 17:03:10.161+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [28852]
04-23 17:03:10.171+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28852)
04-23 17:03:10.171+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 17:03:10.171+0200 I/servicemanager(26979): App control destroyed.
04-23 17:03:10.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:03:10.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28852
04-23 17:03:10.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:03:10.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:03:10.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28852
04-23 17:03:10.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:03:10.231+0200 E/CAPI_APPFW_APPLICATION(28852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:03:10.231+0200 E/CAPI_APPFW_APPLICATION(28852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:03:10.231+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (28852) was created
04-23 17:03:10.261+0200 W/LOCATION(28852): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:03:10.261+0200 E/LOCATION(28852): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:03:10.261+0200 E/PKGMGR_INFO(28852): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:03:10.261+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:03:10.281+0200 I/LOCATION(28852): location.c: location_new(269) > method: 0
04-23 17:03:10.281+0200 W/LOCATION(28852): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:03:10.291+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:03:10.291+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:03:10.301+0200 W/LOCATION(28852): module-internal.c: module_new(311) > module (gps) open success
04-23 17:03:10.301+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:03:10.301+0200 W/LOCATION(28852): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:03:10.301+0200 W/LOCATION(28852): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:03:10.311+0200 W/LOCATION(28852): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:03:10.311+0200 W/LOCATION(28852): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:03:10.331+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:03:10.331+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:03:10.341+0200 W/LOCATION(28852): module-internal.c: module_new(311) > module (wps) open success
04-23 17:03:10.341+0200 W/LOCATION(28852): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:03:10.341+0200 W/LOCATION(28852): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:03:10.341+0200 W/LOCATION(28852): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:03:10.341+0200 W/LOCATION(28852): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:03:10.361+0200 W/LOCATION(28852): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:03:10.361+0200 I/LOCATION(28852): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf775bc18
04-23 17:03:10.361+0200 I/LOCATION(28852): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:03:10.361+0200 I/LOCATION(28852): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf775bc18
04-23 17:03:10.361+0200 I/LOCATION(28852): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:03:10.361+0200 I/location(28852): es.ugr.frailty.location: creado servicio de localización
04-23 17:03:10.411+0200 I/LOCATION(28852): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:03:10.451+0200 W/LOCATION(28852): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:03:10.451+0200 W/LOCATION(28852): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:03:10.451+0200 I/LOCATION(28852): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:03:10.501+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:03:10.501+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:03:10.501+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:03:10.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:03:10.511+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:03:10.511+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:03:10.511+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:03:10.511+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:03:10.521+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:03:10.521+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:03:10.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:03:10.521+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:03:10.521+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:03:10.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:03:10.531+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:03:10.541+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:03:10.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:03:10.541+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:03:10.551+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:03:10.551+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:03:10.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:03:10.551+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:03:10.561+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:03:10.561+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:03:10.561+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:03:10.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:03:10.581+0200 W/LOCATION(28852): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:03:10.581+0200 W/LOCATION(28852): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:03:10.651+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:03:10.681+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf796eaa8]
04-23 17:03:10.681+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:03:10.681+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:03:10.681+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:03:10.681+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:03:10.691+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:03:10.691+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:03:10.701+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:03:10.711+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:03:10.711+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:03:10.711+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:03:10.711+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:03:10.711+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:03:10.711+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:03:10.711+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:03:10.711+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:03:10.711+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:03:10.711+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:03:10.711+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:03:10.721+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:03:10.721+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:03:10.721+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:03:10.761+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:03:10.781+0200 W/LOCATION(28852): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:03:10.781+0200 I/LOCATION(28852): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:03:10.781+0200 I/LOCATION(28852): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:03:10.781+0200 I/location(28852): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:03:10.861+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 9686219 to 9686520) (logOverhead=0,0,0,0,0,0,0), start: 17:03:10.564
04-23 17:03:10.861+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 305 ms (from 9686217 to 9686522) (logOverhead=0,0,0,0,0,0,0), start: 17:03:10.562
04-23 17:03:10.861+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 9686217 to 9686522) (logOverhead=0,0,0,0,0,0,0), start: 17:03:10.562
04-23 17:03:10.871+0200 I/LOCATION(28852): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:03:10.911+0200 E/location(28852): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:03:10.911+0200 W/AUL     (28852): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:03:10.911+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:03:10.911+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 28852
04-23 17:03:10.921+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:03:10.921+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.921+0200 I/utils   (26979): specific action
04-23 17:03:10.921+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.921+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.921+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.921+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:03:10.921+0200 W/AUL     (28852): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:03:10.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:03:10.931+0200 I/location(28852): request sent to service es.ugr.frailty.servicemanager
04-23 17:03:10.931+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:03:10.931+0200 W/CAPI_APPFW_APP_CONTROL(28852): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.931+0200 I/utils   (28852): specific action
04-23 17:03:10.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 28352
04-23 17:03:10.931+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.941+0200 I/utils   (28352): specific action
04-23 17:03:10.941+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.941+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.941+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.941+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:03:10.941+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:03:10.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:03:10.941+0200 I/recorder(28352): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:03:10.941+0200 I/recorder(28352): guardando datos en local
04-23 17:03:10.941+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:03:10.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(28352), cmd(0)
04-23 17:03:10.941+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28352)
04-23 17:03:10.941+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:03:10.941+0200 I/servicemanager(26979): requesting to save local data
04-23 17:03:11.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:03:11.131+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(9686795), time2(9623680)
04-23 17:03:11.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:03:11.131+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:03:11.131+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:03:11.131+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:03:11.681+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 144 ms (from 9687198 to 9687342) (logOverhead=0,0,0,0,0,0,0), start: 17:03:11.543
04-23 17:03:11.681+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 144 ms (from 9687198 to 9687342) (logOverhead=0,0,0,0,0,0,0), start: 17:03:11.543
04-23 17:03:11.731+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:03:11.731+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:03:11.731+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:03:11.841+0200 E/CAPI_TELEPHONY(28530): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:03:12.521+0200 W/LOCATION(28852): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:03:12.561+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:03:12.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:03:12.561+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:03:12.751+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:03:12.751+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:03:12.761+0200 E/CAPI_LOCATION_MANAGER(28530): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:03:12.761+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:03:12.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:03:12.801+0200 W/AUL     (28865): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:03:12.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:03:12.801+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:03:12.801+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28771
04-23 17:03:12.801+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:03:12.831+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:03:12.831+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:03:12.831+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:03:12.831+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf796eaa8
04-23 17:03:12.831+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28771
04-23 17:03:12.831+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28771)
04-23 17:03:12.841+0200 W/CRASH_MANAGER(28863): worker.c: worker_job(1205) > 11288526c6f63152449579
