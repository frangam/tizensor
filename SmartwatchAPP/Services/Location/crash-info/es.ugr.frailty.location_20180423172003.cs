S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 29852
Date: 2018-04-23 17:20:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf723852d, r5   = 0xf7a63f98
r6   = 0xff8dac90, r7   = 0xff8dab40
r8   = 0xf7a60c18, r9   = 0x00000000
r10  = 0xff8dac1c, fp   = 0xff8dac90
ip   = 0x00000001, sp   = 0xff8d99c0
lr   = 0xf7238539, pc   = 0xf72a12b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11556 KB
Buffers:     65844 KB
Cached:     224928 KB
VmPeak:      53460 KB
VmSize:      53444 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11852 KB
VmData:      11172 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 29852 TID = 29852
29852 29855 

Maps Information
f4103000 f4902000 rw-p [stack:29855]
f4909000 f490b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4913000 f4917000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4920000 f4922000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f492a000 f492d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f493c000 f4941000 r-xp /usr/lib/libsystem.so.0.0.0
f494c000 f494f000 r-xp /lib/libattr.so.1.1.0
f4957000 f4967000 r-xp /usr/lib/libmdm-common.so.1.1.24
f496f000 f4978000 r-xp /usr/lib/libedbus.so.1.7.99
f4980000 f4981000 r-xp /usr/lib/libresponse.so.0.2.96
f498a000 f498f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6231000 f6337000 r-xp /usr/lib/libicuuc.so.57.1
f634d000 f64d5000 r-xp /usr/lib/libicui18n.so.57.1
f64e5000 f64f2000 r-xp /usr/lib/libail.so.0.1.0
f64fb000 f6502000 r-xp /usr/lib/libminizip.so.1.0.0
f650b000 f66b4000 r-xp /usr/lib/libcrypto.so.1.0.0
f66d4000 f671b000 r-xp /usr/lib/libssl.so.1.0.0
f6727000 f6729000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6731000 f6738000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6741000 f6748000 r-xp /lib/libcrypt-2.13.so
f6779000 f677c000 r-xp /lib/libcap.so.2.21
f6784000 f6786000 r-xp /usr/lib/libiri.so
f678e000 f67d7000 r-xp /usr/lib/libmdm.so.1.2.69
f67df000 f67e5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67ed000 f6810000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f681a000 f681c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6824000 f6841000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f684a000 f684e000 r-xp /usr/lib/libsmack.so.1.0.0
f6857000 f6870000 r-xp /usr/lib/libnetwork.so.0.0.0
f6879000 f6881000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6889000 f688f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6898000 f689a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68a3000 f68b3000 r-xp /lib/libresolv-2.13.so
f68b7000 f68cf000 r-xp /usr/lib/liblzma.so.5.0.3
f68d8000 f68da000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68e2000 f68fc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6904000 f6933000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f693c000 f694b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6955000 f695f000 r-xp /usr/lib/libsensord-shared.so
f6968000 f6a3b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a46000 f6a5c000 r-xp /lib/libz.so.1.2.5
f6a64000 f6a69000 r-xp /usr/lib/libffi.so.5.0.10
f6a71000 f6a72000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a7a000 f6a8a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a92000 f6aab000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ab3000 f6ab5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6abd000 f6b32000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b3c000 f6b42000 r-xp /lib/librt-2.13.so
f6b4b000 f6b69000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b73000 f6b74000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b7c000 f6b9f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ba7000 f6bac000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bb4000 f6bde000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6be7000 f6bfe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c06000 f6c6f000 r-xp /lib/libm-2.13.so
f6c78000 f6d0c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d1f000 f6d24000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d2c000 f6d33000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d3b000 f6d65000 r-xp /usr/lib/libsensor.so.1.9.6
f6d6e000 f6e3a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e47000 f6e49000 r-xp /usr/lib/libiniparser.so.0
f6e52000 f6e58000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e61000 f6f31000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f32000 f6f66000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f6f000 f6fab000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fb3000 f6fb6000 r-xp /usr/lib/libbundle.so.0.1.22
f6fbe000 f6fc4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fcc000 f700d000 r-xp /usr/lib/libeina.so.1.7.99
f7016000 f702d000 r-xp /usr/lib/libecore.so.1.7.99
f7044000 f704d000 r-xp /usr/lib/libvconf.so.0.2.45
f7055000 f7069000 r-xp /lib/libpthread-2.13.so
f7074000 f7081000 r-xp /usr/lib/libaul.so.0.1.0
f708b000 f708d000 r-xp /lib/libdl-2.13.so
f7096000 f70a1000 r-xp /lib/libunwind.so.8.0.1
f70ce000 f70d6000 r-xp /lib/libgcc_s-4.6.so.1
f70d7000 f71fb000 r-xp /lib/libc-2.13.so
f7209000 f720b000 r-xp /usr/lib/libdlog.so.0.0.0
f7213000 f721f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7228000 f722d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7235000 f7244000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f724c000 f7250000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7259000 f725c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7264000 f7266000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f726e000 f7272000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f727a000 f7297000 r-xp /lib/ld-2.13.so
f72a0000 f72a3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72a3000 f72a7000 r-xp /usr/lib/libsys-assert.so
f7a30000 f7aa0000 rw-p [heap]
ff8bc000 ff8dd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29852)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf72a12b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7238539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f3f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f3dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f49e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f4fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f4fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f8475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f7f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f3dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f49e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f4fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f4fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f81e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f82017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f89f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49211fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4914171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69e7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e94fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e967a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7026ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7021b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70225a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7022879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf725a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf725a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72a16c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16c3
28: __libc_start_main + 0x114 (0xf70ee85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72a0fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
rtrate: SM-R760,23/04/2018,17:19:47:609,80
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [10683.400218] layer(0x5ac2c0) now usable
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10683.400271] layer[0x5abe10]zpos[1]
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [10683.400312] layer(0x5ac310) now usable
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10683.400332] layer[0x5abf30]zpos[2]
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_unset_buffer(1602) > [10683.400375] layer(0x5ac250) now usable
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [10683.400394] layer[0x5abcf0]zpos[0]
04-23 17:19:47.741+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [10683.400556] dpms[0 -> 3]sync[1]
04-23 17:19:47.741+0200 I/TDM     ( 1785): 
04-23 17:19:47.751+0200 W/WATCH_CORE( 2864): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 17:19:47.751+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 17:19:47.751+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): gesture.c: _manual_render_enable(138) > 1
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 17:19:47.751+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:19:47.751+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 17:19:47.751+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 17:19:47.751+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 17:19:47.751+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 17:19:47.751+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145282292[0;m
04-23 17:19:47.761+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 17:19:47.761+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 17:19:47.761+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 17:19:47.771+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 17:19:47.771+0200 E/WAKEUP-SERVICE( 3242): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 17:19:47.771+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 17:19:47.771+0200 I/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 17:19:47.771+0200 W/TIZEN_N_SOUND_MANAGER( 3242): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 17:19:47.771+0200 W/WAKEUP-SERVICE( 3242): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 17:19:47.771+0200 I/HIGEAR  ( 3242): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 17:19:47.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 17:19:47.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 17:19:47.801+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:47.801+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:47:809,80
04-23 17:19:47.881+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [10683.541293] dpms[3 -> 3]done
04-23 17:19:47.881+0200 I/TDM     ( 1785): 
04-23 17:19:47.881+0200 W/SHealthCommon( 2916): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:19:47.891+0200 W/SHealthCommon( 3091): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 17:19:47.891+0200 W/SHealthService( 3091): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 17:19:47.891+0200 I/watchface-viewer( 2864): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 17:19:47.911+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 17:19:47.911+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 17:19:47.911+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 17:19:47.911+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 17:19:47.911+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:19:47.921+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: PAUSE State: RUNNING
04-23 17:19:47.921+0200 I/CAPI_APPFW_APPLICATION( 2775): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): main.c: _appcore_pause_cb(488) > appcore pause
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:19:47.921+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 17:19:47.921+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 17:19:47.921+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): main.c: home_pause(547) > clock/widget paused
04-23 17:19:47.921+0200 W/W_HOME  ( 2775): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 17:19:47.921+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 17:19:47.921+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 17:19:47.921+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.w-home]register msg port [false][0m
04-23 17:19:47.931+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 17:19:47.931+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 17:19:47.931+0200 W/WATCH_CORE( 2864): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 17:19:47.931+0200 W/AUL     ( 2864): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2864) status(bg) type(watchapp)
04-23 17:19:47.931+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppPause(552) > 
04-23 17:19:48.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:48.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:48:10,80
04-23 17:19:48.201+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:48.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:48:209,79
04-23 17:19:48.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:48.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:48:410,79
04-23 17:19:48.421+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:19:48.601+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:48.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:48:610,79
04-23 17:19:48.801+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:48.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:48:810,79
04-23 17:19:49.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:49.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:49:11,79
04-23 17:19:49.201+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:49.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:49:209,79
04-23 17:19:49.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:49.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:49:410,79
04-23 17:19:49.601+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:49.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:49:610,79
04-23 17:19:49.801+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:49.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:49:810,78
04-23 17:19:50.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:50.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:50:10,78
04-23 17:19:50.201+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:50.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:50:210,78
04-23 17:19:50.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:50.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:50:410,78
04-23 17:19:50.601+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:50.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:50:611,78
04-23 17:19:50.801+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:50.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:50:811,78
04-23 17:19:51.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:51.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:51:11,78
04-23 17:19:51.201+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:51.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:51:211,78
04-23 17:19:51.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:51.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:51:411,78
04-23 17:19:51.601+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:51.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:51:611,78
04-23 17:19:51.801+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:51.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:51:811,78
04-23 17:19:52.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:52.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:52:11,78
04-23 17:19:52.211+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:52.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:52:212,78
04-23 17:19:52.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:52.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:52:412,78
04-23 17:19:52.611+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:52.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:52:612,78
04-23 17:19:52.811+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:52.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:52:812,77
04-23 17:19:52.941+0200 I/APP_CORE( 2775): appcore-efl.c: __do_app(453) > [APP 2775] Event: MEM_FLUSH State: PAUSED
04-23 17:19:53.001+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:53.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:53:12,77
04-23 17:19:53.211+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:53.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:53:212,77
04-23 17:19:53.411+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:53.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:53:412,77
04-23 17:19:53.611+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:53.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:53:612,77
04-23 17:19:53.811+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:53.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:53:812,77
04-23 17:19:54.011+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:54.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:54:13,77
04-23 17:19:54.211+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:54.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:54:213,77
04-23 17:19:54.411+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:54.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:54:413,76
04-23 17:19:54.611+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:54.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:54:613,76
04-23 17:19:54.811+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:54.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:54:813,77
04-23 17:19:55.011+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:55.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:55:13,77
04-23 17:19:55.201+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:55.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:55:213,76
04-23 17:19:55.411+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:55.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:55:414,76
04-23 17:19:55.611+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:55.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:55:614,76
04-23 17:19:55.811+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:55.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:55:814,76
04-23 17:19:56.011+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:56.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:56:14,76
04-23 17:19:56.211+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:56.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:56:214,76
04-23 17:19:56.401+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:56.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:56:414,77
04-23 17:19:56.611+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:56.611+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:56:615,77
04-23 17:19:56.811+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:56.811+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:56:814,77
04-23 17:19:57.011+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:57.011+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:57:15,77
04-23 17:19:57.211+0200 I/heartrate(29750): capturing data from es.ugr.frailty.heartrate
04-23 17:19:57.211+0200 I/heartrate(29750): es.ugr.frailty.heartrate: SM-R760,23/04/2018,17:19:57:215,77
04-23 17:19:57.221+0200 I/servicemanager(26979): es.ugr.frailty.heartrate sleep timeout
04-23 17:19:57.221+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 17:19:57.221+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:19:57.221+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:19:57.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29750
04-23 17:19:57.241+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29750)
04-23 17:19:57.241+0200 I/servicemanager(26979): es.ugr.frailty.heartrate stop request sent!
04-23 17:19:57.241+0200 I/servicemanager(26979): App control destroyed.
04-23 17:19:57.241+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:19:57.241+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(29750), cmd(0)
04-23 17:19:57.251+0200 I/heartrate(29750): stopping es.ugr.frailty.heartrate service
04-23 17:19:57.251+0200 W/AUL     (29750): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:19:57.251+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:19:57.251+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 29750
04-23 17:19:57.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:19:57.271+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:19:57.271+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:19:57.271+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.271+0200 I/utils   (26979): specific action
04-23 17:19:57.271+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.271+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.271+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:19:57.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:19:57.281+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:19:57.291+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29506
04-23 17:19:57.301+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:19:57.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(29506), cmd(0)
04-23 17:19:57.301+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.301+0200 I/utils   (29506): specific action
04-23 17:19:57.301+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.301+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.301+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:19:57.301+0200 I/recorder(29506): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 17:19:57.301+0200 I/recorder(29506): guardando datos en local
04-23 17:19:57.301+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29506)
04-23 17:19:57.301+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:19:57.301+0200 I/servicemanager(26979): requesting to save local data
04-23 17:19:57.301+0200 W/AUL     (29750): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:19:57.301+0200 I/heartrate(29750): request sent to service es.ugr.frailty.servicemanager
04-23 17:19:57.301+0200 I/CAPI_APPFW_APPLICATION(29750): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 17:19:57.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 17:19:57.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 17:19:57.371+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:19:57.381+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 17:19:57.411+0200 I/heartrate(29750): es.ugr.frailty.heartrate listener destroyed
04-23 17:19:57.531+0200 W/AUL     (29851): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 17:19:57.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:19:57.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:19:57.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29750
04-23 17:19:57.541+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:19:57.571+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29750
04-23 17:19:57.571+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29750)
04-23 17:19:59.311+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 17:20:00.391+0200 I/servicemanager(26979): es.ugr.frailty.location alive timeout
04-23 17:20:00.391+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 17:20:00.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:20:00.401+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:20:00.421+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 17:20:00.421+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 29852
04-23 17:20:00.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 29852
04-23 17:20:00.481+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(29852) type(svcapp) bg(0)
04-23 17:20:00.491+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [29852]
04-23 17:20:00.511+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29852)
04-23 17:20:00.511+0200 I/servicemanager(26979): es.ugr.frailty.location launch request sent!
04-23 17:20:00.511+0200 I/servicemanager(26979): App control destroyed.
04-23 17:20:00.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:20:00.531+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29852
04-23 17:20:00.541+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:20:00.551+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 17:20:00.561+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 29852
04-23 17:20:00.561+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 17:20:00.571+0200 E/CAPI_APPFW_APPLICATION(29852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:20:00.571+0200 E/CAPI_APPFW_APPLICATION(29852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 17:20:00.581+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (29852) was created
04-23 17:20:00.601+0200 W/LOCATION(29852): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 17:20:00.601+0200 E/LOCATION(29852): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 17:20:00.601+0200 E/PKGMGR_INFO(29852): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 17:20:00.611+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:20:00.631+0200 I/LOCATION(29852): location.c: location_new(269) > method: 0
04-23 17:20:00.631+0200 W/LOCATION(29852): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:20:00.631+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:20:00.641+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:20:00.641+0200 W/LOCATION(29852): module-internal.c: module_new(311) > module (gps) open success
04-23 17:20:00.641+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:20:00.651+0200 W/LOCATION(29852): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:20:00.651+0200 W/LOCATION(29852): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:20:00.651+0200 W/LOCATION(29852): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:20:00.651+0200 W/LOCATION(29852): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:20:00.671+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:20:00.671+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 17:20:00.681+0200 W/LOCATION(29852): module-internal.c: module_new(311) > module (wps) open success
04-23 17:20:00.681+0200 W/LOCATION(29852): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 17:20:00.681+0200 W/LOCATION(29852): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 17:20:00.681+0200 W/LOCATION(29852): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:20:00.681+0200 W/LOCATION(29852): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:20:00.701+0200 W/LOCATION(29852): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 17:20:00.701+0200 I/LOCATION(29852): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a60c18
04-23 17:20:00.701+0200 I/LOCATION(29852): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 17:20:00.701+0200 I/LOCATION(29852): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a60c18
04-23 17:20:00.701+0200 I/LOCATION(29852): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 17:20:00.701+0200 I/location(29852): es.ugr.frailty.location: creado servicio de localización
04-23 17:20:00.741+0200 I/LOCATION(29852): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 17:20:00.781+0200 W/LOCATION(29852): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:20:00.781+0200 W/LOCATION(29852): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:20:00.781+0200 I/LOCATION(29852): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:20:00.851+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 17:20:00.851+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 17:20:00.851+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:00.851+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:00.851+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:20:00.851+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 17:20:00.851+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 17:20:00.851+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:20:00.861+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:20:00.871+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:20:00.871+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 17:20:00.871+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:20:00.871+0200 W/gpsd    ( 3104): ProcessEvent(fd3, bRead=1, bWrite=0, bError=0), handler=GpsiServerWriteSM
04-23 17:20:00.871+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 17:20:00.871+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:20:00.881+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:20:00.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 17:20:00.881+0200 W/gpsd    ( 3104): WakeLock(Release,GPSD)
04-23 17:20:00.891+0200 W/gpsd    ( 3104): WakeLock(Acquire,GPSD)
04-23 17:20:00.901+0200 W/gpsd    ( 3104): ProcessEvent(fd15, bRead=1, bWrite=0, bError=0), handler=GPSD
04-23 17:20:00.901+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 17:20:00.901+0200 E/lhd     ( 2444): checkForcedLogSetting: BRCM forced log (TIZEN) NOT detected. Disabling BRCM GPS log.
04-23 17:20:00.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 17:20:00.901+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 17:20:00.901+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 17:20:00.901+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 17:20:00.931+0200 W/LOCATION(29852): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 17:20:00.931+0200 W/LOCATION(29852): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 17:20:01.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:20:01.041+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_create(453) > New handle created[0xf3e1fbd8]
04-23 17:20:01.041+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 17:20:01.041+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 17:20:01.041+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 17:20:01.041+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_get_type(507) > Connected Network = 2
04-23 17:20:01.051+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:20:01.051+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:20:01.061+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:20:01.061+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:20:01.061+0200 E/LOCATION(29741): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 17:20:01.061+0200 I/LOCATION(29741): location.c: location_new(269) > method: 1
04-23 17:20:01.071+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 17:20:01.071+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (gps) open success
04-23 17:20:01.071+0200 W/LOCATION(29741): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 17:20:01.071+0200 W/LOCATION(29741): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 17:20:01.071+0200 W/LOCATION(29741): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 17:20:01.071+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 17:20:01.071+0200 W/LOCATION(29741): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 17:20:01.071+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:20:01.081+0200 I/AUL     (29741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 17:20:01.081+0200 E/LOCATION(29741): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 17:20:01.091+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:20:01.131+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:20:01.161+0200 W/LOCATION(29852): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 17:20:01.161+0200 I/LOCATION(29852): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 17:20:01.161+0200 I/LOCATION(29852): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 17:20:01.161+0200 I/location(29852): es.ugr.frailty.location:iniciado servicio de localización
04-23 17:20:01.201+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::OnStart took 301 ms (from 10696563 to 10696864) (logOverhead=0,0,0,0,0,0,0), start: 17:20:00.908
04-23 17:20:01.201+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): marshal_gps_start took 306 ms (from 10696561 to 10696867) (logOverhead=0,0,0,0,0,0,0), start: 17:20:00.906
04-23 17:20:01.201+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 308 ms (from 10696561 to 10696869) (logOverhead=0,0,0,0,0,0,0), start: 17:20:00.906
04-23 17:20:01.261+0200 I/LOCATION(29852): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 17:20:01.311+0200 E/location(29852): es.ugr.frailty.location: error intentando obtener la última localización
04-23 17:20:01.311+0200 W/AUL     (29852): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 17:20:01.311+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:20:01.311+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 29852
04-23 17:20:01.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26979
04-23 17:20:01.321+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.321+0200 I/utils   (26979): specific action
04-23 17:20:01.321+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.321+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.321+0200 W/CAPI_APPFW_APP_CONTROL(26979): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.331+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 17:20:01.331+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:20:01.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(26979), cmd(0)
04-23 17:20:01.331+0200 W/AUL     (29852): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26979)
04-23 17:20:01.331+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 17:20:01.331+0200 I/location(29852): request sent to service es.ugr.frailty.servicemanager
04-23 17:20:01.331+0200 W/CAPI_APPFW_APP_CONTROL(29852): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.331+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 26979
04-23 17:20:01.331+0200 I/utils   (29852): specific action
04-23 17:20:01.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 29506
04-23 17:20:01.341+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.341+0200 I/utils   (29506): specific action
04-23 17:20:01.341+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.341+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.341+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.341+0200 W/CAPI_APPFW_APP_CONTROL(29506): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 17:20:01.341+0200 I/recorder(29506): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 17:20:01.341+0200 I/recorder(29506): guardando datos en local
04-23 17:20:01.341+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 17:20:01.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(29506), cmd(0)
04-23 17:20:01.341+0200 W/AUL     (26979): launch.c: app_request_to_launchpad(298) > request cmd(0) result(29506)
04-23 17:20:01.341+0200 I/servicemanager(26979): request sent to service es.ugr.frailty.recorder
04-23 17:20:01.341+0200 I/servicemanager(26979): requesting to save local data
04-23 17:20:01.501+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 17:20:01.501+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(10697164), time2(10633639)
04-23 17:20:01.501+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 17:20:01.501+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 17:20:01.501+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 17:20:01.501+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 17:20:02.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): GlEngine::ChipData took 147 ms (from 10697567 to 10697714) (logOverhead=0,0,0,0,0,0,0), start: 17:20:01.912
04-23 17:20:02.051+0200 W/gpsd    ( 3104): CALL_SENTRY(main()): ProcessEvent took 147 ms (from 10697567 to 10697714) (logOverhead=0,0,0,0,0,0,0), start: 17:20:01.912
04-23 17:20:02.091+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:20:02.091+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:02.091+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:20:02.231+0200 E/CAPI_TELEPHONY(29741): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 17:20:02.931+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:20:02.931+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:02.941+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:20:02.991+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 17:20:03.021+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:03.021+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 17:20:03.031+0200 W/LOCATION(29852): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 17:20:03.241+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 17:20:03.241+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 17:20:03.241+0200 E/CAPI_LOCATION_MANAGER(29741): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 17:20:03.241+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 17:20:03.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 17:20:03.261+0200 W/AUL     (29865): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 17:20:03.261+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 17:20:03.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 17:20:03.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 29763
04-23 17:20:03.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 17:20:03.281+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 29763
04-23 17:20:03.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(29763)
04-23 17:20:03.331+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 17:20:03.331+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 17:20:03.331+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 17:20:03.331+0200 I/CAPI_NETWORK_CONNECTION(29741): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1fbd8
04-23 17:20:03.331+0200 W/CRASH_MANAGER(29863): worker.c: worker_job(1205) > 11298526c6f63152449680
