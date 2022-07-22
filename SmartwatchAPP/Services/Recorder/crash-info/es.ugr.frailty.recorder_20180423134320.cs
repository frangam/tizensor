S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 16947
Date: 2018-04-23 13:43:20+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf738c648, r1   = 0xf75fe1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf75fe1b8, r5   = 0x00012cd0
r6   = 0xf7610e88, r7   = 0xf738c250
r8   = 0x00000618, r9   = 0xf6e6f824
r10  = 0xf75f69d8, fp   = 0x00000000
ip   = 0xf738b030, sp   = 0xff93ef10
lr   = 0xf72cf5d0, pc   = 0xf72cb9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:    102260 KB
Buffers:     28968 KB
Cached:     148236 KB
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
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6a06000 f6a09000 r-xp /lib/libattr.so.1.1.0
f6a12000 f6a19000 r-xp /lib/libcrypt-2.13.so
f6a49000 f6a4c000 r-xp /lib/libcap.so.2.21
f6a54000 f6a56000 r-xp /usr/lib/libiri.so
f6a5e000 f6a7b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a84000 f6a88000 r-xp /usr/lib/libsmack.so.1.0.0
f6a92000 f6a94000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a9c000 f6aa1000 r-xp /usr/lib/libffi.so.5.0.10
f6aa9000 f6aaa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ab2000 f6ab4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6abc000 f6abe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ac8000 f6ad8000 r-xp /lib/libresolv-2.13.so
f6adc000 f6af4000 r-xp /usr/lib/liblzma.so.5.0.3
f6afc000 f6afe000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b06000 f6b35000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b3e000 f6b4d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b56000 f6b60000 r-xp /usr/lib/libsensord-shared.so
f6b69000 f6b9d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ba6000 f6c79000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c84000 f6c9a000 r-xp /lib/libz.so.1.2.5
f6ca2000 f6ca8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cb1000 f6d26000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d30000 f6d4a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d52000 f6d58000 r-xp /lib/librt-2.13.so
f6d61000 f6d7f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d89000 f6d8a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d92000 f6d97000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d9f000 f6e6f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e70000 f6e9a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea3000 f6eba000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec2000 f6f2b000 r-xp /lib/libm-2.13.so
f6f34000 f6fc8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdb000 f6fe0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fe8000 f6fef000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ff7000 f7021000 r-xp /usr/lib/libsensor.so.1.9.6
f702a000 f70f6000 r-xp /usr/lib/libxml2.so.2.7.8
f7103000 f7105000 r-xp /usr/lib/libiniparser.so.0
f710e000 f7111000 r-xp /usr/lib/libbundle.so.0.1.22
f7119000 f711f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7127000 f714a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7152000 f7193000 r-xp /usr/lib/libeina.so.1.7.99
f719c000 f71b3000 r-xp /usr/lib/libecore.so.1.7.99
f71ca000 f71d3000 r-xp /usr/lib/libvconf.so.0.2.45
f71db000 f71ef000 r-xp /lib/libpthread-2.13.so
f71fa000 f7207000 r-xp /usr/lib/libaul.so.0.1.0
f7211000 f7213000 r-xp /lib/libdl-2.13.so
f721c000 f7227000 r-xp /lib/libunwind.so.8.0.1
f7254000 f725c000 r-xp /lib/libgcc_s-4.6.so.1
f725d000 f7381000 r-xp /lib/libc-2.13.so
f738f000 f7391000 r-xp /usr/lib/libdlog.so.0.0.0
f7399000 f73a5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73ae000 f73b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73bb000 f73bf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73c8000 f73ca000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f73d3000 f73d6000 r-xp /usr/lib/libappcore-agent.so.1.1
f73f4000 f7411000 r-xp /lib/ld-2.13.so
f741a000 f741d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f741d000 f7421000 r-xp /usr/lib/libsys-assert.so
f75ec000 f763a000 rw-p [heap]
ff921000 ff942000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16947)
Call Stack Count: 1
 0: (0xf72cb9fc) [/lib/libc.so.6] + 0x6e9fc
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
process(606) > child process: 16863
04-23 13:42:59.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:42:59.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:42:59.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16863
04-23 13:42:59.791+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(16863) type(svcapp) bg(0)
04-23 13:42:59.791+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16863)
04-23 13:42:59.791+0200 I/servicemanager(16526): es.ugr.frailty.accelerometer stop request sent!
04-23 13:42:59.791+0200 I/servicemanager(16526): App control destroyed.
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:42:59.791+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 0
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:42:59.791+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 1
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 2
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:42:59.791+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:42:59.791+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:42:59.791+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:42:59.791+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:42:59.791+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(16526), cmd(0)
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 3
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 4
04-23 13:42:59.791+0200 I/servicemanager(16526): deleting timer 5
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:42:59.801+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:42:59.801+0200 I/servicemanager(16526): deleting timer 6
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:42:59.801+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:42:59.801+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:42:59.801+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:42:59.801+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16863]
04-23 13:42:59.811+0200 I/servicemanager(16526): deleting timer 7
04-23 13:42:59.811+0200 E/EFL     (16526): <16526> ecore_timer.c:559 _ecore_timer_del() safety check failed: timer->delete_me is true
04-23 13:42:59.821+0200 I/servicemanager(16526): deleting timer 8
04-23 13:42:59.821+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:42:59.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:42:59.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16863
04-23 13:42:59.861+0200 E/CAPI_APPFW_APPLICATION(16863): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:42:59.861+0200 E/CAPI_APPFW_APPLICATION(16863): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:42:59.861+0200 I/utils   (16863): trying to start service: es.ugr.frailty.accelerometer
04-23 13:42:59.861+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16863) was created
04-23 13:42:59.861+0200 I/utils   (16863): es.ugr.frailty.accelerometer sensor supported
04-23 13:42:59.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:42:59.881+0200 I/utils   (16863): es.ugr.frailty.accelerometer listener started
04-23 13:42:59.881+0200 I/accelerometer(16863): stopping es.ugr.frailty.accelerometer service
04-23 13:42:59.881+0200 E/CAPI_APPFW_APP_CONTROL(16863): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:42:59.881+0200 E/accelerometer(16863): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:42:59.881+0200 I/CAPI_APPFW_APPLICATION(16863): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:42:59.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:42:59.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:42:59.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:42:59.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:42:59.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16532
04-23 13:42:59.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:42:59.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16863
04-23 13:42:59.961+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16532)
04-23 13:42:59.961+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.recorder
04-23 13:42:59.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:42:59.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16532), cmd(0)
04-23 13:42:59.971+0200 I/utils   (16532): specific action
04-23 13:42:59.971+0200 I/recorder(16532): obteniendo datos locales...
04-23 13:42:59.971+0200 I/recorder(16532): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:42:424,1.545763,-2.364109,9.480364
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:42:616,1.660619,-2.191825,9.549755
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:42:812,1.713261,-2.244468,9.446864
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:16,1.706082,-2.120041,9.566505
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:212,1.713261,-2.189433,9.494720
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:412,1.641476,-2.172683,9.513863
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:612,1.710868,-2.270789,9.489935
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:812,1.698904,-2.043471,9.485149
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:16,1.636691,-2.225325,9.561719
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:213,1.691726,-2.230111,9.552148
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:413,1.694118,-2.139183,9.564112
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:613,1.677369,-2.081756,9.585647
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:813,1.749153,-2.120041,9.530612
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:13,1.751546,-1.947758,9.542577
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:213,1.753939,-2.266003,9.911072
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:413,2.579463,-0.981057,9.375079
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:613,5.730811,-7.496714,10.097712
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:814,6.187840,-4.622933,3.584448
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:46:14,5.869594,-3.720839,4.376472
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:46:214,7.231110,-5.417351,5.079963
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:46:414,7.484749,-3.373880,4.733003
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:46:614,8.015956,-1.682154,6.072984
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:46:814,8.025528,-1.928615,5.857630
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:47:14,8.238488,-1.624727,5.273781
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:47:215,7.757531,-1.663012,5.761917
04-23 13:42:59.971+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:47:415,7.750352,-2.007578,6.039484
04-23 13:42:59.981+0200 I/recorder(16532): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 13:42:59.981+0200 I/recorder(16532): obteniendo datos locales, DATA: SM-R760,23/04/2018,13:42:42:424,1.545763,-2.364109,9.480364
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:42:616,1.660619,-2.191825,9.549755
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:42:812,1.713261,-2.244468,9.446864
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:16,1.706082,-2.120041,9.566505
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:212,1.713261,-2.189433,9.494720
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:412,1.641476,-2.172683,9.513863
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:612,1.710868,-2.270789,9.489935
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:43:812,1.698904,-2.043471,9.485149
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:16,1.636691,-2.225325,9.561719
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:213,1.691726,-2.230111,9.552148
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:413,1.694118,-2.139183,9.564112
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:613,1.677369,-2.081756,9.585647
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:44:813,1.749153,-2.120041,9.530612
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:13,1.751546,-1.947758,9.542577
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:213,1.753939,-2.266003,9.911072
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:413,2.579463,-0.981057,9.375079
04-23 13:42:59.981+0200 I/recorder(16532): SM-R760,23/04/2018,13:42:45:613,5.
04-23 13:42:59.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:42:59.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20655.139189] layer(0x47f2c0) now usable
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20655.139222] layer[0x47ee10]zpos[1]
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20655.139247] layer(0x47f310) now usable
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20655.139259] layer[0x47ef30]zpos[2]
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20655.139286] layer(0x47f250) now usable
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20655.139297] layer[0x47ecf0]zpos[0]
04-23 13:43:00.021+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [20655.139397] dpms[0 -> 3]sync[1]
04-23 13:43:00.021+0200 I/TDM     ( 1945): 
04-23 13:43:00.041+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 13:43:00.051+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:43:00.051+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 13:43:00.051+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 13:43:00.051+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 13:43:00.051+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 13:43:00.051+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 13:43:00.051+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 13:43:00.051+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 13:43:00.051+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 13:43:00.051+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 13:43:00.051+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 13:43:00.051+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 13:43:00.051+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 13:43:00.051+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 13:43:00.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:00.091+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 13:43:00.091+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 13:43:00.091+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 13:43:00.091+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 13:43:00.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:00.111+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:00.121+0200 I/accelerometer(16863): es.ugr.frailty.accelerometer listener destroyed
04-23 13:43:00.141+0200 W/AUL     (16883): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:43:00.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:00.141+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:00.141+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:00.141+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:00.141+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:00.141+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:00.141+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:00.141+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:00.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:00.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16532
04-23 13:43:00.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:00.151+0200 E/AUL     (16883): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:00.151+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16532
04-23 13:43:00.151+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16532)
04-23 13:43:00.171+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [20655.280889] dpms[3 -> 3]done
04-23 13:43:00.171+0200 I/TDM     ( 1945): 
04-23 13:43:00.171+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:43:00.171+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:43:00.171+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 13:43:00.211+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:43:00.211+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:43:00.211+0200 W/CRASH_MANAGER(16881): worker.c: worker_job(1205) > 06165327265631524483779
04-23 13:43:00.211+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 13:43:00.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 13:43:00.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 13:43:00.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 13:43:00.211+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: RUNNING
04-23 13:43:00.211+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): main.c: _appcore_pause_cb(488) > appcore pause
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): main.c: home_pause(547) > clock/widget paused
04-23 13:43:00.211+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 13:43:00.211+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:43:00.221+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:43:00.231+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 13:43:00.231+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(bg) type(watchapp)
04-23 13:43:00.231+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppPause(552) > 
04-23 13:43:00.231+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 13:43:00.241+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 13:43:00.241+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 13:43:00.241+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [false][0m
04-23 13:43:00.241+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 13:43:00.241+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 13:43:00.241+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:43:00.241+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:43:00.241+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:43:00.271+0200 W/AUL     (16890): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:43:00.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:00.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:00.271+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:00.271+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:00.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:00.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:00.271+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:00.271+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:00.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:00.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16863
04-23 13:43:00.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:00.281+0200 E/AUL     (16890): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:00.281+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16863
04-23 13:43:00.281+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16863)
04-23 13:43:00.731+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 13:43:02.401+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:43:05.231+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 13:43:19.661+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:43:19.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:19.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:19.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16529
04-23 13:43:19.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:19.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16529), cmd(0)
04-23 13:43:19.711+0200 I/utils   (16529): specific action
04-23 13:43:19.711+0200 I/httppostreq(16529): internet connection check received
04-23 13:43:19.711+0200 I/httppostreq(16529): internet connection != null
04-23 13:43:19.711+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16529)
04-23 13:43:19.711+0200 I/CAPI_NETWORK_CONNECTION(16529): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:43:19.711+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.httppostreq
04-23 13:43:19.711+0200 I/httppostreq(16529): internet connection type...
04-23 13:43:19.711+0200 I/httppostreq(16529): internet connection type 1
04-23 13:43:19.711+0200 I/httppostreq(16529): internet available
04-23 13:43:19.711+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:43:19.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:19.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16529
04-23 13:43:19.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16526
04-23 13:43:19.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:19.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16526), cmd(0)
04-23 13:43:19.771+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:19.771+0200 I/utils   (16526): specific action
04-23 13:43:19.771+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:19.771+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:19.771+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:19.771+0200 I/servicemanager(16526): internet connection available. stop all sensors
04-23 13:43:19.771+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:43:19.771+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16526)
04-23 13:43:19.771+0200 I/httppostreq(16529): request sent to service es.ugr.frailty.servicemanager
04-23 13:43:19.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:19.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:19.791+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16933
04-23 13:43:19.791+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:19.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16933
04-23 13:43:19.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(16933) type(svcapp) bg(0)
04-23 13:43:19.841+0200 E/CAPI_APPFW_APPLICATION(16933): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:19.841+0200 E/CAPI_APPFW_APPLICATION(16933): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:19.841+0200 I/utils   (16933): trying to start service: es.ugr.frailty.accelerometer
04-23 13:43:19.851+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16933) was created
04-23 13:43:19.851+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16933]
04-23 13:43:19.851+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16933)
04-23 13:43:19.861+0200 I/utils   (16933): es.ugr.frailty.accelerometer sensor supported
04-23 13:43:19.861+0200 I/servicemanager(16526): es.ugr.frailty.accelerometer stop request sent!
04-23 13:43:19.861+0200 I/servicemanager(16526): App control destroyed.
04-23 13:43:19.861+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.861+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.861+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.861+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.871+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.871+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.871+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.871+0200 I/utils   (16933): es.ugr.frailty.accelerometer listener started
04-23 13:43:19.871+0200 I/accelerometer(16933): stopping es.ugr.frailty.accelerometer service
04-23 13:43:19.871+0200 E/CAPI_APPFW_APP_CONTROL(16933): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:43:19.871+0200 E/accelerometer(16933): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:43:19.871+0200 I/CAPI_APPFW_APPLICATION(16933): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:43:19.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:19.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16933
04-23 13:43:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:43:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:43:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:19.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16933
04-23 13:43:19.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:19.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 0
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 1
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 2
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 3
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 4
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 5
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 6
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 7
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:19.971+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:19.971+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:19.971+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:19.971+0200 I/servicemanager(16526): deleting timer 8
04-23 13:43:19.971+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:43:19.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:19.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:19.981+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:19.991+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:19.991+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16947
04-23 13:43:19.991+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:20.021+0200 I/accelerometer(16933): es.ugr.frailty.accelerometer listener destroyed
04-23 13:43:20.041+0200 E/CAPI_APPFW_APPLICATION(16947): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:20.041+0200 E/CAPI_APPFW_APPLICATION(16947): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:20.041+0200 I/utils   (16947): specific action
04-23 13:43:20.041+0200 I/recorder(16947): obteniendo datos locales...
04-23 13:43:20.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16947
04-23 13:43:20.041+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(16947) type(svcapp) bg(0)
04-23 13:43:20.051+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16947)
04-23 13:43:20.051+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.recorder
04-23 13:43:20.051+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16947]
04-23 13:43:20.051+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16947) was created
04-23 13:43:20.071+0200 I/recorder(16947): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:43:20.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:42:424,1.545763,-2.364109,9.480364
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:42:616,1.660619,-2.191825,9.549755
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:42:812,1.713261,-2.244468,9.446864
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:43:16,1.706082,-2.120041,9.566505
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:43:212,1.713261,-2.189433,9.494720
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:43:412,1.641476,-2.172683,9.513863
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:43:612,1.710868,-2.270789,9.489935
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:43:812,1.698904,-2.043471,9.485149
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:44:16,1.636691,-2.225325,9.561719
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:44:213,1.691726,-2.230111,9.552148
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:44:413,1.694118,-2.139183,9.564112
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:44:613,1.677369,-2.081756,9.585647
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:44:813,1.749153,-2.120041,9.530612
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:45:13,1.751546,-1.947758,9.542577
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:45:213,1.753939,-2.266003,9.911072
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:45:413,2.579463,-0.981057,9.375079
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:45:613,5.730811,-7.496714,10.097712
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:45:814,6.187840,-4.622933,3.584448
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:46:14,5.869594,-3.720839,4.376472
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:46:214,7.231110,-5.417351,5.079963
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:46:414,7.484749,-3.373880,4.733003
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:46:614,8.015956,-1.682154,6.072984
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:46:814,8.025528,-1.928615,5.857630
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:47:14,8.238488,-1.624727,5.273781
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:47:215,7.757531,-1.663012,5.761917
04-23 13:43:20.071+0200 I/recorder(16947): SM-R760,23/04/2018,13:42:47:415,7.750352,-2.007578,6.039484
04-23 13:43:20.081+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16947
04-23 13:43:20.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:20.091+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16947
04-23 13:43:20.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:20.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:20.171+0200 W/AUL     (16951): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:43:20.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:20.171+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:20.171+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:20.171+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:20.171+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:20.171+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:20.171+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:20.171+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:20.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:20.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16933
04-23 13:43:20.181+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:20.181+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16933
04-23 13:43:20.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16933)
04-23 13:43:20.181+0200 W/CRASH_MANAGER(16881): worker.c: worker_job(1205) > 1116947726563152448380
