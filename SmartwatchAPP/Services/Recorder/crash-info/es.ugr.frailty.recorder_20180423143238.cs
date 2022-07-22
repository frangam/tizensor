S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 5962
Date: 2018-04-23 14:32:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7334648, r1   = 0xf74981b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf74981b8, r5   = 0x00012cd0
r6   = 0xf74aae88, r7   = 0xf7334250
r8   = 0x00000618, r9   = 0xf6e17824
r10  = 0xf74909d8, fp   = 0x00000000
ip   = 0xf7333030, sp   = 0xffad7650
lr   = 0xf72775d0, pc   = 0xf72739fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     66168 KB
Buffers:     37796 KB
Cached:     220284 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7712 KB
VmRSS:        7708 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f69ae000 f69b1000 r-xp /lib/libattr.so.1.1.0
f69ba000 f69c1000 r-xp /lib/libcrypt-2.13.so
f69f1000 f69f4000 r-xp /lib/libcap.so.2.21
f69fc000 f69fe000 r-xp /usr/lib/libiri.so
f6a06000 f6a23000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a2c000 f6a30000 r-xp /usr/lib/libsmack.so.1.0.0
f6a3a000 f6a3c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a44000 f6a49000 r-xp /usr/lib/libffi.so.5.0.10
f6a51000 f6a52000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a5a000 f6a5c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a64000 f6a66000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a70000 f6a80000 r-xp /lib/libresolv-2.13.so
f6a84000 f6a9c000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa4000 f6aa6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aae000 f6add000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ae6000 f6af5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6afe000 f6b08000 r-xp /usr/lib/libsensord-shared.so
f6b11000 f6b45000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b4e000 f6c21000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c2c000 f6c42000 r-xp /lib/libz.so.1.2.5
f6c4a000 f6c50000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c59000 f6cce000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cd8000 f6cf2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cfa000 f6d00000 r-xp /lib/librt-2.13.so
f6d09000 f6d27000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d31000 f6d32000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3a000 f6d3f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d47000 f6e17000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e18000 f6e42000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e4b000 f6e62000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e6a000 f6ed3000 r-xp /lib/libm-2.13.so
f6edc000 f6f70000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f83000 f6f88000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f90000 f6f97000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f9f000 f6fc9000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd2000 f709e000 r-xp /usr/lib/libxml2.so.2.7.8
f70ab000 f70ad000 r-xp /usr/lib/libiniparser.so.0
f70b6000 f70b9000 r-xp /usr/lib/libbundle.so.0.1.22
f70c1000 f70c7000 r-xp /usr/lib/libappsvc.so.0.1.0
f70cf000 f70f2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70fa000 f713b000 r-xp /usr/lib/libeina.so.1.7.99
f7144000 f715b000 r-xp /usr/lib/libecore.so.1.7.99
f7172000 f717b000 r-xp /usr/lib/libvconf.so.0.2.45
f7183000 f7197000 r-xp /lib/libpthread-2.13.so
f71a2000 f71af000 r-xp /usr/lib/libaul.so.0.1.0
f71b9000 f71bb000 r-xp /lib/libdl-2.13.so
f71c4000 f71cf000 r-xp /lib/libunwind.so.8.0.1
f71fc000 f7204000 r-xp /lib/libgcc_s-4.6.so.1
f7205000 f7329000 r-xp /lib/libc-2.13.so
f7337000 f7339000 r-xp /usr/lib/libdlog.so.0.0.0
f7341000 f734d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7356000 f735b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7363000 f7367000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7370000 f7372000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f737b000 f737e000 r-xp /usr/lib/libappcore-agent.so.1.1
f739c000 f73b9000 r-xp /lib/ld-2.13.so
f73c2000 f73c5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73c5000 f73c9000 r-xp /usr/lib/libsys-assert.so
f7486000 f74d4000 rw-p [heap]
ffab9000 ffada000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5962)
Call Stack Count: 1
 0: (0xf72739fc) [/lib/libc.so.6] + 0x6e9fc
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
imer_cb(168) > send SIGKILL: No such process
04-23 14:32:00.291+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:32:00.311+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:32:17.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:32:17.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:17.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:32:18.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:32:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:32:18.011+0200 I/utils   ( 4443): specific action
04-23 14:32:18.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:32:18.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:32:18.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:32:18.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:32:18.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:32:18.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:32:18.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:32:18.011+0200 I/httppostreq( 4443): internet available
04-23 14:32:18.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:32:18.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:18.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:32:18.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:32:18.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:32:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:32:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:18.041+0200 I/utils   ( 4440): specific action
04-23 14:32:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:18.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:32:18.041+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:32:18.041+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:32:18.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:32:18.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:18.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5835
04-23 14:32:18.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:18.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5835
04-23 14:32:18.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5835) type(svcapp) bg(0)
04-23 14:32:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5835)
04-23 14:32:18.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:32:18.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:32:18.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:18.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5835]
04-23 14:32:18.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:18.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5838
04-23 14:32:18.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:18.151+0200 E/CAPI_APPFW_APPLICATION( 5835): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.151+0200 E/CAPI_APPFW_APPLICATION( 5835): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.151+0200 I/utils   ( 5835): trying to start service: es.ugr.frailty.accelerometer
04-23 14:32:18.161+0200 I/utils   ( 5835): es.ugr.frailty.accelerometer sensor supported
04-23 14:32:18.171+0200 I/utils   ( 5835): es.ugr.frailty.accelerometer listener started
04-23 14:32:18.171+0200 I/accelerometer( 5835): stopping es.ugr.frailty.accelerometer service
04-23 14:32:18.171+0200 E/CAPI_APPFW_APP_CONTROL( 5835): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.171+0200 E/accelerometer( 5835): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:18.171+0200 I/CAPI_APPFW_APPLICATION( 5835): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:18.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5838
04-23 14:32:18.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5838) type(svcapp) bg(0)
04-23 14:32:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.181+0200 E/CAPI_APPFW_APPLICATION( 5838): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.181+0200 E/CAPI_APPFW_APPLICATION( 5838): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.191+0200 I/utils   ( 5838): trying to start service: es.ugr.frailty.gyroscope
04-23 14:32:18.191+0200 I/utils   ( 5838): es.ugr.frailty.gyroscope sensor supported
04-23 14:32:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5835
04-23 14:32:18.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5835) was created
04-23 14:32:18.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5838) was created
04-23 14:32:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.201+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5838]
04-23 14:32:18.201+0200 I/utils   ( 5838): es.ugr.frailty.gyroscope listener started
04-23 14:32:18.201+0200 I/gyroscope( 5838): stopping es.ugr.frailty.gyroscope service
04-23 14:32:18.201+0200 E/CAPI_APPFW_APP_CONTROL( 5838): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.201+0200 E/gyroscope( 5838): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:18.201+0200 I/CAPI_APPFW_APPLICATION( 5838): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5835
04-23 14:32:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:18.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:18.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:18.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:18.221+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5838)
04-23 14:32:18.221+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:32:18.221+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:18.221+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:32:18.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5838
04-23 14:32:18.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:18.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:18.241+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5861
04-23 14:32:18.281+0200 E/CAPI_APPFW_APPLICATION( 5861): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.281+0200 E/CAPI_APPFW_APPLICATION( 5861): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.281+0200 I/utils   ( 5861): trying to start service: es.ugr.frailty.heartrate
04-23 14:32:18.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5861
04-23 14:32:18.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5861) type(svcapp) bg(0)
04-23 14:32:18.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5861) was created
04-23 14:32:18.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5838
04-23 14:32:18.301+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:18.311+0200 I/utils   ( 5861): es.ugr.frailty.heartrate sensor supported
04-23 14:32:18.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5861)
04-23 14:32:18.311+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:32:18.311+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:18.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:18.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:32:18.311+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:32:18.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:32:18.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:18.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:18.321+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5866
04-23 14:32:18.331+0200 I/utils   ( 5861): es.ugr.frailty.heartrate listener started
04-23 14:32:18.331+0200 I/heartrate( 5861): stopping es.ugr.frailty.heartrate service
04-23 14:32:18.331+0200 E/CAPI_APPFW_APP_CONTROL( 5861): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.331+0200 E/heartrate( 5861): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:18.331+0200 I/CAPI_APPFW_APPLICATION( 5861): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:18.351+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5861]
04-23 14:32:18.351+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:18.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5866
04-23 14:32:18.381+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5866) type(svcapp) bg(0)
04-23 14:32:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.381+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5866)
04-23 14:32:18.381+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:32:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5861
04-23 14:32:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.401+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5866]
04-23 14:32:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5866
04-23 14:32:18.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.421+0200 E/CAPI_APPFW_APPLICATION( 5866): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5861
04-23 14:32:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.461+0200 E/CAPI_APPFW_APPLICATION( 5866): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:18.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:18.471+0200 I/utils   ( 5866): specific action
04-23 14:32:18.471+0200 I/recorder( 5866): obteniendo datos locales...
04-23 14:32:18.471+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5866
04-23 14:32:18.471+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5866) was created
04-23 14:32:18.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:18.481+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.491+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.491+0200 I/recorder( 5866): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:32:18.491+0200 I/recorder( 5866): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:32:18.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.511+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.541+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:18.561+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11058667265631524486738
04-23 14:32:18.571+0200 I/gyroscope( 5838): es.ugr.frailty.gyroscope listener destroyed
04-23 14:32:18.581+0200 W/AUL     ( 5883): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:32:18.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:32:18.581+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:32:18.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5866
04-23 14:32:18.581+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:32:18.581+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5866
04-23 14:32:18.581+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5866)
04-23 14:32:18.581+0200 I/accelerometer( 5835): es.ugr.frailty.accelerometer listener destroyed
04-23 14:32:18.591+0200 I/heartrate( 5861): es.ugr.frailty.heartrate listener destroyed
04-23 14:32:18.741+0200 W/AUL     ( 5890): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:32:18.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:32:18.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:32:18.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5835
04-23 14:32:18.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:32:18.751+0200 W/AUL     ( 5889): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:32:18.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:32:18.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:32:18.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5861
04-23 14:32:18.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:32:18.751+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5835
04-23 14:32:18.751+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5835)
04-23 14:32:18.761+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5861
04-23 14:32:18.761+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5861)
04-23 14:32:18.771+0200 W/AUL     ( 5891): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:32:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:32:18.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:32:18.781+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5838
04-23 14:32:18.781+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:32:18.781+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5838
04-23 14:32:18.781+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5838)
04-23 14:32:20.211+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:32:20.211+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:32:20.381+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:32:37.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:32:37.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:37.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:37.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:32:38.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:32:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:32:38.001+0200 I/utils   ( 4443): specific action
04-23 14:32:38.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:32:38.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:32:38.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:32:38.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:32:38.001+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:32:38.001+0200 I/httppostreq( 4443): internet connection type...
04-23 14:32:38.001+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:32:38.001+0200 I/httppostreq( 4443): internet available
04-23 14:32:38.001+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:32:38.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:38.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:32:38.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:32:38.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:32:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:32:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:38.031+0200 I/utils   ( 4440): specific action
04-23 14:32:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:38.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:32:38.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:32:38.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:32:38.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:32:38.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:32:38.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:38.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:38.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:38.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5932
04-23 14:32:38.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5932
04-23 14:32:38.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5932) type(svcapp) bg(0)
04-23 14:32:38.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5932)
04-23 14:32:38.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:32:38.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:38.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:32:38.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5932]
04-23 14:32:38.121+0200 E/CAPI_APPFW_APPLICATION( 5932): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.121+0200 E/CAPI_APPFW_APPLICATION( 5932): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.121+0200 I/utils   ( 5932): trying to start service: es.ugr.frailty.accelerometer
04-23 14:32:38.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:38.131+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:38.141+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5935
04-23 14:32:38.141+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:38.141+0200 I/utils   ( 5932): es.ugr.frailty.accelerometer sensor supported
04-23 14:32:38.161+0200 I/utils   ( 5932): es.ugr.frailty.accelerometer listener started
04-23 14:32:38.161+0200 I/accelerometer( 5932): stopping es.ugr.frailty.accelerometer service
04-23 14:32:38.161+0200 E/CAPI_APPFW_APP_CONTROL( 5932): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.161+0200 E/accelerometer( 5932): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:38.161+0200 I/CAPI_APPFW_APPLICATION( 5932): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:38.191+0200 E/CAPI_APPFW_APPLICATION( 5935): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.191+0200 E/CAPI_APPFW_APPLICATION( 5935): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.191+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5935
04-23 14:32:38.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5935) type(svcapp) bg(0)
04-23 14:32:38.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5932
04-23 14:32:38.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5932) was created
04-23 14:32:38.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5935) was created
04-23 14:32:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.201+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5935)
04-23 14:32:38.201+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:32:38.201+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:38.201+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:32:38.211+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5932
04-23 14:32:38.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:38.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:38.221+0200 I/utils   ( 5935): trying to start service: es.ugr.frailty.gyroscope
04-23 14:32:38.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:38.231+0200 I/utils   ( 5935): es.ugr.frailty.gyroscope sensor supported
04-23 14:32:38.231+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5950
04-23 14:32:38.231+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5935]
04-23 14:32:38.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:38.261+0200 I/utils   ( 5935): es.ugr.frailty.gyroscope listener started
04-23 14:32:38.261+0200 I/gyroscope( 5935): stopping es.ugr.frailty.gyroscope service
04-23 14:32:38.261+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.271+0200 E/CAPI_APPFW_APP_CONTROL( 5935): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.271+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.281+0200 E/gyroscope( 5935): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:38.281+0200 I/CAPI_APPFW_APPLICATION( 5935): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:38.281+0200 E/CAPI_APPFW_APPLICATION( 5950): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.281+0200 E/CAPI_APPFW_APPLICATION( 5950): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.281+0200 I/utils   ( 5950): trying to start service: es.ugr.frailty.heartrate
04-23 14:32:38.281+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5950
04-23 14:32:38.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5950) type(svcapp) bg(0)
04-23 14:32:38.281+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5950)
04-23 14:32:38.281+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:32:38.281+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:32:38.281+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:32:38.281+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:32:38.281+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:32:38.281+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:32:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.281+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5950) was created
04-23 14:32:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:32:38.291+0200 I/utils   ( 5950): es.ugr.frailty.heartrate sensor supported
04-23 14:32:38.291+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5950]
04-23 14:32:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:32:38.301+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5962
04-23 14:32:38.301+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:32:38.321+0200 I/utils   ( 5950): es.ugr.frailty.heartrate listener started
04-23 14:32:38.321+0200 I/heartrate( 5950): stopping es.ugr.frailty.heartrate service
04-23 14:32:38.321+0200 E/CAPI_APPFW_APP_CONTROL( 5950): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.321+0200 E/heartrate( 5950): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:32:38.321+0200 I/CAPI_APPFW_APPLICATION( 5950): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:32:38.351+0200 E/CAPI_APPFW_APPLICATION( 5962): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.351+0200 E/CAPI_APPFW_APPLICATION( 5962): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:32:38.351+0200 I/utils   ( 5962): specific action
04-23 14:32:38.351+0200 I/recorder( 5962): obteniendo datos locales...
04-23 14:32:38.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5962
04-23 14:32:38.351+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5962) type(svcapp) bg(0)
04-23 14:32:38.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.361+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5962)
04-23 14:32:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5935
04-23 14:32:38.361+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5962) was created
04-23 14:32:38.361+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:32:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:32:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:32:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.371+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5935
04-23 14:32:38.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.381+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5962]
04-23 14:32:38.391+0200 I/recorder( 5962): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:32:38.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:32:38.391+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:32:38.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5950
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:32:38.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:32:38.401+0200 I/recorder( 5962): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:32:38.401+0200 I/accelerometer( 5932): es.ugr.frailty.accelerometer listener destroyed
04-23 14:32:38.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5962
04-23 14:32:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5950
04-23 14:32:38.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.481+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.511+0200 I/heartrate( 5950): es.ugr.frailty.heartrate listener destroyed
04-23 14:32:38.521+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.531+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 14:32:38.541+0200 W/AUL     ( 5977): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:32:38.541+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:32:38.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5962
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5932
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:32:38.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:32:38.561+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5932
04-23 14:32:38.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5932)
04-23 14:32:38.571+0200 I/gyroscope( 5935): es.ugr.frailty.gyroscope listener destroyed
04-23 14:32:38.591+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1105962726563152448675
