S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4050
Date: 2018-04-23 19:55:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf734252d, r5   = 0xf7626f98
r6   = 0xffee33a0, r7   = 0xffee3250
r8   = 0xf7623c18, r9   = 0x00000000
r10  = 0xffee332c, fp   = 0xffee33a0
ip   = 0x00000001, sp   = 0xffee3228
lr   = 0xf7342539, pc   = 0xf73ab228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     69720 KB
Buffers:     32200 KB
Cached:     220576 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11856 KB
VmRSS:       11856 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4050 TID = 4050
4050 4083 

Maps Information
f420d000 f4a0c000 rw-p [stack:4083]
f4a13000 f4a15000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a1d000 f4a21000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a2a000 f4a2c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a34000 f4a37000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a46000 f4a4b000 r-xp /usr/lib/libsystem.so.0.0.0
f4a56000 f4a59000 r-xp /lib/libattr.so.1.1.0
f4a61000 f4a71000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a79000 f4a82000 r-xp /usr/lib/libedbus.so.1.7.99
f4a8a000 f4a8b000 r-xp /usr/lib/libresponse.so.0.2.96
f4a94000 f4a99000 r-xp /usr/lib/libproc-stat.so.0.2.96
f633b000 f6441000 r-xp /usr/lib/libicuuc.so.57.1
f6457000 f65df000 r-xp /usr/lib/libicui18n.so.57.1
f65ef000 f65fc000 r-xp /usr/lib/libail.so.0.1.0
f6605000 f660c000 r-xp /usr/lib/libminizip.so.1.0.0
f6615000 f67be000 r-xp /usr/lib/libcrypto.so.1.0.0
f67de000 f6825000 r-xp /usr/lib/libssl.so.1.0.0
f6831000 f6833000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f683b000 f6842000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f684b000 f6852000 r-xp /lib/libcrypt-2.13.so
f6883000 f6886000 r-xp /lib/libcap.so.2.21
f688e000 f6890000 r-xp /usr/lib/libiri.so
f6898000 f68e1000 r-xp /usr/lib/libmdm.so.1.2.69
f68e9000 f68ef000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68f7000 f691a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6924000 f6926000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f692e000 f694b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6954000 f6958000 r-xp /usr/lib/libsmack.so.1.0.0
f6961000 f697a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6983000 f698b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6993000 f6999000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69a2000 f69a4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69ad000 f69bd000 r-xp /lib/libresolv-2.13.so
f69c1000 f69d9000 r-xp /usr/lib/liblzma.so.5.0.3
f69e2000 f69e4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69ec000 f6a06000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a0e000 f6a3d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a46000 f6a55000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a5f000 f6a69000 r-xp /usr/lib/libsensord-shared.so
f6a72000 f6b45000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b50000 f6b66000 r-xp /lib/libz.so.1.2.5
f6b6e000 f6b73000 r-xp /usr/lib/libffi.so.5.0.10
f6b7b000 f6b7c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b84000 f6b94000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b9c000 f6bb5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bbd000 f6bbf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bc7000 f6c3c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c46000 f6c4c000 r-xp /lib/librt-2.13.so
f6c55000 f6c73000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c7d000 f6c7e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c86000 f6ca9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cb1000 f6cb6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cbe000 f6ce8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cf1000 f6d08000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d10000 f6d79000 r-xp /lib/libm-2.13.so
f6d82000 f6e16000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e29000 f6e2e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e36000 f6e3d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e45000 f6e6f000 r-xp /usr/lib/libsensor.so.1.9.6
f6e78000 f6f44000 r-xp /usr/lib/libxml2.so.2.7.8
f6f51000 f6f53000 r-xp /usr/lib/libiniparser.so.0
f6f5c000 f6f62000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f6b000 f703b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f703c000 f7070000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7079000 f70b5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70bd000 f70c0000 r-xp /usr/lib/libbundle.so.0.1.22
f70c8000 f70ce000 r-xp /usr/lib/libappsvc.so.0.1.0
f70d6000 f7117000 r-xp /usr/lib/libeina.so.1.7.99
f7120000 f7137000 r-xp /usr/lib/libecore.so.1.7.99
f714e000 f7157000 r-xp /usr/lib/libvconf.so.0.2.45
f715f000 f7173000 r-xp /lib/libpthread-2.13.so
f717e000 f718b000 r-xp /usr/lib/libaul.so.0.1.0
f7195000 f7197000 r-xp /lib/libdl-2.13.so
f71a0000 f71ab000 r-xp /lib/libunwind.so.8.0.1
f71d8000 f71e0000 r-xp /lib/libgcc_s-4.6.so.1
f71e1000 f7305000 r-xp /lib/libc-2.13.so
f7313000 f7315000 r-xp /usr/lib/libdlog.so.0.0.0
f731d000 f7329000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7332000 f7337000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f733f000 f734e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7356000 f735a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7363000 f7366000 r-xp /usr/lib/libappcore-agent.so.1.1
f736e000 f7370000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7378000 f737c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7384000 f73a1000 r-xp /lib/ld-2.13.so
f73aa000 f73ad000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73ad000 f73b1000 r-xp /usr/lib/libsys-assert.so
f75f3000 f767d000 rw-p [heap]
ffec4000 ffee5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4050)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73ab228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7342539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70493f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7047c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7053e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7059be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7059dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf708e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70891f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7047c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7053e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7059be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7059dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf708be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf708c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7093f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a2b1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a1e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6af1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f9efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fa07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7130ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf712bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf712c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf712c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7364183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73647fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73ab4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf71f885c) [/lib/libc.so.6] + 0x1785c
29: (0xf73aaf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
99+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.799+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:793,-0.010262,-0.003963,-0.027087
04-23 19:55:37.799+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.809+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.809+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:814,-0.070000,-0.070000,-0.070000
04-23 19:55:37.809+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:803,0.044701,9.771850,0.824216
04-23 19:55:37.819+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.819+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:814,0.031107,9.757930,0.806381
04-23 19:55:37.819+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:818,-0.014418,-0.013746,-0.019856
04-23 19:55:37.819+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.829+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.829+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.829+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:825,0.042755,9.772061,0.821815
04-23 19:55:37.839+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:839,0.007178,9.824929,0.787239
04-23 19:55:37.839+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.849+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:834,-0.070000,-0.070000,-0.070000
04-23 19:55:37.849+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:851,0.045338,9.772300,0.818832
04-23 19:55:37.849+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.849+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:839,-0.037522,0.053080,-0.036977
04-23 19:55:37.849+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.849+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.859+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.869+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:862,0.100499,9.779467,0.799203
04-23 19:55:37.869+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:859,0.057743,0.007405,-0.022612
04-23 19:55:37.869+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:857,-0.070000,0.210000,-0.070000
04-23 19:55:37.869+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.869+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.879+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.879+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:869,0.045078,9.772499,0.816465
04-23 19:55:37.879+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.889+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:884,-0.002267,-0.002405,-0.026807
04-23 19:55:37.889+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:886,0.043071,9.769895,0.792024
04-23 19:55:37.889+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:881,-0.070000,0.070000,-0.070000
04-23 19:55:37.889+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.889+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.899+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:903,-0.070000,0.070000,-0.070000
04-23 19:55:37.899+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.909+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:895,0.043780,9.772822,0.812654
04-23 19:55:37.909+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.909+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:919,0.044619,9.772985,0.810658
04-23 19:55:37.919+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.919+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:907,-0.023542,0.011753,-0.069905
04-23 19:55:37.919+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:911,0.021535,9.784252,0.746561
04-23 19:55:37.919+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.919+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.929+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.929+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:925,-0.070000,0.070000,-0.070000
04-23 19:55:37.929+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:931,0.020826,0.001858,-0.013451
04-23 19:55:37.939+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.939+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:932,0.064606,9.774680,0.799203
04-23 19:55:37.939+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.949+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.949+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:940,0.044148,9.773261,0.807338
04-23 19:55:37.949+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:945,-0.070000,0.140000,-0.070000
04-23 19:55:37.949+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:957,0.038285,9.817751,0.763310
04-23 19:55:37.959+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.959+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:37.959+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:950,-0.006334,0.044766,-0.047348
04-23 19:55:37.959+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:37.969+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:37.969+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:37:971,-0.070000,0.140000,0.070000
04-23 19:55:37.969+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:964,0.045371,9.773130,0.808861
04-23 19:55:37.979+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:37.979+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:37:973,0.022851,0.015777,-0.000957
04-23 19:55:37.989+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.009+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:37:985,0.047135,9.773216,0.807721
04-23 19:55:38.049+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.059+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:37:976,0.066999,9.789038,0.806381
04-23 19:55:38.059+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.069+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:64,0.033592,0.027871,-0.040765
04-23 19:55:38.069+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.069+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:75,0.046859,9.773063,0.809589
04-23 19:55:38.069+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:67,0.078963,9.801002,0.768096
04-23 19:55:38.069+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:59,-0.070000,0.070000,0.070000
04-23 19:55:38.069+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.069+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.079+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.079+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:85,-0.008850,0.032571,0.008231
04-23 19:55:38.079+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.089+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:82,-0.070000,0.070000,0.070000
04-23 19:55:38.089+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:87,0.038285,9.805787,0.815953
04-23 19:55:38.089+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.089+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:97,0.048063,9.772923,0.811198
04-23 19:55:38.099+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:103,-0.070000,0.070000,0.070000
04-23 19:55:38.099+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.099+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.109+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.109+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:107,0.022533,0.037511,0.006364
04-23 19:55:38.109+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.119+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:115,0.047627,9.772874,0.811823
04-23 19:55:38.119+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.119+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:110,0.069392,9.810574,0.815953
04-23 19:55:38.119+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.129+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.129+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:122,-0.070000,0.070000,0.070000
04-23 19:55:38.129+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:126,-0.012170,0.016114,-0.021566
04-23 19:55:38.139+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:138,0.048112,9.772910,0.811357
04-23 19:55:38.139+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:131,0.035892,9.789038,0.789631
04-23 19:55:38.139+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.139+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.149+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.149+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:153,0.007408,0.085555,-0.031762
04-23 19:55:38.159+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.159+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:155,0.055035,9.858429,0.780060
04-23 19:55:38.159+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:151,-0.070000,0.070000,0.070000
04-23 19:55:38.169+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.169+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.169+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.169+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:167,0.047685,9.772693,0.813992
04-23 19:55:38.179+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.189+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:175,-0.012220,0.013735,0.023738
04-23 19:55:38.189+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:174,-0.070000,0.070000,0.070000
04-23 19:55:38.189+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.189+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:181,0.035892,9.786645,0.835095
04-23 19:55:38.199+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.199+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:190,0.049317,9.772629,0.814665
04-23 19:55:38.199+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.209+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.209+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:199,-0.070000,0.070000,0.070000
04-23 19:55:38.209+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:203,0.031278,0.011559,-0.010004
04-23 19:55:38.209+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.209+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.219+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:208,0.078963,9.784252,0.803988
04-23 19:55:38.219+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.219+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:221,-0.070000,0.070000,0.070000
04-23 19:55:38.219+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:214,0.048478,9.772625,0.814761
04-23 19:55:38.229+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.229+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:223,-0.020603,-0.009912,-0.039391
04-23 19:55:38.229+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:229,0.028714,9.762716,0.775275
04-23 19:55:38.229+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.229+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.239+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.239+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:235,0.047110,9.772828,0.812405
04-23 19:55:38.249+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.249+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:244,-0.026942,0.021198,-0.034701
04-23 19:55:38.259+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:243,-0.070000,-0.070000,-0.070000
04-23 19:55:38.259+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.259+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.259+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:250,0.021535,9.793823,0.780060
04-23 19:55:38.259+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:256,0.046838,9.772665,0.814376
04-23 19:55:38.259+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.269+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.269+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:265,-0.070000,0.070000,0.070000
04-23 19:55:38.279+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:273,0.038285,9.789038,0.820738
04-23 19:55:38.279+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:266,-0.008824,0.016210,0.008334
04-23 19:55:38.279+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.279+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.289+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.289+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:279,0.045784,9.772531,0.816049
04-23 19:55:38.309+0200 W/LOCATION( 4050): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:55:38.319+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.319+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:295,0.021535,9.789038,0.811167
04-23 19:55:38.329+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:290,-0.070000,0.070000,0.070000
04-23 19:55:38.329+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:293,-0.025303,0.016373,-0.003209
04-23 19:55:38.329+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.329+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:339,-0.070000,0.070000,0.070000
04-23 19:55:38.339+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.339+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.339+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:325,0.042857,9.772348,0.818380
04-23 19:55:38.349+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.349+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:345,-0.064927,0.035649,-0.000097
04-23 19:55:38.359+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:346,-0.019143,9.808180,0.815953
04-23 19:55:38.359+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.359+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.359+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.369+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:367,-0.070000,0.070000,0.070000
04-23 19:55:38.369+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:353,0.043127,9.772429,0.817412
04-23 19:55:38.369+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.379+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.379+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:372,0.002607,0.035831,-0.050284
04-23 19:55:38.379+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:376,0.045464,9.808180,0.768096
04-23 19:55:38.389+0200 I/servicemanager( 3660): es.ugr.frailty.location sleep timeout
04-23 19:55:38.389+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 19:55:38.389+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:55:38.389+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 3660
04-23 19:55:38.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4050
04-23 19:55:38.399+0200 W/AUL     ( 3660): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4050)
04-23 19:55:38.399+0200 I/servicemanager( 3660): es.ugr.frailty.location stop request sent!
04-23 19:55:38.399+0200 I/servicemanager( 3660): App control destroyed.
04-23 19:55:38.399+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.399+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.399+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:383,0.042824,9.772348,0.818381
04-23 19:55:38.409+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:413,0.033500,9.808180,0.806381
04-23 19:55:38.419+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.419+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:411,-0.009627,0.035751,-0.011030
04-23 19:55:38.419+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:392,-0.070000,-0.070000,0.070000
04-23 19:55:38.429+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.429+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.429+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.429+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:424,0.044678,9.772351,0.818257
04-23 19:55:38.439+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.439+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:434,-0.070000,0.070000,0.070000
04-23 19:55:38.449+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.449+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:437,0.078963,9.820145,0.799203
04-23 19:55:38.449+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.459+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:440,0.036139,0.047796,-0.019179
04-23 19:55:38.459+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.469+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:450,0.043610,9.772243,0.819604
04-23 19:55:38.469+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 19:55:38.469+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:55:38.469+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 19:55:38.479+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:468,-0.025536,0.007115,-0.016661
04-23 19:55:38.479+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.479+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:459,-0.070000,0.070000,0.070000
04-23 19:55:38.479+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:465,0.019143,9.779467,0.801596
04-23 19:55:38.479+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.489+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.489+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.499+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:493,-0.070000,0.070000,0.070000
04-23 19:55:38.499+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:485,0.045323,9.772296,0.818883
04-23 19:55:38.509+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:501,0.076570,9.810574,0.789631
04-23 19:55:38.509+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.509+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:518,0.044675,9.772214,0.819887
04-23 19:55:38.509+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.519+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:499,0.032960,0.038331,-0.029972
04-23 19:55:38.519+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.519+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.529+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:532,-0.016609,0.040669,-0.017287
04-23 19:55:38.529+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:532,0.028714,9.812965,0.801596
04-23 19:55:38.529+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.539+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:523,-0.070000,0.070000,0.070000
04-23 19:55:38.539+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.539+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.549+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.559+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:543,0.045598,9.772635,0.814807
04-23 19:55:38.559+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.559+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:556,0.022324,0.035966,-0.061363
04-23 19:55:38.569+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:550,-0.070000,0.070000,-0.070000
04-23 19:55:38.569+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.569+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:558,0.066999,9.808180,0.758525
04-23 19:55:38.569+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:570,0.045312,9.772650,0.814641
04-23 19:55:38.579+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.579+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.579+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.589+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:575,-0.070000,0.070000,-0.070000
04-23 19:55:38.589+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:583,-0.002527,0.064259,0.025074
04-23 19:55:38.599+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.599+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:585,0.043071,9.836893,0.839881
04-23 19:55:38.599+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.599+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.609+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:610,-0.070000,0.140000,-0.070000
04-23 19:55:38.639+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:597,0.045269,9.772920,0.811405
04-23 19:55:38.639+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.649+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.649+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:615,0.047856,9.810574,0.772882
04-23 19:55:38.659+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:612,0.002544,0.037924,-0.041759
04-23 19:55:38.659+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.669+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.669+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:654,0.044559,9.772877,0.811959
04-23 19:55:38.669+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.669+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:671,0.033500,9.817751,0.851845
04-23 19:55:38.669+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:663,-0.070000,0.070000,-0.070000
04-23 19:55:38.679+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:683,0.046273,9.773081,0.809403
04-23 19:55:38.679+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.689+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.689+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:673,-0.011770,0.044831,0.040440
04-23 19:55:38.689+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.689+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:697,0.083749,9.786645,0.792024
04-23 19:55:38.699+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:693,-0.070000,0.070000,-0.070000
04-23 19:55:38.699+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.699+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.709+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:701,0.039190,0.013768,-0.019934
04-23 19:55:38.709+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.709+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.719+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:707,0.045615,9.773248,0.807426
04-23 19:55:38.719+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.719+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:726,-0.010381,0.049457,-0.017379
04-23 19:55:38.729+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:716,-0.070000,0.070000,-0.070000
04-23 19:55:38.729+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.729+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:720,0.035892,9.822537,0.792024
04-23 19:55:38.739+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.739+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:734,0.047719,9.773372,0.805798
04-23 19:55:38.739+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.749+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.749+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:740,-0.070000,0.140000,-0.070000
04-23 19:55:38.749+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:749,0.047705,0.018183,-0.008223
04-23 19:55:38.759+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.759+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:747,0.093320,9.791430,0.799203
04-23 19:55:38.769+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.769+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.779+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:763,0.047181,9.773254,0.807248
04-23 19:55:38.779+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:770,-0.070000,0.140000,0.070000
04-23 19:55:38.779+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.789+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.789+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:777,-0.014219,0.020452,-0.004202
04-23 19:55:38.789+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:777,0.033500,9.793823,0.801596
04-23 19:55:38.789+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.799+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:791,0.048271,9.773266,0.807052
04-23 19:55:38.799+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.809+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.809+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:811,0.066999,9.815358,0.780060
04-23 19:55:38.819+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:798,-0.070000,0.070000,0.070000
04-23 19:55:38.819+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:806,0.019818,0.042104,-0.027188
04-23 19:55:38.819+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.829+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.829+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.829+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:823,0.046597,9.773057,0.809673
04-23 19:55:38.839+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.839+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:838,0.009571,9.808180,0.835095
04-23 19:55:38.849+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:830,-0.070000,0.070000,0.070000
04-23 19:55:38.849+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.859+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.859+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:837,-0.038699,0.034914,0.028043
04-23 19:55:38.859+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.859+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:853,0.047613,9.773063,0.809549
04-23 19:55:38.869+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:872,0.018009,-0.000770,-0.029612
04-23 19:55:38.869+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.879+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:858,-0.070000,0.070000,0.070000
04-23 19:55:38.879+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:883,0.047649,9.773055,0.809636
04-23 19:55:38.879+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:866,0.064606,9.772287,0.780060
04-23 19:55:38.879+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.889+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.889+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.889+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:892,-0.070000,0.070000,0.070000
04-23 19:55:38.889+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:897,-0.002149,0.049475,-0.027096
04-23 19:55:38.899+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.899+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:903,0.046765,9.773091,0.809248
04-23 19:55:38.899+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.909+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:900,0.045464,9.822537,0.782453
04-23 19:55:38.909+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:914,-0.070000,0.070000,0.070000
04-23 19:55:38.909+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.909+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.909+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:919,-0.021328,0.025554,-0.048719
04-23 19:55:38.919+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:923,0.026321,9.798609,0.760918
04-23 19:55:38.919+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.929+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.929+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.929+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.949+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:932,0.048196,9.772993,0.810354
04-23 19:55:38.949+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.949+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:936,-0.070000,0.070000,0.070000
04-23 19:55:38.949+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:944,0.074178,9.827322,0.808774
04-23 19:55:38.949+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.949+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:940,0.027413,0.054231,-0.000474
04-23 19:55:38.959+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.959+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.969+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:38:973,0.031107,9.817751,0.787239
04-23 19:55:38.979+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:955,0.047508,9.772932,0.811123
04-23 19:55:38.979+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.979+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:962,-0.070000,0.210000,0.070000
04-23 19:55:38.989+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:38.989+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:38:993,-0.070000,-0.070000,-0.070000
04-23 19:55:38.989+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:38:969,-0.017089,0.044758,-0.023116
04-23 19:55:38.989+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:38.989+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:38.999+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:38:984,0.046817,9.773010,0.810225
04-23 19:55:38.999+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:38.999+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.009+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:3,-0.011616,0.006535,0.007222
04-23 19:55:39.009+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:14,-0.140000,0.140000,0.070000
04-23 19:55:39.019+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:0,0.035892,9.779467,0.818345
04-23 19:55:39.019+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:10,0.048609,9.772922,0.811192
04-23 19:55:39.019+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.019+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.019+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.029+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:33,0.048377,9.773032,0.809866
04-23 19:55:39.029+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:28,0.034539,-0.003116,-0.011022
04-23 19:55:39.029+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.049+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.049+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:26,0.081356,9.769895,0.799203
04-23 19:55:39.069+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.069+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:61,-0.007931,0.006545,-0.062238
04-23 19:55:39.069+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.079+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:44,-0.070000,0.070000,0.070000
04-23 19:55:39.089+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:82,0.050072,9.772927,0.811027
04-23 19:55:39.089+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.089+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:96,-0.070000,0.070000,0.070000
04-23 19:55:39.089+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.089+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:81,0.040678,9.779467,0.748954
04-23 19:55:39.099+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.099+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.109+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:102,0.032979,0.042326,0.001301
04-23 19:55:39.109+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:105,0.052341,9.772621,0.814566
04-23 19:55:39.109+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.119+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.119+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:105,0.081356,9.815358,0.811167
04-23 19:55:39.119+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.119+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.129+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:133,0.051028,9.772501,0.816092
04-23 19:55:39.139+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:120,-0.070000,0.140000,0.070000
04-23 19:55:39.139+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.139+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:128,0.045641,0.008931,0.038425
04-23 19:55:39.139+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.139+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:131,0.095713,9.781858,0.849452
04-23 19:55:39.149+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.149+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.169+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:148,-0.070000,0.070000,0.070000
04-23 19:55:39.169+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:152,-0.030806,-0.007512,-0.005792
04-23 19:55:39.169+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:155,0.051251,9.772508,0.815995
04-23 19:55:39.169+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.179+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.179+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.189+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:160,0.021535,9.765109,0.808774
04-23 19:55:39.189+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.199+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:180,-0.070000,-0.070000,0.070000
04-23 19:55:39.199+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:193,0.053054,9.772468,0.816358
04-23 19:55:39.209+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.209+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.209+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:201,0.052642,9.844072,0.794417
04-23 19:55:39.209+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:191,0.001614,0.071571,-0.021675
04-23 19:55:39.209+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.259+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.269+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:261,0.034891,0.038066,-0.007221
04-23 19:55:39.269+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:221,0.053645,9.772367,0.817537
04-23 19:55:39.269+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:216,-0.070000,-0.070000,0.070000
04-23 19:55:39.269+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.279+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:270,0.086142,9.810574,0.808774
04-23 19:55:39.279+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.279+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.279+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.289+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:292,0.062213,9.786645,0.818345
04-23 19:55:39.289+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:285,0.054103,9.772531,0.815534
04-23 19:55:39.289+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:287,0.009160,0.014177,0.001987
04-23 19:55:39.299+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:280,-0.070000,-0.070000,0.070000
04-23 19:55:39.299+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.299+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.299+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.309+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.319+0200 I/accelerometer( 3999): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:39:318,0.059821,9.805787,0.758525
04-23 19:55:39.319+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:309,-0.070000,-0.070000,0.070000
04-23 19:55:39.329+0200 I/gyroscope( 4031): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:39.329+0200 I/linearacceleration( 4053): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:39:313,0.006176,0.033421,-0.059013
04-23 19:55:39.329+0200 I/gyroscope( 4031): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:39:335,-0.070000,0.140000,0.070000
04-23 19:55:39.329+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:313,0.054850,9.772439,0.816590
04-23 19:55:39.329+0200 I/gravity ( 4070): capturing data from es.ugr.frailty.gravity
04-23 19:55:39.329+0200 I/linearacceleration( 4053): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:39.329+0200 I/accelerometer( 3999): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:39.349+0200 I/gravity ( 4070): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:39:341,0.054893,9.772348,0.817671
04-23 19:55:39.349+0200 W/CRASH_MANAGER( 3827): worker.c: worker_job(1205) > 11040506c6f63152450613
