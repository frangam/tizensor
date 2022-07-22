S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 10982
Date: 2018-04-12 19:26:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xf4

Register Information
r0   = 0x000000f7, r1   = 0x000000f4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xfff69118
r6   = 0xf737a6da, r7   = 0x000000f7
r8   = 0x0000001e, r9   = 0x00000000
r10  = 0xf737a6bc, fp   = 0xfff6910c
ip   = 0xfff69650, sp   = 0xfff68ba0
lr   = 0xf7214e8c, pc   = 0xf724a0b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     50232 KB
Buffers:     52756 KB
Cached:     224592 KB
VmPeak:      45264 KB
VmSize:      45012 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7264 KB
VmRSS:        7264 KB
VmData:      35184 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 10982 TID = 10982
10982 10991 10992 10993 10994 

Maps Information
f4986000 f5185000 rw-p [stack:10994]
f5186000 f5985000 rw-p [stack:10993]
f5986000 f6185000 rw-p [stack:10992]
f6186000 f6989000 rw-p [stack:10991]
f6989000 f698c000 r-xp /lib/libattr.so.1.1.0
f6994000 f699b000 r-xp /lib/libcrypt-2.13.so
f69cc000 f69cf000 r-xp /lib/libcap.so.2.21
f69d7000 f69d9000 r-xp /usr/lib/libiri.so
f69e1000 f69e3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69eb000 f69ed000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69f6000 f6ac2000 r-xp /usr/lib/libxml2.so.2.7.8
f6ad0000 f6aed000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6af6000 f6afa000 r-xp /usr/lib/libsmack.so.1.0.0
f6b03000 f6b19000 r-xp /lib/libz.so.1.2.5
f6b21000 f6b23000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b2b000 f6b30000 r-xp /usr/lib/libffi.so.5.0.10
f6b38000 f6b39000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b41000 f6b51000 r-xp /lib/libresolv-2.13.so
f6b55000 f6b6d000 r-xp /usr/lib/liblzma.so.5.0.3
f6b75000 f6b77000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b7f000 f6b99000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ba1000 f6bd0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bd9000 f6be8000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bf1000 f6bfb000 r-xp /usr/lib/libsensord-shared.so
f6c04000 f6c38000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c41000 f6d14000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d1f000 f6d25000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d2e000 f6da3000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dad000 f6db3000 r-xp /lib/librt-2.13.so
f6dbc000 f6dda000 r-xp /usr/lib/libsystemd.so.0.4.0
f6de4000 f6de5000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ded000 f6e10000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e18000 f6e1d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e25000 f6ef5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ef6000 f6f20000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f29000 f6f40000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f48000 f6fb1000 r-xp /lib/libm-2.13.so
f6fba000 f704e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7061000 f7066000 r-xp /usr/lib/libctx-client.so.0.8.3
f706e000 f7075000 r-xp /usr/lib/libctx-shared.so.0.8.3
f707d000 f70a7000 r-xp /usr/lib/libsensor.so.1.9.6
f70b0000 f70b3000 r-xp /usr/lib/libbundle.so.0.1.22
f70bb000 f70c1000 r-xp /usr/lib/libappsvc.so.0.1.0
f70c9000 f710a000 r-xp /usr/lib/libeina.so.1.7.99
f7113000 f712a000 r-xp /usr/lib/libecore.so.1.7.99
f7141000 f714a000 r-xp /usr/lib/libvconf.so.0.2.45
f7152000 f7166000 r-xp /lib/libpthread-2.13.so
f7171000 f717e000 r-xp /usr/lib/libaul.so.0.1.0
f7188000 f718a000 r-xp /lib/libdl-2.13.so
f7193000 f719e000 r-xp /lib/libunwind.so.8.0.1
f71cb000 f71d3000 r-xp /lib/libgcc_s-4.6.so.1
f71d4000 f72f8000 r-xp /lib/libc-2.13.so
f7306000 f7308000 r-xp /usr/lib/libdlog.so.0.0.0
f7310000 f731c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7325000 f7329000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7332000 f7335000 r-xp /usr/lib/libappcore-agent.so.1.1
f7353000 f7370000 r-xp /lib/ld-2.13.so
f7379000 f737b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f737b000 f737f000 r-xp /usr/lib/libsys-assert.so
f7a0b000 f7a4d000 rw-p [heap]
fff4a000 fff6b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10982)
Call Stack Count: 1
 0: strlen + 0x4 (0xf724a0b4) [/lib/libc.so.6] + 0x760b4
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
 > [13668.689860] dpms[0 -> 0]done
