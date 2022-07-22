S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 17639
Date: 2018-04-23 13:47:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7162648, r1   = 0xf73e31b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf73e31b8, r5   = 0x00012cd0
r6   = 0xf73f5e88, r7   = 0xf7162250
r8   = 0x000005e0, r9   = 0xf6c45824
r10  = 0xf73db9d8, fp   = 0x00000000
ip   = 0xf7161030, sp   = 0xffd0f340
lr   = 0xf70a55d0, pc   = 0xf70a19fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     81720 KB
Buffers:     30216 KB
Cached:     148528 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7760 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f67dc000 f67df000 r-xp /lib/libattr.so.1.1.0
f67e8000 f67ef000 r-xp /lib/libcrypt-2.13.so
f681f000 f6822000 r-xp /lib/libcap.so.2.21
f682a000 f682c000 r-xp /usr/lib/libiri.so
f6834000 f6851000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f685a000 f685e000 r-xp /usr/lib/libsmack.so.1.0.0
f6868000 f686a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6872000 f6877000 r-xp /usr/lib/libffi.so.5.0.10
f687f000 f6880000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6888000 f688a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6892000 f6894000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f689e000 f68ae000 r-xp /lib/libresolv-2.13.so
f68b2000 f68ca000 r-xp /usr/lib/liblzma.so.5.0.3
f68d2000 f68d4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68dc000 f690b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6914000 f6923000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f692c000 f6936000 r-xp /usr/lib/libsensord-shared.so
f693f000 f6973000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f697c000 f6a4f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a5a000 f6a70000 r-xp /lib/libz.so.1.2.5
f6a78000 f6a7e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a87000 f6afc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b06000 f6b20000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b28000 f6b2e000 r-xp /lib/librt-2.13.so
f6b37000 f6b55000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b5f000 f6b60000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b68000 f6b6d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b75000 f6c45000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c46000 f6c70000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c79000 f6c90000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c98000 f6d01000 r-xp /lib/libm-2.13.so
f6d0a000 f6d9e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6db1000 f6db6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dbe000 f6dc5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dcd000 f6df7000 r-xp /usr/lib/libsensor.so.1.9.6
f6e00000 f6ecc000 r-xp /usr/lib/libxml2.so.2.7.8
f6ed9000 f6edb000 r-xp /usr/lib/libiniparser.so.0
f6ee4000 f6ee7000 r-xp /usr/lib/libbundle.so.0.1.22
f6eef000 f6ef5000 r-xp /usr/lib/libappsvc.so.0.1.0
f6efd000 f6f20000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f28000 f6f69000 r-xp /usr/lib/libeina.so.1.7.99
f6f72000 f6f89000 r-xp /usr/lib/libecore.so.1.7.99
f6fa0000 f6fa9000 r-xp /usr/lib/libvconf.so.0.2.45
f6fb1000 f6fc5000 r-xp /lib/libpthread-2.13.so
f6fd0000 f6fdd000 r-xp /usr/lib/libaul.so.0.1.0
f6fe7000 f6fe9000 r-xp /lib/libdl-2.13.so
f6ff2000 f6ffd000 r-xp /lib/libunwind.so.8.0.1
f702a000 f7032000 r-xp /lib/libgcc_s-4.6.so.1
f7033000 f7157000 r-xp /lib/libc-2.13.so
f7165000 f7167000 r-xp /usr/lib/libdlog.so.0.0.0
f716f000 f717b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7184000 f7189000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7191000 f7195000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f719e000 f71a0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f71a9000 f71ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f71ca000 f71e7000 r-xp /lib/ld-2.13.so
f71f0000 f71f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f71f3000 f71f7000 r-xp /usr/lib/libsys-assert.so
f73d1000 f741f000 rw-p [heap]
ffcf1000 ffd12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17639)
Call Stack Count: 1
 0: (0xf70a19fc) [/lib/libc.so.6] + 0x6e9fc
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
cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 13:46:56.321+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 13:46:56.321+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 13:46:56.321+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 13:46:56.321+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[event],charge : 0, connected : 0
04-23 13:46:56.321+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 13:46:56.331+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 13:46:56.331+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 13:46:56.331+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 13:46:56.331+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 13:46:56.331+0200 W/SHealthCommon(17411): FeedbackManager.cpp: PlayFeedback(67) > [1;40;33mshealth pattern : 19 tizenPattern tpye 115 feedbackType : 3[0;m
04-23 13:46:56.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:56.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:56:344,70
04-23 13:46:56.341+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 13:46:56.341+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 13:46:56.341+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 13:46:56.341+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 13:46:56.351+0200 W/WSLib   (17411): Application.cpp: ReplyAppControll(555) > [1;35m ###[0;m
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [20891.470763] layer(0x47f2c0) not usable
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [20891.470798] layer(0x47f2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [20891.470816] layer[0x47ee10]zpos[1]
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [20891.470877] layer(0x47f250) not usable
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [20891.470890] layer(0x47f250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [20891.470905] layer[0x47ecf0]zpos[0]
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [20891.470930] layer(0x47f310) not usable
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [20891.470941] layer(0x47f310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 13:46:56.361+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [20891.470955] layer[0x47ef30]zpos[2]
04-23 13:46:56.361+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-23 13:46:56.361+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(524) > [APP 17411] Initial Launching, call the resume_cb
04-23 13:46:56.361+0200 I/CAPI_APPFW_APPLICATION(17411): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-23 13:46:56.361+0200 W/WSLib   (17411): Application.cpp: SOnAppResume(323) > [1;35m ###[0;m
04-23 13:46:56.361+0200 W/SHealthCommon(17411): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_resumed, name: app_resumed][0;m
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:46:56.361+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:46:56.361+0200 W/SHealthAlertViewer(17411): AlertViewerApplication.cpp: OnAppResumeImpl(183) > [1;35m ###[0;m
04-23 13:46:56.361+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_resumed[0;m
04-23 13:46:56.371+0200 W/APP_CORE(17411): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3400003
04-23 13:46:56.371+0200 I/efl-extension(17411): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0xf80f0120 = w: 1 h: 1  obj 0xf80f60a0 w: 360 h: 360
04-23 13:46:56.381+0200 I/efl-extension(17411): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
04-23 13:46:56.411+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 13:46:56.471+0200 E/WMS     ( 2466): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23480) > _wms_event_handler_cb_nomove_detector is called
04-23 13:46:56.491+0200 W/W_HOME  ( 2759): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(1)
04-23 13:46:56.491+0200 W/W_HOME  ( 2759): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-23 13:46:56.491+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:46:56.491+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:46:56.491+0200 W/W_HOME  ( 2759): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(1)
04-23 13:46:56.491+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: PAUSED
04-23 13:46:56.491+0200 I/wnotib  ( 2759): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
04-23 13:46:56.491+0200 E/wnotib  ( 2759): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-23 13:46:56.491+0200 W/wnotib  ( 2759): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [0], notiboard card appending count [0].
04-23 13:46:56.501+0200 W/STARTER ( 2693): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2759] goes to (4)
04-23 13:46:56.501+0200 E/STARTER ( 2693): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2759)'s state(4)
04-23 13:46:56.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:46:56.511+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20891.620504] layer(0x47f250) now usable
04-23 13:46:56.511+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20891.620531] layer[0x47ecf0]zpos[0]
04-23 13:46:56.511+0200 W/STARTER ( 2693): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[17411] goes to (3)
04-23 13:46:56.521+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 13:46:56.521+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 0
04-23 13:46:56.521+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 13:46:56.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:56.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2759) status(bg) type(uiapp)
04-23 13:46:56.541+0200 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-23 13:46:56.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-23 13:46:56.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.shealth.alert) pid(17411) status(fg) type(uiapp)
04-23 13:46:56.561+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 13:46:56.561+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 13:46:56.591+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: RESUME State: RUNNING
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:Home.Reserved.Display]
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:46:56.591+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(300) > [reserved_apps_message_received_cb:300] current reserved apps status : 8
04-23 13:46:56.591+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(303) > [reserved_apps_message_received_cb:303] appid [com.samsung.shealth.alert], msg value[drop]
04-23 13:46:56.591+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(391) > [reserved_apps_message_received_cb:391] now reserved apps status 0
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:Home.Reserved.Display]
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:46:56.591+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:46:56.601+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(300) > [reserved_apps_message_received_cb:300] current reserved apps status : 0
04-23 13:46:56.601+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(303) > [reserved_apps_message_received_cb:303] appid [com.samsung.shealth.alert], msg value[show]
04-23 13:46:56.601+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(337) > [reserved_apps_message_received_cb:337] now reserved apps status 1
04-23 13:46:56.601+0200 W/STARTER ( 2693): clock-mgr.c: reserved_apps_message_received_cb(422) > [reserved_apps_message_received_cb:422] 0. com.samsung.shealth.alert
04-23 13:46:56.611+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [event]
04-23 13:46:56.611+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 13:46:56.651+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [1581][0;m
04-23 13:46:56.661+0200 W/SHealthCommon(17411): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 13:46:56.661+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:56:539,70
04-23 13:46:56.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:56.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:56:738,70
04-23 13:46:56.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:46:56.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:46:56.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:46:56.871+0200 W/WSLib   (17411): Application.cpp: OnTimerTick(579) > [1;35m ###[0;m
04-23 13:46:56.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:46:56.901+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:46:56.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:46:56.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:56.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:56:939,70
04-23 13:46:56.951+0200 W/SHealthService( 3087): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [1280][0;m
04-23 13:46:56.961+0200 E/AUL     ( 2478): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-23 13:46:56.961+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 13:46:56.961+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:46:56.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:46:56.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:46:57.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:46:57.101+0200 I/AUL_PAD (17615): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-23 13:46:57.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:57.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:57:140,70
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491217292,000000, pattern:[H:mm][0;m
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:57.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:46:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:46][0;m
04-23 13:46:57.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:57.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:57:343,70
04-23 13:46:57.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:57.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:57:539,70
04-23 13:46:57.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:57.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:57:740,70
04-23 13:46:57.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:57.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:57:940,70
04-23 13:46:58.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:58.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:58:140,70
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491218292,000000, pattern:[H:mm][0;m
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:58.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:46:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:46][0;m
04-23 13:46:58.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:58.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:58:340,70
04-23 13:46:58.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:58.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:58:540,70
04-23 13:46:58.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:58.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:58:741,70
04-23 13:46:58.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:58.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:58:941,70
04-23 13:46:59.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:59.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:59:140,70
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491219292,000000, pattern:[H:mm][0;m
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:46:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:46:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:46:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:46][0;m
04-23 13:46:59.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:59.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:59:340,70
04-23 13:46:59.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:59.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:59:541,71
04-23 13:46:59.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:59.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:59:741,70
04-23 13:46:59.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:46:59.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:46:59:941,70
04-23 13:47:00.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:00.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:00:142,70
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491220300,000000, pattern:[H:mm][0;m
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:00.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:00.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:00.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:00:341,70
04-23 13:47:00.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:00.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:00:542,70
04-23 13:47:00.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:00.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:00:742,70
04-23 13:47:00.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:00.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:00:942,70
04-23 13:47:01.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:01.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:01:142,70
04-23 13:47:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:47:01.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:01.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:47:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:47:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:01.311+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491221324,000000, pattern:[H:mm][0;m
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:01.311+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:01.311+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:01.311+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:01.321+0200 I/utils   (17422): specific action
04-23 13:47:01.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:47:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:47:01.331+0200 I/httppostreq(17422): internet connection check received
04-23 13:47:01.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:01.341+0200 I/httppostreq(17422): internet connection != null
04-23 13:47:01.341+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:47:01.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:01:347,70
04-23 13:47:01.341+0200 I/httppostreq(17422): internet connection type...
04-23 13:47:01.341+0200 I/httppostreq(17422): internet connection type 1
04-23 13:47:01.341+0200 I/httppostreq(17422): internet available
04-23 13:47:01.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:47:01.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:47:01.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:47:01.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:47:01.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:47:01.391+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:01.391+0200 I/utils   (17419): specific action
04-23 13:47:01.391+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:01.391+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:01.391+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:47:01.391+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:47:01.391+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:47:01.401+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:47:01.401+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:47:01.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:01.421+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:47:01.421+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17625
04-23 13:47:01.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17625
04-23 13:47:01.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(17625) type(svcapp) bg(0)
04-23 13:47:01.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17625]
04-23 13:47:01.481+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17625)
04-23 13:47:01.481+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:47:01.481+0200 I/servicemanager(17419): App control destroyed.
04-23 13:47:01.481+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.481+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.481+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.481+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.481+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.481+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.481+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.481+0200 I/servicemanager(17419): deleting timer 0
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.491+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.491+0200 I/servicemanager(17419): deleting timer 1
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.491+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.491+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.491+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.501+0200 E/CAPI_APPFW_APPLICATION(17625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:01.501+0200 E/CAPI_APPFW_APPLICATION(17625): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.501+0200 I/utils   (17625): trying to start service: es.ugr.frailty.accelerometer
04-23 13:47:01.501+0200 I/utils   (17625): es.ugr.frailty.accelerometer sensor supported
04-23 13:47:01.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17625
04-23 13:47:01.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.521+0200 I/utils   (17625): es.ugr.frailty.accelerometer listener started
04-23 13:47:01.521+0200 I/accelerometer(17625): stopping es.ugr.frailty.accelerometer service
04-23 13:47:01.521+0200 E/CAPI_APPFW_APP_CONTROL(17625): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:47:01.521+0200 E/accelerometer(17625): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:47:01.521+0200 I/CAPI_APPFW_APPLICATION(17625): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:47:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17625
04-23 13:47:01.521+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17625) was created
04-23 13:47:01.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 2
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.571+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 3
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.571+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 4
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.571+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 5
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.571+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 6
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:47:01.571+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:47:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:47:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 7
04-23 13:47:01.571+0200 I/servicemanager(17419): deleting timer 8
04-23 13:47:01.571+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:47:01.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:47:01.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:47:01.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:47:01.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:47:01.581+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:01.591+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17639
04-23 13:47:01.611+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:47:01.641+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:47:01.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17639
04-23 13:47:01.641+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(17639) type(svcapp) bg(0)
04-23 13:47:01.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.651+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17639]
04-23 13:47:01.661+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17639)
04-23 13:47:01.661+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:47:01.671+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:01:592,70
04-23 13:47:01.681+0200 E/CAPI_APPFW_APPLICATION(17639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:01.681+0200 E/CAPI_APPFW_APPLICATION(17639): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:47:01.681+0200 I/utils   (17639): specific action
04-23 13:47:01.681+0200 I/recorder(17639): obteniendo datos locales...
04-23 13:47:01.691+0200 I/accelerometer(17625): es.ugr.frailty.accelerometer listener destroyed
04-23 13:47:01.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.701+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17625
04-23 13:47:01.701+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:47:01.701+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17639) was created
04-23 13:47:01.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.711+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17639
04-23 13:47:01.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.721+0200 I/recorder(17639): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:47:01.721+0200 I/recorder(17639): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:47:01.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:01.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:01:742,70
04-23 13:47:01.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17639
04-23 13:47:01.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:47:01.851+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17639
04-23 13:47:01.851+0200 W/AUL     (17644): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:47:01.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:47:01.861+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1117639726563152448402
