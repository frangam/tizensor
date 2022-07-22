S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14870
Date: 2018-06-07 17:02:39+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf707052d, r5   = 0xf7638f98
r6   = 0xffc5b4c0, r7   = 0xffc5b370
r8   = 0xf7635c18, r9   = 0x00000000
r10  = 0xffc5b44c, fp   = 0xffc5b4c0
ip   = 0x00000001, sp   = 0xffc5b348
lr   = 0xf7070539, pc   = 0xf70d9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     43360 KB
Buffers:      8540 KB
Cached:      49764 KB
VmPeak:      53524 KB
VmSize:      53520 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11684 KB
VmRSS:       11684 KB
VmData:      11248 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14870 TID = 14870
14870 14875 

Maps Information
f3f3b000 f473a000 rw-p [stack:14875]
f4741000 f4743000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f474b000 f474f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4758000 f475a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4762000 f4765000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4774000 f4779000 r-xp /usr/lib/libsystem.so.0.0.0
f4784000 f4787000 r-xp /lib/libattr.so.1.1.0
f478f000 f479f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47a7000 f47b0000 r-xp /usr/lib/libedbus.so.1.7.99
f47b8000 f47b9000 r-xp /usr/lib/libresponse.so.0.2.96
f47c2000 f47c7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6069000 f616f000 r-xp /usr/lib/libicuuc.so.57.1
f6185000 f630d000 r-xp /usr/lib/libicui18n.so.57.1
f631d000 f632a000 r-xp /usr/lib/libail.so.0.1.0
f6333000 f633a000 r-xp /usr/lib/libminizip.so.1.0.0
f6343000 f64ec000 r-xp /usr/lib/libcrypto.so.1.0.0
f650c000 f6553000 r-xp /usr/lib/libssl.so.1.0.0
f655f000 f6561000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6569000 f6570000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6579000 f6580000 r-xp /lib/libcrypt-2.13.so
f65b1000 f65b4000 r-xp /lib/libcap.so.2.21
f65bc000 f65be000 r-xp /usr/lib/libiri.so
f65c6000 f660f000 r-xp /usr/lib/libmdm.so.1.2.69
f6617000 f661d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6625000 f6648000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6652000 f6654000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f665c000 f6679000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6682000 f6686000 r-xp /usr/lib/libsmack.so.1.0.0
f668f000 f66a8000 r-xp /usr/lib/libnetwork.so.0.0.0
f66b1000 f66b9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66c1000 f66c7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66d0000 f66d2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66db000 f66eb000 r-xp /lib/libresolv-2.13.so
f66ef000 f6707000 r-xp /usr/lib/liblzma.so.5.0.3
f6710000 f6712000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f671a000 f6734000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f673c000 f676b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6774000 f6783000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f678d000 f6797000 r-xp /usr/lib/libsensord-shared.so
f67a0000 f6873000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f687e000 f6894000 r-xp /lib/libz.so.1.2.5
f689c000 f68a1000 r-xp /usr/lib/libffi.so.5.0.10
f68a9000 f68aa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68b2000 f68c2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68ca000 f68e3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68eb000 f68ed000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68f5000 f696a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6974000 f697a000 r-xp /lib/librt-2.13.so
f6983000 f69a1000 r-xp /usr/lib/libsystemd.so.0.4.0
f69ab000 f69ac000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69b4000 f69d7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69df000 f69e4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69ec000 f6a16000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a1f000 f6a36000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a3e000 f6aa7000 r-xp /lib/libm-2.13.so
f6ab0000 f6b44000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b57000 f6b5c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b64000 f6b6b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b73000 f6b9d000 r-xp /usr/lib/libsensor.so.1.9.6
f6ba6000 f6c72000 r-xp /usr/lib/libxml2.so.2.7.8
f6c7f000 f6c81000 r-xp /usr/lib/libiniparser.so.0
f6c8a000 f6c90000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c99000 f6d69000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d6a000 f6d9e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6da7000 f6de3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6deb000 f6dee000 r-xp /usr/lib/libbundle.so.0.1.22
f6df6000 f6dfc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e04000 f6e45000 r-xp /usr/lib/libeina.so.1.7.99
f6e4e000 f6e65000 r-xp /usr/lib/libecore.so.1.7.99
f6e7c000 f6e85000 r-xp /usr/lib/libvconf.so.0.2.45
f6e8d000 f6ea1000 r-xp /lib/libpthread-2.13.so
f6eac000 f6eb9000 r-xp /usr/lib/libaul.so.0.1.0
f6ec3000 f6ec5000 r-xp /lib/libdl-2.13.so
f6ece000 f6ed9000 r-xp /lib/libunwind.so.8.0.1
f6f06000 f6f0e000 r-xp /lib/libgcc_s-4.6.so.1
f6f0f000 f7033000 r-xp /lib/libc-2.13.so
f7041000 f7043000 r-xp /usr/lib/libdlog.so.0.0.0
f704b000 f7057000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7060000 f7065000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f706d000 f707c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7084000 f7088000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7091000 f7094000 r-xp /usr/lib/libappcore-agent.so.1.1
f709c000 f709e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70a6000 f70aa000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70b2000 f70cf000 r-xp /lib/ld-2.13.so
f70d8000 f70db000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70db000 f70df000 r-xp /usr/lib/libsys-assert.so
f7605000 f7688000 rw-p [heap]
ffc3c000 ffc5d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14870)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70d9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7070539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d773f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d75c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d81e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d87be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d87dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6dbc75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6db71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d75c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d81e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d87be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d87dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6db9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dba017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6dc1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47591fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf474c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf681f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cccfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cce7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e5eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e59b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e5a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e5a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7092183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70927fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70d95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f2685c) [/lib/libc.so.6] + 0x1785c
29: (0xf70d8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
07/06/2018,17:02:38:98,-0.089244,0.079970,-0.019068
06-07 17:02:38.091+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.101+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:102,2.770889,-1.591227,9.382257
06-07 17:02:38.101+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:102,-0.097832,0.023924,0.080542
06-07 17:02:38.101+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.101+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:93,2.986647,-1.275326,9.253317
06-07 17:02:38.101+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:89,-10.990000,3.500000,-0.280000
06-07 17:02:38.101+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:107,-0.222121,-0.190654,0.053414
06-07 17:02:38.101+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:38.111+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.111+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.111+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:38:113,654.000000
06-07 17:02:38.111+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.111+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:118,2.766103,-1.660619,9.231510
06-07 17:02:38.111+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:118,-0.285150,-0.050298,0.133726
06-07 17:02:38.111+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.111+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.121+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:123,-0.213640,-0.294687,0.131206
06-07 17:02:38.121+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.121+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:117,-2.590000,5.670000,0.420000
06-07 17:02:38.121+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:123,2.984529,-1.296540,9.251052
06-07 17:02:38.121+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.121+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:128,-0.220677,-0.331367,-0.014172
06-07 17:02:38.121+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.131+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.131+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:133,-0.272506,-0.090362,0.396036
06-07 17:02:38.131+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.131+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:133,2.694318,-1.438086,9.645468
06-07 17:02:38.131+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:138,2.240000,5.180000,0.700000
06-07 17:02:38.141+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:140,2.986779,-1.329251,9.245682
06-07 17:02:38.141+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.141+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.141+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:149,2.966824,-1.347725,9.249432
06-07 17:02:38.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.141+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.151+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.151+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:151,-0.289421,-0.062880,0.190308
06-07 17:02:38.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:154,2.641676,-1.406980,9.451650
06-07 17:02:38.151+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:155,2.931097,-1.344099,9.261342
06-07 17:02:38.151+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.161+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:162,2.908748,-1.346230,9.268076
06-07 17:02:38.161+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.161+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:168,-0.243144,-0.036821,0.217073
06-07 17:02:38.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:156,-0.490000,2.940000,-0.210000
06-07 17:02:38.161+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.161+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:169,2.665605,-1.383051,9.485149
06-07 17:02:38.171+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:173,2.896055,-1.350692,9.271401
06-07 17:02:38.171+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:175,-1.960000,0.700000,0.070000
06-07 17:02:38.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.181+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.181+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:191,2.766103,-1.509871,9.437292
06-07 17:02:38.181+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:190,-0.129952,-0.159179,0.165891
06-07 17:02:38.181+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.191+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.191+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:195,-0.140000,0.490000,0.350000
06-07 17:02:38.191+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:196,2.885084,-1.357230,9.273867
06-07 17:02:38.201+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.201+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.211+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.211+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:215,-0.217087,-0.178962,-0.004072
06-07 17:02:38.211+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.221+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:214,0.420000,4.060000,-0.490000
06-07 17:02:38.221+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:220,2.864410,-1.363188,9.279400
06-07 17:02:38.221+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.231+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:220,2.667997,-1.536192,9.269794
06-07 17:02:38.231+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.231+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.231+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.231+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:236,2.586641,-1.411765,9.422935
06-07 17:02:38.231+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:233,2.842644,-1.363791,9.286002
06-07 17:02:38.241+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:236,0.420000,2.100000,0.770000
06-07 17:02:38.241+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:239,-0.277769,-0.048577,0.143536
06-07 17:02:38.241+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.241+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.241+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.251+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:251,2.689533,-1.416551,9.339187
06-07 17:02:38.251+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.251+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:254,-0.350000,3.220000,0.070000
06-07 17:02:38.251+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:258,2.828070,-1.365528,9.290195
06-07 17:02:38.251+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:252,-0.153112,-0.052760,0.053185
06-07 17:02:38.261+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.261+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.261+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:269,2.622534,-1.373480,9.576077
06-07 17:02:38.261+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:269,-1.120000,2.520000,0.140000
06-07 17:02:38.261+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.261+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.271+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:274,-0.205536,-0.007953,0.285881
06-07 17:02:38.271+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:274,2.811349,-1.365824,9.295226
06-07 17:02:38.281+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.281+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.281+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:290,2.629712,-1.581656,9.525827
06-07 17:02:38.281+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:290,0.210000,1.120000,-0.140000
06-07 17:02:38.281+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.291+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.291+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:38.291+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:296,-0.181637,-0.215832,0.230601
06-07 17:02:38.291+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:38:296,82
06-07 17:02:38.291+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:295,2.795633,-1.373501,9.298834
06-07 17:02:38.301+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:38.301+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.311+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.311+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:38:313,654.000000
06-07 17:02:38.311+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.311+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:313,0.630000,0.770000,-0.210000
06-07 17:02:38.311+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.321+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:315,-0.153957,-0.074157,0.104959
06-07 17:02:38.321+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.321+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:319,2.641676,-1.447658,9.403792
06-07 17:02:38.321+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:330,-0.280000,0.350000,0.280000
06-07 17:02:38.331+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.331+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.331+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:336,-0.132431,-0.008198,0.147037
06-07 17:02:38.331+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:326,2.783679,-1.374854,9.302220
06-07 17:02:38.331+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.341+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:337,2.651247,-1.383051,9.449257
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:38.341+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:38.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390958351,000000, pattern:[H:mm][0;m
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:02:38.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:02:38.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:02:38.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:02][0;m
06-07 17:02:38.351+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.351+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.351+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:345,2.774924,-1.375062,9.304805
06-07 17:02:38.351+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.361+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:356,-0.082999,-0.036703,0.089417
06-07 17:02:38.361+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:350,-1.610000,0.770000,0.280000
06-07 17:02:38.361+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:361,2.691926,-1.411765,9.394222
06-07 17:02:38.361+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.361+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.361+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:370,2.622534,-1.509871,9.387043
06-07 17:02:38.361+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:370,-1.610000,2.170000,0.070000
06-07 17:02:38.371+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.371+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:365,2.770824,-1.379237,9.305408
06-07 17:02:38.381+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.381+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.381+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.381+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:389,2.598605,-1.478764,9.343972
06-07 17:02:38.381+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:389,-0.280000,2.100000,-0.350000
06-07 17:02:38.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:377,-0.148290,-0.130634,0.081635
06-07 17:02:38.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.391+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:386,2.760550,-1.387196,9.307279
06-07 17:02:38.391+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.391+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:398,-0.161944,-0.091569,0.036694
06-07 17:02:38.391+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:400,2.748311,-1.390954,9.310339
06-07 17:02:38.401+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.401+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.411+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:414,1.330000,1.540000,-1.260000
06-07 17:02:38.411+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:414,2.653640,-1.495514,9.468399
06-07 17:02:38.411+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.411+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.411+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:420,-0.094671,-0.104560,0.158060
06-07 17:02:38.411+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:420,2.736533,-1.391055,9.313793
06-07 17:02:38.421+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.421+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.421+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:429,2.533999,-1.387837,9.379865
06-07 17:02:38.421+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:429,4.480000,2.590000,-0.770000
06-07 17:02:38.431+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.431+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.431+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:435,2.712827,-1.380606,9.322279
06-07 17:02:38.441+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:436,-0.202534,0.003217,0.066072
06-07 17:02:38.441+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.451+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.451+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.461+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:452,2.800000,2.380000,-0.840000
06-07 17:02:38.461+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.461+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:462,2.632105,-1.299303,9.343972
06-07 17:02:38.471+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.461+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.471+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:473,-2.030000,4.760000,-0.630000
06-07 17:02:38.471+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:457,2.699525,-1.369902,9.327718
06-07 17:02:38.471+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.471+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:479,-0.080722,0.081303,0.021693
06-07 17:02:38.471+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.481+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:477,2.658426,-1.265803,9.233903
06-07 17:02:38.481+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.481+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:481,2.693755,-1.367336,9.329762
06-07 17:02:38.481+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.481+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:488,-3.990000,3.710000,-0.840000
06-07 17:02:38.481+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.491+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:38.491+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:485,-0.041099,0.104098,-0.093815
06-07 17:02:38.491+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.491+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:38:497,82
06-07 17:02:38.491+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:501,0.005348,-0.022894,-0.033646
06-07 17:02:38.501+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:491,2.699104,-1.390230,9.296116
06-07 17:02:38.501+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:503,2.694835,-1.374470,9.328402
06-07 17:02:38.501+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:38.501+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.511+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.511+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:38:514,659.000000
06-07 17:02:38.511+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:514,-2.100000,4.550000,-1.050000
06-07 17:02:38.511+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.511+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.511+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:517,0.037768,-0.125830,0.022749
06-07 17:02:38.521+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:521,2.732604,-1.500300,9.351151
06-07 17:02:38.521+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.521+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:524,2.691131,-1.381622,9.328415
06-07 17:02:38.521+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.521+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:528,-0.490000,6.580000,-1.610000
06-07 17:02:38.521+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.531+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.531+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:531,2.677627,-1.386635,9.331556
06-07 17:02:38.531+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:535,2.612962,-1.521835,9.159724
06-07 17:02:38.531+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:534,-0.078169,-0.140213,-0.168691
06-07 17:02:38.541+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.541+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.551+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.551+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.551+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:555,-0.088593,-0.156736,-0.033048
06-07 17:02:38.551+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:552,2.589034,-1.543371,9.298509
06-07 17:02:38.551+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:556,2.660032,-1.392301,9.335744
06-07 17:02:38.551+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:551,-1.050000,7.700000,-0.980000
06-07 17:02:38.561+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.561+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.571+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.571+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:571,2.569891,-1.452443,9.274581
06-07 17:02:38.571+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.571+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:576,-0.090140,-0.060143,-0.061163
06-07 17:02:38.571+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:576,2.641391,-1.394903,9.340647
06-07 17:02:38.571+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:571,-2.100000,9.520000,-1.190000
06-07 17:02:38.581+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.581+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.581+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:589,2.474179,-1.445265,9.463614
06-07 17:02:38.581+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:589,-0.980000,10.710000,-1.820000
06-07 17:02:38.581+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.581+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.591+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:593,2.612743,-1.393027,9.348981
06-07 17:02:38.591+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:594,-0.167212,-0.050361,0.122967
06-07 17:02:38.601+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.601+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.611+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.611+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:614,0.490000,9.660000,-3.780000
06-07 17:02:38.611+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:614,2.428715,-1.674976,9.554541
06-07 17:02:38.611+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.621+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.621+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:622,-0.184028,-0.281949,0.205560
06-07 17:02:38.661+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.661+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.681+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:630,2.371287,-1.507478,9.487542
06-07 17:02:38.681+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:619,2.582177,-1.397724,9.356769
06-07 17:02:38.691+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:38.701+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:38.741+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:38:699,82
06-07 17:02:38.741+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:38:714,671.000000
06-07 17:02:38.751+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:670,1.330000,10.850000,-3.010000
06-07 17:02:38.751+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.781+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:789,2.547226,-1.393347,9.366996
06-07 17:02:38.781+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.781+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.791+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:795,-0.560000,10.010000,-1.820000
06-07 17:02:38.791+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:795,2.404787,-1.349552,9.583255
06-07 17:02:38.791+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:675,-0.210889,-0.109754,0.130774
06-07 17:02:38.801+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.801+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.801+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.811+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.821+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:806,-0.142440,0.043795,0.216259
06-07 17:02:38.821+0200 W/LOCATION(14870): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:02:38.821+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:820,2.519727,-1.385890,9.375536
06-07 17:02:38.831+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.831+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:836,2.491241,-1.374987,9.384748
06-07 17:02:38.831+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.831+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.841+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:822,2.342573,-1.275374,9.485149
06-07 17:02:38.841+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.841+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:847,2.328217,-1.009771,9.528220
06-07 17:02:38.851+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:824,0.210000,9.520000,-1.120000
06-07 17:02:38.851+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.851+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:843,-0.177153,0.110516,0.109613
06-07 17:02:38.851+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.861+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:843,2.460233,-1.348049,9.396830
06-07 17:02:38.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:871,2.225325,-1.205983,9.568897
06-07 17:02:38.861+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.871+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.871+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:857,2.450000,9.380000,0.490000
06-07 17:02:38.871+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:876,2.427315,-1.335835,9.407129
06-07 17:02:38.871+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:864,-0.163025,0.365216,0.143472
06-07 17:02:38.871+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.881+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:884,2.390096,-1.329859,9.417500
06-07 17:02:38.881+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.881+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.891+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:38.891+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:38:898,82
06-07 17:02:38.891+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:894,2.354901,-1.329784,9.426373
06-07 17:02:38.901+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.901+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.901+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:906,-0.234909,0.142066,0.172068
06-07 17:02:38.901+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:907,2.324950,-1.330674,9.433679
06-07 17:02:38.901+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:890,0.770000,8.540000,1.890000
06-07 17:02:38.901+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.901+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:38.911+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:913,2.298629,-1.325330,9.440879
06-07 17:02:38.911+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:38:914,687.000000
06-07 17:02:38.911+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.911+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:921,2.278042,-1.322821,9.446219
06-07 17:02:38.921+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.921+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.921+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:874,2.158326,-1.347159,9.741181
06-07 17:02:38.921+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.921+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:928,2.258162,-1.313792,9.452250
06-07 17:02:38.921+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.931+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.931+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:927,1.050000,7.910000,2.800000
06-07 17:02:38.931+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.931+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:936,2.238727,-1.293979,9.459604
06-07 17:02:38.931+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:934,-0.268989,-0.011324,0.334052
06-07 17:02:38.931+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.931+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.941+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:930,2.143969,-1.500300,9.695717
06-07 17:02:38.941+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.941+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:944,2.224187,-1.274298,9.465703
06-07 17:02:38.941+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.951+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:953,2.219507,-1.261253,9.468549
06-07 17:02:38.951+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:938,1.960000,6.720000,2.450000
06-07 17:02:38.951+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.951+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:948,2.158326,-1.560120,9.655040
06-07 17:02:38.961+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.961+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:961,2.219752,-1.250522,9.469914
06-07 17:02:38.961+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.961+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:944,-0.246127,-0.170441,0.278217
06-07 17:02:38.961+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.971+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:973,3.360000,4.480000,2.310000
06-07 17:02:38.971+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:967,2.182254,-1.459622,9.789038
06-07 17:02:38.981+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:984,-0.196575,-0.230336,0.228667
06-07 17:02:38.981+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:38.991+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:38:969,2.209119,-1.236772,9.474206
06-07 17:02:38.991+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:38.991+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:38.991+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:38:987,2.165504,-1.517050,9.789038
06-07 17:02:38.991+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:38.991+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:0,2.193068,-1.215540,9.480680
06-07 17:02:39.001+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.001+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:38:999,4.060000,3.150000,2.030000
06-07 17:02:39.001+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.001+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:8,2.185410,-1.189750,9.485719
06-07 17:02:39.011+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.011+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:16,2.178177,-1.166794,9.490233
06-07 17:02:39.011+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.011+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:38:994,-0.142696,-0.128947,0.355359
06-07 17:02:39.021+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:3,2.136791,-1.450050,9.607183
06-07 17:02:39.021+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.021+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:23,2.167288,-1.142509,9.495679
06-07 17:02:39.021+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.021+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.031+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:32,2.156713,-1.120291,9.500732
06-07 17:02:39.031+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:10,4.690000,0.280000,1.540000
06-07 17:02:39.031+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.031+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:27,2.210968,-1.366302,9.592826
06-07 17:02:39.031+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.031+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:32,-0.133124,-0.191720,0.348159
06-07 17:02:39.041+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:41,7.420000,-1.260000,1.120000
06-07 17:02:39.041+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.041+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.041+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.051+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:52,2.149012,-1.096782,9.505219
06-07 17:02:39.051+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:43,2.222932,-1.275374,9.554541
06-07 17:02:39.051+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.051+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:53,-0.141251,-0.127229,0.160964
06-07 17:02:39.051+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.061+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:59,2.254039,-1.227518,9.492328
06-07 17:02:39.061+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.061+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:50,11.130000,-1.960000,0.630000
06-07 17:02:39.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:02:39.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:02:39.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:02:39.071+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.071+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.071+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:71,2.309074,-1.189233,9.504292
06-07 17:02:39.071+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.071+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:64,-0.047194,-0.052510,0.140575
06-07 17:02:39.081+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.081+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:81,2.156596,-1.086390,9.504696
06-07 17:02:39.081+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:78,9.450000,-1.750000,0.210000
06-07 17:02:39.091+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.091+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 17:02:39.091+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:02:39:97,82
06-07 17:02:39.091+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:96,2.173824,-1.089036,9.500467
06-07 17:02:39.091+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.101+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:83,2.230111,-1.251446,9.631111
06-07 17:02:39.101+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:88,-0.015795,0.018604,0.094936
06-07 17:02:39.101+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:02:39.111+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.111+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:02:39:114,700.000000
06-07 17:02:39.111+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:118,2.178148,-1.087843,9.499614
06-07 17:02:39.111+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.121+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.121+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.121+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:126,2.203789,-1.201197,9.611969
06-07 17:02:39.121+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:105,5.740000,-1.960000,-0.070000
06-07 17:02:39.131+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.131+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:130,2.172457,-1.071672,9.502754
06-07 17:02:39.131+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:129,0.029852,0.046780,0.026625
06-07 17:02:39.131+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:141,3.780000,-1.400000,-0.280000
06-07 17:02:39.141+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.141+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.141+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.151+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:146,2.316252,-1.083949,9.585647
06-07 17:02:39.151+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.161+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:153,0.089566,0.072020,0.035743
06-07 17:02:39.161+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:02:39:167,2.304288,-1.088734,9.573684
06-07 17:02:39.171+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:155,2.166592,-1.047955,9.506738
06-07 17:02:39.171+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.171+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.191+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:02:39:162,6.300000,-0.560000,-0.770000
06-07 17:02:39.191+0200 I/gyroscope(14786): es.ugr.frailty.gyroscope - capturing data
06-07 17:02:39.221+0200 I/accelerometer(14888): es.ugr.frailty.accelerometer - capturing data
06-07 17:02:39.251+0200 I/gravity (14730): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:02:39:198,2.169057,-1.030143,9.508121
06-07 17:02:39.251+0200 I/gravity (14730): es.ugr.frailty.gravity - capturing data
06-07 17:02:39.261+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:02:39:180,0.010359,-0.000924,0.161197
06-07 17:02:39.261+0200 I/linearacceleration(14803): es.ugr.frailty.linearacceleration - capturing data
06-07 17:02:39.291+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11148706c6f63152838375
