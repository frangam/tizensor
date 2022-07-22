S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 6967
Date: 2018-04-12 18:42:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x58

Register Information
r0   = 0x00000058, r1   = 0x00000058
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xff9fe688
r6   = 0xf75626d8, r7   = 0x00000058
r8   = 0x00000014, r9   = 0x00000000
r10  = 0xf75626c3, fp   = 0xff9fe67c
ip   = 0xff9febbc, sp   = 0xff9fe110
lr   = 0xf73fce8c, pc   = 0xf74320b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     68204 KB
Buffers:     42992 KB
Cached:     219812 KB
VmPeak:      45392 KB
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
PID = 6967 TID = 6967
6967 6976 6977 6978 6979 

Maps Information
f4b6e000 f536d000 rw-p [stack:6979]
f536e000 f5b6d000 rw-p [stack:6978]
f5b6e000 f636d000 rw-p [stack:6977]
f636e000 f6b71000 rw-p [stack:6976]
f6b71000 f6b74000 r-xp /lib/libattr.so.1.1.0
f6b7c000 f6b83000 r-xp /lib/libcrypt-2.13.so
f6bb4000 f6bb7000 r-xp /lib/libcap.so.2.21
f6bbf000 f6bc1000 r-xp /usr/lib/libiri.so
f6bc9000 f6bcb000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bd3000 f6bd5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bde000 f6caa000 r-xp /usr/lib/libxml2.so.2.7.8
f6cb8000 f6cd5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cde000 f6ce2000 r-xp /usr/lib/libsmack.so.1.0.0
f6ceb000 f6d01000 r-xp /lib/libz.so.1.2.5
f6d09000 f6d0b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d13000 f6d18000 r-xp /usr/lib/libffi.so.5.0.10
f6d20000 f6d21000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d29000 f6d39000 r-xp /lib/libresolv-2.13.so
f6d3d000 f6d55000 r-xp /usr/lib/liblzma.so.5.0.3
f6d5d000 f6d5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d67000 f6d81000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d89000 f6db8000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dc1000 f6dd0000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6dd9000 f6de3000 r-xp /usr/lib/libsensord-shared.so
f6dec000 f6e20000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e29000 f6efc000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f07000 f6f0d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f16000 f6f8b000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f95000 f6f9b000 r-xp /lib/librt-2.13.so
f6fa4000 f6fc2000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fcc000 f6fcd000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fd5000 f6ff8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7000000 f7005000 r-xp /usr/lib/libxdgmime.so.1.1.0
f700d000 f70dd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70de000 f7108000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7111000 f7128000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7130000 f7199000 r-xp /lib/libm-2.13.so
f71a2000 f7236000 r-xp /usr/lib/libstdc++.so.6.0.16
f7249000 f724e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7256000 f725d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7265000 f728f000 r-xp /usr/lib/libsensor.so.1.9.6
f7298000 f729b000 r-xp /usr/lib/libbundle.so.0.1.22
f72a3000 f72a9000 r-xp /usr/lib/libappsvc.so.0.1.0
f72b1000 f72f2000 r-xp /usr/lib/libeina.so.1.7.99
f72fb000 f7312000 r-xp /usr/lib/libecore.so.1.7.99
f7329000 f7332000 r-xp /usr/lib/libvconf.so.0.2.45
f733a000 f734e000 r-xp /lib/libpthread-2.13.so
f7359000 f7366000 r-xp /usr/lib/libaul.so.0.1.0
f7370000 f7372000 r-xp /lib/libdl-2.13.so
f737b000 f7386000 r-xp /lib/libunwind.so.8.0.1
f73b3000 f73bb000 r-xp /lib/libgcc_s-4.6.so.1
f73bc000 f74e0000 r-xp /lib/libc-2.13.so
f74ee000 f74f0000 r-xp /usr/lib/libdlog.so.0.0.0
f74f8000 f7504000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f750d000 f7511000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f751a000 f751d000 r-xp /usr/lib/libappcore-agent.so.1.1
f753b000 f7558000 r-xp /lib/ld-2.13.so
f7561000 f7563000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f7563000 f7567000 r-xp /usr/lib/libsys-assert.so
f7c9e000 f7cdf000 rw-p [heap]
ff9df000 ffa00000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6967)
Call Stack Count: 1
 0: strlen + 0x4 (0xf74320b4) [/lib/libc.so.6] + 0x760b4
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
ce::SendMessage
04-12 18:42:03.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:03.949+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:42:03.949+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:42:03.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:42:03.949+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:03.959+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(bg) type(uiapp)
04-12 18:42:03.959+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-12 18:42:03.959+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:42:03.959+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-12 18:42:03.959+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (4)
04-12 18:42:03.959+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(4)
04-12 18:42:03.959+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_unset_buffer(1602) > [10989.223662] layer(0x21e250) now usable
04-12 18:42:03.959+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10989.223678] layer[0x21dcf0]zpos[0]
04-12 18:42:03.959+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[6915] goes to (3)
04-12 18:42:03.959+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:42:03.959+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:42:03.959+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(es.ugr.frailty.frailtylauncher) pid(6915) status(fg) type(uiapp)
04-12 18:42:03.969+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_pause(1113) > widget_pause
04-12 18:42:03.969+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(bg) type(watchapp)
04-12 18:42:03.969+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppPause(552) > 
04-12 18:42:03.979+0200 I/APP_CORE( 6915): appcore-efl.c: __do_app(453) > [APP 6915] Event: RESUME State: RUNNING
04-12 18:42:03.989+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:42:03.989+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [false][0m
04-12 18:42:03.989+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:42:03.989+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:42:04.049+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:42:04.079+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:42:04.079+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:42:04.089+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:42:04.119+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:42:04.129+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:42:04.139+0200 W/healthData( 2828): health_fw_share.c: __health_notify_share_cb(331) > [1;40;33mNotification is called [category:shealth_pedometer_info][0;m
04-12 18:42:04.139+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:42:04.339+0200 E/AUL     ( 2499): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-12 18:42:04.389+0200 I/AUL     ( 6929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-12 18:42:04.399+0200 I/AUL     ( 6929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-12 18:42:04.399+0200 E/AUL     ( 6929): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-12 18:42:04.399+0200 E/AUL     ( 6929): aul_path.c: __get_path(169) > root_path is NULL!
04-12 18:42:04.449+0200 E/EFL     ( 6915): ecore_x<6915> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=10989715 button=1
04-12 18:42:04.449+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.449+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.449+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] hold(0), freeze(0)
04-12 18:42:04.459+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:42:04.469+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.469+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] hold(0), freeze(0)
04-12 18:42:04.489+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.489+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] hold(0), freeze(0)
04-12 18:42:04.499+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.499+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] hold(0), freeze(0)
04-12 18:42:04.519+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] mouse move
04-12 18:42:04.519+0200 E/EFL     ( 6915): elementary<6915> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf8000f90 : elm_list] hold(0), freeze(0)
04-12 18:42:04.569+0200 E/EFL     ( 6915): ecore_x<6915> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=10989836 button=1
04-12 18:42:04.569+0200 W/AUL     ( 6915): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:42:04.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:42:04.569+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6915
04-12 18:42:04.589+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6952
04-12 18:42:04.589+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:42:04.609+0200 E/CAPI_APPFW_APPLICATION( 6952): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.609+0200 E/CAPI_APPFW_APPLICATION( 6952): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.609+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:42:04.639+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6952
04-12 18:42:04.639+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(6952) type(svcapp) bg(0)
04-12 18:42:04.639+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:42:04.639+0200 W/AUL     ( 6915): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6952)
04-12 18:42:04.639+0200 I/utils   ( 6915): es.ugr.frailty.servicemanager launch request sent!
04-12 18:42:04.639+0200 I/utils   ( 6915): App control destroyed.
04-12 18:42:04.639+0200 I/CAPI_APPFW_APPLICATION( 6915): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:42:04.639+0200 I/CAPI_APPFW_APPLICATION( 6915): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:42:04.639+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6952]
04-12 18:42:04.649+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6952
04-12 18:42:04.659+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6955
04-12 18:42:04.659+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:42:04.699+0200 E/CAPI_APPFW_APPLICATION( 6955): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.699+0200 E/CAPI_APPFW_APPLICATION( 6955): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.709+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6955
04-12 18:42:04.709+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(6955) type(svcapp) bg(0)
04-12 18:42:04.709+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6952) was created
04-12 18:42:04.709+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6955) was created
04-12 18:42:04.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.719+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6955]
04-12 18:42:04.719+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6952
04-12 18:42:04.719+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.729+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6952
04-12 18:42:04.729+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:04.729+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6955)
04-12 18:42:04.729+0200 I/servicemanager( 6952): es.ugr.frailty.httppostreq launch request sent!
04-12 18:42:04.729+0200 I/servicemanager( 6952): App control destroyed.
04-12 18:42:04.729+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:42:04.739+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:42:04.739+0200 E/PKGMGR_SERVER( 6879): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=1, queue_status=1] 
04-12 18:42:04.739+0200 E/PKGMGR_SERVER( 6879): pkgmgr-server.c: main(2295) > package manager server terminated.
04-12 18:42:04.739+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6952
04-12 18:42:04.749+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6958
04-12 18:42:04.799+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:42:04.799+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6958
04-12 18:42:04.799+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6958) type(svcapp) bg(0)
04-12 18:42:04.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:04.799+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.809+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6955
04-12 18:42:04.819+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:04.819+0200 E/CAPI_APPFW_APPLICATION( 6958): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.819+0200 E/CAPI_APPFW_APPLICATION( 6958): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:04.819+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6958) was created
04-12 18:42:04.819+0200 W/CAPI_APPFW_APP_CONTROL( 6958): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:04.819+0200 W/CAPI_APPFW_APP_CONTROL( 6958): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:04.819+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6958)
04-12 18:42:04.819+0200 I/servicemanager( 6952): es.ugr.frailty.recorder launch request sent!
04-12 18:42:04.819+0200 I/servicemanager( 6952): App control destroyed.
04-12 18:42:04.819+0200 I/servicemanager( 6952): Frailty Service Manager created
04-12 18:42:04.819+0200 W/CAPI_APPFW_APP_CONTROL( 6952): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:04.819+0200 W/CAPI_APPFW_APP_CONTROL( 6952): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:04.829+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6958]
04-12 18:42:04.839+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.849+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6958
04-12 18:42:04.849+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:04.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.869+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6915
04-12 18:42:04.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:04.949+0200 W/APP_CORE( 6915): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:42:04.949+0200 W/APP_CORE( 6915): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[601cf6] for es.ugr.frailty.frailtylauncher[6915]
04-12 18:42:04.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:04.999+0200 I/APP_CORE( 6915): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:42:04.999+0200 I/APP_CORE( 6915): appcore-efl.c: __after_loop(1234) > [APP 6915] PAUSE before termination
04-12 18:42:04.999+0200 I/CAPI_APPFW_APPLICATION( 6915): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:42:04.999+0200 I/CAPI_APPFW_APPLICATION( 6915): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:42:04.999+0200 I/APP_CORE( 6915): appcore-efl.c: __after_loop(1243) > [APP 6915] After terminate() callback
04-12 18:42:05.009+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6955
04-12 18:42:05.009+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:42:05.009+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:42:05.009+0200 I/CAPI_NETWORK_CONNECTION( 6955): connection.c: connection_create(453) > New handle created[0xf7959be0]
04-12 18:42:05.019+0200 W/CAPI_APPFW_APP_CONTROL( 6955): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:05.019+0200 W/CAPI_APPFW_APP_CONTROL( 6955): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:05.019+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:42:05.019+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:42:05.019+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.019+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.019+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:42:05.029+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:42:05.029+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:42:05.029+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:42:05.029+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:42:05.029+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:42:05.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:05.069+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:05.079+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6958
04-12 18:42:05.079+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:05.089+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:42:05.089+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:42:05.089+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.089+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.089+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:42:05.099+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:42:05.099+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.099+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.099+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:42:05.099+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.099+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:42:05.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:05.109+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:42:05.109+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6915
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:42:05.129+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:42:05.129+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 18:42:05.129+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:42:05.139+0200 I/UXT     ( 6915): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:42:05.149+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:42:05.149+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:42:05.149+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:42:05.159+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 18:42:05.159+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 18:42:05.159+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 18:42:05.159+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.159+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.169+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:42:05.169+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 18:42:05.169+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 18:42:05.169+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 18:42:05.179+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(36), length(2)
04-12 18:42:05.179+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 36%
04-12 18:42:05.179+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 36, isCharging: 0
04-12 18:42:05.179+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_40
04-12 18:42:05.179+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 18:42:05.179+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:05.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.259+0200 I/efl-extension( 6915): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:42:05.279+0200 W/AUL_PAD ( 6915): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:42:05.279+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 6915 pgid = 6915
04-12 18:42:05.279+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:42:05.329+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:42:05.329+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6915
04-12 18:42:05.329+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6915)
04-12 18:42:05.339+0200 I/AUL_PAD ( 6956): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-12 18:42:05.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.569+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [10990.836388] layer(0x21e250) not usable
04-12 18:42:05.569+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [10990.836445] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:42:05.569+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [10990.836476] layer[0x21dcf0]zpos[0]
04-12 18:42:05.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:05.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:05.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:42:06.139+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.139+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:42:06.139+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:42:06.149+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:06.159+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:42:06.179+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:42:06.179+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:42:06.179+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.179+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:42:06.179+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:42:06.179+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:42:06.179+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:42:06.179+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.179+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:42:06.189+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.189+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:42:06.189+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:42:06.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:06.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:06.199+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:42:06.199+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:42:06.199+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:42:06.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:06.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:06.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:06.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:06.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:06.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:06.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:06.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:07.009+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:42:07.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:07.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:07.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:07.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:07.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:07.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:07.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:07.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:07.829+0200 I/servicemanager( 6952): accelerometer alive timeout
04-12 18:42:07.829+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:42:07.829+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:42:07.829+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 6952
04-12 18:42:07.849+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 6967
04-12 18:42:07.849+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:42:07.899+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6967
04-12 18:42:07.899+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6967) type(svcapp) bg(0)
04-12 18:42:07.899+0200 W/AUL     ( 6952): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6967)
04-12 18:42:07.909+0200 I/servicemanager( 6952): es.ugr.frailty.accelerometer launch request sent!
04-12 18:42:07.909+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6967]
04-12 18:42:07.909+0200 E/CAPI_APPFW_APPLICATION( 6967): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:07.909+0200 E/CAPI_APPFW_APPLICATION( 6967): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:42:07.909+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (6967) was created
04-12 18:42:07.909+0200 I/servicemanager( 6952): App control destroyed.
04-12 18:42:07.909+0200 I/accelerometer( 6967): Starting es.ugr.frailty.accelerometer service
04-12 18:42:07.919+0200 I/accelerometer( 6967): sensor supported
04-12 18:42:07.939+0200 I/accelerometer( 6967): es.ugr.frailty.accelerometer listener started
04-12 18:42:07.939+0200 W/CAPI_APPFW_APP_CONTROL( 6967): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:42:07.949+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:07.969+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6967
04-12 18:42:07.969+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:42:07.979+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6967
04-12 18:42:07.979+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:07.979+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:42:07.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:07.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:08.029+0200 I/utils   ( 6967): accelerometer utils fecha 12/04/2018,18:42:08
04-12 18:42:08.029+0200 I/utils   ( 6967): accelerometer utils fecha X,X
04-12 18:42:08.029+0200 I/accelerometer( 6967): accelerometer fecha conseguida
04-12 18:42:08.139+0200 W/AUL     ( 6982): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:42:08.139+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:42:08.149+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:42:08.149+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6967
04-12 18:42:08.149+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:42:08.149+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6967
04-12 18:42:08.149+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6967)
04-12 18:42:08.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:42:08.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:42:08.199+0200 W/CRASH_MANAGER( 6981): worker.c: worker_job(1205) > 1106967616363152355132
