S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 5675
Date: 2018-04-23 14:31:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7244648, r1   = 0xf77401b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77401b8, r5   = 0x00012cd0
r6   = 0xf7752e88, r7   = 0xf7244250
r8   = 0x00000618, r9   = 0xf6d27824
r10  = 0xf77389d8, fp   = 0x00000000
ip   = 0xf7243030, sp   = 0xffb6ce90
lr   = 0xf71875d0, pc   = 0xf71839fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     65672 KB
Buffers:     37192 KB
Cached:     220012 KB
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
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f68be000 f68c1000 r-xp /lib/libattr.so.1.1.0
f68ca000 f68d1000 r-xp /lib/libcrypt-2.13.so
f6901000 f6904000 r-xp /lib/libcap.so.2.21
f690c000 f690e000 r-xp /usr/lib/libiri.so
f6916000 f6933000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f693c000 f6940000 r-xp /usr/lib/libsmack.so.1.0.0
f694a000 f694c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6954000 f6959000 r-xp /usr/lib/libffi.so.5.0.10
f6961000 f6962000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f696a000 f696c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6974000 f6976000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6980000 f6990000 r-xp /lib/libresolv-2.13.so
f6994000 f69ac000 r-xp /usr/lib/liblzma.so.5.0.3
f69b4000 f69b6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69be000 f69ed000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69f6000 f6a05000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a0e000 f6a18000 r-xp /usr/lib/libsensord-shared.so
f6a21000 f6a55000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a5e000 f6b31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b3c000 f6b52000 r-xp /lib/libz.so.1.2.5
f6b5a000 f6b60000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b69000 f6bde000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6be8000 f6c02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c0a000 f6c10000 r-xp /lib/librt-2.13.so
f6c19000 f6c37000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c41000 f6c42000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c4a000 f6c4f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c57000 f6d27000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d28000 f6d52000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d5b000 f6d72000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d7a000 f6de3000 r-xp /lib/libm-2.13.so
f6dec000 f6e80000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e93000 f6e98000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ea0000 f6ea7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6eaf000 f6ed9000 r-xp /usr/lib/libsensor.so.1.9.6
f6ee2000 f6fae000 r-xp /usr/lib/libxml2.so.2.7.8
f6fbb000 f6fbd000 r-xp /usr/lib/libiniparser.so.0
f6fc6000 f6fc9000 r-xp /usr/lib/libbundle.so.0.1.22
f6fd1000 f6fd7000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fdf000 f7002000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f700a000 f704b000 r-xp /usr/lib/libeina.so.1.7.99
f7054000 f706b000 r-xp /usr/lib/libecore.so.1.7.99
f7082000 f708b000 r-xp /usr/lib/libvconf.so.0.2.45
f7093000 f70a7000 r-xp /lib/libpthread-2.13.so
f70b2000 f70bf000 r-xp /usr/lib/libaul.so.0.1.0
f70c9000 f70cb000 r-xp /lib/libdl-2.13.so
f70d4000 f70df000 r-xp /lib/libunwind.so.8.0.1
f710c000 f7114000 r-xp /lib/libgcc_s-4.6.so.1
f7115000 f7239000 r-xp /lib/libc-2.13.so
f7247000 f7249000 r-xp /usr/lib/libdlog.so.0.0.0
f7251000 f725d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7266000 f726b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7273000 f7277000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7280000 f7282000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f728b000 f728e000 r-xp /usr/lib/libappcore-agent.so.1.1
f72ac000 f72c9000 r-xp /lib/ld-2.13.so
f72d2000 f72d5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f72d5000 f72d9000 r-xp /usr/lib/libsys-assert.so
f772e000 f777c000 rw-p [heap]
ffb4f000 ffb70000 rw-p [stack]
End of Maps Information

