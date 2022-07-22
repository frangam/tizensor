S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26390
Date: 2018-04-23 12:54:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7724648, r1   = 0xf7cb11b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cb11b8, r5   = 0x00012cd0
r6   = 0xf7cc3e88, r7   = 0xf7724250
r8   = 0x000005c8, r9   = 0xf7207824
r10  = 0xf7ca99d8, fp   = 0x00000000
ip   = 0xf7723030, sp   = 0xffd1d790
lr   = 0xf76675d0, pc   = 0xf76639fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     14236 KB
Buffers:     71848 KB
Cached:     185112 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7728 KB
VmRSS:        7724 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6d9e000 f6da1000 r-xp /lib/libattr.so.1.1.0
f6daa000 f6db1000 r-xp /lib/libcrypt-2.13.so
f6de1000 f6de4000 r-xp /lib/libcap.so.2.21
f6dec000 f6dee000 r-xp /usr/lib/libiri.so
f6df6000 f6e13000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6e1c000 f6e20000 r-xp /usr/lib/libsmack.so.1.0.0
f6e2a000 f6e2c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e34000 f6e39000 r-xp /usr/lib/libffi.so.5.0.10
f6e41000 f6e42000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e4a000 f6e4c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e54000 f6e56000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e60000 f6e70000 r-xp /lib/libresolv-2.13.so
f6e74000 f6e8c000 r-xp /usr/lib/liblzma.so.5.0.3
f6e94000 f6e96000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e9e000 f6ecd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ed6000 f6ee5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6eee000 f6ef8000 r-xp /usr/lib/libsensord-shared.so
f6f01000 f6f35000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f3e000 f7011000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f701c000 f7032000 r-xp /lib/libz.so.1.2.5
f703a000 f7040000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7049000 f70be000 r-xp /usr/lib/libsqlite3.so.0.8.6
f70c8000 f70e2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f70ea000 f70f0000 r-xp /lib/librt-2.13.so
f70f9000 f7117000 r-xp /usr/lib/libsystemd.so.0.4.0
f7121000 f7122000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f712a000 f712f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7137000 f7207000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7208000 f7232000 r-xp /usr/lib/libdbus-1.so.3.8.12
f723b000 f7252000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f725a000 f72c3000 r-xp /lib/libm-2.13.so
f72cc000 f7360000 r-xp /usr/lib/libstdc++.so.6.0.16
f7373000 f7378000 r-xp /usr/lib/libctx-client.so.0.8.3
f7380000 f7387000 r-xp /usr/lib/libctx-shared.so.0.8.3
f738f000 f73b9000 r-xp /usr/lib/libsensor.so.1.9.6
f73c2000 f748e000 r-xp /usr/lib/libxml2.so.2.7.8
f749b000 f749d000 r-xp /usr/lib/libiniparser.so.0
f74a6000 f74a9000 r-xp /usr/lib/libbundle.so.0.1.22
f74b1000 f74b7000 r-xp /usr/lib/libappsvc.so.0.1.0
f74bf000 f74e2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f74ea000 f752b000 r-xp /usr/lib/libeina.so.1.7.99
f7534000 f754b000 r-xp /usr/lib/libecore.so.1.7.99
f7562000 f756b000 r-xp /usr/lib/libvconf.so.0.2.45
f7573000 f7587000 r-xp /lib/libpthread-2.13.so
f7592000 f759f000 r-xp /usr/lib/libaul.so.0.1.0
f75a9000 f75ab000 r-xp /lib/libdl-2.13.so
f75b4000 f75bf000 r-xp /lib/libunwind.so.8.0.1
f75ec000 f75f4000 r-xp /lib/libgcc_s-4.6.so.1
f75f5000 f7719000 r-xp /lib/libc-2.13.so
f7727000 f7729000 r-xp /usr/lib/libdlog.so.0.0.0
f7731000 f773d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7746000 f774b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7753000 f7757000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7760000 f7762000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f776b000 f776e000 r-xp /usr/lib/libappcore-agent.so.1.1
f778c000 f77a9000 r-xp /lib/ld-2.13.so
f77b2000 f77b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f77b5000 f77b9000 r-xp /usr/lib/libsys-assert.so
f7c9f000 f7ced000 rw-p [heap]
ffcff000 ffd20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26390)
Call Stack Count: 1
 0: (0xf76639fc) [/lib/libc.so.6] + 0x6e9fc
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
> [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:49.431+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:53:49.431+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:49.431+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:53:49.431+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:49.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:49.461+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:49.461+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26246
04-23 12:53:49.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26246
04-23 12:53:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26246) type(svcapp) bg(0)
04-23 12:53:49.521+0200 E/CAPI_APPFW_APPLICATION(26246): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.521+0200 E/CAPI_APPFW_APPLICATION(26246): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.521+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26246]
04-23 12:53:49.521+0200 I/utils   (26246): trying to start service: es.ugr.frailty.accelerometer
04-23 12:53:49.521+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26246) was created
04-23 12:53:49.521+0200 I/utils   (26246): es.ugr.frailty.accelerometer sensor supported
04-23 12:53:49.531+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26246)
04-23 12:53:49.531+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:53:49.531+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.531+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.531+0200 E/servicemanager(25863): deleting timer 0
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.531+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.531+0200 E/servicemanager(25863): deleting timer 1
04-23 12:53:49.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.541+0200 I/utils   (26246): es.ugr.frailty.accelerometer listener started
04-23 12:53:49.541+0200 I/accelerometer(26246): stopping es.ugr.frailty.accelerometer service
04-23 12:53:49.541+0200 E/CAPI_APPFW_APP_CONTROL(26246): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.541+0200 E/accelerometer(26246): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:53:49.541+0200 I/CAPI_APPFW_APPLICATION(26246): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:49.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26246
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 2
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 3
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 4
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 5
04-23 12:53:49.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:49.571+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26259
04-23 12:53:49.601+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:49.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26259
04-23 12:53:49.621+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26259) type(svcapp) bg(0)
04-23 12:53:49.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.621+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26259]
04-23 12:53:49.631+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26246
04-23 12:53:49.631+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26259)
04-23 12:53:49.631+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:49.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.661+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26259
04-23 12:53:49.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.661+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:49.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.681+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26259
04-23 12:53:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.691+0200 E/CAPI_APPFW_APPLICATION(26259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.691+0200 E/CAPI_APPFW_APPLICATION(26259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.691+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26259) was created
04-23 12:53:49.691+0200 I/utils   (26259): specific action
04-23 12:53:49.691+0200 I/recorder(26259): obteniendo datos locales...
04-23 12:53:49.691+0200 I/accelerometer(26246): es.ugr.frailty.accelerometer listener destroyed
04-23 12:53:49.711+0200 I/recorder(26259): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:53:49.761+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11262597265631524480829
04-23 12:53:49.781+0200 W/AUL     (26266): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:53:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26259
04-23 12:53:49.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:49.781+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26259
04-23 12:53:49.781+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26259)
04-23 12:53:49.821+0200 W/AUL     (26267): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:53:49.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:49.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:49.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26246
04-23 12:53:49.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:49.821+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26246
04-23 12:53:49.821+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26246)
04-23 12:53:51.551+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:53:59.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:53:59.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:53:59.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:53:59.381+0200 I/utils   (25866): specific action
04-23 12:53:59.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:53:59.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:53:59.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:53:59.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:53:59.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:53:59.381+0200 I/httppostreq(25866): internet available
04-23 12:53:59.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:53:59.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:53:59.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:53:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:53:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:53:59.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:53:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:59.391+0200 I/utils   (25863): specific action
04-23 12:53:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:59.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:53:59.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:53:59.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:59.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26310
04-23 12:53:59.401+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:59.441+0200 E/CAPI_APPFW_APPLICATION(26310): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:59.441+0200 E/CAPI_APPFW_APPLICATION(26310): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:59.441+0200 I/utils   (26310): trying to start service: es.ugr.frailty.accelerometer
04-23 12:53:59.441+0200 I/utils   (26310): es.ugr.frailty.accelerometer sensor supported
04-23 12:53:59.451+0200 I/utils   (26310): es.ugr.frailty.accelerometer listener started
04-23 12:53:59.451+0200 I/accelerometer(26310): stopping es.ugr.frailty.accelerometer service
04-23 12:53:59.451+0200 E/CAPI_APPFW_APP_CONTROL(26310): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:53:59.451+0200 E/accelerometer(26310): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:53:59.451+0200 I/CAPI_APPFW_APPLICATION(26310): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:59.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26310
04-23 12:53:59.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26310) type(svcapp) bg(0)
04-23 12:53:59.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:59.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:59.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26310) was created
04-23 12:53:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26310)
04-23 12:53:59.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:53:59.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:59.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:53:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:59.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26310]
04-23 12:53:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:59.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:59.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26322
04-23 12:53:59.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:59.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26322
04-23 12:53:59.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26322) type(svcapp) bg(0)
04-23 12:53:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26310
04-23 12:53:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:59.551+0200 E/CAPI_APPFW_APPLICATION(26322): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:59.551+0200 E/CAPI_APPFW_APPLICATION(26322): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:59.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26322) was created
04-23 12:53:59.551+0200 I/utils   (26322): specific action
04-23 12:53:59.551+0200 I/recorder(26322): obteniendo datos locales...
04-23 12:53:59.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26322]
04-23 12:53:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26322
04-23 12:53:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:59.601+0200 I/recorder(26322): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:53:59.601+0200 I/recorder(26322): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:53:59.671+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11263227265631524480839
04-23 12:53:59.681+0200 W/AUL     (26328): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:53:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26322
04-23 12:53:59.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:59.691+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26322
04-23 12:53:59.691+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26322)
04-23 12:53:59.731+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26322)
04-23 12:53:59.731+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:59.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:59.741+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26310
04-23 12:53:59.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:59.751+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:53:59.751+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:53:59.751+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(26322), proc(0)
04-23 12:53:59.751+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:53:59.751+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:53:59.751+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:53:59.771+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:59.781+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:59.821+0200 I/accelerometer(26310): es.ugr.frailty.accelerometer listener destroyed
04-23 12:53:59.961+0200 W/AUL     (26338): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:53:59.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:59.961+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:59.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26310
04-23 12:53:59.961+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:59.961+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26310
04-23 12:53:59.961+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26310)
04-23 12:54:01.461+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:09.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:09.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:09.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:09.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:09.381+0200 I/utils   (25866): specific action
04-23 12:54:09.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:09.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:09.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:09.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:09.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:09.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:09.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:09.381+0200 I/httppostreq(25866): internet available
04-23 12:54:09.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:09.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:09.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:09.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:09.391+0200 I/utils   (25863): specific action
04-23 12:54:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:09.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:09.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:09.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:09.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:09.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:09.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:09.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:09.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26378
04-23 12:54:09.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:09.451+0200 E/CAPI_APPFW_APPLICATION(26378): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:09.451+0200 E/CAPI_APPFW_APPLICATION(26378): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:09.451+0200 I/utils   (26378): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:09.451+0200 I/utils   (26378): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:09.461+0200 I/utils   (26378): es.ugr.frailty.accelerometer listener started
04-23 12:54:09.461+0200 I/accelerometer(26378): stopping es.ugr.frailty.accelerometer service
04-23 12:54:09.461+0200 E/CAPI_APPFW_APP_CONTROL(26378): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:09.461+0200 E/accelerometer(26378): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:09.461+0200 I/CAPI_APPFW_APPLICATION(26378): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26378
04-23 12:54:09.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26378) type(svcapp) bg(0)
04-23 12:54:09.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:09.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:09.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26378) was created
04-23 12:54:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26378)
04-23 12:54:09.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:09.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:09.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:09.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26378]
04-23 12:54:09.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:09.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26378
04-23 12:54:09.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:09.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:09.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:09.501+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:09.501+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26390
04-23 12:54:09.551+0200 E/CAPI_APPFW_APPLICATION(26390): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:09.551+0200 E/CAPI_APPFW_APPLICATION(26390): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:09.551+0200 I/utils   (26390): specific action
04-23 12:54:09.551+0200 I/recorder(26390): obteniendo datos locales...
04-23 12:54:09.571+0200 I/recorder(26390): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:09.571+0200 I/recorder(26390): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:09.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26390
04-23 12:54:09.631+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26390) type(svcapp) bg(0)
04-23 12:54:09.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:09.631+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26390]
04-23 12:54:09.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26378
04-23 12:54:09.641+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26390) was created
04-23 12:54:09.651+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26390)
04-23 12:54:09.651+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:09.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:09.661+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126390726563152448084
