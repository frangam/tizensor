S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18689
Date: 2018-06-07 17:15:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74f452d, r5   = 0xf761af98
r6   = 0xffdff490, r7   = 0xffdff340
r8   = 0xf7617c18, r9   = 0x00000000
r10  = 0xffdff41c, fp   = 0xffdff490
ip   = 0x00000001, sp   = 0xffdff318
lr   = 0xf74f4539, pc   = 0xf755d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    112800 KB
Buffers:      5684 KB
Cached:      56440 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11408 KB
VmRSS:       11408 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18689 TID = 18689
18689 18692 

Maps Information
f43bf000 f4bbe000 rw-p [stack:18692]
f4bc5000 f4bc7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4bcf000 f4bd3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bdc000 f4bde000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4be6000 f4be9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bf8000 f4bfd000 r-xp /usr/lib/libsystem.so.0.0.0
f4c08000 f4c0b000 r-xp /lib/libattr.so.1.1.0
f4c13000 f4c23000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c2b000 f4c34000 r-xp /usr/lib/libedbus.so.1.7.99
f4c3c000 f4c3d000 r-xp /usr/lib/libresponse.so.0.2.96
f4c46000 f4c4b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64ed000 f65f3000 r-xp /usr/lib/libicuuc.so.57.1
f6609000 f6791000 r-xp /usr/lib/libicui18n.so.57.1
f67a1000 f67ae000 r-xp /usr/lib/libail.so.0.1.0
f67b7000 f67be000 r-xp /usr/lib/libminizip.so.1.0.0
f67c7000 f6970000 r-xp /usr/lib/libcrypto.so.1.0.0
f6990000 f69d7000 r-xp /usr/lib/libssl.so.1.0.0
f69e3000 f69e5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69ed000 f69f4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69fd000 f6a04000 r-xp /lib/libcrypt-2.13.so
f6a35000 f6a38000 r-xp /lib/libcap.so.2.21
f6a40000 f6a42000 r-xp /usr/lib/libiri.so
f6a4a000 f6a93000 r-xp /usr/lib/libmdm.so.1.2.69
f6a9b000 f6aa1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6aa9000 f6acc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6ad6000 f6ad8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae0000 f6afd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b06000 f6b0a000 r-xp /usr/lib/libsmack.so.1.0.0
f6b13000 f6b2c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b35000 f6b3d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b45000 f6b4b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b54000 f6b56000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b5f000 f6b6f000 r-xp /lib/libresolv-2.13.so
f6b73000 f6b8b000 r-xp /usr/lib/liblzma.so.5.0.3
f6b94000 f6b96000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b9e000 f6bb8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bc0000 f6bef000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bf8000 f6c07000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c11000 f6c1b000 r-xp /usr/lib/libsensord-shared.so
f6c24000 f6cf7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d02000 f6d18000 r-xp /lib/libz.so.1.2.5
f6d20000 f6d25000 r-xp /usr/lib/libffi.so.5.0.10
f6d2d000 f6d2e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d36000 f6d46000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d4e000 f6d67000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d6f000 f6d71000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d79000 f6dee000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6df8000 f6dfe000 r-xp /lib/librt-2.13.so
f6e07000 f6e25000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e2f000 f6e30000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e38000 f6e5b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e63000 f6e68000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e70000 f6e9a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ea3000 f6eba000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ec2000 f6f2b000 r-xp /lib/libm-2.13.so
f6f34000 f6fc8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fdb000 f6fe0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fe8000 f6fef000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ff7000 f7021000 r-xp /usr/lib/libsensor.so.1.9.6
f702a000 f70f6000 r-xp /usr/lib/libxml2.so.2.7.8
f7103000 f7105000 r-xp /usr/lib/libiniparser.so.0
f710e000 f7114000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f711d000 f71ed000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ee000 f7222000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f722b000 f7267000 r-xp /usr/lib/libSLP-location.so.0.9.24
f726f000 f7272000 r-xp /usr/lib/libbundle.so.0.1.22
f727a000 f7280000 r-xp /usr/lib/libappsvc.so.0.1.0
f7288000 f72c9000 r-xp /usr/lib/libeina.so.1.7.99
f72d2000 f72e9000 r-xp /usr/lib/libecore.so.1.7.99
f7300000 f7309000 r-xp /usr/lib/libvconf.so.0.2.45
f7311000 f7325000 r-xp /lib/libpthread-2.13.so
f7330000 f733d000 r-xp /usr/lib/libaul.so.0.1.0
f7347000 f7349000 r-xp /lib/libdl-2.13.so
f7352000 f735d000 r-xp /lib/libunwind.so.8.0.1
f738a000 f7392000 r-xp /lib/libgcc_s-4.6.so.1
f7393000 f74b7000 r-xp /lib/libc-2.13.so
f74c5000 f74c7000 r-xp /usr/lib/libdlog.so.0.0.0
f74cf000 f74db000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74e4000 f74e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74f1000 f7500000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7508000 f750c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7515000 f7518000 r-xp /usr/lib/libappcore-agent.so.1.1
f7520000 f7522000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f752a000 f752e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7536000 f7553000 r-xp /lib/ld-2.13.so
f755c000 f755f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f755f000 f7563000 r-xp /usr/lib/libsys-assert.so
f75e7000 f7675000 rw-p [heap]
ffde0000 ffe01000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18689)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf755d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74f4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71fb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7205e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf720bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf720bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf724075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf723b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71f9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7205e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf720bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf720bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf723de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf723e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7245f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bdd1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4bd0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ca3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7150fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71527a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72e2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72ddb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72de5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72de879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7516183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75167fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf755d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73aa85c) [/lib/libc.so.6] + 0x1785c
29: (0xf755cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
oscope: SM-R760,07/06/2018,17:15:12:188,0.140000,0.070000,0.070000
06-07 17:15:12.181+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.181+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.191+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:193,0.070000,0.070000,0.070000
06-07 17:15:12.191+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.211+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:178,0.306281,-0.074178,9.856036
06-07 17:15:12.221+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.221+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:193,0.017565,0.039919,0.049554
06-07 17:15:12.221+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.231+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.231+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:12.231+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:12.241+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:200,0.070000,0.070000,0.070000
06-07 17:15:12.241+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:240,0.298552,-0.090748,9.801684
06-07 17:15:12.251+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:233,0.318245,-0.110070,9.865608
06-07 17:15:12.251+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.261+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:248,0.041270,-0.031558,0.083040
06-07 17:15:12.261+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.271+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.271+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.281+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:282,0.070000,0.070000,0.140000
06-07 17:15:12.291+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.291+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:265,0.315853,-0.078963,9.882358
06-07 17:15:12.301+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:297,0.140000,0.070000,0.070000
06-07 17:15:12.301+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:295,0.022966,0.000802,0.092670
06-07 17:15:12.301+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.311+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:277,0.299513,-0.092835,9.801636
06-07 17:15:12.311+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.311+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.321+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.331+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:315,0.140000,0.070000,0.070000
06-07 17:15:12.331+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.331+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:321,0.306281,-0.122034,9.882358
06-07 17:15:12.341+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.341+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:340,-0.070000,0.070000,0.070000
06-07 17:15:12.351+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:327,0.299475,-0.092666,9.801639
06-07 17:15:12.351+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.361+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:357,0.070000,0.070000,0.070000
06-07 17:15:12.361+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:339,0.032040,-0.004229,0.056791
06-07 17:15:12.361+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.361+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.371+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:12.371+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.371+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:12:378,704.000000
06-07 17:15:12.381+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:358,0.291924,-0.095713,9.908678
06-07 17:15:12.381+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.381+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:374,0.070000,0.070000,0.070000
06-07 17:15:12.381+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.391+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:375,0.299141,-0.092143,9.801653
06-07 17:15:12.391+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.401+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:12.401+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:12.401+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:385,0.002599,-0.025906,0.061599
06-07 17:15:12.401+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:397,0.070000,0.070000,0.070000
06-07 17:15:12.401+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.411+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:402,0.315853,-0.050249,9.851252
06-07 17:15:12.411+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.431+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:415,0.070000,0.070000,0.140000
06-07 17:15:12.431+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.441+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:441,0.140000,0.070000,0.070000
06-07 17:15:12.441+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.441+0200 W/LOCATION(18689): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:15:12.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:450,0.070000,0.070000,0.070000
06-07 17:15:12.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.451+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:459,0.070000,0.070000,0.070000
06-07 17:15:12.461+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.461+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:467,0.070000,0.070000,0.070000
06-07 17:15:12.461+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.471+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.471+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:474,0.070000,0.070000,0.070000
06-07 17:15:12.471+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.471+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:481,0.140000,0.140000,0.070000
06-07 17:15:12.481+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.481+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:425,0.041442,-0.025034,0.075945
06-07 17:15:12.481+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:486,0.140000,0.140000,0.070000
06-07 17:15:12.481+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.481+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:414,0.299537,-0.093122,9.801632
06-07 17:15:12.481+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:491,0.140000,0.140000,0.070000
06-07 17:15:12.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:498,0.140000,0.140000,0.070000
06-07 17:15:12.491+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.491+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.501+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:503,0.140000,0.140000,0.070000
06-07 17:15:12.501+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:490,0.339781,-0.119641,9.884750
06-07 17:15:12.501+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.501+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:510,0.140000,0.140000,0.140000
06-07 17:15:12.511+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.511+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.511+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.511+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:516,0.070000,0.070000,0.070000
06-07 17:15:12.511+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:521,0.070000,0.070000,0.140000
06-07 17:15:12.521+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:505,0.299740,-0.092443,9.801632
06-07 17:15:12.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:528,0.140000,0.070000,0.070000
06-07 17:15:12.521+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:534,0.070000,0.070000,0.070000
06-07 17:15:12.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.531+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.531+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:540,0.140000,0.140000,0.070000
06-07 17:15:12.531+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:516,0.018537,0.021367,0.116673
06-07 17:15:12.541+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.541+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.541+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:546,0.140000,0.140000,0.070000
06-07 17:15:12.541+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:551,0.140000,0.070000,0.070000
06-07 17:15:12.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.551+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:526,0.323031,-0.088534,9.894321
06-07 17:15:12.551+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:546,0.297898,-0.090144,9.801710
06-07 17:15:12.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:558,0.070000,0.070000,0.070000
06-07 17:15:12.551+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:563,0.070000,0.070000,0.070000
06-07 17:15:12.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.561+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:568,0.070000,0.070000,0.070000
06-07 17:15:12.561+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.571+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:12.571+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:552,-0.002953,-0.006332,0.104696
06-07 17:15:12.571+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.571+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:12:579,704.000000
06-07 17:15:12.571+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:574,0.070000,0.070000,0.070000
06-07 17:15:12.581+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.581+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:569,0.332602,-0.093320,9.858429
06-07 17:15:12.581+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:580,0.298577,-0.087858,9.801710
06-07 17:15:12.591+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.591+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:589,0.140000,0.070000,0.140000
06-07 17:15:12.581+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.591+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.601+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:12.601+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:12.601+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:585,0.002529,0.010502,0.099891
06-07 17:15:12.601+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:600,0.140000,0.070000,0.140000
06-07 17:15:12.601+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.601+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.611+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:604,0.303888,-0.114855,9.863215
06-07 17:15:12.611+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.611+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:615,0.070000,0.070000,0.070000
06-07 17:15:12.621+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:596,0.297499,-0.088664,9.801736
06-07 17:15:12.621+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:618,-0.013767,-0.030893,0.049621
06-07 17:15:12.621+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.621+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.631+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:631,0.070000,0.070000,0.070000
06-07 17:15:12.631+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.641+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.641+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:625,0.342174,-0.114855,9.877571
06-07 17:15:12.641+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:639,0.070000,0.070000,0.070000
06-07 17:15:12.641+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.651+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:637,0.297502,-0.089441,9.801728
06-07 17:15:12.651+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:652,0.070000,0.070000,0.070000
06-07 17:15:12.651+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.661+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.671+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.671+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:668,0.070000,0.070000,0.070000
06-07 17:15:12.671+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.671+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:651,0.042617,-0.001044,0.061554
06-07 17:15:12.671+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.681+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:663,0.320638,-0.069392,9.918249
06-07 17:15:12.681+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:686,0.005554,0.022601,0.035265
06-07 17:15:12.691+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:681,0.070000,0.070000,0.070000
06-07 17:15:12.691+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.691+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:676,0.298934,-0.089124,9.801687
06-07 17:15:12.691+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.691+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:697,-0.140000,-0.070000,0.070000
06-07 17:15:12.691+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.701+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.701+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.701+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:703,0.070000,0.070000,0.070000
06-07 17:15:12.711+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.711+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:710,0.300464,-0.089436,9.801638
06-07 17:15:12.711+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:701,0.299103,-0.095713,9.906286
06-07 17:15:12.711+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.721+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:717,0.070000,0.070000,0.070000
06-07 17:15:12.721+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.721+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.731+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:716,-0.006167,0.004581,0.059175
06-07 17:15:12.731+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:727,0.140000,0.070000,0.070000
06-07 17:15:12.731+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.731+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.731+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:727,0.303888,-0.078963,9.901501
06-07 17:15:12.741+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:739,0.070000,0.070000,0.070000
06-07 17:15:12.741+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.741+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.751+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:750,0.070000,0.070000,0.070000
06-07 17:15:12.751+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:738,0.299905,-0.089424,9.801655
06-07 17:15:12.751+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.761+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.761+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:746,0.023341,-0.000622,0.025646
06-07 17:15:12.761+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:765,0.070000,0.070000,0.070000
06-07 17:15:12.771+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.771+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.771+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:12.771+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:12:779,704.000000
06-07 17:15:12.781+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:757,0.287139,-0.119641,9.851252
06-07 17:15:12.781+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:770,0.299308,-0.089935,9.801669
06-07 17:15:12.781+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:777,0.003583,-0.046234,0.049594
06-07 17:15:12.781+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:777,0.070000,0.070000,0.070000
06-07 17:15:12.781+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.781+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.791+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.791+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:795,0.342174,-0.090927,9.863215
06-07 17:15:12.791+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:15:12.791+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:15:12.791+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.791+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.801+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:804,0.298863,-0.088836,9.801692
06-07 17:15:12.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18571
06-07 17:15:12.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18571)
06-07 17:15:12.811+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:12.811+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:12.811+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:15:12.811+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.811+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:15:12.811+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:15:12.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.811+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18556
06-07 17:15:12.821+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:806,-0.008247,0.025136,0.056785
06-07 17:15:12.831+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18556)
06-07 17:15:12.831+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:15:12.831+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.831+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:15:12.831+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:15:12.831+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.831+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.831+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.841+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:15:12.841+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:12.841+0200 I/utils   (18034): specific action
06-07 17:15:12.841+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:794,0.070000,0.070000,0.140000
06-07 17:15:12.851+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:12.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:15:12.851+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:15:12.851+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:15:12.851+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.851+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:15:12.851+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:15:12.851+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.851+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.851+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:841,0.299346,-0.089631,9.801670
06-07 17:15:12.861+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:849,-0.009776,0.004579,0.061532
06-07 17:15:12.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18689
06-07 17:15:12.871+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18689)
06-07 17:15:12.871+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:15:12.871+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.871+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:15:12.871+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:15:12.871+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.871+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.881+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:803,0.306281,-0.066999,9.836893
06-07 17:15:12.881+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:870,0.140000,0.070000,0.140000
06-07 17:15:12.881+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18620
06-07 17:15:12.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18620)
06-07 17:15:12.891+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:15:12.891+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.891+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:15:12.891+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:15:12.891+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.891+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.891+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18583
06-07 17:15:12.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18583)
06-07 17:15:12.901+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:15:12.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.901+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:15:12.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:15:12.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.911+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.911+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.921+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:893,0.299542,-0.088923,9.801671
06-07 17:15:12.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:15:12.921+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:12.921+0200 I/utils   (18075): specific action
06-07 17:15:12.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:15:12.921+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:15:12.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.921+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:15:12.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:15:12.921+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:12.921+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18075), cmd(0)
06-07 17:15:12.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.931+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:901,0.000759,-0.017375,0.023212
06-07 17:15:12.931+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:12.931+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:909,0.294317,-0.083749,9.860823
06-07 17:15:12.931+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:15:12.941+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:12.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:15:12.941+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:12.941+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:15:12.941+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18079), cmd(0)
06-07 17:15:12.941+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.941+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:15:12.941+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:15:12.951+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:12.951+0200 I/utils   (18079): specific action
06-07 17:15:12.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:15:12.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:15:12.951+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:948,0.299197,-0.090117,9.801670
06-07 17:15:12.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:15:12.961+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:12.961+0200 I/utils   (18111): specific action
06-07 17:15:12.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:15:12.961+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:15:12.961+0200 I/servicemanager(17973): App control destroyed.
06-07 17:15:12.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:12.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18111), cmd(0)
06-07 17:15:12.961+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.961+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:927,0.070000,0.070000,0.070000
06-07 17:15:12.971+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:973,0.298288,-0.090168,9.801698
06-07 17:15:12.971+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:12.971+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:12:978,705.000000
06-07 17:15:12.971+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.981+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:12.981+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:983,0.298510,-0.088083,9.801710
06-07 17:15:12.981+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.981+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:12:954,0.058809,0.004652,0.071055
06-07 17:15:12.981+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:989,0.300065,-0.089336,9.801651
06-07 17:15:12.991+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:12:969,0.323031,-0.088534,9.827322
06-07 17:15:12.991+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.991+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:12:996,0.300562,-0.089091,9.801638
06-07 17:15:12.991+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.001+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:2,0.301289,-0.088950,9.801617
06-07 17:15:12.991+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.001+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.001+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:8,0.300732,-0.089821,9.801626
06-07 17:15:13.001+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:12.991+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.011+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:12:988,0.070000,0.070000,0.070000
06-07 17:15:13.001+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:13.011+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:14,0.302101,-0.090759,9.801576
06-07 17:15:13.011+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:13.011+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.011+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:20,0.302056,-0.089381,9.801590
06-07 17:15:13.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:15:13.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(18583), cmd(0)
06-07 17:15:13.021+0200 W/CAPI_APPFW_APP_CONTROL(18583): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:15:13.021+0200 I/utils   (18583): specific action
06-07 17:15:13.021+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.021+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:29,0.301359,-0.089465,9.801610
06-07 17:15:13.021+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:13.021+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.031+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:34,0.300905,-0.088749,9.801631
06-07 17:15:13.031+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.031+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:13:12,0.025651,-0.010081,0.099829
06-07 17:15:13.031+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.031+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:40,0.299557,-0.089884,9.801661
06-07 17:15:13.041+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:13:20,0.303888,-0.133998,9.851252
06-07 17:15:13.041+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.041+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.041+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:46,0.300727,-0.089600,9.801628
06-07 17:15:13.041+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.051+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:13:58,0.291924,-0.064606,9.858429
06-07 17:15:13.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:15:13.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:15:13.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:15:13.061+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:13:34,0.070000,0.070000,0.070000
06-07 17:15:13.061+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:51,0.300484,-0.088330,9.801647
06-07 17:15:13.061+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.071+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:13.071+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:74,0.299690,-0.087912,9.801676
06-07 17:15:13.071+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.081+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:83,0.300305,-0.087764,9.801658
06-07 17:15:13.081+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:13:53,0.041746,0.023678,0.073530
06-07 17:15:13.081+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.081+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.081+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.081+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:89,0.300171,-0.089742,9.801644
06-07 17:15:13.091+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.091+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:13:76,0.140000,0.070000,0.070000
06-07 17:15:13.091+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:95,0.299308,-0.088327,9.801683
06-07 17:15:13.091+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.101+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:102,0.298344,-0.087909,9.801717
06-07 17:15:13.101+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.101+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:109,0.297721,-0.088401,9.801731
06-07 17:15:13.101+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.101+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:13.111+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:114,0.299773,-0.088024,9.801672
06-07 17:15:13.111+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.121+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:125,0.300428,-0.088284,9.801649
06-07 17:15:13.121+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.121+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:130,0.301634,-0.087004,9.801624
06-07 17:15:13.131+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.131+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:140,0.302597,-0.085449,9.801608
06-07 17:15:13.131+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.141+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:144,0.303710,-0.086295,9.801566
06-07 17:15:13.141+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.141+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:150,0.305027,-0.087528,9.801515
06-07 17:15:13.151+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.151+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:13:93,0.035754,0.029577,0.044841
06-07 17:15:13.151+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:156,0.305217,-0.088816,9.801497
06-07 17:15:13.151+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.151+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:13:94,0.289532,-0.083749,9.863215
06-07 17:15:13.161+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:162,0.305393,-0.088649,9.801493
06-07 17:15:13.161+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.161+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:168,0.304545,-0.087509,9.801529
06-07 17:15:13.161+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.161+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.171+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:173,0.305137,-0.086473,9.801520
06-07 17:15:13.171+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:15:13.171+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.171+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:15:13:179,706.000000
06-07 17:15:13.171+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.181+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:185,0.305548,-0.087379,9.801499
06-07 17:15:13.181+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:13:156,0.070000,0.070000,0.070000
06-07 17:15:13.181+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.181+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:13.181+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:191,0.304509,-0.090487,9.801503
06-07 17:15:13.191+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.191+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:13:181,0.299103,-0.105284,9.824929
06-07 17:15:13.191+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:197,0.304570,-0.090982,9.801497
06-07 17:15:13.191+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.201+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:15:13.201+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:15:13.201+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:13:182,0.032398,-0.022228,0.052035
06-07 17:15:13.201+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:203,0.305210,-0.092345,9.801464
06-07 17:15:13.201+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.201+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.211+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:210,0.305756,-0.092306,9.801448
06-07 17:15:13.211+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.211+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:13:201,0.070000,0.070000,0.070000
06-07 17:15:13.211+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:218,0.306015,-0.091692,9.801445
06-07 17:15:13.211+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.211+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.221+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:224,0.307034,-0.093571,9.801395
06-07 17:15:13.221+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.221+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:230,0.306288,-0.092903,9.801426
06-07 17:15:13.221+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.231+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope - capturing data
06-07 17:15:13.231+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:235,0.305857,-0.093307,9.801435
06-07 17:15:13.231+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.241+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:243,0.306106,-0.092095,9.801438
06-07 17:15:13.241+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.241+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:15:13:226,0.036071,-0.030954,0.073613
06-07 17:15:13.241+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:15:13:224,0.356531,-0.083749,9.872787
06-07 17:15:13.251+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:250,0.306337,-0.092481,9.801428
06-07 17:15:13.251+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.251+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:259,0.307223,-0.093343,9.801392
06-07 17:15:13.251+0200 I/linearacceleration(18620): es.ugr.frailty.linearacceleration - capturing data
06-07 17:15:13.251+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.261+0200 I/gyroscope(18556): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:15:13:250,0.140000,0.070000,0.070000
06-07 17:15:13.261+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:264,0.308441,-0.092468,9.801362
06-07 17:15:13.261+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.261+0200 I/accelerometer(18571): es.ugr.frailty.accelerometer - capturing data
06-07 17:15:13.261+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:271,0.309563,-0.094230,9.801310
06-07 17:15:13.271+0200 I/gravity (18583): es.ugr.frailty.gravity - capturing data
06-07 17:15:13.271+0200 I/gravity (18583): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:15:13:277,0.309017,-0.094224,9.801327
06-07 17:15:13.271+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11186896c6f63152838451
