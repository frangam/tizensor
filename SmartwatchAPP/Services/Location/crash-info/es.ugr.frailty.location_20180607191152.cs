S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 29687
Date: 2018-06-07 19:11:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71aa52d, r5   = 0xf73ea150
r6   = 0xffee61f0, r7   = 0xffee60a0
r8   = 0xf73fcc18, r9   = 0x00000000
r10  = 0xffee617c, fp   = 0xffee61f0
ip   = 0x00000001, sp   = 0xffee6078
lr   = 0xf71aa539, pc   = 0xf7213228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    255016 KB
Buffers:      9776 KB
Cached:     102488 KB
VmPeak:      53444 KB
VmSize:      53420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11844 KB
VmRSS:       11844 KB
VmData:      11148 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29687 TID = 29687
29687 29757 

Maps Information
f4075000 f4874000 rw-p [stack:29757]
f487b000 f487d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4885000 f4889000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4892000 f4894000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f489c000 f489f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48ae000 f48b3000 r-xp /usr/lib/libsystem.so.0.0.0
f48be000 f48c1000 r-xp /lib/libattr.so.1.1.0
f48c9000 f48d9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48e1000 f48ea000 r-xp /usr/lib/libedbus.so.1.7.99
f48f2000 f48f3000 r-xp /usr/lib/libresponse.so.0.2.96
f48fc000 f4901000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61a3000 f62a9000 r-xp /usr/lib/libicuuc.so.57.1
f62bf000 f6447000 r-xp /usr/lib/libicui18n.so.57.1
f6457000 f6464000 r-xp /usr/lib/libail.so.0.1.0
f646d000 f6474000 r-xp /usr/lib/libminizip.so.1.0.0
f647d000 f6626000 r-xp /usr/lib/libcrypto.so.1.0.0
f6646000 f668d000 r-xp /usr/lib/libssl.so.1.0.0
f6699000 f669b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66a3000 f66aa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66b3000 f66ba000 r-xp /lib/libcrypt-2.13.so
f66eb000 f66ee000 r-xp /lib/libcap.so.2.21
f66f6000 f66f8000 r-xp /usr/lib/libiri.so
f6700000 f6749000 r-xp /usr/lib/libmdm.so.1.2.69
f6751000 f6757000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f675f000 f6782000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f678c000 f678e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6796000 f67b3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67bc000 f67c0000 r-xp /usr/lib/libsmack.so.1.0.0
f67c9000 f67e2000 r-xp /usr/lib/libnetwork.so.0.0.0
f67eb000 f67f3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67fb000 f6801000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f680a000 f680c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6815000 f6825000 r-xp /lib/libresolv-2.13.so
f6829000 f6841000 r-xp /usr/lib/liblzma.so.5.0.3
f684a000 f684c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6854000 f686e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6876000 f68a5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68ae000 f68bd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68c7000 f68d1000 r-xp /usr/lib/libsensord-shared.so
f68da000 f69ad000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69b8000 f69ce000 r-xp /lib/libz.so.1.2.5
f69d6000 f69db000 r-xp /usr/lib/libffi.so.5.0.10
f69e3000 f69e4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69ec000 f69fc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a04000 f6a1d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a25000 f6a27000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a2f000 f6aa4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aae000 f6ab4000 r-xp /lib/librt-2.13.so
f6abd000 f6adb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ae5000 f6ae6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aee000 f6b11000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b19000 f6b1e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b26000 f6b50000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b59000 f6b70000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b78000 f6be1000 r-xp /lib/libm-2.13.so
f6bea000 f6c7e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c91000 f6c96000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c9e000 f6ca5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cad000 f6cd7000 r-xp /usr/lib/libsensor.so.1.9.6
f6ce0000 f6dac000 r-xp /usr/lib/libxml2.so.2.7.8
f6db9000 f6dbb000 r-xp /usr/lib/libiniparser.so.0
f6dc4000 f6dca000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dd3000 f6ea3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ea4000 f6ed8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ee1000 f6f1d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f25000 f6f28000 r-xp /usr/lib/libbundle.so.0.1.22
f6f30000 f6f36000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f3e000 f6f7f000 r-xp /usr/lib/libeina.so.1.7.99
f6f88000 f6f9f000 r-xp /usr/lib/libecore.so.1.7.99
f6fb6000 f6fbf000 r-xp /usr/lib/libvconf.so.0.2.45
f6fc7000 f6fdb000 r-xp /lib/libpthread-2.13.so
f6fe6000 f6ff3000 r-xp /usr/lib/libaul.so.0.1.0
f6ffd000 f6fff000 r-xp /lib/libdl-2.13.so
f7008000 f7013000 r-xp /lib/libunwind.so.8.0.1
f7040000 f7048000 r-xp /lib/libgcc_s-4.6.so.1
f7049000 f716d000 r-xp /lib/libc-2.13.so
f717b000 f717d000 r-xp /usr/lib/libdlog.so.0.0.0
f7185000 f7191000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f719a000 f719f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71a7000 f71b6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71be000 f71c2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71cb000 f71ce000 r-xp /usr/lib/libappcore-agent.so.1.1
f71d6000 f71d8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71e0000 f71e4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71ec000 f7209000 r-xp /lib/ld-2.13.so
f7212000 f7215000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7215000 f7219000 r-xp /usr/lib/libsys-assert.so
f73cc000 f7436000 rw-p [heap]
ffec7000 ffee8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29687)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7213228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71aa539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6eb13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ebbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ec1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ec1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ef675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ef11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eafc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ebbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ec1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ec1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ef3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ef4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6efbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48931fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4886171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6959663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e06fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e087a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f98ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f93b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f945a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f94879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71cc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71cc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72135c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf706085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7212f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: location
App ID: es.ugr.frailty.location
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ile/calendar/alarm_state FAILED[0;m
06-07 19:11:51.661+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-07 19:11:51.661+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:628,0.070000,0.070000,0.070000
06-07 19:11:51.661+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-07 19:11:51.661+0200 W/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-07 19:11:51.661+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-07 19:11:51.661+0200 I/HIGEAR  ( 3285): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-07 19:11:51.681+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.681+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:611,0.318430,-0.076169,9.801183
06-07 19:11:51.681+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:482,0.039874,0.029850,0.045218
06-07 19:11:51.681+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.681+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.691+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.691+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:693,0.070000,0.070000,0.070000
06-07 19:11:51.701+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:689,0.318245,-0.059821,9.858429
06-07 19:11:51.701+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:700,0.317837,-0.075196,9.801209
06-07 19:11:51.701+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.701+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.701+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.711+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:689,0.015389,-0.029304,0.073937
06-07 19:11:51.711+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.721+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:711,0.070000,0.070000,0.070000
06-07 19:11:51.721+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:717,0.317499,-0.075069,9.801222
06-07 19:11:51.721+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:713,0.323031,-0.076570,9.868000
06-07 19:11:51.721+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:722,0.003154,-0.044879,0.083526
06-07 19:11:51.721+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.721+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.731+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [15336.500964] dpms[3 -> 3]done
06-07 19:11:51.731+0200 I/TDM     ( 1956): 
06-07 19:11:51.731+0200 W/SHealthCommon( 2909): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 19:11:51.731+0200 W/SHealthCommon( 3178): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 19:11:51.731+0200 W/SHealthService( 3178): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
06-07 19:11:51.731+0200 I/watchface-viewer( 2865): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-07 19:11:51.741+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.741+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.741+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
06-07 19:11:51.741+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
06-07 19:11:51.741+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
06-07 19:11:51.741+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
06-07 19:11:51.741+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-6-2018, 19:12:12), repeat(1), interval(20), type(-1073741822)
06-07 19:11:51.751+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: PAUSE State: RUNNING
06-07 19:11:51.751+0200 I/CAPI_APPFW_APPLICATION( 2762): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): main.c: _appcore_pause_cb(488) > appcore pause
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 19:11:51.751+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xee468850
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xee468850, elm_layout, func : 0xf7719d05
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xee468850, activated : 1
06-07 19:11:51.751+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 19:11:51.751+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 19:11:51.751+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 19:11:51.751+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 19:11:51.751+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:746,0.070000,0.070000,0.070000
06-07 19:11:51.761+0200 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:11:51.761+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:750,0.325424,-0.110070,9.824929
06-07 19:11:51.761+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.761+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 19:11:51.761+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 19:11:51.761+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:751,0.317520,-0.076542,9.801209
06-07 19:11:51.771+0200 E/CAPI_APPFW_APP_CONTROL( 3247): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-07 19:11:51.771+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3247]   [com.samsung.w-home]register msg port [false][0m
06-07 19:11:51.771+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-07 19:11:51.771+0200 I/heartrate(29666): es.ugr.frailty.heartrate - capturing data
06-07 19:11:51.771+0200 I/heartrate(29666): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:11:51.771+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.781+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:775,0.320638,-0.062213,9.875179
06-07 19:11:51.781+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:775,0.070000,0.070000,0.070000
06-07 19:11:51.781+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:785,0.317054,-0.075663,9.801231
06-07 19:11:51.791+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.791+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.791+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 744178199, next duetime: 1528391532
06-07 19:11:51.791+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(744178199)
06-07 19:11:51.791+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1528408106), due_time(1528391532)
06-07 19:11:51.801+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.801+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:799,0.070000,0.070000,0.070000
06-07 19:11:51.801+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:803,0.303888,-0.062213,9.860823
06-07 19:11:51.801+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 19:11:51.811+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 19:11:51.811+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 17:12:12 (UTC).
06-07 19:11:51.811+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 19:11:51.811+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 19:11:51.821+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 19:11:51.821+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.821+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:806,0.315879,-0.074824,9.801275
06-07 19:11:51.831+0200 I/light   (29728): es.ugr.frailty.light - capturing data
06-07 19:11:51.831+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.831+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.831+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:734,0.003420,0.009671,0.045247
06-07 19:11:51.831+0200 I/light   (29728): es.ugr.frailty.light: SM-R760,07/06/2018,19:11:51:837,2067.000000
06-07 19:11:51.831+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:841,0.070000,0.070000,0.070000
06-07 19:11:51.841+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:840,0.346959,-0.119641,9.868000
06-07 19:11:51.841+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.851+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:852,0.013395,0.001846,0.038050
06-07 19:11:51.851+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:845,0.317078,-0.076701,9.801223
06-07 19:11:51.851+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.851+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.861+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.861+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.881+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:865,0.070000,0.070000,0.070000
06-07 19:11:51.881+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:873,0.317490,-0.076519,9.801210
06-07 19:11:51.881+0200 W/LOCATION(29687): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 19:11:51.881+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.881+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:869,0.337388,-0.076570,9.832108
06-07 19:11:51.881+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.891+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.891+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:880,0.044426,-0.012779,0.059587
06-07 19:11:51.891+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.901+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:894,0.070000,0.070000,0.070000
06-07 19:11:51.901+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:902,0.318506,-0.075856,9.801183
06-07 19:11:51.901+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:895,0.339781,-0.059821,9.853643
06-07 19:11:51.901+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.901+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.911+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.911+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:905,-0.000185,0.016349,0.057246
06-07 19:11:51.911+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.911+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:913,0.356531,-0.131605,9.868000
06-07 19:11:51.911+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:911,0.070000,0.070000,0.070000
06-07 19:11:51.921+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.921+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.921+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:921,0.005194,-0.001374,0.066791
06-07 19:11:51.921+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.921+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:918,0.320161,-0.078219,9.801110
06-07 19:11:51.921+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.931+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:928,0.070000,0.070000,0.070000
06-07 19:11:51.931+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:931,0.320638,-0.098106,9.812965
06-07 19:11:51.931+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:932,0.007925,-0.035001,0.023707
06-07 19:11:51.931+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.931+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.931+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.941+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:936,0.320199,-0.079276,9.801101
06-07 19:11:51.941+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:947,-0.070000,0.070000,0.070000
06-07 19:11:51.941+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:945,0.003118,0.014329,0.073970
06-07 19:11:51.941+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.941+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.951+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:955,0.320074,-0.080401,9.801095
06-07 19:11:51.951+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:950,0.315853,-0.100499,9.853643
06-07 19:11:51.951+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.951+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.961+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:960,-0.013166,0.013450,0.059591
06-07 19:11:51.961+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.961+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.961+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:963,0.070000,0.070000,0.070000
06-07 19:11:51.971+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:965,0.327817,-0.129212,9.834501
06-07 19:11:51.971+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.971+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.971+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:971,0.031080,-0.044817,0.066725
06-07 19:11:51.971+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:973,0.320137,-0.082501,9.801076
06-07 19:11:51.971+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.971+0200 I/heartrate(29666): es.ugr.frailty.heartrate - capturing data
06-07 19:11:51.971+0200 I/heartrate(29666): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:11:51.981+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:51.981+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:982,0.020310,0.000131,0.030886
06-07 19:11:51.991+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:51:979,-0.070000,0.140000,0.070000
06-07 19:11:51.991+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:51.991+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:51:982,0.294317,-0.064606,9.851252
06-07 19:11:51.991+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:51.991+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:51.991+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:51:998,0.022291,0.016698,0.052433
06-07 19:11:51.991+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:51:991,0.319323,-0.081900,9.801107
06-07 19:11:52.001+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.001+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.001+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:0,-0.070000,0.070000,0.070000
06-07 19:11:52.001+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.001+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:2,0.299103,-0.086142,9.829715
06-07 19:11:52.011+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.011+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:8,0.038025,-0.055749,0.066817
06-07 19:11:52.011+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.011+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:9,0.318716,-0.082387,9.801124
06-07 19:11:52.011+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.021+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:15,0.070000,0.070000,0.070000
06-07 19:11:52.021+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:22,0.000477,-0.019887,0.011855
06-07 19:11:52.021+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.021+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:18,0.315853,-0.069392,9.863215
06-07 19:11:52.021+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.031+0200 I/light   (29728): es.ugr.frailty.light - capturing data
06-07 19:11:52.031+0200 I/light   (29728): es.ugr.frailty.light: SM-R760,07/06/2018,19:11:52:37,2067.000000
06-07 19:11:52.031+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.031+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:27,0.318926,-0.082029,9.801120
06-07 19:11:52.031+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.041+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:35,-0.140000,0.070000,0.070000
06-07 19:11:52.041+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:45,0.319185,-0.082455,9.801107
06-07 19:11:52.041+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:42,-0.004346,-0.021222,0.052543
06-07 19:11:52.041+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:36,0.339781,-0.098106,9.817751
06-07 19:11:52.041+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.041+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.051+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.051+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.051+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:54,0.007743,-0.048811,0.033406
06-07 19:11:52.061+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.061+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:55,-0.140000,0.070000,0.070000
06-07 19:11:52.061+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.061+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:60,0.342174,-0.086142,9.841680
06-07 19:11:52.061+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:67,-0.025820,0.017894,0.050176
06-07 19:11:52.071+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.071+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.081+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:66,0.320334,-0.082750,9.801067
06-07 19:11:52.081+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.081+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:81,-0.020220,-0.004242,0.028607
06-07 19:11:52.081+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.081+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:73,-0.140000,0.070000,0.070000
06-07 19:11:52.081+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.081+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:80,0.334995,-0.071785,9.856036
06-07 19:11:52.081+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.091+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:89,0.321049,-0.082350,9.801047
06-07 19:11:52.091+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:94,0.140000,0.070000,0.070000
06-07 19:11:52.091+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:92,-0.002864,0.012995,0.062092
06-07 19:11:52.091+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.091+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.101+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.101+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:96,0.366102,-0.105284,9.851252
06-07 19:11:52.101+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:104,0.020854,-0.016077,0.016631
06-07 19:11:52.101+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.111+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.111+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:111,-0.070000,0.070000,0.070000
06-07 19:11:52.111+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:106,0.323168,-0.083511,9.800968
06-07 19:11:52.111+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.111+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:117,0.022988,-0.003687,0.040572
06-07 19:11:52.121+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.121+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:114,0.358923,-0.064606,9.798609
06-07 19:11:52.121+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.121+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.121+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:127,-0.070000,0.070000,0.070000
06-07 19:11:52.131+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:122,0.324123,-0.082459,9.800945
06-07 19:11:52.131+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:129,0.014661,0.010966,0.054969
06-07 19:11:52.131+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.131+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.131+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.131+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:134,0.311067,-0.074178,9.839286
06-07 19:11:52.141+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:139,0.323895,-0.082334,9.800954
06-07 19:11:52.141+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.141+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:141,0.045052,-0.022934,0.050204
06-07 19:11:52.141+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.141+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:149,0.327817,-0.062213,9.856036
06-07 19:11:52.151+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.151+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:144,-0.070000,0.140000,0.070000
06-07 19:11:52.151+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:154,0.035756,0.018904,-0.002359
06-07 19:11:52.151+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.151+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.161+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:162,-0.013056,0.008281,0.038341
06-07 19:11:52.161+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.161+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.161+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:167,0.003922,0.020121,0.055082
06-07 19:11:52.161+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.161+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:158,0.323240,-0.081037,9.800986
06-07 19:11:52.171+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:173,0.018933,-0.000319,0.011979
06-07 19:11:52.171+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.171+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.171+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:166,0.070000,0.140000,0.070000
06-07 19:11:52.181+0200 I/heartrate(29666): es.ugr.frailty.heartrate - capturing data
06-07 19:11:52.181+0200 I/heartrate(29666): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:11:52.181+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:180,-0.007333,0.063962,0.074188
06-07 19:11:52.181+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.181+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:188,0.046019,-0.013495,0.038245
06-07 19:11:52.181+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:169,0.342174,-0.081356,9.812965
06-07 19:11:52.181+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.181+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.181+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.191+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:194,0.041965,-0.017827,0.033519
06-07 19:11:52.191+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.191+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:200,0.315853,-0.016750,9.875179
06-07 19:11:52.191+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:201,-0.026550,-0.012389,0.019217
06-07 19:11:52.201+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.201+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:182,0.323185,-0.080711,9.800991
06-07 19:11:52.201+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.201+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:206,-0.010348,-0.002382,0.040695
06-07 19:11:52.201+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.201+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:195,-0.140000,0.070000,0.070000
06-07 19:11:52.211+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.211+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:213,-0.023670,-0.009628,0.035874
06-07 19:11:52.211+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.211+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.211+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:213,0.322476,-0.077432,9.801041
06-07 19:11:52.211+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:220,-0.021965,-0.021300,-0.000072
06-07 19:11:52.221+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.221+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:227,0.023132,-0.032568,0.040546
06-07 19:11:52.221+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.221+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:221,0.368495,-0.090927,9.839286
06-07 19:11:52.231+0200 I/light   (29728): es.ugr.frailty.light - capturing data
06-07 19:11:52.231+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:217,0.140000,0.070000,0.070000
06-07 19:11:52.231+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.231+0200 I/light   (29728): es.ugr.frailty.light: SM-R760,07/06/2018,19:11:52:238,2068.000000
06-07 19:11:52.231+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.231+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:232,0.005664,0.011833,0.052545
06-07 19:11:52.231+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.241+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.241+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:246,-0.001228,-0.000882,0.019031
06-07 19:11:52.241+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:242,0.140000,0.140000,0.070000
06-07 19:11:52.251+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:238,0.324137,-0.077886,9.800982
06-07 19:11:52.251+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.251+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.251+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.251+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:258,-0.012490,-0.039321,0.052505
06-07 19:11:52.261+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:250,0.366102,-0.095713,9.834501
06-07 19:11:52.261+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.261+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:260,0.325653,-0.078538,9.800927
06-07 19:11:52.261+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:269,0.299103,-0.090927,9.820145
06-07 19:11:52.261+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 19:11:52.271+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.271+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:265,0.070000,0.070000,0.070000
06-07 19:11:52.271+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.271+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.271+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.281+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:284,0.022118,-0.016104,0.002234
06-07 19:11:52.281+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:278,0.323807,-0.078974,9.800984
06-07 19:11:52.281+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:282,0.070000,0.070000,0.070000
06-07 19:11:52.281+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.291+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:285,0.313460,-0.081356,9.841680
06-07 19:11:52.291+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.291+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.291+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.291+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:297,-0.007239,0.017983,0.052508
06-07 19:11:52.301+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:295,0.322773,-0.078906,9.801019
06-07 19:11:52.301+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.311+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:302,0.070000,0.070000,0.070000
06-07 19:11:52.311+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.311+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.311+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:305,0.299103,-0.088534,9.836893
06-07 19:11:52.311+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.321+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:318,0.044016,0.031266,0.066824
06-07 19:11:52.321+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:323,0.070000,0.070000,0.070000
06-07 19:11:52.321+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:316,0.321068,-0.079198,9.801073
06-07 19:11:52.321+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:326,0.299103,-0.100499,9.801002
06-07 19:11:52.331+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.331+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.331+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.331+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:337,-0.026614,0.022470,0.052494
06-07 19:11:52.331+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.341+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:337,0.319042,-0.079895,9.801133
06-07 19:11:52.341+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.341+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:346,0.342174,-0.112463,9.841680
06-07 19:11:52.341+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:342,0.070000,0.070000,0.070000
06-07 19:11:52.341+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.351+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.351+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.361+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:353,0.319760,-0.081224,9.801099
06-07 19:11:52.361+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:356,0.070000,0.070000,0.070000
06-07 19:11:52.361+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.361+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:365,0.023869,-0.015161,0.009325
06-07 19:11:52.361+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.361+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:359,0.325424,-0.069392,9.853643
06-07 19:11:52.371+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.371+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.371+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:380,0.318245,-0.081356,9.820145
06-07 19:11:52.371+0200 I/heartrate(29666): es.ugr.frailty.heartrate - capturing data
06-07 19:11:52.371+0200 I/heartrate(29666): es.ugr.frailty.heartrate: waiting for rigth values
06-07 19:11:52.381+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:374,0.319473,-0.080474,9.801114
06-07 19:11:52.381+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:375,0.140000,0.140000,0.070000
06-07 19:11:52.381+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.381+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.381+0200 W/AUL     (29765): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 19:11:52.381+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 19:11:52.391+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 19:11:52.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28634
06-07 19:11:52.391+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 19:11:52.391+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:395,0.070000,0.070000,0.070000
06-07 19:11:52.411+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28634
06-07 19:11:52.411+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28634)
06-07 19:11:52.421+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,19:11:52:378,0.011354,-0.033782,0.088309
06-07 19:11:52.421+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 19:11:52.421+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 19:11:52.421+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 19:11:52.421+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 19:11:52.421+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 19:11:52.431+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 19:11:52.431+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 19:11:52.431+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 19:11:52.431+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 19:11:52.431+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:393,0.318772,-0.080320,9.801139
06-07 19:11:52.431+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.441+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:400,0.306281,-0.119641,9.853643
06-07 19:11:52.441+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.441+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.461+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:455,0.317663,-0.082002,9.801161
06-07 19:11:52.461+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:454,0.070000,0.070000,0.070000
06-07 19:11:52.461+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope - capturing data
06-07 19:11:52.461+0200 I/gravity (29693): es.ugr.frailty.gravity - capturing data
06-07 19:11:52.461+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,19:11:52:457,0.339781,-0.098106,9.803394
06-07 19:11:52.461+0200 I/accelerometer(29650): es.ugr.frailty.accelerometer - capturing data
06-07 19:11:52.471+0200 I/gravity (29693): es.ugr.frailty.gravity: SM-R760,07/06/2018,19:11:52:476,0.318306,-0.082589,9.801135
06-07 19:11:52.481+0200 I/light   (29728): es.ugr.frailty.light - capturing data
06-07 19:11:52.481+0200 I/light   (29728): es.ugr.frailty.light: SM-R760,07/06/2018,19:11:52:488,2067.000000
06-07 19:11:52.481+0200 I/linearacceleration(29690): es.ugr.frailty.linearacceleration - capturing data
06-07 19:11:52.491+0200 I/gyroscope(29653): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,19:11:52:473,0.070000,0.140000,0.070000
06-07 19:11:52.501+0200 W/CRASH_MANAGER(29764): worker.c: worker_job(1205) > 11296876c6f63152839151
