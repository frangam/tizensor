S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21271
Date: 2018-04-23 12:35:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf773c648, r1   = 0xf78661b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78661b8, r5   = 0x00012cd0
r6   = 0xf7878e88, r7   = 0xf773c250
r8   = 0x000005d8, r9   = 0xf721f824
r10  = 0xf785e9d8, fp   = 0x00000000
ip   = 0xf773b030, sp   = 0xfff41018
lr   = 0xf767f5d0, pc   = 0xf767b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11488 KB
Buffers:     70508 KB
Cached:     190072 KB
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
VmPTE:          32 KB
VmSwap:          0 KB

Maps Information
f6db6000 f6db9000 r-xp /lib/libattr.so.1.1.0
f6dc2000 f6dc9000 r-xp /lib/libcrypt-2.13.so
f6df9000 f6dfc000 r-xp /lib/libcap.so.2.21
f6e04000 f6e06000 r-xp /usr/lib/libiri.so
f6e0e000 f6e2b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6e34000 f6e38000 r-xp /usr/lib/libsmack.so.1.0.0
f6e42000 f6e44000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e4c000 f6e51000 r-xp /usr/lib/libffi.so.5.0.10
f6e59000 f6e5a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e62000 f6e64000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e6c000 f6e6e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e78000 f6e88000 r-xp /lib/libresolv-2.13.so
f6e8c000 f6ea4000 r-xp /usr/lib/liblzma.so.5.0.3
f6eac000 f6eae000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6eb6000 f6ee5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6eee000 f6efd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6f06000 f6f10000 r-xp /usr/lib/libsensord-shared.so
f6f19000 f6f4d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f56000 f7029000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f7034000 f704a000 r-xp /lib/libz.so.1.2.5
f7052000 f7058000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7061000 f70d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f70e0000 f70fa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f7102000 f7108000 r-xp /lib/librt-2.13.so
f7111000 f712f000 r-xp /usr/lib/libsystemd.so.0.4.0
f7139000 f713a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7142000 f7147000 r-xp /usr/lib/libxdgmime.so.1.1.0
f714f000 f721f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7220000 f724a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7253000 f726a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7272000 f72db000 r-xp /lib/libm-2.13.so
f72e4000 f7378000 r-xp /usr/lib/libstdc++.so.6.0.16
f738b000 f7390000 r-xp /usr/lib/libctx-client.so.0.8.3
f7398000 f739f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f73a7000 f73d1000 r-xp /usr/lib/libsensor.so.1.9.6
f73da000 f74a6000 r-xp /usr/lib/libxml2.so.2.7.8
f74b3000 f74b5000 r-xp /usr/lib/libiniparser.so.0
f74be000 f74c1000 r-xp /usr/lib/libbundle.so.0.1.22
f74c9000 f74cf000 r-xp /usr/lib/libappsvc.so.0.1.0
f74d7000 f74fa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7502000 f7543000 r-xp /usr/lib/libeina.so.1.7.99
f754c000 f7563000 r-xp /usr/lib/libecore.so.1.7.99
f757a000 f7583000 r-xp /usr/lib/libvconf.so.0.2.45
f758b000 f759f000 r-xp /lib/libpthread-2.13.so
f75aa000 f75b7000 r-xp /usr/lib/libaul.so.0.1.0
f75c1000 f75c3000 r-xp /lib/libdl-2.13.so
f75cc000 f75d7000 r-xp /lib/libunwind.so.8.0.1
f7604000 f760c000 r-xp /lib/libgcc_s-4.6.so.1
f760d000 f7731000 r-xp /lib/libc-2.13.so
f773f000 f7741000 r-xp /usr/lib/libdlog.so.0.0.0
f7749000 f7755000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f775e000 f7763000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f776b000 f776f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7778000 f777a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7783000 f7786000 r-xp /usr/lib/libappcore-agent.so.1.1
f77a4000 f77c1000 r-xp /lib/ld-2.13.so
f77ca000 f77cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f77cd000 f77d1000 r-xp /usr/lib/libsys-assert.so
f7854000 f78a2000 rw-p [heap]
fff23000 fff44000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21271)
Call Stack Count: 1
 0: (0xf767b9fc) [/lib/libc.so.6] + 0x6e9fc
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
6,9.803394,0.830309
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:19.221+0200 I/recorder(21060): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21060
04-23 12:35:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:19.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21060
04-23 12:35:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:19.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11210607265631524479719
04-23 12:35:19.341+0200 W/AUL     (21078): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:35:19.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:19.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:19.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21060
04-23 12:35:19.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:19.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21060
04-23 12:35:19.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21060)
04-23 12:35:19.371+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:19.381+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:19.391+0200 I/accelerometer(21057): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:19.511+0200 W/AUL     (21085): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:35:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21057
04-23 12:35:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:19.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21057
04-23 12:35:19.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21057)
04-23 12:35:21.201+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:35:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:35:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:35:29.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:35:29.001+0200 I/utils   (20587): specific action
04-23 12:35:29.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:35:29.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:35:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:35:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:35:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:35:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:35:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:35:29.011+0200 I/httppostreq(20587): internet available
04-23 12:35:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:35:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:35:29.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:35:29.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:29.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:35:29.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:29.031+0200 I/utils   (20584): specific action
04-23 12:35:29.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:29.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:35:29.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:35:29.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:35:29.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:35:29.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:29.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21123
04-23 12:35:29.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:29.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21123
04-23 12:35:29.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21123) type(svcapp) bg(0)
04-23 12:35:29.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21123]
04-23 12:35:29.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21123)
04-23 12:35:29.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:35:29.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:29.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:29.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:35:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:29.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:29.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:35:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:35:29.131+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21123
04-23 12:35:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:29.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:29.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:29.151+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21126
04-23 12:35:29.161+0200 E/CAPI_APPFW_APPLICATION(21123): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:29.161+0200 E/CAPI_APPFW_APPLICATION(21123): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:29.161+0200 I/utils   (21123): trying to start service: es.ugr.frailty.accelerometer
04-23 12:35:29.161+0200 I/utils   (21123): es.ugr.frailty.accelerometer sensor supported
04-23 12:35:29.191+0200 E/CAPI_APPFW_APPLICATION(21126): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:29.191+0200 E/CAPI_APPFW_APPLICATION(21126): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:29.201+0200 I/utils   (21126): specific action
04-23 12:35:29.201+0200 I/recorder(21126): obteniendo datos locales...
04-23 12:35:29.221+0200 I/recorder(21126): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:29.221+0200 I/recorder(21126): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:29.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21126
04-23 12:35:29.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21126) type(svcapp) bg(0)
04-23 12:35:29.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:29.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21123) was created
04-23 12:35:29.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21126) was created
04-23 12:35:29.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21123
04-23 12:35:29.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21126]
04-23 12:35:29.251+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21126)
04-23 12:35:29.261+0200 I/utils   (21123): es.ugr.frailty.accelerometer listener started
04-23 12:35:29.261+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:35:29.261+0200 I/accelerometer(21123): stopping es.ugr.frailty.accelerometer service
04-23 12:35:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:29.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21126
04-23 12:35:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:29.281+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11211267265631524479729
04-23 12:35:29.281+0200 E/CAPI_APPFW_APP_CONTROL(21123): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:35:29.281+0200 E/accelerometer(21123): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:35:29.281+0200 I/CAPI_APPFW_APPLICATION(21123): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:35:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:35:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:35:29.311+0200 W/AUL     (21141): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:35:29.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:29.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:29.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21126
04-23 12:35:29.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:29.331+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21126
04-23 12:35:29.331+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21126)
04-23 12:35:29.341+0200 I/AUL     ( 3087): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
04-23 12:35:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 15
04-23 12:35:29.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:35:29.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:29.371+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:29.391+0200 I/accelerometer(21123): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:29.501+0200 W/AUL     (21149): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:35:29.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:29.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:29.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21123
04-23 12:35:29.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:29.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21123
04-23 12:35:29.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21123)
04-23 12:35:31.291+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:35:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:35:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:35:39.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:35:39.001+0200 I/utils   (20587): specific action
04-23 12:35:39.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:35:39.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:35:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:35:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:35:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:35:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:35:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:35:39.011+0200 I/httppostreq(20587): internet available
04-23 12:35:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:35:39.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:39.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:35:39.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:35:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:35:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:39.041+0200 I/utils   (20584): specific action
04-23 12:35:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:39.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:35:39.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:35:39.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:35:39.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:35:39.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:39.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21193
04-23 12:35:39.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:39.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21193
04-23 12:35:39.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21193) type(svcapp) bg(0)
04-23 12:35:39.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21193]
04-23 12:35:39.121+0200 E/CAPI_APPFW_APPLICATION(21193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:39.121+0200 E/CAPI_APPFW_APPLICATION(21193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:39.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21193) was created
04-23 12:35:39.131+0200 I/utils   (21193): trying to start service: es.ugr.frailty.accelerometer
04-23 12:35:39.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21193)
04-23 12:35:39.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:35:39.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:39.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:39.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:39.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:39.141+0200 E/servicemanager(20584): deleting timer 1
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:39.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:39.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:39.141+0200 E/servicemanager(20584): deleting timer 2
04-23 12:35:39.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:35:39.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:39.141+0200 I/utils   (21193): es.ugr.frailty.accelerometer sensor supported
04-23 12:35:39.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21193
04-23 12:35:39.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:39.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21193
04-23 12:35:39.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:39.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:39.171+0200 I/utils   (21193): es.ugr.frailty.accelerometer listener started
04-23 12:35:39.171+0200 I/accelerometer(21193): stopping es.ugr.frailty.accelerometer service
04-23 12:35:39.171+0200 E/CAPI_APPFW_APP_CONTROL(21193): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:35:39.171+0200 E/accelerometer(21193): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:35:39.171+0200 I/CAPI_APPFW_APPLICATION(21193): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:35:39.181+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21206
04-23 12:35:39.211+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:39.221+0200 E/CAPI_APPFW_APPLICATION(21206): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:39.221+0200 E/CAPI_APPFW_APPLICATION(21206): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:39.221+0200 I/utils   (21206): specific action
04-23 12:35:39.221+0200 I/recorder(21206): obteniendo datos locales...
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21206
04-23 12:35:39.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21206) type(svcapp) bg(0)
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21206) was created
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:35:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:39.241+0200 I/recorder(21206): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:39.241+0200 I/recorder(21206): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:39.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21206]
04-23 12:35:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21206
04-23 12:35:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:39.281+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21206)
04-23 12:35:39.281+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:35:39.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:39.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21206
04-23 12:35:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:39.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:39.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:39.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11212067265631524479739
04-23 12:35:39.341+0200 I/accelerometer(21193): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:39.351+0200 W/AUL     (21213): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:35:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21206
04-23 12:35:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:39.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21206
04-23 12:35:39.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21206)
04-23 12:35:39.461+0200 W/AUL     (21220): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:35:39.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:39.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:39.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21193
04-23 12:35:39.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:39.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21193
04-23 12:35:39.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21193)
04-23 12:35:41.231+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:35:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:35:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:35:49.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:35:49.011+0200 I/utils   (20587): specific action
04-23 12:35:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:35:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:35:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:35:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:35:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:35:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:35:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:35:49.011+0200 I/httppostreq(20587): internet available
04-23 12:35:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:35:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:49.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:35:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:35:49.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:35:49.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:49.051+0200 I/utils   (20584): specific action
04-23 12:35:49.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:35:49.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:49.051+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:35:49.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:35:49.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:35:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:49.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21258
04-23 12:35:49.081+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21258
04-23 12:35:49.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21258) type(svcapp) bg(0)
04-23 12:35:49.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21258]
04-23 12:35:49.151+0200 E/CAPI_APPFW_APPLICATION(21258): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:49.151+0200 E/CAPI_APPFW_APPLICATION(21258): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:49.151+0200 I/utils   (21258): trying to start service: es.ugr.frailty.accelerometer
04-23 12:35:49.151+0200 I/utils   (21258): es.ugr.frailty.accelerometer sensor supported
04-23 12:35:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21258
04-23 12:35:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:49.171+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21258)
04-23 12:35:49.171+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:35:49.171+0200 I/servicemanager(20584): App control destroyed.
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:49.171+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:49.171+0200 E/servicemanager(20584): deleting timer 0
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:49.171+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:49.171+0200 E/servicemanager(20584): deleting timer 1
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:49.171+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:49.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:49.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:49.171+0200 E/servicemanager(20584): deleting timer 2
04-23 12:35:49.171+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:35:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21258
04-23 12:35:49.171+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21258) was created
04-23 12:35:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:49.171+0200 I/utils   (21258): es.ugr.frailty.accelerometer listener started
04-23 12:35:49.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:49.181+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21271
04-23 12:35:49.181+0200 I/accelerometer(21258): stopping es.ugr.frailty.accelerometer service
04-23 12:35:49.181+0200 E/CAPI_APPFW_APP_CONTROL(21258): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:35:49.181+0200 E/accelerometer(21258): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:35:49.181+0200 I/CAPI_APPFW_APPLICATION(21258): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:35:49.211+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:49.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21271
04-23 12:35:49.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21271) type(svcapp) bg(0)
04-23 12:35:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:35:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:35:49.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21271)
04-23 12:35:49.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:35:49.241+0200 E/CAPI_APPFW_APPLICATION(21271): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:49.241+0200 E/CAPI_APPFW_APPLICATION(21271): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:49.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21271) was created
04-23 12:35:49.241+0200 I/utils   (21271): specific action
04-23 12:35:49.241+0200 I/recorder(21271): obteniendo datos locales...
04-23 12:35:49.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21271]
04-23 12:35:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21271
04-23 12:35:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:49.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:49.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21271
04-23 12:35:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:49.301+0200 I/recorder(21271): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:49.301+0200 I/recorder(21271): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:49.311+0200 I/accelerometer(21258): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:49.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121271726563152447974
