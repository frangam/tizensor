S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 11445
Date: 2018-04-12 19:28:54+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x38323a38

Register Information
r0   = 0x38323a39, r1   = 0x38323a38
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffa4bf58
r6   = 0xf72106c3, r7   = 0x38323a39
r8   = 0x0000001a, r9   = 0x00000000
r10  = 0xf72106a8, fp   = 0xffa4bf4c
ip   = 0xffa4c48c, sp   = 0xffa4b9e0
lr   = 0xf70aae8c, pc   = 0xf70e00b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     49144 KB
Buffers:     53588 KB
Cached:     224696 KB
VmPeak:      45396 KB
VmSize:      45008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7256 KB
VmRSS:        7256 KB
VmData:      35180 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 11445 TID = 11445
11445 11454 11455 11456 11457 

Maps Information
f481c000 f501b000 rw-p [stack:11457]
f501c000 f581b000 rw-p [stack:11456]
f581c000 f601b000 rw-p [stack:11455]
f601c000 f681f000 rw-p [stack:11454]
f681f000 f6822000 r-xp /lib/libattr.so.1.1.0
f682a000 f6831000 r-xp /lib/libcrypt-2.13.so
f6862000 f6865000 r-xp /lib/libcap.so.2.21
f686d000 f686f000 r-xp /usr/lib/libiri.so
f6877000 f6879000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6881000 f6883000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f688c000 f6958000 r-xp /usr/lib/libxml2.so.2.7.8
f6966000 f6983000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f698c000 f6990000 r-xp /usr/lib/libsmack.so.1.0.0
f6999000 f69af000 r-xp /lib/libz.so.1.2.5
f69b7000 f69b9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69c1000 f69c6000 r-xp /usr/lib/libffi.so.5.0.10
f69ce000 f69cf000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69d7000 f69e7000 r-xp /lib/libresolv-2.13.so
f69eb000 f6a03000 r-xp /usr/lib/liblzma.so.5.0.3
f6a0b000 f6a0d000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a15000 f6a2f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a37000 f6a66000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a6f000 f6a7e000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a87000 f6a91000 r-xp /usr/lib/libsensord-shared.so
f6a9a000 f6ace000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ad7000 f6baa000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bb5000 f6bbb000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bc4000 f6c39000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c43000 f6c49000 r-xp /lib/librt-2.13.so
f6c52000 f6c70000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c7a000 f6c7b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c83000 f6ca6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cae000 f6cb3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cbb000 f6d8b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d8c000 f6db6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dbf000 f6dd6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dde000 f6e47000 r-xp /lib/libm-2.13.so
f6e50000 f6ee4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ef7000 f6efc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f04000 f6f0b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f13000 f6f3d000 r-xp /usr/lib/libsensor.so.1.9.6
f6f46000 f6f49000 r-xp /usr/lib/libbundle.so.0.1.22
f6f51000 f6f57000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f5f000 f6fa0000 r-xp /usr/lib/libeina.so.1.7.99
f6fa9000 f6fc0000 r-xp /usr/lib/libecore.so.1.7.99
f6fd7000 f6fe0000 r-xp /usr/lib/libvconf.so.0.2.45
f6fe8000 f6ffc000 r-xp /lib/libpthread-2.13.so
f7007000 f7014000 r-xp /usr/lib/libaul.so.0.1.0
f701e000 f7020000 r-xp /lib/libdl-2.13.so
f7029000 f7034000 r-xp /lib/libunwind.so.8.0.1
f7061000 f7069000 r-xp /lib/libgcc_s-4.6.so.1
f706a000 f718e000 r-xp /lib/libc-2.13.so
f719c000 f719e000 r-xp /usr/lib/libdlog.so.0.0.0
f71a6000 f71b2000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71bb000 f71bf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71c8000 f71cb000 r-xp /usr/lib/libappcore-agent.so.1.1
f71e9000 f7206000 r-xp /lib/ld-2.13.so
f720f000 f7211000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7211000 f7215000 r-xp /usr/lib/libsys-assert.so
f777d000 f77be000 rw-p [heap]
ffa2d000 ffa4e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11445)
Call Stack Count: 1
 0: strlen + 0x4 (0xf70e00b4) [/lib/libc.so.6] + 0x760b4
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
2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 19:28:50.439+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [13795.707491] layer(0x21e250) now usable
04-12 19:28:50.439+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [13795.707507] layer[0x21dcf0]zpos[0]
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:28:50.449+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:50.449+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[11395] goes to (3)
04-12 19:28:50.449+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:28:50.449+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:28:50.449+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(11395) status(fg) type(uiapp)
04-12 19:28:50.449+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 19:28:50.449+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:28:50.449+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 19:28:50.449+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 19:28:50.449+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 19:28:50.449+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 19:28:50.479+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:28:50.479+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 19:28:50.819+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 19:28:50.839+0200 I/AUL     (11407): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 19:28:50.849+0200 I/AUL     (11407): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 19:28:50.849+0200 E/AUL     (11407): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 19:28:50.849+0200 E/AUL     (11407): aul_path.c: __get_path(169) > root_path is NULL!
04-12 19:28:50.949+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 19:28:51.259+0200 E/EFL     (11395): ecore_x<11395> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13796518 button=1
04-12 19:28:51.259+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.259+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.259+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.269+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.269+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.279+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.279+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.279+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.289+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11395
04-12 19:28:51.289+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.309+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11395
04-12 19:28:51.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.349+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.349+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.399+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.399+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.429+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.429+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.449+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] mouse move
04-12 19:28:51.449+0200 E/EFL     (11395): elementary<11395> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7204fb0 : elm_list] hold(0), freeze(0)
04-12 19:28:51.479+0200 E/EFL     (11395): ecore_x<11395> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13796739 button=1
04-12 19:28:51.479+0200 W/AUL     (11395): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:28:51.479+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:28:51.479+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11395
04-12 19:28:51.489+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11434
04-12 19:28:51.489+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:28:51.499+0200 I/AUL_PAD (11431): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 19:28:51.509+0200 E/CAPI_APPFW_APPLICATION(11434): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.509+0200 E/CAPI_APPFW_APPLICATION(11434): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.509+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:28:51.539+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11434
04-12 19:28:51.539+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(11434) type(svcapp) bg(0)
04-12 19:28:51.539+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:28:51.539+0200 W/AUL     (11395): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11434)
04-12 19:28:51.539+0200 I/utils   (11395): es.ugr.frailty.servicemanager launch request sent!
04-12 19:28:51.539+0200 I/utils   (11395): App control destroyed.
04-12 19:28:51.539+0200 I/CAPI_APPFW_APPLICATION(11395): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:28:51.539+0200 I/CAPI_APPFW_APPLICATION(11395): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:28:51.549+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11434]
04-12 19:28:51.549+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11434
04-12 19:28:51.559+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11437
04-12 19:28:51.559+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:28:51.589+0200 E/CAPI_APPFW_APPLICATION(11437): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.589+0200 E/CAPI_APPFW_APPLICATION(11437): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.609+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11437
04-12 19:28:51.609+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(11437) type(svcapp) bg(0)
04-12 19:28:51.609+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11434) was created
04-12 19:28:51.609+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11437) was created
04-12 19:28:51.609+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.619+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11434
04-12 19:28:51.619+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.619+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11437)
04-12 19:28:51.619+0200 I/servicemanager(11434): es.ugr.frailty.httppostreq launch request sent!
04-12 19:28:51.619+0200 I/servicemanager(11434): App control destroyed.
04-12 19:28:51.619+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:28:51.619+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11437]
04-12 19:28:51.629+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:28:51.629+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11434
04-12 19:28:51.639+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11439
04-12 19:28:51.639+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:28:51.649+0200 E/CAPI_APPFW_APPLICATION(11439): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.649+0200 E/CAPI_APPFW_APPLICATION(11439): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:51.649+0200 W/CAPI_APPFW_APP_CONTROL(11439): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.649+0200 W/CAPI_APPFW_APP_CONTROL(11439): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.689+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11439
04-12 19:28:51.689+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(11439) type(svcapp) bg(0)
04-12 19:28:51.689+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.699+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11439)
04-12 19:28:51.699+0200 I/servicemanager(11434): es.ugr.frailty.recorder launch request sent!
04-12 19:28:51.699+0200 I/servicemanager(11434): App control destroyed.
04-12 19:28:51.699+0200 I/servicemanager(11434): Frailty Service Manager created
04-12 19:28:51.699+0200 W/CAPI_APPFW_APP_CONTROL(11434): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.699+0200 W/CAPI_APPFW_APP_CONTROL(11434): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.699+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11437
04-12 19:28:51.699+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11439) was created
04-12 19:28:51.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.709+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11434
04-12 19:28:51.719+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11439]
04-12 19:28:51.719+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.719+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.739+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.749+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11439
04-12 19:28:51.749+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.749+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.759+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11437
04-12 19:28:51.759+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.769+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:51.779+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11439
04-12 19:28:51.779+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:51.779+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:28:51.779+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:28:51.779+0200 W/APP_CORE(11395): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:28:51.789+0200 W/APP_CORE(11395): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[604f08] for es.ugr.frailty.frailtylauncher[11395]
04-12 19:28:51.789+0200 I/CAPI_NETWORK_CONNECTION(11437): connection.c: connection_create(453) > New handle created[0xf7ef0be0]
04-12 19:28:51.789+0200 W/CAPI_APPFW_APP_CONTROL(11437): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.789+0200 W/CAPI_APPFW_APP_CONTROL(11437): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:51.819+0200 I/APP_CORE(11395): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:28:51.819+0200 I/APP_CORE(11395): appcore-efl.c: __after_loop(1234) > [APP 11395] PAUSE before termination
04-12 19:28:51.819+0200 I/CAPI_APPFW_APPLICATION(11395): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:28:51.819+0200 I/CAPI_APPFW_APPLICATION(11395): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:28:51.819+0200 I/APP_CORE(11395): appcore-efl.c: __after_loop(1243) > [APP 11395] After terminate() callback
04-12 19:28:51.829+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:28:51.829+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:28:51.829+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:51.829+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:51.829+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:28:51.829+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:28:51.829+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:28:51.839+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:28:51.839+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:28:51.839+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:28:51.879+0200 I/UXT     (11395): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:28:51.889+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:28:51.899+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:28:51.899+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:28:51.899+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:51.899+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:51.899+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:28:51.899+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:28:51.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.899+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.909+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.909+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:28:51.909+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:28:51.909+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:28:51.929+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:28:51.929+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 19:28:51.929+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 19:28:51.929+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(26), length(2)
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 26%
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 26, isCharging: 0
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-12 19:28:51.929+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 19:28:51.929+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:28:51.929+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:28:51.939+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 19:28:51.939+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 19:28:51.939+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 19:28:51.949+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:51.949+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:51.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:51.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:52.009+0200 I/efl-extension(11395): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:28:52.009+0200 W/AUL_PAD (11395): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:28:52.019+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 11395 pgid = 11395
04-12 19:28:52.019+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:28:52.059+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:28:52.069+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11395
04-12 19:28:52.069+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11395)
04-12 19:28:52.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:52.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:52.379+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [13797.641749] layer(0x21e250) not usable
04-12 19:28:52.379+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [13797.641802] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:28:52.379+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [13797.641836] layer[0x21dcf0]zpos[0]
04-12 19:28:52.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:52.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:52.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:52.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:52.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:52.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:28:52.929+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.929+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:28:52.929+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:28:52.929+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:52.949+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:28:52.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:28:52.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:28:52.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:28:52.959+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.959+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:28:52.959+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:28:52.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:28:52.959+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:28:52.959+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.969+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:28:52.969+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:28:52.969+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:28:52.969+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:28:52.969+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:28:52.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:52.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:53.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:53.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:53.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:53.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:53.519+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 19:28:53.569+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:28:53.579+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:28:53.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:53.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:53.599+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 19:28:53.629+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 19:28:53.639+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 19:28:53.659+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 19:28:53.779+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:28:53.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:53.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:53.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:53.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:54.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:54.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:54.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:54.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:54.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:54.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:54.699+0200 I/servicemanager(11434): accelerometer alive timeout
04-12 19:28:54.699+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:28:54.699+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:28:54.699+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 11434
04-12 19:28:54.729+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 11445
04-12 19:28:54.729+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:28:54.779+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11445
04-12 19:28:54.779+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(11445) type(svcapp) bg(0)
04-12 19:28:54.779+0200 W/AUL     (11434): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11445)
04-12 19:28:54.779+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11445]
04-12 19:28:54.779+0200 I/servicemanager(11434): es.ugr.frailty.accelerometer launch request sent!
04-12 19:28:54.779+0200 I/servicemanager(11434): App control destroyed.
04-12 19:28:54.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:54.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:54.809+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:54.819+0200 E/CAPI_APPFW_APPLICATION(11445): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:54.819+0200 E/CAPI_APPFW_APPLICATION(11445): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:28:54.819+0200 I/accelerometer(11445): Starting es.ugr.frailty.accelerometer service
04-12 19:28:54.829+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11445
04-12 19:28:54.829+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (11445) was created
04-12 19:28:54.829+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:54.839+0200 I/accelerometer(11445): sensor supported
04-12 19:28:54.849+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:28:54.849+0200 I/accelerometer(11445): es.ugr.frailty.accelerometer listener started
04-12 19:28:54.849+0200 W/CAPI_APPFW_APP_CONTROL(11445): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:28:54.859+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11445
04-12 19:28:54.859+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:28:54.899+0200 I/utils   (11445): accelerometer utils fecha 9:28:54,19:28:54
04-12 19:28:54.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:28:54.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:28:55.019+0200 W/AUL     (11460): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:28:55.019+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:28:55.019+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:28:55.019+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 11445
04-12 19:28:55.019+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:28:55.029+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 11445
04-12 19:28:55.029+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(11445)
04-12 19:28:55.079+0200 W/CRASH_MANAGER(11459): worker.c: worker_job(1205) > 1111445616363152355413
