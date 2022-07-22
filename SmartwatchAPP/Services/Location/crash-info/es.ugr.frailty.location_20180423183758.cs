S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8512
Date: 2018-04-23 18:37:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf724852d, r5   = 0xf7ad0f98
r6   = 0xffb6a690, r7   = 0xffb6a540
r8   = 0xf7acdc18, r9   = 0x00000000
r10  = 0xffb6a61c, fp   = 0xffb6a690
ip   = 0x00000001, sp   = 0xffb6a518
lr   = 0xf7248539, pc   = 0xf72b1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12720 KB
Buffers:     69316 KB
Cached:     216316 KB
VmPeak:      53460 KB
VmSize:      53416 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12024 KB
VmRSS:       12024 KB
VmData:      11144 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8512 TID = 8512
8512 8547 

Maps Information
f4113000 f4912000 rw-p [stack:8547]
f4919000 f491b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4923000 f4927000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4930000 f4932000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f493a000 f493d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f494c000 f4951000 r-xp /usr/lib/libsystem.so.0.0.0
f495c000 f495f000 r-xp /lib/libattr.so.1.1.0
f4967000 f4977000 r-xp /usr/lib/libmdm-common.so.1.1.24
f497f000 f4988000 r-xp /usr/lib/libedbus.so.1.7.99
f4990000 f4991000 r-xp /usr/lib/libresponse.so.0.2.96
f499a000 f499f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6241000 f6347000 r-xp /usr/lib/libicuuc.so.57.1
f635d000 f64e5000 r-xp /usr/lib/libicui18n.so.57.1
f64f5000 f6502000 r-xp /usr/lib/libail.so.0.1.0
f650b000 f6512000 r-xp /usr/lib/libminizip.so.1.0.0
f651b000 f66c4000 r-xp /usr/lib/libcrypto.so.1.0.0
f66e4000 f672b000 r-xp /usr/lib/libssl.so.1.0.0
f6737000 f6739000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6741000 f6748000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6751000 f6758000 r-xp /lib/libcrypt-2.13.so
f6789000 f678c000 r-xp /lib/libcap.so.2.21
f6794000 f6796000 r-xp /usr/lib/libiri.so
f679e000 f67e7000 r-xp /usr/lib/libmdm.so.1.2.69
f67ef000 f67f5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67fd000 f6820000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f682a000 f682c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6834000 f6851000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f685a000 f685e000 r-xp /usr/lib/libsmack.so.1.0.0
f6867000 f6880000 r-xp /usr/lib/libnetwork.so.0.0.0
f6889000 f6891000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6899000 f689f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68a8000 f68aa000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68b3000 f68c3000 r-xp /lib/libresolv-2.13.so
f68c7000 f68df000 r-xp /usr/lib/liblzma.so.5.0.3
f68e8000 f68ea000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68f2000 f690c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6914000 f6943000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f694c000 f695b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6965000 f696f000 r-xp /usr/lib/libsensord-shared.so
f6978000 f6a4b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a56000 f6a6c000 r-xp /lib/libz.so.1.2.5
f6a74000 f6a79000 r-xp /usr/lib/libffi.so.5.0.10
f6a81000 f6a82000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a8a000 f6a9a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6aa2000 f6abb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ac3000 f6ac5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6acd000 f6b42000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b4c000 f6b52000 r-xp /lib/librt-2.13.so
f6b5b000 f6b79000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b83000 f6b84000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b8c000 f6baf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bb7000 f6bbc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bc4000 f6bee000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bf7000 f6c0e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c16000 f6c7f000 r-xp /lib/libm-2.13.so
f6c88000 f6d1c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d2f000 f6d34000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d3c000 f6d43000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d4b000 f6d75000 r-xp /usr/lib/libsensor.so.1.9.6
f6d7e000 f6e4a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e57000 f6e59000 r-xp /usr/lib/libiniparser.so.0
f6e62000 f6e68000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e71000 f6f41000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f42000 f6f76000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f7f000 f6fbb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fc3000 f6fc6000 r-xp /usr/lib/libbundle.so.0.1.22
f6fce000 f6fd4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fdc000 f701d000 r-xp /usr/lib/libeina.so.1.7.99
f7026000 f703d000 r-xp /usr/lib/libecore.so.1.7.99
f7054000 f705d000 r-xp /usr/lib/libvconf.so.0.2.45
f7065000 f7079000 r-xp /lib/libpthread-2.13.so
f7084000 f7091000 r-xp /usr/lib/libaul.so.0.1.0
f709b000 f709d000 r-xp /lib/libdl-2.13.so
f70a6000 f70b1000 r-xp /lib/libunwind.so.8.0.1
f70de000 f70e6000 r-xp /lib/libgcc_s-4.6.so.1
f70e7000 f720b000 r-xp /lib/libc-2.13.so
f7219000 f721b000 r-xp /usr/lib/libdlog.so.0.0.0
f7223000 f722f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7238000 f723d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7245000 f7254000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f725c000 f7260000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7269000 f726c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7274000 f7276000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f727e000 f7282000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f728a000 f72a7000 r-xp /lib/ld-2.13.so
f72b0000 f72b3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72b3000 f72b7000 r-xp /usr/lib/libsys-assert.so
f7a9d000 f7b06000 rw-p [heap]
ffb4b000 ffb6c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8512)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72b1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7248539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f4f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f4dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f59e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f5fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f5fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f9475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f8f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f4dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f59e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f5fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f5fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f91e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f92017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f99f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49311fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4924171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69f7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ea4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ea67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7036ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7031b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70325a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7032879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf726a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf726a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72b14f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf70fe85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72b0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
0200 I/LOCATION( 8512): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:37:56.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:37:56.201+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:37:56.201+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:37:56.201+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:56.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:37:56.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:37:56.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:37:56.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:37:56.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:37:56.201+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:37:56.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:37:56.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:37:56.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:56.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:56.251+0200 W/LOCATION( 8512): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:37:56.251+0200 W/LOCATION( 8512): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:37:56.301+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:56.301+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:56:311,177.309998,115.360001,140.839996
04-23 18:37:56.311+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:56.311+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:56:315,7.185646,-2.909672,1.579263
04-23 18:37:56.341+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:56.371+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf1213e00]
04-23 18:37:56.371+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:37:56.371+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:37:56.371+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:37:56.371+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:37:56.381+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:37:56.381+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:37:56.391+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:56.401+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:56.401+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:37:56.401+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:37:56.401+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:37:56.401+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:37:56.401+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:37:56.401+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:37:56.401+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:37:56.401+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:37:56.401+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:37:56.401+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:56.411+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:56.411+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:37:56.411+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:56.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:56.431+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:56.431+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:37:56.431+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(15372092), time2(15362215)
04-23 18:37:56.431+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 18:37:56.431+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:37:56.431+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:37:56.431+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:37:56.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:56.491+0200 W/LOCATION( 8512): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:37:56.491+0200 I/LOCATION( 8512): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:37:56.491+0200 I/LOCATION( 8512): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:37:56.491+0200 I/location( 8512): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:37:56.501+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:56.501+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:56.511+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:56:512,5.000999,4.369294,8.851050
04-23 18:37:56.511+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:56:508,206.289993,146.580002,38.779999
04-23 18:37:56.591+0200 I/LOCATION( 8512): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:37:56.631+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:56.631+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:56.641+0200 E/location( 8512): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:37:56.641+0200 W/AUL     ( 8512): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:37:56.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:37:56.641+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8512
04-23 18:37:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8361
04-23 18:37:56.651+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.651+0200 I/utils   ( 8361): specific action
04-23 18:37:56.651+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.651+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.651+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.651+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:37:56.651+0200 W/AUL     ( 8512): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8361)
04-23 18:37:56.651+0200 I/location( 8512): request sent to service es.ugr.frailty.servicemanager
04-23 18:37:56.651+0200 W/CAPI_APPFW_APP_CONTROL( 8512): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.651+0200 I/utils   ( 8512): specific action
04-23 18:37:56.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:37:56.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:37:56.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8367
04-23 18:37:56.661+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.661+0200 I/utils   ( 8367): specific action
04-23 18:37:56.661+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.661+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.661+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.661+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8367)
04-23 18:37:56.661+0200 I/servicemanager( 8361): request sent to service es.ugr.frailty.recorder
04-23 18:37:56.661+0200 I/servicemanager( 8361): requesting to save local data
04-23 18:37:56.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:37:56.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8361), cmd(0)
04-23 18:37:56.661+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:56.661+0200 I/recorder( 8367): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:37:56.661+0200 I/recorder( 8367): guardando datos en local
04-23 18:37:56.661+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:37:56.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(8367), cmd(0)
04-23 18:37:56.701+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:56.701+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:56.701+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:56:710,3.493521,0.325424,10.559525
04-23 18:37:56.701+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:56:710,-10.010000,17.639999,23.170000
04-23 18:37:56.831+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:56.831+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:56.901+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:56.911+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:56.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:37:56.961+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:56.961+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:37:57.011+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:56:909,2.600998,-1.363909,9.236296
04-23 18:37:57.011+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:56:909,-31.500000,0.910000,17.150000
04-23 18:37:57.011+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.011+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.021+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:18,-16.520000,-2.170000,13.090000
04-23 18:37:57.021+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.021+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:18,2.782853,-1.347159,9.903893
04-23 18:37:57.021+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.031+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:31,-18.129999,-2.940000,10.850000
04-23 18:37:57.031+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.031+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:57.031+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:57.031+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:36,-12.320000,-3.850000,10.640000
04-23 18:37:57.031+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:33,2.565106,-1.624727,9.693325
04-23 18:37:57.031+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.041+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:41,2.553142,-1.895115,9.573684
04-23 18:37:57.041+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.041+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.051+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:53,2.522035,-1.732404,9.439686
04-23 18:37:57.051+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:53,-6.790000,-2.240000,8.260000
04-23 18:37:57.061+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.061+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.061+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:68,-9.590000,-4.760000,7.350000
04-23 18:37:57.061+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:68,2.445465,-1.830509,9.399008
04-23 18:37:57.081+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.081+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.091+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:89,-12.180000,-4.620000,5.110000
04-23 18:37:57.091+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:89,2.727818,-2.151148,9.174082
04-23 18:37:57.101+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.101+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.111+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:109,-21.000000,0.700000,3.290000
04-23 18:37:57.111+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:110,2.660819,-2.309074,8.566305
04-23 18:37:57.121+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.121+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.131+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:131,2.699104,-2.139183,9.253045
04-23 18:37:57.131+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:131,-16.450001,-2.170000,1.680000
04-23 18:37:57.141+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.141+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.151+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:154,2.811567,-2.014757,9.748360
04-23 18:37:57.151+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:154,-0.070000,1.330000,0.280000
04-23 18:37:57.161+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.161+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.161+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:168,2.670390,-1.945365,9.020942
04-23 18:37:57.171+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:168,2.730000,3.010000,0.140000
04-23 18:37:57.181+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.181+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.191+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:191,2.545963,-1.682154,9.272188
04-23 18:37:57.191+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:191,6.300000,1.400000,1.190000
04-23 18:37:57.201+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.201+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.211+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:209,-23.030001,4.830000,1.120000
04-23 18:37:57.211+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:211,2.541178,-1.696511,9.152546
04-23 18:37:57.221+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.221+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.221+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:228,-21.770000,-4.130000,1.680000
04-23 18:37:57.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:57.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:57.231+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:228,2.189433,-1.840081,9.750752
04-23 18:37:57.241+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.241+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.251+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:254,-3.570000,-3.990000,2.940000
04-23 18:37:57.251+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:254,2.478964,-1.658226,9.566505
04-23 18:37:57.261+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.261+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.271+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:268,11.970000,-8.400000,4.760000
04-23 18:37:57.271+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:268,2.574677,-1.658226,9.513863
04-23 18:37:57.291+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.291+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.321+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:300,2.651247,-1.660619,9.190832
04-23 18:37:57.321+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.331+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:330,2.636890,-1.969293,8.965906
04-23 18:37:57.331+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.341+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:342,2.730211,-2.388037,8.965906
04-23 18:37:57.351+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.351+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:295,11.900000,-9.450000,5.320000
04-23 18:37:57.351+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:356,2.732604,-2.622534,9.135797
04-23 18:37:57.351+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.361+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.371+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:364,0.490000,-7.560000,5.880000
04-23 18:37:57.371+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.371+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:369,2.727818,-2.266003,9.370294
04-23 18:37:57.381+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:378,-10.080000,-5.740000,5.180000
04-23 18:37:57.381+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.381+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.381+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:387,-9.800000,-2.240000,3.430000
04-23 18:37:57.391+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:389,2.612962,-1.873580,9.116654
04-23 18:37:57.391+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.391+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:396,-0.980000,-0.420000,1.750000
04-23 18:37:57.401+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.401+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.411+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:410,2.550749,-2.160719,9.207582
04-23 18:37:57.411+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:405,2.730000,0.910000,0.840000
04-23 18:37:57.421+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.421+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.421+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:429,2.569891,-2.045863,9.425328
04-23 18:37:57.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:57.431+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:57.431+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:426,2.030000,2.100000,-0.770000
04-23 18:37:57.431+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.441+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:442,-2.100000,2.310000,-1.190000
04-23 18:37:57.441+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.441+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.451+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:453,1.190000,-0.490000,-1.050000
04-23 18:37:57.451+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:453,2.572284,-2.084148,9.638289
04-23 18:37:57.461+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.461+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.461+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:469,4.830000,-2.940000,0.210000
04-23 18:37:57.471+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:469,2.780460,-1.835295,9.544970
04-23 18:37:57.481+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.481+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.491+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:489,2.706282,-1.758725,9.324830
04-23 18:37:57.491+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:37:57.491+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:488,5.390000,-3.920000,1.750000
04-23 18:37:57.501+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.501+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.501+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:509,2.790031,-1.883151,9.195618
04-23 18:37:57.501+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:509,3.640000,-2.240000,2.310000
04-23 18:37:57.521+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.521+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.531+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:529,2.651247,-2.019542,9.181261
04-23 18:37:57.531+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:529,1.540000,-2.590000,2.240000
04-23 18:37:57.541+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.541+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.551+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:554,-0.560000,-0.980000,1.470000
04-23 18:37:57.551+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:554,2.596212,-1.990828,9.248260
04-23 18:37:57.561+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.561+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.571+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:569,-2.450000,-0.280000,0.980000
04-23 18:37:57.571+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:568,2.636890,-2.017149,9.327222
04-23 18:37:57.581+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.581+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.591+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:590,-3.920000,0.980000,0.700000
04-23 18:37:57.591+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:590,2.723032,-2.117648,9.320045
04-23 18:37:57.601+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.601+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.611+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:610,-6.790000,1.960000,1.330000
04-23 18:37:57.611+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:610,2.617748,-1.907080,9.324830
04-23 18:37:57.621+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.621+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.631+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:57.631+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:57.631+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:629,-7.700000,1.400000,2.100000
04-23 18:37:57.631+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:629,2.526821,-1.875973,9.245867
04-23 18:37:57.641+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.641+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.651+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:654,-4.410000,0.910000,2.310000
04-23 18:37:57.651+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:654,2.620141,-2.007578,9.152546
04-23 18:37:57.661+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.661+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.671+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:670,2.579463,-2.191825,9.157332
04-23 18:37:57.671+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:669,-0.700000,1.260000,1.680000
04-23 18:37:57.681+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.681+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.691+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:690,2.629712,-2.165504,9.276974
04-23 18:37:57.691+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:690,2.170000,1.820000,0.210000
04-23 18:37:57.701+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.701+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.731+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:710,2.870000,1.680000,-0.840000
04-23 18:37:57.731+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:713,2.679961,-2.165504,9.245867
04-23 18:37:57.731+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.741+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:742,2.667997,-2.062613,9.286544
04-23 18:37:57.741+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.751+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:750,2.730000,2.380000,-1.400000
04-23 18:37:57.751+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.751+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.761+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:760,0.560000,4.270000,-2.100000
04-23 18:37:57.761+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.771+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:773,-1.120000,4.340000,-3.430000
04-23 18:37:57.781+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:761,2.636890,-1.995614,9.296116
04-23 18:37:57.781+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.791+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.791+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:790,-7.350000,4.690000,-4.620000
04-23 18:37:57.801+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.811+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:796,2.545963,-1.962115,9.178867
04-23 18:37:57.811+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.811+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:809,-16.170000,1.750000,-4.830000
04-23 18:37:57.821+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.831+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:818,2.634498,-1.938186,9.394222
04-23 18:37:57.831+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.831+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:838,2.706282,-2.244468,9.451650
04-23 18:37:57.841+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:831,-28.490000,1.610000,-4.970000
04-23 18:37:57.841+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.841+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.851+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:854,-39.270000,-0.210000,-5.950000
04-23 18:37:57.851+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:847,2.658426,-2.057827,9.521042
04-23 18:37:57.851+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.861+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:57.861+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:57.861+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.861+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:863,2.500499,-2.368894,9.276974
04-23 18:37:57.861+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.871+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:869,-36.470001,-2.800000,-5.950000
04-23 18:37:57.871+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:871,2.500499,-2.577070,9.107083
04-23 18:37:57.881+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.881+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.881+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:889,2.696711,-2.665605,9.095119
04-23 18:37:57.891+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:889,-25.690001,-1.820000,-5.180000
04-23 18:37:57.901+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.901+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.911+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:909,-7.840000,-0.770000,-4.270000
04-23 18:37:57.911+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:909,2.734996,-2.620141,9.114261
04-23 18:37:57.921+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.921+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.931+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:927,-5.950000,3.150000,-3.290000
04-23 18:37:57.951+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.951+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:37:57.951+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:57.951+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:37:57.961+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:955,-19.460001,2.030000,-2.170000
04-23 18:37:57.961+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.971+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:927,2.658426,-2.055435,9.135797
04-23 18:37:57.971+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.981+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:978,2.474179,-2.347359,9.095119
04-23 18:37:57.981+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:972,-28.770000,1.330000,-2.310000
04-23 18:37:57.981+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.981+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:57.981+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:987,2.579463,-2.775674,9.126225
04-23 18:37:57.981+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:57.991+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:57:991,-18.340000,2.450000,-2.800000
04-23 18:37:57.991+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:57:993,2.531606,-2.971886,9.171689
04-23 18:37:58.001+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.001+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.011+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:10,-5.390000,3.360000,-3.360000
04-23 18:37:58.011+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:10,2.560320,-2.890530,9.183653
04-23 18:37:58.021+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.021+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.021+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:29,2.555535,-2.799603,9.169296
04-23 18:37:58.031+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:29,-2.240000,3.360000,-3.710000
04-23 18:37:58.031+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:58.031+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:58.041+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.041+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.051+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:54,2.536392,-2.766103,9.016156
04-23 18:37:58.051+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:54,-3.220000,0.910000,-3.500000
04-23 18:37:58.061+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.061+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.071+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:71,2.632105,-3.180061,9.030513
04-23 18:37:58.071+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:71,-1.820000,1.050000,-3.780000
04-23 18:37:58.081+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.081+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.091+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:92,2.691926,-2.974278,9.080762
04-23 18:37:58.091+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:92,3.010000,3.220000,-4.760000
04-23 18:37:58.101+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.101+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.111+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:112,2.550749,-2.883351,9.176475
04-23 18:37:58.111+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:112,7.980000,3.640000,-6.020000
04-23 18:37:58.121+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.121+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.131+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:129,2.610569,-2.852244,9.207582
04-23 18:37:58.131+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:129,13.650000,2.100000,-6.650000
04-23 18:37:58.141+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.141+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.151+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:154,19.250000,1.680000,-6.230000
04-23 18:37:58.151+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:154,2.574677,-2.756532,9.054441
04-23 18:37:58.161+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.161+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.171+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:170,2.548356,-2.658426,9.214760
04-23 18:37:58.181+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:169,26.530001,0.350000,-5.810000
04-23 18:37:58.181+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.191+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:190,32.970001,3.710000,-5.390000
04-23 18:37:58.201+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.201+0200 W/LOCATION( 8512): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:37:58.211+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:212,2.761317,-2.388037,9.054441
04-23 18:37:58.211+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.221+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.221+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:220,2.526821,-2.301895,9.135797
04-23 18:37:58.221+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.231+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:58.231+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:58.231+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:230,2.610569,-2.141576,9.633504
04-23 18:37:58.241+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:225,34.790001,2.800000,-5.040000
04-23 18:37:58.241+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.241+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.251+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:247,38.220001,0.910000,-4.550000
04-23 18:37:58.251+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.251+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:254,2.574677,-1.940579,9.583255
04-23 18:37:58.261+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:258,39.340000,0.210000,-4.340000
04-23 18:37:58.261+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.261+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.271+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:270,34.299999,-2.240000,-3.710000
04-23 18:37:58.271+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:270,2.507678,-1.828116,9.482756
04-23 18:37:58.281+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.281+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.291+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:290,26.740000,-4.130000,-2.450000
04-23 18:37:58.291+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:290,2.488536,-1.696511,9.458827
04-23 18:37:58.301+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.311+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.311+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:310,15.610000,-2.450000,-2.100000
04-23 18:37:58.311+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:316,2.550749,-1.777867,9.389436
04-23 18:37:58.321+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.331+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.331+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:329,11.270000,-3.850000,-1.260000
04-23 18:37:58.331+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:335,2.481357,-1.840081,9.358330
04-23 18:37:58.341+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.341+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.351+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:354,2.600998,-1.710868,9.564112
04-23 18:37:58.351+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:354,12.390000,-3.360000,-0.910000
04-23 18:37:58.361+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.361+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.361+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:369,2.565106,-1.753939,9.387043
04-23 18:37:58.371+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:369,12.250000,-2.380000,-0.840000
04-23 18:37:58.381+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.381+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.381+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:389,2.627320,-1.670190,9.226725
04-23 18:37:58.381+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:389,11.130000,-2.030000,-0.910000
04-23 18:37:58.401+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.401+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.401+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:409,2.868994,-1.409373,9.087940
04-23 18:37:58.401+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:409,10.990000,0.420000,-0.910000
04-23 18:37:58.421+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.421+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.421+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:429,2.744568,-1.447658,9.013763
04-23 18:37:58.431+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:429,9.310000,3.710000,-0.490000
04-23 18:37:58.431+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:58.431+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:58.441+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.441+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.451+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:453,2.739782,-1.342373,9.389436
04-23 18:37:58.451+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:453,9.100000,4.970000,-0.210000
04-23 18:37:58.461+0200 I/accelerometer( 8482): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:58.461+0200 I/gyroscope( 8495): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:58.461+0200 I/accelerometer( 8482): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:58:471,2.636890,-1.435694,9.461221
04-23 18:37:58.471+0200 I/gyroscope( 8495): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:58:471,4.970000,4.900000,-0.070000
04-23 18:37:58.491+0200 W/CRASH_MANAGER( 8438): worker.c: worker_job(1205) > 11085126c6f63152450147
