S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 27737
Date: 2018-04-23 12:57:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7740648, r1   = 0xf7d901b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7d901b8, r5   = 0x00012cd0
r6   = 0xf7da2e88, r7   = 0xf7740250
r8   = 0x000005c8, r9   = 0xf7223824
r10  = 0xf7d889d8, fp   = 0x00000000
ip   = 0xf773f030, sp   = 0xfff1feb0
lr   = 0xf76835d0, pc   = 0xf767f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     10592 KB
Buffers:     72440 KB
Cached:     185984 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7720 KB
VmRSS:        7720 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          32 KB
VmSwap:          0 KB

Maps Information
f6dba000 f6dbd000 r-xp /lib/libattr.so.1.1.0
f6dc6000 f6dcd000 r-xp /lib/libcrypt-2.13.so
f6dfd000 f6e00000 r-xp /lib/libcap.so.2.21
f6e08000 f6e0a000 r-xp /usr/lib/libiri.so
f6e12000 f6e2f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6e38000 f6e3c000 r-xp /usr/lib/libsmack.so.1.0.0
f6e46000 f6e48000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e50000 f6e55000 r-xp /usr/lib/libffi.so.5.0.10
f6e5d000 f6e5e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e66000 f6e68000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e70000 f6e72000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e7c000 f6e8c000 r-xp /lib/libresolv-2.13.so
f6e90000 f6ea8000 r-xp /usr/lib/liblzma.so.5.0.3
f6eb0000 f6eb2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6eba000 f6ee9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ef2000 f6f01000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6f0a000 f6f14000 r-xp /usr/lib/libsensord-shared.so
f6f1d000 f6f51000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f5a000 f702d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f7038000 f704e000 r-xp /lib/libz.so.1.2.5
f7056000 f705c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7065000 f70da000 r-xp /usr/lib/libsqlite3.so.0.8.6
f70e4000 f70fe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f7106000 f710c000 r-xp /lib/librt-2.13.so
f7115000 f7133000 r-xp /usr/lib/libsystemd.so.0.4.0
f713d000 f713e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7146000 f714b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7153000 f7223000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7224000 f724e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7257000 f726e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7276000 f72df000 r-xp /lib/libm-2.13.so
f72e8000 f737c000 r-xp /usr/lib/libstdc++.so.6.0.16
f738f000 f7394000 r-xp /usr/lib/libctx-client.so.0.8.3
f739c000 f73a3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f73ab000 f73d5000 r-xp /usr/lib/libsensor.so.1.9.6
f73de000 f74aa000 r-xp /usr/lib/libxml2.so.2.7.8
f74b7000 f74b9000 r-xp /usr/lib/libiniparser.so.0
f74c2000 f74c5000 r-xp /usr/lib/libbundle.so.0.1.22
f74cd000 f74d3000 r-xp /usr/lib/libappsvc.so.0.1.0
f74db000 f74fe000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7506000 f7547000 r-xp /usr/lib/libeina.so.1.7.99
f7550000 f7567000 r-xp /usr/lib/libecore.so.1.7.99
f757e000 f7587000 r-xp /usr/lib/libvconf.so.0.2.45
f758f000 f75a3000 r-xp /lib/libpthread-2.13.so
f75ae000 f75bb000 r-xp /usr/lib/libaul.so.0.1.0
f75c5000 f75c7000 r-xp /lib/libdl-2.13.so
f75d0000 f75db000 r-xp /lib/libunwind.so.8.0.1
f7608000 f7610000 r-xp /lib/libgcc_s-4.6.so.1
f7611000 f7735000 r-xp /lib/libc-2.13.so
f7743000 f7745000 r-xp /usr/lib/libdlog.so.0.0.0
f774d000 f7759000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7762000 f7767000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f776f000 f7773000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f777c000 f777e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7787000 f778a000 r-xp /usr/lib/libappcore-agent.so.1.1
f77a8000 f77c5000 r-xp /lib/ld-2.13.so
f77ce000 f77d1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f77d1000 f77d5000 r-xp /usr/lib/libsys-assert.so
f7d7e000 f7dcc000 rw-p [heap]
fff02000 fff23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27737)
Call Stack Count: 1
 0: (0xf767f9fc) [/lib/libc.so.6] + 0x6e9fc
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
 apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:57:11.381+0200 W/W_HOME  ( 2759): clock_manager.c: _compositing_set(205) > hwc:1