04-12 19:26:43.419+0200 I/TDM     ( 1957): 
04-12 19:26:43.459+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-12 19:26:43.459+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-12 19:26:43.459+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:43.459+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:43.459+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:26:43.459+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): gesture.c: _apps_status_get(128) > apps status:0
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:0 info->offtime:41874
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-12 19:26:43.469+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:43.469+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [41874]ms
04-12 19:26:43.469+0200 W/STARTER ( 2661): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-12 19:26:43.479+0200 I/APP_CORE(10929): appcore-efl.c: __do_app(453) > [APP 10929] Event: RESUME State: RUNNING
04-12 19:26:43.499+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151049460[0;m
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [13668.773458] layer(0x21e2c0) not usable
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [13668.773526] layer(0x21e2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [13668.773558] layer[0x21de10]zpos[1]
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [13668.773647] layer(0x21e310) not usable
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [13668.773669] layer(0x21e310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:26:43.509+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [13668.773695] layer[0x21df30]zpos[2]
04-12 19:26:43.519+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-12 19:26:43.519+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-12 19:26:43.519+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-12 19:26:43.519+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-12 19:26:43.519+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-12 19:26:43.519+0200 W/W_HOME  ( 2742): gesture.c: _widget_updated_cb(188) > widget updated
04-12 19:26:43.519+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-12 19:26:43.519+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 19:26:43.529+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-12 19:26:43.529+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-12 19:26:43.529+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-12 19:26:43.529+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-12 19:26:43.529+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-12 19:26:43.539+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-12 19:26:43.539+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-12 19:26:43.539+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-12 19:26:43.539+0200 I/HIGEAR  ( 3240): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-12 19:26:43.559+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 19:26:43.589+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_enable(138) > 0
04-12 19:26:43.609+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 19:26:43.689+0200 I/watchface-viewer( 2828): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-12 19:26:43.689+0200 W/SHealthCommon( 2887): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 19:26:43.699+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-12 19:26:43.699+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-12 19:26:43.729+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:26:43.729+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 19:26:43.739+0200 W/SHealthCommon( 3180): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 19:26:43.739+0200 W/SHealthService( 3180): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-12 19:26:43.739+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 19:26:43.759+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 19:26:43.759+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 19:26:43.769+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 19:26:44.059+0200 E/EFL     (10929): ecore_x<10929> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=13669325 button=1
04-12 19:26:44.059+0200 E/EFL     (10929): elementary<10929> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7c0efb0 : elm_list] mouse move
04-12 19:26:44.059+0200 E/EFL     (10929): elementary<10929> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7c0efb0 : elm_list] mouse move
04-12 19:26:44.059+0200 E/EFL     (10929): elementary<10929> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7c0efb0 : elm_list] hold(0), freeze(0)
04-12 19:26:44.159+0200 E/EFL     (10929): elementary<10929> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7c0efb0 : elm_list] mouse move
04-12 19:26:44.159+0200 E/EFL     (10929): elementary<10929> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7c0efb0 : elm_list] hold(0), freeze(0)
04-12 19:26:44.169+0200 E/EFL     (10929): ecore_x<10929> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=13669434 button=1
04-12 19:26:44.169+0200 W/AUL     (10929): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:26:44.169+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:26:44.169+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10929
04-12 19:26:44.189+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:26:44.189+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10971
04-12 19:26:44.219+0200 E/CAPI_APPFW_APPLICATION(10971): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.219+0200 E/CAPI_APPFW_APPLICATION(10971): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.219+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:26:44.239+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10971
04-12 19:26:44.239+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(10971) type(svcapp) bg(0)
04-12 19:26:44.249+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:26:44.249+0200 W/AUL     (10929): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10971)
04-12 19:26:44.249+0200 I/utils   (10929): es.ugr.frailty.servicemanager launch request sent!
04-12 19:26:44.249+0200 I/utils   (10929): App control destroyed.
04-12 19:26:44.249+0200 I/CAPI_APPFW_APPLICATION(10929): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 19:26:44.249+0200 I/CAPI_APPFW_APPLICATION(10929): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 19:26:44.259+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10971]
04-12 19:26:44.259+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10971
04-12 19:26:44.269+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10974
04-12 19:26:44.279+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:26:44.319+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10974
04-12 19:26:44.319+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(10974) type(svcapp) bg(0)
04-12 19:26:44.329+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10971) was created
04-12 19:26:44.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.339+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10974]
04-12 19:26:44.339+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10971
04-12 19:26:44.339+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.349+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10974)
04-12 19:26:44.349+0200 I/servicemanager(10971): es.ugr.frailty.httppostreq launch request sent!
04-12 19:26:44.349+0200 I/servicemanager(10971): App control destroyed.
04-12 19:26:44.349+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:26:44.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:26:44.359+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10971
04-12 19:26:44.369+0200 E/CAPI_APPFW_APPLICATION(10974): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.369+0200 E/CAPI_APPFW_APPLICATION(10974): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.379+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10976
04-12 19:26:44.379+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:26:44.399+0200 E/CAPI_APPFW_APPLICATION(10976): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.399+0200 E/CAPI_APPFW_APPLICATION(10976): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:44.399+0200 W/CAPI_APPFW_APP_CONTROL(10976): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.399+0200 W/CAPI_APPFW_APP_CONTROL(10976): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.429+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10976
04-12 19:26:44.429+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(10976) type(svcapp) bg(0)
04-12 19:26:44.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.439+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10976)
04-12 19:26:44.439+0200 I/servicemanager(10971): es.ugr.frailty.recorder launch request sent!
04-12 19:26:44.439+0200 I/servicemanager(10971): App control destroyed.
04-12 19:26:44.439+0200 I/servicemanager(10971): Frailty Service Manager created
04-12 19:26:44.439+0200 W/CAPI_APPFW_APP_CONTROL(10971): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.439+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10974
04-12 19:26:44.439+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10974) was created
04-12 19:26:44.439+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10976) was created
04-12 19:26:44.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10971
04-12 19:26:44.449+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.469+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10976]
04-12 19:26:44.479+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.489+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10976
04-12 19:26:44.489+0200 W/CAPI_APPFW_APP_CONTROL(10971): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.489+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.509+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.519+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10974
04-12 19:26:44.519+0200 I/CAPI_NETWORK_CONNECTION(10974): connection.c: connection_create(453) > New handle created[0xf7a18be0]
04-12 19:26:44.519+0200 W/CAPI_APPFW_APP_CONTROL(10974): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.519+0200 W/CAPI_APPFW_APP_CONTROL(10974): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:44.519+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.539+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:44.539+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10976
04-12 19:26:44.539+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:44.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:26:44.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:26:44.569+0200 W/APP_CORE(10929): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 19:26:44.569+0200 W/APP_CORE(10929): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[604922] for es.ugr.frailty.frailtylauncher[10929]
04-12 19:26:44.609+0200 I/APP_CORE(10929): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 19:26:44.609+0200 I/APP_CORE(10929): appcore-efl.c: __after_loop(1234) > [APP 10929] PAUSE before termination
04-12 19:26:44.609+0200 I/CAPI_APPFW_APPLICATION(10929): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 19:26:44.609+0200 I/CAPI_APPFW_APPLICATION(10929): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 19:26:44.609+0200 I/APP_CORE(10929): appcore-efl.c: __after_loop(1243) > [APP 10929] After terminate() callback
04-12 19:26:44.609+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:26:44.609+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:26:44.609+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:44.609+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:44.609+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:26:44.619+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 19:26:44.619+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 19:26:44.619+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 19:26:44.619+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 19:26:44.619+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 19:26:44.659+0200 I/UXT     (10929): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 19:26:44.679+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 19:26:44.679+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 19:26:44.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.679+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 19:26:44.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.679+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 19:26:44.679+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:44.679+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:44.679+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 19:26:44.679+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.679+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 19:26:44.679+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 19:26:44.679+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 19:26:44.709+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 19:26:44.709+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 19:26:44.709+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 19:26:44.709+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 19:26:44.709+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 19:26:44.709+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 19:26:44.709+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 19:26:44.709+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 19:26:44.709+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 19:26:44.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(27), length(2)
04-12 19:26:44.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 27%
04-12 19:26:44.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 27, isCharging: 0
04-12 19:26:44.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_30
04-12 19:26:44.719+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 19:26:44.719+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 19:26:44.719+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 19:26:44.719+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 19:26:44.729+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:44.729+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:44.769+0200 I/efl-extension(10929): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 19:26:44.779+0200 W/AUL_PAD (10929): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 19:26:44.789+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 10929 pgid = 10929
04-12 19:26:44.789+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 19:26:44.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:44.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:44.849+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 19:26:44.849+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10929
04-12 19:26:44.849+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10929)
04-12 19:26:44.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:44.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:45.149+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [13670.418279] layer(0x21e250) not usable
04-12 19:26:45.149+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [13670.418330] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 19:26:45.149+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [13670.418361] layer[0x21dcf0]zpos[0]
04-12 19:26:45.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:45.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:45.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:45.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:45.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:45.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:26:45.709+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.709+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 19:26:45.709+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 19:26:45.709+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:45.729+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 19:26:45.739+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:26:45.739+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:26:45.739+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:26:45.739+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:26:45.739+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:26:45.739+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:26:45.749+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.749+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:26:45.749+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:26:45.749+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 19:26:45.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 19:26:45.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 19:26:45.759+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 19:26:45.759+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.759+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 19:26:45.759+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 19:26:45.759+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 19:26:45.759+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.759+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 19:26:45.769+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 19:26:45.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:45.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:45.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:45.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:46.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:46.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:46.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:46.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:46.569+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 19:26:46.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:46.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:46.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:46.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:46.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:46.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:47.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:47.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:47.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:47.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:47.439+0200 I/servicemanager(10971): accelerometer alive timeout
04-12 19:26:47.439+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:26:47.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:26:47.439+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 10971
04-12 19:26:47.459+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 10982
04-12 19:26:47.459+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 19:26:47.519+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10982
04-12 19:26:47.519+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(10982) type(svcapp) bg(0)
04-12 19:26:47.519+0200 W/AUL     (10971): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10982)
04-12 19:26:47.519+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10982]
04-12 19:26:47.519+0200 I/servicemanager(10971): es.ugr.frailty.accelerometer launch request sent!
04-12 19:26:47.519+0200 I/servicemanager(10971): App control destroyed.
04-12 19:26:47.539+0200 E/CAPI_APPFW_APPLICATION(10982): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:47.539+0200 E/CAPI_APPFW_APPLICATION(10982): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 19:26:47.539+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (10982) was created
04-12 19:26:47.539+0200 I/accelerometer(10982): Starting es.ugr.frailty.accelerometer service
04-12 19:26:47.559+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:47.559+0200 I/accelerometer(10982): sensor supported
04-12 19:26:47.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10982
04-12 19:26:47.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 19:26:47.589+0200 I/accelerometer(10982): es.ugr.frailty.accelerometer listener started
04-12 19:26:47.589+0200 W/CAPI_APPFW_APP_CONTROL(10982): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:26:47.589+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10982
04-12 19:26:47.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:47.589+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 19:26:47.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:47.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:47.629+0200 I/utils   (10982): accelerometer utils fecha ,øƒ¢÷6:47
04-12 19:26:47.759+0200 W/AUL     (10997): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:26:47.759+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:26:47.759+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:26:47.759+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10982
04-12 19:26:47.759+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:26:47.759+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10982
04-12 19:26:47.759+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10982)
04-12 19:26:47.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 19:26:47.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 19:26:47.849+0200 W/CRASH_MANAGER(10998): worker.c: worker_job(1205) > 1110982616363152355400
