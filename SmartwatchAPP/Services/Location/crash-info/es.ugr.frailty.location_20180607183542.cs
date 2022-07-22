S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 28634
Date: 2018-06-07 18:35:42+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf71ee52d, r5   = 0xf79d3f98
r6   = 0xff9b5ca8, r7   = 0xff9b5b58
r8   = 0xf79d0c18, r9   = 0x00000000
r10  = 0xff9b5c34, fp   = 0xff9b5ca8
ip   = 0x00000001, sp   = 0xff9b5b30
lr   = 0xf71ee539, pc   = 0xf7257228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    278040 KB
Buffers:      6912 KB
Cached:     100460 KB
VmPeak:      53460 KB
VmSize:      53428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11888 KB
VmRSS:       11884 KB
VmData:      11156 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28634 TID = 28634
28634 28703 

Maps Information
f40b9000 f48b8000 rw-p [stack:28703]
f48bf000 f48c1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f48c9000 f48cd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f48d6000 f48d8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f48e0000 f48e3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f48f2000 f48f7000 r-xp /usr/lib/libsystem.so.0.0.0
f4902000 f4905000 r-xp /lib/libattr.so.1.1.0
f490d000 f491d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4925000 f492e000 r-xp /usr/lib/libedbus.so.1.7.99
f4936000 f4937000 r-xp /usr/lib/libresponse.so.0.2.96
f4940000 f4945000 r-xp /usr/lib/libproc-stat.so.0.2.96
f61e7000 f62ed000 r-xp /usr/lib/libicuuc.so.57.1
f6303000 f648b000 r-xp /usr/lib/libicui18n.so.57.1
f649b000 f64a8000 r-xp /usr/lib/libail.so.0.1.0
f64b1000 f64b8000 r-xp /usr/lib/libminizip.so.1.0.0
f64c1000 f666a000 r-xp /usr/lib/libcrypto.so.1.0.0
f668a000 f66d1000 r-xp /usr/lib/libssl.so.1.0.0
f66dd000 f66df000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f66e7000 f66ee000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f66f7000 f66fe000 r-xp /lib/libcrypt-2.13.so
f672f000 f6732000 r-xp /lib/libcap.so.2.21
f673a000 f673c000 r-xp /usr/lib/libiri.so
f6744000 f678d000 r-xp /usr/lib/libmdm.so.1.2.69
f6795000 f679b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67a3000 f67c6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f67d0000 f67d2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67da000 f67f7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6800000 f6804000 r-xp /usr/lib/libsmack.so.1.0.0
f680d000 f6826000 r-xp /usr/lib/libnetwork.so.0.0.0
f682f000 f6837000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f683f000 f6845000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f684e000 f6850000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6859000 f6869000 r-xp /lib/libresolv-2.13.so
f686d000 f6885000 r-xp /usr/lib/liblzma.so.5.0.3
f688e000 f6890000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6898000 f68b2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68ba000 f68e9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68f2000 f6901000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f690b000 f6915000 r-xp /usr/lib/libsensord-shared.so
f691e000 f69f1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69fc000 f6a12000 r-xp /lib/libz.so.1.2.5
f6a1a000 f6a1f000 r-xp /usr/lib/libffi.so.5.0.10
f6a27000 f6a28000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a30000 f6a40000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a48000 f6a61000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6a69000 f6a6b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a73000 f6ae8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6af2000 f6af8000 r-xp /lib/librt-2.13.so
f6b01000 f6b1f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b29000 f6b2a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b32000 f6b55000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b5d000 f6b62000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b6a000 f6b94000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b9d000 f6bb4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bbc000 f6c25000 r-xp /lib/libm-2.13.so
f6c2e000 f6cc2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6cd5000 f6cda000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ce2000 f6ce9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6cf1000 f6d1b000 r-xp /usr/lib/libsensor.so.1.9.6
f6d24000 f6df0000 r-xp /usr/lib/libxml2.so.2.7.8
f6dfd000 f6dff000 r-xp /usr/lib/libiniparser.so.0
f6e08000 f6e0e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e17000 f6ee7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ee8000 f6f1c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f25000 f6f61000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6f69000 f6f6c000 r-xp /usr/lib/libbundle.so.0.1.22
f6f74000 f6f7a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6f82000 f6fc3000 r-xp /usr/lib/libeina.so.1.7.99
f6fcc000 f6fe3000 r-xp /usr/lib/libecore.so.1.7.99
f6ffa000 f7003000 r-xp /usr/lib/libvconf.so.0.2.45
f700b000 f701f000 r-xp /lib/libpthread-2.13.so
f702a000 f7037000 r-xp /usr/lib/libaul.so.0.1.0
f7041000 f7043000 r-xp /lib/libdl-2.13.so
f704c000 f7057000 r-xp /lib/libunwind.so.8.0.1
f7084000 f708c000 r-xp /lib/libgcc_s-4.6.so.1
f708d000 f71b1000 r-xp /lib/libc-2.13.so
f71bf000 f71c1000 r-xp /usr/lib/libdlog.so.0.0.0
f71c9000 f71d5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f71de000 f71e3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f71eb000 f71fa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7202000 f7206000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f720f000 f7212000 r-xp /usr/lib/libappcore-agent.so.1.1
f721a000 f721c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7224000 f7228000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7230000 f724d000 r-xp /lib/ld-2.13.so
f7256000 f7259000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7259000 f725d000 r-xp /usr/lib/libsys-assert.so
f79a0000 f7a0c000 rw-p [heap]
ff997000 ff9b8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28634)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7257228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf71ee539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6ef53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6ef3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6effe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f05be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f05dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f3a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f351f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6ef3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6effe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f05be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f05dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f37e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f38017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f3c8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf72260bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf48ca171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf699d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e4afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e4c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6fdcca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6fd7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6fd85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6fd8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7210183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72107fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72575c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70a485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7256f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
5:42.041+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.041+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.041+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:46,0.070000,0.070000,0.070000
06-07 18:35:42.041+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.041+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:46,0.309328,-0.078645,9.801455
06-07 18:35:42.051+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:47,0.008992,-0.000245,-0.000455
06-07 18:35:42.051+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:51,0.318245,-0.078963,9.801002
06-07 18:35:42.051+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.051+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.061+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.061+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:64,0.070000,0.070000,0.070000
06-07 18:35:42.061+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.061+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:66,-0.003047,-0.033817,-0.024382
06-07 18:35:42.061+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:64,0.309288,-0.078492,9.801457
06-07 18:35:42.061+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:70,0.306281,-0.112463,9.777073
06-07 18:35:42.071+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.071+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.081+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.081+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:85,0.070000,0.070000,0.070000
06-07 18:35:42.081+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.091+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:92,0.318245,-0.066999,9.827322
06-07 18:35:42.091+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:89,0.008958,0.011493,0.025865
06-07 18:35:42.091+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:85,0.308809,-0.079947,9.801460
06-07 18:35:42.091+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.091+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.101+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.101+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:105,0.070000,0.070000,0.070000
06-07 18:35:42.101+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.111+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:105,0.308731,-0.079154,9.801470
06-07 18:35:42.111+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:110,-0.002527,-0.027730,0.066540
06-07 18:35:42.111+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.121+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.121+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.121+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:125,0.070000,0.070000,0.070000
06-07 18:35:42.121+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:114,0.306281,-0.107677,9.868000
06-07 18:35:42.131+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.131+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:126,0.308113,-0.080308,9.801479
06-07 18:35:42.131+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:128,-0.012021,-0.016559,0.054566
06-07 18:35:42.131+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:136,0.296710,-0.095713,9.856036
06-07 18:35:42.141+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.141+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.141+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.141+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:146,0.070000,0.070000,0.070000
06-07 18:35:42.141+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.141+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:146,0.307036,-0.080857,9.801509
06-07 18:35:42.151+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:148,-0.013796,-0.024976,0.018665
06-07 18:35:42.151+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:152,0.294317,-0.105284,9.820145
06-07 18:35:42.151+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.151+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.161+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.161+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:165,0.140000,0.070000,0.070000
06-07 18:35:42.161+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.171+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:164,0.305682,-0.081701,9.801544
06-07 18:35:42.171+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:169,0.032745,-0.024427,0.009065
06-07 18:35:42.171+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:171,0.339781,-0.105284,9.810574
06-07 18:35:42.171+0200 I/light   (28675): es.ugr.frailty.light - capturing data
06-07 18:35:42.171+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.181+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:185,0.070000,0.070000,0.070000
06-07 18:35:42.181+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.181+0200 I/light   (28675): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:42:185,1574.000000
06-07 18:35:42.181+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.191+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.191+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:191,0.306281,-0.038285,9.827322
06-07 18:35:42.191+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:192,0.306946,-0.082629,9.801497
06-07 18:35:42.191+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:196,0.000599,0.043416,0.025778
06-07 18:35:42.191+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.191+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.191+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.201+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.211+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:205,0.070000,0.070000,0.070000
06-07 18:35:42.211+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:205,0.016086,0.025202,0.047361
06-07 18:35:42.211+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:205,0.306456,-0.080312,9.801532
06-07 18:35:42.211+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:210,0.323031,-0.057428,9.848858
06-07 18:35:42.221+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.221+0200 I/heartrate(28622): es.ugr.frailty.heartrate - capturing data
06-07 18:35:42.221+0200 I/heartrate(28622): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:42.221+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.221+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.221+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:226,-0.210000,-0.140000,0.070000
06-07 18:35:42.221+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.221+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:227,0.308259,-0.079714,9.801479
06-07 18:35:42.231+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:229,-0.033674,-0.010615,0.009042
06-07 18:35:42.231+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:232,0.272782,-0.090927,9.810574
06-07 18:35:42.241+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.241+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.241+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:246,0.307613,-0.080780,9.801492
06-07 18:35:42.241+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.241+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.251+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:246,-0.210000,-0.140000,0.070000
06-07 18:35:42.251+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:251,0.361316,-0.069392,9.812965
06-07 18:35:42.251+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:252,0.053057,0.010323,0.011486
06-07 18:35:42.251+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.251+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.261+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.261+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:264,0.309478,-0.080114,9.801438
06-07 18:35:42.261+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.261+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:265,0.070000,0.070000,0.070000
06-07 18:35:42.271+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:268,-0.010903,0.001816,0.083259
06-07 18:35:42.271+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:270,0.296710,-0.078963,9.884750
06-07 18:35:42.271+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.281+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.281+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.281+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.291+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:285,0.140000,0.070000,0.070000
06-07 18:35:42.291+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:287,0.308004,-0.079708,9.801488
06-07 18:35:42.291+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:291,-0.015161,-0.013206,0.009135
06-07 18:35:42.291+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:291,0.294317,-0.093320,9.810574
06-07 18:35:42.301+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.301+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.301+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.301+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.311+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:306,0.070000,0.070000,0.070000
06-07 18:35:42.311+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:306,0.306875,-0.080193,9.801519
06-07 18:35:42.311+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:313,0.294317,-0.088534,9.846465
06-07 18:35:42.311+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:312,-0.013686,-0.008827,0.044977
06-07 18:35:42.321+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.321+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.321+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.321+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.331+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:327,0.305754,-0.080409,9.801553
06-07 18:35:42.331+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:327,0.070000,0.070000,0.070000
06-07 18:35:42.331+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:335,0.330210,-0.095713,9.781858
06-07 18:35:42.331+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:334,0.024456,-0.015304,-0.019694
06-07 18:35:42.341+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.341+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.341+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.341+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.351+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:347,0.307118,-0.081273,9.801503
06-07 18:35:42.351+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:347,-0.070000,0.070000,0.070000
06-07 18:35:42.351+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:351,0.041206,-0.000947,0.018592
06-07 18:35:42.351+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:351,0.346959,-0.081356,9.820145
06-07 18:35:42.351+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.351+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.361+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.361+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.361+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:365,0.308172,-0.080964,9.801473
06-07 18:35:42.371+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:365,0.140000,0.070000,0.070000
06-07 18:35:42.371+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:369,0.368495,-0.083749,9.872787
06-07 18:35:42.371+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:369,0.061377,-0.002476,0.071283
06-07 18:35:42.371+0200 I/light   (28675): es.ugr.frailty.light - capturing data
06-07 18:35:42.381+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.381+0200 I/light   (28675): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:42:385,1614.000000
06-07 18:35:42.381+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.381+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.391+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:385,0.070000,0.070000,0.070000
06-07 18:35:42.391+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.391+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:391,0.334995,-0.052642,9.824929
06-07 18:35:42.391+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:391,0.310335,-0.080927,9.801404
06-07 18:35:42.391+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:397,0.026823,0.028322,0.023457
06-07 18:35:42.391+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.391+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.401+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:405,0.060553,0.001964,0.033097
06-07 18:35:42.401+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.401+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:405,0.070000,0.070000,0.070000
06-07 18:35:42.411+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.411+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:410,0.370888,-0.078963,9.834501
06-07 18:35:42.411+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:416,0.310870,-0.079427,9.801399
06-07 18:35:42.411+0200 I/heartrate(28622): es.ugr.frailty.heartrate - capturing data
06-07 18:35:42.421+0200 I/heartrate(28622): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:42.421+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.421+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.421+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.421+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.421+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:426,-0.140000,-0.070000,0.070000
06-07 18:35:42.431+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:426,0.007375,-0.025857,0.023530
06-07 18:35:42.431+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:432,0.318245,-0.105284,9.824929
06-07 18:35:42.431+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:432,0.314238,-0.079753,9.801290
06-07 18:35:42.441+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.441+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.441+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.441+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.441+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:446,-0.012742,0.051040,0.016461
06-07 18:35:42.451+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:446,-0.070000,-0.070000,0.070000
06-07 18:35:42.451+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:451,0.314891,-0.081124,9.801257
06-07 18:35:42.451+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:451,0.301496,-0.028714,9.817751
06-07 18:35:42.461+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.461+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.461+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.461+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.461+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:466,0.024889,-0.019374,0.057172
06-07 18:35:42.461+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:466,0.070000,-0.070000,0.070000
06-07 18:35:42.471+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:471,0.339781,-0.100499,9.858429
06-07 18:35:42.471+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:470,0.314249,-0.078432,9.801300
06-07 18:35:42.481+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.481+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.481+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.481+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:487,0.003997,0.004255,0.030808
06-07 18:35:42.481+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.491+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:486,-0.070000,-0.070000,0.070000
06-07 18:35:42.491+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:491,0.318245,-0.074178,9.832108
06-07 18:35:42.491+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:495,0.315896,-0.079613,9.801237
06-07 18:35:42.491+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.491+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.501+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.501+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.511+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:505,0.019100,0.017399,0.030871
06-07 18:35:42.511+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:510,0.334995,-0.062213,9.832108
06-07 18:35:42.511+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:505,0.140000,0.070000,0.070000
06-07 18:35:42.521+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.521+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.521+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:514,0.315191,-0.079021,9.801265
06-07 18:35:42.521+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.521+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.531+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:527,0.007840,-0.021477,0.006915
06-07 18:35:42.531+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:533,0.323031,-0.100499,9.808180
06-07 18:35:42.531+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:526,0.070000,0.070000,0.070000
06-07 18:35:42.531+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:535,0.315539,-0.078055,9.801262
06-07 18:35:42.541+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.541+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.541+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.541+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:547,0.036259,-0.035913,0.011709
06-07 18:35:42.541+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.551+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:547,0.070000,0.070000,0.070000
06-07 18:35:42.551+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:553,0.315486,-0.078943,9.801256
06-07 18:35:42.551+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:550,0.351745,-0.114855,9.812965
06-07 18:35:42.551+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.551+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.561+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.561+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:565,0.026688,-0.011984,0.042816
06-07 18:35:42.561+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:564,0.070000,0.070000,0.070000
06-07 18:35:42.561+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.571+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:571,0.342174,-0.090927,9.844072
06-07 18:35:42.571+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:571,0.316939,-0.080434,9.801197
06-07 18:35:42.581+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.581+0200 I/light   (28675): es.ugr.frailty.light - capturing data
06-07 18:35:42.581+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.581+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.591+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:585,0.070000,0.070000,0.070000
06-07 18:35:42.591+0200 I/light   (28675): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:42:586,1623.000000
06-07 18:35:42.591+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:591,-0.001086,0.001471,0.014161
06-07 18:35:42.591+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.591+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:591,0.315853,-0.078963,9.815358
06-07 18:35:42.591+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.601+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:600,0.317628,-0.080742,9.801172
06-07 18:35:42.601+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.601+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.601+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.601+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:609,0.317061,-0.080483,9.801192
06-07 18:35:42.611+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:605,0.070000,0.070000,0.070000
06-07 18:35:42.621+0200 I/heartrate(28622): es.ugr.frailty.heartrate - capturing data
06-07 18:35:42.621+0200 I/heartrate(28622): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:42.621+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.621+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.621+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:612,0.327817,-0.114855,9.832108
06-07 18:35:42.621+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.621+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:627,0.316906,-0.081760,9.801188
06-07 18:35:42.621+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:614,0.010189,-0.034113,0.030936
06-07 18:35:42.631+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.631+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:626,0.140000,0.070000,0.070000
06-07 18:35:42.631+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:633,0.291924,-0.074178,9.851252
06-07 18:35:42.631+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:637,-0.025137,0.006305,0.050059
06-07 18:35:42.641+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.641+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.641+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:647,0.140000,0.070000,0.070000
06-07 18:35:42.641+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.641+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.641+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:647,0.314908,-0.081057,9.801257
06-07 18:35:42.651+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:652,0.311067,-0.105284,9.851252
06-07 18:35:42.651+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:652,-0.005839,-0.023524,0.050064
06-07 18:35:42.651+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.651+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.661+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:665,-0.070000,0.070000,0.070000
06-07 18:35:42.661+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:665,0.314811,-0.082323,9.801250
06-07 18:35:42.661+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.661+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.661+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:670,0.039230,0.021237,0.066743
06-07 18:35:42.671+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:671,0.354138,-0.059821,9.868000
06-07 18:35:42.671+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.671+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.681+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.681+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.681+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:686,0.316498,-0.081406,9.801204
06-07 18:35:42.691+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:685,-0.070000,0.070000,0.070000
06-07 18:35:42.691+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:691,0.344566,-0.083749,9.894321
06-07 18:35:42.691+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:691,0.029755,-0.001426,0.093072
06-07 18:35:42.691+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.691+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.691+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.701+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:705,0.025675,-0.019092,0.066796
06-07 18:35:42.711+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.721+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.731+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:705,0.317785,-0.081620,9.801160
06-07 18:35:42.731+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:705,-0.070000,0.070000,0.070000
06-07 18:35:42.741+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.741+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.741+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:728,0.019603,-0.011700,0.007020
06-07 18:35:42.751+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:721,0.342174,-0.100499,9.868000
06-07 18:35:42.751+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.761+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:752,0.319021,-0.082607,9.801111
06-07 18:35:42.761+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:751,-0.070000,0.070000,0.070000
06-07 18:35:42.761+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.771+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:765,0.337388,-0.093320,9.808180
06-07 18:35:42.771+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:775,0.320036,-0.083246,9.801073
06-07 18:35:42.791+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:35:42.791+0200 W/libgps_d( 3131): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
06-07 18:35:42.791+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.791+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
06-07 18:35:42.791+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:35:42.801+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:35:42.801+0200 I/light   (28675): es.ugr.frailty.light - capturing data
06-07 18:35:42.801+0200 I/light   (28675): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:42:807,1630.000000
06-07 18:35:42.801+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.811+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.811+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:816,-0.070000,0.070000,0.070000
06-07 18:35:42.811+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:35:42.811+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:813,-0.024704,-0.008320,-0.000110
06-07 18:35:42.821+0200 I/heartrate(28622): es.ugr.frailty.heartrate - capturing data
06-07 18:35:42.821+0200 I/heartrate(28622): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:42.821+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.821+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:827,0.294317,-0.090927,9.801002
06-07 18:35:42.821+0200 I/AUL     ( 3823): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
06-07 18:35:42.821+0200 E/LOCATION( 3823): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
06-07 18:35:42.821+0200 I/LOCATION( 3823): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
06-07 18:35:42.821+0200 I/LOCATION( 3823): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:35:42.821+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.821+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.831+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:801,0.317731,-0.083156,9.801148
06-07 18:35:42.831+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.831+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:839,0.317874,-0.083233,9.801144
06-07 18:35:42.831+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:839,0.210000,0.070000,0.070000
06-07 18:35:42.831+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.831+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.841+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:835,-0.013755,0.006676,0.229639
06-07 18:35:42.841+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.841+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.851+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:843,0.319695,-0.084343,9.801075
06-07 18:35:42.851+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:846,0.306281,-0.076570,10.030712
06-07 18:35:42.851+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.851+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:855,-0.210000,-0.070000,0.070000
06-07 18:35:42.851+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.851+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:858,0.320314,-0.084183,9.801056
06-07 18:35:42.851+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.851+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:852,0.026836,-0.019736,-0.033647
06-07 18:35:42.861+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:862,0.344566,-0.102891,9.767502
06-07 18:35:42.861+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.861+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.861+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:871,0.002764,0.006663,-0.093462
06-07 18:35:42.871+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:863,0.319431,-0.083841,9.801087
06-07 18:35:42.871+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.871+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.871+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:879,0.318161,-0.085676,9.801113
06-07 18:35:42.871+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:875,-0.070000,-0.070000,0.070000
06-07 18:35:42.881+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.881+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.881+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:888,-0.008629,0.002987,0.200923
06-07 18:35:42.881+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:891,-0.070000,-0.070000,0.070000
06-07 18:35:42.891+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.891+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:880,0.320638,-0.076570,9.707682
06-07 18:35:42.891+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.891+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.891+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:895,0.317630,-0.085764,9.801129
06-07 18:35:42.891+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:900,-0.021211,-0.040244,-0.102945
06-07 18:35:42.891+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.901+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.901+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:905,0.317330,-0.086922,9.801129
06-07 18:35:42.901+0200 I/LOCATION(28634): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-07 18:35:42.901+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:897,0.311067,-0.081356,10.001998
06-07 18:35:42.901+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.901+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:906,0.070000,-0.070000,0.070000
06-07 18:35:42.901+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.911+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.921+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.921+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:916,-0.022721,0.000092,0.050164
06-07 18:35:42.921+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:913,0.299103,-0.124427,9.698111
06-07 18:35:42.921+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.921+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:925,0.316934,-0.086370,9.801147
06-07 18:35:42.921+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:930,0.296710,-0.083749,9.851252
06-07 18:35:42.921+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.921+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:921,0.070000,0.070000,0.070000
06-07 18:35:42.921+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.931+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:935,-0.019058,-0.019608,-0.033611
06-07 18:35:42.931+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.931+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:939,-0.070000,-0.140000,0.070000
06-07 18:35:42.941+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.941+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:944,0.299103,-0.105284,9.767502
06-07 18:35:42.941+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:947,0.316195,-0.085508,9.801178
06-07 18:35:42.941+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.951+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.951+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:956,-0.070000,-0.140000,0.070000
06-07 18:35:42.951+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.951+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:952,-0.004170,0.006801,0.160191
06-07 18:35:42.951+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.961+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:963,0.313460,-0.078963,9.961320
06-07 18:35:42.961+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:965,0.316012,-0.085059,9.801188
06-07 18:35:42.961+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.961+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.971+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:972,0.311067,-0.071785,9.719646
06-07 18:35:42.971+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.971+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.971+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:976,0.070000,-0.140000,0.070000
06-07 18:35:42.971+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.971+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:977,0.315853,-0.078963,9.820145
06-07 18:35:42.971+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.971+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:980,0.070000,0.140000,0.070000
06-07 18:35:42.971+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:42.981+0200 I/light   (28675): es.ugr.frailty.light - capturing data
06-07 18:35:42.981+0200 I/light   (28675): es.ugr.frailty.light: SM-R760,07/06/2018,18:35:42:986,1628.000000
06-07 18:35:42.981+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:42.981+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:42:990,0.315481,-0.084880,9.801207
06-07 18:35:42.991+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:982,0.303888,-0.078963,9.856036
06-07 18:35:42.991+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:973,-0.006263,0.015137,-0.081484
06-07 18:35:42.991+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.991+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:42.991+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:42:997,-0.001082,0.007407,0.018998
06-07 18:35:42.991+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:42.991+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:42:998,0.332602,-0.105284,9.798609
06-07 18:35:42.991+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:43.001+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:43:6,0.316223,-0.085710,9.801175
06-07 18:35:43.001+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:43.001+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:43:10,0.303888,-0.076570,9.879964
06-07 18:35:43.001+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:42:984,0.070000,-0.070000,0.070000
06-07 18:35:43.011+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:43:1,-0.012307,0.006545,0.054858
06-07 18:35:43.011+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:43.011+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:43.011+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:43:16,0.016590,-0.020225,-0.002579
06-07 18:35:43.011+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:43.011+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:43:17,-0.070000,0.070000,0.070000
06-07 18:35:43.011+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:43.011+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:43:20,-0.011592,0.008309,0.078757
06-07 18:35:43.021+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:43.021+0200 I/heartrate(28622): es.ugr.frailty.heartrate - capturing data
06-07 18:35:43.021+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:43.021+0200 I/heartrate(28622): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:35:43.021+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:43:26,0.016379,-0.045895,0.002219
06-07 18:35:43.021+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:43.021+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:43:27,0.315095,-0.085070,9.801217
06-07 18:35:43.031+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:35:43:31,0.332602,-0.131605,9.803394
06-07 18:35:43.031+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:35:43:22,0.070000,-0.070000,0.070000
06-07 18:35:43.031+0200 I/gyroscope(28599): es.ugr.frailty.gyroscope - capturing data
06-07 18:35:43.041+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:43.041+0200 I/gravity (28650): es.ugr.frailty.gravity - capturing data
06-07 18:35:43.041+0200 I/accelerometer(28596): es.ugr.frailty.accelerometer - capturing data
06-07 18:35:43.041+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:35:43:47,0.003151,-0.001071,0.011748
06-07 18:35:43.051+0200 I/gravity (28650): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:35:43:47,0.315430,-0.086911,9.801190
06-07 18:35:43.061+0200 I/linearacceleration(28638): es.ugr.frailty.linearacceleration - capturing data
06-07 18:35:43.071+0200 W/CRASH_MANAGER(28485): worker.c: worker_job(1205) > 11286346c6f63152838934
