S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22119
Date: 2018-04-23 12:37:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7338648, r1   = 0xf7a061b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7a061b8, r5   = 0x00012cd0
r6   = 0xf7a18e88, r7   = 0xf7338250
r8   = 0x000005d8, r9   = 0xf6e1b824
r10  = 0xf79fe9d8, fp   = 0x00000000
ip   = 0xf7337030, sp   = 0xff98d558
lr   = 0xf727b5d0, pc   = 0xf72779fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8936 KB
Buffers:     70720 KB
Cached:     190768 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7764 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f69b2000 f69b5000 r-xp /lib/libattr.so.1.1.0
f69be000 f69c5000 r-xp /lib/libcrypt-2.13.so
f69f5000 f69f8000 r-xp /lib/libcap.so.2.21
f6a00000 f6a02000 r-xp /usr/lib/libiri.so
f6a0a000 f6a27000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a30000 f6a34000 r-xp /usr/lib/libsmack.so.1.0.0
f6a3e000 f6a40000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a48000 f6a4d000 r-xp /usr/lib/libffi.so.5.0.10
f6a55000 f6a56000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a5e000 f6a60000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a68000 f6a6a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a74000 f6a84000 r-xp /lib/libresolv-2.13.so
f6a88000 f6aa0000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa8000 f6aaa000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ab2000 f6ae1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aea000 f6af9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b02000 f6b0c000 r-xp /usr/lib/libsensord-shared.so
f6b15000 f6b49000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b52000 f6c25000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c30000 f6c46000 r-xp /lib/libz.so.1.2.5
f6c4e000 f6c54000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c5d000 f6cd2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cdc000 f6cf6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cfe000 f6d04000 r-xp /lib/librt-2.13.so
f6d0d000 f6d2b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d35000 f6d36000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3e000 f6d43000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d4b000 f6e1b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e1c000 f6e46000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e4f000 f6e66000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e6e000 f6ed7000 r-xp /lib/libm-2.13.so
f6ee0000 f6f74000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f87000 f6f8c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f94000 f6f9b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fa3000 f6fcd000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd6000 f70a2000 r-xp /usr/lib/libxml2.so.2.7.8
f70af000 f70b1000 r-xp /usr/lib/libiniparser.so.0
f70ba000 f70bd000 r-xp /usr/lib/libbundle.so.0.1.22
f70c5000 f70cb000 r-xp /usr/lib/libappsvc.so.0.1.0
f70d3000 f70f6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70fe000 f713f000 r-xp /usr/lib/libeina.so.1.7.99
f7148000 f715f000 r-xp /usr/lib/libecore.so.1.7.99
f7176000 f717f000 r-xp /usr/lib/libvconf.so.0.2.45
f7187000 f719b000 r-xp /lib/libpthread-2.13.so
f71a6000 f71b3000 r-xp /usr/lib/libaul.so.0.1.0
f71bd000 f71bf000 r-xp /lib/libdl-2.13.so
f71c8000 f71d3000 r-xp /lib/libunwind.so.8.0.1
f7200000 f7208000 r-xp /lib/libgcc_s-4.6.so.1
f7209000 f732d000 r-xp /lib/libc-2.13.so
f733b000 f733d000 r-xp /usr/lib/libdlog.so.0.0.0
f7345000 f7351000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f735a000 f735f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7367000 f736b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7374000 f7376000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f737f000 f7382000 r-xp /usr/lib/libappcore-agent.so.1.1
f73a0000 f73bd000 r-xp /lib/ld-2.13.so
f73c6000 f73c9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73c9000 f73cd000 r-xp /usr/lib/libsys-assert.so
f79f4000 f7a42000 rw-p [heap]
ff96f000 ff990000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22119)
Call Stack Count: 1
 0: (0xf72779fc) [/lib/libc.so.6] + 0x6e9fc
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
/2018,12:34:46:137,-0.014357,9.812965,0.763310
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
04-23 12:37:49.361+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11220617265631524479869
04-23 12:37:49.361+0200 I/accelerometer(22052): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:49.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:49.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:37:49.381+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:37:49.381+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:37:49.381+0200 W/AUL     (22072): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22061
04-23 12:37:49.381+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:49.391+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22061
04-23 12:37:49.391+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22061)
04-23 12:37:49.481+0200 W/AUL     (22078): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22052
04-23 12:37:49.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:49.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22052
04-23 12:37:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22052)
04-23 12:37:51.261+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:59.001+0200 I/utils   (20587): specific action
04-23 12:37:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:59.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:59.011+0200 I/httppostreq(20587): internet available
04-23 12:37:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:59.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:59.041+0200 I/utils   (20584): specific action
04-23 12:37:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:59.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:59.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:59.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22116
04-23 12:37:59.071+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22116
04-23 12:37:59.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22116) type(svcapp) bg(0)
04-23 12:37:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22116)
04-23 12:37:59.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:59.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:59.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:59.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:59.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:59.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22116]
04-23 12:37:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22119
04-23 12:37:59.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:59.161+0200 E/CAPI_APPFW_APPLICATION(22116): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:59.161+0200 E/CAPI_APPFW_APPLICATION(22116): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:59.161+0200 I/utils   (22116): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:59.161+0200 I/utils   (22116): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:59.181+0200 I/utils   (22116): es.ugr.frailty.accelerometer listener started
04-23 12:37:59.181+0200 I/accelerometer(22116): stopping es.ugr.frailty.accelerometer service
04-23 12:37:59.181+0200 E/CAPI_APPFW_APP_CONTROL(22116): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:59.181+0200 E/accelerometer(22116): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:59.181+0200 I/CAPI_APPFW_APPLICATION(22116): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:59.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22119
04-23 12:37:59.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22119) type(svcapp) bg(0)
04-23 12:37:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:59.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22119]
04-23 12:37:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22116
04-23 12:37:59.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22116) was created
04-23 12:37:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:59.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22119)
04-23 12:37:59.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22116
04-23 12:37:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22119
04-23 12:37:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:59.241+0200 E/CAPI_APPFW_APPLICATION(22119): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:59.241+0200 E/CAPI_APPFW_APPLICATION(22119): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:59.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22119) was created
04-23 12:37:59.251+0200 I/utils   (22119): specific action
04-23 12:37:59.251+0200 I/recorder(22119): obteniendo datos locales...
04-23 12:37:59.261+0200 I/recorder(22119): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22119
04-23 12:37:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:59.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:59.331+0200 I/accelerometer(22116): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:59.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122119726563152447987
