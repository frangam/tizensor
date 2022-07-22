S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21797
Date: 2018-04-23 12:37:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7552648, r1   = 0xf7ccb1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7ccb1b8, r5   = 0x00012cd0
r6   = 0xf7cdde88, r7   = 0xf7552250
r8   = 0x000005d8, r9   = 0xf7035824
r10  = 0xf7cc39d8, fp   = 0x00000000
ip   = 0xf7551030, sp   = 0xffb1d778
lr   = 0xf74955d0, pc   = 0xf74919fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9828 KB
Buffers:     70636 KB
Cached:     190404 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7760 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6bcc000 f6bcf000 r-xp /lib/libattr.so.1.1.0
f6bd8000 f6bdf000 r-xp /lib/libcrypt-2.13.so
f6c0f000 f6c12000 r-xp /lib/libcap.so.2.21
f6c1a000 f6c1c000 r-xp /usr/lib/libiri.so
f6c24000 f6c41000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c4a000 f6c4e000 r-xp /usr/lib/libsmack.so.1.0.0
f6c58000 f6c5a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c62000 f6c67000 r-xp /usr/lib/libffi.so.5.0.10
f6c6f000 f6c70000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c78000 f6c7a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c82000 f6c84000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c8e000 f6c9e000 r-xp /lib/libresolv-2.13.so
f6ca2000 f6cba000 r-xp /usr/lib/liblzma.so.5.0.3
f6cc2000 f6cc4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ccc000 f6cfb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d04000 f6d13000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d1c000 f6d26000 r-xp /usr/lib/libsensord-shared.so
f6d2f000 f6d63000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d6c000 f6e3f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e4a000 f6e60000 r-xp /lib/libz.so.1.2.5
f6e68000 f6e6e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e77000 f6eec000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ef6000 f6f10000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f18000 f6f1e000 r-xp /lib/librt-2.13.so
f6f27000 f6f45000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f4f000 f6f50000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f58000 f6f5d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f65000 f7035000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7036000 f7060000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7069000 f7080000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7088000 f70f1000 r-xp /lib/libm-2.13.so
f70fa000 f718e000 r-xp /usr/lib/libstdc++.so.6.0.16
f71a1000 f71a6000 r-xp /usr/lib/libctx-client.so.0.8.3
f71ae000 f71b5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71bd000 f71e7000 r-xp /usr/lib/libsensor.so.1.9.6
f71f0000 f72bc000 r-xp /usr/lib/libxml2.so.2.7.8
f72c9000 f72cb000 r-xp /usr/lib/libiniparser.so.0
f72d4000 f72d7000 r-xp /usr/lib/libbundle.so.0.1.22
f72df000 f72e5000 r-xp /usr/lib/libappsvc.so.0.1.0
f72ed000 f7310000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7318000 f7359000 r-xp /usr/lib/libeina.so.1.7.99
f7362000 f7379000 r-xp /usr/lib/libecore.so.1.7.99
f7390000 f7399000 r-xp /usr/lib/libvconf.so.0.2.45
f73a1000 f73b5000 r-xp /lib/libpthread-2.13.so
f73c0000 f73cd000 r-xp /usr/lib/libaul.so.0.1.0
f73d7000 f73d9000 r-xp /lib/libdl-2.13.so
f73e2000 f73ed000 r-xp /lib/libunwind.so.8.0.1
f741a000 f7422000 r-xp /lib/libgcc_s-4.6.so.1
f7423000 f7547000 r-xp /lib/libc-2.13.so
f7555000 f7557000 r-xp /usr/lib/libdlog.so.0.0.0
f755f000 f756b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7574000 f7579000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7581000 f7585000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f758e000 f7590000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7599000 f759c000 r-xp /usr/lib/libappcore-agent.so.1.1
f75ba000 f75d7000 r-xp /lib/ld-2.13.so
f75e0000 f75e3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f75e3000 f75e7000 r-xp /usr/lib/libsys-assert.so
f7cb9000 f7d07000 rw-p [heap]
ffaff000 ffb20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21797)
Call Stack Count: 1
 0: (0xf74919fc) [/lib/libc.so.6] + 0x6e9fc
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
+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21590) was created
04-23 12:36:39.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21593) was created
04-23 12:36:39.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21590
04-23 12:36:39.241+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21593]
04-23 12:36:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:39.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21593)
04-23 12:36:39.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:39.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:39.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21593
04-23 12:36:39.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:39.261+0200 I/utils   (21590): es.ugr.frailty.accelerometer listener started
04-23 12:36:39.261+0200 I/accelerometer(21590): stopping es.ugr.frailty.accelerometer service
04-23 12:36:39.261+0200 E/CAPI_APPFW_APP_CONTROL(21590): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:39.261+0200 E/accelerometer(21590): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:39.261+0200 I/CAPI_APPFW_APPLICATION(21590): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:39.281+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11215937265631524479799
04-23 12:36:39.291+0200 W/AUL     (21608): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21593
04-23 12:36:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:39.311+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21593
04-23 12:36:39.311+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21593)
04-23 12:36:39.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:39.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:39.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:36:39.351+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:36:39.351+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:36:39.371+0200 I/accelerometer(21590): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:39.491+0200 W/AUL     (21616): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21590
04-23 12:36:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21590
04-23 12:36:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21590)
04-23 12:36:41.271+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:49.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:49.011+0200 I/utils   (20587): specific action
04-23 12:36:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:49.011+0200 I/httppostreq(20587): internet available
04-23 12:36:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:49.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:49.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:49.041+0200 I/utils   (20584): specific action
04-23 12:36:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:49.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:49.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21660
04-23 12:36:49.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:49.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21660
04-23 12:36:49.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21660) type(svcapp) bg(0)
04-23 12:36:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21660)
04-23 12:36:49.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:49.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:49.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:49.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:49.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:49.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21660]
04-23 12:36:49.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21663
04-23 12:36:49.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:49.161+0200 E/CAPI_APPFW_APPLICATION(21660): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:49.161+0200 E/CAPI_APPFW_APPLICATION(21660): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:49.161+0200 I/utils   (21660): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:49.171+0200 I/utils   (21660): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:49.181+0200 I/utils   (21660): es.ugr.frailty.accelerometer listener started
04-23 12:36:49.181+0200 I/accelerometer(21660): stopping es.ugr.frailty.accelerometer service
04-23 12:36:49.181+0200 E/CAPI_APPFW_APP_CONTROL(21660): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:49.181+0200 E/accelerometer(21660): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:49.181+0200 I/CAPI_APPFW_APPLICATION(21660): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:49.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21663
04-23 12:36:49.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21663) type(svcapp) bg(0)
04-23 12:36:49.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:49.181+0200 E/CAPI_APPFW_APPLICATION(21663): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:49.181+0200 E/CAPI_APPFW_APPLICATION(21663): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:49.191+0200 I/utils   (21663): specific action
04-23 12:36:49.191+0200 I/recorder(21663): obteniendo datos locales...
04-23 12:36:49.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21660
04-23 12:36:49.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21660) was created
04-23 12:36:49.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21663) was created
04-23 12:36:49.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:49.201+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21663]
04-23 12:36:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21660
04-23 12:36:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:49.211+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21663)
04-23 12:36:49.211+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:49.221+0200 I/recorder(21663): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:49.221+0200 I/recorder(21663): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21663
04-23 12:36:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:49.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21663
04-23 12:36:49.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11216637265631524479809
04-23 12:36:49.311+0200 W/AUL     (21678): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21663
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:49.321+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21663
04-23 12:36:49.321+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21663)
04-23 12:36:49.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:49.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:49.371+0200 I/accelerometer(21660): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:49.501+0200 W/AUL     (21686): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21660
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:49.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21660
04-23 12:36:49.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21660)
04-23 12:36:51.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:59.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:59.011+0200 I/utils   (20587): specific action
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:59.011+0200 I/httppostreq(20587): internet available
04-23 12:36:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:59.041+0200 I/utils   (20584): specific action
04-23 12:36:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21728
04-23 12:36:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21728
04-23 12:36:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21728) type(svcapp) bg(0)
04-23 12:36:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21728)
04-23 12:36:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21728]
04-23 12:36:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21731
04-23 12:36:59.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:59.151+0200 E/CAPI_APPFW_APPLICATION(21728): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.151+0200 E/CAPI_APPFW_APPLICATION(21728): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.161+0200 I/utils   (21728): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:59.161+0200 I/utils   (21728): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:59.171+0200 I/utils   (21728): es.ugr.frailty.accelerometer listener started
04-23 12:36:59.171+0200 I/accelerometer(21728): stopping es.ugr.frailty.accelerometer service
04-23 12:36:59.171+0200 E/CAPI_APPFW_APP_CONTROL(21728): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.171+0200 E/accelerometer(21728): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:59.171+0200 I/CAPI_APPFW_APPLICATION(21728): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:59.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21731
04-23 12:36:59.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21731) type(svcapp) bg(0)
04-23 12:36:59.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.181+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21731)
04-23 12:36:59.181+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:59.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21731]
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21728
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21728) was created
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.201+0200 E/CAPI_APPFW_APPLICATION(21731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.201+0200 E/CAPI_APPFW_APPLICATION(21731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.201+0200 I/utils   (21731): specific action
04-23 12:36:59.201+0200 I/recorder(21731): obteniendo datos locales...
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21728
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21731) was created
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21731
04-23 12:36:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21731
04-23 12:36:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.271+0200 I/recorder(21731): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:59.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:59.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11217317265631524479819
04-23 12:36:59.331+0200 W/AUL     (21746): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21731
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:59.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21731
04-23 12:36:59.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21731)
04-23 12:36:59.351+0200 I/accelerometer(21728): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:59.471+0200 W/AUL     (21754): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21728
04-23 12:36:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:59.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21728
04-23 12:36:59.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21728)
04-23 12:37:01.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:09.001+0200 I/utils   (20587): specific action
04-23 12:37:09.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:09.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:09.011+0200 I/httppostreq(20587): internet available
04-23 12:37:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:09.031+0200 I/utils   (20584): specific action
04-23 12:37:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:09.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:09.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:09.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:09.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:09.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21794
04-23 12:37:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21794
04-23 12:37:09.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21794) type(svcapp) bg(0)
04-23 12:37:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21794)
04-23 12:37:09.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:09.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:09.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.121+0200 E/CAPI_APPFW_APPLICATION(21794): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.121+0200 E/CAPI_APPFW_APPLICATION(21794): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21797
04-23 12:37:09.141+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21794]
04-23 12:37:09.151+0200 I/utils   (21794): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:09.161+0200 I/utils   (21794): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:09.171+0200 I/utils   (21794): es.ugr.frailty.accelerometer listener started
04-23 12:37:09.181+0200 I/accelerometer(21794): stopping es.ugr.frailty.accelerometer service
04-23 12:37:09.181+0200 E/CAPI_APPFW_APP_CONTROL(21794): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.181+0200 E/accelerometer(21794): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:09.181+0200 I/CAPI_APPFW_APPLICATION(21794): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:09.191+0200 E/CAPI_APPFW_APPLICATION(21797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.191+0200 E/CAPI_APPFW_APPLICATION(21797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.191+0200 I/utils   (21797): specific action
04-23 12:37:09.191+0200 I/recorder(21797): obteniendo datos locales...
04-23 12:37:09.211+0200 I/recorder(21797): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:09.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21797
04-23 12:37:09.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21797) type(svcapp) bg(0)
04-23 12:37:09.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21797)
04-23 12:37:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:09.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:09.241+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21794
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21794) was created
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21797) was created
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21794
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:09.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:09.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121797726563152447982
