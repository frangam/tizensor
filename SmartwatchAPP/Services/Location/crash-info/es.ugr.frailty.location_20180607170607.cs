S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15851
Date: 2018-06-07 17:06:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76fe52d, r5   = 0xf7a03f98
r6   = 0xffd86390, r7   = 0xffd86240
r8   = 0xf7a00c18, r9   = 0x00000000
r10  = 0xffd8631c, fp   = 0xffd86390
ip   = 0x00000001, sp   = 0xffd86218
lr   = 0xf76fe539, pc   = 0xf7767228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     12504 KB
Buffers:     11484 KB
Cached:      59948 KB
VmPeak:      53520 KB
VmSize:      53456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11852 KB
VmRSS:       11852 KB
VmData:      11184 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15851 TID = 15851
15851 15857 

Maps Information
f45c9000 f4dc8000 rw-p [stack:15857]
f4dcf000 f4dd1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4dd9000 f4ddd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4de6000 f4de8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4df0000 f4df3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e02000 f4e07000 r-xp /usr/lib/libsystem.so.0.0.0
f4e12000 f4e15000 r-xp /lib/libattr.so.1.1.0
f4e1d000 f4e2d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e35000 f4e3e000 r-xp /usr/lib/libedbus.so.1.7.99
f4e46000 f4e47000 r-xp /usr/lib/libresponse.so.0.2.96
f4e50000 f4e55000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66f7000 f67fd000 r-xp /usr/lib/libicuuc.so.57.1
f6813000 f699b000 r-xp /usr/lib/libicui18n.so.57.1
f69ab000 f69b8000 r-xp /usr/lib/libail.so.0.1.0
f69c1000 f69c8000 r-xp /usr/lib/libminizip.so.1.0.0
f69d1000 f6b7a000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b9a000 f6be1000 r-xp /usr/lib/libssl.so.1.0.0
f6bed000 f6bef000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6bf7000 f6bfe000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c07000 f6c0e000 r-xp /lib/libcrypt-2.13.so
f6c3f000 f6c42000 r-xp /lib/libcap.so.2.21
f6c4a000 f6c4c000 r-xp /usr/lib/libiri.so
f6c54000 f6c9d000 r-xp /usr/lib/libmdm.so.1.2.69
f6ca5000 f6cab000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cb3000 f6cd6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ce0000 f6ce2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cea000 f6d07000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d10000 f6d14000 r-xp /usr/lib/libsmack.so.1.0.0
f6d1d000 f6d36000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d3f000 f6d47000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d4f000 f6d55000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d5e000 f6d60000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d69000 f6d79000 r-xp /lib/libresolv-2.13.so
f6d7d000 f6d95000 r-xp /usr/lib/liblzma.so.5.0.3
f6d9e000 f6da0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6da8000 f6dc2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dca000 f6df9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e02000 f6e11000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e1b000 f6e25000 r-xp /usr/lib/libsensord-shared.so
f6e2e000 f6f01000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f0c000 f6f22000 r-xp /lib/libz.so.1.2.5
f6f2a000 f6f2f000 r-xp /usr/lib/libffi.so.5.0.10
f6f37000 f6f38000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f40000 f6f50000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f58000 f6f71000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f79000 f6f7b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f83000 f6ff8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7002000 f7008000 r-xp /lib/librt-2.13.so
f7011000 f702f000 r-xp /usr/lib/libsystemd.so.0.4.0
f7039000 f703a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7042000 f7065000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f706d000 f7072000 r-xp /usr/lib/libxdgmime.so.1.1.0
f707a000 f70a4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70ad000 f70c4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70cc000 f7135000 r-xp /lib/libm-2.13.so
f713e000 f71d2000 r-xp /usr/lib/libstdc++.so.6.0.16
f71e5000 f71ea000 r-xp /usr/lib/libctx-client.so.0.8.3
f71f2000 f71f9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7201000 f722b000 r-xp /usr/lib/libsensor.so.1.9.6
f7234000 f7300000 r-xp /usr/lib/libxml2.so.2.7.8
f730d000 f730f000 r-xp /usr/lib/libiniparser.so.0
f7318000 f731e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7327000 f73f7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73f8000 f742c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7435000 f7471000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7479000 f747c000 r-xp /usr/lib/libbundle.so.0.1.22
f7484000 f748a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7492000 f74d3000 r-xp /usr/lib/libeina.so.1.7.99
f74dc000 f74f3000 r-xp /usr/lib/libecore.so.1.7.99
f750a000 f7513000 r-xp /usr/lib/libvconf.so.0.2.45
f751b000 f752f000 r-xp /lib/libpthread-2.13.so
f753a000 f7547000 r-xp /usr/lib/libaul.so.0.1.0
f7551000 f7553000 r-xp /lib/libdl-2.13.so
f755c000 f7567000 r-xp /lib/libunwind.so.8.0.1
f7594000 f759c000 r-xp /lib/libgcc_s-4.6.so.1
f759d000 f76c1000 r-xp /lib/libc-2.13.so
f76cf000 f76d1000 r-xp /usr/lib/libdlog.so.0.0.0
f76d9000 f76e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76ee000 f76f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76fb000 f770a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7712000 f7716000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f771f000 f7722000 r-xp /usr/lib/libappcore-agent.so.1.1
f772a000 f772c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7734000 f7738000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7740000 f775d000 r-xp /lib/ld-2.13.so
f7766000 f7769000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7769000 f776d000 r-xp /usr/lib/libsys-assert.so
f79d0000 f7a41000 rw-p [heap]
ffd67000 ffd88000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15851)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7767228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76fe539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74053f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7403c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf740fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7415be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7415dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf744a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74451f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7403c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf740fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7415be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7415dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7447e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7448017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf744ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4de71fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4dda171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ead663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf735afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf735c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74ecca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf74e7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74e85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74e8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7720183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf77207fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77675c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf75b485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7766f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
6.401+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.401+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:401,2.800000,1.260000,2.940000
06-07 17:06:06.401+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.401+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:409,0.770000,1.470000,0.840000
06-07 17:06:06.411+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:402,-0.119922,0.272024,0.226523
06-07 17:06:06.411+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.411+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:407,9.597611,2.060220,1.820938
06-07 17:06:06.411+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:418,-0.770000,1.330000,-1.400000
06-07 17:06:06.411+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.411+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.421+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:406,9.439070,1.263900,2.340280
06-07 17:06:06.421+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.421+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:425,-0.770000,2.100000,-2.730000
06-07 17:06:06.421+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.421+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.431+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:434,-3.080000,4.830000,-3.710000
06-07 17:06:06.431+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.441+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:441,-6.860000,6.090000,-3.430000
06-07 17:06:06.441+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.441+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:426,-0.012302,0.166301,0.428639
06-07 17:06:06.441+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:06.441+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:448,-10.220000,7.210000,-3.010000
06-07 17:06:06.441+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.451+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:06:450,338.000000
06-07 17:06:06.451+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:437,9.427651,1.279804,2.377365
06-07 17:06:06.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:455,-10.360000,8.750000,-3.080000
06-07 17:06:06.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:461,-9.100000,10.010000,-3.500000
06-07 17:06:06.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.461+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.461+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.461+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:443,9.415757,1.596013,2.065006
06-07 17:06:06.461+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:467,-6.860000,10.010000,-3.990000
06-07 17:06:06.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:465,-0.052027,0.183757,0.433001
06-07 17:06:06.471+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.471+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:475,-3.360000,9.660000,-4.760000
06-07 17:06:06.471+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.471+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.471+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:471,9.416050,1.297180,2.413650
06-07 17:06:06.471+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.481+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:481,-5.250000,8.470000,-4.410000
06-07 17:06:06.481+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.481+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.481+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:489,-8.330000,6.580000,-4.760000
06-07 17:06:06.481+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:479,9.454042,1.294517,2.167897
06-07 17:06:06.491+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:06.491+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.491+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:486,-0.062143,0.203746,0.381559
06-07 17:06:06.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:06:498,79
06-07 17:06:06.491+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:496,9.405737,1.313493,2.444836
06-07 17:06:06.501+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:496,-6.510000,4.970000,-4.270000
06-07 17:06:06.501+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.501+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.501+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:500,9.473185,1.263410,2.143969
06-07 17:06:06.501+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:508,-3.010000,5.530000,-3.780000
06-07 17:06:06.501+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.511+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:514,-1.820000,5.250000,-3.780000
06-07 17:06:06.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.511+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:512,-0.084042,0.219870,0.496023
06-07 17:06:06.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:521,-2.100000,4.200000,-3.150000
06-07 17:06:06.521+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.521+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.521+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.521+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:527,-2.100000,2.660000,-2.730000
06-07 17:06:06.521+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.521+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:523,9.395030,1.328981,2.477419
06-07 17:06:06.531+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:534,0.770000,0.980000,-3.010000
06-07 17:06:06.531+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.531+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:526,9.509077,1.375873,2.134398
06-07 17:06:06.531+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:539,4.620000,1.050000,-3.430000
06-07 17:06:06.531+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.541+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.541+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.541+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:544,5.390000,1.820000,-3.920000
06-07 17:06:06.541+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:535,-0.054586,0.162879,0.421765
06-07 17:06:06.541+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.541+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.541+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:547,9.386703,1.342502,2.501574
06-07 17:06:06.551+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:551,3.290000,-0.770000,-3.640000
06-07 17:06:06.551+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.551+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:550,9.473185,1.383051,2.270789
06-07 17:06:06.551+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:557,4.130000,-2.940000,-3.500000
06-07 17:06:06.551+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.551+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:563,5.180000,-3.290000,-2.870000
06-07 17:06:06.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.561+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:561,-0.036700,-0.008143,0.300648
06-07 17:06:06.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:568,3.150000,-3.570000,-2.100000
06-07 17:06:06.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.571+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:575,-0.490000,-4.200000,-1.400000
06-07 17:06:06.571+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.571+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.571+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:570,9.380846,1.350587,2.519131
06-07 17:06:06.571+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.571+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:581,-2.800000,-4.200000,-1.050000
06-07 17:06:06.581+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.581+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.581+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:586,-2.170000,-4.060000,-1.680000
06-07 17:06:06.581+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.581+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:579,9.420543,1.165305,2.263610
06-07 17:06:06.591+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.591+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:593,0.560000,-4.410000,-2.170000
06-07 17:06:06.591+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:583,0.019483,0.153012,0.443991
06-07 17:06:06.591+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:594,9.371616,1.367470,2.544253
06-07 17:06:06.601+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.601+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:608,-0.091908,0.331567,0.282864
06-07 17:06:06.611+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.611+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:605,9.425328,1.320838,2.340181
06-07 17:06:06.621+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.621+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.631+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:620,9.364158,1.390157,2.559375
06-07 17:06:06.641+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:633,9.367901,1.596013,2.270789
06-07 17:06:06.641+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.641+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:635,-0.092250,0.374505,0.255350
06-07 17:06:06.641+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:06.661+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:06:651,334.000000
06-07 17:06:06.671+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.671+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.671+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.691+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:06.691+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:06:698,78
06-07 17:06:06.691+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:650,9.358182,1.413435,2.568464
06-07 17:06:06.691+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.691+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:684,3.850000,-4.970000,-2.240000
06-07 17:06:06.701+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:689,-0.010613,0.308747,0.127765
06-07 17:06:06.701+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.711+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:710,0.026468,0.297433,0.018177
06-07 17:06:06.711+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.711+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:718,-0.001774,0.268994,-0.060769
06-07 17:06:06.711+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.731+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.741+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:691,9.394222,1.916651,2.282753
06-07 17:06:06.741+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:744,5.320000,-4.620000,-1.890000
06-07 17:06:06.741+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.741+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:724,0.020686,0.147698,-0.071902
06-07 17:06:06.751+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.751+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:757,4.620000,-5.040000,-1.260000
06-07 17:06:06.761+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.761+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.761+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:748,9.355318,1.432303,2.568447
06-07 17:06:06.761+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.771+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:757,9.384650,1.947758,2.299503
06-07 17:06:06.771+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:770,2.380000,-6.370000,-0.700000
06-07 17:06:06.771+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.781+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.781+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:782,2.030000,-5.740000,-0.630000
06-07 17:06:06.791+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:774,9.354393,1.448315,2.562830
06-07 17:06:06.791+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.791+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.791+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:798,4.060000,-4.410000,-1.470000
06-07 17:06:06.801+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:769,0.101518,-0.029492,-0.048759
06-07 17:06:06.801+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.801+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.811+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:789,9.229117,1.950150,2.299503
06-07 17:06:06.811+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:808,6.440000,-3.990000,-2.100000
06-07 17:06:06.811+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.811+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.821+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:799,9.354918,1.460400,2.554044
06-07 17:06:06.821+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:807,0.030605,-0.127824,-0.028341
06-07 17:06:06.821+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.821+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.831+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:824,5.390000,-3.780000,-2.520000
06-07 17:06:06.831+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.831+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:832,0.083439,-0.214533,0.024178
06-07 17:06:06.841+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.841+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:06.851+0200 W/LOCATION(15851): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:06:06.851+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:825,9.329616,1.840081,2.467000
06-07 17:06:06.851+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.851+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:861,9.360723,2.098505,2.337788
06-07 17:06:06.851+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:06:851,312.000000
06-07 17:06:06.861+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:849,0.073841,-0.134148,-0.014553
06-07 17:06:06.861+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:844,2.590000,-4.340000,-2.660000
06-07 17:06:06.871+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:827,9.356438,1.465412,2.545590
06-07 17:06:06.871+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.871+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.871+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:879,2.800000,-3.430000,-2.870000
06-07 17:06:06.881+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.881+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.881+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:879,9.358640,1.463587,2.538535
06-07 17:06:06.881+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.891+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.891+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:889,0.046695,0.004534,-0.001925
06-07 17:06:06.891+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:06.901+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:06:902,78
06-07 17:06:06.901+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.901+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:903,1.750000,-1.120000,-2.800000
06-07 17:06:06.911+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:890,9.324830,2.404787,2.529213
06-07 17:06:06.911+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.911+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:907,-0.004453,0.005142,-0.046453
06-07 17:06:06.911+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:894,9.361059,1.459771,2.531802
06-07 17:06:06.911+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.921+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.921+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.921+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:919,-2.730000,0.560000,-2.380000
06-07 17:06:06.921+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:926,9.162118,2.309074,2.639283
06-07 17:06:06.931+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:927,0.057353,-0.065874,-0.212120
06-07 17:06:06.931+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.931+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:922,9.364277,1.452695,2.523960
06-07 17:06:06.941+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.941+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.951+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:942,-7.490000,0.840000,-1.470000
06-07 17:06:06.951+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.951+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.951+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:947,0.086724,-0.088953,-0.268887
06-07 17:06:06.961+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:952,9.092726,2.124826,2.727818
06-07 17:06:06.961+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.961+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.961+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:959,-10.220000,1.400000,-0.840000
06-07 17:06:06.971+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.971+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:968,0.109118,-0.065778,-0.187490
06-07 17:06:06.971+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:956,9.367568,1.449695,2.513453
06-07 17:06:06.971+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:06.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:06:06.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(15740), cmd(0)
06-07 17:06:06.971+0200 W/CAPI_APPFW_APP_CONTROL(15740): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:06:06.971+0200 I/utils   (15740): specific action
06-07 17:06:06.971+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:06.981+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:967,9.272188,1.935793,2.696711
06-07 17:06:06.981+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.981+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:06:980,-9.800000,2.310000,-1.120000
06-07 17:06:06.991+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:06.991+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:06:985,0.100860,0.108371,-0.211632
06-07 17:06:06.991+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:06:994,9.315259,1.933401,2.730211
06-07 17:06:06.991+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:06.991+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.001+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:06:984,9.370368,1.451318,2.502051
06-07 17:06:07.001+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.011+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:0,9.310472,1.907080,2.754139
06-07 17:06:07.011+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:3,-7.910000,3.430000,-0.840000
06-07 17:06:07.011+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.011+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.021+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:14,0.060621,0.162292,-0.263607
06-07 17:06:07.021+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:19,9.374496,1.450469,2.487033
06-07 17:06:07.021+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:24,9.265009,1.799403,2.778067
06-07 17:06:07.031+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:30,-9.100000,4.200000,-0.140000
06-07 17:06:07.031+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.031+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.041+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.041+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:40,0.083926,0.111940,-0.370515
06-07 17:06:07.041+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:07.051+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:07:51,299.000000
06-07 17:06:07.051+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:49,9.380817,1.446437,2.465457
06-07 17:06:07.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:06:07.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:06:07.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:06:07.061+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:41,9.327222,1.744368,2.715853
06-07 17:06:07.061+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.061+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.071+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.071+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:77,9.332008,1.593620,2.605784
06-07 17:06:07.081+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.091+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:73,-12.880000,3.570000,0.770000
06-07 17:06:07.091+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:85,0.114299,0.041057,-0.461608
06-07 17:06:07.091+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:07.091+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.091+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.091+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:07:98,78
06-07 17:06:07.101+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:93,9.386683,1.444571,2.444135
06-07 17:06:07.101+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.111+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:115,0.146103,0.126860,-0.480006
06-07 17:06:07.111+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.111+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:121,9.391028,1.445685,2.426718
06-07 17:06:07.121+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:102,-14.000000,2.590000,1.400000
06-07 17:06:07.121+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.121+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:112,9.425328,1.641476,2.514857
06-07 17:06:07.121+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.131+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.141+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:146,9.336794,1.823331,2.445465
06-07 17:06:07.151+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:135,-9.240000,2.800000,1.400000
06-07 17:06:07.151+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.151+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:158,9.394044,1.455359,2.409200
06-07 17:06:07.151+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.151+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:140,0.070127,0.265154,-0.439327
06-07 17:06:07.151+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.161+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:165,-4.620000,4.060000,0.980000
06-07 17:06:07.161+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.171+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.181+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.181+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:172,0.038601,0.252663,-0.404825
06-07 17:06:07.181+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:181,9.238688,1.904687,2.239682
06-07 17:06:07.191+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:185,9.397171,1.466422,2.390223
06-07 17:06:07.191+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.201+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.201+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.211+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:198,-4.480000,4.480000,0.350000
06-07 17:06:07.211+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:213,9.322437,1.966900,2.215754
06-07 17:06:07.221+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.221+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:207,0.020609,0.203655,-0.331499
06-07 17:06:07.221+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.231+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.231+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:216,9.401259,1.476331,2.367943
06-07 17:06:07.241+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:232,-4.620000,3.010000,-0.280000
06-07 17:06:07.241+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:07.251+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:07:251,302.000000
06-07 17:06:07.251+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.251+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:261,9.405451,1.483999,2.346407
06-07 17:06:07.261+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:243,0.048586,0.114122,-0.225868
06-07 17:06:07.261+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.261+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:250,9.446864,2.100898,2.045863
06-07 17:06:07.271+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:275,-2.870000,1.890000,-1.260000
06-07 17:06:07.271+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.271+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.281+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.291+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:07.291+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.291+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:284,-0.017871,0.212191,-0.188229
06-07 17:06:07.301+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.301+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:07:298,78
06-07 17:06:07.301+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:292,9.401401,2.258825,1.715654
06-07 17:06:07.311+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:295,9.408263,1.494098,2.328655
06-07 17:06:07.311+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:305,-2.310000,3.010000,-1.610000
06-07 17:06:07.311+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.321+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.321+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:316,0.040874,0.349898,-0.105960
06-07 17:06:07.331+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.341+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:330,9.409505,1.507214,2.315149
06-07 17:06:07.341+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:326,9.559326,2.210968,2.254039
06-07 17:06:07.341+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:07.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391167353,000000, pattern:[H:mm][0;m
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:07.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:06:07.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:06][0;m
06-07 17:06:07.351+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.351+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.361+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:343,-1.610000,3.080000,-1.890000
06-07 17:06:07.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.371+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:351,-0.006660,0.022211,0.016078
06-07 17:06:07.371+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.371+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:380,3.150000,0.980000,-2.590000
06-07 17:06:07.381+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:372,9.358330,1.627119,2.414358
06-07 17:06:07.381+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:368,9.410241,1.517783,2.305231
06-07 17:06:07.391+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.391+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.401+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:390,0.085501,-0.278316,0.097220
06-07 17:06:07.401+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.411+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:404,9.409699,1.527391,2.301091
06-07 17:06:07.421+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:415,8.750000,-1.680000,-3.290000
06-07 17:06:07.421+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:405,9.425328,1.380659,2.411965
06-07 17:06:07.421+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.441+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.441+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:07.451+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:07:452,311.000000
06-07 17:06:07.451+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.451+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:423,0.077829,-0.382469,0.123852
06-07 17:06:07.461+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.471+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:436,9.408383,1.533254,2.302571
06-07 17:06:07.471+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:447,9.533006,1.325624,2.132005
06-07 17:06:07.471+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:464,9.520000,-2.660000,-2.660000
06-07 17:06:07.471+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.471+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.491+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.491+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:478,0.078093,-0.218597,0.192334
06-07 17:06:07.491+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:07.501+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:487,9.405668,1.542695,2.307352
06-07 17:06:07.501+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:493,9.578469,1.306481,1.981257
06-07 17:06:07.501+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.511+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:505,-0.009750,-0.185304,0.277793
06-07 17:06:07.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:498,3.010000,-1.540000,-2.450000
06-07 17:06:07.511+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.511+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.521+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:07:504,78
06-07 17:06:07.531+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:517,9.402041,1.553691,2.314745
06-07 17:06:07.531+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.541+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.541+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:543,-0.068767,-0.197172,0.227813
06-07 17:06:07.541+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:529,9.573684,1.100698,2.048256
06-07 17:06:07.541+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:531,4.830000,-1.260000,-4.340000
06-07 17:06:07.541+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.551+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:555,9.400141,1.547774,2.326399
06-07 17:06:07.561+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.561+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:565,9.571291,1.019342,2.151148
06-07 17:06:07.561+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.571+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:570,16.240000,-1.680000,-4.200000
06-07 17:06:07.581+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.581+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.581+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.581+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:575,-0.014356,-0.038732,0.151552
06-07 17:06:07.601+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.601+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:607,-0.013121,0.070167,0.045117
06-07 17:06:07.601+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:587,9.399878,1.529864,2.339272
06-07 17:06:07.601+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:594,9.602397,0.861416,2.163112
06-07 17:06:07.611+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.611+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:599,23.030001,-1.750000,-2.940000
06-07 17:06:07.611+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.641+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.641+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.641+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:07.651+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:656,9.647861,0.710668,2.227718
06-07 17:06:07.641+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:618,9.399186,1.510928,2.354312
06-07 17:06:07.651+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:07:660,319.000000
06-07 17:06:07.641+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:646,19.389999,-3.710000,-1.190000
06-07 17:06:07.661+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.671+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.671+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:665,0.017282,0.033311,0.294867
06-07 17:06:07.671+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.671+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.691+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:684,16.730000,-3.920000,0.700000
06-07 17:06:07.691+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:673,9.395988,1.501261,2.373185
06-07 17:06:07.691+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:07.691+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.691+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:686,9.664611,0.464208,2.036292
06-07 17:06:07.701+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:07.701+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:07:693,-0.111929,-0.091116,0.381009
06-07 17:06:07.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:07:702,78
06-07 17:06:07.711+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.711+0200 I/linearacceleration(15780): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:07.711+0200 I/accelerometer(15721): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:07:720,9.640682,0.397209,2.088934
06-07 17:06:07.721+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:07:718,11.060000,-2.450000,2.940000
06-07 17:06:07.721+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:706,9.391828,1.493568,2.394411
06-07 17:06:07.731+0200 I/gravity (15740): es.ugr.frailty.gravity - capturing data
06-07 17:06:07.731+0200 I/gyroscope(15776): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:07.731+0200 I/gravity (15740): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:07:740,9.388200,1.487560,2.412312
06-07 17:06:07.741+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11158516c6f63152838396
