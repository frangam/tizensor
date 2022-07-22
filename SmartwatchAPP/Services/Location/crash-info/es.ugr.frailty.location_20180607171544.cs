S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18878
Date: 2018-06-07 17:15:44+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf727a52d, r5   = 0xf751ef98
r6   = 0xfff7edc0, r7   = 0xfff7ec70
r8   = 0xf751bc18, r9   = 0x00000000
r10  = 0xfff7ed4c, fp   = 0xfff7edc0
ip   = 0x00000001, sp   = 0xfff7ec48
lr   = 0xf727a539, pc   = 0xf72e3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    254160 KB
Buffers:      6268 KB
Cached:      53736 KB
VmPeak:      53636 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11768 KB
VmRSS:       11764 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18878 TID = 18878
18878 18885 

Maps Information
f4145000 f4944000 rw-p [stack:18885]
f494b000 f494d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4955000 f4959000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4962000 f4964000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f496c000 f496f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f497e000 f4983000 r-xp /usr/lib/libsystem.so.0.0.0
f498e000 f4991000 r-xp /lib/libattr.so.1.1.0
f4999000 f49a9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49b1000 f49ba000 r-xp /usr/lib/libedbus.so.1.7.99
f49c2000 f49c3000 r-xp /usr/lib/libresponse.so.0.2.96
f49cc000 f49d1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6273000 f6379000 r-xp /usr/lib/libicuuc.so.57.1
f638f000 f6517000 r-xp /usr/lib/libicui18n.so.57.1
f6527000 f6534000 r-xp /usr/lib/libail.so.0.1.0
f653d000 f6544000 r-xp /usr/lib/libminizip.so.1.0.0
f654d000 f66f6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6716000 f675d000 r-xp /usr/lib/libssl.so.1.0.0
f6769000 f676b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6773000 f677a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6783000 f678a000 r-xp /lib/libcrypt-2.13.so
f67bb000 f67be000 r-xp /lib/libcap.so.2.21
f67c6000 f67c8000 r-xp /usr/lib/libiri.so
f67d0000 f6819000 r-xp /usr/lib/libmdm.so.1.2.69
f6821000 f6827000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f682f000 f6852000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f685c000 f685e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6866000 f6883000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f688c000 f6890000 r-xp /usr/lib/libsmack.so.1.0.0
f6899000 f68b2000 r-xp /usr/lib/libnetwork.so.0.0.0
f68bb000 f68c3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68cb000 f68d1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68da000 f68dc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68e5000 f68f5000 r-xp /lib/libresolv-2.13.so
f68f9000 f6911000 r-xp /usr/lib/liblzma.so.5.0.3
f691a000 f691c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6924000 f693e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6946000 f6975000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f697e000 f698d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6997000 f69a1000 r-xp /usr/lib/libsensord-shared.so
f69aa000 f6a7d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a88000 f6a9e000 r-xp /lib/libz.so.1.2.5
f6aa6000 f6aab000 r-xp /usr/lib/libffi.so.5.0.10
f6ab3000 f6ab4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6abc000 f6acc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ad4000 f6aed000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6af5000 f6af7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6aff000 f6b74000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b7e000 f6b84000 r-xp /lib/librt-2.13.so
f6b8d000 f6bab000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bb5000 f6bb6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bbe000 f6be1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6be9000 f6bee000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bf6000 f6c20000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c29000 f6c40000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c48000 f6cb1000 r-xp /lib/libm-2.13.so
f6cba000 f6d4e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d61000 f6d66000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d6e000 f6d75000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d7d000 f6da7000 r-xp /usr/lib/libsensor.so.1.9.6
f6db0000 f6e7c000 r-xp /usr/lib/libxml2.so.2.7.8
f6e89000 f6e8b000 r-xp /usr/lib/libiniparser.so.0
f6e94000 f6e9a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ea3000 f6f73000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f74000 f6fa8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fb1000 f6fed000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ff5000 f6ff8000 r-xp /usr/lib/libbundle.so.0.1.22
f7000000 f7006000 r-xp /usr/lib/libappsvc.so.0.1.0
f700e000 f704f000 r-xp /usr/lib/libeina.so.1.7.99
f7058000 f706f000 r-xp /usr/lib/libecore.so.1.7.99
f7086000 f708f000 r-xp /usr/lib/libvconf.so.0.2.45
f7097000 f70ab000 r-xp /lib/libpthread-2.13.so
f70b6000 f70c3000 r-xp /usr/lib/libaul.so.0.1.0
f70cd000 f70cf000 r-xp /lib/libdl-2.13.so
f70d8000 f70e3000 r-xp /lib/libunwind.so.8.0.1
f7110000 f7118000 r-xp /lib/libgcc_s-4.6.so.1
f7119000 f723d000 r-xp /lib/libc-2.13.so
f724b000 f724d000 r-xp /usr/lib/libdlog.so.0.0.0
f7255000 f7261000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f726a000 f726f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7277000 f7286000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f728e000 f7292000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f729b000 f729e000 r-xp /usr/lib/libappcore-agent.so.1.1
f72a6000 f72a8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72b0000 f72b4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72bc000 f72d9000 r-xp /lib/ld-2.13.so
f72e2000 f72e5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72e5000 f72e9000 r-xp /usr/lib/libsys-assert.so
f74eb000 f7579000 rw-p [heap]
fff60000 fff81000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18878)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72e3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf727a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f813f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f7fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f8be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f91be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f91dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fc675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fc11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f7fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f8be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f91be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f91dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fc3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fc4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fcbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49631fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4956171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a29663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ed6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ed87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7068ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7063b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70645a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7064879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf729c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf729c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72e35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf713085c) [/lib/libc.so.6] + 0x1785c
29: (0xf72e2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:501,0.140000,0.070000,0.070000
06-07 17:15:43.501+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.501+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:505,0.305283,-0.087726,9.801504
06-07 17:15:43.501+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.501+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:497,0.038205,-0.033938,0.052197
06-07 17:15:43.501+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.501+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.511+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:506,0.334995,-0.090927,9.853643
06-07 17:15:43.511+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:511,0.070000,0.140000,0.070000
06-07 17:15:43.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.511+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:512,0.307328,-0.090505,9.801415
06-07 17:15:43.511+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.521+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:517,0.000840,0.029651,0.073792
06-07 17:15:43.521+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:525,0.307678,-0.090445,9.801405
06-07 17:15:43.521+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:522,0.070000,0.140000,0.070000
06-07 17:15:43.521+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.521+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.521+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.521+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:521,0.299103,-0.093320,9.868000
06-07 17:15:43.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:532,0.070000,0.070000,0.070000
06-07 17:15:43.531+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.531+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:533,0.307561,-0.090495,9.801408
06-07 17:15:43.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.531+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:532,-0.010646,0.016062,0.068976
06-07 17:15:43.531+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.541+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:540,0.349352,-0.153141,9.865608
06-07 17:15:43.541+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:544,0.070000,0.070000,0.070000
06-07 17:15:43.541+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.541+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.541+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:545,0.308774,-0.091116,9.801364
06-07 17:15:43.551+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:552,0.000185,0.024505,0.076104
06-07 17:15:43.551+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:553,0.070000,0.070000,0.070000
06-07 17:15:43.551+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.551+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.551+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:558,0.325424,-0.093320,9.853643
06-07 17:15:43.551+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.551+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:559,0.309634,-0.092562,9.801324
06-07 17:15:43.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:565,0.070000,0.070000,0.070000
06-07 17:15:43.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.561+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:570,0.070000,0.070000,0.070000
06-07 17:15:43.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.561+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.571+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:575,0.070000,0.070000,0.070000
06-07 17:15:43.571+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.571+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:570,0.029574,-0.003217,0.052143
06-07 17:15:43.571+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.571+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.571+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:581,0.309822,-0.090870,9.801333
06-07 17:15:43.571+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:575,0.315853,-0.095713,9.863215
06-07 17:15:43.581+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:581,-0.070000,0.070000,0.070000
06-07 17:15:43.581+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:582,-0.007032,-0.005666,0.066522
06-07 17:15:43.581+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.581+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:592,0.342174,-0.107677,9.834501
06-07 17:15:43.591+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.591+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:43.591+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.591+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:600,0.309109,-0.091684,9.801349
06-07 17:15:43.591+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.601+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:43:599,948.000000
06-07 17:15:43.601+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:604,-0.070000,0.070000,0.070000
06-07 17:15:43.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:596,0.334995,-0.126820,9.879964
06-07 17:15:43.601+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:596,0.044070,-0.065415,0.064104
06-07 17:15:43.601+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:613,0.313460,-0.055035,9.863215
06-07 17:15:43.611+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.611+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.611+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.611+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:615,0.018096,-0.002815,0.052228
06-07 17:15:43.621+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:43.621+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:43.621+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.621+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:620,0.308138,-0.093294,9.801364
06-07 17:15:43.621+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:622,-0.140000,0.070000,0.070000
06-07 17:15:43.621+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:617,0.294317,-0.105284,9.836893
06-07 17:15:43.621+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:627,0.008174,-0.005267,0.061810
06-07 17:15:43.621+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.631+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.631+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.631+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.631+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:637,0.034613,-0.017182,0.033093
06-07 17:15:43.641+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.641+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:641,-0.140000,0.070000,0.070000
06-07 17:15:43.641+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:639,0.310466,-0.094892,9.801275
06-07 17:15:43.641+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:635,0.284746,-0.119641,9.865608
06-07 17:15:43.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.651+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:648,0.026221,-0.035704,0.078600
06-07 17:15:43.651+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.651+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:660,0.310002,-0.096208,9.801277
06-07 17:15:43.651+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.651+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.661+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:664,0.003826,0.037528,0.061892
06-07 17:15:43.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:664,-0.140000,0.070000,0.070000
06-07 17:15:43.661+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.661+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:656,0.349352,-0.122034,9.844072
06-07 17:15:43.671+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.671+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.671+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:680,0.311659,-0.095971,9.801227
06-07 17:15:43.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.671+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:672,-0.015504,-0.014414,0.035560
06-07 17:15:43.671+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:684,-0.070000,0.070000,0.070000
06-07 17:15:43.681+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:677,0.296710,-0.117248,9.879964
06-07 17:15:43.681+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.681+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:685,-0.024363,-0.027957,0.064260
06-07 17:15:43.681+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.691+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:693,0.346959,-0.088534,9.863215
06-07 17:15:43.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.691+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.691+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:695,0.041214,-0.028740,0.042708
06-07 17:15:43.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:701,-0.070000,0.070000,0.070000
06-07 17:15:43.701+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:699,0.311011,-0.097083,9.801236
06-07 17:15:43.691+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.701+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.701+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:709,0.299103,-0.117248,9.875179
06-07 17:15:43.711+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:709,-0.013756,-0.022356,0.078689
06-07 17:15:43.711+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.711+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.711+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.711+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:719,0.311905,-0.098686,9.801191
06-07 17:15:43.711+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.721+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:724,0.327817,-0.129212,9.848858
06-07 17:15:43.721+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:720,-0.070000,0.070000,0.070000
06-07 17:15:43.721+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:717,0.036957,0.007673,0.061938
06-07 17:15:43.721+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.731+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:733,-0.012556,-0.021277,0.073953
06-07 17:15:43.731+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.731+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:740,0.311371,-0.097730,9.801218
06-07 17:15:43.731+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.741+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:744,0.299103,-0.076570,9.846465
06-07 17:15:43.741+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.741+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:750,-0.070000,0.070000,0.070000
06-07 17:15:43.741+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.751+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.751+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:760,0.310851,-0.096970,9.801243
06-07 17:15:43.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.761+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:764,0.311067,-0.086142,9.877571
06-07 17:15:43.761+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:754,0.016806,-0.032129,0.047622
06-07 17:15:43.761+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.761+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.771+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:773,0.070000,0.070000,0.070000
06-07 17:15:43.771+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.771+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:779,0.311806,-0.095641,9.801225
06-07 17:15:43.771+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:775,-0.012802,0.022115,0.045274
06-07 17:15:43.771+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.781+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.781+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:783,0.337388,-0.071785,9.882358
06-07 17:15:43.781+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.781+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:789,0.070000,-0.070000,0.070000
06-07 17:15:43.791+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:788,-0.000304,0.011588,0.076353
06-07 17:15:43.791+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.791+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:43.791+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.791+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:43:800,950.000000
06-07 17:15:43.801+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.801+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:797,0.026537,0.025185,0.081115
06-07 17:15:43.801+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.801+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:803,0.311313,-0.091971,9.801276
06-07 17:15:43.801+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:807,-0.003132,0.071712,0.112240
06-07 17:15:43.801+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:806,0.308674,-0.023928,9.913465
06-07 17:15:43.801+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.811+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:814,0.070000,0.070000,0.070000
06-07 17:15:43.811+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.811+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.811+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:819,0.311044,-0.092514,9.801279
06-07 17:15:43.811+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.821+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:43.821+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:43.821+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:823,0.004539,-0.015706,0.054760
06-07 17:15:43.821+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.821+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:819,0.315853,-0.107677,9.856036
06-07 17:15:43.831+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.831+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:839,0.310988,-0.094562,9.801262
06-07 17:15:43.831+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.831+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:832,0.070000,0.070000,0.070000
06-07 17:15:43.841+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.841+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.841+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:845,0.318245,-0.141177,9.882358
06-07 17:15:43.841+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:844,0.007202,-0.048662,0.081079
06-07 17:15:43.841+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:847,0.070000,0.070000,0.070000
06-07 17:15:43.851+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.851+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:859,0.311660,-0.095163,9.801234
06-07 17:15:43.851+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.861+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.861+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.861+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:866,-0.070000,0.070000,0.070000
06-07 17:15:43.861+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:865,0.325424,-0.105284,9.875179
06-07 17:15:43.861+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:863,0.014436,-0.010722,0.073917
06-07 17:15:43.871+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.871+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:879,0.312733,-0.095947,9.801192
06-07 17:15:43.871+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.881+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.881+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.881+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:885,0.334995,-0.110070,9.894321
06-07 17:15:43.881+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:883,0.023335,-0.014907,0.093087
06-07 17:15:43.881+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:886,-0.070000,0.070000,0.070000
06-07 17:15:43.891+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.891+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:899,0.003119,-0.030873,0.085951
06-07 17:15:43.891+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.891+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.901+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.901+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:905,0.315853,-0.126820,9.887143
06-07 17:15:43.901+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:903,0.312873,-0.097481,9.801173
06-07 17:15:43.901+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:905,-0.070000,0.070000,0.070000
06-07 17:15:43.911+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.911+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.911+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.921+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.921+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:926,0.312175,-0.099307,9.801177
06-07 17:15:43.921+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:920,-0.004199,-0.043695,0.093148
06-07 17:15:43.921+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:923,0.070000,0.070000,0.070000
06-07 17:15:43.931+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:922,0.308674,-0.141177,9.894321
06-07 17:15:43.931+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.931+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:939,0.006071,-0.025120,0.090752
06-07 17:15:43.931+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.931+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.941+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.941+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:945,0.318245,-0.124427,9.891929
06-07 17:15:43.941+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:943,-0.070000,0.070000,0.070000
06-07 17:15:43.941+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:945,0.312431,-0.100567,9.801156
06-07 17:15:43.951+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.951+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.951+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:959,-0.027685,0.002461,0.050096
06-07 17:15:43.951+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.951+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.951+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:959,0.284746,-0.098106,9.851252
06-07 17:15:43.961+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:969,-0.070000,0.070000,0.070000
06-07 17:15:43.971+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:966,0.311087,-0.100566,9.801199
06-07 17:15:43.971+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:43.971+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:43.981+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:43.981+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:43.981+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:43:984,0.315853,-0.095713,9.822537
06-07 17:15:43.991+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:43:981,0.004766,0.004853,0.021338
06-07 17:15:43.991+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:43.991+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:43:989,-0.070000,0.070000,0.070000
06-07 17:15:43.991+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.001+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:43:989,0.311358,-0.100456,9.801191
06-07 17:15:44.001+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:44:0,952.000000
06-07 17:15:44.001+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.001+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.001+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:9,0.342174,-0.093320,9.829715
06-07 17:15:44.001+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:9,0.313108,-0.100302,9.801137
06-07 17:15:44.001+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.001+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:3,0.030816,0.007136,0.028523
06-07 17:15:44.011+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.011+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.011+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:21,-0.011612,-0.045660,0.033364
06-07 17:15:44.011+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:15,-0.070000,-0.070000,0.070000
06-07 17:15:44.021+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:44.021+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:44.021+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.021+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.021+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:20,0.301496,-0.145962,9.834501
06-07 17:15:44.021+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:29,0.312887,-0.102620,9.801120
06-07 17:15:44.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:32,-0.070000,-0.070000,0.140000
06-07 17:15:44.031+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.031+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.031+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:39,-0.018569,0.026050,0.054916
06-07 17:15:44.031+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:39,0.294317,-0.076570,9.856036
06-07 17:15:44.031+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.041+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:45,0.312082,-0.101468,9.801158
06-07 17:15:44.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:50,-0.070000,0.070000,0.140000
06-07 17:15:44.051+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.051+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:15:44.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:15:44.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:15:44.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.061+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:68,-0.070000,0.070000,0.070000
06-07 17:15:44.061+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:60,-0.022550,-0.001423,0.042914
06-07 17:15:44.071+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:63,0.310985,-0.101654,9.801190
06-07 17:15:44.071+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.071+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:79,-0.035810,0.017905,0.073989
06-07 17:15:44.071+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.081+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:85,0.309298,-0.100890,9.801252
06-07 17:15:44.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.081+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:67,0.289532,-0.102891,9.844072
06-07 17:15:44.081+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:92,-0.070000,0.070000,0.070000
06-07 17:15:44.091+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.091+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:100,-0.000624,-0.006787,0.095462
06-07 17:15:44.091+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.101+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:95,0.275175,-0.083749,9.875179
06-07 17:15:44.101+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:107,0.309193,-0.101294,9.801251
06-07 17:15:44.101+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.101+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.111+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.111+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:120,0.042552,-0.001597,0.088284
06-07 17:15:44.111+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:113,-0.070000,0.070000,0.070000
06-07 17:15:44.121+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:116,0.308674,-0.107677,9.896714
06-07 17:15:44.121+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.121+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:128,0.311088,-0.101478,9.801189
06-07 17:15:44.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.121+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.131+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.131+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:140,-0.002414,-0.001414,0.050062
06-07 17:15:44.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:134,-0.070000,0.070000,0.140000
06-07 17:15:44.141+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.171+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.171+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:136,0.351745,-0.102891,9.889536
06-07 17:15:44.181+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.181+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.191+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:149,0.310968,-0.101650,9.801191
06-07 17:15:44.191+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:44.201+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.201+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:193,0.016848,-0.006027,0.042881
06-07 17:15:44.201+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:182,-0.070000,0.070000,0.070000
06-07 17:15:44.201+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.201+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:194,0.308674,-0.102891,9.851252
06-07 17:15:44.211+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.211+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.211+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:44:203,956.000000
06-07 17:15:44.221+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:44.221+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:44.231+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:211,0.311778,-0.102044,9.801162
06-07 17:15:44.241+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.241+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:222,-0.070000,0.070000,0.070000
06-07 17:15:44.241+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:225,0.327817,-0.107677,9.844072
06-07 17:15:44.251+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:227,-0.010283,0.030259,0.093160
06-07 17:15:44.251+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.251+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.251+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.261+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:265,0.301496,-0.071785,9.894321
06-07 17:15:44.261+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:264,-0.070000,0.070000,0.070000
06-07 17:15:44.261+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:252,0.311338,-0.100678,9.801189
06-07 17:15:44.271+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.271+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:269,0.021264,0.016929,0.062026
06-07 17:15:44.281+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.281+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.281+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.291+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:281,0.312300,-0.099997,9.801166
06-07 17:15:44.291+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:291,0.332602,-0.083749,9.863215
06-07 17:15:44.301+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:293,0.032267,0.021034,0.050086
06-07 17:15:44.301+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.301+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:309,0.313756,-0.099144,9.801128
06-07 17:15:44.301+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.311+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.311+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:293,-0.070000,0.070000,0.140000
06-07 17:15:44.311+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.321+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:322,-0.012261,0.034538,0.040551
06-07 17:15:44.321+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:317,0.344566,-0.078963,9.851252
06-07 17:15:44.321+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.331+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:335,0.313584,-0.097744,9.801147
06-07 17:15:44.331+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:323,-0.070000,0.070000,0.140000
06-07 17:15:44.341+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.341+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.341+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.361+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.371+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:350,0.301496,-0.064606,9.841680
06-07 17:15:44.371+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:350,0.016626,-0.017112,0.081210
06-07 17:15:44.371+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:352,-0.140000,0.070000,0.070000
06-07 17:15:44.391+0200 W/LOCATION(18878): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:15:44.391+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:44.401+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:44:403,957.000000
06-07 17:15:44.401+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.401+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.411+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:375,0.313858,-0.098328,9.801133
06-07 17:15:44.411+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:389,-0.009970,-0.002171,0.081224
06-07 17:15:44.421+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:44.421+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:44.441+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.441+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:415,0.330210,-0.114855,9.882358
06-07 17:15:44.441+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:447,0.312841,-0.098221,9.801167
06-07 17:15:44.451+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:416,0.070000,0.070000,0.070000
06-07 17:15:44.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.451+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.471+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.481+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:457,0.000619,0.019258,0.078797
06-07 17:15:44.481+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.491+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:465,0.070000,0.070000,0.070000
06-07 17:15:44.491+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:484,0.313180,-0.097449,9.801164
06-07 17:15:44.501+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:467,0.303888,-0.100499,9.882358
06-07 17:15:44.501+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.501+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.501+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:509,0.313460,-0.078963,9.879964
06-07 17:15:44.511+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.511+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:503,-0.004506,0.001736,0.076407
06-07 17:15:44.511+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.521+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:513,-0.070000,-0.070000,0.070000
06-07 17:15:44.521+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.541+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:525,0.010095,0.040035,0.078793
06-07 17:15:44.541+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:518,0.312937,-0.097462,9.801171
06-07 17:15:44.541+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.551+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:537,-0.070000,0.070000,0.070000
06-07 17:15:44.561+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.561+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:535,0.308674,-0.095713,9.877571
06-07 17:15:44.561+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.571+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:563,0.312789,-0.095341,9.801197
06-07 17:15:44.591+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.591+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:567,0.017420,-0.019515,0.057232
06-07 17:15:44.591+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:44.591+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:581,0.323031,-0.057428,9.879964
06-07 17:15:44.591+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:44:601,958.000000
06-07 17:15:44.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.601+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:585,0.070000,0.140000,0.070000
06-07 17:15:44.601+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.611+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:598,0.313485,-0.096334,9.801165
06-07 17:15:44.621+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:44.621+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:44.631+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:604,-0.004811,-0.018522,0.069229
06-07 17:15:44.631+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.641+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:615,0.330210,-0.114855,9.858429
06-07 17:15:44.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:620,-0.070000,0.140000,0.140000
06-07 17:15:44.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:668,-0.070000,0.140000,0.140000
06-07 17:15:44.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.671+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:644,-0.009165,-0.012784,0.090759
06-07 17:15:44.671+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.671+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:646,0.313053,-0.097286,9.801169
06-07 17:15:44.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:674,0.140000,0.070000,0.070000
06-07 17:15:44.671+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:15:44.671+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.671+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:44:662,0.308674,-0.114855,9.870394
06-07 17:15:44.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:684,0.070000,0.140000,0.070000
06-07 17:15:44.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.691+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:44.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:691,0.070000,0.070000,0.070000
06-07 17:15:44.691+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.701+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:44:701,0.070000,0.070000,0.070000
06-07 17:15:44.701+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:44:681,0.311794,-0.097524,9.801207
06-07 17:15:44.701+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:44.701+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:44:678,0.035165,-0.010153,0.097900
06-07 17:15:44.701+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:44.711+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11188786c6f63152838454
