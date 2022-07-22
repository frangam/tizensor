S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 5623
Date: 2018-04-23 18:25:33+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74f852d, r5   = 0xf7bd9f98
r6   = 0xfffc1c70, r7   = 0xfffc1b20
r8   = 0xf7bd6c18, r9   = 0x00000000
r10  = 0xfffc1bfc, fp   = 0xfffc1c70
ip   = 0x00000001, sp   = 0xfffc1af8
lr   = 0xf74f8539, pc   = 0xf7561228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8856 KB
Buffers:     68960 KB
Cached:     219836 KB
VmPeak:      53536 KB
VmSize:      53532 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11936 KB
VmRSS:       11932 KB
VmData:      11260 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 5623 TID = 5623
5623 5641 

Maps Information
f43c3000 f4bc2000 rw-p [stack:5641]
f4bc9000 f4bcb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bd3000 f4bd7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4be0000 f4be2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bea000 f4bed000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bfc000 f4c01000 r-xp /usr/lib/libsystem.so.0.0.0
f4c0c000 f4c0f000 r-xp /lib/libattr.so.1.1.0
f4c17000 f4c27000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c2f000 f4c38000 r-xp /usr/lib/libedbus.so.1.7.99
f4c40000 f4c41000 r-xp /usr/lib/libresponse.so.0.2.96
f4c4a000 f4c4f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64f1000 f65f7000 r-xp /usr/lib/libicuuc.so.57.1
f660d000 f6795000 r-xp /usr/lib/libicui18n.so.57.1
f67a5000 f67b2000 r-xp /usr/lib/libail.so.0.1.0
f67bb000 f67c2000 r-xp /usr/lib/libminizip.so.1.0.0
f67cb000 f6974000 r-xp /usr/lib/libcrypto.so.1.0.0
f6994000 f69db000 r-xp /usr/lib/libssl.so.1.0.0
f69e7000 f69e9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69f1000 f69f8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a01000 f6a08000 r-xp /lib/libcrypt-2.13.so
f6a39000 f6a3c000 r-xp /lib/libcap.so.2.21
f6a44000 f6a46000 r-xp /usr/lib/libiri.so
f6a4e000 f6a97000 r-xp /usr/lib/libmdm.so.1.2.69
f6a9f000 f6aa5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aad000 f6ad0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ada000 f6adc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae4000 f6b01000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b0a000 f6b0e000 r-xp /usr/lib/libsmack.so.1.0.0
f6b17000 f6b30000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b39000 f6b41000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b49000 f6b4f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b58000 f6b5a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b63000 f6b73000 r-xp /lib/libresolv-2.13.so
f6b77000 f6b8f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b98000 f6b9a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ba2000 f6bbc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc4000 f6bf3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bfc000 f6c0b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c15000 f6c1f000 r-xp /usr/lib/libsensord-shared.so
f6c28000 f6cfb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d06000 f6d1c000 r-xp /lib/libz.so.1.2.5
f6d24000 f6d29000 r-xp /usr/lib/libffi.so.5.0.10
f6d31000 f6d32000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d3a000 f6d4a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d52000 f6d6b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d73000 f6d75000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d7d000 f6df2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dfc000 f6e02000 r-xp /lib/librt-2.13.so
f6e0b000 f6e29000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e33000 f6e34000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e3c000 f6e5f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e67000 f6e6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e74000 f6e9e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea7000 f6ebe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec6000 f6f2f000 r-xp /lib/libm-2.13.so
f6f38000 f6fcc000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdf000 f6fe4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fec000 f6ff3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ffb000 f7025000 r-xp /usr/lib/libsensor.so.1.9.6
f702e000 f70fa000 r-xp /usr/lib/libxml2.so.2.7.8
f7107000 f7109000 r-xp /usr/lib/libiniparser.so.0
f7112000 f7118000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7121000 f71f1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71f2000 f7226000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f722f000 f726b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7273000 f7276000 r-xp /usr/lib/libbundle.so.0.1.22
f727e000 f7284000 r-xp /usr/lib/libappsvc.so.0.1.0
f728c000 f72cd000 r-xp /usr/lib/libeina.so.1.7.99
f72d6000 f72ed000 r-xp /usr/lib/libecore.so.1.7.99
f7304000 f730d000 r-xp /usr/lib/libvconf.so.0.2.45
f7315000 f7329000 r-xp /lib/libpthread-2.13.so
f7334000 f7341000 r-xp /usr/lib/libaul.so.0.1.0
f734b000 f734d000 r-xp /lib/libdl-2.13.so
f7356000 f7361000 r-xp /lib/libunwind.so.8.0.1
f738e000 f7396000 r-xp /lib/libgcc_s-4.6.so.1
f7397000 f74bb000 r-xp /lib/libc-2.13.so
f74c9000 f74cb000 r-xp /usr/lib/libdlog.so.0.0.0
f74d3000 f74df000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e8000 f74ed000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f5000 f7504000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f750c000 f7510000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7519000 f751c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7524000 f7526000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f752e000 f7532000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f753a000 f7557000 r-xp /lib/ld-2.13.so
f7560000 f7563000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7563000 f7567000 r-xp /usr/lib/libsys-assert.so
f7ba6000 f7c2c000 rw-p [heap]
fffa3000 fffc4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5623)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7561228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74f8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71ff3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7209e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf720fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf720fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf723f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71fdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7209e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf720fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf720fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7241e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7242017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7249f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4be11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bd4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7154fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71567a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72e1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72e25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72e2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf751a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf751a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75614f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf73ae85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7560f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
04-23 18:25:31.161+0200 I/LOCATION( 5623): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:31.171+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:31.171+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:31.221+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:25:31.221+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:25:31.221+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:31.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:31.221+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:31.221+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:25:31.221+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:25:31.221+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:25:31.221+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:25:31.231+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:31.231+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:25:31.241+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:25:31.241+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:25:31.241+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:25:31.241+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 18:25:31.241+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:25:31.251+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:31:236,6.228518,4.242475,5.857630
04-23 18:25:31.251+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:25:31.251+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:31:233,38.080002,23.730000,3.850000
04-23 18:25:31.261+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:25:31.261+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:25:31.261+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:25:31.271+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:25:31.281+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:25:31.281+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:25:31.281+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 18:25:31.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:25:31.281+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:25:31.281+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:25:31.281+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:25:31.301+0200 W/LOCATION( 5623): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:25:31.301+0200 W/LOCATION( 5623): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:25:31.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:31.371+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:31.371+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:31.401+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf3c0d0b0]
04-23 18:25:31.401+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:25:31.401+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:25:31.401+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:25:31.401+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:25:31.411+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:31.411+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:31.421+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:31.421+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:31.421+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:31.431+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:31.431+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:25:31.431+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:25:31.431+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:25:31.431+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:25:31.431+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:25:31.431+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:25:31.431+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:25:31.431+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:25:31.431+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:25:31.431+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:31:432,6.113662,7.415358,4.417150
04-23 18:25:31.431+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:31:432,54.040001,17.780001,-30.940001
04-23 18:25:31.441+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:31.441+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:25:31.451+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:25:31.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:31.491+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:31.511+0200 W/LOCATION( 5623): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:25:31.511+0200 I/LOCATION( 5623): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:31.511+0200 I/LOCATION( 5623): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:25:31.511+0200 I/location( 5623): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:25:31.571+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:31.571+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:31.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 300 ms (from 14626942 to 14627242) (logOverhead=0,0,0,0,0,0,0), start: 18:25:31.287
04-23 18:25:31.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 304 ms (from 14626940 to 14627244) (logOverhead=0,0,0,0,0,0,0), start: 18:25:31.285
04-23 18:25:31.581+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 304 ms (from 14626940 to 14627244) (logOverhead=0,0,0,0,0,0,0), start: 18:25:31.286
04-23 18:25:31.601+0200 I/LOCATION( 5623): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:25:31.621+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:31.621+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:31.631+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:31:631,-24.920000,-4.410000,24.150000
04-23 18:25:31.631+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:31:632,4.857430,5.785845,6.288338
04-23 18:25:31.641+0200 E/location( 5623): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:25:31.641+0200 W/AUL     ( 5623): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:25:31.641+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:31.651+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5623
04-23 18:25:31.661+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5575
04-23 18:25:31.661+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.661+0200 I/utils   ( 5575): specific action
04-23 18:25:31.661+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.661+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.661+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.661+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:25:31.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:25:31.661+0200 W/AUL     ( 5623): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5575)
04-23 18:25:31.661+0200 I/location( 5623): request sent to service es.ugr.frailty.servicemanager
04-23 18:25:31.661+0200 W/CAPI_APPFW_APP_CONTROL( 5623): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.661+0200 I/utils   ( 5623): specific action
04-23 18:25:31.661+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:25:31.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5582
04-23 18:25:31.671+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.671+0200 I/utils   ( 5582): specific action
04-23 18:25:31.671+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.671+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.671+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.671+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:31.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:25:31.671+0200 W/CAPI_APPFW_APP_CONTROL( 5582): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:25:31.671+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:25:31.671+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(5582), cmd(0)
04-23 18:25:31.671+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5582)
04-23 18:25:31.671+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.recorder
04-23 18:25:31.671+0200 I/servicemanager( 5575): requesting to save local data
04-23 18:25:31.691+0200 I/recorder( 5582): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:25:31.691+0200 I/recorder( 5582): guardando datos en local
04-23 18:25:31.771+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:31.771+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:31.821+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:31.821+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:31.831+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:31:832,6.946364,3.766303,5.469993
04-23 18:25:31.831+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:31:832,-60.619999,-14.560000,53.130001
04-23 18:25:31.851+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:25:31.851+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(14627515), time2(14551588)
04-23 18:25:31.851+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:25:31.851+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:25:31.851+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:25:31.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:25:31.971+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:31.971+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.021+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.021+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.031+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:30,-41.720001,22.960001,-15.120000
04-23 18:25:32.031+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:30,8.664411,0.909273,5.860023
04-23 18:25:32.171+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:32.171+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.231+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.231+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.231+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:232,5.553742,2.864209,7.712067
04-23 18:25:32.241+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:232,6.230000,6.440000,-15.470000
04-23 18:25:32.381+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:32.381+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.391+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 139 ms (from 14627918 to 14628057) (logOverhead=0,0,0,0,0,0,0), start: 18:25:32.263
04-23 18:25:32.391+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 139 ms (from 14627918 to 14628057) (logOverhead=0,0,0,0,0,0,0), start: 18:25:32.263
04-23 18:25:32.421+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.431+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:432,5.563312,3.962514,7.329216
04-23 18:25:32.431+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:32.451+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:32.451+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:32.451+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:439,-1.260000,14.840000,-16.100000
04-23 18:25:32.471+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.471+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.471+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:475,5.460421,4.515256,7.616355
04-23 18:25:32.471+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:479,5.250000,13.860000,-2.450000
04-23 18:25:32.481+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.481+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.491+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:490,5.467600,4.560720,7.255038
04-23 18:25:32.491+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:490,10.850000,11.830000,4.760000
04-23 18:25:32.511+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.511+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.511+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:517,11.060000,14.910000,10.710000
04-23 18:25:32.541+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:518,5.314459,4.235296,6.855437
04-23 18:25:32.541+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.541+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.551+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:548,5.123034,4.280759,6.812366
04-23 18:25:32.551+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:551,6.650000,15.750000,17.360001
04-23 18:25:32.551+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.551+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:559,5.501099,4.043870,7.293324
04-23 18:25:32.551+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.561+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:25:32.561+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:564,-1.330000,13.930000,22.190001
04-23 18:25:32.561+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.571+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.571+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:32.571+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.571+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:575,-12.810000,16.799999,25.340000
04-23 18:25:32.571+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:574,5.139783,3.481557,6.874579
04-23 18:25:32.581+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.581+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.591+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:592,4.036692,3.067599,7.054041
04-23 18:25:32.591+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:592,-17.360001,13.300000,24.850000
04-23 18:25:32.601+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.611+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.611+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:615,0.560000,5.460000,21.000000
04-23 18:25:32.611+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:612,3.785445,1.959722,6.731010
04-23 18:25:32.621+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.621+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.631+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:633,4.261617,2.555535,6.266802
04-23 18:25:32.631+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:633,12.460000,3.990000,16.940001
04-23 18:25:32.641+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.641+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.651+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:653,7.280000,2.030000,15.190001
04-23 18:25:32.651+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:653,4.658825,3.105884,7.082755
04-23 18:25:32.671+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.671+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.681+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:677,4.692325,2.452643,7.604390
04-23 18:25:32.681+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:682,3.780000,4.130000,11.550000
04-23 18:25:32.681+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.681+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.691+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:694,10.360000,-0.350000,8.680000
04-23 18:25:32.691+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:694,4.350152,2.435893,7.697710
04-23 18:25:32.701+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.701+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.711+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:712,4.498507,3.036492,6.415157
04-23 18:25:32.711+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:712,16.240000,-6.790000,7.280000
04-23 18:25:32.721+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.721+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.731+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:733,20.440001,-7.910000,3.080000
04-23 18:25:32.731+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:734,5.424529,3.237489,6.776474
04-23 18:25:32.741+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.751+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.751+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:755,5.948557,2.435893,8.882158
04-23 18:25:32.761+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:754,30.380001,-2.450000,6.230000
04-23 18:25:32.761+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.761+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.771+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:32.771+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.771+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:772,46.759998,-7.210000,-0.210000
04-23 18:25:32.771+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:773,5.532206,2.033899,9.375079
04-23 18:25:32.781+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.781+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.791+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:794,78.610001,-13.020000,-1.540000
04-23 18:25:32.791+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:794,5.539384,3.716053,7.566105
04-23 18:25:32.801+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.811+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.811+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:813,76.860001,-15.610000,7.140000
04-23 18:25:32.811+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:814,6.379266,5.541777,6.379266
04-23 18:25:32.821+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.821+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.831+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:833,6.235696,4.697111,6.683154
04-23 18:25:32.831+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:833,44.590000,-10.640000,8.120000
04-23 18:25:32.841+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.841+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.851+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:854,6.051448,5.075177,6.329016
04-23 18:25:32.861+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:854,26.809999,-11.200000,12.250000
04-23 18:25:32.871+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.881+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.881+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:883,5.903094,4.369294,6.372087
04-23 18:25:32.891+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:888,11.270000,-5.950000,15.820000
04-23 18:25:32.891+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.891+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.901+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:897,1.050000,-1.190000,21.420000
04-23 18:25:32.901+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:896,6.144768,5.108676,6.017949
04-23 18:25:32.901+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.901+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.911+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:913,6.008378,4.335794,6.099305
04-23 18:25:32.911+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:912,-26.809999,6.020000,24.150000
04-23 18:25:32.921+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.921+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.931+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:933,5.649454,2.766103,5.840880
04-23 18:25:32.941+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.951+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:953,5.434100,2.833102,6.807580
04-23 18:25:32.961+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.971+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:933,-25.549999,12.110000,20.299999
04-23 18:25:32.971+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.971+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:972,5.845665,1.950150,7.427321
04-23 18:25:32.981+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:980,-26.600000,11.130000,14.210000
04-23 18:25:32.981+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:32.991+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:32.991+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:32.991+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:32.991+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:32:996,6.764510,2.414358,6.453443
04-23 18:25:33.001+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.011+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:32:993,-19.460001,7.560000,8.190000
04-23 18:25:33.011+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:12,6.470192,3.261417,5.819345
04-23 18:25:33.021+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.021+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:25,-3.010000,7.490000,1.400000
04-23 18:25:33.021+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.031+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:33,6.120840,3.981657,5.793024
04-23 18:25:33.031+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.041+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:40,14.000000,12.880000,-5.390000
04-23 18:25:33.041+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.041+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.051+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:53,5.781059,3.007778,6.979864
04-23 18:25:33.051+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:48,-0.350000,13.440001,-6.930000
04-23 18:25:33.051+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.051+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:60,-26.880001,14.560000,-9.590000
04-23 18:25:33.061+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.061+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.071+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:72,-19.040001,7.560000,-11.900000
04-23 18:25:33.071+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:72,6.616155,2.368894,8.413164
04-23 18:25:33.081+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.081+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.091+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:93,0.070000,3.010000,-12.180000
04-23 18:25:33.091+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:93,7.207181,4.232903,9.154939
04-23 18:25:33.101+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.101+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.111+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:113,6.790830,5.563312,7.843673
04-23 18:25:33.111+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:113,5.880000,-0.700000,-5.530000
04-23 18:25:33.121+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.121+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.131+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:133,-24.570000,-0.700000,-3.290000
04-23 18:25:33.131+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:133,5.919843,3.964907,6.209375
04-23 18:25:33.141+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.141+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.151+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:153,-33.250000,7.070000,-2.730000
04-23 18:25:33.151+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:153,5.489135,2.294717,7.125826
04-23 18:25:33.161+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.161+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.171+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:33.171+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:33.171+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:173,4.902894,1.301696,8.779266
04-23 18:25:33.191+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.191+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:174,-16.660000,1.960000,-9.800000
04-23 18:25:33.191+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.191+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:195,6.147161,2.060220,7.800602
04-23 18:25:33.201+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:200,21.420000,-3.080000,-13.020000
04-23 18:25:33.201+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.201+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.211+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:213,35.490002,-4.900000,-8.610000
04-23 18:25:33.211+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:214,5.838487,5.008178,8.269595
04-23 18:25:33.221+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.221+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.231+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:234,0.560000,-11.130000,-7.490000
04-23 18:25:33.231+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:234,5.228317,4.668397,7.056434
04-23 18:25:33.241+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.241+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.261+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:254,-18.830000,-8.610000,-2.100000
04-23 18:25:33.271+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:25:33.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:33.271+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:25:33.271+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.281+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:254,5.005785,3.522235,6.589834
04-23 18:25:33.281+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.291+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:287,4.984250,3.342773,7.420143
04-23 18:25:33.291+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:284,-10.010000,-7.700000,-0.770000
04-23 18:25:33.291+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.291+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.291+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:296,5.242674,2.663212,7.453642
04-23 18:25:33.301+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:297,-11.060000,-9.870000,-0.210000
04-23 18:25:33.301+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.301+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.311+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:313,5.927022,3.536592,7.300502
04-23 18:25:33.311+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:313,8.050000,-12.530000,-2.100000
04-23 18:25:33.331+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.341+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.351+0200 W/LOCATION( 5623): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:25:33.351+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:335,0.630000,-11.340000,-2.100000
04-23 18:25:33.351+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.361+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:335,5.383851,3.689733,6.647261
04-23 18:25:33.361+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.371+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:368,5.520242,3.510271,6.410372
04-23 18:25:33.371+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.371+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:33.371+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:33.371+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:362,-14.560000,-11.410000,-2.660000
04-23 18:25:33.371+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.381+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:378,5.213961,2.612962,7.173682
04-23 18:25:33.391+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:382,-14.560000,-9.730000,-3.710000
04-23 18:25:33.391+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.391+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:397,16.450001,-13.580000,-2.800000
04-23 18:25:33.391+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.401+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:403,5.467600,2.823531,7.527820
04-23 18:25:33.401+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.411+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:414,46.060001,-15.330000,2.940000
04-23 18:25:33.411+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.421+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:420,6.159126,5.101498,7.846066
04-23 18:25:33.421+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.431+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.431+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:435,5.706882,5.379066,7.539784
04-23 18:25:33.441+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:434,16.309999,-14.770000,12.250000
04-23 18:25:33.441+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.451+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.451+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:455,5.398208,4.208975,7.228717
04-23 18:25:33.461+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:453,-1.120000,-17.990000,17.150000
04-23 18:25:33.461+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.471+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.471+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:475,5.077570,3.486342,6.640083
04-23 18:25:33.471+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:474,10.080000,-17.780001,24.780001
04-23 18:25:33.481+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.481+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.491+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:494,18.059999,-9.380000,28.770000
04-23 18:25:33.491+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:494,5.300103,3.335595,5.321638
04-23 18:25:33.501+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.501+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.511+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:513,-1.820000,-3.500000,33.740002
04-23 18:25:33.511+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:513,4.666004,3.093920,5.934200
04-23 18:25:33.521+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.521+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.531+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:534,-8.050000,-10.920000,36.820000
04-23 18:25:33.531+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:534,4.668397,2.857030,6.654440
04-23 18:25:33.541+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.551+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.551+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:555,-2.940000,-19.670000,39.410000
04-23 18:25:33.561+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:554,4.780859,3.428915,6.563512
04-23 18:25:33.561+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.571+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.571+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:575,-6.790000,-26.250000,44.660000
04-23 18:25:33.581+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:573,5.166104,3.692125,6.336195
04-23 18:25:33.581+0200 I/heartrate( 5602): capturing data from es.ugr.frailty.heartrate
04-23 18:25:33.581+0200 I/heartrate( 5602): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:25:33.591+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.591+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.591+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:595,5.515456,3.151347,6.585048
04-23 18:25:33.601+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:595,-11.130000,-27.790001,51.240002
04-23 18:25:33.611+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.611+0200 W/AUL     ( 5650): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:25:33.611+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 18:25:33.611+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 18:25:33.611+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:25:33.611+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:25:33.611+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:25:33.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:25:33.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5283
04-23 18:25:33.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:25:33.621+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:624,4.830000,-26.040001,60.689999
04-23 18:25:33.621+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5283
04-23 18:25:33.621+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5283)
04-23 18:25:33.631+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:616,5.233103,3.732803,5.443672
04-23 18:25:33.631+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.631+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:25:33.641+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:636,5.297709,4.201797,4.981857
04-23 18:25:33.641+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:637,10.920000,-26.600000,73.989998
04-23 18:25:33.651+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.661+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:656,7.013363,4.658825,4.883751
04-23 18:25:33.671+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.681+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:682,5.950000,-28.490000,84.980003
04-23 18:25:33.681+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.681+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.691+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:687,7.219146,4.644469,4.934000
04-23 18:25:33.691+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:688,-29.540001,-17.500000,99.680000
04-23 18:25:33.691+0200 I/accelerometer( 5586): capturing data from es.ugr.frailty.accelerometer
04-23 18:25:33.691+0200 I/gyroscope( 5589): capturing data from es.ugr.frailty.gyroscope
04-23 18:25:33.691+0200 I/accelerometer( 5586): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:25:33:698,6.489335,2.976671,5.761917
04-23 18:25:33.701+0200 I/gyroscope( 5589): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:25:33:699,-54.950001,-12.880000,112.419998
04-23 18:25:33.701+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:25:33.701+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:25:33.701+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 18:25:33.701+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_destroy(471) > Destroy handle: 0xf3c0d0b0
04-23 18:25:33.711+0200 W/CRASH_MANAGER( 5651): worker.c: worker_job(1205) > 11056236c6f63152450073
