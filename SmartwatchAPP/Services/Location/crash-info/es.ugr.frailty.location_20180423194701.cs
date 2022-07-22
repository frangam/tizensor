S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21885
Date: 2018-04-23 19:47:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75c452d, r5   = 0xf77f4f98
r6   = 0xffc0dc08, r7   = 0xffc0dab8
r8   = 0xf77f1c18, r9   = 0x00000000
r10  = 0xffc0db94, fp   = 0xffc0dc08
ip   = 0x00000001, sp   = 0xffc0da90
lr   = 0xf75c4539, pc   = 0xf762d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9464 KB
Buffers:     57600 KB
Cached:     232096 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11672 KB
VmRSS:       11668 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21885 TID = 21885
21885 21915 

Maps Information
f448f000 f4c8e000 rw-p [stack:21915]
f4c95000 f4c97000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c9f000 f4ca3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cac000 f4cae000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cb6000 f4cb9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cc8000 f4ccd000 r-xp /usr/lib/libsystem.so.0.0.0
f4cd8000 f4cdb000 r-xp /lib/libattr.so.1.1.0
f4ce3000 f4cf3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cfb000 f4d04000 r-xp /usr/lib/libedbus.so.1.7.99
f4d0c000 f4d0d000 r-xp /usr/lib/libresponse.so.0.2.96
f4d16000 f4d1b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65bd000 f66c3000 r-xp /usr/lib/libicuuc.so.57.1
f66d9000 f6861000 r-xp /usr/lib/libicui18n.so.57.1
f6871000 f687e000 r-xp /usr/lib/libail.so.0.1.0
f6887000 f688e000 r-xp /usr/lib/libminizip.so.1.0.0
f6897000 f6a40000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a60000 f6aa7000 r-xp /usr/lib/libssl.so.1.0.0
f6ab3000 f6ab5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6abd000 f6ac4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6acd000 f6ad4000 r-xp /lib/libcrypt-2.13.so
f6b05000 f6b08000 r-xp /lib/libcap.so.2.21
f6b10000 f6b12000 r-xp /usr/lib/libiri.so
f6b1a000 f6b63000 r-xp /usr/lib/libmdm.so.1.2.69
f6b6b000 f6b71000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b79000 f6b9c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ba6000 f6ba8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bb0000 f6bcd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bd6000 f6bda000 r-xp /usr/lib/libsmack.so.1.0.0
f6be3000 f6bfc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c05000 f6c0d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c15000 f6c1b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c24000 f6c26000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c2f000 f6c3f000 r-xp /lib/libresolv-2.13.so
f6c43000 f6c5b000 r-xp /usr/lib/liblzma.so.5.0.3
f6c64000 f6c66000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c6e000 f6c88000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c90000 f6cbf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cc8000 f6cd7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ce1000 f6ceb000 r-xp /usr/lib/libsensord-shared.so
f6cf4000 f6dc7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dd2000 f6de8000 r-xp /lib/libz.so.1.2.5
f6df0000 f6df5000 r-xp /usr/lib/libffi.so.5.0.10
f6dfd000 f6dfe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e06000 f6e16000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e1e000 f6e37000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e3f000 f6e41000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e49000 f6ebe000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ec8000 f6ece000 r-xp /lib/librt-2.13.so
f6ed7000 f6ef5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eff000 f6f00000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f08000 f6f2b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f33000 f6f38000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f40000 f6f6a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f73000 f6f8a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f92000 f6ffb000 r-xp /lib/libm-2.13.so
f7004000 f7098000 r-xp /usr/lib/libstdc++.so.6.0.16
f70ab000 f70b0000 r-xp /usr/lib/libctx-client.so.0.8.3
f70b8000 f70bf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70c7000 f70f1000 r-xp /usr/lib/libsensor.so.1.9.6
f70fa000 f71c6000 r-xp /usr/lib/libxml2.so.2.7.8
f71d3000 f71d5000 r-xp /usr/lib/libiniparser.so.0
f71de000 f71e4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71ed000 f72bd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72be000 f72f2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72fb000 f7337000 r-xp /usr/lib/libSLP-location.so.0.9.24
f733f000 f7342000 r-xp /usr/lib/libbundle.so.0.1.22
f734a000 f7350000 r-xp /usr/lib/libappsvc.so.0.1.0
f7358000 f7399000 r-xp /usr/lib/libeina.so.1.7.99
f73a2000 f73b9000 r-xp /usr/lib/libecore.so.1.7.99
f73d0000 f73d9000 r-xp /usr/lib/libvconf.so.0.2.45
f73e1000 f73f5000 r-xp /lib/libpthread-2.13.so
f7400000 f740d000 r-xp /usr/lib/libaul.so.0.1.0
f7417000 f7419000 r-xp /lib/libdl-2.13.so
f7422000 f742d000 r-xp /lib/libunwind.so.8.0.1
f745a000 f7462000 r-xp /lib/libgcc_s-4.6.so.1
f7463000 f7587000 r-xp /lib/libc-2.13.so
f7595000 f7597000 r-xp /usr/lib/libdlog.so.0.0.0
f759f000 f75ab000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75b4000 f75b9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75c1000 f75d0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75d8000 f75dc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75e5000 f75e8000 r-xp /usr/lib/libappcore-agent.so.1.1
f75f0000 f75f2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75fa000 f75fe000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7606000 f7623000 r-xp /lib/ld-2.13.so
f762c000 f762f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f762f000 f7633000 r-xp /usr/lib/libsys-assert.so
f77c1000 f784f000 rw-p [heap]
ffbef000 ffc10000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21885)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf762d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75c4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72cb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72c9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72d5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72dbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72dbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf730b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72c9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72d5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72dbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72dbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf730de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf730e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73128d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf75fc0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4ca0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d73663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7220fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72227a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73b2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73adb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73ae5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73ae879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75e6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75e67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf762d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf747a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf762cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:46:59.969+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:46:59.969+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:46:59.979+0200 W/LOCATION(21885): module-internal.c: module_new(311) > module (gps) open success
04-23 19:46:59.979+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:46:59.979+0200 W/LOCATION(21885): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:46:59.979+0200 W/LOCATION(21885): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:46:59.979+0200 W/LOCATION(21885): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:46:59.979+0200 W/LOCATION(21885): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:46:59.989+0200 E/CAPI_APPFW_APPLICATION(21902): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:46:59.989+0200 E/CAPI_APPFW_APPLICATION(21902): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:46:59.989+0200 I/utils   (21902): trying to start service: es.ugr.frailty.gravity
04-23 19:46:59.989+0200 I/utils   (21902): es.ugr.frailty.gravity sensor supported
04-23 19:46:59.999+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21902
04-23 19:46:59.999+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(21902) type(svcapp) bg(0)
04-23 19:46:59.999+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21902) was created
04-23 19:47:00.009+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21902]
04-23 19:47:00.009+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21902)
04-23 19:47:00.009+0200 I/servicemanager(21592): es.ugr.frailty.gravity launch request sent!
04-23 19:47:00.009+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:00.009+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:00.019+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:00.029+0200 I/utils   (21902): es.ugr.frailty.gravity listener started
04-23 19:47:00.029+0200 W/CAPI_APPFW_APP_CONTROL(21902): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:00.029+0200 I/utils   (21902): specific action
04-23 19:47:00.029+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21902
04-23 19:47:00.029+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:00.039+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:00.039+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:00.049+0200 W/LOCATION(21885): module-internal.c: module_new(311) > module (wps) open success
04-23 19:47:00.049+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.049+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.049+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:57,2.906882,-2.219232,9.099199
04-23 19:47:00.059+0200 W/LOCATION(21885): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 19:47:00.059+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.059+0200 W/LOCATION(21885): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 19:47:00.059+0200 W/LOCATION(21885): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:00.059+0200 W/LOCATION(21885): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:00.059+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:64,2.002793,-1.529014,6.269196
04-23 19:47:00.059+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.079+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:57,-44.029999,5.250000,58.799999
04-23 19:47:00.079+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:68,9.520600,4.255958,3.781816
04-23 19:47:00.099+0200 W/LOCATION(21885): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 19:47:00.099+0200 I/LOCATION(21885): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77f1c18
04-23 19:47:00.099+0200 I/LOCATION(21885): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 19:47:00.099+0200 I/LOCATION(21885): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77f1c18
04-23 19:47:00.109+0200 I/LOCATION(21885): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 19:47:00.109+0200 I/location(21885): es.ugr.frailty.location: creado servicio de localización
04-23 19:47:00.119+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:00:19,88
04-23 19:47:00.159+0200 I/LOCATION(21885): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 19:47:00.189+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:00.189+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21902
04-23 19:47:00.199+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:00.199+0200 W/LOCATION(21885): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:00.199+0200 W/LOCATION(21885): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:00.199+0200 I/LOCATION(21885): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:00.209+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:00.229+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:00:222,88
04-23 19:47:00.259+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.269+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.269+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:275,-1.263410,-11.260624,2.924029
04-23 19:47:00.269+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.269+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:270,1.791369,-3.210761,9.091336
04-23 19:47:00.279+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.279+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:283,-4.170292,-9.041391,-6.175170
04-23 19:47:00.279+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:279,13.650000,5.600000,38.220001
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 19:47:00.319+0200 W/libgps  ( 3158): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHookStateIdle             : EXIT
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHookStateGps              : ENTRY
04-23 19:47:00.319+0200 W/libgps  ( 3158): [proxy__gps_start][line = 1022]: called.
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:00.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:26
04-23 19:47:00.319+0200 D/gpsd_d  ( 3126): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 19:47:00.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:27
04-23 19:47:00.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:8
04-23 19:47:00.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 19:47:00.319+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:1
04-23 19:47:00.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(11), data(0xf7672238), size(4)
04-23 19:47:00.319+0200 W/libgps_d( 3158): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 19:47:00.319+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 19:47:00.319+0200 W/libgps_d( 3158): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 19:47:00.379+0200 W/LOCATION(21885): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:00.379+0200 W/LOCATION(21885): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:00.409+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:00.409+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:00:419,88
04-23 19:47:00.449+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.449+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.449+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:454,1.808974,-4.831109,5.194818
04-23 19:47:00.449+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.449+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:458,98.209999,-30.030001,-52.990002
04-23 19:47:00.469+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.479+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:00.499+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:453,2.240032,-2.259747,9.276108
04-23 19:47:00.519+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_create(453) > New handle created[0xf400c9a0]
04-23 19:47:00.519+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:47:00.519+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:47:00.519+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:47:00.519+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:47:00.529+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:00.529+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:00.529+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:473,0.017604,-1.620348,-3.896518
04-23 19:47:00.539+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.549+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:47:00.549+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(3280837), time2(3276081)
04-23 19:47:00.549+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 19:47:00.549+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:47:00.549+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:47:00.549+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:47:00.599+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:47:00.609+0200 W/libgps_d( 3158): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 19:47:00.609+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 19:47:00.609+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:47:00.609+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.609+0200 E/LOCATION(21673): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:47:00.609+0200 I/LOCATION(21673): location.c: location_new(269) > method: 1
04-23 19:47:00.609+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:00.609+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:00.609+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:00.609+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:00.609+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:00.609+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:00.609+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:00.609+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:00.619+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.619+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.629+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.629+0200 E/LOCATION(21673): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:47:00.639+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:00.639+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:638,-184.169998,-34.860001,60.410000
04-23 19:47:00.639+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:00:623,88
04-23 19:47:00.639+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.649+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.649+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:653,2.289078,-7.125865,6.336604
04-23 19:47:00.649+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.659+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:652,-0.033500,-7.604390,4.153940
04-23 19:47:00.659+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.659+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.659+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.669+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:672,2.115536,-7.539975,5.902853
04-23 19:47:00.669+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:671,-1.258625,-6.228518,3.201597
04-23 19:47:00.669+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:661,-2.273532,-5.344643,-5.122168
04-23 19:47:00.669+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.689+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:00.689+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:683,-3.547702,0.897348,-3.135007
04-23 19:47:00.689+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.699+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:664,-218.190002,-15.400000,59.010002
04-23 19:47:00.699+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.699+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.699+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.709+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:704,-251.089996,7.700000,55.020000
04-23 19:47:00.709+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.709+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:708,1.967317,-8.104513,5.159158
04-23 19:47:00.709+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.709+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.709+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:718,1.800235,-8.556287,4.440664
04-23 19:47:00.719+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:00.719+0200 E/LOCATION(21673): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:47:00.719+0200 I/LOCATION(21673): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:47:00.719+0200 I/LOCATION(21673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:00.719+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:702,-3.869475,-3.254047,-4.895474
04-23 19:47:00.719+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.719+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:727,-3.879183,-9.008953,-4.831341
04-23 19:47:00.719+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:706,-1.753939,-10.794022,1.007378
04-23 19:47:00.719+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.739+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:715,-414.750000,-8.750000,24.920000
04-23 19:47:00.739+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.739+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:744,-353.779999,-25.059999,44.590000
04-23 19:47:00.739+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.749+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:731,-1.911865,-17.113466,0.327817
04-23 19:47:00.749+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.749+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.759+0200 W/LOCATION(21885): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:47:00.759+0200 I/LOCATION(21885): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:00.759+0200 I/LOCATION(21885): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:00.759+0200 I/location(21885): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:47:00.769+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:758,1.689020,-8.717483,4.162101
04-23 19:47:00.769+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.769+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:778,1.739150,-8.769274,4.030580
04-23 19:47:00.769+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.779+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.779+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:756,-0.768096,-15.900306,4.651647
04-23 19:47:00.779+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.789+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:783,-2.568331,-7.344019,0.210983
04-23 19:47:00.789+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.789+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:748,-94.220001,-26.950001,42.910000
04-23 19:47:00.789+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.799+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:786,0.806381,-0.990629,-0.303888
04-23 19:47:00.799+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.809+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:805,-0.323031,-7.116255,-0.923629
04-23 19:47:00.809+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:00.809+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:00:818,88
04-23 19:47:00.819+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:799,54.040001,2.170000,28.980000
04-23 19:47:00.819+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.819+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:782,1.552668,-9.082821,3.355886
04-23 19:47:00.819+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.819+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:795,-0.882639,7.726854,-4.465990
04-23 19:47:00.819+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.829+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.849+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:831,-2.062181,1.653019,-4.954209
04-23 19:47:00.849+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.849+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:855,-1.827842,-5.003725,0.199848
04-23 19:47:00.849+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.849+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:833,-0.275175,-14.086546,3.555735
04-23 19:47:00.849+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.859+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:825,-239.259995,4.480000,65.870003
04-23 19:47:00.859+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.859+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:863,-240.449997,-1.540000,86.099998
04-23 19:47:00.859+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.859+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:829,1.326576,-9.336869,2.689508
04-23 19:47:00.859+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.869+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:872,1.170388,-9.418713,2.467476
04-23 19:47:00.869+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.869+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:876,1.000658,-9.442542,2.451014
04-23 19:47:00.869+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.879+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:862,-0.064606,-12.203396,2.878566
04-23 19:47:00.879+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.879+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:886,-1.127020,-7.341179,-0.378066
04-23 19:47:00.899+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:867,-37.099998,-6.230000,66.430000
04-23 19:47:00.899+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.899+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:859,-1.391183,-2.866527,0.189058
04-23 19:47:00.899+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.899+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.909+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:904,10.570000,9.100000,57.820000
04-23 19:47:00.909+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.909+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:912,-2.134398,-8.867801,-3.294917
04-23 19:47:00.909+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.919+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:907,-2.297407,2.077533,-2.845542
04-23 19:47:00.919+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.919+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:924,-3.135056,0.574741,-5.745931
04-23 19:47:00.919+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.919+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:928,-3.438164,-7.065003,-4.910717
04-23 19:47:00.919+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.929+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:880,0.743846,-9.584258,1.938831
04-23 19:47:00.929+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.929+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:934,0.575075,-9.668303,1.537400
04-23 19:47:00.929+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.929+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:939,0.474292,-9.644970,1.708796
04-23 19:47:00.929+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.939+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:915,-109.620003,21.559999,64.190002
04-23 19:47:00.939+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.939+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:946,-152.529999,35.139999,52.009998
04-23 19:47:00.939+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.949+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:920,-2.694318,-16.649261,-2.971886
04-23 19:47:00.949+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.949+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:954,-2.093720,-17.596817,0.205783
04-23 19:47:00.949+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.949+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:957,-1.380659,-12.859028,0.375673
04-23 19:47:00.949+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.969+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:943,0.428631,-9.435569,2.637558
04-23 19:47:00.969+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.969+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:976,0.278965,-8.791032,4.337087
04-23 19:47:00.969+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:00.979+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:949,-37.310001,26.530001,31.639999
04-23 19:47:00.979+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.979+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:985,93.660004,35.840000,2.380000
04-23 19:47:00.979+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:00.979+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:931,-2.668794,-7.928514,-1.331617
04-23 19:47:00.979+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:00.999+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:00:992,-1.854951,-3.214058,-1.333122
04-23 19:47:00.999+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:00:961,-1.686940,-9.312866,1.028914
04-23 19:47:00.999+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:00.999+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.009+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:00:989,108.570000,31.360001,-1.610000
04-23 19:47:01.009+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.009+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:01.009+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:01:19,88
04-23 19:47:01.019+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:12,-2.115571,0.122703,-1.608644
04-23 19:47:01.019+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.019+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:25,-2.006583,0.758327,-2.286438
04-23 19:47:01.019+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.019+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:29,-2.372330,-3.135175,-1.279323
04-23 19:47:01.019+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.029+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:8,-1.727618,-8.032705,2.050649
04-23 19:47:01.029+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.029+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:00:980,0.163754,-8.431729,5.004948
04-23 19:47:01.029+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.029+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:37,0.058844,-8.376955,5.098386
04-23 19:47:01.029+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.039+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:35,-2.208575,-11.566904,3.725625
04-23 19:47:01.039+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.039+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:46,-2.548356,-14.802001,3.034099
04-23 19:47:01.039+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.039+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:16,78.190002,24.500000,6.370000
04-23 19:47:01.039+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.059+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:53,80.849998,23.590000,15.960000
04-23 19:47:01.059+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.059+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:66,167.649994,19.600000,6.580000
04-23 19:47:01.059+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:41,-0.031792,-8.370859,5.108629
04-23 19:47:01.069+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.069+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:32,-2.607200,-6.425046,-2.064287
04-23 19:47:01.069+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.069+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:50,-1.447658,-12.643675,3.471986
04-23 19:47:01.069+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.079+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:73,-0.121320,-7.858576,5.865020
04-23 19:47:01.079+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.079+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.079+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:85,258.510010,23.240000,-7.630000
04-23 19:47:01.079+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.089+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:95,-0.327817,-8.839087,2.435893
04-23 19:47:01.089+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.089+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:98,-1.237089,-9.214760,4.883751
04-23 19:47:01.089+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.099+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:78,-1.415865,-4.272816,-1.636643
04-23 19:47:01.099+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.099+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:84,-0.215304,-7.052229,6.811027
04-23 19:47:01.099+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.109+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:89,287.769989,36.259998,-19.670000
04-23 19:47:01.109+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.109+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:116,239.889999,31.150000,-25.830000
04-23 19:47:01.109+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.109+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:119,213.360001,12.810000,-35.490002
04-23 19:47:01.129+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:109,-0.206497,-0.980511,-3.429127
04-23 19:47:01.129+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.129+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:139,-1.021785,-2.162530,-1.927276
04-23 19:47:01.129+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.139+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:112,-0.328185,-6.321547,7.490042
04-23 19:47:01.139+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.139+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:144,-0.381585,-5.502422,8.108521
04-23 19:47:01.139+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.149+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:102,-1.172483,-10.023535,7.101898
04-23 19:47:01.149+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:142,-0.844298,-3.701988,-0.388144
04-23 19:47:01.149+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.149+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:158,-0.106550,-3.738658,-0.760163
04-23 19:47:01.149+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.159+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.169+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:171,-0.488136,-9.241080,7.348359
04-23 19:47:01.169+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.169+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:147,-0.395818,-4.737627,8.577214
04-23 19:47:01.169+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.169+0200 I/LOCATION(21885): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:01.169+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:179,-0.361866,-4.222465,8.843655
04-23 19:47:01.179+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.179+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.189+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:161,0.312069,-2.735158,-0.001338
04-23 19:47:01.189+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:191,-0.252919,-4.065896,8.920477
04-23 19:47:01.199+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.199+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:185,206.850006,8.050000,-55.160000
04-23 19:47:01.199+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.199+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.199+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:206,-0.113392,-4.092866,8.911003
04-23 19:47:01.199+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:203,1.149105,-2.582724,0.734815
04-23 19:47:01.199+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.209+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:212,0.757805,-2.421047,-0.746594
04-23 19:47:01.209+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.229+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:01.229+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:218,0.021056,-4.166755,8.877392
04-23 19:47:01.229+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.229+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.229+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:01:233,88
04-23 19:47:01.239+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:235,0.364639,-3.248313,-1.593751
04-23 19:47:01.239+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:237,0.167985,-4.210688,8.855070
04-23 19:47:01.239+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.239+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.249+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:251,0.964787,1.123085,-1.222752
04-23 19:47:01.249+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:254,0.352837,-4.319258,8.797153
04-23 19:47:01.249+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.249+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.249+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:259,1.344279,2.774994,-1.683781
04-23 19:47:01.259+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:175,-0.083749,-7.472785,8.575876
04-23 19:47:01.259+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.259+0200 I/accelerometer(21859): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:01:265,0.787239,-6.805188,9.578469
04-23 19:47:01.259+0200 I/accelerometer(21859): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:01.259+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.259+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:263,0.530256,-4.434216,8.730803
04-23 19:47:01.259+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.269+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:277,1.176177,3.072597,-0.857768
04-23 19:47:01.279+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:281,0.704418,-4.636910,8.612389
04-23 19:47:01.279+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.279+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:285,1.240433,2.802311,-1.447051
04-23 19:47:01.299+0200 E/location(21885): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:47:01.299+0200 W/AUL     (21885): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:47:01.299+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:01.299+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21885
04-23 19:47:01.299+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.309+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21592
04-23 19:47:01.309+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.309+0200 I/utils   (21592): specific action
04-23 19:47:01.309+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.309+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.309+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.309+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:47:01.309+0200 W/AUL     (21885): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21592)
04-23 19:47:01.309+0200 I/location(21885): request sent to service es.ugr.frailty.servicemanager
04-23 19:47:01.309+0200 W/CAPI_APPFW_APP_CONTROL(21885): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.309+0200 I/utils   (21885): specific action
04-23 19:47:01.309+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.319+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:01.319+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:323,1.477836,3.964527,-3.403214
04-23 19:47:01.319+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.319+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:01.319+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:327,0.771172,2.494088,-4.302522
04-23 19:47:01.319+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.329+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21598
04-23 19:47:01.329+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:01.329+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21592), cmd(0)
04-23 19:47:01.329+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21598)
04-23 19:47:01.329+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:01.329+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(21598), cmd(0)
04-23 19:47:01.329+0200 I/servicemanager(21592): request sent to service es.ugr.frailty.recorder
04-23 19:47:01.329+0200 I/servicemanager(21592): requesting to save local data
04-23 19:47:01.329+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.329+0200 I/utils   (21598): specific action
04-23 19:47:01.329+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.329+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.329+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.329+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:01.329+0200 I/recorder(21598): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:47:01.329+0200 I/recorder(21598): guardando datos en local
04-23 19:47:01.359+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:308,0.899018,-4.937160,8.425355
04-23 19:47:01.359+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.359+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:365,1.033920,-5.377217,8.135535
04-23 19:47:01.359+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.369+0200 I/LOCATION(21885): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:01.399+0200 I/gyroscope(21872): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:01:206,170.520004,-5.740000,-67.970001
04-23 19:47:01.399+0200 I/gyroscope(21872): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:01.409+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:47:01.409+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:47:01:419,88
04-23 19:47:01.439+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:331,-0.607997,0.907424,-2.971824
04-23 19:47:01.439+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.439+0200 I/linearacceleration(21889): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:01:445,-1.959955,1.051136,-4.516570
04-23 19:47:01.439+0200 I/linearacceleration(21889): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:01.469+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:369,1.057861,-5.817639,7.823451
04-23 19:47:01.469+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.469+0200 I/gravity (21902): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:01:474,0.970236,-6.222076,7.517632
04-23 19:47:01.469+0200 I/gravity (21902): capturing data from es.ugr.frailty.gravity
04-23 19:47:01.479+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11218856c6f63152450562
