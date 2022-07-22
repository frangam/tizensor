S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 7201
Date: 2018-04-12 18:44:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffe05ab8
r6   = 0xf77b66f8, r7   = 0x000000f7
r8   = 0x00000014, r9   = 0x00000000
r10  = 0xf77b66e3, fp   = 0xffe05aac
ip   = 0xffe05fec, sp   = 0xffe05540
lr   = 0xf7650e8c, pc   = 0xf76860b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     67424 KB
Buffers:     43732 KB
Cached:     220188 KB
VmPeak:      45264 KB
VmSize:      45008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7112 KB
VmRSS:        7112 KB
VmData:      35180 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7201 TID = 7201
7201 7210 7211 7212 7213 

Maps Information
f4dc2000 f55c1000 rw-p [stack:7213]
f55c2000 f5dc1000 rw-p [stack:7212]
f5dc2000 f65c1000 rw-p [stack:7211]
f65c2000 f6dc5000 rw-p [stack:7210]
f6dc5000 f6dc8000 r-xp /lib/libattr.so.1.1.0
f6dd0000 f6dd7000 r-xp /lib/libcrypt-2.13.so
f6e08000 f6e0b000 r-xp /lib/libcap.so.2.21
f6e13000 f6e15000 r-xp /usr/lib/libiri.so
f6e1d000 f6e1f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e27000 f6e29000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e32000 f6efe000 r-xp /usr/lib/libxml2.so.2.7.8
f6f0c000 f6f29000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6f32000 f6f36000 r-xp /usr/lib/libsmack.so.1.0.0
f6f3f000 f6f55000 r-xp /lib/libz.so.1.2.5
f6f5d000 f6f5f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f67000 f6f6c000 r-xp /usr/lib/libffi.so.5.0.10
f6f74000 f6f75000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f7d000 f6f8d000 r-xp /lib/libresolv-2.13.so
f6f91000 f6fa9000 r-xp /usr/lib/liblzma.so.5.0.3
f6fb1000 f6fb3000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6fbb000 f6fd5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6fdd000 f700c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f7015000 f7024000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f702d000 f7037000 r-xp /usr/lib/libsensord-shared.so
f7040000 f7074000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f707d000 f7150000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f715b000 f7161000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f716a000 f71df000 r-xp /usr/lib/libsqlite3.so.0.8.6
f71e9000 f71ef000 r-xp /lib/librt-2.13.so
f71f8000 f7216000 r-xp /usr/lib/libsystemd.so.0.4.0
f7220000 f7221000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7229000 f724c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7254000 f7259000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7261000 f7331000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7332000 f735c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7365000 f737c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7384000 f73ed000 r-xp /lib/libm-2.13.so
f73f6000 f748a000 r-xp /usr/lib/libstdc++.so.6.0.16
f749d000 f74a2000 r-xp /usr/lib/libctx-client.so.0.8.3
f74aa000 f74b1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f74b9000 f74e3000 r-xp /usr/lib/libsensor.so.1.9.6
f74ec000 f74ef000 r-xp /usr/lib/libbundle.so.0.1.22
f74f7000 f74fd000 r-xp /usr/lib/libappsvc.so.0.1.0
f7505000 f7546000 r-xp /usr/lib/libeina.so.1.7.99
f754f000 f7566000 r-xp /usr/lib/libecore.so.1.7.99
f757d000 f7586000 r-xp /usr/lib/libvconf.so.0.2.45
f758e000 f75a2000 r-xp /lib/libpthread-2.13.so
f75ad000 f75ba000 r-xp /usr/lib/libaul.so.0.1.0
f75c4000 f75c6000 r-xp /lib/libdl-2.13.so
f75cf000 f75da000 r-xp /lib/libunwind.so.8.0.1
f7607000 f760f000 r-xp /lib/libgcc_s-4.6.so.1
f7610000 f7734000 r-xp /lib/libc-2.13.so
f7742000 f7744000 r-xp /usr/lib/libdlog.so.0.0.0
f774c000 f7758000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7761000 f7765000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f776e000 f7771000 r-xp /usr/lib/libappcore-agent.so.1.1
f778f000 f77ac000 r-xp /lib/ld-2.13.so
f77b5000 f77b7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f77b7000 f77bb000 r-xp /usr/lib/libsys-assert.so
f79fb000 f7a3c000 rw-p [heap]
ffde7000 ffe08000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7201)
Call Stack Count: 1
 0: strlen + 0x4 (0xf76860b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: accelerometer
App ID: es.ugr.frailty.accelerometer
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
00 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:44:51.679+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:51.689+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:44:51.689+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:44:51.689+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:44:51.689+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:51.689+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 18:44:51.689+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:44:51.689+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 18:44:51.689+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [11156.955335] layer(0x21e250) now usable
04-12 18:44:51.689+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [11156.955349] layer[0x21dcf0]zpos[0]
04-12 18:44:51.689+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:44:51.689+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:44:51.689+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(7151) status(fg) type(uiapp)
04-12 18:44:51.689+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 18:44:51.689+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 18:44:51.689+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[7151] goes to (3)
04-12 18:44:51.699+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 18:44:51.699+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 18:44:51.699+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 18:44:51.709+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:44:51.709+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 18:44:51.729+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:44:51.729+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:44:51.739+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:44:51.789+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:44:51.789+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:44:51.809+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:44:51.909+0200 I/AUL     ( 7163): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 18:44:51.919+0200 I/AUL     ( 7163): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 18:44:51.919+0200 E/AUL     ( 7163): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 18:44:51.919+0200 E/AUL     ( 7163): aul_path.c: __get_path(169) > root_path is NULL!
04-12 18:44:52.069+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:44:52.189+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:44:52.559+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:52.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7151
04-12 18:44:52.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:52.599+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:52.609+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7151
04-12 18:44:52.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:52.739+0200 E/PKGMGR_SERVER( 7116): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-12 18:44:52.739+0200 E/PKGMGR_SERVER( 7116): pkgmgr-server.c: main(2295) > package manager server terminated.
04-12 18:44:52.819+0200 I/AUL_PAD ( 7186): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:44:52.959+0200 E/EFL     ( 7151): ecore_x<7151> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11158226 button=1
04-12 18:44:52.959+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] mouse move
04-12 18:44:53.009+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] mouse move
04-12 18:44:53.009+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] hold(0), freeze(0)
04-12 18:44:53.029+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] mouse move
04-12 18:44:53.029+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] hold(0), freeze(0)
04-12 18:44:53.039+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] mouse move
04-12 18:44:53.039+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] hold(0), freeze(0)
04-12 18:44:53.059+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] mouse move
04-12 18:44:53.059+0200 E/EFL     ( 7151): elementary<7151> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d77f90 : elm_list] hold(0), freeze(0)
04-12 18:44:53.139+0200 E/EFL     ( 7151): ecore_x<7151> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11158402 button=1
04-12 18:44:53.139+0200 W/AUL     ( 7151): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:44:53.139+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:44:53.139+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7151
04-12 18:44:53.149+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7190
04-12 18:44:53.149+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:44:53.169+0200 E/CAPI_APPFW_APPLICATION( 7190): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.169+0200 E/CAPI_APPFW_APPLICATION( 7190): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.169+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:44:53.199+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7190
04-12 18:44:53.199+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(7190) type(svcapp) bg(0)
04-12 18:44:53.209+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:44:53.209+0200 W/AUL     ( 7151): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7190)
04-12 18:44:53.209+0200 I/utils   ( 7151): es.ugr.frailty.servicemanager launch request sent!
04-12 18:44:53.209+0200 I/utils   ( 7151): App control destroyed.
04-12 18:44:53.209+0200 I/CAPI_APPFW_APPLICATION( 7151): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:44:53.209+0200 I/CAPI_APPFW_APPLICATION( 7151): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:44:53.209+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7190
04-12 18:44:53.219+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7190]
04-12 18:44:53.219+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7193
04-12 18:44:53.229+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:44:53.269+0200 E/CAPI_APPFW_APPLICATION( 7193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.269+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7193
04-12 18:44:53.269+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(7193) type(svcapp) bg(0)
04-12 18:44:53.269+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7190) was created
04-12 18:44:53.279+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.279+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7190
04-12 18:44:53.279+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.289+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7193]
04-12 18:44:53.289+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7193)
04-12 18:44:53.289+0200 I/servicemanager( 7190): es.ugr.frailty.httppostreq launch request sent!
04-12 18:44:53.289+0200 I/servicemanager( 7190): App control destroyed.
04-12 18:44:53.289+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:44:53.299+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7190
04-12 18:44:53.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:44:53.299+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7190
04-12 18:44:53.309+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7194
04-12 18:44:53.319+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:44:53.329+0200 E/CAPI_APPFW_APPLICATION( 7194): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.329+0200 E/CAPI_APPFW_APPLICATION( 7193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.339+0200 E/CAPI_APPFW_APPLICATION( 7194): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:53.339+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.339+0200 W/CAPI_APPFW_APP_CONTROL( 7194): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.369+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7194
04-12 18:44:53.369+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(7194) type(svcapp) bg(0)
04-12 18:44:53.369+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.369+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7193) was created
04-12 18:44:53.369+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7194) was created
04-12 18:44:53.369+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.369+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7194]
04-12 18:44:53.379+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7194)
04-12 18:44:53.379+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.389+0200 I/servicemanager( 7190): es.ugr.frailty.recorder launch request sent!
04-12 18:44:53.389+0200 I/servicemanager( 7190): App control destroyed.
04-12 18:44:53.389+0200 I/servicemanager( 7190): Frailty Service Manager created
04-12 18:44:53.389+0200 W/CAPI_APPFW_APP_CONTROL( 7190): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.389+0200 W/CAPI_APPFW_APP_CONTROL( 7190): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.389+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7193
04-12 18:44:53.389+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.409+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.419+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7194
04-12 18:44:53.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.419+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.429+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7193
04-12 18:44:53.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.429+0200 W/APP_CORE( 7151): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:44:53.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:44:53.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:44:53.439+0200 W/APP_CORE( 7151): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[60203e] for es.ugr.frailty.frailtylauncher[7151]
04-12 18:44:53.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:53.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7194
04-12 18:44:53.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:53.499+0200 I/APP_CORE( 7151): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:44:53.499+0200 I/APP_CORE( 7151): appcore-efl.c: __after_loop(1234) > [APP 7151] PAUSE before termination
04-12 18:44:53.499+0200 I/CAPI_APPFW_APPLICATION( 7151): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:44:53.499+0200 I/CAPI_APPFW_APPLICATION( 7151): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:44:53.499+0200 I/APP_CORE( 7151): appcore-efl.c: __after_loop(1243) > [APP 7151] After terminate() callback
04-12 18:44:53.519+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:44:53.519+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:44:53.519+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:53.519+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:53.519+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:44:53.529+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:44:53.529+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:44:53.529+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:44:53.529+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:44:53.529+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:44:53.559+0200 I/CAPI_NETWORK_CONNECTION( 7193): connection.c: connection_create(453) > New handle created[0xf7820be0]
04-12 18:44:53.559+0200 W/CAPI_APPFW_APP_CONTROL( 7193): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.559+0200 W/CAPI_APPFW_APP_CONTROL( 7193): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:53.559+0200 I/UXT     ( 7151): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:44:53.589+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:44:53.589+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:44:53.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.589+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.589+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:44:53.589+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:44:53.589+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:44:53.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:53.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:53.589+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:44:53.589+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:44:53.589+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:44:53.609+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:44:53.609+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:44:53.609+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.609+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.609+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:44:53.619+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:44:53.619+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 18:44:53.619+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(35), length(2)
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 35%
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 35, isCharging: 0
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_35
04-12 18:44:53.619+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 18:44:53.619+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:44:53.619+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:44:53.619+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:44:53.629+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 18:44:53.629+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 18:44:53.629+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 18:44:53.639+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:53.639+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:53.679+0200 I/efl-extension( 7151): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:44:53.689+0200 W/AUL_PAD ( 7151): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:44:53.699+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7151 pgid = 7151
04-12 18:44:53.699+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:44:53.739+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:44:53.739+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7151
04-12 18:44:53.739+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7151)
04-12 18:44:53.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:53.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:53.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:53.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:54.069+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [11159.332484] layer(0x21e250) not usable
04-12 18:44:54.069+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [11159.332540] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:44:54.069+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [11159.332571] layer[0x21dcf0]zpos[0]
04-12 18:44:54.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:54.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:54.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:54.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:54.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:54.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:44:54.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.619+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:44:54.619+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:44:54.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:54.629+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:44:54.649+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:44:54.649+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:44:54.649+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:44:54.649+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:44:54.649+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:44:54.649+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:44:54.649+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.649+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:44:54.649+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:44:54.649+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:44:54.649+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:44:54.659+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:44:54.659+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:44:54.659+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:44:54.659+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.659+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:44:54.659+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:44:54.669+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:44:54.669+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:44:54.669+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:44:54.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:54.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:54.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:54.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:55.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:55.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:55.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:55.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:55.439+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:44:55.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:55.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:55.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:55.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:55.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:55.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:56.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:56.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:56.389+0200 I/servicemanager( 7190): accelerometer alive timeout
04-12 18:44:56.389+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:44:56.389+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:44:56.389+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7190
04-12 18:44:56.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:56.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:56.409+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7201
04-12 18:44:56.409+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:44:56.459+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7201
04-12 18:44:56.459+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(7201) type(svcapp) bg(0)
04-12 18:44:56.459+0200 W/AUL     ( 7190): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7201)
04-12 18:44:56.459+0200 I/servicemanager( 7190): es.ugr.frailty.accelerometer launch request sent!
04-12 18:44:56.459+0200 I/servicemanager( 7190): App control destroyed.
04-12 18:44:56.469+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7201]
04-12 18:44:56.489+0200 E/CAPI_APPFW_APPLICATION( 7201): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:56.489+0200 E/CAPI_APPFW_APPLICATION( 7201): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:44:56.509+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7201) was created
04-12 18:44:56.509+0200 I/accelerometer( 7201): Starting es.ugr.frailty.accelerometer service
04-12 18:44:56.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:56.519+0200 I/accelerometer( 7201): sensor supported
04-12 18:44:56.529+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7201
04-12 18:44:56.529+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:56.529+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:44:56.539+0200 I/accelerometer( 7201): es.ugr.frailty.accelerometer listener started
04-12 18:44:56.539+0200 W/CAPI_APPFW_APP_CONTROL( 7201): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:44:56.549+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7201
04-12 18:44:56.549+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:44:56.589+0200 I/utils   ( 7201): accelerometer utils fecha 12/04/2018,18:44:56
04-12 18:44:56.589+0200 I/utils   ( 7201): accelerometer utils fecha ˆòs÷òs÷ð¡÷è_¡÷,8òs÷ø‘¡÷p ¡÷
04-12 18:44:56.589+0200 I/accelerometer( 7201): accelerometer fecha conseguida
04-12 18:44:56.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:44:56.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:44:56.709+0200 W/AUL     ( 7217): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:44:56.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:44:56.709+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:44:56.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7201
04-12 18:44:56.709+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:44:56.719+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7201
04-12 18:44:56.719+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7201)
04-12 18:44:56.759+0200 W/CRASH_MANAGER( 7215): worker.c: worker_job(1205) > 1107201616363152355149
