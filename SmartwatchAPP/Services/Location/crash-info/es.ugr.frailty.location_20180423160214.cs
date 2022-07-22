S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 23030
Date: 2018-04-23 16:02:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf752c52d, r5   = 0xf7c8ff98
r6   = 0xff941ce8, r7   = 0xff941b98
r8   = 0xf7c8cc18, r9   = 0x00000000
r10  = 0xff941c74, fp   = 0xff941ce8
ip   = 0x00000001, sp   = 0xff940a18
lr   = 0xf752c539, pc   = 0xf75952b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      6924 KB
Buffers:     60736 KB
Cached:     226248 KB
VmPeak:      52532 KB
VmSize:      52528 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11956 KB
VmRSS:       11956 KB
VmData:      10256 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 23030 TID = 23030
23030 23033 

Maps Information
f43f7000 f4bf6000 rw-p [stack:23033]
f4bfd000 f4bff000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c07000 f4c0b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c14000 f4c16000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c1e000 f4c21000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c30000 f4c35000 r-xp /usr/lib/libsystem.so.0.0.0
f4c40000 f4c43000 r-xp /lib/libattr.so.1.1.0
f4c4b000 f4c5b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c63000 f4c6c000 r-xp /usr/lib/libedbus.so.1.7.99
f4c74000 f4c75000 r-xp /usr/lib/libresponse.so.0.2.96
f4c7e000 f4c83000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6525000 f662b000 r-xp /usr/lib/libicuuc.so.57.1
f6641000 f67c9000 r-xp /usr/lib/libicui18n.so.57.1
f67d9000 f67e6000 r-xp /usr/lib/libail.so.0.1.0
f67ef000 f67f6000 r-xp /usr/lib/libminizip.so.1.0.0
f67ff000 f69a8000 r-xp /usr/lib/libcrypto.so.1.0.0
f69c8000 f6a0f000 r-xp /usr/lib/libssl.so.1.0.0
f6a1b000 f6a1d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a25000 f6a2c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a35000 f6a3c000 r-xp /lib/libcrypt-2.13.so
f6a6d000 f6a70000 r-xp /lib/libcap.so.2.21
f6a78000 f6a7a000 r-xp /usr/lib/libiri.so
f6a82000 f6acb000 r-xp /usr/lib/libmdm.so.1.2.69
f6ad3000 f6ad9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6ae1000 f6b04000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b0e000 f6b10000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b18000 f6b35000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b3e000 f6b42000 r-xp /usr/lib/libsmack.so.1.0.0
f6b4b000 f6b64000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b6d000 f6b75000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b7d000 f6b83000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b8c000 f6b8e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b97000 f6ba7000 r-xp /lib/libresolv-2.13.so
f6bab000 f6bc3000 r-xp /usr/lib/liblzma.so.5.0.3
f6bcc000 f6bce000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bd6000 f6bf0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bf8000 f6c27000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c30000 f6c3f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c49000 f6c53000 r-xp /usr/lib/libsensord-shared.so
f6c5c000 f6d2f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d3a000 f6d50000 r-xp /lib/libz.so.1.2.5
f6d58000 f6d5d000 r-xp /usr/lib/libffi.so.5.0.10
f6d65000 f6d66000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d6e000 f6d7e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d86000 f6d9f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6da7000 f6da9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6db1000 f6e26000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e30000 f6e36000 r-xp /lib/librt-2.13.so
f6e3f000 f6e5d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e67000 f6e68000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e70000 f6e93000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e9b000 f6ea0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ea8000 f6ed2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6edb000 f6ef2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6efa000 f6f63000 r-xp /lib/libm-2.13.so
f6f6c000 f7000000 r-xp /usr/lib/libstdc++.so.6.0.16
f7013000 f7018000 r-xp /usr/lib/libctx-client.so.0.8.3
f7020000 f7027000 r-xp /usr/lib/libctx-shared.so.0.8.3
f702f000 f7059000 r-xp /usr/lib/libsensor.so.1.9.6
f7062000 f712e000 r-xp /usr/lib/libxml2.so.2.7.8
f713b000 f713d000 r-xp /usr/lib/libiniparser.so.0
f7146000 f714c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7155000 f7225000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7226000 f725a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7263000 f729f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72a7000 f72aa000 r-xp /usr/lib/libbundle.so.0.1.22
f72b2000 f72b8000 r-xp /usr/lib/libappsvc.so.0.1.0
f72c0000 f7301000 r-xp /usr/lib/libeina.so.1.7.99
f730a000 f7321000 r-xp /usr/lib/libecore.so.1.7.99
f7338000 f7341000 r-xp /usr/lib/libvconf.so.0.2.45
f7349000 f735d000 r-xp /lib/libpthread-2.13.so
f7368000 f7375000 r-xp /usr/lib/libaul.so.0.1.0
f737f000 f7381000 r-xp /lib/libdl-2.13.so
f738a000 f7395000 r-xp /lib/libunwind.so.8.0.1
f73c2000 f73ca000 r-xp /lib/libgcc_s-4.6.so.1
f73cb000 f74ef000 r-xp /lib/libc-2.13.so
f74fd000 f74ff000 r-xp /usr/lib/libdlog.so.0.0.0
f7507000 f7513000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f751c000 f7521000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7529000 f7538000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7540000 f7544000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f754d000 f7550000 r-xp /usr/lib/libappcore-agent.so.1.1
f7558000 f755a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7562000 f7566000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f756e000 f758b000 r-xp /lib/ld-2.13.so
f7594000 f7597000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7597000 f759b000 r-xp /usr/lib/libsys-assert.so
f7c5c000 f7ceb000 rw-p [heap]
ff923000 ff944000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23030)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75952b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf752c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72333f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7231c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf723de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7243be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7243dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf727875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72731f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7231c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf723de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7243be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7243dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7275e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7276017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf727a8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf75640bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4c08171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cdb663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7188fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf718a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf731aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7315b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73165a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7316879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf754e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf754e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75956a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf73e285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7594fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
mingMessage() dest id:0, msg id:8
04-23 16:02:15.641+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:15.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:15.651+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:15.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:15.651+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:15.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:15.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:15.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:15.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:15.671+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:15:655,4.830000,3.150000,3.080000
04-23 16:02:15.671+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:15.671+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:15:676,-2.520000,4.760000,4.200000
04-23 16:02:15.681+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:15.681+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:15:686,0.770000,0.700000,2.170000
04-23 16:02:15.711+0200 W/LOCATION(23044): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:15.711+0200 W/LOCATION(23044): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:15.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:15.821+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:15.851+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2e3a0]
04-23 16:02:15.851+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:15.851+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:15.851+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:15.851+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:15.851+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:15.851+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:15.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:15.871+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:15.871+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:15.871+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:15.871+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:15.871+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:15.871+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:15.871+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:15.871+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:15.871+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:15.871+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:15.881+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:15.881+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:15:885,9.899107,-0.478565,1.914258
04-23 16:02:15.881+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:15.881+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:15.881+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:15.881+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:15:825,-0.560000,-0.070000,0.910000
04-23 16:02:15.891+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:15.891+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6031552), time2(6029254)
04-23 16:02:15.891+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:15.891+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:15.891+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:15.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:15.891+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:15.891+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:15.891+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:15.941+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:15.961+0200 W/LOCATION(23044): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:15.961+0200 I/LOCATION(23044): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:15.961+0200 I/LOCATION(23044): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:02:15.961+0200 I/location(23044): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:02:16.021+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:16.021+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:16:25,-9.380000,3.500000,3.570000
04-23 16:02:16.021+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:16.021+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:16:29,9.308081,-0.748954,2.282753
04-23 16:02:16.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:16.061+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:16.071+0200 I/LOCATION(23044): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:16.111+0200 W/AUL     (23044): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:16.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:16.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23044
04-23 16:02:16.121+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:16.121+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.131+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:16.131+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:16.131+0200 I/utils   (19708): specific action
04-23 16:02:16.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.131+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.131+0200 W/AUL     (23044): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:16.131+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:16.131+0200 I/location(23044): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:16.131+0200 I/location(23044): stopping es.ugr.frailty.location service
04-23 16:02:16.131+0200 E/CAPI_APPFW_APP_CONTROL(23044): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:02:16.131+0200 E/location(23044): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:02:16.131+0200 I/CAPI_APPFW_APPLICATION(23044): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:16.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:16.131+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:16.141+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:16.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:16.161+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:16.161+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:16.141+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:16.161+0200 I/utils   (22624): specific action
04-23 16:02:16.161+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.161+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.161+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.161+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:16.161+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:02:16.141+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:16.161+0200 I/recorder(22624): guardando datos en local
04-23 16:02:16.161+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:16.161+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:16.191+0200 W/LOCATION(23044): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:02:16.191+0200 I/LOCATION(23044): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:16.191+0200 I/LOCATION(23044): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:02:16.221+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:16.221+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:16:225,-14.630000,-0.560000,3.570000
04-23 16:02:16.221+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:16.221+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:16:229,9.377472,-1.194018,2.301895
04-23 16:02:16.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:16.261+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:02:16.281+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:02:16.281+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:02:16.281+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:02:16.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:02:16.411+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:16.411+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:16.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.431+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:16:424,14.770000,4.480000,-0.420000
04-23 16:02:16.441+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:16:422,9.707682,-0.887737,2.189433
04-23 16:02:16.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:16.461+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:16.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:16.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:16.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:16.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2e3a0
04-23 16:02:16.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e19ab8]
04-23 16:02:16.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:16.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:16.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:16.521+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:16.531+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:16.531+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:16.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.551+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:16.551+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:16.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:16.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:16.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:16.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:16.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:16.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:16.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:16.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.571+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:16.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.611+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:16.621+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:16.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.631+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:16:623,9.494720,-0.799203,2.368894
04-23 16:02:16.631+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:16:625,7.840000,1.190000,0.560000
04-23 16:02:16.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:16.661+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:16.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:16.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e19ab8
04-23 16:02:16.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2c920]
04-23 16:02:16.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:16.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:16.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:16.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:16.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:16.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:16.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.781+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:16.781+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:16.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:16.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:16.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:16.781+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:16.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:16.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:16.781+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:16.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.811+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:16.811+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:16.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.811+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:16.821+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:16.821+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:16:827,3.010000,0.070000,-0.070000
04-23 16:02:16.831+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:16:823,9.444471,-0.622134,2.249253
04-23 16:02:16.851+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:16.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:02:16.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:02:16.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:02:16.871+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2c920
04-23 16:02:16.871+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:16.871+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.021+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:17.021+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:17.021+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:17:25,-6.510000,0.910000,0.630000
04-23 16:02:17.021+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:17:25,9.583255,-0.720240,2.244468
04-23 16:02:17.051+0200 W/AUL     (23058): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:02:17.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:17.051+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:17.051+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23030
04-23 16:02:17.051+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:17.051+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23030
04-23 16:02:17.051+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23030)
04-23 16:02:17.061+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:17.061+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.151+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:02:17.151+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:02:17.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:17.161+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 23059
04-23 16:02:17.161+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:02:17.211+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23059
04-23 16:02:17.211+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(23059) type(svcapp) bg(0)
04-23 16:02:17.211+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23059]
04-23 16:02:17.221+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23059)
04-23 16:02:17.221+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:02:17.221+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:17.221+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:17.221+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:17.231+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:17:225,-2.170000,3.290000,1.190000
04-23 16:02:17.231+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:17:229,9.293723,-0.736989,2.282753
04-23 16:02:17.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:17.241+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23059
04-23 16:02:17.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:17.261+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:17.261+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:02:17.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23059
04-23 16:02:17.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:02:17.291+0200 E/CAPI_APPFW_APPLICATION(23059): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:17.291+0200 E/CAPI_APPFW_APPLICATION(23059): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:02:17.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (23059) was created
04-23 16:02:17.361+0200 W/LOCATION(23059): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:02:17.361+0200 E/LOCATION(23059): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:02:17.361+0200 E/PKGMGR_INFO(23059): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:02:17.361+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:17.391+0200 I/LOCATION(23059): location.c: location_new(269) > method: 0
04-23 16:02:17.401+0200 W/LOCATION(23059): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:17.411+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:17.421+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:17.421+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:17:425,-9.940000,-1.610000,0.420000
04-23 16:02:17.421+0200 I/accelerometer(22991): capturing data from es.ugr.frailty.accelerometer
04-23 16:02:17.421+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:02:17:429,9.516255,-0.720240,2.050649
04-23 16:02:17.431+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:17.441+0200 W/LOCATION(23059): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:17.441+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:17.441+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:02:17.441+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:02:17.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.451+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:17.461+0200 W/LOCATION(23059): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:17.461+0200 W/LOCATION(23059): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:17.461+0200 W/LOCATION(23059): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:17.461+0200 W/LOCATION(23059): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:17.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22991
04-23 16:02:17.461+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.461+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22991), cmd(0)
04-23 16:02:17.461+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:17.461+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.461+0200 I/accelerometer(22991): stopping es.ugr.frailty.accelerometer service
04-23 16:02:17.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22991)
04-23 16:02:17.461+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:02:17.461+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:17.461+0200 W/AUL     (22991): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:17.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.471+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22991
04-23 16:02:17.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:17.481+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:17.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:17.481+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.481+0200 I/utils   (19708): specific action
04-23 16:02:17.481+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:17.481+0200 W/AUL     (22991): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:17.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.481+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:02:17.481+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:17.491+0200 W/LOCATION(23059): module-internal.c: module_new(311) > module (wps) open success
04-23 16:02:17.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:17.491+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.491+0200 I/utils   (22624): specific action
04-23 16:02:17.491+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.491+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:02:17.491+0200 I/recorder(22624): guardando datos en local
04-23 16:02:17.491+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:17.501+0200 I/accelerometer(22991): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:17.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:17.501+0200 I/CAPI_APPFW_APPLICATION(22991): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:17.501+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:17.501+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:17.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:17.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:17.511+0200 W/LOCATION(23059): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:02:17.511+0200 W/LOCATION(23059): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:02:17.511+0200 W/LOCATION(23059): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:17.511+0200 W/LOCATION(23059): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:17.561+0200 W/LOCATION(23059): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:02:17.561+0200 I/LOCATION(23059): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77eec18
04-23 16:02:17.561+0200 I/LOCATION(23059): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:02:17.561+0200 I/LOCATION(23059): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77eec18
04-23 16:02:17.561+0200 I/LOCATION(23059): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:02:17.561+0200 I/location(23059): es.ugr.frailty.location: creado servicio de localización
04-23 16:02:17.571+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:17.581+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:17.611+0200 I/gyroscope(23004): capturing data from es.ugr.frailty.gyroscope
04-23 16:02:17.611+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:02:17:620,11.200000,-0.910000,0.070000
04-23 16:02:17.621+0200 I/accelerometer(22991): es.ugr.frailty.accelerometer listener destroyed
04-23 16:02:17.641+0200 I/LOCATION(23059): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:02:17.661+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:17.671+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.691+0200 W/LOCATION(23059): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:17.691+0200 W/LOCATION(23059): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:17.691+0200 I/LOCATION(23059): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:02:17.691+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:02:17.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:02:17.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:17.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 23004
04-23 16:02:17.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(23004), cmd(0)
04-23 16:02:17.711+0200 I/gyroscope(23004): stopping es.ugr.frailty.gyroscope service
04-23 16:02:17.711+0200 W/AUL     (23004): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:02:17.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23004)
04-23 16:02:17.711+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:02:17.711+0200 I/servicemanager(19708): App control destroyed.
04-23 16:02:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 23004
04-23 16:02:17.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:02:17.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:02:17.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.721+0200 W/AUL     (23004): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:02:17.721+0200 I/gyroscope(23004): request sent to service es.ugr.frailty.servicemanager
04-23 16:02:17.731+0200 I/CAPI_APPFW_APPLICATION(23004): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:02:17.731+0200 I/utils   (19708): specific action
04-23 16:02:17.731+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.731+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:02:17.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:02:17.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:02:17.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:02:17.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:02:17.751+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:02:17.751+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:02:17.751+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:02:17.751+0200 I/servicemanager(19708): requesting to save local data
04-23 16:02:17.761+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.761+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:02:17.761+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:02:17.761+0200 I/utils   (22624): specific action
04-23 16:02:17.761+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.761+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:02:17.761+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:02:17.761+0200 I/recorder(22624): guardando datos en local
04-23 16:02:17.771+0200 W/AUL     (23064): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:02:17.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:17.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:17.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22991
04-23 16:02:17.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:17.771+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22991
04-23 16:02:17.771+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22991)
04-23 16:02:17.841+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:02:17.841+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:02:17.841+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:17.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:02:17.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:02:17.851+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:02:17.851+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:02:17.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:02:17.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:02:17.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:02:17.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:02:17.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:02:17.851+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:02:17.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:02:17.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:02:17.861+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:17.861+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:17.871+0200 I/gyroscope(23004): es.ugr.frailty.gyroscope listener destroyed
04-23 16:02:17.911+0200 W/LOCATION(23059): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:02:17.911+0200 W/LOCATION(23059): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:02:18.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:18.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e192d8]
04-23 16:02:18.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:02:18.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:02:18.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:02:18.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:02:18.061+0200 W/AUL     (23067): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:02:18.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:02:18.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:02:18.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23004
04-23 16:02:18.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:02:18.071+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23004
04-23 16:02:18.071+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23004)
04-23 16:02:18.071+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:18.071+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:18.071+0200 I/heartrate(23016): capturing data from es.ugr.frailty.heartrate
04-23 16:02:18.071+0200 I/heartrate(23016): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:02:18.081+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:18.091+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:18.091+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:02:18.091+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:02:18.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:02:18.091+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:02:18.091+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:02:18.091+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:02:18.091+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:02:18.091+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:02:18.091+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:02:18.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:18.101+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:02:18.101+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:02:18.111+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:18.111+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:02:18.111+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6033778), time2(6029254)
04-23 16:02:18.111+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:02:18.111+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:02:18.111+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:02:18.111+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:02:18.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:02:18.161+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:02:18.201+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11230306c6f63152449213
