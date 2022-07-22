S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 23630
Date: 2018-04-23 12:41:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf741c648, r1   = 0xf7ae91b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7ae91b8, r5   = 0x00012cd0
r6   = 0xf7afbe88, r7   = 0xf741c250
r8   = 0x000005d8, r9   = 0xf6eff824
r10  = 0xf7ae19d8, fp   = 0x00000000
ip   = 0xf741b030, sp   = 0xffaa5e38
lr   = 0xf735f5d0, pc   = 0xf735b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      7512 KB
Buffers:     71224 KB
Cached:     191568 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7696 KB
VmRSS:        7692 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6a96000 f6a99000 r-xp /lib/libattr.so.1.1.0
f6aa2000 f6aa9000 r-xp /lib/libcrypt-2.13.so
f6ad9000 f6adc000 r-xp /lib/libcap.so.2.21
f6ae4000 f6ae6000 r-xp /usr/lib/libiri.so
f6aee000 f6b0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b14000 f6b18000 r-xp /usr/lib/libsmack.so.1.0.0
f6b22000 f6b24000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b2c000 f6b31000 r-xp /usr/lib/libffi.so.5.0.10
f6b39000 f6b3a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b42000 f6b44000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b4c000 f6b4e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b58000 f6b68000 r-xp /lib/libresolv-2.13.so
f6b6c000 f6b84000 r-xp /usr/lib/liblzma.so.5.0.3
f6b8c000 f6b8e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b96000 f6bc5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bce000 f6bdd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6be6000 f6bf0000 r-xp /usr/lib/libsensord-shared.so
f6bf9000 f6c2d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c36000 f6d09000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d14000 f6d2a000 r-xp /lib/libz.so.1.2.5
f6d32000 f6d38000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d41000 f6db6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dc0000 f6dda000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6de2000 f6de8000 r-xp /lib/librt-2.13.so
f6df1000 f6e0f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e19000 f6e1a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e22000 f6e27000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e2f000 f6eff000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f00000 f6f2a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f33000 f6f4a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f52000 f6fbb000 r-xp /lib/libm-2.13.so
f6fc4000 f7058000 r-xp /usr/lib/libstdc++.so.6.0.16
f706b000 f7070000 r-xp /usr/lib/libctx-client.so.0.8.3
f7078000 f707f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7087000 f70b1000 r-xp /usr/lib/libsensor.so.1.9.6
f70ba000 f7186000 r-xp /usr/lib/libxml2.so.2.7.8
f7193000 f7195000 r-xp /usr/lib/libiniparser.so.0
f719e000 f71a1000 r-xp /usr/lib/libbundle.so.0.1.22
f71a9000 f71af000 r-xp /usr/lib/libappsvc.so.0.1.0
f71b7000 f71da000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71e2000 f7223000 r-xp /usr/lib/libeina.so.1.7.99
f722c000 f7243000 r-xp /usr/lib/libecore.so.1.7.99
f725a000 f7263000 r-xp /usr/lib/libvconf.so.0.2.45
f726b000 f727f000 r-xp /lib/libpthread-2.13.so
f728a000 f7297000 r-xp /usr/lib/libaul.so.0.1.0
f72a1000 f72a3000 r-xp /lib/libdl-2.13.so
f72ac000 f72b7000 r-xp /lib/libunwind.so.8.0.1
f72e4000 f72ec000 r-xp /lib/libgcc_s-4.6.so.1
f72ed000 f7411000 r-xp /lib/libc-2.13.so
f741f000 f7421000 r-xp /usr/lib/libdlog.so.0.0.0
f7429000 f7435000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f743e000 f7443000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f744b000 f744f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7458000 f745a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7463000 f7466000 r-xp /usr/lib/libappcore-agent.so.1.1
f7484000 f74a1000 r-xp /lib/ld-2.13.so
f74aa000 f74ad000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f74ad000 f74b1000 r-xp /usr/lib/libsys-assert.so
f7ad7000 f7b25000 rw-p [heap]
ffa88000 ffaa9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:23630)
Call Stack Count: 1
 0: (0xf735b9fc) [/lib/libc.so.6] + 0x6e9fc
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
12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:29.291+0200 I/recorder(23466): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23466
04-23 12:41:29.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:29.351+0200 W/AUL     (23471): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23466
04-23 12:41:29.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:29.351+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11234667265631524480089
04-23 12:41:29.361+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23466
04-23 12:41:29.361+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23466)
04-23 12:41:29.421+0200 W/AUL     (23475): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23453
04-23 12:41:29.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:29.421+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23453
04-23 12:41:29.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23453)
04-23 12:41:31.171+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 3
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524480004, curr_wall_time = 1524480094
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 90 seconds
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 93 seconds
04-23 12:41:34.251+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 84, charging remaining time = 25 minutes
04-23 12:41:38.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:38.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:38.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:39.011+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:39.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:39.011+0200 I/utils   (20587): specific action
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:39.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:39.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:39.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:39.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:39.011+0200 I/httppostreq(20587): internet available
04-23 12:41:39.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:39.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:39.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:39.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:39.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:39.051+0200 I/utils   (20584): specific action
04-23 12:41:39.051+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:39.051+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:39.051+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:39.051+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:39.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23494
04-23 12:41:39.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:39.081+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:39.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23494
04-23 12:41:39.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23494) type(svcapp) bg(0)
04-23 12:41:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23494)
04-23 12:41:39.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:39.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:39.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:39.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:39.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:39.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:39.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:39.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:39.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:39.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23494]
04-23 12:41:39.141+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23497
04-23 12:41:39.141+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:39.151+0200 E/CAPI_APPFW_APPLICATION(23494): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.151+0200 E/CAPI_APPFW_APPLICATION(23494): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.151+0200 I/utils   (23494): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:39.171+0200 I/utils   (23494): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:39.181+0200 I/utils   (23494): es.ugr.frailty.accelerometer listener started
04-23 12:41:39.181+0200 I/accelerometer(23494): stopping es.ugr.frailty.accelerometer service
04-23 12:41:39.181+0200 E/CAPI_APPFW_APP_CONTROL(23494): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.181+0200 E/accelerometer(23494): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:39.181+0200 I/CAPI_APPFW_APPLICATION(23494): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:39.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23497
04-23 12:41:39.191+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23497) type(svcapp) bg(0)
04-23 12:41:39.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23497)
04-23 12:41:39.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:39.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23497]
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23494
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23494) was created
04-23 12:41:39.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23494
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:39.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.221+0200 E/CAPI_APPFW_APPLICATION(23497): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.221+0200 E/CAPI_APPFW_APPLICATION(23497): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:39.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23497) was created
04-23 12:41:39.221+0200 I/utils   (23497): specific action
04-23 12:41:39.221+0200 I/recorder(23497): obteniendo datos locales...
04-23 12:41:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.231+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.241+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23497
04-23 12:41:39.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.261+0200 I/recorder(23497): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:39.261+0200 I/recorder(23497): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:39.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23497
04-23 12:41:39.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:39.311+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:39.321+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:39.331+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11234977265631524480099
04-23 12:41:39.351+0200 W/AUL     (23513): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23497
04-23 12:41:39.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:39.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23497
04-23 12:41:39.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23497)
04-23 12:41:39.361+0200 I/accelerometer(23494): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:39.421+0200 E/CAPI_SYSTEM_INFO( 3419): system_info_parse.c: system_info_get_value_from_config_xml(279) > cannot find tizen.org/feature/container field from /etc/config/model-config.xml file!!!
04-23 12:41:39.421+0200 E/CAPI_SYSTEM_INFO( 3419): system_info.c: system_info_get_platform_bool(293) > cannot get tizen.org/feature/container
04-23 12:41:39.491+0200 W/AUL     (23522): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23494
04-23 12:41:39.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:39.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23494
04-23 12:41:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23494)
04-23 12:41:41.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:41.991+0200 E/wnoti-ancs( 2999): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][5][0][63][0][0][0][0][0][0][0][0][0][0]
04-23 12:41:48.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:48.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:48.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:49.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:49.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:49.001+0200 I/utils   (20587): specific action
04-23 12:41:49.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:49.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:49.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:49.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:49.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:49.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:49.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:49.011+0200 I/httppostreq(20587): internet available
04-23 12:41:49.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:49.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:49.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:49.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:49.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:49.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:49.041+0200 I/utils   (20584): specific action
04-23 12:41:49.041+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:49.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:49.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:49.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:49.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:49.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:49.071+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23566
04-23 12:41:49.071+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23566
04-23 12:41:49.121+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23566) type(svcapp) bg(0)
04-23 12:41:49.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23566)
04-23 12:41:49.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:49.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:49.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:49.121+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:49.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:49.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:49.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:49.121+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:49.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:49.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:49.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:49.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23566]
04-23 12:41:49.131+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23569
04-23 12:41:49.131+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:49.161+0200 E/CAPI_APPFW_APPLICATION(23566): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:49.161+0200 E/CAPI_APPFW_APPLICATION(23566): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:49.171+0200 I/utils   (23566): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:49.171+0200 I/utils   (23566): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:49.181+0200 E/CAPI_APPFW_APPLICATION(23569): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:49.181+0200 E/CAPI_APPFW_APPLICATION(23569): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:49.181+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23569
04-23 12:41:49.181+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23569) type(svcapp) bg(0)
04-23 12:41:49.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:49.191+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23569)
04-23 12:41:49.191+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:49.191+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23569]
04-23 12:41:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23566
04-23 12:41:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23566) was created
04-23 12:41:49.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23569) was created
04-23 12:41:49.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:49.201+0200 I/utils   (23566): es.ugr.frailty.accelerometer listener started
04-23 12:41:49.201+0200 I/accelerometer(23566): stopping es.ugr.frailty.accelerometer service
04-23 12:41:49.201+0200 E/CAPI_APPFW_APP_CONTROL(23566): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:49.201+0200 E/accelerometer(23566): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:49.201+0200 I/CAPI_APPFW_APPLICATION(23566): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23566
04-23 12:41:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:49.211+0200 I/utils   (23569): specific action
04-23 12:41:49.211+0200 I/recorder(23569): obteniendo datos locales...
04-23 12:41:49.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:49.231+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23569
04-23 12:41:49.231+0200 I/recorder(23569): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:49.231+0200 I/recorder(23569): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:49.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:49.261+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23569
04-23 12:41:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:49.301+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 11235697265631524480109
04-23 12:41:49.311+0200 W/AUL     (23584): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:41:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23569
04-23 12:41:49.311+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:49.351+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23569
04-23 12:41:49.351+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23569)
04-23 12:41:49.361+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:49.371+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:49.391+0200 I/accelerometer(23566): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:49.511+0200 W/AUL     (23592): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:41:49.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:41:49.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:41:49.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 23566
04-23 12:41:49.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:41:49.531+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 23566
04-23 12:41:49.531+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(23566)
04-23 12:41:51.211+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:41:58.991+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:41:58.991+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:58.991+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20587
04-23 12:41:59.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:59.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20587), cmd(0)
04-23 12:41:59.001+0200 I/utils   (20587): specific action
04-23 12:41:59.001+0200 I/httppostreq(20587): internet connection check received
04-23 12:41:59.001+0200 I/httppostreq(20587): internet connection != null
04-23 12:41:59.011+0200 I/CAPI_NETWORK_CONNECTION(20587): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:41:59.011+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20587)
04-23 12:41:59.011+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.httppostreq
04-23 12:41:59.011+0200 I/httppostreq(20587): internet connection type...
04-23 12:41:59.011+0200 I/httppostreq(20587): internet connection type 1
04-23 12:41:59.011+0200 I/httppostreq(20587): internet available
04-23 12:41:59.011+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:41:59.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:59.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20587
04-23 12:41:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20584
04-23 12:41:59.031+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:41:59.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(20584), cmd(0)
04-23 12:41:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:59.031+0200 I/utils   (20584): specific action
04-23 12:41:59.031+0200 W/CAPI_APPFW_APP_CONTROL(20584): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:41:59.041+0200 I/servicemanager(20584): internet connection available. stop all sensors
04-23 12:41:59.041+0200 W/AUL     (20587): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20584)
04-23 12:41:59.041+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:41:59.041+0200 I/httppostreq(20587): request sent to service es.ugr.frailty.servicemanager
04-23 12:41:59.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:59.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:59.061+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23626
04-23 12:41:59.061+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:59.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23626
04-23 12:41:59.111+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(23626) type(svcapp) bg(0)
04-23 12:41:59.111+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23626]
04-23 12:41:59.121+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23626)
04-23 12:41:59.121+0200 I/servicemanager(20584): es.ugr.frailty.accelerometer stop request sent!
04-23 12:41:59.121+0200 I/servicemanager(20584): App control destroyed.
04-23 12:41:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:59.121+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:59.121+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:59.121+0200 E/servicemanager(20584): deleting timer 0
04-23 12:41:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:59.121+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:59.121+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:59.121+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:59.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:59.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:59.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:59.131+0200 E/servicemanager(20584): deleting timer 1
04-23 12:41:59.131+0200 E/EFL     (20584): ecore<20584> ecore.c:573 _ecore_magic_fail() 
04-23 12:41:59.131+0200 E/EFL     (20584): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:41:59.131+0200 E/EFL     (20584): *** IN FUNCTION: ecore_timer_del()
04-23 12:41:59.131+0200 E/EFL     (20584): ecore<20584> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:41:59.131+0200 E/EFL     (20584): ecore<20584> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:41:59.131+0200 E/EFL     (20584): *** SPANK SPANK SPANK!!!
04-23 12:41:59.131+0200 E/EFL     (20584): *** Now go fix your code. Tut tut tut!
04-23 12:41:59.131+0200 E/servicemanager(20584): deleting timer 2
04-23 12:41:59.131+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:41:59.131+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:59.141+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23626
04-23 12:41:59.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:41:59.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 20584
04-23 12:41:59.151+0200 E/CAPI_APPFW_APPLICATION(23626): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:59.151+0200 E/CAPI_APPFW_APPLICATION(23626): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:59.151+0200 I/utils   (23626): trying to start service: es.ugr.frailty.accelerometer
04-23 12:41:59.151+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 23630
04-23 12:41:59.151+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:41:59.161+0200 I/utils   (23626): es.ugr.frailty.accelerometer sensor supported
04-23 12:41:59.171+0200 I/utils   (23626): es.ugr.frailty.accelerometer listener started
04-23 12:41:59.171+0200 I/accelerometer(23626): stopping es.ugr.frailty.accelerometer service
04-23 12:41:59.171+0200 E/CAPI_APPFW_APP_CONTROL(23626): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:41:59.181+0200 E/accelerometer(23626): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:41:59.181+0200 I/CAPI_APPFW_APPLICATION(23626): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:41:59.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 23630
04-23 12:41:59.201+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(23630) type(svcapp) bg(0)
04-23 12:41:59.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:59.201+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23626) was created
04-23 12:41:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:59.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23626
04-23 12:41:59.221+0200 W/AUL     (20584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(23630)
04-23 12:41:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:41:59.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:41:59.221+0200 I/servicemanager(20584): request sent to service es.ugr.frailty.recorder
04-23 12:41:59.221+0200 E/CAPI_APPFW_APPLICATION(23630): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:59.221+0200 E/CAPI_APPFW_APPLICATION(23630): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:41:59.221+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (23630) was created
04-23 12:41:59.231+0200 I/utils   (23630): specific action
04-23 12:41:59.231+0200 I/recorder(23630): obteniendo datos locales...
04-23 12:41:59.251+0200 I/recorder(23630): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:41:538,9.853643,0.009571,0.844666
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:41:741,-0.038285,9.824929,0.830309
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:41:939,0.004786,9.789038,0.794417
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:42:139,-0.016750,9.846465,0.792024
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:42:338,-0.011964,9.781858,0.866202
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:42:538,-0.009571,9.822537,0.823131
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:42:740,-0.009571,9.791430,0.801596
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:42:943,-0.016750,9.784252,0.813560
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:43:138,-0.014357,9.793823,0.787239
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:43:338,-0.016750,9.779467,0.803988
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:43:538,-0.023928,9.815358,0.859023
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:43:738,0.004786,9.791430,0.813560
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:43:939,-0.031107,9.786645,0.823131
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:44:138,0.004786,9.844072,0.818345
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:44:338,0.004786,9.846465,0.863809
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:44:538,-0.007178,9.836893,0.780060
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:44:738,-0.019143,9.829715,0.870987
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:44:938,-0.011964,9.793823,0.796810
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:45:138,0.004786,9.803394,0.830309
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:45:337,0.038285,9.774680,0.794417
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:45:538,0.052642,9.820145,0.849452
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:45:738,-0.004786,9.846465,0.789631
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:45:937,-0.004786,9.820145,0.851845
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:46:137,-0.014357,9.812965,0.763310
04-23 12:41:59.251+0200 I/recorder(23630): SM-R760,23/04/2018,12:34:46:338,-0.011964,9.762716,0.811167
04-23 12:41:59.251+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [23630]
04-23 12:41:59.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23630
04-23 12:41:59.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:41:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 23630
04-23 12:41:59.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:59.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:41:59.291+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:59.301+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:41:59.311+0200 I/accelerometer(23626): es.ugr.frailty.accelerometer listener destroyed
04-23 12:41:59.341+0200 W/CRASH_MANAGER(20869): worker.c: worker_job(1205) > 1123630726563152448011
