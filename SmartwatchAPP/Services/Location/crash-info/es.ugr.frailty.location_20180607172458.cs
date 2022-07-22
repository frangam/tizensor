S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21288
Date: 2018-06-07 17:24:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf742452d, r5   = 0xf79b9f98
r6   = 0xffea9430, r7   = 0xffea92e0
r8   = 0xf79b6c18, r9   = 0x00000000
r10  = 0xffea93bc, fp   = 0xffea9430
ip   = 0x00000001, sp   = 0xffea92b8
lr   = 0xf7424539, pc   = 0xf748d228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    108928 KB
Buffers:     16616 KB
Cached:     114128 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11568 KB
VmRSS:       11568 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21288 TID = 21288
21288 21294 

Maps Information
f42ef000 f4aee000 rw-p [stack:21294]
f4af5000 f4af7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4aff000 f4b03000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b0c000 f4b0e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b16000 f4b19000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b28000 f4b2d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b38000 f4b3b000 r-xp /lib/libattr.so.1.1.0
f4b43000 f4b53000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b5b000 f4b64000 r-xp /usr/lib/libedbus.so.1.7.99
f4b6c000 f4b6d000 r-xp /usr/lib/libresponse.so.0.2.96
f4b76000 f4b7b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f641d000 f6523000 r-xp /usr/lib/libicuuc.so.57.1
f6539000 f66c1000 r-xp /usr/lib/libicui18n.so.57.1
f66d1000 f66de000 r-xp /usr/lib/libail.so.0.1.0
f66e7000 f66ee000 r-xp /usr/lib/libminizip.so.1.0.0
f66f7000 f68a0000 r-xp /usr/lib/libcrypto.so.1.0.0
f68c0000 f6907000 r-xp /usr/lib/libssl.so.1.0.0
f6913000 f6915000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f691d000 f6924000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f692d000 f6934000 r-xp /lib/libcrypt-2.13.so
f6965000 f6968000 r-xp /lib/libcap.so.2.21
f6970000 f6972000 r-xp /usr/lib/libiri.so
f697a000 f69c3000 r-xp /usr/lib/libmdm.so.1.2.69
f69cb000 f69d1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69d9000 f69fc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a06000 f6a08000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a10000 f6a2d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a36000 f6a3a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a43000 f6a5c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a65000 f6a6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a75000 f6a7b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a84000 f6a86000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a8f000 f6a9f000 r-xp /lib/libresolv-2.13.so
f6aa3000 f6abb000 r-xp /usr/lib/liblzma.so.5.0.3
f6ac4000 f6ac6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ace000 f6ae8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6af0000 f6b1f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b28000 f6b37000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b41000 f6b4b000 r-xp /usr/lib/libsensord-shared.so
f6b54000 f6c27000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c32000 f6c48000 r-xp /lib/libz.so.1.2.5
f6c50000 f6c55000 r-xp /usr/lib/libffi.so.5.0.10
f6c5d000 f6c5e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c66000 f6c76000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c7e000 f6c97000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c9f000 f6ca1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ca9000 f6d1e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d28000 f6d2e000 r-xp /lib/librt-2.13.so
f6d37000 f6d55000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d5f000 f6d60000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d68000 f6d8b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d93000 f6d98000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6da0000 f6dca000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6dd3000 f6dea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6df2000 f6e5b000 r-xp /lib/libm-2.13.so
f6e64000 f6ef8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f0b000 f6f10000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f18000 f6f1f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f27000 f6f51000 r-xp /usr/lib/libsensor.so.1.9.6
f6f5a000 f7026000 r-xp /usr/lib/libxml2.so.2.7.8
f7033000 f7035000 r-xp /usr/lib/libiniparser.so.0
f703e000 f7044000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f704d000 f711d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f711e000 f7152000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f715b000 f7197000 r-xp /usr/lib/libSLP-location.so.0.9.24
f719f000 f71a2000 r-xp /usr/lib/libbundle.so.0.1.22
f71aa000 f71b0000 r-xp /usr/lib/libappsvc.so.0.1.0
f71b8000 f71f9000 r-xp /usr/lib/libeina.so.1.7.99
f7202000 f7219000 r-xp /usr/lib/libecore.so.1.7.99
f7230000 f7239000 r-xp /usr/lib/libvconf.so.0.2.45
f7241000 f7255000 r-xp /lib/libpthread-2.13.so
f7260000 f726d000 r-xp /usr/lib/libaul.so.0.1.0
f7277000 f7279000 r-xp /lib/libdl-2.13.so
f7282000 f728d000 r-xp /lib/libunwind.so.8.0.1
f72ba000 f72c2000 r-xp /lib/libgcc_s-4.6.so.1
f72c3000 f73e7000 r-xp /lib/libc-2.13.so
f73f5000 f73f7000 r-xp /usr/lib/libdlog.so.0.0.0
f73ff000 f740b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7414000 f7419000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7421000 f7430000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7438000 f743c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7445000 f7448000 r-xp /usr/lib/libappcore-agent.so.1.1
f7450000 f7452000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f745a000 f745e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7466000 f7483000 r-xp /lib/ld-2.13.so
f748c000 f748f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f748f000 f7493000 r-xp /usr/lib/libsys-assert.so
f7986000 f7a14000 rw-p [heap]
ffe8a000 ffeab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21288)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf748d228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7424539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf712b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7129c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7135e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf713bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf713bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf717075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf716b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7129c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7135e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf713bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf713bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf716de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf716e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7175f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4b0d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4b00171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6bd3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7080fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70827a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7212ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf720db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf720e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf720e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7446183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74467fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf748d5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72da85c) [/lib/libc.so.6] + 0x1785c
29: (0xf748cf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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

06-07 17:27:12.631+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:621,0.332602,-0.105284,9.836893
06-07 17:27:12.631+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:600,0.314489,-0.089866,9.801194
06-07 17:27:12.631+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.641+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.651+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:647,0.315011,-0.090292,9.801173
06-07 17:27:12.651+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.651+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:627,0.070000,0.070000,0.070000
06-07 17:27:12.661+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.661+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:667,0.327817,-0.102891,9.820145
06-07 17:27:12.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:12.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:12.671+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:650,-0.093830,0.053018,0.010949
06-07 17:27:12.681+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.681+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.691+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:695,0.314711,-0.089661,9.801188
06-07 17:27:12.691+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:678,0.070000,0.070000,0.070000
06-07 17:27:12.701+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:702,-0.010113,0.020945,0.035771
06-07 17:27:12.701+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.711+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.721+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.721+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:721,0.070000,0.070000,0.070000
06-07 17:27:12.741+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:12.741+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:12:747,946.000000
06-07 17:27:12.741+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.761+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:716,0.334995,-0.148355,9.841680
06-07 17:27:12.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.761+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:733,0.312654,-0.089070,9.801260
06-07 17:27:12.791+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:756,-0.027680,0.006054,-0.008286
06-07 17:27:12.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.801+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:775,0.070000,0.070000,0.140000
06-07 17:27:12.801+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:778,0.311067,-0.088534,9.836893
06-07 17:27:12.811+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.811+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:817,0.337388,-0.086142,9.824929
06-07 17:27:12.821+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:797,0.311711,-0.091235,9.801270
06-07 17:27:12.821+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.831+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.831+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:805,-0.018526,0.001094,0.056303
06-07 17:27:12.841+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.851+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:836,0.070000,0.070000,0.070000
06-07 17:27:12.861+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:12.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:12.871+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:853,0.003159,0.065777,0.060638
06-07 17:27:12.871+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.871+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:875,0.070000,0.070000,0.070000
06-07 17:27:12.881+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:843,0.312678,-0.092475,9.801228
06-07 17:27:12.881+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.881+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:888,0.311986,-0.092204,9.801252
06-07 17:27:12.891+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.901+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:881,0.323031,-0.074178,9.827322
06-07 17:27:12.911+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.911+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:916,0.070000,0.070000,0.070000
06-07 17:27:12.921+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:896,-0.018561,0.009788,0.007800
06-07 17:27:12.921+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.921+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.931+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:935,0.311462,-0.091464,9.801276
06-07 17:27:12.931+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:12.941+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:12.941+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:12:947,947.000000
06-07 17:27:12.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:12.961+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:12:954,-0.022078,0.025666,0.074524
06-07 17:27:12.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:12:981,0.140000,0.070000,0.070000
06-07 17:27:12.981+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:12.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:933,0.311067,-0.086142,9.848858
06-07 17:27:12.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:12.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.001+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.011+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:12:995,0.325424,-0.112463,9.853643
06-07 17:27:13.011+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:5,0.000935,-0.016783,0.074265
06-07 17:27:13.011+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:12:991,0.310459,-0.093244,9.801291
06-07 17:27:13.021+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.031+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:37,0.310164,-0.094768,9.801286
06-07 17:27:13.041+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.041+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:13,0.070000,0.070000,0.070000
06-07 17:27:13.051+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.061+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:13.061+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:13.071+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:54,0.025795,-0.003941,0.045188
06-07 17:27:13.071+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:47,0.308674,-0.031107,9.887143
06-07 17:27:13.081+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.081+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.101+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.101+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:63,0.070000,0.070000,0.070000
06-07 17:27:13.101+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.101+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:111,0.070000,0.070000,0.140000
06-07 17:27:13.111+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:95,0.315853,-0.078963,9.887143
06-07 17:27:13.121+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:87,0.309647,-0.096075,9.801290
06-07 17:27:13.121+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.131+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(21939) cmd(0)
06-07 17:27:13.141+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:13.141+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:13:147,954.000000
06-07 17:27:13.141+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.151+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:107,0.018934,-0.015312,0.035674
06-07 17:27:13.151+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.161+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:154,0.279960,-0.114855,9.791430
06-07 17:27:13.181+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:140,0.308807,-0.093741,9.801338
06-07 17:27:13.191+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.241+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:167,0.009177,-0.015515,0.019062
06-07 17:27:13.241+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.251+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.251+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:256,0.299103,-0.078963,9.846465
06-07 17:27:13.251+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.251+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:175,0.070000,0.070000,0.140000
06-07 17:27:13.251+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.261+0200 I/location(21939): es.ugr.frailty.location: waiting for rigth values
06-07 17:27:13.261+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:220,0.308206,-0.093531,9.801359
06-07 17:27:13.271+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.271+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:248,0.014822,-0.056370,0.040689
06-07 17:27:13.271+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:278,0.309984,-0.091934,9.801318
06-07 17:27:13.281+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:261,0.070000,0.070000,0.140000
06-07 17:27:13.281+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:260,0.318245,-0.150748,9.810574
06-07 17:27:13.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.291+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:297,0.070000,0.070000,0.140000
06-07 17:27:13.291+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:13.291+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:13.301+0200 I/location(21939): stopping es.ugr.frailty.location service
06-07 17:27:13.301+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:306,-0.012124,0.007955,0.036045
06-07 17:27:13.301+0200 I/CAPI_APPFW_APPLICATION(21939): service_app_main.c: service_app_exit(441) > service_app_exit
06-07 17:27:13.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 22
06-07 17:27:13.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(999) > app status : 4
06-07 17:27:13.311+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.311+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.331+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.331+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.341+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:349,0.009506,0.028067,0.024427
06-07 17:27:13.351+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:318,0.310353,-0.092368,9.801303
06-07 17:27:13.351+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.351+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:325,0.294317,-0.088534,9.803394
06-07 17:27:13.361+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:27:13.361+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:27:13.361+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:27:13.371+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:346,0.070000,0.070000,0.070000
06-07 17:27:13.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.381+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:13.381+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:13:387,956.000000
06-07 17:27:13.381+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:362,0.310254,-0.091746,9.801311
06-07 17:27:13.381+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.391+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:393,0.310534,-0.091062,9.801310
06-07 17:27:13.391+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.391+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:399,0.308788,-0.090987,9.801365
06-07 17:27:13.391+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.401+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:405,0.308005,-0.089566,9.801403
06-07 17:27:13.401+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.411+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:411,0.307357,-0.091091,9.801409
06-07 17:27:13.411+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.411+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:419,0.306596,-0.090197,9.801441
06-07 17:27:13.411+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.421+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:426,0.306522,-0.089478,9.801450
06-07 17:27:13.421+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.431+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:434,0.306817,-0.091155,9.801425
06-07 17:27:13.431+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.441+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:440,0.307610,-0.091690,9.801395
06-07 17:27:13.441+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.441+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:448,0.309243,-0.093317,9.801329
06-07 17:27:13.441+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.451+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:378,0.330210,-0.078963,9.860823
06-07 17:27:13.461+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:13.461+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:13.481+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:395,0.003491,0.030050,0.026434
06-07 17:27:13.491+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.491+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:383,0.070000,0.070000,0.070000
06-07 17:27:13.501+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:454,0.310298,-0.093625,9.801292
06-07 17:27:13.511+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.511+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.521+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.541+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:13.541+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:13:547,953.000000
06-07 17:27:13.561+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:506,0.320638,-0.086142,9.812965
06-07 17:27:13.561+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:540,0.311251,-0.093205,9.801267
06-07 17:27:13.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:527,-0.011037,0.010858,0.047979
06-07 17:27:13.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:521,0.070000,0.070000,0.070000
06-07 17:27:13.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.591+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.641+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:596,0.006336,-0.024350,0.052582
06-07 17:27:13.641+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:576,0.311067,-0.083749,9.805787
06-07 17:27:13.641+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:600,0.311159,-0.093227,9.801269
06-07 17:27:13.651+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.651+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:594,0.070000,-0.070000,0.070000
06-07 17:27:13.651+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.651+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.661+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:663,-0.004195,0.055016,0.085864
06-07 17:27:13.661+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:13.661+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:13.671+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:661,0.070000,-0.070000,0.070000
06-07 17:27:13.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:656,0.346959,-0.102891,9.820145
06-07 17:27:13.671+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.671+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:666,0.309982,-0.094167,9.801297
06-07 17:27:13.681+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.681+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.681+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:690,0.001903,0.014466,0.085965
06-07 17:27:13.691+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.701+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:689,0.070000,0.070000,0.070000
06-07 17:27:13.711+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:682,0.299103,-0.124427,9.817751
06-07 17:27:13.721+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.721+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:707,0.310102,-0.093068,9.801304
06-07 17:27:13.721+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.731+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.731+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.741+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:13.741+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:13:751,954.000000
06-07 17:27:13.751+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:730,0.330210,-0.124427,9.801002
06-07 17:27:13.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:763,0.308826,-0.092550,9.801349
06-07 17:27:13.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:738,0.070000,0.070000,0.140000
06-07 17:27:13.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:743,-0.028605,-0.044559,-0.010112
06-07 17:27:13.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.791+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.791+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.801+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:798,-0.140000,0.070000,0.070000
06-07 17:27:13.811+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:803,-0.012157,-0.005056,0.045034
06-07 17:27:13.821+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:789,0.291924,-0.098106,9.796216
06-07 17:27:13.821+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.831+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.831+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:807,0.309508,-0.093656,9.801317
06-07 17:27:13.831+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.841+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:13.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:13.871+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:837,0.354138,-0.122034,9.856036
06-07 17:27:13.871+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:853,0.017401,-0.062033,0.008941
06-07 17:27:13.871+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.871+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:845,0.070000,-0.070000,0.070000
06-07 17:27:13.871+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:856,0.309528,-0.091719,9.801334
06-07 17:27:13.871+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.891+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:895,0.070000,0.070000,0.070000
06-07 17:27:13.901+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.901+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.911+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:909,-0.002564,-0.004393,0.001600
06-07 17:27:13.931+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:885,0.318245,-0.102891,9.875179
06-07 17:27:13.931+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.931+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:13.931+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:910,0.310611,-0.090818,9.801309
06-07 17:27:13.941+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:13.941+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:13:949,957.000000
06-07 17:27:13.951+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:13.951+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:13.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:13:954,0.070000,-0.070000,0.070000
06-07 17:27:13.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:13:962,0.310382,-0.090704,9.801317
06-07 17:27:13.971+0200 W/LOCATION(21939): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
06-07 17:27:13.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:13:955,0.320638,-0.124427,9.832108
06-07 17:27:13.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:13.991+0200 I/LOCATION(21939): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
06-07 17:27:14.001+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.001+0200 I/LOCATION(21939): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
06-07 17:27:13.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:13:974,0.027352,0.025534,0.059407
06-07 17:27:14.001+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.001+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.011+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:2,0.070000,0.070000,0.070000
06-07 17:27:14.021+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:11,0.310514,-0.090975,9.801311
06-07 17:27:14.021+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:15,0.023240,0.011772,0.011315
06-07 17:27:14.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:8,0.330210,-0.117248,9.777073
06-07 17:27:14.031+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.031+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.041+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.051+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.051+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:42,0.070000,0.070000,0.070000
06-07 17:27:14.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:14.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:14.071+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:47,0.330210,-0.098106,9.801002
06-07 17:27:14.081+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.091+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:49,0.307692,-0.089464,9.801414
06-07 17:27:14.091+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.091+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.091+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:62,0.006916,0.006656,0.004272
06-07 17:27:14.121+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.121+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:126,0.040551,-0.015116,0.018676
06-07 17:27:14.131+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:98,0.308350,-0.090211,9.801386
06-07 17:27:14.131+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:89,0.070000,0.140000,0.070000
06-07 17:27:14.131+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:100,0.325424,-0.102891,9.832108
06-07 17:27:14.131+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.141+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:14.141+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:14:148,957.000000
06-07 17:27:14.151+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:144,-0.070000,0.140000,0.070000
06-07 17:27:14.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:169,0.342174,-0.093320,9.875179
06-07 17:27:14.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:174,-0.005757,-0.039202,0.016212
06-07 17:27:14.191+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:167,0.306177,-0.089357,9.801462
06-07 17:27:14.191+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.201+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.201+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.221+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.221+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:203,0.070000,0.140000,0.070000
06-07 17:27:14.221+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:228,0.014356,-0.034621,-0.000149
06-07 17:27:14.231+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.231+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:210,0.304578,-0.090039,9.801505
06-07 17:27:14.241+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:214,0.301496,-0.100499,9.836893
06-07 17:27:14.251+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.251+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.251+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.261+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:14.261+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:14.281+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:247,0.070000,0.140000,0.070000
06-07 17:27:14.291+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.291+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:267,-0.015503,0.002028,-0.005102
06-07 17:27:14.291+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:269,0.375673,-0.055035,9.824929
06-07 17:27:14.291+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:263,0.303691,-0.089420,9.801538
06-07 17:27:14.301+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.311+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:316,0.304218,-0.089954,9.801517
06-07 17:27:14.311+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.331+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.331+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:337,0.041435,-0.015119,0.054956
06-07 17:27:14.331+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:299,0.070000,0.140000,0.070000
06-07 17:27:14.341+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:14.341+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:14:348,957.000000
06-07 17:27:14.351+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.371+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:27:14.371+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:27:14.371+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:27:14.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:388,0.015051,-0.000137,0.073756
06-07 17:27:14.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:393,0.003781,-0.016713,0.031171
06-07 17:27:14.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:397,0.016399,-0.012632,-0.023996
06-07 17:27:14.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:403,0.016901,0.011721,-0.000027
06-07 17:27:14.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:412,0.005829,0.010398,0.031322
06-07 17:27:14.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:417,0.018645,0.015832,0.074475
06-07 17:27:14.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:342,0.351745,-0.098106,9.841680
06-07 17:27:14.431+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.441+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:445,0.373280,-0.119641,9.882358
06-07 17:27:14.451+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:423,-0.019600,0.005238,0.036072
06-07 17:27:14.451+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:357,0.070000,0.140000,0.070000
06-07 17:27:14.451+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.451+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:366,0.305196,-0.090931,9.801478
06-07 17:27:14.451+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.451+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.461+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:14.461+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:14.471+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:463,0.070000,0.140000,0.070000
06-07 17:27:14.481+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.501+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:466,0.306164,-0.088976,9.801466
06-07 17:27:14.501+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.511+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:475,0.051429,0.045172,0.024154
06-07 17:27:14.511+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.511+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:517,0.070000,0.070000,0.070000
06-07 17:27:14.521+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.521+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:527,0.308541,-0.089009,9.801391
06-07 17:27:14.521+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:492,0.370888,-0.071785,9.832108
06-07 17:27:14.531+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.541+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:14.541+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:14:550,954.000000
06-07 17:27:14.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.551+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.551+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:533,0.035063,0.003050,0.040667
06-07 17:27:14.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:570,0.070000,0.070000,0.070000
06-07 17:27:14.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:539,0.318245,-0.081356,9.748360
06-07 17:27:14.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.591+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.611+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:617,-0.070000,0.070000,0.140000
06-07 17:27:14.611+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:574,0.307944,-0.088540,9.801414
06-07 17:27:14.621+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.621+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:627,0.307002,-0.088312,9.801446
06-07 17:27:14.641+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:585,0.038449,-0.032377,0.081814
06-07 17:27:14.641+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.641+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:598,0.354138,-0.071785,9.824929
06-07 17:27:14.641+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.641+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.651+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:648,0.033971,0.017744,0.031656
06-07 17:27:14.661+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.661+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:14.661+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:14.661+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.671+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:672,0.306755,-0.087191,9.801463
06-07 17:27:14.671+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:681,-0.027303,0.016533,-0.051712
06-07 17:27:14.681+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:656,0.325424,-0.059821,9.848858
06-07 17:27:14.691+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:659,0.070000,0.070000,0.070000
06-07 17:27:14.701+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.701+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.711+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.731+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.741+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 17:27:14.741+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 17:27:14.741+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 17:27:14.751+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 17:27:14.751+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 17:27:14.761+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:14:761,954.000000
06-07 17:27:14.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:720,0.070000,0.070000,0.070000
06-07 17:27:14.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:712,0.301496,-0.086142,9.801002
06-07 17:27:14.791+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.791+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.791+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:731,0.303571,-0.087065,9.801563
06-07 17:27:14.821+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:827,0.070000,0.070000,0.070000
06-07 17:27:14.831+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:776,0.004306,0.016245,0.024917
06-07 17:27:14.831+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.831+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.841+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:815,0.282353,-0.086142,9.820145
06-07 17:27:14.841+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.841+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.851+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:838,0.302048,-0.088610,9.801597
06-07 17:27:14.851+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:843,-0.011132,0.024975,0.048351
06-07 17:27:14.851+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:14.861+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:14.871+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:857,0.313460,-0.088534,9.808180
06-07 17:27:14.871+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.891+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:855,0.070000,0.070000,0.070000
06-07 17:27:14.891+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:865,0.301664,-0.089053,9.801604
06-07 17:27:14.891+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.891+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.901+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:887,-0.036909,-0.006882,0.000512
06-07 17:27:14.921+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:903,0.070000,0.070000,0.070000
06-07 17:27:14.921+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.921+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:931,0.301332,-0.090349,9.801603
06-07 17:27:14.931+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.931+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:907,0.315853,-0.088534,9.858429
06-07 17:27:14.941+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:14.941+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:14:949,952.000000
06-07 17:27:14.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:14.951+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:14.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:14:959,0.070000,0.070000,0.070000
06-07 17:27:14.971+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:14.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:940,-0.047786,-0.014713,0.019314
06-07 17:27:14.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:14.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:14:974,0.308674,-0.071785,9.858429
06-07 17:27:14.991+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:14:984,0.302829,-0.090836,9.801553
06-07 17:27:14.991+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:15.011+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:14:995,-0.003511,-0.013233,0.006943
06-07 17:27:15.011+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:15.011+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:15.031+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:15:7,0.070000,0.070000,0.070000
06-07 17:27:15.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:15.071+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11212886c6f63152838509
