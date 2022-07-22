S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 2615
Date: 2018-04-23 18:10:40+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf755252d, r5   = 0xf76e3958
r6   = 0xffb0bfd8, r7   = 0xffb0be88
r8   = 0xf76f6c18, r9   = 0x00000000
r10  = 0xffb0bf64, fp   = 0xffb0bfd8
ip   = 0x00000001, sp   = 0xffb0be60
lr   = 0xf7552539, pc   = 0xf75bb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9968 KB
Buffers:     68460 KB
Cached:     218340 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11736 KB
VmRSS:       11732 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2615 TID = 2615
2615 2644 

Maps Information
f441d000 f4c1c000 rw-p [stack:2644]
f4c23000 f4c25000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c2d000 f4c31000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c3a000 f4c3c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c44000 f4c47000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c56000 f4c5b000 r-xp /usr/lib/libsystem.so.0.0.0
f4c66000 f4c69000 r-xp /lib/libattr.so.1.1.0
f4c71000 f4c81000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c89000 f4c92000 r-xp /usr/lib/libedbus.so.1.7.99
f4c9a000 f4c9b000 r-xp /usr/lib/libresponse.so.0.2.96
f4ca4000 f4ca9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f654b000 f6651000 r-xp /usr/lib/libicuuc.so.57.1
f6667000 f67ef000 r-xp /usr/lib/libicui18n.so.57.1
f67ff000 f680c000 r-xp /usr/lib/libail.so.0.1.0
f6815000 f681c000 r-xp /usr/lib/libminizip.so.1.0.0
f6825000 f69ce000 r-xp /usr/lib/libcrypto.so.1.0.0
f69ee000 f6a35000 r-xp /usr/lib/libssl.so.1.0.0
f6a41000 f6a43000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a4b000 f6a52000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a5b000 f6a62000 r-xp /lib/libcrypt-2.13.so
f6a93000 f6a96000 r-xp /lib/libcap.so.2.21
f6a9e000 f6aa0000 r-xp /usr/lib/libiri.so
f6aa8000 f6af1000 r-xp /usr/lib/libmdm.so.1.2.69
f6af9000 f6aff000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b07000 f6b2a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b34000 f6b36000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b3e000 f6b5b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b64000 f6b68000 r-xp /usr/lib/libsmack.so.1.0.0
f6b71000 f6b8a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b93000 f6b9b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ba3000 f6ba9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bb2000 f6bb4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bbd000 f6bcd000 r-xp /lib/libresolv-2.13.so
f6bd1000 f6be9000 r-xp /usr/lib/liblzma.so.5.0.3
f6bf2000 f6bf4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bfc000 f6c16000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c1e000 f6c4d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c56000 f6c65000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c6f000 f6c79000 r-xp /usr/lib/libsensord-shared.so
f6c82000 f6d55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d60000 f6d76000 r-xp /lib/libz.so.1.2.5
f6d7e000 f6d83000 r-xp /usr/lib/libffi.so.5.0.10
f6d8b000 f6d8c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d94000 f6da4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dac000 f6dc5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6dcd000 f6dcf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dd7000 f6e4c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e56000 f6e5c000 r-xp /lib/librt-2.13.so
f6e65000 f6e83000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e8d000 f6e8e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e96000 f6eb9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ec1000 f6ec6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ece000 f6ef8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f01000 f6f18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f20000 f6f89000 r-xp /lib/libm-2.13.so
f6f92000 f7026000 r-xp /usr/lib/libstdc++.so.6.0.16
f7039000 f703e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7046000 f704d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7055000 f707f000 r-xp /usr/lib/libsensor.so.1.9.6
f7088000 f7154000 r-xp /usr/lib/libxml2.so.2.7.8
f7161000 f7163000 r-xp /usr/lib/libiniparser.so.0
f716c000 f7172000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f717b000 f724b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f724c000 f7280000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7289000 f72c5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72cd000 f72d0000 r-xp /usr/lib/libbundle.so.0.1.22
f72d8000 f72de000 r-xp /usr/lib/libappsvc.so.0.1.0
f72e6000 f7327000 r-xp /usr/lib/libeina.so.1.7.99
f7330000 f7347000 r-xp /usr/lib/libecore.so.1.7.99
f735e000 f7367000 r-xp /usr/lib/libvconf.so.0.2.45
f736f000 f7383000 r-xp /lib/libpthread-2.13.so
f738e000 f739b000 r-xp /usr/lib/libaul.so.0.1.0
f73a5000 f73a7000 r-xp /lib/libdl-2.13.so
f73b0000 f73bb000 r-xp /lib/libunwind.so.8.0.1
f73e8000 f73f0000 r-xp /lib/libgcc_s-4.6.so.1
f73f1000 f7515000 r-xp /lib/libc-2.13.so
f7523000 f7525000 r-xp /usr/lib/libdlog.so.0.0.0
f752d000 f7539000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7542000 f7547000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f754f000 f755e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7566000 f756a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7573000 f7576000 r-xp /usr/lib/libappcore-agent.so.1.1
f757e000 f7580000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7588000 f758c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7594000 f75b1000 r-xp /lib/ld-2.13.so
f75ba000 f75bd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75bd000 f75c1000 r-xp /usr/lib/libsys-assert.so
f76c6000 f7737000 rw-p [heap]
ffaed000 ffb0e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2615)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75bb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7552539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72593f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7257c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7263e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7269be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7269dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf729e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72991f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7257c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7263e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7269be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7269dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf729be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf729c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72a08d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf758a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4c2e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d01663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71aefcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71b07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7340ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf733bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf733c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf733c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7574183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75747fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75bb4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf740885c) [/lib/libc.so.6] + 0x1785c
29: (0xf75baf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
3 18:10:39.081+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:10:39.091+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:39.091+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:39.101+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.101+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.101+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:105,0.140000,0.350000,-0.070000
04-23 18:10:39.121+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.121+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:10:39.121+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:10:39.121+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:10:39.121+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:10:39.121+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:10:39.121+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:10:39.121+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:10:39.121+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:10:39.121+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:10:39.131+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.141+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.141+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:10:39.141+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:39.191+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:10:39.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:39.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:39.271+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:39.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:39.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 18:10:39.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:10:39.391+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:39.391+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:10:39.401+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:39.401+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:39.401+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.421+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:39.421+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:10:39.421+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:10:39.421+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:39.471+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.471+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:479,-0.140000,0.630000,0.070000
04-23 18:10:39.471+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.481+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:483,0.070000,0.560000,0.280000
04-23 18:10:39.481+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.491+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:491,0.070000,0.980000,0.210000
04-23 18:10:39.491+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.491+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:498,0.420000,0.630000,0.210000
04-23 18:10:39.491+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.501+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:502,0.420000,0.280000,0.210000
04-23 18:10:39.501+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.501+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:506,-0.280000,-0.280000,-0.070000
04-23 18:10:39.501+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.511+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:510,0.070000,-0.140000,-0.140000
04-23 18:10:39.511+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.511+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:516,-0.210000,0.350000,-0.420000
04-23 18:10:39.521+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:89,2.086541,-0.631705,9.590433
04-23 18:10:39.531+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.531+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:535,0.910000,0.560000,-0.420000
04-23 18:10:39.531+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.531+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:39:275,72
04-23 18:10:39.531+0200 W/LOCATION( 2615): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:10:39.531+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:39.531+0200 I/LOCATION( 2615): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:39.531+0200 I/LOCATION( 2615): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:10:39.541+0200 I/location( 2615): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:10:39.551+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:540,2.105684,-0.748954,9.645468
04-23 18:10:39.551+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.561+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:39:543,73
04-23 18:10:39.561+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.561+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:568,2.115255,-0.655633,9.592826
04-23 18:10:39.561+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:561,0.560000,0.350000,-0.350000
04-23 18:10:39.571+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.571+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:580,0.350000,-0.070000,-0.280000
04-23 18:10:39.581+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.581+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.591+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:594,0.630000,-0.490000,-0.210000
04-23 18:10:39.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:39.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:39.591+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:584,2.065006,-0.713061,9.643075
04-23 18:10:39.591+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.601+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:602,2.062613,-0.634098,9.592826
04-23 18:10:39.601+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.611+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.611+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:610,2.057827,-0.643669,9.602397
04-23 18:10:39.621+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:615,-0.420000,-0.490000,-0.280000
04-23 18:10:39.621+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.631+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.631+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:39.631+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:39:640,73
04-23 18:10:39.641+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:631,2.081756,-0.686740,9.705289
04-23 18:10:39.651+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:636,-0.560000,-0.630000,-0.140000
04-23 18:10:39.651+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.651+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:659,0.490000,-0.140000,-0.210000
04-23 18:10:39.661+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.661+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.671+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:674,0.700000,-0.140000,-0.140000
04-23 18:10:39.671+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:665,2.129612,-0.679562,9.647861
04-23 18:10:39.671+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.691+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:681,2.115255,-0.698704,9.592826
04-23 18:10:39.691+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.691+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:694,0.490000,0.280000,0.070000
04-23 18:10:39.691+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.701+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:701,2.033899,-0.717847,9.650253
04-23 18:10:39.711+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.711+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.721+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:723,2.065006,-0.617348,9.609575
04-23 18:10:39.721+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:715,-0.700000,0.630000,0.490000
04-23 18:10:39.731+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.731+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.731+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:735,-1.050000,0.490000,0.630000
04-23 18:10:39.751+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.761+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:762,-0.490000,0.980000,0.630000
04-23 18:10:39.791+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.791+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:795,-0.140000,0.560000,0.350000
04-23 18:10:39.791+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:39.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:39.791+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:799,0.280000,0.420000,-0.070000
04-23 18:10:39.801+0200 I/LOCATION( 2615): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:39.801+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:736,2.115255,-0.629312,9.614362
04-23 18:10:39.801+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.811+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.821+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:815,-0.070000,0.420000,-0.070000
04-23 18:10:39.821+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:822,2.048256,-0.600598,9.671788
04-23 18:10:39.821+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.821+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.831+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:834,-0.630000,-0.210000,0.140000
04-23 18:10:39.831+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:39.831+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:39:840,73
04-23 18:10:39.841+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:829,2.132005,-0.602991,9.611969
04-23 18:10:39.841+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.851+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.851+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:858,-0.280000,0.070000,0.210000
04-23 18:10:39.861+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:850,2.115255,-0.624527,9.600004
04-23 18:10:39.861+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.861+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.871+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:874,-0.560000,0.140000,-0.140000
04-23 18:10:39.871+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:866,2.053042,-0.681954,9.628718
04-23 18:10:39.871+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.871+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:880,2.122434,-0.729811,9.588040
04-23 18:10:39.881+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.891+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:893,0.070000,0.210000,-0.700000
04-23 18:10:39.891+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.891+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:898,2.105684,-0.669990,9.607183
04-23 18:10:39.901+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.911+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.911+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:915,1.400000,-0.210000,-1.050000
04-23 18:10:39.911+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:905,2.091327,-0.641276,9.592826
04-23 18:10:39.921+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.921+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.931+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:934,1.540000,-0.700000,-0.910000
04-23 18:10:39.931+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:926,2.086541,-0.576670,9.583255
04-23 18:10:39.931+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.941+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:944,2.110470,-0.643669,9.571291
04-23 18:10:39.951+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.951+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:958,2.380000,-1.330000,-0.980000
04-23 18:10:39.951+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.961+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.971+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:973,4.200000,-0.980000,-1.470000
04-23 18:10:39.971+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:964,2.134398,-0.617348,9.566505
04-23 18:10:39.971+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.971+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:979,2.076970,-0.677169,9.681360
04-23 18:10:39.981+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:39.991+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:39:993,5.390000,-0.210000,-1.890000
04-23 18:10:39.991+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:39.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:39.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:39.991+0200 E/location( 2615): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:10:40.001+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:39:998,2.067399,-0.646062,9.619147
04-23 18:10:40.001+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.001+0200 W/AUL     ( 2615): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:10:40.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:40.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2615
04-23 18:10:40.001+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:6,2.033899,-0.583849,9.571291
04-23 18:10:40.001+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2259
04-23 18:10:40.001+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:40.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2259), cmd(0)
04-23 18:10:40.011+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:14,7.000000,-0.980000,-2.240000
04-23 18:10:40.011+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.011+0200 I/utils   ( 2259): specific action
04-23 18:10:40.011+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.011+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.011+0200 W/CAPI_APPFW_APP_CONTROL( 2259): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.011+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:10:40.021+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:11,2.081756,-0.662812,9.573684
04-23 18:10:40.021+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.021+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:26,2.155933,-0.725025,9.626326
04-23 18:10:40.021+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.021+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.031+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:33,7.910000,-2.170000,-2.520000
04-23 18:10:40.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:40.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2259
04-23 18:10:40.031+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:40.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2264
04-23 18:10:40.041+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:40:40,73
04-23 18:10:40.041+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:31,2.120041,-0.708275,9.597611
04-23 18:10:40.041+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.041+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:47,2.076970,-0.655633,9.607183
04-23 18:10:40.041+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:10:40.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(2264), cmd(0)
04-23 18:10:40.051+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.051+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:57,8.820000,-3.500000,-2.450000
04-23 18:10:40.061+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:51,2.072184,-0.634098,9.578469
04-23 18:10:40.061+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.061+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.061+0200 I/utils   ( 2264): specific action
04-23 18:10:40.061+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.061+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.061+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.061+0200 W/CAPI_APPFW_APP_CONTROL( 2264): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.061+0200 I/recorder( 2264): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:10:40.061+0200 I/recorder( 2264): guardando datos en local
04-23 18:10:40.061+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:66,2.072184,-0.629312,9.609575
04-23 18:10:40.061+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.061+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.071+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2264)
04-23 18:10:40.071+0200 I/servicemanager( 2259): request sent to service es.ugr.frailty.recorder
04-23 18:10:40.071+0200 I/servicemanager( 2259): requesting to save local data
04-23 18:10:40.071+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:73,10.080000,-3.710000,-2.660000
04-23 18:10:40.071+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:71,2.122434,-0.765703,9.633504
04-23 18:10:40.071+0200 W/AUL     ( 2615): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2259)
04-23 18:10:40.071+0200 I/location( 2615): request sent to service es.ugr.frailty.servicemanager
04-23 18:10:40.071+0200 W/CAPI_APPFW_APP_CONTROL( 2615): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:10:40.071+0200 I/utils   ( 2615): specific action
04-23 18:10:40.081+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.081+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.091+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:93,8.260000,-3.430000,-3.220000
04-23 18:10:40.091+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:89,2.196611,-0.739382,9.662218
04-23 18:10:40.101+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.101+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:105,2.132005,-0.708275,9.621540
04-23 18:10:40.111+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.121+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:115,5.250000,-4.690000,-2.380000
04-23 18:10:40.131+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.131+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.141+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:136,4.550000,-2.590000,-1.680000
04-23 18:10:40.181+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.191+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:142,2.069792,-0.602991,9.633504
04-23 18:10:40.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:40.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:40.191+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.191+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:193,1.400000,-2.380000,-0.700000
04-23 18:10:40.211+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.211+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:202,2.060220,-0.612563,9.712467
04-23 18:10:40.221+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.221+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:215,-2.380000,-2.100000,0.350000
04-23 18:10:40.231+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:40.231+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:40:240,73
04-23 18:10:40.241+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.251+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:250,-1.260000,-1.470000,1.190000
04-23 18:10:40.251+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:225,2.091327,-0.614955,9.786645
04-23 18:10:40.251+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.261+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.291+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:264,2.103291,-0.543171,9.702895
04-23 18:10:40.291+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.291+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:270,-1.330000,-1.050000,3.780000
04-23 18:10:40.301+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.321+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:301,2.017149,-0.401994,9.480364
04-23 18:10:40.321+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.331+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:306,-4.550000,-2.660000,5.530000
04-23 18:10:40.331+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.331+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:330,2.158326,-0.330210,9.549755
04-23 18:10:40.341+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.341+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:337,-5.600000,-2.940000,7.700000
04-23 18:10:40.351+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.361+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:350,2.184647,-0.279960,9.473185
04-23 18:10:40.361+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:10:40.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 18:10:40.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:10:40.371+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:10:40.371+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:364,-8.120000,-0.630000,8.190000
04-23 18:10:40.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:40.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:40.401+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:40.411+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:10:40.411+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:10:40.411+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:10:40.411+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:40.421+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.421+0200 I/LOCATION( 2615): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:10:40.441+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:40.461+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:40:445,74
04-23 18:10:40.471+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:10:40.481+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:374,2.273181,-0.191426,9.501899
04-23 18:10:40.481+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.491+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:494,2.400001,-0.177069,9.487542
04-23 18:10:40.491+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.491+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:498,2.373680,-0.090927,9.635897
04-23 18:10:40.491+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.501+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:503,2.318645,-0.057428,9.712467
04-23 18:10:40.501+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.501+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:507,2.313859,-0.239282,9.772287
04-23 18:10:40.501+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.511+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:511,2.258825,-0.270389,9.518648
04-23 18:10:40.511+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.511+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:517,2.234896,-0.342174,9.320045
04-23 18:10:40.521+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.521+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:525,2.354537,-0.454636,9.293723
04-23 18:10:40.521+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.521+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:529,2.337788,-0.614955,9.389436
04-23 18:10:40.531+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.531+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:535,2.246860,-0.997807,9.568897
04-23 18:10:40.531+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.531+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:539,2.234896,-0.748954,9.789038
04-23 18:10:40.531+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.541+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:543,2.088934,-0.983450,9.394222
04-23 18:10:40.541+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.541+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:547,2.222932,-0.892523,9.602397
04-23 18:10:40.541+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.561+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:552,2.048256,-1.658226,10.121639
04-23 18:10:40.561+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.561+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:566,2.366502,-0.492921,9.781858
04-23 18:10:40.561+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.571+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:572,2.280360,0.741775,10.291530
04-23 18:10:40.571+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.571+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:578,2.014757,0.468993,10.095319
04-23 18:10:40.571+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.581+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:582,2.158326,-0.157926,9.614362
04-23 18:10:40.591+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:40.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:40.591+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:428,-11.270000,1.400000,8.540000
04-23 18:10:40.591+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.601+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:604,-14.350000,3.570000,6.930000
04-23 18:10:40.601+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:597,2.203789,-0.748954,9.628718
04-23 18:10:40.611+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.611+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:615,2.081756,-1.016950,9.343972
04-23 18:10:40.611+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.621+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.631+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:623,-12.180000,2.940000,5.390000
04-23 18:10:40.631+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:40.631+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:40:641,74
04-23 18:10:40.641+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.641+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:629,2.220540,-1.174876,9.123833
04-23 18:10:40.641+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.661+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:646,-0.140000,3.150000,5.180000
04-23 18:10:40.661+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.661+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:651,2.371287,-0.897308,9.317651
04-23 18:10:40.661+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.671+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:666,-1.820000,3.500000,4.200000
04-23 18:10:40.671+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.681+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:670,2.323431,-1.098306,9.391829
04-23 18:10:40.681+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.681+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:677,-3.570000,1.820000,2.660000
04-23 18:10:40.681+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.691+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:690,2.390430,-1.564906,9.233903
04-23 18:10:40.691+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:694,-5.740000,4.200000,3.780000
04-23 18:10:40.691+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.701+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.701+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:708,7.560000,-2.240000,3.920000
04-23 18:10:40.711+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:702,2.478964,-2.057827,8.913264
04-23 18:10:40.711+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.721+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.731+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:724,2.467000,-2.476572,9.183653
04-23 18:10:40.731+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:729,6.580000,-2.800000,7.560000
04-23 18:10:40.731+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.741+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.751+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:738,2.593820,-2.335395,9.288938
04-23 18:10:40.751+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:747,-16.940001,-8.400000,11.270000
04-23 18:10:40.751+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.761+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.761+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:762,2.483750,-1.847259,9.635897
04-23 18:10:40.771+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.771+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:766,-32.480000,-12.110000,15.960000
04-23 18:10:40.771+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:40.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:40.831+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:40.891+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:40:841,74
04-23 18:10:40.891+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:775,2.481357,-1.933401,9.671788
04-23 18:10:40.901+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.901+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:783,-32.549999,-13.650000,18.129999
04-23 18:10:40.901+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.911+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:903,2.481357,-2.256432,9.602397
04-23 18:10:40.911+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.921+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:911,-15.610000,-13.230000,16.799999
04-23 18:10:40.921+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.931+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:924,2.467000,-1.856830,9.724431
04-23 18:10:40.931+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.941+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:932,-9.730000,-8.750000,17.639999
04-23 18:10:40.941+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.941+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:941,2.457429,-1.320838,9.568897
04-23 18:10:40.951+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:950,-16.940001,-4.970000,16.450001
04-23 18:10:40.951+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.971+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.971+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:964,2.423929,-1.304088,9.463614
04-23 18:10:40.971+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:975,-35.490002,-3.080000,15.610000
04-23 18:10:40.981+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.981+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:40.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 18:10:40.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 18:10:40.991+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:40:985,2.414358,-1.076770,9.504292
04-23 18:10:40.991+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:40.991+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:40:994,-45.080002,-3.290000,13.510000
04-23 18:10:41.001+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:2,2.313859,-1.036092,9.186047
04-23 18:10:41.001+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.011+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:13,-41.860001,-0.280000,10.710000
04-23 18:10:41.011+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.021+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:19,2.304288,-1.117448,9.377472
04-23 18:10:41.021+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.031+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.031+0200 I/heartrate( 2598): capturing data from es.ugr.frailty.heartrate
04-23 18:10:41.041+0200 I/heartrate( 2598): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:10:41:42,74
04-23 18:10:41.041+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:25,-26.180000,0.840000,7.700000
04-23 18:10:41.041+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.041+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:35,2.380858,-0.959522,9.461221
04-23 18:10:41.051+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.051+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:50,-0.280000,3.920000,2.520000
04-23 18:10:41.061+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.091+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:61,2.349752,-1.019342,9.310472
04-23 18:10:41.091+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.091+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:69,9.240000,4.200000,0.210000
04-23 18:10:41.101+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.101+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:100,2.423929,-1.478764,9.638289
04-23 18:10:41.111+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.111+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:105,7.070000,1.470000,-2.310000
04-23 18:10:41.121+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.121+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:117,2.423929,-1.146162,9.454042
04-23 18:10:41.121+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:125,5.390000,0.210000,-2.590000
04-23 18:10:41.121+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.131+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.141+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:130,2.502892,-1.138984,9.528220
04-23 18:10:41.141+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.141+0200 I/servicemanager( 2259): es.ugr.frailty.location sleep timeout
04-23 18:10:41.141+0200 W/AUL     ( 2259): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 18:10:41.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:10:41.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 2259
04-23 18:10:41.151+0200 I/gyroscope( 2578): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:10:41:138,17.150000,-1.050000,-2.940000
04-23 18:10:41.161+0200 I/gyroscope( 2578): capturing data from es.ugr.frailty.gyroscope
04-23 18:10:41.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2615
04-23 18:10:41.161+0200 I/accelerometer( 2562): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:10:41:151,2.636890,-1.414158,9.410972
04-23 18:10:41.161+0200 I/accelerometer( 2562): capturing data from es.ugr.frailty.accelerometer
04-23 18:10:41.171+0200 W/CRASH_MANAGER( 2332): worker.c: worker_job(1205) > 11026156c6f63152449984
