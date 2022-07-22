S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 7886
Date: 2018-04-12 18:49:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x69baaa00
r4   = 0xf77a9e89, r5   = 0xf74de7fc
r6   = 0x00000000, r7   = 0xffd6ed88
r8   = 0x00000041, r9   = 0xf7325824
r10  = 0xf7fb1f00, fp   = 0x00000000
ip   = 0xf767a0b0, sp   = 0xffd6ead8
lr   = 0xf77a9f79, pc   = 0xf767a0b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     63236 KB
Buffers:     45664 KB
Cached:     220960 KB
VmPeak:      45264 KB
VmSize:      45008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7252 KB
VmRSS:        7252 KB
VmData:      35180 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7886 TID = 7886
7886 7895 7896 7897 7898 

Maps Information
f4db6000 f55b5000 rw-p [stack:7898]
f55b6000 f5db5000 rw-p [stack:7897]
f5db6000 f65b5000 rw-p [stack:7896]
f65b6000 f6db9000 rw-p [stack:7895]
f6db9000 f6dbc000 r-xp /lib/libattr.so.1.1.0
f6dc4000 f6dcb000 r-xp /lib/libcrypt-2.13.so
f6dfc000 f6dff000 r-xp /lib/libcap.so.2.21
f6e07000 f6e09000 r-xp /usr/lib/libiri.so
f6e11000 f6e13000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e1b000 f6e1d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e26000 f6ef2000 r-xp /usr/lib/libxml2.so.2.7.8
f6f00000 f6f1d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6f26000 f6f2a000 r-xp /usr/lib/libsmack.so.1.0.0
f6f33000 f6f49000 r-xp /lib/libz.so.1.2.5
f6f51000 f6f53000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f5b000 f6f60000 r-xp /usr/lib/libffi.so.5.0.10
f6f68000 f6f69000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f71000 f6f81000 r-xp /lib/libresolv-2.13.so
f6f85000 f6f9d000 r-xp /usr/lib/liblzma.so.5.0.3
f6fa5000 f6fa7000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6faf000 f6fc9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6fd1000 f7000000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f7009000 f7018000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f7021000 f702b000 r-xp /usr/lib/libsensord-shared.so
f7034000 f7068000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7071000 f7144000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f714f000 f7155000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f715e000 f71d3000 r-xp /usr/lib/libsqlite3.so.0.8.6
f71dd000 f71e3000 r-xp /lib/librt-2.13.so
f71ec000 f720a000 r-xp /usr/lib/libsystemd.so.0.4.0
f7214000 f7215000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f721d000 f7240000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7248000 f724d000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7255000 f7325000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7326000 f7350000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7359000 f7370000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7378000 f73e1000 r-xp /lib/libm-2.13.so
f73ea000 f747e000 r-xp /usr/lib/libstdc++.so.6.0.16
f7491000 f7496000 r-xp /usr/lib/libctx-client.so.0.8.3
f749e000 f74a5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f74ad000 f74d7000 r-xp /usr/lib/libsensor.so.1.9.6
f74e0000 f74e3000 r-xp /usr/lib/libbundle.so.0.1.22
f74eb000 f74f1000 r-xp /usr/lib/libappsvc.so.0.1.0
f74f9000 f753a000 r-xp /usr/lib/libeina.so.1.7.99
f7543000 f755a000 r-xp /usr/lib/libecore.so.1.7.99
f7571000 f757a000 r-xp /usr/lib/libvconf.so.0.2.45
f7582000 f7596000 r-xp /lib/libpthread-2.13.so
f75a1000 f75ae000 r-xp /usr/lib/libaul.so.0.1.0
f75b8000 f75ba000 r-xp /lib/libdl-2.13.so
f75c3000 f75ce000 r-xp /lib/libunwind.so.8.0.1
f75fb000 f7603000 r-xp /lib/libgcc_s-4.6.so.1
f7604000 f7728000 r-xp /lib/libc-2.13.so
f7736000 f7738000 r-xp /usr/lib/libdlog.so.0.0.0
f7740000 f774c000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7755000 f7759000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7762000 f7765000 r-xp /usr/lib/libappcore-agent.so.1.1
f7783000 f77a0000 r-xp /lib/ld-2.13.so
f77a9000 f77ab000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f77ab000 f77af000 r-xp /usr/lib/libsys-assert.so
f7fa7000 f7fe8000 rw-p [heap]
ffd4f000 ffd70000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7886)
Call Stack Count: 1
 0: strlen + 0x4 (0xf767a0b4) [/lib/libc.so.6] + 0x760b4
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
[powerkey] after screen off time [102437]ms
04-12 18:49:42.179+0200 W/STARTER ( 2661): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-12 18:49:42.189+0200 I/APP_CORE( 7832): appcore-efl.c: __do_app(453) > [APP 7832] Event: RESUME State: RUNNING
04-12 18:49:42.199+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151049460[0;m
04-12 18:49:42.199+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-12 18:49:42.199+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-12 18:49:42.199+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-12 18:49:42.209+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-12 18:49:42.209+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-12 18:49:42.219+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-12 18:49:42.219+0200 W/W_HOME  ( 2742): gesture.c: _widget_updated_cb(188) > widget updated
04-12 18:49:42.219+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-12 18:49:42.219+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 18:49:42.219+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-12 18:49:42.219+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-12 18:49:42.219+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-12 18:49:42.219+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-12 18:49:42.229+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-12 18:49:42.229+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-12 18:49:42.229+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-12 18:49:42.229+0200 I/HIGEAR  ( 3240): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [11447.496822] layer(0x21e2c0) not usable
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [11447.496859] layer(0x21e2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [11447.496881] layer[0x21de10]zpos[1]
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [11447.496939] layer(0x21e310) not usable
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [11447.496954] layer(0x21e310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:49:42.229+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [11447.496974] layer[0x21df30]zpos[2]
04-12 18:49:42.249+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 18:49:42.289+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_enable(138) > 0
04-12 18:49:42.309+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-12 18:49:42.409+0200 I/watchface-viewer( 2828): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-12 18:49:42.419+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-12 18:49:42.419+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-12 18:49:42.419+0200 W/SHealthCommon( 2887): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 18:49:42.459+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:49:42.459+0200 W/SHealthService( 3180): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-12 18:49:42.469+0200 W/SHealthCommon( 3180): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 18:49:42.469+0200 W/SHealthService( 3180): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-12 18:49:42.469+0200 W/SHealthCommon( 3180): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1523491200000,000000[0;m
04-12 18:49:42.489+0200 W/SHealthCommon( 3180): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 1[0;m
04-12 18:49:42.499+0200 I/HealthDataService( 2906): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-12 18:49:42.519+0200 I/healthData( 3180): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-12 18:49:42.869+0200 E/EFL     ( 7832): ecore_x<7832> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=11448131 button=1
04-12 18:49:42.869+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.869+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.869+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:42.899+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.899+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:42.929+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.929+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:42.939+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.939+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:42.949+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.949+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:42.959+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:42.959+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:43.019+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] mouse move
04-12 18:49:43.019+0200 E/EFL     ( 7832): elementary<7832> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7d37f90 : elm_list] hold(0), freeze(0)
04-12 18:49:43.029+0200 E/EFL     ( 7832): ecore_x<7832> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=11448290 button=1
04-12 18:49:43.029+0200 W/AUL     ( 7832): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:49:43.029+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:49:43.029+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7832
04-12 18:49:43.049+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:49:43.049+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7875
04-12 18:49:43.069+0200 E/CAPI_APPFW_APPLICATION( 7875): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.069+0200 E/CAPI_APPFW_APPLICATION( 7875): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.069+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:49:43.099+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7875
04-12 18:49:43.099+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(7875) type(svcapp) bg(0)
04-12 18:49:43.099+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:49:43.099+0200 W/AUL     ( 7832): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7875)
04-12 18:49:43.099+0200 I/utils   ( 7832): es.ugr.frailty.servicemanager launch request sent!
04-12 18:49:43.099+0200 I/utils   ( 7832): App control destroyed.
04-12 18:49:43.099+0200 I/CAPI_APPFW_APPLICATION( 7832): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:49:43.099+0200 I/CAPI_APPFW_APPLICATION( 7832): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:49:43.099+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7875]
04-12 18:49:43.109+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7875
04-12 18:49:43.119+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7878
04-12 18:49:43.119+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:49:43.169+0200 E/CAPI_APPFW_APPLICATION( 7878): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.169+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: MEM_FLUSH State: PAUSED
04-12 18:49:43.169+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7878
04-12 18:49:43.169+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(7878) type(svcapp) bg(0)
04-12 18:49:43.169+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7875) was created
04-12 18:49:43.169+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.179+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7878]
04-12 18:49:43.179+0200 E/CAPI_APPFW_APPLICATION( 7878): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.189+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7875
04-12 18:49:43.189+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.199+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7875
04-12 18:49:43.199+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7878) was created
04-12 18:49:43.199+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.199+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7878)
04-12 18:49:43.199+0200 I/servicemanager( 7875): es.ugr.frailty.httppostreq launch request sent!
04-12 18:49:43.199+0200 I/servicemanager( 7875): App control destroyed.
04-12 18:49:43.199+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:49:43.229+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:49:43.229+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7875
04-12 18:49:43.239+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:49:43.239+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7880
04-12 18:49:43.259+0200 E/CAPI_APPFW_APPLICATION( 7880): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.259+0200 E/CAPI_APPFW_APPLICATION( 7880): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:43.269+0200 W/CAPI_APPFW_APP_CONTROL( 7880): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.269+0200 W/CAPI_APPFW_APP_CONTROL( 7880): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.289+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7880
04-12 18:49:43.289+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(7880) type(svcapp) bg(0)
04-12 18:49:43.289+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.289+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7880]
04-12 18:49:43.309+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7878
04-12 18:49:43.309+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7880) was created
04-12 18:49:43.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.309+0200 I/CAPI_NETWORK_CONNECTION( 7878): connection.c: connection_create(453) > New handle created[0xf74db798]
04-12 18:49:43.309+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.309+0200 W/CAPI_APPFW_APP_CONTROL( 7878): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.309+0200 W/CAPI_APPFW_APP_CONTROL( 7878): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.319+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7880)
04-12 18:49:43.319+0200 I/servicemanager( 7875): es.ugr.frailty.recorder launch request sent!
04-12 18:49:43.319+0200 I/servicemanager( 7875): App control destroyed.
04-12 18:49:43.319+0200 I/servicemanager( 7875): Frailty Service Manager created
04-12 18:49:43.319+0200 W/CAPI_APPFW_APP_CONTROL( 7875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.319+0200 W/CAPI_APPFW_APP_CONTROL( 7875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:43.319+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.329+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7880
04-12 18:49:43.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.349+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.349+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7878
04-12 18:49:43.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.379+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:43.379+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7880
04-12 18:49:43.379+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:43.409+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:49:43.409+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:49:43.409+0200 W/APP_CORE( 7832): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:49:43.409+0200 W/APP_CORE( 7832): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[60272e] for es.ugr.frailty.frailtylauncher[7832]
04-12 18:49:43.449+0200 I/APP_CORE( 7832): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:49:43.449+0200 I/APP_CORE( 7832): appcore-efl.c: __after_loop(1234) > [APP 7832] PAUSE before termination
04-12 18:49:43.449+0200 I/CAPI_APPFW_APPLICATION( 7832): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:49:43.449+0200 I/CAPI_APPFW_APPLICATION( 7832): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:49:43.449+0200 I/APP_CORE( 7832): appcore-efl.c: __after_loop(1243) > [APP 7832] After terminate() callback
04-12 18:49:43.469+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:49:43.469+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:49:43.469+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.469+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:43.469+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:49:43.469+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:49:43.469+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:49:43.469+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:49:43.469+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:49:43.469+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:49:43.519+0200 I/UXT     ( 7832): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:49:43.529+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:49:43.539+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:49:43.539+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.539+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.539+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.539+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:49:43.539+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:49:43.539+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:49:43.539+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:49:43.539+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:49:43.539+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.539+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:43.539+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:49:43.569+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:49:43.569+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 18:49:43.569+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:49:43.569+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:49:43.569+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:49:43.569+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(34), length(2)
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 34%
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 34, isCharging: 0
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_35
04-12 18:49:43.569+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 18:49:43.579+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 18:49:43.579+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 18:49:43.579+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 18:49:43.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:43.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:43.649+0200 I/efl-extension( 7832): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:49:43.649+0200 W/AUL_PAD ( 7832): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:49:43.669+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 7832 pgid = 7832
04-12 18:49:43.669+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:49:43.719+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:49:43.729+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7832
04-12 18:49:43.729+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7832)
04-12 18:49:43.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:43.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:43.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:44.019+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [11449.280182] layer(0x21e250) not usable
04-12 18:49:44.019+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [11449.280238] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:49:44.019+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [11449.280269] layer[0x21dcf0]zpos[0]
04-12 18:49:44.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:44.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:44.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:44.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:49:44.569+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.569+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:49:44.569+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:49:44.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:44.579+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:49:44.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:44.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:44.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:49:44.599+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:49:44.599+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:49:44.599+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:49:44.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:49:44.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:49:44.599+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.599+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:49:44.599+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:49:44.599+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:49:44.609+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:49:44.609+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:49:44.609+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:49:44.609+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.609+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:49:44.619+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.619+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:49:44.619+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:49:44.629+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:49:44.629+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:49:44.629+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:49:44.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:44.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:44.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:44.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:45.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:45.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:45.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:45.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:45.409+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:49:45.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:45.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:45.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:45.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:45.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:45.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:46.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:46.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:46.319+0200 I/servicemanager( 7875): accelerometer alive timeout
04-12 18:49:46.319+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:49:46.319+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:49:46.319+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 7875
04-12 18:49:46.339+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 7886
04-12 18:49:46.339+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:49:46.389+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7886
04-12 18:49:46.389+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(7886) type(svcapp) bg(0)
04-12 18:49:46.389+0200 W/AUL     ( 7875): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7886)
04-12 18:49:46.389+0200 I/servicemanager( 7875): es.ugr.frailty.accelerometer launch request sent!
04-12 18:49:46.389+0200 I/servicemanager( 7875): App control destroyed.
04-12 18:49:46.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:46.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:46.399+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7886]
04-12 18:49:46.429+0200 E/CAPI_APPFW_APPLICATION( 7886): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:46.429+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:46.429+0200 E/CAPI_APPFW_APPLICATION( 7886): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:49:46.439+0200 I/accelerometer( 7886): Starting es.ugr.frailty.accelerometer service
04-12 18:49:46.439+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7886
04-12 18:49:46.439+0200 I/accelerometer( 7886): sensor supported
04-12 18:49:46.439+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:49:46.449+0200 I/accelerometer( 7886): es.ugr.frailty.accelerometer listener started
04-12 18:49:46.449+0200 W/CAPI_APPFW_APP_CONTROL( 7886): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:49:46.449+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7886
04-12 18:49:46.449+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (7886) was created
04-12 18:49:46.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:46.459+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:49:46.529+0200 I/utils   ( 7886): accelerometer utils fecha 12/04/2018,18:49:46
04-12 18:49:46.529+0200 I/accelerometer( 7886): accelerometer fecha conseguida
04-12 18:49:46.529+0200 I/accelerometer( 7886): accelerometer fecha 12/04/2018,18:49:46
04-12 18:49:46.529+0200 I/accelerometer( 7886): accelerometer: 12/04/2018,18:49:46,0.177069,-0.004786,9.829715
04-12 18:49:46.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:49:46.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:49:46.659+0200 W/AUL     ( 7901): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:49:46.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:49:46.659+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:49:46.659+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7886
04-12 18:49:46.659+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:49:46.669+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7886
04-12 18:49:46.669+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7886)
04-12 18:49:46.759+0200 W/CRASH_MANAGER( 7902): worker.c: worker_job(1205) > 1107886616363152355178
