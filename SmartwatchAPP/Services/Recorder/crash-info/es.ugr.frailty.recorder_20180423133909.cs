S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15993
Date: 2018-04-23 13:39:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf76d4648, r1   = 0xf7ce11b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7ce11b8, r5   = 0x00012cd0
r6   = 0xf7cf3e88, r7   = 0xf76d4250
r8   = 0x000005e0, r9   = 0xf71b7824
r10  = 0xf7cd99d8, fp   = 0x00000000
ip   = 0xf76d3030, sp   = 0xffde0ce0
lr   = 0xf76175d0, pc   = 0xf76139fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5560 KB
Buffers:     31780 KB
Cached:     149540 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7728 KB
VmRSS:        7724 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6d4e000 f6d51000 r-xp /lib/libattr.so.1.1.0
f6d5a000 f6d61000 r-xp /lib/libcrypt-2.13.so
f6d91000 f6d94000 r-xp /lib/libcap.so.2.21
f6d9c000 f6d9e000 r-xp /usr/lib/libiri.so
f6da6000 f6dc3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6dcc000 f6dd0000 r-xp /usr/lib/libsmack.so.1.0.0
f6dda000 f6ddc000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6de4000 f6de9000 r-xp /usr/lib/libffi.so.5.0.10
f6df1000 f6df2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dfa000 f6dfc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e04000 f6e06000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e10000 f6e20000 r-xp /lib/libresolv-2.13.so
f6e24000 f6e3c000 r-xp /usr/lib/liblzma.so.5.0.3
f6e44000 f6e46000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e4e000 f6e7d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e86000 f6e95000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e9e000 f6ea8000 r-xp /usr/lib/libsensord-shared.so
f6eb1000 f6ee5000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6eee000 f6fc1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6fcc000 f6fe2000 r-xp /lib/libz.so.1.2.5
f6fea000 f6ff0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ff9000 f706e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7078000 f7092000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f709a000 f70a0000 r-xp /lib/librt-2.13.so
f70a9000 f70c7000 r-xp /usr/lib/libsystemd.so.0.4.0
f70d1000 f70d2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70da000 f70df000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e7000 f71b7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71b8000 f71e2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f71eb000 f7202000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f720a000 f7273000 r-xp /lib/libm-2.13.so
f727c000 f7310000 r-xp /usr/lib/libstdc++.so.6.0.16
f7323000 f7328000 r-xp /usr/lib/libctx-client.so.0.8.3
f7330000 f7337000 r-xp /usr/lib/libctx-shared.so.0.8.3
f733f000 f7369000 r-xp /usr/lib/libsensor.so.1.9.6
f7372000 f743e000 r-xp /usr/lib/libxml2.so.2.7.8
f744b000 f744d000 r-xp /usr/lib/libiniparser.so.0
f7456000 f7459000 r-xp /usr/lib/libbundle.so.0.1.22
f7461000 f7467000 r-xp /usr/lib/libappsvc.so.0.1.0
f746f000 f7492000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f749a000 f74db000 r-xp /usr/lib/libeina.so.1.7.99
f74e4000 f74fb000 r-xp /usr/lib/libecore.so.1.7.99
f7512000 f751b000 r-xp /usr/lib/libvconf.so.0.2.45
f7523000 f7537000 r-xp /lib/libpthread-2.13.so
f7542000 f754f000 r-xp /usr/lib/libaul.so.0.1.0
f7559000 f755b000 r-xp /lib/libdl-2.13.so
f7564000 f756f000 r-xp /lib/libunwind.so.8.0.1
f759c000 f75a4000 r-xp /lib/libgcc_s-4.6.so.1
f75a5000 f76c9000 r-xp /lib/libc-2.13.so
f76d7000 f76d9000 r-xp /usr/lib/libdlog.so.0.0.0
f76e1000 f76ed000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f6000 f76fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7703000 f7707000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7710000 f7712000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f771b000 f771e000 r-xp /usr/lib/libappcore-agent.so.1.1
f773c000 f7759000 r-xp /lib/ld-2.13.so
f7762000 f7765000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7765000 f7769000 r-xp /usr/lib/libsys-assert.so
f7ccf000 f7d1d000 rw-p [heap]
ffdc2000 ffde3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15993)
Call Stack Count: 1
 0: (0xf76139fc) [/lib/libc.so.6] + 0x6e9fc
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
 listener started
