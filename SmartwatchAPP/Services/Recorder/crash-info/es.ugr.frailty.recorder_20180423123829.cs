S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 22316
Date: 2018-04-23 12:38:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf731e648, r1   = 0xf791a1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf791a1b8, r5   = 0x00012cd0
r6   = 0xf792ce88, r7   = 0xf731e250
r8   = 0x000005d8, r9   = 0xf6e01824
r10  = 0xf79129d8, fp   = 0x00000000
ip   = 0xf731d030, sp   = 0xffd7b6c8
lr   = 0xf72615d0, pc   = 0xf725d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9048 KB
Buffers:     70772 KB
Cached:     190932 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7712 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6998000 f699b000 r-xp /lib/libattr.so.1.1.0
f69a4000 f69ab000 r-xp /lib/libcrypt-2.13.so
f69db000 f69de000 r-xp /lib/libcap.so.2.21
f69e6000 f69e8000 r-xp /usr/lib/libiri.so
f69f0000 f6a0d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a16000 f6a1a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a24000 f6a26000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a2e000 f6a33000 r-xp /usr/lib/libffi.so.5.0.10
f6a3b000 f6a3c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a44000 f6a46000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a4e000 f6a50000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a5a000 f6a6a000 r-xp /lib/libresolv-2.13.so
f6a6e000 f6a86000 r-xp /usr/lib/liblzma.so.5.0.3
f6a8e000 f6a90000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a98000 f6ac7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ad0000 f6adf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ae8000 f6af2000 r-xp /usr/lib/libsensord-shared.so
f6afb000 f6b2f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b38000 f6c0b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c16000 f6c2c000 r-xp /lib/libz.so.1.2.5
f6c34000 f6c3a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c43000 f6cb8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cc2000 f6cdc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ce4000 f6cea000 r-xp /lib/librt-2.13.so
f6cf3000 f6d11000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d1b000 f6d1c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d24000 f6d29000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d31000 f6e01000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e02000 f6e2c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e35000 f6e4c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e54000 f6ebd000 r-xp /lib/libm-2.13.so
f6ec6000 f6f5a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f6d000 f6f72000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f7a000 f6f81000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f89000 f6fb3000 r-xp /usr/lib/libsensor.so.1.9.6
f6fbc000 f7088000 r-xp /usr/lib/libxml2.so.2.7.8
f7095000 f7097000 r-xp /usr/lib/libiniparser.so.0
f70a0000 f70a3000 r-xp /usr/lib/libbundle.so.0.1.22
f70ab000 f70b1000 r-xp /usr/lib/libappsvc.so.0.1.0
f70b9000 f70dc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70e4000 f7125000 r-xp /usr/lib/libeina.so.1.7.99
f712e000 f7145000 r-xp /usr/lib/libecore.so.1.7.99
f715c000 f7165000 r-xp /usr/lib/libvconf.so.0.2.45
f716d000 f7181000 r-xp /lib/libpthread-2.13.so
f718c000 f7199000 r-xp /usr/lib/libaul.so.0.1.0
f71a3000 f71a5000 r-xp /lib/libdl-2.13.so
f71ae000 f71b9000 r-xp /lib/libunwind.so.8.0.1
f71e6000 f71ee000 r-xp /lib/libgcc_s-4.6.so.1
f71ef000 f7313000 r-xp /lib/libc-2.13.so
f7321000 f7323000 r-xp /usr/lib/libdlog.so.0.0.0
f732b000 f7337000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7340000 f7345000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f734d000 f7351000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f735a000 f735c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7365000 f7368000 r-xp /usr/lib/libappcore-agent.so.1.1
f7386000 f73a3000 r-xp /lib/ld-2.13.so
f73ac000 f73af000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73af000 f73b3000 r-xp /usr/lib/libsys-assert.so
f7908000 f7956000 rw-p [heap]
ffd5d000 ffd7e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22316)
Call Stack Count: 1
 0: (0xf725d9fc) [/lib/libc.so.6] + 0x6e9fc
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
5,9.774680,0.794417
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:37:59.261+0200 I/recorder(22119): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:37:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:37:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22119
04-23 12:37:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:37:59.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:59.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:37:59.331+0200 I/accelerometer(22116): es.ugr.frailty.accelerometer listener destroyed
04-23 12:37:59.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11221197265631524479879
04-23 12:37:59.341+0200 W/AUL     (22135): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:37:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22119
04-23 12:37:59.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:59.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22119
04-23 12:37:59.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22119)
04-23 12:37:59.481+0200 W/AUL     (22142): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:37:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:37:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:37:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22116
04-23 12:37:59.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:37:59.481+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22116
04-23 12:37:59.481+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22116)
04-23 12:38:01.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:04.161+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 1
04-23 12:38:04.161+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524479794, curr_wall_time = 1524479884
04-23 12:38:04.161+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 90 seconds
04-23 12:38:04.161+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 87 seconds
04-23 12:38:04.161+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 82, charging remaining time = 26 minutes
04-23 12:38:08.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:08.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:09.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:09.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:09.001+0200 I/utils   (20587): specific action
04-23 12:38:09.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:09.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:09.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:09.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:09.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:09.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:09.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:09.011+0200 I/httppostreq(20587): internet available
04-23 12:38:09.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:09.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:09.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:09.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:09.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:09.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:09.041+0200 I/utils   (20584): specific action
04-23 12:38:09.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:09.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:09.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:09.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:09.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:09.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:09.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:09.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:09.081+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22182
04-23 12:38:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22182
04-23 12:38:09.131+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22182) type(svcapp) bg(0)
04-23 12:38:09.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22182]
04-23 12:38:09.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22182)
04-23 12:38:09.131+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:09.131+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:09.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:09.131+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:09.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:09.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:09.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:09.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:09.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:09.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:09.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:09.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:09.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:09.151+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22184
04-23 12:38:09.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:09.151+0200 E/CAPI_APPFW_APPLICATION(22182): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:09.151+0200 E/CAPI_APPFW_APPLICATION(22182): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:09.151+0200 I/utils   (22182): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:09.161+0200 I/utils   (22182): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:09.181+0200 I/utils   (22182): es.ugr.frailty.accelerometer listener started
04-23 12:38:09.181+0200 I/accelerometer(22182): stopping es.ugr.frailty.accelerometer service
04-23 12:38:09.181+0200 E/CAPI_APPFW_APP_CONTROL(22182): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:09.181+0200 E/accelerometer(22182): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:09.181+0200 I/CAPI_APPFW_APPLICATION(22182): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:09.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22184
04-23 12:38:09.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22184) type(svcapp) bg(0)
04-23 12:38:09.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:09.201+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22184)
04-23 12:38:09.201+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:38:09.201+0200 E/CAPI_APPFW_APPLICATION(22184): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:09.201+0200 E/CAPI_APPFW_APPLICATION(22184): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:09.201+0200 I/utils   (22184): specific action
04-23 12:38:09.201+0200 I/recorder(22184): obteniendo datos locales...
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22182
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22182) was created
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22184) was created
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:09.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:09.221+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22184]
04-23 12:38:09.221+0200 I/recorder(22184): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22182
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:09.221+0200 I/recorder(22184): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:09.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:09.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:09.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22184
04-23 12:38:09.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:09.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11221847265631524479889
04-23 12:38:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:09.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 12:38:09.321+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 12:38:09.321+0200 E/CAPI_APPFW_APP_MANAGER( 3087): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 12:38:09.341+0200 W/AUL     (22200): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:38:09.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:09.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:09.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22184
04-23 12:38:09.341+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:09.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22184
04-23 12:38:09.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22184)
04-23 12:38:09.351+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:09.361+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:09.371+0200 I/accelerometer(22182): es.ugr.frailty.accelerometer listener destroyed
04-23 12:38:09.511+0200 W/AUL     (22209): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:38:09.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22182
04-23 12:38:09.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:09.521+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22182
04-23 12:38:09.521+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22182)
04-23 12:38:11.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:18.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:18.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:18.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:19.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:19.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:19.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:19.011+0200 I/utils   (20587): specific action
04-23 12:38:19.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:19.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:19.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:19.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:19.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:19.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:19.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:19.011+0200 I/httppostreq(20587): internet available
04-23 12:38:19.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:19.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:19.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:19.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:19.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:19.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:19.041+0200 I/utils   (20584): specific action
04-23 12:38:19.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:19.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:19.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:19.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:19.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:19.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:19.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:19.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22247
04-23 12:38:19.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:19.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22247
04-23 12:38:19.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22247) type(svcapp) bg(0)
04-23 12:38:19.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22247)
04-23 12:38:19.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:19.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:19.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:19.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:19.121+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22247]
04-23 12:38:19.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:19.141+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:19.141+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:19.141+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:19.141+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:19.141+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:19.141+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:19.151+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:19.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:19.151+0200 E/CAPI_APPFW_APPLICATION(22247): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:19.151+0200 E/CAPI_APPFW_APPLICATION(22247): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:19.151+0200 I/utils   (22247): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:19.151+0200 I/utils   (22247): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22247
04-23 12:38:19.161+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22247) was created
04-23 12:38:19.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:19.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:19.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:19.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:19.171+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:19.171+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:19.171+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:19.171+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:19.171+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:19.171+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:19.171+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:19.171+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:19.171+0200 I/utils   (22247): es.ugr.frailty.accelerometer listener started
04-23 12:38:19.171+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:19.171+0200 I/accelerometer(22247): stopping es.ugr.frailty.accelerometer service
04-23 12:38:19.171+0200 E/CAPI_APPFW_APP_CONTROL(22247): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:19.171+0200 E/accelerometer(22247): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:19.171+0200 I/CAPI_APPFW_APPLICATION(22247): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:19.171+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:19.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:19.171+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:19.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:19.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:19.191+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:19.191+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22259
04-23 12:38:19.241+0200 E/CAPI_APPFW_APPLICATION(22259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:19.241+0200 E/CAPI_APPFW_APPLICATION(22259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:19.241+0200 I/utils   (22259): specific action
04-23 12:38:19.241+0200 I/recorder(22259): obteniendo datos locales...
04-23 12:38:19.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22259
04-23 12:38:19.241+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22259) type(svcapp) bg(0)
04-23 12:38:19.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:19.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22247
04-23 12:38:19.251+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22259) was created
04-23 12:38:19.261+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22259]
04-23 12:38:19.261+0200 I/recorder(22259): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:19.261+0200 I/recorder(22259): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:19.281+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22259)
04-23 12:38:19.281+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:38:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:19.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22259
04-23 12:38:19.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:19.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:19.321+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22259
04-23 12:38:19.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:19.361+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11222597265631524479899
04-23 12:38:19.361+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:19.371+0200 W/AUL     (22267): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:38:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22259
04-23 12:38:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:19.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22259
04-23 12:38:19.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22259)
04-23 12:38:19.391+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:38:19.431+0200 I/accelerometer(22247): es.ugr.frailty.accelerometer listener destroyed
04-23 12:38:19.551+0200 W/AUL     (22275): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:38:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:38:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:38:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22247
04-23 12:38:19.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:38:19.561+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22247
04-23 12:38:19.561+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22247)
04-23 12:38:21.171+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:38:28.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:38:28.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:28.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:38:29.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:29.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:38:29.001+0200 I/utils   (20587): specific action
04-23 12:38:29.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:38:29.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:38:29.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:38:29.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:38:29.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:38:29.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:38:29.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:38:29.011+0200 I/httppostreq(20587): internet available
04-23 12:38:29.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:38:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:29.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:38:29.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:38:29.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:38:29.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:38:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:29.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:38:29.041+0200 I/utils   (20584): specific action
04-23 12:38:29.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:38:29.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:38:29.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:38:29.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:38:29.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:29.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:29.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22313
04-23 12:38:29.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22313
04-23 12:38:29.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(22313) type(svcapp) bg(0)
04-23 12:38:29.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22313)
04-23 12:38:29.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:38:29.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:29.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:29.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:38:29.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:38:29.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:38:29.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:38:29.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:38:29.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:38:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:38:29.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:38:29.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22313]
04-23 12:38:29.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22316
04-23 12:38:29.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:38:29.161+0200 E/CAPI_APPFW_APPLICATION(22313): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:29.161+0200 E/CAPI_APPFW_APPLICATION(22313): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:29.161+0200 I/utils   (22313): trying to start service: es.ugr.frailty.accelerometer
04-23 12:38:29.171+0200 I/utils   (22313): es.ugr.frailty.accelerometer sensor supported
04-23 12:38:29.181+0200 I/utils   (22313): es.ugr.frailty.accelerometer listener started
04-23 12:38:29.181+0200 I/accelerometer(22313): stopping es.ugr.frailty.accelerometer service
04-23 12:38:29.181+0200 E/CAPI_APPFW_APP_CONTROL(22313): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:38:29.181+0200 E/accelerometer(22313): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:38:29.181+0200 I/CAPI_APPFW_APPLICATION(22313): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:38:29.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22316
04-23 12:38:29.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(22316) type(svcapp) bg(0)
04-23 12:38:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:29.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22316)
04-23 12:38:29.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22316]
04-23 12:38:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22313
04-23 12:38:29.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22313) was created
04-23 12:38:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22313
04-23 12:38:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:38:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:38:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.211+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:38:29.211+0200 E/CAPI_APPFW_APPLICATION(22316): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:29.211+0200 E/CAPI_APPFW_APPLICATION(22316): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:38:29.211+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22316) was created
04-23 12:38:29.221+0200 I/utils   (22316): specific action
04-23 12:38:29.221+0200 I/recorder(22316): obteniendo datos locales...
04-23 12:38:29.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:29.231+0200 I/recorder(22316): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:38:29.231+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:38:29.241+0200 I/recorder(22316): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:38:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22316
04-23 12:38:29.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:38:29.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22316
04-23 12:38:29.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:38:29.311+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1122316726563152447990
