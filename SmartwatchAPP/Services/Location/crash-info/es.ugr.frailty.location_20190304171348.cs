S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8394
Date: 2019-03-04 17:13:48+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf762952d, r5   = 0xf7c7f150
r6   = 0xff857500, r7   = 0xff8573b0
r8   = 0xf7c91c18, r9   = 0x00000000
r10  = 0xff85748c, fp   = 0xff857500
ip   = 0x00000001, sp   = 0xff857388
lr   = 0xf7629539, pc   = 0xf76922fc
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     71004 KB
Buffers:     41040 KB
Cached:     178692 KB
VmPeak:      53476 KB
VmSize:      53392 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11860 KB
VmData:      11120 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8394 TID = 8394
8394 8439 

Maps Information
f44f5000 f4cf4000 rw-p [stack:8439]
f4cfb000 f4cfd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d05000 f4d09000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d12000 f4d14000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d1c000 f4d1f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d2e000 f4d33000 r-xp /usr/lib/libsystem.so.0.0.0
f4d3e000 f4d41000 r-xp /lib/libattr.so.1.1.0
f4d49000 f4d59000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d61000 f4d6a000 r-xp /usr/lib/libedbus.so.1.7.99
f4d72000 f4d73000 r-xp /usr/lib/libresponse.so.0.2.96
f4d7c000 f4d81000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6623000 f6729000 r-xp /usr/lib/libicuuc.so.57.1
f673f000 f68c7000 r-xp /usr/lib/libicui18n.so.57.1
f68d7000 f68e4000 r-xp /usr/lib/libail.so.0.1.0
f68ed000 f68f4000 r-xp /usr/lib/libminizip.so.1.0.0
f68fd000 f6aa6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6ac6000 f6b0d000 r-xp /usr/lib/libssl.so.1.0.0
f6b19000 f6b1b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b23000 f6b2a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b33000 f6b3a000 r-xp /lib/libcrypt-2.13.so
f6b6b000 f6b6e000 r-xp /lib/libcap.so.2.21
f6b76000 f6b78000 r-xp /usr/lib/libiri.so
f6b80000 f6bc9000 r-xp /usr/lib/libmdm.so.1.2.69
f6bd1000 f6bd7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6bdf000 f6c02000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c0c000 f6c0e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c16000 f6c33000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c3c000 f6c40000 r-xp /usr/lib/libsmack.so.1.0.0
f6c49000 f6c62000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c6b000 f6c73000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c7b000 f6c81000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c8a000 f6c8c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c95000 f6ca5000 r-xp /lib/libresolv-2.13.so
f6ca9000 f6cc1000 r-xp /usr/lib/liblzma.so.5.0.3
f6cca000 f6ccc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6cd4000 f6cee000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cf6000 f6d25000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d2e000 f6d3d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d46000 f6d50000 r-xp /usr/lib/libsensord-shared.so
f6d59000 f6e2c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e37000 f6e4d000 r-xp /lib/libz.so.1.2.5
f6e55000 f6e5a000 r-xp /usr/lib/libffi.so.5.0.10
f6e62000 f6e63000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e6b000 f6e7b000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e83000 f6e9c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ea4000 f6ea6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eae000 f6f23000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f2d000 f6f4b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f55000 f6f56000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f5e000 f6f81000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f89000 f6f8e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f96000 f6fc0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fc9000 f6fe0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fe8000 f6fee000 r-xp /lib/librt-2.13.so
f6ff7000 f7060000 r-xp /lib/libm-2.13.so
f7069000 f70fd000 r-xp /usr/lib/libstdc++.so.6.0.16
f7110000 f7115000 r-xp /usr/lib/libctx-client.so.0.8.3
f711d000 f7124000 r-xp /usr/lib/libctx-shared.so.0.8.3
f712c000 f7156000 r-xp /usr/lib/libsensor.so.1.9.6
f715f000 f722b000 r-xp /usr/lib/libxml2.so.2.7.8
f7238000 f723a000 r-xp /usr/lib/libiniparser.so.0
f7243000 f7249000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7252000 f7322000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7323000 f7357000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7360000 f739c000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73a4000 f73a7000 r-xp /usr/lib/libbundle.so.0.1.22
f73af000 f73b5000 r-xp /usr/lib/libappsvc.so.0.1.0
f73bd000 f73fe000 r-xp /usr/lib/libeina.so.1.7.99
f7407000 f7410000 r-xp /usr/lib/libvconf.so.0.2.45
f7418000 f742c000 r-xp /lib/libpthread-2.13.so
f7437000 f7444000 r-xp /usr/lib/libaul.so.0.1.0
f744e000 f7450000 r-xp /lib/libdl-2.13.so
f7459000 f7464000 r-xp /lib/libunwind.so.8.0.1
f7491000 f7499000 r-xp /lib/libgcc_s-4.6.so.1
f749a000 f75be000 r-xp /lib/libc-2.13.so
f75cc000 f75e3000 r-xp /usr/lib/libecore.so.1.7.99
f75fa000 f75fc000 r-xp /usr/lib/libdlog.so.0.0.0
f7604000 f7610000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7619000 f761e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7626000 f7635000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f763d000 f7641000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f764a000 f764d000 r-xp /usr/lib/libappcore-agent.so.1.1
f7655000 f7657000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f765f000 f7663000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f766b000 f7688000 r-xp /lib/ld-2.13.so
f7691000 f7694000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7695000 f7699000 r-xp /usr/lib/libsys-assert.so
f7c61000 f7cc2000 rw-p [heap]
ff838000 ff859000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8394)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76922fc) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12fc
 1: (0xf7629539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73303f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf732ec55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf733ae57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7340be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7340dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf737575b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73701f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf732ec55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf733ae57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7340be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7340dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7372e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7373017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf737af93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d131fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d06171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6dd8663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7285fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72877a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf75dcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf75d7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf75d85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf75d8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf764b183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf764b7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76927eb) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x17eb
