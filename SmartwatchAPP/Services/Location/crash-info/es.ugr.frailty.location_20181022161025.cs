S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4544
Date: 2018-10-22 16:10:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf726852d, r5   = 0xf77b6fe0
r6   = 0xffe758a0, r7   = 0xffe75750
r8   = 0xf7788c18, r9   = 0x00000000
r10  = 0xffe7582c, fp   = 0xffe758a0
ip   = 0x00000001, sp   = 0xffe75728
lr   = 0xf7268539, pc   = 0xf72d1270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5652 KB
Buffers:     35988 KB
Cached:     233804 KB
VmPeak:      53520 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11900 KB
VmRSS:       11900 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4544 TID = 4544
4544 4615 

Maps Information
f4133000 f4932000 rw-p [stack:4615]
f4939000 f493b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4943000 f4947000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4950000 f4952000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f495a000 f495d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f496c000 f4971000 r-xp /usr/lib/libsystem.so.0.0.0
f497c000 f497f000 r-xp /lib/libattr.so.1.1.0
f4987000 f4997000 r-xp /usr/lib/libmdm-common.so.1.1.24
f499f000 f49a8000 r-xp /usr/lib/libedbus.so.1.7.99
f49b0000 f49b1000 r-xp /usr/lib/libresponse.so.0.2.96
f49ba000 f49bf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6261000 f6367000 r-xp /usr/lib/libicuuc.so.57.1
f637d000 f6505000 r-xp /usr/lib/libicui18n.so.57.1
f6515000 f6522000 r-xp /usr/lib/libail.so.0.1.0
f652b000 f6532000 r-xp /usr/lib/libminizip.so.1.0.0
f653b000 f66e4000 r-xp /usr/lib/libcrypto.so.1.0.0
f6704000 f674b000 r-xp /usr/lib/libssl.so.1.0.0
f6757000 f6759000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6761000 f6768000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6771000 f6778000 r-xp /lib/libcrypt-2.13.so
f67a9000 f67ac000 r-xp /lib/libcap.so.2.21
f67b4000 f67b6000 r-xp /usr/lib/libiri.so
f67be000 f6807000 r-xp /usr/lib/libmdm.so.1.2.69
f680f000 f6815000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f681d000 f6840000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f684a000 f684c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6854000 f6871000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f687a000 f687e000 r-xp /usr/lib/libsmack.so.1.0.0
f6887000 f68a0000 r-xp /usr/lib/libnetwork.so.0.0.0
f68a9000 f68b1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68b9000 f68bf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68c8000 f68ca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68d3000 f68e3000 r-xp /lib/libresolv-2.13.so
f68e7000 f68ff000 r-xp /usr/lib/liblzma.so.5.0.3
f6908000 f690a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6912000 f692c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6934000 f6963000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f696c000 f697b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6985000 f698f000 r-xp /usr/lib/libsensord-shared.so
f6998000 f6a6b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a76000 f6a8c000 r-xp /lib/libz.so.1.2.5
f6a94000 f6a99000 r-xp /usr/lib/libffi.so.5.0.10
f6aa1000 f6aa2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aaa000 f6aba000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ac2000 f6adb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ae3000 f6ae5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6aed000 f6b62000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b6c000 f6b8a000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b94000 f6b95000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b9d000 f6bc0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bc8000 f6bcd000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bd5000 f6bff000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c08000 f6c1f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c27000 f6c2d000 r-xp /lib/librt-2.13.so
f6c36000 f6c9f000 r-xp /lib/libm-2.13.so
f6ca8000 f6d3c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d4f000 f6d54000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d5c000 f6d63000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d6b000 f6d95000 r-xp /usr/lib/libsensor.so.1.9.6
f6d9e000 f6e6a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e77000 f6e79000 r-xp /usr/lib/libiniparser.so.0
f6e82000 f6e88000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e91000 f6f61000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f62000 f6f96000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f9f000 f6fdb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fe3000 f6fe6000 r-xp /usr/lib/libbundle.so.0.1.22
f6fee000 f6ff4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ffc000 f703d000 r-xp /usr/lib/libeina.so.1.7.99
f7046000 f704f000 r-xp /usr/lib/libvconf.so.0.2.45
f7057000 f706b000 r-xp /lib/libpthread-2.13.so
f7076000 f7083000 r-xp /usr/lib/libaul.so.0.1.0
f708d000 f708f000 r-xp /lib/libdl-2.13.so
f7098000 f70a3000 r-xp /lib/libunwind.so.8.0.1
f70d0000 f70d8000 r-xp /lib/libgcc_s-4.6.so.1
f70d9000 f71fd000 r-xp /lib/libc-2.13.so
f720b000 f7222000 r-xp /usr/lib/libecore.so.1.7.99
f7239000 f723b000 r-xp /usr/lib/libdlog.so.0.0.0
f7243000 f724f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7258000 f725d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7265000 f7274000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f727c000 f7280000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7289000 f728c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7294000 f7296000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f729e000 f72a2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72aa000 f72c7000 r-xp /lib/ld-2.13.so
f72d0000 f72d3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72d3000 f72d7000 r-xp /usr/lib/libsys-assert.so
f7782000 f77f3000 rw-p [heap]
ffe57000 ffe78000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4544)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72d1270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf7268539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f6f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f6dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f79e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f7fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f7fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fb475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6faf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f6dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f79e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f7fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f7fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fb1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fb2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fb9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49511fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4944171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a17663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ec4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ec67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf721bca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7216b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72175a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7217879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf728a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf728a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72d160b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf70f085c) [/lib/libc.so.6] + 0x1785c
29: (0xf72d0f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
yroscope: SM-R760,22/10/2018,16:10:25.311,-0.070000,0.140000,0.070000
10-22 16:10:25.321+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.321+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.308,-0.090927,9.774680,1.038485
10-22 16:10:25.321+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.321+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.308,-0.106829,9.751184,1.036036
10-22 16:10:25.321+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.321+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.321,0.016845,0.011500,0.026771
10-22 16:10:25.321+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.331+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.329,-0.107070,9.751319,1.034742
10-22 16:10:25.331+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.331+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.326,-0.070000,0.070000,0.070000
10-22 16:10:25.331+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.331+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.334,-0.008027,0.033068,-0.009515
10-22 16:10:25.331+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.341+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.328,-0.093320,9.803394,1.040878
10-22 16:10:25.341+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.341+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.342,-0.070000,0.070000,0.070000
10-22 16:10:25.341+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.341+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.338,-0.106159,9.751409,1.033995
10-22 16:10:25.341+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.351+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3659.911271] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.351+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.346,-0.112463,9.791430,1.055235
10-22 16:10:25.351+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.351+0200 I/light   ( 4584): es.ugr.frailty.light - capturing data
10-22 16:10:25.351+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.349,-0.105385,9.751487,1.033336
10-22 16:10:25.361+0200 I/light   ( 4584): es.ugr.frailty.light: SM-R760,22/10/2018,16:10:25.363,26.000000
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.346,-0.070000,0.140000,0.070000
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.367,-0.070000,0.140000,0.070000
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.371,-0.070000,0.070000,0.070000
10-22 16:10:25.361+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.371+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.344,0.016143,0.023361,0.003743
10-22 16:10:25.371+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.371+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.371+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.376,0.012839,0.051986,0.006883
10-22 16:10:25.371+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.371+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.375,-0.105565,9.751463,1.033543
10-22 16:10:25.371+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.381+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.357,-0.119641,9.781858,1.045663
10-22 16:10:25.381+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.381+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3659.945014] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.381+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.380,-0.106085,9.751473,1.033392
10-22 16:10:25.381+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.388,-0.078963,9.796216,1.071985
10-22 16:10:25.381+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.391+0200 W/AUL     ( 4551): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
10-22 16:10:25.391+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.391+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.380,-0.007078,0.039944,0.021899
10-22 16:10:25.391+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.391+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4551
10-22 16:10:25.391+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.375,-0.070000,0.070000,0.070000
10-22 16:10:25.391+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.391+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.400,-0.070000,0.070000,0.070000
10-22 16:10:25.391+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.401+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4501
10-22 16:10:25.401+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.394,-0.138784,9.784252,1.055235
10-22 16:10:25.401+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.401+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4501), cmd(0)
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 I/utils   ( 4501): specific action
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.401+0200 I/servicemanager( 4501): requesting to save local data for es.ugr.frailty.gravity
10-22 16:10:25.401+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
10-22 16:10:25.401+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.401+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4501
10-22 16:10:25.411+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.411+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.418,-0.110070,9.757930,1.064806
10-22 16:10:25.411+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4504
10-22 16:10:25.421+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.398,-0.014077,0.030396,0.012120
10-22 16:10:25.421+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.421+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3659.985848] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.421+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.421+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4504), cmd(0)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 I/utils   ( 4504): specific action
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.421+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.431+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.403,-0.140000,0.070000,0.070000
10-22 16:10:25.431+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.431+0200 I/recorder( 4504): saving local data for es.ugr.frailty.gravity
10-22 16:10:25.431+0200 I/recorder( 4504): es.ugr.frailty.gravity file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
10-22 16:10:25.431+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4504)
10-22 16:10:25.431+0200 I/servicemanager( 4501): request sent to service es.ugr.frailty.recorder
10-22 16:10:25.431+0200 I/servicemanager( 4501): requesting to save local data
10-22 16:10:25.431+0200 W/AUL     ( 4551): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4501)
10-22 16:10:25.431+0200 I/gravity ( 4551): request sent to service es.ugr.frailty.servicemanager
10-22 16:10:25.431+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.431+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.436,-0.070000,0.070000,0.070000
10-22 16:10:25.431+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.431+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.431+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.437,-0.104653,9.751406,1.034177
10-22 16:10:25.431+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.441+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.442,-0.106120,9.751345,1.034600
10-22 16:10:25.441+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.441+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.426,0.027121,0.044743,0.038593
10-22 16:10:25.441+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.451+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.012102] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.451+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.442,-0.136391,9.796216,1.069592
10-22 16:10:25.451+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.451+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.447,-0.106169,9.751266,1.035339
10-22 16:10:25.451+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.451+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.452,-0.034131,0.032846,0.021058
10-22 16:10:25.451+0200 W/AUL     ( 4549): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
10-22 16:10:25.461+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.459,-0.107441,9.751148,1.036317
10-22 16:10:25.461+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.461+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.466,-0.106511,9.751220,1.035738
10-22 16:10:25.461+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.461+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.458,-0.090927,9.762716,1.040878
10-22 16:10:25.461+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.461+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.470,-0.105951,9.751167,1.036291
10-22 16:10:25.471+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.471+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4549
10-22 16:10:25.471+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.481+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.484,-0.106821,9.751123,1.036611
10-22 16:10:25.481+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4501
10-22 16:10:25.481+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.473,-0.098106,9.805787,1.069592
10-22 16:10:25.481+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.491+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.491,-0.126820,9.757930,1.057628
10-22 16:10:25.491+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.051222] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.491+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.491+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4501), cmd(0)
10-22 16:10:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.491+0200 I/utils   ( 4501): specific action
10-22 16:10:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.491+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.491+0200 I/servicemanager( 4501): requesting to save local data for es.ugr.frailty.linearacceleration
10-22 16:10:25.491+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
10-22 16:10:25.491+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.491+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.491+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4501
10-22 16:10:25.501+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.502,-0.108305,9.750987,1.037738
10-22 16:10:25.501+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.501+0200 I/heartrate( 4522): es.ugr.frailty.heartrate - capturing data
10-22 16:10:25.501+0200 I/heartrate( 4522): es.ugr.frailty.heartrate: waiting for rigth values
10-22 16:10:25.501+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.507,-0.141177,9.765109,1.069592
10-22 16:10:25.501+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4504
10-22 16:10:25.511+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.511+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4504), cmd(0)
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 I/utils   ( 4504): specific action
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.511+0200 I/recorder( 4504): saving local data for es.ugr.frailty.linearacceleration
10-22 16:10:25.511+0200 I/recorder( 4504): es.ugr.frailty.linearacceleration file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
10-22 16:10:25.511+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4504)
10-22 16:10:25.511+0200 I/servicemanager( 4501): request sent to service es.ugr.frailty.recorder
10-22 16:10:25.511+0200 I/servicemanager( 4501): requesting to save local data
10-22 16:10:25.511+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.511+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.511+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.078531] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.511+0200 W/AUL     ( 4549): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4501)
10-22 16:10:25.511+0200 I/linearacceleration( 4549): request sent to service es.ugr.frailty.servicemanager
10-22 16:10:25.511+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.521+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.522,-0.109353,9.750629,1.040985
10-22 16:10:25.521+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.523,-0.133998,9.791430,1.119841
10-22 16:10:25.521+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.440,-0.070000,0.070000,0.070000
10-22 16:10:25.521+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.531+0200 E/CAPI_APPFW_APP_CONTROL( 4571): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
10-22 16:10:25.531+0200 E/pressure( 4571): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pressure; data: 
10-22 16:10:25.531+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.524,-0.003950,0.006585,0.030206
10-22 16:10:25.531+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.531+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.533,-0.070000,0.070000,0.070000
10-22 16:10:25.531+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.531+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.536,-0.030222,0.044950,0.034253
10-22 16:10:25.531+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.531+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.537,-0.070000,0.070000,0.070000
10-22 16:10:25.531+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.531+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.531+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.541,-0.070000,0.070000,0.070000
10-22 16:10:25.541+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.541+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.541+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.545,-0.070000,0.210000,0.070000
10-22 16:10:25.541+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.541+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.542,-0.107899,9.750501,1.042341
10-22 16:10:25.541+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.545,-0.081356,9.748360,1.091127
10-22 16:10:25.551+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.111757] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.551+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.549,-0.070000,0.070000,0.070000
10-22 16:10:25.551+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.551+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.540,0.016513,0.011568,0.004561
10-22 16:10:25.551+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.551+0200 I/light   ( 4584): es.ugr.frailty.light - capturing data
10-22 16:10:25.561+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.559,-0.070000,0.070000,0.070000
10-22 16:10:25.561+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.561+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.561+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.566,-0.070000,0.070000,0.070000
10-22 16:10:25.561+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.567,-0.108979,9.750556,1.041712
10-22 16:10:25.561+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.561+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.561+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.570,-0.070000,0.070000,0.070000
10-22 16:10:25.561+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.570,-0.133998,9.805787,1.045663
10-22 16:10:25.571+0200 I/light   ( 4584): es.ugr.frailty.light: SM-R760,22/10/2018,16:10:25.563,26.000000
10-22 16:10:25.571+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.562,0.008406,0.054567,0.033854
10-22 16:10:25.571+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.581+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.581+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.586,-0.070000,0.140000,0.070000
10-22 16:10:25.581+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.581+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.145408] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.581+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.581,-0.020869,0.006763,0.021336
10-22 16:10:25.581+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.581+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.591+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.593,-0.124427,9.779467,1.045663
10-22 16:10:25.591+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.590,-0.109574,9.750612,1.041126
10-22 16:10:25.591+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.592,-0.034356,0.013986,0.032981
10-22 16:10:25.591+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.591+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.591+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.600,-0.025693,0.040443,0.082103
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.601+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.605,-0.109924,9.750746,1.039838
10-22 16:10:25.601+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.606,0.027997,-0.002270,0.050143
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.601+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.609,-0.070000,0.070000,0.070000
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.610,-0.026099,0.055286,0.003323
10-22 16:10:25.601+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.601+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.602,-0.119641,9.753145,1.026521
10-22 16:10:25.611+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.613,-0.015448,0.028911,0.003952
10-22 16:10:25.611+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.611+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.611+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.611+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.178760] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.611+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.621+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.623,-0.102891,9.753145,1.050449
10-22 16:10:25.621+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.624,-0.010067,0.002533,-0.014605
10-22 16:10:25.621+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.621+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.630,0.007032,0.002399,0.010612
10-22 16:10:25.621+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.623,-0.070000,0.070000,0.070000
10-22 16:10:25.631+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.622,-0.109451,9.750772,1.039643
10-22 16:10:25.631+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.631+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.631+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.641+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.642,-0.093320,9.777073,1.024128
10-22 16:10:25.641+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.641+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.645,-0.070000,0.280000,0.070000
10-22 16:10:25.641+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.642,0.016130,0.026301,-0.015515
10-22 16:10:25.651+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.211597] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.651+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.646,-0.108554,9.750967,1.037904
10-22 16:10:25.651+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.651+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.661+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.664,0.034377,0.042856,0.048437
10-22 16:10:25.661+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.661+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.664,-0.074178,9.793823,1.086342
10-22 16:10:25.661+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.669,-0.070000,0.140000,0.070000
10-22 16:10:25.661+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.671+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.673,-0.106786,9.750888,1.038828
10-22 16:10:25.671+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.681+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.684,-0.057428,9.779467,1.038485
10-22 16:10:25.681+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.691+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.250367] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.691+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.691,-0.070000,-0.070000,0.070000
10-22 16:10:25.691+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.691+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.691+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.691+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.691+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.696,0.049358,0.028579,-0.000343
10-22 16:10:25.691+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.701+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.705,0.001364,0.030849,0.012505
10-22 16:10:25.701+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.702,-0.070000,-0.070000,0.070000
10-22 16:10:25.701+0200 I/heartrate( 4522): es.ugr.frailty.heartrate - capturing data
10-22 16:10:25.701+0200 I/heartrate( 4522): es.ugr.frailty.heartrate: waiting for rigth values
10-22 16:10:25.701+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.703,-0.102891,9.781858,1.050449
10-22 16:10:25.701+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.698,-0.104255,9.751010,1.037944
10-22 16:10:25.701+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.711+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.713,-0.104022,9.751023,1.037841
10-22 16:10:25.711+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.711+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.711+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.279390] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.711+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.721+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.724,-0.070000,-0.070000,0.070000
10-22 16:10:25.721+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.725,-0.039547,0.035622,0.026965
10-22 16:10:25.721+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.722,-0.143569,9.786645,1.064806
10-22 16:10:25.721+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.731+0200 W/AUL     ( 4584): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
10-22 16:10:25.731+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.731,-0.105724,9.750909,1.038737
10-22 16:10:25.731+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.731+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4584
10-22 16:10:25.731+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.741+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4501
10-22 16:10:25.741+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.741+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4501), cmd(0)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 I/utils   ( 4501): specific action
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 W/CAPI_APPFW_APP_CONTROL( 4501): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.741+0200 I/servicemanager( 4501): requesting to save local data for es.ugr.frailty.light
10-22 16:10:25.741+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
10-22 16:10:25.741+0200 W/AUL_AMD ( 2480): amd_request.c: __request_handler(669) > __request_handler: 0
10-22 16:10:25.741+0200 W/AUL_AMD ( 2480): amd_launch.c: _start_app(1782) > caller pid : 4501
10-22 16:10:25.751+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.318080] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.761+0200 W/AUL_AMD ( 2480): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4504
10-22 16:10:25.761+0200 W/AUL     ( 4584): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4501)
10-22 16:10:25.761+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.761+0200 E/AUL_AMD ( 2480): amd_launch.c: __real_send(909) > send fail to client
10-22 16:10:25.761+0200 W/AUL_AMD ( 2480): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4504), cmd(0)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 I/utils   ( 4504): specific action
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 W/CAPI_APPFW_APP_CONTROL( 4504): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
10-22 16:10:25.761+0200 I/recorder( 4504): saving local data for es.ugr.frailty.light
10-22 16:10:25.761+0200 I/recorder( 4504): es.ugr.frailty.light file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
10-22 16:10:25.761+0200 I/light   ( 4584): request sent to service es.ugr.frailty.servicemanager
10-22 16:10:25.761+0200 I/light   ( 4584): es.ugr.frailty.light - capturing data
10-22 16:10:25.771+0200 W/AUL     ( 4501): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4504)
10-22 16:10:25.771+0200 I/servicemanager( 4501): request sent to service es.ugr.frailty.recorder
10-22 16:10:25.771+0200 I/servicemanager( 4501): requesting to save local data
10-22 16:10:25.771+0200 I/light   ( 4584): es.ugr.frailty.light: SM-R760,22/10/2018,16:10:25.775,26.000000
10-22 16:10:25.771+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.769,-0.138784,9.774680,1.048056
10-22 16:10:25.771+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.771+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.771+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.742,-0.070000,-0.070000,0.070000
10-22 16:10:25.771+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.781+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.780,-0.033060,0.023771,0.009319
10-22 16:10:25.781+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.781+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.346640] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.781+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.791+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.788,-0.017291,-0.012103,-0.017025
10-22 16:10:25.791+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.801+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.784,-0.070000,0.070000,0.070000
10-22 16:10:25.801+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.801+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.797,-0.004621,0.035621,0.008223
10-22 16:10:25.801+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.801+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.807,-0.070000,0.070000,0.070000
10-22 16:10:25.801+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.801+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.811,0.048087,-0.033814,0.013421
10-22 16:10:25.801+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.811,0.070000,-0.070000,0.070000
10-22 16:10:25.801+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.780,-0.107136,9.750892,1.038760
10-22 16:10:25.811+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.792,-0.124427,9.738789,1.021735
10-22 16:10:25.811+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.811+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.821+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.381691] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.821+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.831+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.831,-0.002217,0.025943,0.011368
10-22 16:10:25.831+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.841+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.844,-0.009471,0.037864,0.035697
10-22 16:10:25.841+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.817,-0.112463,9.786645,1.045663
10-22 16:10:25.841+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.841+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.821,-0.107841,9.751024,1.037440
10-22 16:10:25.851+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.851+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.412920] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.851+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.850,-0.059821,9.717253,1.050449
10-22 16:10:25.851+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.851+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.857,-0.107908,9.751067,1.037029
10-22 16:10:25.851+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.851+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.861+0200 E/CAPI_APPFW_APP_CONTROL( 4590): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
10-22 16:10:25.861+0200 E/pedometer( 4590): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pedometer; data: 
10-22 16:10:25.861+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.864,-0.018765,0.021177,0.006410
10-22 16:10:25.861+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.864,-0.105460,9.751130,1.036688
10-22 16:10:25.861+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.861+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.861,-0.107677,9.777073,1.048056
10-22 16:10:25.861+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.871+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.871+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope: SM-R760,22/10/2018,16:10:25.875,0.070000,-0.070000,0.070000
10-22 16:10:25.871+0200 I/gyroscope( 4511): es.ugr.frailty.gyroscope - capturing data
10-22 16:10:25.871+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.874,-0.114855,9.789038,1.071985
10-22 16:10:25.871+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.871+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.881+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.447357] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.891+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.883,-0.003674,-0.005204,0.038172
10-22 16:10:25.891+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.880,-0.124427,9.772287,1.043271
10-22 16:10:25.901+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.911+0200 I/heartrate( 4522): es.ugr.frailty.heartrate - capturing data
10-22 16:10:25.911+0200 I/heartrate( 4522): es.ugr.frailty.heartrate: waiting for rigth values
10-22 16:10:25.911+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.906,-0.015612,0.047529,-0.008152
10-22 16:10:25.921+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.480106] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.921+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.921+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.931+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.926,-0.003076,0.023446,0.031644
10-22 16:10:25.931+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.927,-0.110070,9.745967,1.074377
10-22 16:10:25.931+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.931+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.941+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.939,-0.122034,9.798609,1.028914
10-22 16:10:25.941+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.941+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.942,-0.000701,0.028324,-0.009898
10-22 16:10:25.941+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.947,-0.110070,9.774680,1.067199
10-22 16:10:25.951+0200 I/gravity ( 4551): es.ugr.frailty.gravity: SM-R760,22/10/2018,16:10:25.874,-0.105384,9.751174,1.036288
10-22 16:10:25.951+0200 I/gravity ( 4551): es.ugr.frailty.gravity - capturing data
10-22 16:10:25.951+0200 I/TDM     ( 1837): tdm_pp.c: tdm_pp_set_info(322) > [3660.515526] pp(0x702698) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
10-22 16:10:25.951+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.961+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration - capturing data
10-22 16:10:25.961+0200 I/linearacceleration( 4549): es.ugr.frailty.linearacceleration: SM-R760,22/10/2018,16:10:25.968,0.018603,0.037940,0.047122
10-22 16:10:25.961+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.961,-0.107677,9.779467,1.026521
10-22 16:10:25.961+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer - capturing data
10-22 16:10:25.971+0200 I/accelerometer( 4508): es.ugr.frailty.accelerometer: SM-R760,22/10/2018,16:10:25.974,-0.088534,9.789038,1.083949
10-22 16:10:25.981+0200 W/CRASH_MANAGER( 4632): worker.c: worker_job(1205) > 11045446c6f63154021742
