S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16021
Date: 2018-06-07 17:06:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75d052d, r5   = 0xf7e48f98
r6   = 0xffc64340, r7   = 0xffc641f0
r8   = 0xf7e45c18, r9   = 0x00000000
r10  = 0xffc642cc, fp   = 0xffc64340
ip   = 0x00000001, sp   = 0xffc641c8
lr   = 0xf75d0539, pc   = 0xf7639228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    154776 KB
Buffers:      7608 KB
Cached:      55008 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11656 KB
VmRSS:       11656 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16021 TID = 16021
16021 16025 

Maps Information
f449b000 f4c9a000 rw-p [stack:16025]
f4ca1000 f4ca3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cab000 f4caf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cb8000 f4cba000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cc2000 f4cc5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cd4000 f4cd9000 r-xp /usr/lib/libsystem.so.0.0.0
f4ce4000 f4ce7000 r-xp /lib/libattr.so.1.1.0
f4cef000 f4cff000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d07000 f4d10000 r-xp /usr/lib/libedbus.so.1.7.99
f4d18000 f4d19000 r-xp /usr/lib/libresponse.so.0.2.96
f4d22000 f4d27000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65c9000 f66cf000 r-xp /usr/lib/libicuuc.so.57.1
f66e5000 f686d000 r-xp /usr/lib/libicui18n.so.57.1
f687d000 f688a000 r-xp /usr/lib/libail.so.0.1.0
f6893000 f689a000 r-xp /usr/lib/libminizip.so.1.0.0
f68a3000 f6a4c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a6c000 f6ab3000 r-xp /usr/lib/libssl.so.1.0.0
f6abf000 f6ac1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ac9000 f6ad0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ad9000 f6ae0000 r-xp /lib/libcrypt-2.13.so
f6b11000 f6b14000 r-xp /lib/libcap.so.2.21
f6b1c000 f6b1e000 r-xp /usr/lib/libiri.so
f6b26000 f6b6f000 r-xp /usr/lib/libmdm.so.1.2.69
f6b77000 f6b7d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b85000 f6ba8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bb2000 f6bb4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bbc000 f6bd9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6be2000 f6be6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bef000 f6c08000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c11000 f6c19000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c21000 f6c27000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c30000 f6c32000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c3b000 f6c4b000 r-xp /lib/libresolv-2.13.so
f6c4f000 f6c67000 r-xp /usr/lib/liblzma.so.5.0.3
f6c70000 f6c72000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c7a000 f6c94000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c9c000 f6ccb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cd4000 f6ce3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ced000 f6cf7000 r-xp /usr/lib/libsensord-shared.so
f6d00000 f6dd3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dde000 f6df4000 r-xp /lib/libz.so.1.2.5
f6dfc000 f6e01000 r-xp /usr/lib/libffi.so.5.0.10
f6e09000 f6e0a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e12000 f6e22000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e2a000 f6e43000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e4b000 f6e4d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e55000 f6eca000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ed4000 f6eda000 r-xp /lib/librt-2.13.so
f6ee3000 f6f01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f0b000 f6f0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f14000 f6f37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3f000 f6f44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f4c000 f6f76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7f000 f6f96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9e000 f7007000 r-xp /lib/libm-2.13.so
f7010000 f70a4000 r-xp /usr/lib/libstdc++.so.6.0.16
f70b7000 f70bc000 r-xp /usr/lib/libctx-client.so.0.8.3
f70c4000 f70cb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70d3000 f70fd000 r-xp /usr/lib/libsensor.so.1.9.6
f7106000 f71d2000 r-xp /usr/lib/libxml2.so.2.7.8
f71df000 f71e1000 r-xp /usr/lib/libiniparser.so.0
f71ea000 f71f0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71f9000 f72c9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72ca000 f72fe000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7307000 f7343000 r-xp /usr/lib/libSLP-location.so.0.9.24
f734b000 f734e000 r-xp /usr/lib/libbundle.so.0.1.22
f7356000 f735c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7364000 f73a5000 r-xp /usr/lib/libeina.so.1.7.99
f73ae000 f73c5000 r-xp /usr/lib/libecore.so.1.7.99
f73dc000 f73e5000 r-xp /usr/lib/libvconf.so.0.2.45
f73ed000 f7401000 r-xp /lib/libpthread-2.13.so
f740c000 f7419000 r-xp /usr/lib/libaul.so.0.1.0
f7423000 f7425000 r-xp /lib/libdl-2.13.so
f742e000 f7439000 r-xp /lib/libunwind.so.8.0.1
f7466000 f746e000 r-xp /lib/libgcc_s-4.6.so.1
f746f000 f7593000 r-xp /lib/libc-2.13.so
f75a1000 f75a3000 r-xp /usr/lib/libdlog.so.0.0.0
f75ab000 f75b7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75c0000 f75c5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75cd000 f75dc000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75e4000 f75e8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75f1000 f75f4000 r-xp /usr/lib/libappcore-agent.so.1.1
f75fc000 f75fe000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7606000 f760a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7612000 f762f000 r-xp /lib/ld-2.13.so
f7638000 f763b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f763b000 f763f000 r-xp /usr/lib/libsys-assert.so
f7e15000 f7ea3000 rw-p [heap]
ffc45000 ffc66000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16021)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7639228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75d0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72d73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf731c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73171f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72d5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72e1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72e7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72e7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7319e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf731a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7321f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4cb91fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4cac171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d7f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf722cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf722e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73beca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73b9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73ba5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73ba879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75f2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75f27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76395c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf748685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7638f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 17:06:38.631+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:638,-0.020891,-0.027690,0.056177
06-07 17:06:38.631+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.631+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:633,1.320838,-1.098306,9.755538
06-07 17:06:38.641+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.641+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:622,1.337137,-1.038312,9.659418
06-07 17:06:38.641+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:642,0.022110,-0.017951,0.053483
06-07 17:06:38.651+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:653,1.540000,0.280000,0.140000
06-07 17:06:38.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.651+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:647,1.323231,-1.091127,9.745967
06-07 17:06:38.651+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:657,0.031605,0.010736,0.029562
06-07 17:06:38.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:661,0.016541,-0.050356,0.055842
06-07 17:06:38.651+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:661,1.375873,-1.107877,9.674182
06-07 17:06:38.661+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.661+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:652,1.336587,-1.042174,9.659079
06-07 17:06:38.661+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.661+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:38.661+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.661+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:671,1.336349,-1.043756,9.658940
06-07 17:06:38.671+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:38:675,500.000000
06-07 17:06:38.671+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:673,1.050000,0.140000,0.070000
06-07 17:06:38.671+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:667,1.301696,-1.024128,9.726824
06-07 17:06:38.681+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.681+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.681+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:686,1.335355,-1.043602,9.659095
06-07 17:06:38.681+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.681+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.681+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.681+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:692,1.335398,-1.043553,9.659094
06-07 17:06:38.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:693,0.910000,-0.070000,0.280000
06-07 17:06:38.691+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:686,1.342373,-1.124627,9.734003
06-07 17:06:38.691+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:691,0.016386,-0.015320,0.015353
06-07 17:06:38.691+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.691+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.701+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:701,1.337588,-1.083949,9.700503
06-07 17:06:38.701+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:699,-0.002218,-0.015817,0.110937
06-07 17:06:38.701+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.701+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:710,0.054798,-0.052940,0.041140
06-07 17:06:38.711+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.711+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:38.731+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:730,1.190000,0.210000,0.070000
06-07 17:06:38.741+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:38:725,79
06-07 17:06:38.741+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:731,1.325624,-1.071985,9.719646
06-07 17:06:38.741+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.751+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.751+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:744,1.334194,-1.041591,9.659472
06-07 17:06:38.761+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.771+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:759,0.980000,0.070000,-0.140000
06-07 17:06:38.771+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:760,1.323231,-1.055235,9.702895
06-07 17:06:38.771+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:776,1.333894,-1.042015,9.659468
06-07 17:06:38.771+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.771+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.781+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.781+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:786,1.334202,-1.040912,9.659544
06-07 17:06:38.781+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.801+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:773,0.002755,0.032573,0.039186
06-07 17:06:38.811+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:790,1.333030,-1.042662,9.659517
06-07 17:06:38.811+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:797,1.354338,-1.062413,9.738789
06-07 17:06:38.811+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.811+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.821+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:819,-0.018535,-0.040731,0.089235
06-07 17:06:38.821+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:795,0.490000,-0.280000,0.140000
06-07 17:06:38.821+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.821+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.831+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:819,1.332168,-1.043256,9.659572
06-07 17:06:38.831+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.831+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.831+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:835,0.490000,0.070000,0.280000
06-07 17:06:38.831+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:841,1.331131,-1.041471,9.659907
06-07 17:06:38.841+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:838,1.359123,-1.026521,9.750752
06-07 17:06:38.851+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.851+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:846,-0.026739,-0.017302,0.074897
06-07 17:06:38.851+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.861+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.861+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:38.871+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:867,1.331910,-1.040606,9.659893
06-07 17:06:38.871+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.871+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:38:872,501.000000
06-07 17:06:38.871+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:866,1.342373,-1.083949,9.678967
06-07 17:06:38.871+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.881+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:876,1.332559,-1.038224,9.660060
06-07 17:06:38.881+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:865,-0.280000,0.280000,0.420000
06-07 17:06:38.881+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.891+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.891+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.891+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:884,0.024013,0.010221,0.115636
06-07 17:06:38.891+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.901+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:894,1.331609,-1.038184,9.660195
06-07 17:06:38.901+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:899,-0.210000,0.280000,0.140000
06-07 17:06:38.911+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.911+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:38.911+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:38:920,79
06-07 17:06:38.911+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:916,1.330918,-1.037336,9.660381
06-07 17:06:38.921+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.921+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:904,1.359123,-1.076770,9.719646
06-07 17:06:38.921+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:907,-0.015555,-0.025769,0.077517
06-07 17:06:38.931+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.931+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:936,1.333531,-1.038363,9.659911
06-07 17:06:38.931+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.931+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.931+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.941+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:933,-0.210000,0.280000,0.140000
06-07 17:06:38.941+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:941,1.332651,-1.039225,9.659940
06-07 17:06:38.941+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.951+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.951+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:943,0.037192,-0.049767,0.017936
06-07 17:06:38.961+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:943,1.349552,-1.057628,9.738789
06-07 17:06:38.961+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.961+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.961+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:955,1.335216,-1.038775,9.659634
06-07 17:06:38.961+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.971+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:970,1.335416,-1.040789,9.659389
06-07 17:06:38.971+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.971+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:961,-0.210000,-0.140000,0.140000
06-07 17:06:38.971+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:969,0.036377,-0.083935,0.109756
06-07 17:06:38.971+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:38.981+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:38:975,1.330409,-1.055235,9.734003
06-07 17:06:38.981+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:38.991+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:980,1.332239,-1.042281,9.659667
06-07 17:06:38.991+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:38.991+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:38.991+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:38:995,-0.008338,-0.065624,0.084097
06-07 17:06:38.991+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:38:998,1.333724,-1.042313,9.659459
06-07 17:06:39.001+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:38:985,-0.350000,-0.210000,-0.210000
06-07 17:06:39.001+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.011+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:2,1.351945,-1.103091,9.710074
06-07 17:06:39.011+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:13,-0.280000,-0.210000,-0.210000
06-07 17:06:39.011+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.011+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.021+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.021+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:26,1.333947,-1.042893,9.659366
06-07 17:06:39.021+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.031+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.031+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:27,1.328017,-1.071985,9.724431
06-07 17:06:39.031+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:24,0.031812,-0.052203,0.038535
06-07 17:06:39.031+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.041+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:32,1.333668,-1.041732,9.659530
06-07 17:06:39.041+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.041+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:39,-0.140000,-0.210000,-0.070000
06-07 17:06:39.051+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:48,1.331361,-1.041897,9.659830
06-07 17:06:39.051+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:06:39.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:06:39.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:06:39.061+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.061+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:62,1.329304,-1.041571,9.660149
06-07 17:06:39.061+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:39.061+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.071+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:39:75,496.000000
06-07 17:06:39.071+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:74,1.329815,-1.041882,9.660045
06-07 17:06:39.081+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:82,1.375873,-1.079163,9.719646
06-07 17:06:39.081+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.081+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.091+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:95,0.490000,-0.210000,-0.070000
06-07 17:06:39.091+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:48,0.017335,-0.034707,0.067348
06-07 17:06:39.091+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.101+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:94,1.330564,-1.044645,9.659643
06-07 17:06:39.101+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.101+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.111+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:102,0.003615,-0.027368,0.072063
06-07 17:06:39.121+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:39.121+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:107,1.328909,-1.047006,9.659616
06-07 17:06:39.121+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.121+0200 W/LOCATION(16021): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:06:39.121+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:131,1.327263,-1.047479,9.659790
06-07 17:06:39.131+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:39:129,79
06-07 17:06:39.141+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.141+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:146,1.324949,-1.044985,9.660378
06-07 17:06:39.141+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.151+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.161+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.161+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:153,0.560000,-0.070000,0.070000
06-07 17:06:39.161+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:117,1.356731,-1.088734,9.736395
06-07 17:06:39.161+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:166,1.323812,-1.041484,9.660912
06-07 17:06:39.161+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.161+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.161+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:163,0.019624,0.017562,0.038278
06-07 17:06:39.171+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.171+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:170,1.321831,-1.039737,9.661371
06-07 17:06:39.171+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.171+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:176,1.313660,-1.079163,9.657433
06-07 17:06:39.181+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.181+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:178,0.560000,-0.140000,0.210000
06-07 17:06:39.181+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.191+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.191+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:186,-0.008393,-0.035403,0.097704
06-07 17:06:39.191+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.201+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:181,1.323757,-1.038434,9.661248
06-07 17:06:39.201+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.201+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:198,1.351945,-1.048056,9.726824
06-07 17:06:39.201+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:199,0.140000,-0.140000,0.210000
06-07 17:06:39.201+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.211+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.211+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:205,-0.004100,-0.028657,0.087824
06-07 17:06:39.211+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:218,1.349552,-1.024128,9.722038
06-07 17:06:39.211+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:208,1.322182,-1.040202,9.661273
06-07 17:06:39.211+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.211+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.221+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:228,0.050649,-0.046480,0.015631
06-07 17:06:39.221+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:217,-0.350000,-0.070000,0.210000
06-07 17:06:39.221+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.231+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.231+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.241+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:237,-0.350000,-0.070000,0.070000
06-07 17:06:39.241+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:223,1.323440,-1.042366,9.660868
06-07 17:06:39.241+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:241,1.325624,-1.093520,9.702895
06-07 17:06:39.241+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.251+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:245,-0.024038,0.036825,0.068295
06-07 17:06:39.251+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.251+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.251+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.251+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:259,0.420000,-0.140000,0.070000
06-07 17:06:39.261+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:253,1.324299,-1.041974,9.660792
06-07 17:06:39.261+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.261+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:39.271+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:39:272,493.000000
06-07 17:06:39.271+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.271+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:265,0.020783,-0.069205,0.074300
06-07 17:06:39.271+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:265,1.356731,-1.162912,9.760324
06-07 17:06:39.271+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.281+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.281+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:268,1.324938,-1.040320,9.660883
06-07 17:06:39.281+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.291+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:290,1.294517,-1.091127,9.736395
06-07 17:06:39.291+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:282,0.630000,-0.350000,-0.210000
06-07 17:06:39.291+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:288,0.017192,-0.028024,0.040691
06-07 17:06:39.291+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.291+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.301+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.301+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:287,1.325764,-1.039981,9.660806
06-07 17:06:39.301+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.311+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:308,0.005807,-0.016769,0.059677
06-07 17:06:39.311+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:39.311+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:39:320,79
06-07 17:06:39.321+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:303,0.560000,-0.210000,-0.280000
06-07 17:06:39.321+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:314,1.329606,-1.045666,9.659664
06-07 17:06:39.321+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.321+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.321+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:330,0.420000,-0.280000,-0.280000
06-07 17:06:39.321+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.321+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:311,1.337588,-1.060020,9.707682
06-07 17:06:39.331+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.331+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:329,1.333495,-1.051121,9.658536
06-07 17:06:39.331+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:335,0.005534,-0.002223,0.042397
06-07 17:06:39.341+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:340,1.328017,-1.064806,9.719646
06-07 17:06:39.341+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.341+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:39.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391199351,000000, pattern:[H:mm][0;m
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:06:39.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:06:39.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:06:39.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:06][0;m
06-07 17:06:39.361+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.361+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.361+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:350,0.630000,-0.490000,-0.070000
06-07 17:06:39.361+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:366,1.335518,-1.052668,9.658088
06-07 17:06:39.361+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.361+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:361,0.038027,-0.011689,0.077852
06-07 17:06:39.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.371+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:379,0.630000,-0.490000,-0.280000
06-07 17:06:39.371+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.381+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:368,1.311267,-1.052842,9.714860
06-07 17:06:39.381+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.381+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:373,1.334251,-1.051879,9.658349
06-07 17:06:39.381+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.391+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.391+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:384,0.041633,0.023563,0.089908
06-07 17:06:39.391+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:398,0.350000,-0.420000,-0.280000
06-07 17:06:39.391+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.391+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:391,1.320838,-1.079163,9.734003
06-07 17:06:39.401+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:405,0.024385,-0.036481,0.017906
06-07 17:06:39.401+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.401+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.401+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:395,1.332158,-1.051473,9.658683
06-07 17:06:39.411+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:416,0.420000,-0.280000,-0.140000
06-07 17:06:39.411+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.421+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:412,1.378266,-1.100698,9.719646
06-07 17:06:39.421+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.421+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.421+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.421+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:425,0.040485,-0.027232,0.058898
06-07 17:06:39.431+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.431+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:432,1.385444,-1.038485,9.712467
06-07 17:06:39.441+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:432,0.070000,-0.280000,-0.140000
06-07 17:06:39.441+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.441+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.441+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:442,0.029793,-0.006887,0.078324
06-07 17:06:39.451+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:434,1.329835,-1.051641,9.658984
06-07 17:06:39.451+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:455,1.363909,-1.031307,9.714860
06-07 17:06:39.451+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.461+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:464,0.010137,-0.004337,0.073627
06-07 17:06:39.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:452,-0.350000,-0.280000,-0.140000
06-07 17:06:39.461+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.461+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.461+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:39.471+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:39:473,494.000000
06-07 17:06:39.471+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.471+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:480,-0.840000,-0.210000,-0.140000
06-07 17:06:39.481+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.481+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:487,0.031139,-0.051770,0.049817
06-07 17:06:39.481+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:484,1.356731,-1.043271,9.712467
06-07 17:06:39.491+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.491+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.491+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:471,1.329911,-1.051614,9.658977
06-07 17:06:39.491+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.501+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.501+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:498,-0.140000,0.070000,0.140000
06-07 17:06:39.501+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.511+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:503,1.361516,-1.067199,9.729217
06-07 17:06:39.511+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:39.511+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:39:520,79
06-07 17:06:39.521+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:504,0.005133,-0.017648,0.064786
06-07 17:06:39.521+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.521+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.521+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:506,1.330618,-1.050343,9.659018
06-07 17:06:39.531+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:516,0.350000,0.210000,-0.070000
06-07 17:06:39.531+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.531+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.531+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:529,1.390230,-1.119841,9.741181
06-07 17:06:39.531+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:541,0.490000,0.070000,-0.070000
06-07 17:06:39.541+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:532,0.052297,-0.023611,0.060228
06-07 17:06:39.541+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.541+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.551+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:549,0.030484,-0.031954,0.077478
06-07 17:06:39.551+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:539,1.330773,-1.051879,9.658829
06-07 17:06:39.551+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.551+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:552,1.402194,-1.081556,9.695717
06-07 17:06:39.551+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.551+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:558,1.330234,-1.051382,9.658957
06-07 17:06:39.551+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.561+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.561+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.561+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:561,0.630000,-0.070000,0.350000
06-07 17:06:39.571+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:572,1.325624,-1.091127,9.702895
06-07 17:06:39.571+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.571+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:568,-0.013325,-0.022183,-0.001361
06-07 17:06:39.581+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.581+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:586,0.026183,0.008873,0.067857
06-07 17:06:39.581+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.581+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:581,0.490000,-0.140000,0.210000
06-07 17:06:39.581+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:562,1.328254,-1.050152,9.659364
06-07 17:06:39.591+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.591+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.591+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:591,1.354338,-1.045663,9.710074
06-07 17:06:39.591+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:596,1.330047,-1.051916,9.658925
06-07 17:06:39.591+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.591+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:601,1.329802,-1.050396,9.659124
06-07 17:06:39.591+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.601+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:605,0.023493,0.031003,0.062916
06-07 17:06:39.601+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:600,0.910000,0.140000,0.350000
06-07 17:06:39.601+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.611+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.621+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:611,1.363909,-1.060020,9.714860
06-07 17:06:39.621+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.621+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:623,-0.001202,-0.040314,0.043668
06-07 17:06:39.621+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:616,1.540000,0.140000,0.210000
06-07 17:06:39.631+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.631+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.631+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.631+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:639,1.328435,-1.052290,9.659106
06-07 17:06:39.631+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.631+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:632,1.387837,-1.055235,9.726824
06-07 17:06:39.641+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:643,0.029711,-0.107183,0.101398
06-07 17:06:39.641+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.641+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:638,1.470000,0.350000,0.140000
06-07 17:06:39.651+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.651+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:644,1.327932,-1.053492,9.659044
06-07 17:06:39.651+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.661+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:653,1.395016,-1.060020,9.777073
06-07 17:06:39.661+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.661+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:659,1.330000,0.350000,0.210000
06-07 17:06:39.661+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:06:39.671+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.671+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:06:39:673,495.000000
06-07 17:06:39.671+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.671+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:676,1.329215,-1.053394,9.658878
06-07 17:06:39.671+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.671+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:664,-0.033817,-0.030155,0.078225
06-07 17:06:39.681+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.681+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:680,1.368695,-1.050449,9.702895
06-07 17:06:39.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:684,1.120000,0.350000,0.140000
06-07 17:06:39.691+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.691+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.691+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:699,1.356731,-1.060020,9.757930
06-07 17:06:39.691+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:689,0.011607,0.001246,0.049220
06-07 17:06:39.701+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.701+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:681,1.329110,-1.055717,9.658639
06-07 17:06:39.701+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.711+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:704,1.050000,0.210000,0.210000
06-07 17:06:39.711+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:707,0.001815,-0.004953,0.061059
06-07 17:06:39.711+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:711,1.332318,-1.059834,9.657746
06-07 17:06:39.711+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.711+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:06:39.721+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:06:39:721,79
06-07 17:06:39.721+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.721+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:729,0.840000,-0.280000,-0.070000
06-07 17:06:39.721+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.731+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:719,1.351945,-1.043271,9.729217
06-07 17:06:39.731+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.731+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.731+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:735,-0.014436,0.005852,0.056078
06-07 17:06:39.741+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:06:39:750,0.420000,-0.560000,-0.140000
06-07 17:06:39.751+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration - capturing data
06-07 17:06:39.761+0200 I/gravity (15960): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:06:39:719,1.333962,-1.063788,9.657084
06-07 17:06:39.761+0200 I/linearacceleration(15989): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:06:39:760,-0.003980,-0.021743,0.074961
06-07 17:06:39.771+0200 I/gravity (15960): es.ugr.frailty.gravity - capturing data
06-07 17:06:39.771+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:06:39:746,1.332802,-1.036092,9.717253
06-07 17:06:39.771+0200 I/accelerometer(15913): es.ugr.frailty.accelerometer - capturing data
06-07 17:06:39.781+0200 I/gyroscope(15981): es.ugr.frailty.gyroscope - capturing data
06-07 17:06:39.781+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11160216c6f63152838399
