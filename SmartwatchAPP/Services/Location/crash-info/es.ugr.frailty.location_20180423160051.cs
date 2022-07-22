S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21938
Date: 2018-04-23 16:00:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76fc52d, r5   = 0xf7d47f98
r6   = 0xffd4a3f8, r7   = 0xffd4a2a8
r8   = 0xf7d44c18, r9   = 0x00000000
r10  = 0xffd4a384, fp   = 0xffd4a3f8
ip   = 0x00000001, sp   = 0xffd49128
lr   = 0xf76fc539, pc   = 0xf77652b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7504 KB
Buffers:     59764 KB
Cached:     234048 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12008 KB
VmRSS:       12008 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21938 TID = 21938
21938 21941 

Maps Information
f45c7000 f4dc6000 rw-p [stack:21941]
f4dcd000 f4dcf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dd7000 f4ddb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4de4000 f4de6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4dee000 f4df1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e00000 f4e05000 r-xp /usr/lib/libsystem.so.0.0.0
f4e10000 f4e13000 r-xp /lib/libattr.so.1.1.0
f4e1b000 f4e2b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e33000 f4e3c000 r-xp /usr/lib/libedbus.so.1.7.99
f4e44000 f4e45000 r-xp /usr/lib/libresponse.so.0.2.96
f4e4e000 f4e53000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66f5000 f67fb000 r-xp /usr/lib/libicuuc.so.57.1
f6811000 f6999000 r-xp /usr/lib/libicui18n.so.57.1
f69a9000 f69b6000 r-xp /usr/lib/libail.so.0.1.0
f69bf000 f69c6000 r-xp /usr/lib/libminizip.so.1.0.0
f69cf000 f6b78000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b98000 f6bdf000 r-xp /usr/lib/libssl.so.1.0.0
f6beb000 f6bed000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bf5000 f6bfc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c05000 f6c0c000 r-xp /lib/libcrypt-2.13.so
f6c3d000 f6c40000 r-xp /lib/libcap.so.2.21
f6c48000 f6c4a000 r-xp /usr/lib/libiri.so
f6c52000 f6c9b000 r-xp /usr/lib/libmdm.so.1.2.69
f6ca3000 f6ca9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cb1000 f6cd4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6cde000 f6ce0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ce8000 f6d05000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d0e000 f6d12000 r-xp /usr/lib/libsmack.so.1.0.0
f6d1b000 f6d34000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d3d000 f6d45000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d4d000 f6d53000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d5c000 f6d5e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d67000 f6d77000 r-xp /lib/libresolv-2.13.so
f6d7b000 f6d93000 r-xp /usr/lib/liblzma.so.5.0.3
f6d9c000 f6d9e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6da6000 f6dc0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dc8000 f6df7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e00000 f6e0f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e19000 f6e23000 r-xp /usr/lib/libsensord-shared.so
f6e2c000 f6eff000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f0a000 f6f20000 r-xp /lib/libz.so.1.2.5
f6f28000 f6f2d000 r-xp /usr/lib/libffi.so.5.0.10
f6f35000 f6f36000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f3e000 f6f4e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f56000 f6f6f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f77000 f6f79000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f81000 f6ff6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7000000 f7006000 r-xp /lib/librt-2.13.so
f700f000 f702d000 r-xp /usr/lib/libsystemd.so.0.4.0
f7037000 f7038000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7040000 f7063000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f706b000 f7070000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7078000 f70a2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70ab000 f70c2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70ca000 f7133000 r-xp /lib/libm-2.13.so
f713c000 f71d0000 r-xp /usr/lib/libstdc++.so.6.0.16
f71e3000 f71e8000 r-xp /usr/lib/libctx-client.so.0.8.3
f71f0000 f71f7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ff000 f7229000 r-xp /usr/lib/libsensor.so.1.9.6
f7232000 f72fe000 r-xp /usr/lib/libxml2.so.2.7.8
f730b000 f730d000 r-xp /usr/lib/libiniparser.so.0
f7316000 f731c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7325000 f73f5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73f6000 f742a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7433000 f746f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7477000 f747a000 r-xp /usr/lib/libbundle.so.0.1.22
f7482000 f7488000 r-xp /usr/lib/libappsvc.so.0.1.0
f7490000 f74d1000 r-xp /usr/lib/libeina.so.1.7.99
f74da000 f74f1000 r-xp /usr/lib/libecore.so.1.7.99
f7508000 f7511000 r-xp /usr/lib/libvconf.so.0.2.45
f7519000 f752d000 r-xp /lib/libpthread-2.13.so
f7538000 f7545000 r-xp /usr/lib/libaul.so.0.1.0
f754f000 f7551000 r-xp /lib/libdl-2.13.so
f755a000 f7565000 r-xp /lib/libunwind.so.8.0.1
f7592000 f759a000 r-xp /lib/libgcc_s-4.6.so.1
f759b000 f76bf000 r-xp /lib/libc-2.13.so
f76cd000 f76cf000 r-xp /usr/lib/libdlog.so.0.0.0
f76d7000 f76e3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76ec000 f76f1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76f9000 f7708000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7710000 f7714000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f771d000 f7720000 r-xp /usr/lib/libappcore-agent.so.1.1
f7728000 f772a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7732000 f7736000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f773e000 f775b000 r-xp /lib/ld-2.13.so
f7764000 f7767000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7767000 f776b000 r-xp /usr/lib/libsys-assert.so
f7d14000 f7d9e000 rw-p [heap]
ffd2b000 ffd4c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21938)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf77652b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf76fc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74033f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7401c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf740de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7413be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7413dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74431f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7401c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf740de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7413be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7413dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7445e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7446017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf744a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf77340bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4dd8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6eab663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7358fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf735a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74eaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74e5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74e65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74e6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf771e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf771e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77656a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf75b285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7764fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
M-R760,23/04/2018,16:00:48:336,-134.399994,31.219999,-29.330000
04-23 16:00:48.351+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:48:335,9.011370,-5.051248,0.643669
04-23 16:00:48.371+0200 W/LOCATION(21926): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:48.371+0200 W/LOCATION(21926): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:48.371+0200 I/LOCATION(21926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:48.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:48.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21926
04-23 16:00:48.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:48.421+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:48.421+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:48:425,8.610000,5.390000,-27.230000
04-23 16:00:48.421+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:48.431+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:48:433,9.327222,-1.679761,1.574477
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:48.491+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:48.491+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:48.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:48.491+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:48.501+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:48.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:48.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:48.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:48.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:48.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:48.501+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:48.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:48.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:48.551+0200 W/LOCATION(21926): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:48.551+0200 W/LOCATION(21926): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:48.611+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:48.621+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:48.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:48.621+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:48:622,28.559999,2.590000,-10.220000
04-23 16:00:48.641+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:48:626,9.360723,-0.902094,0.562313
04-23 16:00:48.661+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01c38]
04-23 16:00:48.661+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:48.661+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:48.661+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:48.661+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:48.671+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:48.671+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:48.681+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:48.681+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:48.681+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:48.681+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:48.681+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:48.681+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:48.681+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:48.681+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:48.681+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:48.681+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:48.691+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:48.691+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:48.701+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:48.701+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:48.701+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:48.741+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:48.741+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5944404), time2(5942254)
04-23 16:00:48.741+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:48.741+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:48.741+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:48.741+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:48.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:48.781+0200 W/LOCATION(21926): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:48.781+0200 I/LOCATION(21926): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:48.781+0200 I/LOCATION(21926): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:48.781+0200 I/location(21926): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:48.811+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:48.821+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:48.821+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:48:825,9.513863,-1.122234,1.931008
04-23 16:00:48.821+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:48:823,-1.610000,0.910000,0.980000
04-23 16:00:48.871+0200 I/LOCATION(21926): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:48.921+0200 W/AUL     (21926): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:48.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:48.921+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21926
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:48.931+0200 W/AUL     (21926): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:48.931+0200 I/location(21926): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:48.931+0200 I/location(21926): stopping es.ugr.frailty.location service
04-23 16:00:48.931+0200 E/CAPI_APPFW_APP_CONTROL(21926): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:00:48.931+0200 E/location(21926): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:00:48.931+0200 I/CAPI_APPFW_APPLICATION(21926): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:00:48.931+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.931+0200 I/utils   (19708): specific action
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:00:48.931+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.931+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.931+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.931+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:48.931+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:48.931+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:48.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:48.941+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:48.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:48.941+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:48.941+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:48.941+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:48.941+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.941+0200 I/utils   (21185): specific action
04-23 16:00:48.941+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.941+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.941+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.941+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:48.941+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:48.941+0200 I/recorder(21185): guardando datos en local
04-23 16:00:48.991+0200 W/LOCATION(21926): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:48.991+0200 I/LOCATION(21926): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:48.991+0200 I/LOCATION(21926): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:00:49.011+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:49.021+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:49.021+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:49:22,9.789038,-1.976472,1.385444
04-23 16:00:49.021+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:49:25,4.200000,-2.940000,0.210000
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:00:49.051+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:00:49.051+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:00:49.051+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:00:49.051+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:49.161+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:49.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:49.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:49.201+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01c38
04-23 16:00:49.211+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:49.231+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:49.251+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:49:223,2.450000,-5.250000,-1.540000
04-23 16:00:49.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18c58]
04-23 16:00:49.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:49.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:49.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:49.271+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:49.271+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:49.271+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:49.281+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.291+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:49:236,9.702895,-2.165504,0.667598
04-23 16:00:49.291+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.291+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:49.291+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:49.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:49.291+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:49.291+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:49.291+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:49.291+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:49.291+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:49.291+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:49.301+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.311+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.311+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:49.311+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.351+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.361+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:49.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:49.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:49.411+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18c58
04-23 16:00:49.421+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:49.421+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:49:425,1.470000,0.770000,0.140000
04-23 16:00:49.421+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:49.421+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:49:429,9.655040,-2.112862,0.902094
04-23 16:00:49.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e04170]
04-23 16:00:49.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:49.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:49.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:49.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:49.481+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:49.481+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:49.491+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.501+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:49.501+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:49.501+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:49.501+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:49.501+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:49.501+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:49.501+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:49.501+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:49.501+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:49.501+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.511+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:49.511+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:49.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:49.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:00:49.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:00:49.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:00:49.581+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e04170
04-23 16:00:49.631+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:49.631+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:49:635,9.724431,-1.761117,0.763310
04-23 16:00:49.631+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:49.631+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:49:639,4.550000,1.330000,1.190000
04-23 16:00:49.761+0200 W/AUL     (21935): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:00:49.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:00:49.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:00:49.761+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21850
04-23 16:00:49.761+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:00:49.761+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21850
04-23 16:00:49.761+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21850)
04-23 16:00:49.811+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:49.821+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:49.821+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:49:823,9.533006,-1.974079,1.531406
04-23 16:00:49.821+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:49:825,30.870001,6.790000,0.700000
04-23 16:00:50.011+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:50.021+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:50.021+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:50:25,9.458827,-1.402194,1.596013
04-23 16:00:50.021+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:50:24,10.010000,0.350000,4.760000
04-23 16:00:50.211+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:50.221+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:50.221+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:50:225,5.390000,8.470000,0.630000
04-23 16:00:50.221+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:50:223,9.473185,-2.251646,2.041078
04-23 16:00:50.261+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:00:50.261+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:00:50.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:50.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:50.281+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21938
04-23 16:00:50.281+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:00:50.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21938
04-23 16:00:50.331+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(21938) type(svcapp) bg(0)
04-23 16:00:50.331+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21938)
04-23 16:00:50.331+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:00:50.331+0200 I/servicemanager(19708): App control destroyed.
04-23 16:00:50.331+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21938]
04-23 16:00:50.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:50.361+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21938
04-23 16:00:50.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:50.371+0200 E/CAPI_APPFW_APPLICATION(21938): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:50.371+0200 E/CAPI_APPFW_APPLICATION(21938): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:00:50.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21938) was created
04-23 16:00:50.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:00:50.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21938
04-23 16:00:50.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:00:50.411+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:50.411+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:50.421+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:50:424,9.497113,-2.469393,1.971686
04-23 16:00:50.421+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:50:423,79.519997,-1.890000,0.490000
04-23 16:00:50.431+0200 W/LOCATION(21938): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:00:50.431+0200 E/LOCATION(21938): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:00:50.431+0200 E/PKGMGR_INFO(21938): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:00:50.441+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:50.461+0200 I/LOCATION(21938): location.c: location_new(269) > method: 0
04-23 16:00:50.461+0200 W/LOCATION(21938): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:50.471+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:50.471+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:50.481+0200 W/LOCATION(21938): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:50.481+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:50.481+0200 W/LOCATION(21938): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:50.481+0200 W/LOCATION(21938): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:50.481+0200 W/LOCATION(21938): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:50.481+0200 W/LOCATION(21938): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:50.511+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:50.511+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:00:50.511+0200 W/LOCATION(21938): module-internal.c: module_new(311) > module (wps) open success
04-23 16:00:50.521+0200 W/LOCATION(21938): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:00:50.521+0200 W/LOCATION(21938): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:00:50.521+0200 W/LOCATION(21938): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:50.521+0200 W/LOCATION(21938): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:50.541+0200 W/LOCATION(21938): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:00:50.541+0200 I/LOCATION(21938): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7d44c18
04-23 16:00:50.541+0200 I/LOCATION(21938): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:00:50.541+0200 I/LOCATION(21938): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7d44c18
04-23 16:00:50.541+0200 I/LOCATION(21938): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:00:50.541+0200 I/location(21938): es.ugr.frailty.location: creado servicio de localización
04-23 16:00:50.591+0200 I/LOCATION(21938): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:00:50.621+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:50.621+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:50.621+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:50:625,65.730003,-8.960000,-4.130000
04-23 16:00:50.621+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:50:625,9.571291,-1.459622,2.218147
04-23 16:00:50.641+0200 W/LOCATION(21938): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:50.641+0200 W/LOCATION(21938): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:50.641+0200 I/LOCATION(21938): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:00:50.711+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:00:50.711+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:00:50.711+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:00:50.711+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:00:50.711+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:00:50.711+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:00:50.711+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:00:50.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:00:50.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:00:50.711+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:00:50.711+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:00:50.711+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:00:50.781+0200 W/LOCATION(21938): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:00:50.791+0200 W/LOCATION(21938): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:00:50.821+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:50.821+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:50.821+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:50:826,9.556933,-0.890130,1.560120
04-23 16:00:50.831+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:50:826,23.590000,-5.950000,1.610000
04-23 16:00:50.881+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:50.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e03e00]
04-23 16:00:50.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:00:50.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:00:50.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:00:50.911+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:00:50.921+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:50.921+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:50.931+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:50.931+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:00:50.941+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:50.941+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:00:50.941+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:00:50.941+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:00:50.941+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:00:50.941+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:00:50.941+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:00:50.941+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:00:50.941+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:00:50.941+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:00:50.951+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:50.951+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:50.951+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:00:50.961+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:51.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:00:51.021+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.031+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:28,9.480364,-1.256232,2.026721
04-23 16:00:51.031+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.031+0200 W/LOCATION(21938): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:00:51.031+0200 I/LOCATION(21938): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:51.031+0200 I/LOCATION(21938): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:00:51.031+0200 I/location(21938): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:00:51.041+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:37,-24.080000,3.640000,19.809999
04-23 16:00:51.041+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:00:51.041+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5946704), time2(5942254)
04-23 16:00:51.041+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:00:51.041+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:00:51.041+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:00:51.041+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:00:51.121+0200 I/LOCATION(21938): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:51.171+0200 W/AUL     (21938): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:00:51.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:51.171+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21938
04-23 16:00:51.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:00:51.181+0200 W/AUL     (21938): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:00:51.181+0200 I/location(21938): request sent to service es.ugr.frailty.servicemanager
04-23 16:00:51.181+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.181+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:51.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:00:51.181+0200 I/utils   (19708): specific action
04-23 16:00:51.181+0200 W/CAPI_APPFW_APP_CONTROL(21938): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.181+0200 I/utils   (21938): specific action
04-23 16:00:51.181+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.181+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.181+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.181+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:00:51.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:00:51.181+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:00:51.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:00:51.191+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.191+0200 I/utils   (21185): specific action
04-23 16:00:51.191+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.191+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.191+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.191+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:00:51.191+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:00:51.191+0200 I/recorder(21185): guardando datos en local
04-23 16:00:51.191+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:00:51.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:00:51.201+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:00:51.201+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:00:51.201+0200 I/servicemanager(19708): requesting to save local data
04-23 16:00:51.211+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.221+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:224,9.406186,-2.254039,1.572084
04-23 16:00:51.221+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.221+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:229,-31.500000,4.480000,21.210001
04-23 16:00:51.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:00:51.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:00:51.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:00:51.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:00:51.391+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:00:51.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:51.411+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:00:51.411+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:00:51.411+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:00:51.411+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:51.411+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:416,9.267403,-2.134398,2.199004
04-23 16:00:51.411+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.421+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:422,-29.750000,6.510000,4.410000
04-23 16:00:51.431+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.441+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:442,9.066404,-3.172883,2.531606
04-23 16:00:51.441+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.441+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:447,-40.250000,2.940000,0.770000
04-23 16:00:51.451+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.461+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:457,9.164511,-3.608376,1.995614
04-23 16:00:51.461+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.461+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:466,-17.080000,-4.970000,-6.230000
04-23 16:00:51.471+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.471+0200 I/LOCATION(21938): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:00:51.471+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:477,9.377472,-2.909672,1.907080
04-23 16:00:51.481+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.481+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:486,5.600000,-2.380000,-13.720000
04-23 16:00:51.491+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.491+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:497,9.425328,-2.270789,2.251646
04-23 16:00:51.491+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.501+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:503,-2.800000,1.960000,-14.420000
04-23 16:00:51.511+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.511+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:517,9.209974,-2.490928,2.000400
04-23 16:00:51.521+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.521+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:527,-31.920000,-4.130000,-12.670000
04-23 16:00:51.531+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.541+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:542,9.363115,-3.378666,1.852045
04-23 16:00:51.541+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.541+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:546,-35.770000,-5.670000,-12.180000
04-23 16:00:51.551+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.551+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:558,9.430114,-3.299703,1.830509
04-23 16:00:51.551+0200 I/gyroscope(21907): capturing data from es.ugr.frailty.gyroscope
04-23 16:00:51.561+0200 I/gyroscope(21907): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:00:51:563,-10.150000,-4.830000,-15.470000
04-23 16:00:51.571+0200 I/accelerometer(21894): capturing data from es.ugr.frailty.accelerometer
04-23 16:00:51.581+0200 I/accelerometer(21894): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:00:51:578,9.410972,-3.050849,1.497907
04-23 16:00:51.581+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11219386c6f63152449205
