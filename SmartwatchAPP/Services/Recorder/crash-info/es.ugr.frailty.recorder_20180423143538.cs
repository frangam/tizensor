S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6858
Date: 2018-04-23 14:35:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7314648, r1   = 0xf7b561b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7b561b8, r5   = 0x00012cd0
r6   = 0xf7b68e88, r7   = 0xf7314250
r8   = 0x00000618, r9   = 0xf6df7824
r10  = 0xf7b4e9d8, fp   = 0x00000000
ip   = 0xf7313030, sp   = 0xffc96ba0
lr   = 0xf72575d0, pc   = 0xf72539fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     61640 KB
Buffers:     39780 KB
Cached:     221396 KB
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
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f698e000 f6991000 r-xp /lib/libattr.so.1.1.0
f699a000 f69a1000 r-xp /lib/libcrypt-2.13.so
f69d1000 f69d4000 r-xp /lib/libcap.so.2.21
f69dc000 f69de000 r-xp /usr/lib/libiri.so
f69e6000 f6a03000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a0c000 f6a10000 r-xp /usr/lib/libsmack.so.1.0.0
f6a1a000 f6a1c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a24000 f6a29000 r-xp /usr/lib/libffi.so.5.0.10
f6a31000 f6a32000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a3a000 f6a3c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a44000 f6a46000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a50000 f6a60000 r-xp /lib/libresolv-2.13.so
f6a64000 f6a7c000 r-xp /usr/lib/liblzma.so.5.0.3
f6a84000 f6a86000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a8e000 f6abd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ac6000 f6ad5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ade000 f6ae8000 r-xp /usr/lib/libsensord-shared.so
f6af1000 f6b25000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b2e000 f6c01000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c0c000 f6c22000 r-xp /lib/libz.so.1.2.5
f6c2a000 f6c30000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c39000 f6cae000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cb8000 f6cd2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cda000 f6ce0000 r-xp /lib/librt-2.13.so
f6ce9000 f6d07000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d11000 f6d12000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d1a000 f6d1f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d27000 f6df7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6df8000 f6e22000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e2b000 f6e42000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e4a000 f6eb3000 r-xp /lib/libm-2.13.so
f6ebc000 f6f50000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f63000 f6f68000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f70000 f6f77000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f7f000 f6fa9000 r-xp /usr/lib/libsensor.so.1.9.6
f6fb2000 f707e000 r-xp /usr/lib/libxml2.so.2.7.8
f708b000 f708d000 r-xp /usr/lib/libiniparser.so.0
f7096000 f7099000 r-xp /usr/lib/libbundle.so.0.1.22
f70a1000 f70a7000 r-xp /usr/lib/libappsvc.so.0.1.0
f70af000 f70d2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70da000 f711b000 r-xp /usr/lib/libeina.so.1.7.99
f7124000 f713b000 r-xp /usr/lib/libecore.so.1.7.99
f7152000 f715b000 r-xp /usr/lib/libvconf.so.0.2.45
f7163000 f7177000 r-xp /lib/libpthread-2.13.so
f7182000 f718f000 r-xp /usr/lib/libaul.so.0.1.0
f7199000 f719b000 r-xp /lib/libdl-2.13.so
f71a4000 f71af000 r-xp /lib/libunwind.so.8.0.1
f71dc000 f71e4000 r-xp /lib/libgcc_s-4.6.so.1
f71e5000 f7309000 r-xp /lib/libc-2.13.so
f7317000 f7319000 r-xp /usr/lib/libdlog.so.0.0.0
f7321000 f732d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7336000 f733b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7343000 f7347000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7350000 f7352000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f735b000 f735e000 r-xp /usr/lib/libappcore-agent.so.1.1
f737c000 f7399000 r-xp /lib/ld-2.13.so
f73a2000 f73a5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73a5000 f73a9000 r-xp /usr/lib/libsys-assert.so
f7b44000 f7b92000 rw-p [heap]
ffc78000 ffc99000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6858)
Call Stack Count: 1
 0: (0xf72539fc) [/lib/libc.so.6] + 0x6e9fc
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
ignal pid(6642)
04-23 14:34:58.691+0200 W/AUL     ( 6691): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6661
04-23 14:34:58.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:34:58.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6661
04-23 14:34:58.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6661)
04-23 14:34:59.851+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 14:34:59.861+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 14:34:59.871+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(pedometer_goal_achieve_percents) error
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 14:34:59.871+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(best_step_goal) error
04-23 14:34:59.871+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:34:59.881+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:34:59.891+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 14:34:59.911+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 14:35:00.211+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.281+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.331+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:00.501+0200 W/SHealthService( 3091): ContextSleepMonitorProxy.cpp: SOnContextAutoSleepMonitorUpdatedCB(126) > [1;35mSleep monitor cb is called[0;m
04-23 14:35:17.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:35:17.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:17.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:35:18.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:35:18.001+0200 I/utils   ( 4443): specific action
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:35:18.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:35:18.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:35:18.001+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:35:18.001+0200 I/httppostreq( 4443): internet connection type...
04-23 14:35:18.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:35:18.011+0200 I/httppostreq( 4443): internet available
04-23 14:35:18.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:35:18.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:35:18.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:35:18.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:18.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 I/utils   ( 4440): specific action
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:18.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:35:18.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:35:18.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:35:18.031+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:35:18.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6735
04-23 14:35:18.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6735
04-23 14:35:18.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6735) type(svcapp) bg(0)
04-23 14:35:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6735)
04-23 14:35:18.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:35:18.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:35:18.111+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6735]
04-23 14:35:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6738
04-23 14:35:18.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.151+0200 E/CAPI_APPFW_APPLICATION( 6735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.151+0200 E/CAPI_APPFW_APPLICATION( 6735): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.151+0200 I/utils   ( 6735): trying to start service: es.ugr.frailty.accelerometer
04-23 14:35:18.161+0200 I/utils   ( 6735): es.ugr.frailty.accelerometer sensor supported
04-23 14:35:18.171+0200 I/utils   ( 6735): es.ugr.frailty.accelerometer listener started
04-23 14:35:18.171+0200 I/accelerometer( 6735): stopping es.ugr.frailty.accelerometer service
04-23 14:35:18.171+0200 E/CAPI_APPFW_APP_CONTROL( 6735): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.171+0200 E/accelerometer( 6735): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.171+0200 I/CAPI_APPFW_APPLICATION( 6735): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6738
04-23 14:35:18.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6738) type(svcapp) bg(0)
04-23 14:35:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6738)
04-23 14:35:18.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:35:18.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:35:18.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6738]
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6735
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6735) was created
04-23 14:35:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6735
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.201+0200 E/CAPI_APPFW_APPLICATION( 6738): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.201+0200 E/CAPI_APPFW_APPLICATION( 6738): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.201+0200 I/utils   ( 6738): trying to start service: es.ugr.frailty.gyroscope
04-23 14:35:18.211+0200 I/utils   ( 6738): es.ugr.frailty.gyroscope sensor supported
04-23 14:35:18.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6758
04-23 14:35:18.221+0200 I/utils   ( 6738): es.ugr.frailty.gyroscope listener started
04-23 14:35:18.221+0200 I/gyroscope( 6738): stopping es.ugr.frailty.gyroscope service
04-23 14:35:18.221+0200 E/CAPI_APPFW_APP_CONTROL( 6738): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.221+0200 E/gyroscope( 6738): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.221+0200 I/CAPI_APPFW_APPLICATION( 6738): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6758
04-23 14:35:18.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6758) type(svcapp) bg(0)
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6738) was created
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.281+0200 E/CAPI_APPFW_APPLICATION( 6758): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.281+0200 E/CAPI_APPFW_APPLICATION( 6758): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6758) was created
04-23 14:35:18.281+0200 I/utils   ( 6758): trying to start service: es.ugr.frailty.heartrate
04-23 14:35:18.291+0200 I/utils   ( 6758): es.ugr.frailty.heartrate sensor supported
04-23 14:35:18.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6738
04-23 14:35:18.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.311+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6758]
04-23 14:35:18.321+0200 I/utils   ( 6758): es.ugr.frailty.heartrate listener started
04-23 14:35:18.321+0200 I/heartrate( 6758): stopping es.ugr.frailty.heartrate service
04-23 14:35:18.321+0200 E/CAPI_APPFW_APP_CONTROL( 6758): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.321+0200 E/heartrate( 6758): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:18.321+0200 I/CAPI_APPFW_APPLICATION( 6758): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:18.321+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6758)
04-23 14:35:18.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.321+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:35:18.321+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:35:18.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:18.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:18.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:35:18.331+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:35:18.331+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6738
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6758
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:18.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:18.351+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6772
04-23 14:35:18.371+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:18.401+0200 E/CAPI_APPFW_APPLICATION( 6772): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.401+0200 E/CAPI_APPFW_APPLICATION( 6772): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:18.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6772
04-23 14:35:18.401+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6772) type(svcapp) bg(0)
04-23 14:35:18.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.411+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6772) was created
04-23 14:35:18.411+0200 I/utils   ( 6772): specific action
04-23 14:35:18.411+0200 I/recorder( 6772): obteniendo datos locales...
04-23 14:35:18.411+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6772]
04-23 14:35:18.421+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6772)
04-23 14:35:18.421+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6772
04-23 14:35:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6758
04-23 14:35:18.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.451+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.491+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.501+0200 I/accelerometer( 6735): es.ugr.frailty.accelerometer listener destroyed
04-23 14:35:18.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:18.521+0200 I/recorder( 6772): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:35:18.521+0200 I/recorder( 6772): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:35:18.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6772
04-23 14:35:18.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:18.521+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:35:18.551+0200 I/gyroscope( 6738): es.ugr.frailty.gyroscope listener destroyed
04-23 14:35:18.551+0200 I/heartrate( 6758): es.ugr.frailty.heartrate listener destroyed
04-23 14:35:18.571+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11067727265631524486918
04-23 14:35:18.591+0200 W/AUL     ( 6782): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:35:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:35:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:35:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6772
04-23 14:35:18.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:35:18.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6772
04-23 14:35:18.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6772)
04-23 14:35:18.631+0200 W/AUL     ( 6784): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:35:18.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:35:18.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:35:18.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6735
04-23 14:35:18.631+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:35:18.631+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6735
04-23 14:35:18.631+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6735)
04-23 14:35:18.681+0200 W/AUL     ( 6788): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:35:18.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:35:18.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:35:18.681+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6738
04-23 14:35:18.681+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:35:18.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6738
04-23 14:35:18.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6738)
04-23 14:35:18.701+0200 W/AUL     ( 6789): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:35:18.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:35:18.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:35:18.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6758
04-23 14:35:18.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:35:18.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6758
04-23 14:35:18.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6758)
04-23 14:35:20.201+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:20.271+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:20.331+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:35:37.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:35:37.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:37.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:35:38.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:35:38.011+0200 I/utils   ( 4443): specific action
04-23 14:35:38.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:35:38.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:35:38.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:35:38.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:35:38.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:35:38.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:35:38.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:35:38.011+0200 I/httppostreq( 4443): internet available
04-23 14:35:38.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:35:38.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:38.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:35:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:35:38.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:35:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:35:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:38.031+0200 I/utils   ( 4440): specific action
04-23 14:35:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:35:38.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:35:38.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:35:38.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:35:38.031+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:35:38.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:38.051+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6831
04-23 14:35:38.051+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:38.101+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6831
04-23 14:35:38.101+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6831) type(svcapp) bg(0)
04-23 14:35:38.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6831)
04-23 14:35:38.101+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:35:38.101+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:38.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:35:38.111+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6831]
04-23 14:35:38.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:38.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:38.121+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6834
04-23 14:35:38.121+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:38.141+0200 E/CAPI_APPFW_APPLICATION( 6831): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.141+0200 E/CAPI_APPFW_APPLICATION( 6831): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.141+0200 I/utils   ( 6831): trying to start service: es.ugr.frailty.accelerometer
04-23 14:35:38.151+0200 I/utils   ( 6831): es.ugr.frailty.accelerometer sensor supported
04-23 14:35:38.161+0200 I/utils   ( 6831): es.ugr.frailty.accelerometer listener started
04-23 14:35:38.161+0200 I/accelerometer( 6831): stopping es.ugr.frailty.accelerometer service
04-23 14:35:38.161+0200 E/CAPI_APPFW_APP_CONTROL( 6831): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.161+0200 E/accelerometer( 6831): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:38.161+0200 I/CAPI_APPFW_APPLICATION( 6831): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:38.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6834
04-23 14:35:38.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6834) type(svcapp) bg(0)
04-23 14:35:38.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.181+0200 E/CAPI_APPFW_APPLICATION( 6834): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.181+0200 E/CAPI_APPFW_APPLICATION( 6834): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.181+0200 I/utils   ( 6834): trying to start service: es.ugr.frailty.gyroscope
04-23 14:35:38.181+0200 I/utils   ( 6834): es.ugr.frailty.gyroscope sensor supported
04-23 14:35:38.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6831
04-23 14:35:38.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6831) was created
04-23 14:35:38.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6834) was created
04-23 14:35:38.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.191+0200 I/utils   ( 6834): es.ugr.frailty.gyroscope listener started
04-23 14:35:38.191+0200 I/gyroscope( 6834): stopping es.ugr.frailty.gyroscope service
04-23 14:35:38.191+0200 E/CAPI_APPFW_APP_CONTROL( 6834): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.191+0200 E/gyroscope( 6834): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:35:38.191+0200 I/CAPI_APPFW_APPLICATION( 6834): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:35:38.201+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6834)
04-23 14:35:38.201+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:35:38.201+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:38.201+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6831
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:38.201+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:38.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6854
04-23 14:35:38.231+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6834]
04-23 14:35:38.231+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:38.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6854
04-23 14:35:38.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6854) type(svcapp) bg(0)
04-23 14:35:38.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.271+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6854]
04-23 14:35:38.271+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6854)
04-23 14:35:38.271+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:35:38.271+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:35:38.271+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:35:38.271+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:35:38.271+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:35:38.271+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:35:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6834
04-23 14:35:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:35:38.281+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:35:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6858
04-23 14:35:38.331+0200 E/CAPI_APPFW_APPLICATION( 6858): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.331+0200 E/CAPI_APPFW_APPLICATION( 6858): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:35:38.331+0200 I/utils   ( 6858): specific action
04-23 14:35:38.331+0200 I/recorder( 6858): obteniendo datos locales...
04-23 14:35:38.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6858
04-23 14:35:38.351+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6858) type(svcapp) bg(0)
04-23 14:35:38.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.351+0200 I/recorder( 6858): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:35:38.351+0200 I/recorder( 6858): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:35:38.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6834
04-23 14:35:38.351+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6858) was created
04-23 14:35:38.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:38.361+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6858]
04-23 14:35:38.361+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6858)
04-23 14:35:38.361+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:35:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:38.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6854
04-23 14:35:38.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:35:38.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:35:38.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 14:35:38.401+0200 E/CAPI_APPFW_APP_MANAGER( 3091): app_manager.c: app_manager_error(77) > [app_context_get_app_context] No such application(0xfeef0001)
04-23 14:35:38.401+0200 E/CAPI_APPFW_APP_MANAGER( 3091): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 14:35:38.411+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:35:38.411+0200 E/RESOURCED( 2584): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/6858/oom_score_adj failed
04-23 14:35:38.411+0200 E/RESOURCED( 2584): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 6858
04-23 14:35:38.421+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106858726563152448693
