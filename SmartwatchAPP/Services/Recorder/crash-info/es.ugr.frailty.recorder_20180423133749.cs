S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15725
Date: 2018-04-23 13:37:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf757e648, r1   = 0xf7e041b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7e041b8, r5   = 0x00012cd0
r6   = 0xf7e16e88, r7   = 0xf757e250
r8   = 0x000005e0, r9   = 0xf7061824
r10  = 0xf7dfc9d8, fp   = 0x00000000
ip   = 0xf757d030, sp   = 0xffc68850
lr   = 0xf74c15d0, pc   = 0xf74bd9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5220 KB
Buffers:     49164 KB
Cached:     157304 KB
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
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6bf8000 f6bfb000 r-xp /lib/libattr.so.1.1.0
f6c04000 f6c0b000 r-xp /lib/libcrypt-2.13.so
f6c3b000 f6c3e000 r-xp /lib/libcap.so.2.21
f6c46000 f6c48000 r-xp /usr/lib/libiri.so
f6c50000 f6c6d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c76000 f6c7a000 r-xp /usr/lib/libsmack.so.1.0.0
f6c84000 f6c86000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c8e000 f6c93000 r-xp /usr/lib/libffi.so.5.0.10
f6c9b000 f6c9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ca4000 f6ca6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cae000 f6cb0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cba000 f6cca000 r-xp /lib/libresolv-2.13.so
f6cce000 f6ce6000 r-xp /usr/lib/liblzma.so.5.0.3
f6cee000 f6cf0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cf8000 f6d27000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d30000 f6d3f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d48000 f6d52000 r-xp /usr/lib/libsensord-shared.so
f6d5b000 f6d8f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d98000 f6e6b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e76000 f6e8c000 r-xp /lib/libz.so.1.2.5
f6e94000 f6e9a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ea3000 f6f18000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f22000 f6f3c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f44000 f6f4a000 r-xp /lib/librt-2.13.so
f6f53000 f6f71000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f7b000 f6f7c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f84000 f6f89000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f91000 f7061000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7062000 f708c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7095000 f70ac000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b4000 f711d000 r-xp /lib/libm-2.13.so
f7126000 f71ba000 r-xp /usr/lib/libstdc++.so.6.0.16
f71cd000 f71d2000 r-xp /usr/lib/libctx-client.so.0.8.3
f71da000 f71e1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71e9000 f7213000 r-xp /usr/lib/libsensor.so.1.9.6
f721c000 f72e8000 r-xp /usr/lib/libxml2.so.2.7.8
f72f5000 f72f7000 r-xp /usr/lib/libiniparser.so.0
f7300000 f7303000 r-xp /usr/lib/libbundle.so.0.1.22
f730b000 f7311000 r-xp /usr/lib/libappsvc.so.0.1.0
f7319000 f733c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7344000 f7385000 r-xp /usr/lib/libeina.so.1.7.99
f738e000 f73a5000 r-xp /usr/lib/libecore.so.1.7.99
f73bc000 f73c5000 r-xp /usr/lib/libvconf.so.0.2.45
f73cd000 f73e1000 r-xp /lib/libpthread-2.13.so
f73ec000 f73f9000 r-xp /usr/lib/libaul.so.0.1.0
f7403000 f7405000 r-xp /lib/libdl-2.13.so
f740e000 f7419000 r-xp /lib/libunwind.so.8.0.1
f7446000 f744e000 r-xp /lib/libgcc_s-4.6.so.1
f744f000 f7573000 r-xp /lib/libc-2.13.so
f7581000 f7583000 r-xp /usr/lib/libdlog.so.0.0.0
f758b000 f7597000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75a0000 f75a5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75ad000 f75b1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75ba000 f75bc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f75c5000 f75c8000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e6000 f7603000 r-xp /lib/ld-2.13.so
f760c000 f760f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f760f000 f7613000 r-xp /usr/lib/libsys-assert.so
f7df2000 f7e40000 rw-p [heap]
ffc4a000 ffc6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15725)
Call Stack Count: 1
 0: (0xf74bd9fc) [/lib/libc.so.6] + 0x6e9fc
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
k.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:37:28.831+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15658
04-23 13:37:28.891+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15658
04-23 13:37:28.891+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15658) type(svcapp) bg(0)
04-23 13:37:28.891+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15658)
04-23 13:37:28.891+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:37:28.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:28.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15646
04-23 13:37:28.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:28.951+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:28.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:28:960,70
04-23 13:37:28.951+0200 E/CAPI_APPFW_APPLICATION(15658): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:28.951+0200 E/CAPI_APPFW_APPLICATION(15658): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:28.971+0200 I/utils   (15658): specific action
04-23 13:37:28.971+0200 I/recorder(15658): obteniendo datos locales...
04-23 13:37:28.971+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15658) was created
04-23 13:37:28.971+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15658]
04-23 13:37:28.991+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:37:29.001+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:37:29.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:29.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15658
04-23 13:37:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:29.021+0200 I/recorder(15658): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:37:29.021+0200 I/recorder(15658): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:37:29.031+0200 I/accelerometer(15646): es.ugr.frailty.accelerometer listener destroyed
04-23 13:37:29.071+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11156587265631524483449
04-23 13:37:29.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:29.101+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:37:29.101+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 13:37:29.111+0200 W/AUL     (15666): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:37:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:37:29.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:29.111+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:29.111+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:29.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:29.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:29.111+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:37:29.111+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:37:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:37:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15658
04-23 13:37:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:37:29.121+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15658
04-23 13:37:29.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15658)
04-23 13:37:29.121+0200 E/AUL     (15666): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:37:29.121+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 13:37:29.131+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:29.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:29:146,70
04-23 13:37:29.181+0200 W/AUL     (15667): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:37:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:37:29.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:29.191+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:29.191+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:29.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:29.191+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:29.191+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:37:29.191+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:37:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:37:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15646
04-23 13:37:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:37:29.191+0200 E/AUL     (15667): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:37:29.201+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15646
04-23 13:37:29.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15646)
04-23 13:37:29.331+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:29.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:29:345,69
04-23 13:37:29.531+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:29.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:29:545,70
04-23 13:37:29.731+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:29.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:29:745,69
04-23 13:37:29.931+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:29.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:29:946,69
04-23 13:37:30.131+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:30.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:30:146,69
04-23 13:37:30.331+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:30.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:30:346,69
04-23 13:37:30.531+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:30.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:30:546,69
04-23 13:37:30.731+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:30.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:30:746,69
04-23 13:37:30.821+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:37:30.931+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:30.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:30:946,69
04-23 13:37:31.131+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:31.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:31:146,70
04-23 13:37:31.331+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:31.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:31:346,70
04-23 13:37:31.531+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:31.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:31:547,70
04-23 13:37:31.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:31.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:31:749,70
04-23 13:37:31.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:31.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:31:949,70
04-23 13:37:32.131+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:32.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:32:147,70
04-23 13:37:32.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:32.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:32:349,70
04-23 13:37:32.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:32.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:32:549,70
04-23 13:37:32.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:32.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:32:749,70
04-23 13:37:32.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:32.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:32:949,70
04-23 13:37:33.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:33.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:33:149,70
04-23 13:37:33.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:33.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:33:349,71
04-23 13:37:33.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:33.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:33:549,71
04-23 13:37:33.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:33.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:33:749,71
04-23 13:37:33.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:33.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:33:949,71
04-23 13:37:34.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:34.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:34:150,71
04-23 13:37:34.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:34.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:34:349,71
04-23 13:37:34.551+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:34.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:34:558,71
04-23 13:37:34.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:34.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:34:749,71
04-23 13:37:34.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:34.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:34:949,71
04-23 13:37:35.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:35.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:35:149,71
04-23 13:37:35.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:35.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:35:349,72
04-23 13:37:35.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:35.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:35:549,72
04-23 13:37:35.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:35.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:35:749,72
04-23 13:37:35.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:35.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:35:950,72
04-23 13:37:36.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:36.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:36:150,72
04-23 13:37:36.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:36.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:36:350,72
04-23 13:37:36.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:36.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:36:550,72
04-23 13:37:36.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:36.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:36:750,72
04-23 13:37:36.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:36.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:36:950,72
04-23 13:37:37.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:37.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:37:150,72
04-23 13:37:37.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:37.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:37:351,72
04-23 13:37:37.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:37.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:37:551,72
04-23 13:37:37.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:37.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:37:751,72
04-23 13:37:37.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:37.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:37:951,72
04-23 13:37:38.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:38.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:38:151,73
04-23 13:37:38.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:38.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:38:351,73
04-23 13:37:38.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:38.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:38:551,73
04-23 13:37:38.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:38.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:38:751,73
04-23 13:37:38.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:38.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:38:952,73
04-23 13:37:39.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:39.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:39:152,73
04-23 13:37:39.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:39.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:39:352,73
04-23 13:37:39.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:39.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:39:552,73
04-23 13:37:39.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:39.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:39:752,73
04-23 13:37:39.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:39.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:39:952,73
04-23 13:37:40.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:40.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:40:153,73
04-23 13:37:40.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:40.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:40:353,73
04-23 13:37:40.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:40.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:40:553,73
04-23 13:37:40.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:40.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:40:754,73
04-23 13:37:40.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:40.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:40:954,74
04-23 13:37:41.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:41.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:41:155,74
04-23 13:37:41.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:41.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:41:353,74
04-23 13:37:41.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:41.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:41:553,74
04-23 13:37:41.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:41.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:41:754,74
04-23 13:37:41.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:41.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:41:954,74
04-23 13:37:42.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:42.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:42:154,73
04-23 13:37:42.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:42.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:42:354,73
04-23 13:37:42.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:42.541+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:42:554,73
04-23 13:37:42.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:42.741+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:42:754,73
04-23 13:37:42.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:42.941+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:42:954,74
04-23 13:37:43.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:43.141+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:43:154,74
04-23 13:37:43.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:43.341+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:43:355,74
04-23 13:37:43.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:43.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:43:555,74
04-23 13:37:43.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:43.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:43:755,74
04-23 13:37:43.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:43.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:43:955,74
04-23 13:37:44.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:44.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:44:156,74
04-23 13:37:44.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:44.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:44:355,74
04-23 13:37:44.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:44.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:44:555,75
04-23 13:37:44.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:44.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:44:755,75
04-23 13:37:44.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:44.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:44:956,75
04-23 13:37:45.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:45.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:45:156,75
04-23 13:37:45.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:45.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:45:356,75
04-23 13:37:45.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:45.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:45:556,75
04-23 13:37:45.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:45.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:45:756,75
04-23 13:37:45.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:45.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:45:956,76
04-23 13:37:46.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:46.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:46:156,75
04-23 13:37:46.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:46.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:46:357,75
04-23 13:37:46.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:46.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:46:557,76
04-23 13:37:46.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:46.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:46:757,76
04-23 13:37:46.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:46.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:46:957,76
04-23 13:37:47.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:47.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:47:157,76
04-23 13:37:47.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:47.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:47:357,76
04-23 13:37:47.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:47.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:47:557,77
04-23 13:37:47.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:47.751+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:47:757,77
04-23 13:37:47.941+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:47.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:47:958,78
04-23 13:37:48.141+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:48.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:48:158,78
04-23 13:37:48.341+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:48.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:48:358,78
04-23 13:37:48.541+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:48.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:48:558,78
04-23 13:37:48.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:37:48.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:37:48.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:37:48.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:37:48.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:37:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:37:48.661+0200 I/utils   ( 9745): specific action
04-23 13:37:48.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:37:48.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:37:48.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:37:48.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:37:48.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:37:48.661+0200 I/httppostreq( 9745): internet available
04-23 13:37:48.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:37:48.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:37:48.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:37:48.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:37:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:37:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:37:48.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:37:48.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:37:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:37:48.691+0200 I/utils   ( 9742): specific action
04-23 13:37:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:37:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:37:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:37:48.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:37:48.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:37:48.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:37:48.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:37:48.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:37:48.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:37:48.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15713
04-23 13:37:48.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:37:48.741+0200 E/CAPI_APPFW_APPLICATION(15713): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:48.741+0200 E/CAPI_APPFW_APPLICATION(15713): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:48.741+0200 I/utils   (15713): trying to start service: es.ugr.frailty.accelerometer
04-23 13:37:48.741+0200 I/utils   (15713): es.ugr.frailty.accelerometer sensor supported
04-23 13:37:48.741+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:48.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15713
04-23 13:37:48.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15713) type(svcapp) bg(0)
04-23 13:37:48.761+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15713]
04-23 13:37:48.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15713) was created
04-23 13:37:48.771+0200 I/utils   (15713): es.ugr.frailty.accelerometer listener started
04-23 13:37:48.771+0200 I/accelerometer(15713): stopping es.ugr.frailty.accelerometer service
04-23 13:37:48.771+0200 E/CAPI_APPFW_APP_CONTROL(15713): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:37:48.771+0200 E/accelerometer(15713): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:37:48.771+0200 I/CAPI_APPFW_APPLICATION(15713): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:37:48.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:37:48.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:37:48.781+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15713)
04-23 13:37:48.781+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:37:48.781+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:37:48.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:37:48.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:37:48.781+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:37:48.781+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:37:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:37:48.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:37:48.801+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:37:48.801+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15725
04-23 13:37:48.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15725
04-23 13:37:48.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15725) type(svcapp) bg(0)
04-23 13:37:48.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15713
04-23 13:37:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:48.901+0200 E/CAPI_APPFW_APPLICATION(15725): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:48.901+0200 E/CAPI_APPFW_APPLICATION(15725): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:37:48.901+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15725]
04-23 13:37:48.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15725
04-23 13:37:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:48.971+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15725) was created
04-23 13:37:48.971+0200 I/utils   (15725): specific action
04-23 13:37:48.971+0200 I/recorder(15725): obteniendo datos locales...
04-23 13:37:48.991+0200 I/recorder(15725): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:37:48.991+0200 I/recorder(15725): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:37:49.031+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15725)
04-23 13:37:49.031+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:37:49.061+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:48:758,78
04-23 13:37:49.061+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:49.071+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:37:49.081+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:37:49.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:49.101+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15713
04-23 13:37:49.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:49.151+0200 I/accelerometer(15713): es.ugr.frailty.accelerometer listener destroyed
04-23 13:37:49.151+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:49:76,78
04-23 13:37:49.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:37:49.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:37:49:170,78
04-23 13:37:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:37:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15725
04-23 13:37:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:37:49.251+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115725726563152448346
