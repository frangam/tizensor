S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 19097
Date: 2018-04-23 13:54:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7336648, r1   = 0xf74c81b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf74c81b8, r5   = 0x00012cd0
r6   = 0xf74dae88, r7   = 0xf7336250
r8   = 0x000005e0, r9   = 0xf6e19824
r10  = 0xf74c09d8, fp   = 0x00000000
ip   = 0xf7335030, sp   = 0xfff205f0
lr   = 0xf72795d0, pc   = 0xf72759fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      7728 KB
Buffers:     27768 KB
Cached:     141268 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          32 KB
VmSwap:          0 KB

Maps Information
f69b0000 f69b3000 r-xp /lib/libattr.so.1.1.0
f69bc000 f69c3000 r-xp /lib/libcrypt-2.13.so
f69f3000 f69f6000 r-xp /lib/libcap.so.2.21
f69fe000 f6a00000 r-xp /usr/lib/libiri.so
f6a08000 f6a25000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a2e000 f6a32000 r-xp /usr/lib/libsmack.so.1.0.0
f6a3c000 f6a3e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a46000 f6a4b000 r-xp /usr/lib/libffi.so.5.0.10
f6a53000 f6a54000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a5c000 f6a5e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a66000 f6a68000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a72000 f6a82000 r-xp /lib/libresolv-2.13.so
f6a86000 f6a9e000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa6000 f6aa8000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ab0000 f6adf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ae8000 f6af7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b00000 f6b0a000 r-xp /usr/lib/libsensord-shared.so
f6b13000 f6b47000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b50000 f6c23000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c2e000 f6c44000 r-xp /lib/libz.so.1.2.5
f6c4c000 f6c52000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c5b000 f6cd0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cda000 f6cf4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cfc000 f6d02000 r-xp /lib/librt-2.13.so
f6d0b000 f6d29000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d33000 f6d34000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d3c000 f6d41000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d49000 f6e19000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e1a000 f6e44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e4d000 f6e64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e6c000 f6ed5000 r-xp /lib/libm-2.13.so
f6ede000 f6f72000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f85000 f6f8a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f92000 f6f99000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fa1000 f6fcb000 r-xp /usr/lib/libsensor.so.1.9.6
f6fd4000 f70a0000 r-xp /usr/lib/libxml2.so.2.7.8
f70ad000 f70af000 r-xp /usr/lib/libiniparser.so.0
f70b8000 f70bb000 r-xp /usr/lib/libbundle.so.0.1.22
f70c3000 f70c9000 r-xp /usr/lib/libappsvc.so.0.1.0
f70d1000 f70f4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70fc000 f713d000 r-xp /usr/lib/libeina.so.1.7.99
f7146000 f715d000 r-xp /usr/lib/libecore.so.1.7.99
f7174000 f717d000 r-xp /usr/lib/libvconf.so.0.2.45
f7185000 f7199000 r-xp /lib/libpthread-2.13.so
f71a4000 f71b1000 r-xp /usr/lib/libaul.so.0.1.0
f71bb000 f71bd000 r-xp /lib/libdl-2.13.so
f71c6000 f71d1000 r-xp /lib/libunwind.so.8.0.1
f71fe000 f7206000 r-xp /lib/libgcc_s-4.6.so.1
f7207000 f732b000 r-xp /lib/libc-2.13.so
f7339000 f733b000 r-xp /usr/lib/libdlog.so.0.0.0
f7343000 f734f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7358000 f735d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7365000 f7369000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7372000 f7374000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f737d000 f7380000 r-xp /usr/lib/libappcore-agent.so.1.1
f739e000 f73bb000 r-xp /lib/ld-2.13.so
f73c4000 f73c7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73c7000 f73cb000 r-xp /usr/lib/libsys-assert.so
f74b6000 f7504000 rw-p [heap]
fff02000 fff23000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19097)
Call Stack Count: 1
 0: (0xf72759fc) [/lib/libc.so.6] + 0x6e9fc
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
(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:54.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:54.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:54.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:54.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:54.401+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:54.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:54:417,74
04-23 13:53:54.601+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:54.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:54:616,74
04-23 13:53:54.801+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:54.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:54:817,74
04-23 13:53:55.001+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:55.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:55:17,75
04-23 13:53:55.201+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:55.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:55:217,74
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:55.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491635299,000000, pattern:[H:mm][0;m
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:55.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:55.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:55.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:55.401+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:55.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:55:417,75
04-23 13:53:55.601+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:55.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:55:617,74
04-23 13:53:55.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:55.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:55:818,75
04-23 13:53:56.001+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:56.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:56:17,75
04-23 13:53:56.201+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:56.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:56:218,74
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:56.301+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491636309,000000, pattern:[H:mm][0;m
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:56.301+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:56.301+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:56.301+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:56.401+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:56.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:56:417,74
04-23 13:53:56.441+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 13:53:56.441+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 13:53:56.441+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 13:53:56.441+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 13:53:56.441+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 13:53:56.441+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 13:53:56.441+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 1
04-23 13:53:56.441+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 1
04-23 13:53:56.441+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] reserved app is running now. raise it.
04-23 13:53:56.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:53:56.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:53:56.451+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1449) > [_pre_lcd_off:1449] [com.samsung.shealth.alert] is now running & will raise when lcd on.
04-23 13:53:56.451+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [21311.568904] layer(0x47f2c0) now usable
04-23 13:53:56.451+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [21311.568928] layer[0x47ee10]zpos[1]
04-23 13:53:56.451+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [21311.568955] layer(0x47f310) now usable
04-23 13:53:56.451+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [21311.568966] layer[0x47ef30]zpos[2]
04-23 13:53:56.451+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [21311.568981] dpms[0 -> 3]sync[1]
04-23 13:53:56.451+0200 I/TDM     ( 1945): 
04-23 13:53:56.471+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 13:53:56.471+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 13:53:56.471+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 13:53:56.471+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 13:53:56.471+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 13:53:56.471+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 13:53:56.471+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 13:53:56.481+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 13:53:56.481+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 13:53:56.481+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 13:53:56.481+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 13:53:56.581+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [21311.690897] dpms[3 -> 3]done
04-23 13:53:56.581+0200 I/TDM     ( 1945): 
04-23 13:53:56.581+0200 W/SHealthCommon(17411): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:53:56.581+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:53:56.581+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 13:53:56.591+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 13:53:56.591+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[com.samsung.shealth.alert] alpm mode[0]
04-23 13:53:56.591+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 1
04-23 13:53:56.591+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1525) > [_post_lcd_off:1525] raise [com.samsung.shealth.alert] when lcd off after 20 sec.
04-23 13:53:56.591+0200 E/ALARM_MANAGER( 2693): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(23-4-2018, 13:54:17), repeat(1), interval(20), type(-1073741822)
04-23 13:53:56.601+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2693].
04-23 13:53:56.621+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 13:53:56.631+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2016607793, next duetime: 1524484457
04-23 13:53:56.631+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(2016607793)
04-23 13:53:56.631+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1524493503), due_time(1524484457)
04-23 13:53:56.641+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 13:53:56.641+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: PAUSE State: RUNNING
04-23 13:53:56.641+0200 I/CAPI_APPFW_APPLICATION(17411): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-23 13:53:56.641+0200 W/WSLib   (17411): Application.cpp: SOnAppPause(315) > [1;35m ###[0;m
04-23 13:53:56.641+0200 W/SHealthCommon(17411): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 13:53:56.641+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 13:53:56.641+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:53:56.641+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 13:53:56.651+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 11:54:17 (UTC).
04-23 13:53:56.651+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 13:53:56.651+0200 W/SHealthAlertViewer(17411): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
04-23 13:53:56.651+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 13:53:56.671+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:53:56.671+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 13:53:56.671+0200 W/SHealthCommon( 3087): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
04-23 13:53:56.671+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 13:53:56.671+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 13:53:56.671+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 13:53:56.671+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:56.681+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:56:685,74
04-23 13:53:56.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:56.811+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:56:818,74
04-23 13:53:56.921+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf8211280) is deleting
04-23 13:53:56.921+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf8211280) is deleting
04-23 13:53:56.921+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xf8211cc8) is deleting
04-23 13:53:56.921+0200 I/Vi::Animations(17411): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xf8211cc8) is deleting
04-23 13:53:57.001+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:57.011+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:57:18,74
04-23 13:53:57.201+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:57.211+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:57:218,74
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491637292,000000, pattern:[H:mm][0;m
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:57.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:57.411+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:57.411+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:57:419,74
04-23 13:53:57.611+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:57.611+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:57:618,74
04-23 13:53:57.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:57.811+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:57:819,74
04-23 13:53:58.011+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:58.011+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:58:19,73
04-23 13:53:58.211+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:58.211+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:58:219,73
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491638293,000000, pattern:[H:mm][0;m
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:58.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:58.411+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:58.411+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:58:419,73
04-23 13:53:58.611+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:58.611+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:58:620,73
04-23 13:53:58.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:58.811+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:58:819,73
04-23 13:53:59.011+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:59.011+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:59:20,73
04-23 13:53:59.211+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:59.211+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:59:220,73
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491639297,000000, pattern:[H:mm][0;m
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:53:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:53:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:53:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:53][0;m
04-23 13:53:59.411+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:59.411+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:59:420,73
04-23 13:53:59.611+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:59.611+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:59:620,73
04-23 13:53:59.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:53:59.811+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:53:59:820,73
04-23 13:54:00.011+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:00.011+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:00:20,73
04-23 13:54:00.211+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:00.211+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:00:220,73
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491640297,000000, pattern:[H:mm][0;m
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:00.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:00.411+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:00.411+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:00:421,73
04-23 13:54:00.611+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:00.611+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:00:620,73
04-23 13:54:00.811+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:00.811+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:00:821,73
04-23 13:54:01.011+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:01.011+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:01:21,73
04-23 13:54:01.211+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:01.211+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:01:221,73
04-23 13:54:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:54:01.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:01.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491641295,000000, pattern:[H:mm][0;m
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:01.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:54:01.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:54:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:54:01.311+0200 I/utils   (17422): specific action
04-23 13:54:01.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:54:01.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:54:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:54:01.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:54:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:54:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:54:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:54:01.311+0200 I/httppostreq(17422): internet available
04-23 13:54:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:54:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:54:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:54:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:54:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:54:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:01.341+0200 I/utils   (17419): specific action
04-23 13:54:01.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:54:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:01.341+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:54:01.341+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:54:01.341+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:54:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:01.361+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:54:01.361+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19079
04-23 13:54:01.401+0200 E/CAPI_APPFW_APPLICATION(19079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:01.401+0200 E/CAPI_APPFW_APPLICATION(19079): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:01.401+0200 I/utils   (19079): trying to start service: es.ugr.frailty.accelerometer
04-23 13:54:01.401+0200 I/utils   (19079): es.ugr.frailty.accelerometer sensor supported
04-23 13:54:01.411+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:01.411+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19079
04-23 13:54:01.411+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(19079) type(svcapp) bg(0)
04-23 13:54:01.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19079) was created
04-23 13:54:01.421+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19079]
04-23 13:54:01.431+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19079)
04-23 13:54:01.431+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:54:01.431+0200 I/servicemanager(17419): App control destroyed.
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 0
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 1
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 2
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 3
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 4
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 5
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 6
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:01.431+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:01.431+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:01.431+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 7
04-23 13:54:01.431+0200 I/servicemanager(17419): deleting timer 8
04-23 13:54:01.431+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:54:01.471+0200 I/utils   (19079): es.ugr.frailty.accelerometer listener started
04-23 13:54:01.471+0200 I/accelerometer(19079): stopping es.ugr.frailty.accelerometer service
04-23 13:54:01.471+0200 E/CAPI_APPFW_APP_CONTROL(19079): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:54:01.471+0200 E/accelerometer(19079): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:54:01.471+0200 I/CAPI_APPFW_APPLICATION(19079): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:54:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:01.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:01.501+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19097
04-23 13:54:01.541+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:54:01.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19097
04-23 13:54:01.551+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(19097) type(svcapp) bg(0)
04-23 13:54:01.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19079
04-23 13:54:01.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19097]
04-23 13:54:01.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19079
04-23 13:54:01.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.591+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:01:421,74
04-23 13:54:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19079
04-23 13:54:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:54:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:54:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19097
04-23 13:54:01.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.691+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19097
04-23 13:54:01.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.721+0200 I/APP_CORE(17411): appcore-efl.c: __do_app(453) > [APP 17411] Event: MEM_FLUSH State: PAUSED
04-23 13:54:01.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:01.821+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19097
04-23 13:54:01.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:01.881+0200 E/CAPI_APPFW_APPLICATION(19097): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:01.881+0200 E/CAPI_APPFW_APPLICATION(19097): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:01.881+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19097) was created
04-23 13:54:01.881+0200 I/utils   (19097): specific action
04-23 13:54:01.881+0200 I/recorder(19097): obteniendo datos locales...
04-23 13:54:01.901+0200 I/recorder(19097): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:54:01.901+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:54:01.911+0200 I/recorder(19097): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:54:01.971+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1119097726563152448444
