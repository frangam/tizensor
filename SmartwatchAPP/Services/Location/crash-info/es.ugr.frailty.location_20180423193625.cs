S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17869
Date: 2018-04-23 19:36:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf742e52d, r5   = 0xf7991958
r6   = 0xff8b5980, r7   = 0xff8b5830
r8   = 0xf79a4c18, r9   = 0x00000000
r10  = 0xff8b590c, fp   = 0xff8b5980
ip   = 0x00000001, sp   = 0xff8b5808
lr   = 0xf742e539, pc   = 0xf7497228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      9200 KB
Buffers:     54616 KB
Cached:     234972 KB
VmPeak:      53488 KB
VmSize:      53404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12136 KB
VmRSS:       12136 KB
VmData:      11132 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17869 TID = 17869
17869 17898 

Maps Information
f42f9000 f4af8000 rw-p [stack:17898]
f4aff000 f4b01000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b09000 f4b0d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b16000 f4b18000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b20000 f4b23000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b32000 f4b37000 r-xp /usr/lib/libsystem.so.0.0.0
f4b42000 f4b45000 r-xp /lib/libattr.so.1.1.0
f4b4d000 f4b5d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b65000 f4b6e000 r-xp /usr/lib/libedbus.so.1.7.99
f4b76000 f4b77000 r-xp /usr/lib/libresponse.so.0.2.96
f4b80000 f4b85000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6427000 f652d000 r-xp /usr/lib/libicuuc.so.57.1
f6543000 f66cb000 r-xp /usr/lib/libicui18n.so.57.1
f66db000 f66e8000 r-xp /usr/lib/libail.so.0.1.0
f66f1000 f66f8000 r-xp /usr/lib/libminizip.so.1.0.0
f6701000 f68aa000 r-xp /usr/lib/libcrypto.so.1.0.0
f68ca000 f6911000 r-xp /usr/lib/libssl.so.1.0.0
f691d000 f691f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6927000 f692e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6937000 f693e000 r-xp /lib/libcrypt-2.13.so
f696f000 f6972000 r-xp /lib/libcap.so.2.21
f697a000 f697c000 r-xp /usr/lib/libiri.so
f6984000 f69cd000 r-xp /usr/lib/libmdm.so.1.2.69
f69d5000 f69db000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69e3000 f6a06000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a10000 f6a12000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a1a000 f6a37000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a40000 f6a44000 r-xp /usr/lib/libsmack.so.1.0.0
f6a4d000 f6a66000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a6f000 f6a77000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a7f000 f6a85000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a8e000 f6a90000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a99000 f6aa9000 r-xp /lib/libresolv-2.13.so
f6aad000 f6ac5000 r-xp /usr/lib/liblzma.so.5.0.3
f6ace000 f6ad0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ad8000 f6af2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6afa000 f6b29000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b32000 f6b41000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b4b000 f6b55000 r-xp /usr/lib/libsensord-shared.so
f6b5e000 f6c31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c3c000 f6c52000 r-xp /lib/libz.so.1.2.5
f6c5a000 f6c5f000 r-xp /usr/lib/libffi.so.5.0.10
f6c67000 f6c68000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c70000 f6c80000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c88000 f6ca1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ca9000 f6cab000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cb3000 f6d28000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d32000 f6d38000 r-xp /lib/librt-2.13.so
f6d41000 f6d5f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d69000 f6d6a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d72000 f6d95000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d9d000 f6da2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6daa000 f6dd4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ddd000 f6df4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dfc000 f6e65000 r-xp /lib/libm-2.13.so
f6e6e000 f6f02000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f15000 f6f1a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f22000 f6f29000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f31000 f6f5b000 r-xp /usr/lib/libsensor.so.1.9.6
f6f64000 f7030000 r-xp /usr/lib/libxml2.so.2.7.8
f703d000 f703f000 r-xp /usr/lib/libiniparser.so.0
f7048000 f704e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7057000 f7127000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7128000 f715c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7165000 f71a1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71a9000 f71ac000 r-xp /usr/lib/libbundle.so.0.1.22
f71b4000 f71ba000 r-xp /usr/lib/libappsvc.so.0.1.0
f71c2000 f7203000 r-xp /usr/lib/libeina.so.1.7.99
f720c000 f7223000 r-xp /usr/lib/libecore.so.1.7.99
f723a000 f7243000 r-xp /usr/lib/libvconf.so.0.2.45
f724b000 f725f000 r-xp /lib/libpthread-2.13.so
f726a000 f7277000 r-xp /usr/lib/libaul.so.0.1.0
f7281000 f7283000 r-xp /lib/libdl-2.13.so
f728c000 f7297000 r-xp /lib/libunwind.so.8.0.1
f72c4000 f72cc000 r-xp /lib/libgcc_s-4.6.so.1
f72cd000 f73f1000 r-xp /lib/libc-2.13.so
f73ff000 f7401000 r-xp /usr/lib/libdlog.so.0.0.0
f7409000 f7415000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f741e000 f7423000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f742b000 f743a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7442000 f7446000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f744f000 f7452000 r-xp /usr/lib/libappcore-agent.so.1.1
f745a000 f745c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7464000 f7468000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7470000 f748d000 r-xp /lib/ld-2.13.so
f7496000 f7499000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7499000 f749d000 r-xp /usr/lib/libsys-assert.so
f7974000 f79d8000 rw-p [heap]
ff897000 ff8b8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17869)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7497228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf742e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71353f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7133c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf713fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7145be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7145dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf717a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71751f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7133c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf713fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7145be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7145dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7177e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7178017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf717ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b171fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b0a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bdd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf708afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf708c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf721cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7217b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72185a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7218879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7450183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74507fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74974f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf72e485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7496f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
19:36:25:123,0.292432,0.763200,-0.345589
04-23 19:36:25.119+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.119+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.119+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:128,-0.216721,0.919232,0.236619
04-23 19:36:25.119+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.119+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:122,-29.330000,2.240000,-4.900000
04-23 19:36:25.129+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:132,-0.121090,0.319048,0.592398
04-23 19:36:25.129+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.129+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.129+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:135,0.088994,-0.078932,0.255599
04-23 19:36:25.129+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:126,10.083356,-0.780060,-0.229711
04-23 19:36:25.129+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.129+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:133,9.785762,-0.632703,0.094569
04-23 19:36:25.129+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.139+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:140,9.980463,-1.071985,-0.117248
04-23 19:36:25.139+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:141,9.783484,-0.666863,0.095555
04-23 19:36:25.139+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:136,-20.580000,5.810000,-6.930000
04-23 19:36:25.139+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.139+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.139+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:146,0.272620,-0.117272,0.094168
04-23 19:36:25.139+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.139+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.149+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:151,9.778976,-0.725651,0.124220
04-23 19:36:25.149+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.149+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:152,9.891929,-0.658026,0.265603
04-23 19:36:25.149+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:146,-8.260000,10.360000,-6.440000
04-23 19:36:25.149+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:155,9.775752,-0.759220,0.169217
04-23 19:36:25.149+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.149+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.149+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:158,9.775887,-0.752061,0.191846
04-23 19:36:25.149+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.149+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.159+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.159+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:159,-7.980000,11.760000,-4.270000
04-23 19:36:25.159+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.159+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:166,0.199521,0.849238,0.368828
04-23 19:36:25.159+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:163,9.592826,-0.356531,0.545564
04-23 19:36:25.159+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:162,9.776039,-0.756079,0.166687
04-23 19:36:25.159+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.159+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.169+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:171,9.580862,-0.401994,0.430708
04-23 19:36:25.169+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:171,9.776566,-0.756021,0.132628
04-23 19:36:25.169+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.169+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:168,-9.170000,4.620000,-1.330000
04-23 19:36:25.169+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.169+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:175,9.756905,-0.976660,0.139054
04-23 19:36:25.169+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.169+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.169+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:177,2.100000,-0.630000,-1.120000
04-23 19:36:25.169+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:179,9.764165,-0.893326,0.182877
04-23 19:36:25.169+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.179+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.179+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.179+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:186,17.500000,4.620000,-4.200000
04-23 19:36:25.179+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:187,-0.304451,1.153009,-0.077491
04-23 19:36:25.179+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:182,10.054641,-0.433101,-0.272782
04-23 19:36:25.179+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.179+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:182,9.764649,-0.880590,0.215788
04-23 19:36:25.179+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.189+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:25.189+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.189+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:25:193,80
04-23 19:36:25.189+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:192,9.765271,-0.870964,0.226471
04-23 19:36:25.189+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.199+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:191,10.248460,-0.349352,-0.904487
04-23 19:36:25.199+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.199+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:202,9.766585,-0.854023,0.234163
04-23 19:36:25.199+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.199+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:198,8.960000,13.510000,-2.940000
04-23 19:36:25.199+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.199+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.199+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:204,10.068997,0.007178,-0.212961
04-23 19:36:25.199+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.209+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:210,-0.206357,0.150741,0.237940
04-23 19:36:25.209+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:206,9.772850,-0.767765,0.268917
04-23 19:36:25.209+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.209+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:208,-5.810000,13.720000,-1.120000
04-23 19:36:25.209+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.209+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:218,9.777648,-0.701090,0.276517
04-23 19:36:25.209+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.209+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:212,9.540184,-0.057428,0.375673
04-23 19:36:25.219+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.219+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.219+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:219,-11.550000,4.340000,1.610000
04-23 19:36:25.219+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.219+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:226,0.108053,-0.423024,0.450558
04-23 19:36:25.219+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:223,9.643075,-0.574277,0.775275
04-23 19:36:25.219+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.229+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:222,9.779090,-0.682460,0.272074
04-23 19:36:25.229+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.229+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:234,9.853643,-0.959522,0.471386
04-23 19:36:25.229+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:234,9.778551,-0.689204,0.274460
04-23 19:36:25.229+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.229+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:229,3.640000,0.280000,-0.140000
04-23 19:36:25.229+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.229+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:238,10.037891,-0.988236,0.320638
04-23 19:36:25.229+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:239,24.850000,1.470000,-2.170000
04-23 19:36:25.239+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.239+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.239+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.239+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:243,9.966106,-0.004786,0.602991
04-23 19:36:25.239+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.239+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.249+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:246,9.780066,-0.670832,0.265880
04-23 19:36:25.249+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:249,0.113378,0.014428,-0.004072
04-23 19:36:25.249+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:243,32.480000,7.560000,-3.710000
04-23 19:36:25.249+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.249+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:258,-1.680000,4.200000,1.470000
04-23 19:36:25.259+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.259+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.259+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.259+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:248,9.468399,0.385244,0.191426
04-23 19:36:25.259+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.269+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:266,9.782314,-0.644117,0.248652
04-23 19:36:25.269+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:271,9.571291,-0.550349,0.514457
04-23 19:36:25.269+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:269,0.154934,0.316694,-0.198881
04-23 19:36:25.269+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.269+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:264,-20.370001,-7.000000,5.110000
04-23 19:36:25.269+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.269+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:276,9.887143,-1.105484,0.722632
04-23 19:36:25.269+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.279+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:280,-4.690000,-7.490000,3.010000
04-23 19:36:25.279+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.279+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:281,9.891929,-0.674776,0.270389
04-23 19:36:25.279+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.279+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.279+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:287,9.785025,-0.604444,0.241514
04-23 19:36:25.279+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.279+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:288,9.934999,-0.354138,0.066999
04-23 19:36:25.289+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.289+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:291,0.114400,0.505334,-0.121833
04-23 19:36:25.289+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:294,9.896714,-0.138784,0.126820
04-23 19:36:25.289+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:284,11.970000,-4.200000,0.280000
04-23 19:36:25.289+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.299+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:299,9.030000,-3.500000,-0.630000
04-23 19:36:25.299+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.299+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:304,-0.140000,-2.030000,1.260000
04-23 19:36:25.299+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.299+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.309+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.309+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:311,9.856036,-0.607777,0.299103
04-23 19:36:25.309+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.309+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:313,0.071012,-0.003333,0.057589
04-23 19:36:25.309+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:311,9.785644,-0.597297,0.234087
04-23 19:36:25.309+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:315,-4.340000,-5.040000,3.360000
04-23 19:36:25.319+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.319+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.319+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:325,0.044071,-0.132514,0.184657
04-23 19:36:25.319+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.319+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:326,9.829715,-0.729811,0.418744
04-23 19:36:25.319+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.319+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:329,9.785152,-0.603877,0.237716
04-23 19:36:25.329+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:330,-0.840000,-2.590000,3.220000
04-23 19:36:25.339+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.339+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.339+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:347,9.753145,-0.413958,0.466600
04-23 19:36:25.339+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:348,-0.032007,0.189919,0.228884
04-23 19:36:25.339+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.339+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.349+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:351,9.785425,-0.596071,0.246034
04-23 19:36:25.349+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:352,2.660000,-2.100000,4.200000
04-23 19:36:25.359+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.359+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.369+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.369+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:373,9.786985,-0.569328,0.247318
04-23 19:36:25.379+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:369,0.008398,0.426180,0.115282
04-23 19:36:25.379+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.379+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.379+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.389+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:25.389+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:25:393,80
04-23 19:36:25.409+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:385,3.920000,-4.550000,5.880000
04-23 19:36:25.409+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.429+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:369,9.793823,-0.169890,0.361316
04-23 19:36:25.429+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.509+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:440,9.791430,0.078963,0.236889
04-23 19:36:25.509+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.509+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:388,0.004445,0.648291,-0.010429
04-23 19:36:25.519+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:391,9.789120,-0.531694,0.246631
04-23 19:36:25.519+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:521,9.834501,-0.143569,0.279960
04-23 19:36:25.519+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.519+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.529+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:415,4.760000,-5.460000,8.330000
04-23 19:36:25.529+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:536,9.790135,-0.515924,0.239701
04-23 19:36:25.539+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.539+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.539+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:544,9.884750,-0.356531,0.224925
04-23 19:36:25.549+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:531,0.045382,0.388124,0.033329
04-23 19:36:25.549+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.549+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.549+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:555,0.094615,0.159393,-0.014776
04-23 19:36:25.559+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.559+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:551,0.350000,-8.330000,10.640000
04-23 19:36:25.569+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.569+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:559,9.790427,-0.516579,0.225991
04-23 19:36:25.569+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.569+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.569+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:578,0.039288,0.095442,-0.087208
04-23 19:36:25.579+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:568,9.829715,-0.421137,0.138784
04-23 19:36:25.579+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:573,-4.900000,-9.170000,12.110000
04-23 19:36:25.589+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.589+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.599+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:586,9.790262,-0.527139,0.208020
04-23 19:36:25.599+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:25.599+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.599+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.609+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:25:607,81
04-23 19:36:25.609+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:603,-6.160000,-9.170000,14.210000
04-23 19:36:25.609+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.609+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:616,-7.490000,-10.010000,16.379999
04-23 19:36:25.609+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.609+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:598,9.786645,-0.504886,0.110070
04-23 19:36:25.619+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.619+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:612,9.789950,-0.547077,0.167223
04-23 19:36:25.619+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:622,-0.980000,-11.620000,17.850000
04-23 19:36:25.619+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.619+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:611,-0.003617,0.022253,-0.097950
04-23 19:36:25.619+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:623,9.738789,-0.830309,-0.102891
04-23 19:36:25.619+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:628,4.760000,-10.220000,18.340000
04-23 19:36:25.619+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.619+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.629+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.629+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:632,3.360000,-7.210000,20.510000
04-23 19:36:25.629+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.629+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:637,0.490000,-6.790000,22.469999
04-23 19:36:25.629+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.629+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.639+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:642,0.140000,-6.230000,23.100000
04-23 19:36:25.639+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.639+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:633,-0.051474,-0.303170,-0.310911
04-23 19:36:25.639+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:637,9.789470,-0.562620,0.141845
04-23 19:36:25.639+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.639+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.639+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:646,0.840000,-6.230000,22.120001
04-23 19:36:25.639+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.649+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:650,16.520000,-0.420000,17.639999
04-23 19:36:25.649+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.649+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:655,46.759998,11.340000,13.160000
04-23 19:36:25.649+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:643,9.841680,-0.600598,-0.205783
04-23 19:36:25.649+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.649+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.659+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:659,78.470001,11.270000,11.900000
04-23 19:36:25.659+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:651,9.639515,-1.764441,0.369971
04-23 19:36:25.659+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:661,9.767502,-0.588634,-0.272782
04-23 19:36:25.659+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.659+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.659+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:650,0.051729,-0.053522,-0.373006
04-23 19:36:25.659+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.659+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.659+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:667,113.260002,5.810000,9.030000
04-23 19:36:25.669+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:666,9.753145,-0.863809,-0.270389
04-23 19:36:25.669+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.669+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:671,9.600466,-1.968507,0.355556
04-23 19:36:25.669+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:669,-0.021968,-0.026014,-0.414626
04-23 19:36:25.669+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:676,9.779467,-1.131805,-0.480957
04-23 19:36:25.669+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.669+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.679+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.679+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:680,9.784252,-1.864009,-0.949951
04-23 19:36:25.679+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.679+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.689+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:684,9.550261,-2.200429,0.347865
04-23 19:36:25.689+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:682,0.113630,0.900632,-0.640360
04-23 19:36:25.689+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.689+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.699+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:36:25.699+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:36:25.699+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:36:25.699+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:686,153.580002,15.680000,-0.070000
04-23 19:36:25.709+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.709+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:685,10.066606,-2.426322,-0.579063
04-23 19:36:25.709+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.709+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:695,0.179001,0.836702,-0.836513
04-23 19:36:25.709+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:713,157.080002,31.219999,-4.900000
04-23 19:36:25.719+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.719+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.719+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:699,9.480409,-2.486013,0.334628
04-23 19:36:25.719+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.719+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:719,9.817751,-2.084148,-0.282353
04-23 19:36:25.719+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.729+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:726,113.050003,31.850000,-0.700000
04-23 19:36:25.729+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:723,0.233991,0.336420,-1.297815
04-23 19:36:25.729+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.729+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:731,9.513863,-2.005185,-0.375673
04-23 19:36:25.729+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.729+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:731,9.385803,-2.823351,0.325231
04-23 19:36:25.729+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:737,9.616754,-3.005385,-0.452243
04-23 19:36:25.729+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.729+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.739+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.739+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:736,0.586197,0.059691,-0.913691
04-23 19:36:25.739+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.739+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:742,9.343184,-2.959574,0.340890
04-23 19:36:25.739+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:746,45.150002,16.379999,4.760000
04-23 19:36:25.739+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:742,10.207782,-2.043471,-0.177069
04-23 19:36:25.739+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.749+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:752,10.076177,-0.430708,0.033500
04-23 19:36:25.749+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.749+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.749+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:748,0.431948,0.739202,-0.607584
04-23 19:36:25.759+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:756,9.432507,-0.471386,0.212961
04-23 19:36:25.759+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.759+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.759+0200 W/LOCATION(17869): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:36:25.759+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:767,2.940000,11.760000,3.640000
04-23 19:36:25.769+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:765,9.466006,-0.909273,0.430708
04-23 19:36:25.769+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.769+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:775,9.903893,-0.789631,0.368495
04-23 19:36:25.779+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.779+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.779+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:780,9.331299,-2.993159,0.371821
04-23 19:36:25.779+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.779+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.789+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:25.789+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:784,0.170678,0.954388,-0.716563
04-23 19:36:25.789+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.789+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:791,9.304914,-3.068943,0.412953
04-23 19:36:25.789+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:25:794,81
04-23 19:36:25.789+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:788,9.748360,-1.155733,0.078963
04-23 19:36:25.789+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.789+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:786,-27.860001,13.650000,3.010000
04-23 19:36:25.799+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:797,0.285455,-0.012226,-0.824064
04-23 19:36:25.799+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.799+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:805,0.902867,1.025472,-0.590022
04-23 19:36:25.799+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.799+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:800,9.296713,-3.083451,0.483568
04-23 19:36:25.799+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.809+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.809+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.809+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:811,9.751595,-1.017658,0.202892
04-23 19:36:25.809+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:813,9.743573,-1.445265,0.693919
04-23 19:36:25.809+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:810,-46.200001,11.200000,0.910000
04-23 19:36:25.809+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.809+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:819,9.744517,-1.066301,0.278855
04-23 19:36:25.819+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:816,0.779464,2.652742,-0.450068
04-23 19:36:25.819+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.819+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.819+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:826,-43.610001,6.020000,-1.680000
04-23 19:36:25.819+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:826,-0.319088,0.546272,0.010069
04-23 19:36:25.819+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.819+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.829+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.829+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:830,9.609575,-1.811367,1.100698
04-23 19:36:25.829+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:833,-0.278511,0.157029,0.151853
04-23 19:36:25.829+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:830,9.740921,-1.086676,0.322455
04-23 19:36:25.829+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.829+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:839,9.736246,-1.117626,0.356109
04-23 19:36:25.839+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.839+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.839+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:843,0.162972,0.297045,0.046039
04-23 19:36:25.839+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.839+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:846,-32.549999,3.850000,-5.040000
04-23 19:36:25.839+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.839+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:849,9.731646,-1.148515,0.382584
04-23 19:36:25.849+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.849+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:850,9.678967,-1.978864,1.519442
04-23 19:36:25.849+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:853,0.012114,-0.038107,-0.277145
04-23 19:36:25.849+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.859+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.859+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:858,9.726921,-1.187804,0.382758
04-23 19:36:25.859+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.859+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.859+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:867,0.011928,-0.296750,0.311334
04-23 19:36:25.859+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.859+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:869,9.729217,-1.981257,1.213161
04-23 19:36:25.869+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:866,-22.960001,1.050000,-8.400000
04-23 19:36:25.869+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.869+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:872,9.721048,-1.228863,0.401880
04-23 19:36:25.869+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.879+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:876,-0.117346,-0.623562,0.717941
04-23 19:36:25.879+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.879+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.879+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.879+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:880,9.713399,-1.277537,0.433774
04-23 19:36:25.879+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.889+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:884,-0.042081,-0.750001,1.117563
04-23 19:36:25.889+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:889,9.690931,-1.801795,0.918844
04-23 19:36:25.889+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.889+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:886,-14.770000,-1.190000,-9.660000
04-23 19:36:25.889+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:891,9.705737,-1.320509,0.474673
04-23 19:36:25.889+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:894,0.015818,-0.703720,0.779387
04-23 19:36:25.889+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.899+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.899+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:905,-0.014806,-0.481287,0.444171
04-23 19:36:25.899+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.899+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:902,9.701814,-1.340784,0.497494
04-23 19:36:25.899+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.909+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.909+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.909+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:911,-6.930000,-2.660000,-9.870000
04-23 19:36:25.909+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:912,9.848858,-1.584049,0.803988
04-23 19:36:25.909+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:913,9.701573,-1.339542,0.505454
04-23 19:36:25.919+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:916,0.147044,-0.243265,0.306494
04-23 19:36:25.919+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.919+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.919+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.919+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:927,9.745967,-1.497907,0.811167
04-23 19:36:25.919+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.929+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:926,-2.170000,-3.080000,-9.380000
04-23 19:36:25.929+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:927,9.703640,-1.323635,0.507685
04-23 19:36:25.929+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:931,0.044394,-0.158365,0.305713
04-23 19:36:25.939+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.939+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.939+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.939+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:947,9.664611,-1.170090,0.882952
04-23 19:36:25.939+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:947,9.705761,-1.305547,0.513940
04-23 19:36:25.939+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.949+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:946,2.520000,-1.680000,-10.150000
04-23 19:36:25.949+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:951,-0.039029,0.153545,0.375267
04-23 19:36:25.959+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.959+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.959+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.959+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.969+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:967,-0.140000,-5.880000,-9.100000
04-23 19:36:25.969+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:968,9.711023,-1.265431,0.514869
04-23 19:36:25.969+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:970,9.659825,-0.890130,0.612563
04-23 19:36:25.969+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:25:970,-0.045936,0.415417,0.098623
04-23 19:36:25.979+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:25.979+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:25.989+0200 I/heartrate(17736): capturing data from es.ugr.frailty.heartrate
04-23 19:36:25.989+0200 I/gyroscope(17856): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:36:25:991,-4.620000,-9.660000,-5.740000
04-23 19:36:25.989+0200 I/accelerometer(17843): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:36:25:988,9.714860,-0.959522,0.122034
04-23 19:36:25.989+0200 I/heartrate(17736): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:36:25:993,81
04-23 19:36:25.989+0200 I/gravity (17885): capturing data from es.ugr.frailty.gravity
04-23 19:36:25.989+0200 I/linearacceleration(17872): capturing data from es.ugr.frailty.linearacceleration
04-23 19:36:25.999+0200 I/gravity (17885): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:36:25:999,9.718918,-1.210864,0.496825
04-23 19:36:25.999+0200 I/linearacceleration(17872): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:36:26:3,0.003837,0.305909,-0.392835
04-23 19:36:25.999+0200 I/accelerometer(17843): capturing data from es.ugr.frailty.accelerometer
04-23 19:36:26.009+0200 I/gyroscope(17856): capturing data from es.ugr.frailty.gyroscope
04-23 19:36:26.029+0200 W/CRASH_MANAGER(17806): worker.c: worker_job(1205) > 11178696c6f63152450498
