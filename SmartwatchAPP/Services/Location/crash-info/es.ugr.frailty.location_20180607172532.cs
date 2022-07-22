S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 21361
Date: 2018-06-07 17:25:32+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf752852d, r5   = 0xf7688f98
r6   = 0xffc95f20, r7   = 0xffc95dd0
r8   = 0xf7685c18, r9   = 0x00000000
r10  = 0xffc95eac, fp   = 0xffc95f20
ip   = 0x00000001, sp   = 0xffc95da8
lr   = 0xf7528539, pc   = 0xf7591228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      4232 KB
Buffers:      8192 KB
Cached:      77068 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11820 KB
VmRSS:       11816 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 21361 TID = 21361
21361 21364 

Maps Information
f43f3000 f4bf2000 rw-p [stack:21364]
f4bf9000 f4bfb000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c03000 f4c07000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c10000 f4c12000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c1a000 f4c1d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c2c000 f4c31000 r-xp /usr/lib/libsystem.so.0.0.0
f4c3c000 f4c3f000 r-xp /lib/libattr.so.1.1.0
f4c47000 f4c57000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c5f000 f4c68000 r-xp /usr/lib/libedbus.so.1.7.99
f4c70000 f4c71000 r-xp /usr/lib/libresponse.so.0.2.96
f4c7a000 f4c7f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6521000 f6627000 r-xp /usr/lib/libicuuc.so.57.1
f663d000 f67c5000 r-xp /usr/lib/libicui18n.so.57.1
f67d5000 f67e2000 r-xp /usr/lib/libail.so.0.1.0
f67eb000 f67f2000 r-xp /usr/lib/libminizip.so.1.0.0
f67fb000 f69a4000 r-xp /usr/lib/libcrypto.so.1.0.0
f69c4000 f6a0b000 r-xp /usr/lib/libssl.so.1.0.0
f6a17000 f6a19000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a21000 f6a28000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a31000 f6a38000 r-xp /lib/libcrypt-2.13.so
f6a69000 f6a6c000 r-xp /lib/libcap.so.2.21
f6a74000 f6a76000 r-xp /usr/lib/libiri.so
f6a7e000 f6ac7000 r-xp /usr/lib/libmdm.so.1.2.69
f6acf000 f6ad5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6add000 f6b00000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b0a000 f6b0c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b14000 f6b31000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b3a000 f6b3e000 r-xp /usr/lib/libsmack.so.1.0.0
f6b47000 f6b60000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b69000 f6b71000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b79000 f6b7f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b88000 f6b8a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b93000 f6ba3000 r-xp /lib/libresolv-2.13.so
f6ba7000 f6bbf000 r-xp /usr/lib/liblzma.so.5.0.3
f6bc8000 f6bca000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6bd2000 f6bec000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6bf4000 f6c23000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c2c000 f6c3b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c45000 f6c4f000 r-xp /usr/lib/libsensord-shared.so
f6c58000 f6d2b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d36000 f6d4c000 r-xp /lib/libz.so.1.2.5
f6d54000 f6d59000 r-xp /usr/lib/libffi.so.5.0.10
f6d61000 f6d62000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d6a000 f6d7a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d82000 f6d9b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6da3000 f6da5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6dad000 f6e22000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e2c000 f6e32000 r-xp /lib/librt-2.13.so
f6e3b000 f6e59000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e63000 f6e64000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e6c000 f6e8f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e97000 f6e9c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ea4000 f6ece000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ed7000 f6eee000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ef6000 f6f5f000 r-xp /lib/libm-2.13.so
f6f68000 f6ffc000 r-xp /usr/lib/libstdc++.so.6.0.16
f700f000 f7014000 r-xp /usr/lib/libctx-client.so.0.8.3
f701c000 f7023000 r-xp /usr/lib/libctx-shared.so.0.8.3
f702b000 f7055000 r-xp /usr/lib/libsensor.so.1.9.6
f705e000 f712a000 r-xp /usr/lib/libxml2.so.2.7.8
f7137000 f7139000 r-xp /usr/lib/libiniparser.so.0
f7142000 f7148000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7151000 f7221000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7222000 f7256000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f725f000 f729b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72a3000 f72a6000 r-xp /usr/lib/libbundle.so.0.1.22
f72ae000 f72b4000 r-xp /usr/lib/libappsvc.so.0.1.0
f72bc000 f72fd000 r-xp /usr/lib/libeina.so.1.7.99
f7306000 f731d000 r-xp /usr/lib/libecore.so.1.7.99
f7334000 f733d000 r-xp /usr/lib/libvconf.so.0.2.45
f7345000 f7359000 r-xp /lib/libpthread-2.13.so
f7364000 f7371000 r-xp /usr/lib/libaul.so.0.1.0
f737b000 f737d000 r-xp /lib/libdl-2.13.so
f7386000 f7391000 r-xp /lib/libunwind.so.8.0.1
f73be000 f73c6000 r-xp /lib/libgcc_s-4.6.so.1
f73c7000 f74eb000 r-xp /lib/libc-2.13.so
f74f9000 f74fb000 r-xp /usr/lib/libdlog.so.0.0.0
f7503000 f750f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7518000 f751d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7525000 f7534000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f753c000 f7540000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7549000 f754c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7554000 f7556000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f755e000 f7562000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f756a000 f7587000 r-xp /lib/ld-2.13.so
f7590000 f7593000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7593000 f7597000 r-xp /usr/lib/libsys-assert.so
f7655000 f76e3000 rw-p [heap]
ffc77000 ffc98000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21361)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7591228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7528539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf722f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf722dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7239e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf723fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf723fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf727475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf726f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf722dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7239e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf723fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf723fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7271e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7272017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7279f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c111fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c04171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6cd7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7184fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71867a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7316ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7311b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73125a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7312879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf754a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf754a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75915c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf73de85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7590f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
gth values
06-07 17:27:28.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:28.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:28.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:28.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:28:966,0.284746,-0.100499,9.841680
06-07 17:27:28.961+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:28.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:28.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:28:975,0.307179,-0.094526,9.801382
06-07 17:27:28.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:28:973,-0.039046,-0.007205,0.040820
06-07 17:27:28.981+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:28:970,0.070000,0.070000,0.070000
06-07 17:27:28.981+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:28:962,1027.000000
06-07 17:27:29.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:29.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:29.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:29.161+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:29.161+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:29:166,0.284746,-0.119641,9.836893
06-07 17:27:29.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:29.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:29:169,0.070000,0.070000,0.070000
06-07 17:27:29.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:29.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:29.181+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:29:164,1027.000000
06-07 17:27:29.191+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:29:176,-0.022433,-0.025116,0.035511
06-07 17:27:29.191+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:29:173,0.296609,-0.101667,9.801636
06-07 17:27:29.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:29.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:29.351+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:29.361+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:29.361+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:29.371+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:29.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:29.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:29:381,0.019244,0.025097,0.075935
06-07 17:27:29.381+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:29:357,1029.000000
06-07 17:27:29.381+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:29:369,0.070000,0.070000,0.070000
06-07 17:27:29.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:29:368,0.315853,-0.076570,9.877571
06-07 17:27:29.381+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:29:376,0.298976,-0.091920,9.801661
06-07 17:27:29.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:29.471+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:29.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:29.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:29.561+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:29.561+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:29.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:29.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:29:560,1032.000000
06-07 17:27:29.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:29:578,0.045591,0.056027,0.054376
06-07 17:27:29.581+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:29:563,0.070000,-0.070000,0.070000
06-07 17:27:29.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:29:566,0.344566,-0.035892,9.856036
06-07 17:27:29.581+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:29:572,0.309784,-0.072653,9.801487
06-07 17:27:29.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:29.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:29.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:29.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:29:757,1033.000000
06-07 17:27:29.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:29.761+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:29.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:29.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:29.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:29:766,0.070000,0.070000,0.070000
06-07 17:27:29.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:29:776,0.037175,-0.008703,0.071300
06-07 17:27:29.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:29:769,0.346959,-0.081356,9.872787
06-07 17:27:29.781+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:29:772,0.317865,-0.074196,9.801216
06-07 17:27:29.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:29.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:29.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:29.951+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:29:958,1034.000000
06-07 17:27:29.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:29.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:29.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:29.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:29:968,0.330210,-0.093320,9.858429
06-07 17:27:29.961+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:29:972,0.318467,-0.079190,9.801158
06-07 17:27:29.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:29.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:29:981,0.012344,-0.019124,0.057213
06-07 17:27:29.981+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:29:962,0.070000,0.070000,0.070000
06-07 17:27:30.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:30.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:30.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:30.151+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:30:158,1033.000000
06-07 17:27:30.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:30.151+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:30.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:30.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:30.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:30:170,-0.016972,-0.018916,0.018987
06-07 17:27:30.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:30:162,0.070000,0.070000,0.070000
06-07 17:27:30.181+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:30:167,0.309583,-0.084337,9.801399
06-07 17:27:30.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:30:166,0.301496,-0.098106,9.820145
06-07 17:27:30.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:30.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:30.351+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:30.361+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:30.361+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:30:369,0.070000,0.070000,0.070000
06-07 17:27:30.371+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:30:359,1034.000000
06-07 17:27:30.371+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:30.371+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:30.371+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:30.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:30:382,0.030198,0.002981,0.018745
06-07 17:27:30.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:30:385,0.339781,-0.081356,9.820145
06-07 17:27:30.401+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:30:385,0.315884,-0.082161,9.801217
06-07 17:27:30.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:30.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:30.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:30.551+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:30:560,1034.000000
06-07 17:27:30.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:30.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:30:565,0.070000,0.070000,0.070000
06-07 17:27:30.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:30.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:30:576,0.014326,-0.013552,0.042855
06-07 17:27:30.581+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:30.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:30.581+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:30:587,0.317276,-0.085332,9.801145
06-07 17:27:30.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:30:591,0.330210,-0.095713,9.844072
06-07 17:27:30.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:30.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:30.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:30.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:30:761,1035.000000
06-07 17:27:30.751+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:30.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:30:766,0.070000,0.070000,0.140000
06-07 17:27:30.761+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:30.761+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:30:770,0.017719,0.015941,0.009429
06-07 17:27:30.771+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:30.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:30.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:30:780,0.334995,-0.069392,9.810574
06-07 17:27:30.781+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:30:776,0.319303,-0.078870,9.801133
06-07 17:27:30.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:30.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:30.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:30.951+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:30.961+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:30:961,1037.000000
06-07 17:27:30.961+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:30.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:30.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:30.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:30:965,0.070000,0.070000,0.070000
06-07 17:27:30.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:30:971,0.315277,-0.079193,9.801261
06-07 17:27:30.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:30:974,0.318245,-0.083749,9.846465
06-07 17:27:30.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:30:969,-0.001058,-0.004878,0.045332
06-07 17:27:31.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:31.071+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:31.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:31.151+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:31:161,1037.000000
06-07 17:27:31.151+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:31.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:31.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:31.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:31.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:31:166,0.070000,0.070000,0.070000
06-07 17:27:31.181+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:31:170,0.312473,-0.088127,9.801274
06-07 17:27:31.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:31:176,0.315853,-0.110070,9.841680
06-07 17:27:31.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:31:174,0.000575,-0.030876,0.040419
06-07 17:27:31.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:31.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:31.371+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:31.411+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:31:382,1038.000000
06-07 17:27:31.411+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:31.411+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:31.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:31.421+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:31:419,0.070000,0.070000,0.070000
06-07 17:27:31.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:31.421+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:31:429,0.315853,-0.138784,9.927821
06-07 17:27:31.431+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:31:425,0.003379,-0.050657,0.126547
06-07 17:27:31.431+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:31:422,0.310332,-0.103090,9.801196
06-07 17:27:31.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:31.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:31.551+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:31.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:31.551+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:31:559,1039.000000
06-07 17:27:31.551+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:31.561+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:31:559,0.302816,-0.096869,9.801495
06-07 17:27:31.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:31.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:31.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:31:563,0.070000,0.070000,0.070000
06-07 17:27:31.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:31:578,-0.013622,0.014555,0.030912
06-07 17:27:31.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:31:584,0.296710,-0.088534,9.832108
06-07 17:27:31.671+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:31.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:31.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:31.761+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:31:764,1041.000000
06-07 17:27:31.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:31.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:31.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:31:771,0.298321,-0.095901,9.801642
06-07 17:27:31.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:31.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:31:776,-0.003713,-0.001236,0.049757
06-07 17:27:31.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:31:768,0.070000,0.070000,0.070000
06-07 17:27:31.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:31.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:31:782,0.299103,-0.098106,9.851252
06-07 17:27:31.871+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:31.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:31.961+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:31.961+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:31:966,1042.000000
06-07 17:27:31.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:31.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:31:969,0.070000,0.070000,0.070000
06-07 17:27:31.971+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:31.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:31.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:31:978,0.024710,-0.016562,0.080715
06-07 17:27:31.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:31.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:31:989,0.323031,-0.112463,9.882358
06-07 17:27:31.981+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:31:976,0.303114,-0.099856,9.801455
06-07 17:27:32.111+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:32.111+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:32.151+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:32.161+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:32.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:32:166,1042.000000
06-07 17:27:32.161+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:32:166,0.303312,-0.086696,9.801575
06-07 17:27:32.151+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:32.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:32.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:32:170,0.070000,0.070000,0.070000
06-07 17:27:32.161+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:32:170,0.012739,0.035250,0.080902
06-07 17:27:32.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:32.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:32:180,0.315853,-0.064606,9.882358
06-07 17:27:32.271+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:32.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:32.391+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:32.391+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:32:397,1042.000000
06-07 17:27:32.391+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:32.391+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:32:401,0.303541,-0.080406,9.801621
06-07 17:27:32.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:32.401+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:32.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:32.411+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:32:405,0.012540,0.014911,0.056854
06-07 17:27:32.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:32:410,0.315853,-0.071785,9.858429
06-07 17:27:32.421+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:32:411,0.070000,0.070000,0.070000
06-07 17:27:32.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:32.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:32.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:32.551+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:32:560,1045.000000
06-07 17:27:32.561+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:32.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:32.561+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:32:569,0.012311,-0.048806,0.073558
06-07 17:27:32.571+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:32:566,0.305070,-0.094949,9.801444
06-07 17:27:32.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:32.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:32.581+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:32:581,0.070000,0.070000,0.070000
06-07 17:27:32.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:32:584,0.315853,-0.129212,9.875179
06-07 17:27:32.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:32.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:32.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:32.761+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:32:764,1046.000000
06-07 17:27:32.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:32.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:32:768,0.300705,-0.094667,9.801581
06-07 17:27:32.761+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:32.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:32.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:32.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:32:779,0.301496,-0.098106,9.839286
06-07 17:27:32.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:32:774,-0.003574,-0.003156,0.037842
06-07 17:27:32.781+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:32:776,0.070000,0.070000,0.070000
06-07 17:27:32.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:32.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:32.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:32.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:32.961+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:32:965,1046.000000
06-07 17:27:32.961+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:32.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:32.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:32.981+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:32:971,0.314331,-0.101387,9.801086
06-07 17:27:32.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:32:975,0.051040,-0.024974,0.075990
06-07 17:27:32.991+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:32:982,0.070000,0.070000,0.070000
06-07 17:27:32.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:32:986,0.351745,-0.119641,9.877571
06-07 17:27:33.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:33.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:33.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:33.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:33:165,1049.000000
06-07 17:27:33.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:33.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:33.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:33.181+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:33:173,0.310849,-0.110627,9.801098
06-07 17:27:33.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:33.191+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:33:176,-0.000871,-0.032611,0.081271
06-07 17:27:33.191+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:33:193,0.313460,-0.133998,9.882358
06-07 17:27:33.191+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:33:178,0.070000,0.070000,0.070000
06-07 17:27:33.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:33.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:33.351+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:33.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:33.371+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:33:362,1050.000000
06-07 17:27:33.371+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:33:373,0.318156,-0.115281,9.800810
06-07 17:27:33.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:33.381+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:33.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:33.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:33:391,0.031324,-0.018586,0.059725
06-07 17:27:33.401+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:33:385,0.070000,0.070000,0.070000
06-07 17:27:33.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:33:397,0.342174,-0.129212,9.860823
06-07 17:27:33.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:33.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:33.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:33.561+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:33.571+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:33.581+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:33:563,1051.000000
06-07 17:27:33.581+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:33:570,0.312573,-0.108895,9.801063
06-07 17:27:33.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:33.581+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:33.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:33:592,0.311067,-0.100499,9.858429
06-07 17:27:33.591+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:33:585,0.070000,0.070000,0.140000
06-07 17:27:33.601+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:33:594,-0.007089,0.014783,0.057619
06-07 17:27:33.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:33.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:33.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:33.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:33:760,1051.000000
06-07 17:27:33.751+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:33.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:33:764,0.313178,-0.105431,9.801081
06-07 17:27:33.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:33.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:33:768,0.070000,0.070000,0.140000
06-07 17:27:33.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:33.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:33.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:33:780,0.012851,0.006004,0.076509
06-07 17:27:33.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:33:776,0.325424,-0.102891,9.877571
06-07 17:27:33.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:33.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:33.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:33.951+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:33:960,1052.000000
06-07 17:27:33.951+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:33.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:33.961+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:33:965,0.298252,-0.108303,9.801516
06-07 17:27:33.961+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:33.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:33.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:33:980,-0.035610,-0.011817,0.009493
06-07 17:27:33.981+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:33:970,0.070000,0.070000,0.140000
06-07 17:27:33.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:33:974,0.277567,-0.117248,9.810574
06-07 17:27:34.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:34.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:34.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:34.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:34.161+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:34:166,1053.000000
06-07 17:27:34.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:34.171+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:34:169,0.306448,-0.119141,9.801137
06-07 17:27:34.171+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:34:174,0.070000,0.070000,0.070000
06-07 17:27:34.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:34.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:34:181,0.330210,-0.145962,9.856036
06-07 17:27:34.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:34.191+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:34:186,0.031958,-0.037659,0.054521
06-07 17:27:34.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:34.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:34.351+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:34.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:34.371+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:34:369,1054.000000
06-07 17:27:34.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:34.381+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:34:374,0.320249,-0.114106,9.800756
06-07 17:27:34.381+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:34:379,0.070000,0.070000,0.140000
06-07 17:27:34.391+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:34.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:34.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:34:405,0.054869,0.011464,0.074042
06-07 17:27:34.411+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:34:396,0.361316,-0.107677,9.875179
06-07 17:27:34.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:34.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:34.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:34.561+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:34.561+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:34:563,1055.000000
06-07 17:27:34.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:34.571+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:34:566,0.308406,-0.109703,9.801186
06-07 17:27:34.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:34.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:34.581+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:34:575,0.070000,0.070000,0.070000
06-07 17:27:34.591+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:34:580,0.294317,-0.105284,9.863215
06-07 17:27:34.591+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:34:590,-0.025932,0.008822,0.062460
06-07 17:27:34.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:34.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:34.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:34.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:34:761,1057.000000
06-07 17:27:34.751+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:34.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:34.761+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:34:765,0.325748,-0.101779,9.800710
06-07 17:27:34.761+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:34.771+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:34.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:34:770,0.070000,0.070000,0.070000
06-07 17:27:34.781+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:34:775,0.375673,-0.088534,9.839286
06-07 17:27:34.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:34:780,0.067267,0.021168,0.038100
06-07 17:27:34.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:34.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:34.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:34.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:34.961+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:34:966,1059.000000
06-07 17:27:34.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:34:970,0.317467,-0.082019,9.801167
06-07 17:27:34.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:34.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:34:979,0.070000,0.070000,0.070000
06-07 17:27:34.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:34.981+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:34.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:34:993,-0.014682,0.053922,0.105577
06-07 17:27:34.991+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:34:985,0.311067,-0.047856,9.906286
06-07 17:27:35.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:35.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:35.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:35.151+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:161,1058.000000
06-07 17:27:35.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:35.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:35.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:35:170,0.070000,0.070000,-0.070000
06-07 17:27:35.171+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:35:166,0.321925,-0.081261,9.801027
06-07 17:27:35.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:35.171+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:35.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:35:182,0.024707,-0.001730,0.047691
06-07 17:27:35.181+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:35:177,0.342174,-0.083749,9.848858
06-07 17:27:35.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:35.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:35.361+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:35.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:35.371+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:368,1058.000000
06-07 17:27:35.371+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:35.371+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:35:370,0.320072,-0.090194,9.801010
06-07 17:27:35.381+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:35:379,0.070000,0.070000,-0.070000
06-07 17:27:35.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:35.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:35:391,0.325424,-0.112463,9.853643
06-07 17:27:35.391+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:35.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:35:401,0.003498,-0.031202,0.052616
06-07 17:27:35.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:35.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:35.551+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:35.551+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:35.561+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:35.571+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:562,1060.000000
06-07 17:27:35.571+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:35:565,0.320094,-0.092195,9.800991
06-07 17:27:35.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:35.571+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:35.571+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:35:579,0.330210,-0.100499,9.856036
06-07 17:27:35.581+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:35:590,0.010137,-0.010304,0.055026
06-07 17:27:35.581+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:35:572,0.070000,0.070000,-0.070000
06-07 17:27:35.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:35.681+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:35.751+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:35.751+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:761,1060.000000
06-07 17:27:35.761+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:35.761+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:35.771+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:35:775,0.070000,0.070000,0.070000
06-07 17:27:35.771+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:35:770,0.315896,-0.089603,9.801151
06-07 17:27:35.771+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:35.781+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:35.791+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:35:782,0.318245,-0.088534,9.856036
06-07 17:27:35.791+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:35:787,-0.001848,0.003661,0.055045
06-07 17:27:35.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:35.881+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:35.951+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:35.961+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:35.961+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:35.971+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:35:966,1061.000000
06-07 17:27:35.971+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:35:970,0.319350,-0.087176,9.801062
06-07 17:27:35.971+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:35:975,0.070000,0.070000,0.070000
06-07 17:27:35.971+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:35.971+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:35.981+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:35:986,0.337388,-0.086142,9.839286
06-07 17:27:35.991+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:35:991,0.021492,0.003462,0.038135
06-07 17:27:36.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:36.081+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:36.151+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:36.161+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:36.161+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:36.171+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:36:166,1061.000000
06-07 17:27:36.171+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:36:170,0.315885,-0.081472,9.801223
06-07 17:27:36.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:36.171+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:36:181,0.320638,-0.074178,9.863215
06-07 17:27:36.181+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:36:175,0.070000,0.070000,0.070000
06-07 17:27:36.181+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:36.191+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:36:194,0.001288,0.012998,0.062154
06-07 17:27:36.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:36.281+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:36.351+0200 I/light   (21998): es.ugr.frailty.light - capturing data
06-07 17:27:36.361+0200 I/gravity (21976): es.ugr.frailty.gravity - capturing data
06-07 17:27:36.371+0200 I/gravity (21976): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:27:36:373,0.314639,-0.084039,9.801241
06-07 17:27:36.381+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope - capturing data
06-07 17:27:36.381+0200 I/light   (21998): es.ugr.frailty.light: SM-R760,07/06/2018,17:27:36:373,1062.000000
06-07 17:27:36.381+0200 I/gyroscope(21968): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:27:36:386,0.070000,0.070000,0.070000
06-07 17:27:36.381+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer - capturing data
06-07 17:27:36.401+0200 I/accelerometer(21803): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:27:36:394,0.323031,-0.093320,9.860823
06-07 17:27:36.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration - capturing data
06-07 17:27:36.401+0200 I/linearacceleration(21825): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:27:36:409,0.007147,-0.011848,0.059600
06-07 17:27:36.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate - capturing data
06-07 17:27:36.481+0200 I/heartrate(21971): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:27:36.481+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): GlEngine::ChipData took 101 ms (from 9081153 to 9081254) (logOverhead=0,0,0,0,0,0,0), start: 17:27:36.388
06-07 17:27:36.481+0200 W/gpsd    ( 3111): CALL_SENTRY(main()): ProcessEvent took 101 ms (from 9081153 to 9081254) (logOverhead=0,0,0,0,0,0,0), start: 17:27:36.388
06-07 17:27:36.481+0200 W/gpsd    ( 3111): WakeLock(Release,GPSD)
06-07 17:27:36.521+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11213616c6f63152838513
