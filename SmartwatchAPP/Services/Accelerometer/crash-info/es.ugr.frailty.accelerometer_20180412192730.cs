S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 11209
Date: 2018-04-12 19:27:30+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xff8b5008
r6   = 0xf76146c2, r7   = 0x000000f7
r8   = 0x0000001e, r9   = 0x00000000
r10  = 0xf76146a4, fp   = 0xff8b4ffc
ip   = 0xff8b5540, sp   = 0xff8b4a90
lr   = 0xf74aee8c, pc   = 0xf74e40b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     50084 KB
Buffers:     53128 KB
Cached:     224868 KB
VmPeak:      45012 KB
VmSize:      45008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7180 KB
VmRSS:        7180 KB
VmData:      35180 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 11209 TID = 11209
11209 11218 11219 11220 11221 

Maps Information
f4b01000 f5300000 rw-p [stack:11221]
f5420000 f5c1f000 rw-p [stack:11220]
f5c20000 f641f000 rw-p [stack:11219]
f6420000 f6c23000 rw-p [stack:11218]
f6c23000 f6c26000 r-xp /lib/libattr.so.1.1.0
f6c2e000 f6c35000 r-xp /lib/libcrypt-2.13.so
f6c66000 f6c69000 r-xp /lib/libcap.so.2.21
f6c71000 f6c73000 r-xp /usr/lib/libiri.so
f6c7b000 f6c7d000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c85000 f6c87000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c90000 f6d5c000 r-xp /usr/lib/libxml2.so.2.7.8
f6d6a000 f6d87000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d90000 f6d94000 r-xp /usr/lib/libsmack.so.1.0.0
f6d9d000 f6db3000 r-xp /lib/libz.so.1.2.5
f6dbb000 f6dbd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dc5000 f6dca000 r-xp /usr/lib/libffi.so.5.0.10
f6dd2000 f6dd3000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ddb000 f6deb000 r-xp /lib/libresolv-2.13.so
f6def000 f6e07000 r-xp /usr/lib/liblzma.so.5.0.3
f6e0f000 f6e11000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e19000 f6e33000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e3b000 f6e6a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e73000 f6e82000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e8b000 f6e95000 r-xp /usr/lib/libsensord-shared.so
f6e9e000 f6ed2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6edb000 f6fae000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6fb9000 f6fbf000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fc8000 f703d000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7047000 f704d000 r-xp /lib/librt-2.13.so
f7056000 f7074000 r-xp /usr/lib/libsystemd.so.0.4.0
f707e000 f707f000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7087000 f70aa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70b2000 f70b7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70bf000 f718f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7190000 f71ba000 r-xp /usr/lib/libdbus-1.so.3.8.12
f71c3000 f71da000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f71e2000 f724b000 r-xp /lib/libm-2.13.so
f7254000 f72e8000 r-xp /usr/lib/libstdc++.so.6.0.16
f72fb000 f7300000 r-xp /usr/lib/libctx-client.so.0.8.3
f7308000 f730f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7317000 f7341000 r-xp /usr/lib/libsensor.so.1.9.6
f734a000 f734d000 r-xp /usr/lib/libbundle.so.0.1.22
f7355000 f735b000 r-xp /usr/lib/libappsvc.so.0.1.0
f7363000 f73a4000 r-xp /usr/lib/libeina.so.1.7.99
f73ad000 f73c4000 r-xp /usr/lib/libecore.so.1.7.99
f73db000 f73e4000 r-xp /usr/lib/libvconf.so.0.2.45
f73ec000 f7400000 r-xp /lib/libpthread-2.13.so
f740b000 f7418000 r-xp /usr/lib/libaul.so.0.1.0
f7422000 f7424000 r-xp /lib/libdl-2.13.so
f742d000 f7438000 r-xp /lib/libunwind.so.8.0.1
f7465000 f746d000 r-xp /lib/libgcc_s-4.6.so.1
f746e000 f7592000 r-xp /lib/libc-2.13.so
f75a0000 f75a2000 r-xp /usr/lib/libdlog.so.0.0.0
f75aa000 f75b6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75bf000 f75c3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75cc000 f75cf000 r-xp /usr/lib/libappcore-agent.so.1.1
f75ed000 f760a000 r-xp /lib/ld-2.13.so
f7613000 f7615000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7615000 f7619000 r-xp /usr/lib/libsys-assert.so
f78c9000 f790a000 rw-p [heap]
ff896000 ff8b7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11209)
Call Stack Count: 1
 0: strlen + 0x4 (0xf74e40b4) [/lib/libc.so.6] + 0x760b4
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
emotePort
04-12 19:27:26.319+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:26.319+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:27:26.319+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:26.329+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 19:27:26.329+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 19:27:26.329+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 19:27:26.329+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [13711.591784] layer(0x21e250) now usable
04-12 19:27:26.329+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [13711.591806] layer[0x21dcf0]zpos[0]
04-12 19:27:26.329+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[11156] goes to (3)
04-12 19:27:26.329+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:27:26.329+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:27:26.329+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(11156) status(fg) type(uiapp)
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:27:26.329+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:26.339+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:27:26.339+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 19:27:26.349+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 19:27:26.349+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:27:26.349+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 19:27:26.359+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 19:27:26.359+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 19:27:26.359+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 19:27:26.629+0200 I/AUL     (11170): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 19:27:26.639+0200 I/AUL     (11170): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 19:27:26.639+0200 E/AUL     (11170): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 19:27:26.639+0200 E/AUL     (11170): aul_path.c: __get_path(169) > root_path is NULL!
04-12 19:27:26.709+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 19:27:26.849+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 19:27:27.169+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.179+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11156
04-12 19:27:27.179+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.189+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11156
04-12 19:27:27.189+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.189+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.199+0200 E/EFL     (11156): ecore_x<11156> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13712322 button=1
04-12 19:27:27.199+0200 E/EFL     (11156): ecore_x<11156> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13712461 button=1
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] mouse move
04-12 19:27:27.199+0200 E/EFL     (11156): elementary<11156> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7fcafb8 : elm_list] hold(0), freeze(0)
04-12 19:27:27.199+0200 W/AUL     (11156): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:27:27.199+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:27:27.199+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11156
04-12 19:27:27.219+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11197
04-12 19:27:27.219+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:27:27.229+0200 E/CAPI_APPFW_APPLICATION(11197): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.229+0200 E/CAPI_APPFW_APPLICATION(11197): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.239+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:27:27.269+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11197
04-12 19:27:27.269+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(11197) type(svcapp) bg(0)
04-12 19:27:27.269+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:27:27.269+0200 W/AUL     (11156): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11197)
04-12 19:27:27.269+0200 I/utils   (11156): es.ugr.frailty.servicemanager launch request sent!
04-12 19:27:27.269+0200 I/utils   (11156): App control destroyed.
04-12 19:27:27.269+0200 I/CAPI_APPFW_APPLICATION(11156): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:27:27.269+0200 I/CAPI_APPFW_APPLICATION(11156): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:27:27.279+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11197]
04-12 19:27:27.279+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11197
04-12 19:27:27.289+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11199
04-12 19:27:27.299+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:27:27.319+0200 E/CAPI_APPFW_APPLICATION(11199): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.319+0200 E/CAPI_APPFW_APPLICATION(11199): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.349+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11199
04-12 19:27:27.349+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(11199) type(svcapp) bg(0)
04-12 19:27:27.349+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11197) was created
04-12 19:27:27.349+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11199) was created
04-12 19:27:27.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.359+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11197
04-12 19:27:27.359+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11199]
04-12 19:27:27.369+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.379+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11199)
04-12 19:27:27.379+0200 I/servicemanager(11197): es.ugr.frailty.httppostreq launch request sent!
04-12 19:27:27.379+0200 I/servicemanager(11197): App control destroyed.
04-12 19:27:27.379+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:27:27.399+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:27:27.399+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11197
04-12 19:27:27.409+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11203
04-12 19:27:27.409+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:27:27.439+0200 E/CAPI_APPFW_APPLICATION(11203): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.439+0200 E/CAPI_APPFW_APPLICATION(11203): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:27.439+0200 W/CAPI_APPFW_APP_CONTROL(11203): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.439+0200 W/CAPI_APPFW_APP_CONTROL(11203): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.449+0200 I/CAPI_NETWORK_CONNECTION(11199): connection.c: connection_create(453) > New handle created[0xf767cbe0]
04-12 19:27:27.449+0200 W/CAPI_APPFW_APP_CONTROL(11199): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.449+0200 W/CAPI_APPFW_APP_CONTROL(11199): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.459+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11203
04-12 19:27:27.459+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(11203) type(svcapp) bg(0)
04-12 19:27:27.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.469+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11199
04-12 19:27:27.469+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11203) was created
04-12 19:27:27.469+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.479+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11203)
04-12 19:27:27.479+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11203]
04-12 19:27:27.479+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11197
04-12 19:27:27.479+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.489+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.489+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.499+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11203
04-12 19:27:27.499+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.499+0200 I/servicemanager(11197): es.ugr.frailty.recorder launch request sent!
04-12 19:27:27.499+0200 I/servicemanager(11197): App control destroyed.
04-12 19:27:27.499+0200 I/servicemanager(11197): Frailty Service Manager created
04-12 19:27:27.499+0200 W/CAPI_APPFW_APP_CONTROL(11197): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.519+0200 W/CAPI_APPFW_APP_CONTROL(11197): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:27.519+0200 I/AUL_PAD (11194): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 19:27:27.519+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.529+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11199
04-12 19:27:27.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:27:27.579+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:27:27.579+0200 W/APP_CORE(11156): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:27:27.579+0200 W/APP_CORE(11156): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[604ba4] for es.ugr.frailty.frailtylauncher[11156]
04-12 19:27:27.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:27.599+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11203
04-12 19:27:27.609+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:27.619+0200 I/APP_CORE(11156): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:27:27.619+0200 I/APP_CORE(11156): appcore-efl.c: __after_loop(1234) > [APP 11156] PAUSE before termination
04-12 19:27:27.619+0200 I/CAPI_APPFW_APPLICATION(11156): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:27:27.619+0200 I/CAPI_APPFW_APPLICATION(11156): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:27:27.619+0200 I/APP_CORE(11156): appcore-efl.c: __after_loop(1243) > [APP 11156] After terminate() callback
04-12 19:27:27.619+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:27:27.619+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:27:27.619+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:27.619+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:27.619+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:27:27.629+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:27:27.629+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:27:27.629+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:27:27.629+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:27:27.629+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:27:27.679+0200 I/UXT     (11156): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:27:27.679+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:27:27.679+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:27:27.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.679+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:27:27.679+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:27:27.679+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:27:27.679+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:27.679+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:27.679+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:27:27.679+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:27:27.679+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:27:27.719+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:27:27.719+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 19:27:27.719+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:27:27.719+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:27:27.719+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:27:27.719+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:27:27.719+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 19:27:27.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 19:27:27.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 19:27:27.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(27), length(2)
04-12 19:27:27.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 27%
04-12 19:27:27.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 27, isCharging: 0
04-12 19:27:27.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-12 19:27:27.729+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 19:27:27.729+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 19:27:27.729+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 19:27:27.729+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 19:27:27.739+0200 E/PKGMGR_SERVER(11106): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-12 19:27:27.739+0200 E/PKGMGR_SERVER(11106): pkgmgr-server.c: main(2295) > package manager server terminated.
04-12 19:27:27.739+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:27.739+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:27.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:27.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:27.809+0200 I/efl-extension(11156): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:27:27.819+0200 W/AUL_PAD (11156): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:27:27.829+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11156 pgid = 11156
04-12 19:27:27.829+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:27:27.869+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:27:27.869+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11156
04-12 19:27:27.869+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11156)
04-12 19:27:27.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:27.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:28.159+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [13713.421396] layer(0x21e250) not usable
04-12 19:27:28.159+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [13713.421451] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:27:28.159+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [13713.421482] layer[0x21dcf0]zpos[0]
04-12 19:27:28.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:28.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:28.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:28.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:28.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:28.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:27:28.719+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.719+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:27:28.719+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:27:28.729+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:28.739+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:27:28.749+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:27:28.749+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:27:28.749+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:27:28.749+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:27:28.749+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:27:28.749+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:27:28.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.749+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:27:28.749+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:27:28.759+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:27:28.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:27:28.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:27:28.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:27:28.759+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:27:28.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.759+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:27:28.759+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:27:28.769+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:27:28.769+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:27:28.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:27:28.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:28.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:28.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:28.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:29.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:29.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:29.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:29.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:29.579+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:27:29.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:29.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:29.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:29.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:29.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:29.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:30.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:30.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:30.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:30.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:30.509+0200 I/servicemanager(11197): accelerometer alive timeout
04-12 19:27:30.509+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:27:30.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:27:30.509+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11197
04-12 19:27:30.529+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11209
04-12 19:27:30.529+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:27:30.579+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11209
04-12 19:27:30.579+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(11209) type(svcapp) bg(0)
04-12 19:27:30.589+0200 W/AUL     (11197): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11209)
04-12 19:27:30.589+0200 I/servicemanager(11197): es.ugr.frailty.accelerometer launch request sent!
04-12 19:27:30.589+0200 I/servicemanager(11197): App control destroyed.
04-12 19:27:30.589+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11209]
04-12 19:27:30.599+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:30.599+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:30.599+0200 E/CAPI_APPFW_APPLICATION(11209): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:30.599+0200 E/CAPI_APPFW_APPLICATION(11209): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:27:30.609+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11209) was created
04-12 19:27:30.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:30.619+0200 I/accelerometer(11209): Starting es.ugr.frailty.accelerometer service
04-12 19:27:30.629+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11209
04-12 19:27:30.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:27:30.639+0200 I/accelerometer(11209): sensor supported
04-12 19:27:30.639+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11209
04-12 19:27:30.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:30.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:27:30.649+0200 I/accelerometer(11209): es.ugr.frailty.accelerometer listener started
04-12 19:27:30.649+0200 W/CAPI_APPFW_APP_CONTROL(11209): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:27:30.719+0200 I/utils   (11209): accelerometer utils fecha 12/04/2018,19:27:30
04-12 19:27:30.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:27:30.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:27:30.839+0200 W/AUL     (11223): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:27:30.839+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:27:30.839+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:27:30.839+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11209
04-12 19:27:30.849+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:27:30.849+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11209
04-12 19:27:30.849+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11209)
04-12 19:27:30.939+0200 W/CRASH_MANAGER(11225): worker.c: worker_job(1205) > 1111209616363152355405
