S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 8806
Date: 2018-04-12 19:01:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xdad4cb00
r4   = 0xf735de89, r5   = 0xf70927fc
r6   = 0x00000000, r7   = 0xff9eb148
r8   = 0x00000041, r9   = 0xf6ed9824
r10  = 0xf7acaf00, fp   = 0x00000000
ip   = 0xf722e0b0, sp   = 0xff9ea028
lr   = 0xf735df5b, pc   = 0xf722e0b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     58808 KB
Buffers:     48252 KB
Cached:     222204 KB
VmPeak:      45264 KB
VmSize:      45012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7184 KB
VmRSS:        7184 KB
VmData:      35184 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8806 TID = 8806
8806 8815 8816 8817 8818 

Maps Information
f496a000 f5169000 rw-p [stack:8818]
f516a000 f5969000 rw-p [stack:8817]
f596a000 f6169000 rw-p [stack:8816]
f616a000 f696d000 rw-p [stack:8815]
f696d000 f6970000 r-xp /lib/libattr.so.1.1.0
f6978000 f697f000 r-xp /lib/libcrypt-2.13.so
f69b0000 f69b3000 r-xp /lib/libcap.so.2.21
f69bb000 f69bd000 r-xp /usr/lib/libiri.so
f69c5000 f69c7000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69cf000 f69d1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69da000 f6aa6000 r-xp /usr/lib/libxml2.so.2.7.8
f6ab4000 f6ad1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ada000 f6ade000 r-xp /usr/lib/libsmack.so.1.0.0
f6ae7000 f6afd000 r-xp /lib/libz.so.1.2.5
f6b05000 f6b07000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b0f000 f6b14000 r-xp /usr/lib/libffi.so.5.0.10
f6b1c000 f6b1d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b25000 f6b35000 r-xp /lib/libresolv-2.13.so
f6b39000 f6b51000 r-xp /usr/lib/liblzma.so.5.0.3
f6b59000 f6b5b000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b63000 f6b7d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b85000 f6bb4000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bbd000 f6bcc000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bd5000 f6bdf000 r-xp /usr/lib/libsensord-shared.so
f6be8000 f6c1c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c25000 f6cf8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d03000 f6d09000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d12000 f6d87000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d91000 f6d97000 r-xp /lib/librt-2.13.so
f6da0000 f6dbe000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dc8000 f6dc9000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dd1000 f6df4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6dfc000 f6e01000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e09000 f6ed9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6eda000 f6f04000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f0d000 f6f24000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f2c000 f6f95000 r-xp /lib/libm-2.13.so
f6f9e000 f7032000 r-xp /usr/lib/libstdc++.so.6.0.16
f7045000 f704a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7052000 f7059000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7061000 f708b000 r-xp /usr/lib/libsensor.so.1.9.6
f7094000 f7097000 r-xp /usr/lib/libbundle.so.0.1.22
f709f000 f70a5000 r-xp /usr/lib/libappsvc.so.0.1.0
f70ad000 f70ee000 r-xp /usr/lib/libeina.so.1.7.99
f70f7000 f710e000 r-xp /usr/lib/libecore.so.1.7.99
f7125000 f712e000 r-xp /usr/lib/libvconf.so.0.2.45
f7136000 f714a000 r-xp /lib/libpthread-2.13.so
f7155000 f7162000 r-xp /usr/lib/libaul.so.0.1.0
f716c000 f716e000 r-xp /lib/libdl-2.13.so
f7177000 f7182000 r-xp /lib/libunwind.so.8.0.1
f71af000 f71b7000 r-xp /lib/libgcc_s-4.6.so.1
f71b8000 f72dc000 r-xp /lib/libc-2.13.so
f72ea000 f72ec000 r-xp /usr/lib/libdlog.so.0.0.0
f72f4000 f7300000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7309000 f730d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7316000 f7319000 r-xp /usr/lib/libappcore-agent.so.1.1
f7337000 f7354000 r-xp /lib/ld-2.13.so
f735d000 f735f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f735f000 f7363000 r-xp /usr/lib/libsys-assert.so
f7ac0000 f7b02000 rw-p [heap]
ff9cc000 ff9ed000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8806)
Call Stack Count: 1
 0: strlen + 0x4 (0xf722e0b4) [/lib/libc.so.6] + 0x760b4
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
sagePortIpcServer::OnReadMessage
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:01:51.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:51.199+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 19:01:51.199+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:01:51.199+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 19:01:51.209+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:01:51.209+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 19:01:51.209+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:01:51.209+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 19:01:51.209+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 19:01:51.209+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 19:01:51.209+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [12176.475553] layer(0x21e250) now usable
04-12 19:01:51.209+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [12176.475582] layer[0x21dcf0]zpos[0]
04-12 19:01:51.209+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[8756] goes to (3)
04-12 19:01:51.219+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:01:51.219+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:01:51.219+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(8756) status(fg) type(uiapp)
04-12 19:01:51.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:01:51.219+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 19:01:51.219+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 19:01:51.219+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 19:01:51.239+0200 I/APP_CORE( 8756): appcore-efl.c: __do_app(453) > [APP 8756] Event: RESUME State: RUNNING
04-12 19:01:51.579+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 19:01:51.619+0200 I/AUL     ( 8768): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 19:01:51.619+0200 I/AUL     ( 8768): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 19:01:51.619+0200 E/AUL     ( 8768): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 19:01:51.619+0200 E/AUL     ( 8768): aul_path.c: __get_path(169) > root_path is NULL!
04-12 19:01:51.699+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 19:01:52.039+0200 E/wnoti-ancs( 2962): wnoti-ancs.c: __wnoti_received_noti(2175) > received_len = 8 :: [2][10][0][0][2][0][0][0][0][0][0][0][0][0][0]
04-12 19:01:52.059+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.069+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8756
04-12 19:01:52.069+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:52.079+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.089+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8756
04-12 19:01:52.089+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:52.279+0200 I/AUL_PAD ( 8792): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 19:01:52.629+0200 E/EFL     ( 8756): ecore_x<8756> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=12177890 button=1
04-12 19:01:52.629+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.629+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.629+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] hold(0), freeze(0)
04-12 19:01:52.649+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.649+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] hold(0), freeze(0)
04-12 19:01:52.659+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.659+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] hold(0), freeze(0)
04-12 19:01:52.699+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.699+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] hold(0), freeze(0)
04-12 19:01:52.709+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] mouse move
04-12 19:01:52.709+0200 E/EFL     ( 8756): elementary<8756> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7829228 : elm_list] hold(0), freeze(0)
04-12 19:01:52.719+0200 E/EFL     ( 8756): ecore_x<8756> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=12177987 button=1
04-12 19:01:52.719+0200 W/AUL     ( 8756): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:01:52.729+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:01:52.729+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8756
04-12 19:01:52.739+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8795
04-12 19:01:52.739+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:01:52.769+0200 E/CAPI_APPFW_APPLICATION( 8795): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.769+0200 E/CAPI_APPFW_APPLICATION( 8795): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.769+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:01:52.789+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8795
04-12 19:01:52.789+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(8795) type(svcapp) bg(0)
04-12 19:01:52.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:01:52.789+0200 W/AUL     ( 8756): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8795)
04-12 19:01:52.789+0200 I/utils   ( 8756): es.ugr.frailty.servicemanager launch request sent!
04-12 19:01:52.789+0200 I/utils   ( 8756): App control destroyed.
04-12 19:01:52.789+0200 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:01:52.789+0200 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:01:52.809+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8795]
04-12 19:01:52.809+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8795
04-12 19:01:52.819+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8798
04-12 19:01:52.819+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:01:52.849+0200 E/CAPI_APPFW_APPLICATION( 8798): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.849+0200 E/CAPI_APPFW_APPLICATION( 8798): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.869+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8798
04-12 19:01:52.869+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(8798) type(svcapp) bg(0)
04-12 19:01:52.869+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8795) was created
04-12 19:01:52.869+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8798) was created
04-12 19:01:52.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.879+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8798]
04-12 19:01:52.889+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8795
04-12 19:01:52.889+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.899+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8795
04-12 19:01:52.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:52.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:52.909+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8798)
04-12 19:01:52.909+0200 I/servicemanager( 8795): es.ugr.frailty.httppostreq launch request sent!
04-12 19:01:52.909+0200 I/servicemanager( 8795): App control destroyed.
04-12 19:01:52.909+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:01:52.909+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:01:52.909+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8795
04-12 19:01:52.919+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8801
04-12 19:01:52.919+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:01:52.949+0200 E/CAPI_APPFW_APPLICATION( 8801): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.949+0200 E/CAPI_APPFW_APPLICATION( 8801): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:52.949+0200 W/CAPI_APPFW_APP_CONTROL( 8801): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:52.949+0200 W/CAPI_APPFW_APP_CONTROL( 8801): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:52.969+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8801
04-12 19:01:52.969+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(8801) type(svcapp) bg(0)
04-12 19:01:52.969+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.979+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8798
04-12 19:01:52.979+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8801) was created
04-12 19:01:52.979+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:52.989+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8801)
04-12 19:01:52.989+0200 I/servicemanager( 8795): es.ugr.frailty.recorder launch request sent!
04-12 19:01:52.989+0200 I/servicemanager( 8795): App control destroyed.
04-12 19:01:52.999+0200 I/servicemanager( 8795): Frailty Service Manager created
04-12 19:01:52.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:52.999+0200 W/CAPI_APPFW_APP_CONTROL( 8795): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:53.009+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8798
04-12 19:01:53.009+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:53.009+0200 W/CAPI_APPFW_APP_CONTROL( 8795): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:53.019+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8801]
04-12 19:01:53.029+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:53.039+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8801
04-12 19:01:53.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:53.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:53.049+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8801
04-12 19:01:53.049+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:53.069+0200 I/CAPI_NETWORK_CONNECTION( 8798): connection.c: connection_create(453) > New handle created[0xf79f8be0]
04-12 19:01:53.069+0200 W/CAPI_APPFW_APP_CONTROL( 8798): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:53.069+0200 W/CAPI_APPFW_APP_CONTROL( 8798): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:53.079+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:01:53.079+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:01:53.079+0200 W/APP_CORE( 8756): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:01:53.079+0200 W/APP_CORE( 8756): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[6030ae] for es.ugr.frailty.frailtylauncher[8756]
04-12 19:01:53.119+0200 I/APP_CORE( 8756): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:01:53.119+0200 I/APP_CORE( 8756): appcore-efl.c: __after_loop(1234) > [APP 8756] PAUSE before termination
04-12 19:01:53.119+0200 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:01:53.119+0200 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:01:53.119+0200 I/APP_CORE( 8756): appcore-efl.c: __after_loop(1243) > [APP 8756] After terminate() callback
04-12 19:01:53.129+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:01:53.129+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:01:53.129+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.129+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.129+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:01:53.129+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:01:53.129+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:01:53.129+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:01:53.129+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:01:53.129+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:01:53.179+0200 I/UXT     ( 8756): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:01:53.189+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:01:53.199+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:01:53.199+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:01:53.199+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.199+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.199+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:01:53.199+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:01:53.199+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.199+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.199+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.199+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:01:53.199+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:01:53.199+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:01:53.219+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:01:53.219+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 19:01:53.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:01:53.219+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:01:53.219+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:01:53.219+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(32), length(2)
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 32%
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 32, isCharging: 0
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_35
04-12 19:01:53.229+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 19:01:53.239+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 19:01:53.239+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 19:01:53.239+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 19:01:53.249+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.249+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.309+0200 I/efl-extension( 8756): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:01:53.309+0200 W/AUL_PAD ( 8756): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:01:53.339+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8756 pgid = 8756
04-12 19:01:53.339+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:01:53.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.409+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:01:53.419+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8756
04-12 19:01:53.419+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8756)
04-12 19:01:53.519+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 19:01:53.589+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:01:53.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.619+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:01:53.639+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 19:01:53.659+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [12178.927940] layer(0x21e250) not usable
04-12 19:01:53.659+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [12178.927989] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:01:53.659+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [12178.928014] layer[0x21dcf0]zpos[0]
04-12 19:01:53.679+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 19:01:53.689+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 19:01:53.709+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 19:01:53.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:53.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:53.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:54.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:54.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:01:54.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.219+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:01:54.219+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:01:54.229+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:54.239+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:01:54.239+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:01:54.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:01:54.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:01:54.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.249+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:01:54.249+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:01:54.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:01:54.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:01:54.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:01:54.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.259+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:01:54.259+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:01:54.269+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:01:54.269+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:01:54.269+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:01:54.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:54.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:54.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:54.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:54.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:54.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:54.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:54.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.079+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:01:55.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:55.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:55.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:55.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:55.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:55.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:55.999+0200 I/servicemanager( 8795): accelerometer alive timeout
04-12 19:01:55.999+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:01:55.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:01:55.999+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8795
04-12 19:01:56.019+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8806
04-12 19:01:56.019+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:01:56.069+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8806
04-12 19:01:56.069+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(8806) type(svcapp) bg(0)
04-12 19:01:56.069+0200 W/AUL     ( 8795): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8806)
04-12 19:01:56.079+0200 I/servicemanager( 8795): es.ugr.frailty.accelerometer launch request sent!
04-12 19:01:56.079+0200 I/servicemanager( 8795): App control destroyed.
04-12 19:01:56.079+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8806]
04-12 19:01:56.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:56.109+0200 E/CAPI_APPFW_APPLICATION( 8806): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:56.109+0200 E/CAPI_APPFW_APPLICATION( 8806): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:01:56.119+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8806
04-12 19:01:56.119+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:56.119+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8806) was created
04-12 19:01:56.129+0200 I/accelerometer( 8806): Starting es.ugr.frailty.accelerometer service
04-12 19:01:56.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:01:56.129+0200 I/accelerometer( 8806): sensor supported
04-12 19:01:56.139+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8806
04-12 19:01:56.139+0200 I/accelerometer( 8806): es.ugr.frailty.accelerometer listener started
04-12 19:01:56.149+0200 W/CAPI_APPFW_APP_CONTROL( 8806): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:01:56.149+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:01:56.159+0200 I/utils   ( 8806): accelerometer utils fecha 12/04/2018,19:01:56
04-12 19:01:56.159+0200 I/accelerometer( 8806): accelerometer: 12/04/2018,19:01:56,0.129212,-0.040678,9.808180
04-12 19:01:56.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:01:56.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:01:56.289+0200 W/AUL     ( 8822): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:01:56.289+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:01:56.289+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:01:56.289+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8806
04-12 19:01:56.289+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:01:56.309+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8806
04-12 19:01:56.309+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8806)
04-12 19:01:56.319+0200 W/CRASH_MANAGER( 8820): worker.c: worker_job(1205) > 1108806616363152355251
