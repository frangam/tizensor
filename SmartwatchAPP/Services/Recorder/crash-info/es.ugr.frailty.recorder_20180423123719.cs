S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 21871
Date: 2018-04-23 12:37:19+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf6f78648, r1   = 0xf73e31b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf73e31b8, r5   = 0x00012cd0
r6   = 0xf73f5e88, r7   = 0xf6f78250
r8   = 0x000005d8, r9   = 0xf6a5b824
r10  = 0xf73db9d8, fp   = 0x00000000
ip   = 0xf6f77030, sp   = 0xff993398
lr   = 0xf6ebb5d0, pc   = 0xf6eb79fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9728 KB
Buffers:     70648 KB
Cached:     190556 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7744 KB
VmRSS:        7740 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f65f2000 f65f5000 r-xp /lib/libattr.so.1.1.0
f65fe000 f6605000 r-xp /lib/libcrypt-2.13.so
f6635000 f6638000 r-xp /lib/libcap.so.2.21
f6640000 f6642000 r-xp /usr/lib/libiri.so
f664a000 f6667000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6670000 f6674000 r-xp /usr/lib/libsmack.so.1.0.0
f667e000 f6680000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6688000 f668d000 r-xp /usr/lib/libffi.so.5.0.10
f6695000 f6696000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f669e000 f66a0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66a8000 f66aa000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66b4000 f66c4000 r-xp /lib/libresolv-2.13.so
f66c8000 f66e0000 r-xp /usr/lib/liblzma.so.5.0.3
f66e8000 f66ea000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66f2000 f6721000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f672a000 f6739000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6742000 f674c000 r-xp /usr/lib/libsensord-shared.so
f6755000 f6789000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6792000 f6865000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6870000 f6886000 r-xp /lib/libz.so.1.2.5
f688e000 f6894000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f689d000 f6912000 r-xp /usr/lib/libsqlite3.so.0.8.6
f691c000 f6936000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f693e000 f6944000 r-xp /lib/librt-2.13.so
f694d000 f696b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6975000 f6976000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f697e000 f6983000 r-xp /usr/lib/libxdgmime.so.1.1.0
f698b000 f6a5b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6a5c000 f6a86000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a8f000 f6aa6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aae000 f6b17000 r-xp /lib/libm-2.13.so
f6b20000 f6bb4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bc7000 f6bcc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bd4000 f6bdb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6be3000 f6c0d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c16000 f6ce2000 r-xp /usr/lib/libxml2.so.2.7.8
f6cef000 f6cf1000 r-xp /usr/lib/libiniparser.so.0
f6cfa000 f6cfd000 r-xp /usr/lib/libbundle.so.0.1.22
f6d05000 f6d0b000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d13000 f6d36000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d3e000 f6d7f000 r-xp /usr/lib/libeina.so.1.7.99
f6d88000 f6d9f000 r-xp /usr/lib/libecore.so.1.7.99
f6db6000 f6dbf000 r-xp /usr/lib/libvconf.so.0.2.45
f6dc7000 f6ddb000 r-xp /lib/libpthread-2.13.so
f6de6000 f6df3000 r-xp /usr/lib/libaul.so.0.1.0
f6dfd000 f6dff000 r-xp /lib/libdl-2.13.so
f6e08000 f6e13000 r-xp /lib/libunwind.so.8.0.1
f6e40000 f6e48000 r-xp /lib/libgcc_s-4.6.so.1
f6e49000 f6f6d000 r-xp /lib/libc-2.13.so
f6f7b000 f6f7d000 r-xp /usr/lib/libdlog.so.0.0.0
f6f85000 f6f91000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f9a000 f6f9f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fa7000 f6fab000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fb4000 f6fb6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6fbf000 f6fc2000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fe0000 f6ffd000 r-xp /lib/ld-2.13.so
f7006000 f7009000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7009000 f700d000 r-xp /usr/lib/libsys-assert.so
f73d1000 f741f000 rw-p [heap]
ff975000 ff996000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21871)
Call Stack Count: 1
 0: (0xf6eb79fc) [/lib/libc.so.6] + 0x6e9fc
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
): worker.c: worker_job(1205) > 11216637265631524479809
04-23 12:36:49.311+0200 W/AUL     (21678): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21663
04-23 12:36:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:49.321+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21663
04-23 12:36:49.321+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21663)
04-23 12:36:49.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:49.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:36:49.371+0200 I/accelerometer(21660): es.ugr.frailty.accelerometer listener destroyed
04-23 12:36:49.501+0200 W/AUL     (21686): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21660
04-23 12:36:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:36:49.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21660
04-23 12:36:49.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21660)
04-23 12:36:51.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:36:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:36:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:36:59.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:36:59.011+0200 I/utils   (20587): specific action
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:36:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:36:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:36:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:36:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:36:59.011+0200 I/httppostreq(20587): internet available
04-23 12:36:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:36:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:36:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:36:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:36:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:59.041+0200 I/utils   (20584): specific action
04-23 12:36:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:36:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:36:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:36:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:36:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:36:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21728
04-23 12:36:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21728
04-23 12:36:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(21728) type(svcapp) bg(0)
04-23 12:36:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21728)
04-23 12:36:59.111+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:36:59.111+0200 I/servicemanager(20584): App control destroyed.
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 0
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 1
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:36:59.111+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:36:59.111+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:36:59.111+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:36:59.111+0200 E/servicemanager(20584): deleting timer 2
04-23 12:36:59.111+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:36:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:36:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21728]
04-23 12:36:59.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:36:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 21731
04-23 12:36:59.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:36:59.151+0200 E/CAPI_APPFW_APPLICATION(21728): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.151+0200 E/CAPI_APPFW_APPLICATION(21728): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.161+0200 I/utils   (21728): trying to start service: es.ugr.frailty.accelerometer
04-23 12:36:59.161+0200 I/utils   (21728): es.ugr.frailty.accelerometer sensor supported
04-23 12:36:59.171+0200 I/utils   (21728): es.ugr.frailty.accelerometer listener started
04-23 12:36:59.171+0200 I/accelerometer(21728): stopping es.ugr.frailty.accelerometer service
04-23 12:36:59.171+0200 E/CAPI_APPFW_APP_CONTROL(21728): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.171+0200 E/accelerometer(21728): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:36:59.171+0200 I/CAPI_APPFW_APPLICATION(21728): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:36:59.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21731
04-23 12:36:59.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21731) type(svcapp) bg(0)
04-23 12:36:59.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.181+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21731)
04-23 12:36:59.181+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:36:59.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21731]
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21728
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21728) was created
04-23 12:36:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.201+0200 E/CAPI_APPFW_APPLICATION(21731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.201+0200 E/CAPI_APPFW_APPLICATION(21731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:36:59.201+0200 I/utils   (21731): specific action
04-23 12:36:59.201+0200 I/recorder(21731): obteniendo datos locales...
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21728
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (21731) was created
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21731
04-23 12:36:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:36:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21731
04-23 12:36:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:36:59.271+0200 I/recorder(21731): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:36:59.271+0200 I/recorder(21731): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
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
04-23 12:37:19.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1121871726563152447983
