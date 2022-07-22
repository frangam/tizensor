S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18849
Date: 2018-04-23 15:52:13+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73ee52d, r5   = 0xf77ac958
r6   = 0xffe9c050, r7   = 0xffe9bf00
r8   = 0xf77bfc18, r9   = 0x00000000
r10  = 0xffe9bfdc, fp   = 0xffe9c050
ip   = 0x00000001, sp   = 0xffe9ad80
lr   = 0xf73ee539, pc   = 0xf74572aa
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11456 KB
Buffers:     56964 KB
Cached:     235816 KB
VmPeak:      53468 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11900 KB
VmRSS:       11900 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18849 TID = 18849
18849 18860 

Maps Information
f42b9000 f4ab8000 rw-p [stack:18860]
f4abf000 f4ac1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ac9000 f4acd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ad6000 f4ad8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ae0000 f4ae3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4af2000 f4af7000 r-xp /usr/lib/libsystem.so.0.0.0
f4b02000 f4b05000 r-xp /lib/libattr.so.1.1.0
f4b0d000 f4b1d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b25000 f4b2e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b36000 f4b37000 r-xp /usr/lib/libresponse.so.0.2.96
f4b40000 f4b45000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63e7000 f64ed000 r-xp /usr/lib/libicuuc.so.57.1
f6503000 f668b000 r-xp /usr/lib/libicui18n.so.57.1
f669b000 f66a8000 r-xp /usr/lib/libail.so.0.1.0
f66b1000 f66b8000 r-xp /usr/lib/libminizip.so.1.0.0
f66c1000 f686a000 r-xp /usr/lib/libcrypto.so.1.0.0
f688a000 f68d1000 r-xp /usr/lib/libssl.so.1.0.0
f68dd000 f68df000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68e7000 f68ee000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68f7000 f68fe000 r-xp /lib/libcrypt-2.13.so
f692f000 f6932000 r-xp /lib/libcap.so.2.21
f693a000 f693c000 r-xp /usr/lib/libiri.so
f6944000 f698d000 r-xp /usr/lib/libmdm.so.1.2.69
f6995000 f699b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69a3000 f69c6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69d0000 f69d2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69da000 f69f7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a00000 f6a04000 r-xp /usr/lib/libsmack.so.1.0.0
f6a0d000 f6a26000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a2f000 f6a37000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a3f000 f6a45000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a4e000 f6a50000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a59000 f6a69000 r-xp /lib/libresolv-2.13.so
f6a6d000 f6a85000 r-xp /usr/lib/liblzma.so.5.0.3
f6a8e000 f6a90000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a98000 f6ab2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6aba000 f6ae9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6af2000 f6b01000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b0b000 f6b15000 r-xp /usr/lib/libsensord-shared.so
f6b1e000 f6bf1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bfc000 f6c12000 r-xp /lib/libz.so.1.2.5
f6c1a000 f6c1f000 r-xp /usr/lib/libffi.so.5.0.10
f6c27000 f6c28000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c30000 f6c40000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c48000 f6c61000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c69000 f6c6b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c73000 f6ce8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cf2000 f6cf8000 r-xp /lib/librt-2.13.so
f6d01000 f6d1f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d29000 f6d2a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d32000 f6d55000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d5d000 f6d62000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d6a000 f6d94000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d9d000 f6db4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dbc000 f6e25000 r-xp /lib/libm-2.13.so
f6e2e000 f6ec2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ed5000 f6eda000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ee2000 f6ee9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ef1000 f6f1b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f24000 f6ff0000 r-xp /usr/lib/libxml2.so.2.7.8
f6ffd000 f6fff000 r-xp /usr/lib/libiniparser.so.0
f7008000 f700e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7017000 f70e7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70e8000 f711c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7125000 f7161000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7169000 f716c000 r-xp /usr/lib/libbundle.so.0.1.22
f7174000 f717a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7182000 f71c3000 r-xp /usr/lib/libeina.so.1.7.99
f71cc000 f71e3000 r-xp /usr/lib/libecore.so.1.7.99
f71fa000 f7203000 r-xp /usr/lib/libvconf.so.0.2.45
f720b000 f721f000 r-xp /lib/libpthread-2.13.so
f722a000 f7237000 r-xp /usr/lib/libaul.so.0.1.0
f7241000 f7243000 r-xp /lib/libdl-2.13.so
f724c000 f7257000 r-xp /lib/libunwind.so.8.0.1
f7284000 f728c000 r-xp /lib/libgcc_s-4.6.so.1
f728d000 f73b1000 r-xp /lib/libc-2.13.so
f73bf000 f73c1000 r-xp /usr/lib/libdlog.so.0.0.0
f73c9000 f73d5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73de000 f73e3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73eb000 f73fa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7402000 f7406000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f740f000 f7412000 r-xp /usr/lib/libappcore-agent.so.1.1
f741a000 f741c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7424000 f7428000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7430000 f744d000 r-xp /lib/ld-2.13.so
f7456000 f7459000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7459000 f745d000 r-xp /usr/lib/libsys-assert.so
f778f000 f77f3000 rw-p [heap]
ffe7d000 ffe9e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18849)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74572aa) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12aa
 1: (0xf73ee539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70f53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70f3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70ffe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7105be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7105dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf713a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71351f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70f3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70ffe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7105be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7105dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7137e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7138017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf713ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ad71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4aca171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b9d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf704afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf704c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71dcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71d7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71d85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71d8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7410183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74107fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf745769f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x169f
28: __libc_start_main + 0x114 (0xf72a485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7456fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
0 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:52:11.531+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:52:11.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:52:11.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:52:11.531+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 15:52:11.541+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 15:52:11.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:52:11.541+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:52:11.541+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 15:52:11.551+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 15:52:11.561+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 15:52:11.561+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:52:11.561+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 15:52:11.561+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 15:52:11.561+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:52:11.571+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:11.571+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:11.571+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 15:52:11.581+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:11:577,8.236095,-4.658825,2.744568
04-23 15:52:11.581+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:11:577,11.830000,-6.790000,-4.760000
04-23 15:52:11.581+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 15:52:11.581+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:52:11.581+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 15:52:11.591+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 15:52:11.601+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 15:52:11.601+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:52:11.601+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 15:52:11.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:52:11.601+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:52:11.601+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 15:52:11.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:52:11.601+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 15:52:11.601+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 15:52:11.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:52:11.621+0200 W/LOCATION(18849): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:52:11.621+0200 W/LOCATION(18849): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:52:11.691+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:11.691+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:11.771+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:11.771+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:11:775,8.267202,-4.369294,3.074777
04-23 15:52:11.771+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:11.781+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:11:781,-10.290000,2.380000,1.680000
04-23 15:52:11.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:52:11.881+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: connection_create(453) > New handle created[0xf7b33b88]
04-23 15:52:11.881+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:52:11.881+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:52:11.881+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:52:11.881+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:52:11.891+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:11.891+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:11.901+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 5427268 to 5427569) (logOverhead=0,0,0,0,0,0,0), start: 15:52:11.613
04-23 15:52:11.911+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 307 ms (from 5427266 to 5427573) (logOverhead=0,0,0,0,0,0,0), start: 15:52:11.611
04-23 15:52:11.911+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 308 ms (from 5427265 to 5427573) (logOverhead=0,0,0,0,0,0,0), start: 15:52:11.610
04-23 15:52:11.911+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:11.931+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:11.931+0200 E/LOCATION(18861): location-common-util.c: location_is_onboard_gps_use_only(156) > Fail to get app_id. Err[-1]
04-23 15:52:11.931+0200 E/PKGMGR_INFO(18861): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 15:52:11.951+0200 W/LOCATION(18861): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:52:11.951+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 15:52:11.961+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:11.961+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:11.961+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:11.971+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:11.971+0200 E/LOCATION(18861): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:52:11.971+0200 I/LOCATION(18861): location.c: location_new(269) > method: 1
04-23 15:52:11.971+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:11:973,7.982457,-5.257031,2.935993
04-23 15:52:11.981+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:11:973,-45.290001,13.300000,11.060000
04-23 15:52:11.981+0200 W/LOCATION(18861): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:52:12.001+0200 W/LOCATION(18861): module-internal.c: module_new(311) > module (gps) open success
04-23 15:52:12.001+0200 W/LOCATION(18861): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:52:12.011+0200 W/LOCATION(18861): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:52:12.011+0200 W/LOCATION(18861): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:52:12.011+0200 W/LOCATION(18861): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:52:12.011+0200 W/LOCATION(18861): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:52:12.021+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:12.031+0200 I/AUL     (18861): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:52:12.031+0200 E/LOCATION(18861): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:52:12.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:52:12.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:52:12.081+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:52:12.091+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:12.091+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:12.111+0200 W/LOCATION(18849): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:52:12.111+0200 I/LOCATION(18849): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:52:12.111+0200 I/LOCATION(18849): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:52:12.111+0200 I/location(18849): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:52:12.111+0200 W/CAPI_APPFW_APP_CONTROL(18849): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:52:12.111+0200 I/utils   (18849): specific action
04-23 15:52:12.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:52:12.161+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(5427820), time2(5173458)
04-23 15:52:12.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 15:52:12.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:52:12.161+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:52:12.161+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:52:12.161+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.161+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.171+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:173,7.853244,-5.328816,3.326023
04-23 15:52:12.171+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:173,7.280000,-8.890000,-2.590000
04-23 15:52:12.291+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:12.291+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:12.361+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.361+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.371+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:372,7.891530,-6.142376,2.426322
04-23 15:52:12.381+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:372,31.850000,-57.540001,6.860000
04-23 15:52:12.491+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:12.491+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:12.571+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.571+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.571+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:575,8.740981,-3.610770,1.473979
04-23 15:52:12.571+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:575,59.779999,-42.209999,-37.730000
04-23 15:52:12.691+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:12.691+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:12.721+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 137 ms (from 5428249 to 5428386) (logOverhead=0,0,0,0,0,0,0), start: 15:52:12.594
04-23 15:52:12.721+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 137 ms (from 5428249 to 5428386) (logOverhead=0,0,0,0,0,0,0), start: 15:52:12.594
04-23 15:52:12.751+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:52:12.751+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:52:12.751+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:52:12.761+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.761+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.781+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:772,9.444471,-2.371287,1.272982
04-23 15:52:12.781+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:772,-8.820000,-13.230000,-19.530001
04-23 15:52:12.781+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.781+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.791+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:794,9.724431,-2.868994,1.134198
04-23 15:52:12.791+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:794,-1.190000,-11.130000,-17.500000
04-23 15:52:12.801+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.801+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.821+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:811,7.980000,-8.820000,-15.330000
04-23 15:52:12.821+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:811,9.518648,-2.770889,0.617348
04-23 15:52:12.821+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.821+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.831+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:833,9.444471,-2.569891,1.354338
04-23 15:52:12.831+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:833,43.820000,-3.360000,-18.129999
04-23 15:52:12.841+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.841+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.851+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:853,55.230000,-4.970000,-20.160000
04-23 15:52:12.851+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:853,9.554541,-1.655833,1.232304
04-23 15:52:12.861+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.861+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.871+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:873,9.449257,-0.416351,0.976272
04-23 15:52:12.871+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:873,18.690001,-4.690000,-13.090000
04-23 15:52:12.891+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.891+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:12.891+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:12.901+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:897,9.298509,-1.205983,0.961915
04-23 15:52:12.911+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.931+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:919,9.430114,-2.313859,1.170090
04-23 15:52:12.941+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.951+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:949,-23.100000,-5.530000,-5.250000
04-23 15:52:12.951+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.951+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.961+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:958,9.698111,-2.926422,1.284946
04-23 15:52:12.961+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:12.971+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:964,-27.719999,-7.420000,-1.750000
04-23 15:52:12.971+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:12.991+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:12:970,9.700503,-2.531606,1.663012
04-23 15:52:13.001+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.001+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:12:981,-4.060000,-4.970000,-4.410000
04-23 15:52:13.001+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.011+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:6,9.410972,-2.507678,1.430908
04-23 15:52:13.011+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.021+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:11,10.780000,-3.920000,-4.550000
04-23 15:52:13.031+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.031+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:21,9.501899,-2.443072,0.677169
04-23 15:52:13.041+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.041+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:45,9.705289,-2.624927,0.535992
04-23 15:52:13.051+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:35,16.799999,-7.770000,-4.130000
04-23 15:52:13.051+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.051+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.051+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:55,9.829715,-2.687140,1.148555
04-23 15:52:13.051+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.061+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:62,9.382257,-2.708675,1.507478
04-23 15:52:13.061+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:56,8.680000,-11.830000,-3.850000
04-23 15:52:13.061+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.071+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:74,9.262616,-2.505285,1.500300
04-23 15:52:13.071+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.071+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:80,10.080000,-7.560000,-5.040000
04-23 15:52:13.081+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.081+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:85,19.040001,-4.550000,-9.590000
04-23 15:52:13.081+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.081+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.091+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:92,9.865608,-2.902494,0.770489
04-23 15:52:13.091+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:13.091+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:13.091+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:89,23.100000,-3.990000,-14.490000
04-23 15:52:13.091+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.101+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:102,26.740000,-11.130000,-15.750000
04-23 15:52:13.101+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.101+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:108,34.650002,-16.240000,-13.160000
04-23 15:52:13.101+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.111+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:114,9.803394,-2.048256,0.849452
04-23 15:52:13.111+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.111+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:119,49.840000,-8.680000,-11.760000
04-23 15:52:13.121+0200 E/CAPI_TELEPHONY(18861): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 15:52:13.121+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.121+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.131+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:133,55.720001,-5.880000,-9.450000
04-23 15:52:13.131+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:133,9.611969,-1.564906,0.760918
04-23 15:52:13.141+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.141+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.151+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:153,57.189999,-5.530000,-6.300000
04-23 15:52:13.151+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:153,9.437292,-1.885544,1.308874
04-23 15:52:13.161+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.161+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.171+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:173,9.705289,-1.636691,1.112662
04-23 15:52:13.171+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:174,62.860001,-3.920000,-8.260000
04-23 15:52:13.181+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.181+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.191+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:193,9.925428,-1.155733,0.811167
04-23 15:52:13.191+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:193,35.840000,-6.790000,-7.490000
04-23 15:52:13.211+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.211+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.211+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:215,6.440000,-1.190000,-1.960000
04-23 15:52:13.211+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:215,9.580862,-1.136591,0.476172
04-23 15:52:13.221+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.221+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.231+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:233,9.449257,-1.538585,0.473779
04-23 15:52:13.231+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:233,5.390000,1.470000,-3.990000
04-23 15:52:13.241+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.241+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.251+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:254,9.851252,-1.703690,1.112662
04-23 15:52:13.251+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:254,24.710001,1.330000,-8.960000
04-23 15:52:13.261+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.261+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.271+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:273,22.120001,3.010000,-13.020000
04-23 15:52:13.281+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:273,9.760324,-1.371087,1.529014
04-23 15:52:13.281+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.281+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.291+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:13.291+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:13.291+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:293,9.387043,-1.088734,0.512064
04-23 15:52:13.301+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:293,4.410000,1.890000,-13.090000
04-23 15:52:13.301+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.301+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.311+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:314,9.700503,-0.904487,0.985843
04-23 15:52:13.321+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:314,-2.940000,2.590000,-8.470000
04-23 15:52:13.321+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.321+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.331+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:333,9.518648,-1.976472,1.378266
04-23 15:52:13.331+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:333,7.000000,3.990000,-8.890000
04-23 15:52:13.341+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.341+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.351+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:354,9.655040,-1.852045,1.612763
04-23 15:52:13.361+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:354,24.010000,2.170000,-9.450000
04-23 15:52:13.371+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.371+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:375,9.645468,-1.103091,1.540978
04-23 15:52:13.381+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.391+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:385,26.670000,2.590000,-11.900000
04-23 15:52:13.391+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.401+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.401+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:399,9.466006,-1.040878,1.512264
04-23 15:52:13.411+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.411+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:406,9.660000,-0.770000,-8.050000
04-23 15:52:13.421+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.431+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:418,9.528220,-1.191626,1.562513
04-23 15:52:13.431+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.431+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:425,0.140000,-2.450000,-8.680000
04-23 15:52:13.431+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.441+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:436,9.695717,-1.572084,1.241875
04-23 15:52:13.451+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:442,-6.370000,-4.900000,-4.970000
04-23 15:52:13.451+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.451+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:458,9.729217,-1.136591,1.339981
04-23 15:52:13.451+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.461+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:463,-7.560000,-4.690000,-5.250000
04-23 15:52:13.461+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.471+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:474,9.650253,-1.103091,0.789631
04-23 15:52:13.471+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.481+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:479,-6.720000,-3.640000,-7.070000
04-23 15:52:13.481+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.491+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.491+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:13.491+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:13.491+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:493,9.805787,-1.615155,1.012164
04-23 15:52:13.501+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:496,-7.910000,-2.520000,-5.810000
04-23 15:52:13.501+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.511+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.511+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:514,-3.430000,-0.840000,-6.300000
04-23 15:52:13.511+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:515,9.621540,-1.380659,1.579263
04-23 15:52:13.521+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.521+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.531+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:532,-10.500000,-4.550000,-9.730000
04-23 15:52:13.531+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:532,9.430114,-0.904487,1.552942
04-23 15:52:13.541+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.541+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.551+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:554,-20.580000,-6.930000,-9.520000
04-23 15:52:13.551+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:554,9.511470,-1.079163,1.349552
04-23 15:52:13.571+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.571+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.571+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:574,9.765109,-1.194018,1.148555
04-23 15:52:13.571+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:574,-23.730000,-8.260000,-11.620000
04-23 15:52:13.581+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.581+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.591+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:594,-23.799999,-6.090000,-12.040000
04-23 15:52:13.601+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:52:13.601+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:52:13.601+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:52:13.611+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.621+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:616,-16.799999,0.350000,-11.130000
04-23 15:52:13.621+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:593,9.951750,-1.756332,0.516850
04-23 15:52:13.621+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.631+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.631+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:633,-13.790000,1.190000,-11.830000
04-23 15:52:13.641+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:637,9.784252,-1.730011,1.019342
04-23 15:52:13.641+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.651+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.651+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:647,9.621540,-0.906880,1.134198
04-23 15:52:13.651+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:656,-18.690001,-0.700000,-6.300000
04-23 15:52:13.651+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.661+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:664,9.664611,-1.284946,0.524028
04-23 15:52:13.671+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.671+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.671+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:676,-20.860001,1.260000,-4.550000
04-23 15:52:13.671+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:676,9.827322,-1.438086,0.775275
04-23 15:52:13.681+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.681+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.691+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:693,-20.860001,3.010000,-2.310000
04-23 15:52:13.691+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:13.691+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:13.691+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:693,9.755538,-1.292124,0.887737
04-23 15:52:13.711+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.711+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.711+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:715,9.822537,-1.237089,0.988236
04-23 15:52:13.711+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:715,-13.160000,3.290000,-2.240000
04-23 15:52:13.721+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.721+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.731+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:734,9.882358,-0.832702,1.208375
04-23 15:52:13.731+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:734,-4.550000,5.670000,-2.730000
04-23 15:52:13.741+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.751+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.761+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:760,9.707682,-0.478565,1.234696
04-23 15:52:13.761+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:754,-2.030000,6.300000,-4.060000
04-23 15:52:13.771+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.771+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.781+0200 W/LOCATION(18849): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 15:52:13.781+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:784,9.655040,-0.765703,1.433301
04-23 15:52:13.791+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.791+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:776,-3.570000,5.950000,-3.570000
04-23 15:52:13.801+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.801+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:798,9.729217,-1.045663,1.708475
04-23 15:52:13.801+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.811+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:805,-6.090000,-0.770000,-0.420000
04-23 15:52:13.811+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:814,9.590433,-0.976272,1.904687
04-23 15:52:13.811+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.821+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:820,-10.220000,-3.570000,3.220000
04-23 15:52:13.821+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.821+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.831+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:833,-6.580000,-8.120000,3.710000
04-23 15:52:13.841+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:833,9.645468,-1.124627,1.088734
04-23 15:52:13.841+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.851+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.851+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:854,-7.910000,-5.670000,2.800000
04-23 15:52:13.851+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:854,9.937392,-1.237089,0.825524
04-23 15:52:13.861+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.861+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.871+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:873,-10.010000,-3.360000,3.220000
04-23 15:52:13.871+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:873,9.698111,-1.062413,0.579063
04-23 15:52:13.881+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.881+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.891+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:893,-6.650000,-5.110000,3.150000
04-23 15:52:13.891+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:13.891+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:13.891+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:893,9.750752,-1.584049,0.583849
04-23 15:52:13.901+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.911+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.911+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:914,4.130000,-1.540000,0.770000
04-23 15:52:13.911+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:915,9.839286,-1.517050,0.916451
04-23 15:52:13.921+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.921+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.931+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:933,3.220000,-1.540000,-0.140000
04-23 15:52:13.931+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:933,9.712467,-1.045663,1.091127
04-23 15:52:13.941+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.941+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.951+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:953,-5.390000,-2.100000,0.070000
04-23 15:52:13.951+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:953,9.647861,-1.004985,0.933201
04-23 15:52:13.961+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.961+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.971+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:974,-8.890000,-5.180000,1.960000
04-23 15:52:13.971+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:974,9.655040,-1.232304,0.533599
04-23 15:52:13.981+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:13.981+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:13.991+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:13:993,-5.600000,-3.920000,1.820000
04-23 15:52:13.991+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:13:993,9.891929,-1.289732,0.928415
04-23 15:52:14.001+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.001+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.011+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:14,-1.890000,-3.920000,-0.490000
04-23 15:52:14.011+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:14,9.908678,-0.959522,1.244268
04-23 15:52:14.021+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.021+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.031+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:33,-6.790000,-0.350000,2.380000
04-23 15:52:14.031+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:33,9.600004,-1.134198,1.155733
04-23 15:52:14.061+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.061+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.061+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:65,-11.480000,-3.010000,1.190000
04-23 15:52:14.071+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.071+0200 W/AUL     (18871): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:52:14.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:52:14.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:52:14.071+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18849
04-23 15:52:14.071+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:52:14.081+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:75,-14.840000,-2.170000,3.290000
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 15:52:14.081+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:52:14.081+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:52:14.081+0200 E/CAPI_LOCATION_MANAGER(18861): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:52:14.081+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:52:14.091+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.091+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18849
04-23 15:52:14.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18849)
04-23 15:52:14.091+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:96,-6.230000,-5.670000,2.730000
04-23 15:52:14.101+0200 I/heartrate(18834): capturing data from es.ugr.frailty.heartrate
04-23 15:52:14.101+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:52:14.111+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:65,9.664611,-1.134198,1.182054
04-23 15:52:14.111+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.111+0200 I/heartrate(18834): es.ugr.frailty.heartrate: waiting for rigth values
04-23 15:52:14.111+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:117,9.616754,-1.282553,0.739382
04-23 15:52:14.111+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.121+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:122,9.853643,-1.665405,0.765703
04-23 15:52:14.121+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.121+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:128,9.815358,-1.162912,1.127020
04-23 15:52:14.121+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.131+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.151+0200 I/accelerometer(18818): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,15:52:14:134,9.583255,-0.569492,0.945165
04-23 15:52:14.151+0200 I/accelerometer(18818): capturing data from es.ugr.frailty.accelerometer
04-23 15:52:14.161+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:139,-2.730000,-4.130000,2.590000
04-23 15:52:14.161+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.161+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:167,-8.750000,-7.490000,4.620000
04-23 15:52:14.161+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.171+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:172,-4.970000,-12.740000,6.930000
04-23 15:52:14.171+0200 I/gyroscope(18830): capturing data from es.ugr.frailty.gyroscope
04-23 15:52:14.171+0200 I/gyroscope(18830): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,15:52:14:177,7.000000,-12.390000,5.950000
04-23 15:52:14.191+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:52:14.191+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:52:14.191+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:52:14.191+0200 I/CAPI_NETWORK_CONNECTION(18861): connection.c: connection_destroy(471) > Destroy handle: 0xf7b33b88
04-23 15:52:14.191+0200 W/CRASH_MANAGER(18872): worker.c: worker_job(1205) > 11188496c6f63152449153
