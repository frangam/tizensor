S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21940
Date: 2018-06-12 19:44:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf775c52d, r5   = 0xf79db150
r6   = 0xffc08670, r7   = 0xffc08520
r8   = 0xf79edc18, r9   = 0x00000000
r10  = 0xffc085fc, fp   = 0xffc08670
ip   = 0x00000001, sp   = 0xffc084f8
lr   = 0xf775c539, pc   = 0xf77c5270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     94460 KB
Buffers:     50680 KB
Cached:     173524 KB
VmPeak:      53444 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11804 KB
VmRSS:       11804 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21940 TID = 21940
21940 21966 

Maps Information
f4627000 f4e26000 rw-p [stack:21966]
f4e2d000 f4e2f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4e37000 f4e3b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4e44000 f4e46000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4e4e000 f4e51000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4e60000 f4e65000 r-xp /usr/lib/libsystem.so.0.0.0
f4e70000 f4e73000 r-xp /lib/libattr.so.1.1.0
f4e7b000 f4e8b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4e93000 f4e9c000 r-xp /usr/lib/libedbus.so.1.7.99
f4ea4000 f4ea5000 r-xp /usr/lib/libresponse.so.0.2.96
f4eae000 f4eb3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6755000 f685b000 r-xp /usr/lib/libicuuc.so.57.1
f6871000 f69f9000 r-xp /usr/lib/libicui18n.so.57.1
f6a09000 f6a16000 r-xp /usr/lib/libail.so.0.1.0
f6a1f000 f6a26000 r-xp /usr/lib/libminizip.so.1.0.0
f6a2f000 f6bd8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6bf8000 f6c3f000 r-xp /usr/lib/libssl.so.1.0.0
f6c4b000 f6c4d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6c55000 f6c5c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6c65000 f6c6c000 r-xp /lib/libcrypt-2.13.so
f6c9d000 f6ca0000 r-xp /lib/libcap.so.2.21
f6ca8000 f6caa000 r-xp /usr/lib/libiri.so
f6cb2000 f6cfb000 r-xp /usr/lib/libmdm.so.1.2.69
f6d03000 f6d09000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6d11000 f6d34000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6d3e000 f6d40000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d48000 f6d65000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6d6e000 f6d72000 r-xp /usr/lib/libsmack.so.1.0.0
f6d7b000 f6d94000 r-xp /usr/lib/libnetwork.so.0.0.0
f6d9d000 f6da5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6dad000 f6db3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6dbc000 f6dbe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6dc7000 f6dd7000 r-xp /lib/libresolv-2.13.so
f6ddb000 f6df3000 r-xp /usr/lib/liblzma.so.5.0.3
f6dfc000 f6dfe000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e06000 f6e20000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e28000 f6e57000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e60000 f6e6f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e79000 f6e83000 r-xp /usr/lib/libsensord-shared.so
f6e8c000 f6f5f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6f6a000 f6f80000 r-xp /lib/libz.so.1.2.5
f6f88000 f6f8d000 r-xp /usr/lib/libffi.so.5.0.10
f6f95000 f6f96000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6f9e000 f6fae000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6fb6000 f6fcf000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6fd7000 f6fd9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6fe1000 f7056000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7060000 f707e000 r-xp /usr/lib/libsystemd.so.0.4.0
f7088000 f7089000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7091000 f70b4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70bc000 f70c1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70c9000 f70f3000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70fc000 f7113000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f711b000 f7121000 r-xp /lib/librt-2.13.so
f712a000 f7193000 r-xp /lib/libm-2.13.so
f719c000 f7230000 r-xp /usr/lib/libstdc++.so.6.0.16
f7243000 f7248000 r-xp /usr/lib/libctx-client.so.0.8.3
f7250000 f7257000 r-xp /usr/lib/libctx-shared.so.0.8.3
f725f000 f7289000 r-xp /usr/lib/libsensor.so.1.9.6
f7292000 f735e000 r-xp /usr/lib/libxml2.so.2.7.8
f736b000 f736d000 r-xp /usr/lib/libiniparser.so.0
f7376000 f737c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7385000 f7455000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7456000 f748a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7493000 f74cf000 r-xp /usr/lib/libSLP-location.so.0.9.24
f74d7000 f74da000 r-xp /usr/lib/libbundle.so.0.1.22
f74e2000 f74e8000 r-xp /usr/lib/libappsvc.so.0.1.0
f74f0000 f7531000 r-xp /usr/lib/libeina.so.1.7.99
f753a000 f7543000 r-xp /usr/lib/libvconf.so.0.2.45
f754b000 f755f000 r-xp /lib/libpthread-2.13.so
f756a000 f7577000 r-xp /usr/lib/libaul.so.0.1.0
f7581000 f7583000 r-xp /lib/libdl-2.13.so
f758c000 f7597000 r-xp /lib/libunwind.so.8.0.1
f75c4000 f75cc000 r-xp /lib/libgcc_s-4.6.so.1
f75cd000 f76f1000 r-xp /lib/libc-2.13.so
f76ff000 f7716000 r-xp /usr/lib/libecore.so.1.7.99
f772d000 f772f000 r-xp /usr/lib/libdlog.so.0.0.0
f7737000 f7743000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f774c000 f7751000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7759000 f7768000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7770000 f7774000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f777d000 f7780000 r-xp /usr/lib/libappcore-agent.so.1.1
f7788000 f778a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7792000 f7796000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f779e000 f77bb000 r-xp /lib/ld-2.13.so
f77c4000 f77c7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f77c7000 f77cb000 r-xp /usr/lib/libsys-assert.so
f79bd000 f7a2b000 rw-p [heap]
ffbe9000 ffc0a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21940)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf77c5270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf775c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf74633f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7461c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf746de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7473be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7473dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf74a875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf74a31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7461c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf746de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7473be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7473dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf74a5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf74a6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf74adf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4e451fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4e38171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6f0b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf73b8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73ba7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf770fca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf770ab4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf770b5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf770b879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf777e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf777e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf77c560b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf75e485c) [/lib/libc.so.6] + 0x1785c
29: (0xf77c4f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
4:01.021+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:30,-1.330000,0.210000,-0.070000
06-12 19:44:01.031+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.031+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.031+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:35,-0.064226,0.261770,0.020641
06-12 19:44:01.031+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:35,-2.380000,0.280000,-0.700000
06-12 19:44:01.031+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.031+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.031+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:34,2.689533,1.012164,9.413363
06-12 19:44:01.031+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:28,2.733682,0.820747,9.382097
06-12 19:44:01.031+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.041+0200 I/light   (21981): es.ugr.frailty.light - capturing data
06-12 19:44:01.041+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.041+0200 I/light   (21981): es.ugr.frailty.light: SM-R760,12/06/2018,19:44:01:46,139.000000
06-12 19:44:01.041+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:41,-0.700000,0.210000,-1.820000
06-12 19:44:01.041+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.051+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:43,2.727309,0.832393,9.382926
06-12 19:44:01.051+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.051+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:39,-0.110095,0.165552,0.082657
06-12 19:44:01.051+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:50,2.627320,0.701097,9.456435
06-12 19:44:01.051+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:54,1.190000,1.190000,-0.630000
06-12 19:44:01.051+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.051+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.061+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:63,-5.320000,-1.470000,-1.120000
06-12 19:44:01.061+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:65,0.027438,-0.102435,0.026318
06-12 19:44:01.061+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.061+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.061+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.061+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:70,-0.210000,-0.700000,-1.680000
06-12 19:44:01.061+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:71,2.754139,0.626920,9.530612
06-12 19:44:01.071+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:59,2.708856,0.817140,9.389609
06-12 19:44:01.071+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.071+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:69,-0.118327,0.275166,-0.097945
06-12 19:44:01.071+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.071+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:78,2.708164,0.809040,9.390511
06-12 19:44:01.071+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.071+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:79,-0.138275,-0.138474,0.114187
06-12 19:44:01.071+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.081+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:83,2.698501,0.798917,9.394158
06-12 19:44:01.081+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.081+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.081+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.081+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:88,2.653640,1.067199,9.375079
06-12 19:44:01.081+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:88,4.970000,2.170000,-0.070000
06-12 19:44:01.091+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:84,0.088354,-0.113650,0.002219
06-12 19:44:01.091+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.091+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:88,2.693682,0.789095,9.396371
06-12 19:44:01.091+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.091+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:96,-0.004275,-0.112729,0.061139
06-12 19:44:01.091+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:97,2.693660,0.801681,9.395312
06-12 19:44:01.091+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.091+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.101+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:101,2.674782,0.786873,9.401955
06-12 19:44:01.101+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:102,0.017352,-0.181569,0.124490
06-12 19:44:01.101+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.101+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.101+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.101+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:108,2.541178,1.012164,9.332008
06-12 19:44:01.101+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:108,-3.080000,0.350000,0.210000
06-12 19:44:01.101+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.111+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:107,2.675942,0.779215,9.402263
06-12 19:44:01.111+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.111+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:113,-0.004149,0.223069,0.016993
06-12 19:44:01.111+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.111+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:117,2.686713,0.802208,9.397256
06-12 19:44:01.111+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.111+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:119,-0.066341,-0.100584,0.061123
06-12 19:44:01.111+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.121+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:121,2.669920,0.806281,9.401692
06-12 19:44:01.121+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.121+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.121+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:127,2.689533,0.643669,9.511470
06-12 19:44:01.121+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:127,-5.880000,-0.980000,-0.140000
06-12 19:44:01.121+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:124,0.079357,-0.159953,0.128657
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.131+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:132,2.652716,0.786668,9.408221
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:136,-0.022302,0.287984,-0.027184
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:141,-0.145536,0.209956,-0.065248
06-12 19:44:01.131+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.141+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.141+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.141+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:146,2.634498,0.777667,9.461221
06-12 19:44:01.141+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:146,0.630000,0.910000,0.770000
06-12 19:44:01.141+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.141+0200 I/heartrate(21928): es.ugr.frailty.heartrate - capturing data
06-12 19:44:01.141+0200 I/heartrate(21928): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:44:01.151+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:145,0.019612,-0.162611,0.109777
06-12 19:44:01.151+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:150,2.652203,0.786816,9.408354
06-12 19:44:01.151+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.151+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:156,-0.018219,-0.009001,0.052999
06-12 19:44:01.161+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.161+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.161+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:167,-0.840000,0.210000,0.560000
06-12 19:44:01.161+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:166,2.610569,0.945165,9.420543
06-12 19:44:01.161+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.161+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.171+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:172,-0.041634,0.158349,0.012189
06-12 19:44:01.171+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:171,2.647450,0.792342,9.409229
06-12 19:44:01.181+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.181+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.181+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:190,-2.310000,0.210000,0.770000
06-12 19:44:01.181+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:189,2.734996,0.859023,9.406186
06-12 19:44:01.181+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.181+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.191+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:194,2.644266,0.790423,9.410286
06-12 19:44:01.191+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:194,0.087547,0.066681,-0.003043
06-12 19:44:01.201+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.201+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.201+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:208,-3.360000,0.350000,1.330000
06-12 19:44:01.201+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:208,2.656033,0.808774,9.461221
06-12 19:44:01.201+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.201+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.211+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:214,0.011767,0.018351,0.050935
06-12 19:44:01.211+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:215,2.633928,0.783772,9.413740
06-12 19:44:01.221+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.221+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.221+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:226,-5.460000,0.350000,0.700000
06-12 19:44:01.221+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:226,2.629712,0.736989,9.406186
06-12 19:44:01.221+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.231+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.231+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:233,-0.004216,-0.046783,-0.007554
06-12 19:44:01.231+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:235,2.616152,0.770236,9.419813
06-12 19:44:01.241+0200 I/light   (21981): es.ugr.frailty.light - capturing data
06-12 19:44:01.241+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.241+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:247,2.641676,0.579063,9.513863
06-12 19:44:01.241+0200 I/light   (21981): es.ugr.frailty.light: SM-R760,12/06/2018,19:44:01:247,138.000000
06-12 19:44:01.241+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.251+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.251+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:252,-3.780000,-0.210000,0.490000
06-12 19:44:01.251+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.251+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:256,0.025525,-0.191173,0.094049
06-12 19:44:01.251+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:258,2.604738,0.753070,9.424362
06-12 19:44:01.261+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.261+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.261+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:268,1.680000,1.050000,-0.350000
06-12 19:44:01.261+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.271+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:268,2.723032,0.531207,9.494720
06-12 19:44:01.271+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.271+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:275,0.118294,-0.221864,0.070358
06-12 19:44:01.281+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.281+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.281+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:288,0.910000,1.400000,0.210000
06-12 19:44:01.281+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:288,2.622534,0.794417,9.501899
06-12 19:44:01.281+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:274,2.611777,0.745493,9.423017
06-12 19:44:01.291+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.291+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:295,0.010756,0.048924,0.078882
06-12 19:44:01.291+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.301+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.301+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:302,2.611622,0.748891,9.422791
06-12 19:44:01.301+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.301+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.301+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.301+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:307,-0.420000,0.420000,-0.770000
06-12 19:44:01.311+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:312,0.077910,-0.033437,0.131750
06-12 19:44:01.311+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:308,2.610329,0.746096,9.423370
06-12 19:44:01.311+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:314,2.689533,0.715454,9.554541
06-12 19:44:01.321+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.321+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.321+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.321+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.331+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:326,-1.820000,0.630000,0.280000
06-12 19:44:01.331+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:326,-0.018903,0.103356,0.037850
06-12 19:44:01.331+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:328,2.601947,0.746926,9.425622
06-12 19:44:01.331+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:333,2.591427,0.849452,9.461221
06-12 19:44:01.341+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.341+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.341+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.341+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:346,-4.270000,-1.050000,0.140000
06-12 19:44:01.341+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.341+0200 I/heartrate(21928): es.ugr.frailty.heartrate - capturing data
06-12 19:44:01.341+0200 I/heartrate(21928): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:44:01.351+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:346,0.061265,-0.084114,0.112169
06-12 19:44:01.351+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:348,2.591188,0.734126,9.429591
06-12 19:44:01.351+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:352,2.663212,0.662812,9.537791
06-12 19:44:01.361+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.361+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.361+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_check_retry_err(507) > key(ALTIBARO_SETTING_PRESSURE), check retry err: -21/(2/No such file or directory).
06-12 19:44:01.361+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: _preference_get_key(1101) > _preference_get_key(ALTIBARO_SETTING_PRESSURE) step(-17825744) failed(2 / No such file or directory)
06-12 19:44:01.361+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 6296): preference.c: preference_get_int(1132) > preference_get_int(6296) : key(ALTIBARO_SETTING_PRESSURE) error
06-12 19:44:01.361+0200 E/ALTIBARO( 6296): AltiBaroStorageMgr.cpp: getSettingPressure(247) > [0;31m* Critical * No Correct Data[0;m
06-12 19:44:01.361+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.371+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.371+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:368,2.761317,0.667598,9.365508
06-12 19:44:01.371+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:367,0.280000,-0.700000,-0.210000
06-12 19:44:01.371+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:374,0.170129,-0.066528,-0.064083
06-12 19:44:01.381+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:375,2.601220,0.731930,9.426999
06-12 19:44:01.381+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.381+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.381+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:388,2.622534,0.878166,9.578469
06-12 19:44:01.381+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:389,1.330000,0.420000,0.350000
06-12 19:44:01.381+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.381+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.391+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:395,2.604382,0.740685,9.425443
06-12 19:44:01.401+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.401+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:394,0.021313,0.146236,0.151470
06-12 19:44:01.401+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.401+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.411+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:407,-2.240000,-0.630000,-0.350000
06-12 19:44:01.411+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:412,0.037294,0.010662,0.026207
06-12 19:44:01.421+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:413,2.599121,0.736830,9.427197
06-12 19:44:01.421+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.421+0200 W/LOCATION(21940): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 19:44:01.421+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.421+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.421+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:427,-2.240000,0.280000,-0.140000
06-12 19:44:01.431+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.431+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:436,0.123911,-0.007019,-0.068867
06-12 19:44:01.441+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:435,2.641676,0.751346,9.451650
06-12 19:44:01.441+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.441+0200 I/light   (21981): es.ugr.frailty.light - capturing data
06-12 19:44:01.461+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:449,2.723032,0.729811,9.358330
06-12 19:44:01.461+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.471+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:470,2.648855,0.751346,9.420543
06-12 19:44:01.471+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.481+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.481+0200 I/light   (21981): es.ugr.frailty.light: SM-R760,12/06/2018,19:44:01:449,138.000000
06-12 19:44:01.481+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:484,2.665605,0.516850,9.432507
06-12 19:44:01.481+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:488,-4.060000,0.980000,-0.350000
06-12 19:44:01.481+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.491+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.491+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:432,2.596991,0.732088,9.428153
06-12 19:44:01.491+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.491+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.501+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:494,-3.220000,1.260000,-0.140000
06-12 19:44:01.501+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.501+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:497,2.682354,0.636491,9.468399
06-12 19:44:01.501+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.501+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:497,2.583221,0.724612,9.432512
06-12 19:44:01.501+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.511+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:501,0.051864,0.019259,-0.007610
06-12 19:44:01.511+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.511+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:512,2.663212,0.832702,9.470792
06-12 19:44:01.511+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:513,2.572479,0.707826,9.436722
06-12 19:44:01.511+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.521+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.531+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:527,2.596212,0.720240,9.559326
06-12 19:44:01.551+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 19:44:01.551+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.551+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:561,2.715853,0.696311,9.463614
06-12 19:44:01.561+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:44:01.561+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 19:44:01.561+0200 I/heartrate(21928): es.ugr.frailty.heartrate - capturing data
06-12 19:44:01.561+0200 I/heartrate(21928): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:44:01.561+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.561+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:510,2.100000,2.100000,-0.280000
06-12 19:44:01.561+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.571+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:574,0.280000,1.680000,-0.280000
06-12 19:44:01.571+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.571+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:519,0.082383,-0.207762,-0.000006
06-12 19:44:01.571+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:571,2.715853,0.416351,9.518648
06-12 19:44:01.571+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:579,-2.380000,0.700000,-0.210000
06-12 19:44:01.571+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.581+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.581+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:583,-4.760000,0.630000,0.350000
06-12 19:44:01.581+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.581+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:589,0.109875,-0.071336,0.031677
06-12 19:44:01.581+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:590,-0.350000,-0.140000,-0.420000
06-12 19:44:01.581+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.591+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.591+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:524,2.579161,0.708041,9.434881
06-12 19:44:01.591+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.591+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:595,2.677568,0.902094,9.363115
06-12 19:44:01.591+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:593,5.670000,2.590000,0.420000
06-12 19:44:01.591+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.601+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.601+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:599,2.579851,0.713905,9.434251
06-12 19:44:01.601+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.601+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.601+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:602,0.084050,0.124662,0.035911
06-12 19:44:01.601+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.601+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:607,2.569188,0.708836,9.437543
06-12 19:44:01.601+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:610,-2.170000,0.210000,0.770000
06-12 19:44:01.601+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:606,2.512464,0.868595,9.552148
06-12 19:44:01.611+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:613,0.016361,0.006334,0.125075
06-12 19:44:01.611+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.611+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.621+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:618,2.557550,0.698109,9.441503
06-12 19:44:01.621+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.621+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.621+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.621+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:622,0.146666,-0.012524,0.026071
06-12 19:44:01.621+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.621+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:628,2.703890,0.567099,9.489935
06-12 19:44:01.631+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:627,2.561031,0.683959,9.441594
06-12 19:44:01.631+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:626,-4.690000,-1.540000,0.490000
06-12 19:44:01.631+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.631+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:636,2.582907,0.705030,9.434082
06-12 19:44:01.631+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:632,0.158304,-0.281758,0.077146
06-12 19:44:01.631+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.641+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.641+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.641+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:646,-0.840000,0.490000,1.400000
06-12 19:44:01.641+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:642,0.116537,0.218135,-0.078479
06-12 19:44:01.641+0200 I/light   (21981): es.ugr.frailty.light - capturing data
06-12 19:44:01.641+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.651+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.651+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:647,2.571138,0.707754,9.437093
06-12 19:44:01.651+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.651+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:652,-0.070444,0.163565,0.118066
06-12 19:44:01.651+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:655,2.646462,0.725025,9.482756
06-12 19:44:01.651+0200 I/light   (21981): es.ugr.frailty.light: SM-R760,12/06/2018,19:44:01:651,137.000000
06-12 19:44:01.651+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.661+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:658,2.563056,0.691617,9.440487
06-12 19:44:01.661+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.661+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.661+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.661+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:663,0.132752,-0.140655,0.052842
06-12 19:44:01.661+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:669,2.563588,0.690690,9.440411
06-12 19:44:01.661+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:670,2.622534,0.677169,9.544970
06-12 19:44:01.671+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.671+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:668,0.210000,0.700000,1.400000
06-12 19:44:01.671+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.671+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:675,0.083406,0.033408,0.042269
06-12 19:44:01.671+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.671+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:680,2.565502,0.689439,9.439982
06-12 19:44:01.681+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.681+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.681+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:685,0.058946,-0.013521,0.104559
06-12 19:44:01.681+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.681+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.691+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:689,2.636890,0.646062,9.410972
06-12 19:44:01.691+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:688,2.030000,0.350000,0.280000
06-12 19:44:01.691+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:691,2.575585,0.691341,9.437097
06-12 19:44:01.691+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:695,0.071389,-0.043377,-0.029011
06-12 19:44:01.701+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.701+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.701+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.701+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.711+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:711,2.629712,0.842274,9.547362
06-12 19:44:01.711+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:707,0.490000,0.140000,1.470000
06-12 19:44:01.711+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:708,2.579800,0.698463,9.435421
06-12 19:44:01.711+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:712,0.054127,0.150933,0.110266
06-12 19:44:01.721+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.721+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.721+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.721+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.721+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:729,2.660819,0.583849,9.413363
06-12 19:44:01.721+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:726,-4.060000,-1.050000,0.140000
06-12 19:44:01.731+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:726,2.571198,0.685043,9.438752
06-12 19:44:01.731+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:730,0.081019,-0.114614,-0.022058
06-12 19:44:01.741+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.741+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.741+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.741+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:748,2.737389,0.449851,9.525827
06-12 19:44:01.741+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:747,2.575604,0.672169,9.438477
06-12 19:44:01.741+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.741+0200 I/heartrate(21928): es.ugr.frailty.heartrate - capturing data
06-12 19:44:01.741+0200 I/heartrate(21928): es.ugr.frailty.heartrate: waiting for rigth values
06-12 19:44:01.751+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:747,-0.630000,-0.280000,0.770000
06-12 19:44:01.751+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:752,0.166191,-0.235192,0.087075
06-12 19:44:01.761+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.761+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.761+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.761+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.771+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:768,2.711068,0.674776,9.384650
06-12 19:44:01.771+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:772,2.100000,0.140000,0.350000
06-12 19:44:01.771+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:768,2.589815,0.676472,9.434279
06-12 19:44:01.771+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:771,0.135464,0.002607,-0.053826
06-12 19:44:01.781+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.781+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.781+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.781+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.791+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:791,2.629712,0.591027,9.561719
06-12 19:44:01.791+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:792,2.450000,0.280000,-0.350000
06-12 19:44:01.801+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.801+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.811+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:795,0.039897,-0.085445,0.127439
06-12 19:44:01.811+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:789,2.598020,0.677002,9.431985
06-12 19:44:01.811+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.811+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:820,2.607216,0.681613,9.429115
06-12 19:44:01.811+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:810,1.260000,0.280000,-0.210000
06-12 19:44:01.821+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.821+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.821+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:809,2.691926,0.715454,9.334401
06-12 19:44:01.821+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.821+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:827,0.093906,0.038452,-0.097584
06-12 19:44:01.831+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.831+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.831+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:836,-0.910000,0.280000,-0.280000
06-12 19:44:01.831+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:831,2.602419,0.679316,9.430606
06-12 19:44:01.831+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:836,-0.008611,-0.009230,0.015356
06-12 19:44:01.841+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:832,2.598605,0.672383,9.444471
06-12 19:44:01.841+0200 I/light   (21981): es.ugr.frailty.light - capturing data
06-12 19:44:01.841+0200 I/gravity (21954): es.ugr.frailty.gravity - capturing data
06-12 19:44:01.841+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.841+0200 I/light   (21981): es.ugr.frailty.light: SM-R760,12/06/2018,19:44:01:846,137.000000
06-12 19:44:01.841+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.841+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.851+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:853,-2.730000,0.280000,-0.280000
06-12 19:44:01.851+0200 I/gravity (21954): es.ugr.frailty.gravity: SM-R760,12/06/2018,19:44:01:847,2.590430,0.677651,9.434026
06-12 19:44:01.851+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:851,2.581856,0.760918,9.449257
06-12 19:44:01.851+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,19:44:01:851,-0.020563,0.081602,0.018651
06-12 19:44:01.871+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 19:44:01.871+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 19:44:01.871+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 19:44:01.871+0200 E/CAPI_LOCATION_MANAGER(21986): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 19:44:01.871+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 19:44:01.891+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 19:44:01.901+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.901+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:879,-3.500000,-0.700000,-0.350000
06-12 19:44:01.911+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:910,2.691926,0.579063,9.544970
06-12 19:44:01.911+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.911+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.921+0200 I/linearacceleration(21942): es.ugr.frailty.linearacceleration - capturing data
06-12 19:44:01.941+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:917,2.632105,0.555135,9.597611
06-12 19:44:01.941+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.941+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:920,2.940000,-0.490000,0.280000
06-12 19:44:01.941+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.951+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:948,2.651247,0.751346,9.427721
06-12 19:44:01.951+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:950,5.670000,0.490000,-0.210000
06-12 19:44:01.951+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.951+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.961+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:958,0.840000,-0.350000,0.770000
06-12 19:44:01.961+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.961+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:962,2.589034,0.830309,9.410972
06-12 19:44:01.961+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.971+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:969,2.665605,0.492921,9.434900
06-12 19:44:01.971+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.971+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:967,-4.130000,-1.610000,-0.420000
06-12 19:44:01.971+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:01.981+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,19:44:01:978,2.794817,0.423530,9.542577
06-12 19:44:01.981+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,19:44:01:982,1.260000,0.420000,-0.700000
06-12 19:44:01.981+0200 I/CAPI_NETWORK_CONNECTION(21986): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 19:44:01.981+0200 I/CAPI_NETWORK_CONNECTION(21986): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 19:44:01.981+0200 I/CAPI_NETWORK_CONNECTION(21986): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 19:44:01.981+0200 I/CAPI_NETWORK_CONNECTION(21986): connection.c: connection_destroy(471) > Destroy handle: 0xf7f319d0
06-12 19:44:01.991+0200 I/accelerometer(21903): es.ugr.frailty.accelerometer - capturing data
06-12 19:44:01.991+0200 I/gyroscope(21916): es.ugr.frailty.gyroscope - capturing data
06-12 19:44:02.001+0200 W/CRASH_MANAGER(22025): worker.c: worker_job(1205) > 11219406c6f63152882544
