S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26588
Date: 2018-04-23 12:54:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf70a2648, r1   = 0xf760c1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf760c1b8, r5   = 0x00012cd0
r6   = 0xf761ee88, r7   = 0xf70a2250
r8   = 0x000005c8, r9   = 0xf6b85824
r10  = 0xf76049d8, fp   = 0x00000000
ip   = 0xf70a1030, sp   = 0xff8d8340
lr   = 0xf6fe55d0, pc   = 0xf6fe19fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13896 KB
Buffers:     71932 KB
Cached:     185384 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7752 KB
VmRSS:        7752 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f671c000 f671f000 r-xp /lib/libattr.so.1.1.0
f6728000 f672f000 r-xp /lib/libcrypt-2.13.so
f675f000 f6762000 r-xp /lib/libcap.so.2.21
f676a000 f676c000 r-xp /usr/lib/libiri.so
f6774000 f6791000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f679a000 f679e000 r-xp /usr/lib/libsmack.so.1.0.0
f67a8000 f67aa000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f67b2000 f67b7000 r-xp /usr/lib/libffi.so.5.0.10
f67bf000 f67c0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67c8000 f67ca000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67d2000 f67d4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67de000 f67ee000 r-xp /lib/libresolv-2.13.so
f67f2000 f680a000 r-xp /usr/lib/liblzma.so.5.0.3
f6812000 f6814000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f681c000 f684b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6854000 f6863000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f686c000 f6876000 r-xp /usr/lib/libsensord-shared.so
f687f000 f68b3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f68bc000 f698f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f699a000 f69b0000 r-xp /lib/libz.so.1.2.5
f69b8000 f69be000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f69c7000 f6a3c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a46000 f6a60000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a68000 f6a6e000 r-xp /lib/librt-2.13.so
f6a77000 f6a95000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a9f000 f6aa0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aa8000 f6aad000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ab5000 f6b85000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b86000 f6bb0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bb9000 f6bd0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bd8000 f6c41000 r-xp /lib/libm-2.13.so
f6c4a000 f6cde000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cf1000 f6cf6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6cfe000 f6d05000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d0d000 f6d37000 r-xp /usr/lib/libsensor.so.1.9.6
f6d40000 f6e0c000 r-xp /usr/lib/libxml2.so.2.7.8
f6e19000 f6e1b000 r-xp /usr/lib/libiniparser.so.0
f6e24000 f6e27000 r-xp /usr/lib/libbundle.so.0.1.22
f6e2f000 f6e35000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e3d000 f6e60000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e68000 f6ea9000 r-xp /usr/lib/libeina.so.1.7.99
f6eb2000 f6ec9000 r-xp /usr/lib/libecore.so.1.7.99
f6ee0000 f6ee9000 r-xp /usr/lib/libvconf.so.0.2.45
f6ef1000 f6f05000 r-xp /lib/libpthread-2.13.so
f6f10000 f6f1d000 r-xp /usr/lib/libaul.so.0.1.0
f6f27000 f6f29000 r-xp /lib/libdl-2.13.so
f6f32000 f6f3d000 r-xp /lib/libunwind.so.8.0.1
f6f6a000 f6f72000 r-xp /lib/libgcc_s-4.6.so.1
f6f73000 f7097000 r-xp /lib/libc-2.13.so
f70a5000 f70a7000 r-xp /usr/lib/libdlog.so.0.0.0
f70af000 f70bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70c4000 f70c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70d1000 f70d5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70de000 f70e0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f70e9000 f70ec000 r-xp /usr/lib/libappcore-agent.so.1.1
f710a000 f7127000 r-xp /lib/ld-2.13.so
f7130000 f7133000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7133000 f7137000 r-xp /usr/lib/libsys-assert.so
f75fa000 f7648000 rw-p [heap]
ff8ba000 ff8db000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26588)
Call Stack Count: 1
 0: (0xf6fe19fc) [/lib/libc.so.6] + 0x6e9fc
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: recorder
App ID: es.ugr.frailty.recorder
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:19.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:19.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26445
04-23 12:54:19.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:19.451+0200 E/CAPI_APPFW_APPLICATION(26445): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:19.451+0200 E/CAPI_APPFW_APPLICATION(26445): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:19.451+0200 I/utils   (26445): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:19.451+0200 I/utils   (26445): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:19.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26445
04-23 12:54:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26445) type(svcapp) bg(0)
04-23 12:54:19.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26445) was created
04-23 12:54:19.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26445]
04-23 12:54:19.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26445)
04-23 12:54:19.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:19.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:19.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:19.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:19.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:19.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:19.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26457
04-23 12:54:19.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:19.531+0200 E/CAPI_APPFW_APPLICATION(26457): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:19.531+0200 I/utils   (26445): es.ugr.frailty.accelerometer listener started
04-23 12:54:19.531+0200 E/CAPI_APPFW_APPLICATION(26457): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:19.531+0200 I/utils   (26457): specific action
04-23 12:54:19.531+0200 I/accelerometer(26445): stopping es.ugr.frailty.accelerometer service
04-23 12:54:19.531+0200 I/recorder(26457): obteniendo datos locales...
04-23 12:54:19.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26457
04-23 12:54:19.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26457) type(svcapp) bg(0)
04-23 12:54:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:19.541+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26457]
04-23 12:54:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26445
04-23 12:54:19.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26457) was created
04-23 12:54:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:19.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26457)
04-23 12:54:19.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:19.551+0200 E/CAPI_APPFW_APP_CONTROL(26445): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:19.551+0200 E/accelerometer(26445): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:19.551+0200 I/CAPI_APPFW_APPLICATION(26445): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:19.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:19.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26457
04-23 12:54:19.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:19.671+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:19.681+0200 I/recorder(26457): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:19.681+0200 I/recorder(26457): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:19.691+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:19.701+0200 I/accelerometer(26445): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:19.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:19.721+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26445
04-23 12:54:19.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26457
04-23 12:54:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:19.791+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11264577265631524480859
04-23 12:54:19.871+0200 W/AUL     (26465): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:19.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:19.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:19.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26445
04-23 12:54:19.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:19.871+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26445
04-23 12:54:19.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26445)
04-23 12:54:19.881+0200 W/AUL     (26466): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26457
04-23 12:54:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:19.881+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26457
04-23 12:54:19.891+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26457)
04-23 12:54:21.561+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:29.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:29.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:29.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:29.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:29.381+0200 I/utils   (25866): specific action
04-23 12:54:29.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:29.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:29.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:29.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:29.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:29.381+0200 I/httppostreq(25866): internet available
04-23 12:54:29.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:29.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:29.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:29.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:29.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:29.391+0200 I/utils   (25863): specific action
04-23 12:54:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:29.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:29.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:29.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:29.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:29.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:29.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26510
04-23 12:54:29.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:29.441+0200 E/CAPI_APPFW_APPLICATION(26510): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:29.441+0200 E/CAPI_APPFW_APPLICATION(26510): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:29.441+0200 I/utils   (26510): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:29.451+0200 I/utils   (26510): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:29.461+0200 I/utils   (26510): es.ugr.frailty.accelerometer listener started
04-23 12:54:29.461+0200 I/accelerometer(26510): stopping es.ugr.frailty.accelerometer service
04-23 12:54:29.461+0200 E/CAPI_APPFW_APP_CONTROL(26510): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:29.461+0200 E/accelerometer(26510): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:29.461+0200 I/CAPI_APPFW_APPLICATION(26510): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:29.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26510
04-23 12:54:29.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26510) type(svcapp) bg(0)
04-23 12:54:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:29.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26510) was created
04-23 12:54:29.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26510)
04-23 12:54:29.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:29.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:29.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:29.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:29.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26510]
04-23 12:54:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:29.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:29.501+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26522
04-23 12:54:29.501+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:29.541+0200 E/CAPI_APPFW_APPLICATION(26522): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:29.541+0200 E/CAPI_APPFW_APPLICATION(26522): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:29.541+0200 I/utils   (26522): specific action
04-23 12:54:29.541+0200 I/recorder(26522): obteniendo datos locales...
04-23 12:54:29.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26522
04-23 12:54:29.551+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26522) type(svcapp) bg(0)
04-23 12:54:29.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:29.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26510
04-23 12:54:29.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26522) was created
04-23 12:54:29.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:29.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26522]
04-23 12:54:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26510
04-23 12:54:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:29.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:29.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26522
04-23 12:54:29.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:29.611+0200 I/recorder(26522): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:29.611+0200 I/recorder(26522): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:29.661+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11265227265631524480869
04-23 12:54:29.661+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26522)
04-23 12:54:29.661+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:29.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:29.681+0200 I/AUL     ( 3087): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
04-23 12:54:29.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 15
04-23 12:54:29.721+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:54:29.721+0200 W/AUL     (26528): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:29.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:29.721+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:29.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26522
04-23 12:54:29.721+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:29.761+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26522
04-23 12:54:29.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26522)
04-23 12:54:29.781+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:29.791+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:29.811+0200 I/accelerometer(26510): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:29.951+0200 W/AUL     (26536): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:29.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:29.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:29.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26510
04-23 12:54:29.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:29.961+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26510
04-23 12:54:29.961+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26510)
04-23 12:54:31.461+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:39.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:39.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:39.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:39.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:39.381+0200 I/utils   (25866): specific action
04-23 12:54:39.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:39.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:39.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:39.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:39.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:39.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:39.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:39.381+0200 I/httppostreq(25866): internet available
04-23 12:54:39.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:39.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:39.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:39.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:39.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:39.401+0200 I/utils   (25863): specific action
04-23 12:54:39.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:39.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:39.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:39.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:39.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:39.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:39.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:39.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:39.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26576
04-23 12:54:39.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:39.451+0200 E/CAPI_APPFW_APPLICATION(26576): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:39.451+0200 E/CAPI_APPFW_APPLICATION(26576): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:39.451+0200 I/utils   (26576): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:39.461+0200 I/utils   (26576): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:39.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26576
04-23 12:54:39.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26576) type(svcapp) bg(0)
04-23 12:54:39.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26576) was created
04-23 12:54:39.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26576)
04-23 12:54:39.471+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:39.471+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:39.471+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:39.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:39.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26576]
04-23 12:54:39.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:39.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:39.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26588
04-23 12:54:39.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:39.491+0200 I/utils   (26576): es.ugr.frailty.accelerometer listener started
04-23 12:54:39.491+0200 I/accelerometer(26576): stopping es.ugr.frailty.accelerometer service
04-23 12:54:39.491+0200 E/CAPI_APPFW_APP_CONTROL(26576): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:39.491+0200 E/accelerometer(26576): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:39.491+0200 I/CAPI_APPFW_APPLICATION(26576): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:39.531+0200 E/CAPI_APPFW_APPLICATION(26588): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:39.531+0200 E/CAPI_APPFW_APPLICATION(26588): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:39.531+0200 I/utils   (26588): specific action
04-23 12:54:39.531+0200 I/recorder(26588): obteniendo datos locales...
04-23 12:54:39.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26588
04-23 12:54:39.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26588) type(svcapp) bg(0)
04-23 12:54:39.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:39.541+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26588]
04-23 12:54:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26576
04-23 12:54:39.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26588) was created
04-23 12:54:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:39.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26588
04-23 12:54:39.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:39.571+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26588)
04-23 12:54:39.571+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:39.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:39.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26576
04-23 12:54:39.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:39.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:39.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:39.711+0200 I/recorder(26588): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:39.721+0200 I/accelerometer(26576): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:39.721+0200 I/recorder(26588): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:39.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:39.741+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26588
04-23 12:54:39.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:39.791+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126588726563152448087