Callstack Information (PID:5675)
Call Stack Count: 1
 0: (0xf71839fc) [/lib/libc.so.6] + 0x6e9fc
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
> _MessagePortService::GetKey
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:31:01.881+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:31:01.881+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:31:01.881+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:31:01.881+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 14:31:01.891+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 14:31:01.891+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 14:31:01.891+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 14:31:01.901+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 14:31:01.901+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 14:31:01.901+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 14:31:02.381+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:31:06.901+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 14:31:17.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:31:17.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:17.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:18.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:31:18.011+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:18.011+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:31:18.011+0200 I/utils   ( 4443): specific action
04-23 14:31:18.011+0200 I/httppostreq( 4443): internet connection check received
04-23 14:31:18.011+0200 I/httppostreq( 4443): internet connection != null
04-23 14:31:18.011+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:31:18.011+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:31:18.011+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:31:18.011+0200 I/httppostreq( 4443): internet connection type...
04-23 14:31:18.011+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:31:18.011+0200 I/httppostreq( 4443): internet available
04-23 14:31:18.011+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:31:18.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:18.021+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:31:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:31:18.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:31:18.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:31:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:18.041+0200 I/utils   ( 4440): specific action
04-23 14:31:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:18.041+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:31:18.041+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:31:18.041+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:31:18.041+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:31:18.041+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:31:18.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:18.051+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:18.061+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5549
04-23 14:31:18.071+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:18.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5549
04-23 14:31:18.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(5549) type(svcapp) bg(0)
04-23 14:31:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5549)
04-23 14:31:18.111+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:31:18.111+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:18.111+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:31:18.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:18.121+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5549]
04-23 14:31:18.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:18.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5552
04-23 14:31:18.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:18.141+0200 E/CAPI_APPFW_APPLICATION( 5549): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.141+0200 E/CAPI_APPFW_APPLICATION( 5549): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.151+0200 I/utils   ( 5549): trying to start service: es.ugr.frailty.accelerometer
04-23 14:31:18.151+0200 I/utils   ( 5549): es.ugr.frailty.accelerometer sensor supported
04-23 14:31:18.171+0200 I/utils   ( 5549): es.ugr.frailty.accelerometer listener started
04-23 14:31:18.171+0200 I/accelerometer( 5549): stopping es.ugr.frailty.accelerometer service
04-23 14:31:18.171+0200 E/CAPI_APPFW_APP_CONTROL( 5549): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.171+0200 E/accelerometer( 5549): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:18.171+0200 I/CAPI_APPFW_APPLICATION( 5549): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:18.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5552
04-23 14:31:18.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(5552) type(svcapp) bg(0)
04-23 14:31:18.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5549
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5549) was created
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5552)
04-23 14:31:18.191+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:31:18.191+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:18.191+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:18.191+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:18.201+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5563
04-23 14:31:18.221+0200 E/CAPI_APPFW_APPLICATION( 5552): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.221+0200 E/CAPI_APPFW_APPLICATION( 5552): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.221+0200 I/utils   ( 5552): trying to start service: es.ugr.frailty.gyroscope
04-23 14:31:18.241+0200 E/CAPI_APPFW_APPLICATION( 5563): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.241+0200 E/CAPI_APPFW_APPLICATION( 5563): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.241+0200 I/utils   ( 5563): trying to start service: es.ugr.frailty.heartrate
04-23 14:31:18.251+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5552]
04-23 14:31:18.251+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:18.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5563
04-23 14:31:18.251+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(5563) type(svcapp) bg(0)
04-23 14:31:18.261+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5552) was created
04-23 14:31:18.261+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5563) was created
04-23 14:31:18.261+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5563)
04-23 14:31:18.261+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:31:18.261+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:31:18.261+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:31:18.261+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:31:18.261+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:31:18.261+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:31:18.261+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5563]
04-23 14:31:18.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:31:18.261+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:31:18.271+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 5569
04-23 14:31:18.281+0200 I/utils   ( 5552): es.ugr.frailty.gyroscope sensor supported
04-23 14:31:18.281+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:31:18.281+0200 I/utils   ( 5563): es.ugr.frailty.heartrate sensor supported
04-23 14:31:18.301+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.311+0200 E/CAPI_APPFW_APPLICATION( 5569): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.311+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.311+0200 E/CAPI_APPFW_APPLICATION( 5569): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.321+0200 I/utils   ( 5569): specific action
04-23 14:31:18.321+0200 I/recorder( 5569): obteniendo datos locales...
04-23 14:31:18.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 5569
04-23 14:31:18.321+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(5569) type(svcapp) bg(0)
04-23 14:31:18.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5552
04-23 14:31:18.331+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (5569) was created
04-23 14:31:18.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.331+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [5569]
04-23 14:31:18.331+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5569)
04-23 14:31:18.331+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:31:18.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.341+0200 I/utils   ( 5563): es.ugr.frailty.heartrate listener started
04-23 14:31:18.341+0200 I/heartrate( 5563): stopping es.ugr.frailty.heartrate service
04-23 14:31:18.341+0200 E/CAPI_APPFW_APP_CONTROL( 5563): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.341+0200 E/heartrate( 5563): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:18.341+0200 I/CAPI_APPFW_APPLICATION( 5563): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:18.351+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5549
04-23 14:31:18.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.351+0200 I/utils   ( 5552): es.ugr.frailty.gyroscope listener started
04-23 14:31:18.351+0200 I/gyroscope( 5552): stopping es.ugr.frailty.gyroscope service
04-23 14:31:18.351+0200 E/CAPI_APPFW_APP_CONTROL( 5552): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:31:18.351+0200 E/gyroscope( 5552): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:31:18.351+0200 I/CAPI_APPFW_APPLICATION( 5552): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5563
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:31:18.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.381+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5569
04-23 14:31:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.391+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.391+0200 I/accelerometer( 5549): es.ugr.frailty.accelerometer listener destroyed
04-23 14:31:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5552
04-23 14:31:18.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5563
04-23 14:31:18.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:31:18.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 5569
04-23 14:31:18.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:31:18.471+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.481+0200 I/recorder( 5569): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:31:18.481+0200 I/recorder( 5569): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:31:18.491+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.511+0200 W/AUL     ( 5593): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:31:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5549
04-23 14:31:18.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:18.531+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5549
04-23 14:31:18.531+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5549)
04-23 14:31:18.551+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 11055697265631524486678
04-23 14:31:18.561+0200 W/AUL     ( 5596): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 14:31:18.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:18.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:18.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5569
04-23 14:31:18.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:18.581+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5569
04-23 14:31:18.581+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5569)
04-23 14:31:18.591+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.601+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:31:18.611+0200 I/heartrate( 5563): es.ugr.frailty.heartrate listener destroyed
04-23 14:31:18.621+0200 I/gyroscope( 5552): es.ugr.frailty.gyroscope listener destroyed
04-23 14:31:18.771+0200 W/AUL     ( 5604): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 14:31:18.771+0200 W/AUL     ( 5605): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5552
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:31:18.771+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 5552
04-23 14:31:18.771+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(5552)
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:31:18.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
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
04-23 14:31:38.431+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1105675726563152448669
