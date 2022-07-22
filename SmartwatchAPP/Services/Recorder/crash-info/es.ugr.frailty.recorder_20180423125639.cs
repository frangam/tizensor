S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 27370
Date: 2018-04-23 12:56:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf73ce648, r1   = 0xf7aad1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7aad1b8, r5   = 0x00012cd0
r6   = 0xf7abfe88, r7   = 0xf73ce250
r8   = 0x000005c8, r9   = 0xf6eb1824
r10  = 0xf7aa59d8, fp   = 0x00000000
ip   = 0xf73cd030, sp   = 0xff859ae0
lr   = 0xf73115d0, pc   = 0xf730d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13436 KB
Buffers:     72232 KB
Cached:     185612 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7708 KB
VmRSS:        7704 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6a48000 f6a4b000 r-xp /lib/libattr.so.1.1.0
f6a54000 f6a5b000 r-xp /lib/libcrypt-2.13.so
f6a8b000 f6a8e000 r-xp /lib/libcap.so.2.21
f6a96000 f6a98000 r-xp /usr/lib/libiri.so
f6aa0000 f6abd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ac6000 f6aca000 r-xp /usr/lib/libsmack.so.1.0.0
f6ad4000 f6ad6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ade000 f6ae3000 r-xp /usr/lib/libffi.so.5.0.10
f6aeb000 f6aec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6af4000 f6af6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6afe000 f6b00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b0a000 f6b1a000 r-xp /lib/libresolv-2.13.so
f6b1e000 f6b36000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3e000 f6b40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b48000 f6b77000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b80000 f6b8f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b98000 f6ba2000 r-xp /usr/lib/libsensord-shared.so
f6bab000 f6bdf000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6be8000 f6cbb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cc6000 f6cdc000 r-xp /lib/libz.so.1.2.5
f6ce4000 f6cea000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf3000 f6d68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d72000 f6d8c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d94000 f6d9a000 r-xp /lib/librt-2.13.so
f6da3000 f6dc1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dcb000 f6dcc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dd4000 f6dd9000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6de1000 f6eb1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eb2000 f6edc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ee5000 f6efc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f04000 f6f6d000 r-xp /lib/libm-2.13.so
f6f76000 f700a000 r-xp /usr/lib/libstdc++.so.6.0.16
f701d000 f7022000 r-xp /usr/lib/libctx-client.so.0.8.3
f702a000 f7031000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7039000 f7063000 r-xp /usr/lib/libsensor.so.1.9.6
f706c000 f7138000 r-xp /usr/lib/libxml2.so.2.7.8
f7145000 f7147000 r-xp /usr/lib/libiniparser.so.0
f7150000 f7153000 r-xp /usr/lib/libbundle.so.0.1.22
f715b000 f7161000 r-xp /usr/lib/libappsvc.so.0.1.0
f7169000 f718c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7194000 f71d5000 r-xp /usr/lib/libeina.so.1.7.99
f71de000 f71f5000 r-xp /usr/lib/libecore.so.1.7.99
f720c000 f7215000 r-xp /usr/lib/libvconf.so.0.2.45
f721d000 f7231000 r-xp /lib/libpthread-2.13.so
f723c000 f7249000 r-xp /usr/lib/libaul.so.0.1.0
f7253000 f7255000 r-xp /lib/libdl-2.13.so
f725e000 f7269000 r-xp /lib/libunwind.so.8.0.1
f7296000 f729e000 r-xp /lib/libgcc_s-4.6.so.1
f729f000 f73c3000 r-xp /lib/libc-2.13.so
f73d1000 f73d3000 r-xp /usr/lib/libdlog.so.0.0.0
f73db000 f73e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73f0000 f73f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73fd000 f7401000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f740a000 f740c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7415000 f7418000 r-xp /usr/lib/libappcore-agent.so.1.1
f7436000 f7453000 r-xp /lib/ld-2.13.so
f745c000 f745f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f745f000 f7463000 r-xp /usr/lib/libsys-assert.so
f7a9b000 f7ae9000 rw-p [heap]
ff83b000 ff85c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27370)
Call Stack Count: 1
 0: (0xf730d9fc) [/lib/libc.so.6] + 0x6e9fc
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
unch.c: start_process(606) > child process: 27225
04-23 12:56:19.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:19.421+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:19.451+0200 E/CAPI_APPFW_APPLICATION(27225): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:19.451+0200 E/CAPI_APPFW_APPLICATION(27225): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:19.451+0200 I/utils   (27225): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:19.461+0200 I/utils   (27225): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:19.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27225
04-23 12:56:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27225) type(svcapp) bg(0)
04-23 12:56:19.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27225]
04-23 12:56:19.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27225) was created
04-23 12:56:19.481+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27225)
04-23 12:56:19.481+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:19.481+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:19.481+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:19.481+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:19.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:19.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:19.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27236
04-23 12:56:19.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:19.531+0200 E/CAPI_APPFW_APPLICATION(27236): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:19.531+0200 E/CAPI_APPFW_APPLICATION(27236): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:19.531+0200 I/utils   (27236): specific action
04-23 12:56:19.531+0200 I/recorder(27236): obteniendo datos locales...
04-23 12:56:19.541+0200 I/utils   (27225): es.ugr.frailty.accelerometer listener started
04-23 12:56:19.541+0200 I/accelerometer(27225): stopping es.ugr.frailty.accelerometer service
04-23 12:56:19.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27236
04-23 12:56:19.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27236) type(svcapp) bg(0)
04-23 12:56:19.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27225
04-23 12:56:19.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27236) was created
04-23 12:56:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:19.561+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27236]
04-23 12:56:19.561+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27236)
04-23 12:56:19.561+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:19.561+0200 E/CAPI_APPFW_APP_CONTROL(27225): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:56:19.561+0200 E/accelerometer(27225): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:56:19.561+0200 I/CAPI_APPFW_APPLICATION(27225): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:56:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:56:19.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:56:19.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:19.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27225
04-23 12:56:19.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:19.611+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27236
04-23 12:56:19.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:19.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:19.701+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:19.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:19.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:19.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27236
04-23 12:56:19.731+0200 I/accelerometer(27225): es.ugr.frailty.accelerometer listener destroyed
04-23 12:56:19.731+0200 I/recorder(27236): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:19.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:19.741+0200 I/recorder(27236): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:19.791+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11272367265631524480979
04-23 12:56:19.841+0200 W/AUL     (27245): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:56:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27236
04-23 12:56:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:19.841+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27236
04-23 12:56:19.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27236)
04-23 12:56:19.881+0200 W/AUL     (27246): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:56:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27225
04-23 12:56:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:19.891+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27225
04-23 12:56:19.891+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27225)
04-23 12:56:21.561+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:56:29.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:56:29.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:29.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:56:29.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:56:29.381+0200 I/utils   (25866): specific action
04-23 12:56:29.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:56:29.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:56:29.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:56:29.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:56:29.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:56:29.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:56:29.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:56:29.381+0200 I/httppostreq(25866): internet available
04-23 12:56:29.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:56:29.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:56:29.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:56:29.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:29.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:56:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:29.401+0200 I/utils   (25863): specific action
04-23 12:56:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:29.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:29.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:56:29.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:56:29.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:56:29.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:29.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:29.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:29.421+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:29.421+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27290
04-23 12:56:29.441+0200 E/wnoti-ancs( 2999): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][5][0][6b][0][0][0][0][0][0][0][0][0][0]
04-23 12:56:29.461+0200 E/CAPI_APPFW_APPLICATION(27290): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:29.461+0200 E/CAPI_APPFW_APPLICATION(27290): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:29.461+0200 I/utils   (27290): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:29.471+0200 I/utils   (27290): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:29.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27290
04-23 12:56:29.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27290) type(svcapp) bg(0)
04-23 12:56:29.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27290) was created
04-23 12:56:29.481+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27290]
04-23 12:56:29.491+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27290)
04-23 12:56:29.491+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:29.491+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:29.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:29.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:29.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:29.491+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:29.491+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:29.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:29.511+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:29.511+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27302
04-23 12:56:29.531+0200 I/utils   (27290): es.ugr.frailty.accelerometer listener started
04-23 12:56:29.531+0200 I/accelerometer(27290): stopping es.ugr.frailty.accelerometer service
04-23 12:56:29.541+0200 E/CAPI_APPFW_APP_CONTROL(27290): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:56:29.541+0200 E/accelerometer(27290): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:56:29.541+0200 I/CAPI_APPFW_APPLICATION(27290): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:56:29.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27302
04-23 12:56:29.561+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27302) type(svcapp) bg(0)
04-23 12:56:29.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27290
04-23 12:56:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:56:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:56:29.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:29.581+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27302]
04-23 12:56:29.581+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27302)
04-23 12:56:29.581+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:29.581+0200 E/CAPI_APPFW_APPLICATION(27302): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:29.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:29.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27302
04-23 12:56:29.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:29.611+0200 E/CAPI_APPFW_APPLICATION(27302): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:29.611+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27302) was created
04-23 12:56:29.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:29.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27290
04-23 12:56:29.631+0200 I/utils   (27302): specific action
04-23 12:56:29.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:29.631+0200 I/recorder(27302): obteniendo datos locales...
04-23 12:56:29.731+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:29.741+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:29.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:29.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27302
04-23 12:56:29.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:29.771+0200 I/accelerometer(27290): es.ugr.frailty.accelerometer listener destroyed
04-23 12:56:29.771+0200 I/recorder(27302): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:29.771+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:29.771+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:29.771+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:29.771+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:29.781+0200 I/recorder(27302): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:29.851+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11273027265631524480989
04-23 12:56:29.861+0200 W/AUL     (27309): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:56:29.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:29.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:29.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27302
04-23 12:56:29.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:29.871+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27302
04-23 12:56:29.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27302)
04-23 12:56:29.931+0200 W/AUL     (27313): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:56:29.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:29.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:29.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27290
04-23 12:56:29.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:29.941+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27290
04-23 12:56:29.941+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27290)
04-23 12:56:31.571+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:56:39.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:56:39.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:39.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:56:39.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:56:39.381+0200 I/utils   (25866): specific action
04-23 12:56:39.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:56:39.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:56:39.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:56:39.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:56:39.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:56:39.381+0200 I/httppostreq(25866): internet available
04-23 12:56:39.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:56:39.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:56:39.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:56:39.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:56:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:56:39.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:56:39.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:39.391+0200 I/utils   (25863): specific action
04-23 12:56:39.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:39.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:39.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:56:39.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:56:39.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:56:39.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:39.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27358
04-23 12:56:39.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:39.441+0200 E/CAPI_APPFW_APPLICATION(27358): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:39.441+0200 E/CAPI_APPFW_APPLICATION(27358): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:39.441+0200 I/utils   (27358): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:39.451+0200 I/utils   (27358): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:39.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27358
04-23 12:56:39.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27358) type(svcapp) bg(0)
04-23 12:56:39.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27358) was created
04-23 12:56:39.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27358]
04-23 12:56:39.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27358)
04-23 12:56:39.471+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:39.471+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:39.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:39.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:39.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:39.471+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:39.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:39.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:39.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:39.481+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27370
04-23 12:56:39.481+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:39.491+0200 I/utils   (27358): es.ugr.frailty.accelerometer listener started
04-23 12:56:39.491+0200 I/accelerometer(27358): stopping es.ugr.frailty.accelerometer service
04-23 12:56:39.491+0200 E/CAPI_APPFW_APP_CONTROL(27358): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:56:39.491+0200 E/accelerometer(27358): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:56:39.491+0200 I/CAPI_APPFW_APPLICATION(27358): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:56:39.521+0200 E/CAPI_APPFW_APPLICATION(27370): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:39.521+0200 E/CAPI_APPFW_APPLICATION(27370): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:39.521+0200 I/utils   (27370): specific action
04-23 12:56:39.521+0200 I/recorder(27370): obteniendo datos locales...
04-23 12:56:39.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27370
04-23 12:56:39.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27370) type(svcapp) bg(0)
04-23 12:56:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:39.541+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27370]
04-23 12:56:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27358
04-23 12:56:39.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27370) was created
04-23 12:56:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:56:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:56:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:39.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27370)
04-23 12:56:39.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:39.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27370
04-23 12:56:39.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:39.671+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:39.681+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:39.691+0200 I/recorder(27370): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:39.691+0200 I/recorder(27370): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:39.701+0200 I/accelerometer(27358): es.ugr.frailty.accelerometer listener destroyed
04-23 12:56:39.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:39.711+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27358
04-23 12:56:39.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:39.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:39.741+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27370
04-23 12:56:39.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:39.781+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1127370726563152448099