04-23 13:38:48.851+0200 I/accelerometer(15915): stopping es.ugr.frailty.accelerometer service
04-23 13:38:48.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15928
04-23 13:38:48.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15928) type(svcapp) bg(0)
04-23 13:38:48.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15915
04-23 13:38:48.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15915
04-23 13:38:48.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:48.891+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15928]
04-23 13:38:48.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:38:48.941+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15928
04-23 13:38:48.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:49.001+0200 E/CAPI_APPFW_APPLICATION(15928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:49.001+0200 E/CAPI_APPFW_APPLICATION(15928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:38:49.001+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15928) was created
04-23 13:38:49.011+0200 I/utils   (15928): specific action
04-23 13:38:49.011+0200 I/recorder(15928): obteniendo datos locales...
04-23 13:38:49.031+0200 I/recorder(15928): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:38:49.031+0200 I/recorder(15928): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:38:49.081+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11159287265631524483529
04-23 13:38:49.081+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15928)
04-23 13:38:49.081+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:38:49.081+0200 E/CAPI_APPFW_APP_CONTROL(15915): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:38:49.081+0200 E/accelerometer(15915): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:38:49.081+0200 I/CAPI_APPFW_APPLICATION(15915): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:38:49.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:38:49.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:38:49.101+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.111+0200 W/AUL     (15932): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:38:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:49.121+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:49.121+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:49.121+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:49.121+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:49.121+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:49.121+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:49.121+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15928
04-23 13:38:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:49.121+0200 E/AUL     (15932): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:49.131+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:118,86
04-23 13:38:49.131+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.131+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:144,86
04-23 13:38:49.161+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15928
04-23 13:38:49.161+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15928)
04-23 13:38:49.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:38:49.211+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.221+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 13:38:49.221+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 13:38:49.221+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(15928), proc(0)
04-23 13:38:49.221+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 13:38:49.221+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 13:38:49.221+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 13:38:49.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:227,86
04-23 13:38:49.231+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:49.241+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:38:49.321+0200 I/accelerometer(15915): es.ugr.frailty.accelerometer listener destroyed
04-23 13:38:49.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:399,86
04-23 13:38:49.461+0200 W/AUL     (15941): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:38:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:38:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:38:49.461+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:38:49.461+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:38:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:38:49.461+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:38:49.461+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:38:49.461+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:38:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:38:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15915
04-23 13:38:49.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:38:49.471+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15915
04-23 13:38:49.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15915)
04-23 13:38:49.481+0200 E/AUL     (15941): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:38:49.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:599,86
04-23 13:38:49.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:49.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:799,86
04-23 13:38:49.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:50.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:49:999,85
04-23 13:38:50.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:50.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:50:208,85
04-23 13:38:50.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:50.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:50:404,85
04-23 13:38:50.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:50.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:50:608,85
04-23 13:38:50.801+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:50.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:50:808,85
04-23 13:38:51.001+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:51:8,85
04-23 13:38:51.091+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:38:51.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:51:200,85
04-23 13:38:51.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:51:400,84
04-23 13:38:51.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:51:600,85
04-23 13:38:51.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:51:800,84
04-23 13:38:51.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:51.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:52:0,84
04-23 13:38:52.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:52.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:52:200,84
04-23 13:38:52.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:52.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:52:401,84
04-23 13:38:52.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:52.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:52:601,84
04-23 13:38:52.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:52.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:52:801,84
04-23 13:38:52.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:52.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:53:1,84
04-23 13:38:53.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:53.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:53:201,84
04-23 13:38:53.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:53.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:53:401,84
04-23 13:38:53.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:53.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:53:601,84
04-23 13:38:53.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:53.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:53:802,84
04-23 13:38:53.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:53.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:54:2,83
04-23 13:38:54.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:54.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:54:203,83
04-23 13:38:54.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:54.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:54:402,83
04-23 13:38:54.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:54.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:54:608,83
04-23 13:38:54.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:54.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:54:802,83
04-23 13:38:54.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:54.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:55:2,83
04-23 13:38:55.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:55.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:55:202,83
04-23 13:38:55.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:55.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:55:402,83
04-23 13:38:55.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:55.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:55:603,82
04-23 13:38:55.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:55.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:55:803,82
04-23 13:38:55.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:55.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:56:3,82
04-23 13:38:56.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:56.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:56:203,82
04-23 13:38:56.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:56.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:56:404,82
04-23 13:38:56.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:56.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:56:604,82
04-23 13:38:56.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:56.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:56:804,82
04-23 13:38:56.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:57:5,82
04-23 13:38:57.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:57:205,82
04-23 13:38:57.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:57:405,82
04-23 13:38:57.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:57:604,82
04-23 13:38:57.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.791+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:57:804,82
04-23 13:38:57.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:57.991+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:58:4,82
04-23 13:38:58.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:58.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:58:204,82
04-23 13:38:58.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:58.391+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:58:405,82
04-23 13:38:58.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:58.591+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:58:605,82
04-23 13:38:58.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:58.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:58:805,81
04-23 13:38:58.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:59.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:59:5,81
04-23 13:38:59.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:59.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:59:206,81
04-23 13:38:59.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:59.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:59:405,81
04-23 13:38:59.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:59.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:59:605,81
04-23 13:38:59.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:38:59.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:38:59:805,81
04-23 13:38:59.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:00.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:00:6,81
04-23 13:39:00.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:00.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:00:206,81
04-23 13:39:00.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:00.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:00:406,81
04-23 13:39:00.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:00.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:00:606,81
04-23 13:39:00.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:00.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:00:806,81
04-23 13:39:00.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:01.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:01:6,81
04-23 13:39:01.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:01.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:01:206,81
04-23 13:39:01.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:01.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:01:407,81
04-23 13:39:01.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:01.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:01:607,80
04-23 13:39:01.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:01.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:01:807,81
04-23 13:39:01.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:02.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:02:7,80
04-23 13:39:02.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:02.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:02:207,80
04-23 13:39:02.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:02.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:02:407,80
04-23 13:39:02.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:02.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:02:607,80
04-23 13:39:02.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:02.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:02:808,80
04-23 13:39:02.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:03.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:03:8,80
04-23 13:39:03.191+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:03.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:03:208,80
04-23 13:39:03.391+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:03.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:03:408,80
04-23 13:39:03.591+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:03.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:03:608,80
04-23 13:39:03.791+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:03.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:03:808,80
04-23 13:39:03.991+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:04.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:04:8,80
04-23 13:39:04.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:04.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:04:209,80
04-23 13:39:04.401+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:04.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:04:409,79
04-23 13:39:04.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:04.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:04:609,79
04-23 13:39:04.801+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:04.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:04:809,79
04-23 13:39:05.001+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:05.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:05:9,79
04-23 13:39:05.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:05.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:05:209,79
04-23 13:39:05.401+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:05.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:05:409,79
04-23 13:39:05.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:05.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:05:609,78
04-23 13:39:05.801+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:05.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:05:809,78
04-23 13:39:06.001+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:06.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:06:10,78
04-23 13:39:06.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:06.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:06:210,78
04-23 13:39:06.401+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:06.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:06:410,78
04-23 13:39:06.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:06.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:06:610,78
04-23 13:39:06.801+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:06.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:06:810,78
04-23 13:39:07.001+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:07.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:07:10,78
04-23 13:39:07.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:07.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:07:210,77
04-23 13:39:07.401+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:07.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:07:411,77
04-23 13:39:07.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:07.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:07:611,77
04-23 13:39:07.801+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:07.801+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:07:811,77
04-23 13:39:08.001+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:08.001+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:08:11,77
04-23 13:39:08.201+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:08.201+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:08:211,77
04-23 13:39:08.401+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:08.401+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:08:411,77
04-23 13:39:08.601+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:08.601+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:08:611,76
04-23 13:39:08.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:39:08.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:08.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:08.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:39:08.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:39:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:39:08.661+0200 I/utils   ( 9745): specific action
04-23 13:39:08.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:39:08.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:39:08.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:39:08.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:39:08.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:39:08.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:39:08.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:39:08.661+0200 I/httppostreq( 9745): internet available
04-23 13:39:08.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:39:08.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:39:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:39:08.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:39:08.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:39:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:08.691+0200 I/utils   ( 9742): specific action
04-23 13:39:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:08.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:39:08.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:39:08.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:39:08.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:08.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:08.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15981
04-23 13:39:08.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:39:08.721+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:39:08.741+0200 E/CAPI_APPFW_APPLICATION(15981): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:08.741+0200 E/CAPI_APPFW_APPLICATION(15981): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:08.741+0200 I/utils   (15981): trying to start service: es.ugr.frailty.accelerometer
04-23 13:39:08.751+0200 I/utils   (15981): es.ugr.frailty.accelerometer sensor supported
04-23 13:39:08.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15981
04-23 13:39:08.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15981) type(svcapp) bg(0)
04-23 13:39:08.751+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15981) was created
04-23 13:39:08.761+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15981]
04-23 13:39:08.761+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15981)
04-23 13:39:08.771+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:39:08.771+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:39:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:08.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15981
04-23 13:39:08.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:08.821+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:08.831+0200 I/utils   (15981): es.ugr.frailty.accelerometer listener started
04-23 13:39:08.841+0200 I/accelerometer(15981): stopping es.ugr.frailty.accelerometer service
04-23 13:39:08.841+0200 E/CAPI_APPFW_APP_CONTROL(15981): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:39:08.841+0200 E/accelerometer(15981): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:39:08.841+0200 I/CAPI_APPFW_APPLICATION(15981): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:39:08.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:39:08.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.841+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.841+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.841+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.841+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.841+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.841+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.841+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.851+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.851+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:39:08.851+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.851+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.851+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.851+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:39:08.851+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.851+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.851+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:08:845,76
04-23 13:39:08.861+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.861+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.861+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:39:08.861+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:08.861+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:08.861+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:08.861+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:08.861+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:39:08.861+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:39:08.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:08.861+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:08.871+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15993
04-23 13:39:08.871+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:39:08.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15993
04-23 13:39:08.921+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15993) type(svcapp) bg(0)
04-23 13:39:08.951+0200 E/CAPI_APPFW_APPLICATION(15993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:08.961+0200 E/CAPI_APPFW_APPLICATION(15993): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:08.961+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15993) was created
04-23 13:39:08.971+0200 I/utils   (15993): specific action
04-23 13:39:08.971+0200 I/recorder(15993): obteniendo datos locales...
04-23 13:39:08.991+0200 I/recorder(15993): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:39:08.991+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:39:09.001+0200 I/recorder(15993): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:39:09.011+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15993]
04-23 13:39:09.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15993
04-23 13:39:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:09.111+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15993)
04-23 13:39:09.111+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:39:09.141+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115993726563152448354
