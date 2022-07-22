S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: accelerometer
PID: 8559
Date: 2018-04-12 18:59:43+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xf71e11b4

Register Information
r0   = 0xf71e11b4, r1   = 0xffdeb74f
r2   = 0x00000000, r3   = 0x00000002
r4   = 0x00000031, r5   = 0xfffffffd
r6   = 0x00000000, r7   = 0xf71e11b4
r8   = 0xf71864c0, r9   = 0x00000002
r10  = 0xffdeb74e, fp   = 0x00000000
ip   = 0x00000032, sp   = 0xffdeb6bc
lr   = 0xf70ec86c, pc   = 0xf70d0250
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     59640 KB
Buffers:     47644 KB
Cached:     221948 KB
VmPeak:      43984 KB
VmSize:      43980 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7172 KB
VmRSS:        7172 KB
VmData:      34152 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        7900 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8559 TID = 8559
8559 8568 8569 8570 8571 

Maps Information
f480a000 f5009000 rw-p [stack:8571]
f500a000 f5809000 rw-p [stack:8570]
f580a000 f6009000 rw-p [stack:8569]
f600a000 f680d000 rw-p [stack:8568]
f680d000 f6810000 r-xp /lib/libattr.so.1.1.0
f6818000 f681f000 r-xp /lib/libcrypt-2.13.so
f6850000 f6853000 r-xp /lib/libcap.so.2.21
f685b000 f685d000 r-xp /usr/lib/libiri.so
f6865000 f6867000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f686f000 f6871000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f687a000 f6946000 r-xp /usr/lib/libxml2.so.2.7.8
f6954000 f6971000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f697a000 f697e000 r-xp /usr/lib/libsmack.so.1.0.0
f6987000 f699d000 r-xp /lib/libz.so.1.2.5
f69a5000 f69a7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69af000 f69b4000 r-xp /usr/lib/libffi.so.5.0.10
f69bc000 f69bd000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69c5000 f69d5000 r-xp /lib/libresolv-2.13.so
f69d9000 f69f1000 r-xp /usr/lib/liblzma.so.5.0.3
f69f9000 f69fb000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a03000 f6a1d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a25000 f6a54000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a5d000 f6a6c000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a75000 f6a7f000 r-xp /usr/lib/libsensord-shared.so
f6a88000 f6abc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ac5000 f6b98000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ba3000 f6ba9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bb2000 f6c27000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c31000 f6c37000 r-xp /lib/librt-2.13.so
f6c40000 f6c5e000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c68000 f6c69000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c71000 f6c94000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c9c000 f6ca1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ca9000 f6d79000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d7a000 f6da4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dad000 f6dc4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dcc000 f6e35000 r-xp /lib/libm-2.13.so
f6e3e000 f6ed2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ee5000 f6eea000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ef2000 f6ef9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f01000 f6f2b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f34000 f6f37000 r-xp /usr/lib/libbundle.so.0.1.22
f6f3f000 f6f45000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f4d000 f6f8e000 r-xp /usr/lib/libeina.so.1.7.99
f6f97000 f6fae000 r-xp /usr/lib/libecore.so.1.7.99
f6fc5000 f6fce000 r-xp /usr/lib/libvconf.so.0.2.45
f6fd6000 f6fea000 r-xp /lib/libpthread-2.13.so
f6ff5000 f7002000 r-xp /usr/lib/libaul.so.0.1.0
f700c000 f700e000 r-xp /lib/libdl-2.13.so
f7017000 f7022000 r-xp /lib/libunwind.so.8.0.1
f704f000 f7057000 r-xp /lib/libgcc_s-4.6.so.1
f7058000 f717c000 r-xp /lib/libc-2.13.so
f718a000 f718c000 r-xp /usr/lib/libdlog.so.0.0.0
f7194000 f71a0000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71a9000 f71ad000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71b6000 f71b9000 r-xp /usr/lib/libappcore-agent.so.1.1
f71d7000 f71f4000 r-xp /lib/ld-2.13.so
f71fd000 f71ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/accelerometer
f71ff000 f7203000 r-xp /usr/lib/libsys-assert.so
f787c000 f78be000 rw-p [heap]
ffdcd000 ffdee000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8559)
Call Stack Count: 1
 0: memcpy + 0xd0 (0xf70d0250) [/lib/libc.so.6] + 0x78250
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
:38.839+0200 W/W_HOME  ( 2742): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-12 18:59:38.839+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:38.849+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [1025]ms
04-12 18:59:38.849+0200 W/STARTER ( 2661): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-12 18:59:38.859+0200 I/APP_CORE( 8504): appcore-efl.c: __do_app(453) > [APP 8504] Event: RESUME State: PAUSED
04-12 18:59:38.859+0200 I/CAPI_APPFW_APPLICATION( 8504): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-12 18:59:38.869+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-12 18:59:38.869+0200 W/W_INDICATOR( 2666): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[powerkey],charge : 0, connected : 0
04-12 18:59:38.869+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151049460[0;m
04-12 18:59:38.869+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-12 18:59:38.869+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-12 18:59:38.879+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2661].
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(557442390)
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-12 18:59:38.879+0200 E/ALARM_MANAGER( 2495): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-12 18:59:38.879+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-12 18:59:38.879+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-12 18:59:38.889+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [12044.152275] layer(0x21e2c0) not usable
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [12044.152314] layer(0x21e2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [12044.152336] layer[0x21de10]zpos[1]
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [12044.152397] layer(0x21e310) not usable
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [12044.152413] layer(0x21e310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:59:38.889+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [12044.152432] layer[0x21df30]zpos[2]
04-12 18:59:38.889+0200 W/W_HOME  ( 2742): gesture.c: _widget_updated_cb(188) > widget updated
04-12 18:59:38.889+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-12 18:59:38.889+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 18:59:38.889+0200 E/WAKEUP-SERVICE( 3240): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-12 18:59:38.889+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-12 18:59:38.889+0200 I/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-12 18:59:38.889+0200 W/TIZEN_N_SOUND_MANAGER( 3240): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-12 18:59:38.889+0200 W/WAKEUP-SERVICE( 3240): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-12 18:59:38.889+0200 I/HIGEAR  ( 3240): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-12 18:59:38.919+0200 W/W_HOME  ( 2742): gesture.c: _manual_render(182) > 
04-12 18:59:38.949+0200 W/W_HOME  ( 2742): gesture.c: _manual_render_enable(138) > 0
04-12 18:59:39.079+0200 W/SHealthCommon( 3180): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 18:59:39.079+0200 W/SHealthService( 3180): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-12 18:59:39.079+0200 I/watchface-viewer( 2828): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-12 18:59:39.079+0200 W/SHealthCommon( 2887): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-12 18:59:39.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-12 18:59:39.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-12 18:59:39.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 12-4-2018, 21:48:26 (UTC).
04-12 18:59:39.099+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-12 18:59:39.109+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-12 18:59:39.109+0200 E/ALARM_MANAGER( 2495): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[557442390] is removed.
04-12 18:59:39.109+0200 W/STARTER ( 2661): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
04-12 18:59:39.109+0200 W/STARTER ( 2661): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-12 18:59:39.619+0200 E/EFL     ( 8504): ecore_x<8504> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=12044882 button=1
04-12 18:59:39.619+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.619+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.619+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] hold(0), freeze(0)
04-12 18:59:39.629+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.629+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] hold(0), freeze(0)
04-12 18:59:39.639+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.639+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] hold(0), freeze(0)
04-12 18:59:39.649+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.649+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] hold(0), freeze(0)
04-12 18:59:39.679+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:3999 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] mouse move
04-12 18:59:39.679+0200 E/EFL     ( 8504): elementary<8504> elm_interface_scrollable.c:4163 _elm_scroll_mouse_move_event_cb() [0xf7725f60 : elm_list] hold(0), freeze(0)
04-12 18:59:39.719+0200 E/EFL     ( 8504): ecore_x<8504> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=12044987 button=1
04-12 18:59:39.719+0200 W/AUL     ( 8504): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 18:59:39.729+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:59:39.729+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8504
04-12 18:59:39.739+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8548
04-12 18:59:39.739+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:59:39.769+0200 E/CAPI_APPFW_APPLICATION( 8548): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.769+0200 E/CAPI_APPFW_APPLICATION( 8548): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.769+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 18:59:39.789+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8548
04-12 18:59:39.789+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.servicemanager) pid(8548) type(svcapp) bg(0)
04-12 18:59:39.789+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:59:39.789+0200 W/AUL     ( 8504): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8548)
04-12 18:59:39.789+0200 I/utils   ( 8504): es.ugr.frailty.servicemanager launch request sent!
04-12 18:59:39.789+0200 I/utils   ( 8504): App control destroyed.
04-12 18:59:39.789+0200 I/CAPI_APPFW_APPLICATION( 8504): app_main.c: ui_app_exit(715) > ui_app_exit
04-12 18:59:39.789+0200 I/CAPI_APPFW_APPLICATION( 8504): app_main.c: app_efl_exit(145) > app_efl_exit
04-12 18:59:39.789+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8548]
04-12 18:59:39.799+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8548
04-12 18:59:39.809+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8551
04-12 18:59:39.809+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:59:39.849+0200 E/CAPI_APPFW_APPLICATION( 8551): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.849+0200 E/CAPI_APPFW_APPLICATION( 8551): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.859+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8551
04-12 18:59:39.859+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(8551) type(svcapp) bg(0)
04-12 18:59:39.859+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8548) was created
04-12 18:59:39.859+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8551) was created
04-12 18:59:39.859+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:39.869+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8548
04-12 18:59:39.869+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:39.879+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8551)
04-12 18:59:39.879+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8551]
04-12 18:59:39.889+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8548
04-12 18:59:39.889+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:39.889+0200 I/servicemanager( 8548): es.ugr.frailty.httppostreq launch request sent!
04-12 18:59:39.889+0200 I/servicemanager( 8548): App control destroyed.
04-12 18:59:39.889+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 18:59:39.899+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:59:39.899+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8548
04-12 18:59:39.909+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8553
04-12 18:59:39.909+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:59:39.929+0200 E/CAPI_APPFW_APPLICATION( 8553): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.929+0200 E/CAPI_APPFW_APPLICATION( 8553): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:39.929+0200 W/CAPI_APPFW_APP_CONTROL( 8553): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:39.929+0200 W/CAPI_APPFW_APP_CONTROL( 8553): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:39.959+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8553
04-12 18:59:39.959+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(8553) type(svcapp) bg(0)
04-12 18:59:39.959+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:39.959+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8553) was created
04-12 18:59:39.959+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:39.969+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8551
04-12 18:59:39.969+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:39.979+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8553]
04-12 18:59:39.979+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8553)
04-12 18:59:39.989+0200 I/servicemanager( 8548): es.ugr.frailty.recorder launch request sent!
04-12 18:59:39.989+0200 I/servicemanager( 8548): App control destroyed.
04-12 18:59:39.989+0200 I/servicemanager( 8548): Frailty Service Manager created
04-12 18:59:39.989+0200 W/CAPI_APPFW_APP_CONTROL( 8548): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:39.989+0200 W/CAPI_APPFW_APP_CONTROL( 8548): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:39.989+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:39.999+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8553
04-12 18:59:39.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:40.029+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:40.039+0200 W/APP_CORE( 8504): appcore-efl.c: appcore_efl_main(1788) > power off : 0
04-12 18:59:40.039+0200 W/APP_CORE( 8504): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2800002] -> redirected win[602de6] for es.ugr.frailty.frailtylauncher[8504]
04-12 18:59:40.039+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8551
04-12 18:59:40.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 18:59:40.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 18:59:40.039+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:40.059+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:40.069+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8553
04-12 18:59:40.069+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:40.099+0200 I/APP_CORE( 8504): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
04-12 18:59:40.099+0200 I/APP_CORE( 8504): appcore-efl.c: __after_loop(1234) > [APP 8504] PAUSE before termination
04-12 18:59:40.099+0200 I/CAPI_APPFW_APPLICATION( 8504): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-12 18:59:40.099+0200 I/CAPI_APPFW_APPLICATION( 8504): app_main.c: _ui_app_appcore_terminate(585) > app_appcore_terminate
04-12 18:59:40.099+0200 I/APP_CORE( 8504): appcore-efl.c: __after_loop(1243) > [APP 8504] After terminate() callback
04-12 18:59:40.129+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:59:40.129+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:59:40.129+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.129+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.129+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:59:40.129+0200 W/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[2742] goes to (3)
04-12 18:59:40.129+0200 E/STARTER ( 2661): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 2742)'s state(3)
04-12 18:59:40.129+0200 W/AUL_AMD ( 2499): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-12 18:59:40.129+0200 W/AUL_AMD ( 2499): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-12 18:59:40.129+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2742) status(fg) type(uiapp)
04-12 18:59:40.139+0200 I/CAPI_NETWORK_CONNECTION( 8551): connection.c: connection_create(453) > New handle created[0xf7801728]
04-12 18:59:40.139+0200 W/CAPI_APPFW_APP_CONTROL( 8551): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:40.139+0200 W/CAPI_APPFW_APP_CONTROL( 8551): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:40.149+0200 I/UXT     ( 8504): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
04-12 18:59:40.179+0200 W/PROCESSMGR( 2312): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-12 18:59:40.179+0200 W/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-12 18:59:40.179+0200 I/WATCH_CORE( 2828): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-12 18:59:40.179+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.179+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.179+0200 I/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-12 18:59:40.189+0200 W/W_HOME  ( 2742): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-12 18:59:40.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.189+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.189+0200 W/W_HOME  ( 2742): main.c: _ecore_x_message_cb(997) > main_info.is_win_on_top: 1
04-12 18:59:40.189+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-12 18:59:40.189+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(466) > Window [0x1E00003] is now visible(0)
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): main.c: _window_visibility_cb(964) > Window [0x1E00003] is now visible(0)
04-12 18:59:40.209+0200 I/APP_CORE( 2742): appcore-efl.c: __do_app(453) > [APP 2742] Event: RESUME State: PAUSED
04-12 18:59:40.209+0200 I/CAPI_APPFW_APPLICATION( 2742): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-12 18:59:40.209+0200 W/W_HOME  ( 2742): main.c: _appcore_resume_cb(479) > appcore resume
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): main.c: home_resume(531) > clock/widget resumed
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-12 18:59:40.219+0200 W/W_HOME  ( 2742): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(32), length(2)
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 32%
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 32, isCharging: 0
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_35
04-12 18:59:40.219+0200 W/W_INDICATOR( 2666): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-12 18:59:40.219+0200 I/wnotib  ( 2742): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
04-12 18:59:40.219+0200 E/wnotib  ( 2742): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-12 18:59:40.219+0200 W/wnotib  ( 2742): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-12 18:59:40.229+0200 W/WATCH_CORE( 2828): appcore-watch.c: __widget_resume(1124) > widget_resume
04-12 18:59:40.229+0200 W/AUL     ( 2828): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2828) status(fg) type(watchapp)
04-12 18:59:40.229+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppResume(560) > 
04-12 18:59:40.239+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.239+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.259+0200 I/efl-extension( 8504): efl_extension.c: eext_mod_shutdown(46) > Shutdown
04-12 18:59:40.269+0200 W/AUL_PAD ( 8504): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
04-12 18:59:40.289+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 8504 pgid = 8504
04-12 18:59:40.289+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
04-12 18:59:40.329+0200 W/AUL_PAD ( 3381): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-12 18:59:40.329+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8504
04-12 18:59:40.329+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8504)
04-12 18:59:40.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.679+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1442) > [12045.948850] layer(0x21e250) not usable
04-12 18:59:40.679+0200 I/TDM     ( 1957): tdm_display.c: tdm_layer_set_info(1459) > [12045.948908] layer(0x21e250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-12 18:59:40.679+0200 I/TDM     ( 1957): tdm_exynos_display.c: exynos_layer_set_info(1578) > [12045.948938] layer[0x21dcf0]zpos[0]
04-12 18:59:40.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:40.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:40.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:41.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:41.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:59:41.219+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.219+0200 E/CAPI_APPFW_APP_CONTROL( 3275): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-12 18:59:41.219+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3275]   [com.samsung.w-home]register msg port [true][0m
04-12 18:59:41.219+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:41.239+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2742
04-12 18:59:41.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:59:41.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:59:41.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:59:41.249+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:59:41.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:59:41.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3275]   bundle_add_str() .. [0xffffffea][0m
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:59:41.249+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.249+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:59:41.249+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:59:41.249+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3275]   [MUSIC_PLAYER_EVENT][0m
04-12 18:59:41.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-12 18:59:41.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-12 18:59:41.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3275): preference.c: preference_get_int(1132) > preference_get_int(3275) : key(music-control-service_native/playing_diration) error
04-12 18:59:41.259+0200 W/MUSIC_CONTROL_SERVICE( 3275): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3275]   preference_get_int() .. [0xfef00030][0m
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:59:41.259+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.269+0200 W/W_HOME  ( 2742): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-12 18:59:41.269+0200 E/W_HOME  ( 2742): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-12 18:59:41.269+0200 I/TIZEN_N_SOUND_MANAGER( 3275): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-12 18:59:41.269+0200 W/TIZEN_N_SOUND_MANAGER( 3275): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-12 18:59:41.279+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-12 18:59:41.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:41.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:41.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:41.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:41.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:41.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:41.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:41.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.039+0200 W/AUL_AMD ( 2499): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-12 18:59:42.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:42.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.389+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:42.389+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.589+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:42.589+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.789+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:42.789+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.989+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:42.989+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:42.999+0200 I/servicemanager( 8548): accelerometer alive timeout
04-12 18:59:42.999+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 18:59:42.999+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 18:59:42.999+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 8548
04-12 18:59:43.019+0200 W/AUL_AMD ( 2499): amd_launch.c: start_process(606) > child process: 8559
04-12 18:59:43.019+0200 E/RESOURCED( 2529): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-12 18:59:43.069+0200 W/AUL_AMD ( 2499): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 8559
04-12 18:59:43.069+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(8559) type(svcapp) bg(0)
04-12 18:59:43.079+0200 W/AUL     ( 8548): launch.c: app_request_to_launchpad(298) > request cmd(0) result(8559)
04-12 18:59:43.079+0200 I/servicemanager( 8548): es.ugr.frailty.accelerometer launch request sent!
04-12 18:59:43.079+0200 I/servicemanager( 8548): App control destroyed.
04-12 18:59:43.089+0200 W/STARTER ( 2661): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [8559]
04-12 18:59:43.109+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:43.109+0200 E/CAPI_APPFW_APPLICATION( 8559): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:43.109+0200 E/CAPI_APPFW_APPLICATION( 8559): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-12 18:59:43.119+0200 I/accelerometer( 8559): Starting es.ugr.frailty.accelerometer service
04-12 18:59:43.119+0200 I/accelerometer( 8559): sensor supported
04-12 18:59:43.119+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8559
04-12 18:59:43.119+0200 W/AUL_AMD ( 2499): amd_status.c: __socket_monitor_cb(1277) > (8559) was created
04-12 18:59:43.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:43.129+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 14
04-12 18:59:43.139+0200 I/accelerometer( 8559): es.ugr.frailty.accelerometer listener started
04-12 18:59:43.139+0200 W/CAPI_APPFW_APP_CONTROL( 8559): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 18:59:43.149+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 8559
04-12 18:59:43.149+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 12
04-12 18:59:43.189+0200 I/CAPI_WATCH_APPLICATION( 2828): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-12 18:59:43.189+0200 E/watchface-loader( 2828): watchface-loader.cpp: OnAppTimeTick(579) > 
04-12 18:59:43.299+0200 W/AUL     ( 8574): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 18:59:43.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 18:59:43.299+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 18:59:43.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 8559
04-12 18:59:43.299+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 18:59:43.299+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 8559
04-12 18:59:43.299+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(8559)
04-12 18:59:43.379+0200 W/CRASH_MANAGER( 8575): worker.c: worker_job(1205) > 1108559616363152355238
