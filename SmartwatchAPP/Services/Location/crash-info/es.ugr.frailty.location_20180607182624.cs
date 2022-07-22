S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28007
Date: 2018-06-07 18:26:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75b652d, r5   = 0xf7c06f98
r6   = 0xffa8dbb0, r7   = 0xffa8da60
r8   = 0xf7c03c18, r9   = 0x00000000
r10  = 0xffa8db3c, fp   = 0xffa8dbb0
ip   = 0x00000001, sp   = 0xffa8da38
lr   = 0xf75b6539, pc   = 0xf761f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    262752 KB
Buffers:      6960 KB
Cached:     101704 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11732 KB
VmRSS:       11732 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28007 TID = 28007
28007 28078 

Maps Information
f4481000 f4c80000 rw-p [stack:28078]
f4c87000 f4c89000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c91000 f4c95000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c9e000 f4ca0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ca8000 f4cab000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cba000 f4cbf000 r-xp /usr/lib/libsystem.so.0.0.0
f4cca000 f4ccd000 r-xp /lib/libattr.so.1.1.0
f4cd5000 f4ce5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ced000 f4cf6000 r-xp /usr/lib/libedbus.so.1.7.99
f4cfe000 f4cff000 r-xp /usr/lib/libresponse.so.0.2.96
f4d08000 f4d0d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65af000 f66b5000 r-xp /usr/lib/libicuuc.so.57.1
f66cb000 f6853000 r-xp /usr/lib/libicui18n.so.57.1
f6863000 f6870000 r-xp /usr/lib/libail.so.0.1.0
f6879000 f6880000 r-xp /usr/lib/libminizip.so.1.0.0
f6889000 f6a32000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a52000 f6a99000 r-xp /usr/lib/libssl.so.1.0.0
f6aa5000 f6aa7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6aaf000 f6ab6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6abf000 f6ac6000 r-xp /lib/libcrypt-2.13.so
f6af7000 f6afa000 r-xp /lib/libcap.so.2.21
f6b02000 f6b04000 r-xp /usr/lib/libiri.so
f6b0c000 f6b55000 r-xp /usr/lib/libmdm.so.1.2.69
f6b5d000 f6b63000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b6b000 f6b8e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b98000 f6b9a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ba2000 f6bbf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bc8000 f6bcc000 r-xp /usr/lib/libsmack.so.1.0.0
f6bd5000 f6bee000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bf7000 f6bff000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c07000 f6c0d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c16000 f6c18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c21000 f6c31000 r-xp /lib/libresolv-2.13.so
f6c35000 f6c4d000 r-xp /usr/lib/liblzma.so.5.0.3
f6c56000 f6c58000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c60000 f6c7a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c82000 f6cb1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cba000 f6cc9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cd3000 f6cdd000 r-xp /usr/lib/libsensord-shared.so
f6ce6000 f6db9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dc4000 f6dda000 r-xp /lib/libz.so.1.2.5
f6de2000 f6de7000 r-xp /usr/lib/libffi.so.5.0.10
f6def000 f6df0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6df8000 f6e08000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e10000 f6e29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e31000 f6e33000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e3b000 f6eb0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6eba000 f6ec0000 r-xp /lib/librt-2.13.so
f6ec9000 f6ee7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ef1000 f6ef2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6efa000 f6f1d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f25000 f6f2a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f32000 f6f5c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f65000 f6f7c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f84000 f6fed000 r-xp /lib/libm-2.13.so
f6ff6000 f708a000 r-xp /usr/lib/libstdc++.so.6.0.16
f709d000 f70a2000 r-xp /usr/lib/libctx-client.so.0.8.3
f70aa000 f70b1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70b9000 f70e3000 r-xp /usr/lib/libsensor.so.1.9.6
f70ec000 f71b8000 r-xp /usr/lib/libxml2.so.2.7.8
f71c5000 f71c7000 r-xp /usr/lib/libiniparser.so.0
f71d0000 f71d6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71df000 f72af000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72b0000 f72e4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72ed000 f7329000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7331000 f7334000 r-xp /usr/lib/libbundle.so.0.1.22
f733c000 f7342000 r-xp /usr/lib/libappsvc.so.0.1.0
f734a000 f738b000 r-xp /usr/lib/libeina.so.1.7.99
f7394000 f73ab000 r-xp /usr/lib/libecore.so.1.7.99
f73c2000 f73cb000 r-xp /usr/lib/libvconf.so.0.2.45
f73d3000 f73e7000 r-xp /lib/libpthread-2.13.so
f73f2000 f73ff000 r-xp /usr/lib/libaul.so.0.1.0
f7409000 f740b000 r-xp /lib/libdl-2.13.so
f7414000 f741f000 r-xp /lib/libunwind.so.8.0.1
f744c000 f7454000 r-xp /lib/libgcc_s-4.6.so.1
f7455000 f7579000 r-xp /lib/libc-2.13.so
f7587000 f7589000 r-xp /usr/lib/libdlog.so.0.0.0
f7591000 f759d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75a6000 f75ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75b3000 f75c2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75ca000 f75ce000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75d7000 f75da000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e2000 f75e4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75ec000 f75f0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75f8000 f7615000 r-xp /lib/ld-2.13.so
f761e000 f7621000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7621000 f7625000 r-xp /usr/lib/libsys-assert.so
f7bd3000 f7c43000 rw-p [heap]
ffa6f000 ffa90000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28007)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf761f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75b6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72bd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf730275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72fd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72ffe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7300017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7307f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c9f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c92171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d65663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7212fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72147a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73a4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf739fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73a05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73a0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75d8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75d87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf761f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf746c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf761ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
oice:Application:WakeupServiceStop:IN]
06-07 18:26:23.941+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:23:777,-0.070000,0.070000,0.070000
06-07 18:26:23.941+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:23.951+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:23:889,0.291924,-0.098106,9.887143
06-07 18:26:23.951+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:23:954,0.070000,0.140000,0.070000
06-07 18:26:23.951+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:23:885,-0.000695,0.020754,0.071486
06-07 18:26:23.951+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:23.951+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:23.961+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:23.961+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:23:766,0.311057,-0.087121,9.801329
06-07 18:26:23.961+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:23.961+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:23:965,0.070000,0.070000,0.070000
06-07 18:26:23.961+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:23.971+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:23:974,0.312068,-0.086294,9.801304
06-07 18:26:23.971+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:23.981+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:23:981,0.311762,-0.087753,9.801300
06-07 18:26:23.981+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:23.981+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:23:988,0.311599,-0.087497,9.801308
06-07 18:26:23.981+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:23.991+0200 I/light   (28043): es.ugr.frailty.light - capturing data
06-07 18:26:23.991+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:23:993,0.311080,-0.086323,9.801334
06-07 18:26:23.991+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:23.991+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:0,0.310081,-0.086990,9.801360
06-07 18:26:23.991+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.001+0200 I/light   (28043): es.ugr.frailty.light: SM-R760,07/06/2018,18:26:23:997,3810.000000
06-07 18:26:24.001+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [12608.771266] dpms[3 -> 3]done
06-07 18:26:24.001+0200 I/TDM     ( 1956): 
06-07 18:26:24.001+0200 W/SHealthCommon( 2909): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 18:26:24.001+0200 I/watchface-viewer( 2865): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-07 18:26:24.001+0200 W/SHealthCommon( 3178): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 18:26:24.001+0200 W/SHealthService( 3178): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
06-07 18:26:24.011+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 18:26:24.011+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
06-07 18:26:24.011+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
06-07 18:26:24.011+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
06-07 18:26:24.011+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
06-07 18:26:24.011+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-6-2018, 18:26:44), repeat(1), interval(20), type(-1073741822)
06-07 18:26:24.011+0200 I/heartrate(27995): es.ugr.frailty.heartrate - capturing data
06-07 18:26:24.011+0200 I/heartrate(27995): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:26:24.021+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 18:26:24.021+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: PAUSE State: RUNNING
06-07 18:26:24.021+0200 I/CAPI_APPFW_APPLICATION( 2762): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): main.c: _appcore_pause_cb(488) > appcore pause
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): rotary.c: rotary_deattach(156) > rotary_deattach:0xee468850
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xee468850, elm_layout, func : 0xf7719d05
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7cf54f0, elm_box, _activated_obj : 0xee468850, activated : 1
06-07 18:26:24.021+0200 I/efl-extension( 2762): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-07 18:26:24.021+0200 E/wnotib  ( 2762): w-notification-board-action.c: wnb_action_is_drawer_hidden(4822) > [NULL==g_wnb_action_data] msg Drawer not initialized.
06-07 18:26:24.021+0200 I/wnotib  ( 2762): w-notification-board-broker-main.c: _wnb_handle_scroller_event(1206) > No second depth view available.
06-07 18:26:24.021+0200 W/W_HOME  ( 2762): win.c: win_back_gesture_disable_set(173) > enable back gesture
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-07 18:26:24.021+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 18:26:24.031+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 18:26:24.031+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 18:26:24.031+0200 W/APPS    ( 2762): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
06-07 18:26:24.041+0200 E/CAPI_APPFW_APP_CONTROL( 3247): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-07 18:26:24.041+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 91613681, next duetime: 1528388804
06-07 18:26:24.041+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(91613681)
06-07 18:26:24.041+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1528408106), due_time(1528388804)
06-07 18:26:24.041+0200 W/MUSIC_CONTROL_SERVICE( 3247): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3247]   [com.samsung.w-home]register msg port [false][0m
06-07 18:26:24.051+0200 W/W_INDICATOR( 2702): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
06-07 18:26:24.051+0200 W/W_INDICATOR( 2702): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
06-07 18:26:24.051+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 18:26:24.051+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 18:26:24.051+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 18:26:24.061+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 18:26:24.061+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 18:26:24.061+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 16:26:44 (UTC).
06-07 18:26:24.061+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 18:26:24.061+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:5,0.310023,-0.086264,9.801369
06-07 18:26:24.061+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.071+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 18:26:24.071+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:74,0.310087,-0.086807,9.801362
06-07 18:26:24.071+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.081+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:23:965,-0.019675,-0.010609,0.085835
06-07 18:26:24.081+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:82,0.311338,-0.085610,9.801332
06-07 18:26:24.081+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.091+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:91,0.310932,-0.085209,9.801349
06-07 18:26:24.091+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.091+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:23:974,0.070000,0.070000,0.070000
06-07 18:26:24.091+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:23:971,0.306281,-0.069392,9.839286
06-07 18:26:24.091+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.091+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.091+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:99,0.312201,-0.086929,9.801293
06-07 18:26:24.101+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.101+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.101+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:107,0.313077,-0.087447,9.801261
06-07 18:26:24.101+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.111+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:113,0.314176,-0.088252,9.801219
06-07 18:26:24.111+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.111+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:119,0.313063,-0.088510,9.801252
06-07 18:26:24.121+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:106,0.311067,-0.095713,9.872787
06-07 18:26:24.121+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:107,-0.004799,0.016931,0.037951
06-07 18:26:24.121+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.121+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:111,-0.070000,0.070000,0.070000
06-07 18:26:24.121+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.121+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.121+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.121+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:127,0.312576,-0.087427,9.801277
06-07 18:26:24.131+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.131+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:136,0.312790,-0.085295,9.801290
06-07 18:26:24.131+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.141+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:141,0.311236,-0.084400,9.801347
06-07 18:26:24.141+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.141+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:148,0.311200,-0.083452,9.801355
06-07 18:26:24.141+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:132,0.000986,-0.008723,0.071426
06-07 18:26:24.141+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:134,-0.070000,0.070000,-0.070000
06-07 18:26:24.141+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.141+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.151+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.151+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:140,0.349352,-0.064606,9.846465
06-07 18:26:24.151+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:157,0.310565,-0.081205,9.801394
06-07 18:26:24.151+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.161+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.161+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:164,0.310130,-0.079773,9.801420
06-07 18:26:24.161+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.161+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:159,0.039329,0.021658,0.045096
06-07 18:26:24.171+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:158,-0.070000,0.070000,-0.070000
06-07 18:26:24.171+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:172,0.310569,-0.083049,9.801379
06-07 18:26:24.171+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:166,0.313460,-0.081356,9.860823
06-07 18:26:24.171+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.171+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.171+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.181+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.181+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:184,0.312995,-0.084719,9.801288
06-07 18:26:24.191+0200 I/light   (28043): es.ugr.frailty.light - capturing data
06-07 18:26:24.191+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:189,0.344566,-0.126820,9.848858
06-07 18:26:24.191+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.191+0200 I/light   (28043): es.ugr.frailty.light: SM-R760,07/06/2018,18:26:24:197,3803.000000
06-07 18:26:24.191+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.201+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:203,0.313890,-0.086989,9.801239
06-07 18:26:24.201+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:202,0.330210,-0.095713,9.865608
06-07 18:26:24.201+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.201+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:183,0.003373,0.005451,0.059461
06-07 18:26:24.201+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:185,0.070000,0.070000,-0.070000
06-07 18:26:24.201+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.211+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.211+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:212,0.351745,-0.112463,9.868000
06-07 18:26:24.211+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.211+0200 I/heartrate(27995): es.ugr.frailty.heartrate - capturing data
06-07 18:26:24.211+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.211+0200 I/heartrate(27995): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:26:24.221+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:224,0.306281,-0.100499,9.808180
06-07 18:26:24.221+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:217,0.313942,-0.087060,9.801237
06-07 18:26:24.221+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.231+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.231+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:220,0.033228,-0.041210,0.047525
06-07 18:26:24.231+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:233,0.311067,-0.069392,9.793823
06-07 18:26:24.231+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.231+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.231+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:225,0.070000,0.070000,-0.070000
06-07 18:26:24.241+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.241+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:244,0.315853,-0.040678,9.913465
06-07 18:26:24.241+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.241+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:240,0.312652,-0.087363,9.801275
06-07 18:26:24.251+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:252,0.277567,-0.064606,9.870394
06-07 18:26:24.251+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.251+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.251+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:245,0.019277,-0.010504,0.064260
06-07 18:26:24.261+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.261+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:250,0.070000,0.070000,0.070000
06-07 18:26:24.261+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:262,0.308674,-0.062213,9.863215
06-07 18:26:24.261+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.271+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.271+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:263,0.312208,-0.087073,9.801292
06-07 18:26:24.281+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:274,0.039544,-0.025533,0.066707
06-07 18:26:24.281+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.291+0200 W/LOCATION(28007): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:26:24.291+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:272,0.308674,-0.040678,9.829715
06-07 18:26:24.291+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.301+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.301+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:299,0.311067,-0.055035,9.836893
06-07 18:26:24.301+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:279,-0.070000,0.070000,0.070000
06-07 18:26:24.301+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.311+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:312,0.323031,-0.155533,9.860823
06-07 18:26:24.311+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.311+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.311+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:305,0.312812,-0.085900,9.801283
06-07 18:26:24.311+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:319,0.370888,-0.124427,9.858429
06-07 18:26:24.311+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.321+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:318,0.140000,0.070000,0.070000
06-07 18:26:24.321+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:324,0.327817,-0.131605,9.860823
06-07 18:26:24.321+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:312,-0.006795,-0.013051,0.006919
06-07 18:26:24.321+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.321+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.321+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.321+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:330,0.313460,-0.086142,9.841680
06-07 18:26:24.331+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.331+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.331+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:337,0.287139,-0.090927,9.856036
06-07 18:26:24.331+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.341+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:344,0.301496,-0.078963,9.844072
06-07 18:26:24.341+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.341+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:338,-0.003109,0.018860,-0.007396
06-07 18:26:24.341+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:336,0.312933,-0.084991,9.801288
06-07 18:26:24.341+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:343,0.140000,0.070000,0.070000
06-07 18:26:24.341+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:350,0.323031,-0.059821,9.844072
06-07 18:26:24.351+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.351+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.351+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:356,0.313460,-0.064606,9.868000
06-07 18:26:24.351+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.351+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.361+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:363,0.313460,-0.071785,9.851252
06-07 18:26:24.361+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.361+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.361+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:369,0.315853,-0.057428,9.808180
06-07 18:26:24.361+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.371+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:374,0.351745,-0.050249,9.848858
06-07 18:26:24.371+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.371+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:362,0.312196,-0.084017,9.801319
06-07 18:26:24.371+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.371+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:365,0.002790,0.047832,0.112212
06-07 18:26:24.381+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:381,0.327817,-0.086142,9.832108
06-07 18:26:24.381+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.381+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.381+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:368,0.070000,0.070000,0.070000
06-07 18:26:24.381+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.381+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:387,0.277567,-0.069392,9.860823
06-07 18:26:24.391+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:384,0.312549,-0.082879,9.801317
06-07 18:26:24.391+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.391+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.391+0200 I/light   (28043): es.ugr.frailty.light - capturing data
06-07 18:26:24.391+0200 I/light   (28043): es.ugr.frailty.light: SM-R760,07/06/2018,18:26:24:398,3763.000000
06-07 18:26:24.391+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:397,0.339781,-0.074178,9.815358
06-07 18:26:24.391+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:388,-0.035009,0.022821,0.069117
06-07 18:26:24.401+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:397,0.314623,-0.081655,9.801262
06-07 18:26:24.401+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.401+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.401+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:393,-0.070000,0.070000,0.070000
06-07 18:26:24.401+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.401+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:410,0.314766,-0.081680,9.801257
06-07 18:26:24.411+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.411+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.411+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:417,0.282353,-0.100499,9.860823
06-07 18:26:24.411+0200 I/heartrate(27995): es.ugr.frailty.heartrate - capturing data
06-07 18:26:24.411+0200 I/heartrate(27995): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:26:24.421+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:412,-0.002562,0.022187,0.061869
06-07 18:26:24.421+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:417,0.313385,-0.081354,9.801304
06-07 18:26:24.421+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.421+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.421+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:414,-0.070000,0.070000,0.070000
06-07 18:26:24.421+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.421+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:427,0.314740,-0.081152,9.801262
06-07 18:26:24.431+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.431+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:430,-0.002562,0.043722,0.028368
06-07 18:26:24.431+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.431+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.441+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:436,0.311067,-0.047856,9.841680
06-07 18:26:24.441+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:432,-0.070000,0.070000,0.070000
06-07 18:26:24.441+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:441,0.313365,-0.082360,9.801296
06-07 18:26:24.441+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.441+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:444,-0.000133,0.028417,0.035538
06-07 18:26:24.441+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.451+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.451+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:456,0.308674,-0.069392,9.841680
06-07 18:26:24.451+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.461+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:456,0.012467,-0.074329,0.059428
06-07 18:26:24.461+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.461+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:452,0.070000,0.140000,0.070000
06-07 18:26:24.461+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:461,0.313771,-0.080980,9.801294
06-07 18:26:24.461+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.461+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:467,0.060758,-0.044653,0.057009
06-07 18:26:24.461+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:470,0.070000,0.070000,0.070000
06-07 18:26:24.471+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.471+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:476,0.318245,-0.069392,9.853643
06-07 18:26:24.471+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.471+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.481+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:481,0.313660,-0.080543,9.801302
06-07 18:26:24.481+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.481+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:482,0.017248,-0.048557,0.059443
06-07 18:26:24.481+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.481+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:489,0.070000,0.070000,0.070000
06-07 18:26:24.481+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.491+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.491+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.491+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:490,0.000465,-0.001423,0.040392
06-07 18:26:24.491+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.491+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:496,0.313460,-0.069392,9.872787
06-07 18:26:24.501+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:500,0.313980,-0.080128,9.801295
06-07 18:26:24.501+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:503,-0.026751,-0.003939,0.054797
06-07 18:26:24.501+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:493,0.070000,0.140000,-0.070000
06-07 18:26:24.501+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.511+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.511+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.511+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.511+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:517,-0.012447,0.008097,0.042835
06-07 18:26:24.521+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.521+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:517,0.323031,-0.083749,9.858429
06-07 18:26:24.521+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:517,0.314017,-0.079728,9.801297
06-07 18:26:24.521+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:512,-0.070000,0.070000,-0.070000
06-07 18:26:24.521+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.521+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:527,0.010379,0.027542,0.042797
06-07 18:26:24.531+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.531+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.531+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.531+0200 I/APP_CORE( 2762): appcore-efl.c: __do_app(453) > [APP 2762] Event: MEM_FLUSH State: PAUSED
06-07 18:26:24.541+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:537,0.001252,0.022466,0.066708
06-07 18:26:24.541+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.541+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:536,0.327817,-0.055035,9.882358
06-07 18:26:24.551+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:544,0.314496,-0.080030,9.801279
06-07 18:26:24.551+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.551+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.551+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:549,0.000647,0.014115,0.049969
06-07 18:26:24.551+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.561+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:531,-0.070000,0.070000,-0.070000
06-07 18:26:24.561+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.561+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:563,0.002920,0.027563,0.006892
06-07 18:26:24.561+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:562,0.315200,-0.078962,9.801265
06-07 18:26:24.561+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:558,0.337388,-0.105284,9.827322
06-07 18:26:24.571+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.571+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.571+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.581+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:576,0.039549,0.033768,0.047539
06-07 18:26:24.581+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:570,-0.070000,0.070000,-0.070000
06-07 18:26:24.581+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.581+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.591+0200 I/light   (28043): es.ugr.frailty.light - capturing data
06-07 18:26:24.591+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:582,0.308674,-0.107677,9.870394
06-07 18:26:24.591+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:581,0.316743,-0.080453,9.801204
06-07 18:26:24.591+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.591+0200 I/light   (28043): es.ugr.frailty.light: SM-R760,07/06/2018,18:26:24:598,3757.000000
06-07 18:26:24.591+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.591+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:589,0.015267,-0.003262,0.030791
06-07 18:26:24.601+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.601+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:594,-0.070000,0.070000,-0.070000
06-07 18:26:24.601+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.611+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:610,-0.037198,0.012288,0.059566
06-07 18:26:24.611+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:604,0.316631,-0.081990,9.801194
06-07 18:26:24.611+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:603,0.311067,-0.078963,9.889536
06-07 18:26:24.611+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.611+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.611+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.611+0200 I/heartrate(27995): es.ugr.frailty.heartrate - capturing data
06-07 18:26:24.611+0200 I/heartrate(27995): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:26:24.621+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:620,0.025015,0.007503,0.014101
06-07 18:26:24.621+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:615,-0.070000,0.070000,-0.070000
06-07 18:26:24.621+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:624,0.315640,-0.081619,9.801229
06-07 18:26:24.621+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.621+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.631+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:623,0.344566,-0.045464,9.841680
06-07 18:26:24.631+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.631+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.631+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:634,-0.032387,-0.019346,0.059561
06-07 18:26:24.631+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.641+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:632,-0.070000,0.070000,-0.070000
06-07 18:26:24.641+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.641+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:650,0.140000,0.070000,-0.070000
06-07 18:26:24.651+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:644,-0.003673,0.033296,0.040418
06-07 18:26:24.651+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:640,0.342174,-0.110070,9.887143
06-07 18:26:24.651+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.651+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:642,0.316444,-0.079763,9.801219
06-07 18:26:24.651+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.651+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.651+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:658,-0.004690,0.012968,0.040383
06-07 18:26:24.661+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:664,0.317746,-0.081258,9.801164
06-07 18:26:24.661+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.661+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.661+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:661,0.284746,-0.057428,9.817751
06-07 18:26:24.671+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.671+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.671+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:670,0.004474,0.011588,0.052349
06-07 18:26:24.671+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.681+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:672,-0.070000,0.070000,-0.070000
06-07 18:26:24.681+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.681+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:680,-0.000200,0.011151,0.071485
06-07 18:26:24.681+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:678,0.316289,-0.080212,9.801220
06-07 18:26:24.681+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.681+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:687,-0.140000,0.070000,-0.070000
06-07 18:26:24.691+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:679,0.323031,-0.100499,9.844072
06-07 18:26:24.691+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.691+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.691+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:697,0.344566,-0.074178,9.834501
06-07 18:26:24.691+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.701+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:704,0.070000,0.070000,-0.070000
06-07 18:26:24.701+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:692,0.009051,-0.003621,0.057134
06-07 18:26:24.701+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.701+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:701,0.316676,-0.081278,9.801199
06-07 18:26:24.701+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.701+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:710,-0.140000,0.070000,-0.070000
06-07 18:26:24.711+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.711+0200 I/gravity (28023): es.ugr.frailty.gravity - capturing data
06-07 18:26:24.711+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:717,0.339781,-0.069392,9.879964
06-07 18:26:24.711+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:713,0.013800,0.024693,0.081060
06-07 18:26:24.711+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.721+0200 I/gravity (28023): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:26:24:718,0.318063,-0.081079,9.801155
06-07 18:26:24.721+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration - capturing data
06-07 18:26:24.721+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:724,-0.070000,0.070000,-0.070000
06-07 18:26:24.721+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.721+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:26:24:729,-0.140000,0.070000,-0.070000
06-07 18:26:24.721+0200 I/linearacceleration(28013): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:26:24:728,0.022892,-0.025254,0.026043
06-07 18:26:24.721+0200 I/gyroscope(27982): es.ugr.frailty.gyroscope - capturing data
06-07 18:26:24.731+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer - capturing data
06-07 18:26:24.731+0200 I/accelerometer(27971): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:26:24:739,0.272782,-0.081356,9.884750
06-07 18:26:24.751+0200 W/CRASH_MANAGER(27853): worker.c: worker_job(1205) > 11280076c6f63152838878
