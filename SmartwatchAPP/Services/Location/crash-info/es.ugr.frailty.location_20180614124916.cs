S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6722
Date: 2018-06-14 12:49:16+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf748052d, r5   = 0xf75e4150
r6   = 0xffc70350, r7   = 0xffc70200
r8   = 0xf75f6c18, r9   = 0x00000000
r10  = 0xffc702dc, fp   = 0xffc70350
ip   = 0x00000001, sp   = 0xffc701d8
lr   = 0xf7480539, pc   = 0xf74e9270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5632 KB
Buffers:     26684 KB
Cached:     116384 KB
VmPeak:      53520 KB
VmSize:      53456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12180 KB
VmRSS:       12180 KB
VmData:      11184 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6722 TID = 6722
6722 6762 

Maps Information
f434b000 f4b4a000 rw-p [stack:6762]
f4b51000 f4b53000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b5b000 f4b5f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b68000 f4b6a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b72000 f4b75000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b84000 f4b89000 r-xp /usr/lib/libsystem.so.0.0.0
f4b94000 f4b97000 r-xp /lib/libattr.so.1.1.0
f4b9f000 f4baf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bb7000 f4bc0000 r-xp /usr/lib/libedbus.so.1.7.99
f4bc8000 f4bc9000 r-xp /usr/lib/libresponse.so.0.2.96
f4bd2000 f4bd7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6479000 f657f000 r-xp /usr/lib/libicuuc.so.57.1
f6595000 f671d000 r-xp /usr/lib/libicui18n.so.57.1
f672d000 f673a000 r-xp /usr/lib/libail.so.0.1.0
f6743000 f674a000 r-xp /usr/lib/libminizip.so.1.0.0
f6753000 f68fc000 r-xp /usr/lib/libcrypto.so.1.0.0
f691c000 f6963000 r-xp /usr/lib/libssl.so.1.0.0
f696f000 f6971000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6979000 f6980000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6989000 f6990000 r-xp /lib/libcrypt-2.13.so
f69c1000 f69c4000 r-xp /lib/libcap.so.2.21
f69cc000 f69ce000 r-xp /usr/lib/libiri.so
f69d6000 f6a1f000 r-xp /usr/lib/libmdm.so.1.2.69
f6a27000 f6a2d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a35000 f6a58000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a62000 f6a64000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a6c000 f6a89000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a92000 f6a96000 r-xp /usr/lib/libsmack.so.1.0.0
f6a9f000 f6ab8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ac1000 f6ac9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6ad1000 f6ad7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6ae0000 f6ae2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aeb000 f6afb000 r-xp /lib/libresolv-2.13.so
f6aff000 f6b17000 r-xp /usr/lib/liblzma.so.5.0.3
f6b20000 f6b22000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b2a000 f6b44000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b4c000 f6b7b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b84000 f6b93000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b9d000 f6ba7000 r-xp /usr/lib/libsensord-shared.so
f6bb0000 f6c83000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c8e000 f6ca4000 r-xp /lib/libz.so.1.2.5
f6cac000 f6cb1000 r-xp /usr/lib/libffi.so.5.0.10
f6cb9000 f6cba000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cc2000 f6cd2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6cda000 f6cf3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6cfb000 f6cfd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d05000 f6d7a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d84000 f6da2000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dac000 f6dad000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6db5000 f6dd8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6de0000 f6de5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ded000 f6e17000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e20000 f6e37000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e3f000 f6e45000 r-xp /lib/librt-2.13.so
f6e4e000 f6eb7000 r-xp /lib/libm-2.13.so
f6ec0000 f6f54000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f67000 f6f6c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f74000 f6f7b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f83000 f6fad000 r-xp /usr/lib/libsensor.so.1.9.6
f6fb6000 f7082000 r-xp /usr/lib/libxml2.so.2.7.8
f708f000 f7091000 r-xp /usr/lib/libiniparser.so.0
f709a000 f70a0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70a9000 f7179000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f717a000 f71ae000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71b7000 f71f3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71fb000 f71fe000 r-xp /usr/lib/libbundle.so.0.1.22
f7206000 f720c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7214000 f7255000 r-xp /usr/lib/libeina.so.1.7.99
f725e000 f7267000 r-xp /usr/lib/libvconf.so.0.2.45
f726f000 f7283000 r-xp /lib/libpthread-2.13.so
f728e000 f729b000 r-xp /usr/lib/libaul.so.0.1.0
f72a5000 f72a7000 r-xp /lib/libdl-2.13.so
f72b0000 f72bb000 r-xp /lib/libunwind.so.8.0.1
f72e8000 f72f0000 r-xp /lib/libgcc_s-4.6.so.1
f72f1000 f7415000 r-xp /lib/libc-2.13.so
f7423000 f743a000 r-xp /usr/lib/libecore.so.1.7.99
f7451000 f7453000 r-xp /usr/lib/libdlog.so.0.0.0
f745b000 f7467000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7470000 f7475000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f747d000 f748c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7494000 f7498000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74a1000 f74a4000 r-xp /usr/lib/libappcore-agent.so.1.1
f74ac000 f74ae000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74b6000 f74ba000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f74c2000 f74df000 r-xp /lib/ld-2.13.so
f74e8000 f74eb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f74eb000 f74ef000 r-xp /usr/lib/libsys-assert.so
f75c6000 f7637000 rw-p [heap]
ffc51000 ffc72000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6722)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf74e9270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf7480539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71873f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7185c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7191e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7197be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7197dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf71cc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71c71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7185c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7191e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7197be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7197dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf71c9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf71ca017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71d1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b691fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b5c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c2f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf70dcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70de7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7433ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf742eb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf742f5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf742f879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74a2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74a27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74e960b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf730885c) [/lib/libc.so.6] + 0x1785c
29: (0xf74e8f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
00 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:422,6.635297,-6.994221,-1.603191
06-14 12:49:15.431+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.441+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:435,-2.590000,-11.060000,-6.580000
06-14 12:49:15.441+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:415,-0.320244,-0.527904,0.255700
06-14 12:49:15.441+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.441+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:443,6.369694,-7.281359,-0.885344
06-14 12:49:15.441+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.441+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:438,6.536031,-7.115766,-1.678261
06-14 12:49:15.441+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.451+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:453,-5.810000,-13.370000,-7.420000
06-14 12:49:15.451+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.451+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:455,6.529549,-7.123007,-1.672765
06-14 12:49:15.451+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.451+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:448,0.253991,0.227937,-0.033705
06-14 12:49:15.451+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:459,6.525558,-7.123797,-1.684932
06-14 12:49:15.451+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.451+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:459,6.719046,-7.322037,-1.007378
06-14 12:49:15.451+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.461+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:464,0.088135,0.103637,0.107208
06-14 12:49:15.461+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.461+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:465,6.618547,-7.396214,-1.263410
06-14 12:49:15.461+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.461+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:15.461+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.471+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.471+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:473,-8.330000,-16.030001,-5.320000
06-14 12:49:15.471+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:476,6.516532,-7.130053,-1.693379
06-14 12:49:15.471+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:469,-0.178725,-0.186219,0.831507
06-14 12:49:15.471+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.471+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:15:472,150.000000
06-14 12:49:15.471+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:471,6.446264,-7.152147,-1.454836
06-14 12:49:15.471+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:481,0.179167,-0.214753,0.691705
06-14 12:49:15.481+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.481+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.481+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:486,0.082516,-0.280449,0.414851
06-14 12:49:15.481+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:486,6.697510,-7.556533,-1.323231
06-14 12:49:15.481+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.481+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.491+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:492,6.508975,-7.128864,-1.727115
06-14 12:49:15.491+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:492,-9.520000,-17.639999,-2.940000
06-14 12:49:15.491+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.491+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.491+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:498,6.463014,-6.941578,-1.715654
06-14 12:49:15.491+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:498,-0.083284,-0.029140,0.217929
06-14 12:49:15.491+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.501+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:503,0.171953,-0.432736,0.361701
06-14 12:49:15.501+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.501+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:507,-0.053518,0.188475,-0.022275
06-14 12:49:15.501+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.501+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.511+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:512,6.477692,-7.146953,-1.769450
06-14 12:49:15.511+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.511+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:513,-7.490000,-20.580000,0.910000
06-14 12:49:15.511+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.511+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:516,-0.141674,-0.085496,-0.225428
06-14 12:49:15.511+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:518,6.367301,-7.214360,-1.952543
06-14 12:49:15.521+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.521+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.531+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:532,6.448610,-7.160497,-1.820193
06-14 12:49:15.531+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:533,-10.360000,-21.629999,6.160000
06-14 12:49:15.531+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.531+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.531+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:538,-0.024250,0.095304,-0.300341
06-14 12:49:15.531+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:538,6.453443,-7.051648,-2.069792
06-14 12:49:15.551+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.551+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.551+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:559,6.423877,-7.174245,-1.853214
06-14 12:49:15.551+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:559,-13.790000,-22.469999,12.390000
06-14 12:49:15.551+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.551+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.561+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:564,0.382899,-0.001221,0.133253
06-14 12:49:15.561+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:565,6.831509,-7.161718,-1.686940
06-14 12:49:15.561+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.561+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.571+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:573,6.402644,-7.185252,-1.883797
06-14 12:49:15.571+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:574,-14.840000,-19.809999,14.280000
06-14 12:49:15.571+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.571+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.571+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:578,0.063066,0.357093,0.233273
06-14 12:49:15.571+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:579,6.486942,-6.817152,-1.619941
06-14 12:49:15.581+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.581+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.591+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:594,6.376285,-7.198474,-1.922328
06-14 12:49:15.591+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.591+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.601+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:594,-18.059999,-19.670000,19.040001
06-14 12:49:15.601+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:602,0.330759,-0.012359,0.060466
06-14 12:49:15.601+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.601+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.611+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:612,6.321891,-7.231026,-1.978976
06-14 12:49:15.611+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:603,6.733403,-7.197611,-1.823331
06-14 12:49:15.611+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.611+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.611+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:613,-13.790000,-21.629999,18.200001
06-14 12:49:15.621+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:621,-0.004198,-0.386774,-0.441781
06-14 12:49:15.621+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.621+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.631+0200 I/heartrate( 6719): es.ugr.frailty.heartrate - capturing data
06-14 12:49:15.631+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.631+0200 I/heartrate( 6719): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:49:15:638,102
06-14 12:49:15.641+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:623,6.372087,-7.585248,-2.364109
06-14 12:49:15.641+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:632,6.265790,-7.263813,-2.036492
06-14 12:49:15.641+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.641+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:639,-0.110124,0.011880,-0.399490
06-14 12:49:15.641+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:633,-9.940000,-25.410000,16.450001
06-14 12:49:15.651+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:650,6.211767,-7.219146,-2.378466
06-14 12:49:15.651+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.651+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.661+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.661+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:661,6.226622,-7.291775,-2.056596
06-14 12:49:15.661+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.661+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:15.661+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.671+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:15:673,140.000000
06-14 12:49:15.671+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:661,0.199618,0.051845,0.330409
06-14 12:49:15.671+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.681+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:667,6.465407,-7.211967,-1.706082
06-14 12:49:15.681+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.681+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:666,-11.200000,-21.700001,19.040001
06-14 12:49:15.681+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:673,6.197746,-7.297747,-2.121606
06-14 12:49:15.681+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.681+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.691+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:684,0.456532,0.113307,-0.673615
06-14 12:49:15.691+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.691+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:687,6.683154,-7.178468,-2.730211
06-14 12:49:15.691+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.691+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:695,6.156224,-7.324136,-2.151353
06-14 12:49:15.701+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:695,-14.350000,-19.320000,19.879999
06-14 12:49:15.701+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.701+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:698,-0.055370,0.126458,0.204955
06-14 12:49:15.701+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:702,6.142376,-7.171289,-1.916651
06-14 12:49:15.701+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.701+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.711+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.711+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:708,-12.810000,-21.559999,18.410000
06-14 12:49:15.711+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:713,6.113917,-7.349767,-2.184335
06-14 12:49:15.711+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:715,6.154340,-7.379465,-2.318645
06-14 12:49:15.711+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.711+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:712,-0.001884,-0.055329,-0.167293
06-14 12:49:15.721+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:722,-7.980000,-16.170000,16.799999
06-14 12:49:15.721+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.721+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.721+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.731+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:732,6.072565,-7.377174,-2.207179
06-14 12:49:15.731+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:733,-5.250000,-15.890000,17.710001
06-14 12:49:15.731+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.731+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:732,0.253384,-0.163696,-0.091240
06-14 12:49:15.731+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:740,6.367301,-7.513463,-2.275574
06-14 12:49:15.751+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.751+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.761+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.761+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.761+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:766,0.065025,0.038387,-0.657030
06-14 12:49:15.761+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:765,6.137590,-7.338787,-2.864209
06-14 12:49:15.761+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:761,6.029187,-7.400185,-2.248680
06-14 12:49:15.761+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:761,-3.220000,-10.220000,19.740000
06-14 12:49:15.761+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.761+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.771+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.771+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:774,5.986729,-7.420951,-2.293239
06-14 12:49:15.771+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.771+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:775,5.998806,-7.362715,-2.924029
06-14 12:49:15.781+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:780,-0.030381,0.037469,-0.675349
06-14 12:49:15.781+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:774,-4.200000,-10.430000,17.780001
06-14 12:49:15.781+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.791+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:793,5.943477,-7.433218,-2.364897
06-14 12:49:15.791+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.791+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.801+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.801+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.801+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:805,-0.236776,0.302303,-1.047142
06-14 12:49:15.801+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.811+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:813,5.898004,-7.442806,-2.447156
06-14 12:49:15.811+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:814,-0.215059,0.194929,-1.267407
06-14 12:49:15.811+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:806,-8.750000,-11.480000,19.110001
06-14 12:49:15.811+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:801,5.749953,-7.118648,-3.340380
06-14 12:49:15.811+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.811+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.821+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:825,5.728417,-7.238289,-3.632305
06-14 12:49:15.821+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.821+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.831+0200 I/heartrate( 6719): es.ugr.frailty.heartrate - capturing data
06-14 12:49:15.831+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:834,-0.131301,-0.393688,-0.129914
06-14 12:49:15.831+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.831+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:825,-8.470000,-14.980000,15.260000
06-14 12:49:15.831+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.841+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:834,5.844598,-7.473866,-2.480402
06-14 12:49:15.841+0200 I/heartrate( 6719): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:49:15:838,101
06-14 12:49:15.841+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:845,-7.980000,-20.719999,13.510000
06-14 12:49:15.841+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:841,5.766702,-7.836494,-2.577070
06-14 12:49:15.851+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.851+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.851+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:859,-0.132930,-0.269308,0.451289
06-14 12:49:15.851+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.851+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.861+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:864,5.711668,-7.743174,-2.029114
06-14 12:49:15.861+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:859,5.802586,-7.507114,-2.478634
06-14 12:49:15.861+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:865,-4.340000,-15.820000,12.600000
06-14 12:49:15.861+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:15.861+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.871+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.871+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.871+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:873,5.776054,-7.521333,-2.497426
06-14 12:49:15.871+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:876,0.289541,-0.066170,-0.175006
06-14 12:49:15.871+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:15:873,140.000000
06-14 12:49:15.881+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:878,6.092126,-7.573284,-2.653640
06-14 12:49:15.881+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.881+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:886,-4.550000,-9.660000,15.470000
06-14 12:49:15.881+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.881+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.891+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:892,0.182074,0.359615,-0.673064
06-14 12:49:15.891+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:892,5.756036,-7.519657,-2.548175
06-14 12:49:15.891+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.891+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.891+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:899,-7.980000,-10.430000,15.330000
06-14 12:49:15.891+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:900,5.958128,-7.161718,-3.170490
06-14 12:49:15.901+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.901+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.911+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:913,5.724700,-7.527576,-2.594954
06-14 12:49:15.911+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:913,-0.020441,0.113871,-0.658207
06-14 12:49:15.911+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.911+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.911+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:918,-7.280000,-9.240000,15.050000
06-14 12:49:15.911+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:919,5.735595,-7.405786,-3.206382
06-14 12:49:15.921+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.921+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.931+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:933,-0.142245,-0.136634,-0.774140
06-14 12:49:15.931+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:933,5.687510,-7.541174,-2.636912
06-14 12:49:15.931+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.931+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.931+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:939,-6.020000,-3.290000,15.820000
06-14 12:49:15.931+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:940,5.582455,-7.664211,-3.369094
06-14 12:49:15.951+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.951+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.961+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:962,5.661039,-7.551397,-2.664475
06-14 12:49:15.961+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.961+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:962,-0.066770,-0.020146,-0.325402
06-14 12:49:15.961+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.961+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.961+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.971+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:973,-0.226939,0.394464,-0.599335
06-14 12:49:15.971+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:969,5.620740,-7.561320,-2.962314
06-14 12:49:15.971+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.971+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:970,-7.980000,-4.130000,14.840000
06-14 12:49:15.971+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:973,5.635300,-7.556459,-2.704385
06-14 12:49:15.981+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.981+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:15:986,-6.720000,-0.840000,17.080000
06-14 12:49:15.981+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:15.981+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:15.991+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:15:987,5.434100,-7.156933,-3.263810
06-14 12:49:15.991+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:15:994,-0.189236,-0.696386,-0.262715
06-14 12:49:15.991+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:15.991+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:15.991+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:15:995,5.585555,-7.589086,-2.716199
06-14 12:49:16.001+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:2,-4.480000,-2.170000,17.639999
06-14 12:49:16.001+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.001+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.011+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:14,-0.187347,0.075623,-0.485398
06-14 12:49:16.021+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.031+0200 I/heartrate( 6719): es.ugr.frailty.heartrate - capturing data
06-14 12:49:16.031+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:33,-0.089367,-0.414482,-0.012779
06-14 12:49:16.031+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:13,-2.520000,-1.190000,17.010000
06-14 12:49:16.031+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.031+0200 I/heartrate( 6719): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:49:16:38,101
06-14 12:49:16.041+0200 W/LOCATION( 6722): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-14 12:49:16.041+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:45,1.540000,-2.450000,16.590000
06-14 12:49:16.041+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.051+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.051+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.061+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:4,5.446064,-8.252845,-2.967100
06-14 12:49:16.061+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.061+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:16.061+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:60,-0.194175,0.047379,0.175565
06-14 12:49:16.071+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.071+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:65,4.620000,-0.700000,18.200001
06-14 12:49:16.071+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:16:73,142.000000
06-14 12:49:16.071+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:68,5.398208,-7.513463,-3.201597
06-14 12:49:16.071+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.071+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:54,5.549788,-7.606259,-2.741360
06-14 12:49:16.081+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.081+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.091+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:83,5.460421,-8.020741,-2.754139
06-14 12:49:16.091+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.091+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:79,-0.209256,-0.150731,-0.212772
06-14 12:49:16.091+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:96,5.506241,-7.639805,-2.735885
06-14 12:49:16.091+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:99,5.312066,-7.592427,-2.560320
06-14 12:49:16.091+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.091+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.101+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:87,7.420000,0.490000,18.270000
06-14 12:49:16.101+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.111+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.111+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:116,5.466287,-7.673799,-2.720828
06-14 12:49:16.111+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:113,5.740000,1.680000,17.290001
06-14 12:49:16.111+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:106,-0.367664,-0.525222,-0.287457
06-14 12:49:16.121+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.121+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:104,5.257031,-7.824530,-2.933600
06-14 12:49:16.121+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.121+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.121+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.121+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:129,5.048856,-8.236095,-3.002992
06-14 12:49:16.121+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.131+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:135,5.364708,-7.530212,-3.842873
06-14 12:49:16.131+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:133,5.416520,-7.710874,-2.715535
06-14 12:49:16.141+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:126,0.007034,0.222789,-1.130554
06-14 12:49:16.141+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.141+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:130,1.610000,5.670000,15.890000
06-14 12:49:16.141+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.141+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.151+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.151+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:155,3.850000,3.080000,14.210000
06-14 12:49:16.151+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.151+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:158,5.357675,-7.753001,-2.712319
06-14 12:49:16.151+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.161+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:149,0.057674,-0.400835,0.357732
06-14 12:49:16.161+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.161+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:162,-0.770000,8.260000,15.960000
06-14 12:49:16.161+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:166,-0.491868,-0.335382,0.058511
06-14 12:49:16.161+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.161+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:156,5.391029,-8.157133,-2.392823
06-14 12:49:16.161+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.171+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:173,2.310000,8.680000,17.219999
06-14 12:49:16.171+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:175,4.814359,-8.121240,-2.660819
06-14 12:49:16.171+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.171+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:163,5.333354,-7.756298,-2.750555
06-14 12:49:16.171+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.171+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:180,4.912465,-8.085347,-3.247060
06-14 12:49:16.171+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.181+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:182,5.306227,-7.785858,-2.719330
06-14 12:49:16.181+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.181+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:185,-0.353615,-0.268305,-0.539176
06-14 12:49:16.181+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.181+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.191+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:194,0.020796,-0.208005,-0.392307
06-14 12:49:16.191+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:194,4.760000,6.440000,13.860000
06-14 12:49:16.191+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.191+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:200,5.242674,-8.051848,-3.108276
06-14 12:49:16.191+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:187,5.266079,-7.817042,-2.707885
06-14 12:49:16.191+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.201+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:205,5.221878,-7.843843,-2.715970
06-14 12:49:16.201+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.201+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.201+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.211+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:212,0.323748,-0.083765,-0.070822
06-14 12:49:16.211+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.211+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:217,5.517848,-7.946564,-2.785245
06-14 12:49:16.211+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:212,4.900000,9.170000,12.810000
06-14 12:49:16.221+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:211,5.194100,-7.862800,-2.714423
06-14 12:49:16.221+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.221+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.221+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.231+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.231+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:232,-0.056281,-0.364397,-0.227852
06-14 12:49:16.231+0200 I/heartrate( 6719): es.ugr.frailty.heartrate - capturing data
06-14 12:49:16.231+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:236,5.130211,-8.238488,-2.924029
06-14 12:49:16.231+0200 I/heartrate( 6719): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:49:16:238,101
06-14 12:49:16.231+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:232,2.380000,13.510000,13.720000
06-14 12:49:16.231+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:227,5.186492,-7.874091,-2.696177
06-14 12:49:16.241+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.241+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:246,5.165194,-7.892135,-2.684281
06-14 12:49:16.251+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.251+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.251+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.251+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:259,-0.300585,-0.042465,-0.139250
06-14 12:49:16.261+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.271+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:273,-0.204033,-0.249379,-0.005602
06-14 12:49:16.271+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:16.271+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:16:278,144.000000
06-14 12:49:16.281+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:259,-0.140000,12.460000,11.270000
06-14 12:49:16.281+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:269,4.864608,-7.934600,-2.823531
06-14 12:49:16.281+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.281+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.281+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.291+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:292,-0.054255,-0.175146,-0.539881
06-14 12:49:16.291+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.291+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:290,4.943572,-8.154739,-2.684747
06-14 12:49:16.291+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.291+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:297,5.147605,-7.905361,-2.679145
06-14 12:49:16.291+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.291+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:300,5.070391,-8.104490,-3.192025
06-14 12:49:16.291+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:301,5.124647,-7.929345,-2.652144
06-14 12:49:16.301+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:289,6.860000,15.260000,12.320000
06-14 12:49:16.301+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.301+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:307,7.280000,16.100000,10.360000
06-14 12:49:16.301+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.301+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.311+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:313,0.034124,-0.124195,0.030901
06-14 12:49:16.311+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:313,5.142176,-8.066205,-2.615355
06-14 12:49:16.311+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.311+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:319,8.610000,12.180000,8.610000
06-14 12:49:16.311+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.321+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:323,5.108051,-7.942010,-2.646256
06-14 12:49:16.321+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.321+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.321+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.331+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:332,-0.478868,-0.160398,-0.162464
06-14 12:49:16.331+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.341+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:332,4.618148,-8.118847,-2.780460
06-14 12:49:16.341+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:341,5.740000,17.010000,9.940000
06-14 12:49:16.341+0200 I/gravity ( 6745): es.ugr.frailty.gravity: SM-R760,14/06/2018,12:49:16:329,5.097016,-7.958449,-2.617996
06-14 12:49:16.341+0200 I/gravity ( 6745): es.ugr.frailty.gravity - capturing data
06-14 12:49:16.351+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.351+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:357,-0.187139,-0.124050,-0.446721
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-14 12:49:16.371+0200 W/libgps  ( 3118): [proxy__gps_stop][line = 1067]: called.
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHookStateGps              : EXIT
06-14 12:49:16.371+0200 W/libgps_d( 3118): GpsiHookStateIdle             : ENTRY
06-14 12:49:16.371+0200 W/gpsd    ( 3090): HandleIncomingMessage() dest id:0, msg id:2
06-14 12:49:16.371+0200 E/CAPI_LOCATION_MANAGER( 6804): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-14 12:49:16.381+0200 I/SECURE_STORAGE( 2511): ss_server_ipc.c: SsServerComm(251) > write succeed
06-14 12:49:16.391+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.391+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,12:49:16:400,-0.297470,-0.929046,0.633099
06-14 12:49:16.391+0200 I/linearacceleration( 6734): es.ugr.frailty.linearacceleration - capturing data
06-14 12:49:16.401+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.401+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:410,4.883751,-8.104490,-3.048456
06-14 12:49:16.401+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer - capturing data
06-14 12:49:16.421+0200 I/accelerometer( 6696): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,12:49:16:415,4.756931,-8.922836,-1.959722
06-14 12:49:16.431+0200 I/heartrate( 6719): es.ugr.frailty.heartrate - capturing data
06-14 12:49:16.431+0200 I/heartrate( 6719): es.ugr.frailty.heartrate: SM-R760,14/06/2018,12:49:16:441,100
06-14 12:49:16.441+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.441+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:446,7.630000,17.080000,8.680000
06-14 12:49:16.441+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.451+0200 I/CAPI_NETWORK_CONNECTION( 6804): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-14 12:49:16.451+0200 I/CAPI_NETWORK_CONNECTION( 6804): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-14 12:49:16.451+0200 I/CAPI_NETWORK_CONNECTION( 6804): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-14 12:49:16.451+0200 I/CAPI_NETWORK_CONNECTION( 6804): connection.c: connection_destroy(471) > Destroy handle: 0xf3f04700
06-14 12:49:16.461+0200 I/light   ( 6774): es.ugr.frailty.light - capturing data
06-14 12:49:16.471+0200 I/light   ( 6774): es.ugr.frailty.light: SM-R760,14/06/2018,12:49:16:474,140.000000
06-14 12:49:16.471+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,12:49:16:451,20.020000,16.590000,5.320000
06-14 12:49:16.471+0200 I/gyroscope( 6699): es.ugr.frailty.gyroscope - capturing data
06-14 12:49:16.471+0200 W/CRASH_MANAGER( 6834): worker.c: worker_job(1205) > 11067226c6f63152897335