04-23 12:57:11.381+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [17906.499130] layer(0x47f250) not usable
04-23 12:57:11.381+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [17906.499162] layer(0x47f250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 12:57:11.381+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17906.499179] layer[0x47ecf0]zpos[0]
04-23 12:57:11.391+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:57:11.391+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:57:11.391+0200 W/W_HOME  ( 2759): clock_manager.c: _hwc_enabled_success_cb(153) > hwc enabled
04-23 12:57:11.411+0200 E/watchface-viewer( 2872): viewer-touch-detector.cpp: OnTouched(150) > Dali::TouchPoint::State = [1]
04-23 12:57:11.411+0200 E/watchface-viewer( 2872): viewer-group.cpp: OnReleased(512) > x y [133,297] trigger[5]
04-23 12:57:11.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:57:11.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:57:11.611+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:57:11.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:57:11.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:57:11.881+0200 W/W_HOME  ( 2759): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
04-23 12:57:11.901+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-23 12:57:11.901+0200 I/WATCH_CORE( 2872): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 12:57:11.901+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:57:11.901+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [17907.020876] layer(0x47f2c0) now usable
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17907.020904] layer[0x47ee10]zpos[1]
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [17907.020927] layer(0x47f310) now usable
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17907.020937] layer[0x47ef30]zpos[2]
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [17907.020961] layer(0x47f250) now usable
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [17907.020972] layer[0x47ecf0]zpos[0]
04-23 12:57:11.911+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [17907.021058] dpms[0 -> 3]sync[1]
04-23 12:57:11.911+0200 I/TDM     ( 1945): 
04-23 12:57:11.921+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 12:57:11.921+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:57:11.931+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 12:57:11.931+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 12:57:11.931+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 12:57:11.931+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 12:57:11.931+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 12:57:11.931+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 12:57:11.941+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 12:57:11.941+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 12:57:11.941+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 12:57:11.941+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 12:57:11.951+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 12:57:11.951+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 12:57:11.951+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 12:57:11.951+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 12:57:11.951+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 12:57:11.951+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 12:57:11.951+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 12:57:11.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:57:11.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:57:12.051+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [17907.160899] dpms[3 -> 3]done
04-23 12:57:12.051+0200 I/TDM     ( 1945): 
04-23 12:57:12.061+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 12:57:12.061+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 12:57:12.081+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 12:57:12.081+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 12:57:12.081+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 12:57:12.081+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 12:57:12.081+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: RUNNING
04-23 12:57:12.081+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): main.c: _appcore_pause_cb(488) > appcore pause
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): main.c: home_pause(547) > clock/widget paused
04-23 12:57:12.081+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 12:57:12.081+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:57:12.091+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 12:57:12.101+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 12:57:12.101+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(bg) type(watchapp)
04-23 12:57:12.101+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppPause(552) > 
04-23 12:57:12.111+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 12:57:12.111+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [false][0m
04-23 12:57:12.111+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 12:57:12.111+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 12:57:12.121+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 12:57:12.121+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 12:57:12.121+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 12:57:12.121+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 12:57:12.121+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 12:57:12.381+0200 E/EFL     ( 2319): ecore_x<2319> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1e00003 time=17907201
04-23 12:57:12.381+0200 E/EFL     ( 2759): ecore_x<2759> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=17907201
04-23 12:57:12.381+0200 E/EFL     ( 2319): ecore_x<2319> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=17907201
04-23 12:57:12.581+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 12:57:17.091+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 12:57:19.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:57:19.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:19.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:19.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:57:19.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:57:19.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:57:19.381+0200 I/utils   (25866): specific action
04-23 12:57:19.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:57:19.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:57:19.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:57:19.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:57:19.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:57:19.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:57:19.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:57:19.381+0200 I/httppostreq(25866): internet available
04-23 12:57:19.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:57:19.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:19.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:57:19.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:57:19.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:57:19.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:57:19.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:19.401+0200 I/utils   (25863): specific action
04-23 12:57:19.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:19.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:19.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:57:19.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:57:19.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:57:19.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:57:19.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:19.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:19.411+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27657
04-23 12:57:19.411+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:57:19.451+0200 E/CAPI_APPFW_APPLICATION(27657): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:19.451+0200 E/CAPI_APPFW_APPLICATION(27657): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:19.451+0200 I/utils   (27657): trying to start service: es.ugr.frailty.accelerometer
04-23 12:57:19.451+0200 I/utils   (27657): es.ugr.frailty.accelerometer sensor supported
04-23 12:57:19.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27657
04-23 12:57:19.461+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27657) type(svcapp) bg(0)
04-23 12:57:19.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27657]
04-23 12:57:19.471+0200 I/utils   (27657): es.ugr.frailty.accelerometer listener started
04-23 12:57:19.471+0200 I/accelerometer(27657): stopping es.ugr.frailty.accelerometer service
04-23 12:57:19.471+0200 E/CAPI_APPFW_APP_CONTROL(27657): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:57:19.471+0200 E/accelerometer(27657): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:57:19.471+0200 I/CAPI_APPFW_APPLICATION(27657): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:57:19.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:57:19.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:57:19.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27657) was created
04-23 12:57:19.481+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27657)
04-23 12:57:19.481+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:57:19.481+0200 I/servicemanager(25863): App control destroyed.
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.481+0200 E/servicemanager(25863): deleting timer 0
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.481+0200 E/servicemanager(25863): deleting timer 1
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.481+0200 E/servicemanager(25863): deleting timer 2
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.481+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.481+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.481+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.481+0200 E/servicemanager(25863): deleting timer 3
04-23 12:57:19.491+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.491+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.491+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.491+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.491+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.491+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.491+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.491+0200 E/servicemanager(25863): deleting timer 4
04-23 12:57:19.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:19.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27657
04-23 12:57:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:19.511+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:19.511+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:19.511+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:19.511+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:19.511+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:19.511+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:19.511+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:19.511+0200 E/servicemanager(25863): deleting timer 5
04-23 12:57:19.511+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:57:19.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:19.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:19.521+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27670
04-23 12:57:19.521+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:57:19.571+0200 E/CAPI_APPFW_APPLICATION(27670): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:19.571+0200 E/CAPI_APPFW_APPLICATION(27670): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:19.571+0200 I/utils   (27670): specific action
04-23 12:57:19.571+0200 I/recorder(27670): obteniendo datos locales...
04-23 12:57:19.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27670
04-23 12:57:19.571+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27670) type(svcapp) bg(0)
04-23 12:57:19.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:19.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27657
04-23 12:57:19.581+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27670) was created
04-23 12:57:19.591+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27670]
04-23 12:57:19.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:19.611+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27670
04-23 12:57:19.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:19.611+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27670)
04-23 12:57:19.611+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:57:19.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:19.711+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:57:19.721+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:57:19.741+0200 I/accelerometer(27657): es.ugr.frailty.accelerometer listener destroyed
04-23 12:57:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:19.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27670
04-23 12:57:19.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:19.761+0200 I/recorder(27670): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:57:19.761+0200 I/recorder(27670): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:57:19.831+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 11276707265631524481039
04-23 12:57:19.841+0200 W/AUL     (27676): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:57:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:57:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:57:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27670
04-23 12:57:19.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:57:19.841+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27670
04-23 12:57:19.841+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27670)
04-23 12:57:19.891+0200 W/AUL     (27680): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:57:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:57:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:57:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 27657
04-23 12:57:19.891+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:57:19.901+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 27657
04-23 12:57:19.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(27657)
04-23 12:57:21.471+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:57:29.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:57:29.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:29.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:57:29.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:57:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:57:29.381+0200 I/utils   (25866): specific action
04-23 12:57:29.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:57:29.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:57:29.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:57:29.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:57:29.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:57:29.381+0200 I/httppostreq(25866): internet available
04-23 12:57:29.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:57:29.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:57:29.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:57:29.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:29.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:57:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:57:29.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:57:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:57:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:29.391+0200 I/utils   (25863): specific action
04-23 12:57:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:29.391+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:57:29.391+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:57:29.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:57:29.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:57:29.391+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:57:29.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:29.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:29.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27725
04-23 12:57:29.401+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:57:29.441+0200 E/CAPI_APPFW_APPLICATION(27725): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:29.441+0200 E/CAPI_APPFW_APPLICATION(27725): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:29.441+0200 I/utils   (27725): trying to start service: es.ugr.frailty.accelerometer
04-23 12:57:29.451+0200 I/utils   (27725): es.ugr.frailty.accelerometer sensor supported
04-23 12:57:29.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27725
04-23 12:57:29.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27725) type(svcapp) bg(0)
04-23 12:57:29.461+0200 I/utils   (27725): es.ugr.frailty.accelerometer listener started
04-23 12:57:29.461+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27725) was created
04-23 12:57:29.461+0200 I/accelerometer(27725): stopping es.ugr.frailty.accelerometer service
04-23 12:57:29.461+0200 E/CAPI_APPFW_APP_CONTROL(27725): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:57:29.461+0200 E/accelerometer(27725): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:57:29.461+0200 I/CAPI_APPFW_APPLICATION(27725): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:57:29.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27725)
04-23 12:57:29.461+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:57:29.461+0200 I/servicemanager(25863): App control destroyed.
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 0
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 1
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 2
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 3
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 4
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:57:29.461+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:57:29.461+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:57:29.461+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:57:29.461+0200 E/servicemanager(25863): deleting timer 5
04-23 12:57:29.461+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:57:29.461+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27725]
04-23 12:57:29.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:57:29.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:57:29.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:57:29.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:57:29.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27737
04-23 12:57:29.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:57:29.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27737
04-23 12:57:29.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27737) type(svcapp) bg(0)
04-23 12:57:29.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:29.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27725
04-23 12:57:29.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:29.551+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27737]
04-23 12:57:29.561+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27737)
04-23 12:57:29.561+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:57:29.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:29.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27737
04-23 12:57:29.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:29.621+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:57:29.631+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:57:29.641+0200 E/CAPI_APPFW_APPLICATION(27737): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:29.641+0200 E/CAPI_APPFW_APPLICATION(27737): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:57:29.641+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27737) was created
04-23 12:57:29.641+0200 I/utils   (27737): specific action
04-23 12:57:29.641+0200 I/recorder(27737): obteniendo datos locales...
04-23 12:57:29.661+0200 I/recorder(27737): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:57:29.661+0200 I/recorder(27737): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:57:29.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:29.691+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27725
04-23 12:57:29.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:29.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:57:29.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27737
04-23 12:57:29.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:57:29.771+0200 I/accelerometer(27725): es.ugr.frailty.accelerometer listener destroyed
04-23 12:57:29.781+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1127737726563152448104
