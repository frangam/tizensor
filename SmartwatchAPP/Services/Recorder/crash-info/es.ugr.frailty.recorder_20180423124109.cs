S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 23353
Date: 2018-04-23 12:41:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75ee648, r1   = 0xf7bb01b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7bb01b8, r5   = 0x00012cd0
r6   = 0xf7bc2e88, r7   = 0xf75ee250
r8   = 0x000005d8, r9   = 0xf70d1824
r10  = 0xf7ba89d8, fp   = 0x00000000
ip   = 0xf75ed030, sp   = 0xffa6a768
lr   = 0xf75315d0, pc   = 0xf752d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8252 KB
Buffers:     71136 KB
Cached:     191372 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7712 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
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
f7b9e000 f7bec000 rw-p [heap]
ffa4c000 ffa6d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23353)
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
178,9.836893,0.780060
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23156
04-23 12:40:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:39.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23161
04-23 12:40:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11231617265631524480039
04-23 12:40:39.361+0200 I/accelerometer(23156): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:39.361+0200 W/AUL     (23176): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23161
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:39.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23161
04-23 12:40:39.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23161)
04-23 12:40:39.481+0200 W/AUL     (23182): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23156
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23156
04-23 12:40:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23156)
04-23 12:40:41.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:49.001+0200 I/utils   (20587): specific action
04-23 12:40:49.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:49.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:49.001+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:49.011+0200 I/httppostreq(20587): internet available
04-23 12:40:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:49.031+0200 I/utils   (20584): specific action
04-23 12:40:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:49.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:49.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:49.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:49.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23220
04-23 12:40:49.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:49.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23220
04-23 12:40:49.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23220) type(svcapp) bg(0)
04-23 12:40:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23220)
04-23 12:40:49.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:49.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:49.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23220]
04-23 12:40:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23223
04-23 12:40:49.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:49.151+0200 E/CAPI_APPFW_APPLICATION(23220): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.151+0200 E/CAPI_APPFW_APPLICATION(23220): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.161+0200 I/utils   (23220): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:49.161+0200 I/utils   (23220): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:49.181+0200 E/CAPI_APPFW_APPLICATION(23223): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.181+0200 E/CAPI_APPFW_APPLICATION(23223): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.181+0200 I/utils   (23223): specific action
04-23 12:40:49.181+0200 I/recorder(23223): obteniendo datos locales...
04-23 12:40:49.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23223
04-23 12:40:49.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23223) type(svcapp) bg(0)
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.201+0200 I/utils   (23220): es.ugr.frailty.accelerometer listener started
04-23 12:40:49.201+0200 I/accelerometer(23220): stopping es.ugr.frailty.accelerometer service
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23220
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23220) was created
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23223) was created
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23220
04-23 12:40:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.221+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23223]
04-23 12:40:49.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23223)
04-23 12:40:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:49.231+0200 E/CAPI_APPFW_APP_CONTROL(23220): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.231+0200 E/accelerometer(23220): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:49.231+0200 I/CAPI_APPFW_APPLICATION(23220): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23223
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.241+0200 I/recorder(23223): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11232237265631524480049
04-23 12:40:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:49.321+0200 W/AUL     (23239): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23223
04-23 12:40:49.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:49.331+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23223
04-23 12:40:49.331+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23223)
04-23 12:40:49.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:49.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:40:49.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:40:49.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:40:49.351+0200 I/accelerometer(23220): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:49.511+0200 W/AUL     (23246): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23220
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:49.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23220
04-23 12:40:49.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23220)
04-23 12:40:51.241+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:59.001+0200 I/utils   (20587): specific action
04-23 12:40:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:59.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:59.011+0200 I/httppostreq(20587): internet available
04-23 12:40:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:59.031+0200 I/utils   (20584): specific action
04-23 12:40:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:59.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:59.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:59.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:59.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23284
04-23 12:40:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:59.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23284
04-23 12:40:59.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23284) type(svcapp) bg(0)
04-23 12:40:59.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23284]
04-23 12:40:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23284)
04-23 12:40:59.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:59.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23286
04-23 12:40:59.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:59.181+0200 E/CAPI_APPFW_APPLICATION(23284): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.181+0200 E/CAPI_APPFW_APPLICATION(23284): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.181+0200 I/utils   (23284): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:59.191+0200 I/utils   (23284): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:59.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23286
04-23 12:40:59.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23286) type(svcapp) bg(0)
04-23 12:40:59.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23286)
04-23 12:40:59.201+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23286]
04-23 12:40:59.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.221+0200 I/utils   (23284): es.ugr.frailty.accelerometer listener started
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23284
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23284) was created
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.221+0200 I/accelerometer(23284): stopping es.ugr.frailty.accelerometer service
04-23 12:40:59.221+0200 E/CAPI_APPFW_APP_CONTROL(23284): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.221+0200 E/accelerometer(23284): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:59.221+0200 I/CAPI_APPFW_APPLICATION(23284): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23286
04-23 12:40:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.251+0200 E/CAPI_APPFW_APPLICATION(23286): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.251+0200 E/CAPI_APPFW_APPLICATION(23286): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.251+0200 I/utils   (23286): specific action
04-23 12:40:59.251+0200 I/recorder(23286): obteniendo datos locales...
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23284
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23286) was created
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.291+0200 I/recorder(23286): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23286
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:59.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11232867265631524480059
04-23 12:40:59.371+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:59.391+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:59.391+0200 W/AUL     (23303): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23286
04-23 12:40:59.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:59.391+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23286
04-23 12:40:59.391+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23286)
04-23 12:40:59.401+0200 I/accelerometer(23284): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:59.521+0200 W/AUL     (23310): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23284
04-23 12:40:59.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:59.541+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23284
04-23 12:40:59.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23284)
04-23 12:41:01.231+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:08.981+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:08.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:08.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:09.001+0200 I/utils   (20587): specific action
04-23 12:41:09.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:09.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:09.001+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:09.001+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:09.001+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:09.001+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:09.001+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:09.001+0200 I/httppostreq(20587): internet available
04-23 12:41:09.001+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:09.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:09.031+0200 I/utils   (20584): specific action
04-23 12:41:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:09.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:09.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:09.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:09.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:09.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23350
04-23 12:41:09.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:09.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23350
04-23 12:41:09.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23350) type(svcapp) bg(0)
04-23 12:41:09.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23350)
04-23 12:41:09.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:09.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:09.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:09.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:09.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:09.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:09.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:09.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:09.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:09.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:09.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:09.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:09.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23350]
04-23 12:41:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:09.121+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23353
04-23 12:41:09.121+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:09.161+0200 E/CAPI_APPFW_APPLICATION(23350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:09.161+0200 E/CAPI_APPFW_APPLICATION(23350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:09.161+0200 I/utils   (23350): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:09.161+0200 I/utils   (23350): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:09.171+0200 E/CAPI_APPFW_APPLICATION(23353): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:09.171+0200 E/CAPI_APPFW_APPLICATION(23353): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:09.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23353
04-23 12:41:09.171+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23353) type(svcapp) bg(0)
04-23 12:41:09.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:09.181+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23353)
04-23 12:41:09.181+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:09.181+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23353]
04-23 12:41:09.181+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23350
04-23 12:41:09.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23350) was created
04-23 12:41:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:09.191+0200 I/utils   (23350): es.ugr.frailty.accelerometer listener started
04-23 12:41:09.191+0200 I/accelerometer(23350): stopping es.ugr.frailty.accelerometer service
04-23 12:41:09.191+0200 E/CAPI_APPFW_APP_CONTROL(23350): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:09.191+0200 E/accelerometer(23350): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:09.191+0200 I/CAPI_APPFW_APPLICATION(23350): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23350
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:09.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23353) was created
04-23 12:41:09.201+0200 I/utils   (23353): specific action
04-23 12:41:09.201+0200 I/recorder(23353): obteniendo datos locales...
04-23 12:41:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23353
04-23 12:41:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:09.231+0200 I/recorder(23353): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:09.231+0200 I/recorder(23353): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23353
04-23 12:41:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:09.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1123353726563152448006
