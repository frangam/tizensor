S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 25998
Date: 2018-06-07 18:00:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74ca52d, r5   = 0xf77d9f98
r6   = 0xff805a80, r7   = 0xff805930
r8   = 0xf77d6c18, r9   = 0x00000000
r10  = 0xff805a0c, fp   = 0xff805a80
ip   = 0x00000001, sp   = 0xff805908
lr   = 0xf74ca539, pc   = 0xf7533228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    278700 KB
Buffers:      8856 KB
Cached:     103228 KB
VmPeak:      53592 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11936 KB
VmRSS:       11936 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 25998 TID = 25998
25998 26066 

Maps Information
f4395000 f4b94000 rw-p [stack:26066]
f4b9b000 f4b9d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ba5000 f4ba9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bb2000 f4bb4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bbc000 f4bbf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bce000 f4bd3000 r-xp /usr/lib/libsystem.so.0.0.0
f4bde000 f4be1000 r-xp /lib/libattr.so.1.1.0
f4be9000 f4bf9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c01000 f4c0a000 r-xp /usr/lib/libedbus.so.1.7.99
f4c12000 f4c13000 r-xp /usr/lib/libresponse.so.0.2.96
f4c1c000 f4c21000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64c3000 f65c9000 r-xp /usr/lib/libicuuc.so.57.1
f65df000 f6767000 r-xp /usr/lib/libicui18n.so.57.1
f6777000 f6784000 r-xp /usr/lib/libail.so.0.1.0
f678d000 f6794000 r-xp /usr/lib/libminizip.so.1.0.0
f679d000 f6946000 r-xp /usr/lib/libcrypto.so.1.0.0
f6966000 f69ad000 r-xp /usr/lib/libssl.so.1.0.0
f69b9000 f69bb000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69c3000 f69ca000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69d3000 f69da000 r-xp /lib/libcrypt-2.13.so
f6a0b000 f6a0e000 r-xp /lib/libcap.so.2.21
f6a16000 f6a18000 r-xp /usr/lib/libiri.so
f6a20000 f6a69000 r-xp /usr/lib/libmdm.so.1.2.69
f6a71000 f6a77000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a7f000 f6aa2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aac000 f6aae000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ab6000 f6ad3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6adc000 f6ae0000 r-xp /usr/lib/libsmack.so.1.0.0
f6ae9000 f6b02000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b0b000 f6b13000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b1b000 f6b21000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b2a000 f6b2c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b35000 f6b45000 r-xp /lib/libresolv-2.13.so
f6b49000 f6b61000 r-xp /usr/lib/liblzma.so.5.0.3
f6b6a000 f6b6c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b74000 f6b8e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b96000 f6bc5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bce000 f6bdd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6be7000 f6bf1000 r-xp /usr/lib/libsensord-shared.so
f6bfa000 f6ccd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cd8000 f6cee000 r-xp /lib/libz.so.1.2.5
f6cf6000 f6cfb000 r-xp /usr/lib/libffi.so.5.0.10
f6d03000 f6d04000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d0c000 f6d1c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d24000 f6d3d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d45000 f6d47000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d4f000 f6dc4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dce000 f6dd4000 r-xp /lib/librt-2.13.so
f6ddd000 f6dfb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e05000 f6e06000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e0e000 f6e31000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e39000 f6e3e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e46000 f6e70000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e79000 f6e90000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e98000 f6f01000 r-xp /lib/libm-2.13.so
f6f0a000 f6f9e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fb1000 f6fb6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fbe000 f6fc5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fcd000 f6ff7000 r-xp /usr/lib/libsensor.so.1.9.6
f7000000 f70cc000 r-xp /usr/lib/libxml2.so.2.7.8
f70d9000 f70db000 r-xp /usr/lib/libiniparser.so.0
f70e4000 f70ea000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70f3000 f71c3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71c4000 f71f8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7201000 f723d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7245000 f7248000 r-xp /usr/lib/libbundle.so.0.1.22
f7250000 f7256000 r-xp /usr/lib/libappsvc.so.0.1.0
f725e000 f729f000 r-xp /usr/lib/libeina.so.1.7.99
f72a8000 f72bf000 r-xp /usr/lib/libecore.so.1.7.99
f72d6000 f72df000 r-xp /usr/lib/libvconf.so.0.2.45
f72e7000 f72fb000 r-xp /lib/libpthread-2.13.so
f7306000 f7313000 r-xp /usr/lib/libaul.so.0.1.0
f731d000 f731f000 r-xp /lib/libdl-2.13.so
f7328000 f7333000 r-xp /lib/libunwind.so.8.0.1
f7360000 f7368000 r-xp /lib/libgcc_s-4.6.so.1
f7369000 f748d000 r-xp /lib/libc-2.13.so
f749b000 f749d000 r-xp /usr/lib/libdlog.so.0.0.0
f74a5000 f74b1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74ba000 f74bf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74c7000 f74d6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74de000 f74e2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74eb000 f74ee000 r-xp /usr/lib/libappcore-agent.so.1.1
f74f6000 f74f8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7500000 f7504000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f750c000 f7529000 r-xp /lib/ld-2.13.so
f7532000 f7535000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7535000 f7539000 r-xp /usr/lib/libsys-assert.so
f77a6000 f7814000 rw-p [heap]
ff7e7000 ff808000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25998)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7533228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74ca539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71d13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71cfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71dbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71e1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71e1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf721675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72111f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71cfc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71dbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71e1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71e1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7213e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7214017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf721bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bb31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ba6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c79663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7126fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71287a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72b8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72b3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72b45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72b4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74ec183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74ec7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75335c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf738085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7532f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
:811,0.070000,0.070000,0.070000
06-07 18:00:54.811+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.811+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:805,0.003286,0.018509,0.009020
06-07 18:00:54.811+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:811,0.430708,-0.215354,9.865608
06-07 18:00:54.811+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.811+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:816,0.406719,-0.160327,9.796901
06-07 18:00:54.811+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:820,0.023843,-0.054114,0.068728
06-07 18:00:54.821+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.821+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.831+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:832,0.070000,0.070000,0.070000
06-07 18:00:54.831+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.831+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.831+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:832,0.421137,-0.174676,9.822537
06-07 18:00:54.831+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:838,0.014417,-0.014349,0.025637
06-07 18:00:54.831+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:837,0.407513,-0.162639,9.796829
06-07 18:00:54.841+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.841+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.851+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:853,0.070000,0.210000,0.070000
06-07 18:00:54.851+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.851+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.851+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:853,0.433101,-0.162712,9.824929
06-07 18:00:54.851+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:859,0.025588,-0.000073,0.028100
06-07 18:00:54.851+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:858,0.407462,-0.162947,9.796826
06-07 18:00:54.861+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.861+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.871+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.871+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:872,0.140000,-0.070000,0.070000
06-07 18:00:54.871+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:873,0.428315,-0.160319,9.891929
06-07 18:00:54.871+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.881+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:880,0.020853,0.002628,0.095102
06-07 18:00:54.881+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:878,0.408365,-0.162651,9.796794
06-07 18:00:54.881+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.881+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.891+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.891+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:893,0.070000,0.070000,0.070000
06-07 18:00:54.891+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.891+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:893,0.411566,-0.136391,9.841680
06-07 18:00:54.901+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:899,0.003200,0.026260,0.044886
06-07 18:00:54.901+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:901,0.408754,-0.162292,9.796783
06-07 18:00:54.901+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.901+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.911+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:913,0.449851,-0.167498,9.815358
06-07 18:00:54.911+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.911+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.921+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:913,0.070000,0.070000,-0.070000
06-07 18:00:54.921+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:921,0.408480,-0.160834,9.796819
06-07 18:00:54.921+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:920,0.041097,-0.005206,0.018575
06-07 18:00:54.921+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.921+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.931+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:932,0.406780,-0.133998,9.860823
06-07 18:00:54.931+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:932,0.070000,0.210000,-0.070000
06-07 18:00:54.931+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.931+0200 I/heartrate(25983): es.ugr.frailty.heartrate - capturing data
06-07 18:00:54.931+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.931+0200 I/heartrate(25983): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:00:54.941+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:940,0.409733,-0.160902,9.796765
06-07 18:00:54.941+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:938,-0.001700,0.026836,0.064004
06-07 18:00:54.941+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.941+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.951+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:954,0.070000,0.210000,0.070000
06-07 18:00:54.951+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.951+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.961+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:954,0.416351,-0.157926,9.829715
06-07 18:00:54.961+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:960,0.408839,-0.159327,9.796828
06-07 18:00:54.961+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:961,0.006618,0.002976,0.032949
06-07 18:00:54.961+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.961+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:54.971+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:972,-0.070000,0.210000,0.070000
06-07 18:00:54.971+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:54.971+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:973,0.408857,-0.159303,9.796828
06-07 18:00:54.971+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:54.971+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:54:978,-0.035559,-0.020134,0.037673
06-07 18:00:54.981+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:54:981,0.373280,-0.179462,9.834501
06-07 18:00:54.981+0200 I/light   (26031): es.ugr.frailty.light - capturing data
06-07 18:00:54.981+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:54.981+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.001+0200 I/light   (26031): es.ugr.frailty.light: SM-R760,07/06/2018,18:00:54:993,1995.000000
06-07 18:00:55.001+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:54:995,0.406351,-0.160029,9.796921
06-07 18:00:55.001+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.001+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.021+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:00:55.021+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:00:55.021+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:00:55.021+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:54:994,0.070000,0.210000,0.140000
06-07 18:00:55.031+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.031+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.031+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:36,0.070000,0.140000,0.070000
06-07 18:00:55.031+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.041+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:43,0.070000,0.140000,0.070000
06-07 18:00:55.041+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:13,-0.064290,-0.008195,0.006566
06-07 18:00:55.041+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.041+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.041+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:35,0.344566,-0.167498,9.803394
06-07 18:00:55.051+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.051+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:40,0.402732,-0.160241,9.797067
06-07 18:00:55.051+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:54,0.070000,0.070000,0.140000
06-07 18:00:55.051+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.051+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:50,0.005214,-0.012254,0.044759
06-07 18:00:55.061+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.061+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.061+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:59,0.411566,-0.172283,9.841680
06-07 18:00:55.071+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:72,0.070000,0.070000,0.070000
06-07 18:00:55.071+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.071+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:67,0.001655,0.023850,0.027863
06-07 18:00:55.071+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.071+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:66,0.402568,-0.160565,9.797068
06-07 18:00:55.071+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:79,0.025747,-0.026075,0.023077
06-07 18:00:55.071+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.081+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.081+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:85,0.016490,-0.027429,0.027826
06-07 18:00:55.081+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.081+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.091+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:82,0.404387,-0.136391,9.824929
06-07 18:00:55.091+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:92,0.070000,0.070000,0.070000
06-07 18:00:55.091+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:86,0.402254,-0.159211,9.797103
06-07 18:00:55.091+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.091+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:93,0.029960,0.009552,0.008739
06-07 18:00:55.091+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.091+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:98,0.403141,-0.160300,9.797049
06-07 18:00:55.091+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.101+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:103,0.403515,-0.161335,9.797016
06-07 18:00:55.101+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:101,0.428315,-0.186640,9.820145
06-07 18:00:55.101+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.101+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.101+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.111+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:112,-0.140000,0.070000,0.070000
06-07 18:00:55.111+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.111+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:112,0.003265,0.046480,0.044663
06-07 18:00:55.111+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:110,0.418744,-0.186640,9.824929
06-07 18:00:55.111+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:117,0.405078,-0.161118,9.796955
06-07 18:00:55.111+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.121+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:124,0.433101,-0.150748,9.805787
06-07 18:00:55.121+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.121+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.121+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.131+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:132,-0.070000,0.070000,0.140000
06-07 18:00:55.131+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:132,-0.010262,-0.008772,-0.007917
06-07 18:00:55.131+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.131+0200 I/heartrate(25983): es.ugr.frailty.heartrate - capturing data
06-07 18:00:55.131+0200 I/heartrate(25983): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:00:55.131+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:129,0.406780,-0.114855,9.841680
06-07 18:00:55.131+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.131+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:137,0.405158,-0.158993,9.796987
06-07 18:00:55.141+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:142,0.394816,-0.169890,9.789038
06-07 18:00:55.141+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.141+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.151+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:153,0.006408,0.041744,0.030335
06-07 18:00:55.151+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:154,0.350000,-0.490000,0.070000
06-07 18:00:55.151+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.151+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.151+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:159,0.404766,-0.158975,9.797004
06-07 18:00:55.161+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:163,0.411566,-0.117248,9.827322
06-07 18:00:55.161+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.161+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.171+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:172,0.350000,0.210000,0.070000
06-07 18:00:55.171+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:172,0.016371,-0.022880,0.049461
06-07 18:00:55.171+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.171+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.171+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:177,0.421137,-0.181855,9.846465
06-07 18:00:55.171+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:177,0.403611,-0.156109,9.797097
06-07 18:00:55.181+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.181+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.191+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:193,0.490000,-0.700000,0.070000
06-07 18:00:55.191+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.191+0200 I/light   (26031): es.ugr.frailty.light - capturing data
06-07 18:00:55.191+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:198,0.404538,-0.156515,9.797052
06-07 18:00:55.191+0200 I/light   (26031): es.ugr.frailty.light: SM-R760,07/06/2018,18:00:55:198,1995.000000
06-07 18:00:55.191+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:194,0.029490,0.031682,0.008690
06-07 18:00:55.191+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.201+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:204,0.433101,-0.124427,9.805787
06-07 18:00:55.201+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.201+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.211+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.211+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:212,0.405747,-0.154540,9.797033
06-07 18:00:55.211+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.221+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.241+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:217,0.018992,-0.010983,0.008735
06-07 18:00:55.251+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:235,0.406190,-0.155647,9.796998
06-07 18:00:55.251+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.251+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:221,0.423530,-0.167498,9.805787
06-07 18:00:55.261+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.261+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.271+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:212,0.280000,-0.350000,0.070000
06-07 18:00:55.271+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.271+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:280,-0.350000,0.630000,0.070000
06-07 18:00:55.271+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.281+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:270,0.407728,-0.155313,9.796939
06-07 18:00:55.281+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:285,0.210000,-0.350000,0.070000
06-07 18:00:55.281+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.281+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:263,0.032139,-0.000994,0.042253
06-07 18:00:55.291+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:290,-0.140000,0.350000,0.070000
06-07 18:00:55.291+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.291+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.291+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:270,0.437887,-0.155533,9.839286
06-07 18:00:55.291+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:296,-0.140000,0.630000,0.070000
06-07 18:00:55.291+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.291+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.301+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:299,0.017339,-0.004672,0.008789
06-07 18:00:55.301+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.301+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.311+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:312,0.070000,0.140000,0.070000
06-07 18:00:55.311+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:307,0.011016,-0.002613,0.071061
06-07 18:00:55.311+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.311+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:304,0.423530,-0.160319,9.805787
06-07 18:00:55.311+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:306,0.408081,-0.155707,9.796918
06-07 18:00:55.321+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:320,-0.001301,0.004959,0.042368
06-07 18:00:55.321+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.321+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.321+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.331+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.331+0200 I/heartrate(25983): es.ugr.frailty.heartrate - capturing data
06-07 18:00:55.341+0200 I/heartrate(25983): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:00:55.341+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:333,0.011286,0.007449,0.037559
06-07 18:00:55.341+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:335,0.407458,-0.155804,9.796943
06-07 18:00:55.341+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:334,0.418744,-0.157926,9.868000
06-07 18:00:55.341+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.341+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.351+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.351+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:345,0.280000,-0.210000,0.140000
06-07 18:00:55.351+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.371+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:357,0.406780,-0.150748,9.839286
06-07 18:00:55.371+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:360,0.406832,-0.155324,9.796976
06-07 18:00:55.371+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:356,0.031055,0.021326,0.059060
06-07 18:00:55.371+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:361,-0.070000,0.280000,0.070000
06-07 18:00:55.371+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.371+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.371+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.381+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.381+0200 I/light   (26031): es.ugr.frailty.light - capturing data
06-07 18:00:55.391+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:385,0.418744,-0.148355,9.834501
06-07 18:00:55.391+0200 I/light   (26031): es.ugr.frailty.light: SM-R760,07/06/2018,18:00:55:393,1995.000000
06-07 18:00:55.391+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:385,0.406954,-0.154453,9.796985
06-07 18:00:55.391+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:384,0.028540,-0.020223,0.056659
06-07 18:00:55.391+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:386,-0.070000,0.280000,0.070000
06-07 18:00:55.391+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.391+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.391+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.391+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.401+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:403,0.437887,-0.133998,9.856036
06-07 18:00:55.401+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:405,0.140000,-0.140000,0.140000
06-07 18:00:55.411+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:405,0.407809,-0.153499,9.796965
06-07 18:00:55.411+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:402,-0.003422,-0.054677,0.030357
06-07 18:00:55.411+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.411+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.411+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.411+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.411+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:417,-0.070000,0.140000,0.070000
06-07 18:00:55.421+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:420,0.435494,-0.174676,9.853643
06-07 18:00:55.421+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.421+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:418,0.031662,0.008528,0.023230
06-07 18:00:55.421+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:422,0.408618,-0.154490,9.796915
06-07 18:00:55.421+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.421+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.431+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:435,0.000831,-0.005960,0.083073
06-07 18:00:55.431+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:432,0.420000,-0.700000,0.140000
06-07 18:00:55.431+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.431+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:440,0.404387,-0.208176,9.827322
06-07 18:00:55.441+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:439,0.408341,-0.156752,9.796891
06-07 18:00:55.441+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.441+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.441+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.441+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:449,0.004323,-0.042268,0.032871
06-07 18:00:55.441+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.451+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:454,-0.070000,0.350000,0.070000
06-07 18:00:55.451+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:455,0.440279,-0.145962,9.820145
06-07 18:00:55.451+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:455,0.409636,-0.156336,9.796844
06-07 18:00:55.451+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.451+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.451+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.461+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.471+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:472,0.140000,-0.210000,0.140000
06-07 18:00:55.471+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:465,-0.002987,-0.025892,0.028086
06-07 18:00:55.471+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:465,0.409767,-0.155963,9.796844
06-07 18:00:55.471+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:466,0.409173,-0.162712,9.879964
06-07 18:00:55.471+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.471+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.471+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.491+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.491+0200 W/LOCATION(25998): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:00:55.491+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:496,-0.210000,0.490000,0.070000
06-07 18:00:55.501+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:485,0.409413,-0.157951,9.796827
06-07 18:00:55.501+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.501+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:507,0.409304,-0.158856,9.796817
06-07 18:00:55.501+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.501+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:494,0.413958,-0.198604,9.829715
06-07 18:00:55.501+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.511+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:489,0.014117,-0.014332,0.040066
06-07 18:00:55.511+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.511+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:513,-0.210000,0.350000,0.070000
06-07 18:00:55.511+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.511+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:514,0.406780,-0.181855,9.824929
06-07 18:00:55.511+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.511+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:520,0.409418,-0.159710,9.796798
06-07 18:00:55.521+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.521+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:527,0.409568,-0.159785,9.796791
06-07 18:00:55.521+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:518,0.009440,0.003322,0.049648
06-07 18:00:55.521+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.521+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.531+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:533,0.420000,-0.280000,0.070000
06-07 18:00:55.531+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:532,0.006933,-0.048465,0.032917
06-07 18:00:55.531+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.531+0200 I/heartrate(25983): es.ugr.frailty.heartrate - capturing data
06-07 18:00:55.531+0200 I/heartrate(25983): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:00:55.531+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.531+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:524,0.423530,-0.172283,9.836893
06-07 18:00:55.531+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.541+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:541,0.409369,-0.161235,9.796775
06-07 18:00:55.541+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:542,0.418744,-0.155533,9.846465
06-07 18:00:55.541+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.541+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:538,-0.007573,-0.000534,0.052067
06-07 18:00:55.541+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:549,0.416351,-0.208176,9.829715
06-07 18:00:55.541+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.541+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.551+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.551+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:555,0.140000,-0.070000,0.070000
06-07 18:00:55.551+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:554,0.401994,-0.160319,9.848858
06-07 18:00:55.551+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.551+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:559,0.397209,-0.215354,9.824929
06-07 18:00:55.551+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.551+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:559,0.408676,-0.160882,9.796810
06-07 18:00:55.561+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:563,-0.012160,-0.054119,0.028154
06-07 18:00:55.561+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.561+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.561+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.561+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.571+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:573,0.378066,-0.150748,9.805787
06-07 18:00:55.571+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:573,0.407799,-0.163708,9.796800
06-07 18:00:55.571+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:572,-0.029733,0.012960,0.008987
06-07 18:00:55.571+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:573,-0.210000,0.420000,0.070000
06-07 18:00:55.581+0200 I/light   (26031): es.ugr.frailty.light - capturing data
06-07 18:00:55.581+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.581+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.591+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.591+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:592,0.008553,-0.022933,0.030522
06-07 18:00:55.591+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:594,0.406473,-0.163451,9.796859
06-07 18:00:55.591+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:596,0.416351,-0.186640,9.827322
06-07 18:00:55.601+0200 I/light   (26031): es.ugr.frailty.light: SM-R760,07/06/2018,18:00:55:593,1994.000000
06-07 18:00:55.601+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.601+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.601+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.601+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:611,0.036200,-0.004047,0.044821
06-07 18:00:55.611+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.611+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:620,-0.210000,0.210000,0.070000
06-07 18:00:55.621+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:614,0.442672,-0.167498,9.841680
06-07 18:00:55.621+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:616,0.409142,-0.160541,9.796796
06-07 18:00:55.621+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.621+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.621+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.621+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.621+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:631,0.011995,0.005008,0.006598
06-07 18:00:55.631+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:636,2.730000,-4.410000,0.280000
06-07 18:00:55.631+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:632,0.421137,-0.155533,9.803394
06-07 18:00:55.641+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:634,0.410131,-0.160298,9.796759
06-07 18:00:55.641+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.641+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.641+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.651+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.651+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:653,-0.000958,-0.064627,0.040134
06-07 18:00:55.651+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:656,0.409626,-0.161128,9.796766
06-07 18:00:55.661+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:650,0.280000,-0.140000,0.070000
06-07 18:00:55.661+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:655,0.409173,-0.224925,9.836893
06-07 18:00:55.661+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.661+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.661+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.661+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.671+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:672,0.049796,-0.008763,0.047306
06-07 18:00:55.681+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:674,0.410845,-0.161483,9.796709
06-07 18:00:55.681+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:673,0.459422,-0.169890,9.844072
06-07 18:00:55.681+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:670,-0.770000,1.400000,0.070000
06-07 18:00:55.681+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.681+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.681+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.691+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.691+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:692,0.027041,0.010735,0.066506
06-07 18:00:55.691+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:696,0.437887,-0.150748,9.863215
06-07 18:00:55.701+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:693,0.412022,-0.162708,9.796639
06-07 18:00:55.701+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:698,1.750000,-2.660000,0.140000
06-07 18:00:55.701+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.701+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.701+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.711+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:712,0.004329,0.026317,0.054612
06-07 18:00:55.711+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.711+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:716,0.416351,-0.136391,9.851252
06-07 18:00:55.721+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:713,0.412046,-0.162698,9.796638
06-07 18:00:55.721+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.721+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.731+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:732,0.029736,0.033148,0.056997
06-07 18:00:55.731+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.731+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:718,-0.630000,1.190000,0.140000
06-07 18:00:55.731+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.731+0200 I/heartrate(25983): es.ugr.frailty.heartrate - capturing data
06-07 18:00:55.731+0200 I/heartrate(25983): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:00:55.731+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:738,-0.490000,1.050000,0.070000
06-07 18:00:55.731+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.741+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:733,0.412936,-0.159968,9.796646
06-07 18:00:55.741+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:738,0.442672,-0.126820,9.853643
06-07 18:00:55.741+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:743,0.980000,-1.610000,0.140000
06-07 18:00:55.741+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.741+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.751+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.761+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:755,0.413184,-0.158755,9.796656
06-07 18:00:55.761+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.761+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:758,0.409173,-0.169890,9.801002
06-07 18:00:55.761+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.771+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.771+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:780,0.399601,-0.167498,9.836893
06-07 18:00:55.771+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:769,-0.350000,0.840000,0.070000
06-07 18:00:55.781+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.781+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:775,0.412278,-0.159719,9.796678
06-07 18:00:55.781+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:753,-0.003763,-0.009923,0.004355
06-07 18:00:55.781+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.781+0200 I/light   (26031): es.ugr.frailty.light - capturing data
06-07 18:00:55.791+0200 I/light   (26031): es.ugr.frailty.light: SM-R760,07/06/2018,18:00:55:794,1984.000000
06-07 18:00:55.791+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.791+0200 I/gravity (26005): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:00:55:800,0.411657,-0.158939,9.796717
06-07 18:00:55.791+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.801+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:792,-0.013583,-0.008743,0.040237
06-07 18:00:55.801+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.801+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:787,-0.350000,0.770000,0.070000
06-07 18:00:55.801+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.801+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:807,0.051930,0.018542,0.059359
06-07 18:00:55.801+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.801+0200 I/gravity (26005): es.ugr.frailty.gravity - capturing data
06-07 18:00:55.811+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:00:55:806,0.464208,-0.141177,9.856036
06-07 18:00:55.811+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:813,0.052551,-0.008559,-0.005286
06-07 18:00:55.811+0200 I/accelerometer(25959): es.ugr.frailty.accelerometer - capturing data
06-07 18:00:55.821+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:00:55:813,0.700000,-0.910000,0.070000
06-07 18:00:55.821+0200 I/gyroscope(25962): es.ugr.frailty.gyroscope - capturing data
06-07 18:00:55.821+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.871+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:00:55:832,0.005156,0.005595,0.018720
06-07 18:00:55.871+0200 I/linearacceleration(25999): es.ugr.frailty.linearacceleration - capturing data
06-07 18:00:55.881+0200 W/AUL     (26074): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 18:00:55.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 18:00:55.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 18:00:55.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 25291
06-07 18:00:55.881+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 18:00:55.891+0200 W/CRASH_MANAGER(26070): worker.c: worker_job(1205) > 11259986c6f63152838725
