S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16699
Date: 2018-06-07 17:09:03+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf749452d, r5   = 0xf789cf98
r6   = 0xffe53a20, r7   = 0xffe538d0
r8   = 0xf7899c18, r9   = 0x00000000
r10  = 0xffe539ac, fp   = 0xffe53a20
ip   = 0x00000001, sp   = 0xffe538a8
lr   = 0xf7494539, pc   = 0xf74fd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     53760 KB
Buffers:      9424 KB
Cached:      56408 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11440 KB
VmRSS:       11440 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16699 TID = 16699
16699 16703 

Maps Information
f435f000 f4b5e000 rw-p [stack:16703]
f4b65000 f4b67000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b6f000 f4b73000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b7c000 f4b7e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b86000 f4b89000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b98000 f4b9d000 r-xp /usr/lib/libsystem.so.0.0.0
f4ba8000 f4bab000 r-xp /lib/libattr.so.1.1.0
f4bb3000 f4bc3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bcb000 f4bd4000 r-xp /usr/lib/libedbus.so.1.7.99
f4bdc000 f4bdd000 r-xp /usr/lib/libresponse.so.0.2.96
f4be6000 f4beb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f648d000 f6593000 r-xp /usr/lib/libicuuc.so.57.1
f65a9000 f6731000 r-xp /usr/lib/libicui18n.so.57.1
f6741000 f674e000 r-xp /usr/lib/libail.so.0.1.0
f6757000 f675e000 r-xp /usr/lib/libminizip.so.1.0.0
f6767000 f6910000 r-xp /usr/lib/libcrypto.so.1.0.0
f6930000 f6977000 r-xp /usr/lib/libssl.so.1.0.0
f6983000 f6985000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f698d000 f6994000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f699d000 f69a4000 r-xp /lib/libcrypt-2.13.so
f69d5000 f69d8000 r-xp /lib/libcap.so.2.21
f69e0000 f69e2000 r-xp /usr/lib/libiri.so
f69ea000 f6a33000 r-xp /usr/lib/libmdm.so.1.2.69
f6a3b000 f6a41000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a49000 f6a6c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a76000 f6a78000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a80000 f6a9d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6aa6000 f6aaa000 r-xp /usr/lib/libsmack.so.1.0.0
f6ab3000 f6acc000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ad5000 f6add000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ae5000 f6aeb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6af4000 f6af6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aff000 f6b0f000 r-xp /lib/libresolv-2.13.so
f6b13000 f6b2b000 r-xp /usr/lib/liblzma.so.5.0.3
f6b34000 f6b36000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b3e000 f6b58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b60000 f6b8f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b98000 f6ba7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bb1000 f6bbb000 r-xp /usr/lib/libsensord-shared.so
f6bc4000 f6c97000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ca2000 f6cb8000 r-xp /lib/libz.so.1.2.5
f6cc0000 f6cc5000 r-xp /usr/lib/libffi.so.5.0.10
f6ccd000 f6cce000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cd6000 f6ce6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cee000 f6d07000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d0f000 f6d11000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d19000 f6d8e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d98000 f6d9e000 r-xp /lib/librt-2.13.so
f6da7000 f6dc5000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dcf000 f6dd0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dd8000 f6dfb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e03000 f6e08000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e10000 f6e3a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e43000 f6e5a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e62000 f6ecb000 r-xp /lib/libm-2.13.so
f6ed4000 f6f68000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f7b000 f6f80000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f88000 f6f8f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f97000 f6fc1000 r-xp /usr/lib/libsensor.so.1.9.6
f6fca000 f7096000 r-xp /usr/lib/libxml2.so.2.7.8
f70a3000 f70a5000 r-xp /usr/lib/libiniparser.so.0
f70ae000 f70b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70bd000 f718d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f718e000 f71c2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71cb000 f7207000 r-xp /usr/lib/libSLP-location.so.0.9.24
f720f000 f7212000 r-xp /usr/lib/libbundle.so.0.1.22
f721a000 f7220000 r-xp /usr/lib/libappsvc.so.0.1.0
f7228000 f7269000 r-xp /usr/lib/libeina.so.1.7.99
f7272000 f7289000 r-xp /usr/lib/libecore.so.1.7.99
f72a0000 f72a9000 r-xp /usr/lib/libvconf.so.0.2.45
f72b1000 f72c5000 r-xp /lib/libpthread-2.13.so
f72d0000 f72dd000 r-xp /usr/lib/libaul.so.0.1.0
f72e7000 f72e9000 r-xp /lib/libdl-2.13.so
f72f2000 f72fd000 r-xp /lib/libunwind.so.8.0.1
f732a000 f7332000 r-xp /lib/libgcc_s-4.6.so.1
f7333000 f7457000 r-xp /lib/libc-2.13.so
f7465000 f7467000 r-xp /usr/lib/libdlog.so.0.0.0
f746f000 f747b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7484000 f7489000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7491000 f74a0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74a8000 f74ac000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74b5000 f74b8000 r-xp /usr/lib/libappcore-agent.so.1.1
f74c0000 f74c2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74ca000 f74ce000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74d6000 f74f3000 r-xp /lib/ld-2.13.so
f74fc000 f74ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74ff000 f7503000 r-xp /usr/lib/libsys-assert.so
f7869000 f78f7000 rw-p [heap]
ffe35000 ffe56000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16699)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74fd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7494539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf719b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7199c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71a5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71abbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71abdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71e075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71db1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7199c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71a5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71abbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71abdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71dde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71de017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71e5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b7d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b70171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c43663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70f0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70f27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7282ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf727db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf727e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf727e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74b6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74b67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74fd5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf734a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf74fcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
ation(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:466,-0.817014,1.072600,1.049996
06-07 17:09:03.521+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.521+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.541+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:483,-31.010000,-13.860000,1.400000
06-07 17:09:03.541+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.541+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:528,1.168320,-2.991215,9.265962
06-07 17:09:03.551+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:539,1.230821,0.884418,0.772738
06-07 17:09:03.561+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.571+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:03.571+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:03:578,683.000000
06-07 17:09:03.581+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.611+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:584,1.103730,-2.790347,9.336280
06-07 17:09:03.611+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.611+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:03.611+0200 I/heartrate(15106): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:09:03.611+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:03.621+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:600,-0.025909,0.932934,-0.119950
06-07 17:09:03.641+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.651+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:640,1.034266,-2.876469,9.318079
06-07 17:09:03.651+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:624,-24.990000,-6.370000,-6.090000
06-07 17:09:03.661+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:03.661+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.671+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:583,-0.650848,-5.405386,7.874779
06-07 17:09:03.671+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:646,-1.207411,0.808650,-0.190214
06-07 17:09:03.681+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.691+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:678,-49.700001,-6.230000,1.680000
06-07 17:09:03.701+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.711+0200 W/WATCH_CORE( 2865): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): dbus.c: _dbus_message_recv_cb(204) > LCD off
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_disable_timer_del(157) > timer del
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): gesture.c: _manual_render_enable(138) > 1
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): event_manager.c: _lcd_off_cb(729) > lcd state: 0
06-07 17:09:03.711+0200 W/W_HOME  ( 2762): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-07 17:09:03.711+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
06-07 17:09:03.711+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
06-07 17:09:03.721+0200 E/STARTER ( 2696): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
06-07 17:09:03.721+0200 E/STARTER ( 2696): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
06-07 17:09:03.721+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 1
06-07 17:09:03.721+0200 W/STARTER ( 2696): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 1
06-07 17:09:03.721+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1426) > [_pre_lcd_off:1426] reserved app is running now. raise it.
06-07 17:09:03.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:09:03.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11356
06-07 17:09:03.731+0200 W/STARTER ( 2696): clock-mgr.c: _pre_lcd_off(1449) > [_pre_lcd_off:1449] [com.samsung.shealth.alert] is now running & will raise when lcd on.
06-07 17:09:03.741+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7968.513513] layer(0x86a2c0) now usable
06-07 17:09:03.741+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7968.513543] layer[0x869e10]zpos[1]
06-07 17:09:03.741+0200 I/TDM     ( 1956): tdm_display.c: tdm_layer_unset_buffer(1602) > [7968.513570] layer(0x86a310) now usable
06-07 17:09:03.741+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [7968.513581] layer[0x869f30]zpos[2]
06-07 17:09:03.741+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [7968.513675] dpms[0 -> 3]sync[1]
06-07 17:09:03.741+0200 I/TDM     ( 1956): 
06-07 17:09:03.741+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -147895540[0;m
06-07 17:09:03.741+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
06-07 17:09:03.741+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
06-07 17:09:03.751+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
06-07 17:09:03.751+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:708,0.583849,-5.400600,7.709675
06-07 17:09:03.751+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:762,0.533599,-4.991428,7.709675
06-07 17:09:03.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:767,-0.772882,-5.776274,8.291130
06-07 17:09:03.761+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:03.761+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.771+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
06-07 17:09:03.771+0200 E/WAKEUP-SERVICE( 3285): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
06-07 17:09:03.771+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
06-07 17:09:03.771+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:774,-0.806381,-6.218946,8.212167
06-07 17:09:03.771+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.771+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:781,-0.579063,-5.661418,8.114061
06-07 17:09:03.781+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.781+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:03:772,682.000000
06-07 17:09:03.781+0200 I/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
06-07 17:09:03.781+0200 W/TIZEN_N_SOUND_MANAGER( 3285): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
06-07 17:09:03.781+0200 W/WAKEUP-SERVICE( 3285): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
06-07 17:09:03.781+0200 I/HIGEAR  ( 3285): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
06-07 17:09:03.781+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:787,-1.579263,-6.982256,7.403394
06-07 17:09:03.781+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.781+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:698,-1.501098,1.221997,-0.474679
06-07 17:09:03.791+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:794,0.047856,-3.921836,9.004191
06-07 17:09:03.791+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.791+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:690,0.976998,-3.217701,9.212071
06-07 17:09:03.791+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.791+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:801,0.212961,-4.718646,8.415558
06-07 17:09:03.801+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.801+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:807,-0.497707,-5.766702,7.334002
06-07 17:09:03.801+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.811+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:03.811+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:814,0.078963,-6.594619,7.647461
06-07 17:09:03.811+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:03.811+0200 I/heartrate(15106): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:09:03.811+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.811+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.811+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:817,-72.940002,-5.250000,18.200001
06-07 17:09:03.821+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:821,0.064606,-7.367501,8.439486
06-07 17:09:03.821+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.821+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:822,-1.236548,0.776155,0.245880
06-07 17:09:03.821+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:829,0.136391,-8.015956,7.814958
06-07 17:09:03.831+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.831+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:837,-0.035892,-7.324430,7.532606
06-07 17:09:03.831+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.831+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:03.841+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:842,-1.368695,-7.044470,6.728617
06-07 17:09:03.841+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.841+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:802,0.915153,-3.614184,9.070312
06-07 17:09:03.841+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:849,-1.875973,-7.566105,5.395815
06-07 17:09:03.841+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:856,-0.713061,-6.185446,7.420143
06-07 17:09:03.851+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.851+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.861+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:862,-1.071985,-4.292724,7.094719
06-07 17:09:03.861+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.861+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:868,-4.639683,-6.472585,5.726025
06-07 17:09:03.861+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:855,-0.086162,-0.298090,-0.220538
06-07 17:09:03.871+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.871+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:876,-2.801995,-6.987042,7.159326
06-07 17:09:03.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:845,-118.230003,10.570000,60.760002
06-07 17:09:03.871+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.871+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:03.881+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:865,0.855188,-3.923480,8.946806
06-07 17:09:03.881+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:883,-0.507278,-6.812366,7.695317
06-07 17:09:03.881+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:03.881+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.881+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:03.881+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:889,1.402194,-8.219346,8.173882
06-07 17:09:03.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.891+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [7968.661841] dpms[3 -> 3]done
06-07 17:09:03.891+0200 I/TDM     ( 1956): 
06-07 17:09:03.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:897,-1.328017,-7.594819,6.886543
06-07 17:09:03.891+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.901+0200 W/SHealthCommon( 2909): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 17:09:03.901+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:903,0.150748,-6.211767,9.461221
06-07 17:09:03.901+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.901+0200 I/watchface-viewer( 2865): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
06-07 17:09:03.901+0200 W/SHealthCommon( 3178): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 17:09:03.901+0200 W/SHealthService( 3178): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
06-07 17:09:03.911+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:912,0.440279,-4.989035,6.491727
06-07 17:09:03.911+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.911+0200 W/STARTER ( 2696): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
06-07 17:09:03.911+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[com.samsung.shealth.alert] alpm mode[0]
06-07 17:09:03.911+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 1
06-07 17:09:03.911+0200 W/STARTER ( 2696): clock-mgr.c: _post_lcd_off(1525) > [_post_lcd_off:1525] raise [com.samsung.shealth.alert] when lcd off after 20 sec.
06-07 17:09:03.911+0200 E/ALARM_MANAGER( 2696): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(7-6-2018, 17:09:24), repeat(1), interval(20), type(-1073741822)
06-07 17:09:03.911+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2696].
06-07 17:09:03.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:920,-1.014557,-6.769295,7.044470
06-07 17:09:03.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.921+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:929,-1.366302,-7.085148,7.609176
06-07 17:09:03.931+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.931+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:936,-0.686740,-6.989435,8.298308
06-07 17:09:03.931+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.941+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:943,-1.127020,-6.276374,6.360123
06-07 17:09:03.941+0200 W/SHealthCommon(11356): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
06-07 17:09:03.941+0200 I/APP_CORE(11356): appcore-efl.c: __do_app(453) > [APP 11356] Event: PAUSE State: RUNNING
06-07 17:09:03.941+0200 I/CAPI_APPFW_APPLICATION(11356): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
06-07 17:09:03.941+0200 W/WSLib   (11356): Application.cpp: SOnAppPause(315) > [1;35m ###[0;m
06-07 17:09:03.941+0200 W/SHealthCommon(11356): SHealthMessagePortConnection.cpp: Send(512) > [1;40;33mSEND CLIENT MESSAGE [feature type: 1, msg type: 2, msg id: app_paused, name: app_paused][0;m
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.shealth-service:com.samsung.shealth.server]
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-07 17:09:03.941+0200 I/MESSAGE_PORT( 2457): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-07 17:09:03.941+0200 W/SHealthCommon( 3178): SHealthMessagePortConnection.cpp: OnPortMessageReceived(135) > [1;40;33mfeatureType: 1, clientMsgType: 2, messageName: app_paused[0;m
06-07 17:09:03.941+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.941+0200 W/SHealthAlertViewer(11356): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
06-07 17:09:03.941+0200 W/SHealthAlertViewer(11356): InactiveTimeAlertView.cpp: onAnimationFinished(201) > [1;40;33mNot Completedly[0;m
06-07 17:09:03.951+0200 E/ALARM_MANAGER( 2466): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 649662020, next duetime: 1528384164
06-07 17:09:03.951+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(649662020)
06-07 17:09:03.951+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1528408106), due_time(1528384164)
06-07 17:09:03.951+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:957,-0.696311,-6.809973,6.754939
06-07 17:09:03.951+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.961+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:964,-0.215354,-6.075377,6.551548
06-07 17:09:03.961+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.971+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:970,1.268196,-7.836494,7.130611
06-07 17:09:03.971+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
06-07 17:09:03.971+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
06-07 17:09:03.971+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 7-6-2018, 15:09:24 (UTC).
06-07 17:09:03.971+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
06-07 17:09:03.971+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.971+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:980,9.241080,-3.479164,13.907085
06-07 17:09:03.981+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:03.981+0200 E/ALARM_MANAGER( 2466): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
06-07 17:09:03.981+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:03:988,4.795217,-6.699903,-2.086541
06-07 17:09:03.991+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:04.001+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:04:1,675.000000
06-07 17:09:04.001+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:09:04.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:09:04.001+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 17:09:04.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.001+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
06-07 17:09:04.001+0200 W/W_INDICATOR( 2702): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
06-07 17:09:04.001+0200 W/W_INDICATOR( 2702): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
06-07 17:09:04.011+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.011+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:04.011+0200 I/heartrate(15106): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:09:04.011+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16527
06-07 17:09:04.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16527)
06-07 17:09:04.021+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:09:04.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.021+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:09:04.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:09:04.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.021+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:03:883,-175.770004,50.259998,141.750000
06-07 17:09:04.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16604
06-07 17:09:04.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16604)
06-07 17:09:04.041+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:09:04.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.041+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:09:04.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:09:04.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.041+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.051+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:03:888,0.764083,-4.184983,8.835863
06-07 17:09:04.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:09:04.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:09:04.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:09:04.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:09:04.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:09:04.071+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:09:04.071+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.071+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:09:04.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:09:04.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.071+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.071+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:04.071+0200 I/utils   (15106): specific action
06-07 17:09:04.081+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:18,-6.434300,-10.626525,9.791430
06-07 17:09:04.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16699
06-07 17:09:04.081+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:03:892,-0.164525,-0.135511,-0.084772
06-07 17:09:04.081+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.081+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:04.081+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(29) , send fd(15), pid(15106), cmd(0)
06-07 17:09:04.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16699)
06-07 17:09:04.081+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:09:04.081+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.081+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:09:04.081+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:09:04.091+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.091+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.091+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:96,0.701459,-4.397194,8.737450
06-07 17:09:04.091+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.101+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:101,0.602477,-4.569384,8.656104
06-07 17:09:04.101+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16633
06-07 17:09:04.101+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:107,0.497827,-4.656849,8.616050
06-07 17:09:04.111+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16633)
06-07 17:09:04.111+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.111+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:09:04.111+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.111+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:09:04.111+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:09:04.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.111+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:116,0.395920,-4.807224,8.538398
06-07 17:09:04.111+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.111+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:122,0.307164,-5.205651,8.305253
06-07 17:09:04.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.121+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:128,0.177005,-5.795201,7.909153
06-07 17:09:04.121+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16582
06-07 17:09:04.121+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.131+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16582)
06-07 17:09:04.131+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:09:04.131+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.131+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:09:04.131+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:09:04.131+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:132,0.035798,-0.666868,9.783884
06-07 17:09:04.131+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.131+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.131+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.141+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:141,-0.008354,-3.296563,9.235962
06-07 17:09:04.141+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:09:04.141+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:04.141+0200 I/utils   (12603): specific action
06-07 17:09:04.141+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:149,-0.074353,-4.050471,8.930763
06-07 17:09:04.141+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:04.141+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(12603), cmd(0)
06-07 17:09:04.151+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.151+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:09:04.151+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:09:04.151+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.151+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:09:04.151+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:09:04.151+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:158,-0.104363,-4.083097,8.915594
06-07 17:09:04.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.151+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.151+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.161+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:165,-0.159737,-4.311289,8.806683
06-07 17:09:04.161+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.161+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:09:04.171+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:170,-0.025123,-3.255503,9.250484
06-07 17:09:04.171+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:04.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(16749), cmd(0)
06-07 17:09:04.171+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:04.171+0200 I/utils   (16749): specific action
06-07 17:09:04.171+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:04.171+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:09:04.171+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:09:04.171+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.171+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:09:04.171+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:09:04.171+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:179,0.025794,-3.058353,9.317521
06-07 17:09:04.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:09:04.181+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.181+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:09:04.181+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:187,0.160977,-2.563353,9.464338
06-07 17:09:04.181+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:09:04.191+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:09:04.191+0200 I/utils   (12618): specific action
06-07 17:09:04.191+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:194,0.142073,-2.641911,9.443013
06-07 17:09:04.191+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:09:04.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(12618), cmd(0)
06-07 17:09:04.191+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.191+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:09:04.201+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:09:04.201+0200 I/servicemanager(12566): App control destroyed.
06-07 17:09:04.201+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:201,0.207009,-2.377176,9.511917
06-07 17:09:04.201+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.201+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:04:183,674.000000
06-07 17:09:04.201+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:60,-154.770004,234.779999,4.970000
06-07 17:09:04.211+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.211+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.211+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.211+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:04.211+0200 I/heartrate(15106): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:09:04.221+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:217,-30.799999,96.739998,-125.300003
06-07 17:09:04.221+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:04:210,-1.152453,0.114869,0.310883
06-07 17:09:04.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xee816b60) is deleting
06-07 17:09:04.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xee816b60) is deleting
06-07 17:09:04.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xef7f6910) is deleting
06-07 17:09:04.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xef7f6910) is deleting
06-07 17:09:04.231+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:225,0.215138,-2.222679,9.549021
06-07 17:09:04.231+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.231+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.251+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.251+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:222,-8.918050,-11.073983,5.893522
06-07 17:09:04.251+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.251+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:04:246,-0.757166,0.520175,0.842058
06-07 17:09:04.261+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:248,0.149505,-2.487611,9.484715
06-07 17:09:04.261+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.261+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:267,-10.456635,-9.068797,-0.964308
06-07 17:09:04.261+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:260,-92.120003,117.389999,90.160004
06-07 17:09:04.271+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.271+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.281+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.281+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:281,-70.000000,22.469999,48.369999
06-07 17:09:04.281+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:285,-0.071785,-9.822537,3.940979
06-07 17:09:04.291+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.291+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.291+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:289,0.097826,-2.780851,9.403600
06-07 17:09:04.291+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:04:276,-0.357774,1.075788,1.029257
06-07 17:09:04.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:302,-4.012764,-9.662218,2.409572
06-07 17:09:04.301+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.301+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:315,-3.538985,-8.760124,3.565305
06-07 17:09:04.311+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:325,-3.122634,-8.468199,5.005785
06-07 17:09:04.331+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.331+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:308,-17.639999,3.360000,14.840000
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:04.331+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:04.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391344343,000000, pattern:[H:mm][0;m
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:09:04.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:09:04.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:09:04.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:09][0;m
06-07 17:09:04.341+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.341+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:04:316,-0.133157,0.516366,0.465458
06-07 17:09:04.351+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:343,0.045614,-3.101887,9.303042
06-07 17:09:04.351+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:339,0.404387,-8.070991,7.982457
06-07 17:09:04.351+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.361+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.361+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:368,-0.277567,-7.147361,7.434500
06-07 17:09:04.361+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:09:04.371+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:09:04:374,675.000000
06-07 17:09:04.371+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:355,26.460001,-33.950001,-5.320000
06-07 17:09:04.371+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.381+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:382,-1.988436,-7.362715,5.773881
06-07 17:09:04.381+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.381+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope - capturing data
06-07 17:09:04.391+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:09:04:363,-0.271346,0.165077,0.842741
06-07 17:09:04.391+0200 I/gravity (16582): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:09:04:380,-0.024959,-3.462808,9.174896
06-07 17:09:04.391+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:395,-2.828316,-8.606983,5.503492
06-07 17:09:04.401+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.401+0200 I/linearacceleration(16633): es.ugr.frailty.linearacceleration - capturing data
06-07 17:09:04.411+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:408,-1.423729,-9.458827,7.061220
06-07 17:09:04.411+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.431+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:422,-2.902494,-8.099705,6.996613
06-07 17:09:04.431+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.441+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:440,-5.194818,-7.257431,5.312066
06-07 17:09:04.441+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer - capturing data
06-07 17:09:04.411+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:09:04.441+0200 I/accelerometer(16527): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:09:04:448,-3.093920,-3.610770,6.484549
06-07 17:09:04.411+0200 I/gravity (16582): es.ugr.frailty.gravity - capturing data
06-07 17:09:04.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:09:04.411+0200 I/gyroscope(16604): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:09:04:404,27.160000,-66.010002,-6.720000
06-07 17:09:04.451+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11166996c6f63152838414
