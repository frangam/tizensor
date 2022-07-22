S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6882
Date: 2019-03-04 16:11:13+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75df52d, r5   = 0xf7770150
r6   = 0xff9ed338, r7   = 0xff9ed1e8
r8   = 0xf7782c18, r9   = 0x00000000
r10  = 0xff9ed2c4, fp   = 0xff9ed338
ip   = 0x00000001, sp   = 0xff9ed1c0
lr   = 0xf75df539, pc   = 0xf76482f8
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     80496 KB
Buffers:     34304 KB
Cached:     171468 KB
VmPeak:      53444 KB
VmSize:      53420 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11872 KB
VmRSS:       11872 KB
VmData:      11148 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6882 TID = 6882
6882 6963 

Maps Information
f44ab000 f4caa000 rw-p [stack:6963]
f4cb1000 f4cb3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4cbb000 f4cbf000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4cc8000 f4cca000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cd2000 f4cd5000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ce4000 f4ce9000 r-xp /usr/lib/libsystem.so.0.0.0
f4cf4000 f4cf7000 r-xp /lib/libattr.so.1.1.0
f4cff000 f4d0f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d17000 f4d20000 r-xp /usr/lib/libedbus.so.1.7.99
f4d28000 f4d29000 r-xp /usr/lib/libresponse.so.0.2.96
f4d32000 f4d37000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65d9000 f66df000 r-xp /usr/lib/libicuuc.so.57.1
f66f5000 f687d000 r-xp /usr/lib/libicui18n.so.57.1
f688d000 f689a000 r-xp /usr/lib/libail.so.0.1.0
f68a3000 f68aa000 r-xp /usr/lib/libminizip.so.1.0.0
f68b3000 f6a5c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a7c000 f6ac3000 r-xp /usr/lib/libssl.so.1.0.0
f6acf000 f6ad1000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ad9000 f6ae0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ae9000 f6af0000 r-xp /lib/libcrypt-2.13.so
f6b21000 f6b24000 r-xp /lib/libcap.so.2.21
f6b2c000 f6b2e000 r-xp /usr/lib/libiri.so
f6b36000 f6b7f000 r-xp /usr/lib/libmdm.so.1.2.69
f6b87000 f6b8d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b95000 f6bb8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6bc2000 f6bc4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bcc000 f6be9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bf2000 f6bf6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bff000 f6c18000 r-xp /usr/lib/libnetwork.so.0.0.0
f6c21000 f6c29000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c31000 f6c37000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c40000 f6c42000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c4b000 f6c5b000 r-xp /lib/libresolv-2.13.so
f6c5f000 f6c77000 r-xp /usr/lib/liblzma.so.5.0.3
f6c80000 f6c82000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c8a000 f6ca4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cac000 f6cdb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ce4000 f6cf3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cfc000 f6d06000 r-xp /usr/lib/libsensord-shared.so
f6d0f000 f6de2000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ded000 f6e03000 r-xp /lib/libz.so.1.2.5
f6e0b000 f6e10000 r-xp /usr/lib/libffi.so.5.0.10
f6e18000 f6e19000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6e21000 f6e31000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e39000 f6e52000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e5a000 f6e5c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e64000 f6ed9000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ee3000 f6f01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f0b000 f6f0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f14000 f6f37000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3f000 f6f44000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f4c000 f6f76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7f000 f6f96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f9e000 f6fa4000 r-xp /lib/librt-2.13.so
f6fad000 f7016000 r-xp /lib/libm-2.13.so
f701f000 f70b3000 r-xp /usr/lib/libstdc++.so.6.0.16
f70c6000 f70cb000 r-xp /usr/lib/libctx-client.so.0.8.3
f70d3000 f70da000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70e2000 f710c000 r-xp /usr/lib/libsensor.so.1.9.6
f7115000 f71e1000 r-xp /usr/lib/libxml2.so.2.7.8
f71ee000 f71f0000 r-xp /usr/lib/libiniparser.so.0
f71f9000 f71ff000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7208000 f72d8000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72d9000 f730d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7316000 f7352000 r-xp /usr/lib/libSLP-location.so.0.9.24
f735a000 f735d000 r-xp /usr/lib/libbundle.so.0.1.22
f7365000 f736b000 r-xp /usr/lib/libappsvc.so.0.1.0
f7373000 f73b4000 r-xp /usr/lib/libeina.so.1.7.99
f73bd000 f73c6000 r-xp /usr/lib/libvconf.so.0.2.45
f73ce000 f73e2000 r-xp /lib/libpthread-2.13.so
f73ed000 f73fa000 r-xp /usr/lib/libaul.so.0.1.0
f7404000 f7406000 r-xp /lib/libdl-2.13.so
f740f000 f741a000 r-xp /lib/libunwind.so.8.0.1
f7447000 f744f000 r-xp /lib/libgcc_s-4.6.so.1
f7450000 f7574000 r-xp /lib/libc-2.13.so
f7582000 f7599000 r-xp /usr/lib/libecore.so.1.7.99
f75b0000 f75b2000 r-xp /usr/lib/libdlog.so.0.0.0
f75ba000 f75c6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75cf000 f75d4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75dc000 f75eb000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75f3000 f75f7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7600000 f7603000 r-xp /usr/lib/libappcore-agent.so.1.1
f760b000 f760d000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7615000 f7619000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7621000 f763e000 r-xp /lib/ld-2.13.so
f7647000 f764a000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f764b000 f764f000 r-xp /usr/lib/libsys-assert.so
f7752000 f77bc000 rw-p [heap]
ff9ce000 ff9ef000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6882)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76482f8) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12f8
 1: (0xf75df539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72e63f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72e4c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72f0e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72f6be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72f6dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf732b75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73261f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72e4c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72f0e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72f6be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72f6dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7328e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7329017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf732d8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf76170bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4cbc171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d8e663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf723bfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf723d7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7592ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf758db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf758e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf758e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7601183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76017fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76487e7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x17e7
28: __libc_start_main + 0x114 (0xf746785c) [/lib/libc.so.6] + 0x1785c
29: (0xf7647fc0) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfc0
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
04/03/2019,16:11:12.309,103.320000,54.740002,168.279999
03-04 16:11:12.301+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.311+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.314,49.840000,52.360001,171.220001
03-04 16:11:12.311+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.311+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.321+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.320,33.110001,39.340000,175.770004
03-04 16:11:12.321+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.310,-5.703626,4.782763,-1.660949
03-04 16:11:12.321+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.321+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.308,-1.725225,1.811367,6.795617
03-04 16:11:12.321+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.331+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.323,2.268322,-3.580887,8.843209
03-04 16:11:12.331+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.331+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.341+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.340,42.349998,25.129999,171.990005
03-04 16:11:12.341+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.341,1.442358,-4.900253,8.371231
03-04 16:11:12.341+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.334,-2.349752,1.744368,8.379664
03-04 16:11:12.341+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.341+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.330,-5.605532,4.896826,-0.317019
03-04 16:11:12.341+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.341+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.347,-2.383251,0.203390,6.577869
03-04 16:11:12.341+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.350,-4.651574,3.784277,-2.265340
03-04 16:11:12.351+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.351+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.351+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.359,18.270000,-1.610000,157.360001
03-04 16:11:12.351+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.359,0.557938,-9.412477,2.695250
03-04 16:11:12.351+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.351+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.361+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.364,-1.682154,-0.358923,4.579862
03-04 16:11:12.361+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:12.371+0100 I/heartrate( 6871): es.ugr.frailty.heartrate: SM-R760,04/03/2019,16:11:12.371,78
03-04 16:11:12.371+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.364,-3.124513,4.541329,-3.791369
03-04 16:11:12.371+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.381+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.381+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.381+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.385,-53.760002,-15.960000,143.990005
03-04 16:11:12.381+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.385,0.490230,7.927498,5.751941
03-04 16:11:12.381+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.381+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.384,-0.478975,10.654351,1.568760
03-04 16:11:12.391+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.390,0.078963,1.241875,4.264010
03-04 16:11:12.391+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.391+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.391+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.401+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.405,1.100997,-7.171366,-0.841869
03-04 16:11:12.401+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.404,0.694041,7.619440,6.134560
03-04 16:11:12.401+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.401+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.402,-128.449997,-29.330000,117.320000
03-04 16:11:12.411+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.412,1.591227,0.756132,4.910072
03-04 16:11:12.411+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.411+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.411+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.420,1.234574,-8.624426,-0.193182
03-04 16:11:12.411+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.420,0.937928,7.930264,5.692238
03-04 16:11:12.421+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.421+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.421+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.425,-171.149994,-30.590000,87.849998
03-04 16:11:12.421+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.428,1.928615,-1.004985,5.941379
03-04 16:11:12.431+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.431+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.431+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.440,1.225010,8.679379,4.397511
03-04 16:11:12.441+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.431+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.440,1.945423,-8.774931,0.335282
03-04 16:11:12.431+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.441+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.445,2.883351,-0.844666,6.027520
03-04 16:11:12.451+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.450,-158.550003,-41.230000,58.450001
03-04 16:11:12.451+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.451+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.461+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.460,3.043785,-9.672400,2.046360
03-04 16:11:12.461+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.460,1.485005,9.297929,2.741107
03-04 16:11:12.461+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.461+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.471+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.471,4.268795,-0.993021,6.443871
03-04 16:11:12.471+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.468,-138.180008,-47.389999,35.770000
03-04 16:11:12.471+0100 I/light   ( 6919): es.ugr.frailty.light - capturing data
03-04 16:11:12.481+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.481+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.486,1.612142,9.604806,1.148518
03-04 16:11:12.481+0100 I/light   ( 6919): es.ugr.frailty.light: SM-R760,04/03/2019,16:11:12.484,851.000000
03-04 16:11:12.481+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.481+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.491+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.491+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.493,2.872325,-10.470412,2.975347
03-04 16:11:12.491+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.493,-106.959999,-30.799999,16.309999
03-04 16:11:12.491+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.491+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.495,4.357330,-1.172483,5.716454
03-04 16:11:12.501+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.501+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.501+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.507,1.697020,-9.657515,0.151384
03-04 16:11:12.501+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.511+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.506,-66.500000,-20.930000,-1.960000
03-04 16:11:12.511+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.507,4.091727,-1.270589,6.307480
03-04 16:11:12.511+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.511+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.511+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.521+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.522,2.243230,-9.387776,1.734346
03-04 16:11:12.521+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.511,2.479585,-10.875395,5.158962
03-04 16:11:12.521+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.521+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.523,4.520042,-0.375673,6.948757
03-04 16:11:12.521+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.528,2.823022,9.281841,6.797372
03-04 16:11:12.531+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.522,-9.310000,-20.090000,-22.610001
03-04 16:11:12.531+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.531+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.531+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.541+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.540,2.799724,-8.868972,3.110189
03-04 16:11:12.541+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.541+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.541,4.811966,0.282353,6.434300
03-04 16:11:12.541+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.540,20.860001,-15.890000,-37.450001
03-04 16:11:12.541+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.549,2.568737,9.670130,4.699954
03-04 16:11:12.551+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.551+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.551+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.559,3.301282,-8.224532,4.198689
03-04 16:11:12.551+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.551+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.561+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:12.561+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.563,4.577469,0.418744,6.350551
03-04 16:11:12.561+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.559,28.350000,-9.800000,-45.920002
03-04 16:11:12.561+0100 I/heartrate( 6871): es.ugr.frailty.heartrate: SM-R760,04/03/2019,16:11:12.566,78
03-04 16:11:12.571+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.563,1.777745,9.287716,3.240362
03-04 16:11:12.571+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.571+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.581+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.581+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.584,3.746566,-7.528865,5.044782
03-04 16:11:12.581+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.581+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.589,1.403008,8.535599,2.376787
03-04 16:11:12.581+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.585,36.750000,-3.780000,-53.410000
03-04 16:11:12.581+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.587,4.704289,0.311067,6.575477
03-04 16:11:12.591+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.591+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.591+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.601+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.602,4.120298,-6.786408,5.756577
03-04 16:11:12.601+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.601+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.601,53.970001,8.680000,-62.860001
03-04 16:11:12.601+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.607,0.720834,7.839932,1.415839
03-04 16:11:12.601+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.602,4.467400,0.311067,6.460621
03-04 16:11:12.611+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.611+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.611+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.611+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.620,4.464680,-6.016365,6.327746
03-04 16:11:12.621+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.621+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.625,0.313602,7.150117,0.857184
03-04 16:11:12.621+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.621,84.279999,13.720000,-77.279999
03-04 16:11:12.621+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.625,4.433900,0.363709,6.613762
03-04 16:11:12.631+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.631+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.631+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.631+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.640,4.921512,-4.987640,6.860944
03-04 16:11:12.641+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.641+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.645,-0.298776,6.971101,1.826993
03-04 16:11:12.641+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.641,4.165904,0.954736,8.154739
03-04 16:11:12.641+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.646,130.339996,15.890000,-93.800003
03-04 16:11:12.651+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.651+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.651+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.661+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.661+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.660,5.381964,-4.068230,7.117187
03-04 16:11:12.671+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.665,-1.112138,6.564510,1.104762
03-04 16:11:12.671+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.660,170.589996,10.430000,-112.279999
03-04 16:11:12.671+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.659,3.809374,1.576870,7.965706
03-04 16:11:12.681+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.681+0100 I/light   ( 6919): es.ugr.frailty.light - capturing data
03-04 16:11:12.681+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.686,5.730024,-3.408352,7.191686
03-04 16:11:12.681+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.681+0100 I/light   ( 6919): es.ugr.frailty.light: SM-R760,04/03/2019,16:11:12.687,872.000000
03-04 16:11:12.681+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.691+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.692,-1.962621,6.197843,-0.266536
03-04 16:11:12.691+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.691+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.701+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.699,3.419343,2.129612,6.850651
03-04 16:11:12.701+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.701+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.701+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.702,6.043935,-2.779434,7.205275
03-04 16:11:12.701+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.709,2.514857,2.328217,6.463014
03-04 16:11:12.711+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.695,177.449997,8.050000,-125.090004
03-04 16:11:12.711+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.711+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.709,-3.215167,5.736568,-0.728672
03-04 16:11:12.711+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.711+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.721+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.720,2.045863,3.060420,7.544570
03-04 16:11:12.721+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.721+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.718,165.619995,4.410000,-135.800003
03-04 16:11:12.721+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.721,6.348592,-2.184793,7.147898
03-04 16:11:12.721+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.731+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.730,-3.998071,5.839854,0.339295
03-04 16:11:12.731+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.731+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.741+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.741,1.734797,3.682554,8.135597
03-04 16:11:12.741+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.732,155.330002,-9.520000,-153.020004
03-04 16:11:12.741+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.741+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.742,6.660348,-1.447334,7.050913
03-04 16:11:12.741+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.741+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.747,185.430008,-16.730000,-168.350006
03-04 16:11:12.741+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.749,-4.613796,5.867347,0.987700
03-04 16:11:12.751+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.751+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.751+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.760,6.865899,-0.810146,6.955104
03-04 16:11:12.751+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.760,0.729811,4.644469,7.377072
03-04 16:11:12.761+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.761+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:12.761+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.766,205.869995,-20.930000,-181.020004
03-04 16:11:12.771+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.771+0100 I/heartrate( 6871): es.ugr.frailty.heartrate: SM-R760,04/03/2019,16:11:12.767,78
03-04 16:11:12.771+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.775,-5.930538,6.091803,0.326159
03-04 16:11:12.771+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.781+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.781+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.784,0.083749,4.828716,5.898308
03-04 16:11:12.781+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.781+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.781+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.790,214.270004,-38.009998,-186.550003
03-04 16:11:12.781+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.790,-6.782150,5.638862,-1.056796
03-04 16:11:12.791+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.785,7.018524,-0.166498,6.847115
03-04 16:11:12.791+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.791+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.801+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.801+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.801+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.801,-0.007178,6.190232,5.386244
03-04 16:11:12.801+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.802,7.116717,0.486757,6.729472
03-04 16:11:12.801+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.805,209.930008,-52.080002,-190.119995
03-04 16:11:12.811+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.807,-7.025702,6.356731,-1.460870
03-04 16:11:12.811+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.811+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.821+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.821+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.821+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.825,-7.277036,7.287523,-1.974934
03-04 16:11:12.821+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.825,214.270004,-63.349998,-189.910004
03-04 16:11:12.821+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.821,-0.160319,7.774280,4.754539
03-04 16:11:12.821+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.821,7.102394,1.300869,6.635821
03-04 16:11:12.831+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.841+0100 W/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 2
03-04 16:11:12.841+0100 I/WATCH_CORE( 2849): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
03-04 16:11:12.841+0100 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
03-04 16:11:12.841+0100 E/watchface-app( 2849): watchface.cpp: OnAppTimeTick(834) > 
03-04 16:11:12.841+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.841,197.259995,-72.169998,-192.360001
03-04 16:11:12.841+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.841+0100 W/W_HOME  ( 2758): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
03-04 16:11:12.841+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -147037776[0;m
03-04 16:11:12.841+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
03-04 16:11:12.841+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
03-04 16:11:12.841+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
03-04 16:11:12.841+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.841+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.848,-0.485743,9.820145,3.823731
03-04 16:11:12.851+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
03-04 16:11:12.851+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.851+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
03-04 16:11:12.851+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
03-04 16:11:12.851+0100 E/WAKEUP-SERVICE( 3226): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
03-04 16:11:12.851+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
03-04 16:11:12.851+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.861+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.861+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.852,7.002567,2.118345,6.530471
03-04 16:11:12.861+0100 I/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
03-04 16:11:12.861+0100 W/TIZEN_N_SOUND_MANAGER( 3226): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-04 16:11:12.861+0100 W/WAKEUP-SERVICE( 3226): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
03-04 16:11:12.861+0100 I/HIGEAR  ( 3226): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
03-04 16:11:12.861+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.861+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.858,-7.588137,8.519276,-2.812090
03-04 16:11:12.871+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.871+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.862,-0.241675,10.861022,2.005185
03-04 16:11:12.871+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.867,160.160004,-83.930000,-180.809998
03-04 16:11:12.871+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.878,-7.244242,8.742677,-4.525286
03-04 16:11:12.881+0100 I/light   ( 6919): es.ugr.frailty.light - capturing data
03-04 16:11:12.881+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.874,6.954764,2.711677,6.359909
03-04 16:11:12.881+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.881+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.881+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.881+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.889,6.890157,3.197353,6.202665
03-04 16:11:12.891+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.888,-0.157926,10.923235,1.450050
03-04 16:11:12.891+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.891+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.901+0100 I/light   ( 6919): es.ugr.frailty.light: SM-R760,04/03/2019,16:11:12.886,629.000000
03-04 16:11:12.901+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.895,106.330002,-83.090004,-151.479996
03-04 16:11:12.901+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.901+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.900,6.778131,3.615585,6.095479
03-04 16:11:12.901+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.901+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.899,-7.112690,8.211557,-4.909859
03-04 16:11:12.911+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.911+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.909,-0.571885,10.904092,1.765903
03-04 16:11:12.911+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.911+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.911+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.915,65.099998,-73.080002,-133.210007
03-04 16:11:12.921+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.921+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.921,6.646760,3.990167,6.005793
03-04 16:11:12.921+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.916,-7.462041,7.706739,-4.436762
03-04 16:11:12.921+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.921+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.922,-0.839881,11.210374,1.792224
03-04 16:11:12.931+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.932,-7.618011,7.594789,-4.303256
03-04 16:11:12.931+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.931+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.941+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.928,50.400002,-70.139999,-117.879997
03-04 16:11:12.941+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.942,6.500735,4.346481,5.917679
03-04 16:11:12.941+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.941+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.941+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.942,-0.605384,11.416157,0.971486
03-04 16:11:12.951+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.949,45.779999,-69.160004,-109.830002
03-04 16:11:12.951+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.951+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.951+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.960,6.323281,4.680639,5.854752
03-04 16:11:12.961+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.961+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.948,-7.252144,7.425990,-5.034307
03-04 16:11:12.961+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:12.961+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.960,-0.330210,11.542977,0.165105
03-04 16:11:12.971+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.965,35.560001,-61.810001,-99.470001
03-04 16:11:12.971+0100 I/heartrate( 6871): es.ugr.frailty.heartrate: SM-R760,04/03/2019,16:11:12.966,79
03-04 16:11:12.971+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.971+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.979,-6.830945,7.196496,-5.752574
03-04 16:11:12.971+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.981+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:12.981+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:12.985,-0.971486,11.633904,0.428315
03-04 16:11:12.981+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:12.981+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:12.985,6.132942,4.966268,5.821821
03-04 16:11:12.981+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:12.981+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:12.989,19.950001,-46.830002,-82.879997
03-04 16:11:12.991+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:12.991,-7.294767,6.953266,-5.426437
03-04 16:11:12.991+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:12.991+0100 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
03-04 16:11:12.991+0100 E/watchface-app( 2849): watchface.cpp: OnAppTimeTick(834) > 
03-04 16:11:12.991+0100 I/watchface-viewer( 2849): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=left ']
03-04 16:11:12.991+0100 I/watchface-viewer( 2849): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 46x41
03-04 16:11:12.991+0100 I/watchface-viewer( 2849): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(561) > ImagesLoadingDoneSignal().Emit()
03-04 16:11:12.991+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.001+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.001+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.1,-1.761117,12.244074,1.026521
03-04 16:11:13.001+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.8,3.920000,-41.369999,-69.300003
03-04 16:11:13.001+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.4,5.943309,5.202692,5.812009
03-04 16:11:13.011+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.011+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.011+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.011+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.021+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.19,-1.847259,11.435300,1.718047
03-04 16:11:13.021+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.25,-3.570000,-35.560001,-55.090000
03-04 16:11:13.031+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.23,5.762961,5.396985,5.816461
03-04 16:11:13.031+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.15,-7.894059,7.277806,-4.795300
03-04 16:11:13.031+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.041+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.43,-7.790568,6.232608,-4.093963
03-04 16:11:13.041+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.051+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.51,5.583066,5.574761,5.824243
03-04 16:11:13.051+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.051+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.061+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 16:11:13.071+0100 W/libgps_d( 3110): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
03-04 16:11:13.071+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.071+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
03-04 16:11:13.071+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 16:11:13.071+0100 E/CAPI_LOCATION_MANAGER( 4933): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
03-04 16:11:13.081+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.78,-2.301895,11.205588,1.935793
03-04 16:11:13.081+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.61,5.411044,5.727726,5.838162
03-04 16:11:13.081+0100 I/AUL     ( 4933): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 16:11:13.081+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.091+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.57,-8.064857,5.808604,-3.880668
03-04 16:11:13.091+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.091+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.101+0100 I/AUL     ( 4933): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 16:11:13.101+0100 E/LOCATION( 4933): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
03-04 16:11:13.101+0100 I/LOCATION( 4933): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
03-04 16:11:13.101+0100 I/LOCATION( 4933): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 16:11:13.101+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.101+0100 I/light   ( 6919): es.ugr.frailty.light - capturing data
03-04 16:11:13.101+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.93,1.190000,-30.450001,-44.590000
03-04 16:11:13.101+0100 I/light   ( 6919): es.ugr.frailty.light: SM-R760,04/03/2019,16:11:13.109,431.000000
03-04 16:11:13.101+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.97,5.248239,5.854316,5.861173
03-04 16:11:13.111+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.108,-2.380858,11.193624,1.773082
03-04 16:11:13.111+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.121+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.121+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.111,-7.963924,5.618864,-4.051161
03-04 16:11:13.121+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.121+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.141+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.127,5.098644,5.959309,5.887346
03-04 16:11:13.141+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.122,-1.750000,-28.840000,-32.200001
03-04 16:11:13.141+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.151+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.130,-2.031506,11.475977,1.526621
03-04 16:11:13.151+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.151+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.133,-7.442550,5.748250,-4.311542
03-04 16:11:13.151+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.161+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:13.161+0100 I/LOCATION( 6882): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 16:11:13.171+0100 I/heartrate( 6871): es.ugr.frailty.heartrate: SM-R760,04/03/2019,16:11:13.167,79
03-04 16:11:13.181+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.181+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.165,4.946639,6.046773,5.927704
03-04 16:11:13.181+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.165,-1.533799,11.849257,1.545763
03-04 16:11:13.181+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.156,-8.750000,-27.090000,-20.719999
03-04 16:11:13.191+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.201+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.201+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.201+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.189,-6.782038,5.994941,-4.315410
03-04 16:11:13.211+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.211+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.212,-1.569692,11.119448,1.605584
03-04 16:11:13.211+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.198,-12.670000,-24.500000,-11.970000
03-04 16:11:13.221+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.221+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.218,-6.668335,5.160139,-4.281762
03-04 16:11:13.221+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.211,4.644374,6.209312,6.003717
03-04 16:11:13.221+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.221+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.241+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.241+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.230,-15.610000,-16.309999,-4.200000
03-04 16:11:13.251+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.251+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.243,-1.720440,10.188639,1.526621
03-04 16:11:13.251+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.234,4.359560,6.349624,6.070164
03-04 16:11:13.251+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.251+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.251+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.248,-6.667078,4.141865,-4.401083
03-04 16:11:13.271+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.271+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.257,-10.990000,-10.780000,0.700000
03-04 16:11:13.281+0100 I/light   ( 6919): es.ugr.frailty.light - capturing data
03-04 16:11:13.281+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.281+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.267,-1.686940,10.408779,2.005185
03-04 16:11:13.281+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.265,4.082717,6.464331,6.141191
03-04 16:11:13.281+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.281+0100 I/light   ( 6919): es.ugr.frailty.light: SM-R760,04/03/2019,16:11:13.285,411.000000
03-04 16:11:13.281+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.291+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.279,-6.331314,4.199467,-3.998532
03-04 16:11:13.301+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.301+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.289,-4.760000,-4.200000,4.200000
03-04 16:11:13.311+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.311+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.298,-1.787439,10.205389,2.459821
03-04 16:11:13.311+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.295,3.808055,6.567151,6.208190
03-04 16:11:13.321+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.321+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.331+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.315,-6.146998,3.855765,-3.610343
03-04 16:11:13.331+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,16:11:13.324,-3.850000,1.330000,8.260000
03-04 16:11:13.331+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration - capturing data
03-04 16:11:13.351+0100 I/gravity ( 6906): es.ugr.frailty.gravity: SM-R760,04/03/2019,16:11:13.329,3.538978,6.649668,6.279167
03-04 16:11:13.351+0100 I/gyroscope( 6859): es.ugr.frailty.gyroscope - capturing data
03-04 16:11:13.351+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,16:11:13.332,-1.753939,10.047462,2.450250
03-04 16:11:13.351+0100 I/gravity ( 6906): es.ugr.frailty.gravity - capturing data
03-04 16:11:13.351+0100 I/accelerometer( 6856): es.ugr.frailty.accelerometer - capturing data
03-04 16:11:13.361+0100 I/linearacceleration( 6885): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,16:11:13.352,-5.836657,3.583131,-3.690941
03-04 16:11:13.361+0100 I/heartrate( 6871): es.ugr.frailty.heartrate - capturing data
03-04 16:11:13.421+0100 W/AUL     ( 6974): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
03-04 16:11:13.421+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 23
03-04 16:11:13.421+0100 W/AUL_AMD ( 2470): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
03-04 16:11:13.421+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6882
03-04 16:11:13.421+0100 W/AUL_AMD ( 2470): amd_request.c: __send_app_termination_signal(528) > send dead signal done
03-04 16:11:13.441+0100 W/CRASH_MANAGER( 6970): worker.c: worker_job(1205) > 11068826c6f63155171227
