S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26718
Date: 2018-04-23 12:54:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf6f5a648, r1   = 0xf76cd1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf76cd1b8, r5   = 0x00012cd0
r6   = 0xf76dfe88, r7   = 0xf6f5a250
r8   = 0x000005c8, r9   = 0xf6a3d824
r10  = 0xf76c59d8, fp   = 0x00000000
ip   = 0xf6f59030, sp   = 0xffce1ee0
lr   = 0xf6e9d5d0, pc   = 0xf6e999fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13436 KB
Buffers:     71976 KB
Cached:     185488 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7792 KB
VmRSS:        7788 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f65d4000 f65d7000 r-xp /lib/libattr.so.1.1.0
f65e0000 f65e7000 r-xp /lib/libcrypt-2.13.so
f6617000 f661a000 r-xp /lib/libcap.so.2.21
f6622000 f6624000 r-xp /usr/lib/libiri.so
f662c000 f6649000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6652000 f6656000 r-xp /usr/lib/libsmack.so.1.0.0
f6660000 f6662000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f666a000 f666f000 r-xp /usr/lib/libffi.so.5.0.10
f6677000 f6678000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6680000 f6682000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f668a000 f668c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6696000 f66a6000 r-xp /lib/libresolv-2.13.so
f66aa000 f66c2000 r-xp /usr/lib/liblzma.so.5.0.3
f66ca000 f66cc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66d4000 f6703000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f670c000 f671b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6724000 f672e000 r-xp /usr/lib/libsensord-shared.so
f6737000 f676b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6774000 f6847000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6852000 f6868000 r-xp /lib/libz.so.1.2.5
f6870000 f6876000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f687f000 f68f4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f68fe000 f6918000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6920000 f6926000 r-xp /lib/librt-2.13.so
f692f000 f694d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6957000 f6958000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6960000 f6965000 r-xp /usr/lib/libxdgmime.so.1.1.0
f696d000 f6a3d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6a3e000 f6a68000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a71000 f6a88000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a90000 f6af9000 r-xp /lib/libm-2.13.so
f6b02000 f6b96000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ba9000 f6bae000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bb6000 f6bbd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bc5000 f6bef000 r-xp /usr/lib/libsensor.so.1.9.6
f6bf8000 f6cc4000 r-xp /usr/lib/libxml2.so.2.7.8
f6cd1000 f6cd3000 r-xp /usr/lib/libiniparser.so.0
f6cdc000 f6cdf000 r-xp /usr/lib/libbundle.so.0.1.22
f6ce7000 f6ced000 r-xp /usr/lib/libappsvc.so.0.1.0
f6cf5000 f6d18000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d20000 f6d61000 r-xp /usr/lib/libeina.so.1.7.99
f6d6a000 f6d81000 r-xp /usr/lib/libecore.so.1.7.99
f6d98000 f6da1000 r-xp /usr/lib/libvconf.so.0.2.45
f6da9000 f6dbd000 r-xp /lib/libpthread-2.13.so
f6dc8000 f6dd5000 r-xp /usr/lib/libaul.so.0.1.0
f6ddf000 f6de1000 r-xp /lib/libdl-2.13.so
f6dea000 f6df5000 r-xp /lib/libunwind.so.8.0.1
f6e22000 f6e2a000 r-xp /lib/libgcc_s-4.6.so.1
f6e2b000 f6f4f000 r-xp /lib/libc-2.13.so
f6f5d000 f6f5f000 r-xp /usr/lib/libdlog.so.0.0.0
f6f67000 f6f73000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f7c000 f6f81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f89000 f6f8d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6f96000 f6f98000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6fa1000 f6fa4000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fc2000 f6fdf000 r-xp /lib/ld-2.13.so
f6fe8000 f6feb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f6feb000 f6fef000 r-xp /usr/lib/libsys-assert.so
f76bb000 f7709000 rw-p [heap]
ffcc4000 ffce5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26718)
Call Stack Count: 1
 0: (0xf6e999fc) [/lib/libc.so.6] + 0x6e9fc
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
_app(1782) > caller pid : 25863
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
04-23 12:54:39.791+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11265887265631524480879
04-23 12:54:39.801+0200 W/AUL     (26595): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26588
04-23 12:54:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:39.811+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26588
04-23 12:54:39.811+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26588)
04-23 12:54:39.861+0200 W/AUL     (26597): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:39.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:39.861+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:39.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26576
04-23 12:54:39.861+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:39.861+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26576
04-23 12:54:39.861+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26576)
04-23 12:54:41.551+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:49.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:49.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:49.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:49.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:49.381+0200 I/utils   (25866): specific action
04-23 12:54:49.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:49.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:49.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:49.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:49.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:49.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:49.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:49.381+0200 I/httppostreq(25866): internet available
04-23 12:54:49.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:49.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:49.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:49.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:49.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:49.391+0200 I/utils   (25863): specific action
04-23 12:54:49.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:49.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:49.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:49.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:49.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:49.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:49.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:49.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:49.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26640
04-23 12:54:49.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:49.441+0200 E/CAPI_APPFW_APPLICATION(26640): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.441+0200 E/CAPI_APPFW_APPLICATION(26640): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.451+0200 I/utils   (26640): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:49.451+0200 I/utils   (26640): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:49.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26640
04-23 12:54:49.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26640) type(svcapp) bg(0)
04-23 12:54:49.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26640) was created
04-23 12:54:49.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26640]
04-23 12:54:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26640
04-23 12:54:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:49.501+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26640)
04-23 12:54:49.501+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:49.501+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:49.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:49.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:49.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:49.501+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:49.501+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:49.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:49.511+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26652
04-23 12:54:49.511+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:49.521+0200 I/utils   (26640): es.ugr.frailty.accelerometer listener started
04-23 12:54:49.531+0200 I/accelerometer(26640): stopping es.ugr.frailty.accelerometer service
04-23 12:54:49.541+0200 E/CAPI_APPFW_APP_CONTROL(26640): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.541+0200 E/accelerometer(26640): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:49.541+0200 I/CAPI_APPFW_APPLICATION(26640): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:49.551+0200 E/CAPI_APPFW_APPLICATION(26652): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.551+0200 E/CAPI_APPFW_APPLICATION(26652): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:49.561+0200 I/utils   (26652): specific action
04-23 12:54:49.561+0200 I/recorder(26652): obteniendo datos locales...
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26652
04-23 12:54:49.561+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26652) type(svcapp) bg(0)
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:49.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26652) was created
04-23 12:54:49.571+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26652)
04-23 12:54:49.571+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:49.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26652]
04-23 12:54:49.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:49.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26652
04-23 12:54:49.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:49.601+0200 I/recorder(26652): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:49.601+0200 I/recorder(26652): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:49.671+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11266527265631524480889
04-23 12:54:49.681+0200 W/AUL     (26657): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26652
04-23 12:54:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:49.691+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26652
04-23 12:54:49.691+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26652)
04-23 12:54:49.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:49.701+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26640
04-23 12:54:49.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(26652), proc(0)
04-23 12:54:49.711+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:54:49.711+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:54:49.711+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:54:49.811+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:49.821+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:54:49.841+0200 I/accelerometer(26640): es.ugr.frailty.accelerometer listener destroyed
04-23 12:54:49.991+0200 W/AUL     (26668): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26640
04-23 12:54:49.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:54:49.991+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26640
04-23 12:54:49.991+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26640)
04-23 12:54:51.571+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:54:59.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:54:59.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:54:59.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:54:59.381+0200 I/utils   (25866): specific action
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:54:59.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:54:59.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:54:59.381+0200 I/httppostreq(25866): internet available
04-23 12:54:59.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:54:59.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:54:59.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:54:59.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 I/utils   (25863): specific action
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:54:59.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:54:59.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:54:59.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:54:59.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:54:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26706
04-23 12:54:59.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:59.451+0200 E/CAPI_APPFW_APPLICATION(26706): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.451+0200 E/CAPI_APPFW_APPLICATION(26706): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.451+0200 I/utils   (26706): trying to start service: es.ugr.frailty.accelerometer
04-23 12:54:59.451+0200 I/utils   (26706): es.ugr.frailty.accelerometer sensor supported
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26706
04-23 12:54:59.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26706) type(svcapp) bg(0)
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26706) was created
04-23 12:54:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26706)
04-23 12:54:59.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:54:59.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26706]
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:54:59.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:54:59.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:54:59.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:54:59.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:54:59.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:54:59.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:54:59.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:54:59.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26718
04-23 12:54:59.481+0200 I/utils   (26706): es.ugr.frailty.accelerometer listener started
04-23 12:54:59.481+0200 I/accelerometer(26706): stopping es.ugr.frailty.accelerometer service
04-23 12:54:59.481+0200 E/CAPI_APPFW_APP_CONTROL(26706): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.481+0200 E/accelerometer(26706): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:54:59.481+0200 I/CAPI_APPFW_APPLICATION(26706): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:54:59.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26718
04-23 12:54:59.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26718) type(svcapp) bg(0)
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:54:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26706
04-23 12:54:59.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26718)
04-23 12:54:59.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:54:59.561+0200 E/CAPI_APPFW_APPLICATION(26718): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.561+0200 E/CAPI_APPFW_APPLICATION(26718): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:54:59.561+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26718) was created
04-23 12:54:59.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26718]
04-23 12:54:59.571+0200 I/utils   (26718): specific action
04-23 12:54:59.571+0200 I/recorder(26718): obteniendo datos locales...
04-23 12:54:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26718
04-23 12:54:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26706
04-23 12:54:59.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.641+0200 I/recorder(26718): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:54:59.651+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:54:59.661+0200 I/recorder(26718): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:54:59.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:54:59.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26718
04-23 12:54:59.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:54:59.731+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126718726563152448089
