S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 14830
Date: 2018-04-23 13:33:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7424648, r1   = 0xf7bc21b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7bc21b8, r5   = 0x00012cd0
r6   = 0xf7bd4e88, r7   = 0xf7424250
r8   = 0x000005e0, r9   = 0xf6f07824
r10  = 0xf7bba9d8, fp   = 0x00000000
ip   = 0xf7423030, sp   = 0xffdf1730
lr   = 0xf73675d0, pc   = 0xf73639fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5036 KB
Buffers:     70564 KB
Cached:     178884 KB
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
f6a9e000 f6aa1000 r-xp /lib/libattr.so.1.1.0
f6aaa000 f6ab1000 r-xp /lib/libcrypt-2.13.so
f6ae1000 f6ae4000 r-xp /lib/libcap.so.2.21
f6aec000 f6aee000 r-xp /usr/lib/libiri.so
f6af6000 f6b13000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b1c000 f6b20000 r-xp /usr/lib/libsmack.so.1.0.0
f6b2a000 f6b2c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b34000 f6b39000 r-xp /usr/lib/libffi.so.5.0.10
f6b41000 f6b42000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b4a000 f6b4c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b54000 f6b56000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b60000 f6b70000 r-xp /lib/libresolv-2.13.so
f6b74000 f6b8c000 r-xp /usr/lib/liblzma.so.5.0.3
f6b94000 f6b96000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b9e000 f6bcd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bd6000 f6be5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bee000 f6bf8000 r-xp /usr/lib/libsensord-shared.so
f6c01000 f6c35000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c3e000 f6d11000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d1c000 f6d32000 r-xp /lib/libz.so.1.2.5
f6d3a000 f6d40000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d49000 f6dbe000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dc8000 f6de2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dea000 f6df0000 r-xp /lib/librt-2.13.so
f6df9000 f6e17000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e21000 f6e22000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e2a000 f6e2f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e37000 f6f07000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f08000 f6f32000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f3b000 f6f52000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f5a000 f6fc3000 r-xp /lib/libm-2.13.so
f6fcc000 f7060000 r-xp /usr/lib/libstdc++.so.6.0.16
f7073000 f7078000 r-xp /usr/lib/libctx-client.so.0.8.3
f7080000 f7087000 r-xp /usr/lib/libctx-shared.so.0.8.3
f708f000 f70b9000 r-xp /usr/lib/libsensor.so.1.9.6
f70c2000 f718e000 r-xp /usr/lib/libxml2.so.2.7.8
f719b000 f719d000 r-xp /usr/lib/libiniparser.so.0
f71a6000 f71a9000 r-xp /usr/lib/libbundle.so.0.1.22
f71b1000 f71b7000 r-xp /usr/lib/libappsvc.so.0.1.0
f71bf000 f71e2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71ea000 f722b000 r-xp /usr/lib/libeina.so.1.7.99
f7234000 f724b000 r-xp /usr/lib/libecore.so.1.7.99
f7262000 f726b000 r-xp /usr/lib/libvconf.so.0.2.45
f7273000 f7287000 r-xp /lib/libpthread-2.13.so
f7292000 f729f000 r-xp /usr/lib/libaul.so.0.1.0
f72a9000 f72ab000 r-xp /lib/libdl-2.13.so
f72b4000 f72bf000 r-xp /lib/libunwind.so.8.0.1
f72ec000 f72f4000 r-xp /lib/libgcc_s-4.6.so.1
f72f5000 f7419000 r-xp /lib/libc-2.13.so
f7427000 f7429000 r-xp /usr/lib/libdlog.so.0.0.0
f7431000 f743d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7446000 f744b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7453000 f7457000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7460000 f7462000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f746b000 f746e000 r-xp /usr/lib/libappcore-agent.so.1.1
f748c000 f74a9000 r-xp /lib/ld-2.13.so
f74b2000 f74b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f74b5000 f74b9000 r-xp /usr/lib/libsys-assert.so
f7bb0000 f7bfe000 rw-p [heap]
ffdd3000 ffdf4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14830)
Call Stack Count: 1
 0: (0xf73639fc) [/lib/libc.so.6] + 0x6e9fc
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
( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
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
04-23 13:33:09.241+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11147617265631524483189
04-23 13:33:09.251+0200 W/AUL     (14768): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:33:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:33:09.251+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:09.251+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:09.251+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:09.251+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:09.251+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:09.251+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:33:09.251+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:33:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:33:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14761
04-23 13:33:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:33:09.261+0200 E/AUL     (14768): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:33:09.261+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14761
04-23 13:33:09.261+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14761)
04-23 13:33:09.351+0200 W/AUL     (14772): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:33:09.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:33:09.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:09.351+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:09.351+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:09.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:09.351+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:09.351+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:33:09.351+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:33:09.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:33:09.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14748
04-23 13:33:09.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:33:09.351+0200 E/AUL     (14772): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:33:09.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14748
04-23 13:33:09.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14748)
04-23 13:33:09.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:09.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:09:373,73
04-23 13:33:09.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:09.561+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:09:572,73
04-23 13:33:09.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:09.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:09:772,73
04-23 13:33:09.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:09.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:09:973,73
04-23 13:33:10.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:10.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:10:173,73
04-23 13:33:10.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:10.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:10:373,73
04-23 13:33:10.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:10.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:10:573,73
04-23 13:33:10.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:10.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:10:778,73
04-23 13:33:10.931+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:33:10.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:10.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:10:978,73
04-23 13:33:11.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:11.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:11:173,73
04-23 13:33:11.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:11.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:11:374,72
04-23 13:33:11.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:11.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:11:574,72
04-23 13:33:11.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:11.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:11:774,72
04-23 13:33:11.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:11.961+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:11:975,72
04-23 13:33:12.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:12.161+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:12:174,72
04-23 13:33:12.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:12.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:12:374,72
04-23 13:33:12.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:12.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:12:574,73
04-23 13:33:12.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:12.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:12:774,73
04-23 13:33:12.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:12.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:12:974,73
04-23 13:33:13.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:13.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:13:175,73
04-23 13:33:13.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:13.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:13:375,73
04-23 13:33:13.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:13.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:13:575,73
04-23 13:33:13.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:13.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:13:775,72
04-23 13:33:13.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:13.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:13:976,72
04-23 13:33:14.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:14.211+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:14:176,72
04-23 13:33:14.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:14.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:14:375,72
04-23 13:33:14.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:14.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:14:576,72
04-23 13:33:14.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:14.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:14:776,72
04-23 13:33:14.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:14:976,73
04-23 13:33:15.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:15:176,72
04-23 13:33:15.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:15:376,73
04-23 13:33:15.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:15:576,73
04-23 13:33:15.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:15:776,73
04-23 13:33:15.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:15.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:15:977,73
04-23 13:33:16.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:16.181+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:16:177,73
04-23 13:33:16.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:16.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:16:377,73
04-23 13:33:16.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:16.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:16:577,73
04-23 13:33:16.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:16.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:16:793,73
04-23 13:33:16.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:16.981+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:16:977,73
04-23 13:33:17.161+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:17.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:17:177,74
04-23 13:33:17.361+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:17.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:17:378,74
04-23 13:33:17.561+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:17.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:17:578,74
04-23 13:33:17.761+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:17.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:17:778,74
04-23 13:33:17.961+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:17.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:17:978,74
04-23 13:33:18.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:18.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:18:179,74
04-23 13:33:18.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:18.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:18:380,74
04-23 13:33:18.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:18.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:18:579,75
04-23 13:33:18.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:18.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:18:779,74
04-23 13:33:18.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:18.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:18:980,74
04-23 13:33:19.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:19.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:19:181,74
04-23 13:33:19.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:19.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:19:382,75
04-23 13:33:19.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:19.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:19:579,74
04-23 13:33:19.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:19.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:19:779,75
04-23 13:33:19.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:19.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:19:979,74
04-23 13:33:20.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:20.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:20:179,74
04-23 13:33:20.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:20.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:20:379,75
04-23 13:33:20.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:20.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:20:580,75
04-23 13:33:20.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:20.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:20:780,75
04-23 13:33:20.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:20.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:20:980,75
04-23 13:33:21.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:21.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:21:180,75
04-23 13:33:21.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:21.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:21:380,75
04-23 13:33:21.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:21.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:21:580,75
04-23 13:33:21.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:21.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:21:780,76
04-23 13:33:21.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:21.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:21:980,76
04-23 13:33:22.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:22.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:22:181,76
04-23 13:33:22.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:22.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:22:381,76
04-23 13:33:22.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:22.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:22:581,76
04-23 13:33:22.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:22.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:22:781,77
04-23 13:33:22.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:22.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:22:981,77
04-23 13:33:23.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:23.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:23:181,77
04-23 13:33:23.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:23.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:23:382,77
04-23 13:33:23.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:23.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:23:582,77
04-23 13:33:23.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:23.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:23:782,77
04-23 13:33:23.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:23.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:23:982,77
04-23 13:33:24.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:24.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:24:182,77
04-23 13:33:24.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:24.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:24:382,77
04-23 13:33:24.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:24.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:24:582,76
04-23 13:33:24.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:24.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:24:782,76
04-23 13:33:24.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:24.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:24:982,76
04-23 13:33:25.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:25.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:25:183,76
04-23 13:33:25.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:25.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:25:383,76
04-23 13:33:25.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:25.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:25:583,76
04-23 13:33:25.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:25.781+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:25:783,75
04-23 13:33:25.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:25.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:25:983,75
04-23 13:33:26.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:26.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:26:183,75
04-23 13:33:26.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:26.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:26:383,75
04-23 13:33:26.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:26.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:26:584,75
04-23 13:33:26.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:26.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:26:784,74
04-23 13:33:26.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:26.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:26:984,74
04-23 13:33:27.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:27.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:27:184,74
04-23 13:33:27.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:27.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:27:384,74
04-23 13:33:27.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:27.571+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:27:584,74
04-23 13:33:27.771+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:27.771+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:27:784,74
04-23 13:33:27.971+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:27.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:27:984,74
04-23 13:33:28.171+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:28.171+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:28:185,74
04-23 13:33:28.371+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:28.371+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:28:385,74
04-23 13:33:28.571+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:28.581+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:28:585,74
04-23 13:33:28.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:33:28.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:28.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:33:28.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:33:28.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:33:28.661+0200 I/utils   ( 9745): specific action
04-23 13:33:28.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:33:28.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:33:28.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:33:28.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:33:28.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:33:28.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:33:28.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:33:28.661+0200 I/httppostreq( 9745): internet available
04-23 13:33:28.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:33:28.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:28.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:33:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:33:28.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:33:28.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:33:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:28.691+0200 I/utils   ( 9742): specific action
04-23 13:33:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:28.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:33:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:33:28.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:33:28.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:33:28.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:33:28.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:28.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:28.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14816
04-23 13:33:28.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:33:28.741+0200 E/CAPI_APPFW_APPLICATION(14816): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:28.741+0200 E/CAPI_APPFW_APPLICATION(14816): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:28.741+0200 I/utils   (14816): trying to start service: es.ugr.frailty.accelerometer
04-23 13:33:28.741+0200 I/utils   (14816): es.ugr.frailty.accelerometer sensor supported
04-23 13:33:28.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14816
04-23 13:33:28.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(14816) type(svcapp) bg(0)
04-23 13:33:28.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14816) was created
04-23 13:33:28.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14816]
04-23 13:33:28.771+0200 I/utils   (14816): es.ugr.frailty.accelerometer listener started
04-23 13:33:28.771+0200 I/accelerometer(14816): stopping es.ugr.frailty.accelerometer service
04-23 13:33:28.771+0200 E/CAPI_APPFW_APP_CONTROL(14816): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:33:28.771+0200 E/accelerometer(14816): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:33:28.771+0200 I/CAPI_APPFW_APPLICATION(14816): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:33:28.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:33:28.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:33:28.781+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:28.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:28.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14816
04-23 13:33:28.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:28.841+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:28:797,73
04-23 13:33:28.911+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14816)
04-23 13:33:28.911+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:33:28.911+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:33:28.911+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:33:28.911+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:33:28.911+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:33:28.911+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:33:28.921+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:33:28.931+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:33:28.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:33:28.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:33:28.941+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14830
04-23 13:33:28.941+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:33:28.991+0200 E/CAPI_APPFW_APPLICATION(14830): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:28.991+0200 E/CAPI_APPFW_APPLICATION(14830): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:33:28.991+0200 I/utils   (14830): specific action
04-23 13:33:28.991+0200 I/recorder(14830): obteniendo datos locales...
04-23 13:33:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14830
04-23 13:33:28.991+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(14830) type(svcapp) bg(0)
04-23 13:33:29.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:29.011+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14830]
04-23 13:33:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14816
04-23 13:33:29.011+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14830) was created
04-23 13:33:29.021+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14830)
04-23 13:33:29.021+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:33:29.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:29.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:29.031+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14830
04-23 13:33:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:29.081+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:29:31,73
04-23 13:33:29.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:33:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14830
04-23 13:33:29.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:33:29.181+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:33:29.191+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:33:29:196,73
04-23 13:33:29.191+0200 I/accelerometer(14816): es.ugr.frailty.accelerometer listener destroyed
04-23 13:33:29.191+0200 I/recorder(14830): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:33:29.191+0200 I/recorder(14830): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:33:29.241+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1114830726563152448320
