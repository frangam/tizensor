S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 27438
Date: 2018-04-23 12:56:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf72cc648, r1   = 0xf78e61b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78e61b8, r5   = 0x00012cd0
r6   = 0xf78f8e88, r7   = 0xf72cc250
r8   = 0x000005c8, r9   = 0xf6daf824
r10  = 0xf78de9d8, fp   = 0x00000000
ip   = 0xf72cb030, sp   = 0xfff24220
lr   = 0xf720f5d0, pc   = 0xf720b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13156 KB
Buffers:     72272 KB
Cached:     185664 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7692 KB
VmRSS:        7688 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6946000 f6949000 r-xp /lib/libattr.so.1.1.0
f6952000 f6959000 r-xp /lib/libcrypt-2.13.so
f6989000 f698c000 r-xp /lib/libcap.so.2.21
f6994000 f6996000 r-xp /usr/lib/libiri.so
f699e000 f69bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69c4000 f69c8000 r-xp /usr/lib/libsmack.so.1.0.0
f69d2000 f69d4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69dc000 f69e1000 r-xp /usr/lib/libffi.so.5.0.10
f69e9000 f69ea000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69f2000 f69f4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69fc000 f69fe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a08000 f6a18000 r-xp /lib/libresolv-2.13.so
f6a1c000 f6a34000 r-xp /usr/lib/liblzma.so.5.0.3
f6a3c000 f6a3e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a46000 f6a75000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a7e000 f6a8d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a96000 f6aa0000 r-xp /usr/lib/libsensord-shared.so
f6aa9000 f6add000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ae6000 f6bb9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bc4000 f6bda000 r-xp /lib/libz.so.1.2.5
f6be2000 f6be8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bf1000 f6c66000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c70000 f6c8a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c92000 f6c98000 r-xp /lib/librt-2.13.so
f6ca1000 f6cbf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cc9000 f6cca000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cd2000 f6cd7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cdf000 f6daf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6db0000 f6dda000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6de3000 f6dfa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e02000 f6e6b000 r-xp /lib/libm-2.13.so
f6e74000 f6f08000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f1b000 f6f20000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f28000 f6f2f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f37000 f6f61000 r-xp /usr/lib/libsensor.so.1.9.6
f6f6a000 f7036000 r-xp /usr/lib/libxml2.so.2.7.8
f7043000 f7045000 r-xp /usr/lib/libiniparser.so.0
f704e000 f7051000 r-xp /usr/lib/libbundle.so.0.1.22
f7059000 f705f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7067000 f708a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7092000 f70d3000 r-xp /usr/lib/libeina.so.1.7.99
f70dc000 f70f3000 r-xp /usr/lib/libecore.so.1.7.99
f710a000 f7113000 r-xp /usr/lib/libvconf.so.0.2.45
f711b000 f712f000 r-xp /lib/libpthread-2.13.so
f713a000 f7147000 r-xp /usr/lib/libaul.so.0.1.0
f7151000 f7153000 r-xp /lib/libdl-2.13.so
f715c000 f7167000 r-xp /lib/libunwind.so.8.0.1
f7194000 f719c000 r-xp /lib/libgcc_s-4.6.so.1
f719d000 f72c1000 r-xp /lib/libc-2.13.so
f72cf000 f72d1000 r-xp /usr/lib/libdlog.so.0.0.0
f72d9000 f72e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72ee000 f72f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72fb000 f72ff000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7308000 f730a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7313000 f7316000 r-xp /usr/lib/libappcore-agent.so.1.1
f7334000 f7351000 r-xp /lib/ld-2.13.so
f735a000 f735d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f735d000 f7361000 r-xp /usr/lib/libsys-assert.so
f78d4000 f7922000 rw-p [heap]
fff06000 fff27000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27438)
Call Stack Count: 1
 0: (0xf720b9fc) [/lib/libc.so.6] + 0x6e9fc
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
st.c: __request_handler(669) > __request_handler: 0
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
04-23 12:56:39.781+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11273707265631524480999
04-23 12:56:39.791+0200 W/AUL     (27377): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:56:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27370
04-23 12:56:39.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:39.801+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27370
04-23 12:56:39.801+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27370)
04-23 12:56:39.841+0200 W/AUL     (27379): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:56:39.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:56:39.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:56:39.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27358
04-23 12:56:39.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:56:39.851+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27358
04-23 12:56:39.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27358)
04-23 12:56:41.551+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:56:49.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:56:49.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:49.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:56:49.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:56:49.381+0200 I/utils   (25866): specific action
04-23 12:56:49.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:56:49.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:56:49.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:56:49.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:56:49.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:56:49.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:56:49.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:56:49.381+0200 I/httppostreq(25866): internet available
04-23 12:56:49.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:56:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:49.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:56:49.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:56:49.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:49.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:56:49.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:49.401+0200 I/utils   (25863): specific action
04-23 12:56:49.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:49.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:49.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:56:49.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:56:49.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:56:49.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:49.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:49.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:49.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27426
04-23 12:56:49.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:49.451+0200 E/CAPI_APPFW_APPLICATION(27426): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:49.451+0200 E/CAPI_APPFW_APPLICATION(27426): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:49.451+0200 I/utils   (27426): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:49.451+0200 I/utils   (27426): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:49.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27426
04-23 12:56:49.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27426) type(svcapp) bg(0)
04-23 12:56:49.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27426) was created
04-23 12:56:49.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27426)
04-23 12:56:49.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:49.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:49.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:49.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:49.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:49.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:49.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:49.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27426]
04-23 12:56:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:49.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:49.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27438
04-23 12:56:49.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:49.531+0200 E/CAPI_APPFW_APPLICATION(27438): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:49.531+0200 E/CAPI_APPFW_APPLICATION(27438): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:49.531+0200 I/utils   (27438): specific action
04-23 12:56:49.541+0200 I/recorder(27438): obteniendo datos locales...
04-23 12:56:49.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27438
04-23 12:56:49.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27438) type(svcapp) bg(0)
04-23 12:56:49.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:49.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27438)
04-23 12:56:49.551+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:49.551+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27438]
04-23 12:56:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27426
04-23 12:56:49.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27438) was created
04-23 12:56:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27426
04-23 12:56:49.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:49.571+0200 I/utils   (27426): es.ugr.frailty.accelerometer listener started
04-23 12:56:49.571+0200 I/accelerometer(27426): stopping es.ugr.frailty.accelerometer service
04-23 12:56:49.571+0200 E/CAPI_APPFW_APP_CONTROL(27426): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:56:49.571+0200 E/accelerometer(27426): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:56:49.571+0200 I/CAPI_APPFW_APPLICATION(27426): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:56:49.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:56:49.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:56:49.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:49.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:49.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27438
04-23 12:56:49.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:49.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:49.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27438
04-23 12:56:49.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:49.631+0200 I/recorder(27438): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:49.631+0200 I/recorder(27438): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:49.731+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:49.741+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:56:49.761+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1127438726563152448100
