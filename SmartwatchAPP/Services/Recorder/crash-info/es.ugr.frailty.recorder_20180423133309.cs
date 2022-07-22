S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 14761
Date: 2018-04-23 13:33:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75b0648, r1   = 0xf7b3b1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7b3b1b8, r5   = 0x00012cd0
r6   = 0xf7b4de88, r7   = 0xf75b0250
r8   = 0x000005e0, r9   = 0xf7093824
r10  = 0xf7b339d8, fp   = 0x00000000
ip   = 0xf75af030, sp   = 0xffc18df0
lr   = 0xf74f35d0, pc   = 0xf74ef9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      7400 KB
Buffers:     70560 KB
Cached:     178872 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6c2a000 f6c2d000 r-xp /lib/libattr.so.1.1.0
f6c36000 f6c3d000 r-xp /lib/libcrypt-2.13.so
f6c6d000 f6c70000 r-xp /lib/libcap.so.2.21
f6c78000 f6c7a000 r-xp /usr/lib/libiri.so
f6c82000 f6c9f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ca8000 f6cac000 r-xp /usr/lib/libsmack.so.1.0.0
f6cb6000 f6cb8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cc0000 f6cc5000 r-xp /usr/lib/libffi.so.5.0.10
f6ccd000 f6cce000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cd6000 f6cd8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ce0000 f6ce2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cec000 f6cfc000 r-xp /lib/libresolv-2.13.so
f6d00000 f6d18000 r-xp /usr/lib/liblzma.so.5.0.3
f6d20000 f6d22000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d2a000 f6d59000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d62000 f6d71000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d7a000 f6d84000 r-xp /usr/lib/libsensord-shared.so
f6d8d000 f6dc1000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dca000 f6e9d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ea8000 f6ebe000 r-xp /lib/libz.so.1.2.5
f6ec6000 f6ecc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ed5000 f6f4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f54000 f6f6e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f76000 f6f7c000 r-xp /lib/librt-2.13.so
f6f85000 f6fa3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fad000 f6fae000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fb6000 f6fbb000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fc3000 f7093000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7094000 f70be000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70c7000 f70de000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70e6000 f714f000 r-xp /lib/libm-2.13.so
f7158000 f71ec000 r-xp /usr/lib/libstdc++.so.6.0.16
f71ff000 f7204000 r-xp /usr/lib/libctx-client.so.0.8.3
f720c000 f7213000 r-xp /usr/lib/libctx-shared.so.0.8.3
f721b000 f7245000 r-xp /usr/lib/libsensor.so.1.9.6
f724e000 f731a000 r-xp /usr/lib/libxml2.so.2.7.8
f7327000 f7329000 r-xp /usr/lib/libiniparser.so.0
f7332000 f7335000 r-xp /usr/lib/libbundle.so.0.1.22
f733d000 f7343000 r-xp /usr/lib/libappsvc.so.0.1.0
f734b000 f736e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7376000 f73b7000 r-xp /usr/lib/libeina.so.1.7.99
f73c0000 f73d7000 r-xp /usr/lib/libecore.so.1.7.99
f73ee000 f73f7000 r-xp /usr/lib/libvconf.so.0.2.45
f73ff000 f7413000 r-xp /lib/libpthread-2.13.so
f741e000 f742b000 r-xp /usr/lib/libaul.so.0.1.0
f7435000 f7437000 r-xp /lib/libdl-2.13.so
f7440000 f744b000 r-xp /lib/libunwind.so.8.0.1
f7478000 f7480000 r-xp /lib/libgcc_s-4.6.so.1
f7481000 f75a5000 r-xp /lib/libc-2.13.so
f75b3000 f75b5000 r-xp /usr/lib/libdlog.so.0.0.0
f75bd000 f75c9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75d2000 f75d7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75df000 f75e3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ec000 f75ee000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f75f7000 f75fa000 r-xp /usr/lib/libappcore-agent.so.1.1
f7618000 f7635000 r-xp /lib/ld-2.13.so
f763e000 f7641000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7641000 f7645000 r-xp /usr/lib/libsys-assert.so
f7b29000 f7b77000 rw-p [heap]
ffbfa000 ffc1b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14761)
Call Stack Count: 1
 0: (0xf74ef9fc) [/lib/libc.so.6] + 0x6e9fc
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
D ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14692
04-23 13:32:48.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(14692) type(svcapp) bg(0)
04-23 13:32:48.901+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14692) was created
04-23 13:32:48.921+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14692]
04-23 13:32:48.921+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14692)
04-23 13:32:48.921+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:32:48.921+0200 E/CAPI_APPFW_APP_CONTROL(14680): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:32:48.921+0200 E/accelerometer(14680): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:32:48.921+0200 I/CAPI_APPFW_APPLICATION(14680): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:32:48.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:32:48.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:32:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:32:48.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14692
04-23 13:32:48.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:32:48.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:32:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14680
04-23 13:32:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:32:49.051+0200 I/recorder(14692): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:32:49.051+0200 I/recorder(14692): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:32:49.101+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:48:991,78
04-23 13:32:49.161+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11146927265631524483169
04-23 13:32:49.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:49.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:49:170,78
04-23 13:32:49.261+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:32:49.271+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:32:49.281+0200 E/AUL     ( 2478): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 13:32:49.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:32:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:32:49.291+0200 W/AUL     (14702): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:32:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:32:49.291+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:32:49.291+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:32:49.291+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:32:49.291+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:32:49.291+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:32:49.291+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:32:49.291+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:32:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:32:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14692
04-23 13:32:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:32:49.291+0200 E/AUL     (14702): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:32:49.301+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 13:32:49.301+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14692
04-23 13:32:49.301+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14692)
04-23 13:32:49.311+0200 I/accelerometer(14680): es.ugr.frailty.accelerometer listener destroyed
04-23 13:32:49.311+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 13:32:49.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:49.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:49:359,79
04-23 13:32:49.461+0200 W/AUL     (14708): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:32:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:32:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:32:49.461+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:32:49.461+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:32:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:32:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:32:49.461+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:32:49.461+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:32:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:32:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14680
04-23 13:32:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:32:49.471+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14680
04-23 13:32:49.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14680)
04-23 13:32:49.481+0200 E/AUL     (14708): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:32:49.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:49.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:49:559,79
04-23 13:32:49.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:49.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:49:759,79
04-23 13:32:49.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:49.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:49:959,79
04-23 13:32:50.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:50.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:50:159,79
04-23 13:32:50.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:50.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:50:359,79
04-23 13:32:50.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:50.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:50:560,79
04-23 13:32:50.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:50.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:50:760,78
04-23 13:32:50.921+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:32:50.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:50.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:50:960,78
04-23 13:32:51.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:51.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:51:160,78
04-23 13:32:51.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:51.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:51:360,78
04-23 13:32:51.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:51.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:51:560,78
04-23 13:32:51.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:51.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:51:760,78
04-23 13:32:51.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:51.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:51:961,78
04-23 13:32:52.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:52.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:52:161,78
04-23 13:32:52.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:52.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:52:361,78
04-23 13:32:52.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:52.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:52:562,78
04-23 13:32:52.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:52.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:52:761,78
04-23 13:32:52.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:52.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:52:961,78
04-23 13:32:53.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:53.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:53:161,78
04-23 13:32:53.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:53.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:53:362,79
04-23 13:32:53.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:53.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:53:561,78
04-23 13:32:53.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:53.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:53:762,78
04-23 13:32:53.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:53.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:53:963,78
04-23 13:32:54.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:54.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:54:162,79
04-23 13:32:54.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:54.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:54:362,78
04-23 13:32:54.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:54.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:54:562,79
04-23 13:32:54.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:54.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:54:768,79
04-23 13:32:54.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:54.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:54:962,78
04-23 13:32:55.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:55.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:55:163,78
04-23 13:32:55.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:55.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:55:363,78
04-23 13:32:55.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:55.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:55:563,78
04-23 13:32:55.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:55.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:55:763,77
04-23 13:32:55.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:55.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:55:963,78
04-23 13:32:56.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:56.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:56:163,77
04-23 13:32:56.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:56.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:56:363,77
04-23 13:32:56.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:56.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:56:564,77
04-23 13:32:56.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:56.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:56:764,77
04-23 13:32:56.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:56.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:56:964,77
04-23 13:32:57.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:57.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:57:164,77
04-23 13:32:57.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:57.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:57:364,76
04-23 13:32:57.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:57.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:57:564,76
04-23 13:32:57.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:57.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:57:764,76
04-23 13:32:57.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:57.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:57:964,76
04-23 13:32:58.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:58.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:58:165,76
04-23 13:32:58.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:58.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:58:365,76
04-23 13:32:58.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:58.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:58:565,76
04-23 13:32:58.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:58.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:58:765,75
04-23 13:32:58.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:58.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:58:966,75
04-23 13:32:59.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:59.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:59:165,74
04-23 13:32:59.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:59.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:59:366,75
04-23 13:32:59.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:59.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:59:566,74
04-23 13:32:59.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:59.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:59:766,74
04-23 13:32:59.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:32:59.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:32:59:966,74
04-23 13:33:00.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:00.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:00:166,74
04-23 13:33:00.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:00.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:00:366,74
04-23 13:33:00.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:00.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:00:566,74
04-23 13:33:00.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:00.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:00:766,74
04-23 13:33:00.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:00.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:00:967,74
04-23 13:33:01.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:01.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:01:167,74
04-23 13:33:01.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:01.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:01:367,74
04-23 13:33:01.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:01.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:01:567,74
04-23 13:33:01.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:01.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:01:767,74
04-23 13:33:01.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:01.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:01:967,74
04-23 13:33:02.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:02.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:02:167,74
04-23 13:33:02.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:02.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:02:367,74
04-23 13:33:02.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:02.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:02:568,74
04-23 13:33:02.751+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:02.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:02:768,74
04-23 13:33:02.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:02.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:02:968,74
04-23 13:33:03.151+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:03.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:03:168,74
04-23 13:33:03.351+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:03.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:03:368,74
04-23 13:33:03.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:03.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:03:568,74
04-23 13:33:03.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:03.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:03:769,74
04-23 13:33:03.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:03.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:03:969,74
04-23 13:33:04.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:04.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:04:169,74
04-23 13:33:04.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:04.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:04:369,74
04-23 13:33:04.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:04.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:04:569,74
04-23 13:33:04.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:04.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:04:769,74
04-23 13:33:04.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:04.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:04:969,74
04-23 13:33:05.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:05.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:05:169,74
04-23 13:33:05.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:05.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:05:370,74
04-23 13:33:05.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:05.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:05:570,73
04-23 13:33:05.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:05.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:05:770,73
04-23 13:33:05.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:05.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:05:970,73
04-23 13:33:06.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:06.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:06:170,73
04-23 13:33:06.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:06.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:06:370,73
04-23 13:33:06.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:06.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:06:570,73
04-23 13:33:06.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:06.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:06:770,73
04-23 13:33:06.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:06.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:06:971,73
04-23 13:33:07.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:07.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:07:171,73
04-23 13:33:07.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:07.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:07:371,73
04-23 13:33:07.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:07.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:07:571,73
04-23 13:33:07.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:07.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:07:771,73
04-23 13:33:07.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:07.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:07:971,73
04-23 13:33:08.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:08.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:08:171,73
04-23 13:33:08.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:08.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:08:371,73
04-23 13:33:08.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:08.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:08:572,74
04-23 13:33:08.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:33:08.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:08.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:08.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:33:08.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:33:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:33:08.661+0200 I/utils   ( 9745): specific action
04-23 13:33:08.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:33:08.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:33:08.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:33:08.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:33:08.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:33:08.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:33:08.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:33:08.661+0200 I/httppostreq( 9745): internet available
04-23 13:33:08.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:33:08.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:33:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:33:08.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:33:08.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:33:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:08.691+0200 I/utils   ( 9742): specific action
04-23 13:33:08.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:33:08.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:33:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:08.701+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:08.701+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:08.701+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:33:08.701+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:33:08.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:08.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:08.711+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14748
04-23 13:33:08.711+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:33:08.751+0200 E/CAPI_APPFW_APPLICATION(14748): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:08.751+0200 E/CAPI_APPFW_APPLICATION(14748): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:08.751+0200 I/utils   (14748): trying to start service: es.ugr.frailty.accelerometer
04-23 13:33:08.751+0200 I/utils   (14748): es.ugr.frailty.accelerometer sensor supported
04-23 13:33:08.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:08.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14748
04-23 13:33:08.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(14748) type(svcapp) bg(0)
04-23 13:33:08.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14748) was created
04-23 13:33:08.781+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14748]
04-23 13:33:08.791+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14748)
04-23 13:33:08.791+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:33:08.791+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:08.791+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:08.791+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:08.791+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:33:08.791+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:33:08.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:08.801+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:08.811+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14761
04-23 13:33:08.811+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:33:08.851+0200 E/CAPI_APPFW_APPLICATION(14761): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:08.851+0200 E/CAPI_APPFW_APPLICATION(14761): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:08.851+0200 I/utils   (14761): specific action
04-23 13:33:08.851+0200 I/recorder(14761): obteniendo datos locales...
04-23 13:33:08.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14761
04-23 13:33:08.861+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(14761) type(svcapp) bg(0)
04-23 13:33:08.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:08.871+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14761]
04-23 13:33:08.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14748
04-23 13:33:08.881+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14761) was created
04-23 13:33:08.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:08.891+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14761)
04-23 13:33:08.891+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:33:08.921+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:08:772,74
04-23 13:33:08.921+0200 I/utils   (14748): es.ugr.frailty.accelerometer listener started
04-23 13:33:08.921+0200 I/accelerometer(14748): stopping es.ugr.frailty.accelerometer service
04-23 13:33:08.921+0200 E/CAPI_APPFW_APP_CONTROL(14748): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:33:08.921+0200 E/accelerometer(14748): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:33:08.921+0200 I/CAPI_APPFW_APPLICATION(14748): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:33:08.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:33:08.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:33:08.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:08.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14761
04-23 13:33:08.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:08.981+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:08.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:08:993,73
04-23 13:33:09.001+0200 I/recorder(14761): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:33:09.001+0200 I/recorder(14761): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:33:09.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:09.081+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14748
04-23 13:33:09.091+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:33:09.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:09.121+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:33:09.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:09.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14761
04-23 13:33:09.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:09.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:09.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:09:213,73
04-23 13:33:09.211+0200 I/accelerometer(14748): es.ugr.frailty.accelerometer listener destroyed
04-23 13:33:09.241+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1114761726563152448318
