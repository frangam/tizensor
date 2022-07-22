S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 27531
Date: 2018-04-23 12:56:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75e4648, r1   = 0xf7cfd1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cfd1b8, r5   = 0x00012cd0
r6   = 0xf7d0fe88, r7   = 0xf75e4250
r8   = 0x000005c8, r9   = 0xf70c7824
r10  = 0xf7cf59d8, fp   = 0x00000000
ip   = 0xf75e3030, sp   = 0xff97f580
lr   = 0xf75275d0, pc   = 0xf75239fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      8916 KB
Buffers:     72304 KB
Cached:     185816 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7728 KB
VmRSS:        7724 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6c5e000 f6c61000 r-xp /lib/libattr.so.1.1.0
f6c6a000 f6c71000 r-xp /lib/libcrypt-2.13.so
f6ca1000 f6ca4000 r-xp /lib/libcap.so.2.21
f6cac000 f6cae000 r-xp /usr/lib/libiri.so
f6cb6000 f6cd3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cdc000 f6ce0000 r-xp /usr/lib/libsmack.so.1.0.0
f6cea000 f6cec000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cf4000 f6cf9000 r-xp /usr/lib/libffi.so.5.0.10
f6d01000 f6d02000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d0a000 f6d0c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d14000 f6d16000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d20000 f6d30000 r-xp /lib/libresolv-2.13.so
f6d34000 f6d4c000 r-xp /usr/lib/liblzma.so.5.0.3
f6d54000 f6d56000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d5e000 f6d8d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d96000 f6da5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6dae000 f6db8000 r-xp /usr/lib/libsensord-shared.so
f6dc1000 f6df5000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dfe000 f6ed1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6edc000 f6ef2000 r-xp /lib/libz.so.1.2.5
f6efa000 f6f00000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f09000 f6f7e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f88000 f6fa2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6faa000 f6fb0000 r-xp /lib/librt-2.13.so
f6fb9000 f6fd7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fe1000 f6fe2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fea000 f6fef000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ff7000 f70c7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70c8000 f70f2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70fb000 f7112000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f711a000 f7183000 r-xp /lib/libm-2.13.so
f718c000 f7220000 r-xp /usr/lib/libstdc++.so.6.0.16
f7233000 f7238000 r-xp /usr/lib/libctx-client.so.0.8.3
f7240000 f7247000 r-xp /usr/lib/libctx-shared.so.0.8.3
f724f000 f7279000 r-xp /usr/lib/libsensor.so.1.9.6
f7282000 f734e000 r-xp /usr/lib/libxml2.so.2.7.8
f735b000 f735d000 r-xp /usr/lib/libiniparser.so.0
f7366000 f7369000 r-xp /usr/lib/libbundle.so.0.1.22
f7371000 f7377000 r-xp /usr/lib/libappsvc.so.0.1.0
f737f000 f73a2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f73aa000 f73eb000 r-xp /usr/lib/libeina.so.1.7.99
f73f4000 f740b000 r-xp /usr/lib/libecore.so.1.7.99
f7422000 f742b000 r-xp /usr/lib/libvconf.so.0.2.45
f7433000 f7447000 r-xp /lib/libpthread-2.13.so
f7452000 f745f000 r-xp /usr/lib/libaul.so.0.1.0
f7469000 f746b000 r-xp /lib/libdl-2.13.so
f7474000 f747f000 r-xp /lib/libunwind.so.8.0.1
f74ac000 f74b4000 r-xp /lib/libgcc_s-4.6.so.1
f74b5000 f75d9000 r-xp /lib/libc-2.13.so
f75e7000 f75e9000 r-xp /usr/lib/libdlog.so.0.0.0
f75f1000 f75fd000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7606000 f760b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7613000 f7617000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7620000 f7622000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f762b000 f762e000 r-xp /usr/lib/libappcore-agent.so.1.1
f764c000 f7669000 r-xp /lib/ld-2.13.so
f7672000 f7675000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7675000 f7679000 r-xp /usr/lib/libsys-assert.so
f7ceb000 f7d39000 rw-p [heap]
ff961000 ff982000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27531)
Call Stack Count: 1
 0: (0xf75239fc) [/lib/libc.so.6] + 0x6e9fc
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
DICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 12:56:58.391+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 12:56:58.391+0200 I/APP_CORE( 2699): appcore-efl.c: __do_app(453) > [APP 2699] Event: PAUSE State: RUNNING
04-23 12:56:58.391+0200 I/CAPI_APPFW_APPLICATION( 2699): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 12:56:58.391+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 12:56:58.391+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 12:56:58.391+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 12:56:58.411+0200 E/EFL     ( 2319): ecore_x<2319> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1a0000d time=17892740
04-23 12:56:58.411+0200 E/EFL     ( 2699): ecore_x<2699> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=17892740
04-23 12:56:58.411+0200 E/EFL     ( 2319): ecore_x<2319> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=17892740
04-23 12:56:58.471+0200 W/W_INDICATOR( 2699): windicator_moment_view.c: windicator_moment_view_battery_disp_timer_cb(737) > [windicator_moment_view_battery_disp_timer_cb:737] [CHARGING_UI] windicator_moment_view_battery_disp_timer_cb
04-23 12:56:58.651+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -143330896[0;m
04-23 12:56:58.651+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-23 12:56:58.651+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 12:56:58.651+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-23 12:56:58.651+0200 I/WATCH_CORE( 2872): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 12:56:58.651+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.651+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:58.651+0200 I/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 12:56:58.661+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [17893.772116] dpms[3 -> 0]sync[0]
04-23 12:56:58.661+0200 I/TDM     ( 1945): 
04-23 12:56:58.661+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [17893.772427] dpms[0 -> 0]done
04-23 12:56:58.661+0200 I/TDM     ( 1945): 
04-23 12:56:58.661+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 12:56:58.661+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-23 12:56:58.661+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 12:56:58.661+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 12:56:58.671+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 12:56:58.671+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 12:56:58.671+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 12:56:58.671+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): gesture.c: _apps_status_get(128) > apps status:0
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:1 info->offtime:541
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 12:56:58.681+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-23 12:56:58.681+0200 I/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.681+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.681+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:58.681+0200 I/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 12:56:58.681+0200 I/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-23 12:56:58.681+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [541]ms
04-23 12:56:58.681+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-23 12:56:58.681+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: RESUME State: PAUSED
04-23 12:56:58.681+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): main.c: _appcore_resume_cb(479) > appcore resume
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): main.c: home_resume(531) > clock/widget resumed
04-23 12:56:58.681+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.691+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2693].
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2135096672)
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-23 12:56:58.691+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-23 12:56:58.701+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 12:56:58.701+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(fg) type(watchapp)
04-23 12:56:58.701+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppResume(560) > 
04-23 12:56:58.701+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.701+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:58.701+0200 W/W_HOME  ( 2759): gesture.c: _widget_updated_cb(188) > widget updated
04-23 12:56:58.701+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 12:56:58.701+0200 W/W_HOME  ( 2759): gesture.c: _manual_render(182) > 
04-23 12:56:58.711+0200 W/W_HOME  ( 2759): gesture.c: _manual_render(182) > 
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [17893.830908] layer(0x47f2c0) not usable
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [17893.830941] layer(0x47f2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17893.830959] layer[0x47ee10]zpos[1]
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [17893.831017] layer(0x47f310) not usable
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [17893.831029] layer(0x47f310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 12:56:58.721+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17893.831043] layer[0x47ef30]zpos[2]
04-23 12:56:58.721+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 0
04-23 12:56:58.751+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 12:56:58.761+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 12:56:58.761+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 12:56:58.771+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -149443828[0;m
04-23 12:56:58.771+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 12:56:58.771+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 12:56:58.771+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 12:56:58.771+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 12:56:58.771+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 12:56:58.791+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 12:56:58.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:58.801+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 12:56:58.801+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 12:56:58.801+0200 I/APP_CORE( 2699): appcore-efl.c: __do_app(453) > [APP 2699] Event: RESUME State: PAUSED
04-23 12:56:58.801+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 12:56:58.801+0200 I/CAPI_APPFW_APPLICATION( 2699): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-23 12:56:58.811+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 12:56:58.811+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 12:56:58.811+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 12:56:58.811+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 12:56:58.811+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 12:56:58.821+0200 W/W_INDICATOR( 2699): windicator_moment_view.c: _charging_ui_fade_out_end_cb(246) > [_charging_ui_fade_out_end_cb:246] Fade out end. Call moment_view_hide
04-23 12:56:58.821+0200 E/W_INDICATOR( 2699): windicator_moment_view.c: windicator_moment_view_hide(1050) > [windicator_moment_view_hide:1050] Hide Moment View , Type(1)
04-23 12:56:58.821+0200 W/PROCESSMGR( 2319): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-23 12:56:58.821+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-23 12:56:58.821+0200 I/WATCH_CORE( 2872): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-23 12:56:58.821+0200 W/W_HOME  ( 2759): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-23 12:56:58.821+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.821+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.821+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.821+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:58.821+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 12:56:58.821+0200 W/W_HOME  ( 2759): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-23 12:56:58.831+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1442) > [17893.947255] layer(0x47f250) not usable
04-23 12:56:58.831+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_set_info(1459) > [17893.947273] layer(0x47f250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 12:56:58.831+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_set_info(1578) > [17893.947289] layer[0x47ecf0]zpos[0]
04-23 12:56:58.851+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 12:56:58.851+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 12:56:58.851+0200 W/W_INDICATOR( 2699): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 12:56:58.861+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(92), length(2)
04-23 12:56:58.861+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 92%
04-23 12:56:58.861+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 92, isCharging: 0
04-23 12:56:58.861+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_95
04-23 12:56:58.861+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 12:56:58.861+0200 I/APP_CORE( 2699): appcore-efl.c: __do_app(453) > [APP 2699] Event: PAUSE State: RUNNING
04-23 12:56:58.861+0200 I/CAPI_APPFW_APPLICATION( 2699): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 12:56:58.881+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 12:56:58.881+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 12:56:58.921+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 12:56:58.921+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 12:56:58.921+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 12:56:58.921+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 12:56:58.941+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 12:56:58.941+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 12:56:58.941+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 14:25:03 (UTC).
04-23 12:56:58.941+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 12:56:58.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:58.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:59.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:59.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:59.201+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 12:56:59.201+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[2135096672] is removed.
04-23 12:56:59.211+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 12:56:59.211+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 12:56:59.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:56:59.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:59.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:56:59.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:59.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:56:59.381+0200 I/utils   (25866): specific action
04-23 12:56:59.381+0200 I/httppostreq(25866): internet connection check received
04-23 12:56:59.381+0200 I/httppostreq(25866): internet connection != null
04-23 12:56:59.381+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:56:59.381+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:56:59.381+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:56:59.381+0200 I/httppostreq(25866): internet connection type...
04-23 12:56:59.381+0200 I/httppostreq(25866): internet connection type 1
04-23 12:56:59.381+0200 I/httppostreq(25866): internet available
04-23 12:56:59.381+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:56:59.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:56:59.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:56:59.401+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:59.401+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:59.401+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:56:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:56:59.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:59.401+0200 I/utils   (25863): specific action
04-23 12:56:59.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:59.401+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:56:59.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:56:59.401+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:56:59.401+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:56:59.401+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:56:59.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:59.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:59.421+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27524
04-23 12:56:59.421+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:59.461+0200 E/CAPI_APPFW_APPLICATION(27524): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:59.461+0200 E/CAPI_APPFW_APPLICATION(27524): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:59.471+0200 I/utils   (27524): trying to start service: es.ugr.frailty.accelerometer
04-23 12:56:59.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27524
04-23 12:56:59.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(27524) type(svcapp) bg(0)
04-23 12:56:59.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27524) was created
04-23 12:56:59.471+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27524]
04-23 12:56:59.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27524)
04-23 12:56:59.471+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:56:59.471+0200 I/servicemanager(25863): App control destroyed.
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 0
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 1
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 2
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 3
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 4
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:56:59.471+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:56:59.471+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:56:59.471+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:56:59.471+0200 E/servicemanager(25863): deleting timer 5
04-23 12:56:59.471+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:56:59.501+0200 I/utils   (27524): es.ugr.frailty.accelerometer sensor supported
04-23 12:56:59.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:56:59.501+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:56:59.511+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 27531
04-23 12:56:59.511+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:56:59.551+0200 E/CAPI_APPFW_APPLICATION(27531): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:59.551+0200 E/CAPI_APPFW_APPLICATION(27531): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:56:59.561+0200 I/utils   (27531): specific action
04-23 12:56:59.561+0200 I/recorder(27531): obteniendo datos locales...
04-23 12:56:59.561+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 27531
04-23 12:56:59.561+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(27531) type(svcapp) bg(0)
04-23 12:56:59.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:59.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [27531]
04-23 12:56:59.581+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(27531)
04-23 12:56:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27524
04-23 12:56:59.581+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (27531) was created
04-23 12:56:59.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:59.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 12:56:59.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 12:56:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27524
04-23 12:56:59.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:59.591+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:56:59.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:59.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 27531
04-23 12:56:59.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:56:59.651+0200 I/recorder(27531): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:56:59.651+0200 I/recorder(27531): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 12:56:59.681+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.691+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 12:56:59.691+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [true][0m
04-23 12:56:59.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:56:59.701+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2759
04-23 12:56:59.701+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3670]   [MUSIC_PLAYER_EVENT][0m
04-23 12:56:59.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 12:56:59.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 12:56:59.701+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: preference_get_int(1132) > preference_get_int(3670) : key(music-control-service_native/playing_diration) error
04-23 12:56:59.701+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3670]   preference_get_int() .. [0xfef00030][0m
04-23 12:56:59.701+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3670]   bundle_add_str() .. [0xffffffea][0m
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.701+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.711+0200 W/W_HOME  ( 2759): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 12:56:59.711+0200 E/W_HOME  ( 2759): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 12:56:59.711+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3670]   [MUSIC_PLAYER_EVENT][0m
04-23 12:56:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 12:56:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 12:56:59.711+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3670): preference.c: preference_get_int(1132) > preference_get_int(3670) : key(music-control-service_native/playing_diration) error
04-23 12:56:59.711+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3670]   preference_get_int() .. [0xfef00030][0m
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 12:56:59.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.711+0200 W/W_HOME  ( 2759): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 12:56:59.711+0200 E/W_HOME  ( 2759): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 12:56:59.721+0200 I/TIZEN_N_SOUND_MANAGER( 3670): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 12:56:59.721+0200 W/TIZEN_N_SOUND_MANAGER( 3670): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 12:56:59.721+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 12:56:59.751+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1127531726563152448101
