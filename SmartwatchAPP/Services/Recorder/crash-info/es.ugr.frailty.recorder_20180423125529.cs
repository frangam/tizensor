S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26915
Date: 2018-04-23 12:55:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7430648, r1   = 0xf7c041b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7c041b8, r5   = 0x00012cd0
r6   = 0xf7c16e88, r7   = 0xf7430250
r8   = 0x000005c8, r9   = 0xf6f13824
r10  = 0xf7bfc9d8, fp   = 0x00000000
ip   = 0xf742f030, sp   = 0xffae9330
lr   = 0xf73735d0, pc   = 0xf736f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13892 KB
Buffers:     72056 KB
Cached:     185216 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6aaa000 f6aad000 r-xp /lib/libattr.so.1.1.0
f6ab6000 f6abd000 r-xp /lib/libcrypt-2.13.so
f6aed000 f6af0000 r-xp /lib/libcap.so.2.21
f6af8000 f6afa000 r-xp /usr/lib/libiri.so
f6b02000 f6b1f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b28000 f6b2c000 r-xp /usr/lib/libsmack.so.1.0.0
f6b36000 f6b38000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b40000 f6b45000 r-xp /usr/lib/libffi.so.5.0.10
f6b4d000 f6b4e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b56000 f6b58000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b60000 f6b62000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b6c000 f6b7c000 r-xp /lib/libresolv-2.13.so
f6b80000 f6b98000 r-xp /usr/lib/liblzma.so.5.0.3
f6ba0000 f6ba2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6baa000 f6bd9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6be2000 f6bf1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bfa000 f6c04000 r-xp /usr/lib/libsensord-shared.so
f6c0d000 f6c41000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c4a000 f6d1d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d28000 f6d3e000 r-xp /lib/libz.so.1.2.5
f6d46000 f6d4c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d55000 f6dca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dd4000 f6dee000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6df6000 f6dfc000 r-xp /lib/librt-2.13.so
f6e05000 f6e23000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e2d000 f6e2e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e36000 f6e3b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e43000 f6f13000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f14000 f6f3e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f47000 f6f5e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f66000 f6fcf000 r-xp /lib/libm-2.13.so
f6fd8000 f706c000 r-xp /usr/lib/libstdc++.so.6.0.16
f707f000 f7084000 r-xp /usr/lib/libctx-client.so.0.8.3
f708c000 f7093000 r-xp /usr/lib/libctx-shared.so.0.8.3
f709b000 f70c5000 r-xp /usr/lib/libsensor.so.1.9.6
f70ce000 f719a000 r-xp /usr/lib/libxml2.so.2.7.8
f71a7000 f71a9000 r-xp /usr/lib/libiniparser.so.0
f71b2000 f71b5000 r-xp /usr/lib/libbundle.so.0.1.22
f71bd000 f71c3000 r-xp /usr/lib/libappsvc.so.0.1.0
f71cb000 f71ee000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71f6000 f7237000 r-xp /usr/lib/libeina.so.1.7.99
f7240000 f7257000 r-xp /usr/lib/libecore.so.1.7.99
f726e000 f7277000 r-xp /usr/lib/libvconf.so.0.2.45
f727f000 f7293000 r-xp /lib/libpthread-2.13.so
f729e000 f72ab000 r-xp /usr/lib/libaul.so.0.1.0
f72b5000 f72b7000 r-xp /lib/libdl-2.13.so
f72c0000 f72cb000 r-xp /lib/libunwind.so.8.0.1
f72f8000 f7300000 r-xp /lib/libgcc_s-4.6.so.1
f7301000 f7425000 r-xp /lib/libc-2.13.so
f7433000 f7435000 r-xp /usr/lib/libdlog.so.0.0.0
f743d000 f7449000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7452000 f7457000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f745f000 f7463000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f746c000 f746e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7477000 f747a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7498000 f74b5000 r-xp /lib/ld-2.13.so
f74be000 f74c1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f74c1000 f74c5000 r-xp /usr/lib/libsys-assert.so
f7bf2000 f7c40000 rw-p [heap]
ffacb000 ffaec000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26915)
Call Stack Count: 1
 0: (0xf736f9fc) [/lib/libc.so.6] + 0x6e9fc
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
(25863): specific action
04-23 12:55:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:09.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:09.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:55:09.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:09.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26774
04-23 12:55:09.401+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:09.411+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:55:09.411+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:55:09.451+0200 E/CAPI_APPFW_APPLICATION(26774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.451+0200 E/CAPI_APPFW_APPLICATION(26774): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.451+0200 I/utils   (26774): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:09.451+0200 I/utils   (26774): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26774
04-23 12:55:09.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26774) type(svcapp) bg(0)
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26774) was created
04-23 12:55:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26774)
04-23 12:55:09.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:09.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:09.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:09.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:09.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:09.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:09.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:09.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26774]
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:09.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:09.471+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26783
04-23 12:55:09.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:09.521+0200 E/CAPI_APPFW_APPLICATION(26783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.521+0200 E/CAPI_APPFW_APPLICATION(26783): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.521+0200 I/utils   (26783): specific action
04-23 12:55:09.521+0200 I/recorder(26783): obteniendo datos locales...
04-23 12:55:09.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26783
04-23 12:55:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26783) type(svcapp) bg(0)
04-23 12:55:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.531+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26783]
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26774
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26783) was created
04-23 12:55:09.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26774
04-23 12:55:09.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.541+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26783)
04-23 12:55:09.541+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:09.551+0200 I/utils   (26774): es.ugr.frailty.accelerometer listener started
04-23 12:55:09.551+0200 I/accelerometer(26774): stopping es.ugr.frailty.accelerometer service
04-23 12:55:09.551+0200 E/CAPI_APPFW_APP_CONTROL(26774): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:09.551+0200 E/accelerometer(26774): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:09.551+0200 I/CAPI_APPFW_APPLICATION(26774): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:09.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:09.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26783
04-23 12:55:09.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:09.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26783
04-23 12:55:09.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:09.611+0200 I/recorder(26783): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:09.611+0200 I/recorder(26783): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:09.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:09.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:09.741+0200 I/accelerometer(26774): es.ugr.frailty.accelerometer listener destroyed
04-23 12:55:09.751+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11267837265631524480909
04-23 12:55:09.771+0200 W/AUL     (26795): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:55:09.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:09.771+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:09.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26783
04-23 12:55:09.771+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:09.771+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26783
04-23 12:55:09.771+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26783)
04-23 12:55:09.891+0200 W/AUL     (26801): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:55:09.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:09.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:09.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26774
04-23 12:55:09.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:09.901+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26774
04-23 12:55:09.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26774)
04-23 12:55:11.551+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:55:19.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:55:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:19.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:19.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:55:19.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:19.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:55:19.381+0200 I/utils   (25866): specific action
04-23 12:55:19.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:55:19.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:55:19.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:55:19.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:55:19.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:55:19.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:55:19.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:55:19.381+0200 I/httppostreq(25866): internet available
04-23 12:55:19.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:55:19.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:19.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:55:19.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:55:19.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:19.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:55:19.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:55:19.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:55:19.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:19.391+0200 I/utils   (25863): specific action
04-23 12:55:19.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:19.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:19.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:55:19.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:55:19.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:19.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:19.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:19.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26839
04-23 12:55:19.441+0200 E/CAPI_APPFW_APPLICATION(26839): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:19.441+0200 E/CAPI_APPFW_APPLICATION(26839): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:19.451+0200 I/utils   (26839): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:19.451+0200 I/utils   (26839): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:19.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26839
04-23 12:55:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26839) type(svcapp) bg(0)
04-23 12:55:19.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26839) was created
04-23 12:55:19.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26839]
04-23 12:55:19.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26839)
04-23 12:55:19.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:19.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:19.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:19.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:19.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:19.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:19.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:19.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:19.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:19.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26851
04-23 12:55:19.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:19.481+0200 I/utils   (26839): es.ugr.frailty.accelerometer listener started
04-23 12:55:19.481+0200 I/accelerometer(26839): stopping es.ugr.frailty.accelerometer service
04-23 12:55:19.501+0200 E/CAPI_APPFW_APP_CONTROL(26839): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:19.511+0200 E/accelerometer(26839): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:19.511+0200 I/CAPI_APPFW_APPLICATION(26839): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:19.521+0200 E/CAPI_APPFW_APPLICATION(26851): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:19.521+0200 E/CAPI_APPFW_APPLICATION(26851): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:19.531+0200 I/utils   (26851): specific action
04-23 12:55:19.531+0200 I/recorder(26851): obteniendo datos locales...
04-23 12:55:19.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26851
04-23 12:55:19.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26851) type(svcapp) bg(0)
04-23 12:55:19.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26839
04-23 12:55:19.541+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26851) was created
04-23 12:55:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:19.551+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26851]
04-23 12:55:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26839
04-23 12:55:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:19.561+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26851)
04-23 12:55:19.561+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:19.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:19.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26851
04-23 12:55:19.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:19.661+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:19.671+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:19.681+0200 I/accelerometer(26839): es.ugr.frailty.accelerometer listener destroyed
04-23 12:55:19.691+0200 I/recorder(26851): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:19.691+0200 I/recorder(26851): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:19.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:19.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:19.741+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26851
04-23 12:55:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:19.781+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11268517265631524480919
04-23 12:55:19.801+0200 W/AUL     (26858): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:55:19.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:19.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:19.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26851
04-23 12:55:19.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:19.801+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26851
04-23 12:55:19.801+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26851)
04-23 12:55:19.811+0200 W/AUL     (26859): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:55:19.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:55:19.831+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:55:19.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26839
04-23 12:55:19.831+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:55:19.851+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26839
04-23 12:55:19.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26839)
04-23 12:55:21.541+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:55:29.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:55:29.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:29.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:55:29.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:55:29.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:55:29.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:55:29.381+0200 I/utils   (25866): specific action
04-23 12:55:29.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:55:29.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:55:29.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:55:29.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:55:29.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:55:29.381+0200 I/httppostreq(25866): internet available
04-23 12:55:29.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:55:29.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:55:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:55:29.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:55:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:55:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:29.401+0200 I/utils   (25863): specific action
04-23 12:55:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:55:29.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:55:29.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:55:29.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:55:29.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:55:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:29.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:29.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26903
04-23 12:55:29.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:29.441+0200 E/CAPI_APPFW_APPLICATION(26903): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:29.441+0200 E/CAPI_APPFW_APPLICATION(26903): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:29.441+0200 I/utils   (26903): trying to start service: es.ugr.frailty.accelerometer
04-23 12:55:29.451+0200 I/utils   (26903): es.ugr.frailty.accelerometer sensor supported
04-23 12:55:29.461+0200 I/utils   (26903): es.ugr.frailty.accelerometer listener started
04-23 12:55:29.461+0200 I/accelerometer(26903): stopping es.ugr.frailty.accelerometer service
04-23 12:55:29.461+0200 E/CAPI_APPFW_APP_CONTROL(26903): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:55:29.461+0200 E/accelerometer(26903): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:55:29.461+0200 I/CAPI_APPFW_APPLICATION(26903): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:55:29.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26903
04-23 12:55:29.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26903) type(svcapp) bg(0)
04-23 12:55:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:55:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:55:29.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26903) was created
04-23 12:55:29.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26903]
04-23 12:55:29.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26903)
04-23 12:55:29.471+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:55:29.471+0200 I/servicemanager(25863): App control destroyed.
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 0
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 1
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 2
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 3
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 4
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:55:29.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:55:29.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:55:29.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:55:29.471+0200 E/servicemanager(25863): deleting timer 5
04-23 12:55:29.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:55:29.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:55:29.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:55:29.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26915
04-23 12:55:29.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:55:29.521+0200 E/CAPI_APPFW_APPLICATION(26915): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:29.521+0200 E/CAPI_APPFW_APPLICATION(26915): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:55:29.521+0200 I/utils   (26915): specific action
04-23 12:55:29.521+0200 I/recorder(26915): obteniendo datos locales...
04-23 12:55:29.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26915
04-23 12:55:29.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26915) type(svcapp) bg(0)
04-23 12:55:29.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:29.541+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26915]
04-23 12:55:29.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26903
04-23 12:55:29.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26915) was created
04-23 12:55:29.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:29.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26915)
04-23 12:55:29.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:55:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:55:29.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26915
04-23 12:55:29.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:55:29.651+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:29.661+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:55:29.671+0200 I/recorder(26915): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:55:29.671+0200 I/recorder(26915): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:55:29.721+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126915726563152448092
