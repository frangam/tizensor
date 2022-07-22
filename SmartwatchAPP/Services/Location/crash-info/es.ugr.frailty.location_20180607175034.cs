S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24897
Date: 2018-06-07 17:50:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71a652d, r5   = 0xf73d8f98
r6   = 0xffb634a0, r7   = 0xffb63350
r8   = 0xf73d5c18, r9   = 0x00000000
r10  = 0xffb6342c, fp   = 0xffb634a0
ip   = 0x00000001, sp   = 0xffb63328
lr   = 0xf71a6539, pc   = 0xf720f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    216784 KB
Buffers:     15052 KB
Cached:     114848 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11752 KB
VmRSS:       11752 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24897 TID = 24897
24897 24969 

Maps Information
f4071000 f4870000 rw-p [stack:24969]
f4877000 f4879000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4881000 f4885000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f488e000 f4890000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4898000 f489b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48aa000 f48af000 r-xp /usr/lib/libsystem.so.0.0.0
f48ba000 f48bd000 r-xp /lib/libattr.so.1.1.0
f48c5000 f48d5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f48dd000 f48e6000 r-xp /usr/lib/libedbus.so.1.7.99
f48ee000 f48ef000 r-xp /usr/lib/libresponse.so.0.2.96
f48f8000 f48fd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f619f000 f62a5000 r-xp /usr/lib/libicuuc.so.57.1
f62bb000 f6443000 r-xp /usr/lib/libicui18n.so.57.1
f6453000 f6460000 r-xp /usr/lib/libail.so.0.1.0
f6469000 f6470000 r-xp /usr/lib/libminizip.so.1.0.0
f6479000 f6622000 r-xp /usr/lib/libcrypto.so.1.0.0
f6642000 f6689000 r-xp /usr/lib/libssl.so.1.0.0
f6695000 f6697000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f669f000 f66a6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66af000 f66b6000 r-xp /lib/libcrypt-2.13.so
f66e7000 f66ea000 r-xp /lib/libcap.so.2.21
f66f2000 f66f4000 r-xp /usr/lib/libiri.so
f66fc000 f6745000 r-xp /usr/lib/libmdm.so.1.2.69
f674d000 f6753000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f675b000 f677e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6788000 f678a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6792000 f67af000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67b8000 f67bc000 r-xp /usr/lib/libsmack.so.1.0.0
f67c5000 f67de000 r-xp /usr/lib/libnetwork.so.0.0.0
f67e7000 f67ef000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67f7000 f67fd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6806000 f6808000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6811000 f6821000 r-xp /lib/libresolv-2.13.so
f6825000 f683d000 r-xp /usr/lib/liblzma.so.5.0.3
f6846000 f6848000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6850000 f686a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6872000 f68a1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68aa000 f68b9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68c3000 f68cd000 r-xp /usr/lib/libsensord-shared.so
f68d6000 f69a9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69b4000 f69ca000 r-xp /lib/libz.so.1.2.5
f69d2000 f69d7000 r-xp /usr/lib/libffi.so.5.0.10
f69df000 f69e0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69e8000 f69f8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a00000 f6a19000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a21000 f6a23000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a2b000 f6aa0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6aaa000 f6ab0000 r-xp /lib/librt-2.13.so
f6ab9000 f6ad7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ae1000 f6ae2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aea000 f6b0d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b15000 f6b1a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b22000 f6b4c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b55000 f6b6c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b74000 f6bdd000 r-xp /lib/libm-2.13.so
f6be6000 f6c7a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c8d000 f6c92000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c9a000 f6ca1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ca9000 f6cd3000 r-xp /usr/lib/libsensor.so.1.9.6
f6cdc000 f6da8000 r-xp /usr/lib/libxml2.so.2.7.8
f6db5000 f6db7000 r-xp /usr/lib/libiniparser.so.0
f6dc0000 f6dc6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dcf000 f6e9f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ea0000 f6ed4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6edd000 f6f19000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f21000 f6f24000 r-xp /usr/lib/libbundle.so.0.1.22
f6f2c000 f6f32000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f3a000 f6f7b000 r-xp /usr/lib/libeina.so.1.7.99
f6f84000 f6f9b000 r-xp /usr/lib/libecore.so.1.7.99
f6fb2000 f6fbb000 r-xp /usr/lib/libvconf.so.0.2.45
f6fc3000 f6fd7000 r-xp /lib/libpthread-2.13.so
f6fe2000 f6fef000 r-xp /usr/lib/libaul.so.0.1.0
f6ff9000 f6ffb000 r-xp /lib/libdl-2.13.so
f7004000 f700f000 r-xp /lib/libunwind.so.8.0.1
f703c000 f7044000 r-xp /lib/libgcc_s-4.6.so.1
f7045000 f7169000 r-xp /lib/libc-2.13.so
f7177000 f7179000 r-xp /usr/lib/libdlog.so.0.0.0
f7181000 f718d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7196000 f719b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71a3000 f71b2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f71ba000 f71be000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f71c7000 f71ca000 r-xp /usr/lib/libappcore-agent.so.1.1
f71d2000 f71d4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f71dc000 f71e0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71e8000 f7205000 r-xp /lib/ld-2.13.so
f720e000 f7211000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7211000 f7215000 r-xp /usr/lib/libsys-assert.so
f73a5000 f7416000 rw-p [heap]
ffb44000 ffb65000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24897)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf720f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71a6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ead3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6eabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6eb7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ebdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ebddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ef275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6eed1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6eabc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6eb7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ebdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ebddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6eefe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ef0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ef7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf488f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4882171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6955663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e02fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e047a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f94ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f8fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f905a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f90879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf71c8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71c87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf720f5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf705c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf720ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
SM-R760,07/06/2018,17:50:33:917,0.356531,-0.074178,9.961320
06-07 17:50:33.911+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:33.921+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:33:917,0.046098,0.009632,0.159943
06-07 17:50:33.921+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:33:923,0.312396,-0.082123,9.801329
06-07 17:50:33.921+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:33.921+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:33.931+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:33.931+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:33:933,0.301496,-0.045464,9.851252
06-07 17:50:33.931+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:33:925,0.070000,0.070000,0.070000
06-07 17:50:33.931+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:33:933,-0.010900,0.036659,0.049923
06-07 17:50:33.931+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:33.941+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:33:936,0.313629,-0.081547,9.801294
06-07 17:50:33.941+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:33:944,0.070000,0.070000,0.140000
06-07 17:50:33.941+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:33.941+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:33.941+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:33.951+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:33.951+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:33:953,0.306281,-0.107677,9.937392
06-07 17:50:33.951+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:33:954,-0.007348,-0.026130,0.136098
06-07 17:50:33.961+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:33:960,0.070000,0.070000,0.140000
06-07 17:50:33.961+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:33:956,0.312603,-0.079608,9.801343
06-07 17:50:33.961+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:33.961+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:33.961+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:33.971+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:33.971+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:33.971+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:33:973,0.323031,-0.124427,9.868000
06-07 17:50:33.971+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:33.981+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:33:973,0.010428,-0.044819,0.066657
06-07 17:50:33.981+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:33:982,0.070000,0.070000,0.140000
06-07 17:50:33.981+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:33:973,0.311663,-0.080715,9.801364
06-07 17:50:33.981+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:33.981+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:33.981+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:33.991+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:33:993,0.303888,-0.143569,9.865608
06-07 17:50:33.991+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.001+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:1,0.070000,-0.070000,0.140000
06-07 17:50:34.001+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:33:994,-0.007774,-0.062855,0.064244
06-07 17:50:34.001+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:33:995,0.312134,-0.082599,9.801333
06-07 17:50:34.001+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.001+0200 I/light   (24935): es.ugr.frailty.light - capturing data
06-07 17:50:34.011+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.011+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.011+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:16,0.311067,-0.093320,9.903893
06-07 17:50:34.011+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:13,-0.001067,-0.010721,0.102560
06-07 17:50:34.011+0200 I/light   (24935): es.ugr.frailty.light: SM-R760,07/06/2018,17:50:34:14,1887.000000
06-07 17:50:34.011+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:16,0.311695,-0.085310,9.801324
06-07 17:50:34.021+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.021+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.021+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.031+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.031+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:32,0.308674,-0.117248,9.927821
06-07 17:50:34.031+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:26,0.070000,-0.070000,0.070000
06-07 17:50:34.031+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.031+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:36,0.311387,-0.085520,9.801332
06-07 17:50:34.031+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:32,-0.003021,-0.031938,0.126497
06-07 17:50:34.031+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:39,0.070000,-0.070000,0.070000
06-07 17:50:34.041+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.041+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.041+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.051+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.051+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:54,0.296710,-0.047856,9.894321
06-07 17:50:34.051+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:54,-0.014677,0.037663,0.092990
06-07 17:50:34.051+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:56,0.310692,-0.086791,9.801343
06-07 17:50:34.051+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:59,0.070000,0.070000,0.070000
06-07 17:50:34.061+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.061+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.061+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.071+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.071+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:73,0.351745,-0.050249,9.851252
06-07 17:50:34.071+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:73,0.041053,0.036541,0.049909
06-07 17:50:34.081+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:76,0.309574,-0.084692,9.801396
06-07 17:50:34.081+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:79,0.070000,0.070000,0.070000
06-07 17:50:34.081+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.081+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.091+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:92,0.318245,-0.076570,9.918249
06-07 17:50:34.091+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:93,0.008671,0.008121,0.116853
06-07 17:50:34.091+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.091+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.101+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:105,0.311219,-0.082987,9.801359
06-07 17:50:34.101+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.101+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.101+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:100,0.070000,-0.140000,0.070000
06-07 17:50:34.111+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.111+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.111+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:113,0.325424,-0.098106,9.856036
06-07 17:50:34.121+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:114,0.014205,-0.015119,0.054677
06-07 17:50:34.121+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:124,0.070000,-0.140000,0.070000
06-07 17:50:34.121+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:119,0.311371,-0.082528,9.801358
06-07 17:50:34.121+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.121+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.131+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:132,0.320638,-0.057428,9.853643
06-07 17:50:34.131+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.131+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:134,0.070000,-0.140000,0.140000
06-07 17:50:34.131+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.141+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:138,0.009267,0.025100,0.052285
06-07 17:50:34.141+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:143,0.312002,-0.083133,9.801333
06-07 17:50:34.141+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.141+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.151+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.151+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.151+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:154,0.001458,0.013741,0.035560
06-07 17:50:34.151+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:154,0.313460,-0.069392,9.836893
06-07 17:50:34.161+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:156,0.070000,0.070000,0.070000
06-07 17:50:34.171+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:34.171+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:34.171+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.181+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:161,0.311832,-0.081715,9.801351
06-07 17:50:34.191+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.191+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.201+0200 I/light   (24935): es.ugr.frailty.light - capturing data
06-07 17:50:34.221+0200 I/light   (24935): es.ugr.frailty.light: SM-R760,07/06/2018,17:50:34:215,1889.000000
06-07 17:50:34.221+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:183,0.306281,-0.057428,9.865608
06-07 17:50:34.231+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.241+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:50:34.241+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:50:34.241+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:50:34.241+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:207,-0.005551,0.024287,0.064258
06-07 17:50:34.241+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:210,0.311104,-0.080792,9.801381
06-07 17:50:34.251+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.251+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.261+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.261+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:249,0.320638,-0.083749,9.884750
06-07 17:50:34.271+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.271+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:263,0.009535,-0.002957,0.083369
06-07 17:50:34.271+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:280,0.313460,-0.095713,9.899107
06-07 17:50:34.281+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:272,0.140000,0.070000,0.070000
06-07 17:50:34.281+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:270,0.310909,-0.079779,9.801395
06-07 17:50:34.281+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.281+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.291+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.291+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.301+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:291,0.002551,-0.015934,0.097712
06-07 17:50:34.301+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.301+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:296,0.310347,-0.079593,9.801414
06-07 17:50:34.301+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.311+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:295,-0.070000,0.070000,0.140000
06-07 17:50:34.311+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.311+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:302,0.332602,-0.083749,9.856036
06-07 17:50:34.311+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.321+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:313,0.022256,-0.004155,0.054622
06-07 17:50:34.321+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.321+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:315,0.309777,-0.080128,9.801429
06-07 17:50:34.321+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:318,0.140000,0.140000,0.070000
06-07 17:50:34.321+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.321+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.331+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:323,0.313460,-0.095713,9.870394
06-07 17:50:34.331+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.341+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:331,0.003683,-0.015585,0.068965
06-07 17:50:34.341+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:334,0.310153,-0.080091,9.801417
06-07 17:50:34.341+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:335,0.070000,0.140000,0.070000
06-07 17:50:34.341+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.341+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:341,0.327817,-0.050249,9.882358
06-07 17:50:34.341+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.341+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.351+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.351+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:354,0.309637,-0.080614,9.801429
06-07 17:50:34.351+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:352,0.070000,0.140000,0.070000
06-07 17:50:34.361+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:352,0.017664,0.029842,0.080940
06-07 17:50:34.361+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.361+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.361+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:363,0.363709,-0.078963,9.887143
06-07 17:50:34.371+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:34.371+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:34.371+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.371+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.381+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:370,0.054072,0.001651,0.085714
06-07 17:50:34.381+0200 W/LOCATION(24897): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:50:34.381+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:375,0.309655,-0.078966,9.801442
06-07 17:50:34.381+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.381+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.391+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:381,0.320638,-0.076570,9.923036
06-07 17:50:34.391+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.391+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:396,0.010983,0.002396,0.121593
06-07 17:50:34.401+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.401+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:404,0.339781,-0.043071,9.858429
06-07 17:50:34.401+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.401+0200 I/light   (24935): es.ugr.frailty.light - capturing data
06-07 17:50:34.411+0200 I/light   (24935): es.ugr.frailty.light: SM-R760,07/06/2018,17:50:34:414,1890.000000
06-07 17:50:34.411+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:397,0.311299,-0.078779,9.801392
06-07 17:50:34.411+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.411+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:411,0.296710,-0.066999,9.918249
06-07 17:50:34.411+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:401,0.070000,0.140000,0.070000
06-07 17:50:34.411+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.421+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.421+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:422,0.306281,-0.117248,9.932607
06-07 17:50:34.421+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:411,0.028481,0.035709,0.057037
06-07 17:50:34.421+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.421+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:428,0.289532,-0.081356,9.860823
06-07 17:50:34.421+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.431+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.431+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:435,0.320638,-0.095713,9.949356
06-07 17:50:34.431+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.431+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:440,0.320638,-0.088534,9.889536
06-07 17:50:34.431+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:422,0.311084,-0.078460,9.801400
06-07 17:50:34.441+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:426,0.070000,0.140000,0.070000
06-07 17:50:34.441+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.441+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:436,-0.014374,0.011461,0.116849
06-07 17:50:34.441+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.441+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.441+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:449,-0.005387,-0.040626,0.131210
06-07 17:50:34.441+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.451+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:455,0.315853,-0.086142,9.877571
06-07 17:50:34.451+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.451+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:454,0.070000,0.140000,0.280000
06-07 17:50:34.451+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:448,0.311668,-0.076622,9.801396
06-07 17:50:34.451+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.461+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:461,-0.020653,-0.005426,0.059374
06-07 17:50:34.461+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.461+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:467,0.011343,-0.018075,0.147892
06-07 17:50:34.461+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.461+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.471+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:473,0.358923,-0.055035,9.879964
06-07 17:50:34.471+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.471+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:465,0.310185,-0.075930,9.801449
06-07 17:50:34.471+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.481+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:480,0.012842,-0.010902,0.088025
06-07 17:50:34.481+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:473,0.070000,0.070000,0.070000
06-07 17:50:34.481+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.481+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.481+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.491+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:493,0.349352,-0.050249,9.868000
06-07 17:50:34.491+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:485,0.309295,-0.077638,9.801464
06-07 17:50:34.491+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:487,0.008078,-0.007889,0.076064
06-07 17:50:34.491+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.491+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:489,0.070000,0.070000,0.070000
06-07 17:50:34.501+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.501+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:501,0.051400,0.023347,0.078450
06-07 17:50:34.501+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.501+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.501+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.511+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:513,0.339781,-0.062213,9.901501
06-07 17:50:34.511+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:510,0.070000,0.140000,0.070000
06-07 17:50:34.511+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:509,0.042281,0.028149,0.066472
06-07 17:50:34.511+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:506,0.307796,-0.077633,9.801511
06-07 17:50:34.511+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.521+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:522,0.031469,0.014790,0.100001
06-07 17:50:34.521+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.521+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.521+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.521+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.531+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:526,0.307775,-0.078253,9.801507
06-07 17:50:34.531+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.531+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:529,0.070000,0.140000,0.070000
06-07 17:50:34.531+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:532,0.351745,-0.055035,9.884750
06-07 17:50:34.531+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.531+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:535,0.042657,0.020400,0.083262
06-07 17:50:34.541+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:542,0.070000,0.070000,0.070000
06-07 17:50:34.541+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:540,0.307523,-0.078382,9.801514
06-07 17:50:34.541+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.541+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.541+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.551+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.551+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:554,0.070000,0.070000,0.070000
06-07 17:50:34.551+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:552,0.307071,-0.078398,9.801528
06-07 17:50:34.551+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:554,0.299103,-0.062213,9.906286
06-07 17:50:34.551+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.551+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:556,-0.010667,0.012410,0.104814
06-07 17:50:34.551+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.561+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.561+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:565,0.308311,-0.077003,9.801499
06-07 17:50:34.561+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.561+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:568,0.140000,0.070000,0.070000
06-07 17:50:34.571+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.571+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.571+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:573,0.048030,-0.055679,0.066555
06-07 17:50:34.571+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:34.571+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:34.571+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:572,0.358923,-0.129212,9.868000
06-07 17:50:34.571+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:580,0.140000,0.070000,0.070000
06-07 17:50:34.581+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:577,0.309088,-0.075435,9.801488
06-07 17:50:34.581+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.581+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.581+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.581+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.581+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:587,0.309770,-0.074623,9.801473
06-07 17:50:34.591+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:590,0.140000,0.070000,0.070000
06-07 17:50:34.591+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.591+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:593,0.334995,-0.102891,9.872787
06-07 17:50:34.591+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.591+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:595,0.025597,-0.030258,0.071287
06-07 17:50:34.601+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:600,0.310893,-0.073534,9.801445
06-07 17:50:34.601+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.601+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:602,0.140000,0.070000,0.070000
06-07 17:50:34.601+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.601+0200 I/light   (24935): es.ugr.frailty.light - capturing data
06-07 17:50:34.601+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.601+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.611+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:612,0.309398,-0.072633,9.801499
06-07 17:50:34.611+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:613,0.070000,0.070000,0.070000
06-07 17:50:34.611+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.611+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.621+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:618,0.291924,-0.114855,9.865608
06-07 17:50:34.621+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:615,-0.019763,-0.039829,0.064199
06-07 17:50:34.621+0200 I/light   (24935): es.ugr.frailty.light: SM-R760,07/06/2018,17:50:34:620,1886.000000
06-07 17:50:34.621+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.621+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.621+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:624,0.311687,-0.075027,9.801409
06-07 17:50:34.621+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:625,0.070000,0.070000,0.070000
06-07 17:50:34.631+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.631+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.631+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:633,0.346959,-0.002393,9.925428
06-07 17:50:34.631+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:632,0.034604,0.073739,0.124050
06-07 17:50:34.641+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:638,0.140000,0.070000,0.070000
06-07 17:50:34.641+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:640,0.312355,-0.076132,9.801378
06-07 17:50:34.641+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.641+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.641+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:649,0.070000,0.070000,0.070000
06-07 17:50:34.641+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.641+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.651+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:653,0.311445,-0.078110,9.801392
06-07 17:50:34.651+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.651+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.651+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:658,0.028336,-0.024781,0.092930
06-07 17:50:34.651+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:655,0.339781,-0.102891,9.894321
06-07 17:50:34.661+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:660,0.070000,0.070000,0.070000
06-07 17:50:34.661+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:661,0.312584,-0.074696,9.801382
06-07 17:50:34.661+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.661+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.661+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.661+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.671+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:671,-0.070000,0.070000,0.070000
06-07 17:50:34.671+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:672,0.008055,-0.018624,0.083368
06-07 17:50:34.671+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:672,0.320638,-0.093320,9.884750
06-07 17:50:34.671+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.671+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:672,0.314006,-0.076110,9.801326
06-07 17:50:34.681+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:684,-0.070000,0.070000,0.070000
06-07 17:50:34.681+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.681+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.681+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.681+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.691+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:692,0.314381,-0.077026,9.801307
06-07 17:50:34.691+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:689,-0.070000,0.070000,0.140000
06-07 17:50:34.691+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.691+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:693,0.289532,-0.021535,9.894321
06-07 17:50:34.691+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:692,-0.024474,0.054575,0.092996
06-07 17:50:34.701+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:701,-0.070000,0.070000,0.070000
06-07 17:50:34.701+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.701+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.701+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.711+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.711+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:713,0.312900,-0.074100,9.801376
06-07 17:50:34.711+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:713,0.315853,-0.050249,9.824929
06-07 17:50:34.711+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:715,0.001471,0.026777,0.023623
06-07 17:50:34.721+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:720,0.070000,0.070000,0.070000
06-07 17:50:34.721+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.721+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.721+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.731+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:732,0.312496,-0.072783,9.801399
06-07 17:50:34.731+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:734,0.358923,-0.081356,9.927821
06-07 17:50:34.731+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.731+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:732,0.046023,-0.007256,0.126445
06-07 17:50:34.731+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:739,0.070000,0.070000,0.070000
06-07 17:50:34.741+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.741+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.741+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.751+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:752,0.349352,-0.124427,9.865608
06-07 17:50:34.751+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:753,0.036856,-0.051644,0.064209
06-07 17:50:34.751+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:753,0.313651,-0.072827,9.801362
06-07 17:50:34.751+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.761+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:765,0.140000,0.070000,0.070000
06-07 17:50:34.761+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.761+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.761+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.771+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:772,0.314839,-0.074854,9.801309
06-07 17:50:34.771+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:772,0.303888,-0.100499,9.889536
06-07 17:50:34.771+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:34.771+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:34.771+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:775,-0.009763,-0.027671,0.088174
06-07 17:50:34.771+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.781+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:783,0.140000,0.070000,0.070000
06-07 17:50:34.781+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.781+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.791+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.791+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:792,0.325424,-0.088534,9.856036
06-07 17:50:34.791+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.791+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:796,0.010585,-0.013680,0.054728
06-07 17:50:34.791+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:797,0.140000,0.070000,0.070000
06-07 17:50:34.791+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:793,0.313415,-0.075727,9.801348
06-07 17:50:34.801+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.801+0200 I/light   (24935): es.ugr.frailty.light - capturing data
06-07 17:50:34.811+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.811+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.811+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:817,0.318245,-0.078963,9.896714
06-07 17:50:34.811+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.811+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:814,0.313465,-0.076143,9.801343
06-07 17:50:34.811+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:50:34:817,0.070000,0.070000,0.070000
06-07 17:50:34.821+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:821,0.004830,-0.003236,0.095366
06-07 17:50:34.821+0200 I/light   (24935): es.ugr.frailty.light: SM-R760,07/06/2018,17:50:34:814,1881.000000
06-07 17:50:34.821+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.821+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.821+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.831+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:833,0.313077,-0.076073,9.801356
06-07 17:50:34.831+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:835,-0.000005,0.011536,0.078621
06-07 17:50:34.831+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:832,0.313460,-0.064606,9.879964
06-07 17:50:34.841+0200 I/gyroscope(24865): es.ugr.frailty.gyroscope - capturing data
06-07 17:50:34.851+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.861+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:863,0.346959,-0.066999,9.870394
06-07 17:50:34.861+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.871+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:868,0.033883,0.009074,0.069037
06-07 17:50:34.871+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.871+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.881+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.881+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:883,0.311067,-0.083749,9.887143
06-07 17:50:34.881+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:880,-0.001426,-0.008421,0.085763
06-07 17:50:34.881+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.891+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 17:50:34.911+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 17:50:34.911+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 17:50:34.911+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:50:34.911+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 17:50:34.911+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:896,0.313460,-0.066999,9.889536
06-07 17:50:34.921+0200 W/AUL     (24976): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 17:50:34.921+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:50:34:894,0.000040,0.007760,0.088181
06-07 17:50:34.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:50:34.921+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:50:34.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24429
06-07 17:50:34.921+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:50:34.921+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer - capturing data
06-07 17:50:34.921+0200 I/linearacceleration(24904): es.ugr.frailty.linearacceleration - capturing data
06-07 17:50:34.931+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24429
06-07 17:50:34.931+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24429)
06-07 17:50:34.931+0200 I/accelerometer(24862): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:50:34:935,0.344566,-0.093320,9.891929
06-07 17:50:34.941+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:944,0.312493,-0.075328,9.801380
06-07 17:50:34.941+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.951+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:954,0.313420,-0.074759,9.801355
06-07 17:50:34.951+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.961+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:962,0.312715,-0.074988,9.801376
06-07 17:50:34.961+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.961+0200 I/gravity (24911): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:50:34:968,0.312132,-0.074407,9.801399
06-07 17:50:34.961+0200 I/gravity (24911): es.ugr.frailty.gravity - capturing data
06-07 17:50:34.971+0200 I/heartrate(24887): es.ugr.frailty.heartrate - capturing data
06-07 17:50:34.971+0200 I/heartrate(24887): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:50:34.981+0200 W/CRASH_MANAGER(24975): worker.c: worker_job(1205) > 11248976c6f63152838663
