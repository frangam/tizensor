S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4134
Date: 2018-06-14 11:52:29+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf714a52d, r5   = 0xf73d0150
r6   = 0xffb35e70, r7   = 0xffb35d20
r8   = 0xf73e2c18, r9   = 0x00000000
r10  = 0xffb35dfc, fp   = 0xffb35e70
ip   = 0x00000001, sp   = 0xffb35cf8
lr   = 0xf714a539, pc   = 0xf71b3270
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5848 KB
Buffers:      7884 KB
Cached:      96204 KB
VmPeak:      53556 KB
VmSize:      53552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12108 KB
VmRSS:       12104 KB
VmData:      11280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4134 TID = 4134
4134 4218 

Maps Information
f4015000 f4814000 rw-p [stack:4218]
f481b000 f481d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4825000 f4829000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4832000 f4834000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f483c000 f483f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f484e000 f4853000 r-xp /usr/lib/libsystem.so.0.0.0
f485e000 f4861000 r-xp /lib/libattr.so.1.1.0
f4869000 f4879000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4881000 f488a000 r-xp /usr/lib/libedbus.so.1.7.99
f4892000 f4893000 r-xp /usr/lib/libresponse.so.0.2.96
f489c000 f48a1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6143000 f6249000 r-xp /usr/lib/libicuuc.so.57.1
f625f000 f63e7000 r-xp /usr/lib/libicui18n.so.57.1
f63f7000 f6404000 r-xp /usr/lib/libail.so.0.1.0
f640d000 f6414000 r-xp /usr/lib/libminizip.so.1.0.0
f641d000 f65c6000 r-xp /usr/lib/libcrypto.so.1.0.0
f65e6000 f662d000 r-xp /usr/lib/libssl.so.1.0.0
f6639000 f663b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6643000 f664a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6653000 f665a000 r-xp /lib/libcrypt-2.13.so
f668b000 f668e000 r-xp /lib/libcap.so.2.21
f6696000 f6698000 r-xp /usr/lib/libiri.so
f66a0000 f66e9000 r-xp /usr/lib/libmdm.so.1.2.69
f66f1000 f66f7000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66ff000 f6722000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f672c000 f672e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6736000 f6753000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f675c000 f6760000 r-xp /usr/lib/libsmack.so.1.0.0
f6769000 f6782000 r-xp /usr/lib/libnetwork.so.0.0.0
f678b000 f6793000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f679b000 f67a1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67aa000 f67ac000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67b5000 f67c5000 r-xp /lib/libresolv-2.13.so
f67c9000 f67e1000 r-xp /usr/lib/liblzma.so.5.0.3
f67ea000 f67ec000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67f4000 f680e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6816000 f6845000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f684e000 f685d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6867000 f6871000 r-xp /usr/lib/libsensord-shared.so
f687a000 f694d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6958000 f696e000 r-xp /lib/libz.so.1.2.5
f6976000 f697b000 r-xp /usr/lib/libffi.so.5.0.10
f6983000 f6984000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f698c000 f699c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69a4000 f69bd000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69c5000 f69c7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69cf000 f6a44000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a4e000 f6a6c000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a76000 f6a77000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a7f000 f6aa2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6aaa000 f6aaf000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ab7000 f6ae1000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aea000 f6b01000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b09000 f6b0f000 r-xp /lib/librt-2.13.so
f6b18000 f6b81000 r-xp /lib/libm-2.13.so
f6b8a000 f6c1e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c31000 f6c36000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c3e000 f6c45000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c4d000 f6c77000 r-xp /usr/lib/libsensor.so.1.9.6
f6c80000 f6d4c000 r-xp /usr/lib/libxml2.so.2.7.8
f6d59000 f6d5b000 r-xp /usr/lib/libiniparser.so.0
f6d64000 f6d6a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d73000 f6e43000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e44000 f6e78000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e81000 f6ebd000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ec5000 f6ec8000 r-xp /usr/lib/libbundle.so.0.1.22
f6ed0000 f6ed6000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ede000 f6f1f000 r-xp /usr/lib/libeina.so.1.7.99
f6f28000 f6f31000 r-xp /usr/lib/libvconf.so.0.2.45
f6f39000 f6f4d000 r-xp /lib/libpthread-2.13.so
f6f58000 f6f65000 r-xp /usr/lib/libaul.so.0.1.0
f6f6f000 f6f71000 r-xp /lib/libdl-2.13.so
f6f7a000 f6f85000 r-xp /lib/libunwind.so.8.0.1
f6fb2000 f6fba000 r-xp /lib/libgcc_s-4.6.so.1
f6fbb000 f70df000 r-xp /lib/libc-2.13.so
f70ed000 f7104000 r-xp /usr/lib/libecore.so.1.7.99
f711b000 f711d000 r-xp /usr/lib/libdlog.so.0.0.0
f7125000 f7131000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f713a000 f713f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7147000 f7156000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f715e000 f7162000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f716b000 f716e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7176000 f7178000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7180000 f7184000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f718c000 f71a9000 r-xp /lib/ld-2.13.so
f71b2000 f71b5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71b5000 f71b9000 r-xp /usr/lib/libsys-assert.so
f73b2000 f743d000 rw-p [heap]
ffb17000 ffb38000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4134)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71b3270) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1270
 1: (0xf714a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e513f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e9675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e911f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e4fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e5be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e61be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e61dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e93e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e94017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e9bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48331fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4826171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68f9663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6da6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6da87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70fdca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70f8b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70f95a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70f9879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf716c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf716c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71b360b) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x160b
