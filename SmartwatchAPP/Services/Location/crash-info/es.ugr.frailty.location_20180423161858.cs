S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27028
Date: 2018-04-23 16:18:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf761452d, r5   = 0xf7d91f98
r6   = 0xfff09ec0, r7   = 0xfff09d70
r8   = 0xf7d8ec18, r9   = 0x00000000
r10  = 0xfff09e4c, fp   = 0xfff09ec0
ip   = 0x00000001, sp   = 0xfff08bf0
lr   = 0xf7614539, pc   = 0xf767d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     14324 KB
Buffers:     63676 KB
Cached:     218688 KB
VmPeak:      53460 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11588 KB
VmRSS:       11588 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27028 TID = 27028
27028 27032 

Maps Information
f44df000 f4cde000 rw-p [stack:27032]
f4ce5000 f4ce7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cef000 f4cf3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cfc000 f4cfe000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d06000 f4d09000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d18000 f4d1d000 r-xp /usr/lib/libsystem.so.0.0.0
f4d28000 f4d2b000 r-xp /lib/libattr.so.1.1.0
f4d33000 f4d43000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d4b000 f4d54000 r-xp /usr/lib/libedbus.so.1.7.99
f4d5c000 f4d5d000 r-xp /usr/lib/libresponse.so.0.2.96
f4d66000 f4d6b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f660d000 f6713000 r-xp /usr/lib/libicuuc.so.57.1
f6729000 f68b1000 r-xp /usr/lib/libicui18n.so.57.1
f68c1000 f68ce000 r-xp /usr/lib/libail.so.0.1.0
f68d7000 f68de000 r-xp /usr/lib/libminizip.so.1.0.0
f68e7000 f6a90000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ab0000 f6af7000 r-xp /usr/lib/libssl.so.1.0.0
f6b03000 f6b05000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b0d000 f6b14000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b1d000 f6b24000 r-xp /lib/libcrypt-2.13.so
f6b55000 f6b58000 r-xp /lib/libcap.so.2.21
f6b60000 f6b62000 r-xp /usr/lib/libiri.so
f6b6a000 f6bb3000 r-xp /usr/lib/libmdm.so.1.2.69
f6bbb000 f6bc1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bc9000 f6bec000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bf6000 f6bf8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c00000 f6c1d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c26000 f6c2a000 r-xp /usr/lib/libsmack.so.1.0.0
f6c33000 f6c4c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c55000 f6c5d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c65000 f6c6b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c74000 f6c76000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c7f000 f6c8f000 r-xp /lib/libresolv-2.13.so
f6c93000 f6cab000 r-xp /usr/lib/liblzma.so.5.0.3
f6cb4000 f6cb6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cbe000 f6cd8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ce0000 f6d0f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d18000 f6d27000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d31000 f6d3b000 r-xp /usr/lib/libsensord-shared.so
f6d44000 f6e17000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e22000 f6e38000 r-xp /lib/libz.so.1.2.5
f6e40000 f6e45000 r-xp /usr/lib/libffi.so.5.0.10
f6e4d000 f6e4e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e56000 f6e66000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e6e000 f6e87000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e8f000 f6e91000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e99000 f6f0e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f18000 f6f1e000 r-xp /lib/librt-2.13.so
f6f27000 f6f45000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f4f000 f6f50000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f58000 f6f7b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f83000 f6f88000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f90000 f6fba000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fc3000 f6fda000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fe2000 f704b000 r-xp /lib/libm-2.13.so
f7054000 f70e8000 r-xp /usr/lib/libstdc++.so.6.0.16
f70fb000 f7100000 r-xp /usr/lib/libctx-client.so.0.8.3
f7108000 f710f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7117000 f7141000 r-xp /usr/lib/libsensor.so.1.9.6
f714a000 f7216000 r-xp /usr/lib/libxml2.so.2.7.8
f7223000 f7225000 r-xp /usr/lib/libiniparser.so.0
f722e000 f7234000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f723d000 f730d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f730e000 f7342000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f734b000 f7387000 r-xp /usr/lib/libSLP-location.so.0.9.24
f738f000 f7392000 r-xp /usr/lib/libbundle.so.0.1.22
f739a000 f73a0000 r-xp /usr/lib/libappsvc.so.0.1.0
f73a8000 f73e9000 r-xp /usr/lib/libeina.so.1.7.99
f73f2000 f7409000 r-xp /usr/lib/libecore.so.1.7.99
f7420000 f7429000 r-xp /usr/lib/libvconf.so.0.2.45
f7431000 f7445000 r-xp /lib/libpthread-2.13.so
f7450000 f745d000 r-xp /usr/lib/libaul.so.0.1.0
f7467000 f7469000 r-xp /lib/libdl-2.13.so
f7472000 f747d000 r-xp /lib/libunwind.so.8.0.1
f74aa000 f74b2000 r-xp /lib/libgcc_s-4.6.so.1
f74b3000 f75d7000 r-xp /lib/libc-2.13.so
f75e5000 f75e7000 r-xp /usr/lib/libdlog.so.0.0.0
f75ef000 f75fb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7604000 f7609000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7611000 f7620000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7628000 f762c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7635000 f7638000 r-xp /usr/lib/libappcore-agent.so.1.1
f7640000 f7642000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f764a000 f764e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7656000 f7673000 r-xp /lib/ld-2.13.so
f767c000 f767f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f767f000 f7683000 r-xp /usr/lib/libsys-assert.so
f7d5e000 f7dcd000 rw-p [heap]
ffeeb000 fff0c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27028)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf767d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7614539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf731b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7319c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7325e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf732bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf732bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf736075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf735b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7319c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7325e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf732bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf732bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf735de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf735e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7365f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cfd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cf0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dc3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7270fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72727a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7402ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73fdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73fe5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73fe879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7636183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76367fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf767d6c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf74ca85c) [/lib/libc.so.6] + 0x1785c
29: (0xf767cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
=0, bError=0), handler=GPSD
04-23 16:18:56.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:18:56.451+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:18:56.451+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:452,3.187240,0.595813,9.552148
04-23 16:18:56.461+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:18:56.461+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 16:18:56.461+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:18:56.471+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:18:56.471+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:18:56.471+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:18:56.471+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:18:56.471+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:18:56.471+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 16:18:56.471+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:18:56.471+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 16:18:56.501+0200 W/LOCATION(27028): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:18:56.501+0200 W/LOCATION(27028): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:18:56.521+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:56.521+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:56:528,-2.380000,-4.340000,-0.700000
04-23 16:18:56.541+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:56.561+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:553,3.263810,0.605384,9.138189
04-23 16:18:56.571+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:56.571+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:56.591+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:18:56.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:56.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:56.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7361150]
04-23 16:18:56.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:18:56.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:18:56.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:18:56.621+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:18:56.631+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:18:56.631+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:18:56.641+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:18:56.641+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:56.651+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:651,3.416951,0.507278,9.403792
04-23 16:18:56.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:18:56.651+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:18:56.651+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:18:56.651+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:18:56.651+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:18:56.651+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:18:56.651+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:18:56.651+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:18:56.651+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:18:56.651+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:18:56.651+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:18:56.661+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:18:56.661+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:18:56.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:18:56.711+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:18:56.721+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:56.731+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:56:728,-1.120000,-0.630000,0.140000
04-23 16:18:56.731+0200 W/LOCATION(27028): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:18:56.731+0200 I/LOCATION(27028): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:18:56.731+0200 I/LOCATION(27028): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:18:56.731+0200 I/location(27028): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:18:56.741+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:56.741+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:750,3.309274,0.658026,9.138189
04-23 16:18:56.771+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:56.771+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:56.771+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 7032131 to 7032432) (logOverhead=0,0,0,0,0,0,0), start: 16:18:56.476
04-23 16:18:56.771+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 304 ms (from 7032130 to 7032434) (logOverhead=0,0,0,0,0,0,0), start: 16:18:56.475
04-23 16:18:56.771+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 305 ms (from 7032129 to 7032434) (logOverhead=0,0,0,0,0,0,0), start: 16:18:56.475
04-23 16:18:56.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:56.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:56.831+0200 I/LOCATION(27028): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:18:56.841+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:56.841+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:848,3.093920,0.411566,9.671788
04-23 16:18:56.881+0200 E/location(27028): es.ugr.frailty.location: error intentando obtener la última localización
04-23 16:18:56.881+0200 W/AUL     (27028): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:18:56.881+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:18:56.891+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 27028
04-23 16:18:56.891+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 16:18:56.891+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.891+0200 I/utils   (26979): specific action
04-23 16:18:56.891+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.901+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.901+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.901+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:18:56.901+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:18:56.901+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 16:18:56.901+0200 W/AUL     (27028): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 16:18:56.901+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:18:56.901+0200 I/location(27028): request sent to service es.ugr.frailty.servicemanager
04-23 16:18:56.901+0200 W/CAPI_APPFW_APP_CONTROL(27028): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.901+0200 I/utils   (27028): specific action
04-23 16:18:56.901+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 16:18:56.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26984
04-23 16:18:56.911+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26984)
04-23 16:18:56.911+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:18:56.911+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26984), cmd(0)
04-23 16:18:56.911+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 16:18:56.911+0200 I/servicemanager(26979): requesting to save local data
04-23 16:18:56.911+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.911+0200 I/utils   (26984): specific action
04-23 16:18:56.911+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.911+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.911+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.911+0200 W/CAPI_APPFW_APP_CONTROL(26984): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:18:56.921+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:56.921+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:56:928,0.700000,-6.160000,-0.140000
04-23 16:18:56.931+0200 I/recorder(26984): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:18:56.931+0200 I/recorder(26984): guardando datos en local
04-23 16:18:56.941+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:56.941+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:56:948,3.146562,0.614955,9.588040
04-23 16:18:56.971+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:56.971+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:56.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:56.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.041+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.051+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:48,3.239882,0.859023,8.918050
04-23 16:18:57.121+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.131+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:128,5.040000,4.900000,-2.450000
04-23 16:18:57.141+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.151+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:147,3.263810,0.327817,9.418150
04-23 16:18:57.171+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:57.171+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:57.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:57.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.241+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.251+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:253,3.330809,0.605384,9.276974
04-23 16:18:57.311+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:18:57.311+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(7032979), time2(6926911)
04-23 16:18:57.311+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:18:57.311+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:18:57.311+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:18:57.311+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:18:57.321+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.331+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:327,1.400000,-3.360000,0.770000
04-23 16:18:57.341+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.351+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:347,3.242275,0.650848,9.291330
04-23 16:18:57.371+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:57.371+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:57.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:57.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.441+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.451+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:450,3.395415,0.732204,9.523434
04-23 16:18:57.561+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.591+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 139 ms (from 7033115 to 7033254) (logOverhead=0,0,0,0,0,0,0), start: 16:18:57.461
04-23 16:18:57.591+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 140 ms (from 7033115 to 7033255) (logOverhead=0,0,0,0,0,0,0), start: 16:18:57.460
04-23 16:18:57.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:57.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.621+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:57.621+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:57.631+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:18:57.631+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:18:57.631+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:18:57.651+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:569,-5.320000,-5.740000,5.110000
04-23 16:18:57.661+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.671+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.691+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:681,3.570000,6.790000,-7.210000
04-23 16:18:57.691+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:666,3.206382,0.519243,8.630912
04-23 16:18:57.691+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.691+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.701+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:702,3.483950,0.126820,9.401401
04-23 16:18:57.701+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:702,4.550000,4.270000,-7.770000
04-23 16:18:57.701+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.711+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.731+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:722,3.428915,0.325424,9.497113
04-23 16:18:57.731+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:714,3.850000,2.170000,-7.000000
04-23 16:18:57.731+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.731+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.731+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:738,-0.770000,0.420000,-6.020000
04-23 16:18:57.741+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:739,3.505485,0.624527,9.518648
04-23 16:18:57.741+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.751+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.751+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:754,0.490000,-0.630000,-5.810000
04-23 16:18:57.751+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:755,3.400201,0.679562,9.372685
04-23 16:18:57.751+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.761+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:764,3.328416,0.634098,9.401401
04-23 16:18:57.761+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.771+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:57.771+0200 E/CAPI_TELEPHONY(19762): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 16:18:57.771+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:57.771+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.771+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:780,3.354738,0.851845,9.284152
04-23 16:18:57.781+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:771,4.410000,-0.140000,-5.950000
04-23 16:18:57.781+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.781+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:788,3.393023,0.978664,9.262616
04-23 16:18:57.781+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.791+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:792,1.610000,-0.490000,-4.270000
04-23 16:18:57.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:57.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.801+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.801+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.801+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:808,-0.700000,-1.120000,-2.450000
04-23 16:18:57.801+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:809,3.407379,0.813560,9.281759
04-23 16:18:57.821+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.821+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.831+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:830,3.376273,0.787239,9.303294
04-23 16:18:57.831+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:830,1.260000,-0.770000,-0.630000
04-23 16:18:57.841+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.841+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.861+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:850,3.369094,0.945165,9.236296
04-23 16:18:57.861+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:852,0.350000,-0.630000,0.490000
04-23 16:18:57.861+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.861+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.881+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:872,3.541377,0.631705,9.229117
04-23 16:18:57.881+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:872,-2.730000,-1.540000,1.470000
04-23 16:18:57.881+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.881+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.891+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:893,-0.210000,-0.770000,1.820000
04-23 16:18:57.901+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:891,3.450450,0.624527,9.243474
04-23 16:18:57.901+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.901+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.911+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:911,3.433701,0.780060,9.341579
04-23 16:18:57.921+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.931+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:909,0.070000,-0.840000,1.960000
04-23 16:18:57.931+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.931+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:932,3.292524,0.693919,9.296116
04-23 16:18:57.941+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:938,-1.190000,-1.120000,2.730000
04-23 16:18:57.941+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.951+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:950,0.700000,-1.050000,2.170000
04-23 16:18:57.951+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.961+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:959,3.275774,0.643669,9.315259
04-23 16:18:57.961+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.961+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.971+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:57.971+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:57.971+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:972,3.314059,0.684347,9.195618
04-23 16:18:57.971+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:971,0.700000,-1.470000,1.330000
04-23 16:18:57.981+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:57.981+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:57.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:57.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:57.991+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:57:994,3.457629,0.521635,9.181261
04-23 16:18:57.991+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:57:992,-1.050000,-1.610000,1.260000
04-23 16:18:58.001+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.001+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.011+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:10,0.560000,-1.190000,1.260000
04-23 16:18:58.011+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:10,3.534199,0.466600,9.140583
04-23 16:18:58.021+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.021+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.031+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:30,2.310000,-0.700000,-0.770000
04-23 16:18:58.031+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:32,3.507878,0.624527,9.186047
04-23 16:18:58.041+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.051+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:51,3.522235,0.555135,9.339187
04-23 16:18:58.051+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.061+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.071+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:64,2.240000,-0.770000,-0.910000
04-23 16:18:58.081+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:72,3.428915,0.681954,9.379865
04-23 16:18:58.081+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.091+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.101+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:87,1.330000,-1.540000,-0.840000
04-23 16:18:58.101+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.101+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:95,3.345166,0.662812,9.454042
04-23 16:18:58.101+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.121+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:111,1.120000,-2.940000,-0.350000
04-23 16:18:58.131+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.131+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:113,3.299703,0.847059,9.516255
04-23 16:18:58.131+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.141+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:135,1.610000,-4.340000,-0.350000
04-23 16:18:58.141+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:137,3.321238,0.837488,9.533006
04-23 16:18:58.141+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.151+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.151+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:152,1.400000,-6.720000,0.630000
04-23 16:18:58.161+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:158,3.426522,0.897308,9.466006
04-23 16:18:58.161+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.161+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.171+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:58.171+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:58.171+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:166,0.770000,-8.820000,2.870000
04-23 16:18:58.171+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:172,3.582055,0.782453,9.284152
04-23 16:18:58.171+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.181+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.191+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:191,3.550949,0.758525,9.367901
04-23 16:18:58.191+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:181,-3.010000,-11.060000,5.250000
04-23 16:18:58.191+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:58.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:58.201+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:200,-3.640000,-11.830000,5.880000
04-23 16:18:58.201+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.201+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.201+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:209,3.450450,0.619741,9.439686
04-23 16:18:58.211+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:209,-0.840000,-12.460000,6.160000
04-23 16:18:58.221+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.221+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.231+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:233,0.070000,-13.930000,6.510000
04-23 16:18:58.231+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:229,3.333202,0.559920,9.626326
04-23 16:18:58.241+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.241+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.251+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:250,3.268596,0.579063,9.640682
04-23 16:18:58.251+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:250,-7.280000,-17.430000,5.950000
04-23 16:18:58.261+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.271+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.271+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:271,3.519842,0.626920,9.920642
04-23 16:18:58.271+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:275,-12.530000,-22.540001,4.480000
04-23 16:18:58.281+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.281+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.291+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:291,2.833102,-0.145962,10.528419
04-23 16:18:58.291+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:291,-7.210000,-27.299999,2.100000
04-23 16:18:58.301+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.301+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.311+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:310,1.952543,-0.291924,10.995021
04-23 16:18:58.311+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:310,-6.650000,-35.630001,3.640000
04-23 16:18:58.321+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.331+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.331+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:330,1.098306,-0.002393,10.480563
04-23 16:18:58.331+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:335,-20.650000,-49.700001,2.870000
04-23 16:18:58.341+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.341+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.351+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:349,0.387637,0.619741,9.872787
04-23 16:18:58.351+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:350,-39.480000,-65.379997,9.940000
04-23 16:18:58.361+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.361+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.371+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:58.371+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:58.371+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:372,-48.860001,-76.650002,20.299999
04-23 16:18:58.371+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:372,1.660619,0.308674,9.432507
04-23 16:18:58.381+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.391+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.391+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:393,1.689333,0.349352,9.312866
04-23 16:18:58.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:58.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:58.391+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:395,-39.900002,-75.320000,25.760000
04-23 16:18:58.401+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.401+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.421+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:412,-26.809999,-81.199997,24.080000
04-23 16:18:58.431+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:414,0.942772,-0.026321,10.748559
04-23 16:18:58.431+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.431+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.431+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:438,-27.510000,-85.120003,19.809999
04-23 16:18:58.441+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:438,1.560120,1.505085,9.202796
04-23 16:18:58.441+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.451+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.451+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:449,-29.540001,-81.410004,20.930000
04-23 16:18:58.491+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:451,2.581856,2.266003,7.133004
04-23 16:18:58.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:18:58.501+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:18:58.501+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:18:58.501+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.511+0200 W/LOCATION(27028): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 16:18:58.511+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:511,-20.510000,-62.299999,26.040001
04-23 16:18:58.511+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.521+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.521+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:521,12.740000,-50.540001,33.250000
04-23 16:18:58.521+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.531+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:532,27.160000,-36.049999,46.410000
04-23 16:18:58.531+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:503,2.916851,1.081556,7.948956
04-23 16:18:58.531+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.531+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.541+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:540,-2.940000,-25.270000,66.919998
04-23 16:18:58.541+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.541+0200 E/WMS     ( 2471): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
04-23 16:18:58.551+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:550,-49.070000,-12.040000,90.300003
04-23 16:18:58.551+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:541,3.467200,0.677169,9.946963
04-23 16:18:58.551+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.561+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.571+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:563,4.905287,2.531606,8.525627
04-23 16:18:58.571+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:58.571+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:58.571+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.571+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:577,5.948557,3.050849,7.085148
04-23 16:18:58.571+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:570,-84.629997,-4.340000,102.970001
04-23 16:18:58.571+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.581+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.591+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:590,-81.480003,-3.500000,111.160004
04-23 16:18:58.591+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:584,7.467999,3.967300,8.477771
04-23 16:18:58.591+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:58.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:58.591+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:599,7.690532,2.467000,10.011569
04-23 16:18:58.601+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.601+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.601+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:609,-21.770000,27.230000,110.180000
04-23 16:18:58.611+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:605,9.083155,-0.110070,9.925428
04-23 16:18:58.611+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.621+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:616,9.628718,-1.500300,9.552148
04-23 16:18:58.621+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.621+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:629,23.450001,58.590000,100.239998
04-23 16:18:58.631+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.631+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:635,8.774480,-0.928415,7.133004
04-23 16:18:58.641+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.651+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:649,31.010000,86.029999,90.019997
04-23 16:18:58.651+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.651+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:657,7.771888,-0.423530,5.539384
04-23 16:18:58.661+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.671+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:671,47.670002,103.949997,67.550003
04-23 16:18:58.671+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.671+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:676,6.740582,-2.151148,6.238089
04-23 16:18:58.681+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.681+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:690,75.250000,107.940002,52.920002
04-23 16:18:58.691+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.691+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:695,6.340980,-5.044070,8.341379
04-23 16:18:58.701+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.701+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:709,102.340004,118.930000,39.410000
04-23 16:18:58.701+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.711+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:713,6.625726,-5.369494,8.580662
04-23 16:18:58.721+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.721+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.731+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:734,6.465407,-3.223132,6.403193
04-23 16:18:58.741+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.751+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:752,5.060820,-2.656033,4.529613
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:18:58.771+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:18:58.771+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:18:58.771+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:18:58.771+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:18:58.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:18:58.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:18:58.781+0200 I/heartrate(27005): capturing data from es.ugr.frailty.heartrate
04-23 16:18:58.791+0200 I/heartrate(27005): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:18:58.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:18:58.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:18:58.821+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:732,87.849998,138.389999,30.309999
04-23 16:18:58.831+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.831+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:834,34.860001,159.320007,28.770000
04-23 16:18:58.831+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.831+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:839,8.470000,161.350006,28.350000
04-23 16:18:58.831+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.841+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:843,13.020000,133.910004,6.580000
04-23 16:18:58.841+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.851+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:847,105.349998,114.660004,-14.770000
04-23 16:18:58.851+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.851+0200 I/gyroscope(26992): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:18:58:858,159.460007,108.639999,-26.110001
04-23 16:18:58.851+0200 I/gyroscope(26992): capturing data from es.ugr.frailty.gyroscope
04-23 16:18:58.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:18:58.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:18:58.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:18:58.861+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7361150
04-23 16:18:58.881+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:776,3.433701,-5.553742,6.857830
04-23 16:18:58.881+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.891+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:895,1.270589,-11.511869,11.502297
04-23 16:18:58.891+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.901+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:901,1.842474,-10.715059,12.784851
04-23 16:18:58.901+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.901+0200 I/accelerometer(26990): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:18:58:905,3.383451,-3.795017,10.119246
04-23 16:18:58.901+0200 I/accelerometer(26990): capturing data from es.ugr.frailty.accelerometer
04-23 16:18:58.911+0200 W/AUL     (27046): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:18:58.911+0200 W/CRASH_MANAGER(27041): worker.c: worker_job(1205) > 11270286c6f63152449313
