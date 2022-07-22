S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 18913
Date: 2018-06-07 17:16:00+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf757652d, r5   = 0xf7be9f98
r6   = 0xffca01c0, r7   = 0xffca0070
r8   = 0xf7be6c18, r9   = 0x00000000
r10  = 0xffca014c, fp   = 0xffca01c0
ip   = 0x00000001, sp   = 0xffca0048
lr   = 0xf7576539, pc   = 0xf75df228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     31332 KB
Buffers:      7040 KB
Cached:      52932 KB
VmPeak:      53460 KB
VmSize:      53448 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11480 KB
VmRSS:       11480 KB
VmData:      11176 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 18913 TID = 18913
18913 18944 

Maps Information
f4441000 f4c40000 rw-p [stack:18944]
f4c47000 f4c49000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c51000 f4c55000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c5e000 f4c60000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c68000 f4c6b000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c7a000 f4c7f000 r-xp /usr/lib/libsystem.so.0.0.0
f4c8a000 f4c8d000 r-xp /lib/libattr.so.1.1.0
f4c95000 f4ca5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cad000 f4cb6000 r-xp /usr/lib/libedbus.so.1.7.99
f4cbe000 f4cbf000 r-xp /usr/lib/libresponse.so.0.2.96
f4cc8000 f4ccd000 r-xp /usr/lib/libproc-stat.so.0.2.96
f656f000 f6675000 r-xp /usr/lib/libicuuc.so.57.1
f668b000 f6813000 r-xp /usr/lib/libicui18n.so.57.1
f6823000 f6830000 r-xp /usr/lib/libail.so.0.1.0
f6839000 f6840000 r-xp /usr/lib/libminizip.so.1.0.0
f6849000 f69f2000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a12000 f6a59000 r-xp /usr/lib/libssl.so.1.0.0
f6a65000 f6a67000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a6f000 f6a76000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a7f000 f6a86000 r-xp /lib/libcrypt-2.13.so
f6ab7000 f6aba000 r-xp /lib/libcap.so.2.21
f6ac2000 f6ac4000 r-xp /usr/lib/libiri.so
f6acc000 f6b15000 r-xp /usr/lib/libmdm.so.1.2.69
f6b1d000 f6b23000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b2b000 f6b4e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b58000 f6b5a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b62000 f6b7f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b88000 f6b8c000 r-xp /usr/lib/libsmack.so.1.0.0
f6b95000 f6bae000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bb7000 f6bbf000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bc7000 f6bcd000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bd6000 f6bd8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6be1000 f6bf1000 r-xp /lib/libresolv-2.13.so
f6bf5000 f6c0d000 r-xp /usr/lib/liblzma.so.5.0.3
f6c16000 f6c18000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c20000 f6c3a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c42000 f6c71000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c7a000 f6c89000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c93000 f6c9d000 r-xp /usr/lib/libsensord-shared.so
f6ca6000 f6d79000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d84000 f6d9a000 r-xp /lib/libz.so.1.2.5
f6da2000 f6da7000 r-xp /usr/lib/libffi.so.5.0.10
f6daf000 f6db0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6db8000 f6dc8000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dd0000 f6de9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6df1000 f6df3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dfb000 f6e70000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e7a000 f6e80000 r-xp /lib/librt-2.13.so
f6e89000 f6ea7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb1000 f6eb2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eba000 f6edd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ee5000 f6eea000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ef2000 f6f1c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f25000 f6f3c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f44000 f6fad000 r-xp /lib/libm-2.13.so
f6fb6000 f704a000 r-xp /usr/lib/libstdc++.so.6.0.16
f705d000 f7062000 r-xp /usr/lib/libctx-client.so.0.8.3
f706a000 f7071000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7079000 f70a3000 r-xp /usr/lib/libsensor.so.1.9.6
f70ac000 f7178000 r-xp /usr/lib/libxml2.so.2.7.8
f7185000 f7187000 r-xp /usr/lib/libiniparser.so.0
f7190000 f7196000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f719f000 f726f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7270000 f72a4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72ad000 f72e9000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72f1000 f72f4000 r-xp /usr/lib/libbundle.so.0.1.22
f72fc000 f7302000 r-xp /usr/lib/libappsvc.so.0.1.0
f730a000 f734b000 r-xp /usr/lib/libeina.so.1.7.99
f7354000 f736b000 r-xp /usr/lib/libecore.so.1.7.99
f7382000 f738b000 r-xp /usr/lib/libvconf.so.0.2.45
f7393000 f73a7000 r-xp /lib/libpthread-2.13.so
f73b2000 f73bf000 r-xp /usr/lib/libaul.so.0.1.0
f73c9000 f73cb000 r-xp /lib/libdl-2.13.so
f73d4000 f73df000 r-xp /lib/libunwind.so.8.0.1
f740c000 f7414000 r-xp /lib/libgcc_s-4.6.so.1
f7415000 f7539000 r-xp /lib/libc-2.13.so
f7547000 f7549000 r-xp /usr/lib/libdlog.so.0.0.0
f7551000 f755d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7566000 f756b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7573000 f7582000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f758a000 f758e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7597000 f759a000 r-xp /usr/lib/libappcore-agent.so.1.1
f75a2000 f75a4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75ac000 f75b0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75b8000 f75d5000 r-xp /lib/ld-2.13.so
f75de000 f75e1000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75e1000 f75e5000 r-xp /usr/lib/libsys-assert.so
f7bb6000 f7c27000 rw-p [heap]
ffc81000 ffca2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18913)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75df228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7576539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf727d3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf727bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7287e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf728dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf728ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72c275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72bd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf727bc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7287e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf728dbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf728ddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72bfe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72c0017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72c7f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c5f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c52171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d25663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71d2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71d47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7364ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf735fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73605a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7360879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7598183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75987fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75df5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf742c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf75def2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 17:16:00.271+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:275,0.310452,-0.098399,9.801241
06-07 17:16:00.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.281+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.281+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:282,-0.001859,-0.017231,0.059475
06-07 17:16:00.281+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.281+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.291+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:290,0.309420,-0.100100,9.801256
06-07 17:16:00.291+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.301+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:296,0.041777,0.031234,0.016392
06-07 17:16:00.301+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.301+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:311,0.016445,0.005700,0.081026
06-07 17:16:00.311+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:292,0.320638,-0.110070,9.896714
06-07 17:16:00.311+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:305,0.307761,-0.099459,9.801315
06-07 17:16:00.311+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.311+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.311+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:285,-0.070000,0.070000,0.070000
06-07 17:16:00.311+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.321+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:319,0.307841,-0.099736,9.801310
06-07 17:16:00.321+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.331+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:326,0.366102,-0.066999,9.872787
06-07 17:16:00.331+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.341+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:326,0.080337,0.017491,0.033190
06-07 17:16:00.341+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:329,-0.070000,0.070000,0.070000
06-07 17:16:00.341+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:341,0.309796,-0.098076,9.801265
06-07 17:16:00.351+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.351+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.351+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.351+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:359,0.342174,-0.064606,9.860823
06-07 17:16:00.361+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.371+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:371,0.140000,0.140000,0.070000
06-07 17:16:00.371+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.371+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.371+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:358,-0.000254,0.026666,0.018956
06-07 17:16:00.371+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:380,0.140000,0.070000,0.070000
06-07 17:16:00.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.381+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:386,0.070000,0.070000,0.070000
06-07 17:16:00.391+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:366,0.310708,-0.096330,9.801253
06-07 17:16:00.391+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.391+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.391+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:397,-0.070000,0.070000,0.140000
06-07 17:16:00.391+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.401+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:404,-0.070000,0.070000,0.070000
06-07 17:16:00.401+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:398,0.002234,-0.015423,0.073974
06-07 17:16:00.401+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.401+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:00.411+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:412,0.070000,0.070000,0.070000
06-07 17:16:00.411+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.411+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:00:415,993.000000
06-07 17:16:00.421+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:421,-0.070000,0.070000,0.070000
06-07 17:16:00.421+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:387,0.354138,-0.069392,9.858429
06-07 17:16:00.421+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.421+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.431+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:00.431+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:00.431+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:433,0.320638,-0.078963,9.841680
06-07 17:16:00.431+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:432,-0.070000,0.070000,0.070000
06-07 17:16:00.451+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.461+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:462,-0.070000,0.070000,0.070000
06-07 17:16:00.461+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.471+0200 W/LOCATION(18913): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:16:00.471+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:426,0.312081,-0.094911,9.801224
06-07 17:16:00.481+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.481+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:443,0.337388,-0.100499,9.887143
06-07 17:16:00.481+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:473,-0.070000,0.070000,0.070000
06-07 17:16:00.481+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.491+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:495,-0.070000,0.070000,0.070000
06-07 17:16:00.491+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.501+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.511+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:503,-0.070000,0.070000,0.070000
06-07 17:16:00.511+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:518,0.289532,-0.100499,9.872787
06-07 17:16:00.511+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.521+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:489,0.000246,0.020989,0.064395
06-07 17:16:00.521+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:517,0.312004,-0.093965,9.801235
06-07 17:16:00.521+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:525,0.070000,0.070000,0.070000
06-07 17:16:00.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.531+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.531+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.531+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:536,0.070000,0.070000,0.070000
06-07 17:16:00.541+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.541+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.551+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:538,-0.011261,0.007819,0.066760
06-07 17:16:00.551+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:544,0.282353,-0.148355,9.911072
06-07 17:16:00.551+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:553,0.070000,0.070000,0.070000
06-07 17:16:00.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.561+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:570,0.070000,0.070000,0.140000
06-07 17:16:00.561+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.561+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:546,0.312959,-0.094109,9.801203
06-07 17:16:00.571+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.581+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.581+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.581+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:577,0.277567,-0.086142,9.882358
06-07 17:16:00.581+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:575,0.003399,0.010090,0.064358
06-07 17:16:00.581+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.591+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:597,0.351745,-0.076570,9.844072
06-07 17:16:00.591+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:589,-0.070000,0.070000,0.070000
06-07 17:16:00.601+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:585,0.311288,-0.094222,9.801255
06-07 17:16:00.601+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.601+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.601+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:00.611+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.611+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:00:614,990.000000
06-07 17:16:00.611+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:609,0.308891,-0.096407,9.801310
06-07 17:16:00.621+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:592,-0.011350,-0.040385,0.061975
06-07 17:16:00.621+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.631+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:623,0.325424,-0.150748,9.851252
06-07 17:16:00.631+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:616,-0.070000,0.070000,0.070000
06-07 17:16:00.631+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:00.631+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:00.631+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.631+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.641+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.641+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:627,-0.024674,0.009173,0.066744
06-07 17:16:00.641+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:644,0.356531,-0.078963,9.865608
06-07 17:16:00.651+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:648,0.070000,0.070000,0.070000
06-07 17:16:00.651+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.651+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.651+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:661,0.012877,-0.010610,0.095399
06-07 17:16:00.661+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:640,0.306893,-0.095710,9.801379
06-07 17:16:00.661+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.661+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.661+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:661,0.356531,-0.107677,9.836893
06-07 17:16:00.671+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.671+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:668,0.308120,-0.094506,9.801353
06-07 17:16:00.681+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.681+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:680,0.344566,-0.114855,9.836893
06-07 17:16:00.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:674,0.070000,0.070000,0.070000
06-07 17:16:00.681+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.691+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.691+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:687,0.058261,0.032737,0.071477
06-07 17:16:00.691+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.701+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:698,0.311067,-0.133998,9.868000
06-07 17:16:00.701+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.701+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.711+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:699,0.308723,-0.096907,9.801311
06-07 17:16:00.711+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:694,0.070000,0.070000,0.140000
06-07 17:16:00.711+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.721+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:711,0.032378,0.033470,0.059558
06-07 17:16:00.721+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:715,0.311067,-0.133998,9.844072
06-07 17:16:00.721+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.721+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.721+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.721+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:729,0.310292,-0.095905,9.801270
06-07 17:16:00.731+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:733,0.351745,-0.088534,9.839286
06-07 17:16:00.731+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:721,0.070000,0.070000,0.070000
06-07 17:16:00.731+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.741+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.741+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.751+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:728,0.043430,0.026939,0.057176
06-07 17:16:00.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:746,0.308674,-0.102891,9.851252
06-07 17:16:00.751+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.751+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.761+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:751,0.311759,-0.096128,9.801222
06-07 17:16:00.761+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:744,0.070000,0.070000,0.070000
06-07 17:16:00.761+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:764,0.303888,-0.095713,9.858429
06-07 17:16:00.771+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:764,0.008557,0.015948,0.040456
06-07 17:16:00.771+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.771+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.781+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.781+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:782,0.299103,-0.088534,9.860823
06-07 17:16:00.781+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.791+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:780,0.312655,-0.096664,9.801188
06-07 17:16:00.791+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:787,0.070000,0.070000,0.070000
06-07 17:16:00.791+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.791+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.801+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:792,0.025384,-0.006533,0.085908
06-07 17:16:00.801+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer alive timeout
06-07 17:16:00.801+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:16:00.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.801+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:00.811+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:00:812,990.000000
06-07 17:16:00.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18800
06-07 17:16:00.821+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:800,0.315853,-0.095713,9.863215
06-07 17:16:00.821+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.821+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18800)
06-07 17:16:00.821+0200 I/servicemanager(17973): es.ugr.frailty.accelerometer launch request sent!
06-07 17:16:00.821+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.821+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope alive timeout
06-07 17:16:00.821+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:16:00.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.831+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:00.831+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:00.831+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18781
06-07 17:16:00.831+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:831,0.339781,-0.088534,9.868000
06-07 17:16:00.841+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18781)
06-07 17:16:00.841+0200 I/servicemanager(17973): es.ugr.frailty.gyroscope launch request sent!
06-07 17:16:00.841+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.841+0200 I/servicemanager(17973): es.ugr.frailty.heartrate alive timeout
06-07 17:16:00.841+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:16:00.841+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.841+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.841+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.851+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18034
06-07 17:16:00.851+0200 W/CAPI_APPFW_APP_CONTROL(18034): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:00.851+0200 I/utils   (18034): specific action
06-07 17:16:00.861+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:00.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(18034), cmd(0)
06-07 17:16:00.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18034)
06-07 17:16:00.861+0200 I/servicemanager(17973): es.ugr.frailty.heartrate launch request sent!
06-07 17:16:00.861+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.861+0200 I/servicemanager(17973): es.ugr.frailty.location alive timeout
06-07 17:16:00.861+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:16:00.861+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:855,0.291924,-0.095713,9.844072
06-07 17:16:00.861+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.861+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.871+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.871+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18913
06-07 17:16:00.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18913)
06-07 17:16:00.881+0200 I/servicemanager(17973): es.ugr.frailty.location launch request sent!
06-07 17:16:00.881+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.881+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration alive timeout
06-07 17:16:00.881+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:16:00.881+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.881+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.891+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:879,0.330210,-0.081356,9.889536
06-07 17:16:00.891+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18828
06-07 17:16:00.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18828)
06-07 17:16:00.901+0200 I/servicemanager(17973): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:16:00.901+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.901+0200 I/servicemanager(17973): es.ugr.frailty.gravity alive timeout
06-07 17:16:00.901+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.901+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:16:00.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.911+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18805
06-07 17:16:00.911+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18805)
06-07 17:16:00.921+0200 I/servicemanager(17973): es.ugr.frailty.gravity launch request sent!
06-07 17:16:00.921+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.921+0200 I/servicemanager(17973): es.ugr.frailty.pressure alive timeout
06-07 17:16:00.921+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:16:00.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18075
06-07 17:16:00.931+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:901,0.323031,-0.100499,9.846465
06-07 17:16:00.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18075)
06-07 17:16:00.931+0200 I/servicemanager(17973): es.ugr.frailty.pressure launch request sent!
06-07 17:16:00.931+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.931+0200 I/servicemanager(17973): es.ugr.frailty.light alive timeout
06-07 17:16:00.931+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:16:00.931+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.941+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:801,-0.070000,0.070000,0.070000
06-07 17:16:00.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.941+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:00.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18079
06-07 17:16:00.951+0200 W/CAPI_APPFW_APP_CONTROL(18079): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:00.951+0200 I/utils   (18079): specific action
06-07 17:16:00.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:00.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(18079), cmd(0)
06-07 17:16:00.951+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:921,-0.023428,-0.006389,0.071584
06-07 17:16:00.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:00.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18075), cmd(0)
06-07 17:16:00.961+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.961+0200 W/CAPI_APPFW_APP_CONTROL(18075): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:00.961+0200 I/utils   (18075): specific action
06-07 17:16:00.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18079)
06-07 17:16:00.961+0200 I/servicemanager(17973): es.ugr.frailty.light launch request sent!
06-07 17:16:00.961+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.961+0200 I/servicemanager(17973): es.ugr.frailty.pedometer alive timeout
06-07 17:16:00.961+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:16:00.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:16:00.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 17973
06-07 17:16:00.961+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:952,0.337388,-0.083749,9.841680
06-07 17:16:00.971+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:00:967,0.070000,0.070000,0.070000
06-07 17:16:00.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 18111
06-07 17:16:00.971+0200 W/CAPI_APPFW_APP_CONTROL(18111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:16:00.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:16:00.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(18111), cmd(0)
06-07 17:16:00.981+0200 I/utils   (18111): specific action
06-07 17:16:00.981+0200 W/AUL     (17973): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18111)
06-07 17:16:00.981+0200 I/servicemanager(17973): es.ugr.frailty.pedometer launch request sent!
06-07 17:16:00.981+0200 I/servicemanager(17973): App control destroyed.
06-07 17:16:00.981+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:907,0.311917,-0.098063,9.801198
06-07 17:16:00.981+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.981+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:00.991+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:992,0.311563,-0.099460,9.801195
06-07 17:16:00.991+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:00.991+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:00:969,-0.028935,-0.054133,0.109817
06-07 17:16:00.991+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:00.991+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:00:998,0.313176,-0.098832,9.801149
06-07 17:16:01.001+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.001+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.001+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:01.011+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:8,0.312795,-0.098878,9.801162
06-07 17:16:01.011+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.011+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:01:12,985.000000
06-07 17:16:01.011+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:4,-0.031323,0.010265,0.081048
06-07 17:16:01.011+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.021+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:00:997,0.287139,-0.100499,9.863215
06-07 17:16:01.021+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:21,0.044852,0.019139,0.042693
06-07 17:16:01.021+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.021+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:17,0.312194,-0.098574,9.801184
06-07 17:16:01.021+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.031+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:7,0.070000,0.070000,0.070000
06-07 17:16:01.031+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:01.031+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:01.031+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:47,0.070000,0.070000,0.070000
06-07 17:16:01.041+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.051+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:54,0.070000,0.070000,0.070000
06-07 17:16:01.051+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:61,0.070000,0.070000,0.070000
06-07 17:16:01.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:16:01.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:16:01.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.031+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:31,0.017304,-0.056242,0.049899
06-07 17:16:01.031+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:33,0.311400,-0.097938,9.801215
06-07 17:16:01.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:16:01.061+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:69,-0.070000,0.070000,0.070000
06-07 17:16:01.071+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.071+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.071+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:77,-0.140000,-0.070000,0.070000
06-07 17:16:01.071+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.081+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:46,0.284746,-0.117248,9.877571
06-07 17:16:01.081+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:78,0.311112,-0.097629,9.801228
06-07 17:16:01.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:85,0.070000,-0.070000,0.070000
06-07 17:16:01.081+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.081+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.091+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.091+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.091+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:95,0.070000,0.070000,0.140000
06-07 17:16:01.091+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.101+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:102,0.070000,0.070000,0.070000
06-07 17:16:01.101+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.101+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:109,-0.140000,0.070000,0.070000
06-07 17:16:01.101+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.111+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:115,-0.140000,0.070000,0.070000
06-07 17:16:01.111+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.111+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:107,0.311643,-0.096856,9.801218
06-07 17:16:01.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:122,0.070000,0.070000,0.070000
06-07 17:16:01.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.121+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:100,0.047807,0.017944,0.064298
06-07 17:16:01.121+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:129,0.070000,0.070000,0.070000
06-07 17:16:01.121+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.131+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:135,0.070000,0.070000,0.070000
06-07 17:16:01.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.131+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:105,0.313460,-0.102891,9.887143
06-07 17:16:01.131+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.131+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:140,0.070000,0.070000,0.070000
06-07 17:16:01.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:146,0.070000,0.070000,0.070000
06-07 17:16:01.141+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.151+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:153,0.070000,0.070000,0.070000
06-07 17:16:01.151+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.151+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:158,0.070000,0.070000,0.070000
06-07 17:16:01.151+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:143,0.046239,-0.011772,0.035623
06-07 17:16:01.151+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.161+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:147,0.310540,-0.096662,9.801255
06-07 17:16:01.161+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:164,0.070000,-0.070000,0.070000
06-07 17:16:01.161+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.161+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:151,0.282353,-0.100499,9.908678
06-07 17:16:01.171+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.171+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:172,0.070000,0.070000,0.070000
06-07 17:16:01.171+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.171+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.171+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.171+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:179,0.140000,0.140000,0.070000
06-07 17:16:01.181+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.181+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:187,0.070000,0.070000,0.070000
06-07 17:16:01.181+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.191+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:194,0.140000,0.070000,0.070000
06-07 17:16:01.191+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.191+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:200,0.070000,0.070000,0.070000
06-07 17:16:01.201+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.201+0200 I/light   (18079): es.ugr.frailty.light - capturing data
06-07 17:16:01.201+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:208,0.070000,0.070000,0.070000
06-07 17:16:01.211+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.211+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:216,0.140000,0.070000,0.070000
06-07 17:16:01.211+0200 I/light   (18079): es.ugr.frailty.light: SM-R760,07/06/2018,17:16:01:213,987.000000
06-07 17:16:01.211+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.221+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:183,0.032807,-0.018728,0.035671
06-07 17:16:01.221+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:186,0.311169,-0.095779,9.801244
06-07 17:16:01.221+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:223,0.140000,0.070000,0.070000
06-07 17:16:01.221+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.221+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.221+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:193,0.299103,-0.093320,9.856036
06-07 17:16:01.221+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:230,0.140000,0.070000,0.070000
06-07 17:16:01.231+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.231+0200 I/heartrate(18034): es.ugr.frailty.heartrate - capturing data
06-07 17:16:01.231+0200 I/heartrate(18034): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:16:01.231+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.231+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:238,0.140000,-0.070000,0.070000
06-07 17:16:01.231+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.241+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.241+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:244,0.070000,-0.070000,0.140000
06-07 17:16:01.241+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.251+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:251,0.070000,-0.070000,0.070000
06-07 17:16:01.251+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.251+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:257,0.070000,-0.070000,0.070000
06-07 17:16:01.251+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.261+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:246,0.311562,-0.095856,9.801230
06-07 17:16:01.261+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:236,-0.001589,-0.037334,0.066812
06-07 17:16:01.261+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:264,0.070000,-0.070000,0.070000
06-07 17:16:01.261+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.261+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:245,0.311067,-0.050249,9.879964
06-07 17:16:01.261+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:270,0.070000,0.070000,0.070000
06-07 17:16:01.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:277,0.140000,0.070000,0.070000
06-07 17:16:01.271+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.271+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.271+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.281+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:283,0.070000,-0.070000,0.070000
06-07 17:16:01.281+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.281+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.281+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:290,0.070000,-0.070000,0.070000
06-07 17:16:01.281+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.291+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:285,-0.000850,-0.035935,0.042874
06-07 17:16:01.291+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:295,0.070000,-0.070000,0.070000
06-07 17:16:01.291+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.301+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:301,0.070000,-0.070000,0.070000
06-07 17:16:01.301+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:291,0.312533,-0.095151,9.801207
06-07 17:16:01.291+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:289,0.303888,-0.074178,9.930215
06-07 17:16:01.301+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.311+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.311+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.321+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.321+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:321,0.040182,0.010926,0.038091
06-07 17:16:01.331+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:319,0.140000,0.070000,0.070000
06-07 17:16:01.341+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.341+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:334,0.334995,-0.083749,9.865608
06-07 17:16:01.351+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.351+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.361+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:311,0.310563,-0.095068,9.801270
06-07 17:16:01.361+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.361+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:363,0.070000,0.070000,0.070000
06-07 17:16:01.361+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.361+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:354,-0.004501,-0.004059,0.050102
06-07 17:16:01.371+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration - capturing data
06-07 17:16:01.371+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:369,0.308788,-0.095944,9.801318
06-07 17:16:01.371+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:16:01:363,0.349352,-0.150748,9.879964
06-07 17:16:01.371+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:16:01:374,0.070000,0.070000,0.070000
06-07 17:16:01.381+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:383,0.308488,-0.096059,9.801326
06-07 17:16:01.381+0200 I/gyroscope(18781): es.ugr.frailty.gyroscope - capturing data
06-07 17:16:01.381+0200 I/accelerometer(18800): es.ugr.frailty.accelerometer - capturing data
06-07 17:16:01.391+0200 I/gravity (18805): es.ugr.frailty.gravity - capturing data
06-07 17:16:01.391+0200 I/gravity (18805): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:16:01:396,0.306432,-0.095912,9.801392
06-07 17:16:01.391+0200 I/linearacceleration(18828): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:16:01:382,-0.008906,0.003165,0.057267
06-07 17:16:01.391+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11189136c6f63152838456
