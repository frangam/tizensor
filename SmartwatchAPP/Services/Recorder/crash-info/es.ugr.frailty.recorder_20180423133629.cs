S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 15460
Date: 2018-04-23 13:36:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf74a0648, r1   = 0xf75c11b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf75c11b8, r5   = 0x00012cd0
r6   = 0xf75d3e88, r7   = 0xf74a0250
r8   = 0x000005e0, r9   = 0xf6f83824
r10  = 0xf75b99d8, fp   = 0x00000000
ip   = 0xf749f030, sp   = 0xff80c1f0
lr   = 0xf73e35d0, pc   = 0xf73df9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5388 KB
Buffers:     63732 KB
Cached:     162320 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6b1a000 f6b1d000 r-xp /lib/libattr.so.1.1.0
f6b26000 f6b2d000 r-xp /lib/libcrypt-2.13.so
f6b5d000 f6b60000 r-xp /lib/libcap.so.2.21
f6b68000 f6b6a000 r-xp /usr/lib/libiri.so
f6b72000 f6b8f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b98000 f6b9c000 r-xp /usr/lib/libsmack.so.1.0.0
f6ba6000 f6ba8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bb0000 f6bb5000 r-xp /usr/lib/libffi.so.5.0.10
f6bbd000 f6bbe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bc6000 f6bc8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bd0000 f6bd2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bdc000 f6bec000 r-xp /lib/libresolv-2.13.so
f6bf0000 f6c08000 r-xp /usr/lib/liblzma.so.5.0.3
f6c10000 f6c12000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c1a000 f6c49000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c52000 f6c61000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c6a000 f6c74000 r-xp /usr/lib/libsensord-shared.so
f6c7d000 f6cb1000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cba000 f6d8d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d98000 f6dae000 r-xp /lib/libz.so.1.2.5
f6db6000 f6dbc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dc5000 f6e3a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e44000 f6e5e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e66000 f6e6c000 r-xp /lib/librt-2.13.so
f6e75000 f6e93000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e9d000 f6e9e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ea6000 f6eab000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6eb3000 f6f83000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f84000 f6fae000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fb7000 f6fce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fd6000 f703f000 r-xp /lib/libm-2.13.so
f7048000 f70dc000 r-xp /usr/lib/libstdc++.so.6.0.16
f70ef000 f70f4000 r-xp /usr/lib/libctx-client.so.0.8.3
f70fc000 f7103000 r-xp /usr/lib/libctx-shared.so.0.8.3
f710b000 f7135000 r-xp /usr/lib/libsensor.so.1.9.6
f713e000 f720a000 r-xp /usr/lib/libxml2.so.2.7.8
f7217000 f7219000 r-xp /usr/lib/libiniparser.so.0
f7222000 f7225000 r-xp /usr/lib/libbundle.so.0.1.22
f722d000 f7233000 r-xp /usr/lib/libappsvc.so.0.1.0
f723b000 f725e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7266000 f72a7000 r-xp /usr/lib/libeina.so.1.7.99
f72b0000 f72c7000 r-xp /usr/lib/libecore.so.1.7.99
f72de000 f72e7000 r-xp /usr/lib/libvconf.so.0.2.45
f72ef000 f7303000 r-xp /lib/libpthread-2.13.so
f730e000 f731b000 r-xp /usr/lib/libaul.so.0.1.0
f7325000 f7327000 r-xp /lib/libdl-2.13.so
f7330000 f733b000 r-xp /lib/libunwind.so.8.0.1
f7368000 f7370000 r-xp /lib/libgcc_s-4.6.so.1
f7371000 f7495000 r-xp /lib/libc-2.13.so
f74a3000 f74a5000 r-xp /usr/lib/libdlog.so.0.0.0
f74ad000 f74b9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74c2000 f74c7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74cf000 f74d3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74dc000 f74de000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f74e7000 f74ea000 r-xp /usr/lib/libappcore-agent.so.1.1
f7508000 f7525000 r-xp /lib/ld-2.13.so
f752e000 f7531000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7531000 f7535000 r-xp /usr/lib/libsys-assert.so
f75af000 f75fd000 rw-p [heap]
ff7ee000 ff80f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15460)
Call Stack Count: 1
 0: (0xf73df9fc) [/lib/libc.so.6] + 0x6e9fc
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
0 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:13:496,73
04-23 13:36:13.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:36:13.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:36:13.631+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 13:36:13.631+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:36:13.631+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 13:36:13.631+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 13:36:13.631+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 13:36:13.631+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 13:36:13.631+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 13:36:13.631+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20248.747857] layer(0x47f2c0) now usable
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20248.747875] layer[0x47ee10]zpos[1]
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20248.747896] layer(0x47f310) now usable
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20248.747906] layer[0x47ef30]zpos[2]
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [20248.747925] layer(0x47f250) now usable
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [20248.747935] layer[0x47ecf0]zpos[0]
04-23 13:36:13.631+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [20248.747950] dpms[0 -> 3]sync[1]
04-23 13:36:13.631+0200 I/TDM     ( 1945): 
04-23 13:36:13.641+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 13:36:13.641+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 13:36:13.651+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 13:36:13.651+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 13:36:13.651+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 13:36:13.651+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 13:36:13.651+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 13:36:13.651+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 13:36:13.651+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 13:36:13.651+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 13:36:13.651+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 13:36:13.681+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:13.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:13:695,73
04-23 13:36:13.771+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [20248.880868] dpms[3 -> 3]done
04-23 13:36:13.771+0200 I/TDM     ( 1945): 
04-23 13:36:13.771+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:36:13.771+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:36:13.771+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:36:13.771+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 13:36:13.771+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:36:13.781+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 13:36:13.781+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 13:36:13.781+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 13:36:13.781+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 13:36:13.781+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: RUNNING
04-23 13:36:13.781+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): main.c: _appcore_pause_cb(488) > appcore pause
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): main.c: home_pause(547) > clock/widget paused
04-23 13:36:13.781+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:36:13.781+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:36:13.791+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:36:13.801+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 13:36:13.801+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [false][0m
04-23 13:36:13.801+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:36:13.801+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:36:13.801+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 13:36:13.801+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(bg) type(watchapp)
04-23 13:36:13.801+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppPause(552) > 
04-23 13:36:13.811+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 13:36:13.821+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 13:36:13.821+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 13:36:13.821+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 13:36:13.821+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:36:13.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:13.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:13:900,73
04-23 13:36:14.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:14.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:14:97,73
04-23 13:36:14.281+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:14.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:14:296,73
04-23 13:36:14.291+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 13:36:14.481+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:14.551+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:14:495,72
04-23 13:36:14.681+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:14.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:14:696,73
04-23 13:36:14.881+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:14.951+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:14:896,73
04-23 13:36:15.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:15.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:15:96,73
04-23 13:36:15.281+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:15.311+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:15:296,73
04-23 13:36:15.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:15.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:15:498,73
04-23 13:36:15.681+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:15.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:15:696,73
04-23 13:36:15.881+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:15.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:15:896,73
04-23 13:36:16.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:16.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:16:96,74
04-23 13:36:16.281+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:16.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:16:297,74
04-23 13:36:16.481+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:16.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:16:497,74
04-23 13:36:16.681+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:16.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:16:697,74
04-23 13:36:16.881+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:16.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:16:897,74
04-23 13:36:17.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:17.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:17:97,74
04-23 13:36:17.281+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:17.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:17:297,74
04-23 13:36:17.481+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:17.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:17:497,74
04-23 13:36:17.681+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:17.761+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:17:698,74
04-23 13:36:17.881+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:17.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:17:898,74
04-23 13:36:18.081+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:18.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:18:98,74
04-23 13:36:18.281+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:18.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:18:298,74
04-23 13:36:18.481+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:18.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:18:498,74
04-23 13:36:18.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:18.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:18:698,74
04-23 13:36:18.801+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 13:36:18.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:18.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:18:898,74
04-23 13:36:19.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:19.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:19:99,74
04-23 13:36:19.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:19.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:19:299,74
04-23 13:36:19.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:19.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:19:499,75
04-23 13:36:19.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:19.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:19:699,75
04-23 13:36:19.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:19.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:19:899,75
04-23 13:36:20.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:20.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:20:99,75
04-23 13:36:20.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:20.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:20:299,75
04-23 13:36:20.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:20.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:20:499,75
04-23 13:36:20.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:20.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:20:699,75
04-23 13:36:20.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:20.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:20:900,75
04-23 13:36:21.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:21.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:21:100,76
04-23 13:36:21.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:21.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:21:300,76
04-23 13:36:21.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:21.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:21:500,76
04-23 13:36:21.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:21.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:21:700,76
04-23 13:36:21.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:21.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:21:900,76
04-23 13:36:22.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:22.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:22:100,77
04-23 13:36:22.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:22.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:22:301,77
04-23 13:36:22.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:22.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:22:501,77
04-23 13:36:22.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:22.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:22:701,77
04-23 13:36:22.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:22.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:22:901,77
04-23 13:36:23.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:23.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:23:101,77
04-23 13:36:23.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:23.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:23:301,77
04-23 13:36:23.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:23.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:23:501,77
04-23 13:36:23.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:23.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:23:701,77
04-23 13:36:23.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:23.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:23:902,77
04-23 13:36:24.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:24.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:24:102,77
04-23 13:36:24.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:24.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:24:302,77
04-23 13:36:24.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:24.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:24:502,77
04-23 13:36:24.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:24.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:24:702,77
04-23 13:36:24.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:24.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:24:902,76
04-23 13:36:25.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:25.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:25:102,76
04-23 13:36:25.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:25.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:25:303,76
04-23 13:36:25.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:25.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:25:503,76
04-23 13:36:25.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:25.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:25:703,76
04-23 13:36:25.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:25.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:25:904,76
04-23 13:36:26.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:26.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:26:104,76
04-23 13:36:26.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:26.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:26:305,76
04-23 13:36:26.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:26.501+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:26:505,75
04-23 13:36:26.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:26.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:26:703,75
04-23 13:36:26.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:26.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:26:904,75
04-23 13:36:27.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:27.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:27:104,75
04-23 13:36:27.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:27.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:27:304,76
04-23 13:36:27.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:27.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:27:504,76
04-23 13:36:27.691+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:27.691+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:27:704,76
04-23 13:36:27.891+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:27.891+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:27:904,76
04-23 13:36:28.091+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:28.091+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:104,75
04-23 13:36:28.291+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:28.291+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:305,75
04-23 13:36:28.491+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:28.491+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:505,75
04-23 13:36:28.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:36:28.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:28.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:36:28.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:36:28.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:36:28.661+0200 I/utils   ( 9745): specific action
04-23 13:36:28.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:36:28.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:36:28.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:36:28.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:36:28.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:36:28.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:36:28.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:36:28.661+0200 I/httppostreq( 9745): internet available
04-23 13:36:28.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:36:28.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:36:28.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:36:28.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:36:28.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:36:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:28.691+0200 I/utils   ( 9742): specific action
04-23 13:36:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:28.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:36:28.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:36:28.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:36:28.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:36:28.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:36:28.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:28.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:28.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15447
04-23 13:36:28.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:36:28.701+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:28.731+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:717,75
04-23 13:36:28.741+0200 E/CAPI_APPFW_APPLICATION(15447): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.741+0200 E/CAPI_APPFW_APPLICATION(15447): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.751+0200 I/utils   (15447): trying to start service: es.ugr.frailty.accelerometer
04-23 13:36:28.751+0200 I/utils   (15447): es.ugr.frailty.accelerometer sensor supported
04-23 13:36:28.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15447
04-23 13:36:28.751+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15447) type(svcapp) bg(0)
04-23 13:36:28.761+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15447) was created
04-23 13:36:28.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15447]
04-23 13:36:28.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:28.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15447
04-23 13:36:28.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:28.841+0200 I/utils   (15447): es.ugr.frailty.accelerometer listener started
04-23 13:36:28.841+0200 I/accelerometer(15447): stopping es.ugr.frailty.accelerometer service
04-23 13:36:28.841+0200 E/CAPI_APPFW_APP_CONTROL(15447): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.841+0200 E/accelerometer(15447): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:36:28.841+0200 I/CAPI_APPFW_APPLICATION(15447): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:36:28.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:36:28.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:36:28.911+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:28.921+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15447)
04-23 13:36:28.921+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:36:28.921+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:28.921+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:36:28.921+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:36:28.921+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:36:28.921+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:36:28.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:36:28.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:36:28.931+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15460
04-23 13:36:28.931+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:36:28.971+0200 E/CAPI_APPFW_APPLICATION(15460): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.971+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:28:926,75
04-23 13:36:28.971+0200 E/CAPI_APPFW_APPLICATION(15460): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:36:28.971+0200 I/utils   (15460): specific action
04-23 13:36:28.971+0200 I/recorder(15460): obteniendo datos locales...
04-23 13:36:28.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15460
04-23 13:36:28.981+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(15460) type(svcapp) bg(0)
04-23 13:36:28.991+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15460) was created
04-23 13:36:29.001+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15460]
04-23 13:36:29.011+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15460)
04-23 13:36:29.011+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:36:29.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.021+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15460
04-23 13:36:29.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.081+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:36:29.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:36:29.111+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.111+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:119,75
04-23 13:36:29.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15447
04-23 13:36:29.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.171+0200 I/accelerometer(15447): es.ugr.frailty.accelerometer listener destroyed
04-23 13:36:29.191+0200 I/recorder(15460): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:36:29.191+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:36:29.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:36:29.201+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15460
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:36:29.201+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:36:29.211+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:36:29.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:36:29.231+0200 I/recorder(15460): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:36:29.331+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:36:29.351+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:36:29:339,75
04-23 13:36:29.361+0200 W/AUL     (15466): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:36:29.361+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:36:29.361+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15447
04-23 13:36:29.361+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:36:29.371+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15447
04-23 13:36:29.371+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15447)
04-23 13:36:29.371+0200 E/AUL     (15466): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:36:29.381+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1115460726563152448338
