S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28580
Date: 2018-04-23 17:00:02+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76ea52d, r5   = 0xf77f9f98
r6   = 0xfffa83c0, r7   = 0xfffa8270
r8   = 0xf77f6c18, r9   = 0x00000000
r10  = 0xfffa834c, fp   = 0xfffa83c0
ip   = 0x00000001, sp   = 0xfffa70f0
lr   = 0xf76ea539, pc   = 0xf77532b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16192 KB
Buffers:     64840 KB
Cached:     221628 KB
VmPeak:      53460 KB
VmSize:      53396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12260 KB
VmRSS:       12260 KB
VmData:      11124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28580 TID = 28580
28580 28583 

Maps Information
f45b5000 f4db4000 rw-p [stack:28583]
f4dbb000 f4dbd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dc5000 f4dc9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4dd2000 f4dd4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ddc000 f4ddf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dee000 f4df3000 r-xp /usr/lib/libsystem.so.0.0.0
f4dfe000 f4e01000 r-xp /lib/libattr.so.1.1.0
f4e09000 f4e19000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e21000 f4e2a000 r-xp /usr/lib/libedbus.so.1.7.99
f4e32000 f4e33000 r-xp /usr/lib/libresponse.so.0.2.96
f4e3c000 f4e41000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66e3000 f67e9000 r-xp /usr/lib/libicuuc.so.57.1
f67ff000 f6987000 r-xp /usr/lib/libicui18n.so.57.1
f6997000 f69a4000 r-xp /usr/lib/libail.so.0.1.0
f69ad000 f69b4000 r-xp /usr/lib/libminizip.so.1.0.0
f69bd000 f6b66000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b86000 f6bcd000 r-xp /usr/lib/libssl.so.1.0.0
f6bd9000 f6bdb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6be3000 f6bea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bf3000 f6bfa000 r-xp /lib/libcrypt-2.13.so
f6c2b000 f6c2e000 r-xp /lib/libcap.so.2.21
f6c36000 f6c38000 r-xp /usr/lib/libiri.so
f6c40000 f6c89000 r-xp /usr/lib/libmdm.so.1.2.69
f6c91000 f6c97000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c9f000 f6cc2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ccc000 f6cce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cd6000 f6cf3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cfc000 f6d00000 r-xp /usr/lib/libsmack.so.1.0.0
f6d09000 f6d22000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d2b000 f6d33000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d3b000 f6d41000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d4a000 f6d4c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d55000 f6d65000 r-xp /lib/libresolv-2.13.so
f6d69000 f6d81000 r-xp /usr/lib/liblzma.so.5.0.3
f6d8a000 f6d8c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d94000 f6dae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6db6000 f6de5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dee000 f6dfd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e07000 f6e11000 r-xp /usr/lib/libsensord-shared.so
f6e1a000 f6eed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ef8000 f6f0e000 r-xp /lib/libz.so.1.2.5
f6f16000 f6f1b000 r-xp /usr/lib/libffi.so.5.0.10
f6f23000 f6f24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f2c000 f6f3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f44000 f6f5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f65000 f6f67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f6f000 f6fe4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fee000 f6ff4000 r-xp /lib/librt-2.13.so
f6ffd000 f701b000 r-xp /usr/lib/libsystemd.so.0.4.0
f7025000 f7026000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f702e000 f7051000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7059000 f705e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7066000 f7090000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7099000 f70b0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70b8000 f7121000 r-xp /lib/libm-2.13.so
f712a000 f71be000 r-xp /usr/lib/libstdc++.so.6.0.16
f71d1000 f71d6000 r-xp /usr/lib/libctx-client.so.0.8.3
f71de000 f71e5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71ed000 f7217000 r-xp /usr/lib/libsensor.so.1.9.6
f7220000 f72ec000 r-xp /usr/lib/libxml2.so.2.7.8
f72f9000 f72fb000 r-xp /usr/lib/libiniparser.so.0
f7304000 f730a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7313000 f73e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73e4000 f7418000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7421000 f745d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7465000 f7468000 r-xp /usr/lib/libbundle.so.0.1.22
f7470000 f7476000 r-xp /usr/lib/libappsvc.so.0.1.0
f747e000 f74bf000 r-xp /usr/lib/libeina.so.1.7.99
f74c8000 f74df000 r-xp /usr/lib/libecore.so.1.7.99
f74f6000 f74ff000 r-xp /usr/lib/libvconf.so.0.2.45
f7507000 f751b000 r-xp /lib/libpthread-2.13.so
f7526000 f7533000 r-xp /usr/lib/libaul.so.0.1.0
f753d000 f753f000 r-xp /lib/libdl-2.13.so
f7548000 f7553000 r-xp /lib/libunwind.so.8.0.1
f7580000 f7588000 r-xp /lib/libgcc_s-4.6.so.1
f7589000 f76ad000 r-xp /lib/libc-2.13.so
f76bb000 f76bd000 r-xp /usr/lib/libdlog.so.0.0.0
f76c5000 f76d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76da000 f76df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76e7000 f76f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76fe000 f7702000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f770b000 f770e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7716000 f7718000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7720000 f7724000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f772c000 f7749000 r-xp /lib/ld-2.13.so
f7752000 f7755000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7755000 f7759000 r-xp /usr/lib/libsys-assert.so
f77c6000 f7828000 rw-p [heap]
fff89000 fffaa000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28580)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf77532b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf76ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73f13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7401be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7401dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf743675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7401be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7401dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7433e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7434017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf743bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4dd31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dc6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e99663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7346fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74d8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74d3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74d45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74d4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf770c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf770c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77536c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf75a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7752fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
ORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 16:59:22.671+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 102 ms (from 9458230 to 9458332) (logOverhead=0,0,0,0,0,0,0), start: 16:59:22.575
04-23 16:59:22.671+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 103 ms (from 9458229 to 9458332) (logOverhead=0,0,0,0,0,0,0), start: 16:59:22.574
04-23 16:59:22.671+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:59:22.681+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 16:59:22.691+0200 W/gpsd    ( 3104): ProcessEvent(fd14, bRead=1, bWrite=0, bError=0), handler=IpcInterface
04-23 16:59:22.691+0200 W/gpsd_d  ( 3104): BrcmGpsLhdHal::OnIpcMessage [18]( A5 93 02 80 0C 00 FB 58 03 00 0B E0 01 8E 5E 03 A5 68)
04-23 16:59:22.691+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 16:59:25.401+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 16:59:39.091+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-23 16:59:39.091+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 16:59:39.091+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.091+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.091+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 16:59:39.091+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -136540160[0;m
04-23 16:59:39.091+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-23 16:59:39.091+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 16:59:39.101+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [9474.765129] dpms[3 -> 0]sync[0]
04-23 16:59:39.101+0200 I/TDM     ( 1785): 
04-23 16:59:39.101+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [9474.765304] dpms[0 -> 0]done
04-23 16:59:39.101+0200 I/TDM     ( 1785): 
04-23 16:59:39.121+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-23 16:59:39.121+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 16:59:39.121+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 16:59:39.141+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-23 16:59:39.141+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-23 16:59:39.141+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.141+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.141+0200 I/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(591) > set force update!!
04-23 16:59:39.141+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): gesture.c: _apps_status_get(128) > apps status:0
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:1 info->offtime:18882
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-23 16:59:39.141+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.151+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [18882]ms
04-23 16:59:39.151+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-23 16:59:39.151+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: RESUME State: PAUSED
04-23 16:59:39.151+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-23 16:59:39.151+0200 W/W_HOME  ( 2775): main.c: _appcore_resume_cb(479) > appcore resume
04-23 16:59:39.151+0200 W/W_HOME  ( 2775): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-23 16:59:39.151+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.161+0200 W/W_HOME  ( 2775): main.c: home_resume(527) > journal_multimedia_screen_loaded_home called
04-23 16:59:39.161+0200 W/W_HOME  ( 2775): main.c: home_resume(531) > clock/widget resumed
04-23 16:59:39.161+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [9474.833008] layer(0x5ac2c0) not usable
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [9474.833059] layer(0x5ac2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [9474.833085] layer[0x5abe10]zpos[1]
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [9474.833168] layer(0x5ac250) not usable
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [9474.833186] layer(0x5ac250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [9474.833207] layer[0x5abcf0]zpos[0]
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [9474.833243] layer(0x5ac310) not usable
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [9474.833259] layer(0x5ac310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:59:39.171+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [9474.833280] layer[0x5abf30]zpos[2]
04-23 16:59:39.171+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_resume(1124) > widget_resume
04-23 16:59:39.171+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(fg) type(watchapp)
04-23 16:59:39.171+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppResume(560) > 
04-23 16:59:39.171+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.171+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 1
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(47), length(2)
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 47%
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 47, isCharging: 0
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_50
04-23 16:59:39.191+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-23 16:59:39.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.201+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-23 16:59:39.201+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-23 16:59:39.211+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 16:59:39.211+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:59:39.211+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:59:39.221+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:59:39.221+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 16:59:39.221+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 16:59:39.221+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:59:39.221+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 16:59:39.221+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 16:59:39.221+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -145282292[0;m
04-23 16:59:39.221+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-23 16:59:39.221+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-23 16:59:39.221+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-23 16:59:39.231+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-23 16:59:39.231+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:59:39.231+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:59:39.231+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 16:59:39.241+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:59:39.241+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 16:59:39.241+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 16:59:39.241+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:59:39.241+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 16:59:39.241+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 16:59:39.351+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 16:59:39.351+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 0
04-23 16:59:39.351+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 16:59:39.361+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 16:59:39.361+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 16:59:39.381+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 16:59:39.381+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 16:59:39.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.401+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:59:39.571+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
04-23 16:59:39.571+0200 I/WATCH_CORE( 2864): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-23 16:59:39.571+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.571+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [9475.377014] layer(0x5ac2c0) now usable
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [9475.377064] layer[0x5abe10]zpos[1]
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [9475.377107] layer(0x5ac310) now usable
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [9475.377127] layer[0x5abf30]zpos[2]
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [9475.377172] layer(0x5ac250) now usable
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [9475.377190] layer[0x5abcf0]zpos[0]
04-23 16:59:39.711+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [9475.377356] dpms[0 -> 3]sync[1]
04-23 16:59:39.711+0200 I/TDM     ( 1785): 
04-23 16:59:39.741+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 16:59:39.741+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.741+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 16:59:39.741+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 16:59:39.741+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 16:59:39.741+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 16:59:39.741+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 16:59:39.741+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 16:59:39.751+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 16:59:39.751+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:59:39.751+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 16:59:39.751+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 16:59:39.751+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 16:59:39.751+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 16:59:39.751+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 16:59:39.751+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 16:59:39.771+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 16:59:39.771+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 16:59:39.771+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 16:59:39.771+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 16:59:39.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:59:39.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:59:39.871+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [9475.531203] dpms[3 -> 3]done
04-23 16:59:39.871+0200 I/TDM     ( 1785): 
04-23 16:59:39.871+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 16:59:39.881+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 16:59:39.891+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 16:59:39.891+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 16:59:39.891+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 16:59:39.891+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 16:59:39.901+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 16:59:39.901+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 16:59:39.901+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:59:39.901+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:59:39.911+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:59:39.911+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:59:39.911+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 16:59:39.911+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 16:59:39.911+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 16:59:39.911+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 16:59:39.921+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 16:59:39.931+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 16:59:39.931+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 16:59:40.411+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 16:59:44.921+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:00:00.361+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 17:00:00.361+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:00:00.361+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:00:00.361+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:00:00.381+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 28580
04-23 17:00:00.381+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:00:00.431+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 28580
04-23 17:00:00.431+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(28580) type(svcapp) bg(0)
04-23 17:00:00.441+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [28580]
04-23 17:00:00.451+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28580)
04-23 17:00:00.451+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 17:00:00.451+0200 I/servicemanager(26979): App control destroyed.
04-23 17:00:00.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:00:00.481+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28580
04-23 17:00:00.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:00:00.491+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:00:00.501+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 28580
04-23 17:00:00.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:00:00.511+0200 E/CAPI_APPFW_APPLICATION(28580): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:00:00.511+0200 E/CAPI_APPFW_APPLICATION(28580): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:00:00.511+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (28580) was created
04-23 17:00:00.531+0200 W/LOCATION(28580): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:00:00.531+0200 E/LOCATION(28580): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:00:00.531+0200 E/PKGMGR_INFO(28580): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:00:00.541+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:00.561+0200 I/LOCATION(28580): location.c: location_new(269) > method: 0
04-23 17:00:00.561+0200 W/LOCATION(28580): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:00.561+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:00.571+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:00.571+0200 W/LOCATION(28580): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:00.571+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:00.581+0200 W/LOCATION(28580): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:00.581+0200 W/LOCATION(28580): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:00.581+0200 W/LOCATION(28580): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:00.581+0200 W/LOCATION(28580): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:00.601+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:00:00.601+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:00:00.601+0200 W/LOCATION(28580): module-internal.c: module_new(311) > module (wps) open success
04-23 17:00:00.611+0200 W/LOCATION(28580): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:00:00.611+0200 W/LOCATION(28580): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:00:00.611+0200 W/LOCATION(28580): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:00:00.611+0200 W/LOCATION(28580): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:00:00.631+0200 W/LOCATION(28580): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:00:00.631+0200 I/LOCATION(28580): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf77f6c18
04-23 17:00:00.631+0200 I/LOCATION(28580): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:00:00.631+0200 I/LOCATION(28580): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf77f6c18
04-23 17:00:00.631+0200 I/LOCATION(28580): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:00:00.631+0200 I/location(28580): es.ugr.frailty.location: creado servicio de localización
04-23 17:00:00.691+0200 I/LOCATION(28580): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:00:00.741+0200 W/LOCATION(28580): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:00.741+0200 W/LOCATION(28580): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:00.741+0200 I/LOCATION(28580): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:00:00.831+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:00:00.831+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:00:00.831+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:00.831+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:00.841+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:00:00.841+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:00:00.841+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:00:00.841+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:00:00.861+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:00:00.871+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:00:00.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:00:00.871+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:00:00.871+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:00:00.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:00:00.891+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:00:00.901+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:00:00.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:00:00.901+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:00:00.911+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:00:00.921+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:00:00.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:00:00.921+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:00:00.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:00:00.921+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:00:00.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:00:00.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:00:00.961+0200 W/LOCATION(28580): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:00:00.961+0200 W/LOCATION(28580): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:00:01.041+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:01.081+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_create(453) > New handle created[0xf4204400]
04-23 17:00:01.081+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:00:01.081+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:00:01.081+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:00:01.081+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:00:01.091+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:01.091+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:01.101+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:01.111+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:01.111+0200 E/LOCATION(28530): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:00:01.111+0200 I/LOCATION(28530): location.c: location_new(269) > method: 1
04-23 17:00:01.111+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:00:01.111+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (gps) open success
04-23 17:00:01.111+0200 W/LOCATION(28530): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:00:01.111+0200 W/LOCATION(28530): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:00:01.111+0200 W/LOCATION(28530): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:00:01.111+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:00:01.111+0200 W/LOCATION(28530): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:00:01.121+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:01.131+0200 I/AUL     (28530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:00:01.131+0200 E/LOCATION(28530): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:00:01.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:01.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:01.191+0200 W/LOCATION(28580): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:00:01.191+0200 I/LOCATION(28580): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:00:01.191+0200 I/LOCATION(28580): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:00:01.191+0200 I/location(28580): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:00:01.221+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 9496588 to 9496889) (logOverhead=0,0,0,0,0,0,0), start: 17:00:00.933
04-23 17:00:01.231+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 307 ms (from 9496585 to 9496892) (logOverhead=0,0,0,0,0,0,0), start: 17:00:00.930
04-23 17:00:01.231+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 307 ms (from 9496585 to 9496892) (logOverhead=0,0,0,0,0,0,0), start: 17:00:00.930
04-23 17:00:01.291+0200 I/LOCATION(28580): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:00:01.331+0200 E/location(28580): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:00:01.331+0200 W/AUL     (28580): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:00:01.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:00:01.331+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 28580
04-23 17:00:01.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:00:01.341+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.341+0200 I/utils   (26979): specific action
04-23 17:00:01.341+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.341+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.341+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.341+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:00:01.341+0200 W/AUL     (28580): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:00:01.341+0200 I/location(28580): request sent to service es.ugr.frailty.servicemanager
04-23 17:00:01.341+0200 W/CAPI_APPFW_APP_CONTROL(28580): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.341+0200 I/utils   (28580): specific action
04-23 17:00:01.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:00:01.351+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:00:01.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 28352
04-23 17:00:01.361+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.361+0200 I/utils   (28352): specific action
04-23 17:00:01.361+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.361+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.361+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.361+0200 W/CAPI_APPFW_APP_CONTROL(28352): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:00:01.361+0200 I/recorder(28352): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:00:01.361+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:00:01.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:00:01.361+0200 I/recorder(28352): guardando datos en local
04-23 17:00:01.361+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:00:01.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(17), pid(28352), cmd(0)
04-23 17:00:01.361+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(28352)
04-23 17:00:01.361+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:00:01.361+0200 I/servicemanager(26979): requesting to save local data
04-23 17:00:01.541+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:00:01.541+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(9497201), time2(9431782)
04-23 17:00:01.541+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:00:01.541+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:00:01.541+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:00:01.541+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:00:02.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 149 ms (from 9497565 to 9497714) (logOverhead=0,0,0,0,0,0,0), start: 17:00:01.910
04-23 17:00:02.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 149 ms (from 9497565 to 9497714) (logOverhead=0,0,0,0,0,0,0), start: 17:00:01.910
04-23 17:00:02.091+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:00:02.101+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:02.101+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:00:02.171+0200 E/CAPI_TELEPHONY(28530): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:00:02.901+0200 W/LOCATION(28580): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:00:02.931+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:00:02.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:02.931+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:00:03.141+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:00:03.141+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:00:03.141+0200 E/CAPI_LOCATION_MANAGER(28530): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:00:03.141+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:00:03.151+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:00:03.171+0200 W/AUL     (28595): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:00:03.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:00:03.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:00:03.171+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 28503
04-23 17:00:03.171+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:00:03.171+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 28503
04-23 17:00:03.171+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(28503)
04-23 17:00:03.241+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:00:03.241+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:00:03.241+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:00:03.241+0200 I/CAPI_NETWORK_CONNECTION(28530): connection.c: connection_destroy(471) > Destroy handle: 0xf4204400
04-23 17:00:03.261+0200 W/CRASH_MANAGER(28593): worker.c: worker_job(1205) > 11285806c6f63152449560
