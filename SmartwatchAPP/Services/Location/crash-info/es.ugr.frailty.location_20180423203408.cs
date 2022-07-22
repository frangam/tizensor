S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10260
Date: 2018-04-23 20:34:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf701252d, r5   = 0xf776cf98
r6   = 0xffe0c2e0, r7   = 0xffe0c190
r8   = 0xf7769c18, r9   = 0x00000000
r10  = 0xffe0c26c, fp   = 0xffe0c2e0
ip   = 0x00000001, sp   = 0xffe0c168
lr   = 0xf7012539, pc   = 0xf707b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    127752 KB
Buffers:     36724 KB
Cached:     156008 KB
VmPeak:      53648 KB
VmSize:      53644 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12116 KB
VmRSS:       12116 KB
VmData:      11372 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10260 TID = 10260
10260 10263 

Maps Information
f3edd000 f46dc000 rw-p [stack:10263]
f46e3000 f46e5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f46ed000 f46f1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f46fa000 f46fc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4704000 f4707000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4716000 f471b000 r-xp /usr/lib/libsystem.so.0.0.0
f4726000 f4729000 r-xp /lib/libattr.so.1.1.0
f4731000 f4741000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4749000 f4752000 r-xp /usr/lib/libedbus.so.1.7.99
f475a000 f475b000 r-xp /usr/lib/libresponse.so.0.2.96
f4764000 f4769000 r-xp /usr/lib/libproc-stat.so.0.2.96
f600b000 f6111000 r-xp /usr/lib/libicuuc.so.57.1
f6127000 f62af000 r-xp /usr/lib/libicui18n.so.57.1
f62bf000 f62cc000 r-xp /usr/lib/libail.so.0.1.0
f62d5000 f62dc000 r-xp /usr/lib/libminizip.so.1.0.0
f62e5000 f648e000 r-xp /usr/lib/libcrypto.so.1.0.0
f64ae000 f64f5000 r-xp /usr/lib/libssl.so.1.0.0
f6501000 f6503000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f650b000 f6512000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f651b000 f6522000 r-xp /lib/libcrypt-2.13.so
f6553000 f6556000 r-xp /lib/libcap.so.2.21
f655e000 f6560000 r-xp /usr/lib/libiri.so
f6568000 f65b1000 r-xp /usr/lib/libmdm.so.1.2.69
f65b9000 f65bf000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f65c7000 f65ea000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f65f4000 f65f6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f65fe000 f661b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6624000 f6628000 r-xp /usr/lib/libsmack.so.1.0.0
f6631000 f664a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6653000 f665b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6663000 f6669000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6672000 f6674000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f667d000 f668d000 r-xp /lib/libresolv-2.13.so
f6691000 f66a9000 r-xp /usr/lib/liblzma.so.5.0.3
f66b2000 f66b4000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66bc000 f66d6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f66de000 f670d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6716000 f6725000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f672f000 f6739000 r-xp /usr/lib/libsensord-shared.so
f6742000 f6815000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6820000 f6836000 r-xp /lib/libz.so.1.2.5
f683e000 f6843000 r-xp /usr/lib/libffi.so.5.0.10
f684b000 f684c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6854000 f6864000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f686c000 f6885000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f688d000 f688f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6897000 f690c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6916000 f691c000 r-xp /lib/librt-2.13.so
f6925000 f6943000 r-xp /usr/lib/libsystemd.so.0.4.0
f694d000 f694e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6956000 f6979000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6981000 f6986000 r-xp /usr/lib/libxdgmime.so.1.1.0
f698e000 f69b8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69c1000 f69d8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f69e0000 f6a49000 r-xp /lib/libm-2.13.so
f6a52000 f6ae6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6af9000 f6afe000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b06000 f6b0d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b15000 f6b3f000 r-xp /usr/lib/libsensor.so.1.9.6
f6b48000 f6c14000 r-xp /usr/lib/libxml2.so.2.7.8
f6c21000 f6c23000 r-xp /usr/lib/libiniparser.so.0
f6c2c000 f6c32000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c3b000 f6d0b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d0c000 f6d40000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d49000 f6d85000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6d8d000 f6d90000 r-xp /usr/lib/libbundle.so.0.1.22
f6d98000 f6d9e000 r-xp /usr/lib/libappsvc.so.0.1.0
f6da6000 f6de7000 r-xp /usr/lib/libeina.so.1.7.99
f6df0000 f6e07000 r-xp /usr/lib/libecore.so.1.7.99
f6e1e000 f6e27000 r-xp /usr/lib/libvconf.so.0.2.45
f6e2f000 f6e43000 r-xp /lib/libpthread-2.13.so
f6e4e000 f6e5b000 r-xp /usr/lib/libaul.so.0.1.0
f6e65000 f6e67000 r-xp /lib/libdl-2.13.so
f6e70000 f6e7b000 r-xp /lib/libunwind.so.8.0.1
f6ea8000 f6eb0000 r-xp /lib/libgcc_s-4.6.so.1
f6eb1000 f6fd5000 r-xp /lib/libc-2.13.so
f6fe3000 f6fe5000 r-xp /usr/lib/libdlog.so.0.0.0
f6fed000 f6ff9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7002000 f7007000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f700f000 f701e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7026000 f702a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7033000 f7036000 r-xp /usr/lib/libappcore-agent.so.1.1
f703e000 f7040000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7048000 f704c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7054000 f7071000 r-xp /lib/ld-2.13.so
f707a000 f707d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f707d000 f7081000 r-xp /usr/lib/libsys-assert.so
f7739000 f77d9000 rw-p [heap]
ffded000 ffe0e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10260)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf707b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7012539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d193f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d5e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d591f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d17c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d23e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d29be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d29dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d5be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d5c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6d63f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46fb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf46ee171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67c1663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6c6efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6c707a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e00ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6dfbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6dfc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6dfc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7034183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70347fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf707b53f) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x153f
28: __libc_start_main + 0x114 (0xf6ec885c) [/lib/libc.so.6] + 0x1785c
29: (0xf707af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
34:07.379+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:383,0.047856,9.805787,0.827917
04-23 20:34:07.389+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.389+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.389+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:388,-0.011951,0.036876,-0.029152
04-23 20:34:07.389+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.389+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:390,0.043322,9.771429,0.829264
04-23 20:34:07.389+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.389+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:395,-0.070000,0.140000,-0.070000
04-23 20:34:07.389+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.399+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:395,0.055035,9.793823,0.818345
04-23 20:34:07.399+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:399,0.004534,0.034358,-0.001347
04-23 20:34:07.399+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.399+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:400,0.042878,9.771359,0.830109
04-23 20:34:07.399+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.399+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:403,-0.070000,0.210000,0.070000
04-23 20:34:07.399+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.409+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.409+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:407,-0.014357,9.803394,0.770489
04-23 20:34:07.409+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.409+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:417,-0.070000,0.140000,0.070000
04-23 20:34:07.409+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:413,0.012157,0.022464,-0.011763
04-23 20:34:07.419+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.419+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:408,0.042944,9.771487,0.828602
04-23 20:34:07.419+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.419+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:419,0.023928,9.767502,0.758525
04-23 20:34:07.419+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:425,0.043645,9.771392,0.829684
04-23 20:34:07.419+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.419+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:423,-0.058002,0.032002,-0.059195
04-23 20:34:07.419+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.419+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:429,0.040994,9.771242,0.831586
04-23 20:34:07.429+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:430,-0.019717,-0.003890,-0.071159
04-23 20:34:07.429+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.429+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:437,-0.070000,0.140000,0.070000
04-23 20:34:07.429+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.429+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.439+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:441,0.047856,9.786645,0.811167
04-23 20:34:07.439+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:441,0.006863,0.015403,-0.020419
04-23 20:34:07.439+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.439+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:445,0.040315,9.771299,0.830941
04-23 20:34:07.449+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.449+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.449+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:457,0.016750,9.834501,0.782453
04-23 20:34:07.449+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.449+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:455,-0.070000,0.070000,0.070000
04-23 20:34:07.459+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.459+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:461,-0.023565,0.063202,-0.048488
04-23 20:34:07.459+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:463,0.040817,9.771253,0.831473
04-23 20:34:07.469+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.469+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.469+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:476,-0.070000,0.070000,0.070000
04-23 20:34:07.469+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:476,0.007040,0.022571,-0.034663
04-23 20:34:07.469+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.479+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:480,0.047856,9.793823,0.796810
04-23 20:34:07.479+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.479+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:484,0.039806,9.771218,0.831922
04-23 20:34:07.489+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.489+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.489+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:495,-0.070000,0.070000,0.070000
04-23 20:34:07.489+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:495,0.028714,9.786645,0.794417
04-23 20:34:07.489+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.489+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.489+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:07.489+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:07.499+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:500,0.040333,9.771244,0.831589
04-23 20:34:07.499+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:501,-0.011092,0.015427,-0.037505
04-23 20:34:07.509+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.509+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.509+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:516,-0.070000,0.210000,0.070000
04-23 20:34:07.509+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.519+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:516,0.043071,9.789038,0.808774
04-23 20:34:07.519+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.519+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:522,0.039914,9.771178,0.832391
04-23 20:34:07.519+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:524,0.002737,0.017794,-0.022815
04-23 20:34:07.529+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.529+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.529+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:536,-0.070000,0.140000,0.070000
04-23 20:34:07.529+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:536,0.038285,9.781858,0.806381
04-23 20:34:07.529+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.539+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.539+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:542,0.040202,9.771120,0.833051
04-23 20:34:07.539+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:544,-0.001628,0.010680,-0.026010
04-23 20:34:07.549+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.549+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.549+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:555,-0.070000,0.070000,0.070000
04-23 20:34:07.549+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:556,0.045464,9.786645,0.818345
04-23 20:34:07.549+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.559+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.559+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:562,0.040257,9.771070,0.833634
04-23 20:34:07.559+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:564,0.005262,0.015525,-0.014705
04-23 20:34:07.569+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.569+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.569+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:576,0.033500,9.801002,0.820738
04-23 20:34:07.569+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:575,-0.070000,0.140000,0.070000
04-23 20:34:07.579+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.579+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.579+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:583,0.040641,9.770983,0.834644
04-23 20:34:07.579+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:584,-0.006758,0.029931,-0.012896
04-23 20:34:07.589+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.589+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.599+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:599,0.026358,0.034804,-0.013906
04-23 20:34:07.599+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.609+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:597,-0.070000,0.140000,0.070000
04-23 20:34:07.609+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.609+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.609+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:612,0.066999,9.805787,0.820738
04-23 20:34:07.619+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.619+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.619+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:620,0.040440,9.770858,0.836114
04-23 20:34:07.619+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.629+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:619,-0.070000,0.140000,0.070000
04-23 20:34:07.629+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.629+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:624,-0.033262,0.046893,-0.041696
04-23 20:34:07.629+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:627,0.007178,9.817751,0.794417
04-23 20:34:07.639+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.639+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.639+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:630,0.041826,9.770839,0.836266
04-23 20:34:07.639+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.639+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:636,-0.070000,0.070000,0.070000
04-23 20:34:07.649+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.649+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:645,-0.013112,0.068447,-0.010742
04-23 20:34:07.649+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:655,-0.070000,0.070000,0.070000
04-23 20:34:07.649+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:646,0.040316,9.770736,0.837543
04-23 20:34:07.649+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:646,0.028714,9.839286,0.825524
04-23 20:34:07.659+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.659+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.659+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:665,0.066999,9.767502,0.811167
04-23 20:34:07.669+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:670,0.026683,-0.003234,-0.026376
04-23 20:34:07.679+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.679+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:684,0.034272,0.016033,-0.051769
04-23 20:34:07.679+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.689+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:692,0.074178,9.786645,0.787239
04-23 20:34:07.689+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.689+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.699+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:702,0.039905,9.770612,0.839007
04-23 20:34:07.699+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:701,-0.070000,0.070000,0.070000
04-23 20:34:07.709+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.709+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:717,0.041340,9.770658,0.838407
04-23 20:34:07.709+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.719+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:722,0.043052,9.770844,0.836139
04-23 20:34:07.719+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.719+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:727,0.043077,9.770849,0.836080
04-23 20:34:07.719+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:07.729+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:07.729+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.729+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:734,-0.000662,0.025558,-0.041597
04-23 20:34:07.729+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.739+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.739+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:743,0.042191,9.770802,0.836681
04-23 20:34:07.739+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:739,-0.021517,0.046906,-0.039329
04-23 20:34:07.739+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.739+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:749,-0.026327,0.015796,-0.046449
04-23 20:34:07.749+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.749+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.749+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.749+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:757,-0.070000,0.140000,0.070000
04-23 20:34:07.749+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:756,0.040678,9.796216,0.796810
04-23 20:34:07.749+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.749+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.759+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:761,-0.070000,0.140000,0.070000
04-23 20:34:07.759+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.759+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.759+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:765,-0.070000,0.070000,0.070000
04-23 20:34:07.759+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.759+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:754,0.041115,9.770738,0.837483
04-23 20:34:07.769+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:769,-0.070000,0.140000,0.070000
04-23 20:34:07.769+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.769+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:763,0.021535,9.817751,0.796810
04-23 20:34:07.769+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.769+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:775,-0.070000,0.070000,0.070000
04-23 20:34:07.769+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.779+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:778,0.039528,9.770606,0.839092
04-23 20:34:07.779+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:769,-0.037406,0.034986,-0.037479
04-23 20:34:07.779+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.779+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:780,0.016750,9.786645,0.789631
04-23 20:34:07.779+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.779+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:786,0.004786,9.805787,0.799203
04-23 20:34:07.779+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.779+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:785,-0.019579,0.044621,-0.064602
04-23 20:34:07.789+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.789+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.789+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:795,-0.070000,0.070000,0.070000
04-23 20:34:07.789+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:790,0.021535,9.815358,0.772882
04-23 20:34:07.789+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.789+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:795,0.038806,9.770646,0.838662
04-23 20:34:07.789+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.799+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:801,0.055035,9.803394,0.782453
04-23 20:34:07.799+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:802,0.015507,0.032788,-0.056639
04-23 20:34:07.809+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.809+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.809+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:815,-0.070000,0.070000,0.070000
04-23 20:34:07.809+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.809+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:815,0.039728,9.770813,0.836671
04-23 20:34:07.809+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.819+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:820,0.004786,9.798609,0.830309
04-23 20:34:07.819+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:821,-0.034021,0.027963,-0.008352
04-23 20:34:07.829+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.829+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.829+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:836,-0.070000,0.140000,0.070000
04-23 20:34:07.829+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:836,0.038221,9.770565,0.839629
04-23 20:34:07.839+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.839+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.839+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:844,0.020093,0.030189,-0.015933
04-23 20:34:07.839+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:845,0.059821,9.801002,0.820738
04-23 20:34:07.849+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.849+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.849+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:855,-0.070000,0.070000,0.070000
04-23 20:34:07.849+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.849+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:856,0.039382,9.770560,0.839634
04-23 20:34:07.849+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.859+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:860,0.035892,9.765109,0.787239
04-23 20:34:07.859+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:862,-0.002328,-0.005456,-0.052390
04-23 20:34:07.869+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.869+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.869+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:874,-0.070000,0.070000,0.070000
04-23 20:34:07.869+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.869+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:875,0.039365,9.770603,0.839130
04-23 20:34:07.879+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.879+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:880,0.050249,9.801002,0.799203
04-23 20:34:07.879+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:883,0.010868,0.030441,-0.040432
04-23 20:34:07.889+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.889+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.889+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:896,-0.070000,0.070000,0.070000
04-23 20:34:07.889+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.889+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.889+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:07.899+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:07.899+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:901,0.053955,0.044755,-0.037535
04-23 20:34:07.899+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:896,0.040027,9.770665,0.838381
04-23 20:34:07.899+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:901,0.093320,9.815358,0.801596
04-23 20:34:07.909+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.909+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.909+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.909+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:917,0.042695,9.770864,0.835921
04-23 20:34:07.919+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:916,-0.070000,0.070000,0.070000
04-23 20:34:07.919+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:921,0.038936,-0.000771,-0.036785
04-23 20:34:07.919+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.919+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:927,0.078963,9.769895,0.801596
04-23 20:34:07.929+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.929+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.929+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.939+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:937,0.044570,9.770969,0.834601
04-23 20:34:07.939+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:936,-0.070000,0.070000,0.070000
04-23 20:34:07.939+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:940,0.021912,0.015780,-0.036718
04-23 20:34:07.939+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.949+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:948,0.064606,9.786645,0.799203
04-23 20:34:07.949+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.949+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.949+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:955,0.045671,9.771039,0.833727
04-23 20:34:07.949+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.949+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.949+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:955,-0.070000,0.070000,0.070000
04-23 20:34:07.959+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:960,0.007178,9.784252,0.748954
04-23 20:34:07.959+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:960,-0.037392,0.013283,-0.085648
04-23 20:34:07.969+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.969+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.969+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:978,-0.070000,0.140000,0.070000
04-23 20:34:07.979+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:07.979+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:977,0.043944,9.771065,0.833513
04-23 20:34:07.979+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:07.989+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:07:983,-0.009779,0.015606,-0.027346
04-23 20:34:07.989+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:07.989+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:07.999+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:07:995,0.043707,9.771013,0.834132
04-23 20:34:07.999+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:07:987,0.035892,9.786645,0.806381
04-23 20:34:07.999+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.009+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.019+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.019+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:07:998,-0.070000,0.070000,0.070000
04-23 20:34:08.019+0200 W/LOCATION(10260): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:34:08.019+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.029+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:9,0.076570,9.779467,0.787239
04-23 20:34:08.029+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:27,0.032626,0.008402,-0.046275
04-23 20:34:08.029+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.029+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:32,-0.070000,0.140000,0.070000
04-23 20:34:08.029+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.039+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:17,0.045421,9.771170,0.832209
04-23 20:34:08.039+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.039+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.039+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:46,-0.070000,0.070000,0.070000
04-23 20:34:08.049+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:42,-0.014993,0.053916,-0.049286
04-23 20:34:08.049+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.049+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:46,0.044762,9.771186,0.832051
04-23 20:34:08.049+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.049+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.059+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:56,-0.019100,0.015475,-0.011471
04-23 20:34:08.059+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.069+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:61,-0.070000,0.070000,0.070000
04-23 20:34:08.069+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.069+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:34:08.069+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:34:08.069+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:34:08.079+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:39,0.028714,9.824929,0.784846
04-23 20:34:08.079+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.089+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:72,-0.020834,0.025030,-0.066347
04-23 20:34:08.089+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:80,-0.070000,-0.140000,0.070000
04-23 20:34:08.089+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:59,0.044036,9.771049,0.833690
04-23 20:34:08.089+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.089+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.099+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:08.099+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:08.099+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.099+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:90,0.026321,9.786645,0.820738
04-23 20:34:08.099+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.099+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:99,0.027748,0.037130,-0.017737
04-23 20:34:08.099+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:104,-0.070000,-0.140000,0.070000
04-23 20:34:08.099+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.109+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.109+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:99,0.043234,9.771148,0.832577
04-23 20:34:08.109+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.119+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:108,0.023928,9.796216,0.765703
04-23 20:34:08.119+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:113,-0.036055,0.025068,-0.057303
04-23 20:34:08.119+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.119+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.119+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:119,0.070000,-0.070000,0.070000
04-23 20:34:08.129+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.129+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:122,0.044742,9.771187,0.832035
04-23 20:34:08.129+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.129+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:128,-0.042349,0.032207,-0.011297
04-23 20:34:08.129+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:125,0.071785,9.808180,0.815953
04-23 20:34:08.129+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.139+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.139+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:137,0.070000,-0.070000,0.070000
04-23 20:34:08.139+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:139,0.043088,9.771191,0.832086
04-23 20:34:08.139+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:142,0.007178,9.796216,0.775275
04-23 20:34:08.139+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.149+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.149+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.149+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:151,0.002393,9.803394,0.820738
04-23 20:34:08.149+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:153,0.041315,9.771040,0.833944
04-23 20:34:08.159+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.159+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.159+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:148,-0.021552,0.022633,-0.030490
04-23 20:34:08.159+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.159+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:156,0.070000,-0.070000,0.070000
04-23 20:34:08.159+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:165,0.021535,9.793823,0.801596
04-23 20:34:08.159+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.169+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.169+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:163,0.040525,9.771008,0.834345
04-23 20:34:08.169+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.169+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:177,0.070000,-0.070000,0.070000
04-23 20:34:08.169+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:177,0.040223,9.771049,0.833890
04-23 20:34:08.169+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:170,0.031107,9.815358,0.794417
04-23 20:34:08.179+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.179+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:169,-0.010209,0.044318,-0.039527
04-23 20:34:08.179+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:184,0.047856,9.808180,0.763310
04-23 20:34:08.179+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.189+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.189+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.189+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:195,0.040743,9.771297,0.830954
04-23 20:34:08.189+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.189+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:196,0.047856,9.805787,0.789631
04-23 20:34:08.199+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:199,0.070000,-0.070000,0.070000
04-23 20:34:08.199+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:189,0.007332,0.037171,-0.071034
04-23 20:34:08.199+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.209+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:209,0.007633,0.034739,-0.044258
04-23 20:34:08.209+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.209+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.209+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.209+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:215,0.041241,9.771366,0.830118
04-23 20:34:08.219+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:216,0.002393,9.793823,0.765703
04-23 20:34:08.219+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:218,-0.140000,-0.070000,0.070000
04-23 20:34:08.219+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.219+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:228,-0.038350,0.022527,-0.065251
04-23 20:34:08.229+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.229+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.229+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.229+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:236,0.039528,9.771329,0.830630
04-23 20:34:08.239+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:237,0.045464,9.801002,0.813560
04-23 20:34:08.239+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:239,-0.070000,-0.070000,0.070000
04-23 20:34:08.239+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.239+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:248,0.004223,0.029635,-0.016559
04-23 20:34:08.249+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.249+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.249+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.249+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:254,0.039963,9.771294,0.831034
04-23 20:34:08.249+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:255,0.038285,9.801002,0.782453
04-23 20:34:08.259+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:256,-0.070000,-0.070000,0.070000
04-23 20:34:08.259+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.259+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:268,-0.001243,0.029673,-0.048177
04-23 20:34:08.269+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.269+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.269+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.269+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:275,0.040040,9.771369,0.830141
04-23 20:34:08.269+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:278,0.078963,9.772287,0.806381
04-23 20:34:08.279+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:276,-0.070000,-0.070000,0.070000
04-23 20:34:08.279+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.279+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:286,0.039000,0.000994,-0.024652
04-23 20:34:08.289+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.289+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.289+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.289+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:295,0.042045,9.771446,0.829124
04-23 20:34:08.299+0200 I/heartrate(10143): capturing data from es.ugr.frailty.heartrate
04-23 20:34:08.299+0200 I/heartrate(10143): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:34:08.299+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:295,-0.070000,-0.070000,0.070000
04-23 20:34:08.299+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:297,0.047856,9.767502,0.815953
04-23 20:34:08.299+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.299+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:307,0.007816,-0.003867,-0.014188
04-23 20:34:08.309+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.309+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.309+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:315,0.042481,9.771386,0.829818
04-23 20:34:08.309+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.309+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:319,0.059821,9.793823,0.792024
04-23 20:34:08.319+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:315,-0.070000,-0.070000,0.070000
04-23 20:34:08.319+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.319+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:325,0.017775,0.022377,-0.037100
04-23 20:34:08.329+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.329+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.329+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.329+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:339,0.021535,9.817751,0.770489
04-23 20:34:08.339+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:343,0.043465,9.771482,0.828640
04-23 20:34:08.339+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:337,-0.070000,-0.070000,0.070000
04-23 20:34:08.339+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.359+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.359+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.359+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.369+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:366,0.042567,9.771530,0.828114
04-23 20:34:08.369+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.379+0200 I/gravity (10179): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:34:08:379,0.042864,9.771538,0.828011
04-23 20:34:08.379+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:368,0.045464,9.784252,0.799203
04-23 20:34:08.379+0200 I/accelerometer(10126): capturing data from es.ugr.frailty.accelerometer
04-23 20:34:08.379+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:364,-0.070000,-0.070000,0.070000
04-23 20:34:08.379+0200 I/gyroscope(10129): capturing data from es.ugr.frailty.gyroscope
04-23 20:34:08.389+0200 I/accelerometer(10126): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:34:08:388,0.031107,9.820145,0.789631
04-23 20:34:08.389+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:350,-0.020946,0.046365,-0.059330
04-23 20:34:08.389+0200 I/linearacceleration(10167): capturing data from es.ugr.frailty.linearacceleration
04-23 20:34:08.389+0200 I/gyroscope(10129): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:34:08:389,-0.070000,-0.070000,0.070000
04-23 20:34:08.389+0200 I/gravity (10179): capturing data from es.ugr.frailty.gravity
04-23 20:34:08.389+0200 I/linearacceleration(10167): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:34:08:394,0.001998,0.012771,-0.029437
04-23 20:34:08.389+0200 W/CRASH_MANAGER(10205): worker.c: worker_job(1205) > 11102606c6f63152450844
