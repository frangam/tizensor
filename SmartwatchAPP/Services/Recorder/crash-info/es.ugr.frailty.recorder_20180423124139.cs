S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 23497
Date: 2018-04-23 12:41:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75ee648, r1   = 0xf786c1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf786c1b8, r5   = 0x00012cd0
r6   = 0xf787ee88, r7   = 0xf75ee250
r8   = 0x000005d8, r9   = 0xf70d1824
r10  = 0xf78649d8, fp   = 0x00000000
ip   = 0xf75ed030, sp   = 0xffeb4e48
lr   = 0xf75315d0, pc   = 0xf752d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      7756 KB
Buffers:     71192 KB
Cached:     191468 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7720 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6c68000 f6c6b000 r-xp /lib/libattr.so.1.1.0
f6c74000 f6c7b000 r-xp /lib/libcrypt-2.13.so
f6cab000 f6cae000 r-xp /lib/libcap.so.2.21
f6cb6000 f6cb8000 r-xp /usr/lib/libiri.so
f6cc0000 f6cdd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ce6000 f6cea000 r-xp /usr/lib/libsmack.so.1.0.0
f6cf4000 f6cf6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cfe000 f6d03000 r-xp /usr/lib/libffi.so.5.0.10
f6d0b000 f6d0c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d14000 f6d16000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d1e000 f6d20000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d2a000 f6d3a000 r-xp /lib/libresolv-2.13.so
f6d3e000 f6d56000 r-xp /usr/lib/liblzma.so.5.0.3
f6d5e000 f6d60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d68000 f6d97000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6da0000 f6daf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db8000 f6dc2000 r-xp /usr/lib/libsensord-shared.so
f6dcb000 f6dff000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e08000 f6edb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ee6000 f6efc000 r-xp /lib/libz.so.1.2.5
f6f04000 f6f0a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f13000 f6f88000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f92000 f6fac000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6fb4000 f6fba000 r-xp /lib/librt-2.13.so
f6fc3000 f6fe1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6feb000 f6fec000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ff4000 f6ff9000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7001000 f70d1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70d2000 f70fc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7105000 f711c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7124000 f718d000 r-xp /lib/libm-2.13.so
f7196000 f722a000 r-xp /usr/lib/libstdc++.so.6.0.16
f723d000 f7242000 r-xp /usr/lib/libctx-client.so.0.8.3
f724a000 f7251000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7259000 f7283000 r-xp /usr/lib/libsensor.so.1.9.6
f728c000 f7358000 r-xp /usr/lib/libxml2.so.2.7.8
f7365000 f7367000 r-xp /usr/lib/libiniparser.so.0
f7370000 f7373000 r-xp /usr/lib/libbundle.so.0.1.22
f737b000 f7381000 r-xp /usr/lib/libappsvc.so.0.1.0
f7389000 f73ac000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f73b4000 f73f5000 r-xp /usr/lib/libeina.so.1.7.99
f73fe000 f7415000 r-xp /usr/lib/libecore.so.1.7.99
f742c000 f7435000 r-xp /usr/lib/libvconf.so.0.2.45
f743d000 f7451000 r-xp /lib/libpthread-2.13.so
f745c000 f7469000 r-xp /usr/lib/libaul.so.0.1.0
f7473000 f7475000 r-xp /lib/libdl-2.13.so
f747e000 f7489000 r-xp /lib/libunwind.so.8.0.1
f74b6000 f74be000 r-xp /lib/libgcc_s-4.6.so.1
f74bf000 f75e3000 r-xp /lib/libc-2.13.so
f75f1000 f75f3000 r-xp /usr/lib/libdlog.so.0.0.0
f75fb000 f7607000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7610000 f7615000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f761d000 f7621000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f762a000 f762c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7635000 f7638000 r-xp /usr/lib/libappcore-agent.so.1.1
f7656000 f7673000 r-xp /lib/ld-2.13.so
f767c000 f767f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f767f000 f7683000 r-xp /usr/lib/libsys-assert.so
f785a000 f78a8000 rw-p [heap]
ffe97000 ffeb8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23497)
Call Stack Count: 1
 0: (0xf752d9fc) [/lib/libc.so.6] + 0x6e9fc
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
353): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23353
04-23 12:41:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:09.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11233537265631524480069
04-23 12:41:09.321+0200 W/AUL     (23369): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23353
04-23 12:41:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:09.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23353
04-23 12:41:09.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23353)
04-23 12:41:09.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:09.361+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:09.381+0200 I/accelerometer(23350): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:09.501+0200 W/AUL     (23376): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23350
04-23 12:41:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:09.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23350
04-23 12:41:09.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23350)
04-23 12:41:11.201+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:18.981+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:18.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:18.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:19.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:19.011+0200 I/utils   (20587): specific action
04-23 12:41:19.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:19.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:19.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:19.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:19.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:19.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:19.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:19.011+0200 I/httppostreq(20587): internet available
04-23 12:41:19.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:19.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:19.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:19.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:19.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:19.041+0200 I/utils   (20584): specific action
04-23 12:41:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:19.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:19.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:19.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:19.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:19.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:19.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:19.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23414
04-23 12:41:19.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:19.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23414
04-23 12:41:19.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23414) type(svcapp) bg(0)
04-23 12:41:19.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23414]
04-23 12:41:19.131+0200 E/CAPI_APPFW_APPLICATION(23414): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:19.131+0200 E/CAPI_APPFW_APPLICATION(23414): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:19.131+0200 I/utils   (23414): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:19.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23414) was created
04-23 12:41:19.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23414)
04-23 12:41:19.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:19.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:19.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:19.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:19.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:19.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:19.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:19.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:19.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:19.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:19.151+0200 I/utils   (23414): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:19.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23414
04-23 12:41:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:19.161+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:19.161+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:19.161+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:19.161+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:19.161+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:19.161+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:19.161+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:19.161+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:19.161+0200 I/utils   (23414): es.ugr.frailty.accelerometer listener started
04-23 12:41:19.161+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:19.161+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:19.161+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:19.161+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:19.161+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:19.161+0200 I/accelerometer(23414): stopping es.ugr.frailty.accelerometer service
04-23 12:41:19.161+0200 E/CAPI_APPFW_APP_CONTROL(23414): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:19.161+0200 E/accelerometer(23414): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:19.161+0200 I/CAPI_APPFW_APPLICATION(23414): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:19.161+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:19.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:19.181+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23426
04-23 12:41:19.181+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:19.231+0200 E/CAPI_APPFW_APPLICATION(23426): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:19.231+0200 E/CAPI_APPFW_APPLICATION(23426): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:19.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23426
04-23 12:41:19.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23426) type(svcapp) bg(0)
04-23 12:41:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:19.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23426)
04-23 12:41:19.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:19.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23414
04-23 12:41:19.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23426) was created
04-23 12:41:19.241+0200 I/utils   (23426): specific action
04-23 12:41:19.241+0200 I/recorder(23426): obteniendo datos locales...
04-23 12:41:19.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23426]
04-23 12:41:19.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23426
04-23 12:41:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:19.281+0200 I/recorder(23426): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:19.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:19.291+0200 I/recorder(23426): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:19.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:19.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:19.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23426
04-23 12:41:19.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:19.321+0200 I/accelerometer(23414): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:19.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11234267265631524480079
04-23 12:41:19.361+0200 W/AUL     (23433): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23426
04-23 12:41:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:19.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23426
04-23 12:41:19.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23426)
04-23 12:41:19.461+0200 W/AUL     (23440): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:19.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:19.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:19.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23414
04-23 12:41:19.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:19.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23414
04-23 12:41:19.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23414)
04-23 12:41:21.161+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:29.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:29.011+0200 I/utils   (20587): specific action
04-23 12:41:29.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:29.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:29.011+0200 I/httppostreq(20587): internet available
04-23 12:41:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:29.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:29.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:29.041+0200 I/utils   (20584): specific action
04-23 12:41:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:29.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:29.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:29.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:29.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:29.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23453
04-23 12:41:29.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:29.061+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:29.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23453
04-23 12:41:29.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23453) type(svcapp) bg(0)
04-23 12:41:29.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23453)
04-23 12:41:29.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23453]
04-23 12:41:29.121+0200 E/CAPI_APPFW_APPLICATION(23453): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:29.121+0200 E/CAPI_APPFW_APPLICATION(23453): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:29.121+0200 I/utils   (23453): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:29.121+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23453) was created
04-23 12:41:29.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:29.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:29.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:29.131+0200 I/utils   (23453): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:29.141+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:29.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:29.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:29.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:29.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:29.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23453
04-23 12:41:29.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:29.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23453
04-23 12:41:29.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:29.161+0200 I/utils   (23453): es.ugr.frailty.accelerometer listener started
04-23 12:41:29.161+0200 I/accelerometer(23453): stopping es.ugr.frailty.accelerometer service
04-23 12:41:29.161+0200 E/CAPI_APPFW_APP_CONTROL(23453): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:29.161+0200 E/accelerometer(23453): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:29.161+0200 I/CAPI_APPFW_APPLICATION(23453): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:29.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:29.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:29.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:29.171+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:29.171+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:29.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:29.171+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:29.191+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23466
04-23 12:41:29.191+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:29.231+0200 E/CAPI_APPFW_APPLICATION(23466): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:29.231+0200 E/CAPI_APPFW_APPLICATION(23466): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:29.241+0200 I/utils   (23466): specific action
04-23 12:41:29.241+0200 I/recorder(23466): obteniendo datos locales...
04-23 12:41:29.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23466
04-23 12:41:29.241+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23466) type(svcapp) bg(0)
04-23 12:41:29.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23466)
04-23 12:41:29.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23466) was created
04-23 12:41:29.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:29.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23466]
04-23 12:41:29.261+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:29.271+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:29.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23466
04-23 12:41:29.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:29.291+0200 I/accelerometer(23453): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:29.291+0200 I/recorder(23466): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23466
04-23 12:41:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:29.351+0200 W/AUL     (23471): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23466
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:29.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11234667265631524480089
04-23 12:41:29.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23466
04-23 12:41:29.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23466)
04-23 12:41:29.421+0200 W/AUL     (23475): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23453
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:29.421+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23453
04-23 12:41:29.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23453)
04-23 12:41:31.171+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 3
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524480004, curr_wall_time = 1524480094
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 90 seconds
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 93 seconds
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 84, charging remaining time = 25 minutes
04-23 12:41:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:39.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:39.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:39.011+0200 I/utils   (20587): specific action
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:39.011+0200 I/httppostreq(20587): internet available
04-23 12:41:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:39.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:39.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:39.051+0200 I/utils   (20584): specific action
04-23 12:41:39.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:39.051+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:39.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:39.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:39.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23494
04-23 12:41:39.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:39.081+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:39.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23494
04-23 12:41:39.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23494) type(svcapp) bg(0)
04-23 12:41:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23494)
04-23 12:41:39.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:39.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:39.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23494]
04-23 12:41:39.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23497
04-23 12:41:39.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:39.151+0200 E/CAPI_APPFW_APPLICATION(23494): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.151+0200 E/CAPI_APPFW_APPLICATION(23494): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.151+0200 I/utils   (23494): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:39.171+0200 I/utils   (23494): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:39.181+0200 I/utils   (23494): es.ugr.frailty.accelerometer listener started
04-23 12:41:39.181+0200 I/accelerometer(23494): stopping es.ugr.frailty.accelerometer service
04-23 12:41:39.181+0200 E/CAPI_APPFW_APP_CONTROL(23494): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.181+0200 E/accelerometer(23494): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:39.181+0200 I/CAPI_APPFW_APPLICATION(23494): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:39.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23497
04-23 12:41:39.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23497) type(svcapp) bg(0)
04-23 12:41:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23497)
04-23 12:41:39.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:39.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23497]
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23494
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23494) was created
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23494
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.221+0200 E/CAPI_APPFW_APPLICATION(23497): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.221+0200 E/CAPI_APPFW_APPLICATION(23497): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23497) was created
04-23 12:41:39.221+0200 I/utils   (23497): specific action
04-23 12:41:39.221+0200 I/recorder(23497): obteniendo datos locales...
04-23 12:41:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23497
04-23 12:41:39.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.261+0200 I/recorder(23497): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23497
04-23 12:41:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:39.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:39.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1123497726563152448009
