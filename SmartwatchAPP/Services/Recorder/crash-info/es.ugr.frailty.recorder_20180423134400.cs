S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 17076
Date: 2018-04-23 13:44:00+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf700a648, r1   = 0xf71d41b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf71d41b8, r5   = 0x00012cd0
r6   = 0xf71e6e88, r7   = 0xf700a250
r8   = 0x00000618, r9   = 0xf6aed824
r10  = 0xf71cc9d8, fp   = 0x00000000
ip   = 0xf7009030, sp   = 0xff9e7c90
lr   = 0xf6f4d5d0, pc   = 0xf6f499fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:    101680 KB
Buffers:     29160 KB
Cached:     148396 KB
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
f6684000 f6687000 r-xp /lib/libattr.so.1.1.0
f6690000 f6697000 r-xp /lib/libcrypt-2.13.so
f66c7000 f66ca000 r-xp /lib/libcap.so.2.21
f66d2000 f66d4000 r-xp /usr/lib/libiri.so
f66dc000 f66f9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6702000 f6706000 r-xp /usr/lib/libsmack.so.1.0.0
f6710000 f6712000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f671a000 f671f000 r-xp /usr/lib/libffi.so.5.0.10
f6727000 f6728000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6730000 f6732000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f673a000 f673c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6746000 f6756000 r-xp /lib/libresolv-2.13.so
f675a000 f6772000 r-xp /usr/lib/liblzma.so.5.0.3
f677a000 f677c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6784000 f67b3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67bc000 f67cb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67d4000 f67de000 r-xp /usr/lib/libsensord-shared.so
f67e7000 f681b000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6824000 f68f7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6902000 f6918000 r-xp /lib/libz.so.1.2.5
f6920000 f6926000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f692f000 f69a4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ae000 f69c8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69d0000 f69d6000 r-xp /lib/librt-2.13.so
f69df000 f69fd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a07000 f6a08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a10000 f6a15000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a1d000 f6aed000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6aee000 f6b18000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b21000 f6b38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b40000 f6ba9000 r-xp /lib/libm-2.13.so
f6bb2000 f6c46000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c59000 f6c5e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c66000 f6c6d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c75000 f6c9f000 r-xp /usr/lib/libsensor.so.1.9.6
f6ca8000 f6d74000 r-xp /usr/lib/libxml2.so.2.7.8
f6d81000 f6d83000 r-xp /usr/lib/libiniparser.so.0
f6d8c000 f6d8f000 r-xp /usr/lib/libbundle.so.0.1.22
f6d97000 f6d9d000 r-xp /usr/lib/libappsvc.so.0.1.0
f6da5000 f6dc8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dd0000 f6e11000 r-xp /usr/lib/libeina.so.1.7.99
f6e1a000 f6e31000 r-xp /usr/lib/libecore.so.1.7.99
f6e48000 f6e51000 r-xp /usr/lib/libvconf.so.0.2.45
f6e59000 f6e6d000 r-xp /lib/libpthread-2.13.so
f6e78000 f6e85000 r-xp /usr/lib/libaul.so.0.1.0
f6e8f000 f6e91000 r-xp /lib/libdl-2.13.so
f6e9a000 f6ea5000 r-xp /lib/libunwind.so.8.0.1
f6ed2000 f6eda000 r-xp /lib/libgcc_s-4.6.so.1
f6edb000 f6fff000 r-xp /lib/libc-2.13.so
f700d000 f700f000 r-xp /usr/lib/libdlog.so.0.0.0
f7017000 f7023000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f702c000 f7031000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7039000 f703d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7046000 f7048000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7051000 f7054000 r-xp /usr/lib/libappcore-agent.so.1.1
f7072000 f708f000 r-xp /lib/ld-2.13.so
f7098000 f709b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f709b000 f709f000 r-xp /usr/lib/libsys-assert.so
f71c2000 f7210000 rw-p [heap]
ff9c9000 ff9ea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17076)
Call Stack Count: 1
 0: (0xf6f499fc) [/lib/libc.so.6] + 0x6e9fc
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
RCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
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
04-23 13:43:20.181+0200 W/CRASH_MANAGER(16881): worker.c: worker_job(1205) > 11169477265631524483800
04-23 13:43:20.191+0200 E/AUL     (16951): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:20.231+0200 W/AUL     (16956): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:43:20.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:20.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:20.231+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:20.231+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:20.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:20.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:20.231+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:20.231+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:20.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:20.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16947
04-23 13:43:20.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:20.241+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16947
04-23 13:43:20.241+0200 E/AUL     (16956): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:20.241+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16947)
04-23 13:43:21.891+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:43:39.661+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:43:39.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:39.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:39.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16529
04-23 13:43:39.701+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:39.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16529), cmd(0)
04-23 13:43:39.711+0200 I/utils   (16529): specific action
04-23 13:43:39.711+0200 I/httppostreq(16529): internet connection check received
04-23 13:43:39.711+0200 I/httppostreq(16529): internet connection != null
04-23 13:43:39.711+0200 I/CAPI_NETWORK_CONNECTION(16529): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:43:39.711+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16529)
04-23 13:43:39.711+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.httppostreq
04-23 13:43:39.711+0200 I/httppostreq(16529): internet connection type...
04-23 13:43:39.711+0200 I/httppostreq(16529): internet connection type 1
04-23 13:43:39.711+0200 I/httppostreq(16529): internet available
04-23 13:43:39.711+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:43:39.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:39.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16529
04-23 13:43:39.741+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16526
04-23 13:43:39.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:39.741+0200 I/utils   (16526): specific action
04-23 13:43:39.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:39.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:39.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:39.741+0200 I/servicemanager(16526): internet connection available. stop all sensors
04-23 13:43:39.741+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:43:39.751+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16526)
04-23 13:43:39.751+0200 I/httppostreq(16529): request sent to service es.ugr.frailty.servicemanager
04-23 13:43:39.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:39.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:39.771+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:39.771+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17001
04-23 13:43:39.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17001
04-23 13:43:39.821+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(17001) type(svcapp) bg(0)
04-23 13:43:39.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:39.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16526), cmd(0)
04-23 13:43:39.831+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17001]
04-23 13:43:39.831+0200 E/CAPI_APPFW_APPLICATION(17001): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:39.831+0200 E/CAPI_APPFW_APPLICATION(17001): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:39.831+0200 I/utils   (17001): trying to start service: es.ugr.frailty.accelerometer
04-23 13:43:39.831+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17001) was created
04-23 13:43:39.831+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17001)
04-23 13:43:39.831+0200 I/servicemanager(16526): es.ugr.frailty.accelerometer stop request sent!
04-23 13:43:39.831+0200 I/servicemanager(16526): App control destroyed.
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 0
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 1
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 2
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 3
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 4
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 5
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 6
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 7
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:39.831+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:39.831+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:39.831+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:39.831+0200 I/servicemanager(16526): deleting timer 8
04-23 13:43:39.831+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:43:39.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:39.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:39.851+0200 I/utils   (17001): es.ugr.frailty.accelerometer sensor supported
04-23 13:43:39.861+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:39.861+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17013
04-23 13:43:39.871+0200 I/utils   (17001): es.ugr.frailty.accelerometer listener started
04-23 13:43:39.871+0200 I/accelerometer(17001): stopping es.ugr.frailty.accelerometer service
04-23 13:43:39.871+0200 E/CAPI_APPFW_APP_CONTROL(17001): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:43:39.871+0200 E/accelerometer(17001): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:43:39.871+0200 I/CAPI_APPFW_APPLICATION(17001): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:43:39.911+0200 E/CAPI_APPFW_APPLICATION(17013): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:39.911+0200 E/CAPI_APPFW_APPLICATION(17013): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:39.911+0200 I/utils   (17013): specific action
04-23 13:43:39.911+0200 I/recorder(17013): obteniendo datos locales...
04-23 13:43:39.911+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17013
04-23 13:43:39.911+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(17013) type(svcapp) bg(0)
04-23 13:43:39.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:39.921+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17013]
04-23 13:43:39.921+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17001
04-23 13:43:39.921+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17013) was created
04-23 13:43:39.931+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17013)
04-23 13:43:39.931+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.recorder
04-23 13:43:39.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:39.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17001
04-23 13:43:39.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:43:39.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:43:39.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:39.981+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:39.991+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:39.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:40.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17013
04-23 13:43:40.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:40.011+0200 I/accelerometer(17001): es.ugr.frailty.accelerometer listener destroyed
04-23 13:43:40.021+0200 I/recorder(17013): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:42:424,1.545763,-2.364109,9.480364
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:42:616,1.660619,-2.191825,9.549755
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:42:812,1.713261,-2.244468,9.446864
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:43:16,1.706082,-2.120041,9.566505
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:43:212,1.713261,-2.189433,9.494720
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:43:412,1.641476,-2.172683,9.513863
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:43:612,1.710868,-2.270789,9.489935
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:43:812,1.698904,-2.043471,9.485149
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:44:16,1.636691,-2.225325,9.561719
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:44:213,1.691726,-2.230111,9.552148
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:44:413,1.694118,-2.139183,9.564112
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:44:613,1.677369,-2.081756,9.585647
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:44:813,1.749153,-2.120041,9.530612
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:45:13,1.751546,-1.947758,9.542577
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:45:213,1.753939,-2.266003,9.911072
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:45:413,2.579463,-0.981057,9.375079
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:45:613,5.730811,-7.496714,10.097712
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:45:814,6.187840,-4.622933,3.584448
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:46:14,5.869594,-3.720839,4.376472
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:46:214,7.231110,-5.417351,5.079963
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:46:414,7.484749,-3.373880,4.733003
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:46:614,8.015956,-1.682154,6.072984
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:46:814,8.025528,-1.928615,5.857630
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:47:14,8.238488,-1.624727,5.273781
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:47:215,7.757531,-1.663012,5.761917
04-23 13:43:40.021+0200 I/recorder(17013): SM-R760,23/04/2018,13:42:47:415,7.750352,-2.007578,6.039484
04-23 13:43:40.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:40.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:40.081+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17013
04-23 13:43:40.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:40.121+0200 W/CRASH_MANAGER(16881): worker.c: worker_job(1205) > 11170137265631524483820
04-23 13:43:40.161+0200 W/AUL     (17023): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:40.161+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:40.161+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:40.161+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:40.161+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:40.161+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:40.161+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:40.161+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 17001
04-23 13:43:40.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:40.171+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 17001
04-23 13:43:40.171+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(17001)
04-23 13:43:40.181+0200 E/AUL     (17023): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:40.191+0200 W/AUL     (17024): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:43:40.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:40.191+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:40.191+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:40.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:40.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:40.191+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:43:40.191+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 17013
04-23 13:43:40.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:43:40.201+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 17013
04-23 13:43:40.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(17013)
04-23 13:43:40.211+0200 E/AUL     (17024): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:43:41.941+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:43:59.651+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:43:59.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:59.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:59.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16529
04-23 13:43:59.691+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:59.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16529), cmd(0)
04-23 13:43:59.691+0200 I/utils   (16529): specific action
04-23 13:43:59.691+0200 I/httppostreq(16529): internet connection check received
04-23 13:43:59.691+0200 I/httppostreq(16529): internet connection != null
04-23 13:43:59.701+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16529)
04-23 13:43:59.701+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.httppostreq
04-23 13:43:59.701+0200 I/CAPI_NETWORK_CONNECTION(16529): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:43:59.701+0200 I/httppostreq(16529): internet connection type...
04-23 13:43:59.701+0200 I/httppostreq(16529): internet connection type 1
04-23 13:43:59.701+0200 I/httppostreq(16529): internet available
04-23 13:43:59.701+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:43:59.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:59.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16529
04-23 13:43:59.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16526
04-23 13:43:59.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:43:59.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16526), cmd(0)
04-23 13:43:59.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:59.741+0200 I/utils   (16526): specific action
04-23 13:43:59.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:59.741+0200 W/AUL     (16529): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16526)
04-23 13:43:59.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:59.741+0200 W/CAPI_APPFW_APP_CONTROL(16526): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:43:59.741+0200 I/servicemanager(16526): internet connection available. stop all sensors
04-23 13:43:59.741+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:43:59.741+0200 I/httppostreq(16529): request sent to service es.ugr.frailty.servicemanager
04-23 13:43:59.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:59.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:59.761+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17069
04-23 13:43:59.761+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:59.811+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17069
04-23 13:43:59.811+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(17069) type(svcapp) bg(0)
04-23 13:43:59.821+0200 E/CAPI_APPFW_APPLICATION(17069): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:59.821+0200 E/CAPI_APPFW_APPLICATION(17069): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:43:59.821+0200 I/utils   (17069): trying to start service: es.ugr.frailty.accelerometer
04-23 13:43:59.831+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17069) was created
04-23 13:43:59.831+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17069]
04-23 13:43:59.841+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17069)
04-23 13:43:59.841+0200 I/servicemanager(16526): es.ugr.frailty.accelerometer stop request sent!
04-23 13:43:59.841+0200 I/servicemanager(16526): App control destroyed.
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 0
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 1
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 2
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 3
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 4
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 5
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 6
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 7
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:573 _ecore_magic_fail() 
04-23 13:43:59.841+0200 E/EFL     (16526): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** IN FUNCTION: ecore_timer_del()
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:43:59.841+0200 E/EFL     (16526): ecore<16526> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** SPANK SPANK SPANK!!!
04-23 13:43:59.841+0200 E/EFL     (16526): *** Now go fix your code. Tut tut tut!
04-23 13:43:59.841+0200 I/servicemanager(16526): deleting timer 8
04-23 13:43:59.841+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:43:59.841+0200 I/utils   (17069): es.ugr.frailty.accelerometer sensor supported
04-23 13:43:59.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:43:59.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 16526
04-23 13:43:59.851+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:43:59.851+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17076
04-23 13:43:59.871+0200 I/utils   (17069): es.ugr.frailty.accelerometer listener started
04-23 13:43:59.871+0200 I/accelerometer(17069): stopping es.ugr.frailty.accelerometer service
04-23 13:43:59.871+0200 E/CAPI_APPFW_APP_CONTROL(17069): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:43:59.871+0200 E/accelerometer(17069): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:43:59.871+0200 I/CAPI_APPFW_APPLICATION(17069): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:43:59.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17076
04-23 13:43:59.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(17076) type(svcapp) bg(0)
04-23 13:43:59.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:59.921+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17069
04-23 13:43:59.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:43:59.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17069
04-23 13:43:59.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:43:59.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:43:59.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:43:59.951+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17076]
04-23 13:43:59.971+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:59.981+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:43:59.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:44:00.001+0200 W/AUL     (16526): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17076)
04-23 13:44:00.001+0200 I/servicemanager(16526): request sent to service es.ugr.frailty.recorder
04-23 13:44:00.011+0200 E/CAPI_APPFW_APPLICATION(17076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:44:00.011+0200 E/CAPI_APPFW_APPLICATION(17076): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:44:00.011+0200 I/accelerometer(17069): es.ugr.frailty.accelerometer listener destroyed
04-23 13:44:00.011+0200 I/utils   (17076): specific action
04-23 13:44:00.011+0200 I/recorder(17076): obteniendo datos locales...
04-23 13:44:00.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:44:00.041+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17076
04-23 13:44:00.041+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17076) was created
04-23 13:44:00.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:44:00.051+0200 I/recorder(17076): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:42:424,1.545763,-2.364109,9.480364
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:42:616,1.660619,-2.191825,9.549755
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:42:812,1.713261,-2.244468,9.446864
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:43:16,1.706082,-2.120041,9.566505
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:43:212,1.713261,-2.189433,9.494720
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:43:412,1.641476,-2.172683,9.513863
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:43:612,1.710868,-2.270789,9.489935
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:43:812,1.698904,-2.043471,9.485149
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:44:16,1.636691,-2.225325,9.561719
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:44:213,1.691726,-2.230111,9.552148
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:44:413,1.694118,-2.139183,9.564112
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:44:613,1.677369,-2.081756,9.585647
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:44:813,1.749153,-2.120041,9.530612
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:45:13,1.751546,-1.947758,9.542577
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:45:213,1.753939,-2.266003,9.911072
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:45:413,2.579463,-0.981057,9.375079
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:45:613,5.730811,-7.496714,10.097712
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:45:814,6.187840,-4.622933,3.584448
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:46:14,5.869594,-3.720839,4.376472
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:46:214,7.231110,-5.417351,5.079963
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:46:414,7.484749,-3.373880,4.733003
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:46:614,8.015956,-1.682154,6.072984
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:46:814,8.025528,-1.928615,5.857630
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:47:14,8.238488,-1.624727,5.273781
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:47:215,7.757531,-1.663012,5.761917
04-23 13:44:00.051+0200 I/recorder(17076): SM-R760,23/04/2018,13:42:47:415,7.750352,-2.007578,6.039484
04-23 13:44:00.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:44:00.091+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17076
04-23 13:44:00.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:44:00.111+0200 W/CRASH_MANAGER(16881): worker.c: worker_job(1205) > 1117076726563152448384
