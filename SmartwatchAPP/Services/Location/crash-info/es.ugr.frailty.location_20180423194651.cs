S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21744
Date: 2018-04-23 19:46:51+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72d452d, r5   = 0xf7951f98
r6   = 0xff946f28, r7   = 0xff946dd8
r8   = 0xf794ec18, r9   = 0x00000000
r10  = 0xff946eb4, fp   = 0xff946f28
ip   = 0x00000001, sp   = 0xff946db0
lr   = 0xf72d4539, pc   = 0xf733d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      7168 KB
Buffers:     57496 KB
Cached:     233992 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11664 KB
VmRSS:       11660 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21744 TID = 21744
21744 21773 

Maps Information
f419f000 f499e000 rw-p [stack:21773]
f49a5000 f49a7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49af000 f49b3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49bc000 f49be000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49c6000 f49c9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49d8000 f49dd000 r-xp /usr/lib/libsystem.so.0.0.0
f49e8000 f49eb000 r-xp /lib/libattr.so.1.1.0
f49f3000 f4a03000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a0b000 f4a14000 r-xp /usr/lib/libedbus.so.1.7.99
f4a1c000 f4a1d000 r-xp /usr/lib/libresponse.so.0.2.96
f4a26000 f4a2b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62cd000 f63d3000 r-xp /usr/lib/libicuuc.so.57.1
f63e9000 f6571000 r-xp /usr/lib/libicui18n.so.57.1
f6581000 f658e000 r-xp /usr/lib/libail.so.0.1.0
f6597000 f659e000 r-xp /usr/lib/libminizip.so.1.0.0
f65a7000 f6750000 r-xp /usr/lib/libcrypto.so.1.0.0
f6770000 f67b7000 r-xp /usr/lib/libssl.so.1.0.0
f67c3000 f67c5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67cd000 f67d4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67dd000 f67e4000 r-xp /lib/libcrypt-2.13.so
f6815000 f6818000 r-xp /lib/libcap.so.2.21
f6820000 f6822000 r-xp /usr/lib/libiri.so
f682a000 f6873000 r-xp /usr/lib/libmdm.so.1.2.69
f687b000 f6881000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6889000 f68ac000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68b6000 f68b8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68c0000 f68dd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68e6000 f68ea000 r-xp /usr/lib/libsmack.so.1.0.0
f68f3000 f690c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6915000 f691d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6925000 f692b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6934000 f6936000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f693f000 f694f000 r-xp /lib/libresolv-2.13.so
f6953000 f696b000 r-xp /usr/lib/liblzma.so.5.0.3
f6974000 f6976000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f697e000 f6998000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69a0000 f69cf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69d8000 f69e7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69f1000 f69fb000 r-xp /usr/lib/libsensord-shared.so
f6a04000 f6ad7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ae2000 f6af8000 r-xp /lib/libz.so.1.2.5
f6b00000 f6b05000 r-xp /usr/lib/libffi.so.5.0.10
f6b0d000 f6b0e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b16000 f6b26000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b2e000 f6b47000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b4f000 f6b51000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b59000 f6bce000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6bd8000 f6bde000 r-xp /lib/librt-2.13.so
f6be7000 f6c05000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c0f000 f6c10000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c18000 f6c3b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c43000 f6c48000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c50000 f6c7a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c83000 f6c9a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ca2000 f6d0b000 r-xp /lib/libm-2.13.so
f6d14000 f6da8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6dbb000 f6dc0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dc8000 f6dcf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6dd7000 f6e01000 r-xp /usr/lib/libsensor.so.1.9.6
f6e0a000 f6ed6000 r-xp /usr/lib/libxml2.so.2.7.8
f6ee3000 f6ee5000 r-xp /usr/lib/libiniparser.so.0
f6eee000 f6ef4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6efd000 f6fcd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fce000 f7002000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f700b000 f7047000 r-xp /usr/lib/libSLP-location.so.0.9.24
f704f000 f7052000 r-xp /usr/lib/libbundle.so.0.1.22
f705a000 f7060000 r-xp /usr/lib/libappsvc.so.0.1.0
f7068000 f70a9000 r-xp /usr/lib/libeina.so.1.7.99
f70b2000 f70c9000 r-xp /usr/lib/libecore.so.1.7.99
f70e0000 f70e9000 r-xp /usr/lib/libvconf.so.0.2.45
f70f1000 f7105000 r-xp /lib/libpthread-2.13.so
f7110000 f711d000 r-xp /usr/lib/libaul.so.0.1.0
f7127000 f7129000 r-xp /lib/libdl-2.13.so
f7132000 f713d000 r-xp /lib/libunwind.so.8.0.1
f716a000 f7172000 r-xp /lib/libgcc_s-4.6.so.1
f7173000 f7297000 r-xp /lib/libc-2.13.so
f72a5000 f72a7000 r-xp /usr/lib/libdlog.so.0.0.0
f72af000 f72bb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72c4000 f72c9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72d1000 f72e0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72e8000 f72ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72f5000 f72f8000 r-xp /usr/lib/libappcore-agent.so.1.1
f7300000 f7302000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f730a000 f730e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7316000 f7333000 r-xp /lib/ld-2.13.so
f733c000 f733f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f733f000 f7343000 r-xp /usr/lib/libsys-assert.so
f791e000 f79ac000 rw-p [heap]
ff928000 ff949000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21744)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf733d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72d4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fdb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fd9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fe5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6febbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6febdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf702075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf701b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fd9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fe5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6febbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6febdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf701de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf701e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70228d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf730c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf49b0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a83663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f30fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f327a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70c2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70bdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70be5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70be879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72f6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72f67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf733d4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf718a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf733cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:50.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:50.399+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 19:46:50.399+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 19:46:50.399+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-23 19:46:50.399+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:50.419+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:50:412,82
04-23 19:46:50.419+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
04-23 19:46:50.419+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_enable(138) > 0
04-23 19:46:50.419+0200 W/W_HOME  ( 2773): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 19:46:50.419+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:292,-2.105684,0.887737,10.147961
04-23 19:46:50.429+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:282,-0.484867,9.286848,5.352308
04-23 19:46:50.429+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-23 19:46:50.429+0200 W/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 19:46:50.429+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-23 19:46:50.429+0200 I/HIGEAR  ( 3256): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-23 19:46:50.439+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:294,82.040001,10.010000,-36.259998
04-23 19:46:50.449+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.459+0200 W/SHealthCommon( 2923): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 19:46:50.459+0200 I/watchface-viewer( 2849): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-23 19:46:50.469+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-23 19:46:50.469+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-23 19:46:50.489+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.489+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:494,-1.711272,-3.252053,9.092089
04-23 19:46:50.489+0200 W/SHealthService( 3098): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 19:46:50.519+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.519+0200 W/SHealthService( 3098): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 19:46:50.519+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.529+0200 W/SHealthCommon( 3098): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:1[0;m
04-23 19:46:50.539+0200 W/SHealthService( 3098): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 19:46:50.539+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:525,3.370491,4.955425,1.524638
04-23 19:46:50.539+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.539+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:546,0.962318,4.374287,1.218584
04-23 19:46:50.549+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:539,0.311067,0.531207,9.724431
04-23 19:46:50.549+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.549+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:554,-0.748954,1.122234,10.310673
04-23 19:46:50.549+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:459,20.860001,-16.730000,-6.510000
04-23 19:46:50.589+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:50.589+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:50.599+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.599+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.599+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:605,-0.705883,1.703690,9.659825
04-23 19:46:50.599+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:50.609+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:50:612,82
04-23 19:46:50.609+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:605,1.005389,4.955743,0.567737
04-23 19:46:50.639+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.639+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.649+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:646,-0.928427,-0.499204,9.749831
04-23 19:46:50.669+0200 I/LOCATION(21744): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:46:50.679+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:649,10.010000,-30.100000,19.740000
04-23 19:46:50.699+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.719+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:706,-1.179662,-1.251446,16.060625
04-23 19:46:50.719+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.739+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:733,-0.251235,-0.752242,6.310794
04-23 19:46:50.749+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:46:50.749+0200 W/libgps_d( 3158): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 19:46:50.759+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 19:46:50.759+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:46:50.759+0200 E/CAPI_LOCATION_MANAGER(21673): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:46:50.769+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:46:50.779+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:46:50.779+0200 E/LOCATION(21673): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:46:50.779+0200 I/LOCATION(21673): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:46:50.779+0200 I/LOCATION(21673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:46:50.789+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:50.789+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:50.799+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.799+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:807,-0.786645,-0.469409,9.763771
04-23 19:46:50.799+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.799+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.799+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:50.809+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:811,-0.704798,-0.373221,9.774167
04-23 19:46:50.809+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.809+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:815,-0.559961,-0.241243,9.787678
04-23 19:46:50.819+0200 E/location(21744): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:46:50.819+0200 W/AUL     (21744): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:46:50.819+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:50:813,82
04-23 19:46:50.819+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.819+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:46:50.819+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21744
04-23 19:46:50.829+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21592
04-23 19:46:50.829+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:811,-1.339981,2.608176,9.784252
04-23 19:46:50.829+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:46:50.829+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21592), cmd(0)
04-23 19:46:50.829+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.829+0200 I/utils   (21592): specific action
04-23 19:46:50.829+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.829+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.829+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.829+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:46:50.829+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:46:50.829+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:46:50.839+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.839+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21598
04-23 19:46:50.849+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.849+0200 I/utils   (21598): specific action
04-23 19:46:50.849+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.849+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.849+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.849+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.849+0200 I/recorder(21598): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:46:50.849+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21598)
04-23 19:46:50.849+0200 I/servicemanager(21592): request sent to service es.ugr.frailty.recorder
04-23 19:46:50.849+0200 I/servicemanager(21592): requesting to save local data
04-23 19:46:50.849+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.849+0200 I/recorder(21598): guardando datos en local
04-23 19:46:50.849+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:46:50.849+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21598), cmd(0)
04-23 19:46:50.859+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:826,-2.030000,-12.250000,29.190001
04-23 19:46:50.859+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.859+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.869+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:870,-21.770000,-36.750000,22.610001
04-23 19:46:50.869+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.869+0200 W/AUL     (21744): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21592)
04-23 19:46:50.869+0200 I/location(21744): request sent to service es.ugr.frailty.servicemanager
04-23 19:46:50.869+0200 W/CAPI_APPFW_APP_CONTROL(21744): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:46:50.869+0200 I/utils   (21744): specific action
04-23 19:46:50.879+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:868,-1.405758,-0.343740,9.699282
04-23 19:46:50.879+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.879+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:888,-1.467855,-0.280185,9.692124
04-23 19:46:50.879+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.899+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:860,-0.411554,3.107380,0.034421
04-23 19:46:50.899+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.899+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:847,-0.315853,1.875973,10.068997
04-23 19:46:50.909+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.919+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:913,0.007178,1.976472,8.719445
04-23 19:46:50.919+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.919+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:877,6.860000,-35.910000,15.540000
04-23 19:46:50.919+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.929+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:910,0.470793,2.345382,0.305226
04-23 19:46:50.929+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.929+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:924,1.103091,2.517249,8.099705
04-23 19:46:50.929+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:930,41.090000,-30.590000,11.760000
04-23 19:46:50.929+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.929+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.939+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:941,13.230000,-9.380000,22.960001
04-23 19:46:50.939+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.939+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:945,-23.240000,-7.770000,27.860001
04-23 19:46:50.939+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.939+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:936,0.711977,2.349692,-1.054722
04-23 19:46:50.939+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.949+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:950,-30.940001,-8.120000,28.210001
04-23 19:46:50.949+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.959+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:962,-22.960001,-6.860000,38.920002
04-23 19:46:50.959+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:891,-1.359033,-0.229412,9.709314
04-23 19:46:50.959+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.959+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.969+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:970,-12.110000,-9.590000,25.760000
04-23 19:46:50.969+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.969+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:970,-1.220141,-0.179194,9.728799
04-23 19:46:50.969+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.969+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:975,-0.840000,-14.910000,18.549999
04-23 19:46:50.969+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.969+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:951,1.663052,2.758492,-1.687973
04-23 19:46:50.969+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.979+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:940,0.803988,2.572284,8.245667
04-23 19:46:50.979+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.979+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:981,2.030000,-14.070000,19.250000
04-23 19:46:50.979+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:986,-0.107677,1.253839,10.358529
04-23 19:46:50.979+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:50.979+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.989+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:981,2.209746,2.916024,-1.453615
04-23 19:46:50.989+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:50.989+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:50:991,-6.090000,-8.120000,17.500000
04-23 19:46:50.989+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:50:976,-1.032216,-0.145330,9.751092
04-23 19:46:50.989+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.989+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:50.989+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:50.999+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:1,-1.043941,-0.090040,9.750511
04-23 19:46:50.999+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:50.999+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.999+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:6,2.520000,-0.980000,15.120000
04-23 19:46:50.999+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:7,-1.217039,-0.042474,9.730745
04-23 19:46:50.999+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:50.999+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:51.009+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:50:990,0.636491,1.256232,11.018949
04-23 19:46:51.009+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.009+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:51:12,83
04-23 19:46:51.009+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:14,1.280160,2.457429,10.229317
04-23 19:46:51.009+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.009+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:11,-1.342542,-0.015482,9.714305
04-23 19:46:51.009+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:17,1.026521,2.170290,9.075976
04-23 19:46:51.009+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.009+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.019+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:21,-1.559551,0.019520,9.681828
04-23 19:46:51.019+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.019+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:25,-1.804026,0.034391,9.639227
04-23 19:46:51.019+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.029+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.029+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:32,10.080000,-2.730000,13.020000
04-23 19:46:51.029+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:50:995,1.360178,1.534024,0.666405
04-23 19:46:51.029+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.029+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:36,-2.271010,0.062741,9.539862
04-23 19:46:51.029+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:38,1.995523,1.485644,1.309634
04-23 19:46:51.029+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.039+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.039+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.039+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:48,-2.993400,0.086575,9.338225
04-23 19:46:51.039+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:48,5.880000,-1.960000,18.129999
04-23 19:46:51.039+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:42,2.500301,2.636623,0.500518
04-23 19:46:51.039+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.049+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:52,2.058737,2.315620,-0.675116
04-23 19:46:51.049+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.049+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:56,2.022606,1.949263,-1.289491
04-23 19:46:51.049+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.059+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.059+0200 I/LOCATION(21744): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:46:51.059+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.069+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:66,-3.765950,0.126043,9.053845
04-23 19:46:51.069+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:69,-4.620000,-1.890000,24.500000
04-23 19:46:51.069+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:21,0.978664,1.859223,8.461020
04-23 19:46:51.069+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.069+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:76,1.792224,2.007578,8.429914
04-23 19:46:51.069+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.109+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.109+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.139+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:120,-4.440560,0.192884,8.741545
04-23 19:46:51.139+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.139+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:122,-16.660000,4.830000,45.009998
04-23 19:46:51.139+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.139+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:144,-4.200509,0.290127,8.856746
04-23 19:46:51.139+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.149+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:148,-28.070000,3.430000,31.710001
04-23 19:46:51.149+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.149+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:155,-32.340000,-16.170000,5.250000
04-23 19:46:51.149+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.159+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:60,3.009263,2.050052,-1.300832
04-23 19:46:51.159+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.169+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:81,1.919044,1.847259,8.401200
04-23 19:46:51.169+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.169+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:152,-2.714087,0.339404,9.417480
04-23 19:46:51.169+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.179+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:173,2.167897,1.694118,8.956335
04-23 19:46:51.179+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.179+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:184,1.459622,1.655833,9.085547
04-23 19:46:51.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:51.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.219+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:46:51.229+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.229+0200 E/CAPI_APPFW_APP_CONTROL( 3301): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 19:46:51.229+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3301]   [com.samsung.w-home]register msg port [true][0m
04-23 19:46:51.229+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:46:51.239+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2773
04-23 19:46:51.239+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3301]   [MUSIC_PLAYER_EVENT][0m
04-23 19:46:51.239+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 19:46:51.239+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 19:46:51.239+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: preference_get_int(1132) > preference_get_int(3301) : key(music-control-service_native/playing_diration) error
04-23 19:46:51.239+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3301]   preference_get_int() .. [0xfef00030][0m
04-23 19:46:51.239+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_add_data(64) > [31m[TID:3301]   bundle_add_str() .. [0xffffffea][0m
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:46:51.249+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.259+0200 W/W_HOME  ( 2773): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 19:46:51.259+0200 E/W_HOME  ( 2773): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 19:46:51.259+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3301]   [MUSIC_PLAYER_EVENT][0m
04-23 19:46:51.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
04-23 19:46:51.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
04-23 19:46:51.259+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3301): preference.c: preference_get_int(1132) > preference_get_int(3301) : key(music-control-service_native/playing_diration) error
04-23 19:46:51.259+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-info.c: music_control_info_get_player_position(603) > [31m[TID:3301]   preference_get_int() .. [0xfef00030][0m
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:46:51.259+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.259+0200 W/W_HOME  ( 2773): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
04-23 19:46:51.259+0200 E/W_HOME  ( 2773): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
04-23 19:46:51.269+0200 I/TIZEN_N_SOUND_MANAGER( 3301): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
04-23 19:46:51.269+0200 W/TIZEN_N_SOUND_MANAGER( 3301): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:46:51.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:46:51.279+0200 E/CAPI_TELEPHONY(21673): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:46:51.289+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:51.299+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:51:296,84
04-23 19:46:51.299+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:159,-16.660000,-20.440001,-14.280000
04-23 19:46:51.299+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.309+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:171,3.261586,1.862741,-1.313105
04-23 19:46:51.309+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.319+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:176,-1.529890,0.339433,9.680631
04-23 19:46:51.339+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.339+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.339+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:316,3.727448,1.674599,-0.725493
04-23 19:46:51.339+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.349+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:312,-21.280001,0.210000,11.970000
04-23 19:46:51.349+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.359+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:344,-1.018254,0.289884,9.749333
04-23 19:46:51.359+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:350,1.911865,2.050649,9.449257
04-23 19:46:51.359+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.369+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.369+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:352,3.263647,1.621442,-0.553679
04-23 19:46:51.369+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.379+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:373,-0.567128,0.269297,9.786533
04-23 19:46:51.379+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.379+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:360,-20.650000,-2.940000,9.730000
04-23 19:46:51.389+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.389+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:46:51.389+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:46:51.389+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:373,1.902294,1.873580,9.190832
04-23 19:46:51.389+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.389+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:376,4.182876,1.987908,-0.090605
04-23 19:46:51.399+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.399+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:396,-0.283597,0.256922,9.799181
04-23 19:46:51.399+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.399+0200 I/heartrate(21618): capturing data from es.ugr.frailty.heartrate
04-23 19:46:51.409+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:398,-11.760000,-1.680000,15.260000
04-23 19:46:51.409+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.409+0200 I/heartrate(21618): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:46:51:413,84
04-23 19:46:51.409+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:401,3.050849,2.462214,9.272188
04-23 19:46:51.409+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.419+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:403,4.895694,1.787005,-0.147393
04-23 19:46:51.419+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.429+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:415,1.890000,3.640000,12.810000
04-23 19:46:51.429+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.429+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:423,-0.267996,0.882952,9.336794
04-23 19:46:51.429+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.429+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:409,-0.163140,0.270946,9.801549
04-23 19:46:51.429+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.429+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:426,6.816799,2.336172,0.218343
04-23 19:46:51.439+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:434,17.710001,20.930000,-8.120000
04-23 19:46:51.439+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.449+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.449+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:441,-0.196556,0.331355,9.799079
04-23 19:46:51.449+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.459+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:456,4.172564,0.690067,0.595249
04-23 19:46:51.459+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.469+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:472,4.537897,0.628717,0.518333
04-23 19:46:51.469+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.469+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:452,0.337388,0.918844,9.375079
04-23 19:46:51.469+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.479+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:482,5.216980,0.050626,1.024798
04-23 19:46:51.479+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.479+0200 I/accelerometer(21717): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:46:51:483,2.502892,0.390030,10.442278
04-23 19:46:51.479+0200 I/accelerometer(21717): capturing data from es.ugr.frailty.accelerometer
04-23 19:46:51.479+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:445,36.750000,15.330000,5.040000
04-23 19:46:51.479+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:488,4.085424,1.182402,0.106014
04-23 19:46:51.479+0200 I/gyroscope(21731): capturing data from es.ugr.frailty.gyroscope
04-23 19:46:51.479+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.489+0200 I/gravity (21760): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:46:51:460,-0.256730,0.433230,9.793712
04-23 19:46:51.489+0200 I/gravity (21760): capturing data from es.ugr.frailty.gravity
04-23 19:46:51.489+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:493,2.719551,0.997454,0.085168
04-23 19:46:51.489+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.489+0200 I/gyroscope(21731): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:46:51:492,57.680000,15.470000,-14.840000
04-23 19:46:51.499+0200 I/linearacceleration(21747): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:46:51:499,2.134427,0.910364,-0.301384
04-23 19:46:51.499+0200 I/linearacceleration(21747): capturing data from es.ugr.frailty.linearacceleration
04-23 19:46:51.499+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11217446c6f63152450561
