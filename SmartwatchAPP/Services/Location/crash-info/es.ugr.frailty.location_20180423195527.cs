S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3916
Date: 2018-04-23 19:55:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f8a52d, r5   = 0xf7218f98
r6   = 0xff865070, r7   = 0xff864f20
r8   = 0xf7215c18, r9   = 0x00000000
r10  = 0xff864ffc, fp   = 0xff865070
ip   = 0x00000001, sp   = 0xff864ef8
lr   = 0xf6f8a539, pc   = 0xf6ff3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     70740 KB
Buffers:     31780 KB
Cached:     219732 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12084 KB
VmRSS:       12080 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3916 TID = 3916
3916 3946 

Maps Information
f3e55000 f4654000 rw-p [stack:3946]
f465b000 f465d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4665000 f4669000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4672000 f4674000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f467c000 f467f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f468e000 f4693000 r-xp /usr/lib/libsystem.so.0.0.0
f469e000 f46a1000 r-xp /lib/libattr.so.1.1.0
f46a9000 f46b9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46c1000 f46ca000 r-xp /usr/lib/libedbus.so.1.7.99
f46d2000 f46d3000 r-xp /usr/lib/libresponse.so.0.2.96
f46dc000 f46e1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f83000 f6089000 r-xp /usr/lib/libicuuc.so.57.1
f609f000 f6227000 r-xp /usr/lib/libicui18n.so.57.1
f6237000 f6244000 r-xp /usr/lib/libail.so.0.1.0
f624d000 f6254000 r-xp /usr/lib/libminizip.so.1.0.0
f625d000 f6406000 r-xp /usr/lib/libcrypto.so.1.0.0
f6426000 f646d000 r-xp /usr/lib/libssl.so.1.0.0
f6479000 f647b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6483000 f648a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6493000 f649a000 r-xp /lib/libcrypt-2.13.so
f64cb000 f64ce000 r-xp /lib/libcap.so.2.21
f64d6000 f64d8000 r-xp /usr/lib/libiri.so
f64e0000 f6529000 r-xp /usr/lib/libmdm.so.1.2.69
f6531000 f6537000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f653f000 f6562000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f656c000 f656e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6576000 f6593000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f659c000 f65a0000 r-xp /usr/lib/libsmack.so.1.0.0
f65a9000 f65c2000 r-xp /usr/lib/libnetwork.so.0.0.0
f65cb000 f65d3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65db000 f65e1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65ea000 f65ec000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65f5000 f6605000 r-xp /lib/libresolv-2.13.so
f6609000 f6621000 r-xp /usr/lib/liblzma.so.5.0.3
f662a000 f662c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6634000 f664e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6656000 f6685000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f668e000 f669d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f66a7000 f66b1000 r-xp /usr/lib/libsensord-shared.so
f66ba000 f678d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6798000 f67ae000 r-xp /lib/libz.so.1.2.5
f67b6000 f67bb000 r-xp /usr/lib/libffi.so.5.0.10
f67c3000 f67c4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67cc000 f67dc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67e4000 f67fd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6805000 f6807000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f680f000 f6884000 r-xp /usr/lib/libsqlite3.so.0.8.6
f688e000 f6894000 r-xp /lib/librt-2.13.so
f689d000 f68bb000 r-xp /usr/lib/libsystemd.so.0.4.0
f68c5000 f68c6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68ce000 f68f1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68f9000 f68fe000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6906000 f6930000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6939000 f6950000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6958000 f69c1000 r-xp /lib/libm-2.13.so
f69ca000 f6a5e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a71000 f6a76000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a7e000 f6a85000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a8d000 f6ab7000 r-xp /usr/lib/libsensor.so.1.9.6
f6ac0000 f6b8c000 r-xp /usr/lib/libxml2.so.2.7.8
f6b99000 f6b9b000 r-xp /usr/lib/libiniparser.so.0
f6ba4000 f6baa000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6bb3000 f6c83000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c84000 f6cb8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cc1000 f6cfd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d05000 f6d08000 r-xp /usr/lib/libbundle.so.0.1.22
f6d10000 f6d16000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d1e000 f6d5f000 r-xp /usr/lib/libeina.so.1.7.99
f6d68000 f6d7f000 r-xp /usr/lib/libecore.so.1.7.99
f6d96000 f6d9f000 r-xp /usr/lib/libvconf.so.0.2.45
f6da7000 f6dbb000 r-xp /lib/libpthread-2.13.so
f6dc6000 f6dd3000 r-xp /usr/lib/libaul.so.0.1.0
f6ddd000 f6ddf000 r-xp /lib/libdl-2.13.so
f6de8000 f6df3000 r-xp /lib/libunwind.so.8.0.1
f6e20000 f6e28000 r-xp /lib/libgcc_s-4.6.so.1
f6e29000 f6f4d000 r-xp /lib/libc-2.13.so
f6f5b000 f6f5d000 r-xp /usr/lib/libdlog.so.0.0.0
f6f65000 f6f71000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f7a000 f6f7f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f87000 f6f96000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f9e000 f6fa2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fab000 f6fae000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fb6000 f6fb8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fc0000 f6fc4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fcc000 f6fe9000 r-xp /lib/ld-2.13.so
f6ff2000 f6ff5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6ff5000 f6ff9000 r-xp /usr/lib/libsys-assert.so
f71e5000 f7268000 rw-p [heap]
ff846000 ff867000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3916)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6ff3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f8a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c913f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c8fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c9be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ca1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ca1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cd675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cd11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c8fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c9be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ca1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ca1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cd3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cd4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6cdbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46731fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4666171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6739663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6be6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6be87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d78ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d73b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d745a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d74879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6fac183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6fac7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6ff34f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6e4085c) [/lib/libc.so.6] + 0x1785c
29: (0xf6ff2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.889+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:898,0.036061,9.775610,0.778808
04-23 19:55:26.889+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.889+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:899,-0.070000,0.070000,0.070000
04-23 19:55:26.899+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.899+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.899+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:902,0.038249,9.775344,0.782026
04-23 19:55:26.899+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:26.899+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.899+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:26:908,-0.028989,-0.000274,0.009928
04-23 19:55:26.899+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:909,0.037194,9.775345,0.782072
04-23 19:55:26.899+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.909+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:26:906,0.009571,9.774680,0.796810
04-23 19:55:26.909+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:903,-0.070000,0.070000,-0.070000
04-23 19:55:26.909+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.909+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:913,0.037216,9.775233,0.783466
04-23 19:55:26.909+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.909+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:916,-0.070000,0.070000,-0.070000
04-23 19:55:26.909+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.909+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:917,0.038561,9.774954,0.786882
04-23 19:55:26.909+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.919+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:920,-0.140000,0.070000,-0.070000
04-23 19:55:26.919+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.919+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.919+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:922,0.037027,9.775056,0.785685
04-23 19:55:26.919+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.919+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:26:926,0.014357,9.851252,0.775275
04-23 19:55:26.919+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:26.919+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:928,0.035771,9.775246,0.783371
04-23 19:55:26.929+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:26:930,-0.022670,0.076196,-0.010411
04-23 19:55:26.929+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:924,-0.070000,-0.070000,-0.070000
04-23 19:55:26.929+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.929+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:937,-0.140000,0.070000,-0.070000
04-23 19:55:26.929+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.939+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.939+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.939+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:26.939+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:946,0.035619,9.775322,0.782428
04-23 19:55:26.939+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:941,-0.140000,0.070000,-0.070000
04-23 19:55:26.939+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.949+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:26:947,0.035892,9.812965,0.792024
04-23 19:55:26.949+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:951,-0.070000,0.070000,-0.070000
04-23 19:55:26.949+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.949+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:26:950,0.000121,0.037720,0.008653
04-23 19:55:26.949+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:956,-0.140000,0.070000,-0.070000
04-23 19:55:26.959+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.959+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.959+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.959+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:965,0.034454,9.775331,0.782378
04-23 19:55:26.959+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:969,-0.070000,0.140000,-0.070000
04-23 19:55:26.959+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:26.969+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:26:966,0.014357,9.779467,0.825524
04-23 19:55:26.969+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:26:972,-0.021262,0.004145,0.043096
04-23 19:55:26.979+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.979+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.979+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:26:986,0.036045,9.775141,0.784671
04-23 19:55:26.979+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.979+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:26.989+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:26.989+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:26.989+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:26:993,-0.070000,0.140000,-0.070000
04-23 19:55:26.989+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:26:986,0.071785,9.803394,0.832702
04-23 19:55:26.989+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:26:991,0.037330,0.028064,0.050324
04-23 19:55:26.999+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:26.999+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:26.999+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:26.999+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:6,0.036336,9.775296,0.782714
04-23 19:55:26.999+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.009+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:7,0.045464,9.796216,0.768096
04-23 19:55:27.009+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:11,-0.070000,0.140000,-0.070000
04-23 19:55:27.009+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:12,0.009419,0.021075,-0.016575
04-23 19:55:27.019+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.019+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.019+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:25,0.026321,9.810574,0.806381
04-23 19:55:27.019+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.019+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:25,0.035703,9.775339,0.782211
04-23 19:55:27.019+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.029+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:30,-0.140000,0.070000,-0.070000
04-23 19:55:27.029+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:31,-0.010015,0.035277,0.023668
04-23 19:55:27.039+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.039+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.039+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:46,0.028714,9.793823,0.760918
04-23 19:55:27.039+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:47,0.035220,9.775559,0.779478
04-23 19:55:27.039+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.049+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.049+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:53,-0.070000,-0.070000,-0.070000
04-23 19:55:27.049+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:54,-0.006989,0.018484,-0.021293
04-23 19:55:27.059+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.059+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.059+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:65,0.026321,9.808180,0.835095
04-23 19:55:27.059+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.059+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.059+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:65,0.034660,9.775517,0.780026
04-23 19:55:27.069+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:71,-0.140000,-0.070000,-0.070000
04-23 19:55:27.069+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:72,-0.008899,0.032620,0.055617
04-23 19:55:27.079+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.079+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.079+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:87,0.028714,9.820145,0.806381
04-23 19:55:27.089+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.089+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:87,0.034219,9.775551,0.779623
04-23 19:55:27.089+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.099+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:93,-0.140000,0.070000,-0.070000
04-23 19:55:27.099+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:97,-0.005946,0.044627,0.026355
04-23 19:55:27.099+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.099+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.099+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.109+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.109+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:107,0.033683,9.775691,0.777890
04-23 19:55:27.109+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:107,0.026321,9.803394,0.775275
04-23 19:55:27.109+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:110,-0.140000,0.070000,-0.070000
04-23 19:55:27.119+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.119+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.119+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.129+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:114,-0.007898,0.027843,-0.004348
04-23 19:55:27.129+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.129+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:129,0.034295,9.775541,0.779743
04-23 19:55:27.139+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.149+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:140,0.016567,0.034883,0.057205
04-23 19:55:27.149+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.159+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:151,0.036024,9.775372,0.781795
04-23 19:55:27.159+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.169+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:157,0.039882,0.011104,0.043388
04-23 19:55:27.169+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:168,0.038548,9.775013,0.786140
04-23 19:55:27.169+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.179+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.189+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:27.189+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:27.189+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:180,0.050118,0.018452,0.026979
04-23 19:55:27.189+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.189+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:189,0.038687,9.774727,0.789688
04-23 19:55:27.199+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:197,-0.000263,0.009239,0.036991
04-23 19:55:27.199+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:128,0.050249,9.810574,0.835095
04-23 19:55:27.199+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.209+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:126,-0.070000,0.140000,-0.070000
04-23 19:55:27.209+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.219+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.219+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:221,0.074178,9.786645,0.823131
04-23 19:55:27.229+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:213,-0.024330,0.004740,0.026264
04-23 19:55:27.229+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.229+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.239+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:227,-0.070000,0.070000,-0.070000
04-23 19:55:27.239+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.239+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:239,-0.020929,0.059967,-0.009665
04-23 19:55:27.249+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:249,-0.070000,0.070000,0.070000
04-23 19:55:27.249+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.249+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.249+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:258,0.037679,9.774534,0.792118
04-23 19:55:27.259+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.259+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:244,0.086142,9.793823,0.808774
04-23 19:55:27.259+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.259+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:263,0.036810,9.774431,0.793431
04-23 19:55:27.259+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.259+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.259+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:261,-0.010489,0.028963,0.003379
04-23 19:55:27.269+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:269,0.036452,9.774284,0.795247
04-23 19:55:27.269+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.269+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:273,0.036036,9.774415,0.793660
04-23 19:55:27.269+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:266,0.038285,9.784252,0.823131
04-23 19:55:27.269+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.269+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.279+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:279,0.014357,9.779467,0.815953
04-23 19:55:27.279+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.279+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.279+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:273,-0.140000,0.070000,0.070000
04-23 19:55:27.279+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.279+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:285,0.035422,9.774372,0.794212
04-23 19:55:27.279+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:287,-0.070000,0.070000,0.070000
04-23 19:55:27.289+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:284,0.016750,9.834501,0.782453
04-23 19:55:27.289+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.289+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:280,-0.005345,0.038681,-0.000830
04-23 19:55:27.289+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.289+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:293,0.026321,9.803394,0.796810
04-23 19:55:27.289+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.289+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.289+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:297,0.031107,9.812965,0.794417
04-23 19:55:27.289+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.299+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:298,-0.140000,0.140000,0.070000
04-23 19:55:27.299+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.299+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:295,-0.009715,0.028979,0.051006
04-23 19:55:27.299+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.299+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:306,0.035968,9.774093,0.797628
04-23 19:55:27.299+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.299+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:302,0.026321,9.803394,0.844666
04-23 19:55:27.299+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.309+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:311,0.040678,9.803394,0.792024
04-23 19:55:27.309+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:311,-0.070000,0.070000,0.070000
04-23 19:55:27.309+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:308,0.005256,0.029022,-0.002188
04-23 19:55:27.309+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.309+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:318,-0.070000,0.070000,-0.070000
04-23 19:55:27.319+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.319+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.319+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.319+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:326,0.037479,9.773874,0.800226
04-23 19:55:27.319+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.319+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:323,-0.070000,0.070000,-0.070000
04-23 19:55:27.329+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.329+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:326,0.064606,9.779467,0.806381
04-23 19:55:27.329+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:331,0.028638,0.005374,0.008753
04-23 19:55:27.329+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:333,-0.070000,0.070000,0.140000
04-23 19:55:27.329+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.339+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.339+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.339+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.339+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:345,0.038448,9.773538,0.804276
04-23 19:55:27.339+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:341,-0.070000,0.070000,0.070000
04-23 19:55:27.339+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.349+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:345,0.055035,9.798609,0.842274
04-23 19:55:27.349+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:352,-0.070000,0.070000,0.070000
04-23 19:55:27.349+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:348,0.017556,0.024734,0.042047
04-23 19:55:27.359+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.359+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.359+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:366,0.083749,9.824929,0.782453
04-23 19:55:27.359+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:366,0.040772,9.773521,0.804359
04-23 19:55:27.359+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.359+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.369+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:369,0.045301,0.051392,-0.021823
04-23 19:55:27.369+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:370,-0.070000,-0.070000,0.070000
04-23 19:55:27.379+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.379+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.379+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:388,0.041607,9.773529,0.804226
04-23 19:55:27.379+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.389+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:27.389+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:27.389+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.389+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:394,-0.070000,0.070000,0.070000
04-23 19:55:27.389+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:393,0.014263,0.025087,-0.033870
04-23 19:55:27.389+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:388,0.055035,9.798609,0.770489
04-23 19:55:27.399+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.399+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.399+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:407,0.028714,9.784252,0.818345
04-23 19:55:27.399+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:407,0.041142,9.773343,0.806512
04-23 19:55:27.399+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.409+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.409+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:412,-0.012893,0.010723,0.014120
04-23 19:55:27.409+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:414,-0.070000,0.070000,0.070000
04-23 19:55:27.419+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.419+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.419+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.419+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:427,0.042057,9.773118,0.809181
04-23 19:55:27.419+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.429+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:428,0.057428,9.789038,0.825524
04-23 19:55:27.429+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:432,-0.070000,0.070000,0.070000
04-23 19:55:27.439+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:431,0.016286,0.015695,0.019012
04-23 19:55:27.439+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.449+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:448,0.042244,9.773060,0.809875
04-23 19:55:27.449+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.449+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.459+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:456,-0.070000,0.070000,0.070000
04-23 19:55:27.459+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.469+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:466,0.042427,9.772891,0.811903
04-23 19:55:27.479+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 19:55:27.479+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:55:27.479+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 19:55:27.479+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.479+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.489+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.489+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:493,0.043071,9.824929,0.792024
04-23 19:55:27.499+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:491,0.001014,0.051811,-0.017157
04-23 19:55:27.499+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.499+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.499+0200 W/LOCATION( 3916): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:55:27.509+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:512,0.043071,9.796216,0.818345
04-23 19:55:27.509+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.519+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:518,0.026321,9.769895,0.806381
04-23 19:55:27.519+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.519+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:524,0.040678,9.798609,0.792024
04-23 19:55:27.519+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.529+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:530,0.043071,9.755538,0.796810
04-23 19:55:27.529+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:486,0.041808,9.772762,0.813478
04-23 19:55:27.529+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.529+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:490,-0.070000,0.070000,0.070000
04-23 19:55:27.529+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:511,0.000826,0.023156,0.008470
04-23 19:55:27.529+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.529+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.539+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:539,-0.016106,-0.002996,-0.005522
04-23 19:55:27.539+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.539+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.539+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:546,0.016750,9.765109,0.818345
04-23 19:55:27.549+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:544,-0.001130,0.025846,-0.021454
04-23 19:55:27.549+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.549+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:539,0.042050,9.772586,0.815590
04-23 19:55:27.549+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:544,-0.070000,0.070000,0.070000
04-23 19:55:27.549+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:555,0.001021,-0.017048,-0.018780
04-23 19:55:27.549+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.549+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.549+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.559+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.559+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:565,0.064606,9.798609,0.815953
04-23 19:55:27.559+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:561,-0.025502,-0.007401,0.001859
04-23 19:55:27.559+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.569+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:572,0.023422,0.026278,-0.002729
04-23 19:55:27.569+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:566,-0.070000,0.070000,0.140000
04-23 19:55:27.569+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.569+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:563,0.042252,9.772510,0.816486
04-23 19:55:27.569+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.579+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:578,-0.070000,0.070000,0.070000
04-23 19:55:27.579+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.579+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.579+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.579+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:586,0.028714,9.801002,0.789631
04-23 19:55:27.579+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:586,-0.013710,0.028771,-0.030186
04-23 19:55:27.589+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:584,-0.070000,0.140000,0.070000
04-23 19:55:27.589+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:27.589+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:27.589+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.589+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:580,0.041184,9.772330,0.818682
04-23 19:55:27.589+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:594,0.070000,0.140000,0.070000
04-23 19:55:27.589+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.589+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.599+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:599,0.070000,0.140000,0.070000
04-23 19:55:27.599+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.599+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.599+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:606,0.055035,9.791430,0.815953
04-23 19:55:27.599+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.599+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:607,0.013138,0.019224,-0.004176
04-23 19:55:27.609+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:600,0.042424,9.772230,0.819817
04-23 19:55:27.609+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.609+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:614,0.041897,9.772206,0.820128
04-23 19:55:27.609+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.619+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:611,0.070000,0.140000,0.070000
04-23 19:55:27.619+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.619+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.619+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:626,-0.016329,0.004966,-0.022074
04-23 19:55:27.619+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:625,0.026321,9.777073,0.799203
04-23 19:55:27.619+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.619+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:619,0.042650,9.772107,0.821277
04-23 19:55:27.619+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.629+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:631,0.070000,0.140000,0.070000
04-23 19:55:27.629+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:631,0.042004,9.772040,0.822102
04-23 19:55:27.639+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.639+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.639+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:646,0.020209,0.016997,0.015386
04-23 19:55:27.639+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:645,0.062213,9.789038,0.837488
04-23 19:55:27.639+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.639+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.649+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:650,0.070000,-0.140000,0.070000
04-23 19:55:27.649+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:650,0.043111,9.771900,0.823707
04-23 19:55:27.659+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.659+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.659+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.659+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:666,0.038285,9.769895,0.832702
04-23 19:55:27.659+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.659+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:669,0.070000,0.070000,0.140000
04-23 19:55:27.669+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:666,-0.004825,-0.002006,0.008995
04-23 19:55:27.669+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:671,0.043175,9.771613,0.827102
04-23 19:55:27.679+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.679+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.679+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:687,0.070000,0.070000,0.070000
04-23 19:55:27.679+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.679+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:687,0.033500,9.796216,0.820738
04-23 19:55:27.679+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.689+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:690,-0.009675,0.024603,-0.006364
04-23 19:55:27.689+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:692,0.042852,9.771512,0.828312
04-23 19:55:27.699+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.699+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.699+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.699+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:707,0.024147,0.039062,-0.045859
04-23 19:55:27.699+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:707,0.066999,9.810574,0.782453
04-23 19:55:27.699+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.709+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:706,0.070000,0.070000,0.070000
04-23 19:55:27.709+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:712,0.044147,9.771656,0.826548
04-23 19:55:27.719+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.719+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.719+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.719+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:726,0.081356,9.798609,0.756132
04-23 19:55:27.719+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.719+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:726,-0.070000,-0.070000,0.140000
04-23 19:55:27.729+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:728,0.037209,0.026953,-0.070416
04-23 19:55:27.729+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:732,0.046266,9.771838,0.824266
04-23 19:55:27.739+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.739+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.739+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.739+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:745,0.064606,9.791430,0.815953
04-23 19:55:27.739+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.739+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:749,0.018341,0.019592,-0.008314
04-23 19:55:27.749+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:746,-0.070000,0.070000,0.140000
04-23 19:55:27.749+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:751,0.047430,9.771648,0.826447
04-23 19:55:27.759+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.759+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.759+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:766,-0.070000,0.140000,0.070000
04-23 19:55:27.759+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.759+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:766,0.040678,9.772287,0.808774
04-23 19:55:27.759+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.769+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:770,-0.006752,0.000639,-0.017673
04-23 19:55:27.769+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:771,0.047251,9.771565,0.827444
04-23 19:55:27.779+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.779+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.779+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:787,-0.070000,0.140000,0.070000
04-23 19:55:27.779+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.779+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:788,0.028714,9.786645,0.811167
04-23 19:55:27.789+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.789+0200 I/heartrate( 3676): capturing data from es.ugr.frailty.heartrate
04-23 19:55:27.789+0200 I/heartrate( 3676): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:55:27.789+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:791,-0.018537,0.015079,-0.016277
04-23 19:55:27.789+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:793,0.046510,9.771460,0.828730
04-23 19:55:27.799+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.799+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.799+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.799+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:807,0.045464,9.784252,0.808774
04-23 19:55:27.799+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:809,-0.001046,0.012793,-0.019956
04-23 19:55:27.809+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:806,-0.070000,0.070000,0.070000
04-23 19:55:27.809+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.819+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:821,0.046606,9.771406,0.829358
04-23 19:55:27.819+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.819+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.829+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:831,0.078963,9.779467,0.806381
04-23 19:55:27.829+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.839+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.839+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.839+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:844,0.032357,0.008060,-0.022977
04-23 19:55:27.839+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.839+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:827,-0.070000,0.070000,0.140000
04-23 19:55:27.849+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:851,0.055035,9.793823,0.837488
04-23 19:55:27.849+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.849+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:839,0.048445,9.771308,0.830407
04-23 19:55:27.849+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.859+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.859+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:865,0.086142,9.798609,0.820738
04-23 19:55:27.859+0200 I/linearacceleration( 3919): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:55:27:849,0.006590,0.022515,0.007081
04-23 19:55:27.859+0200 I/linearacceleration( 3919): capturing data from es.ugr.frailty.linearacceleration
04-23 19:55:27.869+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:861,0.048898,9.771158,0.832140
04-23 19:55:27.869+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.869+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:874,0.050801,9.771132,0.832327
04-23 19:55:27.869+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:859,-0.070000,0.070000,0.070000
04-23 19:55:27.869+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.869+0200 I/gyroscope( 3900): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:55:27:879,-0.070000,0.070000,0.070000
04-23 19:55:27.879+0200 I/accelerometer( 3878): capturing data from es.ugr.frailty.accelerometer
04-23 19:55:27.879+0200 I/gravity ( 3933): capturing data from es.ugr.frailty.gravity
04-23 19:55:27.879+0200 I/gravity ( 3933): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:55:27:886,0.048993,9.770977,0.834259
04-23 19:55:27.879+0200 I/accelerometer( 3878): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:55:27:886,0.009571,9.779467,0.825524
04-23 19:55:27.879+0200 I/gyroscope( 3900): capturing data from es.ugr.frailty.gyroscope
04-23 19:55:27.889+0200 W/CRASH_MANAGER( 3827): worker.c: worker_job(1205) > 11039166c6f63152450612
