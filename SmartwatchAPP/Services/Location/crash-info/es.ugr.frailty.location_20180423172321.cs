S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 30149
Date: 2018-04-23 17:23:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74fa52d, r5   = 0xf775ef98
r6   = 0xff9cb220, r7   = 0xff9cb0d0
r8   = 0xf775bc18, r9   = 0x00000000
r10  = 0xff9cb1ac, fp   = 0xff9cb220
ip   = 0x00000001, sp   = 0xff9c9f50
lr   = 0xf74fa539, pc   = 0xf75632b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8220 KB
Buffers:     66064 KB
Cached:     225700 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12100 KB
VmRSS:       12100 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 30149 TID = 30149
30149 30158 

Maps Information
f43c5000 f4bc4000 rw-p [stack:30158]
f4bcb000 f4bcd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bd5000 f4bd9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4be2000 f4be4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bec000 f4bef000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bfe000 f4c03000 r-xp /usr/lib/libsystem.so.0.0.0
f4c0e000 f4c11000 r-xp /lib/libattr.so.1.1.0
f4c19000 f4c29000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c31000 f4c3a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c42000 f4c43000 r-xp /usr/lib/libresponse.so.0.2.96
f4c4c000 f4c51000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64f3000 f65f9000 r-xp /usr/lib/libicuuc.so.57.1
f660f000 f6797000 r-xp /usr/lib/libicui18n.so.57.1
f67a7000 f67b4000 r-xp /usr/lib/libail.so.0.1.0
f67bd000 f67c4000 r-xp /usr/lib/libminizip.so.1.0.0
f67cd000 f6976000 r-xp /usr/lib/libcrypto.so.1.0.0
f6996000 f69dd000 r-xp /usr/lib/libssl.so.1.0.0
f69e9000 f69eb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69f3000 f69fa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a03000 f6a0a000 r-xp /lib/libcrypt-2.13.so
f6a3b000 f6a3e000 r-xp /lib/libcap.so.2.21
f6a46000 f6a48000 r-xp /usr/lib/libiri.so
f6a50000 f6a99000 r-xp /usr/lib/libmdm.so.1.2.69
f6aa1000 f6aa7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aaf000 f6ad2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6adc000 f6ade000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae6000 f6b03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b0c000 f6b10000 r-xp /usr/lib/libsmack.so.1.0.0
f6b19000 f6b32000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b3b000 f6b43000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b4b000 f6b51000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b5a000 f6b5c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b65000 f6b75000 r-xp /lib/libresolv-2.13.so
f6b79000 f6b91000 r-xp /usr/lib/liblzma.so.5.0.3
f6b9a000 f6b9c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ba4000 f6bbe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc6000 f6bf5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bfe000 f6c0d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c17000 f6c21000 r-xp /usr/lib/libsensord-shared.so
f6c2a000 f6cfd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d08000 f6d1e000 r-xp /lib/libz.so.1.2.5
f6d26000 f6d2b000 r-xp /usr/lib/libffi.so.5.0.10
f6d33000 f6d34000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d3c000 f6d4c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d54000 f6d6d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d75000 f6d77000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d7f000 f6df4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dfe000 f6e04000 r-xp /lib/librt-2.13.so
f6e0d000 f6e2b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e35000 f6e36000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e3e000 f6e61000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e69000 f6e6e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e76000 f6ea0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea9000 f6ec0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec8000 f6f31000 r-xp /lib/libm-2.13.so
f6f3a000 f6fce000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fe1000 f6fe6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fee000 f6ff5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ffd000 f7027000 r-xp /usr/lib/libsensor.so.1.9.6
f7030000 f70fc000 r-xp /usr/lib/libxml2.so.2.7.8
f7109000 f710b000 r-xp /usr/lib/libiniparser.so.0
f7114000 f711a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7123000 f71f3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71f4000 f7228000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7231000 f726d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7275000 f7278000 r-xp /usr/lib/libbundle.so.0.1.22
f7280000 f7286000 r-xp /usr/lib/libappsvc.so.0.1.0
f728e000 f72cf000 r-xp /usr/lib/libeina.so.1.7.99
f72d8000 f72ef000 r-xp /usr/lib/libecore.so.1.7.99
f7306000 f730f000 r-xp /usr/lib/libvconf.so.0.2.45
f7317000 f732b000 r-xp /lib/libpthread-2.13.so
f7336000 f7343000 r-xp /usr/lib/libaul.so.0.1.0
f734d000 f734f000 r-xp /lib/libdl-2.13.so
f7358000 f7363000 r-xp /lib/libunwind.so.8.0.1
f7390000 f7398000 r-xp /lib/libgcc_s-4.6.so.1
f7399000 f74bd000 r-xp /lib/libc-2.13.so
f74cb000 f74cd000 r-xp /usr/lib/libdlog.so.0.0.0
f74d5000 f74e1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74ea000 f74ef000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f7000 f7506000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f750e000 f7512000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f751b000 f751e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7526000 f7528000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7530000 f7534000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f753c000 f7559000 r-xp /lib/ld-2.13.so
f7562000 f7565000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7565000 f7569000 r-xp /usr/lib/libsys-assert.so
f772b000 f77b5000 rw-p [heap]
ff9ac000 ff9cd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30149)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf75632b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf74fa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72013f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf720be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7211be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7211dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72411f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71ffc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf720be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7211be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7211dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7243e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7244017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf724bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4be31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bd6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7156fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71587a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72e3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72e45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72e4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf751c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf751c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75636c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf73b085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7562fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:23:19.341+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:23:19.341+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:23:19.341+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:23:19.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:23:19.341+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:23:19.341+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:23:19.341+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:23:19.351+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:19.351+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:19.361+0200 W/LOCATION(30149): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:23:19.361+0200 W/LOCATION(30149): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:23:19.371+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:19.371+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:19.381+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:19:375,-24.080000,-0.770000,0.280000
04-23 17:23:19.381+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:19:375,9.712467,0.677169,1.045663
04-23 17:23:19.531+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:19.531+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:19.541+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:23:19.561+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:19.561+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:19.571+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:19:574,-0.630000,-0.770000,2.310000
04-23 17:23:19.581+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:19:574,9.769895,0.772882,1.071985
04-23 17:23:19.601+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_create(453) > New handle created[0xf748d980]
04-23 17:23:19.601+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:23:19.601+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:23:19.601+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:23:19.601+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:23:19.621+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.631+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.631+0200 E/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
04-23 17:23:19.631+0200 E/PKGMGR_INFO(30159): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:23:19.641+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 10895004 to 10895305) (logOverhead=0,0,0,0,0,0,0), start: 17:23:19.349
04-23 17:23:19.641+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 307 ms (from 10895001 to 10895308) (logOverhead=0,0,0,0,0,0,0), start: 17:23:19.346
04-23 17:23:19.641+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 307 ms (from 10895001 to 10895308) (logOverhead=0,0,0,0,0,0,0), start: 17:23:19.346
04-23 17:23:19.651+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:23:19.661+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.671+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.671+0200 E/LOCATION(30159): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:23:19.671+0200 I/LOCATION(30159): location.c: location_new(269) > method: 1
04-23 17:23:19.681+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:23:19.701+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (gps) open success
04-23 17:23:19.701+0200 W/LOCATION(30159): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:23:19.711+0200 W/LOCATION(30159): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:23:19.711+0200 W/LOCATION(30159): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:23:19.711+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:23:19.711+0200 W/LOCATION(30159): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:23:19.721+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.731+0200 I/AUL     (30159): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:23:19.731+0200 E/LOCATION(30159): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:23:19.731+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:19.731+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:19.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:23:19.741+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:23:19.761+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:19.771+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:19.771+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:19:779,9.812965,0.729811,1.146162
04-23 17:23:19.781+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:19:774,-13.020000,-1.190000,3.080000
04-23 17:23:19.791+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:23:19.821+0200 W/LOCATION(30149): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:23:19.821+0200 I/LOCATION(30149): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:23:19.821+0200 I/LOCATION(30149): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:23:19.821+0200 I/location(30149): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:23:19.911+0200 I/LOCATION(30149): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:23:19.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:23:19.921+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(10895586), time2(10762371)
04-23 17:23:19.921+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:23:19.921+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:23:19.921+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:23:19.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:23:19.931+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:19.931+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:19.961+0200 E/location(30149): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:23:19.961+0200 W/AUL     (30149): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:23:19.961+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:23:19.961+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30149
04-23 17:23:19.971+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:19.971+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30105
04-23 17:23:19.971+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:23:19.971+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30105), cmd(0)
04-23 17:23:19.981+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.981+0200 I/utils   (30105): specific action
04-23 17:23:19.981+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.981+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.981+0200 W/CAPI_APPFW_APP_CONTROL(30105): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.981+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:23:19.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:23:19.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 30105
04-23 17:23:19.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30110
04-23 17:23:19.991+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:23:19.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30110), cmd(0)
04-23 17:23:19.991+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:19.991+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.991+0200 I/utils   (30110): specific action
04-23 17:23:19.991+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.991+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.991+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.991+0200 W/CAPI_APPFW_APP_CONTROL(30110): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:19.991+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:0,9.702895,0.595813,0.892523
04-23 17:23:19.991+0200 W/AUL     (30105): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30110)
04-23 17:23:19.991+0200 I/servicemanager(30105): request sent to service es.ugr.frailty.recorder
04-23 17:23:19.991+0200 I/servicemanager(30105): requesting to save local data
04-23 17:23:20.001+0200 W/AUL     (30149): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30105)
04-23 17:23:20.001+0200 I/location(30149): request sent to service es.ugr.frailty.servicemanager
04-23 17:23:20.001+0200 W/CAPI_APPFW_APP_CONTROL(30149): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:23:20.001+0200 I/utils   (30149): specific action
04-23 17:23:20.001+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:19:979,-20.930000,-5.110000,11.690000
04-23 17:23:20.011+0200 I/recorder(30110): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:23:20.011+0200 I/recorder(30110): guardando datos en local
04-23 17:23:20.131+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:20.131+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:20.161+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.171+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.181+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:177,9.915856,-0.440279,0.327817
04-23 17:23:20.191+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:174,58.869999,14.770000,12.740000
04-23 17:23:20.341+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:20.351+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:20.361+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.361+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.381+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:373,-15.820000,6.440000,-7.910000
04-23 17:23:20.381+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:373,9.755538,-0.471386,2.093720
04-23 17:23:20.461+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 134 ms (from 10895987 to 10896121) (logOverhead=0,0,0,0,0,0,0), start: 17:23:20.333
04-23 17:23:20.461+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 135 ms (from 10895987 to 10896122) (logOverhead=0,0,0,0,0,0,0), start: 17:23:20.332
04-23 17:23:20.491+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:23:20.491+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:23:20.491+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:23:20.501+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.511+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:513,11.340000,-1.890000,-8.470000
04-23 17:23:20.521+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.521+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.531+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:532,9.801002,0.598206,1.294517
04-23 17:23:20.531+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:533,-1.820000,-3.290000,-6.930000
04-23 17:23:20.531+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:20.531+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:20.551+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.551+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.561+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:557,-6.580000,-3.710000,-5.250000
04-23 17:23:20.561+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:555,9.753145,0.114855,1.167697
04-23 17:23:20.561+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.561+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.571+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:573,9.779467,0.081356,1.359123
04-23 17:23:20.571+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:573,-0.490000,-2.870000,-5.670000
04-23 17:23:20.581+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.581+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.601+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:594,9.762716,0.279960,1.282553
04-23 17:23:20.621+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.641+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:594,4.970000,-2.660000,-5.110000
04-23 17:23:20.651+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:632,9.731609,0.435494,1.457229
04-23 17:23:20.661+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.661+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.661+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:665,6.090000,-2.170000,-4.130000
04-23 17:23:20.661+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:665,9.745967,0.332602,1.512264
04-23 17:23:20.661+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.661+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.671+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:671,9.734003,0.122034,1.459622
04-23 17:23:20.671+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.681+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:678,9.827322,0.210568,1.210768
04-23 17:23:20.681+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:671,4.060000,-2.240000,-2.870000
04-23 17:23:20.681+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.691+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.691+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:689,0.770000,-3.990000,-1.610000
04-23 17:23:20.691+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.691+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:695,9.750752,0.196211,1.258625
04-23 17:23:20.691+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:697,0.770000,-4.060000,-0.700000
04-23 17:23:20.691+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.711+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.721+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:715,9.741181,0.126820,1.354338
04-23 17:23:20.731+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.731+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:703,1.120000,-2.660000,-0.210000
04-23 17:23:20.731+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.731+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:735,9.693325,0.165105,1.387837
04-23 17:23:20.731+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:736,4.340000,-0.980000,0.140000
04-23 17:23:20.731+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:20.731+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:20.731+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.741+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:742,5.040000,-1.400000,-1.330000
04-23 17:23:20.751+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.751+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.751+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:755,9.726824,0.095713,1.390230
04-23 17:23:20.751+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:755,2.940000,-3.080000,-0.420000
04-23 17:23:20.771+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.771+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.771+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:775,9.750752,0.110070,1.160519
04-23 17:23:20.791+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:775,3.080000,-3.080000,-0.560000
04-23 17:23:20.791+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.791+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:799,9.877571,0.064606,0.878166
04-23 17:23:20.791+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.801+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:803,5.040000,0.070000,-1.680000
04-23 17:23:20.811+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.811+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:815,9.856036,0.227318,1.354338
04-23 17:23:20.811+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.811+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:820,7.210000,2.730000,-2.660000
04-23 17:23:20.821+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.831+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.831+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:838,4.200000,1.470000,-2.730000
04-23 17:23:20.831+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:834,9.530612,0.203390,1.497907
04-23 17:23:20.841+0200 E/CAPI_TELEPHONY(30159): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:23:20.851+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.851+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.851+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:856,9.793823,0.145962,1.469193
04-23 17:23:20.851+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:856,2.100000,-3.430000,-0.910000
04-23 17:23:20.871+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.871+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.871+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:875,9.810574,0.236889,1.277767
04-23 17:23:20.871+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:875,3.010000,-1.750000,-2.450000
04-23 17:23:20.881+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.881+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.891+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:894,2.380000,-0.420000,-2.030000
04-23 17:23:20.891+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:894,9.726824,0.217747,1.071985
04-23 17:23:20.911+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.911+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.911+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:915,3.150000,1.610000,-1.820000
04-23 17:23:20.911+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:915,9.769895,0.184247,1.251446
04-23 17:23:20.931+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.931+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.931+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:20.931+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:20.941+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:937,9.678967,0.368495,1.328017
04-23 17:23:20.941+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:937,5.810000,1.260000,-1.960000
04-23 17:23:20.951+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.951+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.951+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:958,9.741181,0.370888,1.294517
04-23 17:23:20.961+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:958,3.010000,-1.050000,-0.980000
04-23 17:23:20.971+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.971+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.971+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:975,2.800000,-0.630000,-0.420000
04-23 17:23:20.971+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:975,9.745967,0.169890,1.191626
04-23 17:23:20.991+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:20.991+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:20.991+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:20:995,9.865608,0.102891,0.990629
04-23 17:23:20.991+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:20:995,5.880000,0.560000,-0.280000
04-23 17:23:21.011+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.011+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:16,8.190000,2.100000,-0.490000
04-23 17:23:21.011+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.021+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:23,9.858429,0.265603,1.196411
04-23 17:23:21.031+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.031+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.031+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:35,3.010000,2.800000,-1.260000
04-23 17:23:21.031+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:36,9.662218,0.334995,1.421337
04-23 17:23:21.051+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.051+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.061+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:59,-2.170000,-0.490000,-0.630000
04-23 17:23:21.061+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:60,9.631111,0.196211,1.263410
04-23 17:23:21.071+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.071+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.071+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:75,-1.260000,-0.840000,-1.400000
04-23 17:23:21.071+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:75,9.793823,0.167498,1.397408
04-23 17:23:21.091+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.091+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.091+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:96,2.730000,-0.350000,-2.100000
04-23 17:23:21.111+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.111+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:116,2.030000,-1.330000,-2.870000
04-23 17:23:21.111+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:96,9.757930,0.133998,1.229911
04-23 17:23:21.121+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.121+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:126,9.750752,0.239282,1.337588
04-23 17:23:21.131+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.131+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:135,-2.030000,-1.960000,-3.920000
04-23 17:23:21.141+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.141+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:21.141+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:21.141+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:145,9.722038,0.198604,1.406980
04-23 17:23:21.151+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.161+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:157,-2.870000,-2.100000,-3.570000
04-23 17:23:21.161+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.161+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:166,9.810574,0.050249,1.036092
04-23 17:23:21.171+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.171+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:175,0.490000,-0.630000,-4.550000
04-23 17:23:21.171+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.181+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:181,9.870394,0.227318,1.138984
04-23 17:23:21.191+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.191+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.191+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:196,0.420000,-0.980000,-5.740000
04-23 17:23:21.201+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:202,9.748360,0.217747,1.186840
04-23 17:23:21.211+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.211+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:216,-1.610000,-1.890000,-6.090000
04-23 17:23:21.211+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.221+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:222,9.789038,0.368495,1.316052
04-23 17:23:21.231+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.231+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.231+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:235,-5.110000,-1.470000,-6.160000
04-23 17:23:21.241+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:241,9.647861,0.468993,1.232304
04-23 17:23:21.251+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.251+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.251+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:259,9.638289,0.425922,1.280160
04-23 17:23:21.251+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:259,-4.620000,-3.640000,-6.860000
04-23 17:23:21.261+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.261+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.271+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:274,-0.420000,-4.690000,-6.440000
04-23 17:23:21.271+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:274,9.822537,0.064606,0.909273
04-23 17:23:21.291+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.291+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.291+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:295,9.911072,0.095713,0.933201
04-23 17:23:21.291+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:295,6.860000,-0.280000,-8.190000
04-23 17:23:21.311+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.311+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.311+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:317,7.980000,1.680000,-9.660000
04-23 17:23:21.311+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:317,9.822537,0.600598,1.182054
04-23 17:23:21.331+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.341+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:336,1.890000,-1.050000,-6.860000
04-23 17:23:21.341+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:21.341+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:21.351+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:23:21.351+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:23:21.351+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:23:21.351+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.361+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.361+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:361,3.150000,0.630000,-7.000000
04-23 17:23:21.361+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:365,9.741181,0.636491,1.081556
04-23 17:23:21.361+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.371+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.371+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:374,9.772287,0.425922,1.167697
04-23 17:23:21.371+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.381+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:377,10.850000,0.980000,-8.470000
04-23 17:23:21.381+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:384,9.635897,0.665205,1.028914
04-23 17:23:21.391+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.391+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.391+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:396,9.772287,0.811167,1.270589
04-23 17:23:21.391+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:396,12.810000,-2.100000,-6.790000
04-23 17:23:21.411+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.411+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.421+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:420,9.674182,0.899701,1.488336
04-23 17:23:21.421+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:420,11.200000,-1.120000,-7.490000
04-23 17:23:21.431+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.431+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.431+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:435,9.688539,0.677169,0.844666
04-23 17:23:21.431+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:435,7.140000,-1.960000,-6.650000
04-23 17:23:21.451+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.451+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.461+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:457,8.750000,0.420000,-5.180000
04-23 17:23:21.461+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:457,9.817751,0.629312,1.239482
04-23 17:23:21.471+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.471+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.471+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:476,9.506684,0.744168,1.406980
04-23 17:23:21.471+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:476,16.799999,1.890000,-6.230000
04-23 17:23:21.491+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.491+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.501+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:496,16.450001,1.050000,-6.230000
04-23 17:23:21.501+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:496,9.707682,0.961915,1.129412
04-23 17:23:21.511+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.511+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.511+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:516,10.710000,-0.210000,-4.480000
04-23 17:23:21.511+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:516,9.650253,0.806381,1.052842
04-23 17:23:21.531+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.531+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:536,9.769895,0.540778,1.069592
04-23 17:23:21.541+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:21.541+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:21.541+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.541+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:547,10.920000,-1.540000,-5.390000
04-23 17:23:21.551+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.561+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.561+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:559,9.731609,1.019342,1.263410
04-23 17:23:21.561+0200 W/LOCATION(30149): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:23:21.571+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.571+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:577,9.710074,0.954736,1.182054
04-23 17:23:21.581+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:569,4.480000,-0.700000,-4.550000
04-23 17:23:21.591+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.591+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.601+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:597,-3.150000,-0.350000,-2.100000
04-23 17:23:21.611+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:600,9.779467,0.873380,1.060020
04-23 17:23:21.611+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.611+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.621+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:620,9.690931,1.028914,0.949951
04-23 17:23:21.621+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:622,0.350000,0.420000,-2.450000
04-23 17:23:21.631+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.631+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:636,9.767502,1.004985,1.012164
04-23 17:23:21.631+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.641+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:634,0.140000,0.350000,-3.710000
04-23 17:23:21.641+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.641+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:648,0.070000,-0.070000,-2.940000
04-23 17:23:21.651+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.651+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:658,9.700503,0.873380,1.473979
04-23 17:23:21.661+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.661+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:666,0.210000,-0.840000,-2.730000
04-23 17:23:21.671+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.671+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:675,9.523434,0.985843,1.452443
04-23 17:23:21.671+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.681+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:682,-4.410000,-1.820000,-3.010000
04-23 17:23:21.691+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.691+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.691+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:695,9.686146,1.138984,1.174876
04-23 17:23:21.701+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:701,-9.800000,-3.150000,-3.360000
04-23 17:23:21.711+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.711+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:716,9.844072,0.949951,0.507278
04-23 17:23:21.711+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.721+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:721,-16.100000,-1.540000,-2.800000
04-23 17:23:21.731+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.731+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:735,9.834501,0.689133,0.894916
04-23 17:23:21.731+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.731+0200 I/heartrate(30131): capturing data from es.ugr.frailty.heartrate
04-23 17:23:21.731+0200 I/heartrate(30131): es.ugr.frailty.heartrate: waiting for rigth values
04-23 17:23:21.741+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:740,-10.080000,2.100000,-2.170000
04-23 17:23:21.751+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.751+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:757,9.671788,0.806381,1.363909
04-23 17:23:21.751+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.761+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:762,-4.830000,2.170000,-2.590000
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:23:21.801+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:23:21.801+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:23:21.801+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:23:21.801+0200 E/CAPI_LOCATION_MANAGER(30159): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:23:21.811+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:23:21.831+0200 W/AUL     (30170): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:23:21.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:23:21.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:23:21.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29880
04-23 17:23:21.831+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:23:21.831+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29880
04-23 17:23:21.831+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29880)
04-23 17:23:21.851+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.861+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:861,9.667004,1.024128,1.540978
04-23 17:23:21.861+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.861+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.861+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:870,-9.730000,0.210000,-4.550000
04-23 17:23:21.871+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:865,9.521042,0.684347,1.038485
04-23 17:23:21.871+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.871+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:877,9.786645,0.555135,0.689133
04-23 17:23:21.871+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.881+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.881+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:885,-20.020000,-2.450000,-4.270000
04-23 17:23:21.881+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.881+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:882,9.985250,0.818345,0.957129
04-23 17:23:21.891+0200 I/accelerometer(30116): capturing data from es.ugr.frailty.accelerometer
04-23 17:23:21.891+0200 I/accelerometer(30116): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,17:23:21:896,9.829715,1.141376,1.153341
04-23 17:23:21.891+0200 I/gyroscope(30119): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,17:23:21:889,-13.090000,-3.150000,-4.270000
04-23 17:23:21.891+0200 I/gyroscope(30119): capturing data from es.ugr.frailty.gyroscope
04-23 17:23:21.901+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:23:21.901+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:23:21.901+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:23:21.901+0200 I/CAPI_NETWORK_CONNECTION(30159): connection.c: connection_destroy(471) > Destroy handle: 0xf748d980
04-23 17:23:21.901+0200 W/CRASH_MANAGER(30168): worker.c: worker_job(1205) > 11301496c6f63152449700
