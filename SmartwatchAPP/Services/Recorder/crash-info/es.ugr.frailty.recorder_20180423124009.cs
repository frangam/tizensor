S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22963
Date: 2018-04-23 12:40:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf71d2648, r1   = 0xf78331b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78331b8, r5   = 0x00012cd0
r6   = 0xf7845e88, r7   = 0xf71d2250
r8   = 0x000005d8, r9   = 0xf6cb5824
r10  = 0xf782b9d8, fp   = 0x00000000
ip   = 0xf71d1030, sp   = 0xffb998a8
lr   = 0xf71155d0, pc   = 0xf71119fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8320 KB
Buffers:     70988 KB
Cached:     191456 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7760 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f684c000 f684f000 r-xp /lib/libattr.so.1.1.0
f6858000 f685f000 r-xp /lib/libcrypt-2.13.so
f688f000 f6892000 r-xp /lib/libcap.so.2.21
f689a000 f689c000 r-xp /usr/lib/libiri.so
f68a4000 f68c1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68ca000 f68ce000 r-xp /usr/lib/libsmack.so.1.0.0
f68d8000 f68da000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68e2000 f68e7000 r-xp /usr/lib/libffi.so.5.0.10
f68ef000 f68f0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68f8000 f68fa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6902000 f6904000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f690e000 f691e000 r-xp /lib/libresolv-2.13.so
f6922000 f693a000 r-xp /usr/lib/liblzma.so.5.0.3
f6942000 f6944000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f694c000 f697b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6984000 f6993000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f699c000 f69a6000 r-xp /usr/lib/libsensord-shared.so
f69af000 f69e3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f69ec000 f6abf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aca000 f6ae0000 r-xp /lib/libz.so.1.2.5
f6ae8000 f6aee000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6af7000 f6b6c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b76000 f6b90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b98000 f6b9e000 r-xp /lib/librt-2.13.so
f6ba7000 f6bc5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bcf000 f6bd0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bd8000 f6bdd000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6be5000 f6cb5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6cb6000 f6ce0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ce9000 f6d00000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d08000 f6d71000 r-xp /lib/libm-2.13.so
f6d7a000 f6e0e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e21000 f6e26000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e2e000 f6e35000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e3d000 f6e67000 r-xp /usr/lib/libsensor.so.1.9.6
f6e70000 f6f3c000 r-xp /usr/lib/libxml2.so.2.7.8
f6f49000 f6f4b000 r-xp /usr/lib/libiniparser.so.0
f6f54000 f6f57000 r-xp /usr/lib/libbundle.so.0.1.22
f6f5f000 f6f65000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f6d000 f6f90000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f98000 f6fd9000 r-xp /usr/lib/libeina.so.1.7.99
f6fe2000 f6ff9000 r-xp /usr/lib/libecore.so.1.7.99
f7010000 f7019000 r-xp /usr/lib/libvconf.so.0.2.45
f7021000 f7035000 r-xp /lib/libpthread-2.13.so
f7040000 f704d000 r-xp /usr/lib/libaul.so.0.1.0
f7057000 f7059000 r-xp /lib/libdl-2.13.so
f7062000 f706d000 r-xp /lib/libunwind.so.8.0.1
f709a000 f70a2000 r-xp /lib/libgcc_s-4.6.so.1
f70a3000 f71c7000 r-xp /lib/libc-2.13.so
f71d5000 f71d7000 r-xp /usr/lib/libdlog.so.0.0.0
f71df000 f71eb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71f4000 f71f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7201000 f7205000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f720e000 f7210000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7219000 f721c000 r-xp /usr/lib/libappcore-agent.so.1.1
f723a000 f7257000 r-xp /lib/ld-2.13.so
f7260000 f7263000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7263000 f7267000 r-xp /usr/lib/libsys-assert.so
f7821000 f786f000 rw-p [heap]
ffb7b000 ffb9c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22963)
Call Stack Count: 1
 0: (0xf71119fc) [/lib/libc.so.6] + 0x6e9fc
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
uest.c: __request_handler(669) > __request_handler: 14
04-23 12:39:39.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22779
04-23 12:39:39.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:39.341+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:39.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:39.361+0200 I/accelerometer(22768): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:39.381+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11227797265631524479979
04-23 12:39:39.391+0200 W/AUL     (22787): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22779
04-23 12:39:39.391+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:39.401+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22779
04-23 12:39:39.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22779)
04-23 12:39:39.481+0200 W/AUL     (22794): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22768
04-23 12:39:39.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22768
04-23 12:39:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22768)
04-23 12:39:41.261+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:39:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:39:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:39:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:39:49.011+0200 I/utils   (20587): specific action
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:39:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:39:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:39:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:39:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:39:49.011+0200 I/httppostreq(20587): internet available
04-23 12:39:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:39:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:39:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:39:49.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:39:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:49.041+0200 I/utils   (20584): specific action
04-23 12:39:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:39:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:39:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:39:49.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:39:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:49.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22832
04-23 12:39:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22832
04-23 12:39:49.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22832) type(svcapp) bg(0)
04-23 12:39:49.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22832]
04-23 12:39:49.131+0200 E/CAPI_APPFW_APPLICATION(22832): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.131+0200 E/CAPI_APPFW_APPLICATION(22832): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.131+0200 I/utils   (22832): trying to start service: es.ugr.frailty.accelerometer
04-23 12:39:49.131+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22832) was created
04-23 12:39:49.141+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22832)
04-23 12:39:49.141+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:39:49.141+0200 I/servicemanager(20584): App control destroyed.
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:39:49.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.141+0200 I/utils   (22832): es.ugr.frailty.accelerometer sensor supported
04-23 12:39:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22832
04-23 12:39:49.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.151+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.151+0200 I/utils   (22832): es.ugr.frailty.accelerometer listener started
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.151+0200 E/servicemanager(20584): deleting timer 1
04-23 12:39:49.151+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:49.151+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:49.151+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:49.151+0200 I/accelerometer(22832): stopping es.ugr.frailty.accelerometer service
04-23 12:39:49.151+0200 E/CAPI_APPFW_APP_CONTROL(22832): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.151+0200 E/accelerometer(22832): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:39:49.151+0200 I/CAPI_APPFW_APPLICATION(22832): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:39:49.161+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:49.161+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:49.161+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:49.161+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:49.161+0200 E/servicemanager(20584): deleting timer 2
04-23 12:39:49.161+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:49.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:49.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22844
04-23 12:39:49.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:49.221+0200 E/CAPI_APPFW_APPLICATION(22844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.221+0200 E/CAPI_APPFW_APPLICATION(22844): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:49.221+0200 I/utils   (22844): specific action
04-23 12:39:49.221+0200 I/recorder(22844): obteniendo datos locales...
04-23 12:39:49.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22844
04-23 12:39:49.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22844) type(svcapp) bg(0)
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22832
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22844) was created
04-23 12:39:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.241+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22844)
04-23 12:39:49.241+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:39:49.241+0200 I/recorder(22844): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:39:49.241+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:39:49.251+0200 I/recorder(22844): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:49.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22844]
04-23 12:39:49.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22844
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22844
04-23 12:39:49.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:49.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:49.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:49.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11228447265631524479989
04-23 12:39:49.351+0200 W/AUL     (22851): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:49.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:49.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:49.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22844
04-23 12:39:49.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:49.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22844
04-23 12:39:49.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22844)
04-23 12:39:49.361+0200 I/accelerometer(22832): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:49.501+0200 W/AUL     (22858): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22832
04-23 12:39:49.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:49.511+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22832
04-23 12:39:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22832)
04-23 12:39:51.161+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:39:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:39:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:39:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:39:59.001+0200 I/utils   (20587): specific action
04-23 12:39:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:39:59.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:39:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:39:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:39:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:39:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:39:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:39:59.011+0200 I/httppostreq(20587): internet available
04-23 12:39:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:39:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:39:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:39:59.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:39:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:39:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:59.041+0200 I/utils   (20584): specific action
04-23 12:39:59.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:39:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:39:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:39:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:39:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:39:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:59.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22896
04-23 12:39:59.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22896
04-23 12:39:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22896) type(svcapp) bg(0)
04-23 12:39:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22896)
04-23 12:39:59.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:39:59.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:59.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:59.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:39:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:39:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:39:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:39:59.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:39:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:39:59.121+0200 E/CAPI_APPFW_APPLICATION(22896): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:59.121+0200 E/CAPI_APPFW_APPLICATION(22896): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:59.121+0200 I/utils   (22896): trying to start service: es.ugr.frailty.accelerometer
04-23 12:39:59.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22896]
04-23 12:39:59.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:39:59.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:39:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22901
04-23 12:39:59.151+0200 I/utils   (22896): es.ugr.frailty.accelerometer sensor supported
04-23 12:39:59.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:39:59.191+0200 E/CAPI_APPFW_APPLICATION(22901): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:59.191+0200 E/CAPI_APPFW_APPLICATION(22901): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:39:59.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22901
04-23 12:39:59.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22901) type(svcapp) bg(0)
04-23 12:39:59.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22896) was created
04-23 12:39:59.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22901) was created
04-23 12:39:59.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22896
04-23 12:39:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22896
04-23 12:39:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:59.221+0200 I/utils   (22901): specific action
04-23 12:39:59.221+0200 I/recorder(22901): obteniendo datos locales...
04-23 12:39:59.221+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22901]
04-23 12:39:59.231+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22901)
04-23 12:39:59.231+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:39:59.231+0200 I/utils   (22896): es.ugr.frailty.accelerometer listener started
04-23 12:39:59.231+0200 I/accelerometer(22896): stopping es.ugr.frailty.accelerometer service
04-23 12:39:59.231+0200 E/CAPI_APPFW_APP_CONTROL(22896): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:39:59.231+0200 E/accelerometer(22896): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:39:59.231+0200 I/CAPI_APPFW_APPLICATION(22896): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:39:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:39:59.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:39:59.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22901
04-23 12:39:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:59.251+0200 I/recorder(22901): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:39:59.251+0200 I/recorder(22901): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:39:59.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:39:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:59.321+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11229017265631524479999
04-23 12:39:59.331+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:39:59.341+0200 W/AUL     (22915): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:39:59.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:39:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:39:59.361+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:39:59.361+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:39:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22901
04-23 12:39:59.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:59.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22901
04-23 12:39:59.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22901)
04-23 12:39:59.371+0200 I/accelerometer(22896): es.ugr.frailty.accelerometer listener destroyed
04-23 12:39:59.491+0200 W/AUL     (22922): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:39:59.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:39:59.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:39:59.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22896
04-23 12:39:59.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:39:59.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22896
04-23 12:39:59.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22896)
04-23 12:40:01.231+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:40:04.211+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 2
04-23 12:40:04.211+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524479884, curr_wall_time = 1524480004
04-23 12:40:04.211+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 120 seconds
04-23 12:40:04.211+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 93 seconds
04-23 12:40:04.211+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 83, charging remaining time = 26 minutes
04-23 12:40:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:40:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:40:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:40:09.011+0200 I/utils   (20587): specific action
04-23 12:40:09.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:40:09.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:40:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:40:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:40:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:40:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:40:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:40:09.011+0200 I/httppostreq(20587): internet available
04-23 12:40:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:40:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:40:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:40:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:40:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:40:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:09.031+0200 I/utils   (20584): specific action
04-23 12:40:09.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:40:09.031+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:40:09.031+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:40:09.031+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:40:09.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:40:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:09.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:09.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:09.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22962
04-23 12:40:09.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22962
04-23 12:40:09.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22962) type(svcapp) bg(0)
04-23 12:40:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22962)
04-23 12:40:09.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:40:09.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:09.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:09.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:40:09.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:40:09.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:40:09.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:40:09.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:40:09.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:40:09.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:40:09.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:40:09.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22962]
04-23 12:40:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22963
04-23 12:40:09.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:40:09.141+0200 E/CAPI_APPFW_APPLICATION(22962): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:09.141+0200 E/CAPI_APPFW_APPLICATION(22962): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:09.151+0200 I/utils   (22962): trying to start service: es.ugr.frailty.accelerometer
04-23 12:40:09.151+0200 I/utils   (22962): es.ugr.frailty.accelerometer sensor supported
04-23 12:40:09.161+0200 I/utils   (22962): es.ugr.frailty.accelerometer listener started
04-23 12:40:09.161+0200 I/accelerometer(22962): stopping es.ugr.frailty.accelerometer service
04-23 12:40:09.161+0200 E/CAPI_APPFW_APP_CONTROL(22962): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:40:09.161+0200 E/accelerometer(22962): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:40:09.171+0200 I/CAPI_APPFW_APPLICATION(22962): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:40:09.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22963
04-23 12:40:09.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22963) type(svcapp) bg(0)
04-23 12:40:09.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:09.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22963]
04-23 12:40:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22962
04-23 12:40:09.191+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22962) was created
04-23 12:40:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:40:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:40:09.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22963
04-23 12:40:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:09.221+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22963)
04-23 12:40:09.221+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:40:09.231+0200 E/CAPI_APPFW_APPLICATION(22963): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:09.231+0200 E/CAPI_APPFW_APPLICATION(22963): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:40:09.231+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22963) was created
04-23 12:40:09.231+0200 I/utils   (22963): specific action
04-23 12:40:09.231+0200 I/recorder(22963): obteniendo datos locales...
04-23 12:40:09.251+0200 I/recorder(22963): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:40:09.251+0200 I/recorder(22963): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:40:09.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:09.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22962
04-23 12:40:09.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:40:09.281+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:09.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:40:09.311+0200 I/accelerometer(22962): es.ugr.frailty.accelerometer listener destroyed
04-23 12:40:09.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:40:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:40:09.321+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:40:09.321+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:40:09.321+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122963726563152448000
