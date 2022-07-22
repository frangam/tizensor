S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22061
Date: 2018-04-23 12:37:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf739c648, r1   = 0xf7bc71b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7bc71b8, r5   = 0x00012cd0
r6   = 0xf7bd9e88, r7   = 0xf739c250
r8   = 0x000005d8, r9   = 0xf6e7f824
r10  = 0xf7bbf9d8, fp   = 0x00000000
ip   = 0xf739b030, sp   = 0xff83f7f8
lr   = 0xf72df5d0, pc   = 0xf72db9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9040 KB
Buffers:     70700 KB
Cached:     190664 KB
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
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6a16000 f6a19000 r-xp /lib/libattr.so.1.1.0
f6a22000 f6a29000 r-xp /lib/libcrypt-2.13.so
f6a59000 f6a5c000 r-xp /lib/libcap.so.2.21
f6a64000 f6a66000 r-xp /usr/lib/libiri.so
f6a6e000 f6a8b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a94000 f6a98000 r-xp /usr/lib/libsmack.so.1.0.0
f6aa2000 f6aa4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6aac000 f6ab1000 r-xp /usr/lib/libffi.so.5.0.10
f6ab9000 f6aba000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ac2000 f6ac4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6acc000 f6ace000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ad8000 f6ae8000 r-xp /lib/libresolv-2.13.so
f6aec000 f6b04000 r-xp /usr/lib/liblzma.so.5.0.3
f6b0c000 f6b0e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b16000 f6b45000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b4e000 f6b5d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b66000 f6b70000 r-xp /usr/lib/libsensord-shared.so
f6b79000 f6bad000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6bb6000 f6c89000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c94000 f6caa000 r-xp /lib/libz.so.1.2.5
f6cb2000 f6cb8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cc1000 f6d36000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d40000 f6d5a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d62000 f6d68000 r-xp /lib/librt-2.13.so
f6d71000 f6d8f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d99000 f6d9a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6da2000 f6da7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6daf000 f6e7f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e80000 f6eaa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6eb3000 f6eca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ed2000 f6f3b000 r-xp /lib/libm-2.13.so
f6f44000 f6fd8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6feb000 f6ff0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ff8000 f6fff000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7007000 f7031000 r-xp /usr/lib/libsensor.so.1.9.6
f703a000 f7106000 r-xp /usr/lib/libxml2.so.2.7.8
f7113000 f7115000 r-xp /usr/lib/libiniparser.so.0
f711e000 f7121000 r-xp /usr/lib/libbundle.so.0.1.22
f7129000 f712f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7137000 f715a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7162000 f71a3000 r-xp /usr/lib/libeina.so.1.7.99
f71ac000 f71c3000 r-xp /usr/lib/libecore.so.1.7.99
f71da000 f71e3000 r-xp /usr/lib/libvconf.so.0.2.45
f71eb000 f71ff000 r-xp /lib/libpthread-2.13.so
f720a000 f7217000 r-xp /usr/lib/libaul.so.0.1.0
f7221000 f7223000 r-xp /lib/libdl-2.13.so
f722c000 f7237000 r-xp /lib/libunwind.so.8.0.1
f7264000 f726c000 r-xp /lib/libgcc_s-4.6.so.1
f726d000 f7391000 r-xp /lib/libc-2.13.so
f739f000 f73a1000 r-xp /usr/lib/libdlog.so.0.0.0
f73a9000 f73b5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73be000 f73c3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73cb000 f73cf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73d8000 f73da000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f73e3000 f73e6000 r-xp /usr/lib/libappcore-agent.so.1.1
f7404000 f7421000 r-xp /lib/ld-2.13.so
f742a000 f742d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f742d000 f7431000 r-xp /usr/lib/libsys-assert.so
f7bb5000 f7c03000 rw-p [heap]
ff821000 ff842000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22061)
Call Stack Count: 1
 0: (0xf72db9fc) [/lib/libc.so.6] + 0x6e9fc
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
18,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:19.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21871]
04-23 12:37:19.261+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21871)
04-23 12:37:19.261+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21871
04-23 12:37:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21871
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.311+0200 I/accelerometer(21858): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:19.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11218717265631524479839
04-23 12:37:19.361+0200 W/AUL     (21878): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21871
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:19.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21871
04-23 12:37:19.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21871)
04-23 12:37:19.451+0200 W/AUL     (21884): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21858
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:19.461+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21858
04-23 12:37:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21858)
04-23 12:37:21.221+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:29.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:29.011+0200 I/utils   (20587): specific action
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:29.011+0200 I/httppostreq(20587): internet available
04-23 12:37:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:29.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:29.041+0200 I/utils   (20584): specific action
04-23 12:37:29.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:29.051+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:29.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:29.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:29.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:29.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21922
04-23 12:37:29.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21922
04-23 12:37:29.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21922) type(svcapp) bg(0)
04-23 12:37:29.131+0200 E/CAPI_APPFW_APPLICATION(21922): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.131+0200 E/CAPI_APPFW_APPLICATION(21922): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.131+0200 I/utils   (21922): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:29.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21922) was created
04-23 12:37:29.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21922]
04-23 12:37:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21922)
04-23 12:37:29.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:29.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:29.131+0200 I/utils   (21922): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:29.141+0200 I/utils   (21922): es.ugr.frailty.accelerometer listener started
04-23 12:37:29.141+0200 I/accelerometer(21922): stopping es.ugr.frailty.accelerometer service
04-23 12:37:29.141+0200 E/CAPI_APPFW_APP_CONTROL(21922): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.141+0200 E/accelerometer(21922): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:29.141+0200 I/CAPI_APPFW_APPLICATION(21922): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.161+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21934
04-23 12:37:29.161+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21934
04-23 12:37:29.211+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21934) type(svcapp) bg(0)
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.211+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21934]
04-23 12:37:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21922
04-23 12:37:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.221+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21934)
04-23 12:37:29.221+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:29.231+0200 E/CAPI_APPFW_APPLICATION(21934): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.231+0200 E/CAPI_APPFW_APPLICATION(21934): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21934) was created
04-23 12:37:29.231+0200 I/utils   (21934): specific action
04-23 12:37:29.231+0200 I/recorder(21934): obteniendo datos locales...
04-23 12:37:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21934
04-23 12:37:29.251+0200 I/recorder(21934): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21922
04-23 12:37:29.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.311+0200 I/accelerometer(21922): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21934
04-23 12:37:29.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11219347265631524479849
04-23 12:37:29.341+0200 W/AUL     (21941): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21934
04-23 12:37:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:29.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21934
04-23 12:37:29.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21934)
04-23 12:37:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.351+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:37:29.351+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:37:29.451+0200 W/AUL     (21948): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:29.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21922
04-23 12:37:29.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:29.461+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21922
04-23 12:37:29.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21922)
04-23 12:37:31.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:39.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:39.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:39.011+0200 I/utils   (20587): specific action
04-23 12:37:39.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:39.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:39.011+0200 I/httppostreq(20587): internet available
04-23 12:37:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:39.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:39.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:39.041+0200 I/utils   (20584): specific action
04-23 12:37:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:39.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:39.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:39.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:39.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:39.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:39.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:39.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:39.081+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21988
04-23 12:37:39.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21988
04-23 12:37:39.131+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21988) type(svcapp) bg(0)
04-23 12:37:39.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21988)
04-23 12:37:39.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:39.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:39.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:39.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:39.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:39.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:39.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:39.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:39.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:39.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:39.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:39.131+0200 E/CAPI_APPFW_APPLICATION(21988): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:39.131+0200 E/CAPI_APPFW_APPLICATION(21988): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:39.131+0200 I/utils   (21988): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:39.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21988]
04-23 12:37:39.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:39.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:39.161+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21993
04-23 12:37:39.161+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:39.161+0200 I/utils   (21988): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:39.181+0200 I/utils   (21988): es.ugr.frailty.accelerometer listener started
04-23 12:37:39.181+0200 I/accelerometer(21988): stopping es.ugr.frailty.accelerometer service
04-23 12:37:39.181+0200 E/CAPI_APPFW_APP_CONTROL(21988): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:39.181+0200 E/accelerometer(21988): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:39.181+0200 I/CAPI_APPFW_APPLICATION(21988): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:39.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21993
04-23 12:37:39.211+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21993) type(svcapp) bg(0)
04-23 12:37:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:39.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21988
04-23 12:37:39.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21988) was created
04-23 12:37:39.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21988
04-23 12:37:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:39.231+0200 E/CAPI_APPFW_APPLICATION(21993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:39.231+0200 E/CAPI_APPFW_APPLICATION(21993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:39.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21993) was created
04-23 12:37:39.241+0200 I/utils   (21993): specific action
04-23 12:37:39.241+0200 I/recorder(21993): obteniendo datos locales...
04-23 12:37:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:39.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21993]
04-23 12:37:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:39.281+0200 I/recorder(21993): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:39.281+0200 I/recorder(21993): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21993
04-23 12:37:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21993
04-23 12:37:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:39.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:39.301+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21993)
04-23 12:37:39.301+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:39.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:39.341+0200 W/AUL     (22006): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:39.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:39.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:39.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21993
04-23 12:37:39.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:39.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21993
04-23 12:37:39.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21993)
04-23 12:37:39.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11219937265631524479859
04-23 12:37:39.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:39.371+0200 I/accelerometer(21988): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:39.491+0200 W/AUL     (22014): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21988
04-23 12:37:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:39.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21988
04-23 12:37:39.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21988)
04-23 12:37:41.231+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:49.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:49.011+0200 I/utils   (20587): specific action
04-23 12:37:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:49.011+0200 I/httppostreq(20587): internet available
04-23 12:37:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:49.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:49.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:49.041+0200 I/utils   (20584): specific action
04-23 12:37:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:49.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:49.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22052
04-23 12:37:49.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:49.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22052
04-23 12:37:49.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22052) type(svcapp) bg(0)
04-23 12:37:49.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22052]
04-23 12:37:49.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22052)
04-23 12:37:49.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:49.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:49.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:49.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:49.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:49.141+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:49.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:49.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22052
04-23 12:37:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:49.151+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:49.151+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:49.151+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:49.151+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:49.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:49.161+0200 E/CAPI_APPFW_APPLICATION(22052): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:49.161+0200 E/CAPI_APPFW_APPLICATION(22052): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:49.161+0200 I/utils   (22052): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:49.161+0200 I/utils   (22052): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:49.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22061
04-23 12:37:49.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:49.221+0200 E/CAPI_APPFW_APPLICATION(22061): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:49.221+0200 E/CAPI_APPFW_APPLICATION(22061): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:49.221+0200 I/utils   (22061): specific action
04-23 12:37:49.221+0200 I/recorder(22061): obteniendo datos locales...
04-23 12:37:49.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22061
04-23 12:37:49.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22061) type(svcapp) bg(0)
04-23 12:37:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:49.241+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22061]
04-23 12:37:49.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22052
04-23 12:37:49.251+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22052) was created
04-23 12:37:49.251+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22061) was created
04-23 12:37:49.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:49.251+0200 I/utils   (22052): es.ugr.frailty.accelerometer listener started
04-23 12:37:49.261+0200 I/accelerometer(22052): stopping es.ugr.frailty.accelerometer service
04-23 12:37:49.261+0200 E/CAPI_APPFW_APP_CONTROL(22052): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:49.261+0200 E/accelerometer(22052): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:49.261+0200 I/CAPI_APPFW_APPLICATION(22052): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22061
04-23 12:37:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:49.281+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22061)
04-23 12:37:49.281+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:49.281+0200 I/recorder(22061): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:49.281+0200 I/recorder(22061): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:49.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:49.361+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122061726563152447986
