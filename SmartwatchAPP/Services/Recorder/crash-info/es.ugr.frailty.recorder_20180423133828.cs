S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15855
Date: 2018-04-23 13:38:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf72da648, r1   = 0xf77271b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77271b8, r5   = 0x00012cd0
r6   = 0xf7739e88, r7   = 0xf72da250
r8   = 0x000005e0, r9   = 0xf6dbd824
r10  = 0xf771f9d8, fp   = 0x00000000
ip   = 0xf72d9030, sp   = 0xffe05bd0
lr   = 0xf721d5d0, pc   = 0xf72199fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      4412 KB
Buffers:     40380 KB
Cached:     154476 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7780 KB
VmRSS:        7776 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6954000 f6957000 r-xp /lib/libattr.so.1.1.0
f6960000 f6967000 r-xp /lib/libcrypt-2.13.so
f6997000 f699a000 r-xp /lib/libcap.so.2.21
f69a2000 f69a4000 r-xp /usr/lib/libiri.so
f69ac000 f69c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69d2000 f69d6000 r-xp /usr/lib/libsmack.so.1.0.0
f69e0000 f69e2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69ea000 f69ef000 r-xp /usr/lib/libffi.so.5.0.10
f69f7000 f69f8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a00000 f6a02000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a0a000 f6a0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a16000 f6a26000 r-xp /lib/libresolv-2.13.so
f6a2a000 f6a42000 r-xp /usr/lib/liblzma.so.5.0.3
f6a4a000 f6a4c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a54000 f6a83000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a8c000 f6a9b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6aa4000 f6aae000 r-xp /usr/lib/libsensord-shared.so
f6ab7000 f6aeb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6af4000 f6bc7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bd2000 f6be8000 r-xp /lib/libz.so.1.2.5
f6bf0000 f6bf6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bff000 f6c74000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c7e000 f6c98000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ca0000 f6ca6000 r-xp /lib/librt-2.13.so
f6caf000 f6ccd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cd7000 f6cd8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ce0000 f6ce5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ced000 f6dbd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dbe000 f6de8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6df1000 f6e08000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e10000 f6e79000 r-xp /lib/libm-2.13.so
f6e82000 f6f16000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f29000 f6f2e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f36000 f6f3d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f45000 f6f6f000 r-xp /usr/lib/libsensor.so.1.9.6
f6f78000 f7044000 r-xp /usr/lib/libxml2.so.2.7.8
f7051000 f7053000 r-xp /usr/lib/libiniparser.so.0
f705c000 f705f000 r-xp /usr/lib/libbundle.so.0.1.22
f7067000 f706d000 r-xp /usr/lib/libappsvc.so.0.1.0
f7075000 f7098000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70a0000 f70e1000 r-xp /usr/lib/libeina.so.1.7.99
f70ea000 f7101000 r-xp /usr/lib/libecore.so.1.7.99
f7118000 f7121000 r-xp /usr/lib/libvconf.so.0.2.45
f7129000 f713d000 r-xp /lib/libpthread-2.13.so
f7148000 f7155000 r-xp /usr/lib/libaul.so.0.1.0
f715f000 f7161000 r-xp /lib/libdl-2.13.so
f716a000 f7175000 r-xp /lib/libunwind.so.8.0.1
f71a2000 f71aa000 r-xp /lib/libgcc_s-4.6.so.1
f71ab000 f72cf000 r-xp /lib/libc-2.13.so
f72dd000 f72df000 r-xp /usr/lib/libdlog.so.0.0.0
f72e7000 f72f3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72fc000 f7301000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7309000 f730d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7316000 f7318000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7321000 f7324000 r-xp /usr/lib/libappcore-agent.so.1.1
f7342000 f735f000 r-xp /lib/ld-2.13.so
f7368000 f736b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f736b000 f736f000 r-xp /usr/lib/libsys-assert.so
f7715000 f7763000 rw-p [heap]
ffde7000 ffe08000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15855)
Call Stack Count: 1
 0: (0xf72199fc) [/lib/libc.so.6] + 0x6e9fc
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
ore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:08.761+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:08.761+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:08.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:08.761+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:38:08.761+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:38:08.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:08:772,77
04-23 13:38:08.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15781]
04-23 13:38:08.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:08.771+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:08.781+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15792
04-23 13:38:08.791+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:08.831+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15792
04-23 13:38:08.831+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15792) type(svcapp) bg(0)
04-23 13:38:08.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:08.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15781
04-23 13:38:08.851+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15792)
04-23 13:38:08.851+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:38:08.871+0200 E/CAPI_APPFW_APPLICATION(15792): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:08.871+0200 E/CAPI_APPFW_APPLICATION(15792): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:08.871+0200 I/utils   (15792): specific action
04-23 13:38:08.871+0200 I/recorder(15792): obteniendo datos locales...
04-23 13:38:08.871+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15792]
04-23 13:38:08.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:08.921+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15781
04-23 13:38:08.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:08.961+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15792) was created
04-23 13:38:08.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:08.981+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15792
04-23 13:38:08.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:09.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:31,76
04-23 13:38:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:09.081+0200 I/recorder(15792): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:38:09.081+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:09.091+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15792
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:38:09.101+0200 I/recorder(15792): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:38:09.151+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11157927265631524483489
04-23 13:38:09.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:09.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:175,77
04-23 13:38:09.181+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:09.191+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:09.221+0200 W/AUL     (15801): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:38:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:09.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:09.231+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:09.231+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:09.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:09.231+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:09.231+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:09.231+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15792
04-23 13:38:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:09.231+0200 E/AUL     (15801): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:09.231+0200 I/accelerometer(15781): es.ugr.frailty.accelerometer listener destroyed
04-23 13:38:09.231+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15792
04-23 13:38:09.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15792)
04-23 13:38:09.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:384,76
04-23 13:38:09.401+0200 W/AUL     (15807): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:38:09.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:09.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:09.411+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:09.411+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:09.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:09.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:09.411+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:09.411+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:09.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:09.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15781
04-23 13:38:09.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:09.421+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15781
04-23 13:38:09.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15781)
04-23 13:38:09.421+0200 E/AUL     (15807): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:09.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:572,76
04-23 13:38:09.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:772,75
04-23 13:38:09.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:09.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:09:972,76
04-23 13:38:10.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:10.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:10:172,75
04-23 13:38:10.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:10.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:10:373,75
04-23 13:38:10.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:10.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:10:573,75
04-23 13:38:10.761+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:38:10.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:10.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:10:775,75
04-23 13:38:10.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:10.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:10:973,75
04-23 13:38:11.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:11.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:11:173,75
04-23 13:38:11.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:11.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:11:373,75
04-23 13:38:11.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:11.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:11:573,75
04-23 13:38:11.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:11.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:11:774,74
04-23 13:38:11.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:11.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:11:974,75
04-23 13:38:12.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:12.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:12:174,74
04-23 13:38:12.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:12.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:12:374,75
04-23 13:38:12.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:12.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:12:575,75
04-23 13:38:12.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:12.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:12:774,75
04-23 13:38:12.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:12.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:12:974,75
04-23 13:38:13.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:13.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:13:176,75
04-23 13:38:13.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:13.361+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:13:375,75
04-23 13:38:13.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:13.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:13:575,75
04-23 13:38:13.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:13.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:13:775,76
04-23 13:38:13.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:13.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:13:975,75
04-23 13:38:14.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:14.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:14:176,75
04-23 13:38:14.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:14.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:14:378,75
04-23 13:38:14.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:14.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:14:575,75
04-23 13:38:14.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:14.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:14:775,75
04-23 13:38:14.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:14:976,75
04-23 13:38:15.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:15:178,75
04-23 13:38:15.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:15:378,75
04-23 13:38:15.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:15:576,74
04-23 13:38:15.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:15:776,75
04-23 13:38:15.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:15.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:15:976,74
04-23 13:38:16.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:16.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:16:177,74
04-23 13:38:16.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:16.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:16:377,74
04-23 13:38:16.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:16.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:16:577,75
04-23 13:38:16.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:16.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:16:778,75
04-23 13:38:16.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:16.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:16:977,75
04-23 13:38:17.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:17.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:17:177,75
04-23 13:38:17.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:17.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:17:377,75
04-23 13:38:17.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:17.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:17:577,74
04-23 13:38:17.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:17.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:17:779,74
04-23 13:38:17.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:17.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:17:979,74
04-23 13:38:18.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:18.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:18:179,74
04-23 13:38:18.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:18.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:18:379,74
04-23 13:38:18.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:18.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:18:579,74
04-23 13:38:18.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:18.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:18:781,74
04-23 13:38:18.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:18.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:18:978,73
04-23 13:38:19.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:19.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:19:179,73
04-23 13:38:19.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:19.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:19:379,73
04-23 13:38:19.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:19.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:19:579,73
04-23 13:38:19.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:19.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:19:779,73
04-23 13:38:19.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:19.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:19:979,73
04-23 13:38:20.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:20.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:20:179,73
04-23 13:38:20.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:20.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:20:379,73
04-23 13:38:20.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:20.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:20:579,73
04-23 13:38:20.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:20.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:20:779,73
04-23 13:38:20.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:20.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:20:980,73
04-23 13:38:21.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:21.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:21:180,73
04-23 13:38:21.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:21.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:21:380,73
04-23 13:38:21.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:21.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:21:580,73
04-23 13:38:21.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:21.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:21:780,73
04-23 13:38:21.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:21.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:21:980,73
04-23 13:38:22.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:22.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:22:180,72
04-23 13:38:22.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:22.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:22:381,72
04-23 13:38:22.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:22.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:22:581,72
04-23 13:38:22.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:22.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:22:781,72
04-23 13:38:22.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:22.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:22:981,72
04-23 13:38:23.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:23.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:23:181,72
04-23 13:38:23.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:23.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:23:381,72
04-23 13:38:23.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:23.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:23:581,72
04-23 13:38:23.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:23.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:23:781,72
04-23 13:38:23.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:23.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:23:982,72
04-23 13:38:24.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:24.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:24:182,72
04-23 13:38:24.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:24.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:24:382,72
04-23 13:38:24.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:24.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:24:582,72
04-23 13:38:24.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:24.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:24:782,73
04-23 13:38:24.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:24.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:24:982,73
04-23 13:38:25.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:25.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:25:182,73
04-23 13:38:25.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:25.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:25:383,74
04-23 13:38:25.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:25.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:25:583,74
04-23 13:38:25.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:25.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:25:783,74
04-23 13:38:25.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:25.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:25:983,74
04-23 13:38:26.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:26.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:26:183,74
04-23 13:38:26.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:26.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:26:383,74
04-23 13:38:26.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:26.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:26:583,74
04-23 13:38:26.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:26.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:26:783,74
04-23 13:38:26.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:26.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:26:984,74
04-23 13:38:27.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:27.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:27:184,74
04-23 13:38:27.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:27.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:27:384,74
04-23 13:38:27.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:27.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:27:584,74
04-23 13:38:27.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:27.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:27:784,73
04-23 13:38:27.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:27.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:27:984,73
04-23 13:38:28.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:28.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:28:184,73
04-23 13:38:28.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:28.381+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:28:385,73
04-23 13:38:28.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:28.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:28:585,73
04-23 13:38:28.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:38:28.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:28.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:38:28.661+0200 I/utils   ( 9745): specific action
04-23 13:38:28.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:38:28.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:38:28.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:38:28.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:38:28.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:38:28.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:38:28.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:38:28.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:38:28.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:38:28.661+0200 I/httppostreq( 9745): internet available
04-23 13:38:28.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:38:28.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:28.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:38:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:38:28.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:38:28.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:38:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:28.691+0200 I/utils   ( 9742): specific action
04-23 13:38:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:38:28.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:38:28.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:38:28.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:38:28.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:28.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:28.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15847
04-23 13:38:28.701+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:38:28.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:28.751+0200 E/CAPI_APPFW_APPLICATION(15847): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.751+0200 E/CAPI_APPFW_APPLICATION(15847): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.751+0200 I/utils   (15847): trying to start service: es.ugr.frailty.accelerometer
04-23 13:38:28.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15847
04-23 13:38:28.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15847) type(svcapp) bg(0)
04-23 13:38:28.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15847) was created
04-23 13:38:28.761+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15847)
04-23 13:38:28.761+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:38:28.761+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.761+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.761+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.761+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.761+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.761+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15847]
04-23 13:38:28.771+0200 I/utils   (15847): es.ugr.frailty.accelerometer sensor supported
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:28.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:38:28.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:38:28.771+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:38:28.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:38:28.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:38:28.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:38:28.791+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15855
04-23 13:38:28.791+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:38:28.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:28.831+0200 E/CAPI_APPFW_APPLICATION(15855): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.831+0200 E/CAPI_APPFW_APPLICATION(15855): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:28.831+0200 I/utils   (15855): specific action
04-23 13:38:28.831+0200 I/recorder(15855): obteniendo datos locales...
04-23 13:38:28.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15855
04-23 13:38:28.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15855) type(svcapp) bg(0)
04-23 13:38:28.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15847
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15855) was created
04-23 13:38:28.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:28.861+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15855]
04-23 13:38:28.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:28.911+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15855
04-23 13:38:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:28.971+0200 I/recorder(15855): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:38:28.971+0200 I/recorder(15855): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:38:29.021+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115855726563152448350