28: __libc_start_main + 0x114 (0xf74b185c) [/lib/libc.so.6] + 0x1785c
29: (0xf7691fc0) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfc0
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
 for rigth values
03-04 17:13:47.661+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:47.624,0.133008,-2.498643,-0.822309
03-04 17:13:47.661+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:47.661+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:47.671+0100 I/light   ( 8434): es.ugr.frailty.light - capturing data
03-04 17:13:47.681+0100 I/light   ( 8434): es.ugr.frailty.light: SM-R760,04/03/2019,17:13:47.688,73.000000
03-04 17:13:47.681+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:47.701+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:47.646,303.869995,163.520004,85.750000
03-04 17:13:47.701+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:47.711+0100 W/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
03-04 17:13:47.711+0100 I/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
03-04 17:13:47.711+0100 W/W_HOME  ( 2758): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
03-04 17:13:47.711+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_schedule(209) > schedule, manual render
03-04 17:13:47.711+0100 I/TDM     ( 1954): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [6995.189587] dpms[3 -> 0]sync[0]
03-04 17:13:47.711+0100 I/TDM     ( 1954): 
03-04 17:13:47.711+0100 I/TDM     ( 1954): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [6995.189747] dpms[0 -> 0]done
03-04 17:13:47.711+0100 I/TDM     ( 1954): 
03-04 17:13:47.721+0100 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
03-04 17:13:47.721+0100 E/watchface-app( 2849): watchface.cpp: OnAppTimeTick(834) > 
03-04 17:13:47.721+0100 I/watchface-app( 2849): watchface.cpp: OnAppTimeTick(846) > set force update!!
03-04 17:13:47.721+0100 I/watchface-viewer( 2849): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=left ']
03-04 17:13:47.721+0100 I/watchface-viewer( 2849): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 46x41
03-04 17:13:47.721+0100 I/watchface-viewer( 2849): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
03-04 17:13:47.731+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -147037776[0;m
03-04 17:13:47.731+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
03-04 17:13:47.731+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
03-04 17:13:47.731+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
03-04 17:13:47.731+0100 W/wnotibp ( 3624): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
03-04 17:13:47.731+0100 I/wnotibp ( 3624): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
03-04 17:13:47.741+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
03-04 17:13:47.741+0100 W/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
03-04 17:13:47.741+0100 I/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
03-04 17:13:47.741+0100 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
03-04 17:13:47.741+0100 E/watchface-app( 2849): watchface.cpp: OnAppTimeTick(834) > 
03-04 17:13:47.741+0100 I/watchface-app( 2849): watchface.cpp: OnAppTimeTick(846) > set force update!!
03-04 17:13:47.741+0100 I/WATCH_CORE( 2849): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): dbus.c: _dbus_message_recv_cb(186) > LCD on
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_disable_timer_set(167) > timer set
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_disable_timer_del(157) > timer del
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): gesture.c: _apps_status_get(128) > apps status:0
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:1679
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_schedule(209) > schedule, manual render
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): event_manager.c: _lcd_on_cb(721) > lcd state: 1
03-04 17:13:47.741+0100 W/W_HOME  ( 2758): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-04 17:13:47.741+0100 W/STARTER ( 2709): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [1679]ms
03-04 17:13:47.741+0100 W/STARTER ( 2709): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
03-04 17:13:47.741+0100 I/APP_CORE( 3585): appcore-efl.c: __do_app(453) > [APP 3585] Event: RESUME State: PAUSED
03-04 17:13:47.741+0100 I/CAPI_APPFW_APPLICATION( 3585): app_main.c: app_appcore_resume(223) > app_appcore_resume
03-04 17:13:47.751+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
03-04 17:13:47.751+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
03-04 17:13:47.751+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
03-04 17:13:47.751+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
03-04 17:13:47.761+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-04 17:13:47.761+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-04 17:13:47.761+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
03-04 17:13:47.761+0100 I/HIGEAR  ( 3226): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
03-04 17:13:47.761+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -152163572[0;m
03-04 17:13:47.771+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
03-04 17:13:47.771+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
03-04 17:13:47.771+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2709].
03-04 17:13:47.771+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1719464328)
03-04 17:13:47.771+0100 E/ALARM_MANAGER( 2462): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
03-04 17:13:47.771+0100 E/ALARM_MANAGER( 2462): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(885027787) is OVER.
03-04 17:13:47.771+0100 W/W_INDICATOR( 2712): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
03-04 17:13:47.771+0100 W/W_INDICATOR( 2712): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
03-04 17:13:47.781+0100 W/W_HOME  ( 2758): gesture.c: _widget_updated_cb(188) > widget updated
03-04 17:13:47.781+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_disable_timer_del(157) > timer del
03-04 17:13:47.781+0100 W/W_HOME  ( 2758): gesture.c: _manual_render(182) > 
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_display.c: tdm_layer_set_info(1442) > [6995.259388] layer(0x67c2c0) not usable
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_display.c: tdm_layer_set_info(1459) > [6995.259437] layer(0x67c2c0) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_exynos_display.c: exynos_layer_set_info(1578) > [6995.259457] layer[0x67be10]zpos[1]
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_display.c: tdm_layer_set_info(1442) > [6995.259519] layer(0x67c310) not usable
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_display.c: tdm_layer_set_info(1459) > [6995.259534] layer(0x67c310) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
03-04 17:13:47.781+0100 I/TDM     ( 1954): tdm_exynos_display.c: exynos_layer_set_info(1578) > [6995.259551] layer[0x67bf30]zpos[2]
03-04 17:13:47.821+0100 W/W_HOME  ( 2758): gesture.c: _manual_render(182) > 
03-04 17:13:47.831+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
03-04 17:13:47.831+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
03-04 17:13:47.831+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:47.697,-4.374080,1.203590,7.061220
03-04 17:13:47.841+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:47.841+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:47.682,-4.815850,4.183475,7.448256
03-04 17:13:47.841+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:47.701,1.193116,-2.867422,-1.695910
03-04 17:13:47.841+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
03-04 17:13:47.841+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
03-04 17:13:47.841+0100 W/W_HOME  ( 2758): gesture.c: _manual_render_enable(138) > 0
03-04 17:13:47.841+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
03-04 17:13:47.841+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
03-04 17:13:47.851+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:47.851+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:47.851+0100 I/heartrate( 8375): es.ugr.frailty.heartrate - capturing data
03-04 17:13:47.851+0100 I/heartrate( 8375): es.ugr.frailty.heartrate: waiting for rigth values
03-04 17:13:47.901+0100 I/light   ( 8434): es.ugr.frailty.light - capturing data
03-04 17:13:47.951+0100 W/LOCATION( 8394): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
03-04 17:13:47.991+0100 W/SHealthCommon( 2900): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
03-04 17:13:47.991+0100 I/watchface-viewer( 2849): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
03-04 17:13:48.001+0100 W/SHealthCommon( 3161): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
03-04 17:13:48.021+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
03-04 17:13:48.031+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-04 17:13:48.031+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 4-3-2019, 21:47:43 (UTC).
03-04 17:13:48.031+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-04 17:13:48.031+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 17:13:48.031+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 17:13:48.031+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 17:13:48.041+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
03-04 17:13:48.041+0100 E/ALARM_MANAGER( 2462): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[1719464328] is removed.
03-04 17:13:48.041+0100 W/STARTER ( 2709): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
03-04 17:13:48.041+0100 W/STARTER ( 2709): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
03-04 17:13:48.051+0100 W/SHealthService( 3161): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
03-04 17:13:48.051+0100 I/heartrate( 8375): es.ugr.frailty.heartrate - capturing data
03-04 17:13:48.051+0100 I/heartrate( 8375): es.ugr.frailty.heartrate: waiting for rigth values
03-04 17:13:48.061+0100 I/light   ( 8434): es.ugr.frailty.light: SM-R760,04/03/2019,17:13:47.938,286.000000
03-04 17:13:48.061+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-04 17:13:48.061+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-04 17:13:48.061+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
03-04 17:13:48.061+0100 I/HIGEAR  ( 3226): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
03-04 17:13:48.061+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:47.860,3.964521,-2.925134,-1.488831
03-04 17:13:48.061+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:47.719,278.040009,142.589996,107.099998
03-04 17:13:48.061+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.061+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.061+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.72,213.990005,43.820000,94.360001
03-04 17:13:48.061+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.071+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.77,175.070007,19.600000,68.809998
03-04 17:13:48.071+0100 I/light   ( 8434): es.ugr.frailty.light - capturing data
03-04 17:13:48.071+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:47.849,-3.622734,1.316052,5.752346
03-04 17:13:48.071+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.071+0100 I/light   ( 8434): es.ugr.frailty.light: SM-R760,04/03/2019,17:13:48.82,259.000000
03-04 17:13:48.081+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:47.862,-5.122647,4.633610,6.961216
03-04 17:13:48.081+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.081+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.081+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.89,-5.213883,5.108832,6.548713
03-04 17:13:48.081+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.90,244.860001,44.799999,54.040001
03-04 17:13:48.081+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.081+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.091+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.94,275.660004,64.260002,59.010002
03-04 17:13:48.091+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.091+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.85,-1.158126,1.708475,5.472386
03-04 17:13:48.091+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.99,295.820007,56.770000,65.169998
03-04 17:13:48.091+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.091+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.72,5.455558,-2.601154,-1.830067
03-04 17:13:48.091+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.101+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.101+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.105,295.119995,14.700000,54.810001
03-04 17:13:48.101+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.101+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.110,0.241675,2.507678,4.718646
03-04 17:13:48.101+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.101+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.111,290.500000,-18.830000,37.799999
03-04 17:13:48.101+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.111+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.115,245.910004,13.580000,25.690001
03-04 17:13:48.111+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.107,3.862963,-2.513421,0.461650
03-04 17:13:48.111+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.111+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.111+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.121,157.919998,101.500000,19.950001
03-04 17:13:48.111+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.111+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.94,-5.066553,5.528378,6.319609
03-04 17:13:48.111+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.121+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.126,46.900002,99.750000,15.190001
03-04 17:13:48.121+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.121+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.130,-11.970000,43.189999,13.090000
03-04 17:13:48.121+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.113,-1.203590,3.014957,6.781260
03-04 17:13:48.121+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.121+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.131+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.135,-80.849998,17.920000,-0.700000
03-04 17:13:48.131+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.126,-4.954076,5.826283,6.138562
03-04 17:13:48.131+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.131+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.131+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.121,3.611702,-2.828077,-0.618320
03-04 17:13:48.131+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.131+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.140,-152.880005,-3.150000,-13.300000
03-04 17:13:48.131+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.131+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.144,3.512137,-3.516904,-2.506711
03-04 17:13:48.141+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.145,-188.369995,-19.460001,-21.350000
03-04 17:13:48.141+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.141+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.135,-1.342373,2.998207,5.520242
03-04 17:13:48.141+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.141+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.140,-4.904760,6.194472,5.808806
03-04 17:13:48.141+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.150,-228.059998,-40.180000,-26.809999
03-04 17:13:48.141+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.141+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.151+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.158,-267.890015,-49.420002,-39.970001
03-04 17:13:48.151+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.151+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.151+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.162,-317.450012,-91.769997,-51.799999
03-04 17:13:48.151+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.161+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.167,-358.399994,-116.129997,-76.930000
03-04 17:13:48.161+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.161+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.152,-1.392623,2.677568,3.302095
03-04 17:13:48.161+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.156,-4.874950,6.606164,5.363193
03-04 17:13:48.161+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.161+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.171,-349.860016,-61.880001,-98.279999
03-04 17:13:48.161+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.161+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.174,-4.809700,7.128455,4.714053
03-04 17:13:48.171+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.164,4.657204,-4.892903,-5.238766
03-04 17:13:48.171+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.171+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.177,-337.260010,-23.309999,-82.040001
03-04 17:13:48.171+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.171+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.171+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.183,-370.790009,-98.980003,-62.369999
03-04 17:13:48.171+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.171+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.185,-0.217747,1.713261,0.124427
03-04 17:13:48.181+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.188,-316.890015,22.330000,-107.520004
03-04 17:13:48.181+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.181+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.192,-254.800003,68.459999,-113.680000
03-04 17:13:48.181+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.191+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.180,6.211894,-5.977508,-8.193217
03-04 17:13:48.191+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.191+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.196,-309.049988,-69.230003,-66.220001
03-04 17:13:48.191+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.191+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.191+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.191+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.201,-301.769989,-214.550003,-18.270000
03-04 17:13:48.191+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.205,-4.590479,7.692781,3.989861
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.201+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.207,-212.380005,-6.720000,-71.750000
03-04 17:13:48.201+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.211,-4.223731,8.312294,3.039121
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.201+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.212,-165.619995,114.449997,-58.520000
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.215,-3.975916,8.676352,2.254641
03-04 17:13:48.201+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.211+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.200,6.755984,-6.383907,-12.814591
03-04 17:13:48.211+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.211+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.203,1.402194,1.150948,-3.479164
03-04 17:13:48.211+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.211+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.220,5.240680,-6.118075,-16.223576
03-04 17:13:48.211+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.211+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.225,5.921280,-6.549132,-18.580870
03-04 17:13:48.221+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.225,-165.130005,-197.889999,14.490000
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.230,5.657352,-5.626242,-17.979979
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.234,5.920040,-5.735818,-16.413563
03-04 17:13:48.221+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.231+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.221,2.165504,1.308874,-8.824730
03-04 17:13:48.231+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.231+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.238,6.557155,-6.137191,-13.922523
03-04 17:13:48.231+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.231+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.231+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.243,-31.430000,-174.229996,-20.020000
03-04 17:13:48.231+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.244,6.659141,-6.191505,-11.522874
03-04 17:13:48.231+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.241+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.241,1.016950,2.194218,-13.184454
03-04 17:13:48.241+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.241+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.248,6.868871,-6.520001,-9.981754
03-04 17:13:48.241+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.241+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.251,-3.728737,8.942694,1.514968
03-04 17:13:48.241+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.241+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.253,7.531327,-7.681434,-9.546713
03-04 17:13:48.241+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.241+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.255,-3.503289,9.102519,1.020536
03-04 17:13:48.241+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.251+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.258,7.779372,-8.024689,-8.645626
03-04 17:13:48.251+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.251+0100 I/heartrate( 8375): es.ugr.frailty.heartrate - capturing data
03-04 17:13:48.251+0100 I/heartrate( 8375): es.ugr.frailty.heartrate: waiting for rigth values
03-04 17:13:48.251+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.251+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.263,7.641378,-8.766036,-7.350060
03-04 17:13:48.251+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.264,108.779999,-9.030000,-12.810000
03-04 17:13:48.261+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.261+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.250,1.945365,2.127219,-16.326229
03-04 17:13:48.261+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.261+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.269,5.492356,-8.130415,-2.082085
03-04 17:13:48.261+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.261+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.273,1.928615,3.316452,-16.465012
03-04 17:13:48.261+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.271+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.275,3.598038,-7.756536,-1.801208
03-04 17:13:48.271+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.271+0100 I/light   ( 8434): es.ugr.frailty.light - capturing data
03-04 17:13:48.271+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.271+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.283,170.729996,78.889999,24.850000
03-04 17:13:48.271+0100 I/light   ( 8434): es.ugr.frailty.light: SM-R760,04/03/2019,17:13:48.282,105.000000
03-04 17:13:48.281+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.279,1.041024,-8.148714,-1.199455
03-04 17:13:48.281+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.281+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.290,2.287236,-6.713707,3.401462
03-04 17:13:48.281+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.281+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.295,-1.181503,-3.702237,8.739018
03-04 17:13:48.291+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.291+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.258,-3.290952,9.209575,0.723713
03-04 17:13:48.291+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.291+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.291+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.300,-4.243644,-4.071468,6.976556
03-04 17:13:48.291+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.291+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.303,203.979996,58.939999,51.799999
03-04 17:13:48.301+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.305,-4.374514,-4.071898,9.302273
03-04 17:13:48.301+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.277,2.416751,3.366701,-15.393027
03-04 17:13:48.301+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.301+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.301+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.301,-3.141692,9.268675,0.625959
03-04 17:13:48.301+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.301+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.311,2.116262,-2.188555,9.522574
03-04 17:13:48.301+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.301+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.315,-3.073854,9.283711,0.731102
03-04 17:13:48.311+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.316,-0.972686,-0.197199,10.958011
03-04 17:13:48.311+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.311+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.310,3.266203,3.072384,-13.198811
03-04 17:13:48.311+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.311+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.320,-10.126120,-2.334537,16.129702
03-04 17:13:48.311+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.311+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.311+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.325,240.100006,7.770000,60.900002
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.325,-3.680977,-1.639709,19.660618
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.330,-0.753710,0.881667,19.984411
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.334,-4.839318,1.552738,18.176994
03-04 17:13:48.321+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.331+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.322,3.517449,3.077170,-10.896914
03-04 17:13:48.331+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.331+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.338,-3.459391,0.604961,13.558639
03-04 17:13:48.331+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.331+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.331+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.343,268.309998,22.190001,50.189999
03-04 17:13:48.331+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.343,-2.743970,-0.046439,10.818913
03-04 17:13:48.331+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.331+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.341+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.347,-2.870109,9.349232,0.724375
03-04 17:13:48.341+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.341+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.348,1.127052,0.191091,5.627094
03-04 17:13:48.341+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.341+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.352,-2.708981,9.388597,0.828274
03-04 17:13:48.341+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.353,2.521566,-1.227569,0.408486
03-04 17:13:48.351+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.341,3.795017,2.763710,-9.250652
03-04 17:13:48.351+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.351+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.351+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.351+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.364,265.649994,57.540001,36.610001
03-04 17:13:48.361+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.365,3.599987,-1.841332,-3.628521
03-04 17:13:48.361+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.359,4.661219,1.667797,-8.822337
03-04 17:13:48.361+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.361+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.361+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.375,-2.606879,9.395349,1.049758
03-04 17:13:48.371+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.371+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.371,5.070391,1.363909,-7.817351
03-04 17:13:48.371+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.371+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.371+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.371+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.383,274.119995,91.489998,24.150000
03-04 17:13:48.371+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.383,6.184840,-2.637392,-7.307840
03-04 17:13:48.381+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.379,-2.738217,9.269399,1.658555
03-04 17:13:48.381+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.381,5.034499,0.629312,-6.300302
03-04 17:13:48.381+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.381+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.391+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.397,-2.899334,9.015161,2.547769
03-04 17:13:48.391+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.391+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.391+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.391+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.403,7.450641,-3.530164,-9.875047
03-04 17:13:48.391+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.403,254.309998,115.150002,0.980000
03-04 17:13:48.401+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.394,2.754139,1.138984,-0.423530
03-04 17:13:48.401+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.401+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.401,-3.074924,8.624886,3.510922
03-04 17:13:48.401+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.411+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.411,0.698704,1.258625,0.746561
03-04 17:13:48.411+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.417,-3.435791,8.051295,4.420675
03-04 17:13:48.411+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.411+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.411+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.411+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.421+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.425,217.979996,145.740005,-34.020000
03-04 17:13:48.421+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.425,9.107250,-3.927437,-9.711050
03-04 17:13:48.421+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.421,-3.520393,7.391969,5.397778
03-04 17:13:48.421+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.421+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.424,-2.033899,0.476172,2.311467
03-04 17:13:48.421+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.431,-3.736420,6.749036,6.054755
03-04 17:13:48.421+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.431+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.436,-4.019508,6.168011,6.478393
03-04 17:13:48.431+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.431+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.431+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.431+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.431+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.443,174.229996,160.229996,-68.110001
03-04 17:13:48.431+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.443,10.806168,-4.212796,-9.950040
03-04 17:13:48.441+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.440,-3.999413,5.473900,7.086007
03-04 17:13:48.441+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.441+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.450,-3.525821,4.774669,7.806504
03-04 17:13:48.441+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.451+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.451+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.465,107.169998,89.599998,-108.570000
03-04 17:13:48.461+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.441,-1.148555,1.337588,7.822137
03-04 17:13:48.461+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.457,-3.467506,4.291865,8.107199
03-04 17:13:48.461+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.461+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.471+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.471+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.483,31.639999,-40.599998,-147.979996
03-04 17:13:48.471+0100 I/light   ( 8434): es.ugr.frailty.light - capturing data
03-04 17:13:48.481+0100 I/heartrate( 8375): es.ugr.frailty.heartrate - capturing data
03-04 17:13:48.481+0100 I/heartrate( 8375): es.ugr.frailty.heartrate: waiting for rigth values
03-04 17:13:48.481+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.481+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.491,11.074484,-4.446566,-9.841000
03-04 17:13:48.481+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.481+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.476,-4.701896,3.689733,14.136796
03-04 17:13:48.481+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.481+0100 I/light   ( 8434): es.ugr.frailty.light: SM-R760,04/03/2019,17:13:48.487,89.000000
03-04 17:13:48.481+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.479,-3.662595,3.955962,8.191834
03-04 17:13:48.491+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.491+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.495,9.636803,-4.646517,-7.855853
03-04 17:13:48.491+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.491+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.491+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,17:13:48.503,7.493557,-4.861170,-5.067170
03-04 17:13:48.491+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.503,-22.680000,-125.580002,-180.389999
03-04 17:13:48.501+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.498,-7.980063,2.677568,13.031311
03-04 17:13:48.531+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.531+0100 I/linearacceleration( 8395): es.ugr.frailty.linearacceleration - capturing data
03-04 17:13:48.541+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.539,-28.070000,-128.380005,-182.419998
03-04 17:13:48.541+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.501,-3.184876,3.449342,8.609819
03-04 17:13:48.541+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.541+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.541+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.552,-8.394022,2.096112,15.780666
03-04 17:13:48.541+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.551+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,17:13:48.556,-31.430000,-88.340004,-191.380005
03-04 17:13:48.551+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.559,-2.812928,3.192230,8.835581
03-04 17:13:48.551+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer - capturing data
03-04 17:13:48.561+0100 I/gyroscope( 8364): es.ugr.frailty.gyroscope - capturing data
03-04 17:13:48.561+0100 I/gravity ( 8400): es.ugr.frailty.gravity - capturing data
03-04 17:13:48.561+0100 I/accelerometer( 8356): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,17:13:48.568,-1.883151,3.285345,16.608582
03-04 17:13:48.581+0100 I/gravity ( 8400): es.ugr.frailty.gravity: SM-R760,04/03/2019,17:13:48.574,-2.886374,3.352768,8.752038
03-04 17:13:48.581+0100 W/CRASH_MANAGER( 8472): worker.c: worker_job(1205) > 11083946c6f63155171602