28: __libc_start_main + 0x114 (0xf6fd285c) [/lib/libc.so.6] + 0x1785c
29: (0xf71b2f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
ration - capturing data
06-14 11:52:29.221+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:227,0.934927,0.245869,-0.910285
06-14 11:52:29.221+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:220,6.575045,-7.236268,0.758674
06-14 11:52:29.231+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.231+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.231+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.231+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:236,6.020000,3.080000,-1.260000
06-14 11:52:29.231+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:236,7.235896,-6.695118,0.004786
06-14 11:52:29.231+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.241+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:236,0.660851,0.541150,-0.753889
06-14 11:52:29.241+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:243,6.603663,-7.212725,0.733907
06-14 11:52:29.251+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.251+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.251+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.251+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:257,7.020542,-6.675975,0.131605
06-14 11:52:29.251+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:257,0.416879,0.536749,-0.602302
06-14 11:52:29.251+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.261+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:256,-3.360000,4.410000,-3.150000
06-14 11:52:29.271+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.271+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.271+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:276,0.440156,0.214683,-0.629256
06-14 11:52:29.271+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:264,6.589958,-7.228046,0.705827
06-14 11:52:29.271+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:278,7.030113,-7.013363,0.076570
06-14 11:52:29.271+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.271+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.281+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:284,-9.940000,5.180000,-3.360000
06-14 11:52:29.281+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:284,6.535022,-7.281286,0.668393
06-14 11:52:29.291+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.291+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.291+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:296,0.447235,0.057354,-0.472181
06-14 11:52:29.291+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:296,6.982256,-7.223931,0.196211
06-14 11:52:29.291+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.291+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.291+0200 I/heartrate( 4121): es.ugr.frailty.heartrate - capturing data
06-14 11:52:29.301+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:303,-11.690000,6.300000,-3.500000
06-14 11:52:29.301+0200 I/heartrate( 4121): es.ugr.frailty.heartrate: SM-R760,14/06/2018,11:52:29:303,91
06-14 11:52:29.301+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:302,6.462844,-7.348249,0.636609
06-14 11:52:29.311+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.311+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.321+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.321+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:321,0.136561,-0.045573,-0.296828
06-14 11:52:29.321+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.321+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:326,-12.950000,7.350000,-4.340000
06-14 11:52:29.321+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:327,6.372791,-7.428552,0.611994
06-14 11:52:29.321+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:321,6.599405,-7.393822,0.339781
06-14 11:52:29.331+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.331+0200 I/light   ( 4172): es.ugr.frailty.light - capturing data
06-14 11:52:29.331+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:338,0.284041,-0.199767,-0.372712
06-14 11:52:29.331+0200 I/light   ( 4172): es.ugr.frailty.light: SM-R760,14/06/2018,11:52:29:339,15846.000000
06-14 11:52:29.331+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.331+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.341+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:345,6.656832,-7.628319,0.239282
06-14 11:52:29.341+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:345,6.291265,-7.499693,0.587348
06-14 11:52:29.341+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.351+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.351+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:351,-9.590000,7.210000,-2.520000
06-14 11:52:29.351+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.351+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:357,0.355997,0.278154,-0.510778
06-14 11:52:29.351+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:359,-1.400000,7.560000,-2.450000
06-14 11:52:29.351+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.351+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.361+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:364,6.647261,-7.221539,0.076570
06-14 11:52:29.361+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:364,6.256200,-7.530441,0.568159
06-14 11:52:29.371+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.371+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.371+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:377,0.441310,-0.057200,-0.546624
06-14 11:52:29.371+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:377,6.697510,-7.587641,0.021535
06-14 11:52:29.371+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.371+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.381+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:383,-0.350000,9.030000,-2.170000
06-14 11:52:29.381+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:383,6.214280,-7.566425,0.549839
06-14 11:52:29.391+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.391+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.391+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:396,0.473659,-0.258105,-0.315343
06-14 11:52:29.391+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:396,-4.620000,10.360000,-3.430000
06-14 11:52:29.391+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.391+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.401+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:402,6.687939,-7.824530,0.234497
06-14 11:52:29.401+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:402,6.148946,-7.620519,0.537167
06-14 11:52:29.411+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.411+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.421+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.421+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:421,0.361925,-0.117869,-0.214136
06-14 11:52:29.421+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.421+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:426,6.510870,-7.738388,0.323031
06-14 11:52:29.421+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:427,6.080037,-7.676246,0.527999
06-14 11:52:29.421+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:420,-5.390000,10.360000,-1.960000
06-14 11:52:29.431+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.431+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.431+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:436,0.356656,-0.031035,-0.181040
06-14 11:52:29.431+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:436,-0.280000,9.730000,0.840000
06-14 11:52:29.431+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.431+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.441+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:442,6.043509,-7.705091,0.527215
06-14 11:52:29.441+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:442,6.436693,-7.707282,0.346959
06-14 11:52:29.451+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.451+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.451+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.451+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:457,0.455397,0.428517,-0.409966
06-14 11:52:29.451+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.461+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:461,6.063663,-7.689121,0.528955
06-14 11:52:29.461+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:463,6.498906,-7.276574,0.117248
06-14 11:52:29.461+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:456,8.820000,9.240000,2.170000
06-14 11:52:29.471+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.471+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.471+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:477,7.980000,10.220000,0.280000
06-14 11:52:29.471+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:478,1.093269,0.702079,-0.696453
06-14 11:52:29.471+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.471+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.481+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:484,6.077729,-7.678823,0.516979
06-14 11:52:29.481+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:483,7.156933,-6.987042,-0.167498
06-14 11:52:29.491+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.491+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.491+0200 I/DOWNLOAD_PROVIDER( 4330): download-provider-queue-manager.c: __dp_queue_manager(243) > queue-manager try to check queue network:1
06-14 11:52:29.491+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.491+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.491+0200 I/heartrate( 4121): es.ugr.frailty.heartrate - capturing data
06-14 11:52:29.501+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:496,-0.140000,10.220000,-0.560000
06-14 11:52:29.501+0200 I/heartrate( 4121): es.ugr.frailty.heartrate: SM-R760,14/06/2018,11:52:29:502,91
06-14 11:52:29.501+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:502,6.924829,-7.159326,0.028714
06-14 11:52:29.501+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:497,0.847100,0.519498,-0.488265
06-14 11:52:29.511+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:501,6.045449,-7.705197,0.502854
06-14 11:52:29.511+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.511+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.521+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.521+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:521,-0.140000,8.540000,-0.910000
06-14 11:52:29.521+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.521+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:526,6.027141,-7.719849,0.497891
06-14 11:52:29.521+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:529,0.635312,0.483658,-0.265965
06-14 11:52:29.531+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:521,6.680761,-7.221539,0.236889
06-14 11:52:29.531+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.531+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.541+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.541+0200 I/light   ( 4172): es.ugr.frailty.light - capturing data
06-14 11:52:29.541+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:546,6.041622,-7.707509,0.513315
06-14 11:52:29.541+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.541+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:539,6.474977,-7.479963,0.514457
06-14 11:52:29.551+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:539,3.570000,9.940000,-4.830000
06-14 11:52:29.551+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.551+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.551+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:558,-1.190000,12.880000,-8.120000
06-14 11:52:29.551+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:558,6.611369,-8.317451,1.311267
06-14 11:52:29.561+0200 I/light   ( 4172): es.ugr.frailty.light: SM-R760,14/06/2018,11:52:29:546,16429.000000
06-14 11:52:29.561+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.561+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:553,0.447837,0.239885,0.016566
06-14 11:52:29.561+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.561+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:567,6.036086,-7.708799,0.557199
06-14 11:52:29.571+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.571+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.571+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:577,-3.570000,13.930000,-8.540000
06-14 11:52:29.571+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:577,6.388836,-8.109276,1.514657
06-14 11:52:29.571+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.581+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:571,0.569746,-0.609942,0.797952
06-14 11:52:29.581+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.581+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:585,6.020709,-7.717041,0.607234
06-14 11:52:29.581+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:588,0.352750,-0.400477,0.957458
06-14 11:52:29.591+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.591+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.591+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:596,0.700000,12.390000,-6.650000
06-14 11:52:29.591+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:596,6.242875,-7.534998,1.127020
06-14 11:52:29.591+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.591+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.601+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:603,6.029002,-7.707479,0.645199
06-14 11:52:29.601+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:603,0.222166,0.182042,0.519785
06-14 11:52:29.611+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.611+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.621+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.621+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:621,0.420000,10.640000,-4.690000
06-14 11:52:29.621+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.621+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:626,6.035347,-7.701562,0.656439
06-14 11:52:29.621+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:627,0.570404,0.500299,-0.001529
06-14 11:52:29.621+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:621,6.599405,-7.207181,0.643669
06-14 11:52:29.631+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.631+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.631+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:636,6.984650,-7.125826,0.155533
06-14 11:52:29.631+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:636,2.310000,8.610000,-2.870000
06-14 11:52:29.631+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.631+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.641+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:642,0.949303,0.575737,-0.500905
06-14 11:52:29.641+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:642,6.040990,-7.698167,0.644237
06-14 11:52:29.651+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.651+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.651+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:657,-0.420000,6.650000,-4.130000
06-14 11:52:29.651+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.651+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.661+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:664,0.931695,1.388294,-0.711236
06-14 11:52:29.661+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:657,6.972685,-6.309873,-0.066999
06-14 11:52:29.661+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:663,6.041600,-7.699975,0.616306
06-14 11:52:29.671+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.671+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.671+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:677,-9.660000,4.340000,-4.270000
06-14 11:52:29.671+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:678,6.943972,-6.223732,0.382852
06-14 11:52:29.671+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.671+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.681+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:684,6.028772,-7.711489,0.597689
06-14 11:52:29.681+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:683,0.902371,1.476244,-0.233454
06-14 11:52:29.691+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.691+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.691+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:696,-20.580000,5.740000,-4.480000
06-14 11:52:29.691+0200 I/heartrate( 4121): es.ugr.frailty.heartrate - capturing data
06-14 11:52:29.691+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.701+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:703,1.300444,0.322453,0.754256
06-14 11:52:29.701+0200 I/heartrate( 4121): es.ugr.frailty.heartrate: SM-R760,14/06/2018,11:52:29:702,91
06-14 11:52:29.701+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.701+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:697,7.329216,-7.389036,1.351945
06-14 11:52:29.701+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:710,5.984145,-7.745499,0.606326
06-14 11:52:29.711+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.711+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.721+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.721+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:721,-7.700000,7.350000,-7.000000
06-14 11:52:29.721+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.721+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:728,7.365108,-7.798209,1.653440
06-14 11:52:29.731+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:721,1.380963,-0.052710,1.047114
06-14 11:52:29.731+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.731+0200 I/light   ( 4172): es.ugr.frailty.light - capturing data
06-14 11:52:29.731+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.741+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:740,19.389999,0.420000,-5.740000
06-14 11:52:29.741+0200 I/light   ( 4172): es.ugr.frailty.light: SM-R760,14/06/2018,11:52:29:741,16429.000000
06-14 11:52:29.741+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.751+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.761+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:757,16.450001,-5.950000,-5.600000
06-14 11:52:29.761+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:754,1.001302,1.187123,-0.858135
06-14 11:52:29.761+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.761+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:726,5.978562,-7.748243,0.626032
06-14 11:52:29.761+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.771+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.771+0200 W/LOCATION( 4134): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-14 11:52:29.771+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:778,2.030000,-4.480000,-2.170000
06-14 11:52:29.771+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:771,0.489029,1.352935,-0.741463
06-14 11:52:29.781+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.781+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:745,6.979864,-6.561120,-0.232104
06-14 11:52:29.781+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.781+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:786,0.732429,0.172755,0.172787
06-14 11:52:29.781+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:788,6.577869,-6.309873,-0.126820
06-14 11:52:29.781+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.791+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.791+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.791+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:796,-5.670000,3.780000,-6.370000
06-14 11:52:29.791+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:797,1.159511,0.769427,0.384219
06-14 11:52:29.791+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:775,6.088840,-7.662808,0.614643
06-14 11:52:29.791+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.801+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:805,6.206758,-7.568969,0.597702
06-14 11:52:29.801+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.801+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:810,6.263025,-7.521972,0.604017
06-14 11:52:29.811+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.811+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:794,6.939186,-7.396214,0.770489
06-14 11:52:29.811+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.811+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.821+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:821,-12.950000,8.050000,-6.440000
06-14 11:52:29.821+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:821,1.451294,1.149235,-0.054339
06-14 11:52:29.821+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.821+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:816,6.296666,-7.492608,0.619045
06-14 11:52:29.821+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.821+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:828,7.422535,-6.752545,0.988236
06-14 11:52:29.821+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.821+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:829,6.272648,-7.513637,0.607897
06-14 11:52:29.831+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.831+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.831+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:836,1.161852,1.761291,-0.741895
06-14 11:52:29.831+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:836,2.870000,-0.350000,-6.440000
06-14 11:52:29.831+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.831+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:833,7.747960,-6.343372,0.564706
06-14 11:52:29.831+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.841+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:844,7.434500,-5.752346,-0.133998
06-14 11:52:29.841+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:841,6.319225,-7.476983,0.576639
06-14 11:52:29.851+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.851+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.851+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:857,18.059999,-10.640000,-1.400000
06-14 11:52:29.851+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.851+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:857,0.749173,1.844278,-0.059790
06-14 11:52:29.851+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.861+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:861,7.068398,-5.632704,0.516850
06-14 11:52:29.861+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:862,6.521899,-7.299603,0.592464
06-14 11:52:29.871+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.871+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.871+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.871+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:877,1.094456,-0.053541,1.462971
06-14 11:52:29.871+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.881+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:877,4.270000,-5.390000,-1.330000
06-14 11:52:29.881+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:879,7.616355,-7.353144,2.055435
06-14 11:52:29.891+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.891+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.891+0200 W/libgps_d( 3118): OnGpsExtensionMessage: message_id(1), data(0xf78e2f38), size(2752)
06-14 11:52:29.891+0200 W/libgps_d( 3118): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-14 11:52:29.891+0200 W/libgps  ( 3118): proxy__gps_sv_status_cb : called
06-14 11:52:29.891+0200 I/heartrate( 4121): es.ugr.frailty.heartrate - capturing data
06-14 11:52:29.901+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.901+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:899,7.613962,-7.491928,3.122634
06-14 11:52:29.901+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:899,1.750000,4.270000,-7.350000
06-14 11:52:29.901+0200 I/heartrate( 4121): es.ugr.frailty.heartrate: SM-R760,14/06/2018,11:52:29:903,91
06-14 11:52:29.901+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:905,0.983045,-0.296556,2.468442
06-14 11:52:29.911+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.911+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.911+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:882,6.630917,-7.195371,0.654191
06-14 11:52:29.911+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.911+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.911+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:919,7.262216,-6.659225,2.100898
06-14 11:52:29.911+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:920,6.671678,-7.151768,0.715058
06-14 11:52:29.911+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.911+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:916,5.530000,7.700000,-8.330000
06-14 11:52:29.921+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:916,0.590538,0.492543,1.385840
06-14 11:52:29.921+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:924,6.738766,-7.080151,0.794278
06-14 11:52:29.931+0200 I/light   ( 4172): es.ugr.frailty.light - capturing data
06-14 11:52:29.931+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.931+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.931+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.931+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:939,7.027720,-6.230910,1.160519
06-14 11:52:29.931+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:940,0.288954,0.849241,0.366241
06-14 11:52:29.941+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:938,11.830000,5.180000,-5.390000
06-14 11:52:29.941+0200 I/light   ( 4172): es.ugr.frailty.light: SM-R760,14/06/2018,11:52:29:938,16149.000000
06-14 11:52:29.941+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.941+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:948,6.810816,-7.006125,0.835091
06-14 11:52:29.951+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.951+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.951+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:957,5.670000,5.390000,-5.740000
06-14 11:52:29.951+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.951+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:957,0.092477,0.330150,0.215358
06-14 11:52:29.951+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.951+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:960,6.903293,-6.675975,1.050449
06-14 11:52:29.951+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:961,6.836123,-6.978493,0.859329
06-14 11:52:29.971+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.971+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.971+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:976,0.363881,0.295340,0.853932
06-14 11:52:29.971+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:976,-3.430000,10.220000,-7.140000
06-14 11:52:29.971+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.971+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.971+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:29:981,6.833492,-6.975137,0.906214
06-14 11:52:29.971+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:29:980,7.200003,-6.683154,1.713261
06-14 11:52:29.991+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:29.991+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:29.991+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:29:996,0.988645,0.794477,0.883617
06-14 11:52:29.991+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:29:996,-4.900000,16.170000,-8.540000
06-14 11:52:29.991+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:29.991+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:29.991+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:0,7.822137,-6.180661,1.789831
06-14 11:52:29.991+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:0,6.848157,-6.953513,0.960094
06-14 11:52:30.011+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.011+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.011+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:21,1.328117,1.277738,0.262638
06-14 11:52:30.011+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:21,4.200000,15.470000,-7.770000
06-14 11:52:30.011+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.011+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.021+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:25,8.176274,-5.675776,1.222732
06-14 11:52:30.021+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:25,6.901757,-6.894985,0.997655
06-14 11:52:30.031+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.031+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.031+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:35,5.810000,6.370000,-5.740000
06-14 11:52:30.031+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:36,7.223931,-5.223531,0.543171
06-14 11:52:30.031+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.031+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:40,0.322174,1.671453,-0.454484
06-14 11:52:30.031+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.041+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:44,6.953815,-6.842955,0.994391
06-14 11:52:30.051+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.051+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.051+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.051+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:57,-10.710000,3.990000,0.770000
06-14 11:52:30.051+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:59,0.334723,-0.110588,0.572908
06-14 11:52:30.051+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.051+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:57,7.288538,-6.953543,1.567299
06-14 11:52:30.061+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:63,6.922232,-6.872518,1.010732
06-14 11:52:30.071+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.071+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.071+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:81,7.451250,-7.302894,2.163112
06-14 11:52:30.071+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.081+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:83,-10.990000,12.040000,-3.150000
06-14 11:52:30.081+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.081+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:88,6.878130,-6.909645,1.057602
06-14 11:52:30.091+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.091+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.091+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:96,6.230000,16.450001,-2.520000
06-14 11:52:30.091+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:85,0.529017,-0.430376,1.152379
06-14 11:52:30.091+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.091+0200 I/heartrate( 4121): es.ugr.frailty.heartrate - capturing data
06-14 11:52:30.101+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.101+0200 I/heartrate( 4121): es.ugr.frailty.heartrate: SM-R760,14/06/2018,11:52:30:105,91
06-14 11:52:30.111+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.121+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:100,7.757531,-6.606583,1.225125
06-14 11:52:30.121+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.121+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:107,0.879401,0.303061,0.167523
06-14 11:52:30.121+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.131+0200 I/light   ( 4172): es.ugr.frailty.light - capturing data
06-14 11:52:30.131+0200 I/light   ( 4172): es.ugr.frailty.light: SM-R760,14/06/2018,11:52:30:139,16149.000000
06-14 11:52:30.131+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:129,7.173682,-6.381658,0.208176
06-14 11:52:30.141+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.141+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:146,6.568298,-6.522834,-0.162712
06-14 11:52:30.141+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:130,0.284359,0.511767,-0.881918
06-14 11:52:30.141+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.141+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:122,17.430000,10.150000,-2.520000
06-14 11:52:30.141+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:151,-0.355198,0.337739,-1.243508
06-14 11:52:30.151+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.151+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:161,6.675975,-7.609176,0.894916
06-14 11:52:30.151+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.161+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.171+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:165,-0.236686,-0.729173,-0.130295
06-14 11:52:30.171+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.171+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:177,0.200870,-0.413026,0.298097
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-14 11:52:30.171+0200 W/libgps  ( 3118): [proxy__gps_stop][line = 1067]: called.
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHookStateGps              : EXIT
06-14 11:52:30.171+0200 W/libgps_d( 3118): GpsiHookStateIdle             : ENTRY
06-14 11:52:30.171+0200 W/gpsd    ( 3090): HandleIncomingMessage() dest id:0, msg id:2
06-14 11:52:30.181+0200 E/CAPI_LOCATION_MANAGER( 4219): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-14 11:52:30.181+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.181+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:188,7.037291,-7.372287,1.299303
06-14 11:52:30.191+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.191+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:196,0.916886,0.598522,-0.063963
06-14 11:52:30.191+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.191+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:166,2.730000,0.980000,4.550000
06-14 11:52:30.191+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.201+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:200,7.697710,-6.415157,0.935594
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:99,6.889323,-6.893425,1.090094
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.201+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:204,-12.950000,-0.210000,11.550000
06-14 11:52:30.201+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:207,6.923497,-6.860573,1.080796
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.201+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:210,-11.760000,1.540000,9.450000
06-14 11:52:30.201+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity: SM-R760,14/06/2018,11:52:30:211,6.912662,-6.880003,1.025210
06-14 11:52:30.201+0200 I/gravity ( 4150): es.ugr.frailty.gravity - capturing data
06-14 11:52:30.211+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope: SM-R760,14/06/2018,11:52:30:214,4.340000,-0.700000,8.330000
06-14 11:52:30.211+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.211+0200 W/AUL     ( 4372): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-14 11:52:30.211+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(669) > __request_handler: 23
06-14 11:52:30.211+0200 W/AUL_AMD ( 2477): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-14 11:52:30.211+0200 W/AUL_AMD ( 2477): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3935
06-14 11:52:30.211+0200 W/AUL_AMD ( 2477): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-14 11:52:30.211+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.221+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration: SM-R760,14/06/2018,11:52:30:225,0.584781,1.492353,-0.230390
06-14 11:52:30.221+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer: SM-R760,14/06/2018,11:52:30:221,7.401000,-5.486742,0.770489
06-14 11:52:30.221+0200 I/gyroscope( 4115): es.ugr.frailty.gyroscope - capturing data
06-14 11:52:30.231+0200 I/linearacceleration( 4146): es.ugr.frailty.linearacceleration - capturing data
06-14 11:52:30.231+0200 I/accelerometer( 4108): es.ugr.frailty.accelerometer - capturing data
06-14 11:52:30.231+0200 W/CRASH_MANAGER( 4370): worker.c: worker_job(1205) > 11041346c6f63152896994
