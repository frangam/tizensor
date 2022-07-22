S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 16389
Date: 2018-06-07 17:07:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70fc52d, r5   = 0xf7385f98
r6   = 0xffe70960, r7   = 0xffe70810
r8   = 0xf7382c18, r9   = 0x00000000
r10  = 0xffe708ec, fp   = 0xffe70960
ip   = 0x00000001, sp   = 0xffe707e8
lr   = 0xf70fc539, pc   = 0xf7165228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    171292 KB
Buffers:      8212 KB
Cached:      51264 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11612 KB
VmRSS:       11612 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 16389 TID = 16389
16389 16393 

Maps Information
f3fc7000 f47c6000 rw-p [stack:16393]
f47cd000 f47cf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47d7000 f47db000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47e4000 f47e6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47ee000 f47f1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4800000 f4805000 r-xp /usr/lib/libsystem.so.0.0.0
f4810000 f4813000 r-xp /lib/libattr.so.1.1.0
f481b000 f482b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4833000 f483c000 r-xp /usr/lib/libedbus.so.1.7.99
f4844000 f4845000 r-xp /usr/lib/libresponse.so.0.2.96
f484e000 f4853000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60f5000 f61fb000 r-xp /usr/lib/libicuuc.so.57.1
f6211000 f6399000 r-xp /usr/lib/libicui18n.so.57.1
f63a9000 f63b6000 r-xp /usr/lib/libail.so.0.1.0
f63bf000 f63c6000 r-xp /usr/lib/libminizip.so.1.0.0
f63cf000 f6578000 r-xp /usr/lib/libcrypto.so.1.0.0
f6598000 f65df000 r-xp /usr/lib/libssl.so.1.0.0
f65eb000 f65ed000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65f5000 f65fc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6605000 f660c000 r-xp /lib/libcrypt-2.13.so
f663d000 f6640000 r-xp /lib/libcap.so.2.21
f6648000 f664a000 r-xp /usr/lib/libiri.so
f6652000 f669b000 r-xp /usr/lib/libmdm.so.1.2.69
f66a3000 f66a9000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66b1000 f66d4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66de000 f66e0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66e8000 f6705000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f670e000 f6712000 r-xp /usr/lib/libsmack.so.1.0.0
f671b000 f6734000 r-xp /usr/lib/libnetwork.so.0.0.0
f673d000 f6745000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f674d000 f6753000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f675c000 f675e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6767000 f6777000 r-xp /lib/libresolv-2.13.so
f677b000 f6793000 r-xp /usr/lib/liblzma.so.5.0.3
f679c000 f679e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67a6000 f67c0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67c8000 f67f7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6800000 f680f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6819000 f6823000 r-xp /usr/lib/libsensord-shared.so
f682c000 f68ff000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f690a000 f6920000 r-xp /lib/libz.so.1.2.5
f6928000 f692d000 r-xp /usr/lib/libffi.so.5.0.10
f6935000 f6936000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f693e000 f694e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6956000 f696f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6977000 f6979000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6981000 f69f6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a00000 f6a06000 r-xp /lib/librt-2.13.so
f6a0f000 f6a2d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a37000 f6a38000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a40000 f6a63000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a6b000 f6a70000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a78000 f6aa2000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aab000 f6ac2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6aca000 f6b33000 r-xp /lib/libm-2.13.so
f6b3c000 f6bd0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6be3000 f6be8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bf0000 f6bf7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bff000 f6c29000 r-xp /usr/lib/libsensor.so.1.9.6
f6c32000 f6cfe000 r-xp /usr/lib/libxml2.so.2.7.8
f6d0b000 f6d0d000 r-xp /usr/lib/libiniparser.so.0
f6d16000 f6d1c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d25000 f6df5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6df6000 f6e2a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e33000 f6e6f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e77000 f6e7a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e82000 f6e88000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e90000 f6ed1000 r-xp /usr/lib/libeina.so.1.7.99
f6eda000 f6ef1000 r-xp /usr/lib/libecore.so.1.7.99
f6f08000 f6f11000 r-xp /usr/lib/libvconf.so.0.2.45
f6f19000 f6f2d000 r-xp /lib/libpthread-2.13.so
f6f38000 f6f45000 r-xp /usr/lib/libaul.so.0.1.0
f6f4f000 f6f51000 r-xp /lib/libdl-2.13.so
f6f5a000 f6f65000 r-xp /lib/libunwind.so.8.0.1
f6f92000 f6f9a000 r-xp /lib/libgcc_s-4.6.so.1
f6f9b000 f70bf000 r-xp /lib/libc-2.13.so
f70cd000 f70cf000 r-xp /usr/lib/libdlog.so.0.0.0
f70d7000 f70e3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70ec000 f70f1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70f9000 f7108000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7110000 f7114000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f711d000 f7120000 r-xp /usr/lib/libappcore-agent.so.1.1
f7128000 f712a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7132000 f7136000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f713e000 f715b000 r-xp /lib/ld-2.13.so
f7164000 f7167000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7167000 f716b000 r-xp /usr/lib/libsys-assert.so
f7352000 f73c3000 rw-p [heap]
ffe52000 ffe73000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16389)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7165228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70fc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e033f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e01c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e0de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e13be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e13dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e4875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e431f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e01c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e0de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e13be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e13dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e45e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e46017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e4df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47e51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47d8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68ab663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d58fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d5a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eeaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ee5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ee65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ee6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf711e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf711e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71655c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6fb285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7164f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
lerometer - capturing data
06-07 17:07:58.121+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:123,9.193225,0.600598,3.335595
06-07 17:07:58.121+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:58.121+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:113,-0.770000,0.420000,0.490000
06-07 17:07:58.121+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:58:129,358.000000
06-07 17:07:58.121+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.121+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:117,9.213127,0.526720,3.318319
06-07 17:07:58.121+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.131+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:134,9.217153,0.610170,3.345166
06-07 17:07:58.131+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.131+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:139,-0.630000,0.350000,0.630000
06-07 17:07:58.131+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:140,9.212783,0.527728,3.319115
06-07 17:07:58.131+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.141+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.141+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:143,0.036170,-0.094800,0.045405
06-07 17:07:58.141+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:147,9.286544,0.509671,3.330809
06-07 17:07:58.141+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.141+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.141+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:144,9.213487,0.529734,3.316840
06-07 17:07:58.141+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.151+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:154,9.213928,0.527042,3.316043
06-07 17:07:58.151+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:154,-0.700000,0.140000,0.070000
06-07 17:07:58.151+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:159,9.213512,0.525553,3.317435
06-07 17:07:58.151+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.161+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.161+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.161+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:158,0.034776,-0.096239,0.093106
06-07 17:07:58.161+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.161+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:168,9.233903,0.476172,3.357130
06-07 17:07:58.161+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:163,9.212872,0.527689,3.318873
06-07 17:07:58.161+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.171+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:58.171+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:174,9.212481,0.530750,3.319468
06-07 17:07:58.171+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.171+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:58:176,80
06-07 17:07:58.171+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:179,9.212474,0.533189,3.319098
06-07 17:07:58.171+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.181+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:183,9.212852,0.531329,3.318346
06-07 17:07:58.181+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:172,-0.070000,0.350000,-0.350000
06-07 17:07:58.181+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:173,0.026418,0.029780,0.074731
06-07 17:07:58.181+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.181+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.181+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.181+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:192,9.272188,0.480957,3.378666
06-07 17:07:58.191+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.191+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:195,9.212297,0.529089,3.320246
06-07 17:07:58.191+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:192,0.560000,0.280000,-0.420000
06-07 17:07:58.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:190,0.035132,0.066700,0.005312
06-07 17:07:58.191+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.201+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.201+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.201+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:206,0.210000,0.140000,0.280000
06-07 17:07:58.201+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:207,9.248260,0.552742,3.395415
06-07 17:07:58.201+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.201+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.211+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:205,0.016335,-0.053949,0.021266
06-07 17:07:58.211+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.211+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:219,0.032380,-0.043991,0.033111
06-07 17:07:58.211+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.221+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.221+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:227,9.243474,0.538385,3.373880
06-07 17:07:58.221+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:225,-0.420000,-0.210000,0.420000
06-07 17:07:58.231+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:212,9.211595,0.527054,3.322516
06-07 17:07:58.231+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.231+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:237,9.210779,0.527639,3.324685
06-07 17:07:58.231+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.231+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:242,0.630000,0.280000,0.140000
06-07 17:07:58.241+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.241+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.241+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:248,9.241080,0.392423,3.306881
06-07 17:07:58.241+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.251+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:253,9.210603,0.527541,3.325188
06-07 17:07:58.251+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:246,0.560000,0.420000,-0.140000
06-07 17:07:58.251+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.261+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:223,0.055866,0.037664,0.050659
06-07 17:07:58.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.261+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:269,9.272188,0.483350,3.371487
06-07 17:07:58.261+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.271+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.271+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:273,9.211930,0.521393,3.322480
06-07 17:07:58.271+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:276,-0.020288,0.075045,0.018160
06-07 17:07:58.271+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.271+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:262,0.420000,0.140000,-0.140000
06-07 17:07:58.281+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:283,0.004281,0.082481,0.026293
06-07 17:07:58.281+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.281+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.281+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:292,9.276974,0.555135,3.349952
06-07 17:07:58.291+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.291+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:296,9.211658,0.520558,3.323366
06-07 17:07:58.291+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.301+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.301+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:307,9.269794,0.519243,3.373880
06-07 17:07:58.301+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.301+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:303,-0.140000,0.210000,0.210000
06-07 17:07:58.301+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.311+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:312,9.211957,0.522486,3.322234
06-07 17:07:58.321+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:58.321+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.321+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:328,9.248260,0.519243,3.352344
06-07 17:07:58.321+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:290,0.074062,-0.021079,0.011341
06-07 17:07:58.321+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.331+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.331+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:58:327,358.000000
06-07 17:07:58.331+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:335,9.211471,0.522335,3.323606
06-07 17:07:58.331+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:315,-0.770000,-0.140000,0.490000
06-07 17:07:58.331+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.341+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.341+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:348,9.233903,0.471386,3.342773
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:58.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391278353,000000, pattern:[H:mm][0;m
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:07:58.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:07:58.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:07:58.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:07][0;m
06-07 17:07:58.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:333,0.021429,-0.057017,0.038032
06-07 17:07:58.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:359,0.059336,-0.050371,0.060320
06-07 17:07:58.351+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.361+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.361+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:365,9.210951,0.522491,3.325021
06-07 17:07:58.361+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.361+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:342,-0.210000,0.490000,0.280000
06-07 17:07:58.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.371+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:58.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:376,0.350000,0.280000,-0.140000
06-07 17:07:58.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:380,0.280000,0.280000,-0.140000
06-07 17:07:58.371+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.371+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:58:376,80
06-07 17:07:58.381+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.381+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:386,9.279366,0.528814,3.345166
06-07 17:07:58.381+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.391+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:371,9.211216,0.520685,3.324570
06-07 17:07:58.391+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:363,0.035962,0.023653,0.075169
06-07 17:07:58.391+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.391+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:399,0.031879,0.011331,0.051363
06-07 17:07:58.391+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.401+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:395,9.276974,0.579063,3.311667
06-07 17:07:58.401+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:384,-0.420000,-0.210000,0.140000
06-07 17:07:58.401+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.411+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.411+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:418,9.269794,0.591027,3.304488
06-07 17:07:58.411+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.421+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:404,9.211385,0.521763,3.323933
06-07 17:07:58.421+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.421+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:428,9.211720,0.525086,3.322484
06-07 17:07:58.421+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.431+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:415,-0.350000,-0.490000,0.140000
06-07 17:07:58.431+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.431+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:439,0.630000,-0.350000,-0.070000
06-07 17:07:58.431+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:423,0.030301,-0.135217,-0.017804
06-07 17:07:58.441+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:449,9.293723,0.531207,3.364309
06-07 17:07:58.441+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:446,0.061585,-0.044190,0.046299
06-07 17:07:58.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:458,0.065043,0.033742,0.027472
06-07 17:07:58.451+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.461+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:432,9.211767,0.528101,3.321873
06-07 17:07:58.461+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.461+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:467,9.210979,0.528699,3.323961
06-07 17:07:58.461+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.471+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:443,0.910000,-0.350000,-0.420000
06-07 17:07:58.471+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.471+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:480,0.420000,-0.770000,-0.210000
06-07 17:07:58.471+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.481+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:453,9.286544,0.466600,3.333202
06-07 17:07:58.481+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:462,0.058137,-0.001316,0.050514
06-07 17:07:58.481+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.491+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:472,9.211618,0.526505,3.322538
06-07 17:07:58.491+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.491+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:497,9.212059,0.526096,3.321382
06-07 17:07:58.491+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:488,9.272188,0.509671,3.349952
06-07 17:07:58.491+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:493,0.036303,-0.003244,0.030110
06-07 17:07:58.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:509,0.022432,-0.050949,0.019168
06-07 17:07:58.501+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:484,-0.070000,-0.420000,-0.140000
06-07 17:07:58.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:518,0.070000,-0.140000,-0.210000
06-07 17:07:58.511+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.521+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:58.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:503,9.209974,0.516850,3.373880
06-07 17:07:58.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:530,9.272188,0.533599,3.323631
06-07 17:07:58.521+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.531+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.531+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:536,9.212159,0.525779,3.321153
06-07 17:07:58.531+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.531+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:58:527,360.000000
06-07 17:07:58.531+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:540,9.212690,0.526085,3.319631
06-07 17:07:58.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:513,0.068416,0.006322,0.020145
06-07 17:07:58.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:549,0.065758,0.058378,-0.012903
06-07 17:07:58.541+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:522,0.560000,-0.630000,-0.280000
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:557,0.840000,-0.140000,-0.280000
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:561,0.560000,-0.140000,-0.280000
06-07 17:07:58.551+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.561+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:534,9.272188,0.557528,3.369094
06-07 17:07:58.561+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.561+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:571,9.224331,0.538385,3.323631
06-07 17:07:58.561+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.561+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:58.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:575,9.212497,0.527452,3.319952
06-07 17:07:58.571+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.571+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:58:579,80
06-07 17:07:58.571+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:579,9.213343,0.527691,3.317566
06-07 17:07:58.571+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:553,0.058410,0.069264,-0.019445
06-07 17:07:58.581+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.581+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:586,9.253045,0.543171,3.299703
06-07 17:07:58.581+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.591+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:565,-0.490000,-0.350000,-0.140000
06-07 17:07:58.591+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.591+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:599,0.070000,-0.140000,-0.350000
06-07 17:07:58.591+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.591+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.601+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:592,0.082004,0.006121,0.041825
06-07 17:07:58.601+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.601+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.601+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:607,0.074777,-0.061500,0.011329
06-07 17:07:58.611+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:604,9.214903,0.527956,3.313189
06-07 17:07:58.611+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.611+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:609,9.279366,0.540778,3.254239
06-07 17:07:58.621+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.621+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.631+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:620,9.217320,0.527726,3.306492
06-07 17:07:58.631+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.631+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:603,0.980000,-0.140000,-0.280000
06-07 17:07:58.631+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.641+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:633,9.272188,0.519243,3.302095
06-07 17:07:58.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:626,0.061209,-0.019027,0.025991
06-07 17:07:58.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:650,-0.001644,-0.009655,0.051342
06-07 17:07:58.641+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:645,0.770000,-0.280000,-0.140000
06-07 17:07:58.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:659,0.770000,-0.210000,0.070000
06-07 17:07:58.651+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.661+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.661+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:666,9.281759,0.500100,3.404987
06-07 17:07:58.661+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:639,9.218147,0.526318,3.304411
06-07 17:07:58.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:677,9.217790,0.524046,3.305769
06-07 17:07:58.671+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.671+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:681,9.217571,0.523382,3.306485
06-07 17:07:58.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:654,0.060129,0.007504,0.002249
06-07 17:07:58.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.681+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:690,0.060029,0.031748,0.047941
06-07 17:07:58.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:672,9.245867,0.512064,3.373880
06-07 17:07:58.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:697,9.212367,0.576670,3.357130
06-07 17:07:58.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.691+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:701,9.248260,0.543171,3.342773
06-07 17:07:58.701+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:663,0.420000,0.280000,0.070000
06-07 17:07:58.701+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.701+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:709,0.420000,0.210000,0.070000
06-07 17:07:58.701+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.711+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.711+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:716,9.217461,0.525296,3.306489
06-07 17:07:58.711+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.711+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:720,9.217233,0.525525,3.307087
06-07 17:07:58.711+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.721+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:58.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:725,0.011641,0.012300,0.004000
06-07 17:07:58.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:730,0.040548,0.015719,-0.020250
06-07 17:07:58.721+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:713,0.420000,-0.140000,0.210000
06-07 17:07:58.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.731+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:58:727,360.000000
06-07 17:07:58.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:737,0.630000,0.140000,0.350000
06-07 17:07:58.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.731+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:741,0.420000,0.210000,0.490000
06-07 17:07:58.741+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.741+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:746,9.286544,0.430708,3.309274
06-07 17:07:58.741+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.741+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:752,9.260223,0.445065,3.378666
06-07 17:07:58.751+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.751+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:755,9.217918,0.521704,3.305781
06-07 17:07:58.751+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.751+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:760,9.217717,0.518845,3.306792
06-07 17:07:58.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:734,0.066024,0.013087,-0.063327
06-07 17:07:58.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:768,0.057285,-0.008713,-0.011093
06-07 17:07:58.761+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.771+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.771+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:58.771+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:776,9.233903,0.564706,3.311667
06-07 17:07:58.771+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.771+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:780,9.200402,0.586242,3.270989
06-07 17:07:58.771+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:58:776,80
06-07 17:07:58.771+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.781+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:785,-0.280000,0.350000,0.420000
06-07 17:07:58.781+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.781+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.791+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:772,0.064439,-0.027626,0.098494
06-07 17:07:58.791+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:791,9.218458,0.520664,3.304440
06-07 17:07:58.791+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.811+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.821+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:789,-0.070000,0.210000,0.420000
06-07 17:07:58.831+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:798,9.219431,0.522825,3.301383
06-07 17:07:58.831+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.831+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:823,0.027719,-0.014254,0.069469
06-07 17:07:58.831+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.831+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.841+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.851+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:844,9.220086,0.521034,3.299837
06-07 17:07:58.851+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.851+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:859,9.218884,0.520535,3.303273
06-07 17:07:58.861+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:850,9.288938,0.485743,3.323631
06-07 17:07:58.861+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.861+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:839,0.630000,0.210000,0.140000
06-07 17:07:58.861+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:840,-0.005423,0.052624,0.051361
06-07 17:07:58.861+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.861+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.871+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:874,0.210000,0.070000,0.350000
06-07 17:07:58.871+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.891+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:867,9.262616,0.492921,3.428915
06-07 17:07:58.901+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:873,0.030688,0.019789,0.036288
06-07 17:07:58.901+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.911+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.911+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:916,9.219178,0.521948,3.302229
06-07 17:07:58.911+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.911+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:920,9.221094,0.524304,3.296501
06-07 17:07:58.911+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.921+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:58.921+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:879,-0.280000,0.070000,0.210000
06-07 17:07:58.921+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.931+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:58:928,360.000000
06-07 17:07:58.931+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.941+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:941,9.265009,0.538385,3.361916
06-07 17:07:58.941+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:909,0.069083,-0.094588,0.002785
06-07 17:07:58.941+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.951+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.951+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:933,0.980000,0.210000,-0.210000
06-07 17:07:58.951+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.961+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:956,9.236296,0.576670,3.278167
06-07 17:07:58.961+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:949,0.042991,-0.080460,0.071579
06-07 17:07:58.961+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:58.971+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:58.971+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:58.981+0200 W/LOCATION(16389): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:07:58.981+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:924,9.222787,0.525402,3.291586
06-07 17:07:58.981+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:58.991+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:58:978,80
06-07 17:07:58.991+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:58:965,1.400000,0.420000,-0.140000
06-07 17:07:58.991+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:58.991+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:58:971,0.015985,0.043002,0.005886
06-07 17:07:58.991+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.001+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:58:982,9.269794,0.567099,3.316452
06-07 17:07:59.001+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.011+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:1,0.490000,0.140000,0.280000
06-07 17:07:59.011+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.021+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:58:989,9.223348,0.522694,3.290447
06-07 17:07:59.021+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.031+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:5,-0.017315,0.067396,-0.035803
06-07 17:07:59.031+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.031+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:10,9.281759,0.459422,3.294917
06-07 17:07:59.031+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.041+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:20,-0.280000,0.140000,0.490000
06-07 17:07:59.041+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:07:59.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:07:59.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:07:59.071+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:38,0.070479,-0.034921,0.019191
06-07 17:07:59.071+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.081+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:59:31,9.222086,0.520945,3.294256
06-07 17:07:59.081+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.081+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:53,0.630000,0.140000,0.070000
06-07 17:07:59.081+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.081+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:42,9.274581,0.459422,3.364309
06-07 17:07:59.091+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:59:86,9.221371,0.523632,3.295833
06-07 17:07:59.091+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.101+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.101+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:78,0.043185,-0.029904,0.127532
06-07 17:07:59.101+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.121+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:07:59.121+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:107,9.226725,0.569492,3.357130
06-07 17:07:59.121+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.121+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:07:59:127,358.000000
06-07 17:07:59.121+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:129,9.214760,0.583849,3.321238
06-07 17:07:59.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:91,1.190000,-0.140000,-0.280000
06-07 17:07:59.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.131+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:138,1.260000,-0.490000,-0.140000
06-07 17:07:59.141+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:113,0.044923,0.017351,0.062078
06-07 17:07:59.141+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.141+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:59:102,9.221038,0.526604,3.296291
06-07 17:07:59.151+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:159,0.910000,-0.490000,0.280000
06-07 17:07:59.151+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.161+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.171+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:07:59.171+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:150,0.017412,0.056135,-0.025106
06-07 17:07:59.171+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.171+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:59:156,9.221353,0.525800,3.295539
06-07 17:07:59.171+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.171+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:07:59:175,80
06-07 17:07:59.181+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:169,9.298509,0.500100,3.326023
06-07 17:07:59.181+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:176,0.050616,0.045151,0.014223
06-07 17:07:59.191+0200 I/gravity (16360): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:07:59:179,9.222033,0.524580,3.293831
06-07 17:07:59.191+0200 I/gravity (16360): es.ugr.frailty.gravity - capturing data
06-07 17:07:59.191+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer - capturing data
06-07 17:07:59.211+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.211+0200 I/accelerometer(16341): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:07:59:205,9.286544,0.471386,3.335595
06-07 17:07:59.221+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:07:59:195,0.560000,-0.560000,0.490000
06-07 17:07:59.231+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:07:59:219,0.060665,-0.064882,-0.001584
06-07 17:07:59.231+0200 I/linearacceleration(16440): es.ugr.frailty.linearacceleration - capturing data
06-07 17:07:59.231+0200 I/gyroscope(16425): es.ugr.frailty.gyroscope - capturing data
06-07 17:07:59.231+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11163896c6f63152838407
