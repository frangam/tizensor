S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 5778
Date: 2018-04-23 14:31:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf76f6648, r1   = 0xf78161b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78161b8, r5   = 0x00012cd0
r6   = 0xf7828e88, r7   = 0xf76f6250
r8   = 0x00000618, r9   = 0xf71d9824
r10  = 0xf780e9d8, fp   = 0x00000000
ip   = 0xf76f5030, sp   = 0xffb75fa0
lr   = 0xf76395d0, pc   = 0xf76359fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     65636 KB
Buffers:     37376 KB
Cached:     220124 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6d70000 f6d73000 r-xp /lib/libattr.so.1.1.0
f6d7c000 f6d83000 r-xp /lib/libcrypt-2.13.so
f6db3000 f6db6000 r-xp /lib/libcap.so.2.21
f6dbe000 f6dc0000 r-xp /usr/lib/libiri.so
f6dc8000 f6de5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6dee000 f6df2000 r-xp /usr/lib/libsmack.so.1.0.0
f6dfc000 f6dfe000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e06000 f6e0b000 r-xp /usr/lib/libffi.so.5.0.10
f6e13000 f6e14000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e1c000 f6e1e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e26000 f6e28000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e32000 f6e42000 r-xp /lib/libresolv-2.13.so
f6e46000 f6e5e000 r-xp /usr/lib/liblzma.so.5.0.3
f6e66000 f6e68000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e70000 f6e9f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ea8000 f6eb7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ec0000 f6eca000 r-xp /usr/lib/libsensord-shared.so
f6ed3000 f6f07000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f10000 f6fe3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6fee000 f7004000 r-xp /lib/libz.so.1.2.5
f700c000 f7012000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f701b000 f7090000 r-xp /usr/lib/libsqlite3.so.0.8.6
f709a000 f70b4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f70bc000 f70c2000 r-xp /lib/librt-2.13.so
f70cb000 f70e9000 r-xp /usr/lib/libsystemd.so.0.4.0
f70f3000 f70f4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70fc000 f7101000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7109000 f71d9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71da000 f7204000 r-xp /usr/lib/libdbus-1.so.3.8.12
f720d000 f7224000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f722c000 f7295000 r-xp /lib/libm-2.13.so
f729e000 f7332000 r-xp /usr/lib/libstdc++.so.6.0.16
f7345000 f734a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7352000 f7359000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7361000 f738b000 r-xp /usr/lib/libsensor.so.1.9.6
f7394000 f7460000 r-xp /usr/lib/libxml2.so.2.7.8
f746d000 f746f000 r-xp /usr/lib/libiniparser.so.0
f7478000 f747b000 r-xp /usr/lib/libbundle.so.0.1.22
f7483000 f7489000 r-xp /usr/lib/libappsvc.so.0.1.0
f7491000 f74b4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f74bc000 f74fd000 r-xp /usr/lib/libeina.so.1.7.99
f7506000 f751d000 r-xp /usr/lib/libecore.so.1.7.99
f7534000 f753d000 r-xp /usr/lib/libvconf.so.0.2.45
f7545000 f7559000 r-xp /lib/libpthread-2.13.so
f7564000 f7571000 r-xp /usr/lib/libaul.so.0.1.0
f757b000 f757d000 r-xp /lib/libdl-2.13.so
f7586000 f7591000 r-xp /lib/libunwind.so.8.0.1
f75be000 f75c6000 r-xp /lib/libgcc_s-4.6.so.1
f75c7000 f76eb000 r-xp /lib/libc-2.13.so
f76f9000 f76fb000 r-xp /usr/lib/libdlog.so.0.0.0
f7703000 f770f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7718000 f771d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7725000 f7729000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7732000 f7734000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f773d000 f7740000 r-xp /usr/lib/libappcore-agent.so.1.1
f775e000 f777b000 r-xp /lib/ld-2.13.so
f7784000 f7787000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7787000 f778b000 r-xp /usr/lib/libsys-assert.so
f7804000 f7852000 rw-p [heap]
ffb58000 ffb79000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5778)
Call Stack Count: 1
 0: (0xf76359fc) [/lib/libc.so.6] + 0x6e9fc
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
0
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5563
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:18.781+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5563
04-23 14:31:18.781+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5563)
04-23 14:31:20.191+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:20.361+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:20.361+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:37.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:31:37.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:37.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:31:38.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:31:38.011+0200 I/utils   ( 4443): specific action
04-23 14:31:38.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:31:38.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:31:38.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:31:38.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:31:38.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:31:38.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:31:38.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:31:38.011+0200 I/httppostreq( 4443): internet available
04-23 14:31:38.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:31:38.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:38.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:31:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:31:38.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:31:38.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:38.041+0200 I/utils   ( 4440): specific action
04-23 14:31:38.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:38.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:31:38.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:38.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:38.041+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:31:38.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:31:38.041+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:31:38.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:38.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:38.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5645
04-23 14:31:38.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:38.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5645
04-23 14:31:38.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5645) type(svcapp) bg(0)
04-23 14:31:38.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5645)
04-23 14:31:38.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:31:38.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:38.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:31:38.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:38.111+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:38.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5645]
04-23 14:31:38.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5648
04-23 14:31:38.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:38.151+0200 E/CAPI_APPFW_APPLICATION( 5645): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.151+0200 E/CAPI_APPFW_APPLICATION( 5645): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.151+0200 I/utils   ( 5645): trying to start service: es.ugr.frailty.accelerometer
04-23 14:31:38.151+0200 I/utils   ( 5645): es.ugr.frailty.accelerometer sensor supported
04-23 14:31:38.161+0200 I/utils   ( 5645): es.ugr.frailty.accelerometer listener started
04-23 14:31:38.161+0200 I/accelerometer( 5645): stopping es.ugr.frailty.accelerometer service
04-23 14:31:38.161+0200 E/CAPI_APPFW_APP_CONTROL( 5645): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.161+0200 E/accelerometer( 5645): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:38.161+0200 I/CAPI_APPFW_APPLICATION( 5645): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:38.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5648
04-23 14:31:38.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5648) type(svcapp) bg(0)
04-23 14:31:38.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5645
04-23 14:31:38.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5645) was created
04-23 14:31:38.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5645
04-23 14:31:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.201+0200 E/CAPI_APPFW_APPLICATION( 5648): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.201+0200 E/CAPI_APPFW_APPLICATION( 5648): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.211+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5648) was created
04-23 14:31:38.211+0200 I/utils   ( 5648): trying to start service: es.ugr.frailty.gyroscope
04-23 14:31:38.211+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5648)
04-23 14:31:38.211+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:31:38.211+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:38.211+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:31:38.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:38.211+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:38.221+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5662
04-23 14:31:38.221+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5648]
04-23 14:31:38.251+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:38.251+0200 I/utils   ( 5648): es.ugr.frailty.gyroscope sensor supported
04-23 14:31:38.271+0200 I/utils   ( 5648): es.ugr.frailty.gyroscope listener started
04-23 14:31:38.271+0200 I/gyroscope( 5648): stopping es.ugr.frailty.gyroscope service
04-23 14:31:38.271+0200 E/CAPI_APPFW_APP_CONTROL( 5648): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.271+0200 E/gyroscope( 5648): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:38.271+0200 I/CAPI_APPFW_APPLICATION( 5648): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:38.271+0200 E/CAPI_APPFW_APPLICATION( 5662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.271+0200 E/CAPI_APPFW_APPLICATION( 5662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5662
04-23 14:31:38.271+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5662) type(svcapp) bg(0)
04-23 14:31:38.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.281+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5662]
04-23 14:31:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5648
04-23 14:31:38.281+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.291+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.311+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5662
04-23 14:31:38.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5662)
04-23 14:31:38.311+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:31:38.311+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:38.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:38.311+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:31:38.311+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:31:38.311+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:31:38.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:38.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:38.311+0200 I/utils   ( 5662): trying to start service: es.ugr.frailty.heartrate
04-23 14:31:38.321+0200 I/accelerometer( 5645): es.ugr.frailty.accelerometer listener destroyed
04-23 14:31:38.321+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5675
04-23 14:31:38.331+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:38.361+0200 E/CAPI_APPFW_APPLICATION( 5675): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.361+0200 E/CAPI_APPFW_APPLICATION( 5675): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.361+0200 I/utils   ( 5675): specific action
04-23 14:31:38.361+0200 I/recorder( 5675): obteniendo datos locales...
04-23 14:31:38.381+0200 I/recorder( 5675): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:31:38.381+0200 I/recorder( 5675): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:31:38.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5675
04-23 14:31:38.391+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5675) type(svcapp) bg(0)
04-23 14:31:38.391+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5662) was created
04-23 14:31:38.391+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5675) was created
04-23 14:31:38.391+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5675]
04-23 14:31:38.391+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5675)
04-23 14:31:38.391+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:31:38.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5648
04-23 14:31:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5675
04-23 14:31:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.431+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11056757265631524486698
04-23 14:31:38.441+0200 E/RESOURCED( 2584): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/5675/oom_score_adj failed
04-23 14:31:38.441+0200 E/RESOURCED( 2584): proc-main.c: resourced_proc_status_change(1508) > Empty pid or process not exists. 5675
04-23 14:31:38.441+0200 W/AUL     ( 5679): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:31:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5675
04-23 14:31:38.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:38.451+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5675
04-23 14:31:38.451+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5675)
04-23 14:31:38.451+0200 I/utils   ( 5662): es.ugr.frailty.heartrate sensor supported
04-23 14:31:38.471+0200 I/utils   ( 5662): es.ugr.frailty.heartrate listener started
04-23 14:31:38.471+0200 I/heartrate( 5662): stopping es.ugr.frailty.heartrate service
04-23 14:31:38.471+0200 E/CAPI_APPFW_APP_CONTROL( 5662): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:38.471+0200 E/heartrate( 5662): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:38.471+0200 I/CAPI_APPFW_APPLICATION( 5662): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:38.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:38.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:38.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.501+0200 W/AUL     ( 5689): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:31:38.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:38.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:38.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5645
04-23 14:31:38.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:38.501+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5645
04-23 14:31:38.501+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5645)
04-23 14:31:38.511+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.521+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:38.531+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5662
04-23 14:31:38.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:38.541+0200 E/SECURITY_EXTENSION_SERVER( 2466): security_extension_system.c: __read_proc(55) > file open error : 2
04-23 14:31:38.541+0200 E/SECURITY_EXTENSION_SERVER( 2466): security_extension_system.c: __get_proc_bypid(85) > ERR: __get_proc_bypid : -2
04-23 14:31:38.541+0200 E/SECURITY_EXTENSION_SERVER( 2466): security_extension_system.c: __status_get_proc_bypid(142) > No file exist : pid(5675), proc(0)
04-23 14:31:38.541+0200 E/SECURITY_EXTENSION_SERVER( 2466): security_extension_system.c: __security_extension_process_handler(179) > Error: fail to status get proc by pid
04-23 14:31:38.541+0200 E/AUL     ( 3091): pkginfo.c: __get_id_bypid(213) > Failed to get the cmdline of pid, error: -2
04-23 14:31:38.541+0200 E/CAPI_APPFW_APP_MANAGER( 3091): app_manager.c: app_manager_error(77) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
04-23 14:31:38.581+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.591+0200 I/gyroscope( 5648): es.ugr.frailty.gyroscope listener destroyed
04-23 14:31:38.591+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:38.621+0200 I/heartrate( 5662): es.ugr.frailty.heartrate listener destroyed
04-23 14:31:38.721+0200 W/AUL     ( 5700): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:31:38.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:38.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:38.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5648
04-23 14:31:38.721+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:38.721+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5648
04-23 14:31:38.721+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5648)
04-23 14:31:38.751+0200 W/AUL     ( 5701): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:31:38.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:38.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:38.751+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5662
04-23 14:31:38.751+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:38.751+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5662
04-23 14:31:38.751+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5662)
04-23 14:31:40.201+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:40.291+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:40.471+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 14:31:57.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:31:57.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:57.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:31:58.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:58.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:31:58.011+0200 I/utils   ( 4443): specific action
04-23 14:31:58.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:31:58.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:31:58.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:31:58.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:31:58.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:31:58.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:31:58.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:31:58.011+0200 I/httppostreq( 4443): internet available
04-23 14:31:58.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:31:58.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:58.011+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:31:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:31:58.031+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:58.031+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:31:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:58.031+0200 I/utils   ( 4440): specific action
04-23 14:31:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:58.031+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:58.031+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:31:58.031+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:31:58.031+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:31:58.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:31:58.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:58.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:58.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5739
04-23 14:31:58.061+0200 E/RESOURCED( 2584): proc-main.c: proc_create_app_info(722) > prelaunched app was not gone to launch state, appid(es.ugr.frailty.recorder)
04-23 14:31:58.061+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:58.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5739
04-23 14:31:58.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5739) type(svcapp) bg(0)
04-23 14:31:58.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5739)
04-23 14:31:58.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:31:58.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:58.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:31:58.111+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:58.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5739]
04-23 14:31:58.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:58.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5742
04-23 14:31:58.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:58.151+0200 E/CAPI_APPFW_APPLICATION( 5739): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.151+0200 E/CAPI_APPFW_APPLICATION( 5739): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.151+0200 I/utils   ( 5739): trying to start service: es.ugr.frailty.accelerometer
04-23 14:31:58.151+0200 I/utils   ( 5739): es.ugr.frailty.accelerometer sensor supported
04-23 14:31:58.161+0200 I/utils   ( 5739): es.ugr.frailty.accelerometer listener started
04-23 14:31:58.161+0200 I/accelerometer( 5739): stopping es.ugr.frailty.accelerometer service
04-23 14:31:58.171+0200 E/CAPI_APPFW_APP_CONTROL( 5739): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.171+0200 E/accelerometer( 5739): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:58.171+0200 I/CAPI_APPFW_APPLICATION( 5739): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:58.181+0200 E/CAPI_APPFW_APPLICATION( 5742): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.181+0200 E/CAPI_APPFW_APPLICATION( 5742): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.181+0200 I/utils   ( 5742): trying to start service: es.ugr.frailty.gyroscope
04-23 14:31:58.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5742
04-23 14:31:58.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5742) type(svcapp) bg(0)
04-23 14:31:58.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.191+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5742]
04-23 14:31:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5739
04-23 14:31:58.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5739) was created
04-23 14:31:58.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5742) was created
04-23 14:31:58.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5739
04-23 14:31:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.221+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5742)
04-23 14:31:58.221+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:31:58.221+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:58.221+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:31:58.221+0200 I/utils   ( 5742): es.ugr.frailty.gyroscope sensor supported
04-23 14:31:58.231+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5742
04-23 14:31:58.231+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:58.231+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:58.241+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5764
04-23 14:31:58.241+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:58.251+0200 I/utils   ( 5742): es.ugr.frailty.gyroscope listener started
04-23 14:31:58.251+0200 I/gyroscope( 5742): stopping es.ugr.frailty.gyroscope service
04-23 14:31:58.251+0200 E/CAPI_APPFW_APP_CONTROL( 5742): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.251+0200 E/gyroscope( 5742): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:58.251+0200 I/CAPI_APPFW_APPLICATION( 5742): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:58.281+0200 E/CAPI_APPFW_APPLICATION( 5764): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.281+0200 E/CAPI_APPFW_APPLICATION( 5764): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.281+0200 I/utils   ( 5764): trying to start service: es.ugr.frailty.heartrate
04-23 14:31:58.281+0200 I/utils   ( 5764): es.ugr.frailty.heartrate sensor supported
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5764
04-23 14:31:58.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5764) type(svcapp) bg(0)
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5764) was created
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:58.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5742
04-23 14:31:58.301+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5764)
04-23 14:31:58.301+0200 I/utils   ( 5764): es.ugr.frailty.heartrate listener started
04-23 14:31:58.301+0200 I/heartrate( 5764): stopping es.ugr.frailty.heartrate service
04-23 14:31:58.301+0200 E/CAPI_APPFW_APP_CONTROL( 5764): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.301+0200 E/heartrate( 5764): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:58.301+0200 I/CAPI_APPFW_APPLICATION( 5764): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:58.311+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5764]
04-23 14:31:58.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.311+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:31:58.311+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:58.311+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:31:58.311+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:58.311+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:58.311+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:58.311+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:58.321+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:58.321+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:58.321+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:31:58.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.321+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:31:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:58.321+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:58.321+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:58.321+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:58.331+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:31:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:58.331+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:58.331+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:31:58.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5764
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:31:58.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:31:58.331+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:31:58.331+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:31:58.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:58.331+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:58.341+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5778
04-23 14:31:58.351+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:58.391+0200 E/CAPI_APPFW_APPLICATION( 5778): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.391+0200 E/CAPI_APPFW_APPLICATION( 5778): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:58.391+0200 I/utils   ( 5778): specific action
04-23 14:31:58.391+0200 I/recorder( 5778): obteniendo datos locales...
04-23 14:31:58.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5778
04-23 14:31:58.401+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5778) type(svcapp) bg(0)
04-23 14:31:58.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.401+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5764
04-23 14:31:58.411+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5778) was created
04-23 14:31:58.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.411+0200 I/recorder( 5778): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:31:58.411+0200 I/recorder( 5778): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:31:58.431+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5778]
04-23 14:31:58.441+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5778)
04-23 14:31:58.441+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:31:58.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5778
04-23 14:31:58.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.461+0200 I/accelerometer( 5739): es.ugr.frailty.accelerometer listener destroyed
04-23 14:31:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:58.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5778
04-23 14:31:58.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:58.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:58.511+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1105778726563152448671
