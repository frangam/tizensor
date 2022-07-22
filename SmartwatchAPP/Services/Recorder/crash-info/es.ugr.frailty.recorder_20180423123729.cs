S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21934
Date: 2018-04-23 12:37:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7574648, r1   = 0xf76e81b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf76e81b8, r5   = 0x00012cd0
r6   = 0xf76fae88, r7   = 0xf7574250
r8   = 0x000005d8, r9   = 0xf7057824
r10  = 0xf76e09d8, fp   = 0x00000000
ip   = 0xf7573030, sp   = 0xffdf4848
lr   = 0xf74b75d0, pc   = 0xf74b39fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9492 KB
Buffers:     70664 KB
Cached:     190608 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7724 KB
VmRSS:        7720 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6bee000 f6bf1000 r-xp /lib/libattr.so.1.1.0
f6bfa000 f6c01000 r-xp /lib/libcrypt-2.13.so
f6c31000 f6c34000 r-xp /lib/libcap.so.2.21
f6c3c000 f6c3e000 r-xp /usr/lib/libiri.so
f6c46000 f6c63000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c6c000 f6c70000 r-xp /usr/lib/libsmack.so.1.0.0
f6c7a000 f6c7c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c84000 f6c89000 r-xp /usr/lib/libffi.so.5.0.10
f6c91000 f6c92000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c9a000 f6c9c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ca4000 f6ca6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cb0000 f6cc0000 r-xp /lib/libresolv-2.13.so
f6cc4000 f6cdc000 r-xp /usr/lib/liblzma.so.5.0.3
f6ce4000 f6ce6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cee000 f6d1d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d26000 f6d35000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d3e000 f6d48000 r-xp /usr/lib/libsensord-shared.so
f6d51000 f6d85000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d8e000 f6e61000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e6c000 f6e82000 r-xp /lib/libz.so.1.2.5
f6e8a000 f6e90000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e99000 f6f0e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f18000 f6f32000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f3a000 f6f40000 r-xp /lib/librt-2.13.so
f6f49000 f6f67000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f71000 f6f72000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f7a000 f6f7f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f87000 f7057000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7058000 f7082000 r-xp /usr/lib/libdbus-1.so.3.8.12
f708b000 f70a2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70aa000 f7113000 r-xp /lib/libm-2.13.so
f711c000 f71b0000 r-xp /usr/lib/libstdc++.so.6.0.16
f71c3000 f71c8000 r-xp /usr/lib/libctx-client.so.0.8.3
f71d0000 f71d7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71df000 f7209000 r-xp /usr/lib/libsensor.so.1.9.6
f7212000 f72de000 r-xp /usr/lib/libxml2.so.2.7.8
f72eb000 f72ed000 r-xp /usr/lib/libiniparser.so.0
f72f6000 f72f9000 r-xp /usr/lib/libbundle.so.0.1.22
f7301000 f7307000 r-xp /usr/lib/libappsvc.so.0.1.0
f730f000 f7332000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f733a000 f737b000 r-xp /usr/lib/libeina.so.1.7.99
f7384000 f739b000 r-xp /usr/lib/libecore.so.1.7.99
f73b2000 f73bb000 r-xp /usr/lib/libvconf.so.0.2.45
f73c3000 f73d7000 r-xp /lib/libpthread-2.13.so
f73e2000 f73ef000 r-xp /usr/lib/libaul.so.0.1.0
f73f9000 f73fb000 r-xp /lib/libdl-2.13.so
f7404000 f740f000 r-xp /lib/libunwind.so.8.0.1
f743c000 f7444000 r-xp /lib/libgcc_s-4.6.so.1
f7445000 f7569000 r-xp /lib/libc-2.13.so
f7577000 f7579000 r-xp /usr/lib/libdlog.so.0.0.0
f7581000 f758d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7596000 f759b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75a3000 f75a7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75b0000 f75b2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f75bb000 f75be000 r-xp /usr/lib/libappcore-agent.so.1.1
f75dc000 f75f9000 r-xp /lib/ld-2.13.so
f7602000 f7605000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7605000 f7609000 r-xp /usr/lib/libsys-assert.so
f76d6000 f7724000 rw-p [heap]
ffdd6000 ffdf7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21934)
Call Stack Count: 1
 0: (0xf74b39fc) [/lib/libc.so.6] + 0x6e9fc
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
SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:36:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:59.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:59.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11217317265631524479819
04-23 12:36:59.331+0200 W/AUL     (21746): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21731
04-23 12:36:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:59.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21731
04-23 12:36:59.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21731)
04-23 12:36:59.351+0200 I/accelerometer(21728): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:59.471+0200 W/AUL     (21754): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:59.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21728
04-23 12:36:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:59.491+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21728
04-23 12:36:59.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21728)
04-23 12:37:01.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:09.001+0200 I/utils   (20587): specific action
04-23 12:37:09.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:09.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:09.011+0200 I/httppostreq(20587): internet available
04-23 12:37:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:09.031+0200 I/utils   (20584): specific action
04-23 12:37:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:09.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:09.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:09.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:09.031+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:09.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:09.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21794
04-23 12:37:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21794
04-23 12:37:09.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21794) type(svcapp) bg(0)
04-23 12:37:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21794)
04-23 12:37:09.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:09.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:09.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:09.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:09.121+0200 E/CAPI_APPFW_APPLICATION(21794): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.121+0200 E/CAPI_APPFW_APPLICATION(21794): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:09.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21797
04-23 12:37:09.141+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21794]
04-23 12:37:09.151+0200 I/utils   (21794): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:09.161+0200 I/utils   (21794): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:09.171+0200 I/utils   (21794): es.ugr.frailty.accelerometer listener started
04-23 12:37:09.181+0200 I/accelerometer(21794): stopping es.ugr.frailty.accelerometer service
04-23 12:37:09.181+0200 E/CAPI_APPFW_APP_CONTROL(21794): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.181+0200 E/accelerometer(21794): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:09.181+0200 I/CAPI_APPFW_APPLICATION(21794): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:09.191+0200 E/CAPI_APPFW_APPLICATION(21797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.191+0200 E/CAPI_APPFW_APPLICATION(21797): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:09.191+0200 I/utils   (21797): specific action
04-23 12:37:09.191+0200 I/recorder(21797): obteniendo datos locales...
04-23 12:37:09.211+0200 I/recorder(21797): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:09.211+0200 I/recorder(21797): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:09.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21797
04-23 12:37:09.231+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21797) type(svcapp) bg(0)
04-23 12:37:09.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21797)
04-23 12:37:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:09.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:09.241+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21794
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21794) was created
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21797) was created
04-23 12:37:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21794
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:09.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:09.291+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11217977265631524479829
04-23 12:37:09.301+0200 E/RESOURCED( 2551): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/21797/oom_score_adj failed
04-23 12:37:09.301+0200 E/RESOURCED( 2551): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 21797
04-23 12:37:09.301+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21797]
04-23 12:37:09.301+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:37:09.301+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:37:09.301+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(21797), proc(0)
04-23 12:37:09.301+0200 E/AUL     ( 2880): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:37:09.301+0200 E/CAPI_APPFW_APP_MANAGER( 2880): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:37:09.301+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:37:09.311+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 12:37:09.311+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 12:37:09.311+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(21797), proc(0)
04-23 12:37:09.311+0200 E/SECURITY_EXTENSION_SERVER( 2459): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 12:37:09.311+0200 W/AUL     (21811): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21797
04-23 12:37:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:09.311+0200 E/AUL     ( 3087): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 12:37:09.311+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:37:09.311+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21797
04-23 12:37:09.311+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21797)
04-23 12:37:09.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:09.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:09.361+0200 I/accelerometer(21794): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:09.511+0200 W/AUL     (21820): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:09.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:09.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:09.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21794
04-23 12:37:09.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:09.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21794
04-23 12:37:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21794)
04-23 12:37:11.251+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:18.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:18.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:18.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:19.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:19.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:19.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:19.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:19.011+0200 I/utils   (20587): specific action
04-23 12:37:19.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:19.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:19.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:19.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:19.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:19.011+0200 I/httppostreq(20587): internet available
04-23 12:37:19.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:19.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:19.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:19.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:19.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:19.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:19.041+0200 I/utils   (20584): specific action
04-23 12:37:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:19.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:19.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:19.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:19.051+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21858
04-23 12:37:19.061+0200 E/RESOURCED( 2551): proc-main.c: proc_create_app_info(722) > prelaunched app was not gone to launch state, appid(es.ugr.frailty.recorder)
04-23 12:37:19.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:19.061+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:19.071+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:19.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21858
04-23 12:37:19.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21858) type(svcapp) bg(0)
04-23 12:37:19.121+0200 E/CAPI_APPFW_APPLICATION(21858): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:19.121+0200 E/CAPI_APPFW_APPLICATION(21858): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:19.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21858)
04-23 12:37:19.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:19.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:19.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:19.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:19.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:19.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:19.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:19.121+0200 I/utils   (21858): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:19.121+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21858) was created
04-23 12:37:19.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21858]
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:19.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:19.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:19.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:19.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.131+0200 I/utils   (21858): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:19.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21858
04-23 12:37:19.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.151+0200 I/utils   (21858): es.ugr.frailty.accelerometer listener started
04-23 12:37:19.151+0200 I/accelerometer(21858): stopping es.ugr.frailty.accelerometer service
04-23 12:37:19.151+0200 E/CAPI_APPFW_APP_CONTROL(21858): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:19.151+0200 E/accelerometer(21858): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:19.151+0200 I/CAPI_APPFW_APPLICATION(21858): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:19.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:19.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:19.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21871
04-23 12:37:19.201+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:19.211+0200 E/CAPI_APPFW_APPLICATION(21871): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:19.211+0200 E/CAPI_APPFW_APPLICATION(21871): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:19.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21871
04-23 12:37:19.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21871) type(svcapp) bg(0)
04-23 12:37:19.221+0200 I/utils   (21871): specific action
04-23 12:37:19.221+0200 I/recorder(21871): obteniendo datos locales...
04-23 12:37:19.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:19.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:19.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21871) was created
04-23 12:37:19.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21858
04-23 12:37:19.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.241+0200 I/recorder(21871): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:19.241+0200 I/recorder(21871): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:19.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21871]
04-23 12:37:19.261+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21871)
04-23 12:37:19.261+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21871
04-23 12:37:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:19.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21871
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:19.311+0200 I/accelerometer(21858): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:19.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11218717265631524479839
04-23 12:37:19.361+0200 W/AUL     (21878): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21871
04-23 12:37:19.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:19.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21871
04-23 12:37:19.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21871)
04-23 12:37:19.451+0200 W/AUL     (21884): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21858
04-23 12:37:19.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:19.461+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21858
04-23 12:37:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21858)
04-23 12:37:21.221+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:37:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:37:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:37:29.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:37:29.011+0200 I/utils   (20587): specific action
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:37:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:37:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:37:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:37:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:37:29.011+0200 I/httppostreq(20587): internet available
04-23 12:37:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:37:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:37:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:37:29.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:37:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:37:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:29.041+0200 I/utils   (20584): specific action
04-23 12:37:29.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:37:29.051+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:37:29.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:37:29.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:37:29.051+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:37:29.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21922
04-23 12:37:29.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21922
04-23 12:37:29.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21922) type(svcapp) bg(0)
04-23 12:37:29.131+0200 E/CAPI_APPFW_APPLICATION(21922): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.131+0200 E/CAPI_APPFW_APPLICATION(21922): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.131+0200 I/utils   (21922): trying to start service: es.ugr.frailty.accelerometer
04-23 12:37:29.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21922) was created
04-23 12:37:29.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21922]
04-23 12:37:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21922)
04-23 12:37:29.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:37:29.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:37:29.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:37:29.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:37:29.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:37:29.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:37:29.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:37:29.131+0200 I/utils   (21922): es.ugr.frailty.accelerometer sensor supported
04-23 12:37:29.141+0200 I/utils   (21922): es.ugr.frailty.accelerometer listener started
04-23 12:37:29.141+0200 I/accelerometer(21922): stopping es.ugr.frailty.accelerometer service
04-23 12:37:29.141+0200 E/CAPI_APPFW_APP_CONTROL(21922): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.141+0200 E/accelerometer(21922): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:37:29.141+0200 I/CAPI_APPFW_APPLICATION(21922): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:37:29.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:37:29.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:37:29.161+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21934
04-23 12:37:29.161+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21934
04-23 12:37:29.211+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21934) type(svcapp) bg(0)
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:37:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.211+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21934]
04-23 12:37:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21922
04-23 12:37:29.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.221+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21934)
04-23 12:37:29.221+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:37:29.231+0200 E/CAPI_APPFW_APPLICATION(21934): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.231+0200 E/CAPI_APPFW_APPLICATION(21934): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:37:29.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21934) was created
04-23 12:37:29.231+0200 I/utils   (21934): specific action
04-23 12:37:29.231+0200 I/recorder(21934): obteniendo datos locales...
04-23 12:37:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21934
04-23 12:37:29.251+0200 I/recorder(21934): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:29.251+0200 I/recorder(21934): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:29.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21922
04-23 12:37:29.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:29.311+0200 I/accelerometer(21922): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:29.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21934
04-23 12:37:29.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121934726563152447984
