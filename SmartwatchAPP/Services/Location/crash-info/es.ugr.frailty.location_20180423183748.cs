S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8409
Date: 2018-04-23 18:37:48+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70d852d, r5   = 0xf71a7f98
r6   = 0xffcb2ed0, r7   = 0xffcb2d80
r8   = 0xf71a4c18, r9   = 0x00000000
r10  = 0xffcb2e5c, fp   = 0xffcb2ed0
ip   = 0x00000001, sp   = 0xffcb2d58
lr   = 0xf70d8539, pc   = 0xf7141228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7328 KB
Buffers:     69336 KB
Cached:     217424 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11908 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8409 TID = 8409
8409 8429 

Maps Information
f3fa3000 f47a2000 rw-p [stack:8429]
f47a9000 f47ab000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47b3000 f47b7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47c0000 f47c2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ca000 f47cd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47dc000 f47e1000 r-xp /usr/lib/libsystem.so.0.0.0
f47ec000 f47ef000 r-xp /lib/libattr.so.1.1.0
f47f7000 f4807000 r-xp /usr/lib/libmdm-common.so.1.1.24
f480f000 f4818000 r-xp /usr/lib/libedbus.so.1.7.99
f4820000 f4821000 r-xp /usr/lib/libresponse.so.0.2.96
f482a000 f482f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60d1000 f61d7000 r-xp /usr/lib/libicuuc.so.57.1
f61ed000 f6375000 r-xp /usr/lib/libicui18n.so.57.1
f6385000 f6392000 r-xp /usr/lib/libail.so.0.1.0
f639b000 f63a2000 r-xp /usr/lib/libminizip.so.1.0.0
f63ab000 f6554000 r-xp /usr/lib/libcrypto.so.1.0.0
f6574000 f65bb000 r-xp /usr/lib/libssl.so.1.0.0
f65c7000 f65c9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65d1000 f65d8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65e1000 f65e8000 r-xp /lib/libcrypt-2.13.so
f6619000 f661c000 r-xp /lib/libcap.so.2.21
f6624000 f6626000 r-xp /usr/lib/libiri.so
f662e000 f6677000 r-xp /usr/lib/libmdm.so.1.2.69
f667f000 f6685000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f668d000 f66b0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66ba000 f66bc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66c4000 f66e1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66ea000 f66ee000 r-xp /usr/lib/libsmack.so.1.0.0
f66f7000 f6710000 r-xp /usr/lib/libnetwork.so.0.0.0
f6719000 f6721000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6729000 f672f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6738000 f673a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6743000 f6753000 r-xp /lib/libresolv-2.13.so
f6757000 f676f000 r-xp /usr/lib/liblzma.so.5.0.3
f6778000 f677a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6782000 f679c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67a4000 f67d3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67dc000 f67eb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67f5000 f67ff000 r-xp /usr/lib/libsensord-shared.so
f6808000 f68db000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e6000 f68fc000 r-xp /lib/libz.so.1.2.5
f6904000 f6909000 r-xp /usr/lib/libffi.so.5.0.10
f6911000 f6912000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f691a000 f692a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6932000 f694b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6953000 f6955000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f695d000 f69d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69dc000 f69e2000 r-xp /lib/librt-2.13.so
f69eb000 f6a09000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a13000 f6a14000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a1c000 f6a3f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a47000 f6a4c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a54000 f6a7e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a87000 f6a9e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aa6000 f6b0f000 r-xp /lib/libm-2.13.so
f6b18000 f6bac000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bbf000 f6bc4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bcc000 f6bd3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bdb000 f6c05000 r-xp /usr/lib/libsensor.so.1.9.6
f6c0e000 f6cda000 r-xp /usr/lib/libxml2.so.2.7.8
f6ce7000 f6ce9000 r-xp /usr/lib/libiniparser.so.0
f6cf2000 f6cf8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d01000 f6dd1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dd2000 f6e06000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e0f000 f6e4b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e53000 f6e56000 r-xp /usr/lib/libbundle.so.0.1.22
f6e5e000 f6e64000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e6c000 f6ead000 r-xp /usr/lib/libeina.so.1.7.99
f6eb6000 f6ecd000 r-xp /usr/lib/libecore.so.1.7.99
f6ee4000 f6eed000 r-xp /usr/lib/libvconf.so.0.2.45
f6ef5000 f6f09000 r-xp /lib/libpthread-2.13.so
f6f14000 f6f21000 r-xp /usr/lib/libaul.so.0.1.0
f6f2b000 f6f2d000 r-xp /lib/libdl-2.13.so
f6f36000 f6f41000 r-xp /lib/libunwind.so.8.0.1
f6f6e000 f6f76000 r-xp /lib/libgcc_s-4.6.so.1
f6f77000 f709b000 r-xp /lib/libc-2.13.so
f70a9000 f70ab000 r-xp /usr/lib/libdlog.so.0.0.0
f70b3000 f70bf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c8000 f70cd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70d5000 f70e4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70ec000 f70f0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70f9000 f70fc000 r-xp /usr/lib/libappcore-agent.so.1.1
f7104000 f7106000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f710e000 f7112000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f711a000 f7137000 r-xp /lib/ld-2.13.so
f7140000 f7143000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7143000 f7147000 r-xp /usr/lib/libsys-assert.so
f7174000 f71fe000 rw-p [heap]
ffc94000 ffcb5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8409)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7141228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70d8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ddf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6de9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6defbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6defdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e2475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e1f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dddc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6de9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6defbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6defdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e21e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e22017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e29f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47c11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47b4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6887663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d34fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d367a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ec6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ec1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ec25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ec2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70fa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70fa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71414f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f8e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7140f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
> __send_result_to_client, pid: 8413
04-23 18:37:45.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:37:45.781+0200 W/LOCATION( 8409): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:37:45.781+0200 W/LOCATION( 8409): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:37:45.781+0200 I/LOCATION( 8409): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:37:45.821+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:45.821+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 18:37:45.841+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 18:37:45.841+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:45.841+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:45.841+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:37:45.851+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:37:45.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 18:37:45.851+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 18:37:45.851+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:37:45.861+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:37:45.871+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:37:45.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 18:37:45.871+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:37:45.871+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 18:37:45.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 18:37:45.881+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:37:45.891+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:37:45.891+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 18:37:45.891+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 18:37:45.901+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:45.901+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 18:37:45.911+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:45.911+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 18:37:45.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 18:37:45.911+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 18:37:45.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 18:37:45.921+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 18:37:45.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 18:37:45.921+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 18:37:45.931+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:45:911,1.260000,-9.940000,-21.210001
04-23 18:37:45.931+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:45:921,8.879765,-0.686740,4.893322
04-23 18:37:45.941+0200 W/LOCATION( 8409): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:37:45.941+0200 W/LOCATION( 8409): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:37:46.021+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:46.021+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:46.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:46.071+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf7269e38]
04-23 18:37:46.071+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:37:46.071+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:37:46.071+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:37:46.071+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:37:46.081+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:37:46.081+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:37:46.081+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:46.091+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:46.091+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:46.101+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:46.101+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:37:46.101+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:37:46.101+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:37:46.101+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:37:46.101+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:37:46.101+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:37:46.101+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:37:46.101+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:37:46.101+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:37:46.101+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:46:102,-50.610001,-2.800000,10.290000
04-23 18:37:46.111+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:46:102,8.195417,1.744368,5.240282
04-23 18:37:46.111+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:46.121+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:37:46.121+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:37:46.121+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:46.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:46.211+0200 W/LOCATION( 8409): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:37:46.211+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 300 ms (from 15361579 to 15361879) (logOverhead=0,0,0,0,0,0,0), start: 18:37:45.924
04-23 18:37:46.221+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 309 ms (from 15361576 to 15361885) (logOverhead=0,0,0,0,0,0,0), start: 18:37:45.921
04-23 18:37:46.221+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 309 ms (from 15361576 to 15361885) (logOverhead=0,0,0,0,0,0,0), start: 18:37:45.921
04-23 18:37:46.221+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:46.221+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:46.221+0200 I/LOCATION( 8409): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:37:46.221+0200 I/LOCATION( 8409): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:37:46.221+0200 I/location( 8409): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:37:46.291+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:46.291+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:46.311+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:46:305,9.387043,0.157926,3.857230
04-23 18:37:46.311+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:46:304,-17.360001,-17.430000,36.959999
04-23 18:37:46.351+0200 I/LOCATION( 8409): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:37:46.401+0200 E/location( 8409): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:37:46.401+0200 W/AUL     ( 8409): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:37:46.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:37:46.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8409
04-23 18:37:46.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8361
04-23 18:37:46.421+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.421+0200 I/utils   ( 8361): specific action
04-23 18:37:46.421+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.421+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.421+0200 W/CAPI_APPFW_APP_CONTROL( 8361): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.421+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:37:46.421+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:46.421+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:46.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:37:46.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8361), cmd(0)
04-23 18:37:46.421+0200 W/AUL     ( 8409): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8361)
04-23 18:37:46.421+0200 I/location( 8409): request sent to service es.ugr.frailty.servicemanager
04-23 18:37:46.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:37:46.421+0200 W/CAPI_APPFW_APP_CONTROL( 8409): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.421+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 8361
04-23 18:37:46.421+0200 I/utils   ( 8409): specific action
04-23 18:37:46.431+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 8367
04-23 18:37:46.431+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.431+0200 I/utils   ( 8367): specific action
04-23 18:37:46.431+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.431+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.431+0200 W/AUL     ( 8361): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8367)
04-23 18:37:46.431+0200 I/servicemanager( 8361): request sent to service es.ugr.frailty.recorder
04-23 18:37:46.431+0200 I/servicemanager( 8361): requesting to save local data
04-23 18:37:46.431+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.431+0200 W/CAPI_APPFW_APP_CONTROL( 8367): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:37:46.431+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:37:46.431+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(8367), cmd(0)
04-23 18:37:46.451+0200 I/recorder( 8367): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:37:46.451+0200 I/recorder( 8367): guardando datos en local
04-23 18:37:46.491+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:46.491+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:46.501+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:46:502,8.518449,-1.974079,4.744967
04-23 18:37:46.501+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:46:502,-72.239998,31.360001,18.760000
04-23 18:37:46.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:37:46.551+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(15362214), time2(14653040)
04-23 18:37:46.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:37:46.551+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:37:46.551+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:37:46.551+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:37:46.621+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:46.621+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:46.691+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:46.691+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:46.701+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:46:702,8.870193,-2.519642,4.773681
04-23 18:37:46.701+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:46:702,-37.799999,-2.170000,-14.350000
04-23 18:37:46.821+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:46.821+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:46.891+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:46.901+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:46:903,8.437093,-1.588834,4.247260
04-23 18:37:46.931+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:46.941+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:46:903,-1.750000,-0.210000,-4.900000
04-23 18:37:47.031+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 137 ms (from 15362559 to 15362696) (logOverhead=0,0,0,0,0,0,0), start: 18:37:46.904
04-23 18:37:47.031+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 137 ms (from 15362559 to 15362696) (logOverhead=0,0,0,0,0,0,0), start: 18:37:46.904
04-23 18:37:47.081+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:37:47.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:47.091+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:37:47.091+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:47.091+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:47.101+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.101+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:105,8.750552,-1.378266,4.809574
04-23 18:37:47.101+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.101+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:110,30.030001,-9.450000,-9.450000
04-23 18:37:47.111+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.111+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.111+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:119,24.080000,-7.910000,-7.490000
04-23 18:37:47.121+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:119,8.549555,-1.198804,4.656433
04-23 18:37:47.131+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.141+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.141+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:141,8.568698,-1.397408,4.015156
04-23 18:37:47.141+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:145,30.799999,-9.380000,-8.540000
04-23 18:37:47.171+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.171+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.171+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:175,45.360001,-6.790000,-10.290000
04-23 18:37:47.171+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:175,8.671589,-1.598405,4.331009
04-23 18:37:47.181+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.181+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.181+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:185,57.820000,-5.670000,-12.250000
04-23 18:37:47.191+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:185,8.812766,-0.859023,4.311867
04-23 18:37:47.191+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.201+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:202,38.639999,-4.550000,-12.740000
04-23 18:37:47.201+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.211+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:208,8.640482,-0.399601,4.077370
04-23 18:37:47.211+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.221+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.221+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:225,25.900000,-7.420000,-8.680000
04-23 18:37:47.221+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:221,8.532805,-0.856631,4.201797
04-23 18:37:47.221+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:47.221+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:47.231+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.241+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.241+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:247,8.721838,-1.495514,4.400401
04-23 18:37:47.241+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:241,47.459999,-8.960000,-10.150000
04-23 18:37:47.251+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.251+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.261+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:37:47.261+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:263,8.965906,-0.949951,4.500899
04-23 18:37:47.261+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:261,74.199997,-7.700000,-19.320000
04-23 18:37:47.271+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.271+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.281+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:282,8.561519,0.323031,4.141976
04-23 18:37:47.281+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:282,51.520000,-5.390000,-21.350000
04-23 18:37:47.291+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.291+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.301+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:304,8.264810,0.375673,4.419543
04-23 18:37:47.301+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:303,13.300000,-12.390000,-14.770000
04-23 18:37:47.311+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.311+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.321+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:324,8.523234,-0.399601,4.443472
04-23 18:37:47.331+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:321,21.210001,-17.219999,-14.980000
04-23 18:37:47.331+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.331+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.341+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:343,80.639999,-18.340000,-18.410000
04-23 18:37:47.341+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:343,8.532805,-0.930808,4.170690
04-23 18:37:47.351+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.351+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.361+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:362,8.463413,1.208375,3.919443
04-23 18:37:47.361+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:362,87.360001,-14.490000,-30.799999
04-23 18:37:47.371+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.371+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.381+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:383,11.060000,-16.309999,-19.250000
04-23 18:37:47.381+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:383,8.135597,2.462214,2.665605
04-23 18:37:47.391+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.391+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.401+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:403,-43.400002,-25.620001,-2.940000
04-23 18:37:47.401+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:403,8.678767,0.746561,3.180061
04-23 18:37:47.411+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.411+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.421+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:47.421+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:47.421+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:422,9.011370,-0.241675,3.536592
04-23 18:37:47.421+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:422,-23.240000,-22.260000,-4.130000
04-23 18:37:47.431+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.431+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.441+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:444,9.660000,-14.140000,-8.120000
04-23 18:37:47.441+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:444,8.621340,0.294317,3.845266
04-23 18:37:47.451+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.451+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.461+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:462,11.550000,-14.210000,-9.590000
04-23 18:37:47.461+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:462,8.437093,0.995414,4.024727
04-23 18:37:47.471+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.471+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.481+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:483,-29.049999,-20.510000,-2.520000
04-23 18:37:47.481+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:483,8.551948,1.280160,3.888337
04-23 18:37:47.501+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.501+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.501+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:505,8.836694,0.464208,4.146761
04-23 18:37:47.511+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:505,-44.240002,-25.340000,2.170000
04-23 18:37:47.511+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.511+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.521+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:522,9.164511,0.050249,4.240082
04-23 18:37:47.521+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:523,-28.280001,-23.870001,1.960000
04-23 18:37:47.531+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.531+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.541+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:543,-6.440000,-22.540001,-1.680000
04-23 18:37:47.541+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:543,9.497113,-0.110070,3.818945
04-23 18:37:47.551+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.551+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.561+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:564,9.513863,0.397209,4.347759
04-23 18:37:47.561+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:564,-1.050000,-20.090000,-3.290000
04-23 18:37:47.571+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.581+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.581+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:583,-10.010000,-24.360001,-1.260000
04-23 18:37:47.591+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.601+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:589,9.353544,0.581456,4.261617
04-23 18:37:47.601+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:602,-17.010000,-26.880001,1.050000
04-23 18:37:47.611+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.621+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.621+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:616,9.755538,0.246461,4.419543
04-23 18:37:47.631+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.631+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:626,-19.740000,-22.889999,2.520000
04-23 18:37:47.641+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:637,9.621540,0.059821,3.768696
04-23 18:37:47.641+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.651+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:650,9.784252,-0.069392,3.026921
04-23 18:37:47.651+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.661+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:658,-22.960001,-20.719999,3.920000
04-23 18:37:47.661+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.671+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:668,10.011569,0.385244,3.000600
04-23 18:37:47.671+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.681+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:47.681+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:47.681+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:677,-15.330000,-16.940001,3.920000
04-23 18:37:47.681+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.681+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.691+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:690,-12.250000,-10.710000,3.850000
04-23 18:37:47.691+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:690,9.662218,0.878166,3.388237
04-23 18:37:47.701+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.701+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.711+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:705,9.147761,0.622134,3.783052
04-23 18:37:47.711+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:706,-14.630000,-12.390000,7.350000
04-23 18:37:47.711+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.711+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.721+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:722,-13.160000,-15.050000,8.820000
04-23 18:37:47.721+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:722,9.095119,0.502493,3.833302
04-23 18:37:47.731+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.731+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.741+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:743,-16.520000,-19.600000,9.870000
04-23 18:37:47.741+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:743,9.111869,0.409173,2.933600
04-23 18:37:47.751+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.751+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.761+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:762,9.363115,0.002393,2.189433
04-23 18:37:47.761+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:762,-28.139999,-22.820000,13.930000
04-23 18:37:47.771+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.771+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.781+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:782,-24.990000,-19.600000,16.520000
04-23 18:37:47.781+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:782,9.681360,-0.404387,2.304288
04-23 18:37:47.791+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.791+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.801+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:804,9.657433,-0.490529,2.950350
04-23 18:37:47.801+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:803,-13.860000,-11.900000,16.799999
04-23 18:37:47.811+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.821+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.821+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:47.821+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:47.821+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:826,9.454042,-0.416351,2.921637
04-23 18:37:47.831+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:823,-9.030000,-15.680000,16.730000
04-23 18:37:47.831+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.831+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.841+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:844,9.535398,-0.227318,2.507678
04-23 18:37:47.841+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:843,-12.810000,-21.420000,17.219999
04-23 18:37:47.851+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.861+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.861+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:864,-20.370001,-22.610001,17.010000
04-23 18:37:47.861+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:865,9.633504,-0.425922,2.048256
04-23 18:37:47.871+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.871+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.881+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:883,-23.170000,-20.860001,16.799999
04-23 18:37:47.881+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:884,9.781858,-0.725025,1.801795
04-23 18:37:47.891+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.891+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.901+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:903,9.652647,-0.689133,2.596212
04-23 18:37:47.911+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:37:47.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:47.911+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:37:47.921+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.941+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:903,-24.430000,-17.500000,16.240000
04-23 18:37:47.941+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:929,9.317651,-0.641276,2.423929
04-23 18:37:47.941+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.941+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.951+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:948,9.499505,-0.722632,2.431108
04-23 18:37:47.961+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:951,-24.010000,-21.910000,16.660000
04-23 18:37:47.961+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.961+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.961+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:966,-25.549999,-25.340000,18.969999
04-23 18:37:47.971+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:47.971+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:969,9.750752,-0.873380,2.194218
04-23 18:37:47.981+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:47.991+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:976,-30.170000,-26.320000,19.530001
04-23 18:37:47.991+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.001+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:47:998,-33.599998,-21.980000,22.400000
04-23 18:37:48.001+0200 W/LOCATION( 8409): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:37:48.011+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.011+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:47:988,9.475577,-1.395016,2.254039
04-23 18:37:48.011+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.021+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:16,-13.370000,-21.420000,22.469999
04-23 18:37:48.021+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:48.021+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.021+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:48.021+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:19,9.564112,-1.959722,1.753939
04-23 18:37:48.031+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.031+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:35,9.724431,-2.282753,1.378266
04-23 18:37:48.041+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:31,18.690001,-12.740000,21.910000
04-23 18:37:48.041+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.041+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.041+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:46,9.753145,-2.139183,1.785046
04-23 18:37:48.051+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:46,47.250000,-3.360000,19.809999
04-23 18:37:48.051+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.051+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.061+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:62,9.647861,-1.617548,1.651048
04-23 18:37:48.061+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:62,63.910000,0.280000,18.549999
04-23 18:37:48.071+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.071+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.081+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:83,65.870003,1.610000,20.160000
04-23 18:37:48.081+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:84,9.449257,-1.162912,1.524228
04-23 18:37:48.091+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.101+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:102,9.396614,-1.275374,1.361516
04-23 18:37:48.101+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.101+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:108,59.920002,-0.140000,22.680000
04-23 18:37:48.111+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.121+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:122,9.552148,-2.127219,1.854438
04-23 18:37:48.121+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.121+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:128,54.810001,0.910000,25.830000
04-23 18:37:48.131+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.141+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:143,9.714860,-2.191825,2.586641
04-23 18:37:48.141+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.141+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:148,65.870003,4.900000,22.330000
04-23 18:37:48.151+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.161+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:162,9.384650,-1.734797,2.344966
04-23 18:37:48.161+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.161+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:166,78.750000,5.880000,20.719999
04-23 18:37:48.171+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.181+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:182,9.614362,-1.612763,1.239482
04-23 18:37:48.181+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.181+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:187,77.840004,4.620000,17.780001
04-23 18:37:48.191+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.201+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:202,9.856036,-1.330409,1.351945
04-23 18:37:48.201+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.211+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:208,66.709999,9.450000,15.540000
04-23 18:37:48.211+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.221+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:222,9.803394,-1.464408,2.079363
04-23 18:37:48.221+0200 I/heartrate( 8395): capturing data from es.ugr.frailty.heartrate
04-23 18:37:48.221+0200 I/heartrate( 8395): es.ugr.frailty.heartrate: waiting for rigth values
04-23 18:37:48.231+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.231+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.241+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:243,11.059627,-1.107877,2.890530
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 18:37:48.251+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 18:37:48.251+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 18:37:48.251+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 18:37:48.251+0200 E/CAPI_LOCATION_MANAGER( 2317): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 18:37:48.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:37:48.281+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.321+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:37:48.321+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:37:48.321+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 18:37:48.321+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_destroy(471) > Destroy handle: 0xf7269e38
04-23 18:37:48.321+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:293,11.071590,-1.138984,2.950350
04-23 18:37:48.321+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.331+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:235,48.580002,14.560000,13.790000
04-23 18:37:48.331+0200 W/AUL     ( 8443): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 18:37:48.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:37:48.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:37:48.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8073
04-23 18:37:48.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:37:48.341+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.341+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8073
04-23 18:37:48.341+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8073)
04-23 18:37:48.341+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:347,17.360001,11.690000,13.020000
04-23 18:37:48.341+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:334,8.688338,-1.514657,2.301895
04-23 18:37:48.351+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.351+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:356,8.496914,-1.902294,2.380858
04-23 18:37:48.351+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.361+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:360,-26.250000,6.510000,10.710000
04-23 18:37:48.361+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.361+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:370,9.171689,-2.242075,2.325824
04-23 18:37:48.371+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.371+0200 I/gyroscope( 8376): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:37:48:375,-62.650002,24.850000,6.230000
04-23 18:37:48.371+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.371+0200 I/gyroscope( 8376): capturing data from es.ugr.frailty.gyroscope
04-23 18:37:48.381+0200 I/accelerometer( 8374): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:37:48:379,9.375079,-2.041078,2.148755
04-23 18:37:48.381+0200 I/accelerometer( 8374): capturing data from es.ugr.frailty.accelerometer
04-23 18:37:48.391+0200 W/CRASH_MANAGER( 8438): worker.c: worker_job(1205) > 11084096c6f63152450146
