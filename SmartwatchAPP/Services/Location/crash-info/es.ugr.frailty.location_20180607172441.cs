S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21238
Date: 2018-06-07 17:24:41+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf772252d, r5   = 0xf7d4ef98
r6   = 0xffb593b0, r7   = 0xffb59260
r8   = 0xf7d4bc18, r9   = 0x00000000
r10  = 0xffb5933c, fp   = 0xffb593b0
ip   = 0x00000001, sp   = 0xffb59238
lr   = 0xf7722539, pc   = 0xf778b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    180452 KB
Buffers:     16320 KB
Cached:     108572 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11680 KB
VmRSS:       11680 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21238 TID = 21238
21238 21244 

Maps Information
f45ed000 f4dec000 rw-p [stack:21244]
f4df3000 f4df5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dfd000 f4e01000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e0a000 f4e0c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e14000 f4e17000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e26000 f4e2b000 r-xp /usr/lib/libsystem.so.0.0.0
f4e36000 f4e39000 r-xp /lib/libattr.so.1.1.0
f4e41000 f4e51000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e59000 f4e62000 r-xp /usr/lib/libedbus.so.1.7.99
f4e6a000 f4e6b000 r-xp /usr/lib/libresponse.so.0.2.96
f4e74000 f4e79000 r-xp /usr/lib/libproc-stat.so.0.2.96
f671b000 f6821000 r-xp /usr/lib/libicuuc.so.57.1
f6837000 f69bf000 r-xp /usr/lib/libicui18n.so.57.1
f69cf000 f69dc000 r-xp /usr/lib/libail.so.0.1.0
f69e5000 f69ec000 r-xp /usr/lib/libminizip.so.1.0.0
f69f5000 f6b9e000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bbe000 f6c05000 r-xp /usr/lib/libssl.so.1.0.0
f6c11000 f6c13000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c1b000 f6c22000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c2b000 f6c32000 r-xp /lib/libcrypt-2.13.so
f6c63000 f6c66000 r-xp /lib/libcap.so.2.21
f6c6e000 f6c70000 r-xp /usr/lib/libiri.so
f6c78000 f6cc1000 r-xp /usr/lib/libmdm.so.1.2.69
f6cc9000 f6ccf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cd7000 f6cfa000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d04000 f6d06000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d0e000 f6d2b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d34000 f6d38000 r-xp /usr/lib/libsmack.so.1.0.0
f6d41000 f6d5a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d63000 f6d6b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d73000 f6d79000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d82000 f6d84000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d8d000 f6d9d000 r-xp /lib/libresolv-2.13.so
f6da1000 f6db9000 r-xp /usr/lib/liblzma.so.5.0.3
f6dc2000 f6dc4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6dcc000 f6de6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dee000 f6e1d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e26000 f6e35000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e3f000 f6e49000 r-xp /usr/lib/libsensord-shared.so
f6e52000 f6f25000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f30000 f6f46000 r-xp /lib/libz.so.1.2.5
f6f4e000 f6f53000 r-xp /usr/lib/libffi.so.5.0.10
f6f5b000 f6f5c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f64000 f6f74000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f7c000 f6f95000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f9d000 f6f9f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fa7000 f701c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7026000 f702c000 r-xp /lib/librt-2.13.so
f7035000 f7053000 r-xp /usr/lib/libsystemd.so.0.4.0
f705d000 f705e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7066000 f7089000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7091000 f7096000 r-xp /usr/lib/libxdgmime.so.1.1.0
f709e000 f70c8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70d1000 f70e8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70f0000 f7159000 r-xp /lib/libm-2.13.so
f7162000 f71f6000 r-xp /usr/lib/libstdc++.so.6.0.16
f7209000 f720e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7216000 f721d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7225000 f724f000 r-xp /usr/lib/libsensor.so.1.9.6
f7258000 f7324000 r-xp /usr/lib/libxml2.so.2.7.8
f7331000 f7333000 r-xp /usr/lib/libiniparser.so.0
f733c000 f7342000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f734b000 f741b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f741c000 f7450000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7459000 f7495000 r-xp /usr/lib/libSLP-location.so.0.9.24
f749d000 f74a0000 r-xp /usr/lib/libbundle.so.0.1.22
f74a8000 f74ae000 r-xp /usr/lib/libappsvc.so.0.1.0
f74b6000 f74f7000 r-xp /usr/lib/libeina.so.1.7.99
f7500000 f7517000 r-xp /usr/lib/libecore.so.1.7.99
f752e000 f7537000 r-xp /usr/lib/libvconf.so.0.2.45
f753f000 f7553000 r-xp /lib/libpthread-2.13.so
f755e000 f756b000 r-xp /usr/lib/libaul.so.0.1.0
f7575000 f7577000 r-xp /lib/libdl-2.13.so
f7580000 f758b000 r-xp /lib/libunwind.so.8.0.1
f75b8000 f75c0000 r-xp /lib/libgcc_s-4.6.so.1
f75c1000 f76e5000 r-xp /lib/libc-2.13.so
f76f3000 f76f5000 r-xp /usr/lib/libdlog.so.0.0.0
f76fd000 f7709000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7712000 f7717000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f771f000 f772e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7736000 f773a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7743000 f7746000 r-xp /usr/lib/libappcore-agent.so.1.1
f774e000 f7750000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7758000 f775c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7764000 f7781000 r-xp /lib/ld-2.13.so
f778a000 f778d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f778d000 f7791000 r-xp /usr/lib/libsys-assert.so
f7d1b000 f7d89000 rw-p [heap]
ffb3a000 ffb5b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21238)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf778b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7722539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74293f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7427c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7433e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7439be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7439dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf746e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74691f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7427c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7433e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7439be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7439dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf746be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf746c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7473f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e0b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dfe171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ed1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf737efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73807a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7510ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf750bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf750c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf750c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7744183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77447fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf778b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75d885c) [/lib/libc.so.6] + 0x1785c
29: (0xf778af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
_result_to_client, pid: 20992
06-07 17:26:22.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:22.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:22.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.621+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:22.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:22.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:22.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:23.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.061+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.101+0200 I/APP_CORE( 2702): appcore-efl.c: __do_app(453) > [APP 2702] Event: MEM_FLUSH State: PAUSED
06-07 17:26:23.161+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.171+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:23.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:23.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:23.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.281+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.391+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:23.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:23.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.501+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:23.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:23.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.611+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.751+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 17:26:23.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:23.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:23.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:23.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:23.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:23.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:24.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.071+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:24.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:24.261+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:24.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:24.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.271+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:24.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.271+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:24.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:24.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.281+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.281+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:24.281+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.281+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:24.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:24.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.301+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:24.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.301+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:24.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:24.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.311+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:24.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.311+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:24.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:24.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.321+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:24.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.321+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:24.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:24.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.331+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:24.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.331+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:24.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:24.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.331+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:24.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.331+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:24.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:24.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.341+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:24.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.341+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:24.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:24.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:24.351+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:24.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:24.351+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:24.351+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:24.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:24.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:24.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:24.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.411+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.521+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:24.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:24.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.631+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.741+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:24.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:24.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.851+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:24.961+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:24.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:24.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:25.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.071+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:25.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:25.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:25.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.301+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11211886c6f631528385065
06-07 17:26:25.301+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:25.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:25.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.411+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.521+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.561+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
06-07 17:26:25.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:25.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:25.611+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-07 17:26:25.611+0200 W/SHealthService( 3178): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
06-07 17:26:25.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.641+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.651+0200 W/SHealthCommon( 3178): TimelineSessionStorage.cpp: OnTriggered(1273) > [1;40;33mlocalStartTime: 1528329600000,000000[0;m
06-07 17:26:25.671+0200 W/SHealthCommon( 3178): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 2[0;m
06-07 17:26:25.681+0200 I/HealthDataService( 2933): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
06-07 17:26:25.691+0200 I/healthData( 3178): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
06-07 17:26:25.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.751+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:25.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:25.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.871+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:25.981+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:25.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:25.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:26.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.091+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:26.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:26.191+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.201+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.261+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:26.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:26.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.271+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:26.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.271+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:26.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:26.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.271+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:26.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.271+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:26.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:26.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.281+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.281+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:26.281+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.281+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:26.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:26.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.291+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:26.291+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.291+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:26.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:26.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.301+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:26.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.301+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:26.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:26.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.321+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.331+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:26.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.331+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:26.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:26.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.341+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:26.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.341+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:26.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:26.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.351+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:26.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.351+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:26.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:26.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:26.351+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:26.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:26.351+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:26.351+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:26.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:26.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:26.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:26.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.431+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.551+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:26.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:26.651+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.671+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.781+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:26.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:26.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:26.891+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:26.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:26.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:27.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.011+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.121+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:27.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:27.231+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.231+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.241+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:27.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.351+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:27.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:27.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.461+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.571+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.581+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:27.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:27.681+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.691+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:27.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:27.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.801+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:27.921+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:27.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:27.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:28.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.141+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.141+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:28.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:28.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.261+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.261+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:28.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:28.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.281+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.281+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:28.281+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.281+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:28.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:28.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.291+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:28.291+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.291+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:28.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:28.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.301+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:28.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.301+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:28.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:28.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.311+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:28.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.311+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:28.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:28.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.321+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:28.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.321+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:28.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:28.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.331+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:28.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.331+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:28.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:28.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.341+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:28.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.341+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:28.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:28.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.351+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.351+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.351+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:28.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.351+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:28.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:28.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:28.361+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:28.371+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:28.371+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:28.371+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:28.371+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:28.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:28.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:28.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.491+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:28.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:28.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.611+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.721+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:28.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:28.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.831+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:28.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:28.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:28.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:29.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.061+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:29.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:29.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:29.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:29.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:29.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.411+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.521+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:29.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:29.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.631+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.751+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:29.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:29.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.861+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:29.981+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:29.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:29.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:30.081+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:30.091+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:30.131+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11212386c6f63152838508
