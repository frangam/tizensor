S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21325
Date: 2018-04-23 12:35:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf71da648, r1   = 0xf73451b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf73451b8, r5   = 0x00012cd0
r6   = 0xf7357e88, r7   = 0xf71da250
r8   = 0x000005d8, r9   = 0xf6cbd824
r10  = 0xf733d9d8, fp   = 0x00000000
ip   = 0xf71d9030, sp   = 0xffa64c78
lr   = 0xf711d5d0, pc   = 0xf71199fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11208 KB
Buffers:     70516 KB
Cached:     190128 KB
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
f6854000 f6857000 r-xp /lib/libattr.so.1.1.0
f6860000 f6867000 r-xp /lib/libcrypt-2.13.so
f6897000 f689a000 r-xp /lib/libcap.so.2.21
f68a2000 f68a4000 r-xp /usr/lib/libiri.so
f68ac000 f68c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68d2000 f68d6000 r-xp /usr/lib/libsmack.so.1.0.0
f68e0000 f68e2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68ea000 f68ef000 r-xp /usr/lib/libffi.so.5.0.10
f68f7000 f68f8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6900000 f6902000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f690a000 f690c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6916000 f6926000 r-xp /lib/libresolv-2.13.so
f692a000 f6942000 r-xp /usr/lib/liblzma.so.5.0.3
f694a000 f694c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6954000 f6983000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f698c000 f699b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69a4000 f69ae000 r-xp /usr/lib/libsensord-shared.so
f69b7000 f69eb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f69f4000 f6ac7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ad2000 f6ae8000 r-xp /lib/libz.so.1.2.5
f6af0000 f6af6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6aff000 f6b74000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b7e000 f6b98000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ba0000 f6ba6000 r-xp /lib/librt-2.13.so
f6baf000 f6bcd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bd7000 f6bd8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6be0000 f6be5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bed000 f6cbd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cbe000 f6ce8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cf1000 f6d08000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d10000 f6d79000 r-xp /lib/libm-2.13.so
f6d82000 f6e16000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e29000 f6e2e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e36000 f6e3d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e45000 f6e6f000 r-xp /usr/lib/libsensor.so.1.9.6
f6e78000 f6f44000 r-xp /usr/lib/libxml2.so.2.7.8
f6f51000 f6f53000 r-xp /usr/lib/libiniparser.so.0
f6f5c000 f6f5f000 r-xp /usr/lib/libbundle.so.0.1.22
f6f67000 f6f6d000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f75000 f6f98000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fa0000 f6fe1000 r-xp /usr/lib/libeina.so.1.7.99
f6fea000 f7001000 r-xp /usr/lib/libecore.so.1.7.99
f7018000 f7021000 r-xp /usr/lib/libvconf.so.0.2.45
f7029000 f703d000 r-xp /lib/libpthread-2.13.so
f7048000 f7055000 r-xp /usr/lib/libaul.so.0.1.0
f705f000 f7061000 r-xp /lib/libdl-2.13.so
f706a000 f7075000 r-xp /lib/libunwind.so.8.0.1
f70a2000 f70aa000 r-xp /lib/libgcc_s-4.6.so.1
f70ab000 f71cf000 r-xp /lib/libc-2.13.so
f71dd000 f71df000 r-xp /usr/lib/libdlog.so.0.0.0
f71e7000 f71f3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71fc000 f7201000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7209000 f720d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7216000 f7218000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7221000 f7224000 r-xp /usr/lib/libappcore-agent.so.1.1
f7242000 f725f000 r-xp /lib/ld-2.13.so
f7268000 f726b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f726b000 f726f000 r-xp /usr/lib/libsys-assert.so
f7333000 f7381000 rw-p [heap]
ffa46000 ffa67000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21325)
Call Stack Count: 1
 0: (0xf71199fc) [/lib/libc.so.6] + 0x6e9fc
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
 stopping es.ugr.frailty.accelerometer service
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
04-23 12:35:49.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11212717265631524479749
04-23 12:35:49.361+0200 W/AUL     (21277): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:35:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21271
04-23 12:35:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:49.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21271
04-23 12:35:49.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21271)
04-23 12:35:49.441+0200 W/AUL     (21283): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:35:49.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:49.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:49.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21258
04-23 12:35:49.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:49.441+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21258
04-23 12:35:49.441+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21258)
04-23 12:35:51.241+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:35:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:35:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:35:59.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:35:59.011+0200 I/utils   (20587): specific action
04-23 12:35:59.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:35:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:35:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:35:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:35:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:35:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:35:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:35:59.011+0200 I/httppostreq(20587): internet available
04-23 12:35:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:35:59.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:59.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:35:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:35:59.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:35:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:59.041+0200 I/utils   (20584): specific action
04-23 12:35:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:35:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:35:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:35:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:35:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21322
04-23 12:35:59.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21322
04-23 12:35:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21322) type(svcapp) bg(0)
04-23 12:35:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21322)
04-23 12:35:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:35:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:35:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:35:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21322]
04-23 12:35:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21325
04-23 12:35:59.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:59.151+0200 E/CAPI_APPFW_APPLICATION(21322): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:59.151+0200 E/CAPI_APPFW_APPLICATION(21322): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:59.151+0200 I/utils   (21322): trying to start service: es.ugr.frailty.accelerometer
04-23 12:35:59.151+0200 I/utils   (21322): es.ugr.frailty.accelerometer sensor supported
04-23 12:35:59.161+0200 I/utils   (21322): es.ugr.frailty.accelerometer listener started
04-23 12:35:59.161+0200 I/accelerometer(21322): stopping es.ugr.frailty.accelerometer service
04-23 12:35:59.161+0200 E/CAPI_APPFW_APP_CONTROL(21322): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:35:59.161+0200 E/accelerometer(21322): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:35:59.161+0200 I/CAPI_APPFW_APPLICATION(21322): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:35:59.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21325
04-23 12:35:59.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21325) type(svcapp) bg(0)
04-23 12:35:59.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21322
04-23 12:35:59.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21322) was created
04-23 12:35:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:35:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:35:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:59.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21325]
04-23 12:35:59.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21325)
04-23 12:35:59.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:35:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21322
04-23 12:35:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21325
04-23 12:35:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:59.241+0200 E/CAPI_APPFW_APPLICATION(21325): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:59.241+0200 E/CAPI_APPFW_APPLICATION(21325): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:59.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21325) was created
04-23 12:35:59.251+0200 I/utils   (21325): specific action
04-23 12:35:59.251+0200 I/recorder(21325): obteniendo datos locales...
04-23 12:35:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21325
04-23 12:35:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:59.291+0200 I/recorder(21325): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:59.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:59.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:59.321+0200 I/accelerometer(21322): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:59.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121325726563152447975
