S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21188
Date: 2018-06-07 17:24:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf710052d, r5   = 0xf77b1f98
r6   = 0xffe5a9d0, r7   = 0xffe5a880
r8   = 0xf77aec18, r9   = 0x00000000
r10  = 0xffe5a95c, fp   = 0xffe5a9d0
ip   = 0x00000001, sp   = 0xffe5a858
lr   = 0xf7100539, pc   = 0xf7169228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    225160 KB
Buffers:     15940 KB
Cached:     111104 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11860 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21188 TID = 21188
21188 21194 

Maps Information
f3fcb000 f47ca000 rw-p [stack:21194]
f47d1000 f47d3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47db000 f47df000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47e8000 f47ea000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47f2000 f47f5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4804000 f4809000 r-xp /usr/lib/libsystem.so.0.0.0
f4814000 f4817000 r-xp /lib/libattr.so.1.1.0
f481f000 f482f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4837000 f4840000 r-xp /usr/lib/libedbus.so.1.7.99
f4848000 f4849000 r-xp /usr/lib/libresponse.so.0.2.96
f4852000 f4857000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60f9000 f61ff000 r-xp /usr/lib/libicuuc.so.57.1
f6215000 f639d000 r-xp /usr/lib/libicui18n.so.57.1
f63ad000 f63ba000 r-xp /usr/lib/libail.so.0.1.0
f63c3000 f63ca000 r-xp /usr/lib/libminizip.so.1.0.0
f63d3000 f657c000 r-xp /usr/lib/libcrypto.so.1.0.0
f659c000 f65e3000 r-xp /usr/lib/libssl.so.1.0.0
f65ef000 f65f1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65f9000 f6600000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6609000 f6610000 r-xp /lib/libcrypt-2.13.so
f6641000 f6644000 r-xp /lib/libcap.so.2.21
f664c000 f664e000 r-xp /usr/lib/libiri.so
f6656000 f669f000 r-xp /usr/lib/libmdm.so.1.2.69
f66a7000 f66ad000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66b5000 f66d8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66e2000 f66e4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66ec000 f6709000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6712000 f6716000 r-xp /usr/lib/libsmack.so.1.0.0
f671f000 f6738000 r-xp /usr/lib/libnetwork.so.0.0.0
f6741000 f6749000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6751000 f6757000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6760000 f6762000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f676b000 f677b000 r-xp /lib/libresolv-2.13.so
f677f000 f6797000 r-xp /usr/lib/liblzma.so.5.0.3
f67a0000 f67a2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67aa000 f67c4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67cc000 f67fb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6804000 f6813000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f681d000 f6827000 r-xp /usr/lib/libsensord-shared.so
f6830000 f6903000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f690e000 f6924000 r-xp /lib/libz.so.1.2.5
f692c000 f6931000 r-xp /usr/lib/libffi.so.5.0.10
f6939000 f693a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6942000 f6952000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f695a000 f6973000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f697b000 f697d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6985000 f69fa000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a04000 f6a0a000 r-xp /lib/librt-2.13.so
f6a13000 f6a31000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a3b000 f6a3c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a44000 f6a67000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a6f000 f6a74000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a7c000 f6aa6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aaf000 f6ac6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ace000 f6b37000 r-xp /lib/libm-2.13.so
f6b40000 f6bd4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6be7000 f6bec000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bf4000 f6bfb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c03000 f6c2d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c36000 f6d02000 r-xp /usr/lib/libxml2.so.2.7.8
f6d0f000 f6d11000 r-xp /usr/lib/libiniparser.so.0
f6d1a000 f6d20000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d29000 f6df9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dfa000 f6e2e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e37000 f6e73000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e7b000 f6e7e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e86000 f6e8c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e94000 f6ed5000 r-xp /usr/lib/libeina.so.1.7.99
f6ede000 f6ef5000 r-xp /usr/lib/libecore.so.1.7.99
f6f0c000 f6f15000 r-xp /usr/lib/libvconf.so.0.2.45
f6f1d000 f6f31000 r-xp /lib/libpthread-2.13.so
f6f3c000 f6f49000 r-xp /usr/lib/libaul.so.0.1.0
f6f53000 f6f55000 r-xp /lib/libdl-2.13.so
f6f5e000 f6f69000 r-xp /lib/libunwind.so.8.0.1
f6f96000 f6f9e000 r-xp /lib/libgcc_s-4.6.so.1
f6f9f000 f70c3000 r-xp /lib/libc-2.13.so
f70d1000 f70d3000 r-xp /usr/lib/libdlog.so.0.0.0
f70db000 f70e7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70f0000 f70f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70fd000 f710c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7114000 f7118000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7121000 f7124000 r-xp /usr/lib/libappcore-agent.so.1.1
f712c000 f712e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7136000 f713a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7142000 f715f000 r-xp /lib/ld-2.13.so
f7168000 f716b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f716b000 f716f000 r-xp /usr/lib/libsys-assert.so
f777e000 f780c000 rw-p [heap]
ffe3c000 ffe5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21188)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7169228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7100539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e073f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e4c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e471f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e05c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e11e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e17be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e17dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e49e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e4a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e51f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47e91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47dc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68af663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d5cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d5e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eeeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ee9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eea5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eea879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7122183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71227fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71695c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6fb685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7168f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:18.861+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:18.861+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:18.861+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:18.861+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:18.861+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:18.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:18.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:18.861+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:18.861+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:18.861+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:18.861+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:18.861+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:18.861+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:18.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:18.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:18.871+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:18.871+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:18.871+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:18.871+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:18.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:18.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:18.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:18.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:19.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.061+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.161+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.171+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:19.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:19.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:19.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.401+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.401+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:19.401+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:19.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:19.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:19.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.621+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:19.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:19.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:19.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:19.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:19.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:20.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.071+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:20.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:20.261+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:20.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:20.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.271+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:20.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.271+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:20.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:20.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.281+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.291+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:20.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.291+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.291+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:20.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:20.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.301+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:20.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.301+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:20.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:20.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.311+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:20.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.311+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:20.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:20.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.321+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:20.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.321+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:20.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:20.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.321+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:20.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.321+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:20.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:20.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.331+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:20.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.331+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:20.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:20.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.331+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:20.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.331+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:20.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:20.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:20.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:20.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:20.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:20.341+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:20.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:20.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:20.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:20.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.401+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:20.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:20.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.621+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:20.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:20.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:20.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:20.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:20.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:21.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.071+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.171+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:21.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:21.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:21.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:21.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:21.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.411+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.521+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.591+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:21.591+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:21.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.631+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.741+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(20995)
06-07 17:26:21.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:21.741+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.recorder) pid(20995) type(svcapp)
06-07 17:26:21.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:26:21.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:26:21.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(20995), cmd(4)
06-07 17:26:21.751+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:26:21.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.761+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20995
06-07 17:26:21.791+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:21.791+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:21.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:21.871+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:21.881+0200 W/AUL     (21632): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
06-07 17:26:21.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:26:21.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:21.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 20848
06-07 17:26:21.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:26:21.901+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20848
06-07 17:26:21.901+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20848)
06-07 17:26:21.901+0200 E/AUL     (21632): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:26:21.991+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:21.991+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:22.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.031+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.031+0200 E/rpm-installer(21496): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.servicemanager] is running, need to terminate it.
06-07 17:26:22.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:26:22.041+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(20845)
06-07 17:26:22.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:22.051+0200 E/AUL_AMD ( 2479): amd_request.c: __app_process_by_pid(201) > pid(20845) is dead. cmd(5) is canceled
06-07 17:26:22.051+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(-3)
06-07 17:26:22.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.061+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.161+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.171+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.191+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:22.191+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:22.251+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:22.251+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:22.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.251+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.261+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.261+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:22.261+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.261+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:22.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:22.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.261+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.261+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.271+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:22.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.271+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:22.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:22.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.281+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:22.281+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.281+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:22.281+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:22.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.291+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:22.291+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.291+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:22.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:22.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.301+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:22.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.301+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:22.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:22.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.311+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:22.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.311+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:22.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:22.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.321+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:22.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.321+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:22.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:22.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.331+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:22.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.331+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:22.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:22.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:22.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:22.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:22.351+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:22.351+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:22.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:22.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.391+0200 I/CAPI_WATCH_APPLICATION( 2865): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
06-07 17:26:22.391+0200 E/watchface-loader( 2865): watchface-loader.cpp: OnAppTimeTick(579) > 
06-07 17:26:22.401+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
06-07 17:26:22.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:22.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20992
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
06-07 17:26:25.301+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11211886c6f63152838506
