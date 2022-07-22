S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 23286
Date: 2018-04-23 12:40:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7500648, r1   = 0xf7cc21b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cc21b8, r5   = 0x00012cd0
r6   = 0xf7cd4e88, r7   = 0xf7500250
r8   = 0x000005d8, r9   = 0xf6fe3824
r10  = 0xf7cba9d8, fp   = 0x00000000
ip   = 0xf74ff030, sp   = 0xffc9d178
lr   = 0xf74435d0, pc   = 0xf743f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8364 KB
Buffers:     71120 KB
Cached:     191272 KB
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
f6b7a000 f6b7d000 r-xp /lib/libattr.so.1.1.0
f6b86000 f6b8d000 r-xp /lib/libcrypt-2.13.so
f6bbd000 f6bc0000 r-xp /lib/libcap.so.2.21
f6bc8000 f6bca000 r-xp /usr/lib/libiri.so
f6bd2000 f6bef000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bf8000 f6bfc000 r-xp /usr/lib/libsmack.so.1.0.0
f6c06000 f6c08000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c10000 f6c15000 r-xp /usr/lib/libffi.so.5.0.10
f6c1d000 f6c1e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c26000 f6c28000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c30000 f6c32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c3c000 f6c4c000 r-xp /lib/libresolv-2.13.so
f6c50000 f6c68000 r-xp /usr/lib/liblzma.so.5.0.3
f6c70000 f6c72000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c7a000 f6ca9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cb2000 f6cc1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cca000 f6cd4000 r-xp /usr/lib/libsensord-shared.so
f6cdd000 f6d11000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d1a000 f6ded000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6df8000 f6e0e000 r-xp /lib/libz.so.1.2.5
f6e16000 f6e1c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e25000 f6e9a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ea4000 f6ebe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ec6000 f6ecc000 r-xp /lib/librt-2.13.so
f6ed5000 f6ef3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6efd000 f6efe000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f06000 f6f0b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f13000 f6fe3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fe4000 f700e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7017000 f702e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7036000 f709f000 r-xp /lib/libm-2.13.so
f70a8000 f713c000 r-xp /usr/lib/libstdc++.so.6.0.16
f714f000 f7154000 r-xp /usr/lib/libctx-client.so.0.8.3
f715c000 f7163000 r-xp /usr/lib/libctx-shared.so.0.8.3
f716b000 f7195000 r-xp /usr/lib/libsensor.so.1.9.6
f719e000 f726a000 r-xp /usr/lib/libxml2.so.2.7.8
f7277000 f7279000 r-xp /usr/lib/libiniparser.so.0
f7282000 f7285000 r-xp /usr/lib/libbundle.so.0.1.22
f728d000 f7293000 r-xp /usr/lib/libappsvc.so.0.1.0
f729b000 f72be000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f72c6000 f7307000 r-xp /usr/lib/libeina.so.1.7.99
f7310000 f7327000 r-xp /usr/lib/libecore.so.1.7.99
f733e000 f7347000 r-xp /usr/lib/libvconf.so.0.2.45
f734f000 f7363000 r-xp /lib/libpthread-2.13.so
f736e000 f737b000 r-xp /usr/lib/libaul.so.0.1.0
f7385000 f7387000 r-xp /lib/libdl-2.13.so
f7390000 f739b000 r-xp /lib/libunwind.so.8.0.1
f73c8000 f73d0000 r-xp /lib/libgcc_s-4.6.so.1
f73d1000 f74f5000 r-xp /lib/libc-2.13.so
f7503000 f7505000 r-xp /usr/lib/libdlog.so.0.0.0
f750d000 f7519000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7522000 f7527000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f752f000 f7533000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f753c000 f753e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7547000 f754a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7568000 f7585000 r-xp /lib/ld-2.13.so
f758e000 f7591000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7591000 f7595000 r-xp /usr/lib/libsys-assert.so
f7cb0000 f7cfe000 rw-p [heap]
ffc7f000 ffca0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23286)
Call Stack Count: 1
 0: (0xf743f9fc) [/lib/libc.so.6] + 0x6e9fc
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
2:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:29.241+0200 I/recorder(23093): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:29.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23093]
04-23 12:40:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:29.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23093
04-23 12:40:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:29.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23093
04-23 12:40:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:29.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:29.321+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11230937265631524480029
04-23 12:40:29.341+0200 W/AUL     (23109): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23093
04-23 12:40:29.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:29.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23093
04-23 12:40:29.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23093)
04-23 12:40:29.351+0200 I/accelerometer(23090): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:29.491+0200 W/AUL     (23116): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23090
04-23 12:40:29.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:29.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23090
04-23 12:40:29.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23090)
04-23 12:40:31.221+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:39.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:39.011+0200 I/utils   (20587): specific action
04-23 12:40:39.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:39.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:39.011+0200 I/httppostreq(20587): internet available
04-23 12:40:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:39.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:39.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:39.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:39.041+0200 I/utils   (20584): specific action
04-23 12:40:39.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:39.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:39.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:39.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:39.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:39.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:39.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:39.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23156
04-23 12:40:39.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:39.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23156
04-23 12:40:39.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23156) type(svcapp) bg(0)
04-23 12:40:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23156)
04-23 12:40:39.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:39.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:39.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:39.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:39.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:39.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23156]
04-23 12:40:39.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:39.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:39.141+0200 E/CAPI_APPFW_APPLICATION(23156): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:39.141+0200 E/CAPI_APPFW_APPLICATION(23156): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:39.141+0200 I/utils   (23156): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:39.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23161
04-23 12:40:39.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:39.151+0200 I/utils   (23156): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:39.161+0200 I/utils   (23156): es.ugr.frailty.accelerometer listener started
04-23 12:40:39.161+0200 I/accelerometer(23156): stopping es.ugr.frailty.accelerometer service
04-23 12:40:39.161+0200 E/CAPI_APPFW_APP_CONTROL(23156): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:39.161+0200 E/accelerometer(23156): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:39.161+0200 I/CAPI_APPFW_APPLICATION(23156): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:39.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23161
04-23 12:40:39.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23161) type(svcapp) bg(0)
04-23 12:40:39.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23161)
04-23 12:40:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23156
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23156) was created
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.211+0200 E/CAPI_APPFW_APPLICATION(23161): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:39.211+0200 E/CAPI_APPFW_APPLICATION(23161): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:39.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23161) was created
04-23 12:40:39.221+0200 I/utils   (23161): specific action
04-23 12:40:39.221+0200 I/recorder(23161): obteniendo datos locales...
04-23 12:40:39.221+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23161]
04-23 12:40:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23161
04-23 12:40:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.251+0200 I/recorder(23161): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:39.251+0200 I/recorder(23161): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23156
04-23 12:40:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:39.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:39.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23161
04-23 12:40:39.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:39.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11231617265631524480039
04-23 12:40:39.361+0200 I/accelerometer(23156): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:39.361+0200 W/AUL     (23176): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23161
04-23 12:40:39.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:39.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23161
04-23 12:40:39.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23161)
04-23 12:40:39.481+0200 W/AUL     (23182): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23156
04-23 12:40:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23156
04-23 12:40:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23156)
04-23 12:40:41.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:49.001+0200 I/utils   (20587): specific action
04-23 12:40:49.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:49.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:49.001+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:49.011+0200 I/httppostreq(20587): internet available
04-23 12:40:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:49.031+0200 I/utils   (20584): specific action
04-23 12:40:49.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:49.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:49.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:49.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:49.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23220
04-23 12:40:49.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:49.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23220
04-23 12:40:49.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23220) type(svcapp) bg(0)
04-23 12:40:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23220)
04-23 12:40:49.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:49.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:49.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:49.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:49.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:49.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:49.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:49.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23220]
04-23 12:40:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:49.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23223
04-23 12:40:49.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:49.151+0200 E/CAPI_APPFW_APPLICATION(23220): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.151+0200 E/CAPI_APPFW_APPLICATION(23220): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.161+0200 I/utils   (23220): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:49.161+0200 I/utils   (23220): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:49.181+0200 E/CAPI_APPFW_APPLICATION(23223): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.181+0200 E/CAPI_APPFW_APPLICATION(23223): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.181+0200 I/utils   (23223): specific action
04-23 12:40:49.181+0200 I/recorder(23223): obteniendo datos locales...
04-23 12:40:49.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23223
04-23 12:40:49.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23223) type(svcapp) bg(0)
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.201+0200 I/utils   (23220): es.ugr.frailty.accelerometer listener started
04-23 12:40:49.201+0200 I/accelerometer(23220): stopping es.ugr.frailty.accelerometer service
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23220
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23220) was created
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23223) was created
04-23 12:40:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23220
04-23 12:40:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.221+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23223]
04-23 12:40:49.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23223)
04-23 12:40:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:49.231+0200 E/CAPI_APPFW_APP_CONTROL(23220): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:49.231+0200 E/accelerometer(23220): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:49.231+0200 I/CAPI_APPFW_APPLICATION(23220): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23223
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:49.241+0200 I/recorder(23223): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:49.241+0200 I/recorder(23223): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11232237265631524480049
04-23 12:40:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:49.321+0200 W/AUL     (23239): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:49.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23223
04-23 12:40:49.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:49.331+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23223
04-23 12:40:49.331+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23223)
04-23 12:40:49.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:49.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:49.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:40:49.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:40:49.341+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:40:49.351+0200 I/accelerometer(23220): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:49.511+0200 W/AUL     (23246): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23220
04-23 12:40:49.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:40:49.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23220
04-23 12:40:49.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23220)
04-23 12:40:51.241+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:59.001+0200 I/utils   (20587): specific action
04-23 12:40:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:59.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:59.011+0200 I/httppostreq(20587): internet available
04-23 12:40:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:59.031+0200 I/utils   (20584): specific action
04-23 12:40:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:59.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:59.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:59.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:59.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:59.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23284
04-23 12:40:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:59.101+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23284
04-23 12:40:59.101+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23284) type(svcapp) bg(0)
04-23 12:40:59.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23284]
04-23 12:40:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23284)
04-23 12:40:59.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:59.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:59.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23286
04-23 12:40:59.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:59.181+0200 E/CAPI_APPFW_APPLICATION(23284): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.181+0200 E/CAPI_APPFW_APPLICATION(23284): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.181+0200 I/utils   (23284): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:59.191+0200 I/utils   (23284): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:59.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23286
04-23 12:40:59.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23286) type(svcapp) bg(0)
04-23 12:40:59.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23286)
04-23 12:40:59.201+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23286]
04-23 12:40:59.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.221+0200 I/utils   (23284): es.ugr.frailty.accelerometer listener started
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23284
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23284) was created
04-23 12:40:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.221+0200 I/accelerometer(23284): stopping es.ugr.frailty.accelerometer service
04-23 12:40:59.221+0200 E/CAPI_APPFW_APP_CONTROL(23284): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.221+0200 E/accelerometer(23284): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:59.221+0200 I/CAPI_APPFW_APPLICATION(23284): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23286
04-23 12:40:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.251+0200 E/CAPI_APPFW_APPLICATION(23286): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.251+0200 E/CAPI_APPFW_APPLICATION(23286): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:59.251+0200 I/utils   (23286): specific action
04-23 12:40:59.251+0200 I/recorder(23286): obteniendo datos locales...
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23284
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23286) was created
04-23 12:40:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:59.291+0200 I/recorder(23286): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23286
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:59.291+0200 I/recorder(23286): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:59.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1123286726563152448005
