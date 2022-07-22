S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6275
Date: 2018-04-23 14:33:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75ce648, r1   = 0xf79fc1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf79fc1b8, r5   = 0x00012cd0
r6   = 0xf7a0ee88, r7   = 0xf75ce250
r8   = 0x00000618, r9   = 0xf70b1824
r10  = 0xf79f49d8, fp   = 0x00000000
ip   = 0xf75cd030, sp   = 0xff999310
lr   = 0xf75115d0, pc   = 0xf750d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     64212 KB
Buffers:     38432 KB
Cached:     220808 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7712 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6c48000 f6c4b000 r-xp /lib/libattr.so.1.1.0
f6c54000 f6c5b000 r-xp /lib/libcrypt-2.13.so
f6c8b000 f6c8e000 r-xp /lib/libcap.so.2.21
f6c96000 f6c98000 r-xp /usr/lib/libiri.so
f6ca0000 f6cbd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cc6000 f6cca000 r-xp /usr/lib/libsmack.so.1.0.0
f6cd4000 f6cd6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cde000 f6ce3000 r-xp /usr/lib/libffi.so.5.0.10
f6ceb000 f6cec000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cf4000 f6cf6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cfe000 f6d00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d0a000 f6d1a000 r-xp /lib/libresolv-2.13.so
f6d1e000 f6d36000 r-xp /usr/lib/liblzma.so.5.0.3
f6d3e000 f6d40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d48000 f6d77000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d80000 f6d8f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d98000 f6da2000 r-xp /usr/lib/libsensord-shared.so
f6dab000 f6ddf000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6de8000 f6ebb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ec6000 f6edc000 r-xp /lib/libz.so.1.2.5
f6ee4000 f6eea000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ef3000 f6f68000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f72000 f6f8c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f94000 f6f9a000 r-xp /lib/librt-2.13.so
f6fa3000 f6fc1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fcb000 f6fcc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fd4000 f6fd9000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fe1000 f70b1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70b2000 f70dc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70e5000 f70fc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7104000 f716d000 r-xp /lib/libm-2.13.so
f7176000 f720a000 r-xp /usr/lib/libstdc++.so.6.0.16
f721d000 f7222000 r-xp /usr/lib/libctx-client.so.0.8.3
f722a000 f7231000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7239000 f7263000 r-xp /usr/lib/libsensor.so.1.9.6
f726c000 f7338000 r-xp /usr/lib/libxml2.so.2.7.8
f7345000 f7347000 r-xp /usr/lib/libiniparser.so.0
f7350000 f7353000 r-xp /usr/lib/libbundle.so.0.1.22
f735b000 f7361000 r-xp /usr/lib/libappsvc.so.0.1.0
f7369000 f738c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7394000 f73d5000 r-xp /usr/lib/libeina.so.1.7.99
f73de000 f73f5000 r-xp /usr/lib/libecore.so.1.7.99
f740c000 f7415000 r-xp /usr/lib/libvconf.so.0.2.45
f741d000 f7431000 r-xp /lib/libpthread-2.13.so
f743c000 f7449000 r-xp /usr/lib/libaul.so.0.1.0
f7453000 f7455000 r-xp /lib/libdl-2.13.so
f745e000 f7469000 r-xp /lib/libunwind.so.8.0.1
f7496000 f749e000 r-xp /lib/libgcc_s-4.6.so.1
f749f000 f75c3000 r-xp /lib/libc-2.13.so
f75d1000 f75d3000 r-xp /usr/lib/libdlog.so.0.0.0
f75db000 f75e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75f0000 f75f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75fd000 f7601000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f760a000 f760c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7615000 f7618000 r-xp /usr/lib/libappcore-agent.so.1.1
f7636000 f7653000 r-xp /lib/ld-2.13.so
f765c000 f765f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f765f000 f7663000 r-xp /usr/lib/libsys-assert.so
f79ea000 f7a38000 rw-p [heap]
ff97b000 ff99c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6275)
Call Stack Count: 1
 0: (0xf750d9fc) [/lib/libc.so.6] + 0x6e9fc
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
rc(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 14:33:35.431+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [711.092644] layer[0x5abcf0]zpos[0]
04-23 14:33:35.431+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [711.092680] layer(0x5ac310) not usable
04-23 14:33:35.431+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [711.092696] layer(0x5ac310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 14:33:35.431+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [711.092718] layer[0x5abf30]zpos[2]
04-23 14:33:35.441+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 14:33:35.441+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(fg) type(watchapp)
04-23 14:33:35.441+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppResume(560) > 
04-23 14:33:35.441+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:35.441+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(75), length(2)
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 75%
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 75, isCharging: 0
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_75
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 14:33:35.451+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 14:33:35.471+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-23 14:33:35.471+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 14:33:35.471+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 14:33:35.471+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 14:33:35.471+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:33:35.481+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:33:35.481+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:33:35.481+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 14:33:35.481+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 14:33:35.481+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:33:35.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 14:33:35.481+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 14:33:35.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -145282292[0;m
04-23 14:33:35.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 14:33:35.481+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 14:33:35.481+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 14:33:35.491+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 14:33:35.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 14:33:35.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 14:33:35.491+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 14:33:35.491+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 14:33:35.501+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 14:33:35.501+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 14:33:35.501+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 14:33:35.501+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 14:33:35.511+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 14:33:35.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:35.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:35.601+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 14:33:35.601+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 0
04-23 14:33:35.601+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 14:33:35.621+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 14:33:35.621+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 14:33:35.641+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 14:33:35.641+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 14:33:35.651+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:33:35.661+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 14:33:35.681+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 14:33:35.681+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 14:33:35.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:35.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:35.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:35.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:36.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:36.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:36.211+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_capacity_cb(413) > [_battery_capacity_cb:413] percentage 74
04-23 14:33:36.211+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 14:33:36.221+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(74), length(2)
04-23 14:33:36.221+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 74%
04-23 14:33:36.221+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 74, isCharging: 0
04-23 14:33:36.221+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_75
04-23 14:33:36.221+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 14:33:36.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:36.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:33:36.421+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.421+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 14:33:36.421+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [true][0m
04-23 14:33:36.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:36.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2775
04-23 14:33:36.451+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:33:36.451+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:33:36.451+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:33:36.451+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:33:36.451+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:33:36.451+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3238]   bundle_add_str() .. [0xffffffea][0m
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.451+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.461+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:33:36.461+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:33:36.461+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3238]   [MUSIC_PLAYER_EVENT][0m
04-23 14:33:36.461+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 14:33:36.461+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 14:33:36.461+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3238): preference.c: preference_get_int(1132) > preference_get_int(3238) : key(music-control-service_native/playing_diration) error
04-23 14:33:36.461+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3238]   preference_get_int() .. [0xfef00030][0m
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:33:36.461+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.461+0200 W/W_HOME  ( 2775): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 14:33:36.461+0200 E/W_HOME  ( 2775): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 14:33:36.471+0200 I/TIZEN_N_SOUND_MANAGER( 3238): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 14:33:36.471+0200 W/TIZEN_N_SOUND_MANAGER( 3238): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 14:33:36.471+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 14:33:36.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:36.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:36.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:36.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:36.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:36.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:37.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:37.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:37.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:37.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.981+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:33:37.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:37.981+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:37.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:37.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:37.991+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4443
04-23 14:33:38.001+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:33:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4443), cmd(0)
04-23 14:33:38.001+0200 I/utils   ( 4443): specific action
04-23 14:33:38.001+0200 I/httppostreq( 4443): internet connection check received
04-23 14:33:38.001+0200 I/httppostreq( 4443): internet connection != null
04-23 14:33:38.001+0200 I/CAPI_NETWORK_CONNECTION( 4443): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:33:38.001+0200 I/httppostreq( 4443): internet connection type...
04-23 14:33:38.001+0200 I/httppostreq( 4443): internet connection type 1
04-23 14:33:38.001+0200 I/httppostreq( 4443): internet available
04-23 14:33:38.001+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:33:38.001+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4443)
04-23 14:33:38.001+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.httppostreq
04-23 14:33:38.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:38.001+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4443
04-23 14:33:38.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4440
04-23 14:33:38.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:38.021+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 14:33:38.021+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(4440), cmd(0)
04-23 14:33:38.021+0200 W/AUL     ( 4443): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4440)
04-23 14:33:38.021+0200 I/httppostreq( 4443): request sent to service es.ugr.frailty.servicemanager
04-23 14:33:38.021+0200 I/utils   ( 4440): specific action
04-23 14:33:38.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:38.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:38.021+0200 W/CAPI_APPFW_APP_CONTROL( 4440): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:33:38.021+0200 I/servicemanager( 4440): internet connection available. stop all sensors
04-23 14:33:38.021+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:33:38.021+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:38.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:38.041+0200 E/RESOURCED( 2584): proc-main.c: proc_create_app_info(722) > prelaunched app was not gone to launch state, appid(es.ugr.frailty.recorder)
04-23 14:33:38.041+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6244
04-23 14:33:38.041+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:38.091+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6244
04-23 14:33:38.091+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(6244) type(svcapp) bg(0)
04-23 14:33:38.101+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6244]
04-23 14:33:38.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6244)
04-23 14:33:38.101+0200 I/servicemanager( 4440): es.ugr.frailty.accelerometer stop request sent!
04-23 14:33:38.101+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:38.101+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 14:33:38.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:38.121+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:38.131+0200 E/CAPI_APPFW_APPLICATION( 6244): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.131+0200 E/CAPI_APPFW_APPLICATION( 6244): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.131+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6247
04-23 14:33:38.131+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:38.151+0200 I/utils   ( 6244): trying to start service: es.ugr.frailty.accelerometer
04-23 14:33:38.151+0200 I/utils   ( 6244): es.ugr.frailty.accelerometer sensor supported
04-23 14:33:38.161+0200 I/utils   ( 6244): es.ugr.frailty.accelerometer listener started
04-23 14:33:38.161+0200 I/accelerometer( 6244): stopping es.ugr.frailty.accelerometer service
04-23 14:33:38.161+0200 E/CAPI_APPFW_APP_CONTROL( 6244): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.161+0200 E/accelerometer( 6244): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:38.161+0200 I/CAPI_APPFW_APPLICATION( 6244): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:38.181+0200 E/CAPI_APPFW_APPLICATION( 6247): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.181+0200 E/CAPI_APPFW_APPLICATION( 6247): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.181+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6247
04-23 14:33:38.181+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gyroscope) pid(6247) type(svcapp) bg(0)
04-23 14:33:38.181+0200 I/utils   ( 6247): trying to start service: es.ugr.frailty.gyroscope
04-23 14:33:38.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.191+0200 I/utils   ( 6247): es.ugr.frailty.gyroscope sensor supported
04-23 14:33:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6244
04-23 14:33:38.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6244) was created
04-23 14:33:38.201+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6247) was created
04-23 14:33:38.201+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.201+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.201+0200 I/utils   ( 6247): es.ugr.frailty.gyroscope listener started
04-23 14:33:38.201+0200 I/gyroscope( 6247): stopping es.ugr.frailty.gyroscope service
04-23 14:33:38.201+0200 E/CAPI_APPFW_APP_CONTROL( 6247): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.201+0200 E/gyroscope( 6247): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:38.201+0200 I/CAPI_APPFW_APPLICATION( 6247): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:38.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.211+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6247)
04-23 14:33:38.211+0200 I/servicemanager( 4440): es.ugr.frailty.gyroscope stop request sent!
04-23 14:33:38.211+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:38.211+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 14:33:38.211+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6247]
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6244
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:38.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:38.241+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6269
04-23 14:33:38.271+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:38.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6269
04-23 14:33:38.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(6269) type(svcapp) bg(0)
04-23 14:33:38.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.291+0200 E/CAPI_APPFW_APPLICATION( 6269): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.291+0200 E/CAPI_APPFW_APPLICATION( 6269): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.291+0200 I/utils   ( 6269): trying to start service: es.ugr.frailty.heartrate
04-23 14:33:38.301+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6247
04-23 14:33:38.301+0200 I/utils   ( 6269): es.ugr.frailty.heartrate sensor supported
04-23 14:33:38.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.301+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6269)
04-23 14:33:38.301+0200 I/servicemanager( 4440): es.ugr.frailty.heartrate stop request sent!
04-23 14:33:38.301+0200 I/servicemanager( 4440): App control destroyed.
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 0
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 1
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 2
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 3
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:573 _ecore_magic_fail() 
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** IN FUNCTION: ecore_timer_del()
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:33:38.301+0200 E/EFL     ( 4440): ecore<4440> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** SPANK SPANK SPANK!!!
04-23 14:33:38.301+0200 E/EFL     ( 4440): *** Now go fix your code. Tut tut tut!
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 4
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 5
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 6
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 7
04-23 14:33:38.301+0200 I/servicemanager( 4440): deleting dead timer 8
04-23 14:33:38.301+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:33:38.301+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6269) was created
04-23 14:33:38.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:33:38.301+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4440
04-23 14:33:38.311+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 6275
04-23 14:33:38.331+0200 I/utils   ( 6269): es.ugr.frailty.heartrate listener started
04-23 14:33:38.331+0200 I/heartrate( 6269): stopping es.ugr.frailty.heartrate service
04-23 14:33:38.331+0200 E/CAPI_APPFW_APP_CONTROL( 6269): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.331+0200 E/heartrate( 6269): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:33:38.331+0200 I/CAPI_APPFW_APPLICATION( 6269): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6275
04-23 14:33:38.361+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(6275) type(svcapp) bg(0)
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:33:38.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 14:33:38.381+0200 E/CAPI_APPFW_APPLICATION( 6275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.381+0200 E/CAPI_APPFW_APPLICATION( 6275): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:33:38.381+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (6275) was created
04-23 14:33:38.381+0200 W/AUL     ( 4440): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6275)
04-23 14:33:38.381+0200 I/servicemanager( 4440): request sent to service es.ugr.frailty.recorder
04-23 14:33:38.381+0200 I/utils   ( 6275): specific action
04-23 14:33:38.381+0200 I/recorder( 6275): obteniendo datos locales...
04-23 14:33:38.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.401+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6269]
04-23 14:33:38.401+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6275]
04-23 14:33:38.401+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 14:33:38.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6247
04-23 14:33:38.421+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6269
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.451+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.461+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6275
04-23 14:33:38.461+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.471+0200 I/recorder( 6275): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:20:782,9.291330,-4.800002,-0.624527
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:20:981,9.310472,-3.196811,0.177069
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:181,9.382257,-2.799603,0.849452
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:381,9.769895,-2.361716,0.256032
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:581,9.580862,-2.514857,0.248854
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:781,9.518648,-2.029114,0.521635
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:21:981,9.418150,-2.309074,0.442672
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:181,9.604790,-2.407180,0.669990
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:382,9.576077,-3.091527,0.650848
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:582,9.446864,-2.641676,1.004985
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:782,9.389436,-2.543570,1.016950
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:22:982,9.382257,-2.823531,1.186840
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:182,9.303294,-2.048256,1.579263
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:382,9.193225,-1.435694,1.581656
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:583,9.348758,0.210568,1.222732
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:783,9.734003,0.581456,0.954736
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:23:983,10.116854,1.165305,0.394816
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:183,9.753145,1.160519,0.973879
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:383,9.614362,0.660419,1.677369
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:583,9.841680,-0.545564,0.686740
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:783,9.772287,-2.065006,0.299103
04-23 14:33:38.471+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:24:984,9.674182,-1.440479,1.351945
04-23 14:33:38.481+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:184,9.738789,-1.672583,1.167697
04-23 14:33:38.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6269
04-23 14:33:38.481+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:384,9.724431,-1.878366,1.191626
04-23 14:33:38.481+0200 I/accelerometer( 6244): es.ugr.frailty.accelerometer listener destroyed
04-23 14:33:38.491+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:584,9.678967,-1.196411,1.301696
04-23 14:33:38.491+0200 I/recorder( 6275): SM-R760,23/04/2018,14:30:25:785,9.609575,0.043071,1.734797
04-23 14:33:38.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:33:38.521+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.521+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6275
04-23 14:33:38.531+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:33:38.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.551+0200 I/gyroscope( 6247): es.ugr.frailty.gyroscope listener destroyed
04-23 14:33:38.581+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 14:33:38.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 14:33:38.591+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:33:38.621+0200 W/AUL     ( 6289): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6244
04-23 14:33:38.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 14:33:38.621+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6244
04-23 14:33:38.621+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6244)
04-23 14:33:38.631+0200 I/heartrate( 6269): es.ugr.frailty.heartrate listener destroyed
04-23 14:33:38.651+0200 W/CRASH_MANAGER( 4854): worker.c: worker_job(1205) > 1106275726563152448681
