S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15163
Date: 2018-04-23 13:35:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf70ec648, r1   = 0xf792e1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf792e1b8, r5   = 0x00012cd0
r6   = 0xf7940e88, r7   = 0xf70ec250
r8   = 0x000005e0, r9   = 0xf6bcf824
r10  = 0xf79269d8, fp   = 0x00000000
ip   = 0xf70eb030, sp   = 0xffe88090
lr   = 0xf702f5d0, pc   = 0xf702b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5416 KB
Buffers:     67916 KB
Cached:     172800 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7688 KB
VmRSS:        7684 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6766000 f6769000 r-xp /lib/libattr.so.1.1.0
f6772000 f6779000 r-xp /lib/libcrypt-2.13.so
f67a9000 f67ac000 r-xp /lib/libcap.so.2.21
f67b4000 f67b6000 r-xp /usr/lib/libiri.so
f67be000 f67db000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67e4000 f67e8000 r-xp /usr/lib/libsmack.so.1.0.0
f67f2000 f67f4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f67fc000 f6801000 r-xp /usr/lib/libffi.so.5.0.10
f6809000 f680a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6812000 f6814000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f681c000 f681e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6828000 f6838000 r-xp /lib/libresolv-2.13.so
f683c000 f6854000 r-xp /usr/lib/liblzma.so.5.0.3
f685c000 f685e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6866000 f6895000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f689e000 f68ad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68b6000 f68c0000 r-xp /usr/lib/libsensord-shared.so
f68c9000 f68fd000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6906000 f69d9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69e4000 f69fa000 r-xp /lib/libz.so.1.2.5
f6a02000 f6a08000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a11000 f6a86000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a90000 f6aaa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ab2000 f6ab8000 r-xp /lib/librt-2.13.so
f6ac1000 f6adf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ae9000 f6aea000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af2000 f6af7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6aff000 f6bcf000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6bd0000 f6bfa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c03000 f6c1a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c22000 f6c8b000 r-xp /lib/libm-2.13.so
f6c94000 f6d28000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d3b000 f6d40000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d48000 f6d4f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d57000 f6d81000 r-xp /usr/lib/libsensor.so.1.9.6
f6d8a000 f6e56000 r-xp /usr/lib/libxml2.so.2.7.8
f6e63000 f6e65000 r-xp /usr/lib/libiniparser.so.0
f6e6e000 f6e71000 r-xp /usr/lib/libbundle.so.0.1.22
f6e79000 f6e7f000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e87000 f6eaa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6eb2000 f6ef3000 r-xp /usr/lib/libeina.so.1.7.99
f6efc000 f6f13000 r-xp /usr/lib/libecore.so.1.7.99
f6f2a000 f6f33000 r-xp /usr/lib/libvconf.so.0.2.45
f6f3b000 f6f4f000 r-xp /lib/libpthread-2.13.so
f6f5a000 f6f67000 r-xp /usr/lib/libaul.so.0.1.0
f6f71000 f6f73000 r-xp /lib/libdl-2.13.so
f6f7c000 f6f87000 r-xp /lib/libunwind.so.8.0.1
f6fb4000 f6fbc000 r-xp /lib/libgcc_s-4.6.so.1
f6fbd000 f70e1000 r-xp /lib/libc-2.13.so
f70ef000 f70f1000 r-xp /usr/lib/libdlog.so.0.0.0
f70f9000 f7105000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f710e000 f7113000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f711b000 f711f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7128000 f712a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7133000 f7136000 r-xp /usr/lib/libappcore-agent.so.1.1
f7154000 f7171000 r-xp /lib/ld-2.13.so
f717a000 f717d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f717d000 f7181000 r-xp /usr/lib/libsys-assert.so
f791c000 f796a000 rw-p [heap]
ffe6a000 ffe8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15163)
Call Stack Count: 1
 0: (0xf702b9fc) [/lib/libc.so.6] + 0x6e9fc
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
): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:34:48.971+0200 I/recorder(15093): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:34:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:34:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15093
04-23 13:34:49.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:34:49.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:49.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:49:46,77
04-23 13:34:49.091+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11150937265631524483288
04-23 13:34:49.111+0200 W/AUL     (15100): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:34:49.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:34:49.111+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:34:49.111+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:34:49.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:34:49.111+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:34:49.111+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:34:49.111+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15093
04-23 13:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:34:49.111+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15093
04-23 13:34:49.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15093)
04-23 13:34:49.121+0200 E/AUL     (15100): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:34:49.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:34:49.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:34:49.201+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 13:34:49.201+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 13:34:49.201+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:34:49.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:49.231+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:34:49.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:49:239,77
04-23 13:34:49.281+0200 I/accelerometer(15080): es.ugr.frailty.accelerometer listener destroyed
04-23 13:34:49.411+0200 W/AUL     (15108): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:34:49.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:34:49.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:34:49.411+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:34:49.411+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:34:49.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:34:49.411+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:34:49.411+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:34:49.411+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:34:49.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:34:49.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15080
04-23 13:34:49.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:34:49.421+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15080
04-23 13:34:49.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15080)
04-23 13:34:49.431+0200 E/AUL     (15108): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:34:49.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:49.431+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:49:444,77
04-23 13:34:49.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:49.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:49:639,77
04-23 13:34:49.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:49.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:49:839,77
04-23 13:34:50.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:50.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:50:39,77
04-23 13:34:50.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:50.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:50:239,77
04-23 13:34:50.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:50.461+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:50:439,77
04-23 13:34:50.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:50.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:50:648,76
04-23 13:34:50.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:50.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:50:848,76
04-23 13:34:50.871+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:34:51.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:51.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:51:40,76
04-23 13:34:51.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:51.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:51:240,76
04-23 13:34:51.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:51.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:51:440,76
04-23 13:34:51.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:51.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:51:640,76
04-23 13:34:51.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:51.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:51:840,76
04-23 13:34:52.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:52.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:52:41,75
04-23 13:34:52.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:52.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:52:241,75
04-23 13:34:52.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:52.431+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:52:441,75
04-23 13:34:52.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:52.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:52:641,75
04-23 13:34:52.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:52.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:52:841,75
04-23 13:34:53.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:53.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:53:41,75
04-23 13:34:53.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:53.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:53:241,75
04-23 13:34:53.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:53.481+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:53:442,74
04-23 13:34:53.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:53.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:53:644,74
04-23 13:34:53.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:53.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:53:842,74
04-23 13:34:54.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:54.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:54:43,74
04-23 13:34:54.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:54.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:54:242,73
04-23 13:34:54.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:54.471+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:54:442,73
04-23 13:34:54.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:54.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:54:649,73
04-23 13:34:54.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:54.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:54:842,73
04-23 13:34:55.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:55.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:55:42,73
04-23 13:34:55.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:55.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:55:243,73
04-23 13:34:55.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:55.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:55:448,72
04-23 13:34:55.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:55.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:55:643,72
04-23 13:34:55.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:55.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:55:843,72
04-23 13:34:56.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:56.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:56:43,71
04-23 13:34:56.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:56.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:56:243,71
04-23 13:34:56.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:56.431+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:56:443,71
04-23 13:34:56.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:56.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:56:644,71
04-23 13:34:56.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:56.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:56:844,71
04-23 13:34:57.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:57.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:57:44,71
04-23 13:34:57.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:57.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:57:244,71
04-23 13:34:57.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:57.431+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:57:444,71
04-23 13:34:57.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:57.631+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:57:644,71
04-23 13:34:57.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:57.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:57:844,72
04-23 13:34:58.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:58.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:58:45,72
04-23 13:34:58.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:58.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:58:245,72
04-23 13:34:58.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:58.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:58:445,72
04-23 13:34:58.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:58.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:58:645,72
04-23 13:34:58.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:58.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:58:845,72
04-23 13:34:59.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:59.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:59:46,72
04-23 13:34:59.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:59.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:59:245,72
04-23 13:34:59.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:59.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:59:446,72
04-23 13:34:59.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:59.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:59:646,72
04-23 13:34:59.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:34:59.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:34:59:846,72
04-23 13:35:00.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:00.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:00:46,72
04-23 13:35:00.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:00.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:00:246,71
04-23 13:35:00.281+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 13:35:00.291+0200 W/SHealthService( 3087): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 13:35:00.301+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(pedometer_goal_achieve_percents) error
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 13:35:00.301+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(best_step_goal) error
04-23 13:35:00.301+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 13:35:00.311+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 13:35:00.331+0200 I/HealthDataService( 2940): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 13:35:00.341+0200 I/healthData( 3087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 13:35:00.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:00.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:00:446,71
04-23 13:35:00.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:00.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:00:646,71
04-23 13:35:00.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:00.841+0200 W/SHealthService( 3087): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 13:35:00.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:00:846,71
04-23 13:35:01.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:01.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:01:46,71
04-23 13:35:01.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:01.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:01:247,71
04-23 13:35:01.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:01.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:01:447,71
04-23 13:35:01.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:01.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:01:647,71
04-23 13:35:01.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:01.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:01:847,71
04-23 13:35:02.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:02.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:02:47,71
04-23 13:35:02.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:02.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:02:247,71
04-23 13:35:02.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:02.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:02:447,71
04-23 13:35:02.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:02.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:02:648,71
04-23 13:35:02.831+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:02.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:02:848,70
04-23 13:35:03.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:03.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:03:48,70
04-23 13:35:03.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:03.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:03:248,70
04-23 13:35:03.431+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:03.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:03:448,70
04-23 13:35:03.631+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:03.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:03:648,70
04-23 13:35:03.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:03.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:03:848,70
04-23 13:35:04.041+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:04.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:04:49,70
04-23 13:35:04.241+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:04.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:04:249,69
04-23 13:35:04.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:04.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:04:449,70
04-23 13:35:04.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:04.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:04:649,69
04-23 13:35:04.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:04.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:04:849,70
04-23 13:35:05.041+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:05.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:05:49,69
04-23 13:35:05.241+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:05.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:05:249,70
04-23 13:35:05.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:05.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:05:450,69
04-23 13:35:05.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:05.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:05:650,70
04-23 13:35:05.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:05.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:05:850,70
04-23 13:35:06.041+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:06.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:06:50,70
04-23 13:35:06.241+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:06.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:06:250,70
04-23 13:35:06.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:06.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:06:450,70
04-23 13:35:06.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:06.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:06:650,70
04-23 13:35:06.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:06.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:06:850,70
04-23 13:35:07.041+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:07.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:07:50,70
04-23 13:35:07.241+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:07.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:07:251,70
04-23 13:35:07.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:07.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:07:451,70
04-23 13:35:07.641+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:07.641+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:07:651,71
04-23 13:35:07.841+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:07.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:07:851,70
04-23 13:35:08.041+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:08.041+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:08:51,71
04-23 13:35:08.241+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:08.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:08:251,70
04-23 13:35:08.441+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:08.441+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:08:451,71
04-23 13:35:08.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:35:08.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:35:08.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:35:08.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:35:08.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:35:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:35:08.661+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:08.671+0200 I/utils   ( 9745): specific action
04-23 13:35:08.671+0200 I/httppostreq( 9745): internet connection check received
04-23 13:35:08.671+0200 I/httppostreq( 9745): internet connection != null
04-23 13:35:08.671+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:35:08.671+0200 I/httppostreq( 9745): internet connection type...
04-23 13:35:08.671+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:35:08.671+0200 I/httppostreq( 9745): internet available
04-23 13:35:08.671+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:35:08.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:35:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:35:08.681+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:35:08.681+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:35:08.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:35:08.691+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:35:08.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:35:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:35:08.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:35:08.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:35:08.691+0200 I/utils   ( 9742): specific action
04-23 13:35:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:35:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:35:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:35:08.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:35:08.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:35:08.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:35:08.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:35:08.711+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15151
04-23 13:35:08.711+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:35:08.711+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:08:675,70
04-23 13:35:08.751+0200 E/CAPI_APPFW_APPLICATION(15151): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:35:08.751+0200 E/CAPI_APPFW_APPLICATION(15151): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:35:08.751+0200 I/utils   (15151): trying to start service: es.ugr.frailty.accelerometer
04-23 13:35:08.751+0200 I/utils   (15151): es.ugr.frailty.accelerometer sensor supported
04-23 13:35:08.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15151
04-23 13:35:08.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15151) type(svcapp) bg(0)
04-23 13:35:08.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15151) was created
04-23 13:35:08.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15151)
04-23 13:35:08.771+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:35:08.771+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:35:08.771+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:35:08.771+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:35:08.771+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:35:08.771+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:35:08.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15151]
04-23 13:35:08.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:35:08.781+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:35:08.791+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:35:08.791+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15163
04-23 13:35:08.801+0200 I/utils   (15151): es.ugr.frailty.accelerometer listener started
04-23 13:35:08.801+0200 I/accelerometer(15151): stopping es.ugr.frailty.accelerometer service
04-23 13:35:08.801+0200 E/CAPI_APPFW_APP_CONTROL(15151): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:35:08.801+0200 E/accelerometer(15151): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:35:08.801+0200 I/CAPI_APPFW_APPLICATION(15151): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:35:08.841+0200 E/CAPI_APPFW_APPLICATION(15163): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:35:08.841+0200 E/CAPI_APPFW_APPLICATION(15163): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:35:08.841+0200 I/utils   (15163): specific action
04-23 13:35:08.841+0200 I/recorder(15163): obteniendo datos locales...
04-23 13:35:08.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15163
04-23 13:35:08.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15163) type(svcapp) bg(0)
04-23 13:35:08.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:35:08.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15151
04-23 13:35:08.851+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15163) was created
04-23 13:35:08.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:35:08.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:35:08.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:35:08.861+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:35:08.871+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15163]
04-23 13:35:08.871+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:35:08:865,71
04-23 13:35:08.911+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15163)
04-23 13:35:08.911+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:35:08.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:35:08.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15151
04-23 13:35:08.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:35:08.961+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15163
04-23 13:35:08.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:35:09.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:35:09.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:35:09.111+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:35:09.131+0200 I/recorder(15163): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:35:09.131+0200 I/recorder(15163): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:35:09.191+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115163726563152448330
