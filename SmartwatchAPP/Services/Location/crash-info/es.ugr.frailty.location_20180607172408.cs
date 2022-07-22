S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21171
Date: 2018-06-07 17:24:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf722a52d, r5   = 0xf7487f98
r6   = 0xff9a3350, r7   = 0xff9a3200
r8   = 0xf7484c18, r9   = 0x00000000
r10  = 0xff9a32dc, fp   = 0xff9a3350
ip   = 0x00000001, sp   = 0xff9a31d8
lr   = 0xf722a539, pc   = 0xf7293228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    257676 KB
Buffers:     15536 KB
Cached:     112308 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11940 KB
VmRSS:       11940 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21171 TID = 21171
21171 21175 

Maps Information
f40f5000 f48f4000 rw-p [stack:21175]
f48fb000 f48fd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4905000 f4909000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4912000 f4914000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f491c000 f491f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f492e000 f4933000 r-xp /usr/lib/libsystem.so.0.0.0
f493e000 f4941000 r-xp /lib/libattr.so.1.1.0
f4949000 f4959000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4961000 f496a000 r-xp /usr/lib/libedbus.so.1.7.99
f4972000 f4973000 r-xp /usr/lib/libresponse.so.0.2.96
f497c000 f4981000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6223000 f6329000 r-xp /usr/lib/libicuuc.so.57.1
f633f000 f64c7000 r-xp /usr/lib/libicui18n.so.57.1
f64d7000 f64e4000 r-xp /usr/lib/libail.so.0.1.0
f64ed000 f64f4000 r-xp /usr/lib/libminizip.so.1.0.0
f64fd000 f66a6000 r-xp /usr/lib/libcrypto.so.1.0.0
f66c6000 f670d000 r-xp /usr/lib/libssl.so.1.0.0
f6719000 f671b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6723000 f672a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6733000 f673a000 r-xp /lib/libcrypt-2.13.so
f676b000 f676e000 r-xp /lib/libcap.so.2.21
f6776000 f6778000 r-xp /usr/lib/libiri.so
f6780000 f67c9000 r-xp /usr/lib/libmdm.so.1.2.69
f67d1000 f67d7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67df000 f6802000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f680c000 f680e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6816000 f6833000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f683c000 f6840000 r-xp /usr/lib/libsmack.so.1.0.0
f6849000 f6862000 r-xp /usr/lib/libnetwork.so.0.0.0
f686b000 f6873000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f687b000 f6881000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f688a000 f688c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6895000 f68a5000 r-xp /lib/libresolv-2.13.so
f68a9000 f68c1000 r-xp /usr/lib/liblzma.so.5.0.3
f68ca000 f68cc000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68d4000 f68ee000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68f6000 f6925000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f692e000 f693d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6947000 f6951000 r-xp /usr/lib/libsensord-shared.so
f695a000 f6a2d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a38000 f6a4e000 r-xp /lib/libz.so.1.2.5
f6a56000 f6a5b000 r-xp /usr/lib/libffi.so.5.0.10
f6a63000 f6a64000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a6c000 f6a7c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a84000 f6a9d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6aa5000 f6aa7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6aaf000 f6b24000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b2e000 f6b34000 r-xp /lib/librt-2.13.so
f6b3d000 f6b5b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b65000 f6b66000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b6e000 f6b91000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b99000 f6b9e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ba6000 f6bd0000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bd9000 f6bf0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bf8000 f6c61000 r-xp /lib/libm-2.13.so
f6c6a000 f6cfe000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d11000 f6d16000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d1e000 f6d25000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d2d000 f6d57000 r-xp /usr/lib/libsensor.so.1.9.6
f6d60000 f6e2c000 r-xp /usr/lib/libxml2.so.2.7.8
f6e39000 f6e3b000 r-xp /usr/lib/libiniparser.so.0
f6e44000 f6e4a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e53000 f6f23000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f24000 f6f58000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f61000 f6f9d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fa5000 f6fa8000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb0000 f6fb6000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fbe000 f6fff000 r-xp /usr/lib/libeina.so.1.7.99
f7008000 f701f000 r-xp /usr/lib/libecore.so.1.7.99
f7036000 f703f000 r-xp /usr/lib/libvconf.so.0.2.45
f7047000 f705b000 r-xp /lib/libpthread-2.13.so
f7066000 f7073000 r-xp /usr/lib/libaul.so.0.1.0
f707d000 f707f000 r-xp /lib/libdl-2.13.so
f7088000 f7093000 r-xp /lib/libunwind.so.8.0.1
f70c0000 f70c8000 r-xp /lib/libgcc_s-4.6.so.1
f70c9000 f71ed000 r-xp /lib/libc-2.13.so
f71fb000 f71fd000 r-xp /usr/lib/libdlog.so.0.0.0
f7205000 f7211000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f721a000 f721f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7227000 f7236000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f723e000 f7242000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f724b000 f724e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7256000 f7258000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7260000 f7264000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f726c000 f7289000 r-xp /lib/ld-2.13.so
f7292000 f7295000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7295000 f7299000 r-xp /usr/lib/libsys-assert.so
f7454000 f74e2000 rw-p [heap]
ff984000 ff9a5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21171)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7293228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf722a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f313f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f2fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f3be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f41be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f41dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f7675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f711f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f2fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f3be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f41be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f41dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f73e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f74017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f7bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49131fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4906171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69d9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e86fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e887a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7018ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7013b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70145a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7014879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf724c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf724c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72935c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70e085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7292f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
signed_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
06-07 17:26:05.161+0200 W/CoreGL  (20785): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
06-07 17:26:05.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.191+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:05.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.301+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.311+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:05.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:05.361+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:05.361+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:05.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.421+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:05:365,613.000000
06-07 17:26:05.421+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.421+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:05:324,-0.070000,0.070000,0.140000
06-07 17:26:05.471+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:05.471+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:05.481+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:05:476,626.000000
06-07 17:26:05.491+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:05:482,0.140000,0.070000,0.140000
06-07 17:26:05.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.531+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.561+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:05.561+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:05.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.691+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:05.691+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:05.761+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.761+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:05:768,628.000000
06-07 17:26:05.761+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:05.761+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:05.761+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:05:765,0.070000,0.070000,0.070000
06-07 17:26:05.851+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:05.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:05.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:05:858,0.070000,0.070000,0.070000
06-07 17:26:05.861+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:05:865,629.000000
06-07 17:26:05.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.871+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:05.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:05.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:05.981+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:05.991+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.061+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:06.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:06.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:06:66,0.070000,0.070000,0.070000
06-07 17:26:06.061+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:06:70,631.000000
06-07 17:26:06.091+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.101+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:06.211+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.211+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:06.211+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.251+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:06.251+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:06.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.251+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:06.251+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:06.251+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.251+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.251+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:06.251+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.251+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:06.251+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:06.261+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:06:259,633.000000
06-07 17:26:06.271+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.271+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.271+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:06:260,0.070000,0.070000,0.070000
06-07 17:26:06.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.271+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.271+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:06.271+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.271+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:06.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:06.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.301+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:06.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.301+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:06.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:06.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.311+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:06.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.311+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:06.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:06.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.341+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.361+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.361+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.361+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:06.361+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.361+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:06.361+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:06.371+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:06.381+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:06.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.381+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.381+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.381+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.381+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:06.381+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.381+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:06.381+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:06.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.421+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.421+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.421+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:06.421+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.421+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:06.421+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:06.471+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:06.471+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:06.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.481+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:06:482,635.000000
06-07 17:26:06.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.481+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:06:477,0.070000,0.070000,0.070000
06-07 17:26:06.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.491+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.491+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.491+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:06.491+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.491+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:06.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:06.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:06.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:06.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:06.531+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:06.531+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:06.531+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:06.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.601+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:06.601+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:06.661+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:06.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:06.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:06:666,0.070000,0.070000,0.070000
06-07 17:26:06.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:06:670,638.000000
06-07 17:26:06.701+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.711+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.821+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.891+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:06.891+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:06.891+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:06.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:06.931+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:06.961+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:06.961+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:06:966,0.070000,0.070000,0.140000
06-07 17:26:06.961+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:06:901,638.000000
06-07 17:26:06.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:06.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:07.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.041+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.161+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:07.241+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:07.241+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:07.241+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:07.241+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:07.241+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:07:250,0.070000,-0.070000,0.070000
06-07 17:26:07.251+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:07:247,638.000000
06-07 17:26:07.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:07.251+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:07.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.271+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:07:266,639.000000
06-07 17:26:07.271+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.271+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:07:265,0.070000,-0.070000,0.070000
06-07 17:26:07.371+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:07.371+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:07.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.451+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:07.451+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:07:459,638.000000
06-07 17:26:07.461+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:07.461+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:07:465,0.070000,-0.070000,0.070000
06-07 17:26:07.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.491+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.561+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:07.561+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:07.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.601+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.651+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:07.651+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:07.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.711+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.781+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:07.781+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:07.781+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:07:665,638.000000
06-07 17:26:07.811+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:07:675,0.070000,0.070000,0.070000
06-07 17:26:07.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.821+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:07.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:07:867,0.070000,0.070000,0.070000
06-07 17:26:07.871+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:07.871+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:07:876,638.000000
06-07 17:26:07.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:07.931+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:07.961+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:07.961+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:08.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.051+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:08.071+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:08.071+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:08:75,635.000000
06-07 17:26:08.071+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:08:73,0.140000,0.070000,0.140000
06-07 17:26:08.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.161+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:08.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:08.261+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:08.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.271+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:08.271+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:08:275,628.000000
06-07 17:26:08.271+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:08:272,0.070000,0.070000,0.070000
06-07 17:26:08.271+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.361+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:08.361+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:08.381+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.391+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.451+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:08.451+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:08.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.461+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:08.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.501+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.551+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:08.551+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:08:555,0.070000,0.070000,0.070000
06-07 17:26:08.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.551+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.551+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:08.551+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.561+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:08.561+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:08.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.571+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.571+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:08.571+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:08.581+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:08:472,619.000000
06-07 17:26:08.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.591+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.591+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:08.591+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.591+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:08.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:08.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.601+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.601+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.611+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.611+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.611+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:08.611+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.611+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:08.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:08.611+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.621+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.621+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:08.621+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.621+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:08.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:08.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.621+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.621+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.621+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:08.621+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.621+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:08.621+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:08.621+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.621+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.631+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.631+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.631+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:08.631+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.631+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:08.631+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:08.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.631+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.631+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.631+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.631+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:08.631+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.631+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:08.631+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:08.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.631+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.641+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.641+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.641+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:08.641+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.641+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:08.641+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:08.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:08.641+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:08.641+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:08.641+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:08.641+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:08.641+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:08.661+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:08.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:08.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:08:666,-0.070000,-0.070000,0.070000
06-07 17:26:08.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:08:665,614.000000
06-07 17:26:08.711+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(21418)
06-07 17:26:08.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:08.711+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.gyroscope) pid(21418) type(svcapp)
06-07 17:26:08.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:26:08.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:26:08.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21418), cmd(4)
06-07 17:26:08.721+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:26:08.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.771+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:08.771+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:08.791+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:08.801+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:08.821+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope listener destroyed
06-07 17:26:08.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.841+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:08.851+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:08.861+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:08:860,607.000000
06-07 17:26:08.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:08.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:08.961+0200 W/AUL     (21567): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
06-07 17:26:08.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:26:08.961+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:08.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 21017
06-07 17:26:08.961+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:26:08.971+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21017
06-07 17:26:08.971+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21017)
06-07 17:26:08.971+0200 E/AUL     (21567): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:26:09.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.051+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21023
06-07 17:26:09.051+0200 E/rpm-installer(21496): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.heartrate] is running, need to terminate it.
06-07 17:26:09.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:26:09.061+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(21023)
06-07 17:26:09.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:09.061+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.heartrate) pid(21023) type(svcapp)
06-07 17:26:09.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:26:09.061+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:26:09.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21023), cmd(4)
06-07 17:26:09.061+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:26:09.071+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.071+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21023
06-07 17:26:09.111+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.121+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.151+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:09.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate listener destroyed
06-07 17:26:09.161+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:09:157,612.000000
06-07 17:26:09.181+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.181+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21023
06-07 17:26:09.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:09.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.301+0200 W/AUL     (21570): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
06-07 17:26:09.341+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:09.341+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:09:346,614.000000
06-07 17:26:09.341+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:26:09.341+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 21023
06-07 17:26:09.341+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:26:09.351+0200 E/AUL     (21570): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:26:09.351+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21023
06-07 17:26:09.351+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21023)
06-07 17:26:09.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.401+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21071
06-07 17:26:09.401+0200 E/rpm-installer(21496): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.light] is running, need to terminate it.
06-07 17:26:09.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:26:09.401+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(21071)
06-07 17:26:09.401+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:09.411+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.light) pid(21071) type(svcapp)
06-07 17:26:09.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:26:09.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:26:09.411+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21071), cmd(4)
06-07 17:26:09.421+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:26:09.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.431+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21071
06-07 17:26:09.481+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.491+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.501+0200 I/light   (21071): es.ugr.frailty.light listener destroyed
06-07 17:26:09.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.541+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21071
06-07 17:26:09.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.651+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.661+0200 W/AUL     (21573): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.light]
06-07 17:26:09.671+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:26:09.671+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.671+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: restart, dead pid: 21071
06-07 17:26:09.671+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:26:09.671+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.681+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.691+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21071
06-07 17:26:09.691+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21071)
06-07 17:26:09.691+0200 E/AUL     (21573): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
06-07 17:26:09.701+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.711+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
06-07 17:26:09.721+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.731+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21084
06-07 17:26:09.731+0200 E/rpm-installer(21496): installer-util.c: __check_running_app(1774) > app[es.ugr.frailty.pedometer] is running, need to terminate it.
06-07 17:26:09.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 17:26:09.741+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(284) > request cmd(5) to(21084)
06-07 17:26:09.741+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 5
06-07 17:26:09.741+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminate_request_signal(627) > aul_send_app_terminate_request_signal app(es.ugr.frailty.pedometer) pid(21084) type(svcapp)
06-07 17:26:09.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:26:09.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:26:09.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21084), cmd(4)
06-07 17:26:09.751+0200 W/AUL     (21496): launch.c: app_request_to_launchpad(298) > request cmd(5) result(0)
06-07 17:26:09.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.761+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21084
06-07 17:26:09.811+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.821+0200 E/PKGMGR_INFO( 2975): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
06-07 17:26:09.831+0200 I/pedometer(21084): es.ugr.frailty.pedometer listener destroyed
06-07 17:26:09.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:09.871+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21084
06-07 17:26:09.911+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11211716c6f63152838504
