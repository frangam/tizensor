S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21523
Date: 2018-04-23 12:36:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7020648, r1   = 0xf730a1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf730a1b8, r5   = 0x00012cd0
r6   = 0xf731ce88, r7   = 0xf7020250
r8   = 0x000005d8, r9   = 0xf6b03824
r10  = 0xf73029d8, fp   = 0x00000000
ip   = 0xf701f030, sp   = 0xff878878
lr   = 0xf6f635d0, pc   = 0xf6f5f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     11072 KB
Buffers:     70568 KB
Cached:     190292 KB
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
f669a000 f669d000 r-xp /lib/libattr.so.1.1.0
f66a6000 f66ad000 r-xp /lib/libcrypt-2.13.so
f66dd000 f66e0000 r-xp /lib/libcap.so.2.21
f66e8000 f66ea000 r-xp /usr/lib/libiri.so
f66f2000 f670f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6718000 f671c000 r-xp /usr/lib/libsmack.so.1.0.0
f6726000 f6728000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6730000 f6735000 r-xp /usr/lib/libffi.so.5.0.10
f673d000 f673e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6746000 f6748000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6750000 f6752000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f675c000 f676c000 r-xp /lib/libresolv-2.13.so
f6770000 f6788000 r-xp /usr/lib/liblzma.so.5.0.3
f6790000 f6792000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f679a000 f67c9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d2000 f67e1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67ea000 f67f4000 r-xp /usr/lib/libsensord-shared.so
f67fd000 f6831000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f683a000 f690d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6918000 f692e000 r-xp /lib/libz.so.1.2.5
f6936000 f693c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6945000 f69ba000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69c4000 f69de000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69e6000 f69ec000 r-xp /lib/librt-2.13.so
f69f5000 f6a13000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a1d000 f6a1e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a26000 f6a2b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a33000 f6b03000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b04000 f6b2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b37000 f6b4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b56000 f6bbf000 r-xp /lib/libm-2.13.so
f6bc8000 f6c5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c6f000 f6c74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c7c000 f6c83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c8b000 f6cb5000 r-xp /usr/lib/libsensor.so.1.9.6
f6cbe000 f6d8a000 r-xp /usr/lib/libxml2.so.2.7.8
f6d97000 f6d99000 r-xp /usr/lib/libiniparser.so.0
f6da2000 f6da5000 r-xp /usr/lib/libbundle.so.0.1.22
f6dad000 f6db3000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dbb000 f6dde000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6de6000 f6e27000 r-xp /usr/lib/libeina.so.1.7.99
f6e30000 f6e47000 r-xp /usr/lib/libecore.so.1.7.99
f6e5e000 f6e67000 r-xp /usr/lib/libvconf.so.0.2.45
f6e6f000 f6e83000 r-xp /lib/libpthread-2.13.so
f6e8e000 f6e9b000 r-xp /usr/lib/libaul.so.0.1.0
f6ea5000 f6ea7000 r-xp /lib/libdl-2.13.so
f6eb0000 f6ebb000 r-xp /lib/libunwind.so.8.0.1
f6ee8000 f6ef0000 r-xp /lib/libgcc_s-4.6.so.1
f6ef1000 f7015000 r-xp /lib/libc-2.13.so
f7023000 f7025000 r-xp /usr/lib/libdlog.so.0.0.0
f702d000 f7039000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7042000 f7047000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f704f000 f7053000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f705c000 f705e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7067000 f706a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7088000 f70a5000 r-xp /lib/ld-2.13.so
f70ae000 f70b1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f70b1000 f70b5000 r-xp /usr/lib/libsys-assert.so
f72f8000 f7346000 rw-p [heap]
ff85a000 ff87b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21523)
Call Stack Count: 1
 0: (0xf6f5f9fc) [/lib/libc.so.6] + 0x6e9fc
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
rder(21325): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:35:59.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:35:59.291+0200 I/recorder(21325): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:35:59.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:35:59.321+0200 I/accelerometer(21322): es.ugr.frailty.accelerometer listener destroyed
04-23 12:35:59.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11213257265631524479759
04-23 12:35:59.361+0200 W/AUL     (21341): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:35:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21325
04-23 12:35:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:59.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21325
04-23 12:35:59.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21325)
04-23 12:35:59.461+0200 W/AUL     (21348): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:35:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:35:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:35:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21322
04-23 12:35:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:35:59.471+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21322
04-23 12:35:59.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21322)
04-23 12:36:01.191+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:09.001+0200 I/utils   (20587): specific action
04-23 12:36:09.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:09.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:09.011+0200 I/httppostreq(20587): internet available
04-23 12:36:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:09.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:09.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:09.041+0200 I/utils   (20584): specific action
04-23 12:36:09.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:09.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:09.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:09.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:09.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:09.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:09.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21388
04-23 12:36:09.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21388
04-23 12:36:09.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21388) type(svcapp) bg(0)
04-23 12:36:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21388)
04-23 12:36:09.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:09.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:09.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:09.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:09.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:09.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21388]
04-23 12:36:09.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:09.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21391
04-23 12:36:09.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:09.161+0200 E/CAPI_APPFW_APPLICATION(21388): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:09.161+0200 E/CAPI_APPFW_APPLICATION(21388): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:09.161+0200 I/utils   (21388): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:09.171+0200 I/utils   (21388): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:09.181+0200 E/CAPI_APPFW_APPLICATION(21391): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:09.181+0200 E/CAPI_APPFW_APPLICATION(21391): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:09.181+0200 I/utils   (21391): specific action
04-23 12:36:09.181+0200 I/recorder(21391): obteniendo datos locales...
04-23 12:36:09.181+0200 I/utils   (21388): es.ugr.frailty.accelerometer listener started
04-23 12:36:09.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21391
04-23 12:36:09.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21391) type(svcapp) bg(0)
04-23 12:36:09.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:09.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21391)
04-23 12:36:09.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:09.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21391]
04-23 12:36:09.191+0200 I/accelerometer(21388): stopping es.ugr.frailty.accelerometer service
04-23 12:36:09.191+0200 E/CAPI_APPFW_APP_CONTROL(21388): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:09.191+0200 E/accelerometer(21388): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:09.191+0200 I/CAPI_APPFW_APPLICATION(21388): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21388
04-23 12:36:09.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21388) was created
04-23 12:36:09.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21391) was created
04-23 12:36:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21388
04-23 12:36:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:09.231+0200 I/recorder(21391): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21391
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:09.231+0200 I/recorder(21391): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:09.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21391
04-23 12:36:09.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:09.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11213917265631524479769
04-23 12:36:09.331+0200 W/AUL     (21407): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:09.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:09.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:09.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21391
04-23 12:36:09.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:09.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21391
04-23 12:36:09.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21391)
04-23 12:36:09.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:09.361+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:09.381+0200 I/accelerometer(21388): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:09.501+0200 W/AUL     (21414): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21388
04-23 12:36:09.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:09.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21388
04-23 12:36:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21388)
04-23 12:36:11.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:18.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:18.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:18.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:19.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:19.011+0200 I/utils   (20587): specific action
04-23 12:36:19.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:19.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:19.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:19.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:19.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:19.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:19.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:19.011+0200 I/httppostreq(20587): internet available
04-23 12:36:19.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:19.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:19.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:19.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:19.041+0200 I/utils   (20584): specific action
04-23 12:36:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:19.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:19.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:19.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:19.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:19.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21452
04-23 12:36:19.071+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:19.091+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:19.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21452
04-23 12:36:19.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21452) type(svcapp) bg(0)
04-23 12:36:19.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21452]
04-23 12:36:19.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21452)
04-23 12:36:19.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:19.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:19.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:19.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:19.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:19.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:19.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:19.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:19.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:19.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:19.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:19.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:19.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:19.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:19.141+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:19.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:19.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:19.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:19.151+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:19.151+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:19.151+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:19.151+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:19.151+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:19.151+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:19.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21452
04-23 12:36:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:19.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:19.161+0200 E/CAPI_APPFW_APPLICATION(21452): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:19.161+0200 E/CAPI_APPFW_APPLICATION(21452): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:19.161+0200 I/utils   (21452): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:19.161+0200 I/utils   (21452): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:19.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21461
04-23 12:36:19.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:19.211+0200 I/utils   (21452): es.ugr.frailty.accelerometer listener started
04-23 12:36:19.211+0200 I/accelerometer(21452): stopping es.ugr.frailty.accelerometer service
04-23 12:36:19.221+0200 E/CAPI_APPFW_APPLICATION(21461): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:19.221+0200 E/CAPI_APPFW_APPLICATION(21461): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:19.221+0200 I/utils   (21461): specific action
04-23 12:36:19.221+0200 I/recorder(21461): obteniendo datos locales...
04-23 12:36:19.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21461
04-23 12:36:19.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21461) type(svcapp) bg(0)
04-23 12:36:19.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:19.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21452) was created
04-23 12:36:19.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21461) was created
04-23 12:36:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:19.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21452
04-23 12:36:19.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21461)
04-23 12:36:19.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:19.241+0200 E/CAPI_APPFW_APP_CONTROL(21452): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:19.241+0200 E/accelerometer(21452): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:19.241+0200 I/CAPI_APPFW_APPLICATION(21452): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:19.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:19.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:19.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21461]
04-23 12:36:19.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:19.261+0200 I/recorder(21461): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21461
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:19.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:19.271+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:19.281+0200 I/recorder(21461): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21461
04-23 12:36:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:19.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:19.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11214617265631524479779
04-23 12:36:19.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:19.351+0200 W/AUL     (21471): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21461
04-23 12:36:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:19.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21461
04-23 12:36:19.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21461)
04-23 12:36:19.381+0200 I/accelerometer(21452): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:19.501+0200 W/AUL     (21478): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21452
04-23 12:36:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:19.531+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21452
04-23 12:36:19.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21452)
04-23 12:36:21.241+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:23.591+0200 E/wnoti-ancs( 2999): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [0][10][0][2][6a][0][0][0][0][0][0][0][0][0][0]
04-23 12:36:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:29.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:29.011+0200 I/utils   (20587): specific action
04-23 12:36:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:29.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:29.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:29.011+0200 I/httppostreq(20587): internet available
04-23 12:36:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:29.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:29.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:29.041+0200 I/utils   (20584): specific action
04-23 12:36:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:29.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:29.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:29.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:29.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21520
04-23 12:36:29.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:29.071+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:29.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21520
04-23 12:36:29.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21520) type(svcapp) bg(0)
04-23 12:36:29.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21520)
04-23 12:36:29.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:29.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:29.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:29.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:29.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:29.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:29.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:29.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:29.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:29.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:29.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:29.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21520]
04-23 12:36:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:29.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21523
04-23 12:36:29.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:29.161+0200 E/CAPI_APPFW_APPLICATION(21520): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:29.161+0200 E/CAPI_APPFW_APPLICATION(21520): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:29.161+0200 I/utils   (21520): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:29.161+0200 I/utils   (21520): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:29.181+0200 I/utils   (21520): es.ugr.frailty.accelerometer listener started
04-23 12:36:29.181+0200 I/accelerometer(21520): stopping es.ugr.frailty.accelerometer service
04-23 12:36:29.181+0200 E/CAPI_APPFW_APP_CONTROL(21520): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:29.181+0200 E/accelerometer(21520): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:29.181+0200 I/CAPI_APPFW_APPLICATION(21520): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:29.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21523
04-23 12:36:29.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21523) type(svcapp) bg(0)
04-23 12:36:29.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:29.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21523)
04-23 12:36:29.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:29.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21523]
04-23 12:36:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21520
04-23 12:36:29.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21520) was created
04-23 12:36:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21520
04-23 12:36:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:29.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21523
04-23 12:36:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21523
04-23 12:36:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:29.251+0200 E/CAPI_APPFW_APPLICATION(21523): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:29.251+0200 E/CAPI_APPFW_APPLICATION(21523): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:29.261+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21523) was created
04-23 12:36:29.261+0200 I/utils   (21523): specific action
04-23 12:36:29.261+0200 I/recorder(21523): obteniendo datos locales...
04-23 12:36:29.281+0200 I/recorder(21523): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:29.281+0200 I/recorder(21523): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:29.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:29.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:29.321+0200 I/accelerometer(21520): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:29.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121523726563152447978
