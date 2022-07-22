S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15526
Date: 2018-04-23 13:36:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75ec648, r1   = 0xf77651b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77651b8, r5   = 0x00012cd0
r6   = 0xf7777e88, r7   = 0xf75ec250
r8   = 0x000005e0, r9   = 0xf70cf824
r10  = 0xf775d9d8, fp   = 0x00000000
ip   = 0xf75eb030, sp   = 0xffb24420
lr   = 0xf752f5d0, pc   = 0xf752b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5004 KB
Buffers:     60560 KB
Cached:     160948 KB
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
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6c66000 f6c69000 r-xp /lib/libattr.so.1.1.0
f6c72000 f6c79000 r-xp /lib/libcrypt-2.13.so
f6ca9000 f6cac000 r-xp /lib/libcap.so.2.21
f6cb4000 f6cb6000 r-xp /usr/lib/libiri.so
f6cbe000 f6cdb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ce4000 f6ce8000 r-xp /usr/lib/libsmack.so.1.0.0
f6cf2000 f6cf4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cfc000 f6d01000 r-xp /usr/lib/libffi.so.5.0.10
f6d09000 f6d0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d12000 f6d14000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d1c000 f6d1e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d28000 f6d38000 r-xp /lib/libresolv-2.13.so
f6d3c000 f6d54000 r-xp /usr/lib/liblzma.so.5.0.3
f6d5c000 f6d5e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d66000 f6d95000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d9e000 f6dad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6db6000 f6dc0000 r-xp /usr/lib/libsensord-shared.so
f6dc9000 f6dfd000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e06000 f6ed9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ee4000 f6efa000 r-xp /lib/libz.so.1.2.5
f6f02000 f6f08000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f11000 f6f86000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f90000 f6faa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6fb2000 f6fb8000 r-xp /lib/librt-2.13.so
f6fc1000 f6fdf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fe9000 f6fea000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ff2000 f6ff7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fff000 f70cf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70d0000 f70fa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7103000 f711a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7122000 f718b000 r-xp /lib/libm-2.13.so
f7194000 f7228000 r-xp /usr/lib/libstdc++.so.6.0.16
f723b000 f7240000 r-xp /usr/lib/libctx-client.so.0.8.3
f7248000 f724f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7257000 f7281000 r-xp /usr/lib/libsensor.so.1.9.6
f728a000 f7356000 r-xp /usr/lib/libxml2.so.2.7.8
f7363000 f7365000 r-xp /usr/lib/libiniparser.so.0
f736e000 f7371000 r-xp /usr/lib/libbundle.so.0.1.22
f7379000 f737f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7387000 f73aa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f73b2000 f73f3000 r-xp /usr/lib/libeina.so.1.7.99
f73fc000 f7413000 r-xp /usr/lib/libecore.so.1.7.99
f742a000 f7433000 r-xp /usr/lib/libvconf.so.0.2.45
f743b000 f744f000 r-xp /lib/libpthread-2.13.so
f745a000 f7467000 r-xp /usr/lib/libaul.so.0.1.0
f7471000 f7473000 r-xp /lib/libdl-2.13.so
f747c000 f7487000 r-xp /lib/libunwind.so.8.0.1
f74b4000 f74bc000 r-xp /lib/libgcc_s-4.6.so.1
f74bd000 f75e1000 r-xp /lib/libc-2.13.so
f75ef000 f75f1000 r-xp /usr/lib/libdlog.so.0.0.0
f75f9000 f7605000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f760e000 f7613000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f761b000 f761f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7628000 f762a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7633000 f7636000 r-xp /usr/lib/libappcore-agent.so.1.1
f7654000 f7671000 r-xp /lib/ld-2.13.so
f767a000 f767d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f767d000 f7681000 r-xp /usr/lib/libsys-assert.so
f7753000 f77a1000 rw-p [heap]
ffb06000 ffb27000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15526)
Call Stack Count: 1
 0: (0xf752b9fc) [/lib/libc.so.6] + 0x6e9fc
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
921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:36:28.921+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:36:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:28.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:28.931+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15460
04-23 13:36:28.931+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:36:28.971+0200 E/CAPI_APPFW_APPLICATION(15460): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:926,75
04-23 13:36:28.971+0200 E/CAPI_APPFW_APPLICATION(15460): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.971+0200 I/utils   (15460): specific action
04-23 13:36:28.971+0200 I/recorder(15460): obteniendo datos locales...
04-23 13:36:28.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15460
04-23 13:36:28.981+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15460) type(svcapp) bg(0)
04-23 13:36:28.991+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15460) was created
04-23 13:36:29.001+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15460]
04-23 13:36:29.011+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15460)
04-23 13:36:29.011+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:36:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.021+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15460
04-23 13:36:29.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.081+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:36:29.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:36:29.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:119,75
04-23 13:36:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15447
04-23 13:36:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.171+0200 I/accelerometer(15447): es.ugr.frailty.accelerometer listener destroyed
04-23 13:36:29.191+0200 I/recorder(15460): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:36:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15460
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:36:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.231+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:36:29.331+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:339,75
04-23 13:36:29.361+0200 W/AUL     (15466): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15447
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:36:29.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15447
04-23 13:36:29.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15447)
04-23 13:36:29.371+0200 E/AUL     (15466): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:36:29.381+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11154607265631524483389
04-23 13:36:29.411+0200 W/AUL     (15469): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:36:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:36:29.421+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:29.421+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:29.421+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:29.421+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:29.421+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:29.421+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:36:29.421+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:36:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:36:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15460
04-23 13:36:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:36:29.431+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15460
04-23 13:36:29.431+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15460)
04-23 13:36:29.441+0200 E/AUL     (15469): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:36:29.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:505,75
04-23 13:36:29.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:706,75
04-23 13:36:29.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:906,75
04-23 13:36:30.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:30.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:30:106,75
04-23 13:36:30.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:30.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:30:308,75
04-23 13:36:30.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:30.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:30:506,75
04-23 13:36:30.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:30.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:30:706,75
04-23 13:36:30.841+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:36:30.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:30.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:30:906,74
04-23 13:36:31.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:31.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:31:106,75
04-23 13:36:31.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:31.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:31:307,74
04-23 13:36:31.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:31.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:31:507,74
04-23 13:36:31.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:31.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:31:707,74
04-23 13:36:31.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:31.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:31:907,74
04-23 13:36:32.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:32.121+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:32:107,74
04-23 13:36:32.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:32.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:32:307,74
04-23 13:36:32.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:32.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:32:507,74
04-23 13:36:32.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:32.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:32:707,74
04-23 13:36:32.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:32.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:32:908,74
04-23 13:36:33.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:33.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:33:108,74
04-23 13:36:33.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:33.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:33:308,73
04-23 13:36:33.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:33.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:33:508,73
04-23 13:36:33.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:33.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:33:709,73
04-23 13:36:33.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:33.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:33:908,73
04-23 13:36:34.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:34.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:34:109,74
04-23 13:36:34.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:34.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:34:309,74
04-23 13:36:34.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:34.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:34:510,74
04-23 13:36:34.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:34.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:34:709,74
04-23 13:36:34.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:34.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:34:910,74
04-23 13:36:35.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:35.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:35:109,74
04-23 13:36:35.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:35.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:35:309,74
04-23 13:36:35.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:35.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:35:509,74
04-23 13:36:35.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:35.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:35:709,74
04-23 13:36:35.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:35.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:35:910,75
04-23 13:36:36.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:36.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:36:110,75
04-23 13:36:36.311+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:36.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:36:319,75
04-23 13:36:36.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:36.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:36:510,75
04-23 13:36:36.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:36.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:36:710,75
04-23 13:36:36.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:36.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:36:910,75
04-23 13:36:37.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:37.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:37:111,76
04-23 13:36:37.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:37.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:37:311,75
04-23 13:36:37.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:37.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:37:511,76
04-23 13:36:37.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:37.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:37:711,76
04-23 13:36:37.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:37.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:37:911,76
04-23 13:36:38.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:38.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:38:111,76
04-23 13:36:38.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:38.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:38:311,76
04-23 13:36:38.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:38.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:38:511,76
04-23 13:36:38.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:38.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:38:711,76
04-23 13:36:38.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:38.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:38:912,76
04-23 13:36:39.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:39.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:39:112,76
04-23 13:36:39.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:39.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:39:312,76
04-23 13:36:39.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:39.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:39:512,76
04-23 13:36:39.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:39.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:39:712,76
04-23 13:36:39.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:39.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:39:912,76
04-23 13:36:40.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:40.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:40:112,77
04-23 13:36:40.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:40.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:40:313,77
04-23 13:36:40.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:40.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:40:513,77
04-23 13:36:40.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:40.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:40:713,77
04-23 13:36:40.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:40.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:40:913,77
04-23 13:36:41.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:41.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:41:113,77
04-23 13:36:41.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:41.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:41:313,77
04-23 13:36:41.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:41.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:41:513,77
04-23 13:36:41.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:41.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:41:714,77
04-23 13:36:41.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:41.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:41:914,78
04-23 13:36:42.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:42.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:42:114,78
04-23 13:36:42.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:42.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:42:314,78
04-23 13:36:42.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:42.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:42:514,78
04-23 13:36:42.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:42.701+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:42:714,78
04-23 13:36:42.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:42.901+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:42:914,78
04-23 13:36:43.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:43.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:43:114,78
04-23 13:36:43.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:43.301+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:43:315,78
04-23 13:36:43.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:43.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:43:515,79
04-23 13:36:43.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:43.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:43:715,79
04-23 13:36:43.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:43.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:43:915,79
04-23 13:36:44.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:44.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:44:116,79
04-23 13:36:44.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:44.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:44:315,79
04-23 13:36:44.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:44.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:44:515,79
04-23 13:36:44.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:44.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:44:716,78
04-23 13:36:44.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:44.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:44:916,78
04-23 13:36:45.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:45.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:45:116,78
04-23 13:36:45.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:45.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:45:316,78
04-23 13:36:45.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:45.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:45:516,77
04-23 13:36:45.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:45.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:45:716,77
04-23 13:36:45.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:45.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:45:916,77
04-23 13:36:46.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:46.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:46:117,77
04-23 13:36:46.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:46.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:46:317,77
04-23 13:36:46.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:46.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:46:517,76
04-23 13:36:46.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:46.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:46:717,76
04-23 13:36:46.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:46.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:46:917,76
04-23 13:36:47.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:47.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:47:117,76
04-23 13:36:47.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:47.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:47:317,76
04-23 13:36:47.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:47.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:47:517,76
04-23 13:36:47.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:47.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:47:717,76
04-23 13:36:47.901+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:47.911+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:47:918,75
04-23 13:36:48.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:48.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:48:118,76
04-23 13:36:48.301+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:48.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:48:318,76
04-23 13:36:48.501+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:48.511+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:48:518,75
04-23 13:36:48.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:36:48.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:48.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:48.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:36:48.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:36:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:36:48.661+0200 I/utils   ( 9745): specific action
04-23 13:36:48.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:36:48.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:36:48.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:36:48.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:36:48.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:36:48.661+0200 I/httppostreq( 9745): internet available
04-23 13:36:48.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:36:48.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:36:48.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:36:48.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:36:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:36:48.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:36:48.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:36:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:48.691+0200 I/utils   ( 9742): specific action
04-23 13:36:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:48.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:36:48.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:36:48.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:36:48.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:36:48.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:48.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:48.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:36:48.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15514
04-23 13:36:48.721+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:48.741+0200 E/CAPI_APPFW_APPLICATION(15514): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:48.741+0200 E/CAPI_APPFW_APPLICATION(15514): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:48.741+0200 I/utils   (15514): trying to start service: es.ugr.frailty.accelerometer
04-23 13:36:48.751+0200 I/utils   (15514): es.ugr.frailty.accelerometer sensor supported
04-23 13:36:48.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:48:718,75
04-23 13:36:48.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15514
04-23 13:36:48.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15514) type(svcapp) bg(0)
04-23 13:36:48.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15514) was created
04-23 13:36:48.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15514]
04-23 13:36:48.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15514
04-23 13:36:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:48.841+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15514)
04-23 13:36:48.841+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:36:48.841+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:48.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:48.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:48.841+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:36:48.841+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:36:48.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:48.841+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:48.851+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15526
04-23 13:36:48.851+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:36:48.861+0200 I/utils   (15514): es.ugr.frailty.accelerometer listener started
04-23 13:36:48.901+0200 E/CAPI_APPFW_APPLICATION(15526): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:48.901+0200 E/CAPI_APPFW_APPLICATION(15526): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:48.901+0200 I/utils   (15526): specific action
04-23 13:36:48.901+0200 I/recorder(15526): obteniendo datos locales...
04-23 13:36:48.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15526
04-23 13:36:48.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15526) type(svcapp) bg(0)
04-23 13:36:48.911+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15526) was created
04-23 13:36:48.911+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15526]
04-23 13:36:48.911+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15526)
04-23 13:36:48.921+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:36:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15526
04-23 13:36:48.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:48.941+0200 I/accelerometer(15514): stopping es.ugr.frailty.accelerometer service
04-23 13:36:48.941+0200 E/CAPI_APPFW_APP_CONTROL(15514): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:36:48.951+0200 E/accelerometer(15514): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:36:48.951+0200 I/CAPI_APPFW_APPLICATION(15514): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:36:48.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:36:48.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:36:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15514
04-23 13:36:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:49.061+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15526
04-23 13:36:49.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:49.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:49.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:49:113,75
04-23 13:36:49.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:49.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:49:119,75
04-23 13:36:49.131+0200 I/recorder(15526): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:36:49.131+0200 I/recorder(15526): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:36:49.181+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115526726563152448340
