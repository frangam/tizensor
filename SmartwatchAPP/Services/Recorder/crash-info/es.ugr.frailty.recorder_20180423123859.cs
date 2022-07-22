S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22511
Date: 2018-04-23 12:38:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf716a648, r1   = 0xf79b71b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf79b71b8, r5   = 0x00012cd0
r6   = 0xf79c9e88, r7   = 0xf716a250
r8   = 0x000005d8, r9   = 0xf6c4d824
r10  = 0xf79af9d8, fp   = 0x00000000
ip   = 0xf7169030, sp   = 0xffaeb4f8
lr   = 0xf70ad5d0, pc   = 0xf70a99fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8648 KB
Buffers:     70848 KB
Cached:     191088 KB
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
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f67e4000 f67e7000 r-xp /lib/libattr.so.1.1.0
f67f0000 f67f7000 r-xp /lib/libcrypt-2.13.so
f6827000 f682a000 r-xp /lib/libcap.so.2.21
f6832000 f6834000 r-xp /usr/lib/libiri.so
f683c000 f6859000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6862000 f6866000 r-xp /usr/lib/libsmack.so.1.0.0
f6870000 f6872000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f687a000 f687f000 r-xp /usr/lib/libffi.so.5.0.10
f6887000 f6888000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6890000 f6892000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f689a000 f689c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68a6000 f68b6000 r-xp /lib/libresolv-2.13.so
f68ba000 f68d2000 r-xp /usr/lib/liblzma.so.5.0.3
f68da000 f68dc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68e4000 f6913000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f691c000 f692b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6934000 f693e000 r-xp /usr/lib/libsensord-shared.so
f6947000 f697b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6984000 f6a57000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a62000 f6a78000 r-xp /lib/libz.so.1.2.5
f6a80000 f6a86000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a8f000 f6b04000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b0e000 f6b28000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b30000 f6b36000 r-xp /lib/librt-2.13.so
f6b3f000 f6b5d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b67000 f6b68000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b70000 f6b75000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b7d000 f6c4d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c4e000 f6c78000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c81000 f6c98000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ca0000 f6d09000 r-xp /lib/libm-2.13.so
f6d12000 f6da6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6db9000 f6dbe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dc6000 f6dcd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dd5000 f6dff000 r-xp /usr/lib/libsensor.so.1.9.6
f6e08000 f6ed4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ee1000 f6ee3000 r-xp /usr/lib/libiniparser.so.0
f6eec000 f6eef000 r-xp /usr/lib/libbundle.so.0.1.22
f6ef7000 f6efd000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f05000 f6f28000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f30000 f6f71000 r-xp /usr/lib/libeina.so.1.7.99
f6f7a000 f6f91000 r-xp /usr/lib/libecore.so.1.7.99
f6fa8000 f6fb1000 r-xp /usr/lib/libvconf.so.0.2.45
f6fb9000 f6fcd000 r-xp /lib/libpthread-2.13.so
f6fd8000 f6fe5000 r-xp /usr/lib/libaul.so.0.1.0
f6fef000 f6ff1000 r-xp /lib/libdl-2.13.so
f6ffa000 f7005000 r-xp /lib/libunwind.so.8.0.1
f7032000 f703a000 r-xp /lib/libgcc_s-4.6.so.1
f703b000 f715f000 r-xp /lib/libc-2.13.so
f716d000 f716f000 r-xp /usr/lib/libdlog.so.0.0.0
f7177000 f7183000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f718c000 f7191000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7199000 f719d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71a6000 f71a8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f71b1000 f71b4000 r-xp /usr/lib/libappcore-agent.so.1.1
f71d2000 f71ef000 r-xp /lib/ld-2.13.so
f71f8000 f71fb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f71fb000 f71ff000 r-xp /usr/lib/libsys-assert.so
f79a5000 f79f3000 rw-p [heap]
ffacd000 ffaee000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22511)
Call Stack Count: 1
 0: (0xf70a99fc) [/lib/libc.so.6] + 0x6e9fc
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
:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22316
04-23 12:38:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22316
04-23 12:38:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.311+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11223167265631524479909
04-23 12:38:29.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:29.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:29.351+0200 W/AUL     (22333): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22316
04-23 12:38:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:29.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22316
04-23 12:38:29.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22316)
04-23 12:38:29.361+0200 I/accelerometer(22313): es.ugr.frailty.accelerometer listener destroyed
04-23 12:38:29.481+0200 W/AUL     (22339): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:38:29.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:29.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:29.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22313
04-23 12:38:29.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:29.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22313
04-23 12:38:29.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22313)
04-23 12:38:31.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:39.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:39.001+0200 I/utils   (20587): specific action
04-23 12:38:39.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:39.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:39.011+0200 I/httppostreq(20587): internet available
04-23 12:38:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:39.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:39.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:39.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:39.041+0200 I/utils   (20584): specific action
04-23 12:38:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:39.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:39.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:39.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:39.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:39.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22380
04-23 12:38:39.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:39.071+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:39.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22380
04-23 12:38:39.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22380) type(svcapp) bg(0)
04-23 12:38:39.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22380)
04-23 12:38:39.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:39.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:39.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:39.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:39.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:39.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:39.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:39.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:39.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:39.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:39.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:39.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22380]
04-23 12:38:39.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22383
04-23 12:38:39.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:39.161+0200 E/CAPI_APPFW_APPLICATION(22380): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:39.161+0200 E/CAPI_APPFW_APPLICATION(22380): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:39.161+0200 I/utils   (22380): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:39.171+0200 I/utils   (22380): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:39.181+0200 I/utils   (22380): es.ugr.frailty.accelerometer listener started
04-23 12:38:39.181+0200 I/accelerometer(22380): stopping es.ugr.frailty.accelerometer service
04-23 12:38:39.181+0200 E/CAPI_APPFW_APP_CONTROL(22380): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:39.181+0200 E/accelerometer(22380): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:39.181+0200 I/CAPI_APPFW_APPLICATION(22380): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:39.181+0200 E/CAPI_APPFW_APPLICATION(22383): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:39.181+0200 E/CAPI_APPFW_APPLICATION(22383): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:39.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22383
04-23 12:38:39.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22383) type(svcapp) bg(0)
04-23 12:38:39.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:39.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22383]
04-23 12:38:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22380
04-23 12:38:39.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22380) was created
04-23 12:38:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:39.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22383)
04-23 12:38:39.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:38:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22380
04-23 12:38:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:39.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22383) was created
04-23 12:38:39.211+0200 I/utils   (22383): specific action
04-23 12:38:39.211+0200 I/recorder(22383): obteniendo datos locales...
04-23 12:38:39.231+0200 I/recorder(22383): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:39.231+0200 I/recorder(22383): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22383
04-23 12:38:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22383
04-23 12:38:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:39.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11223837265631524479919
04-23 12:38:39.311+0200 W/AUL     (22398): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:38:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22383
04-23 12:38:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:39.321+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22383
04-23 12:38:39.321+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22383)
04-23 12:38:39.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:39.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:39.371+0200 I/accelerometer(22380): es.ugr.frailty.accelerometer listener destroyed
04-23 12:38:39.491+0200 W/AUL     (22406): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:38:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22380
04-23 12:38:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:39.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22380
04-23 12:38:39.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22380)
04-23 12:38:41.201+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:49.011+0200 I/utils   (20587): specific action
04-23 12:38:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:49.011+0200 I/httppostreq(20587): internet available
04-23 12:38:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:49.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:49.041+0200 I/utils   (20584): specific action
04-23 12:38:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:49.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:49.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22444
04-23 12:38:49.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22444
04-23 12:38:49.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22444) type(svcapp) bg(0)
04-23 12:38:49.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22444)
04-23 12:38:49.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:49.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:49.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:49.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:49.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:49.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:49.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22444]
04-23 12:38:49.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22447
04-23 12:38:49.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:49.151+0200 E/CAPI_APPFW_APPLICATION(22444): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:49.151+0200 E/CAPI_APPFW_APPLICATION(22444): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:49.151+0200 I/utils   (22444): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:49.161+0200 I/utils   (22444): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:49.171+0200 I/utils   (22444): es.ugr.frailty.accelerometer listener started
04-23 12:38:49.171+0200 I/accelerometer(22444): stopping es.ugr.frailty.accelerometer service
04-23 12:38:49.171+0200 E/CAPI_APPFW_APP_CONTROL(22444): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:49.171+0200 E/accelerometer(22444): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:49.171+0200 I/CAPI_APPFW_APPLICATION(22444): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:49.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22447
04-23 12:38:49.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22447) type(svcapp) bg(0)
04-23 12:38:49.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22444
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22444) was created
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:49.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22447)
04-23 12:38:49.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:38:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22444
04-23 12:38:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:49.221+0200 E/CAPI_APPFW_APPLICATION(22447): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:49.221+0200 E/CAPI_APPFW_APPLICATION(22447): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:49.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22447) was created
04-23 12:38:49.231+0200 I/utils   (22447): specific action
04-23 12:38:49.231+0200 I/recorder(22447): obteniendo datos locales...
04-23 12:38:49.251+0200 I/recorder(22447): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:49.251+0200 I/recorder(22447): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:49.271+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22447]
04-23 12:38:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:49.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22447
04-23 12:38:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22447
04-23 12:38:49.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:49.331+0200 I/accelerometer(22444): es.ugr.frailty.accelerometer listener destroyed
04-23 12:38:49.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11224477265631524479929
04-23 12:38:49.361+0200 W/AUL     (22463): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:38:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22447
04-23 12:38:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:49.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22447
04-23 12:38:49.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22447)
04-23 12:38:49.491+0200 W/AUL     (22470): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:38:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22444
04-23 12:38:49.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:49.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22444
04-23 12:38:49.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22444)
04-23 12:38:51.201+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:59.001+0200 I/utils   (20587): specific action
04-23 12:38:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:59.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:59.011+0200 I/httppostreq(20587): internet available
04-23 12:38:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:59.031+0200 I/utils   (20584): specific action
04-23 12:38:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:59.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:59.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:59.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22508
04-23 12:38:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22508
04-23 12:38:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22508) type(svcapp) bg(0)
04-23 12:38:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22508)
04-23 12:38:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:59.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22508]
04-23 12:38:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22511
04-23 12:38:59.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:59.151+0200 E/CAPI_APPFW_APPLICATION(22508): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:59.151+0200 E/CAPI_APPFW_APPLICATION(22508): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:59.151+0200 I/utils   (22508): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:59.161+0200 I/utils   (22508): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:59.181+0200 E/CAPI_APPFW_APPLICATION(22511): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:59.181+0200 E/CAPI_APPFW_APPLICATION(22511): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:59.181+0200 I/utils   (22511): specific action
04-23 12:38:59.181+0200 I/recorder(22511): obteniendo datos locales...
04-23 12:38:59.201+0200 I/recorder(22511): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:59.201+0200 I/recorder(22511): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:59.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22511
04-23 12:38:59.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22511) type(svcapp) bg(0)
04-23 12:38:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22508
04-23 12:38:59.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22508) was created
04-23 12:38:59.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22511) was created
04-23 12:38:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:59.241+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22511]
04-23 12:38:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22508
04-23 12:38:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:59.261+0200 I/utils   (22508): es.ugr.frailty.accelerometer listener started
04-23 12:38:59.261+0200 I/accelerometer(22508): stopping es.ugr.frailty.accelerometer service
04-23 12:38:59.261+0200 E/CAPI_APPFW_APP_CONTROL(22508): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:59.261+0200 E/accelerometer(22508): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:59.261+0200 I/CAPI_APPFW_APPLICATION(22508): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22511
04-23 12:38:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22511
04-23 12:38:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:59.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122511726563152447993
