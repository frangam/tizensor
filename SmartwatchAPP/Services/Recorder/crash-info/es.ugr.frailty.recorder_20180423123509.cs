S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 20995
Date: 2018-04-23 12:35:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7434648, r1   = 0xf7c351b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7c351b8, r5   = 0x00012cd0
r6   = 0xf7c47e88, r7   = 0xf7434250
r8   = 0x000005d8, r9   = 0xf6f17824
r10  = 0xf7c2d9d8, fp   = 0x00000000
ip   = 0xf7433030, sp   = 0xff8c5398
lr   = 0xf73775d0, pc   = 0xf73739fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11696 KB
Buffers:     70448 KB
Cached:     189876 KB
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
f6aae000 f6ab1000 r-xp /lib/libattr.so.1.1.0
f6aba000 f6ac1000 r-xp /lib/libcrypt-2.13.so
f6af1000 f6af4000 r-xp /lib/libcap.so.2.21
f6afc000 f6afe000 r-xp /usr/lib/libiri.so
f6b06000 f6b23000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b2c000 f6b30000 r-xp /usr/lib/libsmack.so.1.0.0
f6b3a000 f6b3c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b44000 f6b49000 r-xp /usr/lib/libffi.so.5.0.10
f6b51000 f6b52000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b5a000 f6b5c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b64000 f6b66000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b70000 f6b80000 r-xp /lib/libresolv-2.13.so
f6b84000 f6b9c000 r-xp /usr/lib/liblzma.so.5.0.3
f6ba4000 f6ba6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bae000 f6bdd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6be6000 f6bf5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bfe000 f6c08000 r-xp /usr/lib/libsensord-shared.so
f6c11000 f6c45000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c4e000 f6d21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d2c000 f6d42000 r-xp /lib/libz.so.1.2.5
f6d4a000 f6d50000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d59000 f6dce000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dd8000 f6df2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dfa000 f6e00000 r-xp /lib/librt-2.13.so
f6e09000 f6e27000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e31000 f6e32000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e3a000 f6e3f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e47000 f6f17000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f18000 f6f42000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f4b000 f6f62000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f6a000 f6fd3000 r-xp /lib/libm-2.13.so
f6fdc000 f7070000 r-xp /usr/lib/libstdc++.so.6.0.16
f7083000 f7088000 r-xp /usr/lib/libctx-client.so.0.8.3
f7090000 f7097000 r-xp /usr/lib/libctx-shared.so.0.8.3
f709f000 f70c9000 r-xp /usr/lib/libsensor.so.1.9.6
f70d2000 f719e000 r-xp /usr/lib/libxml2.so.2.7.8
f71ab000 f71ad000 r-xp /usr/lib/libiniparser.so.0
f71b6000 f71b9000 r-xp /usr/lib/libbundle.so.0.1.22
f71c1000 f71c7000 r-xp /usr/lib/libappsvc.so.0.1.0
f71cf000 f71f2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71fa000 f723b000 r-xp /usr/lib/libeina.so.1.7.99
f7244000 f725b000 r-xp /usr/lib/libecore.so.1.7.99
f7272000 f727b000 r-xp /usr/lib/libvconf.so.0.2.45
f7283000 f7297000 r-xp /lib/libpthread-2.13.so
f72a2000 f72af000 r-xp /usr/lib/libaul.so.0.1.0
f72b9000 f72bb000 r-xp /lib/libdl-2.13.so
f72c4000 f72cf000 r-xp /lib/libunwind.so.8.0.1
f72fc000 f7304000 r-xp /lib/libgcc_s-4.6.so.1
f7305000 f7429000 r-xp /lib/libc-2.13.so
f7437000 f7439000 r-xp /usr/lib/libdlog.so.0.0.0
f7441000 f744d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7456000 f745b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7463000 f7467000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7470000 f7472000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f747b000 f747e000 r-xp /usr/lib/libappcore-agent.so.1.1
f749c000 f74b9000 r-xp /lib/ld-2.13.so
f74c2000 f74c5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f74c5000 f74c9000 r-xp /usr/lib/libsys-assert.so
f7c23000 f7c71000 rw-p [heap]
ff8a7000 ff8c8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20995)
Call Stack Count: 1
 0: (0xf73739fc) [/lib/libc.so.6] + 0x6e9fc
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
ONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:34:49.001+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:34:49.001+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection type...
04-23 12:34:49.001+0200 I/httppostreq(20587): internet connection type 1
04-23 12:34:49.001+0200 I/httppostreq(20587): internet available
04-23 12:34:49.001+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:34:49.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:49.031+0200 I/utils   (20584): specific action
04-23 12:34:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:49.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:34:49.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:49.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20856
04-23 12:34:49.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:49.051+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:49.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20856
04-23 12:34:49.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20856) type(svcapp) bg(0)
04-23 12:34:49.101+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20856)
04-23 12:34:49.101+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:34:49.101+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:49.101+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 0
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:49.101+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:49.101+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:49.101+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 1
04-23 12:34:49.101+0200 E/servicemanager(20584): deleting timer 2
04-23 12:34:49.101+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:49.111+0200 E/CAPI_APPFW_APPLICATION(20856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.111+0200 E/CAPI_APPFW_APPLICATION(20856): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20856]
04-23 12:34:49.111+0200 I/utils   (20856): trying to start service: es.ugr.frailty.accelerometer
04-23 12:34:49.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:49.111+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20589
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20856) was created
04-23 12:34:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:49.121+0200 I/utils   (20856): es.ugr.frailty.accelerometer sensor supported
04-23 12:34:49.141+0200 I/utils   (20856): es.ugr.frailty.accelerometer listener started
04-23 12:34:49.141+0200 I/accelerometer(20856): stopping es.ugr.frailty.accelerometer service
04-23 12:34:49.141+0200 E/CAPI_APPFW_APP_CONTROL(20856): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:34:49.141+0200 E/accelerometer(20856): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:34:49.141+0200 I/CAPI_APPFW_APPLICATION(20856): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20856
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:49.141+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:49.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20589), cmd(0)
04-23 12:34:49.151+0200 I/utils   (20589): specific action
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales...
04-23 12:34:49.151+0200 I/recorder(20589): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 12:34:49.151+0200 I/recorder(20589): obteniendo datos locales, DATA: SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:49.151+0200 I/recorder(20589): SM-R760,23/04/2018,12:34:44:738,-0.0
04-23 12:34:49.151+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20589)
04-23 12:34:49.151+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:34:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20856
04-23 12:34:49.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:49.261+0200 W/AUL     (20872): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20589
04-23 12:34:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:49.271+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20589
04-23 12:34:49.271+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20589)
04-23 12:34:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 06205897265631524479689
04-23 12:34:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:49.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:49.341+0200 I/accelerometer(20856): es.ugr.frailty.accelerometer listener destroyed
04-23 12:34:49.501+0200 W/AUL     (20884): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20856
04-23 12:34:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:49.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20856
04-23 12:34:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20856)
04-23 12:34:51.141+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:34:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:34:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:34:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:34:59.001+0200 I/utils   (20587): specific action
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:34:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:34:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:34:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:34:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:34:59.011+0200 I/httppostreq(20587): internet available
04-23 12:34:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:34:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:34:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:34:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:34:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:34:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:59.041+0200 I/utils   (20584): specific action
04-23 12:34:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:34:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:34:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:34:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:34:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:34:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20926
04-23 12:34:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20926
04-23 12:34:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20926) type(svcapp) bg(0)
04-23 12:34:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20926)
04-23 12:34:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:34:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:34:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:34:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:34:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:34:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:34:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:34:59.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:34:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20926]
04-23 12:34:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:34:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20928
04-23 12:34:59.141+0200 E/CAPI_APPFW_APPLICATION(20926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.141+0200 E/CAPI_APPFW_APPLICATION(20926): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.141+0200 I/utils   (20926): trying to start service: es.ugr.frailty.accelerometer
04-23 12:34:59.141+0200 I/utils   (20926): es.ugr.frailty.accelerometer sensor supported
04-23 12:34:59.151+0200 I/utils   (20926): es.ugr.frailty.accelerometer listener started
04-23 12:34:59.151+0200 I/accelerometer(20926): stopping es.ugr.frailty.accelerometer service
04-23 12:34:59.161+0200 E/CAPI_APPFW_APP_CONTROL(20926): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.161+0200 E/accelerometer(20926): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:34:59.161+0200 I/CAPI_APPFW_APPLICATION(20926): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:34:59.181+0200 E/CAPI_APPFW_APPLICATION(20928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.181+0200 E/CAPI_APPFW_APPLICATION(20928): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:34:59.181+0200 I/utils   (20928): specific action
04-23 12:34:59.181+0200 I/recorder(20928): obteniendo datos locales...
04-23 12:34:59.201+0200 I/recorder(20928): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:34:59.201+0200 I/recorder(20928): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:34:59.251+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20928
04-23 12:34:59.251+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(20928) type(svcapp) bg(0)
04-23 12:34:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:59.261+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11209287265631524479699
04-23 12:34:59.261+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:34:59.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20928]
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20926
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20926) was created
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20928) was created
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:34:59.271+0200 E/RESOURCED( 2551): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/20928/oom_score_adj failed
04-23 12:34:59.271+0200 E/RESOURCED( 2551): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 20928
04-23 12:34:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:59.271+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:34:59.271+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:34:59.271+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(20928), proc(0)
04-23 12:34:59.271+0200 E/AUL     ( 2880): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:34:59.271+0200 E/CAPI_APPFW_APP_MANAGER( 2880): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:34:59.271+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:34:59.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:59.281+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20928)
04-23 12:34:59.291+0200 W/AUL     (20942): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:34:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20928
04-23 12:34:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:59.291+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20928
04-23 12:34:59.291+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20928)
04-23 12:34:59.301+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:34:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:34:59.341+0200 I/accelerometer(20926): es.ugr.frailty.accelerometer listener destroyed
04-23 12:34:59.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:34:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20926
04-23 12:34:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:34:59.361+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:34:59.361+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:34:59.361+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(20928), proc(0)
04-23 12:34:59.361+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:34:59.361+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:34:59.361+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:34:59.471+0200 W/AUL     (20952): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:34:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:34:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:34:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 20926
04-23 12:34:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:34:59.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20926
04-23 12:34:59.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20926)
04-23 12:35:00.311+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 12:35:00.311+0200 W/SHealthService( 3087): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 12:35:00.321+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(pedometer_goal_achieve_percents) error
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 12:35:00.321+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3087): preference.c: preference_get_int(1132) > preference_get_int(3087) : key(best_step_goal) error
04-23 12:35:00.321+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 12:35:00.331+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 12:35:00.351+0200 I/HealthDataService( 2940): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 12:35:00.361+0200 I/healthData( 3087): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 12:35:00.491+0200 W/SHealthService( 3087): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 12:35:01.271+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:35:04.101+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 4
04-23 12:35:04.101+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524479614, curr_wall_time = 1524479704
04-23 12:35:04.101+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 90 seconds
04-23 12:35:04.101+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 87 seconds
04-23 12:35:04.101+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 80, charging remaining time = 29 minutes
04-23 12:35:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:35:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:35:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:35:09.011+0200 I/utils   (20587): specific action
04-23 12:35:09.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:35:09.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:35:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:35:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:35:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:35:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:35:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:35:09.011+0200 I/httppostreq(20587): internet available
04-23 12:35:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:35:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:35:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:35:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:35:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:35:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:09.031+0200 I/utils   (20584): specific action
04-23 12:35:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:35:09.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:35:09.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:35:09.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:35:09.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:35:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:09.061+0200 E/RESOURCED( 2551): proc-main.c: proc_create_app_info(722) > prelaunched app was not gone to launch state, appid(es.ugr.frailty.recorder)
04-23 12:35:09.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:09.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20992
04-23 12:35:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20992
04-23 12:35:09.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20992) type(svcapp) bg(0)
04-23 12:35:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20992)
04-23 12:35:09.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:35:09.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:09.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:09.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:35:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:35:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:35:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:35:09.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:35:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:35:09.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:35:09.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:35:09.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20992]
04-23 12:35:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20995
04-23 12:35:09.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:35:09.141+0200 E/CAPI_APPFW_APPLICATION(20992): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:09.141+0200 E/CAPI_APPFW_APPLICATION(20992): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:09.151+0200 I/utils   (20992): trying to start service: es.ugr.frailty.accelerometer
04-23 12:35:09.151+0200 I/utils   (20992): es.ugr.frailty.accelerometer sensor supported
04-23 12:35:09.161+0200 I/utils   (20992): es.ugr.frailty.accelerometer listener started
04-23 12:35:09.161+0200 I/accelerometer(20992): stopping es.ugr.frailty.accelerometer service
04-23 12:35:09.161+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:35:09.161+0200 E/accelerometer(20992): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:35:09.161+0200 I/CAPI_APPFW_APPLICATION(20992): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:35:09.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20995
04-23 12:35:09.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(20995) type(svcapp) bg(0)
04-23 12:35:09.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
04-23 12:35:09.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20992) was created
04-23 12:35:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:35:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:35:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:09.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20995)
04-23 12:35:09.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:35:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
04-23 12:35:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:09.221+0200 E/CAPI_APPFW_APPLICATION(20995): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:09.221+0200 E/CAPI_APPFW_APPLICATION(20995): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:35:09.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20995) was created
04-23 12:35:09.221+0200 I/utils   (20995): specific action
04-23 12:35:09.221+0200 I/recorder(20995): obteniendo datos locales...
04-23 12:35:09.241+0200 I/recorder(20995): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:09.241+0200 I/recorder(20995): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:09.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20995]
04-23 12:35:09.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:09.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:09.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
04-23 12:35:09.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:09.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:09.311+0200 I/accelerometer(20992): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:35:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
04-23 12:35:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:35:09.321+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1120995726563152447970
