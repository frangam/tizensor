S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22844
Date: 2018-04-23 12:39:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf766e648, r1   = 0xf7cb31b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cb31b8, r5   = 0x00012cd0
r6   = 0xf7cc5e88, r7   = 0xf766e250
r8   = 0x000005d8, r9   = 0xf7151824
r10  = 0xf7cab9d8, fp   = 0x00000000
ip   = 0xf766d030, sp   = 0xffe83b88
lr   = 0xf75b15d0, pc   = 0xf75ad9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      7976 KB
Buffers:     70968 KB
Cached:     191248 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7704 KB
VmRSS:        7700 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6ce8000 f6ceb000 r-xp /lib/libattr.so.1.1.0
f6cf4000 f6cfb000 r-xp /lib/libcrypt-2.13.so
f6d2b000 f6d2e000 r-xp /lib/libcap.so.2.21
f6d36000 f6d38000 r-xp /usr/lib/libiri.so
f6d40000 f6d5d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d66000 f6d6a000 r-xp /usr/lib/libsmack.so.1.0.0
f6d74000 f6d76000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d7e000 f6d83000 r-xp /usr/lib/libffi.so.5.0.10
f6d8b000 f6d8c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d94000 f6d96000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d9e000 f6da0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6daa000 f6dba000 r-xp /lib/libresolv-2.13.so
f6dbe000 f6dd6000 r-xp /usr/lib/liblzma.so.5.0.3
f6dde000 f6de0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6de8000 f6e17000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e20000 f6e2f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e38000 f6e42000 r-xp /usr/lib/libsensord-shared.so
f6e4b000 f6e7f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e88000 f6f5b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f66000 f6f7c000 r-xp /lib/libz.so.1.2.5
f6f84000 f6f8a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f93000 f7008000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7012000 f702c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f7034000 f703a000 r-xp /lib/librt-2.13.so
f7043000 f7061000 r-xp /usr/lib/libsystemd.so.0.4.0
f706b000 f706c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7074000 f7079000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7081000 f7151000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7152000 f717c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7185000 f719c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f71a4000 f720d000 r-xp /lib/libm-2.13.so
f7216000 f72aa000 r-xp /usr/lib/libstdc++.so.6.0.16
f72bd000 f72c2000 r-xp /usr/lib/libctx-client.so.0.8.3
f72ca000 f72d1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f72d9000 f7303000 r-xp /usr/lib/libsensor.so.1.9.6
f730c000 f73d8000 r-xp /usr/lib/libxml2.so.2.7.8
f73e5000 f73e7000 r-xp /usr/lib/libiniparser.so.0
f73f0000 f73f3000 r-xp /usr/lib/libbundle.so.0.1.22
f73fb000 f7401000 r-xp /usr/lib/libappsvc.so.0.1.0
f7409000 f742c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7434000 f7475000 r-xp /usr/lib/libeina.so.1.7.99
f747e000 f7495000 r-xp /usr/lib/libecore.so.1.7.99
f74ac000 f74b5000 r-xp /usr/lib/libvconf.so.0.2.45
f74bd000 f74d1000 r-xp /lib/libpthread-2.13.so
f74dc000 f74e9000 r-xp /usr/lib/libaul.so.0.1.0
f74f3000 f74f5000 r-xp /lib/libdl-2.13.so
f74fe000 f7509000 r-xp /lib/libunwind.so.8.0.1
f7536000 f753e000 r-xp /lib/libgcc_s-4.6.so.1
f753f000 f7663000 r-xp /lib/libc-2.13.so
f7671000 f7673000 r-xp /usr/lib/libdlog.so.0.0.0
f767b000 f7687000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7690000 f7695000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f769d000 f76a1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76aa000 f76ac000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f76b5000 f76b8000 r-xp /usr/lib/libappcore-agent.so.1.1
f76d6000 f76f3000 r-xp /lib/ld-2.13.so
f76fc000 f76ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f76ff000 f7703000 r-xp /usr/lib/libsys-assert.so
f7ca1000 f7cef000 rw-p [heap]
ffe65000 ffe86000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22844)
Call Stack Count: 1
 0: (0xf75ad9fc) [/lib/libc.so.6] + 0x6e9fc
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
,9.812965,0.763310
04-23 12:39:19.241+0200 I/recorder(22641): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:19.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22641]
04-23 12:39:19.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22641
04-23 12:39:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:19.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22641
04-23 12:39:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:19.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:19.311+0200 I/accelerometer(22638): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:19.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11226417265631524479959
04-23 12:39:19.351+0200 W/AUL     (22657): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:19.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:19.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:19.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22641
04-23 12:39:19.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:19.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22641
04-23 12:39:19.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22641)
04-23 12:39:19.431+0200 W/AUL     (22664): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:19.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:19.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:19.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22638
04-23 12:39:19.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:19.451+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22638
04-23 12:39:19.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22638)
04-23 12:39:21.181+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:39:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:39:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:39:29.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:39:29.011+0200 I/utils   (20587): specific action
04-23 12:39:29.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:39:29.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:39:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:39:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:39:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:39:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:39:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:39:29.011+0200 I/httppostreq(20587): internet available
04-23 12:39:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:39:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:39:29.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:39:29.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:29.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:39:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:29.041+0200 I/utils   (20584): specific action
04-23 12:39:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:29.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:39:29.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:39:29.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:39:29.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:39:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:29.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:29.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22702
04-23 12:39:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22702
04-23 12:39:29.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22702) type(svcapp) bg(0)
04-23 12:39:29.121+0200 E/CAPI_APPFW_APPLICATION(22702): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:29.121+0200 E/CAPI_APPFW_APPLICATION(22702): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:29.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22702) was created
04-23 12:39:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22702)
04-23 12:39:29.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:39:29.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:29.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:29.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:29.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:39:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:39:29.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:29.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22702]
04-23 12:39:29.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:29.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22705
04-23 12:39:29.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:29.151+0200 I/utils   (22702): trying to start service: es.ugr.frailty.accelerometer
04-23 12:39:29.161+0200 I/utils   (22702): es.ugr.frailty.accelerometer sensor supported
04-23 12:39:29.171+0200 I/utils   (22702): es.ugr.frailty.accelerometer listener started
04-23 12:39:29.171+0200 I/accelerometer(22702): stopping es.ugr.frailty.accelerometer service
04-23 12:39:29.171+0200 E/CAPI_APPFW_APP_CONTROL(22702): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:39:29.171+0200 E/accelerometer(22702): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:39:29.181+0200 I/CAPI_APPFW_APPLICATION(22702): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:39:29.191+0200 E/CAPI_APPFW_APPLICATION(22705): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:29.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22705
04-23 12:39:29.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22705) type(svcapp) bg(0)
04-23 12:39:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:29.211+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22705)
04-23 12:39:29.211+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:39:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22702
04-23 12:39:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22702
04-23 12:39:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:39:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:39:29.221+0200 E/CAPI_APPFW_APPLICATION(22705): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:29.221+0200 I/utils   (22705): specific action
04-23 12:39:29.221+0200 I/recorder(22705): obteniendo datos locales...
04-23 12:39:29.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22705) was created
04-23 12:39:29.241+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22705]
04-23 12:39:29.241+0200 I/recorder(22705): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:39:29.241+0200 I/recorder(22705): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22705
04-23 12:39:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:29.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11227057265631524479969
04-23 12:39:29.321+0200 E/AUL     ( 2478): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 12:39:29.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:29.331+0200 W/AUL     (22720): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:29.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22705
04-23 12:39:29.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:29.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22705
04-23 12:39:29.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22705)
04-23 12:39:29.341+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:39:29.341+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:39:29.341+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(22705), proc(0)
04-23 12:39:29.341+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:39:29.341+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:39:29.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:39:29.351+0200 I/accelerometer(22702): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:29.491+0200 W/AUL     (22728): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22702
04-23 12:39:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:29.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22702
04-23 12:39:29.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22702)
04-23 12:39:31.221+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:39:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:39:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:39:39.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:39:39.001+0200 I/utils   (20587): specific action
04-23 12:39:39.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:39:39.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:39:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:39:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:39:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:39:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:39:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:39:39.011+0200 I/httppostreq(20587): internet available
04-23 12:39:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:39:39.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:39.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:39:39.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:39:39.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:39.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:39:39.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:39.031+0200 I/utils   (20584): specific action
04-23 12:39:39.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:39.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:39:39.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:39:39.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:39:39.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:39:39.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:39.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22768
04-23 12:39:39.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:39.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22768
04-23 12:39:39.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22768) type(svcapp) bg(0)
04-23 12:39:39.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22768]
04-23 12:39:39.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22768)
04-23 12:39:39.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:39:39.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:39.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:39.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:39.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:39.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:39.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:39.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:39.141+0200 E/servicemanager(20584): deleting timer 1
04-23 12:39:39.151+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:39.151+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:39.151+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:39.151+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:39.151+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:39.151+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:39.151+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:39.151+0200 E/servicemanager(20584): deleting timer 2
04-23 12:39:39.151+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:39:39.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22768
04-23 12:39:39.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:39.161+0200 E/CAPI_APPFW_APPLICATION(22768): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:39.161+0200 E/CAPI_APPFW_APPLICATION(22768): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:39.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22768
04-23 12:39:39.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:39.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:39.171+0200 I/utils   (22768): trying to start service: es.ugr.frailty.accelerometer
04-23 12:39:39.171+0200 I/utils   (22768): es.ugr.frailty.accelerometer sensor supported
04-23 12:39:39.181+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22779
04-23 12:39:39.191+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:39.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22779
04-23 12:39:39.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22779) type(svcapp) bg(0)
04-23 12:39:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:39.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22768) was created
04-23 12:39:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:39.251+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22779)
04-23 12:39:39.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22779]
04-23 12:39:39.251+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:39:39.251+0200 I/utils   (22768): es.ugr.frailty.accelerometer listener started
04-23 12:39:39.251+0200 I/accelerometer(22768): stopping es.ugr.frailty.accelerometer service
04-23 12:39:39.251+0200 E/CAPI_APPFW_APP_CONTROL(22768): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:39:39.251+0200 E/accelerometer(22768): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:39:39.251+0200 I/CAPI_APPFW_APPLICATION(22768): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:39:39.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:39:39.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:39:39.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22779
04-23 12:39:39.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:39.281+0200 E/CAPI_APPFW_APPLICATION(22779): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:39.281+0200 E/CAPI_APPFW_APPLICATION(22779): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:39.281+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22779) was created
04-23 12:39:39.281+0200 I/utils   (22779): specific action
04-23 12:39:39.281+0200 I/recorder(22779): obteniendo datos locales...
04-23 12:39:39.301+0200 I/recorder(22779): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:39:39.301+0200 I/recorder(22779): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:39.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22779
04-23 12:39:39.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:39.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:39.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:39.361+0200 I/accelerometer(22768): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:39.381+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11227797265631524479979
04-23 12:39:39.391+0200 W/AUL     (22787): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22779
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:39.401+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22779
04-23 12:39:39.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22779)
04-23 12:39:39.481+0200 W/AUL     (22794): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22768
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22768
04-23 12:39:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22768)
04-23 12:39:41.261+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:39:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:39:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:39:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:39:49.011+0200 I/utils   (20587): specific action
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:39:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:39:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:39:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:39:49.011+0200 I/httppostreq(20587): internet available
04-23 12:39:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:39:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:39:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:39:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:39:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:49.041+0200 I/utils   (20584): specific action
04-23 12:39:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:39:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:39:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:39:49.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:39:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:49.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22832
04-23 12:39:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22832
04-23 12:39:49.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22832) type(svcapp) bg(0)
04-23 12:39:49.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22832]
04-23 12:39:49.131+0200 E/CAPI_APPFW_APPLICATION(22832): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.131+0200 E/CAPI_APPFW_APPLICATION(22832): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.131+0200 I/utils   (22832): trying to start service: es.ugr.frailty.accelerometer
04-23 12:39:49.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22832) was created
04-23 12:39:49.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22832)
04-23 12:39:49.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:39:49.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:39:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.141+0200 I/utils   (22832): es.ugr.frailty.accelerometer sensor supported
04-23 12:39:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22832
04-23 12:39:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.151+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.151+0200 I/utils   (22832): es.ugr.frailty.accelerometer listener started
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.151+0200 E/servicemanager(20584): deleting timer 1
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.151+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.151+0200 I/accelerometer(22832): stopping es.ugr.frailty.accelerometer service
04-23 12:39:49.151+0200 E/CAPI_APPFW_APP_CONTROL(22832): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.151+0200 E/accelerometer(22832): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:39:49.151+0200 I/CAPI_APPFW_APPLICATION(22832): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:39:49.161+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.161+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.161+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.161+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.161+0200 E/servicemanager(20584): deleting timer 2
04-23 12:39:49.161+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22844
04-23 12:39:49.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:49.221+0200 E/CAPI_APPFW_APPLICATION(22844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.221+0200 E/CAPI_APPFW_APPLICATION(22844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.221+0200 I/utils   (22844): specific action
04-23 12:39:49.221+0200 I/recorder(22844): obteniendo datos locales...
04-23 12:39:49.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22844
04-23 12:39:49.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22844) type(svcapp) bg(0)
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22832
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22844) was created
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22844)
04-23 12:39:49.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:39:49.241+0200 I/recorder(22844): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:49.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22844]
04-23 12:39:49.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22844
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22844
04-23 12:39:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:49.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122844726563152447998
